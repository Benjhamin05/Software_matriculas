namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMatri = new System.Windows.Forms.NumericUpDown();
            this.txtNivel = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.Registrar_m = new System.Windows.Forms.Button();
            this.Eliminar_m = new System.Windows.Forms.Button();
            this.Actualizar_m = new System.Windows.Forms.Button();
            this.Seleccionar_m = new System.Windows.Forms.Button();
            this.txtIdAlumno = new System.Windows.Forms.NumericUpDown();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR MATRICULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alumno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // txtIdMatri
            // 
            this.txtIdMatri.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMatri.Location = new System.Drawing.Point(119, 47);
            this.txtIdMatri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMatri.Name = "txtIdMatri";
            this.txtIdMatri.Size = new System.Drawing.Size(149, 25);
            this.txtIdMatri.TabIndex = 9;
            // 
            // txtNivel
            // 
            this.txtNivel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.FormattingEnabled = true;
            this.txtNivel.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria"});
            this.txtNivel.Location = new System.Drawing.Point(119, 134);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(275, 25);
            this.txtNivel.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(119, 217);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(275, 25);
            this.txtFecha.TabIndex = 12;
            this.txtFecha.ValueChanged += new System.EventHandler(this.txtFecha_ValueChanged);
            // 
            // Registrar_m
            // 
            this.Registrar_m.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar_m.Image = ((System.Drawing.Image)(resources.GetObject("Registrar_m.Image")));
            this.Registrar_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrar_m.Location = new System.Drawing.Point(25, 457);
            this.Registrar_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Registrar_m.Name = "Registrar_m";
            this.Registrar_m.Size = new System.Drawing.Size(150, 50);
            this.Registrar_m.TabIndex = 13;
            this.Registrar_m.Text = "Registrar";
            this.Registrar_m.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Registrar_m.UseVisualStyleBackColor = true;
            this.Registrar_m.Click += new System.EventHandler(this.Registrar_m_Click);
            // 
            // Eliminar_m
            // 
            this.Eliminar_m.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_m.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar_m.Image")));
            this.Eliminar_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_m.Location = new System.Drawing.Point(389, 457);
            this.Eliminar_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminar_m.Name = "Eliminar_m";
            this.Eliminar_m.Size = new System.Drawing.Size(119, 50);
            this.Eliminar_m.TabIndex = 14;
            this.Eliminar_m.Text = "Eliminar";
            this.Eliminar_m.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_m.UseVisualStyleBackColor = true;
            this.Eliminar_m.Click += new System.EventHandler(this.Eliminar_m_Click);
            // 
            // Actualizar_m
            // 
            this.Actualizar_m.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar_m.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar_m.Image")));
            this.Actualizar_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar_m.Location = new System.Drawing.Point(202, 457);
            this.Actualizar_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Actualizar_m.Name = "Actualizar_m";
            this.Actualizar_m.Size = new System.Drawing.Size(148, 50);
            this.Actualizar_m.TabIndex = 15;
            this.Actualizar_m.Text = "Actualizar";
            this.Actualizar_m.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Actualizar_m.UseVisualStyleBackColor = true;
            this.Actualizar_m.Click += new System.EventHandler(this.Actualizar_m_Click);
            // 
            // Seleccionar_m
            // 
            this.Seleccionar_m.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccionar_m.Image = ((System.Drawing.Image)(resources.GetObject("Seleccionar_m.Image")));
            this.Seleccionar_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Seleccionar_m.Location = new System.Drawing.Point(261, 288);
            this.Seleccionar_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Seleccionar_m.Name = "Seleccionar_m";
            this.Seleccionar_m.Size = new System.Drawing.Size(157, 50);
            this.Seleccionar_m.TabIndex = 16;
            this.Seleccionar_m.Text = "Seleccionar";
            this.Seleccionar_m.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Seleccionar_m.UseVisualStyleBackColor = true;
            this.Seleccionar_m.Click += new System.EventHandler(this.Seleccionar_m_Click);
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAlumno.Location = new System.Drawing.Point(119, 84);
            this.txtIdAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(149, 25);
            this.txtIdAlumno.TabIndex = 17;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(119, 178);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(149, 25);
            this.txtMonto.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Seleccionar_m);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtIdAlumno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNivel);
            this.groupBox1.Controls.Add(this.txtIdMatri);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 347);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(538, 536);
            this.Controls.Add(this.Actualizar_m);
            this.Controls.Add(this.Eliminar_m);
            this.Controls.Add(this.Registrar_m);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown txtIdMatri;
        private System.Windows.Forms.ComboBox txtNivel;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Button Registrar_m;
        private System.Windows.Forms.Button Eliminar_m;
        private System.Windows.Forms.Button Actualizar_m;
        private System.Windows.Forms.Button Seleccionar_m;
        private System.Windows.Forms.NumericUpDown txtIdAlumno;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}