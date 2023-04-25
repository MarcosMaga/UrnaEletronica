
namespace UrnaEletronica
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btZero = new System.Windows.Forms.Button();
            this.btNove = new System.Windows.Forms.Button();
            this.btOito = new System.Windows.Forms.Button();
            this.btSete = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btQuatro = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btDois = new System.Windows.Forms.Button();
            this.btUm = new System.Windows.Forms.Button();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btCorrige = new System.Windows.Forms.Button();
            this.btBranco = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPartido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lbFim = new System.Windows.Forms.Label();
            this.btVotarAgain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btZero);
            this.panel1.Controls.Add(this.btNove);
            this.panel1.Controls.Add(this.btOito);
            this.panel1.Controls.Add(this.btSete);
            this.panel1.Controls.Add(this.btSeis);
            this.panel1.Controls.Add(this.btCinco);
            this.panel1.Controls.Add(this.btQuatro);
            this.panel1.Controls.Add(this.btTres);
            this.panel1.Controls.Add(this.btDois);
            this.panel1.Controls.Add(this.btUm);
            this.panel1.Controls.Add(this.btConfirma);
            this.panel1.Controls.Add(this.btCorrige);
            this.panel1.Controls.Add(this.btBranco);
            this.panel1.Location = new System.Drawing.Point(485, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 375);
            this.panel1.TabIndex = 1;
            // 
            // btZero
            // 
            this.btZero.BackColor = System.Drawing.Color.Black;
            this.btZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZero.ForeColor = System.Drawing.Color.White;
            this.btZero.Location = new System.Drawing.Point(116, 241);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(52, 43);
            this.btZero.TabIndex = 12;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = false;
            this.btZero.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btNove
            // 
            this.btNove.BackColor = System.Drawing.Color.Black;
            this.btNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNove.ForeColor = System.Drawing.Color.White;
            this.btNove.Location = new System.Drawing.Point(208, 174);
            this.btNove.Name = "btNove";
            this.btNove.Size = new System.Drawing.Size(52, 43);
            this.btNove.TabIndex = 11;
            this.btNove.Text = "9";
            this.btNove.UseVisualStyleBackColor = false;
            this.btNove.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btOito
            // 
            this.btOito.BackColor = System.Drawing.Color.Black;
            this.btOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOito.ForeColor = System.Drawing.Color.White;
            this.btOito.Location = new System.Drawing.Point(116, 174);
            this.btOito.Name = "btOito";
            this.btOito.Size = new System.Drawing.Size(52, 43);
            this.btOito.TabIndex = 10;
            this.btOito.Text = "8";
            this.btOito.UseVisualStyleBackColor = false;
            this.btOito.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btSete
            // 
            this.btSete.BackColor = System.Drawing.Color.Black;
            this.btSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSete.ForeColor = System.Drawing.Color.White;
            this.btSete.Location = new System.Drawing.Point(31, 174);
            this.btSete.Name = "btSete";
            this.btSete.Size = new System.Drawing.Size(52, 43);
            this.btSete.TabIndex = 9;
            this.btSete.Text = "7";
            this.btSete.UseVisualStyleBackColor = false;
            this.btSete.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btSeis
            // 
            this.btSeis.BackColor = System.Drawing.Color.Black;
            this.btSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeis.ForeColor = System.Drawing.Color.White;
            this.btSeis.Location = new System.Drawing.Point(208, 105);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(52, 43);
            this.btSeis.TabIndex = 8;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = false;
            this.btSeis.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btCinco
            // 
            this.btCinco.BackColor = System.Drawing.Color.Black;
            this.btCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCinco.ForeColor = System.Drawing.Color.White;
            this.btCinco.Location = new System.Drawing.Point(116, 105);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(52, 43);
            this.btCinco.TabIndex = 7;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = false;
            this.btCinco.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btQuatro
            // 
            this.btQuatro.BackColor = System.Drawing.Color.Black;
            this.btQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuatro.ForeColor = System.Drawing.Color.White;
            this.btQuatro.Location = new System.Drawing.Point(31, 105);
            this.btQuatro.Name = "btQuatro";
            this.btQuatro.Size = new System.Drawing.Size(52, 43);
            this.btQuatro.TabIndex = 6;
            this.btQuatro.Text = "4";
            this.btQuatro.UseVisualStyleBackColor = false;
            this.btQuatro.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btTres
            // 
            this.btTres.BackColor = System.Drawing.Color.Black;
            this.btTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTres.ForeColor = System.Drawing.Color.White;
            this.btTres.Location = new System.Drawing.Point(208, 39);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(52, 43);
            this.btTres.TabIndex = 5;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = false;
            this.btTres.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btDois
            // 
            this.btDois.BackColor = System.Drawing.Color.Black;
            this.btDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDois.ForeColor = System.Drawing.Color.White;
            this.btDois.Location = new System.Drawing.Point(116, 39);
            this.btDois.Name = "btDois";
            this.btDois.Size = new System.Drawing.Size(52, 43);
            this.btDois.TabIndex = 4;
            this.btDois.Text = "2";
            this.btDois.UseVisualStyleBackColor = false;
            this.btDois.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btUm
            // 
            this.btUm.BackColor = System.Drawing.Color.Black;
            this.btUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUm.ForeColor = System.Drawing.Color.White;
            this.btUm.Location = new System.Drawing.Point(31, 39);
            this.btUm.Name = "btUm";
            this.btUm.Size = new System.Drawing.Size(52, 43);
            this.btUm.TabIndex = 3;
            this.btUm.Text = "1";
            this.btUm.UseVisualStyleBackColor = false;
            this.btUm.Click += new System.EventHandler(this.ClicaTeclado);
            // 
            // btConfirma
            // 
            this.btConfirma.BackColor = System.Drawing.Color.Green;
            this.btConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btConfirma.Location = new System.Drawing.Point(208, 318);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(81, 47);
            this.btConfirma.TabIndex = 2;
            this.btConfirma.Text = "CONFIRMA";
            this.btConfirma.UseVisualStyleBackColor = false;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // btCorrige
            // 
            this.btCorrige.BackColor = System.Drawing.Color.Red;
            this.btCorrige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCorrige.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCorrige.Location = new System.Drawing.Point(116, 328);
            this.btCorrige.Name = "btCorrige";
            this.btCorrige.Size = new System.Drawing.Size(81, 36);
            this.btCorrige.TabIndex = 1;
            this.btCorrige.Text = "CORRIGE";
            this.btCorrige.UseVisualStyleBackColor = false;
            this.btCorrige.Click += new System.EventHandler(this.btCorrige_Click);
            // 
            // btBranco
            // 
            this.btBranco.BackColor = System.Drawing.Color.White;
            this.btBranco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBranco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBranco.Location = new System.Drawing.Point(20, 328);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(81, 36);
            this.btBranco.TabIndex = 0;
            this.btBranco.Text = "BRANCO";
            this.btBranco.UseVisualStyleBackColor = false;
            this.btBranco.Click += new System.EventHandler(this.btBranco_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbFim);
            this.panel2.Controls.Add(this.pbFoto);
            this.panel2.Controls.Add(this.lb5);
            this.panel2.Controls.Add(this.lb4);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Controls.Add(this.lb2);
            this.panel2.Controls.Add(this.lb1);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbPartido);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbNome);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbEstado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 375);
            this.panel2.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(77, 170);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(23, 24);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "0";
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(10, 316);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(450, 47);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Status da votação";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-2, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 10);
            this.panel3.TabIndex = 7;
            // 
            // lbPartido
            // 
            this.lbPartido.AutoSize = true;
            this.lbPartido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartido.Location = new System.Drawing.Point(77, 255);
            this.lbPartido.Name = "lbPartido";
            this.lbPartido.Size = new System.Drawing.Size(12, 16);
            this.lbPartido.TabIndex = 6;
            this.lbPartido.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Partido:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(77, 215);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(12, 16);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(159, 59);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(82, 19);
            this.lbEstado.TabIndex = 1;
            this.lbEstado.Text = "Tipo Voto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEU VOTO PARA";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(103, 170);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(23, 24);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "0";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(155, 170);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(23, 24);
            this.lb4.TabIndex = 12;
            this.lb4.Text = "0";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(129, 170);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(23, 24);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "0";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(182, 170);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(23, 24);
            this.lb5.TabIndex = 13;
            this.lb5.Text = "0";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(323, 8);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(137, 181);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 14;
            this.pbFoto.TabStop = false;
            // 
            // lbFim
            // 
            this.lbFim.AutoSize = true;
            this.lbFim.Font = new System.Drawing.Font("Arial", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFim.Location = new System.Drawing.Point(131, 103);
            this.lbFim.Name = "lbFim";
            this.lbFim.Size = new System.Drawing.Size(265, 139);
            this.lbFim.TabIndex = 15;
            this.lbFim.Text = "FIM";
            this.lbFim.Visible = false;
            // 
            // btVotarAgain
            // 
            this.btVotarAgain.Location = new System.Drawing.Point(94, 12);
            this.btVotarAgain.Name = "btVotarAgain";
            this.btVotarAgain.Size = new System.Drawing.Size(109, 23);
            this.btVotarAgain.TabIndex = 3;
            this.btVotarAgain.Text = "Votar Novamente";
            this.btVotarAgain.UseVisualStyleBackColor = true;
            this.btVotarAgain.Visible = false;
            this.btVotarAgain.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVotarAgain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCorrige;
        private System.Windows.Forms.Button btBranco;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btNove;
        private System.Windows.Forms.Button btOito;
        private System.Windows.Forms.Button btSete;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btQuatro;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btDois;
        private System.Windows.Forms.Button btUm;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPartido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbFim;
        private System.Windows.Forms.Button btVotarAgain;
    }
}

