using System;

namespace condicional
{
    class IfElse
    {
        static void Main(string[] args)
        {
            try
            {
                //Recebendo o input do usuário
               
                Console.WriteLine("Por favor, digite a sobremesa escolhida do nosso menu de doces: ");

                string? sobremesaLeitura = Console.ReadLine();

                //____________________________________________________________________________________________
                //Caso a sobremesa digitada não esteja no menu uma mensagem avisando o cliente é informada!


                if (sobremesaLeitura == "pudim" || sobremesaLeitura=="brigadeiro")
                {
                    Console.WriteLine(sobremesaLeitura + " é uma ótima escolha!");
                }
                else
                {
                    Console.WriteLine("Desculpe, não temos essa opção em nosso menu de sobremesas.");
                }

                Console.ReadKey();

                //__________________________________________________________________________________
                //Tratamento de erro caso seja digitado algo fora do esperado pelo cliente.
            }
            catch (Exception ex)
            {

                Console.WriteLine("Aconteceu um erro ao executar a aplicação." + "\n\r" + ex);

            }
        }
    }
}



