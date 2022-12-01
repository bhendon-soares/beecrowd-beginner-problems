using System;
using System.Globalization;

namespace Beecrowd
{
    class URI
    {
        static void Main(string[] args)
        {
            double nota100, nota50, nota20, nota10, nota5, nota2, 
                   moeda1, moeda50, moeda25, moeda10, moeda05, moeda01, resto;


            double N = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS: ");
            nota100 = N / 100;
            resto = N % 100;
            Console.WriteLine((int)nota100 +  "nota(s) de R$ 100.00");

            nota50 = resto / 50;
            resto = resto % 50;
            Console.WriteLine((int)nota50 +  "nota(s) de R$ 50.00");

            nota20 = resto / 20;
            resto = resto % 20;
            Console.WriteLine((int)nota20 +  "nota(s) de R$ 20.00");

            nota10 = resto / 10;
            resto = resto % 10;
            Console.WriteLine((int)nota10 +  "nota(s) de R$ 10.00");

            nota5 = resto / 5;
            resto = resto % 5;
            Console.WriteLine((int)nota5 +  "nota(s) de R$ 5.00");

            nota2 = resto / 2;
            resto = resto % 2;
            Console.WriteLine((int)nota2 +  "nota(s) de R$ 2.00");


            Console.WriteLine("MOEDAS: ");























            //1020 - IDADE EM DIAS
            //int idade = int.Parse(Console.ReadLine());

            //int anos, meses, dias, resto;

            //anos = idade / 365;
            //resto = idade % 365;
            //Console.WriteLine($"{anos} ano(s)");

            //meses = resto / 30;
            //resto = resto % 30;
            //Console.WriteLine($"{meses} mes(es)");

            //dias = resto;
            //Console.WriteLine($"{dias} dia(s)");









            //1019 - CONVERSÃO DE TEMPO
            //int N = int.Parse(Console.ReadLine());
            //int hora, minutos, segundos, resto;

            //hora = N / 3600;
            //resto = N % 3600;

            //minutos = resto / 60;
            //resto = resto % 60;

            //segundos = resto;

            //Console.WriteLine($"{hora}:{minutos}:{segundos}");










            //1018 - CEDULAS
            //int nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;

            //int N = int.Parse(Console.ReadLine());

            //Console.WriteLine(N);

            //nota100 = N / 100;
            //resto = N % 100;
            //Console.WriteLine($"{nota100} nota(s) de R$ 100,00");

            //nota50 = resto / 50;
            //resto = resto % 50;
            //Console.WriteLine($"{nota50} nota(s) de R$ 50,00");

            //nota20 = resto / 20;
            //resto = resto % 20;
            //Console.WriteLine($"{nota20} nota(s) de R$ 20,00");

            //nota10 = resto / 10;
            //resto = resto % 10;
            //Console.WriteLine($"{nota10} nota(s) de R$ 10,00");

            //nota5 = resto / 5;
            //resto = resto % 5;
            //Console.WriteLine($"{nota5} nota(s) de R$ 5,00");

            //nota2 = resto / 2;
            //resto = resto % 2;
            //Console.WriteLine($"{nota2} nota(s) de R$ 2,00");

            //nota1 = resto / 1;
            //resto = resto % 1;
            //Console.WriteLine($"{nota1} nota(s) de R$ 1,00");








            //1017 - GASTO DE COMBUSTIVEL
            //int tempo = int.Parse(Console.ReadLine());
            //int velocidadeMedia = int.Parse(Console.ReadLine());

            //double combustivel = (double)(tempo * velocidadeMedia) / 12;

            //Console.WriteLine(combustivel.ToString("F3"));








            //1016 - DISTANCIA
            //int distancia = int.Parse(Console.ReadLine());
            //int tempo = distancia * 2;
            //Console.WriteLine($"{tempo} minutos");










            //1015 - DISTANCIA ENTRE DOIS PONTOS
            //string[] x1y1 = Console.ReadLine().Split(' ');
            //double x1 = double.Parse(x1y1[0]);
            //double y1 = double.Parse(x1y1[1]);

            //string[] x2y2 = Console.ReadLine().Split(' ');
            //double x2 = double.Parse(x2y2[0]);
            //double y2 = double.Parse(x2y2[1]);

            //double distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine(distancia.ToString("F4"));












            //1014 - CONSUMO
            //int X = int.Parse(Console.ReadLine());
            //double Y = double.Parse(Console.ReadLine());
            //double consumo = X / Y;

            //Console.WriteLine($"{consumo.ToString("F3")} km/l");









            //1013 - MAIOR
            //string line1 = Console.ReadLine();
            //String[] valores = line1.Split(' ');
            //int A = int.Parse(valores[0]);
            //int B = int.Parse(valores[1]);
            //int C = int.Parse(valores[2]);

            //double maiorAB = (A + B + Math.Abs(A - B)) / 2;

            //if(C > maiorAB)
            //{
            //    Console.WriteLine($"{C} eh o maior");
            //}
            //else
            //{
            //    Console.WriteLine($"{maiorAB} eh o maior");
            //}






            //1012 - AREA
            //string line1 = Console.ReadLine();
            //String[] valores = line1.Split(' ');
            //double A = double.Parse(valores[0]);
            //double B = double.Parse(valores[1]);
            //double C = double.Parse(valores[2]);

            //double areaTriangulo = (A * C) / 2;
            //double areaCirculo = 3.14159 * (C * C);
            //double areaTrapezio = ((A + B) * C) / 2;
            //double areaQuadrado = B * B;
            //double areaRetangulo = A * B;

            //Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}\n" +
            //                  $"CIRCULO: {areaCirculo.ToString("F3")}\n" +
            //                  $"TRAPEZIO: {areaTrapezio.ToString("F3")}\n" +
            //                  $"QUADRADO: {areaQuadrado.ToString("F3")}\n" +
            //                  $"RETANGULO: {areaRetangulo.ToString("F3")}");








            //1011 - ESFERA
            //double r = double.Parse(Console.ReadLine());
            //r = Math.Pow(r, 3);
            //double pi = 3.14159;

            //double volume = (4 / 3.0) * pi * r;

            //Console.WriteLine($"VOLUME = {volume.ToString("F3")}");








            //1010 - CALCULO SIMPLES
            //string line1 = Console.ReadLine();
            //string line2 = Console.ReadLine();

            //String[] values1 = line1.Split(' ');
            //int codPeca1 = int.Parse(values1[0]);
            //int numPeca1 = int.Parse(values1[1]);
            //double valorPeca1 = double.Parse(values1[2]);

            //String[] values2 = line2.Split(' ');
            //int codPeca2 = int.Parse(values2[0]);
            //int numPeca2 = int.Parse(values2[1]);
            //double valorPeca2 = double.Parse(values2[2]);

            //double valorTotal = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);
            //Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2")}");






            //1009 - SALARIO COM BONUS
            //string nome = Console.ReadLine();
            //double salarioFixo = double.Parse(Console.ReadLine());
            //double vendasEfetuadas = double.Parse(Console.ReadLine());

            //vendasEfetuadas *= 0.15;
            //double salarioFinal = salarioFixo + vendasEfetuadas;
            //Console.WriteLine($"TOTAL = R$ {salarioFinal.ToString("F2")}");








            //1008 - SALARIO
            //int numeroFuncionario = int.Parse(Console.ReadLine());
            //int horasTrabalhadas = int.Parse(Console.ReadLine());
            //double salarioPorHora = double.Parse(Console.ReadLine());

            //double salario = horasTrabalhadas * salarioPorHora;

            //Console.WriteLine($"NUMBER = {numeroFuncionario}");
            //Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");








            //1007 - DIFERENÇA
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //int DIFERENCA = (A * B - C * D);
            //Console.WriteLine($"DIFERENCA = {DIFERENCA}");







            //1006 - MEDIA 2
            //double A = double.Parse(Console.ReadLine());
            //double B = double.Parse(Console.ReadLine());
            //double C = double.Parse(Console.ReadLine());

            //double media = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);
            //Console.WriteLine($"MEDIA = {media.ToString("F1")}");






            //1005 - MEDIA 1
            //double A = double.Parse(Console.ReadLine());
            //double B = double.Parse(Console.ReadLine());

            //double media = ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);
            //Console.WriteLine($"MEDIA = {media.ToString("F5")}");







            //1004 - PRODUTO SIMPLES
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //int PROD = A * B;

            //Console.WriteLine($"PROD = {PROD}");








            //1003 - SOMA SIMPLES:
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //int SOMA = A + B;

            //Console.WriteLine($"SOMA = {SOMA}");






            //1002 - AREA DO CIRCULO:
            //double n = 3.14159;
            //double area, raio;

            //raio = double.Parse(Console.ReadLine());

            //area = n * (raio * raio);

            //Console.WriteLine($"A={area.ToString("F4")}");
        }
    }
}
