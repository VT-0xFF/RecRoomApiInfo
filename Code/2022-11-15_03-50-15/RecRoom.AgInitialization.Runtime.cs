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
public class PBIPNKEGBNL : MBHKLJOPNMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CCKMMDPMKJH EIIMANKGEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly MIDPNFMDJEE IGANADNANDF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFC90", Offset = "0x5FEE690", VA = "0x185FEFC90")]
	public PBIPNKEGBNL(MIDPNFMDJEE FGHMIKACJGF = MIDPNFMDJEE.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFCD0", Offset = "0x5FEE6D0", VA = "0x185FEFCD0")]
	public PBIPNKEGBNL(CCKMMDPMKJH EHOMOADDGHA, MIDPNFMDJEE FGHMIKACJGF = MIDPNFMDJEE.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class NKPJIKGDKFE : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBB90", Offset = "0x5FEA590", VA = "0x185FEBB90")]
	public NKPJIKGDKFE(int NKLKLHAEGOD = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class DDIKHCMIJDB : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CAOPMCLNOKH OCPLJFNEADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int DPADGBLCMNH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBC70", Offset = "0x5FEA670", VA = "0x185FEBC70")]
	public DDIKHCMIJDB(CAOPMCLNOKH ECPEHEPKJNB = CAOPMCLNOKH.ExitingPlayMode, int NKLKLHAEGOD = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CAOPMCLNOKH
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
public class ICEOFGDOCJO : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	public ICEOFGDOCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class MBHKLJOPNMI : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly FECLCHMHGEE DLDAEHMDHIC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FEBB90", Offset = "0x5FEA590", VA = "0x185FEBB90")]
	public MBHKLJOPNMI(FECLCHMHGEE EKMHEOJHLDA = FECLCHMHGEE.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FECLCHMHGEE
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
		private sealed class CDBJHPGPJJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public CDBJHPGPJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5FEFA90", Offset = "0x5FEE490", VA = "0x185FEFA90")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5FEFB60", Offset = "0x5FEE560", VA = "0x185FEFB60")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FGDBIEGBNCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public FGDBIEGBNCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FEFBD0", Offset = "0x5FEE5D0", VA = "0x185FEFBD0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MLFCHLLHCLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public MLFCHLLHCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FEFC40", Offset = "0x5FEE640", VA = "0x185FEFC40")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string OPLCCOOMHLK = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string PCDIIAKOLHM = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<FECLCHMHGEE, IGrouping<FECLCHMHGEE, MethodInfo>> GDJACGEOCPP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type OONFKKLJLPO;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1180", Offset = "0x5FEFB80", VA = "0x185FF1180")]
		private static void LEOJBOMIDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1770", Offset = "0x5FF0170", VA = "0x185FF1770")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFD10", Offset = "0x5FEE710", VA = "0x185FEFD10")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFF90", Offset = "0x5FEE990", VA = "0x185FEFF90")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFF40", Offset = "0x5FEE940", VA = "0x185FEFF40")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFD60", Offset = "0x5FEE760", VA = "0x185FEFD60")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFDB0", Offset = "0x5FEE7B0", VA = "0x185FEFDB0")]
		private static void BKHAKKHFOLL(FECLCHMHGEE EKMHEOJHLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFE80", Offset = "0x5FEE880", VA = "0x185FEFE80")]
		private static IEnumerable<MethodInfo> BPECHICJEON(Type OEIGGGHLFND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0F00", Offset = "0x5FEF900", VA = "0x185FF0F00")]
		private static bool HCOKPILNDEF(string BGEJFNEAOPN, out Dictionary<string, List<string>> FEICPLBFDPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FF00C0", Offset = "0x5FEEAC0", VA = "0x185FF00C0")]
		private static IEnumerable<Type> EKKCNCEGGAC(Dictionary<string, List<string>> FEICPLBFDPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFFE0", Offset = "0x5FEE9E0", VA = "0x185FEFFE0")]
		private static IEnumerable<MethodInfo> CGMLEHLMNMB(IEnumerable<Type> GKLDKDMPMKM, Type OEIGGGHLFND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0E70", Offset = "0x5FEF870", VA = "0x185FF0E70")]
		internal static IEnumerable<MethodInfo> GPIAFNJDGEE(FECLCHMHGEE EKMHEOJHLDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0840", Offset = "0x5FEF240", VA = "0x185FF0840")]
		internal static void EPMKHAACFDN(IEnumerable<MethodInfo> LNMDLIKHDPC, Type EHNNADNMODB, [Optional] object[] INOCFKIFMHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FF10C0", Offset = "0x5FEFAC0", VA = "0x185FF10C0")]
		private static Dictionary<FECLCHMHGEE, IGrouping<FECLCHMHGEE, MethodInfo>> KPPKBFEBGLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0D50", Offset = "0x5FEF750", VA = "0x185FF0D50")]
		private static bool FGLOJFLPEBD(MethodInfo DNKMMIFMCPI, Type MFJGPGODIGP)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FF18E0", Offset = "0x5FF02E0", VA = "0x185FF18E0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AIENHJGIMEB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct PLBAPECPIID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo GIEKJDHOCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MIDPNFMDJEE IGANADNANDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool BPGKNBGPNED;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<CCKMMDPMKJH, List<PLBAPECPIID>> KAADCJMEODB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static MCKMOPCGMKB LADDNFCCMDO;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static MCKMOPCGMKB NBNAAMNELBA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static MCKMOPCGMKB POMKBPIBKMI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MCKMOPCGMKB OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF3D0", Offset = "0x5FEDDD0", VA = "0x185FEF3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MCKMOPCGMKB OEOPJOPCDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FEE6E0", Offset = "0x5FED0E0", VA = "0x185FEE6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MCKMOPCGMKB IMGGEEHGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FEE4C0", Offset = "0x5FECEC0", VA = "0x185FEE4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF320", Offset = "0x5FEDD20", VA = "0x185FEF320")]
	[ICEOFGDOCJO]
	private static void LBJFMPJPBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE3D0", Offset = "0x5FECDD0", VA = "0x185FEE3D0")]
	[MBHKLJOPNMI(FECLCHMHGEE.Unity_AfterAssembliesLoaded)]
	private static void EEGGOJDNAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FEEF50", Offset = "0x5FED950", VA = "0x185FEEF50")]
	public static MCKMOPCGMKB JJHIHLPPJIN(CCKMMDPMKJH EHOMOADDGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF190", Offset = "0x5FEDB90", VA = "0x185FEF190")]
	private static void JJHIHLPPJIN(CCKMMDPMKJH EHOMOADDGHA, MCKMOPCGMKB NLLANANFHIG, ref MCKMOPCGMKB FOFFAOBPIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE8F0", Offset = "0x5FED2F0", VA = "0x185FEE8F0")]
	private static void JJHIHLPPJIN(CCKMMDPMKJH EHOMOADDGHA, MCKMOPCGMKB FOFFAOBPIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE5D0", Offset = "0x5FECFD0", VA = "0x185FEE5D0")]
	public static void GBOGBCGMCJH(CCKMMDPMKJH EHOMOADDGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE720", Offset = "0x5FED120", VA = "0x185FEE720")]
	private static bool HIKBEFHCLEF(MIDPNFMDJEE FGHMIKACJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE800", Offset = "0x5FED200", VA = "0x185FEE800")]
	private static MCKMOPCGMKB HLBGIIJOCHM(string IPCLCDPECDP, [Optional] MCKMOPCGMKB NLLANANFHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE500", Offset = "0x5FECF00", VA = "0x185FEE500")]
	private static void GBOGBCGMCJH(ref MCKMOPCGMKB FOFFAOBPIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF320", Offset = "0x5FEDD20", VA = "0x185FEF320")]
	private static void KDLJDGPKIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF4C0", Offset = "0x5FEDEC0", VA = "0x185FEF4C0")]
	private static IEnumerable<PLBAPECPIID> LDBHBAPMLCF(CCKMMDPMKJH EHOMOADDGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE2E0", Offset = "0x5FECCE0", VA = "0x185FEE2E0")]
	private static MCKMOPCGMKB EEDKDMGDDGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NHKADLICHGK<T> : IDisposable where T : global::NHKADLICHGK<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T LOGLKKHAEGG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T BLPHKNHCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC9C0", Offset = "0x1FDB3C0", VA = "0x181FDC9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
	protected NHKADLICHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCC50", Offset = "0x1FDB650", VA = "0x181FDCC50", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum MIDPNFMDJEE
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CCKMMDPMKJH
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
