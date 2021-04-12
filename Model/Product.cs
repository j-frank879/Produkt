using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Produkt.Pages.Model
{
    public class Product
    {public string Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string Url { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title{ get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
    }
}
