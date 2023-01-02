using CaixaEletronico;
using System;

class Program
{
    static void Main()
    {
        Conta conta1 = new Conta();

        conta1.numero = 1;
        conta1.titular = "conta1";
        conta1.saldo = 560;

        Conta conta2 = new Conta();

        conta2.numero = 2;
        conta2.titular = "conta2";
        conta2.saldo = 10;

        conta1.Deposito(1000);

        if (conta1.Saque(100))
        {
            Console.WriteLine($"Saque realizado com sucesso! \nSaldo atual: {conta1.saldo}");
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente! \nSaldo atual: {conta1.saldo}");
        }

        conta1.Transferencia(1000, conta2);
    }
}

