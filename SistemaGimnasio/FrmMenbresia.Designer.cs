namespace SistemaGimnasio
{
    partial class FrmMenbresia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidemenbresia = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombreee = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cbactivo = new System.Windows.Forms.CheckBox();
            this.datamebresia = new System.Windows.Forms.DataGridView();
            this.btnsalirr = new System.Windows.Forms.Button();
            this.btndesabilitar = new System.Windows.Forms.Button();
            this.grupBoxDatosMembresia = new System.Windows.Forms.GroupBox();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datamebresia)).BeginInit();
            this.grupBoxDatosMembresia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id de menbresia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "duracion(meses)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lista de menbresias";
            // 
            // txtidemenbresia
            // 
            this.txtidemenbresia.Location = new System.Drawing.Point(17, 49);
            this.txtidemenbresia.Name = "txtidemenbresia";
            this.txtidemenbresia.Size = new System.Drawing.Size(100, 20);
            this.txtidemenbresia.TabIndex = 6;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(17, 171);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 7;
            // 
            // txtnombreee
            // 
            this.txtnombreee.Location = new System.Drawing.Point(148, 48);
            this.txtnombreee.Name = "txtnombreee";
            this.txtnombreee.Size = new System.Drawing.Size(100, 20);
            this.txtnombreee.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(17, 95);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(231, 56);
            this.txtdescripcion.TabIndex = 9;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(363, 36);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(363, 87);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 11;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(363, 141);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 12;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(363, 200);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // cbactivo
            // 
            this.cbactivo.AutoSize = true;
            this.cbactivo.Location = new System.Drawing.Point(19, 203);
            this.cbactivo.Name = "cbactivo";
            this.cbactivo.Size = new System.Drawing.Size(55, 17);
            this.cbactivo.TabIndex = 14;
            this.cbactivo.Text = "activo";
            this.cbactivo.UseVisualStyleBackColor = true;
            // 
            // datamebresia
            // 
            this.datamebresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamebresia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.precio,
            this.estado});
            this.datamebresia.Location = new System.Drawing.Point(15, 269);
            this.datamebresia.Name = "datamebresia";
            this.datamebresia.Size = new System.Drawing.Size(443, 150);
            this.datamebresia.TabIndex = 15;
            this.datamebresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamebresia_CellContentClick);
            // 
            // btnsalirr
            // 
            this.btnsalirr.Location = new System.Drawing.Point(15, 425);
            this.btnsalirr.Name = "btnsalirr";
            this.btnsalirr.Size = new System.Drawing.Size(75, 23);
            this.btnsalirr.TabIndex = 16;
            this.btnsalirr.Text = "salir";
            this.btnsalirr.UseVisualStyleBackColor = true;
            this.btnsalirr.Click += new System.EventHandler(this.btnsalirr_Click);
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.Location = new System.Drawing.Point(105, 425);
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.Size = new System.Drawing.Size(75, 23);
            this.btndesabilitar.TabIndex = 17;
            this.btndesabilitar.Text = "desabilitar";
            this.btndesabilitar.UseVisualStyleBackColor = true;
            // 
            // grupBoxDatosMembresia
            // 
            this.grupBoxDatosMembresia.Controls.Add(this.txtduracion);
            this.grupBoxDatosMembresia.Controls.Add(this.label1);
            this.grupBoxDatosMembresia.Controls.Add(this.label2);
            this.grupBoxDatosMembresia.Controls.Add(this.label3);
            this.grupBoxDatosMembresia.Controls.Add(this.cbactivo);
            this.grupBoxDatosMembresia.Controls.Add(this.label4);
            this.grupBoxDatosMembresia.Controls.Add(this.txtidemenbresia);
            this.grupBoxDatosMembresia.Controls.Add(this.txtnombreee);
            this.grupBoxDatosMembresia.Controls.Add(this.txtprecio);
            this.grupBoxDatosMembresia.Controls.Add(this.label5);
            this.grupBoxDatosMembresia.Controls.Add(this.txtdescripcion);
            this.grupBoxDatosMembresia.Location = new System.Drawing.Point(13, 13);
            this.grupBoxDatosMembresia.Name = "grupBoxDatosMembresia";
            this.grupBoxDatosMembresia.Size = new System.Drawing.Size(307, 228);
            this.grupBoxDatosMembresia.TabIndex = 18;
            this.grupBoxDatosMembresia.TabStop = false;
            this.grupBoxDatosMembresia.Text = "Datos Menbresia";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(146, 172);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(100, 20);
            this.txtduracion.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "nombre";
            this.Nombre.Name = "Nombre";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // FrmMenbresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.btnsalirr);
            this.Controls.Add(this.datamebresia);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grupBoxDatosMembresia);
            this.Name = "FrmMenbresia";
            this.Text = "FrmMenbresia";
            this.Load += new System.EventHandler(this.FrmMenbresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamebresia)).EndInit();
            this.grupBoxDatosMembresia.ResumeLayout(false);
            this.grupBoxDatosMembresia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidemenbresia;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombreee;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.CheckBox cbactivo;
        private System.Windows.Forms.DataGridView datamebresia;
        private System.Windows.Forms.Button btnsalirr;
        private System.Windows.Forms.Button btndesabilitar;
        private System.Windows.Forms.GroupBox grupBoxDatosMembresia;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}