﻿using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto()
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/amazon.png"
                },
                new Proyecto()
                {
                    Titulo = "New York Times",
                    Descripcion = "pagina noticias en react",
                    Link = "https://nytimes.com",
                    ImagenURL = "/imagenes/nyt.PNG"
                },new Proyecto()
                {
                    Titulo = "Reddit",
                    Descripcion = "red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/reddit.PNG"
                }
                ,new Proyecto()
                {
                    Titulo = "Steam",
                    Descripcion = "tienda en linea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/imagenes/steam.PNG"
                }
            };
        }
    }
}
