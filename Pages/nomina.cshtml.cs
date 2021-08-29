using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace practircaII.Pages
{
    public class NominaModel : PageModel
    {
      public  String Nombre { get; set; }
      public String Apellido { get; set; }

      public String Cargo { get; set; }
      public String Salario { get; set; }

        public List<NominaModel> empleados = new List<NominaModel>() 
        { 
          
        };
      

    
        public void OnGet() { }
       
        
    }
}
