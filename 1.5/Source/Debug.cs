namespace Floordrawings
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{FloordrawingsMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
