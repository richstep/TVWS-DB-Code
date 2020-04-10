// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Whitespace.Common.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Unity;
    using Unity.Registration;
    using Unity.Resolution;

    public static class UnityExtensions
    {
        /// <summary>
        /// Resolve all the registered instances of type T.
        /// </summary>
        /// <typeparam name="T"> Type </typeparam>
        /// <param name="container">The unity container instance.</param>
        /// <returns>Collection of resolve type T.</returns>
        /// <remarks>
        /// This extension method is a fix for the bug in unity ResolveAll Generic method.
        /// For more details follow the thread at "http://unity.codeplex.com/workitem/3392"
        /// </remarks>
        public static IEnumerable<T> ResolveAll<T>(this Unity.IUnityContainer container)
        {

            // IEnumerable <ContainerRegistration> names = container.Registrations.Where(registration => registration.RegisteredType == typeof(T));
            IEnumerable<IContainerRegistration> names = container.Registrations.Where(registration => registration.RegisteredType == typeof(T));


            foreach (ContainerRegistration registration in names)
            {
                //TODO yield return container.Resolve<T>(registration.Name);
                

            }

            return null;
        }
    }
}
