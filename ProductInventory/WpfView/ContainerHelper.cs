using Microsoft.Practices.Unity;
using ProductInventory.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfView
{
    public static class ContainerHelper
    {
        private static IUnityContainer _container;

        static ContainerHelper()
        {
            _container = new UnityContainer();
            _container.RegisterType<IProductRepository, ProductRepository>(new ContainerControlledLifetimeManager());

        }


        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }


}
