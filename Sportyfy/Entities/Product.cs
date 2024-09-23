namespace Sportyfy.Entities
{
    public class Product:BaseEtnity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }


        public int ProductTypeId { get; set; }
        public int ProductBrandId{ get; set; }


        //Navigation Properties
        //sa her ta krijojna nje klas i bjen qe eke kriju ni data type te ri
        public ProductType ProductType { get; set; }
        public ProductBrand ProductBrand { get; set; }


    }
}
