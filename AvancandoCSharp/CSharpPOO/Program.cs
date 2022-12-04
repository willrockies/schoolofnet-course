using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharpPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento humanas = new Departamento();
            humanas.Nome = "Departamento de humanas";

            Departamento exatas = new Departamento();
            exatas.Nome = "Departamento de Exatas";

            Aluno joazinho = new Aluno();
            //joazinho.nome = "João da Silva";
            //joazinho.idade = 12;
            joazinho.setNome("João da Silva");
            joazinho.setIdade(12);
            joazinho.Matricula = "ABC123";
            joazinho.Birthday = new DateTime(1988, 04, 21);
            //joazinho.Birthday = new DateTime(2022, 11, 17);
            joazinho.Presente = false;
            joazinho.Imprimir();
            Aluno ritinha = new Aluno();
            //ritinha.nome = "Rita de Souza";
            //ritinha.idade = 11;
            ritinha.setNome("Rita de Souza");
            ritinha.setIdade(11);
            ritinha.Matricula = "xyz890";
            ritinha.Presente = true;
            ritinha.Imprimir();

            Professor prof = new Professor();
            //prof.nome = "Jose da Silva";
            //prof.idade = 35;
            prof.setNome("Jose da Silva");
            prof.setIdade(48);
            prof.ValorHora = 30;
            prof.Tipo = 1;
            Console.WriteLine("Salario: {0:c}", prof.CalcularSalarioFinal(120));
            prof.Imprimir();
            prof.addAluno(joazinho);
            prof.addAluno(ritinha);
            prof.ImprimirAlunos();
            prof.setDepartamento = exatas;


            Professor profMaria = new Professor();

            profMaria.setNome("Maria Josivania");
            profMaria.setIdade(35);
            profMaria.ValorHora = 30;
            profMaria.Tipo = 2;
            profMaria.Bonus = 15;
            Console.WriteLine("Salario: {0:c}", profMaria.CalcularSalarioFinal(120));
            profMaria.Imprimir();
            profMaria.addAluno(ritinha);
            profMaria.ImprimirAlunos();
            profMaria.setDepartamento = humanas;

            humanas.addProfessores(profMaria);
            exatas.addProfessores(prof);


            joazinho.addProfessor(prof);
            

            Console.ReadLine();


            /*    List<Int32> li = new List<int>();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                for (int i = 0; i < 10000; i++)
                {
                    li.Add(i);
                }
                sw.Stop();
                Console.Write("Usando um Arraylist(Object)  -> tempo gasto : " + sw.ElapsedTicks + "\n");
                //-------------------------------------------------------------------------------------------------------
                sw.Reset();
                sw.Start();
                Int32[] a = new Int32[10000];
                for (int i = 0; i < 10000; i++)
                {
                    a[i] = i;
                }
                sw.Stop();
                Console.Write("Usando Array de Inteiros (Integer Array)  -> tempo gasto : " + sw.ElapsedTicks);
                //---------------------------------------------------------------------------------------------------------
                Console.ReadLine();*/

        }
    }
}
