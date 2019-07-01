using Griffin.Container;
using Splat;
using System;
using System.Collections.Generic;

namespace IpsPeek.Vendor
{
    public class GriffinDependancyResolver : IDependencyResolver
    {
        private readonly ContainerRegistrar _registrar;
        private Container _container;

        public GriffinDependancyResolver(ContainerRegistrar registrar)
        {
            _registrar = registrar;
            _container = _registrar.Build();
        }

        public void Dispose()
        {
        }

        public object GetService(Type serviceType, string contract = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(contract)) throw new NotSupportedException();

                return _container.Resolve(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType, string contract = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(contract)) throw new NotSupportedException();

                return _container.ResolveAll(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool HasRegistration(Type serviceType, string contract = null)
        {
            if (!string.IsNullOrEmpty(contract)) throw new NotSupportedException();

            return _container.IsRegistered(serviceType);
        }

        public void Register(Func<object> factory, Type serviceType, string contract = null)
        {
            if (!string.IsNullOrEmpty(contract)) throw new NotSupportedException();

            _registrar.RegisterService(serviceType, (c) => factory(), Lifetime.Transient);
            _container = _registrar.Build();
        }

        public IDisposable ServiceRegistrationCallback(Type serviceType, string contract, Action<IDisposable> callback)
        {
            throw new NotImplementedException();
        }

        public void UnregisterAll(Type serviceType, string contract = null)
        {
            // if (!string.IsNullOrEmpty(contract)) throw new NotSupportedException();

            throw new NotImplementedException();
        }

        public void UnregisterCurrent(Type serviceType, string contract = null)
        {
            throw new NotImplementedException();

            //if (!string.IsNullOrEmpty(contract)) throw new NotSupportedException();

            //var isNull = serviceType is null;

            //    if (isNull)
            //    {
            //        serviceType = typeof(NullServiceType);
            //    }

            //    var bindings = _registrar.(serviceType).ToArray();

            //    if (bindings is null || bindings.Length < 1)
            //    {
            //        return;
            //    }        }
        }
    }
}