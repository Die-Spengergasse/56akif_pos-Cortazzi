namespace Spg.Uebung.Properties
{
    partial class Program
    {
        public class Rechteck
        {
            public int Laenge
            {
                get
                {
                    return _laenge;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Ungueltige Laenge!");
                    }
                    _laenge = value;
                }
            }

            private int _laenge;
            public int Breite
            {
                get
                {
                    return _breite;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Ungueltige Breite!");
                    }
                    _breite = value;
                }
            }
            private int _breite;
            public int Flaeche { get { return Laenge * Breite; } }
        }
    }
}