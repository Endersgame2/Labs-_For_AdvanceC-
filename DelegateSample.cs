namespace labs_assignment
{
    public delegate string RandomDelegate(string wordArg, int numArg);
    public static class DelegateSample
    {
        public static string RandomFunction(string wordArg, int numArg, RandomDelegate randomDelegate)
        {
            return randomDelegate(wordArg, numArg);
        }
    }
}
