using CardManagement.Enums;

namespace CardManagement
{
    public class Card
    {
        public Card()
        {
            Aspects = new Aspect[2];
        }

        public string Name { get; set; }
        public string Subtitle { get; set; }
        public Set Set { get; set; }
        public int Num { get; set; }
        public Rarity Rarity { get; set; }
        public Aspect[] Aspects { get; set; }
        public CardType Type { get; set; }
        public string Traits { get; set; }
        public int Cost { get; set; }
        public int? Power { get; set; }
        public int? Health { get; set; }
        public string CardText { get; set; }
    }
}
