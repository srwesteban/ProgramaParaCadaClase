using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentaBancaria
{
    public class Cuenta
    {
        public string id { get; set; }
        public string name { get; set; }
        public int balance { get; set; }

        
        public Cuenta()
        {

        }
        public Cuenta(string id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public Cuenta(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public int creditar(int credito)
        {
            int nuevoSaldo = this.balance + credito ;

            this.balance = nuevoSaldo;
            return balance;
        }
        public int debitar(int debito)
        {
            if (debito > balance)
            {
                Console.WriteLine("saldo insuficiente");
                return balance;
            }
            else
            {
                int debitar = this.balance - debito;

                this.balance = debitar;

                return balance;
            }

            
        }
        public int transferir(Cuenta cuentaUno, int valor)
        {
            if(this.balance >= valor)
            {
                cuentaUno.creditar(valor);
                this.debitar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficuente");
                
            }

            return balance;

        }
        public override string ToString()
        {
            return $"cuenta id:{id} nombre:{name} balance:{balance}";
        }
    }
}
