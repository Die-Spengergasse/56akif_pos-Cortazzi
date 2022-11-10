namespace Spg.Uebung.Properties
{
    public class Lehrer
    {
        public string Vorname { get; set; } = string.Empty;
        public string? Zuname { get; set; } = null;
        public decimal? Bruttogehalt
        {
            get
            {
                return _bruttogehalt;
            }
            set
            {
                if (_bruttogehalt is null)
                {
                    _bruttogehalt = value;
                }
            }

        }
        private decimal? _bruttogehalt;
        public decimal Nettogehalt
        {
            get
            {
                if (Bruttogehalt is not null)
                    return (decimal)(_bruttogehalt * 0.8M);
                else
                    return 0;
            }
        }
       
        public string Kuerzel
        {
            get 
            {
                if (Zuname?.Length >= 3)
                { 
                return Zuname?.Substring(0, 3)?.ToUpper() ?? "--";
                }
                return "";
            }

            
        }
    }
}