/*******************************
           Projeto Sistema Automatizado de Estufas

     *Autores*:
         Gustavo Fernando Mastrocollo Gea
         Jacson Silveira Ribeiro

     *Revisões*:
        Versão 1: 20/03/2022
        Versão 2: 03/04/2022
        Versão 3: 19/04/2022
        Versão 4: 01/05/2022
        Versão 5: 08/05/2022
        Versão 6: 15/05/2022
        Versão 7: 24/05/2022
        Versão 8: 20/02/2023
        Versão 9: 21/03/2023
        Versão 10: 30/04/2023
        Versão 11: 20/05/2023
        Versão 12: 27/05/2023
        Versão 13: 03/06/2023

     *Descrição*:
        Esse projeto tem como objetivo a automação do controle de estufas a partir da medição de valores por sensores e
configurações pré-definidas pelo usuário.

     *Configurações*:
  MCU: Arduino Uno
  Dev.Board: desenvolvido pelos alunos
  Oscilador: Interno
  Software Compilador: Arduino IDE 2.0.4

      *Notas*:

*******************************/

#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
#include <SoftwareSerial.h>'
#include <TMP36.h>

TMP36 myTMP36(A2, 5.0); //DEFINE O PINO ANALÓGICO UTILIZADO PELO SENSOR E DEFINE A TENSÃO DE REFERÊNCIA (5V)
#define pin_lm393 A1 //Pino o qual o sensor higrômetro está conectado
#define pin_ldr A3 //Pino o qual o sensor de luminosidade está conectado

LiquidCrystal_I2C lcd(0x27,16,2); //Criando um LCD de 16x2 no endereço 0x27 (codigo do nosso i2c)

int umidadesolo; //variável que irá receber o valor da umidade do solo lida pelo sensor de umidade
int analogSoloSeco = 1000; //valor medido com o solo seco (podemos fazer o teste e ajustar a depender do solo)
int analogSoloMolhado = 150; //valor medido com o solo molhado (podemos fazer o teste e ajustar a depender do solo)
int percSoloSeco = 0; //menor percentual do solo seco (0%)
int percSoloMolhado = 100; //maior percentual do solo molhado (100%)

int luminosidade; //variável que irá receber o valor da luminosidade do sistema

float temperatura;

bool botaoPlanta_1=false;
bool botaoPlanta_2=false;
bool botaoPlanta_3=false; //botões que irão mudar a pré-definição

int tipodeplanta;

char cmd;

int Led = 11; // pino que está ligado o LED
int Ventoinha = 3; // pino que está ligado a ventoinha
int Motor = 10; // pino que está ligado a valvula solenoide

int dutyLUZ=0;

bool estado=false; //Flag para mudar estado da válvula

void inicializacao(){  //inicialização do LCD e com o setup pronto, só irá entrar os valores depois
  
lcd.setCursor(0,0);
  //       0123456789012345
lcd.print(" PROJETO ESTUFA ");
lcd.setCursor(0,1);
lcd.print("    FATEC-SP    ");
delay(2000);
lcd.clear();

lcd.setCursor(0,0);
lcd.print("    AUTORES    ");
lcd.setCursor(0,1);
lcd.print("GUSTAVO E JACSON");
delay(1000);
lcd.clear();

lcd.setCursor(0,0);
  //       0123456789012345
lcd.print("TIPO:  ");
lcd.setCursor(8,0);
lcd.print("UMI");
lcd.setCursor(15,0);
lcd.print("%");
lcd.setCursor(0,1);
lcd.print("TP:");
lcd.setCursor(6,1);
lcd.print("C");
lcd.setCursor(8,1);
lcd.print("LUZ");
}

void sensorTMP36(){ //bloco para funcionamento do sensor de temperatura
  float celsius = myTMP36.getTempC(); //VARIÁVEL LOCAL QUE ARMAZENA A TEMPERATURA EM GRAUS CELSIUS
  //OBTIDA ATRAVÉS DA FUNÇÃO myTMP36.getTempC()

    for (int i=0;i<1000;i++) { //Para evitar as grandes variações de leitura do componente são feitas 1000 leituras onde calculamos a média
        temperatura = temperatura + celsius;
    }
    temperatura = temperatura/1000; // calcula a média das leituras

  delay(1000);
}

void sensorLM393(){ //bloco para funcionamento do sensor de umidade do solo
   umidadesolo = constrain(analogRead(pin_lm393),analogSoloMolhado,analogSoloSeco); //MANTÉM umidadesolo DENTRO DO INTERVALO (ENTRE analogSoloMolhado E analogSoloSeco) 
   umidadesolo = map(umidadesolo,analogSoloMolhado,analogSoloSeco,percSoloMolhado,percSoloSeco); //EXECUTA A FUNÇÃO "map" DE ACORDO COM OS PARÂMETROS PASSADOS
   delay(1000);
}

void sensorLDR(){
  luminosidade=analogRead(pin_ldr); //Lê o valor do sensor ldr e armazena na variável luminosidade
  delay(1000);
}

void resultadosLCD(){

  lcd.setCursor(12,0);
  lcd.print("   ");
  lcd.setCursor(12,0);
  lcd.print(umidadesolo);
  
  
  lcd.setCursor(6,0);
  lcd.print(tipodeplanta);


  lcd.setCursor(4,1);
  lcd.print("  "); 
  lcd.setCursor(4,1); 
  lcd.print(temperatura,0);

  if(luminosidade<50)
  {
  lcd.setCursor(11,1);
  lcd.print("     ");
  lcd.setCursor(12,1);
  lcd.print("LOW");
  }
  if(luminosidade>51 && luminosidade<399)
  {
  lcd.setCursor(11,1);
  lcd.print("     ");
  lcd.setCursor(12,1);
  lcd.print("GOOD");
  }
  if(luminosidade>400)
  {
  lcd.setCursor(11,1);
  lcd.print("    ");
  lcd.setCursor(12,1);
  lcd.print("HIGH");
  }
}

void tipos_plantas(){

  Serial.available();
  cmd=Serial.read();
  
  if(cmd=='a'){   //configuração do comando para ativar modo de planta 1
  botaoPlanta_1=true;
  botaoPlanta_2=false;
  botaoPlanta_3=false;
  }

  if(cmd=='b'){   //configuração do comando para ativar modo de planta 2 
  botaoPlanta_2=true;
  botaoPlanta_1=false;
  botaoPlanta_3=false;
  }

  if(cmd=='c'){   //configuração do comando para ativar modo de planta 3
  botaoPlanta_3=true;
  botaoPlanta_1=false;
  botaoPlanta_2=false;
  }

  if(cmd=='x'){   //configuração do comando para ativar modo manual
  botaoPlanta_3=false;
  botaoPlanta_1=false;
  botaoPlanta_2=false;
  tipodeplanta=0;
  dutyLUZ=0;
  analogWrite(Led,dutyLUZ);
  }

  if(cmd=='z'){   //configuração do comando para ativar a rega
  digitalWrite(Motor, LOW); //Altera estado do pino para ativar a solenoide
  }

  if(cmd=='y'){   //configuração do comando para desativar a rega
  digitalWrite(Motor, HIGH); //Altera estado do pino para desativar a solenoide
  }

  if(cmd=='d'){   //configuração do comando para ativar o fan
  digitalWrite(Ventoinha, LOW); //Altera estado do pino para ativar o fan
  }

  if(cmd=='e'){   //configuração do comando para desativar o fan
  digitalWrite(Ventoinha, HIGH); //Altera estado do pino para desativar o fan
  }

  if(cmd=='f'){   //configuração do comando para aumentar a luz
  dutyLUZ=dutyLUZ+25;
  analogWrite(Led,dutyLUZ); //Altera estado do pino para aumentar a luz
  }

  if(cmd=='g'){   //configuração do comando para diminuir a luz
  dutyLUZ=dutyLUZ-25;
  analogWrite(Led,dutyLUZ); //Altera estado do pino para aumentar a luz
  }

}
  
void Planta1(){ //Planta 1 possui temperatura ideal por volta de até 25°C e luminosidade ajustável com a externa
  dutyLUZ=0;
    if(luminosidade<50)
  {
  dutyLUZ=255;
  analogWrite(Led,dutyLUZ);
  }
  if(luminosidade>51 && luminosidade<399)
  {
  dutyLUZ=100;
  analogWrite(Led,dutyLUZ);
  }
  if(luminosidade>400)
  {
  dutyLUZ=0;
  analogWrite(Led,dutyLUZ);
  }

   tipodeplanta=1;

   if(temperatura>25)
   {
    digitalWrite(Ventoinha, LOW);
   }
   else
   {
    digitalWrite(Ventoinha, HIGH);
   }

  if(umidadesolo<20) ///se umidade do solo abaixo de 20%, liga a valvula solenoide até estabilizar
  {
      digitalWrite(Motor, LOW); //Altera estado do pino
  }
  else
  {
      digitalWrite(Motor, HIGH); //Altera estado do pino
  }
}

void Planta2(){  //Planta 2 possui temperatura ideal por volta de até 30°C e luminosidade alta
   dutyLUZ=0;
   if(luminosidade<250)
  {
    dutyLUZ=255;
    analogWrite(Led,dutyLUZ);
  }
  else
  {
    dutyLUZ=0;
    analogWrite(Led,dutyLUZ);
  }


   tipodeplanta=2;

   if(temperatura>30)
   {
    digitalWrite(Ventoinha, LOW);
   }
   else
   {
    digitalWrite(Ventoinha, HIGH);
   }

  if(umidadesolo<40) ///se umidade do solo abaixo de 40%, liga a valvula solenoide até estabilizar
  {
      digitalWrite(Motor, LOW); //Altera estado do pino
  }
  else
  {
      digitalWrite(Motor, HIGH); //Altera estado do pino
  }
}

void Planta3(){ //Planta 3 possui temperatura ideal por volta de até 20°C e luminosidade apenas diaria
   dutyLUZ=0;
   analogWrite(Led,dutyLUZ);
  
   tipodeplanta=3;

   if(temperatura>20)
   {
    digitalWrite(Ventoinha, LOW);
   }
   else
   {
    digitalWrite(Ventoinha, HIGH);
   }

  if(umidadesolo<60) ///se umidade do solo abaixo de 60%, liga a valvula solenoide até estabilizar
  {
      digitalWrite(Motor, LOW); //Altera estado do pino
  }
  else
  {
      digitalWrite(Motor, HIGH); //Altera estado do pino
  }
   
}

void modos_pin(){ //void para configurar os modos dos pinos
  pinMode(pin_ldr, INPUT); // Define o sensor como uma entrada de sinal
  pinMode(pin_lm393, INPUT); // Define o sensor como uma entrada de sinal
  pinMode(Led, OUTPUT); // Define o LED como uma saída de sinal
  pinMode(Ventoinha, OUTPUT); // Define a VETOINHA como uma saída de sinal
  pinMode(Motor, OUTPUT); // Define o MOTOR como uma saída de sinal
}
  
void setup() {

Serial.begin(9600); // Inicia a comunicação

lcd.init();                 // Inicializando o LCD
lcd.backlight();            // Ligando o BackLight do LCD

modos_pin();

inicializacao(); //void para o setup do LCD

}

void loop() {

  sensorTMP36();
  sensorLM393();
  sensorLDR();
  resultadosLCD();
  tipos_plantas();

  if (botaoPlanta_1==true){
    Planta1();
  }

  if (botaoPlanta_2==true){
    Planta2();
  }

  if (botaoPlanta_3==true){
    Planta3();
  }

}
