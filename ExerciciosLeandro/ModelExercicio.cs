using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLeandro
{
    class ModelExercicio
    {

        public ModelExercicio()
        {



        }//fim construtor
        //ExerciciosLeandro 01 média de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {

            return (nota1 + nota2) / 2;

        }//Fim método média


        //metodo validação

        public bool validarNotas(double nota)
        {

            if ((nota < 0) || (nota > 10))
            {

                return true;
            }
            else
            {

                return false;

            }

        }//fim do método


        //Exercício 2

        public int Comparar(int num1, int num2)
        {

             if (num1 > num2)
            { 
                return num1;
            }
            else
            {

        return num2;
            }


        }//Fim comparar

        //Exercício 03

        public int Antecessor(int num1)
        {

            return num1 - 1;
        
        }//Fim do antecessor

        //Exercício 04
        public int AreaRetangulo(int num1, int num2)
        {

            return num1 * num2;

        }//Fim AreaRetangulo

        //Exercício 05
        public double Eleitores(double brancos, double validos, double nulos, double total, double pBrancos, double pNulos);

        //validar eleitores 
   
         


    }//Fim classe

}//Fim projeto
