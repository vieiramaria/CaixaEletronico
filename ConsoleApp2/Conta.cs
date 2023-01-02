using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta // classe que abriga dados da conta e operações de saques/depósitos/transferências
    {
        public int numero;
        public string titular;      //declaração de atributos da conta
        public double saldo;

        //método para realizar saques
        public bool Saque(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            { 
                return false;
            }

        }

        //método para realzar depositos
        public void Deposito(double valor)
        {
            this.saldo += valor;
            Console.WriteLine($"Depósito realizado com sucesso! \nSaldo atual {this.saldo}");
        } 

        //metodo para realizar transferências
        public void Transferencia(double valor, Conta destino) 
        {
            if (Saque(valor))
            {
                this.saldo -= valor;
                destino.saldo += valor;
                Console.WriteLine($"Transferência realizada com sucesso!");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente \nSaldo atual: {this.saldo}");
            }
        }
    }

    
}
