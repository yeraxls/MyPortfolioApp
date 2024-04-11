namespace MyPortfolio.Models
{
    public class HomeDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Estudio> MyJobs { get; set; }
        public List<Estudio> Experience { get; set; }
        public List<Estudio> Studies { get; set;}
    }
}
