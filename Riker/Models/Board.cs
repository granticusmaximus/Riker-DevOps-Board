namespace Riker.Models
{
    public class Board
    {
        [Key]
        public int BoardID {get;set;}
        public string BoardTitle {get;set;}
        public BoardColumn Column {get;set;}
    }

    public class BoardColumn
    {
        [Key]
        public int ColumnID {get;set;}
        public string ColumnTitle {get;set;}
        
    }
}