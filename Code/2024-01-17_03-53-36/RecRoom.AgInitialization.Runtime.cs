using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class DBHOIFOPLJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public DBHOIFOPLJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5E94640", Offset = "0x5E93440", VA = "0x185E94640")]
			internal IEnumerable<MethodInfo> OHICMDMDDLC(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E945E0", Offset = "0x5E933E0", VA = "0x185E945E0")]
			internal bool FKCCNFDNAIN(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class NCAOLKFIAGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public NCAOLKFIAGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5E95D10", Offset = "0x5E94B10", VA = "0x185E95D10")]
			internal bool APKGDEKPCII(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GPMIBBFNKKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public GPMIBBFNKKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E94700", Offset = "0x5E93500", VA = "0x185E94700")]
			internal bool POJGOJLDJEK(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<HNLGNAJIJHC, IGrouping<HNLGNAJIJHC, MethodInfo>> AIKBINEMPMJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type GEIGEAOOJEP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E96A40", Offset = "0x5E95840", VA = "0x185E96A40")]
		private static void MHCGFKBGCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E975F0", Offset = "0x5E963F0", VA = "0x185E975F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E95D70", Offset = "0x5E94B70", VA = "0x185E95D70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E95F00", Offset = "0x5E94D00", VA = "0x185E95F00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E95EB0", Offset = "0x5E94CB0", VA = "0x185E95EB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E95DC0", Offset = "0x5E94BC0", VA = "0x185E95DC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E95F50", Offset = "0x5E94D50", VA = "0x185E95F50")]
		private static void FDCNLIIBEHB(HNLGNAJIJHC APPPIMEGLPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E96890", Offset = "0x5E95690", VA = "0x185E96890")]
		private static IEnumerable<MethodInfo> HNMHPEDIEOP(Type LLOOKFGEFDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E96FB0", Offset = "0x5E95DB0", VA = "0x185E96FB0")]
		private static bool NBIKGJIJBBL(string GGJPMOIFGHL, [Out] Dictionary<string, List<string>> DADFBIHKBAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E96010", Offset = "0x5E94E10", VA = "0x185E96010")]
		private static IEnumerable<Type> FMJJLBLDOGL(Dictionary<string, List<string>> DADFBIHKBAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E96720", Offset = "0x5E95520", VA = "0x185E96720")]
		private static IEnumerable<MethodInfo> FPNLKAHLGNC(IEnumerable<Type> LCOEIAOACBM, Type LLOOKFGEFDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E96800", Offset = "0x5E95600", VA = "0x185E96800")]
		internal static IEnumerable<MethodInfo> GFNJGNCGDEK(HNLGNAJIJHC APPPIMEGLPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E970D0", Offset = "0x5E95ED0", VA = "0x185E970D0")]
		internal static void NGNFJMHEMDP(IEnumerable<MethodInfo> JKMNICCNCAI, Type IMBFMKKAGDL, [Optional] object[] JMFMJMCAPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E95E10", Offset = "0x5E94C10", VA = "0x185E95E10")]
		private static Dictionary<HNLGNAJIJHC, IGrouping<HNLGNAJIJHC, MethodInfo>> BGNDAKAHOGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E96920", Offset = "0x5E95720", VA = "0x185E96920")]
		private static bool LJPHEIJGLLE(MethodInfo DNIJNKFCEJH, Type NMEDMEKHAFK, bool EOPKNLEAKAI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ICNOIMGOMBO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> JPEMLDOEGNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EOGPHAELNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E94750", Offset = "0x5E93550", VA = "0x185E94750")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E97750", Offset = "0x5E96550", VA = "0x185E97750")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LCAFFOJDPDF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IIJJDMDLLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo ELMOFBAHKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FNGNILODNLI HCGAAHNAMEM;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<OBFBFIBMGDJ, List<IIJJDMDLLBJ>> DHKMIIMMAAP;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static LPFNGCMIAEC HFHJPNDJHEI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LPFNGCMIAEC JDGLIPPMIPM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static LPFNGCMIAEC AMLDDEKGILG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LPFNGCMIAEC AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E952F0", Offset = "0x5E940F0", VA = "0x185E952F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LPFNGCMIAEC CKNLMMNDPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E952B0", Offset = "0x5E940B0", VA = "0x185E952B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static LPFNGCMIAEC GAABDLHGMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E95100", Offset = "0x5E93F00", VA = "0x185E95100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E95050", Offset = "0x5E93E50", VA = "0x185E95050")]
	[NCCOAOICGFB]
	private static void OFDFHDHGALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E94810", Offset = "0x5E93610", VA = "0x185E94810")]
	[GEDGJALKBHL(HNLGNAJIJHC.Unity_AfterAssembliesLoaded)]
	private static void HDFCFGKHMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E94CD0", Offset = "0x5E93AD0", VA = "0x185E94CD0")]
	public static LPFNGCMIAEC HIBKKDMGMOG(OBFBFIBMGDJ LFOAPHKBBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E94F10", Offset = "0x5E93D10", VA = "0x185E94F10")]
	private static void HIBKKDMGMOG(OBFBFIBMGDJ LFOAPHKBBOJ, LPFNGCMIAEC INEDFHCCMAN, LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E948E0", Offset = "0x5E936E0", VA = "0x185E948E0")]
	private static void HIBKKDMGMOG(OBFBFIBMGDJ LFOAPHKBBOJ, LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E95590", Offset = "0x5E94390", VA = "0x185E95590")]
	public static void OJODBNDLPDM(OBFBFIBMGDJ LFOAPHKBBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2166C00", Offset = "0x2165A00", VA = "0x182166C00")]
	private static bool GBCJLCGMOPG(FNGNILODNLI OBDBFKPJKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E95140", Offset = "0x5E93F40", VA = "0x185E95140")]
	private static LPFNGCMIAEC LDKJHEHINKB(string OEGFKFNHLIP, [Optional] LPFNGCMIAEC INEDFHCCMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E953C0", Offset = "0x5E941C0", VA = "0x185E953C0")]
	private static void OJODBNDLPDM(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E95050", Offset = "0x5E93E50", VA = "0x185E95050")]
	private static void IODIHPIANNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E956B0", Offset = "0x5E944B0", VA = "0x185E956B0")]
	private static IEnumerable<IIJJDMDLLBJ> OKCMGMGJLBP(OBFBFIBMGDJ LFOAPHKBBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E95C50", Offset = "0x5E94A50", VA = "0x185E95C50")]
	private static LPFNGCMIAEC OOKGMACCKBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GOODBGKHBBJ<T> : IDisposable where T : GOODBGKHBBJ<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T PICGAENFGAG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T CEIKCOHBGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x36FFC90", Offset = "0x36FEA90", VA = "0x1836FFC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected GOODBGKHBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36FFC50", Offset = "0x36FEA50", VA = "0x1836FFC50", Slot = "5")]
	public virtual void Dispose()
	{
	}
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
