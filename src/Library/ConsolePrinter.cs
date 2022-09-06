using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{

    public class ConsolePrinter
    {

        Recipe recip = new Recipe();
        public ConsolePrinter(Recipe recipp){
            this.recip = recipp;  
        }

        public void ConsolePrinterr(){
            Console.WriteLine($"Receta de {recip.FinalProduct.Description}");
            foreach (Step step in recip.steps){
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
       

    }

}