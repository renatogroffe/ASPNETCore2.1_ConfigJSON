namespace APIDadosBrasil.Models
{
    public class DadosPais
    {
        public string Nome { get; set; }
        public string NomeOficial { get; set; }
        public string Capital { get; set; }
        public DadosPopulacao Populacao { get; set; }
        public DadosEconomia Economia { get; set; }
    }

    public class DadosPopulacao
    {
        public int NumHabitantes { get; set; }
        public double DensidadeHabKm2 { get; set; }
    }

    public class DadosEconomia
    {
        public double PIB { get; set; }
        public double RendaPerCapita { get; set; }
    }
}