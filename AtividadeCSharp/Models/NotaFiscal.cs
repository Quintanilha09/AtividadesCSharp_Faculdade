namespace AtividadeCSharp.Models
{
    public class NotaFiscal
    {
        public int Numero { get; private set; }
        public decimal Valor { get; private set; }
        public PessoaFisica ClientePF { get; private set; }
        public PessoaJuridica ClientePJ { get; private set; }

        public NotaFiscal(int numero, decimal valor, PessoaFisica cliente)
        {
            Numero = numero;
            Valor = valor;
            ClientePF = cliente;
            ClientePJ = null;
        }

        public NotaFiscal(int numero, decimal valor, PessoaJuridica cliente)
        {
            Numero = numero;
            Valor = valor;
            ClientePF = null;
            ClientePJ = cliente;
        }
    }
}
