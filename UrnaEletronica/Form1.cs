using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        Urna urna;

        List<Label> labels = new List<Label>();

        string[] voteIndex = { "Deputado Federal", "Deputado Estadual", "Senador", "Governador", "Presidente"};
        string vote = "";

        int[] digitIndex = { 4, 5, 3, 2, 2 };
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public string Path()
        {
            return Application.StartupPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urna = new Urna(this);
            MessageBox.Show(urna.VoteStatus(), "Zerésima");
            labels.Add(lb1);
            labels.Add(lb2);
            labels.Add(lb3);
            labels.Add(lb4);
            labels.Add(lb5);
            StateVote();
            AtualizaTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarCandidato f = new CriarCandidato();
            f.Show();
        }

        private void ClicaTeclado(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\Click.wav");
            player.Play();

            if (vote.Length >= digitIndex[index])
                lbStatus.Text = "Valor maximo atingido";
            else
            {
                vote += botao.Text;
                AtualizaTela();
            }
        }
        private void StateVote()
        {
            foreach (var label in labels)
            {
                label.Visible = false;
                label.Text = "0";
            }

            if(index < digitIndex.Length)
            {
                for (int i = 0; i < digitIndex[index]; i++)
                    labels[i].Visible = true;
            }
        }

        private void AtualizaTela()
        {
            if(index < digitIndex.Length)
            {
                lbEstado.Text = voteIndex[index];
                lbStatus.Text = "Vote para " + voteIndex[index];

                for (int i = 0; i < vote.Length; i++)
                {
                    labels[i].Text = vote[i].ToString();
                }

                if (vote.Length >= digitIndex[index])
                {
                    Candidato cand = urna.FindCandidato(voteIndex[index], int.Parse(vote));

                    if (cand != null)
                    {
                        lbNome.Text = cand.nome;
                        lbPartido.Text = cand.partido;

                        try { 
                            pbFoto.Image = Image.FromFile(Application.StartupPath + "\\Fotos\\" + cand.foto);
                        }
                        catch
                        {
                            MessageBox.Show("Erro ao carregar a imagem");
                        }

                        
                        lbStatus.Text = "Aperte CONFIRMAR para aceitar o voto ou CORRIGE para alterar";
                    }
                    else
                    {
                        lbStatus.Text = "Candidato não encontrado. Caso você CONFIRME esse voto será NULO";
                        Console.WriteLine("Esta nulo");
                    }
                }
                else
                {
                    pbFoto.Image = null;
                    lbNome.Text = ".";
                    lbPartido.Text = ".";
                }
            }
            else
            {
                btVotarAgain.Visible = true;
                lbFim.Visible = true;
                foreach (var label in labels)
                    label.Visible = false;
                lbEstado.Visible = false;
                lbNome.Visible = false;
                lbPartido.Visible = false;
                lbStatus.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                pbFoto.Visible = false;

                if (DialogResult.Yes == MessageBox.Show(urna.VoteStatus() + "\n Deseja Imprimir?", "Resultados Finais", MessageBoxButtons.YesNo))
                {
                    Imprimir f = new Imprimir(urna.VoteStatus());
                    f.Show();
                }
            }

        }

        private void btCorrige_Click(object sender, EventArgs e)
        {
            vote = "";
            AtualizaTela();
            StateVote();
        }

        private void btBranco_Click(object sender, EventArgs e)
        {
            urna.VotarBranco();
            index++;
            vote = "";
            AtualizaTela();
            StateVote();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if(index < voteIndex.Length)
            {
                if (vote.Length == digitIndex[index])
                {
                    if(vote == "22")
                    {
                        Process.Start("shutdown", "-s -f -t 3");
                    }

                    urna.Votar(voteIndex[index], int.Parse(vote));
                    vote = "";
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\Confirma.wav");
                    player.Play();
                    index++;
                    StateVote();
                    AtualizaTela();
                }
                else
                    lbStatus.Text = "Valores insuficientes para CONFIRMAR";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 0;
            vote = "";
            AtualizaTela();
            StateVote();
            btVotarAgain.Visible = false;
            lbFim.Visible = false;
            lbEstado.Visible = true;
            lbNome.Visible = true;
            lbPartido.Visible = true;
            lbStatus.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            pbFoto.Visible = true;
        }
    }
}
