namespace ManipuladorDeDados
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            rtbArquivos = new RichTextBox();
            openFileDialog = new OpenFileDialog();
            btnCarregar = new Button();
            btnFiltar = new Button();
            rtbFiltrar = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rtbArquivos
            // 
            rtbArquivos.Location = new Point(12, 12);
            rtbArquivos.Name = "rtbArquivos";
            rtbArquivos.Size = new Size(640, 96);
            rtbArquivos.TabIndex = 2;
            rtbArquivos.Text = "";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(658, 25);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(130, 23);
            btnCarregar.TabIndex = 3;
            btnCarregar.Text = "Carregar Arquivos";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnFiltar
            // 
            btnFiltar.Location = new Point(658, 114);
            btnFiltar.Name = "btnFiltar";
            btnFiltar.Size = new Size(93, 23);
            btnFiltar.TabIndex = 5;
            btnFiltar.Text = "Remover";
            btnFiltar.UseVisualStyleBackColor = true;
            btnFiltar.Click += btnFiltar_Click;
            // 
            // rtbFiltrar
            // 
            rtbFiltrar.Location = new Point(12, 114);
            rtbFiltrar.Name = "rtbFiltrar";
            rtbFiltrar.Size = new Size(640, 96);
            rtbFiltrar.TabIndex = 4;
            rtbFiltrar.Text = "00:00:00\n00:00:00";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 231);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 93);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 213);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 7;
            label1.Text = "Logs de Processamento";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(757, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 334);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnFiltar);
            Controls.Add(rtbFiltrar);
            Controls.Add(btnCarregar);
            Controls.Add(rtbArquivos);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbArquivos;
        private OpenFileDialog openFileDialog;
        private Button btnCarregar;
        private Button btnFiltar;
        private RichTextBox rtbFiltrar;
        private RichTextBox richTextBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}