using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
namespace PO.Project.Domain.Models
{
    public class UserModule:Autofac.Module
    {

        public interface IUserRepository
        {
            User GetUser(int Id);
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(typeof(IUserRepository).GetTypeInfo().Assembly).AsImplementedInterfaces();
        }
    }
}
