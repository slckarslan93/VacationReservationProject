using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class MainFeature
    {
        [Key]
        public int FeatureId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}