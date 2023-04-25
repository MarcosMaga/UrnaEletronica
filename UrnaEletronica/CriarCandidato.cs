using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class CriarCandidato : Form
    {
        public CriarCandidato()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                bool ok = true;
                string digito = textBox1.Text;
                string nome = textBox2.Text;
                string partido = textBox3.Text;
                string foto = label5.Text;
                string cargo = "";

                try
                {
                    int.Parse(digito);
                    switch (digito.Length)
                    {
                        case 5: cargo = "Deputado Estadual"; break;
                        case 4: cargo = "Deputado Federal"; break;
                        case 3: cargo = "Senador"; break;
                        case 2:
                            if (DialogResult.Yes == MessageBox.Show("Seu candidato é presidenciavel? Caso não, ele será considerado Governador", "Confirmação", MessageBoxButtons.YesNo))
                                cargo = "Presidente";
                            else
                                cargo = "Governador";
                            break;
                        default: MessageBox.Show("Digito invalido"); ok = false; break;
                    }
                }
                catch
                {
                    ok = false;
                    MessageBox.Show("Valor de Digito invalido");
                }

                if(ok)
                {
                    StreamWriter x;
                    x = File.CreateText(Application.StartupPath + "\\Candidatos\\" + nome + ".txt");
                    x.WriteLine(digito);
                    x.WriteLine(cargo);
                    x.WriteLine(nome);
                    x.WriteLine(partido);
                    x.WriteLine(foto);
                    x.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    label5.Text = "Local:";
                }

            }
            else
                MessageBox.Show("Dados incompletos");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                string[] arch = open.FileName.Split('\\');
                label5.Text = arch[arch.Length - 1];

                try
                {
                    File.Copy(open.FileName, Application.StartupPath + "\\Fotos\\" + arch[arch.Length-1], true);
                }
                catch
                {
                    MessageBox.Show("Erro ao copiar a imagem");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
