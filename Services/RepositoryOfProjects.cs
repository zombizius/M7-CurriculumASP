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
                    Description = "Web de venta de videojuegos como proyecto de PHP",
                    Link = "#",
                    imageURL = "/img/ecommerce.png"
                },

                new ClassProjects
                {
                    Title = "Ciberseguridad",
                    Description = "Web realizada con HTML y CSS para el proyecto final de ASIX",
                    Link = "#",
                    imageURL = "/img/itcrowd1.png"
                },

                new ClassProjects
                {
                    Title = "Aliexpress",
                    Description = "Creación de la sección de pagos y usuarios de la página de Aliexpress",
                    Link = "https://es.aliexpress.com/",
                    imageURL = "/img/aliexpress.png"
                },

                new ClassProjects
                {
                    Title = "Amazon",
                    Description = "Configuración de una gran parte de la página de Amazon con Python.",
                    Link = "https://www.amazon.es/",
                    imageURL = "/img/amazon.png"
                },

                new ClassProjects
                {
                    Title = "Bofrost*",
                    Description = "Creación de una web para la empresa Bofrost* con HTML, CSS y JS",
                    Link = "https://www.bofrost.es/es/",
                    imageURL = "/img/bofrost.png"
                },

                new ClassProjects
                {
                    Title = "Ciberseguridad",
                    Description = "6 meses trabajando en Fortinet en ciberseguridad para detener ataques rusos",
                    Link = "https://www.fortinet.com/lat",
                    imageURL = "/img/fortinet.png"
                },


            };
        }
    }
}
