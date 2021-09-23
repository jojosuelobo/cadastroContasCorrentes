using System;
namespace Ex1Pix
{
    public class ContaCorrenteEx{
        IPessoaEx correntista{get; set;}
        public double saldo{get; set;}

        public ContaCorrenteEx(IPessoaEx correntista, double saldo){
           this.correntista = correntista;
           this.saldo = saldo; 
        }

        public void AdicionarPF(IPessoaEx correntista){
            this.correntista = correntista;
        }
        public void imprimiPF(){
            Console.WriteLine("\n- DADOS DO CLIENTE FISICO -");
            Console.WriteLine($"Nome: {correntista.nome}");
            Console.WriteLine($"Sobrenome: {correntista.sobrenome}");
            Console.WriteLine($"CPF: {(correntista as PessoaFisicaEx).cpf}");
            if((correntista as PessoaFisicaEx).status)
                Console.WriteLine($"CPF VÁLIDO");
            else
                Console.WriteLine($"CPF INVÁLIDO");
            Console.WriteLine($"Saldo: {saldo}");
        }

        public void AdicionarPJ(IPessoaEx correntista){
            this.correntista = correntista;
        }
        public void imprimiPJ(){
            Console.WriteLine("\n- DADOS DO CLIENTE JURIDICO -");
            Console.WriteLine($"Nome: {correntista.nome}");
            Console.WriteLine($"Sobrenome: {correntista.sobrenome}");
            Console.WriteLine($"CNPJ: {(correntista as PessoaJuridicaEx).cnpj}");
            Console.WriteLine($"Crédito: {(correntista as PessoaJuridicaEx).credito}");
            Console.WriteLine($"Saldo: {saldo}");
        }




    }
}