namespace asa_empleado
{
    partial class asa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asa));
            this.EMPLEADOS = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.MODIFICAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ALTAS = new System.Windows.Forms.Button();
            this.ASISTENCIA = new System.Windows.Forms.Button();
            this.BAJAS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LAST_NAME = new System.Windows.Forms.TextBox();
            this.TIA = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EMPLEADOS
            // 
            this.EMPLEADOS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.EMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EMPLEADOS.Location = new System.Drawing.Point(130, 147);
            this.EMPLEADOS.Name = "EMPLEADOS";
            this.EMPLEADOS.Size = new System.Drawing.Size(667, 300);
            this.EMPLEADOS.TabIndex = 15;
            this.EMPLEADOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EMPLEADOS_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LAST_NAME);
            this.panel1.Controls.Add(this.TIA);
            this.panel1.Controls.Add(this.NAME);
            this.panel1.Controls.Add(this.EMPLEADOS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.MODIFICAR);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.ALTAS);
            this.panel3.Controls.Add(this.ASISTENCIA);
            this.panel3.Controls.Add(this.BAJAS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 414);
            this.panel3.TabIndex = 29;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::asa_empleado.Properties.Resources.logout__1_;
            this.pictureBox7.Location = new System.Drawing.Point(13, 371);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.BackColor = System.Drawing.Color.Yellow;
            this.MODIFICAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MODIFICAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODIFICAR.Location = new System.Drawing.Point(10, 87);
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.Size = new System.Drawing.Size(105, 34);
            this.MODIFICAR.TabIndex = 14;
            this.MODIFICAR.Text = "MODIFICAR";
            this.MODIFICAR.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::asa_empleado.Properties.Resources.asa;
            this.pictureBox1.Location = new System.Drawing.Point(0, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // ALTAS
            // 
            this.ALTAS.BackColor = System.Drawing.Color.Lime;
            this.ALTAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ALTAS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ALTAS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALTAS.Location = new System.Drawing.Point(10, 38);
            this.ALTAS.Name = "ALTAS";
            this.ALTAS.Size = new System.Drawing.Size(107, 33);
            this.ALTAS.TabIndex = 24;
            this.ALTAS.Text = "ALTAS";
            this.ALTAS.UseVisualStyleBackColor = false;
            // 
            // ASISTENCIA
            // 
            this.ASISTENCIA.BackColor = System.Drawing.Color.Yellow;
            this.ASISTENCIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ASISTENCIA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ASISTENCIA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.ASISTENCIA.Location = new System.Drawing.Point(8, 140);
            this.ASISTENCIA.Name = "ASISTENCIA";
            this.ASISTENCIA.Size = new System.Drawing.Size(107, 31);
            this.ASISTENCIA.TabIndex = 25;
            this.ASISTENCIA.Text = "ASISTENCIA";
            this.ASISTENCIA.UseVisualStyleBackColor = false;
            // 
            // BAJAS
            // 
            this.BAJAS.BackColor = System.Drawing.Color.Red;
            this.BAJAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAJAS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAJAS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.BAJAS.Location = new System.Drawing.Point(8, 187);
            this.BAJAS.Name = "BAJAS";
            this.BAJAS.Size = new System.Drawing.Size(107, 30);
            this.BAJAS.TabIndex = 16;
            this.BAJAS.Text = "BAJAS";
            this.BAJAS.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 36);
            this.panel2.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "AEREOPUERTOS Y SERVICIOS AUXILIARES";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(703, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 11);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::asa_empleado.Properties.Resources.asa_logo2;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(654, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 11);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(597, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 11);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::asa_empleado.Properties.Resources.icons8_cancelar_40;
            this.pictureBox2.Location = new System.Drawing.Point(761, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "NUMERO DE TIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "APELLIDOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "SEGURIDAD AEREOPUERTARIA";
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.Location = new System.Drawing.Point(207, 72);
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.Size = new System.Drawing.Size(133, 20);
            this.LAST_NAME.TabIndex = 19;
            // 
            // TIA
            // 
            this.TIA.Location = new System.Drawing.Point(697, 73);
            this.TIA.Name = "TIA";
            this.TIA.Size = new System.Drawing.Size(100, 20);
            this.TIA.TabIndex = 18;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(438, 72);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(133, 20);
            this.NAME.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // asa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "asa";
            this.Text = "Aereopuertos y Servicios Auxiliares";
            this.Load += new System.EventHandler(this.asa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EMPLEADOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ASISTENCIA;
        private System.Windows.Forms.Button ALTAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LAST_NAME;
        private System.Windows.Forms.TextBox TIA;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Button BAJAS;
        private System.Windows.Forms.Button MODIFICAR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer timer3;
    }
}

