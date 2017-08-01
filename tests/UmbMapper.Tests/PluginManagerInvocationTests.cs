﻿using System;
using System.Collections.Generic;
using System.Linq;
using UmbMapper.Invocations;
using UmbMapper.Tests.Mapping.Models;
using Xunit;

namespace UmbMapper.Tests
{
    public class PluginManagerInvocationTests
    {
        [Fact]
        public void CanResolveRuntimeTypes()
        {
            IEnumerable<Type> types = PluginManagerInvocations.ResolveTypes(typeof(PublishedItem));

            Assert.NotNull(types);
            Assert.True(types.Contains(typeof(PublishedItem)));
        }
    }
}
