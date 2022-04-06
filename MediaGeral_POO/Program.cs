using System;

namespace MediaGeral_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mudar titulo Console
            Console.Title = "## Média Geral dos Alunos ##";

            // Perguntas
            Console.WriteLine("Quantos alunos?");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Objeto derivado da classe alunos
            Aluno[] alunos = new Aluno[nAlunos];

            // Loop para obter nome do aluno e quantidade de provas
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();

                Console.Write($"Aluno #{(i + 1)} Nome..: ");
                string nome = Console.ReadLine();

                Console.Write($"Aluno #{(i + 1)} Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine($"Insira as notas do aluno {nome}");
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            // Percorrer array de alunos e imprimir o nome e média de cada aluno
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Média: {aluno.Media}");

                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            // Calculo do resultado final
            double resultadoFinal = (mediaGeral / alunos.Length);

            Console.WriteLine($"Média geral dos alunos: {resultadoFinal}");

            Console.ReadKey();


        }
    }
}