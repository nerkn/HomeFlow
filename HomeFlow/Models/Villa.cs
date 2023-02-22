namespace HomeFlow.Models
{

    public class Villa : BaseModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public VillaCategory? Category { get; set; }

        public Models.RentSale RentSale { get; set; } = RentSale.Sale;

        public Villa(string name, string desc, string rentsale)
        {
            Name = name;
            Description = desc;
            RentSale = (Models.RentSale)Enum.Parse(typeof(Models.RentSale), value: rentsale);

        }
    }
}
