// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.Testing;
using Xunit;

namespace Microsoft.AspNetCore.Mvc.FunctionalTests
{
    [Repeat]
    public class SystemTextJsonInputFormatterTest : JsonInputFormatterTestBase<FormatterWebSite.StartupWithJsonFormatter>
    {
        public SystemTextJsonInputFormatterTest(MvcTestFixture<FormatterWebSite.StartupWithJsonFormatter> fixture)
            : base(fixture)
        {
        }

        [Fact]
        public override Task JsonInputFormatter_RoundtripsRecordType()
            => base.JsonInputFormatter_RoundtripsRecordType();

        [Fact]
        public override Task JsonInputFormatter_ValidationWithRecordTypes_NoValidationErrors()
            => base.JsonInputFormatter_ValidationWithRecordTypes_NoValidationErrors();

        [Fact]
        public override Task JsonInputFormatter_ValidationWithRecordTypes_ValidationErrors()
            => base.JsonInputFormatter_ValidationWithRecordTypes_ValidationErrors();
    }
}
