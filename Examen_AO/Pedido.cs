using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_AO
{
    public class Pedido
    {
        public static List<Pedido> pedidos = new List<Pedido>();

        private int codPedi;
        private int codCliPedi;
        private DateTime fechaPedi;

        public int CodPedi { get => codPedi; set => codPedi = value; }
        public int CodCliPedi { get => codCliPedi; set => codCliPedi = value; }
        public DateTime FechaPedi { get => fechaPedi; set => fechaPedi = value; }

        public Pedido(int codPedi, int codCliPedi, DateTime fechaPedi)
        {
            this.CodPedi = codPedi;
            this.CodCliPedi = codCliPedi;
            this.FechaPedi = fechaPedi;
        }
    }
}
