using AuthenticationHandler.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using IO.Swagger.Models;

namespace Core.Api.Business
{
    public class DepartmentBusiness : BusinessBase
    {
        private List<Departamento> Departments;

        public DepartmentBusiness(TmsTcEntities context, ClaimsPrincipal user) :base(context, user)
        {
            this.Departments = context.Departamento.ToList();
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = (from d in this.Departments
                                            select new Department()
                                            {
                                                Id = (int)d.Id,
                                                Active = (bool)d.Active,
                                                Name = d.Name,
                                                Description = d.Description,
                                                Key = d.Key,
                                            }).ToList();
            return departments;
        }

        public Department GetDepartmentByid(int idDepartment)
        {
            var departmento = this.Departments.FirstOrDefault(d => d.Id == idDepartment);
            Department departament = new Department()
            {
                Id = (int)departmento.Id,
                Active = (bool)departmento.Active,
                Name = departmento.Name,
                Description = departmento.Description,
                Key = departmento.Key,
            };
            return departament;
        }

        public int CreateDepartment(Department department)
        {
            Departamento departamento = new Departamento
            {
                Id = (int)department.Id,
                Active = (bool)department.Active,
                Name = department.Name,
                Description = department.Description,
                Key = department.Key,
                CreatedBy = CurrentUser.Id,
                CreatedAt = DateTime.Now,
                UpdatedBy = CurrentUser.Id,
                UpdatedAt = DateTime.Now
            };

            this.Departments.Add(departamento);
            return this.Context.SaveChanges();
        }

        public int UpdateDepartment(int id, Department department)
        {
            Departamento departamento = this.Context.Departamento.FirstOrDefault(x => x.Id == id);

            departamento.Active = (bool)department.Active;
            departamento.Name = department.Name;
            departamento.Description = department.Description;
            departamento.Key = department.Key;
            departamento.CreatedBy = CurrentUser.Id;
            departamento.CreatedAt = DateTime.Now;
            departamento.UpdatedBy = CurrentUser.Id;
            departamento.UpdatedAt = DateTime.Now;

            this.Departments.Add(departamento);
            return this.Context.SaveChanges();
        }

        public int DeleteDepartmentBy(int id)
        {
            Departamento departamento = this.Context.Departamento.FirstOrDefault(x => x.Id == id);
            this.Context.Departamento.Remove(departamento);
            return this.Context.SaveChanges();
        
        }

    }
}
