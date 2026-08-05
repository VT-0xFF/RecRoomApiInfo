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
		private sealed class GIMEPFMEDDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public GIMEPFMEDDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D760", Offset = "0x5D0CB60", VA = "0x185D0D760")]
			internal IEnumerable<MethodInfo> HOHPCBICJMI(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D700", Offset = "0x5D0CB00", VA = "0x185D0D700")]
			internal bool GALNJBBNBIC(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GJDOFIJCFKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public GJDOFIJCFKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D820", Offset = "0x5D0CC20", VA = "0x185D0D820")]
			internal bool LEKJHNLAKKC(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GPOEAIMOHOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public GPOEAIMOHOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D880", Offset = "0x5D0CC80", VA = "0x185D0D880")]
			internal bool CGKMFEOPIKB(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<LDDPNLEJGAE, IGrouping<LDDPNLEJGAE, MethodInfo>> NAPCOHNHDBN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type ANJKDLFLIJI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F8D0", Offset = "0x5D0ECD0", VA = "0x185D0F8D0")]
		private static void LOANMHGMNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D10710", Offset = "0x5D0FB10", VA = "0x185D10710")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EE90", Offset = "0x5D0E290", VA = "0x185D0EE90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F010", Offset = "0x5D0E410", VA = "0x185D0F010")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EFC0", Offset = "0x5D0E3C0", VA = "0x185D0EFC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EEE0", Offset = "0x5D0E2E0", VA = "0x185D0EEE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F060", Offset = "0x5D0E460", VA = "0x185D0F060")]
		private static void CBAMCCOOJLP(LDDPNLEJGAE EMACICCJKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D10080", Offset = "0x5D0F480", VA = "0x185D10080")]
		private static IEnumerable<MethodInfo> OPJCDIHKMID(Type GMONGKGFIPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FE40", Offset = "0x5D0F240", VA = "0x185D0FE40")]
		private static bool MECDEJPJJIP(string BAGICNHBKGE, [Out] Dictionary<string, List<string>> BLBDDNEKLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F1C0", Offset = "0x5D0E5C0", VA = "0x185D0F1C0")]
		private static IEnumerable<Type> FBMCOGMMCBG(Dictionary<string, List<string>> BLBDDNEKLIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D10110", Offset = "0x5D0F510", VA = "0x185D10110")]
		private static IEnumerable<MethodInfo> PKEEPEMEALK(IEnumerable<Type> LDELOPILKFA, Type GMONGKGFIPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EF30", Offset = "0x5D0E330", VA = "0x185D0EF30")]
		internal static IEnumerable<MethodInfo> BOBGHAKALDA(LDDPNLEJGAE EMACICCJKGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D101F0", Offset = "0x5D0F5F0", VA = "0x185D101F0")]
		internal static void PKNDEOABCLP(IEnumerable<MethodInfo> JGMIACCPBLJ, Type OHKDJCKNCCJ, [Optional] object[] NNBNMFFCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F120", Offset = "0x5D0E520", VA = "0x185D0F120")]
		private static Dictionary<LDDPNLEJGAE, IGrouping<LDDPNLEJGAE, MethodInfo>> EMGHPPMPONK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FF60", Offset = "0x5D0F360", VA = "0x185D0FF60")]
		private static bool NCMKMLLPLOM(MethodInfo BFEODAFDFIK, Type OCHIJGDOCED, bool OKDPKPOEFAO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NDLPHDJKPDP
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> MMGLLAHELFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> BBMLODNPPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D8D0", Offset = "0x5D0CCD0", VA = "0x185D0D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D10870", Offset = "0x5D0FC70", VA = "0x185D10870")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OKNPAGKLKOH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct FDPGECJICMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo ALILKKNNKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public PLCOHLLKCIG FFPGIHCLKDH;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<IHKKALDEJFL, List<FDPGECJICMI>> AHOOIMPAOBA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static DIBCBJLEDOH JLCDKOOCFCJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DIBCBJLEDOH AIJMCOGJNGN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static DIBCBJLEDOH KMDGHEJOPLK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DIBCBJLEDOH MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E540", Offset = "0x5D0D940", VA = "0x185D0E540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DIBCBJLEDOH GPFPDGDIMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E500", Offset = "0x5D0D900", VA = "0x185D0E500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DIBCBJLEDOH BHFINENGPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E610", Offset = "0x5D0DA10", VA = "0x185D0E610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E390", Offset = "0x5D0D790", VA = "0x185D0E390")]
	[LFCNCNFPMGP]
	private static void CPNJIPBPOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E650", Offset = "0x5D0DA50", VA = "0x185D0E650")]
	[HJCCINDKAPB(LDDPNLEJGAE.Unity_AfterAssembliesLoaded)]
	private static void NGMCECBBIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EB10", Offset = "0x5D0DF10", VA = "0x185D0EB10")]
	public static DIBCBJLEDOH NNHIBGENBLC(IHKKALDEJFL BBEOOCDDOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D0ED50", Offset = "0x5D0E150", VA = "0x185D0ED50")]
	private static void NNHIBGENBLC(IHKKALDEJFL BBEOOCDDOEN, DIBCBJLEDOH MAJPGMDBMIO, DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E720", Offset = "0x5D0DB20", VA = "0x185D0E720")]
	private static void NNHIBGENBLC(IHKKALDEJFL BBEOOCDDOEN, DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DF30", Offset = "0x5D0D330", VA = "0x185D0DF30")]
	public static void BMHMPFOLOHH(IHKKALDEJFL BBEOOCDDOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35FD3C0", Offset = "0x35FC7C0", VA = "0x1835FD3C0")]
	private static bool AFMGGIBIPMA(PLCOHLLKCIG HGBDKHPDBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E220", Offset = "0x5D0D620", VA = "0x185D0E220")]
	private static DIBCBJLEDOH CKLFLEBLOBJ(string DLGLMNAIPHH, [Optional] DIBCBJLEDOH MAJPGMDBMIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E050", Offset = "0x5D0D450", VA = "0x185D0E050")]
	private static void BMHMPFOLOHH(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E390", Offset = "0x5D0D790", VA = "0x185D0E390")]
	private static void KCHFCJPICKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D990", Offset = "0x5D0CD90", VA = "0x185D0D990")]
	private static IEnumerable<FDPGECJICMI> BEFJMDPLKCD(IHKKALDEJFL BBEOOCDDOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E440", Offset = "0x5D0D840", VA = "0x185D0E440")]
	private static DIBCBJLEDOH DGANLAJPNCH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NPDNJFDPDLC<T> : IDisposable where T : NPDNJFDPDLC<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T OJEBKBIJNNG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T NMGLFNHIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D377E0", Offset = "0x3D36BE0", VA = "0x183D377E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected NPDNJFDPDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D377A0", Offset = "0x3D36BA0", VA = "0x183D377A0", Slot = "5")]
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
