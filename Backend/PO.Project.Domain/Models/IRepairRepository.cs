using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
    public class RepairModule:Autofac.Module
    {
        public interface IRepairRepository
        {
            Repair GetRepair(int Id);
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IRepairRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }




    }
}
