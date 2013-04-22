namespace Utility
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Этот класс может быть заменет утилитами:
    ///     - Castle Windsor
    ///     - Unity
    ///     - Ninject
    ///     - любой другой IoC-контейнер
    /// </summary>
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, Type> Services = new Dictionary<Type, Type>();

        public static void RegisterService<T>(Type service)
        {
            Services[typeof (T)] = service;
        }

        public static T Resolve<T>()
        {
            return (T) Activator.CreateInstance(Services[typeof (T)]);
        }
    }
}