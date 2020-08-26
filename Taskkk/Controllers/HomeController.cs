using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
//using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Omu.AwesomeMvc;
using Taskkk.Model;
using Taskkk.Models;

namespace Taskkk.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        private readonly OrdersTestContext db;
        public HomeController(OrdersTestContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            //List<TblClcards> clcards = db.TblClcards.ToList();
            //List<TblTransorders> transorders = db.TblTransorders.ToList();
            // List<TblSpecodes> specodes = db.TblSpecodes.ToList();
            //List<TblPoints> points = db.TblPoints.ToList();

            var data = db.TblClcards
                            .Include(x => x.TblTransorders)
                              .ThenInclude(x => x.OrdTypeNavigation)
                                .ToList();

            #region Linq
            var myList = db.TblClcards
                        .Join(
                           db.TblTransorders,
                              card => card.ClcRecno,
                                 trans => trans.OrdClcrecno,
                                    (cards, trans) => new { cards, trans })
                        .Join(
                           db.TblSpecodes,
                              trans => trans.trans.OrdPricearea,
                                 spec => spec.ScRefid,
                                    (cs, spc) => new { cards = cs.cards, trans = cs.trans, spec = spc })
                        .Where(x => x.spec.ScType == "PRICE_AREA")
                        .Select(c => new ViewModel
                        {
                            clcards = c.cards,
                            transorders = c.trans,
                            specodes = c.spec
                        }).ToList();
            #endregion


            var datas = db.TblTransorders
                               .Include(x => x.OrdClcrecnoNavigation)
                                  .Include(x => x.OrdTypeNavigation)
                                    .Where(x => x.OrdClcrecno == x.OrdClcrecnoNavigation.ClcRecno || x.OrdPricearea == x.OrdTypeNavigation.ScRefid)
                                    .Select(x => new ViewModel()
                                    {
                                        clcards = x.OrdClcrecnoNavigation,
                                        transorders = x,
                                        specodes = x.OrdTypeNavigation
                                    }).ToList();



            //var employeeRecord = (from e in db.TblTransorders
            //                      join d in db.TblClcards on e.OrdClcrecno equals d.ClcRecno

            //                      //from a in specodes
            //                      join b in db.TblSpecodes on e.OrdPricearea equals b.ScRefid
            //                      where b.ScType == "PRICE_AREA"

            //                      //from c in points
            //                      select new ViewModel
            //                      {
            //                          clcards = d,
            //                          transorders = e,
            //                          specodes = b,

            //                      }).ToList();






            model.empl = myList;
            model.points = db.TblPoints.ToList();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await db.TblTransorders
                .Include(i => i.OrdClcrecnoNavigation)
                .Include(i => i.OrdFirmNavigation)
                .Include(i => i.OrdTypeNavigation)

                .FirstOrDefaultAsync(m => m.OrdRecno == id);

            if (instructor == null)
            {
                return NotFound();
            }
            var a = from e in db.TblSpecodes where e.ScType == "ORD_TYPEACT" select e.ScValue1;
            var d = from e in db.TblSpecodes where e.ScType == "PRICE_AREA" select e;
            var t = from e in db.TblSpecodes where e.ScType == "VGN_OWNERTYPE" select e;
            var f = from e in db.TblRtctype select e;
            var b = from e in db.TblClcards select e;
            var c = from e in db.TblFirms select e;
            var v = from e in db.TblPoints where e.PntRecno== instructor.OrdFpoint select e;
            var vall = from e in db.TblPoints  select e;
            var g = from e in db.TblPoints where e.PntRecno== instructor.OrdTpoint select e;
            var g1 = from e in db.TblPoints where e.PntRecno== Convert.ToInt32(instructor.OrdBegpoint) select e;
            var g2 = from e in db.TblPoints where e.PntRecno== Convert.ToInt32(instructor.OrdEndpoint) select e;
            var g3 = from e in db.TblPoints where e.PntRecno== Convert.ToInt32(instructor.OrdStartid) select e;
            var g4 = from e in db.TblPoints where e.PntRecno== Convert.ToInt32(instructor.OrdEndid) select e;

            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;
            ViewBag.d = d;
            ViewBag.v = v;
            ViewBag.f = f;
            ViewBag.t = t;
            ViewBag.g = g;
            ViewBag.g1 = g1;
            ViewBag.g2 = g2;
            ViewBag.g3 = g3;
            ViewBag.g4 = g4;
            ViewBag.vall = vall;
            //PopulateAssignedCourseData(instructor);
            return View(instructor);
        }
        public IActionResult GetIstn1()
        {
            string term = HttpContext.Request.Query["term"].ToString();
            var names = db.TblPoints.Where(p => p.PntName1.StartsWith(term)).Select(a => new { label = a.PntName1, id = a.PntCode,recno=a.PntRecno }).ToList();
            return Json(names);
        }
        public IActionResult GetIstnid1()
        {
            string term = HttpContext.Request.Query["term"].ToString();
            var codes = db.TblPoints.Where(p => p.PntCode.StartsWith(term)).Select(a => new { label = a.PntCode, id = a.PntName1,recno=a.PntRecno }).ToList();
            return Json(codes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Save(int id, TblTransorders product)
        {
            try
            {
                var a = db.TblTransorders.FirstOrDefault(p => p.OrdRecno == id);
                a.OrdFicheno = product.OrdFicheno;
                a.OrdPricearea = product.OrdPricearea;
                a.OrdFirm = product.OrdFirm;
                a.OrdClcrecno = product.OrdClcrecno;
                a.OrdPodcode = product.OrdPodcode;
                a.OrdNts = product.OrdNts;
                a.OrdFclient = product.OrdFclient;
                a.OrdFpoint = product.OrdFpoint;
                a.OrdTpoint = product.OrdTpoint;
                a.OrdBegpoint = product.OrdBegpoint;
                a.OrdEndpoint = product.OrdEndpoint;
                a.OrdStartid = product.OrdStartid;
                a.OrdEndid = product.OrdEndid;
                a.OrdLoadstcard1 = product.OrdLoadstcard1;
                a.OrdDistance = product.OrdDistance;
                a.OrdVagonowner = product.OrdVagonowner;
                a.OrdVagontype = product.OrdVagontype;
                a.OrdVagontonnaj = product.OrdVagontonnaj;
                a.OrdVgalltonnaj = product.OrdVgalltonnaj;
                a.OrdVagoncount = product.OrdVagoncount;


                db.TblTransorders.Update(a);
                db.SaveChanges();
            }
            catch(Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }
          


            //var saved = false;
            //while (!saved)
            //{
            //    try
            //    {
            //        // Attempt to save changes to the database
            //        db.SaveChanges();
            //        saved = true;
            //    }
            //    catch (DbUpdateConcurrencyException ex)
            //    {
            //        foreach (var entry in ex.Entries)
            //        {
            //            if (entry.Entity is TblTransorders)
            //            {
            //                var proposedValues = entry.CurrentValues;
            //                var databaseValues = entry.GetDatabaseValues();

            //                foreach (var property in proposedValues.Properties)
            //                {
            //                    var proposedValue = proposedValues[property];
            //                    var databaseValue = databaseValues[property];

            //                    // TODO: decide which value should be written to database
            //                    // proposedValues[property] = <value to be saved>;
            //                }

            //                // Refresh original values to bypass next concurrency check
            //                entry.OriginalValues.SetValues(databaseValues);
            //            }
            //            else
            //            {
            //                throw new NotSupportedException(
            //                    "Don't know how to handle concurrency conflicts for "
            //                    + entry.Metadata.Name);
            //            }
            //        }
            //    }
            //}
            return RedirectToAction("Index");
        }

            //    if (id != product.OrdRecno)
            //    {
            //        return NotFound();
            //    }

            //    if (ModelState.IsValid)
            //    {
            //        try
            //        {
            //            db.Entry(product).State = EntityState.Modified;
            //            db.SaveChanges();
            //        }
            //        catch (DbUpdateConcurrencyException)
            //        {
            //            if (!ProductExists(product.OrdRecno))
            //            {
            //                return NotFound();
            //            }
            //            else
            //            {
            //                throw;
            //            }
            //        }
            //        return RedirectToAction(nameof(Index));
            //    }

            //    return RedirectToAction(nameof(Detail));
            //}

            //private bool ProductExists(int id)
            //{
            //    return db.TblTransorders.Any(e => e.OrdRecno == id);
            //}
           // return RedirectToAction(nameof(Detail));

        }
    }

