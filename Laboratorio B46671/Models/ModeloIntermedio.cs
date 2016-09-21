using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_B46671.Models;

namespace Laboratorio_B46671.Models
{
    public class ModeloIntermedio
    {
        public cliente modeloCliente{ get; set; }
        public telefono modeloTelefono1{ get; set;}
        public telefono modeloTelefono2{ get; set; }
        public cuenta modeloCuenta1 { get; set; }
        public cuenta modeloCuenta2 { get; set; }
        public cuenta modeloCuenta3 { get; set; }
        public List<cliente> listaCliente = new List<cliente>();
        public List<telefono> listaTelefono = new List<telefono>();
        public List<cuenta> listaCuenta = new List<cuenta>();
    }
}
