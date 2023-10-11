using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeandro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conectar control com a program
            ControlFormulario control = new ControlFormulario(); //Instanciando 
            control.Operacao();

            //Manter aberto
            Console.ReadLine();
        }//Fim do método main
    }//Fim classe program
}//Fim do projeto
