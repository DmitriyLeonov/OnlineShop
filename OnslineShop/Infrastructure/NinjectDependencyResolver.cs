using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using OnlineStore.Domain.Abstract;
using OnlineStore.Domain.Entities;

namespace OnslineShop.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IItemRepository> mock = new Mock<IItemRepository>();
            mock.Setup(m => m.Items).Returns(new List<Item>());
            kernel.Bind<IItemRepository>().ToConstant(mock.Object);
        }
    }
}