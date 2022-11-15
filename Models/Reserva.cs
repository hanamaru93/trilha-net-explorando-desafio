namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            this.Hospedes = hospedes;
            this.DiasReservados = diasReservados;
            this.Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            var quantidadeDeHospedes = ObterQuantidadeHospedes();
            var capacidade = this.Suite.Capacidade;

            if (capacidade >= quantidadeDeHospedes)
            {
                
                this.Hospedes = hospedes;

            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                try{



                }
                catch (Exception){

                    Console.WriteLine("Capacidade de Suite menor que a quantidade de hospedes.");
                
                }

                    

                
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            var hospedes = this.Hospedes.Count();
            return hospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            var diasReservados = this.DiasReservados;
            decimal valor = diasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (diasReservados >= 10)
            {
                var desconto = valor / 10;
                valor = valor - desconto;
            }

            return valor;
        }
    }
}