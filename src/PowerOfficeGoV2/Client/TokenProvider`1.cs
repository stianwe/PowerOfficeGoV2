// <auto-generated>
/*
 * merged spec
 *
 * merged spec
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Linq;
using System.Collections.Generic;
using PowerOfficeGoV2.Client;

namespace PowerOfficeGoV2
{
    /// <summary>
    /// A class which will provide tokens.
    /// </summary>
    public abstract class TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        /// <summary>
        /// The array of tokens.
        /// </summary>
        protected TTokenBase[] _tokens;

        internal abstract System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(string header = "", System.Threading.CancellationToken cancellation = default);

        /// <summary>
        /// Instantiates a TokenProvider.
        /// </summary>
        /// <param name="tokens"></param>
        public TokenProvider(IEnumerable<TTokenBase> tokens)
        {
            _tokens = tokens.ToArray();

            if (_tokens.Length == 0)
                throw new ArgumentException("You did not provide any tokens.");
        }
    }
}