
namespace AgendaDLL
{
    partial class Kontrola
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abizenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new AgendaDLL.AgendaDataSet();
            this.kontaktuaTableAdapter = new AgendaDLL.AgendaDataSetTableAdapters.KontaktuaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nanDataGridViewTextBoxColumn,
            this.izenaDataGridViewTextBoxColumn,
            this.abizenaDataGridViewTextBoxColumn,
            this.emailaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontaktuaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // nanDataGridViewTextBoxColumn
            // 
            this.nanDataGridViewTextBoxColumn.DataPropertyName = "Nan";
            this.nanDataGridViewTextBoxColumn.HeaderText = "Nan";
            this.nanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nanDataGridViewTextBoxColumn.Name = "nanDataGridViewTextBoxColumn";
            this.nanDataGridViewTextBoxColumn.Width = 125;
            // 
            // izenaDataGridViewTextBoxColumn
            // 
            this.izenaDataGridViewTextBoxColumn.DataPropertyName = "Izena";
            this.izenaDataGridViewTextBoxColumn.HeaderText = "Izena";
            this.izenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.izenaDataGridViewTextBoxColumn.Name = "izenaDataGridViewTextBoxColumn";
            this.izenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // abizenaDataGridViewTextBoxColumn
            // 
            this.abizenaDataGridViewTextBoxColumn.DataPropertyName = "Abizena";
            this.abizenaDataGridViewTextBoxColumn.HeaderText = "Abizena";
            this.abizenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.abizenaDataGridViewTextBoxColumn.Name = "abizenaDataGridViewTextBoxColumn";
            this.abizenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailaDataGridViewTextBoxColumn
            // 
            this.emailaDataGridViewTextBoxColumn.DataPropertyName = "Emaila";
            this.emailaDataGridViewTextBoxColumn.HeaderText = "Emaila";
            this.emailaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailaDataGridViewTextBoxColumn.Name = "emailaDataGridViewTextBoxColumn";
            this.emailaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kontaktuaBindingSource
            // 
            this.kontaktuaBindingSource.DataMember = "Kontaktua";
            this.kontaktuaBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontaktuaTableAdapter
            // 
            this.kontaktuaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontaktuak";
            // 
            // Kontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kontrola";
            this.Size = new System.Drawing.Size(544, 150);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abizenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kontaktuaBindingSource;
        private AgendaDataSet agendaDataSet;
        private AgendaDataSetTableAdapters.KontaktuaTableAdapter kontaktuaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
