using System;

namespace Academy.TestWeek5.Core
{
    public enum Tipologia
    {
        Primo,
        Secondo,
        Contorno,
        Dolce
    }
    public class Piatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public Tipologia Tipologia { get; set; }
        public double Prezzo { get; set; }
    }
}
