using System;

namespace Exercicio012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir o IMC - Índice de Massa Corporal!");
            Console.ReadKey();
            Console.WriteLine("Digite o primeiro nome...");
            string nomePrimeiro = Console.ReadLine();
            Console.WriteLine("Digite a idade do primeiro nome...");
            decimal idadePrimeiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do primeiro nome...");
            decimal alturaPrimeiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso do primeiro nome...");
            decimal pesoPrimeiro = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo nome...");
            string nomeSegundo = Console.ReadLine();
            Console.WriteLine("Digite a idade do segundo nome...");
            decimal idadeSegundo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do segundo nome...");
            decimal alturaSegundo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso do segundo nome...");
            decimal pesoSegundo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro nome...");
            string nomeTerceiro = Console.ReadLine();
            Console.WriteLine("Digite a idade do terceiro nome...");
            decimal idadeTerceiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do terceiro nome...");
            decimal alturaTerceiro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso do terceiro nome...");
            decimal pesoTerceiro = decimal.Parse(Console.ReadLine());

            decimal imc;
            imc = IMC(pesoPrimeiro, alturaPrimeiro);

            Console.WriteLine("O IMC do " + nomePrimeiro + " é... " + imc + " e você está: " + ClassificacaoIMC(imc));
            
            imc = IMC(pesoSegundo, alturaSegundo);
            Console.WriteLine("O IMC do " + nomeSegundo + " é... " + imc + " e você está: " + ClassificacaoIMC(imc));

            imc = IMC(pesoTerceiro, alturaTerceiro);
            Console.WriteLine("O IMC do " + nomeTerceiro + " é... " + imc + " e você está: " + ClassificacaoIMC(imc));
        }
        static decimal IMC(decimal peso, decimal altura)
        {
            return Math.Round((peso / (altura * altura)),2);
        }

        static string ClassificacaoIMC(decimal imc)
        {
            string classificacao = "";
            
            if (imc < 18.5m)
            {
                classificacao = "Abaixo do peso...";
            }
            else if ((imc >= 18.5m) && (imc <= 24.9m))
            {
                classificacao = "Peso normal...";
            }
            else if ((imc >= 25.0m) && (imc <= 29.9m))
            {
                classificacao = "Sobrepeso...";
            }
            else if  ((imc >= 30.0m) && (imc <= 34.9m))
            {
                classificacao = "Obesidade Grau I...";
            }
            else if  ((imc >= 35.0m) && (imc <= 39.9m))
            {
                classificacao = "Obesidade Grau II...";
            }
             else if  (imc >= 40.0m)
            {
                classificacao = "Obesidade Grau III ou Mórbida...";
            }
            return classificacao;
        }
    }


}
