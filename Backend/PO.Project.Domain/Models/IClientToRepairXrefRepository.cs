using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PO.Project.Domain.Models
{
    public class ClientToRepairXrefModule:Autofac.Module
    {
        public interface IClientToRepairXrefRepository
        {
            
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IClientToRepairXrefRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }

    }
}
