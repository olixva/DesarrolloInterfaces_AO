using System;
using System.Collections.Generic;

namespace Ejercicio1ArchivosTexto
{
    internal class Contacto
    {
        //Lista de todos los contactos
        public static List<Contacto> contactos = new List<Contacto>();

        //Atributos de la clase
        int id;
        string nombre;
        int telefono;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public Contacto(int id, string nombre, int telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            contactos.Add(this);
        }
        public Contacto()
        {
            contactos.Add(this);
        }
        //Metodo estatico para eliminar un contacto
        public static void EliminarContacto(Contacto cBorrar)
        {
            foreach (Contacto c in contactos)
            {
                if (c == cBorrar)
                {
                    contactos.Remove(c);
                    break;
                }
            }
        }

        //Metodo estatico para mostrar el telefono de un contacto por su nombre
        public static String MostrarTelefono(String nombre)
        {
            foreach (Contacto c in contactos)
            {
                if (c.nombre.Equals(nombre))
                {
                    return ("El telefono de " + nombre + " es: " + c.telefono);
                }
            }
            return ("No existe ningun contacto con ese nombre");
        }

        //Metodo estatico que devuelve todos los contactos que contengan una determinada cadena
        public static List<Contacto> MostrarContactosNombre(string cadena)
        {
            List<Contacto> contactosCadena = new List<Contacto>();
            foreach (Contacto c in contactos)
            {
                if (c.nombre.Contains(cadena))
                {
                    contactosCadena.Add(c);
                }
            }
            return contactosCadena;
        }

        //Metodo para mostrar todos los contactos con una determinada inicial
        public static List<Contacto> MostrarContactosInicial(char inicial)
        {
            List<Contacto> contactosInicial = new List<Contacto>();
            foreach (Contacto c in contactos)
            {
                if (string.Equals(c.nombre[0].ToString(), inicial.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    contactosInicial.Add(c);
                }
            }
            return contactosInicial;
        }
        public override string ToString()
        {
            return "Id: " + id + " Nombre: " + nombre + " Telefono: " + telefono + "\n";
        }
    }
}
