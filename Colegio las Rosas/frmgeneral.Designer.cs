namespace Colegio_las_Rosas
{
    partial class frmgeneral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcerrarsesion = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pBempleados = new System.Windows.Forms.PictureBox();
            this.pbFinanzas = new System.Windows.Forms.PictureBox();
            this.pbregistro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBempleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinanzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbregistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btcerrarsesion);
            this.panel1.Controls.Add(this.btsalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 488);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btcerrarsesion
            // 
            this.btcerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrarsesion.Location = new System.Drawing.Point(25, 399);
            this.btcerrarsesion.Name = "btcerrarsesion";
            this.btcerrarsesion.Size = new System.Drawing.Size(145, 31);
            this.btcerrarsesion.TabIndex = 2;
            this.btcerrarsesion.Text = "Cerrar Sesion";
            this.btcerrarsesion.UseVisualStyleBackColor = true;
            this.btcerrarsesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btsalir
            // 
            this.btsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir.Location = new System.Drawing.Point(25, 362);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(145, 31);
            this.btsalir.TabIndex = 1;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.crearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.archivosToolStripMenuItem.Text = "Archivos ";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.usuariosToolStripMenuItem.Text = "1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario ";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbregistro);
            this.panel2.Location = new System.Drawing.Point(241, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 180);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTROS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pbFinanzas);
            this.panel3.Location = new System.Drawing.Point(506, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 180);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "FINANZAS";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pBempleados);
            this.panel5.Location = new System.Drawing.Point(506, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 180);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "EMPLEADOS";
            // 
            // pBempleados
            // 
            this.pBempleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBempleados.Location = new System.Drawing.Point(26, 3);
            this.pBempleados.Name = "pBempleados";
            this.pBempleados.Size = new System.Drawing.Size(148, 141);
            this.pBempleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBempleados.TabIndex = 2;
            this.pBempleados.TabStop = false;
            this.pBempleados.Click += new System.EventHandler(this.pBempleados_Click);
            // 
            // pbFinanzas
            // 
            this.pbFinanzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFinanzas.Location = new System.Drawing.Point(28, 3);
            this.pbFinanzas.Name = "pbFinanzas";
            this.pbFinanzas.Size = new System.Drawing.Size(148, 141);
            this.pbFinanzas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFinanzas.TabIndex = 1;
            this.pbFinanzas.TabStop = false;
            this.pbFinanzas.Click += new System.EventHandler(this.pbFinanzas_Click);
            // 
            // pbregistro
            // 
            this.pbregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbregistro.Location = new System.Drawing.Point(26, 3);
            this.pbregistro.Name = "pbregistro";
            this.pbregistro.Size = new System.Drawing.Size(148, 141);
            this.pbregistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbregistro.TabIndex = 0;
            this.pbregistro.TabStop = false;
            this.pbregistro.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbregistro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.entrar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmgeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 511);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmgeneral";
            this.Text = "General";
            this.Load += new System.EventHandler(this.frmgeneral_Load);
            this.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBempleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinanzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbregistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Button btcerrarsesion;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbregistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFinanzas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBempleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
    }
}