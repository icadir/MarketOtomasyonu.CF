using Market.Models.Entities;

namespace Market.Models.ViewModels
{
    public class MultiProductViewModel
    {
        public int UrunId { get; set; }
        public int MultiProductId { get; set; }
        public string MPBarkod { get; set; }
        public string Cname { get; set; }
        public decimal MPPiece { get; set; }

        public decimal MPPrice { get; set; }

        public string MPExplanation { get; set; }
        public byte[] MPPicture { get; set; }

        public virtual Product Product { get; set; }
    }
}
