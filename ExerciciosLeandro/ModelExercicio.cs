using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        public double AreaRetangulo(double bas, double alt)
        {

            return bas * alt;

        }//Fim AreaRetangulo

        //Exercício 05
        public double PorcentagemVotos(double votos, double total)
        {

            return (votos * 100) / total;


        }//fim do método de porcentagem

        public bool Validar(double num)
        {

            if (num < 0)
            {
                return false;
            }
            else
            {

                return true;

            }
        }//Fim validação

        //EX 6
        public double AjusteSalario(double salario, double reajuste)
        {

            return salario * (reajuste / 100) + salario;
        }//Fim método

        //EX 7
        public double CustoFinal(double porc, double custInicial)
        {

            return custInicial * (porc / 100);

        }//fim método

        public double Comissao(double totalCarros, double comissao)
        {
            return totalCarros * comissao;
        }//Fim do Comicao Carro

        public double TotalComVendas(double totalCarros)
        {
            return totalCarros * 0.05;
        }//Fim do Total - Comissão - Vendas




        public int Pimp(int num1)
        {

            return num1 % 2;

        }//.... fim

        public int BiAno(int ano)
        { 
            
            return ano % 4; 
        
        }

        //EX 5 - 13
        public double NotasAluno(double notaa1, double notaa2)
        {

            return (notaa1 + notaa2) / 2;

        }//Fim método média


        //EX 7 - 15
  
    


        }//Fim do classe
}//Fim projeto
