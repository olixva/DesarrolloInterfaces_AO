using System;

namespace EjercicioClasesHerencia
{
    internal class Cuenta
    {
        public static int contadorCuentas = 0;

        private int numeroCuenta;
        public String titular;
        private String dni;
        public double saldo;

        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string Dni { get => dni; set => dni = value; }

        public Cuenta(string titular, string dni)
        {
            this.numeroCuenta = ++contadorCuentas;
            this.titular = titular;
            this.dni = dni;
            this.saldo = 0;
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
            return this.Reintegro(importe) && destino.Ingreso(importe);
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
