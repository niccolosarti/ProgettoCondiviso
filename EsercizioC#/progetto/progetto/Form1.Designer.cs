namespace progetto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.txtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(161, 451);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(159, 35);
            this.btnSalva.TabIndex = 0;
            this.btnSalva.Text = "Salva su file";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(393, 451);
            this.btnCarica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(172, 35);
            this.btnCarica.TabIndex = 1;
            this.btnCarica.Text = "Carica da file";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(668, 451);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(140, 151);
            this.list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(180, 147);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(668, 151);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(148, 26);
            this.txtB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnSalva);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.TextBox txtB;
    }
}

