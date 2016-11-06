﻿namespace AngleSharp.Core.Tests.Mocks
{
    using AngleSharp.Scripting;
    using AngleSharp.Scripting.Services;
    using System;

    class MockScriptService<T> : IScriptingProvider
        where T : IScriptEngine
    {
        private readonly T _engine;

        public MockScriptService(T engine)
        {
            _engine = engine;
        }

        public IScriptEngine GetEngine(String mimeType)
        {
            return _engine;
        }
    }
}
