using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
   public class OwnerModule:Autofac.Module
    {

        public interface IOwnerRepository
        {
            Owner GetOwner(int Id);
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IOwnerRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }


    }
}
