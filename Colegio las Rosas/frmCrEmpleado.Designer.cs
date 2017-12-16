namespace Colegio_las_Rosas
{
    partial class frmCrEmpleado
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbgenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.tbcelular = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcodCargo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbsueldo = new System.Windows.Forms.TextBox();
            this.btdepar = new System.Windows.Forms.Button();
            this.tbDepart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btguardar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cbgenero);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtNacimiento);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.tbcedula);
            this.panel4.Controls.Add(this.tbcelular);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.tbtelefono);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.tbdireccion);
            this.panel4.Controls.Add(this.tbapellido);
            this.panel4.Controls.Add(this.tbnombre);
            this.panel4.Location = new System.Drawing.Point(9, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 179);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cbgenero
            // 
            this.cbgenero.FormattingEnabled = true;
            this.cbgenero.Items.AddRange(new object[] {
            "H",
            "M"});
            this.cbgenero.Location = new System.Drawing.Point(572, 146);
            this.cbgenero.Name = "cbgenero";
            this.cbgenero.Size = new System.Drawing.Size(40, 21);
            this.cbgenero.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Telefono";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNacimiento.Location = new System.Drawing.Point(154, 53);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(159, 20);
            this.dtNacimiento.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(336, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Cedula";
            // 
            // tbcedula
            // 
            this.tbcedula.Location = new System.Drawing.Point(388, 50);
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.Size = new System.Drawing.Size(226, 20);
            this.tbcedula.TabIndex = 13;
            // 
            // tbcelular
            // 
            this.tbcelular.Location = new System.Drawing.Point(388, 146);
            this.tbcelular.Name = "tbcelular";
            this.tbcelular.Size = new System.Drawing.Size(140, 20);
            this.tbcelular.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Direccion";
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(153, 146);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(160, 20);
            this.tbtelefono.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Fecha de Nacimiento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(336, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Apellido ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Nombre";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(154, 88);
            this.tbdireccion.Multiline = true;
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(460, 43);
            this.tbdireccion.TabIndex = 5;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(389, 19);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(225, 20);
            this.tbapellido.TabIndex = 4;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(154, 19);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(160, 20);
            this.tbnombre.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btcodCargo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbsueldo);
            this.panel1.Controls.Add(this.btdepar);
            this.panel1.Controls.Add(this.tbDepart);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbCargo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtIngreso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 98);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btcodCargo
            // 
            this.btcodCargo.Location = new System.Drawing.Point(265, 55);
            this.btcodCargo.Name = "btcodCargo";
            this.btcodCargo.Size = new System.Drawing.Size(57, 20);
            this.btcodCargo.TabIndex = 27;
            this.btcodCargo.Text = "///";
            this.btcodCargo.UseVisualStyleBackColor = true;
            this.btcodCargo.Click += new System.EventHandler(this.btcodCargo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sueldo";
            // 
            // tbsueldo
            // 
            this.tbsueldo.Location = new System.Drawing.Point(451, 17);
            this.tbsueldo.Name = "tbsueldo";
            this.tbsueldo.Size = new System.Drawing.Size(93, 20);
            this.tbsueldo.TabIndex = 25;
            // 
            // btdepar
            // 
            this.btdepar.Location = new System.Drawing.Point(555, 56);
            this.btdepar.Name = "btdepar";
            this.btdepar.Size = new System.Drawing.Size(57, 20);
            this.btdepar.TabIndex = 24;
            this.btdepar.Text = "///";
            this.btdepar.UseVisualStyleBackColor = true;
            this.btdepar.Click += new System.EventHandler(this.btdepar_Click);
            // 
            // tbDepart
            // 
            this.tbDepart.Location = new System.Drawing.Point(451, 56);
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.Size = new System.Drawing.Size(93, 20);
            this.tbDepart.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Departamento";
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(153, 56);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(93, 20);
            this.tbCargo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cargo";
            // 
            // dtIngreso
            // 
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIngreso.Location = new System.Drawing.Point(153, 14);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(159, 20);
            this.dtIngreso.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datos Generales ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dato Laboral";
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(132, 334);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(110, 28);
            this.btguardar.TabIndex = 11;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(276, 334);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(110, 28);
            this.bteditar.TabIndex = 12;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(429, 334);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(110, 28);
            this.bteliminar.TabIndex = 13;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            // 
            // frmCrEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 376);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "frmCrEmpleado";
            this.Text = "Crear Empleado";
            this.Load += new System.EventHandler(this.frmCrEmpleado_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbcedula;
        private System.Windows.Forms.TextBox tbcelular;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbsueldo;
        private System.Windows.Forms.Button btdepar;
        private System.Windows.Forms.TextBox tbDepart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.ComboBox cbgenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btcodCargo;
    }
}