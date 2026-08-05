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
public class JGJJPBKAAKL : MEDELDMGJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DNFMHNHLIMA GCGMJOHFFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly HKPPGBCDEPD LHKILKEKEFC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6059BF0", Offset = "0x60587F0", VA = "0x186059BF0")]
	public JGJJPBKAAKL(HKPPGBCDEPD COGEGMHDELN = HKPPGBCDEPD.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6059C30", Offset = "0x6058830", VA = "0x186059C30")]
	public JGJJPBKAAKL(DNFMHNHLIMA POJONJKJOIF, HKPPGBCDEPD COGEGMHDELN = HKPPGBCDEPD.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class DBBNCPOBEMI : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6057FF0", Offset = "0x6056BF0", VA = "0x186057FF0")]
	public DBBNCPOBEMI(int ILJBAGMHILE = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class AKLMCCEMLAH : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OAKCDKKFGKB DFCAOEEHDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int MCHGIDGNMMM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6058D70", Offset = "0x6057970", VA = "0x186058D70")]
	public AKLMCCEMLAH(OAKCDKKFGKB NLHNOPGEPKJ = OAKCDKKFGKB.ExitingPlayMode, int ILJBAGMHILE = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OAKCDKKFGKB
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
public class GBAILBPBCKK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8143D0", Offset = "0x812FD0", VA = "0x1808143D0")]
	public GBAILBPBCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class MEDELDMGJHM : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MEBIFFDBFIH HINECANOFKJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6057FF0", Offset = "0x6056BF0", VA = "0x186057FF0")]
	public MEDELDMGJHM(MEBIFFDBFIH IIHFFOBCPEA = MEBIFFDBFIH.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MEBIFFDBFIH
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
		private sealed class OJFEBKEFIDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public OJFEBKEFIDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x605B420", Offset = "0x605A020", VA = "0x18605B420")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x605B4F0", Offset = "0x605A0F0", VA = "0x18605B4F0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FJMBNLEBMHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public FJMBNLEBMHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6059B80", Offset = "0x6058780", VA = "0x186059B80")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OLOINDIMOJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public OLOINDIMOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x605B560", Offset = "0x605A160", VA = "0x18605B560")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string PIGEDMMDOPN = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string OCGHABCKJAM = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<MEBIFFDBFIH, IGrouping<MEBIFFDBFIH, MethodInfo>> MMHJDENLNMC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type NBCDCEGAEEK;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x605C960", Offset = "0x605B560", VA = "0x18605C960")]
		private static void MDJGAMPLAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x605D010", Offset = "0x605BC10", VA = "0x18605D010")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x605B5B0", Offset = "0x605A1B0", VA = "0x18605B5B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x605B9D0", Offset = "0x605A5D0", VA = "0x18605B9D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x605B980", Offset = "0x605A580", VA = "0x18605B980")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x605B600", Offset = "0x605A200", VA = "0x18605B600")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x605C2C0", Offset = "0x605AEC0", VA = "0x18605C2C0")]
		private static void GBOHFFOOAFF(MEBIFFDBFIH IIHFFOBCPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x605C8A0", Offset = "0x605B4A0", VA = "0x18605C8A0")]
		private static IEnumerable<MethodInfo> LNPEFCCCKJJ(Type AKAOJBHGGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x605B650", Offset = "0x605A250", VA = "0x18605B650")]
		private static bool BHAOOIBPOON(string OLJEDPPEPIL, out Dictionary<string, List<string>> MHNAGOOBBKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x605BA20", Offset = "0x605A620", VA = "0x18605BA20")]
		private static IEnumerable<Type> CLBJNOAJJMG(Dictionary<string, List<string>> MHNAGOOBBKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x605B8A0", Offset = "0x605A4A0", VA = "0x18605B8A0")]
		private static IEnumerable<MethodInfo> BKEAGIDNEOC(IEnumerable<Type> HAAPMPEHPPA, Type AKAOJBHGGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x605B810", Offset = "0x605A410", VA = "0x18605B810")]
		internal static IEnumerable<MethodInfo> BIFEEKONHOG(MEBIFFDBFIH IIHFFOBCPEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x605C390", Offset = "0x605AF90", VA = "0x18605C390")]
		internal static void INDFHFBBEPH(IEnumerable<MethodInfo> BLCKADOCACH, Type GJJIALGNNMJ, [Optional] object[] FPLMCNNAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x605CF50", Offset = "0x605BB50", VA = "0x18605CF50")]
		private static Dictionary<MEBIFFDBFIH, IGrouping<MEBIFFDBFIH, MethodInfo>> MLADFEFCAAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x605C1A0", Offset = "0x605ADA0", VA = "0x18605C1A0")]
		private static bool DFGPPCBDFLK(MethodInfo LNGCPCCGKMP, Type FPEBCHIEHOC, bool PNPILAFFBML)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x605D180", Offset = "0x605BD80", VA = "0x18605D180")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MOOAIELFANL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct IGBFMOGGHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo IBPMCHFFJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public HKPPGBCDEPD LHKILKEKEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool CCMLLFCKCPI;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<DNFMHNHLIMA, List<IGBFMOGGHMI>> LEAAJFCEGDH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static FNLADHKGADM BJJJIPBIDMD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static FNLADHKGADM EHEHKCDDKEM;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static FNLADHKGADM HDNOEOGABEB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FNLADHKGADM MNGIEAKGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x605AA20", Offset = "0x6059620", VA = "0x18605AA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FNLADHKGADM MOBEKOOFGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x605B3E0", Offset = "0x6059FE0", VA = "0x18605B3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FNLADHKGADM BGIMNEEDLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x605AC00", Offset = "0x6059800", VA = "0x18605AC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x605A6A0", Offset = "0x60592A0", VA = "0x18605A6A0")]
	[GBAILBPBCKK]
	private static void BHAJIMDFOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x605A930", Offset = "0x6059530", VA = "0x18605A930")]
	[MEDELDMGJHM(MEBIFFDBFIH.Unity_AfterAssembliesLoaded)]
	private static void DJNAFNNHAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6059E00", Offset = "0x6058A00", VA = "0x186059E00")]
	public static FNLADHKGADM BBMAKMODKFA(DNFMHNHLIMA POJONJKJOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6059C70", Offset = "0x6058870", VA = "0x186059C70")]
	private static void BBMAKMODKFA(DNFMHNHLIMA POJONJKJOIF, FNLADHKGADM PMOACODFDOJ, ref FNLADHKGADM MDGENIFLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x605A040", Offset = "0x6058C40", VA = "0x18605A040")]
	private static void BBMAKMODKFA(DNFMHNHLIMA POJONJKJOIF, FNLADHKGADM MDGENIFLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x605A750", Offset = "0x6059350", VA = "0x18605A750")]
	public static void CGDFLKLEEKE(DNFMHNHLIMA POJONJKJOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x605AD30", Offset = "0x6059930", VA = "0x18605AD30")]
	private static bool JHLJIIOFKDL(HKPPGBCDEPD COGEGMHDELN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x605AB10", Offset = "0x6059710", VA = "0x18605AB10")]
	private static FNLADHKGADM FHEDOIMEBMO(string GFLKEFKJFNM, [Optional] FNLADHKGADM PMOACODFDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x605A860", Offset = "0x6059460", VA = "0x18605A860")]
	private static void CGDFLKLEEKE(ref FNLADHKGADM MDGENIFLAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x605A6A0", Offset = "0x60592A0", VA = "0x18605A6A0")]
	private static void BHDNPBOIKKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x605AE10", Offset = "0x6059A10", VA = "0x18605AE10")]
	private static IEnumerable<IGBFMOGGHMI> KDMJPMKGDIF(DNFMHNHLIMA POJONJKJOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x605AC40", Offset = "0x6059840", VA = "0x18605AC40")]
	private static FNLADHKGADM IIMINPLIBEI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CEOGADCEIEJ<T> : IDisposable where T : global::CEOGADCEIEJ<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T JBMLNCPMHCB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T OHEGMANNBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x30DFB10", Offset = "0x30DE710", VA = "0x1830DFB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
	protected CEOGADCEIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30DFAD0", Offset = "0x30DE6D0", VA = "0x1830DFAD0", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum HKPPGBCDEPD
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum DNFMHNHLIMA
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
