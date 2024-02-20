using System.Collections.Generic;

namespace Examen_AO
{
    public class DetallePed
    {

        public static List<DetallePed> detallesPeds = new List<DetallePed>();

        private int codPediDetal;
        private int codProDetal;
        private int cantidadDetal;

        public int CodPediDetal { get => codPediDetal; set => codPediDetal = value; }
        public int CodProDetal { get => codProDetal; set => codProDetal = value; }
        public int CantidadDetal { get => cantidadDetal; set => cantidadDetal = value; }

        public DetallePed(int codPediDetal, int codProDetal, int cantidadDetal)
        {
            this.CodPediDetal = codPediDetal;
            this.CodProDetal = codProDetal;
            this.CantidadDetal = cantidadDetal;
        }
    }
}
