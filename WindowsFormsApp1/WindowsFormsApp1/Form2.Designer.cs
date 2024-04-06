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
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR MATRICULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alumno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // txtIdMatri
            // 
            this.txtIdMatri.Location = new System.Drawing.Point(125, 79);
            this.txtIdMatri.Name = "txtIdMatri";
            this.txtIdMatri.Size = new System.Drawing.Size(129, 22);
            this.txtIdMatri.TabIndex = 9;
            // 
            // txtNivel
            // 
            this.txtNivel.FormattingEnabled = true;
            this.txtNivel.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria"});
            this.txtNivel.Location = new System.Drawing.Point(125, 166);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(310, 24);
            this.txtNivel.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(125, 249);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(260, 22);
            this.txtFecha.TabIndex = 12;
            // 
            // Registrar_m
            // 
            this.Registrar_m.Location = new System.Drawing.Point(144, 340);
            this.Registrar_m.Name = "Registrar_m";
            this.Registrar_m.Size = new System.Drawing.Size(125, 51);
            this.Registrar_m.TabIndex = 13;
            this.Registrar_m.Text = "Registrar";
            this.Registrar_m.UseVisualStyleBackColor = true;
            this.Registrar_m.Click += new System.EventHandler(this.Registrar_m_Click);
            // 
            // Eliminar_m
            // 
            this.Eliminar_m.Location = new System.Drawing.Point(275, 340);
            this.Eliminar_m.Name = "Eliminar_m";
            this.Eliminar_m.Size = new System.Drawing.Size(110, 51);
            this.Eliminar_m.TabIndex = 14;
            this.Eliminar_m.Text = "Eliminar";
            this.Eliminar_m.UseVisualStyleBackColor = true;
            this.Eliminar_m.Click += new System.EventHandler(this.Eliminar_m_Click);
            // 
            // Actualizar_m
            // 
            this.Actualizar_m.Location = new System.Drawing.Point(391, 340);
            this.Actualizar_m.Name = "Actualizar_m";
            this.Actualizar_m.Size = new System.Drawing.Size(120, 51);
            this.Actualizar_m.TabIndex = 15;
            this.Actualizar_m.Text = "Actualizar";
            this.Actualizar_m.UseVisualStyleBackColor = true;
            this.Actualizar_m.Click += new System.EventHandler(this.Actualizar_m_Click);
            // 
            // Seleccionar_m
            // 
            this.Seleccionar_m.Location = new System.Drawing.Point(12, 340);
            this.Seleccionar_m.Name = "Seleccionar_m";
            this.Seleccionar_m.Size = new System.Drawing.Size(126, 51);
            this.Seleccionar_m.TabIndex = 16;
            this.Seleccionar_m.Text = "Seleccionar";
            this.Seleccionar_m.UseVisualStyleBackColor = true;
            this.Seleccionar_m.Click += new System.EventHandler(this.Seleccionar_m_Click);
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(125, 116);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(129, 22);
            this.txtIdAlumno.TabIndex = 17;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(125, 210);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(120, 22);
            this.txtMonto.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 403);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtIdAlumno);
            this.Controls.Add(this.Seleccionar_m);
            this.Controls.Add(this.Actualizar_m);
            this.Controls.Add(this.Eliminar_m);
            this.Controls.Add(this.Registrar_m);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtIdMatri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
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
    }
}