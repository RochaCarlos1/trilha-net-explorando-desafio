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
            
            // *IMPLEMENTADO*
            try{
            (hospedes == 1 || hospedes == 2);
            if (true)
            {
                Hospedes = hospedes;
            }
            }
            catch (Exception ex) {
            
                
                // *IMPLEMENTADO*
                Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            // *IMPLEMENTADO*
            Console.WriteLine($"Quantidade de hospedes = {hospedes}");
            
        }

        public decimal CalcularValorDiaria()
        {
            
            // *IMPLEMENTADO*
            decimal valor =  DiasReservados * Suite.ValorDiaria;

           
            // *IMPLEMENTADO*
            DiasReservados >= 10;
            if (true)
            {
                valor = valor - (valor * 10/100);
            }

            return valor;
        }
    }
}