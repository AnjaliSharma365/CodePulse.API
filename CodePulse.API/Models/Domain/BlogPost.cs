namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string ShortDescription { get; set; } 
        public string Content { get; set; }
        public string FeaturedImageUrl{ get; set; } 
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public String Author { get; set; }
        public bool IsVisible { get; set; }
    }
}
