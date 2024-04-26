namespace Controle_de_Contas_Bancarias;

class Program
{
	static void Main()
	{
		ContaPoupanca contaPoupanca = new ContaPoupanca { NumeroDaConta = 32232, Saldo = 20520, TaxaDeJuros = 0.07 };
		ContaCorrente contaCorrente = new ContaCorrente(082212, 2250, 8);

		contaPoupanca.Depositar(920);
		contaPoupanca.Sacar(4340);
		contaPoupanca.AplicarJuros();

		contaCorrente.Depositar(3945);
		contaCorrente.Sacar(1090);
		
		Console.WriteLine("Saldo total da conta poupança: " + contaPoupanca.Saldo);
		Console.WriteLine("Saldo total da conta corrente: " + contaCorrente.Saldo);
	}
}