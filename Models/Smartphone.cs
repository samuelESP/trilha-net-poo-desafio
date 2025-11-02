namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {

            if (string.IsNullOrWhiteSpace(imei))
            {
                throw new ArgumentNullException("O número IMEI não pode ser vazio");
            }

            if(imei.Length < 15)
            {
                throw new ArgumentNullException("O número IMEI não pode ser menor que 15");
            }

            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }


        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ExibirDados()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Dispositivo: {this.Modelo}");
            Console.WriteLine($"Número: {this.Numero}");
            Console.WriteLine($"IMEI: {this.IMEI}");
            Console.WriteLine($"Memória: {this.Memoria} GB");
            Console.WriteLine("------------------------------");
        }
    }
}