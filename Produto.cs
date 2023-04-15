using System.Globalization;

namespace PrimeiroProjeto {
    internal class Produto {

        public string Name;
        public double Price;
        public int Qtd;

        public double VlTotalEmEstoque() {
            return Price * Qtd;
        }

        public void AddProdutos(int qtd) {
            Qtd += qtd;
        }

        public void RemoverProdutos(int qtd) {
            Qtd -= qtd;
        }

        public override string ToString() {
            return Name + ", R$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Qtd + " unidades, Total: R$ " + VlTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }




    }

}
