﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExampleApi.BusinessLogic
{
    public class TestService : ITestService
    {
        public TestService(TestService2 testService2) { }

        public TestService(int x) { }
    }
}
