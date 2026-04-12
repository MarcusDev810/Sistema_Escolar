namespace Sistema_Escolar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Alunos{

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
        private Alunos[] aluno;

    public ListaEstatica(){     
        //Construtor da classe

        this.Tam = 0;
        this.Tam_Max = 1000;
        this.aluno = new Alunos[Tam_Max];
    }

    public int Tamanho(){       
    //Função que retorna o tamanho da lista
        return Tam;
    }
    
    public void Adicionar_Inicio(int codigo, string nome, double nota){       
    //Função que adiciona um aluno ao inicío da lista
        if(Tam == Tam_Max){
            return;
        }

        for(int i = Tam; i > 0; i--){
            aluno[i] = aluno[i - 1];       
        }

        aluno[0] = new Alunos(codigo, nome, nota);
        Tam++;
    }

    public void Adicionar_Pos(int pos, int codigo, string nome, double nota){
    //Função que adiciona uma tarefa na posição indicada
        if(pos < 0 || pos > Tam){
            return;
        }
         
        if(Tam == Tam_Max){
            return;
        }

        for(int i = Tam; i > pos; i--){
            aluno[i] = aluno[i - 1];
        }

        aluno[pos] = new Tarefas(codigo, nome, nota);
        Tam++;
    }

    public void Adicionar_Final(int codigo, string nome, double nota){
    //Função que adiciona uma tarefa na posição final da lista
        if(Tam == Tam_Max){
            return;
        }

        tarefa[Tam] = new Tarefas(codigo, nome, nota);
        Tam++;
    }
}