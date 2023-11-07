namespace EjercicioClasesHerencia
{
    internal class CuentaEmpresa : Cuenta
    {
        public double credito;
        public long interes;
        public int mesesCredito;
        public double topeCredito;

        public CuentaEmpresa(string titular, string dni, long interes, int mesesCredito, double topeCredito)
        : base(titular, dni)
        {
            this.credito = 0;
            this.interes = interes;
            this.mesesCredito = mesesCredito;
            this.topeCredito = topeCredito;
        }

        public override bool Reintegro(double importe)
        {
            return (importe > 0 && (base.Reintegro(importe) || CalcularCredito(importe)));

        }

        public string MostrarCredito()
        {
            double cuotaMensual = (credito + (credito * interes / 100)) / mesesCredito;

            string resultado = $"Crédito: {credito}\nInterés: {interes}%\nNumero de cuotas: {mesesCredito}\nCuota Mensual: {cuotaMensual}";

            return resultado;
        }


        private bool CalcularCredito(double importe)
        {
            //Comprobamos que el importe a prestar (importe - saldo) no supera el credito disponible (topeCredito - credito)
            if ((importe - saldo) < (topeCredito - credito))
            {
                credito += (importe - saldo);
                saldo = 0;
                return true; //Devolvemos true si se saca credito
            }
            else
            {
                return false; //Devolvemos false si no es posible
            }
        }
        public override string ToString()
        {
            return $"Número de Cuenta: {NumeroCuenta}\n" +
                   $"Titular: {titular}\n" +
                   $"DNI: {Dni}\n" +
                   $"Saldo: {saldo} EUROS\n" +
                   $"Crédito: {credito} EUROS\n" +
                   $"Interés: {interes}%\n" +
                   $"Meses de Crédito: {mesesCredito}\n" +
                   $"Tope de Crédito: {topeCredito} EUROS";
        }
    }
}