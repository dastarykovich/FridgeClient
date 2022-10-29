using System;

namespace FridgeClient.Models.DataTransferObjects
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int DefaultQuantity { get; set; }
    }
}
