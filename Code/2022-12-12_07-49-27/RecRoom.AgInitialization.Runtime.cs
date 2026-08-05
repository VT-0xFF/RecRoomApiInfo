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
public class PILNOHNDGDF : NMAKMGELEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CONDJIOCDHH MKNNOOBMMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly KBMKLHMPDPB PHANJMGJIEE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x608CBA0", Offset = "0x608B1A0", VA = "0x18608CBA0")]
	public PILNOHNDGDF(KBMKLHMPDPB PPHJLJDNGFG = KBMKLHMPDPB.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x608CBE0", Offset = "0x608B1E0", VA = "0x18608CBE0")]
	public PILNOHNDGDF(CONDJIOCDHH KDAFJLJEJCD, KBMKLHMPDPB PPHJLJDNGFG = KBMKLHMPDPB.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class CAHNOBHLALK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CDE8B0", Offset = "0x1CDCEB0", VA = "0x181CDE8B0")]
	public CAHNOBHLALK(int IPGJOMPJEJJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class IIADNJEBFGG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NKLKDILCDDO OHDJONLPFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int JDIIMBFLEBI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1CE05C0", Offset = "0x1CDEBC0", VA = "0x181CE05C0")]
	public IIADNJEBFGG(NKLKDILCDDO BAEHAHHPOLD = NKLKDILCDDO.ExitingPlayMode, int IPGJOMPJEJJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NKLKDILCDDO
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
public class FJLALEHBJKB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77F0B0", Offset = "0x77D6B0", VA = "0x18077F0B0")]
	public FJLALEHBJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class NMAKMGELEDF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly BCECDANOCKH ACCJCGOGDFO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CDE8B0", Offset = "0x1CDCEB0", VA = "0x181CDE8B0")]
	public NMAKMGELEDF(BCECDANOCKH LHNJKLCBBEN = BCECDANOCKH.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BCECDANOCKH
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
		private sealed class HIKDJLENJOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public HIKDJLENJOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x608B260", Offset = "0x6089860", VA = "0x18608B260")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x608B330", Offset = "0x6089930", VA = "0x18608B330")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HBHPALOHCAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public HBHPALOHCAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x608B1F0", Offset = "0x60897F0", VA = "0x18608B1F0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OFJCBIFNCBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public OFJCBIFNCBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x608B3A0", Offset = "0x60899A0", VA = "0x18608B3A0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string FLBLHLHHGLG = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string KHOKFPGJECK = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<BCECDANOCKH, IGrouping<BCECDANOCKH, MethodInfo>> CLDKIBGINLG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type LJAFPHONNCA;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x608D840", Offset = "0x608BE40", VA = "0x18608D840")]
		private static void MJFCDNNGAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x608E680", Offset = "0x608CC80", VA = "0x18608E680")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x608CC20", Offset = "0x608B220", VA = "0x18608CC20")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x608CD10", Offset = "0x608B310", VA = "0x18608CD10")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x608CCC0", Offset = "0x608B2C0", VA = "0x18608CCC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x608CC70", Offset = "0x608B270", VA = "0x18608CC70")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x608DE30", Offset = "0x608C430", VA = "0x18608DE30")]
		private static void MKGIHNGMEOH(BCECDANOCKH LHNJKLCBBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x608D1E0", Offset = "0x608B7E0", VA = "0x18608D1E0")]
		private static IEnumerable<MethodInfo> JFLNMPPAIJP(Type NKHGAHHHIEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x608CD60", Offset = "0x608B360", VA = "0x18608CD60")]
		private static bool CHBOAHAOFKD(string BAMPFOAHBBF, out Dictionary<string, List<string>> EODFOKINKIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x608DF00", Offset = "0x608C500", VA = "0x18608DF00")]
		private static IEnumerable<Type> NMMNIMIKHPC(Dictionary<string, List<string>> EODFOKINKIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x608D040", Offset = "0x608B640", VA = "0x18608D040")]
		private static IEnumerable<MethodInfo> FCNMLNMNGFI(IEnumerable<Type> KJJNFLPAOCJ, Type NKHGAHHHIEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x608D7B0", Offset = "0x608BDB0", VA = "0x18608D7B0")]
		internal static IEnumerable<MethodInfo> LHOAENAIMPB(BCECDANOCKH LHNJKLCBBEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x608D2A0", Offset = "0x608B8A0", VA = "0x18608D2A0")]
		internal static void LGCIEOILGGI(IEnumerable<MethodInfo> GPEOCLBNMOE, Type ABHJFHMNBEO, [Optional] object[] JJDMBGDPAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x608D120", Offset = "0x608B720", VA = "0x18608D120")]
		private static Dictionary<BCECDANOCKH, IGrouping<BCECDANOCKH, MethodInfo>> IBJINGBMCLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x608CF20", Offset = "0x608B520", VA = "0x18608CF20")]
		private static bool CMDNDJHFGBO(MethodInfo KKBIFPGOODL, Type BHFICJGKJGA, bool IPFPIPMIMKG)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x608E7F0", Offset = "0x608CDF0", VA = "0x18608E7F0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OLNKGNNLCGF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct NFNDEDGIPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo JAHHODACMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KBMKLHMPDPB PHANJMGJIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool OJBDGKPJBFG;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<CONDJIOCDHH, List<NFNDEDGIPMH>> GHNPIEBMOHA;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static PEGEFOEHCCC JNKBMPECOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static PEGEFOEHCCC AGFNLPCBLKE;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static PEGEFOEHCCC BJALHOMCFII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PEGEFOEHCCC AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x608BBA0", Offset = "0x608A1A0", VA = "0x18608BBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PEGEFOEHCCC LIIOABBGKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x608BD70", Offset = "0x608A370", VA = "0x18608BD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PEGEFOEHCCC POPOMPABEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x608B4E0", Offset = "0x6089AE0", VA = "0x18608B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x608B520", Offset = "0x6089B20", VA = "0x18608B520")]
	[FJLALEHBJKB]
	private static void NEEOGJBLAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x608CAB0", Offset = "0x608B0B0", VA = "0x18608CAB0")]
	[NMAKMGELEDF(BCECDANOCKH.Unity_AfterAssembliesLoaded)]
	private static void NMPBKKCJDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x608C030", Offset = "0x608A630", VA = "0x18608C030")]
	public static PEGEFOEHCCC MBMJHENIJNM(CONDJIOCDHH KDAFJLJEJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x608BEA0", Offset = "0x608A4A0", VA = "0x18608BEA0")]
	private static void MBMJHENIJNM(CONDJIOCDHH KDAFJLJEJCD, PEGEFOEHCCC DFGEEFJFNPH, ref PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x608C270", Offset = "0x608A870", VA = "0x18608C270")]
	private static void MBMJHENIJNM(CONDJIOCDHH KDAFJLJEJCD, PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x608C9A0", Offset = "0x608AFA0", VA = "0x18608C9A0")]
	public static void MCJLGPEOPAO(CONDJIOCDHH KDAFJLJEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x608BC90", Offset = "0x608A290", VA = "0x18608BC90")]
	private static bool KCICLCKLGHC(KBMKLHMPDPB PPHJLJDNGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x608B3F0", Offset = "0x60899F0", VA = "0x18608B3F0")]
	private static PEGEFOEHCCC CKCDOPLEPGG(string EIHFEMBCCHO, [Optional] PEGEFOEHCCC DFGEEFJFNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x608C8D0", Offset = "0x608AED0", VA = "0x18608C8D0")]
	private static void MCJLGPEOPAO(ref PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x608B520", Offset = "0x6089B20", VA = "0x18608B520")]
	private static void IGBNJFMNFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x608B5D0", Offset = "0x6089BD0", VA = "0x18608B5D0")]
	private static IEnumerable<NFNDEDGIPMH> IOGMHLLENDA(CONDJIOCDHH KDAFJLJEJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x608BDB0", Offset = "0x608A3B0", VA = "0x18608BDB0")]
	private static PEGEFOEHCCC LBIGNCPBJJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MPIBLMGBEDP<T> : IDisposable where T : global::MPIBLMGBEDP<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T PFOFOPEANHM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T LOGBPMLPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B750", Offset = "0x3B99D50", VA = "0x183B9B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	protected MPIBLMGBEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B9E0", Offset = "0x3B99FE0", VA = "0x183B9B9E0", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum KBMKLHMPDPB
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CONDJIOCDHH
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
