namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnStarta = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMeddelande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.lbxKlientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(132, 36);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(383, 26);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(417, 391);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(98, 34);
            this.btnStarta.TabIndex = 2;
            this.btnStarta.Text = "Starta";
            this.btnStarta.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(132, 82);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(383, 271);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMeddelande
            // 
            this.txtMeddelande.Location = new System.Drawing.Point(132, 359);
            this.txtMeddelande.Name = "txtMeddelande";
            this.txtMeddelande.Size = new System.Drawing.Size(383, 26);
            this.txtMeddelande.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meddelande:";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(291, 391);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(98, 34);
            this.btnSkicka.TabIndex = 6;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // lbxKlientIP
            // 
            this.lbxKlientIP.FormattingEnabled = true;
            this.lbxKlientIP.ItemHeight = 20;
            this.lbxKlientIP.Location = new System.Drawing.Point(557, 72);
            this.lbxKlientIP.Name = "lbxKlientIP";
            this.lbxKlientIP.Size = new System.Drawing.Size(240, 324);
            this.lbxKlientIP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Klient IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxKlientIP);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMeddelande);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStarta);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnStarta;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMeddelande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.ListBox lbxKlientIP;
        private System.Windows.Forms.Label label3;
    }
}

