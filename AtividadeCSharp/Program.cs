using System;
using AtividadeCSharp.Models;

namespace AtividadeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica("João", "123.456.789-00");
            PessoaJuridica pessoaJuridica = new PessoaJuridica("Empresa XYZ", "12.345.678/0001-00");

            NotaFiscal notaFiscal1 = new NotaFiscal(1, 100.0m, pessoaFisica);
            NotaFiscal notaFiscal2 = new NotaFiscal(2, 200.0m, pessoaJuridica);

            Console.WriteLine("Nota Fiscal 1 - Cliente: " + notaFiscal1.ClientePF.Nome);
            Console.WriteLine("Nota Fiscal 2 - Cliente: " + notaFiscal2.ClientePJ.RazaoSocial);
        }
    }
}
