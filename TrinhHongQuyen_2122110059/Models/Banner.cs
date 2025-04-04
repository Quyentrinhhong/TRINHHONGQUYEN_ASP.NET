namespace TrinhHongQuyen_2122110059.Model
{
    public class Banner
    {
        public int Id { get; set; }                     
        public string Title { get; set; }               
        public string ImageUrl { get; set; }           
        public string Link { get; set; }               
        public bool IsActive { get; set; }            
        public DateTime CreatedAt { get; set; }         
        public DateTime UpdatedAt { get; set; }        
    }
}
