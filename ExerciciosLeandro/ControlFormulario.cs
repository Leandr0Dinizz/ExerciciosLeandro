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
                               "9. Exercício 09\n" +
                               "10. Exercício 10\n" +
                               "11. Exercício 11\n" +
                               "12. Exercício 12\n" +
                               "13. Exercício 13\n" +
                               "14. Exercício 14\n" +
                               "15. Exercício 15\n" +
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


                        } while (exercicio.Validar(salarioFix) == false);

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

                            Console.WriteLine("Informe valor total de vendas");
                            valorTotal = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.Validar(valorTotal) == false)
                            {

                                Console.WriteLine("Informe um valor positivo");
                            }


                        } while (exercicio.Validar(valorTotal) == false);
                        Console.WriteLine("O salário total é: " +
                                         (exercicio.Comissao(totalCarros, comissao) +
                                          exercicio.TotalComVendas(valorTotal) + salarioFix));
                        break;

                    case 9:
                        do
                        {
                            Console.WriteLine("Informe um número");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(num1) == false)
                            {

                                Console.WriteLine("O número é invalido");
                            }
                        } while (exercicio.Validar(num1) == false);

                        if (exercicio.Pimp(num1) == 0)
                        {

                            Console.WriteLine("O número " + num1 + " É PAR ");
                        }
                        else
                        {

                            Console.WriteLine("O número " + num1 + " É IMPÁR ");
                        }
                        break;

                    case 10:
                        int idade;
                        do
                        {
                            Console.WriteLine("Informe sua idade");
                            idade = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(idade) == false)
                            {

                                Console.WriteLine("Informe um número válido");


                            }

                        } while (exercicio.Validar(idade) == false);

                        if (idade >= 18)
                        {

                            Console.WriteLine("é maior de idade");
                        }
                        else
                        {
                            Console.WriteLine("é menor de idade");

                        }
                        break;

                    case 12:
                        int ano;
                        do
                        {
                            Console.WriteLine("Informe o ano");
                            ano = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.Validar(ano) == false)
                            {

                                Console.WriteLine("O ano  é invalido");
                            }
                        } while (exercicio.Validar(ano) == false);

                        if (exercicio.BiAno(ano) == 0)
                        {

                            Console.WriteLine("É Bissexto");
                        }
                        else
                        {
                            Console.WriteLine("Não é Bissexto");
                        }
                        break;

                    case 13:
                        double notaa1;
                        double notaa2;
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            notaa1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.validarNotas(notaa1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim validação
                        } while (exercicio.validarNotas(notaa1) == true);//agora o while enxerga a variável

                        do
                        {
                            Console.WriteLine("Informe a segunda nota:  ");
                            notaa2 = Convert.ToDouble(Console.ReadLine());


                            if (exercicio.validarNotas(notaa2) == true)
                            {

                                Console.WriteLine("Informe uma nota entre 0 e 10");

                            }//fim da validação
                        } while (exercicio.validarNotas(notaa2) == true);


                        if (exercicio.NotasAluno(notaa1, notaa2) >= 7)
                        {
                            Console.WriteLine("Você está aprovado ");
                        }
                        else
                        {
                            Console.WriteLine("Você está reprovado");
                        }
                        break;

                    case 14:
                        double medida1;
                        double medida2;
                        double medida3;
                        do
                        {
                            Console.WriteLine("Informe a primeira medida:  ");
                            medida1 = Convert.ToInt32(Console.ReadLine());

                            if (exercicio.Validar(medida1) == false)
                            {

                                Console.WriteLine("Medida inválida");

                            }
                        } while (exercicio.Validar(medida1) == false);

                        do
                        {
                            Console.WriteLine("Informe a segunda medida:  ");
                            medida2 = Convert.ToInt32(Console.ReadLine());


                            if (exercicio.Validar(medida2) == false)
                            {

                                Console.WriteLine("Medida inválida");

                            }
                        } while (exercicio.Validar(medida2) == false);

                        do
                        {
                            Console.WriteLine("Informe a primeira medida:  ");
                            medida3 = Convert.ToInt32(Console.ReadLine());


                            if (exercicio.Validar(medida3) == false)
                            {

                                Console.WriteLine("Medida inválida");

                            }
                        } while (exercicio.Validar(medida3) == false);

                        if ((medida1 == medida2) && (medida2 == medida3))
                        {
                            Console.WriteLine("O triângulo é equilátero");
                        }
                        else if ((medida1 == medida2) || ((medida1 == medida3)) || (medida2 == medida3))
                        {
                            Console.WriteLine("É Isósceles");
                        }
                        else
                        {
                            Console.WriteLine("É escaleno");
                        }
                        break;


                    case 15:
                        double numpn;
                        Console.WriteLine("Informe um número");
                        numpn = Convert.ToDouble(Console.ReadLine());
                        if (numpn < 0)
                        {
                            Console.WriteLine("O número é negativo");
                        }
                        else
                        {
                            Console.WriteLine("O número é positivo");
                        }


                        break;
                    default:


                        Console.WriteLine("Opção escolhida não é válida");
                        break;

                }
                }while (ConsultarOpcao != 0) ;

            }//Fim do método

        }//Fim classe
     }//fim projeto
