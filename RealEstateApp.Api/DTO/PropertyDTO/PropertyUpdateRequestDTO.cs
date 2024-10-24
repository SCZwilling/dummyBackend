﻿namespace RealEstateApp.Api.DTO.PropertyDTO
{
    public class PropertyUpdateRequestDTO
    {
        public int Id { get; set; }
        public string? EndDate { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public int? PropertyTypeId { get; set; }
        public int? PropertyStatusId { get; set; }
        public int? CurrencyId { get; set; }
        public int? Price { get; set; }
        public string? PropertyInfo { get; set; }


    }
}
