namespace Colegio_las_Rosas
{
    partial class frmRegistros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRep = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCali = new System.Windows.Forms.PictureBox();
            this.pbinscripcion = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbinscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.usuariosToolStripMenuItem.Text = "Calif";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pbinscripcion);
            this.panel4.Location = new System.Drawing.Point(222, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 180);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "INSCRIPCCION";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbCali);
            this.panel1.Location = new System.Drawing.Point(493, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 180);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "CALIFICACIONES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 488);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pbRep);
            this.panel3.Location = new System.Drawing.Point(222, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 180);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Garamond Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "REPORTES";
            // 
            // pbRep
            // 
            this.pbRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRep.Location = new System.Drawing.Point(26, 2);
            this.pbRep.Name = "pbRep";
            this.pbRep.Size = new System.Drawing.Size(148, 141);
            this.pbRep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRep.TabIndex = 1;
            this.pbRep.TabStop = false;
            this.pbRep.Click += new System.EventHandler(this.pbRep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbCali
            // 
            this.pbCali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCali.Location = new System.Drawing.Point(26, 2);
            this.pbCali.Name = "pbCali";
            this.pbCali.Size = new System.Drawing.Size(148, 141);
            this.pbCali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCali.TabIndex = 1;
            this.pbCali.TabStop = false;
            this.pbCali.Click += new System.EventHandler(this.pbCali_Click);
            // 
            // pbinscripcion
            // 
            this.pbinscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbinscripcion.Location = new System.Drawing.Point(26, 2);
            this.pbinscripcion.Name = "pbinscripcion";
            this.pbinscripcion.Size = new System.Drawing.Size(148, 141);
            this.pbinscripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbinscripcion.TabIndex = 1;
            this.pbinscripcion.TabStop = false;
            this.pbinscripcion.Click += new System.EventHandler(this.pbinscripcion_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRegistros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbinscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbinscripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCali;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbRep;
    }
}