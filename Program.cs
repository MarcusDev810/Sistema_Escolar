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

//Criação da Lista estática
public class ListaEstatica{ 

        private int Tam = 0;
        private int Tam_Max;
        private Tarefas[] tarefa;

    public ListaEstatica(){     
        //Construtor da classe

        this.Tam = 0;
        this.Tam_Max = 1000;
        this.tarefa = new Tarefas[Tam_Max];
    }

    public int Tamanho(){       
    //Função que retorna o tamanho da lista
        return Tam;
    }
    

}