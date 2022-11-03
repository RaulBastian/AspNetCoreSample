namespace AspNetCoreSample.Model.DbInitializer
{
    public static class DbRandom
    {
        private static Random random = new Random(DateTime.Now.Second);

        public static int GetNumber(int max)
        {
            return random.Next(max);
        }

    }
}
