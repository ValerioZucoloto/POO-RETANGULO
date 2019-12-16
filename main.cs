using System;
using System.Globalization;

 class Program {
 static void Main(string[] args) {
 Retangulo x = new Retangulo();

 x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 x.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

 Console.WriteLine("AREA = " + x.area().ToString("F2", CultureInfo.InvariantCulture));

 Console.WriteLine("PERIMETRO = " + x.perimetro().ToString("F2", CultureInfo.InvariantCulture));

 Console.WriteLine("DIAGONAL = " + x.diagonal().ToString("F2", CultureInfo.InvariantCulture));
 
 Console.ReadLine();
 }
 }
