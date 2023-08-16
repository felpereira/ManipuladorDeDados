using System;

namespace ManipuladorDeDados
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<string> listaArquivos = new();

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog1.FileNames)
                {
                    listaArquivos.Add(file);
                    rtbArquivos.Text = rtbArquivos.Text + file + "\n";
                }
            }
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbArquivos.Text))
            {
                MessageBox.Show("Selecione Arquivos");
            }

            if (string.IsNullOrEmpty(rtbFiltrar.Text))
            {
                MessageBox.Show("Selecione um Filtro");
            }

            string[] linesArray = rtbFiltrar.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            var lista = new List<string>(linesArray);

            lista.RemoveAll(string.IsNullOrEmpty);

            foreach (var item in listaArquivos)
            {
                var diretorio = Path.GetDirectoryName(item);
                var nomeArquivo = Path.GetFileName(item);

                using var sw = new StreamWriter(diretorio + "\\filtrado" + nomeArquivo);
                using var file = new StreamReader(item);
                string? line;

                while ((line = file.ReadLine()) != null)
                {
                    var shouldContinue = false;

                    foreach (var filtros in lista)
                    {
                        if (line.Contains(filtros))
                        {
                            shouldContinue = true;
                            break;
                        }
                    }

                    if (shouldContinue)
                    {
                        continue;
                    }

                    sw.WriteLine(line);
                }
            }

        }
    }
}