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
public class EEPNDFMGFKJ : BAGFEACOEOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PGHNHBNHACN BAHPBOLNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly CPDKPFACMJL GGPPLOKNPBN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2815BF0", Offset = "0x2814DF0", VA = "0x182815BF0")]
	public EEPNDFMGFKJ(CPDKPFACMJL KPOFHIKKAKE = CPDKPFACMJL.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2815BB0", Offset = "0x2814DB0", VA = "0x182815BB0")]
	public EEPNDFMGFKJ(PGHNHBNHACN AJDCFDMNHDF, CPDKPFACMJL KPOFHIKKAKE = CPDKPFACMJL.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class ACOALEJFCOF : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public ACOALEJFCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class FJGCJGIINCP : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DMLMBCGCBMP FINBHMGNAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MONGBBFOOKD;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2815C30", Offset = "0x2814E30", VA = "0x182815C30")]
	public FJGCJGIINCP(DMLMBCGCBMP GCOCEJACAFA = DMLMBCGCBMP.ExitingPlayMode, int JKCDJLGNPKP = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DMLMBCGCBMP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class OBLKCIBLMBL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x874640", Offset = "0x873840", VA = "0x180874640")]
	public OBLKCIBLMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class BAGFEACOEOD : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly DHALNGCEHDC MFBKNALKFIM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2815A60", Offset = "0x2814C60", VA = "0x182815A60")]
	public BAGFEACOEOD(DHALNGCEHDC BKEOENJKPCA = DHALNGCEHDC.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DHALNGCEHDC
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Unity_AfterSceneLoad = 0,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_BeforeSceneLoad = 1,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_AfterAssembliesLoaded = 2,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Unity_BeforeSplashScreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unity_SubsystemRegistration = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ManuallyInvoked = int.MaxValue
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class BDJBOICKNKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public BDJBOICKNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2815A90", Offset = "0x2814C90", VA = "0x182815A90")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2815B40", Offset = "0x2814D40", VA = "0x182815B40")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JDPLMFEIAHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public JDPLMFEIAHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2815C70", Offset = "0x2814E70", VA = "0x182815C70")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JPKFLGDCOPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public JPKFLGDCOPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2815CE0", Offset = "0x2814EE0", VA = "0x182815CE0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const string NBLEBODPCHD = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string PILIMGGANHL = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static Dictionary<DHALNGCEHDC, IGrouping<DHALNGCEHDC, MethodInfo>> PCEDEDAKEPM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Type OHJOEKBPPPK;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2817BF0", Offset = "0x2816DF0", VA = "0x182817BF0")]
		private static void KEKBCMIHDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2818810", Offset = "0x2817A10", VA = "0x182818810")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2817670", Offset = "0x2816870", VA = "0x182817670")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2817760", Offset = "0x2816960", VA = "0x182817760")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2817710", Offset = "0x2816910", VA = "0x182817710")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28176C0", Offset = "0x28168C0", VA = "0x1828176C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2817870", Offset = "0x2816A70", VA = "0x182817870")]
		private static void JFDNCNDCEHL(DHALNGCEHDC BKEOENJKPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2818750", Offset = "0x2817950", VA = "0x182818750")]
		private static IEnumerable<MethodInfo> OMGPNMDFHBN(Type LDENLEKMDKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2817A30", Offset = "0x2816C30", VA = "0x182817A30")]
		private static bool KCGFIDNFKJN(string JIKDLFBHAEF, out Dictionary<string, List<string>> AGEOPNJHOCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28180F0", Offset = "0x28172F0", VA = "0x1828180F0")]
		private static IEnumerable<Type> MHMNOFJNEAE(Dictionary<string, List<string>> AGEOPNJHOCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28186A0", Offset = "0x28178A0", VA = "0x1828186A0")]
		private static IEnumerable<MethodInfo> NMJGNMBOHPE(IEnumerable<Type> DGBCFCPCHGO, Type LDENLEKMDKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2817220", Offset = "0x2816420", VA = "0x182817220")]
		internal static IEnumerable<MethodInfo> AMMOHGGCAPB(DHALNGCEHDC BKEOENJKPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28172A0", Offset = "0x28164A0", VA = "0x1828172A0")]
		internal static void AMPINMKKEBL(IEnumerable<MethodInfo> BLJOPJPPLPA, Type COMGELHHEIM, [Optional] object[] JBADGMEDNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28177B0", Offset = "0x28169B0", VA = "0x1828177B0")]
		private static Dictionary<DHALNGCEHDC, IGrouping<DHALNGCEHDC, MethodInfo>> CDIJDAHONMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2817940", Offset = "0x2816B40", VA = "0x182817940")]
		private static bool JIAJJHNDFLO(MethodInfo MHGDKANKBFH, Type GIMGODOCAGK)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2818920", Offset = "0x2817B20", VA = "0x182818920")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MFKDIDIAGHG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct EINPJNNMJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MethodInfo DHGIBKPJMDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CPDKPFACMJL GGPPLOKNPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public bool DNOOFGJOINH;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static Dictionary<PGHNHBNHACN, List<EINPJNNMJMF>> FMBHDGGMKHD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static EIFHKIDJKKE KOKPEJBIJCP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static EIFHKIDJKKE EGHPEBGJANM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static EIFHKIDJKKE FJGGIKEMIOD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EIFHKIDJKKE CKGIOFEICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2816530", Offset = "0x2815730", VA = "0x182816530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EIFHKIDJKKE DALJCGDAFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28164F0", Offset = "0x28156F0", VA = "0x1828164F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EIFHKIDJKKE GDFGHACICFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2815F90", Offset = "0x2815190", VA = "0x182815F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2815EE0", Offset = "0x28150E0", VA = "0x182815EE0")]
	[OBLKCIBLMBL]
	private static void BKPOPIFDBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2816890", Offset = "0x2815A90", VA = "0x182816890")]
	[BAGFEACOEOD(DHALNGCEHDC.Unity_AfterAssembliesLoaded)]
	private static void JEMOIPCPIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2816A90", Offset = "0x2815C90", VA = "0x182816A90")]
	public static EIFHKIDJKKE MFJEJCOMOMG(PGHNHBNHACN AJDCFDMNHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2816940", Offset = "0x2815B40", VA = "0x182816940")]
	private static void MFJEJCOMOMG(PGHNHBNHACN AJDCFDMNHDF, EIFHKIDJKKE NGFIHKMEPJH, ref EIFHKIDJKKE APJAHLFEOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2816CA0", Offset = "0x2815EA0", VA = "0x182816CA0")]
	private static void MFJEJCOMOMG(PGHNHBNHACN AJDCFDMNHDF, EIFHKIDJKKE APJAHLFEOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28166C0", Offset = "0x28158C0", VA = "0x1828166C0")]
	public static void HELALABCFJF(PGHNHBNHACN AJDCFDMNHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2815E00", Offset = "0x2815000", VA = "0x182815E00")]
	private static bool ADKNLDHPGJO(CPDKPFACMJL KPOFHIKKAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2815D30", Offset = "0x2814F30", VA = "0x182815D30")]
	private static EIFHKIDJKKE AADDMFMNPIF(string DNOPIMEHNCG, [Optional] EIFHKIDJKKE NGFIHKMEPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2816610", Offset = "0x2815810", VA = "0x182816610")]
	private static void HELALABCFJF(ref EIFHKIDJKKE APJAHLFEOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2815EE0", Offset = "0x28150E0", VA = "0x182815EE0")]
	private static void HHBJHBNBIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2815FD0", Offset = "0x28151D0", VA = "0x182815FD0")]
	private static IEnumerable<EINPJNNMJMF> DGGPFFIAFPO(PGHNHBNHACN AJDCFDMNHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x28167B0", Offset = "0x28159B0", VA = "0x1828167B0")]
	private static EIFHKIDJKKE IPHFHKFEFJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PJBBJKGKFML<T> : IDisposable where T : global::PJBBJKGKFML<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static T BGGBBPALEOI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T HBKBBJLFPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4529C90", Offset = "0x4528E90", VA = "0x184529C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	protected PJBBJKGKFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4529F20", Offset = "0x4529120", VA = "0x184529F20", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum CPDKPFACMJL
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum PGHNHBNHACN
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
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
