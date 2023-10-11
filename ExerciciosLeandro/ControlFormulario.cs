using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExerciciosLeandro
{
     class ControlFormulario
    {


        ModelExercicio exercicio;//criando uma variável para representar a ação
        private int opcao;
        public ControlFormulario() 
        {
        
            exercicio = new ModelExercicio();//conecta a classe model e a control
            ConsultarOpcao = -1;
        }//fim método construtor


        //métodos modificadores

        public int ConsultarOpcao
        {

            get { return opcao; }
            set { opcao = value; }

        }//Fim do método

        public void menu()
        {

            Console.WriteLine("\n\n ------- Menu ------- \n\n" +
                               "0,=. Sair\n"       +
                               "1. Exercício 01\n" +
                               "2. Exercício 02\n" +
                               "3. Exercício 03\n" +
                               "4. Exercício 04\n" +
                               "5. Exercício 05\n" +
                               "6. Exercício 06\n" +
                               "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//mostrar menu

        public void Operacao()
        {
            do
            {
                menu();
                Console.Clear();//limpar dados antigos
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        double nota1 = 0;//declarei a variável nota1 do lado de fora
                        double nota2 = 0;
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.validarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim validação
                        } while (exercicio.validarNotas(nota1) == true);//agora o while enxerga a variável

                        do
                        {
                            Console.WriteLine("Informe a segunda nota:  ");
                            nota2 = Convert.ToDouble(Console.ReadLine());


                            if (exercicio.validarNotas(nota2) == true)
                            {

                                Console.WriteLine("Informe uma nota entre 0 e 10");

                            }//fim da validação
                        } while (exercicio.validarNotas(nota2) == true);


                        //Chamar o método da média que está na calsse model
                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));    //usei a variável exercecio para ele reconhecer
                        break;
                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());


                        //comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;



                    case 3:
                        Console.WriteLine("Informe um número");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("O antecessor é: " + exercicio.Antecessor(num));
                        break;


                    case 4:                      
                        Console.WriteLine("Informe um número");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número");
                        num2 = Convert.ToInt32(Console.ReadLine());


                        //Comparação
                        Console.WriteLine("A área do retângulo é: " + exercicio.AreaRetangulo(num1, num2));
                        break;

                    case 5:
                        Console.WriteLine("Informe o total de eleitores");
                       double total = Convert.ToDouble(Console.ReadLine());




                        Console.WriteLine("Informe o total de votos válidos");
                        double validos = Convert.ToDouble(Console.ReadLine());




                        Console.WriteLine("Informe o total de votos brancos");
                        double brancos = Convert.ToDouble(Console.ReadLine());




                        Console.WriteLine("Informe o total de votos nulos");
                        double nulos = Convert.ToDouble(Console.ReadLine());
                    break;



                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0);//Fim do while
                        
           
        }//Fim do método



    }//Fim class


}//fim projeto
