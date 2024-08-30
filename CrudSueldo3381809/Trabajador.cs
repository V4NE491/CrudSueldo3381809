using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSueldo3381809
{
    public class Trabajador
    {
        public int HorasTrabajadas { get; set; }
        public decimal PagoPorHora { get; set; }

        public decimal CalcularSueldoSemanal()
        {
            return HorasTrabajadas * PagoPorHora;
        }
    }
}
