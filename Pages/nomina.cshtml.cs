using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practircaII.Models;

namespace practircaII.Pages
{
    public class NominaModel : PageModel
    {
      

        public List<Empleado> empleados = new List<Empleado>() 
        { 
          new Empleado{ 
             Nombre = "Juan",
             Apellido ="Santo",
             Cargo="Programador",
             Salario = 50000.0
          },
           new Empleado{
             Nombre = "Julio",
             Apellido ="Perez",
             Cargo="Conserje",
             Salario = 15000.0
          },
            new Empleado{
             Nombre = "Pablo",
             Apellido ="Ruiz",
             Cargo="Gerente",
             Salario = 45000.0
          },
             new Empleado{
             Nombre = "Delania",
             Apellido ="Mena",
             Cargo="Contador",
             Salario = 35000.0
          },
              new Empleado{
             Nombre = "Andrea",
             Apellido ="De oleo",
             Cargo="Programador",
             Salario = 60000.0
          },

           new Empleado{
             Nombre = "Candida",
             Apellido ="Montilla",
             Cargo="Programador",
             Salario = 300000.0
          },
           new Empleado{
             Nombre = "Pablo",
             Apellido ="Escobal",
             Cargo="Programador",
             Salario = 70000.0
          }
        };

        public double sfs( double salario) {
            double descuento = salario * 3.04 / 100;
            if (descuento > 4098.53) {
              return   descuento = 4098.53;
            }
            return descuento;
        }

        public double afp(double salario) {
            double descuento = salario * 2.87 / 100;
            if (descuento > 7738.67 )
            {
                return descuento = 7738.67;
            }
            return descuento;
        }

        public double isr(double salario) {

            double salarioAnual = salario * 12;
            double descuento = 0.0;
            if (salarioAnual <= 416220.00)
            {
                return descuento;
            }
            else if(salarioAnual >= 416220.01 && salarioAnual <= 624329.00 ){
                descuento = ( salarioAnual - 416220.01) * 15 / 100;
                return Math.Round(descuento, 2);
            } 
            else if (salarioAnual >= 624329.01 && salarioAnual <= 867123.00)
            {
              descuento = ( (salarioAnual - 624329.01) * 20 / 100) + 31216.00;
              return Math.Round(descuento, 2);
            }
            else if (salarioAnual >= 867123.01 )
            {
                 descuento = ((salarioAnual - 867123.01) * 25 / 100) + 79776.00;
                return Math.Round(descuento,2);
            }

            return descuento;
        }
    
        public void OnGet() { }
       
        
    }
}
