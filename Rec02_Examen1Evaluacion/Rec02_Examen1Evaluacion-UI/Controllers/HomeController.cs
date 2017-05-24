using System;
using System.Web.Mvc;
using BL.Manejadoras;
using ENT;

namespace Rec02_Examen1Evaluacion_UI.Controllers
{
    public class HomeController : Controller
    {
       /// <summary>
       /// Controlador para la vista Index
       /// </summary>
       /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Controlador que llamaremos al hacer click en el boton
        /// 
        /// Recogemos el id de la persona y guardamos el nick
        /// 
        /// Nos mostrará la vista detalles
        /// </summary>
        /// <param name="btnAceptar"></param>
        /// <param name="txtId"></param>
        /// <param name="txtNick"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(string btnAceptar, string txtId, string txtNick)
        {

            //Guardamos el nick en una variable de sesion
            if (Session["nick"] == null)
                Session["nick"] = txtNick;

            try
            {
                int idPersona = Convert.ToInt32(txtId);

                clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();
                clsPersona per = oManejadoraPersonaBL.getPersona(idPersona);

                if (per != null)
                    return View("Detalles", per);
                else
                    return View("ErrorId", idPersona);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }

        public ActionResult Detalles(int id)
        {
            clsPersona p;

            try
            {
                clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();
                p = oManejadoraPersonaBL.getPersona(id);
                return View(p);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}