
namespace Kalkulagailua
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGehi = new System.Windows.Forms.Button();
            this.btnKen = new System.Windows.Forms.Button();
            this.btnZati = new System.Windows.Forms.Button();
            this.btnBider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(441, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnGehi
            // 
            this.btnGehi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGehi.Location = new System.Drawing.Point(191, 163);
            this.btnGehi.Name = "btnGehi";
            this.btnGehi.Size = new System.Drawing.Size(109, 78);
            this.btnGehi.TabIndex = 2;
            this.btnGehi.Text = "+";
            this.btnGehi.UseVisualStyleBackColor = false;
            this.btnGehi.Click += new System.EventHandler(this.btnGehi_Click);
            // 
            // btnKen
            // 
            this.btnKen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKen.Location = new System.Drawing.Point(395, 163);
            this.btnKen.Name = "btnKen";
            this.btnKen.Size = new System.Drawing.Size(109, 78);
            this.btnKen.TabIndex = 3;
            this.btnKen.Text = "-";
            this.btnKen.UseVisualStyleBackColor = false;
            this.btnKen.Click += new System.EventHandler(this.btnKen_Click);
            // 
            // btnZati
            // 
            this.btnZati.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnZati.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZati.Location = new System.Drawing.Point(395, 269);
            this.btnZati.Name = "btnZati";
            this.btnZati.Size = new System.Drawing.Size(109, 78);
            this.btnZati.TabIndex = 4;
            this.btnZati.Text = "/";
            this.btnZati.UseVisualStyleBackColor = false;
            this.btnZati.Click += new System.EventHandler(this.btnZati_Click);
            // 
            // btnBider
            // 
            this.btnBider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBider.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBider.Location = new System.Drawing.Point(191, 269);
            this.btnBider.Name = "btnBider";
            this.btnBider.Size = new System.Drawing.Size(109, 78);
            this.btnBider.TabIndex = 5;
            this.btnBider.Text = "*";
            this.btnBider.UseVisualStyleBackColor = false;
            this.btnBider.Click += new System.EventHandler(this.btnBider_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBider);
            this.Controls.Add(this.btnZati);
            this.Controls.Add(this.btnKen);
            this.Controls.Add(this.btnGehi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGehi;
        private System.Windows.Forms.Button btnKen;
        private System.Windows.Forms.Button btnZati;
        private System.Windows.Forms.Button btnBider;
    }
}

