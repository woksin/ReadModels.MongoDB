/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 * --------------------------------------------------------------------------------------------*/
namespace Dolittle.ReadModels.MongoDB
{
    /// <summary>
    /// Represents a resource configuration for a MongoDB Read model implementation 
    /// </summary>
    public class ReadModelRepositoryConfiguration
    {
        /// <summary>
        /// Gets or set the Database name
        /// </summary>
        public string Database { get; set; }
        /// <summary>
        /// Gets or sets the connection string for the configuration
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the Host String
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// Gets or sets whether or not use SSL
        /// </summary>
        public bool UseSSL { get; set; }
     
     }
}