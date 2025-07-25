using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;
using System.Security.Cryptography;

namespace BeecrowdExercises
{
    public static class ResolvedExercises
    {
        public static void ExercicioAreaRaio()
        {
            double pi, raio, raioQuadrado, area;

            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            raioQuadrado = Math.Pow(raio, 2);
            area = raioQuadrado * pi;

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        public static void ExercicioSoma()
        {
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine($"SOMA = {SOMA}");
        }

        public static void ExericioMultiplicacao()
        {
            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;

            Console.WriteLine($"PROD = {PROD}");
        }

        public static void ExercicioSubstracao()
        {
            int A, B, C, D, Difference;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            Difference = (A * B) - (C * D);

            Console.WriteLine($"DIFERENCA = {Difference}");
        }

        public static void SalarioHora()
        {
            int A, B;
            float C, D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            D = B * C;
            Console.WriteLine($"NUMBER = {A}");
            Console.WriteLine($"SALARY = U$ {D.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void Mercadoria()
        {
            int CodigoItem1, CodigoItem2, QuantidadeItem1, QuantidadeItem2;
            float PrecoItem1, PrecoItem2, TotalItem1, TotalItem2, Total;

            string[] Compra1 = Console.ReadLine().Split(' ');
            string[] Compra2 = Console.ReadLine().Split(' ');

            CodigoItem1 = int.Parse(Compra1[0]);
            QuantidadeItem1 = int.Parse(Compra1[1]);
            PrecoItem1 = float.Parse(Compra1[2], CultureInfo.InvariantCulture);
            TotalItem1 = PrecoItem1 * QuantidadeItem1;

            CodigoItem2 = int.Parse(Compra2[0]);
            QuantidadeItem2 = int.Parse(Compra2[1]);
            PrecoItem2 = float.Parse(Compra2[2], CultureInfo.InvariantCulture);
            TotalItem2 = PrecoItem2 * QuantidadeItem2;

            Total = TotalItem1 + TotalItem2;

            Console.WriteLine($"VALOR A PAGAR: R$ {Total.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ConsumoDeGasolina()
        {
            int X;
            float Y, Distance;

            X = int.Parse(Console.ReadLine());
            Y = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Distance = X / Y;

            Console.WriteLine($"{Distance.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }

        public static void DistanciaDoCarro()
        {
            int km, time;

            km = int.Parse(Console.ReadLine());
            time = km * 2;

            Console.WriteLine($"{time} minutos");
        }
        public static void GasolinaGasta()
        {
            int km = 12;
            float time, kmH;
            float total;

            time = float.Parse(Console.ReadLine());
            kmH = float.Parse(Console.ReadLine());
            total = (time / km) * kmH;

            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture));

        }
        public static void Media()
        {
            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

        }
        public static void MediaDois()
        {
            double A, B, C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
        public static void SalaryBonus()
        {
            string sellerName;
            double fixedSalary, totalSales, finalSalary;

            sellerName = Console.ReadLine();
            fixedSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            finalSalary = (totalSales * 0.15) + fixedSalary;

            Console.WriteLine($"TOTAL = R$ {finalSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void SphereVolume()
        {
            double radius, volume, pi = 3.14159;

            radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        public static void Area()
        {
            string[] values;
            double A, B, C, areaTriangle, areaCircle, areaTrapeze, areaSquare, areaRectangle, pi = 3.14159;

            values = Console.ReadLine().Split(' ');
            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);

            areaTriangle = (C * A) / 2;
            areaCircle = pi * Math.Pow(C, 2);
            areaTrapeze = ((A + B) / 2) * C;
            areaSquare = Math.Pow(B, 2);
            areaRectangle = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCircle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaSquare.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRectangle.ToString("F3", CultureInfo.InvariantCulture)}");
        }
        public static void GreatestNumber()
        {
            int A, B, C, greatestNumber, greatestNumberAB;
            string[] numbers;

            numbers = Console.ReadLine().Split(' ');
            A = int.Parse(numbers[0]);
            B = int.Parse(numbers[1]);
            C = int.Parse(numbers[2]);

            greatestNumberAB = (A + B + Math.Abs(A - B)) / 2;
            greatestNumber = (greatestNumberAB + C + Math.Abs(greatestNumberAB - C)) / 2;

            Console.WriteLine($"{greatestNumber} eh o maior");
        }
        public static void DistanceBetweenTwoPoints()
        {
            double x1, y1, x2, y2, distance;
            string[] valuesX, valuesY;

            valuesX = Console.ReadLine().Split(' ');
            x1 = double.Parse(valuesX[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valuesX[1], CultureInfo.InvariantCulture);

            valuesY = Console.ReadLine().Split(' ');
            x2 = double.Parse(valuesY[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valuesY[1], CultureInfo.InvariantCulture);

            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
        }
        public static void SecondsToFullTime()
        {
            int N, hours, minutes, seconds, rest;

            N = int.Parse(Console.ReadLine());

            hours = N / 3600;
            rest = N % 3600;
            minutes = rest / 60;
            seconds = rest % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
        public static void BankNotes()
        {
            int noteValue, quotient, note, rest;

            noteValue = int.Parse(Console.ReadLine());
            Console.WriteLine(noteValue);

            rest = noteValue;

            note = 100;
            quotient = rest / note;
            Console.WriteLine($"{quotient} nota(s) de R$ {note},00");
            rest = rest % note;

            note = 50;
            quotient = rest / note;
            Console.WriteLine($"{quotient} nota(s) de R$ {note},00");
            rest = rest % note;

            note = 20;
            quotient = rest / note;
            Console.WriteLine($"{quotient} nota(s) de R$ {note},00");
            rest = rest % note;

            note = 10;
            quotient = rest / note;
            Console.WriteLine($"{quotient} nota(s) de R$ {note},00");
            rest = rest % note;

            note = 5;
            quotient = rest / note;
            Console.WriteLine($"{quotient} nota(s) de R$ {note},00");
            rest = rest % note;

            note = 2;
            quotient = rest / note;
            Console.WriteLine($"{quotient} nota(s) de R$ {note},00");
            rest = rest % note;

            Console.WriteLine($"{rest} nota(s) de R$ 1,00");
        }
        public static void AgeInDays()
        {
            int age, year, month, day, rest;
            age = int.Parse(Console.ReadLine());

            year = age / 365;
            rest = age % 365;
            month = rest / 30;
            day = rest % 30;

            Console.WriteLine($"{year} ano(s)");
            Console.WriteLine($"{month} mes(es)");
            Console.WriteLine($"{day} dia(s)");
        }
        public static void FormulaDeBhaskara()
        {
            double A, B, C, delta, r1, r2;
            string[] values;

            values = Console.ReadLine().Split(' ');
            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }
        public static void SelectionTest()
        {
            int A, B, C, D, sumAB, sumCD;

            string[] values;

            values = Console.ReadLine().Split(' ');
            A = int.Parse(values[0]);
            B = int.Parse(values[1]);
            C = int.Parse(values[2]);
            D = int.Parse(values[3]);

            sumAB = A + B;
            sumCD = C + D;

            if (
                B > C && D > A && B > A && sumCD > sumAB && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
        public static void Snack()
        {
            int x, y;
            double total;
            string[] values;

            values = Console.ReadLine().Split(' ');

            x = int.Parse(values[0]);
            y = int.Parse(values[1]);

            switch (x)
            {
                case 1:
                    total = y * 4.00;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 2:
                    total = y * 4.50;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 3:
                    total = y * 5.00;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 4:
                    total = y * 2.00;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    total = y * 1.50;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
            }
        }
        public static void Multiples()
        {
            int x, y;
            string[] values;

            values = Console.ReadLine().Split(' ');
            x = int.Parse(values[0]);
            y = int.Parse(values[1]);

            if (x % y == 0 || y % x == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
        public static void GameTime()
        {
            int start, end, duration;
            string[] values;

            values = Console.ReadLine().Split(' ');
            start = int.Parse(values[0]);
            end = int.Parse(values[1]);

            if (start < end)
            {
                duration = end - start;
            }
            else
            {
                duration = 24 - start + end;
            }

            Console.WriteLine("O JOGO DUROU " + duration + " HORA(S)");
        }
        public static void SalaryIncrease()
        {
            double salary, salaryIncrease, salaryTotal, salaryPercentage;

            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary > 0 && salary <= 400)
            {
                salaryPercentage = 15.0;

            }
            else if (salary >= 400.01 && salary <= 800)
            {
                salaryPercentage = 12.0;

            }
            else if (salary >= 800.01 && salary <= 1200)
            {
                salaryPercentage = 10.0;

            }
            else if (salary >= 1200.01 && salary <= 2000)
            {
                salaryPercentage = 7.0;

            }
            else
            {
                salaryPercentage = 4.0;

            }

            salaryIncrease = salary * salaryPercentage / 100;
            salaryTotal = salary + salaryIncrease;

            Console.WriteLine("Novo salario: " + salaryTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + salaryIncrease.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + salaryPercentage.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
        public static void Interval()
        {
            double interval;

            interval = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (interval < 0.0 || interval > 100.00)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (interval <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (interval <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (interval <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
        public static void Average()
        {
            float n1, n2, n3, n4, average, aditionalExam, newAverage;
            string[] values;

            values = Console.ReadLine().Split(' ');
            n1 = float.Parse(values[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(values[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(values[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(values[3], CultureInfo.InvariantCulture);

            average = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (average == 4.85f)
            {
                average = 4.8f;
            }

            Console.WriteLine($"Media: {average.ToString("F1", CultureInfo.InvariantCulture)}");

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                aditionalExam = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                newAverage = (average + aditionalExam) / 2;
                Console.WriteLine($"Nota do exame: {aditionalExam.ToString("F1", CultureInfo.InvariantCulture)}");

                if (newAverage >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + newAverage.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        public static void CoordinatesOfPoint()
        {
            float x, y;
            string[] values;

            values = Console.ReadLine().Split(' ');
            x = float.Parse(values[0], CultureInfo.InvariantCulture);
            y = float.Parse(values[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
        public static void TriangleTypes()
        {
            double n1, n2, n3, a, b, c;
            string[] values;

            values = Console.ReadLine().Split(' ');
            n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(values[2], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3)
            {
                a = n1;
                if (n2 > n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n2;
                }
            }
            else if (n2 > n3)
            {
                a = n2;
                if (n1 > n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else
            {
                a = n3;
                if (n1 > n2)
                {
                    b = n1;
                    c = n2;
                }
                else
                {
                    b = n2;
                    c = n1;
                }
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
        public static void GameTimeWithMinutes()
        {
            int startHour, startMinute, finalHour, finalMinute, instanceStart, instanceFinal, duration, durationHours, durationMinutes;
            string[] values;

            values = Console.ReadLine().Split(' ');
            startHour = int.Parse(values[0]);
            startMinute = int.Parse(values[1]);
            finalHour = int.Parse(values[2]);
            finalMinute = int.Parse(values[3]);

            instanceStart = startHour * 60 + startMinute;
            instanceFinal = finalHour * 60 + finalMinute;

            if (instanceStart < instanceFinal)
            {
                duration = instanceFinal - instanceStart;
            }
            else
            {
                duration = (24 * 60 - instanceStart) + instanceFinal;
            }

            durationHours = duration / 60;
            durationMinutes = duration % 60;

            Console.WriteLine($"O JOGO DUROU {durationHours} HORA(S) E {durationMinutes} MINUTO(S)");
        }
        public static void Animal()
        {
            string wordOne, wordTwo, wordThree;

            wordOne = Console.ReadLine();
            wordTwo = Console.ReadLine();
            wordThree = Console.ReadLine();

            if (wordOne == "vertebrado")
            {
                if (wordTwo == "ave")
                {
                    if (wordThree == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (wordThree == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (wordTwo == "inseto")
                {
                    if (wordThree == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (wordThree == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
        public static void Taxes()
        {
            double salary, tax;

            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 2000.00)
            {
                tax = 0.0;
            }
            else if (salary <= 3000.0)
            {
                tax = (salary - 2000.0) * 0.08;
            }
            else if (salary <= 4500.0)
            {
                tax = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                tax = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (tax == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        public static void SimpleSort()
        {
            int a, b, c, highest, middle, lowest;
            string[] values;

            values = Console.ReadLine().Split(' ');
            a = int.Parse(values[0]);
            b = int.Parse(values[1]);
            c = int.Parse(values[2]);

            if (a < b && a < c)
            {
                lowest = a;
                if (b > c)
                {
                    highest = b;
                    middle = c;
                }
                else
                {
                    highest = c;
                    middle = b;
                }
            }
            else if (b < c)
            {
                lowest = b;
                if (a < c)
                {
                    highest = c;
                    middle = a;
                }
                else
                {
                    highest = a;
                    middle = c;
                }
            }
            else
            {
                lowest = c;
                if (a < b)
                {
                    highest = b;
                    middle = a;
                }
                else
                {
                    highest = a;
                    middle = b;
                }
            }

            Console.WriteLine(lowest);
            Console.WriteLine(middle);
            Console.WriteLine(highest);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        public static void AscendingAndDescending()
        {
            int x, y;
            string[] z;

            z = Console.ReadLine().Split(' ');
            x = int.Parse(z[0]);
            y = int.Parse(z[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                z = Console.ReadLine().Split(' ');
                x = int.Parse(z[0]);
                y = int.Parse(z[1]);
            }
        }
        public static void FixedPassword()
        {
            int attempt, password;
            password = 2002;
            attempt = int.Parse(Console.ReadLine());

            while (attempt != password)
            {
                Console.WriteLine("Senha Invalida");
                attempt = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
        public static void Quadrant()
        {
            string[] z;
            int x, y;

            z = Console.ReadLine().Split(' ');
            x = int.Parse(z[0]);
            y = int.Parse(z[1]);

            while (x != null || y != null)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    break;
                }
                z = Console.ReadLine().Split(' ');
                x = int.Parse(z[0]);
                y = int.Parse(z[1]);
            }
        }
        public static void ScoreValidation()
        {
            double x, y, average;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x < 0 || x > 10)
            {
                Console.WriteLine("nota invalida");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (y < 0 || y > 10)
            {
                Console.WriteLine("nota invalida");
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            average = (x + y) / 2;
            Console.WriteLine($"media = {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void TypeOfFuel()
        {
            int option, alcool, gasolina, diesel;
            alcool = 0;
            gasolina = 0;
            diesel = 0;

            option = int.Parse(Console.ReadLine());

            while (option != 4)
            {
                if (option == 1)
                {
                    alcool++;
                }
                else if (option == 2)
                {
                    gasolina++;
                }
                else if (option == 3)
                {
                    diesel++;
                }

                option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
        public static void Ages()
        {
            int count;
            double age, sumAge, average;

            age = double.Parse(Console.ReadLine());
            count = 0;
            sumAge = 0;

            while (age > 0)
            {
                count++;
                sumAge = sumAge + age;
                age = double.Parse(Console.ReadLine());
            }

            average = sumAge / count;
            Console.WriteLine(average.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void SumOfConsecutiveEvenNumbers()
        {
            int number;

            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                if (number % 2 != 0)
                {
                    number = number + 1;
                }

                int sum = number + number + 2 + number + 4 + number + 6 + number + 8;
                Console.WriteLine(sum);

                number = int.Parse(Console.ReadLine());
            }
        }
        public static void SeveralScoresWithValidation()
        {
            double x, y, average;
            int newAverage = 1;

            while (newAverage == 1)
            {
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (x < 0 || x > 10)
                {
                    Console.WriteLine("nota invalida");
                    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (y < 0 || y > 10)
                {
                    Console.WriteLine("nota invalida");
                    y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                average = (x + y) / 2;
                Console.WriteLine($"media = {average.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                newAverage = int.Parse(Console.ReadLine());
                while (newAverage != 1 && newAverage != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    newAverage = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void Grenais()
        {
            string[] scores;
            int interWin, gremioWin, interWinTotal, gremioWinTotal, total, draw, option;

            scores = Console.ReadLine().Split(' ') ;
            interWin = int.Parse(scores[0]);
            gremioWin = int.Parse(scores[1]);
            draw = 0;
            option = 0;
            interWinTotal = 0;
            gremioWinTotal = 0;
            total = 0;

            if (interWin > gremioWin)
            {
                interWinTotal++;
                total++;
            }
            else if (gremioWin > interWin)
            {
                gremioWinTotal++;
                total++;
            }
            else
            {
                draw++;
                total++;
            }

            while (option != 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    break;
                }
                else
                {
                    scores = Console.ReadLine().Split(' ');
                    interWin = int.Parse(scores[0]);
                    gremioWin = int.Parse(scores[1]);

                    if (interWin > gremioWin)
                    {
                        interWinTotal++;
                        total++;
                    }
                    else if (gremioWin > interWin)
                    {
                        gremioWinTotal++;
                        total++;
                    }
                    else
                    {
                        draw++;
                        total++;
                    }
                }
                //Console.WriteLine("Novo grenal (1-sim 2-nao)");
                //option = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{total} grenais");
            Console.WriteLine($"Inter:{interWinTotal}");
            Console.WriteLine($"Gremio:{gremioWinTotal}");
            Console.WriteLine($"Empates:{draw}");
            if (interWinTotal > gremioWinTotal)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
        public static void MultiplicationTable()
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i=1; i <= 10; i++)
            {
                int result = i * N;
                Console.WriteLine($"{i} x {N} = {result}");
            }
        }
        public static void SumOfConsecutiveOddNumbers()
        {
            int x, y, min, max, sum;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            sum = 0;
            for (int i= min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine(sum);
        }
        public static void OddNumbers()
        {
            int number, betweenOddNumbers, y = 0;

            number = int.Parse(Console.ReadLine());

            for (int i = 0; number >= i; i++)
            {
                if (y % 2 != 0)
                {
                    betweenOddNumbers = y;
                    Console.WriteLine(betweenOddNumbers);
                    y++;
                }
                else
                {
                    y++;
                }
            }
        }
        public static void IntervalPartTwo()
        {
            int number, x, inRange, outRange;

            number = int.Parse(Console.ReadLine());
            inRange = 0;
            outRange = 0;
            for (int i = 1; i <= number; i++)
            {
                x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    inRange++;
                }
                else
                {
                    outRange++;
                }
            }
            Console.WriteLine($"{inRange} in");
            Console.WriteLine($"{outRange} out");
        }
        public static void EvenSquare()
        {
            int number;
            double squareEven;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if(i % 2 == 0)
                {
                    squareEven = Math.Pow(i, 2);
                    Console.WriteLine($"{i}^2 = {squareEven}");
                }
            }
        }
        public static void EvenOrOdd()
        {
            int number, evenOrOdd;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                evenOrOdd = int.Parse(Console.ReadLine());

                if (evenOrOdd % 2 == 0 && evenOrOdd > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (evenOrOdd % 2 == 0 && evenOrOdd < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (evenOrOdd % 2 != 0 && evenOrOdd > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (evenOrOdd % 2 != 0 && evenOrOdd < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
        public static void RemainingPartTwo()
        {
            int number;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % number == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void WeightedAverages()
        {
            int number;
            string[] testCases;
            double caseOne, caseTwo, caseThree, average;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number;  i++)
            {
                testCases = Console.ReadLine().Split(' ');
                caseOne = double.Parse(testCases[0], CultureInfo.InvariantCulture);
                caseTwo = double.Parse(testCases[1], CultureInfo.InvariantCulture);
                caseThree = double.Parse(testCases[2], CultureInfo.InvariantCulture);

                average = ((caseOne * 2) + (caseTwo * 3) + (caseThree * 5)) / 10;
                Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        public static void HighestAndPosition()
        {
            int highestNumber, index;
            highestNumber = 0;
            index = 0;

            for(int i = 1; i <= 100; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > highestNumber)
                {
                    highestNumber = numbers;
                    index = i;
                }
            }
            Console.WriteLine(highestNumber);
            Console.WriteLine(index);
        }
        public static void Experiments()
        {
            string[] values;
            int number, value, rabbit = 0, rat = 0, frog = 0, total;
            double rabbitPercentage, ratPercentage, frogPercentage;
            char letter;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                values = Console.ReadLine().Split(' ');
                value = int.Parse(values[0]);
                letter = char.Parse(values[1].ToUpper());

                if (letter == 'C')
                    rabbit += value;
                else if (letter == 'R')
                    rat += value;
                else if (letter == 'S')
                    frog += value;
            }

            total = rabbit + rat + frog;

            rabbitPercentage = ((double)rabbit / total) * 100;
            ratPercentage = ((double)rat / total) * 100;
            frogPercentage = ((double)frog / total) * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {rabbit}");
            Console.WriteLine($"Total de ratos: {rat}");
            Console.WriteLine($"Total de sapos: {frog}");
            Console.WriteLine($"Percentual de coelhos: {rabbitPercentage.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {ratPercentage.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {frogPercentage.ToString("F2", CultureInfo.InvariantCulture)} %");
        }
        public static void SequenceIJPartTwo()
        {
            for (int i = 1; i <= 9;  i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine($"I={i} J=7");
                    Console.WriteLine($"I={i} J=6");
                    Console.WriteLine($"I={i} J=5");
                }
            }
        }
        public static void SequenceIJPartThree()
        {
            int number = 7;

            for (int i = 1; i <= 9;  i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine($"I={i} J={number}");
                    Console.WriteLine($"I={i} J={number - 1}");
                    Console.WriteLine($"I={i} J={number - 2}");
                    number = number + 2;
                }
            }
        }
        public static void DividingXByY()
        {
            int number;
            string[] values;
            double x, y, division;

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                values = Console.ReadLine().Split(' ');
                x = double.Parse(values[0], CultureInfo.InvariantCulture);
                y = double.Parse(values[1], CultureInfo.InvariantCulture);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    division = x / y;
                    Console.WriteLine(division.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
        public static void MultiplesOfThirteen()
        {
            int X, Y, min, max, sum = 0;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            min = Math.Min(X, Y);
            max = Math.Max(X, Y);
            for (int i = min; i <= max; i++)
            {
                if(i % 13 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        public static void RestOfDivision()
        {
            int X, Y;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            int start = Math.Min(X, Y);
            int end = Math.Max(X, Y);

            for (int i = start + 1; i <= end; i++)
            {
                if (i % 5 == 2 ||  i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PUM()
        {
            int N = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{number} {number + 1} {number + 2} PUM");
                number += 4;
            }
        }
        public static void SquaredAndCubic()
        {
            int number;

            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
        public static void LogicalSequence()
        {
            int number, x = 0, y = 0;
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
                x = (int)Math.Pow(i, 2) + 1;
                y = (int)Math.Pow(i, 3) + 1;
                Console.WriteLine($"{i} {x} {y}");
            }
        }
        public static void EasyFibonacci()
        {
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i = i + 1)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                }
                int aux = b;
                b = a;
                a = aux + b;
            }
        }
        public static void SumOfConsecutiveOddNumbersPartTwo()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int X = int.Parse(values[0]);
                int Y = int.Parse(values[1]);

                if(X % 2 != 0 || Y % 2 != 0)
                {
                    Console.WriteLine(X + Y);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
