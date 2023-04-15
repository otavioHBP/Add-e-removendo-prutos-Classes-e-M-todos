using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto();


            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Dados do produtos: {p}");

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que deseja adicionar ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade que deseja remover do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);



        }

    }
}




