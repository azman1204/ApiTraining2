using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ApiConsumer
    {
        public static void Runme() {
            var response = Demo1();
            // deserialize JSON
            string json = response.Result;
            List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(json);
            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.name} \t {emp.age}");
            }
            //Console.WriteLine(employees); // print list of employee
        }

        public static async Task<string> Demo1()
        {
            // HttpClient imagine a browser / Postman
            HttpClient client = new HttpClient();
            string url = "https://localhost:7024/api/employee";
            var response = client.GetStringAsync(url);
            return await response;
        }
    }

    class Employee
    { 
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }
    }
}
