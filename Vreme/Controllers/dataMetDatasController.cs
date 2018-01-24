using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vreme.Models;

namespace Vreme.Controllers
{
    public class dataMetDatasController : Controller
    {
        private VremeContext db = new VremeContext();

        // GET: dataMetDatas
        public ActionResult Index()
        {
            var podatki = from x in db.dataMetDatas
                          select new { x.valid, x.dd_icon, x.tavg, x.rhavg };
            return View(podatki);
        }

        // GET: dataMetDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dataMetDatas dataMetDatas = db.dataMetDatas.Find(id);
            if (dataMetDatas == null)
            {
                return HttpNotFound();
            }
            return View(dataMetDatas);
        }

        // GET: dataMetDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dataMetDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,domain_title,domain_shortTitle,domain_longTitle,domain_meteosiId,domain_lat,domain_lon,domain_altitude,dataSource_title,sunrise,sunset,tsValid_issued,tsValid_issued_day,tsValid_issued_UTC,tsValid_issued_RFC822,tsUpdated,tsUpdated_day,tsUpdated_UTC,tsUpdated_RFC822,valid_day,valid,valid_UTC,validStart,validEnd,nn_var_desc,wwsyn_var_desc,nn_iconwwsyn_icon,wwsyn_icon,t_var_desc,t_var_unit,t,t_state,td_var_desc,td_var_unit,td,td_state,tavg_var_desc,tavg_var_unit,tavg,tavg_state,tx_var_desc,tx_var_unit,tx,tx_state,tn_var_desc,tn_var_unit,tn,tn_state,rh_var_desc,rh_var_unit,rh,rh_state,rhavg_var_desc,rhavg_var_unit,rhavg,rhavg_state,dd_var_desc,dd_var_unit,dd_shortText,dd_icon,dd_state,ddavg_var_desc,ddavg_var_unit,ddavg_shortText,ddavg_longText,ddavg_icon,ddavg_state,ddmax_var_desc,ddmax_var_unit,ddmax_shortText,ddmax_icon,ddmax_state,ff_var_desc,ff_var_unit,ff_val,ff_val_kmh,ff_state,ffavg_var_desc,ffavg_var_unit,ffavg_val,ffavg_val_kmh,ffavg_state,ffmax_var_desc,ffmax_var_unit,ffmax_val,ffmax_val_kmh,ffmax_state,msl_var_desc,msl_var_unit,mslavg_var_desc,mslavg_var_unit,p_var_desc,p_var_unit,pavg_var_desc,pavg_var_unit,rr_var_desc,rr_var_unit,rr_val,rr_state,snow_var_desc,snow_var_unit,tp_12h_acc_var_desc,tp_12h_acc_var_unit,tp_12h_acc,tp_12h_acc_state,tp_24h_acc_var_desc,tp_24h_acc_var_unit,tp_24h_acc,tp_24h_acc_state,tw_var_desc,tw_var_unit,gSunRad_var_desc,gSunRad_var_unit,gSunRadavg_var_desc,gSunRadavg_var_unit,diffSunRad_var_desc,diffSunRad_var_unit,diffSunRadavg_var_desc,diffSunRadavg_var_unit,vis_desc,vis_unit,t_5_cm_var_desc,t_5_cm_var_unit,tavg_5_cm_var_desc,tavg_5_cm_var_unit,tg_5_cm_var_desc,tg_5_cm_var_unit,tgavg_5_cm_var_desc,tgavg_5_cm_var_unit,tg_10_cm_var_desc,tg_10_cm_var_unit,tgavg_10_cm_var_desc,tgavg_10_cm_var_unit,tg_20_cm_var_desc,tg_20_cm_var_unit,tgavg_20_cm_var_desc,tgavg_20_cm_var_unit,tg_30_cm_var_desc,tg_30_cm_var_unit,tgavg_30_cm_var_desc,tgavg_30_cm_var_unit,tg_50_cm_var_desc,tg_50_cm_var_unit,tgavg_50_cm_var_desc,tgavg_50_cm_var_unit,hhs_var_desc,hhs_var_unit,ns_var_desc,ns_var_unit,rrHh")] dataMetDatas dataMetDatas)
        {
            if (ModelState.IsValid)
            {
                db.dataMetDatas.Add(dataMetDatas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dataMetDatas);
        }

        // GET: dataMetDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dataMetDatas dataMetDatas = db.dataMetDatas.Find(id);
            if (dataMetDatas == null)
            {
                return HttpNotFound();
            }
            return View(dataMetDatas);
        }

        // POST: dataMetDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,domain_title,domain_shortTitle,domain_longTitle,domain_meteosiId,domain_lat,domain_lon,domain_altitude,dataSource_title,sunrise,sunset,tsValid_issued,tsValid_issued_day,tsValid_issued_UTC,tsValid_issued_RFC822,tsUpdated,tsUpdated_day,tsUpdated_UTC,tsUpdated_RFC822,valid_day,valid,valid_UTC,validStart,validEnd,nn_var_desc,wwsyn_var_desc,nn_iconwwsyn_icon,wwsyn_icon,t_var_desc,t_var_unit,t,t_state,td_var_desc,td_var_unit,td,td_state,tavg_var_desc,tavg_var_unit,tavg,tavg_state,tx_var_desc,tx_var_unit,tx,tx_state,tn_var_desc,tn_var_unit,tn,tn_state,rh_var_desc,rh_var_unit,rh,rh_state,rhavg_var_desc,rhavg_var_unit,rhavg,rhavg_state,dd_var_desc,dd_var_unit,dd_shortText,dd_icon,dd_state,ddavg_var_desc,ddavg_var_unit,ddavg_shortText,ddavg_longText,ddavg_icon,ddavg_state,ddmax_var_desc,ddmax_var_unit,ddmax_shortText,ddmax_icon,ddmax_state,ff_var_desc,ff_var_unit,ff_val,ff_val_kmh,ff_state,ffavg_var_desc,ffavg_var_unit,ffavg_val,ffavg_val_kmh,ffavg_state,ffmax_var_desc,ffmax_var_unit,ffmax_val,ffmax_val_kmh,ffmax_state,msl_var_desc,msl_var_unit,mslavg_var_desc,mslavg_var_unit,p_var_desc,p_var_unit,pavg_var_desc,pavg_var_unit,rr_var_desc,rr_var_unit,rr_val,rr_state,snow_var_desc,snow_var_unit,tp_12h_acc_var_desc,tp_12h_acc_var_unit,tp_12h_acc,tp_12h_acc_state,tp_24h_acc_var_desc,tp_24h_acc_var_unit,tp_24h_acc,tp_24h_acc_state,tw_var_desc,tw_var_unit,gSunRad_var_desc,gSunRad_var_unit,gSunRadavg_var_desc,gSunRadavg_var_unit,diffSunRad_var_desc,diffSunRad_var_unit,diffSunRadavg_var_desc,diffSunRadavg_var_unit,vis_desc,vis_unit,t_5_cm_var_desc,t_5_cm_var_unit,tavg_5_cm_var_desc,tavg_5_cm_var_unit,tg_5_cm_var_desc,tg_5_cm_var_unit,tgavg_5_cm_var_desc,tgavg_5_cm_var_unit,tg_10_cm_var_desc,tg_10_cm_var_unit,tgavg_10_cm_var_desc,tgavg_10_cm_var_unit,tg_20_cm_var_desc,tg_20_cm_var_unit,tgavg_20_cm_var_desc,tgavg_20_cm_var_unit,tg_30_cm_var_desc,tg_30_cm_var_unit,tgavg_30_cm_var_desc,tgavg_30_cm_var_unit,tg_50_cm_var_desc,tg_50_cm_var_unit,tgavg_50_cm_var_desc,tgavg_50_cm_var_unit,hhs_var_desc,hhs_var_unit,ns_var_desc,ns_var_unit,rrHh")] dataMetDatas dataMetDatas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataMetDatas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dataMetDatas);
        }

        // GET: dataMetDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dataMetDatas dataMetDatas = db.dataMetDatas.Find(id);
            if (dataMetDatas == null)
            {
                return HttpNotFound();
            }
            return View(dataMetDatas);
        }

        // POST: dataMetDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dataMetDatas dataMetDatas = db.dataMetDatas.Find(id);
            db.dataMetDatas.Remove(dataMetDatas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
