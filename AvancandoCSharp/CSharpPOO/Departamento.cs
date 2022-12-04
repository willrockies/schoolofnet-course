using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{

    //agregação
    // de certa forma, agregação é muito semelhante a Associação, porem um objeto é proprietario de outro objeto, mas mesmo assim não há dependência

    class Departamento
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;

        }

        public List<Professor> professores = new List<Professor>();

        private Escola _escola = new Escola();
        public Escola setEscola
        {
            get => _escola;
            set => _escola = value;
        }



        public void addProfessores(Professor professor)
        {
            this.professores.Add(professor);
        }

        public void ListarProfessores()
        {
            foreach (Professor professor in professores)
            {
                Console.WriteLine("Professor: {0}", professor.getNome());
            }

            Console.WriteLine("-----------");
        }
    }
}
