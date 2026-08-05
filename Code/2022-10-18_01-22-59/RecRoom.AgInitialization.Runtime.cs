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
	[Cpp2IlInjected.Address(RVA = "0x5E48800", Offset = "0x5E47800", VA = "0x185E48800")]
	public IMCONJMNGLO(KJBNBKOGAAL ILOOCOPHLJK = KJBNBKOGAAL.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E48840", Offset = "0x5E47840", VA = "0x185E48840")]
	public IMCONJMNGLO(EPFIGEBMEBE KPJADOMHGDH, KJBNBKOGAAL ILOOCOPHLJK = KJBNBKOGAAL.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class DENBNEDFNAD : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E48720", Offset = "0x5E47720", VA = "0x185E48720")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E48750", Offset = "0x5E47750", VA = "0x185E48750")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDCE0", VA = "0x1806BECE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E48720", Offset = "0x5E47720", VA = "0x185E48720")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public NBHFIAGPFKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E488D0", Offset = "0x5E478D0", VA = "0x185E488D0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5E489A0", Offset = "0x5E479A0", VA = "0x185E489A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public ICNCHKBNOGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E48790", Offset = "0x5E47790", VA = "0x185E48790")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public MFMNLMJLCMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E48880", Offset = "0x5E47880", VA = "0x185E48880")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E4A260", Offset = "0x5E49260", VA = "0x185E4A260")]
		private static void BCNGLAFCOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BC20", Offset = "0x5E4AC20", VA = "0x185E4BC20")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A1C0", Offset = "0x5E491C0", VA = "0x185E4A1C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AA60", Offset = "0x5E49A60", VA = "0x185E4AA60")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AA10", Offset = "0x5E49A10", VA = "0x185E4AA10")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A210", Offset = "0x5E49210", VA = "0x185E4A210")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AB70", Offset = "0x5E49B70", VA = "0x185E4AB70")]
		private static void HAIPKCHDFGE(AJGKCOCFBKH IABNJMPGJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AAB0", Offset = "0x5E49AB0", VA = "0x185E4AAB0")]
		private static IEnumerable<MethodInfo> EPLDCJCAMIC(Type KNBHGHOFGFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A850", Offset = "0x5E49850", VA = "0x185E4A850")]
		private static bool BEGIEMNFPGK(string BJMLHIIIAAC, out Dictionary<string, List<string>> DFPHOLAJEHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B410", Offset = "0x5E4A410", VA = "0x185E4B410")]
		private static IEnumerable<Type> NLCLPIKKBKE(Dictionary<string, List<string>> DFPHOLAJEHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B330", Offset = "0x5E4A330", VA = "0x185E4B330")]
		private static IEnumerable<MethodInfo> NJOFHBFJKCH(IEnumerable<Type> DCPGKOEBMPG, Type KNBHGHOFGFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BB90", Offset = "0x5E4AB90", VA = "0x185E4BB90")]
		internal static IEnumerable<MethodInfo> PPGIGBDOLGP(AJGKCOCFBKH IABNJMPGJMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AC40", Offset = "0x5E49C40", VA = "0x185E4AC40")]
		internal static void JBKFIPCBGMI(IEnumerable<MethodInfo> FDBPDDDJPKH, Type JPGOBBGJELO, [Optional] object[] PJGALDPNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B150", Offset = "0x5E4A150", VA = "0x185E4B150")]
		private static Dictionary<AJGKCOCFBKH, IGrouping<AJGKCOCFBKH, MethodInfo>> JMGGLHMOKLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B210", Offset = "0x5E4A210", VA = "0x185E4B210")]
		private static bool LOBDHMGFNBJ(MethodInfo MKNJAKNCPEL, Type MHMBPHOKINC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BD90", Offset = "0x5E4AD90", VA = "0x185E4BD90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E4A0D0", Offset = "0x5E490D0", VA = "0x185E4A0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ELODGKLHEKG ILIPEKOBENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A090", Offset = "0x5E49090", VA = "0x185E4A090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ELODGKLHEKG PFJBMLEAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E49A10", Offset = "0x5E48A10", VA = "0x185E49A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E49D20", Offset = "0x5E48D20", VA = "0x185E49D20")]
	[CEHIHDMDFDA]
	private static void OFFMELMCBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E49FA0", Offset = "0x5E48FA0", VA = "0x185E49FA0")]
	[AMBDGJEEPDK(AJGKCOCFBKH.Unity_AfterAssembliesLoaded)]
	private static void OBKDLHIPLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E49200", Offset = "0x5E48200", VA = "0x185E49200")]
	public static ELODGKLHEKG AKEEDLDDDMJ(EPFIGEBMEBE KPJADOMHGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E48A10", Offset = "0x5E47A10", VA = "0x185E48A10")]
	private static void AKEEDLDDDMJ(EPFIGEBMEBE KPJADOMHGDH, ELODGKLHEKG JHMBJLLFPPI, ref ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E48BA0", Offset = "0x5E47BA0", VA = "0x185E48BA0")]
	private static void AKEEDLDDDMJ(EPFIGEBMEBE KPJADOMHGDH, ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E49C10", Offset = "0x5E48C10", VA = "0x185E49C10")]
	public static void IPNBAOBLACD(EPFIGEBMEBE KPJADOMHGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E49EC0", Offset = "0x5E48EC0", VA = "0x185E49EC0")]
	private static bool NMPJCAMPOMI(KJBNBKOGAAL ILOOCOPHLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E49A50", Offset = "0x5E48A50", VA = "0x185E49A50")]
	private static ELODGKLHEKG GEAJKNPCODP(string HIDMEEGJGPA, [Optional] ELODGKLHEKG JHMBJLLFPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E49B40", Offset = "0x5E48B40", VA = "0x185E49B40")]
	private static void IPNBAOBLACD(ref ELODGKLHEKG BGLEKJNFDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E49D20", Offset = "0x5E48D20", VA = "0x185E49D20")]
	private static void LJAEAACIDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E49440", Offset = "0x5E48440", VA = "0x185E49440")]
	private static IEnumerable<KKKJGAFMOMI> EJBBBDAJOEG(EPFIGEBMEBE KPJADOMHGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E49DD0", Offset = "0x5E48DD0", VA = "0x185E49DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AEAF40", Offset = "0x2AE9F40", VA = "0x182AEAF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
	protected HDEJMPKAEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAF00", Offset = "0x2AE9F00", VA = "0x182AEAF00", Slot = "5")]
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
