namespace NorthWind.Win
{
    partial class FrmCategorias
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbocategorias = new System.Windows.Forms.ComboBox();
            this.txtbusqcat = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.codCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCategoriaBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnagregar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Búsqueda :";
            // 
            // cbocategorias
            // 
            this.cbocategorias.FormattingEnabled = true;
            this.cbocategorias.Location = new System.Drawing.Point(152, 59);
            this.cbocategorias.Name = "cbocategorias";
            this.cbocategorias.Size = new System.Drawing.Size(138, 21);
            this.cbocategorias.TabIndex = 6;
            // 
            // txtbusqcat
            // 
            this.txtbusqcat.Location = new System.Drawing.Point(152, 29);
            this.txtbusqcat.Name = "txtbusqcat";
            this.txtbusqcat.Size = new System.Drawing.Size(207, 20);
            this.txtbusqcat.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 274);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvcategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.AllowUserToAddRows = false;
            this.dgvcategoria.AutoGenerateColumns = false;
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCategoriaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgvcategoria.DataSource = this.tbCategoriaBEBindingSource;
            this.dgvcategoria.Location = new System.Drawing.Point(7, 7);
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.Size = new System.Drawing.Size(367, 235);
            this.dgvcategoria.TabIndex = 0;
            // 
            // codCategoriaDataGridViewTextBoxColumn
            // 
            this.codCategoriaDataGridViewTextBoxColumn.DataPropertyName = "codCategoria";
            this.codCategoriaDataGridViewTextBoxColumn.HeaderText = "codCategoria";
            this.codCategoriaDataGridViewTextBoxColumn.Name = "codCategoriaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // tbCategoriaBEBindingSource
            // 
            this.tbCategoriaBEBindingSource.DataSource = typeof(NorthWind.Entity.TbCategoriaBE);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(342, 384);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(NorthWind.Entity.TbCategoriaBE);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 437);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbocategorias);
            this.Controls.Add(this.txtbusqcat);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Categorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbocategorias;
        private System.Windows.Forms.TextBox txtbusqcat;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbCategoriaBEBindingSource;
    }
}