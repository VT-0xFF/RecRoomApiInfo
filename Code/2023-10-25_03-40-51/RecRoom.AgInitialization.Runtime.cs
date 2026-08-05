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
		private sealed class DIDDLKBMCGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public DIDDLKBMCGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5B7F2C0", Offset = "0x5B7E0C0", VA = "0x185B7F2C0")]
			internal IEnumerable<MethodInfo> PDADEJDJIFI(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5B7F260", Offset = "0x5B7E060", VA = "0x185B7F260")]
			internal bool INJBBEPIGLF(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class KEINLMHIIII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public KEINLMHIIII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5B7F440", Offset = "0x5B7E240", VA = "0x185B7F440")]
			internal bool MKNHFDCHNFL(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class PAMNLLIJCHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public PAMNLLIJCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5B809A0", Offset = "0x5B7F7A0", VA = "0x185B809A0")]
			internal bool MIJKLFLBEFO(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<JMJDGGKCJFL, IGrouping<JMJDGGKCJFL, MethodInfo>> DLEPNKDJANB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type IANFDHKIHPJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5B81C60", Offset = "0x5B80A60", VA = "0x185B81C60")]
		private static void MKJJLNENAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B82270", Offset = "0x5B81070", VA = "0x185B82270")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5B80F10", Offset = "0x5B7FD10", VA = "0x185B80F10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5B810E0", Offset = "0x5B7FEE0", VA = "0x185B810E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B81090", Offset = "0x5B7FE90", VA = "0x185B81090")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B80F60", Offset = "0x5B7FD60", VA = "0x185B80F60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B81250", Offset = "0x5B80050", VA = "0x185B81250")]
		private static void HDBHABMPPIF(JMJDGGKCJFL NJBANAFMIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5B811C0", Offset = "0x5B7FFC0", VA = "0x185B811C0")]
		private static IEnumerable<MethodInfo> GNMKDEAELEK(Type GANPCLMKAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B81B40", Offset = "0x5B80940", VA = "0x185B81B40")]
		private static bool MKCHJNPFDLL(string LEIPBMOGLBK, [Out] Dictionary<string, List<string>> CFKKLLJCHNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B81310", Offset = "0x5B80110", VA = "0x185B81310")]
		private static IEnumerable<Type> LAGBINIPLJM(Dictionary<string, List<string>> CFKKLLJCHNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5B80FB0", Offset = "0x5B7FDB0", VA = "0x185B80FB0")]
		private static IEnumerable<MethodInfo> BCOKDFLHEOA(IEnumerable<Type> OEBJFMPBJFI, Type GANPCLMKAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B81130", Offset = "0x5B7FF30", VA = "0x185B81130")]
		internal static IEnumerable<MethodInfo> EGAHMOMEEBO(JMJDGGKCJFL NJBANAFMIMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B809F0", Offset = "0x5B7F7F0", VA = "0x185B809F0")]
		internal static void APCBMGPNLJM(IEnumerable<MethodInfo> JAPFHKGJPDK, Type ELAOAILFBMM, [Optional] object[] APKDPMMLKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B821D0", Offset = "0x5B80FD0", VA = "0x185B821D0")]
		private static Dictionary<JMJDGGKCJFL, IGrouping<JMJDGGKCJFL, MethodInfo>> MODMODDNGAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B81A20", Offset = "0x5B80820", VA = "0x185B81A20")]
		private static bool LAJEFOODMGA(MethodInfo AFGGLLKDDFI, Type GJMEDBOJMNN, bool MHOOOHIBGHN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ELIPKPLCGDE
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> GJGPGBKBHDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> MBKJDOGADBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F380", Offset = "0x5B7E180", VA = "0x185B7F380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B823D0", Offset = "0x5B811D0", VA = "0x185B823D0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MJFBNDDJDHP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct AHNKONOEGPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo FOMFDCCEEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IEJLPKKICHC BCOBKJOMGDP;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<KHJICKDGEOE, List<AHNKONOEGPE>> CFOANBOHNMF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static NNIGDKDCOBN PKCMGINNEMG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static NNIGDKDCOBN OBIBBHPFKKO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static NNIGDKDCOBN LAILLAKNCNM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static NNIGDKDCOBN CCHJIKDEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B805A0", Offset = "0x5B7F3A0", VA = "0x185B805A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NNIGDKDCOBN MLKNCNBJBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5B804A0", Offset = "0x5B7F2A0", VA = "0x185B804A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static NNIGDKDCOBN PEGPKDCGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5B80670", Offset = "0x5B7F470", VA = "0x185B80670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F4A0", Offset = "0x5B7E2A0", VA = "0x185B7F4A0")]
	[KKGLGPKDMLB]
	private static void FMIIKMKGGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F550", Offset = "0x5B7E350", VA = "0x185B7F550")]
	[NDCOICPCJMM(JMJDGGKCJFL.Unity_AfterAssembliesLoaded)]
	private static void FCENJBAAPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F620", Offset = "0x5B7E420", VA = "0x185B7F620")]
	public static NNIGDKDCOBN FGIGOCKGDGE(KHJICKDGEOE FIDMACDFCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FC50", Offset = "0x5B7EA50", VA = "0x185B7FC50")]
	private static void FGIGOCKGDGE(KHJICKDGEOE FIDMACDFCEP, NNIGDKDCOBN AKMLFNCIJHN, NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F860", Offset = "0x5B7E660", VA = "0x185B7F860")]
	private static void FGIGOCKGDGE(KHJICKDGEOE FIDMACDFCEP, NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B80880", Offset = "0x5B7F680", VA = "0x185B80880")]
	public static void NAIPAIPABIA(KHJICKDGEOE FIDMACDFCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35ADAF0", Offset = "0x35AC8F0", VA = "0x1835ADAF0")]
	private static bool BKECIPDLBNP(IEJLPKKICHC BOBBIIBDEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B80330", Offset = "0x5B7F130", VA = "0x185B80330")]
	private static NNIGDKDCOBN HLKJLBKJMHH(string MANCIPOEBLO, [Optional] NNIGDKDCOBN AKMLFNCIJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B806B0", Offset = "0x5B7F4B0", VA = "0x185B806B0")]
	private static void NAIPAIPABIA(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F4A0", Offset = "0x5B7E2A0", VA = "0x185B7F4A0")]
	private static void DLOIOAKEKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FD90", Offset = "0x5B7EB90", VA = "0x185B7FD90")]
	private static IEnumerable<AHNKONOEGPE> GIAHJNCMEJI(KHJICKDGEOE FIDMACDFCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5B804E0", Offset = "0x5B7F2E0", VA = "0x185B804E0")]
	private static NNIGDKDCOBN JABCKLNGDGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NDMNKDNBLOH<T> : IDisposable where T : NDMNKDNBLOH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T BBDPDFCKIOF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6B90", Offset = "0x3BD5990", VA = "0x183BD6B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected NDMNKDNBLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6E50", Offset = "0x3BD5C50", VA = "0x183BD6E50", Slot = "5")]
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
