using HarmonyLib;
using NeosModLoader;
using FrooxEngine;

namespace Fools
{
	public class Fools : NeosMod
	{
		public override string Name => "Fools";
		public override string Author => "eia485";
		public override string Version => "1.0.0";
		public override string Link => "https://github.com/eia485/NeosFools/";
		public override void OnEngineInit()
		{
			Harmony harmony = new Harmony("net.eia485.Fools");
			harmony.PatchAll();
		}

		[HarmonyPatch(typeof(Engine), "IsAprilFools", MethodType.Getter)]
		class FoolsPatch
		{ 
			public static bool Prefix(ref bool __result) 
			{
				__result = true;
				return false;
			}
		}
	}
}