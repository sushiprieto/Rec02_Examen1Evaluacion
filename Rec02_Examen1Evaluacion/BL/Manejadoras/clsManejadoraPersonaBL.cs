using System;
using ENT;
using DAL.Manejadoras;

namespace BL.Manejadoras
{
    public class clsManejadoraPersonaBL
    {

        private clsManejadoraPersonaDAL oManejadoraPersonaDAL;

        public clsManejadoraPersonaBL()
        {
            oManejadoraPersonaDAL = new clsManejadoraPersonaDAL();
        }

        /// <summary>
        /// Obtiene una persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsPersona getPersona(int id)
        {
            clsPersona p = oManejadoraPersonaDAL.getPersonaDAL(id);
            return p;
        }

    }
}
