
namespace KaixoMundua
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
            this.btnAgurra = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgurra
            // 
            this.btnAgurra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgurra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgurra.ForeColor = System.Drawing.Color.Coral;
            this.btnAgurra.Location = new System.Drawing.Point(202, 139);
            this.btnAgurra.Name = "btnAgurra";
            this.btnAgurra.Size = new System.Drawing.Size(203, 79);
            this.btnAgurra.TabIndex = 0;
            this.btnAgurra.Text = "Agurra";
            this.btnAgurra.UseVisualStyleBackColor = false;
            this.btnAgurra.Click += new System.EventHandler(this.btnAgurra_Click);
            // 
            // btnItxi
            // 
            this.btnItxi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnItxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItxi.ForeColor = System.Drawing.Color.Coral;
            this.btnItxi.Location = new System.Drawing.Point(442, 139);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(203, 79);
            this.btnItxi.TabIndex = 1;
            this.btnItxi.Text = "Itxi";
            this.btnItxi.UseVisualStyleBackColor = false;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnAgurra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgurra;
        private System.Windows.Forms.Button btnItxi;
    }
}

