using System;

namespace BusinessLogicLayer.DTOmodels
{
    class CommodityDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime TimeWarrantyExpiration { get; set; }
        public CommodityTypes Types { get; set; }
    }
}
