﻿namespace NewTelDesktopApp
{
    partial class HasieraPantailaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasieraPantailaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasahitza = new System.Windows.Forms.TextBox();
            this.buttonSubmitLogin = new System.Windows.Forms.Button();
            this.textBoxKorreoa = new System.Windows.Forms.TextBox();
            this.buttonIrten = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(263, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASI SAIOA";
            // 
            // textBoxPasahitza
            // 
            this.textBoxPasahitza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasahitza.Location = new System.Drawing.Point(258, 234);
            this.textBoxPasahitza.Name = "textBoxPasahitza";
            this.textBoxPasahitza.Size = new System.Drawing.Size(253, 26);
            this.textBoxPasahitza.TabIndex = 2;
            this.textBoxPasahitza.Text = "Pasahitza";
            this.textBoxPasahitza.Click += new System.EventHandler(this.textBoxPasahitza_Click);
            // 
            // buttonSubmitLogin
            // 
            this.buttonSubmitLogin.BackColor = System.Drawing.Color.Black;
            this.buttonSubmitLogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonSubmitLogin.FlatAppearance.BorderSize = 2;
            this.buttonSubmitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitLogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitLogin.ForeColor = System.Drawing.Color.White;
            this.buttonSubmitLogin.Location = new System.Drawing.Point(258, 318);
            this.buttonSubmitLogin.Name = "buttonSubmitLogin";
            this.buttonSubmitLogin.Size = new System.Drawing.Size(117, 39);
            this.buttonSubmitLogin.TabIndex = 3;
            this.buttonSubmitLogin.Text = "SARTU";
            this.buttonSubmitLogin.UseVisualStyleBackColor = false;
            this.buttonSubmitLogin.Click += new System.EventHandler(this.ButtonSubmitLogin_Click);
            // 
            // textBoxKorreoa
            // 
            this.textBoxKorreoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKorreoa.Location = new System.Drawing.Point(258, 188);
            this.textBoxKorreoa.Name = "textBoxKorreoa";
            this.textBoxKorreoa.Size = new System.Drawing.Size(253, 26);
            this.textBoxKorreoa.TabIndex = 4;
            this.textBoxKorreoa.Text = "Korreo elektronikoa";
            this.textBoxKorreoa.Click += new System.EventHandler(this.textBoxKorreoa_Click);
            // 
            // buttonIrten
            // 
            this.buttonIrten.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonIrten.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonIrten.FlatAppearance.BorderSize = 2;
            this.buttonIrten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIrten.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrten.ForeColor = System.Drawing.Color.White;
            this.buttonIrten.Location = new System.Drawing.Point(393, 318);
            this.buttonIrten.Name = "buttonIrten";
            this.buttonIrten.Size = new System.Drawing.Size(117, 39);
            this.buttonIrten.TabIndex = 5;
            this.buttonIrten.Text = "IRTEN";
            this.buttonIrten.UseVisualStyleBackColor = false;
            this.buttonIrten.Click += new System.EventHandler(this.ButtonIrten_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(316, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email edo pasahitza okerra!";
            // 
            // HasieraPantailaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIrten);
            this.Controls.Add(this.textBoxKorreoa);
            this.Controls.Add(this.buttonSubmitLogin);
            this.Controls.Add(this.textBoxPasahitza);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HasieraPantailaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasahitza;
        private System.Windows.Forms.Button buttonSubmitLogin;
        private System.Windows.Forms.TextBox textBoxKorreoa;
        private System.Windows.Forms.Button buttonIrten;
        private System.Windows.Forms.Label label2;
    }
}

