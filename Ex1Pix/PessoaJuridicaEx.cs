namespace Ex1Pix
{
    public class PessoaJuridicaEx : IPessoaEx{
        public string nome{get; set;}
        public string sobrenome{get; set;}
        public string cnpj;
        public bool status;
		public float credito{get; set;}
        public PessoaJuridicaEx(string nome, string sobrenome, string cnpj, float credito){
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cnpj = cnpj;
            this.status = validarDados(this.cnpj);
			this.credito = credito;
        }

        public bool validarDados(string cnpj){
            int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
			int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
			   return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for(int i=0; i<12; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if ( resto < 2)
			   resto = 0;
			else
			   resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
			    resto = 0;
			else
			   resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
        }


    }
}