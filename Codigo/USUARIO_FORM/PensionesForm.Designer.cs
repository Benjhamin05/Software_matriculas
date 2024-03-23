namespace USUARIO_FORM
{
    partial class PensionesForm
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pENSIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDMATRICULADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_MATRICULADataSet = new USUARIO_FORM.BD_MATRICULADataSet();
            this.pENSIONESTableAdapter = new USUARIO_FORM.BD_MATRICULADataSetTableAdapters.PENSIONESTableAdapter();
            this.idPENSIONESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadopagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENSIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMATRICULADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_MATRICULADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(22, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "PANEL DE CONTROL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "PENSIONES";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.White;
            this.Inicio.Location = new System.Drawing.Point(22, 159);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(156, 43);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "INICIO";
            this.Inicio.UseVisualStyleBackColor = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(221, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 89);
            this.panel2.TabIndex = 6;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreUsuario.Location = new System.Drawing.Point(405, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USUARIO_FORM.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(485, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Inicio);
            this.panel1.Location = new System.Drawing.Point(6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 449);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(221, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 330);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPENSIONESDataGridViewTextBoxColumn,
            this.idestudianteDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechapagoDataGridViewTextBoxColumn,
            this.estadopagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pENSIONESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pENSIONESBindingSource
            // 
            this.pENSIONESBindingSource.DataMember = "PENSIONES";
            this.pENSIONESBindingSource.DataSource = this.bDMATRICULADataSetBindingSource;
            // 
            // bDMATRICULADataSetBindingSource
            // 
            this.bDMATRICULADataSetBindingSource.DataSource = this.bD_MATRICULADataSet;
            this.bDMATRICULADataSetBindingSource.Position = 0;
            // 
            // bD_MATRICULADataSet
            // 
            this.bD_MATRICULADataSet.DataSetName = "BD_MATRICULADataSet";
            this.bD_MATRICULADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pENSIONESTableAdapter
            // 
            this.pENSIONESTableAdapter.ClearBeforeFill = true;
            // 
            // idPENSIONESDataGridViewTextBoxColumn
            // 
            this.idPENSIONESDataGridViewTextBoxColumn.DataPropertyName = "id_PENSIONES";
            this.idPENSIONESDataGridViewTextBoxColumn.HeaderText = "ID PENSION";
            this.idPENSIONESDataGridViewTextBoxColumn.Name = "idPENSIONESDataGridViewTextBoxColumn";
            // 
            // idestudianteDataGridViewTextBoxColumn
            // 
            this.idestudianteDataGridViewTextBoxColumn.DataPropertyName = "id_estudiante";
            this.idestudianteDataGridViewTextBoxColumn.HeaderText = "CODIGO ESTUDIANTE";
            this.idestudianteDataGridViewTextBoxColumn.Name = "idestudianteDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "MONTO";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // fechapagoDataGridViewTextBoxColumn
            // 
            this.fechapagoDataGridViewTextBoxColumn.DataPropertyName = "fecha_pago";
            this.fechapagoDataGridViewTextBoxColumn.HeaderText = "FECHA PAGO";
            this.fechapagoDataGridViewTextBoxColumn.Name = "fechapagoDataGridViewTextBoxColumn";
            // 
            // estadopagoDataGridViewTextBoxColumn
            // 
            this.estadopagoDataGridViewTextBoxColumn.DataPropertyName = "estado_pago";
            this.estadopagoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadopagoDataGridViewTextBoxColumn.Name = "estadopagoDataGridViewTextBoxColumn";
            // 
            // PensionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PensionesForm";
            this.Text = "PensionesForm";
            this.Load += new System.EventHandler(this.PensionesForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENSIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDMATRICULADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_MATRICULADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bDMATRICULADataSetBindingSource;
        private BD_MATRICULADataSet bD_MATRICULADataSet;
        private System.Windows.Forms.BindingSource pENSIONESBindingSource;
        private BD_MATRICULADataSetTableAdapters.PENSIONESTableAdapter pENSIONESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPENSIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadopagoDataGridViewTextBoxColumn;
    }
}