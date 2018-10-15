using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UtilLibrary.Test
{
    using UtilLibrary;

    public class IEnumerableExtentionsTest
    {
        [Fact]
        public void PushFrontTest()
        {
            IEnumerable<int> foo = new int[] { 0 };
            {
                var bar = foo.PushFront(1);
                Assert.Equal(bar, new int[] { 1, 0 });
                Assert.NotEqual(bar, new int[] { 0, 1 });
            }
            {
                var bar = foo.PushFront(1).PushFront(2).PushFront(3);
                Assert.Equal(bar, new int[] { 3, 2, 1, 0 });
                Assert.NotEqual(bar, new int[] { 0, 1, 2, 3 });
            }
        }

        [Fact]
        public void PushBackTest()
        {
            IEnumerable<int> foo = new int[] { 0 };
            {
                var bar = foo.PushBack(1);
                Assert.Equal(bar, new int[] { 0, 1 });
                Assert.NotEqual(bar, new int[] { 1, 0 });
            }
            {
                var bar = foo.PushBack(1).PushBack(2).PushBack(3);
                Assert.Equal(bar, new int[] { 0, 1, 2, 3 });
                Assert.NotEqual(bar, new int[] { 3, 2, 1, 0 });
            }
        }

        [Fact]
        public void IsSortedTest()
        {
            Assert.True(new int[] { 0, 1, 2, 3 }.IsSorted((a, b) => Math.Min(a, b) == a));
            Assert.False(new int[] { 3, 2, 1, 0 }.IsSorted((a, b) => Math.Min(a, b) == a));
        }

        [Fact]
        public void PopFrontTest()
        {
            Assert.Equal(new int[] { 0, 1, 2, 3 }.PopFront(), new int[] { 1, 2, 3 });
            Assert.NotEqual(new int[] { 0, 1, 2, 3 }.PopFront(), new int[] { 0, 1, 2 });
        }

        [Fact]
        public void PopBackTest()
        {
            Assert.Equal(new int[] { 0, 1, 2, 3 }.PopBack(), new int[] { 0, 1, 2 });
            Assert.NotEqual(new int[] { 0, 1, 2, 3 }.PopBack(), new int[] { 1, 2, 3 });
        }
    }
}
