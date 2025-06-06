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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Temporada = new Label();
            label7 = new Label();
            txbPrecio = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvResumen
            // 
            dgvResumen.AllowUserToAddRows = false;
            dgvResumen.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(89, 112);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 62;
            dgvResumen.Size = new Size(1201, 317);
            dgvResumen.TabIndex = 0;
            dgvResumen.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbTipo
            // 
            cmbTipo.Anchor = AnchorStyles.Left;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(74, 526);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(252, 33);
            cmbTipo.TabIndex = 1;
            // 
            // cmbTemporada
            // 
            cmbTemporada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbTemporada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemporada.FormattingEnabled = true;
            cmbTemporada.Location = new Point(562, 526);
            cmbTemporada.Name = "cmbTemporada";
            cmbTemporada.Size = new Size(252, 33);
            cmbTemporada.TabIndex = 2;
            // 
            // cmbProduc
            // 
            cmbProduc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduc.Font = new Font("Sitka Text Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProduc.FormattingEnabled = true;
            cmbProduc.Location = new Point(1011, 526);
            cmbProduc.Name = "cmbProduc";
            cmbProduc.Size = new Size(264, 37);
            cmbProduc.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(74, 644);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 31);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(605, 631);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 56);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1039, 592);
            label1.Name = "label1";
            label1.Size = new Size(217, 29);
            label1.TabIndex = 7;
            label1.Text = "Digite El Precio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 595);
            label2.Name = "label2";
            label2.Size = new Size(279, 26);
            label2.TabIndex = 8;
            label2.Text = "Selecione la cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Honeydew;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(319, 24);
            label3.Name = "label3";
            label3.Size = new Size(760, 44);
            label3.TabIndex = 9;
            label3.Text = "----------Productos Agricolas----------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(491, 84);
            label4.Name = "label4";
            label4.Size = new Size(415, 25);
            label4.TabIndex = 10;
            label4.Text = "Los mejores Productos del Condado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 484);
            label5.Name = "label5";
            label5.Size = new Size(70, 29);
            label5.TabIndex = 11;
            label5.Text = "Tipo";
            // 
            // Temporada
            // 
            Temporada.AutoSize = true;
            Temporada.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Temporada.Location = new Point(605, 484);
            Temporada.Name = "Temporada";
            Temporada.Size = new Size(164, 29);
            Temporada.TabIndex = 12;
            Temporada.Text = "Temporada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(1076, 484);
            label7.Name = "label7";
            label7.Size = new Size(134, 29);
            label7.TabIndex = 13;
            label7.Text = "Producto";
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(1011, 644);
            txbPrecio.Mask = "0000000000";
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(264, 31);
            txbPrecio.TabIndex = 14;
            txbPrecio.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 693);
            Controls.Add(txbPrecio);
            Controls.Add(label7);
            Controls.Add(Temporada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbProduc);
            Controls.Add(cmbTemporada);
            Controls.Add(cmbTipo);
            Controls.Add(dgvResumen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Temporada;
        private Label label7;
        private MaskedTextBox txbPrecio;
    }
}