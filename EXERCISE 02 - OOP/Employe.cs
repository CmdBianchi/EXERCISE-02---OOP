using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace EXERCISE_02___OOP{
    //---------------------- START | OBJ EMPLOYE ------------------------//
    class Employe{ //----> CLASS ATTRIBUTES
        public string Name;
        public double GroossSalary;
        public double Tax;
        //------------------------ MET. CLASS -------------------------------//
        public double NetSalary(){
            return GroossSalary - Tax;
        }
        public void IncreaseSalary(double percentage){
            GroossSalary = GroossSalary + (GroossSalary * percentage / 100);
        }
        public override string ToString(){
            return Name
            + ", R$ "
            + NetSalary().ToString("F2");
        }
    }
    //--------------------------- END --------------------------------//
}
