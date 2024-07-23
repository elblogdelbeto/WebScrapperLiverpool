using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebScraper
{
    public class Record
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_u")]
        public string Url { get; set; }

        [JsonProperty("_t")]
        public string Title { get; set; }

        public string? Collection { get; set; }
        public AllMeta AllMeta { get; set; }

        public Record(string id, string url, string title, AllMeta allMeta)
        {
            Id = id;
            Url = url;
            Title = title;
            AllMeta = allMeta;
        }
    }

    public class AllMeta
    {
        public required string Name { get; set; }
        public List<string> Categories { get; set; }
        public string Availability { get; set; }
        public List<Variant> Variants { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<string> Ancestors { get; set; }
        public string Brand { get; set; }
        public RatingInfo RatingInfo { get; set; }
        public List<string> CategoryBreadCrumbs { get; set; }
        public string Department { get; set; }
        public string GroupType { get; set; }
        public string HemService { get; set; }
        public string IsCollectionProduct { get; set; }
        public string IsImportationProduct { get; set; }
        public string IsMarketPlace { get; set; }
        public string IsSustainable { get; set; }
        public string ItrEligibility { get; set; }
        public string MaterialGroup { get; set; }
        public double MinimumListPrice { get; set; }
        public double MaximumListPrice { get; set; }
        public double MinimumPromoPrice { get; set; }
        public double MaximumPromoPrice { get; set; }
        public int NumRecords { get; set; }
        public string ProductId { get; set; }
        public string ProductType { get; set; }
        public string PromotionalGiftMessage { get; set; }
        public string SkipInventory { get; set; }
        public List<string> SwatchColors { get; set; } = null!;
        public bool RegaloPmr { get; set; }
        public string Ar { get; set; }
        public long NewArrivalSort { get; set; }
        public List<string> GalleryImagesVariants { get; set; }
    }

    public class Variant
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Availability { get; set; }
        public ColorInfo ColorInfo { get; set; }
        public string Color { get; set; }
        public string Colorhex { get; set; }
        public string EnableTryOn { get; set; }
        public string DwpromoDescription { get; set; }
        public string DwToolTipInfo { get; set; }
        public List<string> GalleriaImages { get; set; }
        public string HasValidOnlineInventory { get; set; }
        public string IsBundle { get; set; }
        public string LargeImage { get; set; }
        public string NormalizedColor { get; set; }
        public List<string> Sellernames { get; set; }
        public string SellersCount { get; set; }
        public string SkuDescription { get; set; }
        public string SkuId { get; set; }
        public string SmallImage { get; set; }
        public string SpecialSaleMessage { get; set; }
        public string ThumbnailImage { get; set; }
        public bool RegaloPmr { get; set; }
        public Prices Prices { get; set; }
    }

    public class ColorInfo
    {
        public List<string> ColorFamilies { get; set; }
        public List<string> Colors { get; set; }
    }

    public class Prices
    {
        public string DiscountPercentage { get; set; }
        public double PromoPrice { get; set; }
        public double SalePrice { get; set; }
        public double ListPrice { get; set; }
        public double SortPrice { get; set; }
    }

    public class ProductImage
    {
        public string LargeImage { get; set; }
        public string ThumbnailImage { get; set; }
        public string SmallImage { get; set; }
    }

    public class RatingInfo
    {
        public string FourRatingCount { get; set; }
        public string FourRatingPercentage { get; set; }
        public string TwoRatingCount { get; set; }
        public string ThreeRatingPercentage { get; set; }
        public string FiveRatingCount { get; set; }
        public string ProductRatingCount { get; set; }
        public string OneRatingCount { get; set; }
        public string OneRatingPercentage { get; set; }
        public string ThreeRatingCount { get; set; }
        public string FiveRatingPercentage { get; set; }
        public string TwoRatingPercentage { get; set; }
        public string ProductAvgRating { get; set; }
    }

    public class SwatchColor
    {
        public string Color { get; set; }
        public string Id { get; set; }
        public string LargeImage { get; set; }
        public string AdditionalInfo { get; set; }
        public string SmallImage { get; set; }
        public string ColorHex { get; set; }
    }
}
