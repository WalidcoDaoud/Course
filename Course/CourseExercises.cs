using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Formats.Asn1;

namespace CourseExercises
{
    public static class Exercises
    {
        public static void ExercicoUm()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static void ExercicoDois()
        {
            Console.WriteLine("Qual é a sua idade?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu sexo? \nF ou M");
            char sex = char.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura?");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Idade: {age}\nSexo: {sex}\nAltura: {height.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Digite na ordem, seu nome, sexo, idade e altura");
            string[] list = Console.ReadLine().Split(' ');
            string listName = list[0];
            char listSex = char.Parse(list[1]);
            byte listAge = byte.Parse(list[2]);
            double listHeight = double.Parse(list[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {listName} Sexo: {listSex} Idade: {listAge} Altura: {listHeight.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ExercicoTres()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome Completo: {name}\nQuantidade de quartos: {number}\nPreço do produto: {price.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] list = Console.ReadLine().Split(' ');
            string listLastName = list[0];
            int listAge = int.Parse(list[1]);
            double listHeight = double.Parse(list[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Último nome: {listLastName} Idade: {listAge} Height: {listHeight.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void ExercicoQuatro()
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine($"Raiz quadrada de {x} = {A}");
            Console.WriteLine($"Raiz quadra de {y} = {B}");
            Console.WriteLine($"Raiz quadra de 25 = {C}");

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine($"{x} elevado a {y} = {A}");
            Console.WriteLine($"{x} elevado ao quadrado = {B}");
            Console.WriteLine($"5 elevado ao quadrado = {C}");

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine($"O valor absoluto de {y} = {A}");
            Console.WriteLine($"O valor abosulto de {z} = {B}");
        }

        public static void ExercicoCinco()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raízes reais.");
                return;
            }

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"O resultado da bhaskara: {x1} e {x2}");
        }

        public static void ExercicioSeis()
        {
            string[] medidas = Console.ReadLine().Split(' ');
            if (medidas.Length != 3)
            {
                Console.WriteLine("Por favor, preencha todas as informações solicitadas (largura, comprimento e preço).");
                return;
            }
            Console.WriteLine("Digite as medidas (largura e comprimento) e o preço do terreno");
            double largura = double.Parse(medidas[0], CultureInfo.InvariantCulture);
            double comprimento = double.Parse(medidas[1], CultureInfo.InvariantCulture);
            double preco = double.Parse(medidas[2], CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double valorTotal = area * preco;
            Console.WriteLine($"A área do terreno é de: {area.ToString("F2", CultureInfo.InvariantCulture)} m² e o valor é de {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void AreaDaForma()
        {
            double baseRetangulo, alturaRetangulo, area, perimetro, diagonal;

            baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baseRetangulo * alturaRetangulo;
            perimetro = 2 * (baseRetangulo + alturaRetangulo);
            diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

            Console.WriteLine($"AREA = {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");
        }
        public static void MediaIdade()
        {
            string nomeA, nomeB;
            string[] pessoaA;
            int idadeA, idadeB;
            double mediaIdade;

            pessoaA = Console.ReadLine().Split(' ');
            nomeA = pessoaA[0];
            idadeA = int.Parse(pessoaA[1], CultureInfo.InvariantCulture);

            string[] pessoaB = Console.ReadLine().Split(' ');
            nomeB = pessoaB[0];
            idadeB = int.Parse(pessoaB[1], CultureInfo.InvariantCulture);

            mediaIdade = (double)(idadeA + idadeB) / 2.0;

            Console.WriteLine($"A idade média de {nomeA} e {nomeB} é de {mediaIdade.ToString("F1", CultureInfo.InvariantCulture)} anos");
        }
        public static void MediaCondicional()
        {
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            soma = nota1 + nota2;

            Console.WriteLine($"NOTA FINAL = {soma.ToString("F1", CultureInfo.InvariantCulture)}");

            if (soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }
        }
        public static void MenorNumero()
        {
            int a, b, c;
            string[] values;

            values = Console.ReadLine().Split(' ');
            a = int.Parse(values[0]);
            b = int.Parse(values[1]);
            c = int.Parse(values[2]);

            if (a < b && a < c)
            {
                Console.WriteLine($"MENOR = {a}");
            }
            else if (b < c)
            {
                Console.WriteLine($"MENOR = {b}");
            }
            else
            {
                Console.WriteLine($"MENOR = {c}");
            }
        }
        public static void CobrarPlanoExtra()
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine($"Valor a pagar: R$ {conta.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void DiasDaSemanaCondicinal()
        {
            int x;
            string dia;

            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sábado";
                    break;
                default:
                    dia = "valor inválido!";
                    break;
            }

            Console.WriteLine($"Dia da semana: {dia}");
        }
        public static void LerVariosNumerosComWhile()
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;
            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        public static void CelsiusToFahrenheit()
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine($"Equivalente em Fahrenheit: {F.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.Write("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
        }

    }
}
