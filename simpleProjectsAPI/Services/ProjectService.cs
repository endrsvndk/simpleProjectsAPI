using simpleProjectsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = simpleProjectsAPI.Models.Task;

namespace simpleProjectsAPI.Services
{
    public class ProjectService
    {
        private List<Project> projects;

        public ProjectService()
        {
            this.projects = new List<Project>
            {
                new Project { Id=1, Name="Vinov", Description="Borç-Alacak yönetim sistemi", CategoryId=1, Tasks=new  List<Task>{
                    new Task { Id=1, Name="Data Access katmanı oluşturulması", IsCompleted=false, ExpectedEndDate=DateTime.Now.AddDays(10)},
                    new Task { Id=2, Name="Angular ile önyüz geliştirme ", IsCompleted=true, ExpectedEndDate=DateTime.Now.AddDays(8)},

                }  },
                 new Project { Id=2, Name="Sözleşme", Description="Satın alma için sözleşme...", CategoryId=2, Tasks=new  List<Task>{
                    new Task { Id=3, Name="Backend alt yapısına karar verilmesi", IsCompleted=false, ExpectedEndDate=DateTime.Now.AddDays(15)},
                    new Task { Id=4, Name="Postgresql db optimizasyonu", IsCompleted=true, ExpectedEndDate=DateTime.Now.AddDays(20)},

                }  },
                  new Project { Id=3, Name="Personel Alım", Description="İK Özlük Yönetimi", CategoryId=3, Tasks=new  List<Task>{
                    new Task { Id=5, Name="API'lerin analizi", IsCompleted=false, ExpectedEndDate=DateTime.Now.AddDays(30)},
                    new Task { Id=6, Name="Elastic search ar-ge'si yapılacak ", IsCompleted=true, ExpectedEndDate=DateTime.Now.AddDays(42)},

                }  },
                   new Project { Id=4, Name="Vinow", Description="Borç-Alacak yönetim sistemi", CategoryId=1, Tasks=new  List<Task>{
                    new Task { Id=7, Name="Data Access katmanı oluşturulması", IsCompleted=false, ExpectedEndDate=DateTime.Now.AddDays(10)},
                    new Task { Id=8, Name="Angular ile önyüz geliştirme ", IsCompleted=true, ExpectedEndDate=DateTime.Now.AddDays(8)},

                }  }

            };
        }
        public List<Project> GetProjects()
        {
            return projects;
        }
    }
}
