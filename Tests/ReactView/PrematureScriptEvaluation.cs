﻿using System;
using NUnit.Framework;

namespace Tests.ReactView {

    public class PrematureScriptEvaluation : ReactViewTestBase {

        protected override bool WaitForReady => false;

        [Test(Description = "Test executing a method before view is ready")]
        public void ExecuteBeforeReady() {
            var eventCalled = false;
            TargetView.Event += (args) => eventCalled = true;
            TargetView.ExecuteMethod("callEvent");
            WaitFor(() => eventCalled, DefaultTimeout, "event call");
        }
    }
}
