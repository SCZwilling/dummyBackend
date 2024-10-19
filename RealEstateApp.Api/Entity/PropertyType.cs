namespace RealEstateApp.Api.Entity
{
    public class PropertyType : PropertyFieldBase
    {
        public PropertyType() { }
        public PropertyType(string type)
        {
            Value = type;
        }

        public static List<PropertyType> GenerateDefault()
        {
            return new List<PropertyType>
            {
                new PropertyType("Aggriculture Land"),
                new PropertyType("Apartment"),
                new PropertyType("Commercial Land"),
                new PropertyType("Hostel"),
                new PropertyType("House"),
                new PropertyType("Industrial land"),
                new PropertyType("Office Space"),
                new PropertyType("Plot"),
                new PropertyType("Shop")
            };
        }
    }
}
