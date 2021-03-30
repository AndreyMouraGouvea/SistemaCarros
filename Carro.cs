using System;

namespace SistemaCarrosClasse
{

    class Carro : Veiculo
   {
        //  atributos
       private int capacidadePortaMala;
       private Boolean bagageiro;
       private int numero_assentos;

        //  construtor
        public Carro(int capacidadePortaMala, Boolean bagageiro, int numero_assentos)
        : base(modelo, fabricante, ano, cor, numero_portas)
        {   
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.numero_assentos = numero_assentos;
        }
        public int capacidadePortaMala{
            get { return this.capacidadePortaMala; }
            set { capacidadePortaMala = value;}
        }
   }



   
    
}