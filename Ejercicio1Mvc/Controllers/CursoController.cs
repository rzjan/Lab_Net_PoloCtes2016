using Ejercicio1Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio1Mvc.Controllers
{

    //Definir nuevo controlador y un nuevo modelo
    //  el controlador debe tener 2 action
    //  action1 = listar todos los items de su modelo
    //  actoin2 = reciba un parametro desde la url que sea el id y el controlador retorne un objeto con ese id
        
    public class CursoController : Controller
    {
         
        /// <summary>
        /// Lista todos los cursos
        /// </summary>
        /// <returns></returns>
        public ActionResult ListarCurso()
        {
            List<Curso> ListCurso = new List<Curso>();
            var curso1 = new Curso(1, "Progración en .net Avanzado", 5000);     
            var curso2 = new Curso(2, "Progración en java", 5000);           
            var curso3 = new Curso(3, "Progración en Phyton", 5000);
                     
            ListCurso.Add(curso1);
            ListCurso.Add(curso2);
            ListCurso.Add(curso3);

            //Persiste la lista en el objeto Session, para luego hacer la busqueda
            Session["lista"] = ListCurso;
            //Pasamos la lista a la vista para mostrar. 
            ViewBag.listaCurso = ListCurso;
            return View();
        }

        /// <summary>
        /// Realiza una busqueda del Id del curso buscado, ingresado por Url
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult ObtenerCurso(int Id)
        {
            List<Curso> _ListCurso = (List<Curso>) Session["lista"];

            foreach (var item in _ListCurso)
	        {
		       if (item.Id == Id)
	            {                    
                    ViewBag.curso = item;		
                    break;
                }
               else
               {
                   ViewBag.id = Id;
                   ViewBag.desc = "El item no se encuentra en la lista, por favor verifique!";
               }               
	        }            
            return View();           
        }
    }
}
