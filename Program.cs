using System;

class Program
{
    static void Main(string[] args)
    {
        /*Calculadora s = new Calculadora();
        Calculadora s2 = new Calculadora();

        double numOne = 4.5;
        double numTwo = 340.6;
        double numThree = 500.9;

        Console.WriteLine($"A soma de {numOne} e {numTwo} é: {s.Soma(numOne, numTwo)}");
        Console.WriteLine("");
        Console.WriteLine($"A soma me {numOne}, {numTwo} e {numThree} é: {s2.Soma(numOne, numTwo, numThree)}");
        */

        Veiculo v = new Veiculo();
        Carro c = new Carro();
        Moto m = new Moto();

        v.Movimento();
        c.Movimento();
        m.Movimento();
    }
}
