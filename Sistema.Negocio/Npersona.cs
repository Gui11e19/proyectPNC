using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class Npersona
    {
        public static DataTable Listar()
        {
            Dpersona datos = new Dpersona();
            return datos.Listar();
            
        }
        public static DataTable Buscar (string Valor)
        {
            Dpersona datos = new Dpersona();
            return datos.Buscar(Valor);
        }
        public static string Insertar(string nombre, string apellido, string telefono, int edad)
        {
            Dpersona datos = new Dpersona();
            string Existe = datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "La persona ya existe";
            }
            else
            {
                persona Obj = new persona();
                Obj.nombre = nombre;
                Obj.apellido = apellido;
                Obj.telefono = telefono;
                Obj.edad = edad;
                return datos.Insertar(Obj);
            }
            
        }
    }
}
