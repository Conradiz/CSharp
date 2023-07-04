
int valorCompra = 1001;
int discount = valorCompra > 1000 ? 100 : 50;
Console.WriteLine($"Desconto : {discount}");
int valorCompra2 = 1000;
Console.WriteLine($"Desconto: {(valorCompra2 > 1000 ? 100: 50)}");

Random numero = new Random();
int result = numero.Next(0,2);
Console.WriteLine((result == 0)? "heads": "tails");