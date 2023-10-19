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
                               "7. Exercício 07\n" +
                               "8. Exercício 08\n" +
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
                        double bas;
                        double alt;
                        do
                        {
                            Console.WriteLine("Informe a base do retângulo");
                            bas = Convert.ToInt32(Console.ReadLine());
                            if (bas < 0)
                            {

                                Console.WriteLine("Erro! Informe um valor positivo!");

                            }
                        } while (bas < 0);

                        do
                        {


                            Console.WriteLine("Informe a altura do retângulo");
                            alt = Convert.ToInt32(Console.ReadLine());
                            if (alt < 0)
                            {

                                Console.WriteLine("Erro! Informe um valor positivo");
                            }

                        } while (alt < 0);
                        //mostrar mensagem na tela



                        //Comparação
                        Console.WriteLine("A área do retângulo é: " + exercicio.AreaRetangulo(bas, alt));
                        break;

                    case 5:
                        double totalEleitores;
                        double validos;
                        double nulos;
                        double brancos;

                        //Total eleitores
                        do
                        {
                            Console.WriteLine("Informe o total de eleitores");
                            totalEleitores = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(totalEleitores) == false)
                            {

                                Console.WriteLine("Informe um valor positivo!");

                            }

                        } while (exercicio.Validar(totalEleitores) == false);


                        //Votos brancos
                        do
                        {
                            Console.WriteLine("Informe o total de votos brancos");
                            brancos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(brancos) == false)
                            {

                                Console.WriteLine("Informe um valor positivo!");

                            }

                        } while (exercicio.Validar(brancos) == false);
                        //Votos válidos
                        do
                        {
                            Console.WriteLine("Informe o total de votos válidos");
                            validos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(validos) == false)
                            {

                                Console.WriteLine("Informe um valor positivo!");

                            }

                        } while (exercicio.Validar(validos) == false);
                        //Votos nulos
                        do
                        {
                            Console.WriteLine("Informe o total de votos nulos");
                            nulos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(nulos) == false)
                            {

                                Console.WriteLine("Informe um valor positivo!");

                            }

                        } while (exercicio.Validar(nulos) == false);


                        //Fazer o cálculo
                        if (brancos + validos + nulos == totalEleitores)
                        {

                            Console.WriteLine("\nHá " + exercicio.PorcentagemVotos(brancos, totalEleitores) + "% de votos brancos"
                                             + "\nHá " + exercicio.PorcentagemVotos(nulos, totalEleitores) + "% de votos nulos"
                                             + "\nHá " + exercicio.PorcentagemVotos(validos, totalEleitores) + "% de votos validos");
                        }
                        else
                        {
                            Console.WriteLine("O total de eleitores é diferente da soma de brancos, validos e nulos.");

                        }
                        break;

                    case 6:
                        double salario;
                        double reajuste;
                        do
                        {
                            Console.WriteLine("Informe um salário");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(salario) == false)
                            {

                                Console.WriteLine("Informe um salário positivo!");
                            }//fim validação
                        } while (exercicio.Validar(salario) == false);

                        do
                        {
                            Console.WriteLine("Informe o porcentual de reajuste: ");
                            reajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(reajuste) == false)

                            {


                                Console.WriteLine("Informe um reajuste positivo! ");
                            }//Fim validação
                        } while (exercicio.Validar(reajuste) == false);



                        Console.WriteLine("O novo salário é: " + exercicio.AjusteSalario(salario, reajuste));
                        break;

                    case 7:
                        double custInicial = 0;
                        double imp = 0;
                        double dist = 0;
                        do
                        {
                            Console.WriteLine("Informe valor de fabricação");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(custInicial) == false)
                            {

                                Console.WriteLine("Informe um valor positivo!");
                            }//fim validação
                        } while (exercicio.Validar(salario) == false);

                        do
                        {
                            Console.WriteLine("Informe o imposto");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(imp) == false)
                            {

                                Console.WriteLine("Informe um salário positivo!");
                            }//fim validação
                        } while (exercicio.Validar(imp) == false);

                        do
                        {
                            Console.WriteLine("Informe o custo dstribuidor");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(dist) == false)
                            {

                                Console.WriteLine("Informe um salário positivo!");
                            }//fim validação
                        } while (exercicio.Validar(dist) == false);

                        //Mostrar

                        Console.WriteLine("O custo final é: R$ " +
                            (exercicio.CustoFinal(imp, custInicial +
                            exercicio.CustoFinal(dist, custInicial +
                            custInicial))));
                        break;

                    case 8:
                        double salarioFix;
                        double totalCarros;
                        double comissao;
                        double valorTotal;
                        do
                        {

                            Console.WriteLine("Informe salario fixo funcionário");
                            salarioFix = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(salarioFix) == false)
                            {

                                Console.WriteLine("Informe um valor positivo");
                            }


                        }while (exercicio.Validar(salarioFix) == false);

                        do
                        {

                            Console.WriteLine("Informe o valor do veiculo");
                            totalCarros = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(totalCarros) == false)
                            {

                                Console.WriteLine("Informe um valor positivo");
                            }


                        } while (exercicio.Validar(totalCarros) == false);

                        do
                        {

                            Console.WriteLine("Informe a comissão");
                            comissao = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(comissao) == false)
                            {

                                Console.WriteLine("Informe um valor positivo");
                            }


                        } while (exercicio.Validar(comissao) == false);

                        do
                        {

                            Console.WriteLine("Infomr valor total de vendas");
                            valorTotal = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(valorTotal) == false)
                            {

                                Console.WriteLine("Informe um valor positivo");
                            }


                        } while (exercicio.Validar(valorTotal) == false);
                        break;

                    default:


                        Console.WriteLine("Opção escolhida não é válida");
                        break;

                }
                }while (ConsultarOpcao != 0) ;
            
           }//Fim do método

        }//Fim classe
     }//fim projeto
