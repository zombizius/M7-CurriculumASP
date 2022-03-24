using CurrículumASP.Models;

namespace CurrículumASP.Services
{
    public class RepositoryOfProjects
    {
        public List<ClassProjects> GetProjects()
        {
            return new List<ClassProjects>()
            {
                new ClassProjects
                {
                    Title = "Ecommerce",
                    Description = "Video game sales website as a PHP project",
                    Link = "#",
                    imageURL = "/img/ecommerce.png"
                },

                new ClassProjects
                {
                    Title = "Cybersecurity",
                    Description = "Web made with HTML and CSS for the final ASIX project",
                    Link = "#",
                    imageURL = "/img/itcrowd1.png"
                },

                new ClassProjects
                {
                    Title = "Aliexpress",
                    Description = "Creation of the payments and users section of the Aliexpress page",
                    Link = "https://es.aliexpress.com/",
                    imageURL = "/img/aliexpress.png"
                },

                new ClassProjects
                {
                    Title = "Amazon",
                    Description = "Setting up a large part of the Amazon page with Python.",
                    Link = "https://www.amazon.es/",
                    imageURL = "/img/amazon.png"
                },

                new ClassProjects
                {
                    Title = "Bofrost*",
                    Description = "Creation of a website for the company Bofrost* with HTML, CSS and JS",
                    Link = "https://www.bofrost.es/es/",
                    imageURL = "/img/bofrost.png"
                },

                new ClassProjects
                {
                    Title = "Cybersecurity",
                    Description = "6 months working at Fortinet in cybersecurity to stop Russian attacks",
                    Link = "https://www.fortinet.com/lat",
                    imageURL = "/img/fortinet.png"
                },


            };
        }
    }
}
