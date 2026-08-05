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
public class EJICMPGFCBP : NMAEGPBBEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CJFFFKHKLCM HFEAKBGEFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly CIKEJIGJNLD INBIEBHCPHE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60D0660", Offset = "0x60CF660", VA = "0x1860D0660")]
	public EJICMPGFCBP(CIKEJIGJNLD BKHAMFHMEGP = CIKEJIGJNLD.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60D0620", Offset = "0x60CF620", VA = "0x1860D0620")]
	public EJICMPGFCBP(CJFFFKHKLCM DOAGMBMKODG, CIKEJIGJNLD BKHAMFHMEGP = CIKEJIGJNLD.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class CNIABNHDEIC : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60C2A70", Offset = "0x60C1A70", VA = "0x1860C2A70")]
	public CNIABNHDEIC(int BBCHOGHICAO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class CIBCLNKDGPH : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MOOMEKEKHGD ICONCNPMIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int IMPMIBBFHDB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60C1040", Offset = "0x60C0040", VA = "0x1860C1040")]
	public CIBCLNKDGPH(MOOMEKEKHGD OKEALDANPKM = MOOMEKEKHGD.ExitingPlayMode, int BBCHOGHICAO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MOOMEKEKHGD
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
public class EKHHFGMPNLA : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	public EKHHFGMPNLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class NMAEGPBBEAO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MLJIKHLLPGF JECPNLFNDFI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60C2A70", Offset = "0x60C1A70", VA = "0x1860C2A70")]
	public NMAEGPBBEAO(MLJIKHLLPGF GOKGCKCBEHC = MLJIKHLLPGF.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MLJIKHLLPGF
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
		private sealed class ONGCAMCJGCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public ONGCAMCJGCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x60D1E50", Offset = "0x60D0E50", VA = "0x1860D1E50")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60D1F20", Offset = "0x60D0F20", VA = "0x1860D1F20")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BCPFBCFJJKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public BCPFBCFJJKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60D0560", Offset = "0x60CF560", VA = "0x1860D0560")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DLEFHINCJHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public DLEFHINCJHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60D05D0", Offset = "0x60CF5D0", VA = "0x1860D05D0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string MCGDGMMBBFI = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string OEAPGIDHDLL = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<MLJIKHLLPGF, IGrouping<MLJIKHLLPGF, MethodInfo>> BJHKEIDAFIL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type CMBELMHDMBF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60D2030", Offset = "0x60D1030", VA = "0x1860D2030")]
		private static void BCNKNJKIEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60D39F0", Offset = "0x60D29F0", VA = "0x1860D39F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60D1F90", Offset = "0x60D0F90", VA = "0x1860D1F90")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60D27D0", Offset = "0x60D17D0", VA = "0x1860D27D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60D2780", Offset = "0x60D1780", VA = "0x1860D2780")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60D1FE0", Offset = "0x60D0FE0", VA = "0x1860D1FE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60D2620", Offset = "0x60D1620", VA = "0x1860D2620")]
		private static void BFGIIKPMFAJ(MLJIKHLLPGF GOKGCKCBEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60D2820", Offset = "0x60D1820", VA = "0x1860D2820")]
		private static IEnumerable<MethodInfo> ELNFLAFDJDL(Type GDMDGCMEKJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60D3750", Offset = "0x60D2750", VA = "0x1860D3750")]
		private static bool NELOIJDHLLJ(string LMAMBCJAPIA, out Dictionary<string, List<string>> DIPGBCFJMBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60D28E0", Offset = "0x60D18E0", VA = "0x1860D28E0")]
		private static IEnumerable<Type> GBOOGCFPMPB(Dictionary<string, List<string>> DIPGBCFJMBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60D3910", Offset = "0x60D2910", VA = "0x1860D3910")]
		private static IEnumerable<MethodInfo> OJIBAFPGKOC(IEnumerable<Type> ELKKGBGGKPO, Type GDMDGCMEKJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60D26F0", Offset = "0x60D16F0", VA = "0x1860D26F0")]
		internal static IEnumerable<MethodInfo> BINFOLCCEKG(MLJIKHLLPGF GOKGCKCBEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60D3120", Offset = "0x60D2120", VA = "0x1860D3120")]
		internal static void LFACEINJDGP(IEnumerable<MethodInfo> MOEGEGMOKKB, Type FHMLLOKGAGH, [Optional] object[] FHLNMMPFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60D3060", Offset = "0x60D2060", VA = "0x1860D3060")]
		private static Dictionary<MLJIKHLLPGF, IGrouping<MLJIKHLLPGF, MethodInfo>> IMDPMLAODNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60D3630", Offset = "0x60D2630", VA = "0x1860D3630")]
		private static bool LHGCDLOFGKP(MethodInfo FHLIGJBMGCI, Type OCMBAPDKBPO, bool CPMMMGMEDOF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60D3B60", Offset = "0x60D2B60", VA = "0x1860D3B60")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GHPPONPGGBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct OPIKHNNCELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo IAPLOPJNAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CIKEJIGJNLD INBIEBHCPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool DEONDOECCNN;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<CJFFFKHKLCM, List<OPIKHNNCELG>> KKLBHJPNNCP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static GBDCKFPNAEP LLGFGIBJJKM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static GBDCKFPNAEP CPJIGFKCPIN;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static GBDCKFPNAEP GMHIFMIHFAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GBDCKFPNAEP GHOIKAHCODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60D0790", Offset = "0x60CF790", VA = "0x1860D0790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GBDCKFPNAEP EDIPEHEEOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60D0880", Offset = "0x60CF880", VA = "0x1860D0880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GBDCKFPNAEP EFBACJMHDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60D1750", Offset = "0x60D0750", VA = "0x1860D1750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60D09B0", Offset = "0x60CF9B0", VA = "0x1860D09B0")]
	[EKHHFGMPNLA]
	private static void GJEANOPMGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60D1790", Offset = "0x60D0790", VA = "0x1860D1790")]
	[NMAEGPBBEAO(MLJIKHLLPGF.Unity_AfterAssembliesLoaded)]
	private static void NLNGLMKBLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60D11A0", Offset = "0x60D01A0", VA = "0x1860D11A0")]
	public static GBDCKFPNAEP LHJJNCLAFHM(CJFFFKHKLCM DOAGMBMKODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60D13E0", Offset = "0x60D03E0", VA = "0x1860D13E0")]
	private static void LHJJNCLAFHM(CJFFFKHKLCM DOAGMBMKODG, GBDCKFPNAEP FLFONOKDLGH, ref GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60D0B40", Offset = "0x60CFB40", VA = "0x1860D0B40")]
	private static void LHJJNCLAFHM(CJFFFKHKLCM DOAGMBMKODG, GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60D1640", Offset = "0x60D0640", VA = "0x1860D1640")]
	public static void MCHCEIDCHGI(CJFFFKHKLCM DOAGMBMKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60D0A60", Offset = "0x60CFA60", VA = "0x1860D0A60")]
	private static bool ILEIMFGLGPC(CIKEJIGJNLD BKHAMFHMEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60D08C0", Offset = "0x60CF8C0", VA = "0x1860D08C0")]
	private static GBDCKFPNAEP EPCCFBBJKBB(string DKMLJBLDLBF, [Optional] GBDCKFPNAEP FLFONOKDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60D1570", Offset = "0x60D0570", VA = "0x1860D1570")]
	private static void MCHCEIDCHGI(ref GBDCKFPNAEP FOIOPKEONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60D09B0", Offset = "0x60CF9B0", VA = "0x1860D09B0")]
	private static void HAMICACDICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60D1880", Offset = "0x60D0880", VA = "0x1860D1880")]
	private static IEnumerable<OPIKHNNCELG> PPLEADOMLGN(CJFFFKHKLCM DOAGMBMKODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60D06A0", Offset = "0x60CF6A0", VA = "0x1860D06A0")]
	private static GBDCKFPNAEP BDJHEELJJCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BFBOBJAJDFH<T> : IDisposable where T : global::BFBOBJAJDFH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T OMPFLELLCCN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T JKCIDAEDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x375A6A0", Offset = "0x37596A0", VA = "0x18375A6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
	protected BFBOBJAJDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x375A930", Offset = "0x3759930", VA = "0x18375A930", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum CIKEJIGJNLD
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CJFFFKHKLCM
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
