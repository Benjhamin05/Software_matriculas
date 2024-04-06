namespace WindowsFormsApp1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtidp = new System.Windows.Forms.NumericUpDown();
            this.txtide = new System.Windows.Forms.NumericUpDown();
            this.txtNpension = new System.Windows.Forms.NumericUpDown();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtidp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNpension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID ESTUDIANTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NRO PENSION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MONTO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA PAGO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "SELECCIONAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidp
            // 
            this.txtidp.Location = new System.Drawing.Point(131, 44);
            this.txtidp.Name = "txtidp";
            this.txtidp.Size = new System.Drawing.Size(60, 20);
            this.txtidp.TabIndex = 7;
            // 
            // txtide
            // 
            this.txtide.Location = new System.Drawing.Point(131, 77);
            this.txtide.Name = "txtide";
            this.txtide.Size = new System.Drawing.Size(60, 20);
            this.txtide.TabIndex = 8;
            // 
            // txtNpension
            // 
            this.txtNpension.Location = new System.Drawing.Point(131, 110);
            this.txtNpension.Name = "txtNpension";
            this.txtNpension.Size = new System.Drawing.Size(60, 20);
            this.txtNpension.TabIndex = 9;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(131, 150);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(60, 20);
            this.txtMonto.TabIndex = 10;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(131, 185);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(174, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "REGISTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(358, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNpension);
            this.Controls.Add(this.txtide);
            this.Controls.Add(this.txtidp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.txtidp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNpension)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtidp;
        private System.Windows.Forms.NumericUpDown txtide;
        private System.Windows.Forms.NumericUpDown txtNpension;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}