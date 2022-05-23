using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] contas = { 1, 2, 3, 4, 5 };
            double[] saldo = { 100000, 100000, 100000, 100000, 100000 };

           
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------------MENU-------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1- Sacar");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {
                if(opcao == (int)Operacao.Sacar)
                {
                    Console.WriteLine("Por favor, informe a conta para saque:");
                    int contaSaque = Convert.ToInt32(Console.ReadLine());
                    
                    for(int i = 0; i < contas.Length; i++)
                    {
                        if(contaSaque == contas[i])
                        {
                            Console.WriteLine("informe o valor que deseja sacar");
                            double valorSaque = Convert.ToDouble(Console.ReadLine());
                            if (saldo[i] >= valorSaque)
                            {
                                saldo[i] = saldo[i] - valorSaque;
                                Console.WriteLine("saque efetuado com sucesso!!!");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                            }
                        }
                    }
                }
                else if (opcao == (int)Operacao.Depositar)
                {
                    Console.WriteLine("Por favor digite a conta que você deseja efetuar o deposito");
                    int contaSaque = Convert.ToInt32(Console.ReadLine());
                    
                    for(int i = 0; i < contas.Length; i++)
                    {
                        if (contaSaque == contas[i])
                        {
                            Console.WriteLine("Informe o valor que você deseja depositar");
                            double ValorDeposito = Convert.ToDouble(Console.ReadLine());
                            saldo[i] = saldo[i] + ValorDeposito;
                            Console.WriteLine("Valor depositado com sucesso!!!");
                        }
                    }
                }
                else if(opcao == (int)Operacao.Transferir)
                {
                    Console.WriteLine("Digite a conta de origem de sua transferencia");
                   int ContaOrigem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a conta de Destino de sua transferencia");
                    int ContaDestino = Convert.ToInt32(Console.ReadLine());

                   int contaOrigemEncontrada = -1;
                    int posicaoOrigem = 0;

                    int ContaDestinoEncontrada = -1;
                    int PosicaoDestino = 0;

                    if(ContaOrigem != ContaDestino)
                    {
                        for(int i = 0; i < 5; i++)
                        {
                            if(ContaOrigem == contas[i])
                            {
                                Console.WriteLine("conta origem encontrada!!!");
                                contaOrigemEncontrada = contas[i];
                                posicaoOrigem = i;
                            }
                            if(ContaDestino == contas[i])
                            {
                                Console.WriteLine("conta destino encontrada!!!");
                                ContaDestinoEncontrada = contas[i];
                                PosicaoDestino = i;
                            }
                            if ((contaOrigemEncontrada >= 0 && ContaDestinoEncontrada >=0))
                            {
                                Console.WriteLine("Informe o valor para transferência");
                                double valorTransfer = Convert.ToDouble(Console.ReadLine());
                                if (contas[posicaoOrigem] >= valorTransfer)
                                {
                                    saldo[posicaoOrigem] = saldo[posicaoOrigem] - valorTransfer;
                                    saldo[PosicaoDestino] += valorTransfer;
                                    Console.WriteLine("Valor transferido");
                                }
                            }
                        




                            else
                            {
                                Console.WriteLine("Uma das contas ou as duas não foram encontradas.");
                            }

                           
                        }


                        
                         
                        
                    }
                    else
                    {
                        Console.WriteLine("Informe contas diferentes para a operação.");
                    }


                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("------------------MENU-------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Sacar");
                Console.WriteLine("2- Depositar");
                Console.WriteLine("3- Transferir");
                Console.WriteLine("0 - Sair");
                 opcao = Convert.ToInt32(Console.ReadLine());

            }
        }
        
    }
    enum Operacao
    {
        Sair,
        Sacar,
        Depositar,
        Transferir,
    }
}


        
        
       
            

    
        

