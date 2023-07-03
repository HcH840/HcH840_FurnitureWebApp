namespace HcH840_FurnitureWebApp.Model
{
    public class Furniture
    {
        public string Mark { get; set; }
        public string Type { get; set; }
        public string Year { get; set; } // Declare Furniture specs (Mark, type:chair, table, dresser... , year of Production dd/mm/yy format) 
        public Furniture(string mark, string type, string year)
        {
            Mark = mark; Type = type; Year = year;
        } // with Furniture(); write classname.attributename ex: frt.Mark = ...
        public void update(string type,  string year)
        { 
            this.Type = type; 
            this.Year = year;
        }
    }
}
