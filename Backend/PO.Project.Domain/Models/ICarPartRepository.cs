using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
    
    public class CarPartModule : Autofac.Module
    {

    
    public interface ICarPartRepository
    {
            CarPart GetCarPart(int Id);
    }


    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);
        builder.RegisterAssemblyTypes(typeof(ICarPartRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
    }



    }

}
