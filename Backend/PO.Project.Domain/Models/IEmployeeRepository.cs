using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
    public class EmployeeModule:Autofac.Module
    {
        public interface IEmployeeRepository
        {
            Employee GetEmployee(int Id);
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IEmployeeRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }


    }
}
