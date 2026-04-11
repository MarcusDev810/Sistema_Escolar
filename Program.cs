namespace Sistema_Escolar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Aluno{

    public int Codigo{ get; private set;}
    public string Nome{ get; private set; }
    public double Nota{get; private set; }

    public Alunos(int codigo, string nome, double nota ){
        this.Codigo = codigo;
        this.Nome = nome;
        this.Nota = nota;
    }

}

