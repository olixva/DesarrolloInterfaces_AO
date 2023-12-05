namespace Examen
{
    public class Cliente
    {
        private string dniCli;
        private string nombreCli;

        private bool bloqueoCli;

        private int claveCli;
        private double saldoCli;

        public string DniCli { get => dniCli; set => dniCli = value; }
        public string NombreCli { get => nombreCli; set => nombreCli = value; }
        public bool BloqueoCli { get => bloqueoCli; set => bloqueoCli = value; }
        public int ClaveCli { get => claveCli; set => claveCli = value; }
        public double SaldoCli { get => saldoCli; set => saldoCli = value; }

        public Cliente(string dniCli, string nombreCli, int claveCli, double saldoCli)
        {
            this.dniCli = dniCli;
            this.nombreCli = nombreCli;
            this.claveCli = claveCli;
            this.saldoCli = saldoCli;

            this.bloqueoCli = false;
        }

        //To String sin mostrar la clave ni el campo bloqueo
        public override string ToString()
        {
            return "DNI: " + dniCli + " Nombre: " + nombreCli + " Saldo: " + saldoCli;
        }

        public void BloquearCliente()
        {
            this.bloqueoCli = true;
        }
        public void DesbloquearCliente()
        {
            this.bloqueoCli = false;
        }
    }
}
