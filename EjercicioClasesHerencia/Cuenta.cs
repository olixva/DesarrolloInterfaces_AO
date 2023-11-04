using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasesHerencia
{
    internal class Cuenta
    {
        public static int contadorCuentas = 0;

        public int numeroCuenta;
        public String titular;
        public String dni;
        public double saldo;

        public Cuenta(string titular, string dni, double saldo)
        {
            this.numeroCuenta = contadorCuentas++;
            this.titular = titular;
            this.dni = dni;
            this.saldo = saldo;
        }

        public virtual bool Reintegro(double importe)
        {
            if (saldo >= importe && importe > 0) // Comprobamos que el saldo sea mayor que el importe y que no sea negativo
            {
                saldo -= importe;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ingreso(double importe)
        {
            if (importe > 0) //Comprobamos que el importe no sea negativo
            {
                saldo += importe;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Trasferencia(Cuenta destino, double importe)
        {
            if (this.Reintegro(importe) && destino.Ingreso(importe)) 
            {
                return true; //Si el reintegro de una cuenta y el ingreso en otra funciona devolvemos true
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Número de Cuenta: {numeroCuenta}\n" +
                   $"Titular: {titular}\n" +
                   $"DNI: {dni}\n" +
                   $"Saldo: {saldo} EUROS"; // Formato de saldo como moneda
        }
    }
}
