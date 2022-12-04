using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    class Professor : Pessoa
    {
        private double _valorHora;
        private int _tipo;
        private int _bonus;
        public List<Aluno> alunos = new List<Aluno>();
        public Departamento departamento = new Departamento();

        public Departamento setDepartamento
        {
            get => departamento;
            set => departamento = value;
        }
        public double ValorHora
        {
            get => _valorHora;
            set => _valorHora = value;
        }

        public int Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }


        public int Bonus
        {
            get => _bonus;
            set => _bonus = value;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome: {0}", this.getNome());
            Console.WriteLine("Idade: {0}", this.getIdade());
            Console.WriteLine("Presença: {0}", this.ResponderPresenca());
        }

        public string ResponderPresenca()
        {
            return "Bateu o ponto";
        }

        public double CalcularSalario(int horas)
        {
            return this._valorHora * horas;
        }
        public double CalcularSalario(int horas, double bonificacao)
        {
            double valor = this.ValorHora * horas;
            double porcentagem = bonificacao / 100;
            return valor + (valor * porcentagem);
        }

        public double CalcularSalarioFinal(int horas)
        {
            if (this.Tipo == 1)
            {
                return this.CalcularSalario(horas);
            }
            else
            {
                var bonus = this.Bonus;
                return this.CalcularSalario(horas, bonus);
            }
        }

        // Associação 
        // Uma classe pode se relacionar com outra classe, na qual a relação é dada de forma eventual, e uma classe existe independente da outra
        public void addAluno(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }

        public void ImprimirAlunos()
        {
            Console.WriteLine("-----------");
            foreach (Aluno aluno in this.alunos)
            {
                Console.WriteLine("Alunos: {0}", aluno.getNome());

            }
            Console.WriteLine("-----------");
        }

    }
}
