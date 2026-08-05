using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Method)]
public class PCIIMDKJBPO : JNLLKANKPEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PMMIAKMEDFG IFFHELHEEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly GGLAACLIDJL APFFAEDLIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60582B0", Offset = "0x60576B0", VA = "0x1860582B0")]
	public PCIIMDKJBPO(GGLAACLIDJL PNPCGLEFMEP = GGLAACLIDJL.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6058270", Offset = "0x6057670", VA = "0x186058270")]
	public PCIIMDKJBPO(PMMIAKMEDFG IOGCDPPIOEN, GGLAACLIDJL PNPCGLEFMEP = GGLAACLIDJL.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class BGOFANINFJB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6052940", Offset = "0x6051D40", VA = "0x186052940")]
	public BGOFANINFJB(int HFEAKOCKPHO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class BPHOCBKBMCO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly JFHBHDNAPPN EPKJGFPNEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int HPIPOHGBCMN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6056800", Offset = "0x6055C00", VA = "0x186056800")]
	public BPHOCBKBMCO(JFHBHDNAPPN BOOGGLNPHIA = JFHBHDNAPPN.ExitingPlayMode, int HFEAKOCKPHO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JFHBHDNAPPN
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class IFEMOHHKKEB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	public IFEMOHHKKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class JNLLKANKPEE : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MFMPNIOLPBG BBAFHMKBNBE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6052940", Offset = "0x6051D40", VA = "0x186052940")]
	public JNLLKANKPEE(MFMPNIOLPBG HFHPJPNJPKI = MFMPNIOLPBG.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MFMPNIOLPBG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_AfterSceneLoad = 0,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_BeforeSceneLoad = 1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Unity_AfterAssembliesLoaded = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unity_BeforeSplashScreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Unity_SubsystemRegistration = 4,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ManuallyInvoked = int.MaxValue
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DOOGMEGEKNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public DOOGMEGEKNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6056910", Offset = "0x6055D10", VA = "0x186056910")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60569E0", Offset = "0x6055DE0", VA = "0x1860569E0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JEPCKECHMNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public JEPCKECHMNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6058200", Offset = "0x6057600", VA = "0x186058200")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PKCLCGFKBAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public PKCLCGFKBAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60582F0", Offset = "0x60576F0", VA = "0x1860582F0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string JOIDPMLMMGD = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string LBDAMHKIMDL = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<MFMPNIOLPBG, IGrouping<MFMPNIOLPBG, MethodInfo>> BHLFHJIDMNL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type HAOOIHOIEJF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60597B0", Offset = "0x6058BB0", VA = "0x1860597B0")]
		private static void POPDFNJCABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6059DA0", Offset = "0x60591A0", VA = "0x186059DA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6058340", Offset = "0x6057740", VA = "0x186058340")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6058500", Offset = "0x6057900", VA = "0x186058500")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60584B0", Offset = "0x60578B0", VA = "0x1860584B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6058390", Offset = "0x6057790", VA = "0x186058390")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60583E0", Offset = "0x60577E0", VA = "0x1860583E0")]
		private static void BBONMGLFJOI(MFMPNIOLPBG HFHPJPNJPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6058550", Offset = "0x6057950", VA = "0x186058550")]
		private static IEnumerable<MethodInfo> FCGLHPCHIMH(Type AHKMGBDCGMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60595F0", Offset = "0x60589F0", VA = "0x1860595F0")]
		private static bool PLAGOCKGGIP(string FKJKJCMJMPH, out Dictionary<string, List<string>> IGKAACNDKEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6058D50", Offset = "0x6058150", VA = "0x186058D50")]
		private static IEnumerable<Type> PBBCENALOCK(Dictionary<string, List<string>> IGKAACNDKEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6058BB0", Offset = "0x6057FB0", VA = "0x186058BB0")]
		private static IEnumerable<MethodInfo> HEBPLDFCGBG(IEnumerable<Type> NONJEDCGPEF, Type AHKMGBDCGMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6058B20", Offset = "0x6057F20", VA = "0x186058B20")]
		internal static IEnumerable<MethodInfo> GLBIDIGDNAA(MFMPNIOLPBG HFHPJPNJPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6058610", Offset = "0x6057A10", VA = "0x186058610")]
		internal static void FLAJHFKEBPP(IEnumerable<MethodInfo> PCPAKCFILLB, Type ENIPEOINEKK, [Optional] object[] CNMIOIIAHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6058C90", Offset = "0x6058090", VA = "0x186058C90")]
		private static Dictionary<MFMPNIOLPBG, IGrouping<MFMPNIOLPBG, MethodInfo>> OINDEHMMMPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60594D0", Offset = "0x60588D0", VA = "0x1860594D0")]
		private static bool PEELPLAGMBA(MethodInfo EAJICJBAIFM, Type MDDGFKDBDFI, bool GGJKMHFHNHD)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6059F10", Offset = "0x6059310", VA = "0x186059F10")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GHCFGJPONFK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct CEMEPGHKDLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo IFMJJLDOKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public GGLAACLIDJL APFFAEDLIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool OLMDMDHLPLH;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<PMMIAKMEDFG, List<CEMEPGHKDLM>> KEBGJPGHFPB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static MMBGCEPKKOC EBNNIOGLOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static MMBGCEPKKOC ILALIHFAKMD;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static MMBGCEPKKOC NAPEINIAEPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MMBGCEPKKOC OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60580D0", Offset = "0x60574D0", VA = "0x1860580D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MMBGCEPKKOC IKNAMEFFNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60581C0", Offset = "0x60575C0", VA = "0x1860581C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MMBGCEPKKOC GILKGAACDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6057110", Offset = "0x6056510", VA = "0x186057110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6057330", Offset = "0x6056730", VA = "0x186057330")]
	[IFEMOHHKKEB]
	private static void GJIOLHICIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6056A50", Offset = "0x6055E50", VA = "0x186056A50")]
	[JNLLKANKPEE(MFMPNIOLPBG.Unity_AfterAssembliesLoaded)]
	private static void AGPCFKIDKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6057740", Offset = "0x6056B40", VA = "0x186057740")]
	public static MMBGCEPKKOC HOPGGMBPPEI(PMMIAKMEDFG IOGCDPPIOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60575B0", Offset = "0x60569B0", VA = "0x1860575B0")]
	private static void HOPGGMBPPEI(PMMIAKMEDFG IOGCDPPIOEN, MMBGCEPKKOC MKGOJGCIFGJ, ref MMBGCEPKKOC CKGKDHACBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6057980", Offset = "0x6056D80", VA = "0x186057980")]
	private static void HOPGGMBPPEI(PMMIAKMEDFG IOGCDPPIOEN, MMBGCEPKKOC CKGKDHACBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6057220", Offset = "0x6056620", VA = "0x186057220")]
	public static void DBFNBIBCIFF(PMMIAKMEDFG IOGCDPPIOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60573E0", Offset = "0x60567E0", VA = "0x1860573E0")]
	private static bool GKNJEEOLMCC(GGLAACLIDJL PNPCGLEFMEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6057FE0", Offset = "0x60573E0", VA = "0x186057FE0")]
	private static MMBGCEPKKOC IHKKGFJJNLO(string CAEHGINOLEP, [Optional] MMBGCEPKKOC MKGOJGCIFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6057150", Offset = "0x6056550", VA = "0x186057150")]
	private static void DBFNBIBCIFF(ref MMBGCEPKKOC CKGKDHACBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6057330", Offset = "0x6056730", VA = "0x186057330")]
	private static void LPGHAFPGLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6056B40", Offset = "0x6055F40", VA = "0x186056B40")]
	private static IEnumerable<CEMEPGHKDLM> CCDLBBBKPGK(PMMIAKMEDFG IOGCDPPIOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60574C0", Offset = "0x60568C0", VA = "0x1860574C0")]
	private static MMBGCEPKKOC HNGKKJAPFCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LIFKBKEBDKD<T> : IDisposable where T : global::LIFKBKEBDKD<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T AGBKKGEFEHG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T KGKEDLDKCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3893300", Offset = "0x3892700", VA = "0x183893300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	protected LIFKBKEBDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38932C0", Offset = "0x38926C0", VA = "0x1838932C0", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum GGLAACLIDJL
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum PMMIAKMEDFG
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Room
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
