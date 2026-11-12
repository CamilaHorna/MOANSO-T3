namespace SistemaGimnasio
{
    partial class frmCategoriaZona
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnDesactivarCat = new System.Windows.Forms.Button();
            this.btnModificarCat = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.lblDescripcionCat = new System.Windows.Forms.Label();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.txtCodigoCat = new System.Windows.Forms.TextBox();
            this.lblCodigoCat = new System.Windows.Forms.Label();
            this.lblTituloCat = new System.Windows.Forms.Label();
            this.tabZonas = new System.Windows.Forms.TabPage();
            this.dgvZonas = new System.Windows.Forms.DataGridView();
            this.btnDesactivarZona = new System.Windows.Forms.Button();
            this.btnModificarZona = new System.Windows.Forms.Button();
            this.btnAgregarZona = new System.Windows.Forms.Button();
            this.txtDescripcionZona = new System.Windows.Forms.TextBox();
            this.txtNombreZona = new System.Windows.Forms.TextBox();
            this.txtCodigoZona = new System.Windows.Forms.TextBox();
            this.lblDescripcionZona = new System.Windows.Forms.Label();
            this.lblNombreZona = new System.Windows.Forms.Label();
            this.lblCodigoZona = new System.Windows.Forms.Label();
            this.lblTituloZona = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tabZonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCategorias);
            this.tabControl1.Controls.Add(this.tabZonas);
            this.tabControl1.Location = new System.Drawing.Point(-1, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.dgvCategorias);
            this.tabCategorias.Controls.Add(this.btnDesactivarCat);
            this.tabCategorias.Controls.Add(this.btnModificarCat);
            this.tabCategorias.Controls.Add(this.btnAgregarCat);
            this.tabCategorias.Controls.Add(this.lblDescripcionCat);
            this.tabCategorias.Controls.Add(this.lblNombreCat);
            this.tabCategorias.Controls.Add(this.txtDescripcionCat);
            this.tabCategorias.Controls.Add(this.txtNombreCat);
            this.tabCategorias.Controls.Add(this.txtCodigoCat);
            this.tabCategorias.Controls.Add(this.lblCodigoCat);
            this.tabCategorias.Controls.Add(this.lblTituloCat);
            this.tabCategorias.Location = new System.Drawing.Point(4, 25);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategorias.Size = new System.Drawing.Size(1012, 543);
            this.tabCategorias.TabIndex = 0;
            this.tabCategorias.Text = "Categorías";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(16, 205);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(991, 332);
            this.dgvCategorias.TabIndex = 10;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // btnDesactivarCat
            // 
            this.btnDesactivarCat.Location = new System.Drawing.Point(792, 126);
            this.btnDesactivarCat.Name = "btnDesactivarCat";
            this.btnDesactivarCat.Size = new System.Drawing.Size(113, 28);
            this.btnDesactivarCat.TabIndex = 9;
            this.btnDesactivarCat.Text = "Desactivar";
            this.btnDesactivarCat.UseVisualStyleBackColor = true;
            this.btnDesactivarCat.Click += new System.EventHandler(this.btnDesactivarCat_Click);
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Location = new System.Drawing.Point(867, 77);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(86, 28);
            this.btnModificarCat.TabIndex = 8;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            this.btnModificarCat.Click += new System.EventHandler(this.btnModificarCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(745, 77);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(86, 28);
            this.btnAgregarCat.TabIndex = 7;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // lblDescripcionCat
            // 
            this.lblDescripcionCat.AutoSize = true;
            this.lblDescripcionCat.Location = new System.Drawing.Point(61, 162);
            this.lblDescripcionCat.Name = "lblDescripcionCat";
            this.lblDescripcionCat.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionCat.TabIndex = 6;
            this.lblDescripcionCat.Text = "Descripcion:";
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.Location = new System.Drawing.Point(66, 117);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCat.TabIndex = 5;
            this.lblNombreCat.Text = "Nombre:";
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Location = new System.Drawing.Point(149, 159);
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(508, 22);
            this.txtDescripcionCat.TabIndex = 4;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(149, 114);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(508, 22);
            this.txtNombreCat.TabIndex = 3;
            // 
            // txtCodigoCat
            // 
            this.txtCodigoCat.Location = new System.Drawing.Point(149, 67);
            this.txtCodigoCat.Name = "txtCodigoCat";
            this.txtCodigoCat.Size = new System.Drawing.Size(508, 22);
            this.txtCodigoCat.TabIndex = 2;
            // 
            // lblCodigoCat
            // 
            this.lblCodigoCat.AutoSize = true;
            this.lblCodigoCat.Location = new System.Drawing.Point(66, 73);
            this.lblCodigoCat.Name = "lblCodigoCat";
            this.lblCodigoCat.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoCat.TabIndex = 1;
            this.lblCodigoCat.Text = "Codigo:";
            // 
            // lblTituloCat
            // 
            this.lblTituloCat.AutoSize = true;
            this.lblTituloCat.Location = new System.Drawing.Point(19, 23);
            this.lblTituloCat.Name = "lblTituloCat";
            this.lblTituloCat.Size = new System.Drawing.Size(234, 16);
            this.lblTituloCat.TabIndex = 0;
            this.lblTituloCat.Text = "ADMINISTRACION DE CATEGORIAS";
            // 
            // tabZonas
            // 
            this.tabZonas.Controls.Add(this.dgvZonas);
            this.tabZonas.Controls.Add(this.btnDesactivarZona);
            this.tabZonas.Controls.Add(this.btnModificarZona);
            this.tabZonas.Controls.Add(this.btnAgregarZona);
            this.tabZonas.Controls.Add(this.txtDescripcionZona);
            this.tabZonas.Controls.Add(this.txtNombreZona);
            this.tabZonas.Controls.Add(this.txtCodigoZona);
            this.tabZonas.Controls.Add(this.lblDescripcionZona);
            this.tabZonas.Controls.Add(this.lblNombreZona);
            this.tabZonas.Controls.Add(this.lblCodigoZona);
            this.tabZonas.Controls.Add(this.lblTituloZona);
            this.tabZonas.Location = new System.Drawing.Point(4, 25);
            this.tabZonas.Name = "tabZonas";
            this.tabZonas.Padding = new System.Windows.Forms.Padding(3);
            this.tabZonas.Size = new System.Drawing.Size(1012, 543);
            this.tabZonas.TabIndex = 1;
            this.tabZonas.Text = "Zonas";
            this.tabZonas.UseVisualStyleBackColor = true;
            // 
            // dgvZonas
            // 
            this.dgvZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZonas.Location = new System.Drawing.Point(21, 202);
            this.dgvZonas.Name = "dgvZonas";
            this.dgvZonas.RowHeadersWidth = 51;
            this.dgvZonas.RowTemplate.Height = 24;
            this.dgvZonas.Size = new System.Drawing.Size(985, 335);
            this.dgvZonas.TabIndex = 10;
            this.dgvZonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZonas_CellClick);
            // 
            // btnDesactivarZona
            // 
            this.btnDesactivarZona.Location = new System.Drawing.Point(802, 141);
            this.btnDesactivarZona.Name = "btnDesactivarZona";
            this.btnDesactivarZona.Size = new System.Drawing.Size(106, 33);
            this.btnDesactivarZona.TabIndex = 9;
            this.btnDesactivarZona.Text = "Desactivar";
            this.btnDesactivarZona.UseVisualStyleBackColor = true;
            this.btnDesactivarZona.Click += new System.EventHandler(this.btnDesactivarZona_Click);
            // 
            // btnModificarZona
            // 
            this.btnModificarZona.Location = new System.Drawing.Point(871, 86);
            this.btnModificarZona.Name = "btnModificarZona";
            this.btnModificarZona.Size = new System.Drawing.Size(106, 32);
            this.btnModificarZona.TabIndex = 8;
            this.btnModificarZona.Text = "Modificar";
            this.btnModificarZona.UseVisualStyleBackColor = true;
            this.btnModificarZona.Click += new System.EventHandler(this.btnModificarZona_Click);
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.Location = new System.Drawing.Point(735, 86);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.Size = new System.Drawing.Size(106, 32);
            this.btnAgregarZona.TabIndex = 7;
            this.btnAgregarZona.Text = "Agregar";
            this.btnAgregarZona.UseVisualStyleBackColor = true;
            this.btnAgregarZona.Click += new System.EventHandler(this.btnAgregarZona_Click);
            // 
            // txtDescripcionZona
            // 
            this.txtDescripcionZona.Location = new System.Drawing.Point(153, 152);
            this.txtDescripcionZona.Name = "txtDescripcionZona";
            this.txtDescripcionZona.Size = new System.Drawing.Size(520, 22);
            this.txtDescripcionZona.TabIndex = 6;
            // 
            // txtNombreZona
            // 
            this.txtNombreZona.Location = new System.Drawing.Point(153, 107);
            this.txtNombreZona.Name = "txtNombreZona";
            this.txtNombreZona.Size = new System.Drawing.Size(520, 22);
            this.txtNombreZona.TabIndex = 5;
            // 
            // txtCodigoZona
            // 
            this.txtCodigoZona.Location = new System.Drawing.Point(153, 66);
            this.txtCodigoZona.Name = "txtCodigoZona";
            this.txtCodigoZona.Size = new System.Drawing.Size(520, 22);
            this.txtCodigoZona.TabIndex = 4;
            // 
            // lblDescripcionZona
            // 
            this.lblDescripcionZona.AutoSize = true;
            this.lblDescripcionZona.Location = new System.Drawing.Point(51, 155);
            this.lblDescripcionZona.Name = "lblDescripcionZona";
            this.lblDescripcionZona.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionZona.TabIndex = 3;
            this.lblDescripcionZona.Text = "Descripcion:";
            // 
            // lblNombreZona
            // 
            this.lblNombreZona.AutoSize = true;
            this.lblNombreZona.Location = new System.Drawing.Point(51, 110);
            this.lblNombreZona.Name = "lblNombreZona";
            this.lblNombreZona.Size = new System.Drawing.Size(59, 16);
            this.lblNombreZona.TabIndex = 2;
            this.lblNombreZona.Text = "Nombre:";
            // 
            // lblCodigoZona
            // 
            this.lblCodigoZona.AutoSize = true;
            this.lblCodigoZona.Location = new System.Drawing.Point(51, 69);
            this.lblCodigoZona.Name = "lblCodigoZona";
            this.lblCodigoZona.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoZona.TabIndex = 1;
            this.lblCodigoZona.Text = "Codigo:";
            // 
            // lblTituloZona
            // 
            this.lblTituloZona.AutoSize = true;
            this.lblTituloZona.Location = new System.Drawing.Point(18, 23);
            this.lblTituloZona.Name = "lblTituloZona";
            this.lblTituloZona.Size = new System.Drawing.Size(193, 16);
            this.lblTituloZona.TabIndex = 0;
            this.lblTituloZona.Text = "ADMINISTRACION DE ZONAS";
            // 
            // frmCategoriaZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCategoriaZona";
            this.Text = "frmCategoriaZona";
            this.Load += new System.EventHandler(this.frmCategoriaZona_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCategorias.ResumeLayout(false);
            this.tabCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tabZonas.ResumeLayout(false);
            this.tabZonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.TabPage tabZonas;
        private System.Windows.Forms.Label lblTituloCat;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.TextBox txtCodigoCat;
        private System.Windows.Forms.Label lblCodigoCat;
        private System.Windows.Forms.Button btnDesactivarCat;
        private System.Windows.Forms.Button btnModificarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Label lblDescripcionCat;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.Label lblCodigoZona;
        private System.Windows.Forms.Label lblTituloZona;
        private System.Windows.Forms.Button btnDesactivarZona;
        private System.Windows.Forms.Button btnModificarZona;
        private System.Windows.Forms.Button btnAgregarZona;
        private System.Windows.Forms.TextBox txtDescripcionZona;
        private System.Windows.Forms.TextBox txtNombreZona;
        private System.Windows.Forms.TextBox txtCodigoZona;
        private System.Windows.Forms.Label lblDescripcionZona;
        private System.Windows.Forms.Label lblNombreZona;
        private System.Windows.Forms.DataGridView dgvZonas;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}