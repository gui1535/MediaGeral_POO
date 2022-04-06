using System;

namespace MediaGeral_POO
{
    class Aluno
    {
        
        public string Nome { get; private set; } // Só posso receber valores

        private double[] Notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            Notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.Write($"Nota #{(i+1)}: ");
                Notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                total += Notas[i];

            }
            return total / Notas.Length;
        }
    }
}