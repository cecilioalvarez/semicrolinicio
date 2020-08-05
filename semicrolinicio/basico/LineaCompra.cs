namespace semicrolinicio
{
    public class LineaCompra
    {

        public int Numero { get; set; }
        public string Concepto { get; set; }
        public double Importe { get; set; }
        public LineaCompra(int numero, string concepto, double importe)
        {
            Numero = numero;
            Concepto = concepto;
            Importe = importe;
        }

        public double ImporteConIVA()
        {
            return Importe * 1.21;
        }
    }
}