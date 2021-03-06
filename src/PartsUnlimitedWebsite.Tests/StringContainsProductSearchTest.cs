// <copyright file="StringContainsProductSearchTest.cs">Copyright © Microsoft 2015</copyright>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartsUnlimited.Models;
using PartsUnlimited.ProductSearch;

namespace PartsUnlimited.ProductSearch.Tests
{
    /// <summary>This class contains parameterized unit tests for StringContainsProductSearch</summary>
    [PexClass(typeof(StringContainsProductSearch))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StringContainsProductSearchTest
    {
        /// <summary>Test stub for Search(String)</summary>
        [PexMethod]
        public Task<IEnumerable<Product>> SearchTest(
            [PexAssumeUnderTest]StringContainsProductSearch target,
            string query
        )
        {
            Task<IEnumerable<Product>> result = target.Search(query);
            return result;
            // TODO: add assertions to method StringContainsProductSearchTest.SearchTest(StringContainsProductSearch, String)
        }
    }
}
