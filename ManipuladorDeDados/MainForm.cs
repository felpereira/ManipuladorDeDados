using System;
using System.Text.RegularExpressions;

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
            var total = 0;

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

                using var sw = new StreamWriter(diretorio + "\\filtrado1" + nomeArquivo);
                using var file = new StreamReader(item);
                string? line;

                while ((line = file.ReadLine()) != null)
                {
                    var shouldContinue = false;

                    foreach (var filtros in lista)
                    {
                        if (line.Contains(filtros))
                        {
                            break;
                        }

                        shouldContinue = true;
                    }

                    //var valor = line.Substring(11, 10);

                    //var valorFinal = ApenasNumeros(valor);

                    //total += Convert.ToInt32(valorFinal);

                    if (shouldContinue)
                    {
                        continue;
                    }

                    sw.WriteLine(line);
                }

                sw.WriteLine("TOTAL: " + total);
            }

            string ApenasNumeros(string str)
            {
                var apenasDigitos = new Regex(@"[^\d]");
                return apenasDigitos.Replace(str, "");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var informacoes = new Informacoes();
            informacoes.ShowDialog();
        }
    }
}