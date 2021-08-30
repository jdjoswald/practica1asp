using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace practicas2.Pages
{
    public class nominaModel : PageModel
    {

      public  List<nomina> lista = new List<nomina>() { 
            new nomina(
                "cdq",
                "puerco",
                 "mmg",
                25000.00 ),


            new nomina(
                "cdq",
                "puerco",
                 "mmg",
                25000.00 ),
            new nomina(
                "cdq",
                "puerco",
                 "mmg",
                25000.00 ),
            new nomina(
                "cdq",
                "puerco",
                 "mmg",
                25000.00 ),
            new nomina(
                "cdq",
                "puerco",
                 "mmg",
                25000.00 )
        };


      

        public double seguro(double num) {
           double  total = num * 0.0304;
            if (total > 4098.53) {
                total = 4098.53;
            }
            return total;
                
         }
        public double admin(double num) {

            double total = num * 0.087;
            if (total > 7738.67) {

                total = 7738.67;
            }
            return total;
        
        }
        public double imp(double num) {
            double anual =num * 12;

            if (anual < 416220) {
                return 0;
            }
            if (anual >= 416220.01 && anual < 624329 )
            {
                
                return num *0.15;
            }
            if (anual >= 624329.01 && anual < 867123)
            {
                return num * 0.20;
            }
            if (anual >= 867123.01)
            {
                return num * 0.25;
            }
            return 0;
           
          
            
        }
        public double total_desc(double num) {
            double total = seguro(num) + admin(num) + imp(num);
            return total;
        }
        public double neto(double num)
        {
            double total = num-total_desc(num) ;
            return total;
        }

        public void OnGet()
        {

        }
    }
     public class nomina
    {
        

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }

        public nomina(string nombre, string apellido, string cargo, double salario) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.salario = salario;
        
        }

    }
}
