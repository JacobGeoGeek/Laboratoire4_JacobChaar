namespace Laboratoire4_JacobChaar
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodeClient = new System.Windows.Forms.TextBox();
            this.txtSocieteClient = new System.Windows.Forms.TextBox();
            this.txtContactClient = new System.Windows.Forms.TextBox();
            this.txtTelContactClient = new System.Windows.Forms.TextBox();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(839, 608);
            this.dataGridView1.TabIndex = 0;
            // 
            // CodeClient
            // 
            this.CodeClient.AutoSize = true;
            this.CodeClient.Location = new System.Drawing.Point(12, 27);
            this.CodeClient.Name = "CodeClient";
            this.CodeClient.Size = new System.Drawing.Size(64, 13);
            this.CodeClient.TabIndex = 1;
            this.CodeClient.Text = "Code Client:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Société Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TelContactClient:";
            // 
            // txtCodeClient
            // 
            this.txtCodeClient.Location = new System.Drawing.Point(105, 27);
            this.txtCodeClient.Name = "txtCodeClient";
            this.txtCodeClient.Size = new System.Drawing.Size(100, 20);
            this.txtCodeClient.TabIndex = 0;
            // 
            // txtSocieteClient
            // 
            this.txtSocieteClient.Location = new System.Drawing.Point(105, 56);
            this.txtSocieteClient.Name = "txtSocieteClient";
            this.txtSocieteClient.Size = new System.Drawing.Size(100, 20);
            this.txtSocieteClient.TabIndex = 1;
            // 
            // txtContactClient
            // 
            this.txtContactClient.Location = new System.Drawing.Point(105, 92);
            this.txtContactClient.Name = "txtContactClient";
            this.txtContactClient.Size = new System.Drawing.Size(100, 20);
            this.txtContactClient.TabIndex = 2;
            // 
            // txtTelContactClient
            // 
            this.txtTelContactClient.Location = new System.Drawing.Point(105, 128);
            this.txtTelContactClient.Name = "txtTelContactClient";
            this.txtTelContactClient.Size = new System.Drawing.Size(100, 20);
            this.txtTelContactClient.TabIndex = 3;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(15, 174);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 4;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(116, 174);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(56, 257);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifer";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(56, 337);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(56, 423);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 633);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.txtTelContactClient);
            this.Controls.Add(this.txtContactClient);
            this.Controls.Add(this.txtSocieteClient);
            this.Controls.Add(this.txtCodeClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CodeClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeClient;
        private System.Windows.Forms.TextBox txtSocieteClient;
        private System.Windows.Forms.TextBox txtContactClient;
        private System.Windows.Forms.TextBox txtTelContactClient;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}

