using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    class Aluno : Pessoa
    {

        private string matricula;
        private bool presente;
        private DateTime birthday;
        public List<Professor> professores = new List<Professor>();

        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }

        public bool Presente
        {
            get => presente;
            set => presente = value;
        }

        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value > DateTime.Now ? throw new Exception("Data errada") : value;
        }

        public void EstaPresente(bool presenca)
        {
            this.presente = presenca;
            if (presenca)
            {
                Console.WriteLine("Esta presente");
            }
            else
            {
                Console.WriteLine("Esta com falta");
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome: {0}", this.getNome());
            Console.WriteLine("Idade: {0}", this.getIdade());
            Console.WriteLine("Ano de nascimento: {0}", this.Birthday);
            Console.WriteLine("Matricula: {0}", this.Matricula);
            Console.WriteLine("presenca: {0}", this.Presente);
            Console.WriteLine("presenca: {0}", this.ResponderPresenca());
            Console.WriteLine("-----------");

        }
        public string ResponderPresenca()
        {
            if (this.presente)
            {
                return "PRESENTE!!!";
            }
            else
            {
                return "...";
            }
        }

        public void addProfessor(Professor professor)
        {

            this.professores.Add(professor);
        }
}
}
