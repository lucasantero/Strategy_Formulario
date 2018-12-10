namespace Strategy_Formulario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.LblIdade = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.CmbIdioma = new System.Windows.Forms.ComboBox();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtEndereco);
            this.panel1.Controls.Add(this.LblEndereco);
            this.panel1.Controls.Add(this.TxtTelefone);
            this.panel1.Controls.Add(this.LblTelefone);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.TxtIdade);
            this.panel1.Controls.Add(this.LblIdade);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(33, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 1;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(59, 113);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(100, 20);
            this.TxtEndereco.TabIndex = 19;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(4, 116);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(53, 13);
            this.LblEndereco.TabIndex = 18;
            this.LblEndereco.Text = "Endereço";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(59, 87);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefone.TabIndex = 17;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(4, 90);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(49, 13);
            this.LblTelefone.TabIndex = 16;
            this.LblTelefone.Text = "Telefone";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(59, 61);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 15;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(4, 64);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 14;
            this.LblEmail.Text = "Email";
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(59, 35);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(100, 20);
            this.TxtIdade.TabIndex = 13;
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Location = new System.Drawing.Point(4, 38);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(34, 13);
            this.LblIdade.TabIndex = 12;
            this.LblIdade.Text = "Idade";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(59, 9);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 11;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(4, 12);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome";
            // 
            // CmbIdioma
            // 
            this.CmbIdioma.FormattingEnabled = true;
            this.CmbIdioma.Location = new System.Drawing.Point(162, 18);
            this.CmbIdioma.Name = "CmbIdioma";
            this.CmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.CmbIdioma.TabIndex = 2;
            this.CmbIdioma.SelectedIndexChanged += new System.EventHandler(this.CmbIdioma_SelectedIndexChanged);
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Location = new System.Drawing.Point(97, 21);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(38, 13);
            this.LblIdioma.TabIndex = 20;
            this.LblIdioma.Text = "Idioma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 264);
            this.Controls.Add(this.LblIdioma);
            this.Controls.Add(this.CmbIdioma);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.ComboBox CmbIdioma;
        private System.Windows.Forms.Label LblIdioma;
    }
}

