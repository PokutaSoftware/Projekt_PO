using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
    public class EmployeeToRepairXrefModule:Autofac.Module
    {
        public interface IEmployeeToRepairXrefRepository
        {
            
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IEmployeeToRepairXrefRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }


    }
}
