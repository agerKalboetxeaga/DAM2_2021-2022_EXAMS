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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZenbaki1 = new System.Windows.Forms.TextBox();
            this.txtZenbaki2 = new System.Windows.Forms.TextBox();
            this.txtZenbaki3 = new System.Windows.Forms.TextBox();
            this.txtZenbaki4 = new System.Windows.Forms.TextBox();
            this.txtEmaitza = new System.Windows.Forms.TextBox();
            this.btnEgin = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zenbaki 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emaitza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zenbaki 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zenbaki 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zenbaki 2";
            // 
            // txtZenbaki1
            // 
            this.txtZenbaki1.Location = new System.Drawing.Point(215, 53);
            this.txtZenbaki1.Name = "txtZenbaki1";
            this.txtZenbaki1.Size = new System.Drawing.Size(133, 20);
            this.txtZenbaki1.TabIndex = 5;
            this.txtZenbaki1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZenbaki1_KeyPress);
            // 
            // txtZenbaki2
            // 
            this.txtZenbaki2.Location = new System.Drawing.Point(215, 95);
            this.txtZenbaki2.Name = "txtZenbaki2";
            this.txtZenbaki2.Size = new System.Drawing.Size(133, 20);
            this.txtZenbaki2.TabIndex = 6;
            this.txtZenbaki2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZenbaki2_KeyPress);
            // 
            // txtZenbaki3
            // 
            this.txtZenbaki3.Location = new System.Drawing.Point(215, 140);
            this.txtZenbaki3.Name = "txtZenbaki3";
            this.txtZenbaki3.Size = new System.Drawing.Size(133, 20);
            this.txtZenbaki3.TabIndex = 7;
            this.txtZenbaki3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZenbaki3_KeyPress);
            // 
            // txtZenbaki4
            // 
            this.txtZenbaki4.Location = new System.Drawing.Point(215, 188);
            this.txtZenbaki4.Name = "txtZenbaki4";
            this.txtZenbaki4.Size = new System.Drawing.Size(133, 20);
            this.txtZenbaki4.TabIndex = 8;
            this.txtZenbaki4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtZenbaki4_KeyPress);
            // 
            // txtEmaitza
            // 
            this.txtEmaitza.Enabled = false;
            this.txtEmaitza.Location = new System.Drawing.Point(215, 236);
            this.txtEmaitza.Name = "txtEmaitza";
            this.txtEmaitza.ReadOnly = true;
            this.txtEmaitza.Size = new System.Drawing.Size(133, 20);
            this.txtEmaitza.TabIndex = 9;
            // 
            // btnEgin
            // 
            this.btnEgin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgin.Location = new System.Drawing.Point(60, 321);
            this.btnEgin.Name = "btnEgin";
            this.btnEgin.Size = new System.Drawing.Size(111, 40);
            this.btnEgin.TabIndex = 10;
            this.btnEgin.Text = "Egin";
            this.btnEgin.UseVisualStyleBackColor = true;
            this.btnEgin.Click += new System.EventHandler(this.BtnEgin_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarbitu.Location = new System.Drawing.Point(201, 321);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(111, 40);
            this.btnGarbitu.TabIndex = 11;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.BtnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrten.Location = new System.Drawing.Point(333, 321);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(111, 40);
            this.btnIrten.TabIndex = 12;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.BtnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnEgin);
            this.Controls.Add(this.txtEmaitza);
            this.Controls.Add(this.txtZenbaki4);
            this.Controls.Add(this.txtZenbaki3);
            this.Controls.Add(this.txtZenbaki2);
            this.Controls.Add(this.txtZenbaki1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZenbaki1;
        private System.Windows.Forms.TextBox txtZenbaki2;
        private System.Windows.Forms.TextBox txtZenbaki3;
        private System.Windows.Forms.TextBox txtZenbaki4;
        private System.Windows.Forms.TextBox txtEmaitza;
        private System.Windows.Forms.Button btnEgin;
        private System.Windows.Forms.Button btnGarbitu;
        private System.Windows.Forms.Button btnIrten;
    }
}

