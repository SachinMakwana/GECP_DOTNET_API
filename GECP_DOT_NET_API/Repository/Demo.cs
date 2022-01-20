using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public class Demo:IDemo
    {
        GECP_ADMINContext dbEntities = new GECP_ADMINContext();
        public IList<string> GetNames()
        {
            //IList<FacultyDetailsVM> x = new List<FacultyDetailsVM>();
            //x = dbEntities.FacultyDetails.Select(m=>new FacultyDetailsVM() { Id = m.Id, DeptId = m.DeptId}).ToList();

            FacultyDetailsVM facultyDetailsVM = new FacultyDetailsVM();

            using (dbEntities=new GECP_ADMINContext())
            {
                
                FacultyDetail obj = new FacultyDetail();
                obj = dbEntities.FacultyDetails.Where(model => model.Id == facultyDetailsVM.Id).FirstOrDefault();
                obj.IsDeleted = true;
                obj.Id = facultyDetailsVM.Id;
                obj.DesignationId = facultyDetailsVM.DesignationId;
                //dbEntities.FacultyDetails.Add(obj);
                //dbEntities.FacultyDetails.Remove(obj);
                dbEntities.SaveChanges();

            }

            return new List<string>(){
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        }
    }
}
