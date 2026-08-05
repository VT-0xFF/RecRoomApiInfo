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
public class IMCONJMNGLO : AMBDGJEEPDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly EPFIGEBMEBE JJHEFCIGGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly KJBNBKOGAAL FPCKPKFAEEF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAB0", Offset = "0x5E3A8B0", VA = "0x185E3BAB0")]
	public IMCONJMNGLO(KJBNBKOGAAL ILOOCOPHLJK = KJBNBKOGAAL.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAF0", Offset = "0x5E3A8F0", VA = "0x185E3BAF0")]
	public IMCONJMNGLO(EPFIGEBMEBE KPJADOMHGDH, KJBNBKOGAAL ILOOCOPHLJK = KJBNBKOGAAL.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class DENBNEDFNAD : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B9D0", Offset = "0x5E3A7D0", VA = "0x185E3B9D0")]
	public DENBNEDFNAD(int HKOHGCMCHKO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class CCHBFIAMMOL : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HBPLHMNGKEN LBFFAGPPGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int KBPAGHAOJMH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BA00", Offset = "0x5E3A800", VA = "0x185E3BA00")]
	public CCHBFIAMMOL(HBPLHMNGKEN PPHGIGFFJDA = HBPLHMNGKEN.ExitingPlayMode, int HKOHGCMCHKO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HBPLHMNGKEN
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
public class CEHIHDMDFDA : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	public CEHIHDMDFDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class AMBDGJEEPDK : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly AJGKCOCFBKH JIJCBHPPPBH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B9D0", Offset = "0x5E3A7D0", VA = "0x185E3B9D0")]
	public AMBDGJEEPDK(AJGKCOCFBKH IABNJMPGJMB = AJGKCOCFBKH.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AJGKCOCFBKH
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
		private sealed class NBHFIAGPFKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public NBHFIAGPFKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BB80", Offset = "0x5E3A980", VA = "0x185E3BB80")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BC50", Offset = "0x5E3AA50", VA = "0x185E3BC50")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class ICNCHKBNOGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public ICNCHKBNOGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BA40", Offset = "0x5E3A840", VA = "0x185E3BA40")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MFMNLMJLCMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public MFMNLMJLCMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BB30", Offset = "0x5E3A930", VA = "0x185E3BB30")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string IJBJLIDEJPN = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string IDOEJCNJKGB = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<AJGKCOCFBKH, IGrouping<AJGKCOCFBKH, MethodInfo>> JOKHJOBNKJD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type MDANPGLEAAL;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D510", Offset = "0x5E3C310", VA = "0x185E3D510")]
		private static void BCNGLAFCOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E3EED0", Offset = "0x5E3DCD0", VA = "0x185E3EED0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D470", Offset = "0x5E3C270", VA = "0x185E3D470")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DD10", Offset = "0x5E3CB10", VA = "0x185E3DD10")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DCC0", Offset = "0x5E3CAC0", VA = "0x185E3DCC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D4C0", Offset = "0x5E3C2C0", VA = "0x185E3D4C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DE20", Offset = "0x5E3CC20", VA = "0x185E3DE20")]
		private static void HAIPKCHDFGE(AJGKCOCFBKH IABNJMPGJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DD60", Offset = "0x5E3CB60", VA = "0x185E3DD60")]
		private static IEnumerable<MethodInfo> EPLDCJCAMIC(Type KNBHGHOFGFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DB00", Offset = "0x5E3C900", VA = "0x185E3DB00")]
		private static bool BEGIEMNFPGK(string BJMLHIIIAAC, out Dictionary<string, List<string>> DFPHOLAJEHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E6C0", Offset = "0x5E3D4C0", VA = "0x185E3E6C0")]
		private static IEnumerable<Type> NLCLPIKKBKE(Dictionary<string, List<string>> DFPHOLAJEHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E5E0", Offset = "0x5E3D3E0", VA = "0x185E3E5E0")]
		private static IEnumerable<MethodInfo> NJOFHBFJKCH(IEnumerable<Type> DCPGKOEBMPG, Type KNBHGHOFGFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E3EE40", Offset = "0x5E3DC40", VA = "0x185E3EE40")]
		internal static IEnumerable<MethodInfo> PPGIGBDOLGP(AJGKCOCFBKH IABNJMPGJMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DEF0", Offset = "0x5E3CCF0", VA = "0x185E3DEF0")]
		internal static void JBKFIPCBGMI(IEnumerable<MethodInfo> FDBPDDDJPKH, Type JPGOBBGJELO, [Optional] object[] PJGALDPNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E400", Offset = "0x5E3D200", VA = "0x185E3E400")]
		private static Dictionary<AJGKCOCFBKH, IGrouping<AJGKCOCFBKH, MethodInfo>> JMGGLHMOKLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E4C0", Offset = "0x5E3D2C0", VA = "0x185E3E4C0")]
		private static bool LOBDHMGFNBJ(MethodInfo MKNJAKNCPEL, Type MHMBPHOKINC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F040", Offset = "0x5E3DE40", VA = "0x185E3F040")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OANAMLOCJBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct KKKJGAFMOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo IFHABCBJEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KJBNBKOGAAL FPCKPKFAEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool GFDALNGIPCP;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<EPFIGEBMEBE, List<KKKJGAFMOMI>> FNGLCCMFFOO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ELODGKLHEKG BMPKFIKNFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static ELODGKLHEKG HEEPHHLJLCN;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static ELODGKLHEKG IACEFAEONBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ELODGKLHEKG BPBHOPDAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D380", Offset = "0x5E3C180", VA = "0x185E3D380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ELODGKLHEKG ILIPEKOBENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D340", Offset = "0x5E3C140", VA = "0x185E3D340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ELODGKLHEKG PFJBMLEAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CCC0", Offset = "0x5E3BAC0", VA = "0x185E3CCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CFD0", Offset = "0x5E3BDD0", VA = "0x185E3CFD0")]
	[CEHIHDMDFDA]
	private static void OFFMELMCBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D250", Offset = "0x5E3C050", VA = "0x185E3D250")]
	[AMBDGJEEPDK(AJGKCOCFBKH.Unity_AfterAssembliesLoaded)]
	private static void OBKDLHIPLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C4B0", Offset = "0x5E3B2B0", VA = "0x185E3C4B0")]
	public static ELODGKLHEKG AKEEDLDDDMJ(EPFIGEBMEBE KPJADOMHGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BCC0", Offset = "0x5E3AAC0", VA = "0x185E3BCC0")]
	private static void AKEEDLDDDMJ(EPFIGEBMEBE KPJADOMHGDH, ELODGKLHEKG JHMBJLLFPPI, ref ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BE50", Offset = "0x5E3AC50", VA = "0x185E3BE50")]
	private static void AKEEDLDDDMJ(EPFIGEBMEBE KPJADOMHGDH, ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CEC0", Offset = "0x5E3BCC0", VA = "0x185E3CEC0")]
	public static void IPNBAOBLACD(EPFIGEBMEBE KPJADOMHGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D170", Offset = "0x5E3BF70", VA = "0x185E3D170")]
	private static bool NMPJCAMPOMI(KJBNBKOGAAL ILOOCOPHLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD00", Offset = "0x5E3BB00", VA = "0x185E3CD00")]
	private static ELODGKLHEKG GEAJKNPCODP(string HIDMEEGJGPA, [Optional] ELODGKLHEKG JHMBJLLFPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CDF0", Offset = "0x5E3BBF0", VA = "0x185E3CDF0")]
	private static void IPNBAOBLACD(ref ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CFD0", Offset = "0x5E3BDD0", VA = "0x185E3CFD0")]
	private static void LJAEAACIDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C6F0", Offset = "0x5E3B4F0", VA = "0x185E3C6F0")]
	private static IEnumerable<KKKJGAFMOMI> EJBBBDAJOEG(EPFIGEBMEBE KPJADOMHGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D080", Offset = "0x5E3BE80", VA = "0x185E3D080")]
	private static ELODGKLHEKG LKEOAOLDHBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDEJMPKAEMH<T> : IDisposable where T : global::HDEJMPKAEMH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T HFEGMKMMHDH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T JNHMLOILMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x27D33E0", Offset = "0x27D21E0", VA = "0x1827D33E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	protected HDEJMPKAEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27D33A0", Offset = "0x27D21A0", VA = "0x1827D33A0", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum KJBNBKOGAAL
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EPFIGEBMEBE
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
