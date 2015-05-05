using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI2M9Teste
{
    class Artigos
    {
        private float preçoArtigo;
        private string nomeArtigo;
        private bool consumido;
        

        //Construtores-------------------------
        public Artigos(string nomeArtigo, float preçoArtigo)
        {
            this.nomeArtigo = nomeArtigo;
            this.preçoArtigo = preçoArtigo;
        }

        public Artigos()
        {
            this.nomeArtigo = "Café";
            this.preçoArtigo = 0.55f;
        }

        //Métodos-----------------------------
        private void setNomeArtigo(string nomeArtigo)
        {
            if (string.IsNullOrEmpty(nomeArtigo))
            {
                Console.WriteLine("o nome e nulo ou nao tem nada lá dentro");
            }
            else
            {
                this.nomeArtigo = nomeArtigo;
            }
            
        }

        public string getNomeArtigo()
        {
            return nomeArtigo;
        }

        private void setPreçoArtigo(float preçoArtigo)
        {
            if (preçoArtigo == 0)
            {
                Console.WriteLine("Nao tem preço");
            }
            else
            {
                this.preçoArtigo = preçoArtigo;
            }
            
        }

        public float getPreçoArtigo()
        {
            return preçoArtigo;
        }


    }
}
