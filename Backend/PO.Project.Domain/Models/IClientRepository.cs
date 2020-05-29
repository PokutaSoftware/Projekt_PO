using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
    public class ClientModule:Autofac.Module
    {
    public interface IClientRepository
        {
            Client GetClient(int Id);
        }



        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IClientRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }

    }
}
