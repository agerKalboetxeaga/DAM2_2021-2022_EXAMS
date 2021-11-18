namespace Ariketa2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtZenbaki1 = new System.Windows.Forms.TextBox();
            this.btnEgin = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zenbaki 1";
            // 
            // txtZenbaki1
            // 
            this.txtZenbaki1.Location = new System.Drawing.Point(368, 124);
            this.txtZenbaki1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZenbaki1.Name = "txtZenbaki1";
            this.txtZenbaki1.Size = new System.Drawing.Size(176, 22);
            this.txtZenbaki1.TabIndex = 5;
            this.txtZenbaki1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZenbaki1_KeyPress);
            // 
            // btnEgin
            // 
            this.btnEgin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgin.Location = new System.Drawing.Point(94, 221);
            this.btnEgin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEgin.Name = "btnEgin";
            this.btnEgin.Size = new System.Drawing.Size(148, 49);
            this.btnEgin.TabIndex = 10;
            this.btnEgin.Text = "Hurrengoa";
            this.btnEgin.UseVisualStyleBackColor = true;
            this.btnEgin.Click += new System.EventHandler(this.BtnEgin_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarbitu.Location = new System.Drawing.Point(294, 221);
            this.btnGarbitu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(148, 49);
            this.btnGarbitu.TabIndex = 11;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.BtnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrten.Location = new System.Drawing.Point(505, 221);
            this.btnIrten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(148, 49);
            this.btnIrten.TabIndex = 12;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.BtnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 554);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnEgin);
            this.Controls.Add(this.txtZenbaki1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZenbaki1;
        private System.Windows.Forms.Button btnEgin;
        private System.Windows.Forms.Button btnGarbitu;
        private System.Windows.Forms.Button btnIrten;
    }
}

