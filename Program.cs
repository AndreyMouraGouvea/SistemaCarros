using System;

namespace SistemaCarrosClasse
{

     class Veiculo
   {
         //atributo da classe
       public string modelo;
       public string fabricante;
       public int ano;
       public string cor;
       public int numero_portas;
       public int capacidadePortaMala;
       public Boolean bagageiro;
       public int numero_assentos;
       public int numero_eixos;
       public double peso_maximo_carga;
       public double quilometragem;
       public string tipo_carteira;
    
        //construtor com parâmetros
        public Veiculo (string modelo, string fabricante, int ano, string cor, int numero_portas){
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
        }
        public string Modelo{
            get{
                return this.modelo;
            }
            set{
                modelo = value;
            }
        }
         public string Fabricante{
            get{
                return this.fabricante;
            }
            set{
                fabricante = value;
            }
        }
         public int Ano{
            get{
                return this.ano;
            }
            set{
                ano = value;
            }
        }
        public string Cor{
            get{
                return this.cor;
            }
            set{
                cor = value;
            }
        }
        public int Numero_Portas{
            get{
                return this.numero_portas;
            }
            set{
                numero_portas = value;
            }
        }

    }
     class Carro : Veiculo
   {
        //  atributos
        private int capacidadePortaMala;
       private Boolean bagageiro;
       private int numero_assentos;


        //  construtor
        public Carro(string modelo, string fabricante, int ano, string cor, int numero_portas, int capacidadePortaMala,Boolean bagageiro, int numero_assentos)
        : base(modelo, fabricante, ano, cor, numero_portas)
        {   
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.numero_assentos = numero_assentos;
        }
        public int CapacidadePortaMala{
            get { return this.capacidadePortaMala; }
            set { capacidadePortaMala = value;}
        }
         public Boolean Bagageiro{
            get { return this.bagageiro; }
            set { bagageiro = value;}
        }
        public int Numero_assentos{
            get { return this.numero_assentos; }
            set { numero_assentos = value;}
        }
   }
   class Caminhao : Veiculo
   {    

       private int numero_eixos;
       private double peso_maximo_carga;

       private char tipo_carteira; 

       public Caminhao(string modelo, string fabricante, int ano, string cor, int numero_portas, int numero_eixos, double peso_maximo_carga, char tipo_carteira)
        : base(modelo, fabricante, ano, cor, numero_portas)
        {
            this.numero_eixos = numero_eixos;
            this.peso_maximo_carga = peso_maximo_carga;
            this.tipo_carteira = tipo_carteira;
        }
        public int Numero_eixos{
            get { return this.numero_eixos; }
            set { numero_eixos = value;}
        }
        public double Peso_maximo_carga{
            get { return this.peso_maximo_carga; }
            set { peso_maximo_carga = value;}
        }
        public char Tipo_carteira{
            get { return this.tipo_carteira; }
            set { tipo_carteira = value;}
        }
   }


    class Program
    {
        
        static void Main(string[] args)
        {
            int x=0, y=0, menu;
            string s;
            Carro[] carro= new Carro[300];
            Caminhao[] caminhao=new Caminhao[200];
            // caminhao[y] = new Caminhao();
            // 
            // 
            do
            {                
                Console.Clear();
                Console.WriteLine("1-Cadastro de Carro");
                Console.WriteLine("2-Cadastro de Caminhão");
                Console.WriteLine("3-Consulta por Placa");
                Console.WriteLine("4-Consulta Caminhão por Modelo/Fabricante");
                Console.WriteLine("5-Consulta Carro por Cor");
                Console.WriteLine("6-Exibir Todos os Carros Cadastrados");
                Console.WriteLine("7-Exibir Todos os Caminhões Cadastrados");
                Console.WriteLine("0-Sair");
                Console.WriteLine("Digite Sua Opção: ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(menu)
                {
                    case 1:
                        do{
                          carro[x] = new Carro();  
                          Console.WriteLine("-------Cadastrar Carro-------")  ;
                          Console.Write("Modelo: ");
                          carro[x].Modelo = Console.ReadLine();
                          Console.Write("Marca/Fabricante: ");
                          carro[x].Fabricante = Console.ReadLine();
                          Console.Write("Ano: ");
                          carro[x].Ano = int.Parse(Console.ReadLine());
                          Console.Write("Cor: ");
                          carro[x].Cor = Console.ReadLine();
                          Console.Write("Numero de Portas: ");
                          carro[x].Numero_Portas = int.Parse(Console.ReadLine());
                          Console.Write("Capacidade Porta Mala: ");
                          carro[x].CapacidadePortaMala = int.Parse(Console.ReadLine());
                          Console.Write("Bagageiro: SIM/NAO");
                          carro[x].Bagageiro = bool.Parse(Console.ReadLine());
                          Console.Write("Numero de Assentos: ");
                          carro[x].Numero_assentos = int.Parse(Console.ReadLine());
                            Console.Write("Os Dados Estão Corretos? SIM/NAO");
                            s = Console.ReadLine();
                        }while (s.ToUpper() != "SIM");
                        x++;
                        break;
                    case 2:
                        do{
                            caminhao[y] = new Caminhao();
                            Console.WriteLine("-------Cadastrar Caminhão-------")  ;
                            Console.Write("Modelo: ");
                            caminhao[y].Modelo = Console.ReadLine();
                            Console.Write("Marca/Fabricante: ");
                            caminhao[y].Fabricante = Console.ReadLine();
                            Console.Write("Ano: ");
                            caminhao[y].Ano = int.Parse(Console.ReadLine());
                            Console.Write("Cor: ");
                            caminhao[y].Cor = Console.ReadLine();
                            Console.Write("Numero de Portas: ");
                            caminhao[y].Numero_Portas = int.Parse(Console.ReadLine());
                            // numero eixos, peso maximo carga
                            Console.Write("Número de Eixos: ");
                            caminhao[y].Numero_eixos = int.Parse(Console.ReadLine());
                            Console.Write("Peso Máximo Carga: ");
                            caminhao[y].Peso_maximo_carga = double.Parse(Console.ReadLine());
                            // tipo carteira
                            Console.Write("Tipo Carteira: ");
                            caminhao[y].Tipo_carteira = char.Parse(Console.ReadLine());
                        }
                
                }
            }
        }
    }
}
