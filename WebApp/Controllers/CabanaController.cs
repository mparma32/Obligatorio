using Microsoft.AspNetCore.Mvc;
using LogicaNegocio.Entidades;

namespace WebApp.Controllers
{
    public class CabanaController : Controller
    {
        public void Index()
        {
            try {

                Cabana cab1 = new Cabana();
                Response.WriteAsync("Correcto");

            } catch (Exception e) {
                Response.WriteAsync(e.Message);
            }
        }
    }
}
