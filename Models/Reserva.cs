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

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // iMPLEMENTADO
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // IMPLEMENTADO
                throw new ArgumentException("A capacidade da Suíte é menor que o número de Hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO
            return Hospedes != null ? Hospedes.Count : 0;
        }

        public decimal CalcularValorDiaria()
        {
           // IMPLEMENTADO
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            

            // IMPLEMENTADO
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90m;
            }

            return valorTotal;
        }
    }
}