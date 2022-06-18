namespace MTG_Application.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string ImageUri { get; set; }
        public string ManaCost { get; set; }
        public int ManaValue { get; set; }
        public string TypeLine { get; set; }
        public string Colors { get; set; }
        public string ColorIdentity { get; set; }
        // should the following two props be booleans?
        public string Foil { get; set; }
        public string NonFoil { get; set; }
        public string SetCode { get; set; }
        public string SetName { get; set; }
        public string Rarity { get; set; }
        public string Artist { get; set; }
        public string Prices { get; set; }

        public Card()
        {
        }

        public Card(string name, string uri, string imageUri, string manaCost, int manaValue, string typeLine, string colors, string colorIdentity, string foil, string nonFoil, string setCode, string setName, string rarity, string artist, string prices)
        {
            Name = name;
            Uri = uri;
            ImageUri = imageUri;
            ManaCost = manaCost;
            ManaValue = manaValue;
            TypeLine = typeLine;
            Colors = colors;
            ColorIdentity = colorIdentity;
            Foil = foil;
            NonFoil = nonFoil;
            SetCode = setCode;
            SetName = setName;
            Rarity = rarity;
            Artist = artist;
            Prices = prices;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Card @card &&
                Id == card.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
