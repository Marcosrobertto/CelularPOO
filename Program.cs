using System;

using CelularPOO.Classes;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular1 = new celular();
            string escolha;

                do
                {
                    Console.Write("O celular está ligado? S/N: ");
                    escolha = Console.ReadLine();

                    if(escolha.ToLower() == "s"){
                    celular1.ligado = true;

                    Console.Write("Digite a cor do celular: ");
                    celular1.cor = Console.ReadLine();

                    Console.Write("Digite o modelo do celular: ");
                    celular1.modelo = Console.ReadLine();

                    Console.Write("Digite o tamanho do celular: ");
                    celular1.tamanho = Console.ReadLine();

                    Console.WriteLine("Deseja enviar alguma mensagem? S/N: ");
                    string resposta = Console.ReadLine();

                    if(resposta.ToLower() == "s"){
                        celular1.mensagens = true;
                        celular1.Mensagem(celular1.mensagens);
                    }else{
                        celular1.mensagens = false;
                        celular1.Mensagem(celular1.mensagens);
                    }

                    Console.WriteLine("Deseja fazer alguma ligação? S/N: ");
                    string resposta2 = Console.ReadLine();
                    if(resposta2.ToLower() == "s"){
                        celular1.ligacoes = true;
                        celular1.FazerLigacao(celular1.ligacoes);
                    }else{
                        celular1.ligacoes = false;
                        celular1.FazerLigacao(celular1.ligacoes);
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("_-_-_-Informações do Celular-_-_-_");
                    Console.WriteLine();
                    Console.WriteLine("Cor do Celular: " + celular1.cor);
                     Console.WriteLine("Modelo do Celular: " + celular1.modelo);
                      Console.WriteLine("Tamonho do Celular: " + celular1.tamanho);
                      break;

                    }else{
                        Console.WriteLine("Fim");
                    }
                } while (true);


        }
    }
}
