using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public class Demo : IDemo
    {
        GECP_ADMINContext dbEntities;

        public FacultyDetailsVM GetFacultyDetail(int id)
        {
            try
            {
                using (dbEntities = new GECP_ADMINContext())
                {
                    var obj = dbEntities.FacultyDetails.Where(m => m.Id == id).FirstOrDefault();
                    if(obj != null)
                    {
                        return obj.Copy();
                    }

                    return null;
                    
                }
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AddFacultyDetail(FacultyDetailsVM facultyDetailsVM)
        {
            try
            {
                using (dbEntities = new GECP_ADMINContext())
                {
                    FacultyDetail dbObj = facultyDetailsVM.Copy();
                    dbEntities.FacultyDetails.Add(dbObj);
                    dbEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateFacultyDetail(FacultyDetailsVM facultyDetailsVM)
        {
            try
            {
                using (dbEntities = new GECP_ADMINContext())
                {
                    FacultyDetail dbObj = new FacultyDetail();
                    dbObj = dbEntities.FacultyDetails.Where(m=>m.Id==facultyDetailsVM.Id).FirstOrDefault();
                    //if (dbObj!=null)
                    //{
                    //    dbObj = facultyDetailsVM.Copy();
                    //}
                    dbObj.Name = facultyDetailsVM.Name;
                    //dbEntities.Entry(dbObj).State = EntityState.Modified;
                    dbEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteFacultyDetail(FacultyDetailsVM facultyDetailsVM)
        {
            try
            {
                using (dbEntities = new GECP_ADMINContext())
                {
                    FacultyDetail dbObj = new FacultyDetail();
                    dbObj = dbEntities.FacultyDetails.Where(m => m.Id == facultyDetailsVM.Id).FirstOrDefault();
                    //if (dbObj != null)
                    //{
                    //    dbObj = facultyDetailsVM.Copy();
                    //}
                    //dbEntities.Entry(dbObj).State = EntityState.Modified;
                    dbEntities.FacultyDetails.Remove(dbObj);
                    dbEntities.SaveChanges();
                }
                return true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IList<string> GetNames()
        {
            //IList<FacultyDetailsVM> x = new List<FacultyDetailsVM>();
            //x = dbEntities.FacultyDetails.Select(m=>new FacultyDetailsVM() { Id = m.Id, DeptId = m.DeptId}).ToList();

            FacultyDetailsVM facultyDetailsVM = new FacultyDetailsVM();


            using (dbEntities = new GECP_ADMINContext())
            {

                FacultyDetail obj = new FacultyDetail();
                facultyDetailsVM = obj.Copy();
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
