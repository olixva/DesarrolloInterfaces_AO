using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasesHerencia
{
    internal class Cuenta
    {
        private int numeroCuenta;
        private String titular;
        private String dni;
        private double saldo;

        public Cuenta()
        {
        }

        public Cuenta(int numeroCuenta, string titular, string dni, double saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.dni = dni;
            this.saldo = saldo;
        }

        public bool Reintegro(double importe)
        {
            if ((saldo - importe) > 0 && importe > 0)
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
            if (importe > 0)
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
                return true;
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
