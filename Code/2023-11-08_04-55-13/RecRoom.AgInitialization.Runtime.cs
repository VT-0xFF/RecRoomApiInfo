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
		private sealed class PDMEMELNFBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public PDMEMELNFBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5CEA590", Offset = "0x5CE9390", VA = "0x185CEA590")]
			internal IEnumerable<MethodInfo> AOHNKONDDKD(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5CEA650", Offset = "0x5CE9450", VA = "0x185CEA650")]
			internal bool KLGOALGKGOH(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class PEDOEKFNJNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public PEDOEKFNJNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5CEA6B0", Offset = "0x5CE94B0", VA = "0x185CEA6B0")]
			internal bool MMGBAINACIJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CBCOGELCLLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public CBCOGELCLLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5CE8F80", Offset = "0x5CE7D80", VA = "0x185CE8F80")]
			internal bool INGJOOOPLJM(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<JMPBNKBIDHL, IGrouping<JMPBNKBIDHL, MethodInfo>> LMKGDFHIKPN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type CLBMGAFFDMH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAF60", Offset = "0x5CE9D60", VA = "0x185CEAF60")]
		private static void DAKHFMJNIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBF90", Offset = "0x5CEAD90", VA = "0x185CEBF90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAE20", Offset = "0x5CE9C20", VA = "0x185CEAE20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAF10", Offset = "0x5CE9D10", VA = "0x185CEAF10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAEC0", Offset = "0x5CE9CC0", VA = "0x185CEAEC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAE70", Offset = "0x5CE9C70", VA = "0x185CEAE70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBD20", Offset = "0x5CEAB20", VA = "0x185CEBD20")]
		private static void MNBEHLCPMDE(JMPBNKBIDHL DMHOCLMNCLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBDE0", Offset = "0x5CEABE0", VA = "0x185CEBDE0")]
		private static IEnumerable<MethodInfo> NNFNPKMPHFO(Type GFBCPGIMPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBE70", Offset = "0x5CEAC70", VA = "0x185CEBE70")]
		private static bool PDPEDOCHOMB(string IODCMPIOMCH, [Out] Dictionary<string, List<string>> FGPGLPEJEBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA710", Offset = "0x5CE9510", VA = "0x185CEA710")]
		private static IEnumerable<Type> AMDACJLICFI(Dictionary<string, List<string>> FGPGLPEJEBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB680", Offset = "0x5CEA480", VA = "0x185CEB680")]
		private static IEnumerable<MethodInfo> GIPICPGGJCH(IEnumerable<Type> DKCJBDGJKED, Type GFBCPGIMPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB4D0", Offset = "0x5CEA2D0", VA = "0x185CEB4D0")]
		internal static IEnumerable<MethodInfo> EFGIEJCGNCF(JMPBNKBIDHL DMHOCLMNCLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB760", Offset = "0x5CEA560", VA = "0x185CEB760")]
		internal static void IHJIOOFELDG(IEnumerable<MethodInfo> DDJILGOOFPI, Type EMGBFBJNHIN, [Optional] object[] CNCKHACNADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBC80", Offset = "0x5CEAA80", VA = "0x185CEBC80")]
		private static Dictionary<JMPBNKBIDHL, IGrouping<JMPBNKBIDHL, MethodInfo>> JJHIDAIELLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB560", Offset = "0x5CEA360", VA = "0x185CEB560")]
		private static bool EKCHJLKBBNG(MethodInfo DGJFLEHENFH, Type NAMIAGIKADP, bool JAEPOHCMNFO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GIHDLDADEFJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> BHDNFJIBFOJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> LDOLHMDGKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8FD0", Offset = "0x5CE7DD0", VA = "0x185CE8FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CEC0F0", Offset = "0x5CEAEF0", VA = "0x185CEC0F0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OAMFGFKFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LGPCBIKNADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo FJLNIOJNJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MIBJABCBNEH NCMDHCCENFM;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<INBBGMADPCI, List<LGPCBIKNADM>> GEIICIPNIOH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static KIDCBAFLGEK APOICMNJOBK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static KIDCBAFLGEK GDPOKMNDMAP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static KIDCBAFLGEK OMGJNCLDLNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KIDCBAFLGEK CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA310", Offset = "0x5CE9110", VA = "0x185CEA310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KIDCBAFLGEK HGGOOKCKHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9090", Offset = "0x5CE7E90", VA = "0x185CE9090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static KIDCBAFLGEK FFHICBDENGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA3E0", Offset = "0x5CE91E0", VA = "0x185CEA3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CE91A0", Offset = "0x5CE7FA0", VA = "0x185CE91A0")]
	[KIPACCNHDBA]
	private static void ELNPLBKNOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CE90D0", Offset = "0x5CE7ED0", VA = "0x185CE90D0")]
	[FLGENPOMBLL(JMPBNKBIDHL.Unity_AfterAssembliesLoaded)]
	private static void ABKAOHNMAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CE99F0", Offset = "0x5CE87F0", VA = "0x185CE99F0")]
	public static KIDCBAFLGEK HLFHHPDDNFM(INBBGMADPCI OPFGPELBFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9C30", Offset = "0x5CE8A30", VA = "0x185CE9C30")]
	private static void HLFHHPDDNFM(INBBGMADPCI OPFGPELBFNB, KIDCBAFLGEK KCGPCMINGIH, KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9600", Offset = "0x5CE8400", VA = "0x185CE9600")]
	private static void HLFHHPDDNFM(INBBGMADPCI OPFGPELBFNB, KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9250", Offset = "0x5CE8050", VA = "0x185CE9250")]
	public static void EEFAOMOLAOP(INBBGMADPCI OPFGPELBFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31019D0", Offset = "0x31007D0", VA = "0x1831019D0")]
	private static bool NPDJJAJJOKI(MIBJABCBNEH GAAAIJNGAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA420", Offset = "0x5CE9220", VA = "0x185CEA420")]
	private static KIDCBAFLGEK NBFMCFMBHFE(string FIFONONNNGI, [Optional] KIDCBAFLGEK KCGPCMINGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9370", Offset = "0x5CE8170", VA = "0x185CE9370")]
	private static void EEFAOMOLAOP(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE91A0", Offset = "0x5CE7FA0", VA = "0x185CE91A0")]
	private static void CPIBCMOKKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9D70", Offset = "0x5CE8B70", VA = "0x185CE9D70")]
	private static IEnumerable<LGPCBIKNADM> HONELGIKDGN(INBBGMADPCI OPFGPELBFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9540", Offset = "0x5CE8340", VA = "0x185CE9540")]
	private static KIDCBAFLGEK GEABLFAFPFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NDEBNBIAGHJ<T> : IDisposable where T : NDEBNBIAGHJ<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T PCALNAMFDCK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T ANGIAPALHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D08270", Offset = "0x3D07070", VA = "0x183D08270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected NDEBNBIAGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D08230", Offset = "0x3D07030", VA = "0x183D08230", Slot = "5")]
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
