namespace Capa_Interfas
{
    partial class Pantalla_De_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_De_Inicio));
            butCatalogo = new Button();
            butHacer_pedido = new Button();
            butSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butCatalogo
            // 
            butCatalogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            butCatalogo.Location = new Point(82, 747);
            butCatalogo.Name = "butCatalogo";
            butCatalogo.Size = new Size(269, 68);
            butCatalogo.TabIndex = 0;
            butCatalogo.Text = "Catalogo";
            butCatalogo.UseVisualStyleBackColor = true;
            butCatalogo.Click += button1_Click;
            // 
            // butHacer_pedido
            // 
            butHacer_pedido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butHacer_pedido.Location = new Point(598, 747);
            butHacer_pedido.Name = "butHacer_pedido";
            butHacer_pedido.Size = new Size(253, 68);
            butHacer_pedido.TabIndex = 1;
            butHacer_pedido.Text = "Hacer Pedido";
            butHacer_pedido.UseVisualStyleBackColor = true;
            butHacer_pedido.Click += button2_Click;
            // 
            // butSalir
            // 
            butSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butSalir.Location = new Point(1108, 747);
            butSalir.Name = "butSalir";
            butSalir.Size = new Size(256, 68);
            butSalir.TabIndex = 2;
            butSalir.Text = "Salir";
            butSalir.UseVisualStyleBackColor = true;
            butSalir.Click += butSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(317, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(864, 573);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Pantalla_De_Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1434, 878);
            Controls.Add(pictureBox1);
            Controls.Add(butSalir);
            Controls.Add(butHacer_pedido);
            Controls.Add(butCatalogo);
            Name = "Pantalla_De_Inicio";
            Opacity = 0.9D;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butCatalogo;
        private Button butHacer_pedido;
        private Button butSalir;
        private PictureBox pictureBox1;
    }
}