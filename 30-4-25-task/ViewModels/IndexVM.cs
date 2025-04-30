using _30_4_25_task.Models;

namespace _30_4_25_task.ViewModels;

public class IndexVM
{
    public List<Service> Services { get; set; }
    public List<Brand> Brands { get; set; }
    public List<ClientReview> ClientReviews { get; set; }
    public List<FeaturedCar> FeaturedCars { get; set; }
    public List<NewCar> NewCars { get; set; }
}
