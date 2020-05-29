using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;

namespace PO.Project.Domain.Models
{
    public class ServiceModule:Autofac.Module
    {

        public interface IServiceRepository
        {
            Service GetService(int Id);
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IServiceRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }


    }
}
