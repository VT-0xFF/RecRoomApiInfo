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
	[Cpp2IlInjected.Address(RVA = "0x6054EB0", Offset = "0x60538B0", VA = "0x186054EB0")]
	public PILNOHNDGDF(KBMKLHMPDPB PPHJLJDNGFG = KBMKLHMPDPB.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6054EF0", Offset = "0x60538F0", VA = "0x186054EF0")]
	public PILNOHNDGDF(CONDJIOCDHH KDAFJLJEJCD, KBMKLHMPDPB PPHJLJDNGFG = KBMKLHMPDPB.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class CAHNOBHLALK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6050CB0", Offset = "0x604F6B0", VA = "0x186050CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x60529C0", Offset = "0x60513C0", VA = "0x1860529C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD6E0", VA = "0x1806DECE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6050CB0", Offset = "0x604F6B0", VA = "0x186050CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public HIKDJLENJOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6053570", Offset = "0x6051F70", VA = "0x186053570")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6053640", Offset = "0x6052040", VA = "0x186053640")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public HBHPALOHCAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6053500", Offset = "0x6051F00", VA = "0x186053500")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public OFJCBIFNCBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60536B0", Offset = "0x60520B0", VA = "0x1860536B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6055B50", Offset = "0x6054550", VA = "0x186055B50")]
		private static void MJFCDNNGAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6056990", Offset = "0x6055390", VA = "0x186056990")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6054F30", Offset = "0x6053930", VA = "0x186054F30")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6055020", Offset = "0x6053A20", VA = "0x186055020")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6054FD0", Offset = "0x60539D0", VA = "0x186054FD0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6054F80", Offset = "0x6053980", VA = "0x186054F80")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6056140", Offset = "0x6054B40", VA = "0x186056140")]
		private static void MKGIHNGMEOH(BCECDANOCKH LHNJKLCBBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60554F0", Offset = "0x6053EF0", VA = "0x1860554F0")]
		private static IEnumerable<MethodInfo> JFLNMPPAIJP(Type NKHGAHHHIEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6055070", Offset = "0x6053A70", VA = "0x186055070")]
		private static bool CHBOAHAOFKD(string BAMPFOAHBBF, out Dictionary<string, List<string>> EODFOKINKIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6056210", Offset = "0x6054C10", VA = "0x186056210")]
		private static IEnumerable<Type> NMMNIMIKHPC(Dictionary<string, List<string>> EODFOKINKIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6055350", Offset = "0x6053D50", VA = "0x186055350")]
		private static IEnumerable<MethodInfo> FCNMLNMNGFI(IEnumerable<Type> KJJNFLPAOCJ, Type NKHGAHHHIEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6055AC0", Offset = "0x60544C0", VA = "0x186055AC0")]
		internal static IEnumerable<MethodInfo> LHOAENAIMPB(BCECDANOCKH LHNJKLCBBEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60555B0", Offset = "0x6053FB0", VA = "0x1860555B0")]
		internal static void LGCIEOILGGI(IEnumerable<MethodInfo> GPEOCLBNMOE, Type ABHJFHMNBEO, [Optional] object[] JJDMBGDPAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6055430", Offset = "0x6053E30", VA = "0x186055430")]
		private static Dictionary<BCECDANOCKH, IGrouping<BCECDANOCKH, MethodInfo>> IBJINGBMCLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6055230", Offset = "0x6053C30", VA = "0x186055230")]
		private static bool CMDNDJHFGBO(MethodInfo KKBIFPGOODL, Type BHFICJGKJGA, bool IPFPIPMIMKG)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6056B00", Offset = "0x6055500", VA = "0x186056B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6053EB0", Offset = "0x60528B0", VA = "0x186053EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PEGEFOEHCCC LIIOABBGKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6054080", Offset = "0x6052A80", VA = "0x186054080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PEGEFOEHCCC POPOMPABEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60537F0", Offset = "0x60521F0", VA = "0x1860537F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6053830", Offset = "0x6052230", VA = "0x186053830")]
	[FJLALEHBJKB]
	private static void NEEOGJBLAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6054DC0", Offset = "0x60537C0", VA = "0x186054DC0")]
	[NMAKMGELEDF(BCECDANOCKH.Unity_AfterAssembliesLoaded)]
	private static void NMPBKKCJDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6054340", Offset = "0x6052D40", VA = "0x186054340")]
	public static PEGEFOEHCCC MBMJHENIJNM(CONDJIOCDHH KDAFJLJEJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60541B0", Offset = "0x6052BB0", VA = "0x1860541B0")]
	private static void MBMJHENIJNM(CONDJIOCDHH KDAFJLJEJCD, PEGEFOEHCCC DFGEEFJFNPH, ref PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6054580", Offset = "0x6052F80", VA = "0x186054580")]
	private static void MBMJHENIJNM(CONDJIOCDHH KDAFJLJEJCD, PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6054CB0", Offset = "0x60536B0", VA = "0x186054CB0")]
	public static void MCJLGPEOPAO(CONDJIOCDHH KDAFJLJEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6053FA0", Offset = "0x60529A0", VA = "0x186053FA0")]
	private static bool KCICLCKLGHC(KBMKLHMPDPB PPHJLJDNGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6053700", Offset = "0x6052100", VA = "0x186053700")]
	private static PEGEFOEHCCC CKCDOPLEPGG(string EIHFEMBCCHO, [Optional] PEGEFOEHCCC DFGEEFJFNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6054BE0", Offset = "0x60535E0", VA = "0x186054BE0")]
	private static void MCJLGPEOPAO(ref PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6053830", Offset = "0x6052230", VA = "0x186053830")]
	private static void IGBNJFMNFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60538E0", Offset = "0x60522E0", VA = "0x1860538E0")]
	private static IEnumerable<NFNDEDGIPMH> IOGMHLLENDA(CONDJIOCDHH KDAFJLJEJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60540C0", Offset = "0x6052AC0", VA = "0x1860540C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EF18D0", Offset = "0x2EF02D0", VA = "0x182EF18D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	protected MPIBLMGBEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1B60", Offset = "0x2EF0560", VA = "0x182EF1B60", Slot = "5")]
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
