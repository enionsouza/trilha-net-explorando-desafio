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
            // DONE: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // DONE: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("A quantidade de hóspedes não pode exceder a capacidade da suíte.", nameof(hospedes));
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // DONE: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // DONE: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                return 0.9M * DiasReservados * Suite.ValorDiaria;
            }

            return DiasReservados * Suite.ValorDiaria;
        }
    }
}