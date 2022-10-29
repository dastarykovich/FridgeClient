using System;

namespace FridgeClient.Models.DataTransferObjects
{
    public class FridgeProductDto
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid FridgeId { get; set; }

        public int Quantity { get; set; }
    }
}
