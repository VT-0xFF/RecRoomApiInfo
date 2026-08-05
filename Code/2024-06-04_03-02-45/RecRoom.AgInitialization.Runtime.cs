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
		private sealed class KMMBOEILCOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public KMMBOEILCOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x66D3C30", Offset = "0x66D2430", VA = "0x1866D3C30")]
			internal IEnumerable<MethodInfo> IEBAMHPEKHD(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66D3BD0", Offset = "0x66D23D0", VA = "0x1866D3BD0")]
			internal bool DMNJPOEGDGM(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class PDGIHGEEFOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PDGIHGEEFOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x66D3E00", Offset = "0x66D2600", VA = "0x1866D3E00")]
			internal bool IINAGFNGJBI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class OIAIAGLIJKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public OIAIAGLIJKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66D3DB0", Offset = "0x66D25B0", VA = "0x1866D3DB0")]
			internal bool HCOAFDJPJFE(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<MHEOPBLLNDG, IGrouping<MHEOPBLLNDG, MethodInfo>> IOABCIAEJKO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type KNEBIKAMFMG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66D5060", Offset = "0x66D3860", VA = "0x1866D5060")]
		private static void JNIHEBHKEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66D56C0", Offset = "0x66D3EC0", VA = "0x1866D56C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66D4450", Offset = "0x66D2C50", VA = "0x1866D4450")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66D4540", Offset = "0x66D2D40", VA = "0x1866D4540")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66D44F0", Offset = "0x66D2CF0", VA = "0x1866D44F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66D44A0", Offset = "0x66D2CA0", VA = "0x1866D44A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66D4390", Offset = "0x66D2B90", VA = "0x1866D4390")]
		private static void ANJABMPGJEH(MHEOPBLLNDG KOLMPACKKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66D4EF0", Offset = "0x66D36F0", VA = "0x1866D4EF0")]
		private static IEnumerable<MethodInfo> HMKFCLMNEOD(Type LAJJKNILLNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66D4620", Offset = "0x66D2E20", VA = "0x1866D4620")]
		private static bool DGBLILNAKGA(string JFONOCKPODN, [Out] Dictionary<string, List<string>> NOCMJDCLBND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66D47D0", Offset = "0x66D2FD0", VA = "0x1866D47D0")]
		private static IEnumerable<Type> HKNLJHNCLNC(Dictionary<string, List<string>> NOCMJDCLBND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66D4F80", Offset = "0x66D3780", VA = "0x1866D4F80")]
		private static IEnumerable<MethodInfo> ICBAPKDBLOG(IEnumerable<Type> DHGCKNFJOCJ, Type LAJJKNILLNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66D4740", Offset = "0x66D2F40", VA = "0x1866D4740")]
		internal static IEnumerable<MethodInfo> EDJJPLHIJMF(MHEOPBLLNDG KOLMPACKKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E60", Offset = "0x66D2660", VA = "0x1866D3E60")]
		internal static void AEAIPNIJCHJ(IEnumerable<MethodInfo> DHMIJDEHDAO, Type NHIFLMLDEPH, [Optional] object[] EKJGIMBPPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66D4590", Offset = "0x66D2D90", VA = "0x1866D4590")]
		private static Dictionary<MHEOPBLLNDG, IGrouping<MHEOPBLLNDG, MethodInfo>> CENKPPMMHDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66D55A0", Offset = "0x66D3DA0", VA = "0x1866D55A0")]
		private static bool LEDAMGBMKJN(MethodInfo FKCDLACMADL, Type CMMLPNCDEBL, bool PPIFENCPODL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LGDGJLDJFJB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> KIKFPJGHMHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> PADCBKODHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66D3CF0", Offset = "0x66D24F0", VA = "0x1866D3CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D5810", Offset = "0x66D4010", VA = "0x1866D5810")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KCEFPEBIBHH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct CBPPBBMGIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo KOKNFDJHOFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public ELBANFBEGNE DHPINBJOPIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<KKPEBAHBECP, List<CBPPBBMGIJB>> OOGCKOPNDKF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static AANDDJDEEFL JJJKKMNIDIE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static AANDDJDEEFL LBNIPNJABKK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static AANDDJDEEFL ANAAFONLDBM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AANDDJDEEFL BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66D3080", Offset = "0x66D1880", VA = "0x1866D3080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AANDDJDEEFL ADCHCPBEMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66D3140", Offset = "0x66D1940", VA = "0x1866D3140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static AANDDJDEEFL HDMFMNMICNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x66D3040", Offset = "0x66D1840", VA = "0x1866D3040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool JOCJEPIIDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66D3180", Offset = "0x66D1980", VA = "0x1866D3180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x66D27F0", Offset = "0x66D0FF0", VA = "0x1866D27F0")]
	[HJMDOGPGJGC]
	private static void NCHJHIOMLOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x66D2720", Offset = "0x66D0F20", VA = "0x1866D2720")]
	[ODHFHHNMGDK(MHEOPBLLNDG.Unity_AfterAssembliesLoaded)]
	private static void CNLIOOGAIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x66D3490", Offset = "0x66D1C90", VA = "0x1866D3490")]
	public static AANDDJDEEFL PONNJMLJGAD(KKPEBAHBECP HOBNEACICIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x66D3A90", Offset = "0x66D2290", VA = "0x1866D3A90")]
	private static void PONNJMLJGAD(KKPEBAHBECP HOBNEACICIM, AANDDJDEEFL MBIIHOBBHFA, AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66D36B0", Offset = "0x66D1EB0", VA = "0x1866D36B0")]
	private static void PONNJMLJGAD(KKPEBAHBECP HOBNEACICIM, AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x66D31C0", Offset = "0x66D19C0", VA = "0x1866D31C0")]
	public static void PNIBONCJJNI(KKPEBAHBECP HOBNEACICIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24BBCB0", Offset = "0x24BA4B0", VA = "0x1824BBCB0")]
	private static bool NAEPKADNLFJ(ELBANFBEGNE OBGMCIBEHEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66D2890", Offset = "0x66D1090", VA = "0x1866D2890")]
	private static AANDDJDEEFL EBBJMJMEKBP(string DPIMNDHOCNJ, [Optional] AANDDJDEEFL MBIIHOBBHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x66D32D0", Offset = "0x66D1AD0", VA = "0x1866D32D0")]
	private static void PNIBONCJJNI(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x66D27F0", Offset = "0x66D0FF0", VA = "0x1866D27F0")]
	private static void DNKEMFHMAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x66D2A00", Offset = "0x66D1200", VA = "0x1866D2A00")]
	private static IEnumerable<CBPPBBMGIJB> FJKHIJIDHAM(KKPEBAHBECP HOBNEACICIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x66D2F90", Offset = "0x66D1790", VA = "0x1866D2F90")]
	private static AANDDJDEEFL HGLGBINLGPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BIAIOINEDOD<T> : IDisposable where T : BIAIOINEDOD<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T OFKHAJDAKLA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T DCEJKJKKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D29B20", Offset = "0x4D28320", VA = "0x184D29B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected BIAIOINEDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D29AE0", Offset = "0x4D282E0", VA = "0x184D29AE0", Slot = "5")]
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
