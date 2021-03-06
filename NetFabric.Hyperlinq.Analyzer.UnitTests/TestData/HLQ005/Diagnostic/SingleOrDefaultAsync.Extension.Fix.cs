﻿using NetFabric.Hyperlinq.Analyzer.UnitTests.TestData;
using System.Threading.Tasks;

namespace HLQ005.Diagnostic
{
    partial class Class
    {
        public ValueTask<TestType> Test_SingleOrDefaultAsync_Extensions()
            => new OptimizedAsyncEnumerable<TestType>().FirstOrDefaultAsync();
    }
}
