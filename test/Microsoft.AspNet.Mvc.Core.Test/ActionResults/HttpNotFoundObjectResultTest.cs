// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.WebUtilities;
using Xunit;

namespace Microsoft.AspNet.Mvc
{
    public class HttpNotFoundObjectResultTest
    {
        [Fact]
        public void HttpNotFoundObjectResult_InitializesStatusCode()
        {
            // Arrange & act
            var notFound = new HttpNotFoundObjectResult(null);

            // Assert
            Assert.Equal(StatusCodes.Status404NotFound, notFound.StatusCode);
        }

        [Fact]
        public void HttpNotFoundObjectResult_InitializesStatusCodeAndResponseContent()
        {
            // Arrange & act
            var notFound = new HttpNotFoundObjectResult("Test Content");

            // Assert
            Assert.Equal(StatusCodes.Status404NotFound, notFound.StatusCode);
            Assert.Equal("Test Content", notFound.Value);
        }
    }
}