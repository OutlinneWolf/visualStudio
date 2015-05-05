using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSI2M9Teste
{
    class Pessoa
    {
        //Atributos
        private string nome;
        private string apelido;
        private string morada;
        private int idade;
        private int bi;
        private string dataNascimento;
        private int telemovel;
        private long niss;
        private string sexo;

        

        //Construtores
        public Pessoa(string nome, string apelido)  //Recebe e trata a data de nascimento
        {
            this.nome = nome;
            this.apelido = apelido;
        }

        public Pessoa(string nome, string apelido, string sexo)  //Recebe e trata a data de nascimento
        {
            this.nome = nome;
            this.apelido = apelido;
            this.sexo = sexo;
        }

        //Metodos 
        public void setAdress(string m)  //Recebe a morada
        {
            morada = m;
        }

        public void setAge(int i)        //Recebe a idade
        {
            idade = i;
        }

        public void setBi(int b)         //Recebe o Bi
        {
            bi = b;
        }

        public void setNiss(long n)      //Recebe o niss
        {
            niss = n;
        }

        public void setSexo(string sexo) //Recebe o sexo
        {
             this.sexo = sexo; 
        }


        public void setTelemovel(int t)  //Recebe o telemovel
        {
            telemovel = t;
        }

        /*******   Devoluçao dos atributos     ******/

        public string getNome()      //Devolve o nome
        {
            return nome;
        }

        public string getApelido()   //Devolve o apelido
        {
            return apelido;
        }

        public int getIdade()       //Devolve a idade
        {
            return idade;
        }

        public string getMorada()   //Devolve a morada
        {
            return morada;
        }

        public int getBi()          //Devolve o BI
        {
            return bi;
        }

        public long getNiss()       //Devolve o Niss
        {
            return niss;
        }

        public string getDataNasc()   //Devolve dataNascimento
        {
            return dataNascimento;
        }

        public int getTelemovel()    //Devolve telemovel
        {
            return telemovel;
        }

        public string getSexo()     //devolve o sexo
       {
            return sexo;
       }



        /*public void beberCafé(Artigos cafe)
        {
            Console.WriteLine("Estou a beber um " + cafe.getNomeArtigo());
        }*/


    }
}
