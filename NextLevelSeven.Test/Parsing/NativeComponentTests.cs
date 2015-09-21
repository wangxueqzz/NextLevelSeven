﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextLevelSeven.Core;

namespace NextLevelSeven.Test.Native
{
    [TestClass]
    public class NativeComponentTests : NativeTestFixture
    {
        [TestMethod]
        public void Component_CanBeCloned()
        {
            var component = Message.Parse(ExampleMessages.Standard)[1][3][1][1];
            var clone = component.Clone();
            Assert.AreNotSame(component, clone, "Cloned component is the same referenced object.");
            Assert.AreEqual(component.Value, clone.Value, "Cloned component has different contents.");
        }

        [TestMethod]
        public void Component_CanAddDescendantsAtEnd()
        {
            var component = Message.Parse(ExampleMessages.Standard)[2][3][4][1];
            var count = component.ValueCount;
            var id = Randomized.String();
            component[count + 1].Value = id;
            Assert.AreEqual(count + 1, component.ValueCount,
                @"Number of elements after appending at the end of a component is incorrect.");
        }

        [TestMethod]
        public void Component_CanGetSubcomponentsByIndexer()
        {
            var id1 = Randomized.String();
            var id2 = Randomized.String();
            var id3 = Randomized.String();
            var id4 = Randomized.String();
            var component =
                Message.Parse(string.Format("MSH|^~\\&|{0}~{1}^{2}&{3}", id1, id2, id3, id4))[1][3][2][2][2];
            Assert.AreEqual(id4, component.Value);
        }

        [TestMethod]
        public void Component_CanDeleteSubcomponent()
        {
            var message = Message.Parse("MSH|^~\\&|\rTST|123^456&ABC~789^012");
            var component = message[2][1][1][2];
            component.Delete(1);
            Assert.AreEqual("MSH|^~\\&|\rTST|123^ABC~789^012", message.Value, @"Message was modified unexpectedly.");
        }

        [TestMethod]
        public void Component_CanWriteStringValue()
        {
            var component = Message.Parse(ExampleMessages.Standard)[1][3][1][1];
            var value = Randomized.String();
            component.Value = value;
            Assert.AreEqual(value, component.Value, "Value mismatch after write.");
        }

        [TestMethod]
        public void Component_CanWriteNullValue()
        {
            var component = Message.Parse(ExampleMessages.Standard)[1][3][1][1];
            var value = Randomized.String();
            component.Value = value;
            component.Value = null;
            Assert.IsNull(component.Value, "Value mismatch after write.");
        }
    }
}