using System.Globalization;

decimal pi = 3.14159M;
decimal raio = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
decimal area = pi * (raio * raio);
Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));