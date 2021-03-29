using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2_MVC_ITI.Controllers
{
    public class CarController : Controller
    {
        static List<Car> cars = new List<Car>() {

          new Car(1, "red", "GT", "Ferrari"),
          new Car(2, "black", "Veyron", "Bugatti"),
          new Car(3, "silver", "Aventador", "Lamborghini"),
          new Car(4, "yellow", "Camaro SS", "Chevrolet")
        };
        // GET: Car
        public ActionResult GetAllCars()
        {
            ViewBag.carList = cars;
            return View();
        }

        public ActionResult GetCarById(int id)
        {
            ViewBag.car = cars.Where(C => C.Num == id).FirstOrDefault();
            return View();
        }

     
        public ActionResult Update(int id)
        {
            ViewBag.car = cars.Where(C => C.Num == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string color, string model, string manufacturer)
        {
            Car updatedCar = cars.Where(C => C.Num == id).FirstOrDefault();
            updatedCar.Num = id;
            updatedCar.Color = color;
            updatedCar.Model = model;
            updatedCar.Manufacturer = manufacturer;
            return RedirectToAction("GetAllCars");
        }

        public ActionResult Delete(int id)
        {
            cars.Remove(cars.Where(C => C.Num == id).FirstOrDefault());

            return RedirectToAction("GetAllCars");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int id, string color, string model, string manufacturer)
        {
            Car newCar = new Car(id,color,model,manufacturer);
            cars.Add(newCar);

            return RedirectToAction("GetAllCars");
        }
    }
}