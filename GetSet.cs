using System;

class programa {
    string CPF;
	string nome;
	char sexo;
	int idade;
    
    public string getCPF () {
		return CPF;
	}

	public void setCPF() {
		CPF = Console.ReadLine();
	}

	public string getNome() {
		return nome;
	}

	public void setNome() {
		nome = Console.ReadLine();
	}

	public char getSexo() {
		return sexo;
	}

	public void setSexo() {
		sexo = Console.ReadLine();
	}

	public int getIdade() {
		return idade;
	}

	public void setIdade() {
		idade = Console.ReadLine();
	}
	
    public int funcaoMenu() {
    int op;
		Console.WriteLine("______bien-vienidos______");
		Console.WriteLine("1- Criar Pessoa");
		Console.WriteLine("2- Mostrar Pessoa");
		Console.WriteLine("0- Sair");
		Console.WriteLine("Digite sua opção: ");
		int.Parse(Console.ReadLine());
		return op;
	}
	public void funcaoImprimir() {
		Console.WriteLine("Nome: "+nome);
		Console.WriteLine("CPF: "+CPF);
		Console.WriteLine("Sexo: "+sexo);
		Console.WriteLine("Idade: "+idade);
	}
	
	static void Main () {
		Pessoa A = new Pessoa();
		do {
			op = funcaoMenu();
			switch (op) {
			case 1:
				Console.WriteLine("CPF: ");
				A.setCPF();
				A.getCPF();
				Console.WriteLine("Nome: ");
				A.setNome();
				A.getNome();
				Console.WriteLine("Sexo: (M/F)");
				A.setSexo();
				A.getSexo();
				Console.WriteLine("Idade: ");
				A.setIdade();
				A.getIdade();
				break;

			case 2:
				op = funcaoImprimir();
				break;
			}

		}
		while (op!=0);

	}
}
