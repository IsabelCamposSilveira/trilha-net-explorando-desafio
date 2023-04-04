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

        public int CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
                return Hospedes.Count;
            
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;

            if(DiasReservados < 10){
                valor = DiasReservados * Suite.ValorDiaria;
            } 
            else {
                valor = DiasReservados * Suite.ValorDiaria;
                decimal desconto = 0.1M * valor;
                valor = valor - desconto;
            }

            return valor;
        }
    }
}