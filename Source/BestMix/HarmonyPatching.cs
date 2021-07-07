﻿using System.Reflection;
using BestMix.Patches;
using HarmonyLib;
using Verse;

namespace BestMix
{
    [StaticConstructorOnStartup]
    internal static class HarmonyPatching
    {
        static HarmonyPatching()
        {
            var harmony = new Harmony("com.Pelador.Rimworld.BestMix");
#if DEBUG
            Harmony.DEBUG = true;
#endif
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            HarmonyPatchTool.PatchAll(harmony);
        }
    }
}