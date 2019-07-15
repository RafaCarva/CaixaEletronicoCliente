using CaixaEletronico09;
using System;


namespace CaixaEletronicoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var caixaEletronico = new CaixaEletronico();
            bool executandoSistema = true;

            //Loop de execução do sistema
            do
            {
                ExecutarAcaoDeMenu();
            } while (executandoSistema);

            //Encera a aplicação caso o usuário decida encerrar o sistema via opção de menu
            Environment.ExitCode = -1;

            //Funções auxiliares de execução do sistema
            void ExecutarAcaoDeMenu()
            {
                switch (ExibirMenu())
                {
                    //Carregar caixa
                    case 1:
                        Console.Write("Digite:\n" +
                            "10 - Para inserir notas de R$10,00\n" +
                            "20 - Para inserir notas de R$20,00\n" +
                            "50 - Para inserir notas de R$50,00\n"
                            );
                        var nota = int.Parse(Console.ReadLine());

                        if (nota != 10 && nota != 20 && nota != 50)
                        {
                            do
                            {
                                Console.WriteLine("Valor inválido!\n" +
                                "Esse caixa suporta apenas notas de 10, 20 ou 50.");
                                Console.Write("Digite:\n" +
                                "10 - Para inserir notas de R$10,00\n" +
                                "20 - Para inserir notas de R$20,00\n" +
                                "50 - Para inserir notas de R$50,00\n"
                                );
                                nota = int.Parse(Console.ReadLine());

                            } while (nota != 10 && nota != 20 && nota != 50);

                        }
                        Console.WriteLine("Digite a Quantidade de notas de R$" + nota + ",00 que serão inseridas no caixa:\n");
                        var quantidade = int.Parse(Console.ReadLine());
                        caixaEletronico.carregar.CarregaCaixa(caixaEletronico.cofre, nota, quantidade);
                        break;

                    //Sacar
                    case 2:
                        Console.WriteLine("Digite o valor que deseja sacar:\n");
                        var valor = int.Parse(Console.ReadLine());
                        caixaEletronico.sacar.sacarDinheiro(caixaEletronico.cofre, valor);
                        break;

                    //Ver saldo
                    case 3:
                        Console.WriteLine("Saldo do caixa:\n" + caixaEletronico.cofre);
                        break;
                    //Sair
                    case 4:
                        Console.WriteLine("==========APLICAÇÃO ENCERRADA==========");
                        executandoSistema = false;
                       
                        break;
                }
            }
            
            int ExibirMenu()
            {
                Console.Write("==========CAIXA ELETRÔNICO==========\n"
                    + "Digite o número:\n"
                    + "1 - Para CARREGAR o caixa\n"
                    + "2 - Para SACAR\n"
                    + "3 - Ver SALDO do caixa\n"
                    + "4 - Para SAIR\n"
                    );
                int opcao = int.Parse(Console.ReadLine());
                return opcao;
            }


        }
    }
}
