using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI2M9Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<Artigos, Pessoa> lista = new Dictionary<Artigos, Pessoa>();
            Pessoa p1 = new Pessoa("Zé", "Manel", "Masculino");



            Artigos cafe1= new Artigos("café", 0.55f);
            Artigos cafe2 = new Artigos("café", 0.60f);
            Artigos cafe3 = new Artigos("café", 0.75f);


            float total = 0;

            lista.Add(cafe1, p1);
            lista.Add(cafe2, p1);
            lista.Add(cafe3, p1);

            //Console.WriteLine(cafe.getNomeArtigo());

            foreach (KeyValuePair<Artigos, Pessoa> i in lista)
            {
                Console.WriteLine(i.Key.getNomeArtigo() + " que custa " + i.Key.getPreçoArtigo() + " foi comprado por " + i.Value.getNome());
                total = total + i.Key.getPreçoArtigo();
            }
            Console.WriteLine(total);
        }
    }
}
