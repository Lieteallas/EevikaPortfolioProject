namespace EevikaPortfolioProject.Models
{
    public class PortfolioContentPiece
    {
        public int WorkId { get; set; }
        public string ContentTitle { get; set; } = string.Empty;

        public string ContentType { get; set;} = string.Empty;

        public string ContentReference { get; set; } = string.Empty;

        public string ContentText { get; set; } = string.Empty;
    }
}
