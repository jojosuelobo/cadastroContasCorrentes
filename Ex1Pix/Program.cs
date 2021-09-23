using System;

namespace Ex1Pix
{
    class Program
    {
        static void Main(string[] args)
        {
            menu1();
        }

        public static void menu1(){
            Console.WriteLine(" - SISTEMA PIX -");
            Console.WriteLine("Selecione uma das opções!");
            Console.WriteLine("[1]: Cadastrar pessoa física");
            Console.WriteLine("[2]: Cadastrar pessoa jurídica");
            Console.WriteLine("[3]: SAIR");
            Console.Write("-> ");
            int op = int.Parse(Console.ReadLine());
            switch(op){
                case 1:
                //CRIA PF
                    Console.Write("Informe o nome do cliente físico: ");
                    string nomePF = Console.ReadLine();
                    Console.Write("Informe o sobrenome do cliente físico: ");
                    string sobrenomePF = Console.ReadLine();
                    Console.Write("Informe o CPF do cliente: ");
                    string cpfPF = Console.ReadLine();
                    IPessoaEx pf1 = new PessoaFisicaEx(nomePF, sobrenomePF, cpfPF);
                //CRIA CC - PF
                    Console.Write("Informe o valor de saldo: ");
                    double saldoCC = double.Parse(Console.ReadLine());
                    ContaCorrenteEx cc1 = new ContaCorrenteEx(pf1, saldoCC); 
                    break;
                case 2:
                //CRIA PJ
                    Console.Write("Informe o nome do cliente jurídico: ");
                    string nomePJ = Console.ReadLine();
                    Console.Write("Informe o sobrenome do cliente jurídico: ");
                    string sobrenomePJ = Console.ReadLine();
                    Console.Write("Informe o CNPJ do cliente: ");
                    string cnpjPJ = Console.ReadLine();
                    Console.Write("Informe o valor de crédito do cliente: ");
                    float creditoPJ = float.Parse(Console.ReadLine());
                    IPessoaEx pj1 = new PessoaJuridicaEx(nomePJ, sobrenomePJ, cnpjPJ, creditoPJ);
                //CRIA CC - PJ
                    Console.Write("Informe o valor de saldo: ");
                    double saldoCC2 = double.Parse(Console.ReadLine());
                    ContaCorrenteEx cc2 = new ContaCorrenteEx(pj1, saldoCC2);
                    break;
                case 3:
                    Console.WriteLine("Obrigado por usar!");
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!!!");
                    break;    
            }
        }   


    }
}
