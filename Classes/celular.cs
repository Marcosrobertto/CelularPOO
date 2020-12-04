using System;

namespace CelularPOO.Classes
{
    public class celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;
        public bool deslidado;
        public bool mensagens;
        public bool ligacoes;

        public void Ligar(bool ligado) {
            if (ligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("Celular está desligado!");
            }
        }

        public void Desligar(bool desligado) {
            if (deslidado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("Celular está desligado!");
            }
        }

        public void Mensagem(bool mensagem) {
            if(mensagem == true){
                Console.WriteLine("Escrever a mensagem: ");
                string mensagens = Console.ReadLine();

                Console.WriteLine("Mensagem foi enviada!");
            }else{
                Console.WriteLine("Mensagem cancelada, tente novamente!");
            }
        }

        public void FazerLigacao(bool ligacao){
            if(ligacao == true){
                Console.WriteLine("Para quem?");
                string quem = Console.ReadLine();
                Console.WriteLine("Ligando!");
                Console.WriteLine($"A(O) {quem} ligação recusada, deixe seu recado ou será sujeito a cobraça após o sinal");
            }else{
                Console.WriteLine("ligue novamente depois");
            }
        }
    }
}