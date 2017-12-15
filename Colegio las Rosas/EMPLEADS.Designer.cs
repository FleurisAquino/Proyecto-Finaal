namespace Colegio_las_Rosas
{
    partial class frmEMPLEADS
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbVempleado = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCemp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbConEmp = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVempleado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCemp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pbVempleado);
            this.panel5.Location = new System.Drawing.Point(221, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 180);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ver Empleados ";
            // 
            // pbVempleado
            // 
            this.pbVempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVempleado.Location = new System.Drawing.Point(26, 3);
            this.pbVempleado.Name = "pbVempleado";
            this.pbVempleado.Size = new System.Drawing.Size(148, 141);
            this.pbVempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVempleado.TabIndex = 2;
            this.pbVempleado.TabStop = false;
            this.pbVempleado.Click += new System.EventHandler(this.pBempleados_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbCemp);
            this.panel1.Location = new System.Drawing.Point(221, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 180);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crear Empleado";
            // 
            // pbCemp
            // 
            this.pbCemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCemp.Location = new System.Drawing.Point(26, 3);
            this.pbCemp.Name = "pbCemp";
            this.pbCemp.Size = new System.Drawing.Size(148, 141);
            this.pbCemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCemp.TabIndex = 2;
            this.pbCemp.TabStop = false;
            this.pbCemp.Click += new System.EventHandler(this.pbCemp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbConEmp);
            this.panel2.Location = new System.Drawing.Point(462, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 180);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado, Cargo, Departamento";
            // 
            // pbConEmp
            // 
            this.pbConEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConEmp.Location = new System.Drawing.Point(69, 6);
            this.pbConEmp.Name = "pbConEmp";
            this.pbConEmp.Size = new System.Drawing.Size(148, 141);
            this.pbConEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConEmp.TabIndex = 2;
            this.pbConEmp.TabStop = false;
            this.pbConEmp.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmEMPLEADS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "frmEMPLEADS";
            this.Text = "EMPLEADOS";
            this.Load += new System.EventHandler(this.frmEMPLEADOS_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVempleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCemp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbVempleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCemp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbConEmp;
    }
}