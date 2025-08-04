using System;

public class Seller {
	string nome;
	string registro;
	string locTrab;
	double valVend;
	string venda;

	public void cadastroVendedor () {
		Console.WriteLine("Digite seu nome: ");
		nome = Console.ReadLine();
		Console.WriteLine("Digite seu registro: ");
		registro = Console.ReadLine();
		Console.WriteLine("Digite seu local de trabalho: ");
		locTrab = Console.ReadLine();
	}

	public void cadastro_Venda () {
	    double somatorio;
        Console.WriteLine("Insira o que foi vendido: ");
        somatorio = Console.ReadLine();
        Console.WriteLine("Insira o valor: ");
        valVend = Convert.ToDouble(Console.ReadLine());
        valVend = valVend + somatorio;
	    }

	public double comissao () {
	    double comission;
	    comission = (valVend*0.05);
	    Console.WriteLine($"Sua comissC#o foi de:{comission}");
	    return comission;
	}

	public void imprimirInfo () {
	    Console.WriteLine("Nome: "+nome);
	    Console.WriteLine("Registro: "+registro);
	    Console.WriteLine("Local de trabalho: "+locTrab);
	    Console.WriteLine("Venda: "+venda);
	    Console.WriteLine("Valor da Venda"+valVend);
	    Console.WriteLine("Comissão: "+comission);
	}

    public void menu () {
        Console.WriteLine("_______BEM-VINDO_______");
        Console.WriteLine("1-Cadastrar Vendedor");
        Console.WriteLine("2-Cadastrar Venda");
        Console.WriteLine("3-Calcular Comissão");
        Console.WriteLine("4-Imprimir Informação");
        Console.WriteLine("0-Sair");
    }

	static void Main() {
		Seller vendedor = new Seller ();
		vendedor.cadastroVendedor();
		vendedor.imprimirInfo();
	}
}
