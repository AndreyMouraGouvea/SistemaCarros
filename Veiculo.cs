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
        
   
}
