using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PO.Project.Domain.Models
{
    public class CarPartsUsedModule:Autofac.Module
    {
    public interface ICarPartsUsedRepository
        {
            CarPartsUsed GetCarPartsUsed(int Id);
        }


        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(ICarPartsUsedRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }



    }
}
