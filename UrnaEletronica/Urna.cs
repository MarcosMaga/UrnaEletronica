using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UrnaEletronica
{
    class Urna
    {
        int votosNulos = 0;
        int votosBrancos = 0;
        List<Candidato> candidatos = new List<Candidato>();
        private void LerCandidatos(string path)
        {
            path += "\\Candidatos";
            string[] paths = Directory.GetFiles(path, "*.txt");

            foreach(var candidato in paths)
            {
                StreamReader x;
                x = File.OpenText(candidato);
                string digito = x.ReadLine().Trim();
                string cargo = x.ReadLine();
                string nome = x.ReadLine().Trim();
                string partido = x.ReadLine().Trim();
                string foto = x.ReadLine().Trim();
                Candidato newCandidato = new Candidato(int.Parse(digito), cargo, nome, partido, foto);
                candidatos.Add(newCandidato);
                x.Close();
            }
        }
        public Urna(Form1 frm)
        {
            LerCandidatos(frm.Path());
        }

        public void Votar(string carg, int dig)
        {
            bool find = false;
            for(int i=0; i < candidatos.Count; i++)
            {
                if (candidatos[i].digito == dig && candidatos[i].cargo == carg)
                {
                    candidatos[i].VotarCandidato();
                    find = true;
                    break;
                }
            }

            if (!find)
                votosNulos++;
        }

        public void VotarBranco()
        {
            votosBrancos++;
        }

        public Candidato FindCandidato(string carg, int dig)
        {
            foreach(var candidato in candidatos)
            {
                if (candidato.digito == dig && candidato.cargo == carg)
                    return candidato;
            }

            return null;
        }

        public string VoteStatus()
        {
            string message = "";

            foreach (var candidato in candidatos)
            {
                message += "Nome: " + candidato.nome + "\n";
                message += "Digito: " + candidato.digito + "\n";
                message += "Votos: " + candidato.votos + "\n";
                message += "=========================================\n";
            }
            message += "Votos em Branco: " + votosBrancos.ToString() + "\n";
            message += "Votos Nulos: " + votosNulos.ToString() + "\n";
            return message;
        }
    }
}
