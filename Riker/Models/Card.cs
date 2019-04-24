namespace Riker.Models
{
    public class Card
    {
        [Key]
        public int CardID {get;set;}
        public string CardTitle {get;set;}
        public string Description {get;set;}
    }
}