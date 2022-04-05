using System;
using ClassLibrary;
namespace ConsoleApp05
{
    class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();
            drug.Name = "drm";
            drug.Price = 25;
            drug.Count = 100;

            Drug drug1 = new Drug();
            drug1.Name = "drmm";
            drug1.Price = 40;
            drug1.Count = 50;

            Pharmacy pharmacy = new Pharmacy();

            
           
            pharmacy.AddDrug(drug);
            pharmacy.AddDrug(drug1);

            
            pharmacy.SaleDrug("drm", 20, 8);
            pharmacy.SaleDrug("drmm", 50, 45);

            pharmacy.ToString();
            pharmacy.DrugList();






        }
    }
}
