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
		private sealed class BOFLPIDEMOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public BOFLPIDEMOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5BDC540", Offset = "0x5BDB340", VA = "0x185BDC540")]
			internal IEnumerable<MethodInfo> JLNMBMIGBEN(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5BDC4E0", Offset = "0x5BDB2E0", VA = "0x185BDC4E0")]
			internal bool BJHALJGEEOA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class APODOBGGEEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public APODOBGGEEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5BDC430", Offset = "0x5BDB230", VA = "0x185BDC430")]
			internal bool HMOBPFNNPJG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class BLMLJDDPKKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public BLMLJDDPKKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5BDC490", Offset = "0x5BDB290", VA = "0x185BDC490")]
			internal bool ODNBIHGIMGJ(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<JPDNIMGFJLH, IGrouping<JPDNIMGFJLH, MethodInfo>> BMFPKACEKGO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type HKNOOKFCPHJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDE20", Offset = "0x5BDCC20", VA = "0x185BDDE20")]
		private static void DCOMOPNKAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF440", Offset = "0x5BDE240", VA = "0x185BDF440")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDCE0", Offset = "0x5BDCAE0", VA = "0x185BDDCE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDDD0", Offset = "0x5BDCBD0", VA = "0x185BDDDD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDD80", Offset = "0x5BDCB80", VA = "0x185BDDD80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDD30", Offset = "0x5BDCB30", VA = "0x185BDDD30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEE60", Offset = "0x5BDDC60", VA = "0x185BDEE60")]
		private static void NHHOCEDNFFD(JPDNIMGFJLH GJDBOFDEJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE470", Offset = "0x5BDD270", VA = "0x185BDE470")]
		private static IEnumerable<MethodInfo> FKGOGHFJDMK(Type IEIJLKHOAGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE630", Offset = "0x5BDD430", VA = "0x185BDE630")]
		private static bool JMIILFGGEJE(string IHAGCAIIJON, [Out] Dictionary<string, List<string>> MJLCOADHHNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE750", Offset = "0x5BDD550", VA = "0x185BDE750")]
		private static IEnumerable<Type> KGNLGKHJJFE(Dictionary<string, List<string>> MJLCOADHHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE390", Offset = "0x5BDD190", VA = "0x185BDE390")]
		private static IEnumerable<MethodInfo> DIFPDBNMKAG(IEnumerable<Type> LIEGNJGABHN, Type IEIJLKHOAGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE500", Offset = "0x5BDD300", VA = "0x185BDE500")]
		internal static IEnumerable<MethodInfo> IJEIILOLKPN(JPDNIMGFJLH GJDBOFDEJKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEF20", Offset = "0x5BDDD20", VA = "0x185BDEF20")]
		internal static void PDEELPBAPBP(IEnumerable<MethodInfo> KFHJLBNKNMP, Type KIFOJHMPMFP, [Optional] object[] FJDDANGEILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE590", Offset = "0x5BDD390", VA = "0x185BDE590")]
		private static Dictionary<JPDNIMGFJLH, IGrouping<JPDNIMGFJLH, MethodInfo>> JDMFEDHFJOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDBC0", Offset = "0x5BDC9C0", VA = "0x185BDDBC0")]
		private static bool AKIOCJHPAPF(MethodInfo BNHGEOINGLK, Type EKIDMBABAGF, bool NLKOGMNPPAL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MHFKGDLMFAI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> NIFIECONHIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> NPODOCGCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDB00", Offset = "0x5BDC900", VA = "0x185BDDB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BDF5A0", Offset = "0x5BDE3A0", VA = "0x185BDF5A0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GKICNLKDLMH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct POHLOBDAHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo BHMKMDJEOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OGJCEJIMIKL MDJOPGNMMBD;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<KLEBEPKJPOL, List<POHLOBDAHON>> CGPNJPHGCMH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static OILPPPCALMB NHFJKHEPNKP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OILPPPCALMB BNOBPJDPOAO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static OILPPPCALMB LKNPNENAGNL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OILPPPCALMB DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDA30", Offset = "0x5BDC830", VA = "0x185BDDA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OILPPPCALMB JPKODIFFFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BDD0A0", Offset = "0x5BDBEA0", VA = "0x185BDD0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OILPPPCALMB GAHPDHEMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BDC600", Offset = "0x5BDB400", VA = "0x185BDC600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD810", Offset = "0x5BDC610", VA = "0x185BDD810")]
	[AEFABAPBKKB]
	private static void NAANNGBDELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD0E0", Offset = "0x5BDBEE0", VA = "0x185BDD0E0")]
	[CCODNAGEEMD(JPDNIMGFJLH.Unity_AfterAssembliesLoaded)]
	private static void HIAGLECOBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCD20", Offset = "0x5BDBB20", VA = "0x185BDCD20")]
	public static OILPPPCALMB FDOPPHKFGCB(KLEBEPKJPOL IBICAKNBONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCF60", Offset = "0x5BDBD60", VA = "0x185BDCF60")]
	private static void FDOPPHKFGCB(KLEBEPKJPOL IBICAKNBONM, OILPPPCALMB LCEHHHGNPPG, OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC930", Offset = "0x5BDB730", VA = "0x185BDC930")]
	private static void FDOPPHKFGCB(KLEBEPKJPOL IBICAKNBONM, OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC810", Offset = "0x5BDB610", VA = "0x185BDC810")]
	public static void FCMDJFDMAKJ(KLEBEPKJPOL IBICAKNBONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3017140", Offset = "0x3015F40", VA = "0x183017140")]
	private static bool BMKDKCMCCDB(OGJCEJIMIKL FDPELPNCNLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD8C0", Offset = "0x5BDC6C0", VA = "0x185BDD8C0")]
	private static OILPPPCALMB OGKAMDNAFHE(string OJGNIEOICEF, [Optional] OILPPPCALMB LCEHHHGNPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC640", Offset = "0x5BDB440", VA = "0x185BDC640")]
	private static void FCMDJFDMAKJ(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD810", Offset = "0x5BDC610", VA = "0x185BDD810")]
	private static void OPIMBJDHJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD270", Offset = "0x5BDC070", VA = "0x185BDD270")]
	private static IEnumerable<POHLOBDAHON> LOJLHGGJGMJ(KLEBEPKJPOL IBICAKNBONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD1B0", Offset = "0x5BDBFB0", VA = "0x185BDD1B0")]
	private static OILPPPCALMB KKGCDDJGMOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ACAPGFABAGN<T> : IDisposable where T : ACAPGFABAGN<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T JGOGHBIKMPG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T GOPCOAILBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3458F50", Offset = "0x3457D50", VA = "0x183458F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected ACAPGFABAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3458F10", Offset = "0x3457D10", VA = "0x183458F10", Slot = "5")]
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
