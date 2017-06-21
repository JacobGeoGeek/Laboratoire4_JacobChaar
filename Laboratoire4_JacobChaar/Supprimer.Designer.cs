namespace Laboratoire4_JacobChaar
{
    partial class Supprimer
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
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.btnSupprminer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCode
            // 
            this.cboCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCode.FormattingEnabled = true;
            this.cboCode.Location = new System.Drawing.Point(44, 64);
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(184, 21);
            this.cboCode.TabIndex = 0;
            // 
            // btnSupprminer
            // 
            this.btnSupprminer.Location = new System.Drawing.Point(44, 116);
            this.btnSupprminer.Name = "btnSupprminer";
            this.btnSupprminer.Size = new System.Drawing.Size(184, 23);
            this.btnSupprminer.TabIndex = 1;
            this.btnSupprminer.Text = "Supprimer";
            this.btnSupprminer.UseVisualStyleBackColor = true;
            this.btnSupprminer.Click += new System.EventHandler(this.btnSupprminer_Click);
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.btnSupprminer);
            this.Controls.Add(this.cboCode);
            this.Name = "Supprimer";
            this.Text = "Supprimer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Supprimer_FormClosed);
            this.Load += new System.EventHandler(this.Supprimer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCode;
        private System.Windows.Forms.Button btnSupprminer;
    }
}