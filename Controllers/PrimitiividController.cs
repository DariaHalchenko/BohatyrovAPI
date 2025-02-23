﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BohatyrovAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrimitiividController : ControllerBase
    {

        // GET: primitiivid/hello-world
        [HttpGet("hello-world")]
        public string HelloWorld()
        {
            return "Hello world at " + DateTime.Now;
        }

        // GET: primitiivid/hello-variable/mari
        [HttpGet("hello-variable/{nimi}")]
        public string HelloVariable(string nimi)
        {
            return "Hello " + nimi;
        }

        // GET: primitiivid/add/5/6
        [HttpGet("add/{nr1}/{nr2}")]
        public int AddNumbers(int nr1, int nr2)
        {
            return nr1 + nr2;
        }

        // GET: primitiivid/multiply/5/6
        [HttpGet("multiply/{nr1}/{nr2}")]
        public int Multiply(int nr1, int nr2)
        {
            return nr1 * nr2;
        }



        // GET: primitiivid/do-logs/5
        [HttpGet("do-logs/{arv}")]
        public void DoLogs(int arv)
        {
            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("See on logi nr " + i);
            }
        }
        Random rnd = new Random();
        [HttpGet("random")]

        public int Random()
        {
            return rnd.Next();
        }

        [HttpGet("birthday/{yearOfBirth}")]

        public string Birthday(int yearOfBirth)
        {

            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - yearOfBirth;

       

            return $"oled nii või naa aastat vana {age}, olenevalt kas sellel aastal on sünnipäev juba olnud";
        }

        // GET: primitiivid/describe/10/20
        [HttpGet("describe/{nr1}/{nr2}")]
        public string DescribeNumbers(int nr1, int nr2)
        {
            return $"Lauses on kaks arvu: {nr1} ja {nr2}.";
        }
    }
}
