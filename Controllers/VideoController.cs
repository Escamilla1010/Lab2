﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;
using System.Data;


namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int reproducciones, string url)
        {
            //Guardar el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");


        }
       
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            //Modificar el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            BaseHelper.ejecutarSentencia("sp_video_eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");

        }

        public ActionResult Edit()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo, int reproducciones, string url)
        {
            //Modificar el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");

        }

        public ActionResult Search()
        {
            
            return View();
        }
          [HttpPost]
        public ActionResult Search(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            ViewData["datavideo"] =  BaseHelper.ejecutarConsulta("sp_video_buscar", CommandType.StoredProcedure, parametros);
            return View("Resultado");
        }

        
          public ActionResult SeeAll()
          {
             
              ViewData["datavideo"] = BaseHelper.ejecutarConsulta("sp_video_todos", CommandType.StoredProcedure);
              return View();
              
          }



    }
}
