using System;
namespace CSharpSandbox
{
    public class Test
    {
        public string? TestName { get; set; }

        public string RunTest(string t)
        {
            return string.Concat(Enumerable.Repeat("0", 10).ToList());
        }

    }
}