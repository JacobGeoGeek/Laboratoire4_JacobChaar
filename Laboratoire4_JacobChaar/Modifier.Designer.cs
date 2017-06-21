namespace Laboratoire4_JacobChaar
{
    partial class Modifier
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
            this.cboCodeclient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtSociete = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtTelContact = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCodeclient
            // 
            this.cboCodeclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeclient.FormattingEnabled = true;
            this.cboCodeclient.Location = new System.Drawing.Point(13, 13);
            this.cboCodeclient.Name = "cboCodeclient";
            this.cboCodeclient.Size = new System.Drawing.Size(313, 21);
            this.cboCodeclient.TabIndex = 0;
            this.cboCodeclient.SelectedValueChanged += new System.EventHandler(this.cboCodeclient_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Société:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ville:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Province:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code Postal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Téléphone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Contact:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fonction:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tél Contact:";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(117, 54);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(170, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtSociete
            // 
            this.txtSociete.Location = new System.Drawing.Point(117, 87);
            this.txtSociete.MaxLength = 40;
            this.txtSociete.Name = "txtSociete";
            this.txtSociete.Size = new System.Drawing.Size(170, 20);
            this.txtSociete.TabIndex = 2;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(117, 120);
            this.txtAdresse.MaxLength = 60;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(170, 20);
            this.txtAdresse.TabIndex = 2;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(117, 153);
            this.txtVille.MaxLength = 15;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(170, 20);
            this.txtVille.TabIndex = 2;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(117, 186);
            this.txtProvince.MaxLength = 15;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(170, 20);
            this.txtProvince.TabIndex = 2;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(117, 219);
            this.txtCodePostal.MaxLength = 10;
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(170, 20);
            this.txtCodePostal.TabIndex = 2;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(117, 252);
            this.txtTelephone.MaxLength = 24;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(170, 20);
            this.txtTelephone.TabIndex = 2;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(117, 285);
            this.txtFax.MaxLength = 24;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(170, 20);
            this.txtFax.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(117, 318);
            this.txtContact.MaxLength = 30;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(170, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(117, 351);
            this.txtFonction.MaxLength = 30;
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(170, 20);
            this.txtFonction.TabIndex = 2;
            // 
            // txtTelContact
            // 
            this.txtTelContact.Location = new System.Drawing.Point(117, 384);
            this.txtTelContact.MaxLength = 50;
            this.txtTelContact.Name = "txtTelContact";
            this.txtTelContact.Size = new System.Drawing.Size(170, 20);
            this.txtTelContact.TabIndex = 2;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(16, 422);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(271, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 486);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtTelContact);
            this.Controls.Add(this.txtFonction);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtSociete);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCodeclient);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Modifier_FormClosed);
            this.Load += new System.EventHandler(this.Modifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCodeclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtSociete;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtTelContact;
        private System.Windows.Forms.Button btnModifier;
    }
}