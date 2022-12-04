using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    class Escola
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;

        }

        public List<Departamento> departamentos = new List<Departamento>();

        public void AddDepartamento(Departamento departamentos)
        {
            this.departamentos.Add(departamentos);
        }

        public void ListarDepartamentos()
        {
            foreach (Departamento departamento in this.departamentos)
            {
                Console.WriteLine("Departamentos", departamento.Nome);
            }
            Console.WriteLine("-----------");
        }


        // composição
        // A composição é uma agregação que contém dependencias entre os objetos

    }
}
