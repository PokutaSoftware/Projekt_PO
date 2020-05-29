using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
   public class ServicesUsedModule:Autofac.Module
    {
        public interface IServicesUsedRepository
        {
            ServicesUsed GetServicesUsed(int Id);
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IServicesUsedRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }


    }
}
