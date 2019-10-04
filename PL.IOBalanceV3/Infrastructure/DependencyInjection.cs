using Autofac;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DataAccess.Entities.Context;
using DataAccess.Entities.Context.Interface;
using DataAccess.Repository.PL;
using DataAccess.Repository.PL.Interface;

using Business.IOBalanceV3;
using Business.IOBalanceV3.Interface;

namespace PL.IOBalanceV3.Infrastructure
{
    public class DependencyInjection
    {
        public ContainerBuilder OnConfigure(ContainerBuilder builder)
        {
            //Context Injection
            builder.RegisterType<IOBalanceDBV3Entities>().As<IIOBalanceDBV3Entities>().InstancePerLifetimeScope();

            //Generic Repository Injection
            builder.RegisterGeneric(typeof(PLRepository<>)).As(typeof(IPLRepository<>)).InstancePerLifetimeScope();

            builder.RegisterType<CommonServices>().As<ICommonServices>().InstancePerLifetimeScope();

            return builder;
        }
    }
}