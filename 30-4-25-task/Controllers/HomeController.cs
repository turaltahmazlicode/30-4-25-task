using _30_4_25_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace _30_4_25_task.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        Service service1 = new() { Icon = "flaticon-car", Title = "largest dealership of car", ShortDescription = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut den fugit sed quia." };
        Service service2 = new() { Icon = "flaticon-car-repair", Title = "unlimited repair warrenty", ShortDescription = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut den fugit sed quia." };
        Service service3 = new() { Icon = "flaticon-car-1", Title = "insurence support", ShortDescription = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut den fugit sed quia." };
        ViewData["Services"] = new List<Service> { service1, service2, service3 };

        NewCar newCar1 = new() { Image = "ncm1.png", Title = "chevrolet camaro za100", Description1 = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Description2 = "Sed ut pers unde omnis iste natus error sit voluptatem accusantium doloremque laudantium." };
        NewCar newCar2 = new() { Image = "ncm2.png", Title = "unlimited repair warrenty", Description1 = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Description2 = "Sed ut pers unde omnis iste natus error sit voluptatem accusantium doloremque laudantium." };
        NewCar newCar3 = new() { Image = "ncm3.png", Title = "insurence support", Description1 = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Description2 = "Sed ut pers unde omnis iste natus error sit voluptatem accusantium doloremque laudantium." };
        ViewData["NewCars"] = new List<NewCar> { newCar1, newCar2, newCar3 };

        FeaturedCar featuredCar1 = new() { Image = "fc1.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar2 = new() { Image = "fc2.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar3 = new() { Image = "fc3.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar4 = new() { Image = "fc4.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar5 = new() { Image = "fc4.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar6 = new() { Image = "fc5.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar7 = new() { Image = "fc7.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        FeaturedCar featuredCar8 = new() { Image = "fc8.png", Detail1 = "2017", Detail2 = "3100 Mi", Detail3 = "240 HP", Detail4 = "Automatic", Model = "BMW 6-series gran coupe", Price = 89395, ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non." };
        ViewData["FeaturedCars"] = new List<FeaturedCar> { featuredCar1, featuredCar2, featuredCar3, featuredCar4, featuredCar5, featuredCar6, featuredCar7, featuredCar8 };

        ClientReview clientReview1 = new() { Image = "c1.png", Comment = "Sed ut pers unde omnis iste natus error sit voluptatem accusantium dolor laudan rem aperiam, eaque ipsa quae ab illo inventore verit.", Fullname = "John Doe", City = "Washington" };
        ClientReview clientReview2 = new() { Image = "c2.png", Comment = "Sed ut pers unde omnis iste natus error sit voluptatem accusantium dolor laudan rem aperiam, eaque ipsa quae ab illo inventore verit.", Fullname = "Romi Rain", City = "London" };
        ClientReview clientReview3 = new() { Image = "c3.png", Comment = "Sed ut pers unde omnis iste natus error sit voluptatem accusantium dolor laudan rem aperiam, eaque ipsa quae ab illo inventore verit.", Fullname = "Tomas Lili", City = "New York" };
        ViewData["ClientReviews"] = new List<ClientReview> { clientReview1, clientReview2, clientReview3 };

        Brand brand1 = new Brand() { Image = "br1.png" };
        Brand brand2 = new Brand() { Image = "br2.png" };
        Brand brand3 = new Brand() { Image = "br3.png" };
        Brand brand4 = new Brand() { Image = "br4.png" };
        Brand brand5 = new Brand() { Image = "br5.png" };
        Brand brand6 = new Brand() { Image = "br6.png" };
        ViewData["Brands"] = new List<Brand> { brand1, brand2, brand3, brand4, brand5, brand6 };
        return View();
    }
}
