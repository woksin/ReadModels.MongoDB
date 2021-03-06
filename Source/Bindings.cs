/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Dolittle.DependencyInversion;
using MongoDB.Driver;

namespace Dolittle.ReadModels.MongoDB
{
    /// <summary>
    /// Represents a <see cref="ICanProvideBindings">provider of bindings</see> for Mini MongoDB implementations
    /// </summary>
    public class Bindings : ICanProvideBindings
    {
        /// <inheritdoc/>
        public void Provide(IBindingProviderBuilder builder)
        {
            builder.Bind<IMongoDatabase>().To<MongoDatabaseProxy>();
            builder.Bind(typeof(IMongoCollection<>)).To(typeof(MongoCollectionProxy<>));
        }
    }
}