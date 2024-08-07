using HarmonyLib;
using Verse;

namespace Floordrawings
{
    public class FloordrawingsMod : Mod
    {
        public const string PACKAGE_ID = "floordrawings.1trickPwnyta";
        public const string PACKAGE_NAME = "Floordrawings";

        public FloordrawingsMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
