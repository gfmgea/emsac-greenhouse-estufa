namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btPlant1 = new System.Windows.Forms.Button();
            this.btPlant3 = new System.Windows.Forms.Button();
            this.btPlant2 = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.lbStatusConect = new System.Windows.Forms.Label();
            this.lbPlant = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manual = new System.Windows.Forms.Button();
            this.botaoRegaON = new System.Windows.Forms.Button();
            this.botaoRegaOFF = new System.Windows.Forms.Button();
            this.botaoVentoON = new System.Windows.Forms.Button();
            this.botaoVentoOFF = new System.Windows.Forms.Button();
            this.trackBarPWM = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlant1
            // 
            this.btPlant1.BackColor = System.Drawing.Color.Silver;
            this.btPlant1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPlant1.BackgroundImage")));
            this.btPlant1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPlant1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btPlant1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlant1.Location = new System.Drawing.Point(957, 414);
            this.btPlant1.Name = "btPlant1";
            this.btPlant1.Size = new System.Drawing.Size(92, 88);
            this.btPlant1.TabIndex = 2;
            this.btPlant1.UseVisualStyleBackColor = false;
            this.btPlant1.Click += new System.EventHandler(this.btPlant1_Click);
            // 
            // btPlant3
            // 
            this.btPlant3.BackColor = System.Drawing.Color.Silver;
            this.btPlant3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPlant3.BackgroundImage")));
            this.btPlant3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPlant3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btPlant3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlant3.Location = new System.Drawing.Point(1180, 414);
            this.btPlant3.Name = "btPlant3";
            this.btPlant3.Size = new System.Drawing.Size(93, 88);
            this.btPlant3.TabIndex = 3;
            this.btPlant3.UseVisualStyleBackColor = false;
            this.btPlant3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPlant2
            // 
            this.btPlant2.BackColor = System.Drawing.Color.Silver;
            this.btPlant2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPlant2.BackgroundImage")));
            this.btPlant2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPlant2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btPlant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlant2.Location = new System.Drawing.Point(1068, 414);
            this.btPlant2.Name = "btPlant2";
            this.btPlant2.Size = new System.Drawing.Size(94, 88);
            this.btPlant2.TabIndex = 4;
            this.btPlant2.UseVisualStyleBackColor = false;
            this.btPlant2.Click += new System.EventHandler(this.btPlant2_Click);
            // 
            // btConectar
            // 
            this.btConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btConectar.Location = new System.Drawing.Point(286, 635);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(139, 72);
            this.btConectar.TabIndex = 5;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // btDesconectar
            // 
            this.btDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btDesconectar.Location = new System.Drawing.Point(507, 635);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(139, 72);
            this.btDesconectar.TabIndex = 6;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btDesconectar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(134, 767);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(220, 44);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair da Aplicação";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(403, 452);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(220, 21);
            this.cbBoxPort.TabIndex = 8;
            this.cbBoxPort.SelectedIndexChanged += new System.EventHandler(this.cbBoxPort_SelectedIndexChanged);
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(403, 561);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(220, 21);
            this.cbBoxBaud.TabIndex = 9;
            this.cbBoxBaud.SelectedIndexChanged += new System.EventHandler(this.cbBoxBaud_SelectedIndexChanged);
            // 
            // lbStatusConect
            // 
            this.lbStatusConect.AutoSize = true;
            this.lbStatusConect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.lbStatusConect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbStatusConect.Location = new System.Drawing.Point(364, 774);
            this.lbStatusConect.Name = "lbStatusConect";
            this.lbStatusConect.Size = new System.Drawing.Size(223, 25);
            this.lbStatusConect.TabIndex = 12;
            this.lbStatusConect.Text = "Aguardando Conexão";
            this.lbStatusConect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStatusConect.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbPlant
            // 
            this.lbPlant.AutoSize = true;
            this.lbPlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(123)))), ((int)(((byte)(91)))));
            this.lbPlant.Font = new System.Drawing.Font("Arial Narrow", 32F, System.Drawing.FontStyle.Bold);
            this.lbPlant.Location = new System.Drawing.Point(1059, 675);
            this.lbPlant.Name = "lbPlant";
            this.lbPlant.Size = new System.Drawing.Size(42, 52);
            this.lbPlant.TabIndex = 13;
            this.lbPlant.Text = "0";
            this.lbPlant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.labelUsers.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.labelUsers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelUsers.Location = new System.Drawing.Point(1337, 740);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(202, 31);
            this.labelUsers.TabIndex = 14;
            this.labelUsers.Text = "Gustavo e Jacson";
            this.labelUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelUsers.Click += new System.EventHandler(this.labelUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(1337, 708);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desenvolvido por";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // manual
            // 
            this.manual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.manual.Location = new System.Drawing.Point(1550, 303);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(93, 88);
            this.manual.TabIndex = 16;
            this.manual.Text = "Modo Manual";
            this.manual.UseVisualStyleBackColor = false;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // botaoRegaON
            // 
            this.botaoRegaON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.botaoRegaON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRegaON.BackgroundImage")));
            this.botaoRegaON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.botaoRegaON.Location = new System.Drawing.Point(1491, 414);
            this.botaoRegaON.Name = "botaoRegaON";
            this.botaoRegaON.Size = new System.Drawing.Size(94, 89);
            this.botaoRegaON.TabIndex = 17;
            this.botaoRegaON.UseVisualStyleBackColor = false;
            this.botaoRegaON.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // botaoRegaOFF
            // 
            this.botaoRegaOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.botaoRegaOFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRegaOFF.BackgroundImage")));
            this.botaoRegaOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.botaoRegaOFF.Location = new System.Drawing.Point(1612, 414);
            this.botaoRegaOFF.Name = "botaoRegaOFF";
            this.botaoRegaOFF.Size = new System.Drawing.Size(94, 89);
            this.botaoRegaOFF.TabIndex = 19;
            this.botaoRegaOFF.UseVisualStyleBackColor = false;
            this.botaoRegaOFF.Click += new System.EventHandler(this.botaoRegaOFF_Click);
            // 
            // botaoVentoON
            // 
            this.botaoVentoON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.botaoVentoON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoVentoON.BackgroundImage")));
            this.botaoVentoON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.botaoVentoON.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoVentoON.Location = new System.Drawing.Point(1491, 523);
            this.botaoVentoON.Name = "botaoVentoON";
            this.botaoVentoON.Size = new System.Drawing.Size(94, 89);
            this.botaoVentoON.TabIndex = 20;
            this.botaoVentoON.UseVisualStyleBackColor = false;
            this.botaoVentoON.Click += new System.EventHandler(this.botaoVentoON_Click);
            // 
            // botaoVentoOFF
            // 
            this.botaoVentoOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))));
            this.botaoVentoOFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoVentoOFF.BackgroundImage")));
            this.botaoVentoOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.botaoVentoOFF.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoVentoOFF.Location = new System.Drawing.Point(1612, 523);
            this.botaoVentoOFF.Name = "botaoVentoOFF";
            this.botaoVentoOFF.Size = new System.Drawing.Size(94, 89);
            this.botaoVentoOFF.TabIndex = 21;
            this.botaoVentoOFF.UseVisualStyleBackColor = false;
            this.botaoVentoOFF.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // trackBarPWM
            // 
            this.trackBarPWM.BackColor = System.Drawing.Color.LightGray;
            this.trackBarPWM.Location = new System.Drawing.Point(1491, 635);
            this.trackBarPWM.Name = "trackBarPWM";
            this.trackBarPWM.Size = new System.Drawing.Size(215, 45);
            this.trackBarPWM.TabIndex = 23;
            this.trackBarPWM.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Tipo_Selecionado1;
            this.ClientSize = new System.Drawing.Size(1870, 884);
            this.Controls.Add(this.trackBarPWM);
            this.Controls.Add(this.botaoVentoOFF);
            this.Controls.Add(this.botaoVentoON);
            this.Controls.Add(this.botaoRegaOFF);
            this.Controls.Add(this.botaoRegaON);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.lbPlant);
            this.Controls.Add(this.lbStatusConect);
            this.Controls.Add(this.cbBoxBaud);
            this.Controls.Add(this.cbBoxPort);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btDesconectar);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btPlant2);
            this.Controls.Add(this.btPlant3);
            this.Controls.Add(this.btPlant1);
            this.Name = "Form1";
            this.Text = "GUI-Projeto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPlant1;
        private System.Windows.Forms.Button btPlant3;
        private System.Windows.Forms.Button btPlant2;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.ComboBox cbBoxBaud;
        private System.Windows.Forms.Label lbStatusConect;
        private System.Windows.Forms.Label lbPlant;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.Button botaoRegaON;
        private System.Windows.Forms.Button botaoRegaOFF;
        private System.Windows.Forms.Button botaoVentoON;
        private System.Windows.Forms.Button botaoVentoOFF;
        private System.Windows.Forms.TrackBar trackBarPWM;
    }
}

