using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    class Candidato
    {
        public int digito;
        public int votos;
        public string cargo;
        public string nome;
        public string partido;
        public string foto;

        public Candidato(int dig, string cargo, string name, string part, string fto)
        {
            this.digito = dig;
            this.nome = name;
            this.cargo = cargo;
            this.partido = part;
            this.foto = fto;
        }

        public void VotarCandidato()
        {
            this.votos++;
        }
    }
}
