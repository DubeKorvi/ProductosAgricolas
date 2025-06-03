namespace Capa_Interfas
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dgvResumen = new DataGridView();
            cmbTipo = new ComboBox();
            cmbTemporada = new ComboBox();
            cmbProduc = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnAgregar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txbPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(25, 12);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 62;
            dgvResumen.Size = new Size(840, 391);
            dgvResumen.TabIndex = 0;
            dgvResumen.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(25, 494);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(252, 33);
            cmbTipo.TabIndex = 1;
            cmbTipo.Text = "Tipo";
            // 
            // cmbTemporada
            // 
            cmbTemporada.FormattingEnabled = true;
            cmbTemporada.Location = new Point(320, 494);
            cmbTemporada.Name = "cmbTemporada";
            cmbTemporada.Size = new Size(252, 33);
            cmbTemporada.TabIndex = 2;
            cmbTemporada.Text = "Temporada";
            // 
            // cmbProduc
            // 
            cmbProduc.FormattingEnabled = true;
            cmbProduc.Location = new Point(615, 494);
            cmbProduc.Name = "cmbProduc";
            cmbProduc.Size = new Size(250, 33);
            cmbProduc.TabIndex = 3;
            cmbProduc.Text = "Producto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 570);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(383, 610);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(615, 569);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(250, 31);
            txbPrecio.TabIndex = 6;
            txbPrecio.Text = "Digite Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 693);
            Controls.Add(txbPrecio);
            Controls.Add(btnAgregar);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbProduc);
            Controls.Add(cmbTemporada);
            Controls.Add(cmbTipo);
            Controls.Add(dgvResumen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResumen;
        private ComboBox cmbTipo;
        private ComboBox cmbTemporada;
        private ComboBox cmbProduc;
        private NumericUpDown numericUpDown1;
        private Button btnAgregar;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txbPrecio;
    }
}