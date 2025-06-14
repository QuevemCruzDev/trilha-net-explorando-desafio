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

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospedes não pode ser maior que a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
  
            int  quantitadeDeHospedes =  Hospedes.Count();
            return quantitadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
 
            decimal valor = DiasReservados * Suite.ValorDiaria;


            if (DiasReservados >= 10)
            {
                valor = (valor / 100) * 10;
            }

            return valor;
        }
    }
}