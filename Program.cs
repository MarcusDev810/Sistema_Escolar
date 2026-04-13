namespace Sistema_Escolar;

class Program{
    static void Main(){

        ListaEstatica lista = new ListaEstatica();
        int opcao;


        do{
            Console.Clear();
            opcao = Menu();

            switch (opcao){
                case 1: 
                    lista.Imprimir();
                    Thread.Sleep(6000);
                break;

                case 2: 
                    Adicionar(lista);
                break;

                case 3: 
                    Buscar(lista);
                break;

                case 4: 
                    Console.Clear();
                    Console.WriteLine("A lista de aluno será ordenada.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    lista.Ordenar();
                    Console.WriteLine("A lista de alunos foi ordenada!!!");
                break;
   
            }

            
        } while (opcao != 0);

        
    }

    static void Adicionar(ListaEstatica lista){

            string nome;
            int codigo;
            double nota;

            Console.Clear();
            Console.WriteLine("===== ADICIONAR =====");
            Console.WriteLine("Qual o nome do aluno?:");
            nome = Console.ReadLine();

            Console.WriteLine("Qual 0 código dele?:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota dele?:");
            nota = double.Parse(Console.ReadLine());

            lista.Adicionar_Final(codigo, nome, nota);

            Console.Clear();
            Console.WriteLine("Aluno adicionado!");
            Thread.Sleep(2000);
    }

    static void Buscar(ListaEstatica lista){
                    
        Console.Clear();
        Console.WriteLine("Você deseja fazer qual tipo de busca?");
        Console.WriteLine("1 - Por código Linear (Sequêncial)");
        Console.WriteLine("2 - Por código Binário (Recursivo)");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção desejada:");

        string? input = Console.ReadLine();

        //Verificação de entrada de dados
        if(!int.TryParse(input, out int res) || res < 0 || res > 2){    //Se a string não virar int, for menor que 0 ou maior que 3, ele dá erro e volta para função.
            Console.Clear();
            Console.WriteLine("Opção invalida, tente novamente:");
            Thread.Sleep(2500);
            Console.Clear();
            Buscar(lista);
        }

        if(input == "1"){
            Console.Clear();

            Console.WriteLine("Qual o código do aluno?");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Buscando aluno");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            lista.Buscar_Codigo_Seq(codigo);
        }

        if(input == "2"){
            Console.Clear();

            Console.WriteLine("O código será ordenado automaticamente para o uso da pesquisa binária.");
            lista.Ordenar();

            Console.WriteLine("Qual o código do aluno?");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Buscando aluno.");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            lista.Buscar_Codigo_Bin(codigo);
        }

        if (input == "0"){
            return;
        }
    }

    static int Menu(){
        Console.Clear();

        Console.WriteLine("====> Sistemas de Alunos <====");
        Console.WriteLine("1 - Listar alunos");
        Console.WriteLine("2 - Cadastrar aluno");
        Console.WriteLine("3 - Buscar aluno");
        Console.WriteLine("4 - Ordenar lista de alunos por código");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção desejada:");

        string? input = Console.ReadLine();

        if(!int.TryParse(input, out int res) || res < 0 || res > 6){
            Console.Clear();
            Console.WriteLine("Opção invalida, tente novamente:");
            Thread.Sleep(2500);
            Console.Clear();
            res = Menu();
        }
        return res;   
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

    public void Adicionar_Final(int codigo, string nome, double nota){
    //Função que adiciona uma tarefa na posição final da lista
        if(Tam == Tam_Max){
            return;
        }

        aluno[Tam] = new Alunos(codigo, nome, nota);
        Tam++;
    }

    public void Imprimir(){
    //Função que imprime a lista de tarefas
        Console.Clear();
        if(Tam == 0){
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Lista de alunos Vazia");
            Console.WriteLine("=========================================================================");
            return;
        }

        Console.WriteLine("=========================================================================");

        for(int i = 0; i < Tam; i++){
            Console.WriteLine($"Código: {aluno[i].Codigo}  |  Nome: {aluno[i].Nome}  |  Nota: {aluno[i].Nota}");
        }

        Console.WriteLine("=========================================================================");
    }

    public void Buscar_Codigo_Seq(int codigo){
    //Função que busca e retorna a posição do aluno com o código indicado

        for( int i = 0; i < Tam; i++){
            if(aluno[i].Codigo == codigo){

                Console.Clear();
                Console.WriteLine("=========================================================================");
                Console.WriteLine($"Código: {aluno[i].Codigo}  |  Nome: {aluno[i].Nome}  |  Nota: {aluno[i].Nota}");
                Console.WriteLine("=========================================================================");
                Thread.Sleep(5000);
                return ;
            }
        }

        Console.WriteLine("Aluno não encontrado");
        return ;  
        
    }

    public void Ordenar(){
        
        for(int i = 0; i < Tam; i++){

            for(int j = 0; j < Tam - 1; j++){
                
                if(aluno[j].Codigo > aluno[j + 1].Codigo){
                    
                    var temp = aluno[j];
                    aluno[j] = aluno[j + 1];
                    aluno[j + 1] = temp;

                }
            }
        }
    }

    public void Buscar_Codigo_Bin(int codigo){
        
        Buscar_Codigo_Bin_Ex(codigo, 0, Tam - 1);
    }

    public void Buscar_Codigo_Bin_Ex(int codigo, int esq, int dir){

        if(esq > dir){
            Console.Clear();
            Console.WriteLine("Aluno não encontrado");      //caso base       
            Thread.Sleep(4000);
            return;
        }

        int meio = (esq + dir)/2;

        if(aluno[meio].Codigo == codigo){
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine($"Código: {aluno[meio].Codigo}  |  Nome: {aluno[meio].Nome}  |  Nota: {aluno[meio].Nota}");
            Console.WriteLine("=========================================================================");
            Thread.Sleep(5000);
            return;
        }

        if(codigo < aluno[meio].Codigo){
            Buscar_Codigo_Bin_Ex(codigo, esq, meio - 1);
        }
        else
        {
            Buscar_Codigo_Bin_Ex(codigo,meio + 1, dir);
        }       
    }
}

//OBS: Programar sem separar os objetos por arquivos é muito difícil. Obrigado POO :)