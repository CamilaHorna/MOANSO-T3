namespace SistemaGimnasio
{
    partial class FrmDescuento
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
            this.groupBoxdatos = new System.Windows.Forms.GroupBox();
            this.cbkestado = new System.Windows.Forms.CheckBox();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdescuentos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btndesabilitar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBoxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxdatos
            // 
            this.groupBoxdatos.Controls.Add(this.cbkestado);
            this.groupBoxdatos.Controls.Add(this.txtporcentaje);
            this.groupBoxdatos.Controls.Add(this.txtid);
            this.groupBoxdatos.Controls.Add(this.txtcodigo);
            this.groupBoxdatos.Controls.Add(this.label3);
            this.groupBoxdatos.Controls.Add(this.label2);
            this.groupBoxdatos.Controls.Add(this.label1);
            this.groupBoxdatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxdatos.Name = "groupBoxdatos";
            this.groupBoxdatos.Size = new System.Drawing.Size(299, 181);
            this.groupBoxdatos.TabIndex = 0;
            this.groupBoxdatos.TabStop = false;
            this.groupBoxdatos.Text = "Datos del descuento ";
            this.groupBoxdatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbkestado
            // 
            this.cbkestado.AutoSize = true;
            this.cbkestado.Location = new System.Drawing.Point(35, 137);
            this.cbkestado.Name = "cbkestado";
            this.cbkestado.Size = new System.Drawing.Size(56, 17);
            this.cbkestado.TabIndex = 6;
            this.cbkestado.Text = "Activo";
            this.cbkestado.UseVisualStyleBackColor = true;
            this.cbkestado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(162, 96);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtporcentaje.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(35, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(162, 58);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porcentaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id descuento ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvdescuentos
            // 
            this.dgvdescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Porcentaje,
            this.Estado});
            this.dgvdescuentos.Location = new System.Drawing.Point(12, 216);
            this.dgvdescuentos.Name = "dgvdescuentos";
            this.dgvdescuentos.Size = new System.Drawing.Size(437, 150);
            this.dgvdescuentos.TabIndex = 1;
            this.dgvdescuentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(357, 34);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click_1);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(357, 70);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(357, 108);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(357, 149);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "cancelar ";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista de descuentos";
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.Location = new System.Drawing.Point(118, 372);
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.Size = new System.Drawing.Size(75, 23);
            this.btndesabilitar.TabIndex = 7;
            this.btndesabilitar.Text = "desabilitar";
            this.btndesabilitar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(262, 372);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // FrmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgvdescuentos);
            this.Controls.Add(this.groupBoxdatos);
            this.Name = "FrmDescuento";
            this.Text = "FrmDescuento";
            this.Load += new System.EventHandler(this.FrmDescuento_Load);
            this.groupBoxdatos.ResumeLayout(false);
            this.groupBoxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvdescuentos;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.CheckBox cbkestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndesabilitar;
        private System.Windows.Forms.Button btnsalir;
    }
}