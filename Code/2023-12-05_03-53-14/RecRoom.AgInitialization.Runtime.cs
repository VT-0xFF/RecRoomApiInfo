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
			[Cpp2IlInjected.Address(RVA = "0x5D0D680", Offset = "0x5D0CA80", VA = "0x185D0D680")]
			internal IEnumerable<MethodInfo> HOHPCBICJMI(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D620", Offset = "0x5D0CA20", VA = "0x185D0D620")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D0D740", Offset = "0x5D0CB40", VA = "0x185D0D740")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D0D7A0", Offset = "0x5D0CBA0", VA = "0x185D0D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0F7F0", Offset = "0x5D0EBF0", VA = "0x185D0F7F0")]
		private static void LOANMHGMNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D10630", Offset = "0x5D0FA30", VA = "0x185D10630")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EDB0", Offset = "0x5D0E1B0", VA = "0x185D0EDB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EF30", Offset = "0x5D0E330", VA = "0x185D0EF30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EEE0", Offset = "0x5D0E2E0", VA = "0x185D0EEE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EE00", Offset = "0x5D0E200", VA = "0x185D0EE00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EF80", Offset = "0x5D0E380", VA = "0x185D0EF80")]
		private static void CBAMCCOOJLP(LDDPNLEJGAE EMACICCJKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FFA0", Offset = "0x5D0F3A0", VA = "0x185D0FFA0")]
		private static IEnumerable<MethodInfo> OPJCDIHKMID(Type GMONGKGFIPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FD60", Offset = "0x5D0F160", VA = "0x185D0FD60")]
		private static bool MECDEJPJJIP(string BAGICNHBKGE, [Out] Dictionary<string, List<string>> BLBDDNEKLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F0E0", Offset = "0x5D0E4E0", VA = "0x185D0F0E0")]
		private static IEnumerable<Type> FBMCOGMMCBG(Dictionary<string, List<string>> BLBDDNEKLIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D10030", Offset = "0x5D0F430", VA = "0x185D10030")]
		private static IEnumerable<MethodInfo> PKEEPEMEALK(IEnumerable<Type> LDELOPILKFA, Type GMONGKGFIPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EE50", Offset = "0x5D0E250", VA = "0x185D0EE50")]
		internal static IEnumerable<MethodInfo> BOBGHAKALDA(LDDPNLEJGAE EMACICCJKGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D10110", Offset = "0x5D0F510", VA = "0x185D10110")]
		internal static void PKNDEOABCLP(IEnumerable<MethodInfo> JGMIACCPBLJ, Type OHKDJCKNCCJ, [Optional] object[] NNBNMFFCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F040", Offset = "0x5D0E440", VA = "0x185D0F040")]
		private static Dictionary<LDDPNLEJGAE, IGrouping<LDDPNLEJGAE, MethodInfo>> EMGHPPMPONK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FE80", Offset = "0x5D0F280", VA = "0x185D0FE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0D7F0", Offset = "0x5D0CBF0", VA = "0x185D0D7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D10790", Offset = "0x5D0FB90", VA = "0x185D10790")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0E460", Offset = "0x5D0D860", VA = "0x185D0E460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DIBCBJLEDOH GPFPDGDIMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E420", Offset = "0x5D0D820", VA = "0x185D0E420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DIBCBJLEDOH BHFINENGPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E530", Offset = "0x5D0D930", VA = "0x185D0E530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E2B0", Offset = "0x5D0D6B0", VA = "0x185D0E2B0")]
	[LFCNCNFPMGP]
	private static void CPNJIPBPOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E570", Offset = "0x5D0D970", VA = "0x185D0E570")]
	[HJCCINDKAPB(LDDPNLEJGAE.Unity_AfterAssembliesLoaded)]
	private static void NGMCECBBIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EA30", Offset = "0x5D0DE30", VA = "0x185D0EA30")]
	public static DIBCBJLEDOH NNHIBGENBLC(IHKKALDEJFL BBEOOCDDOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EC70", Offset = "0x5D0E070", VA = "0x185D0EC70")]
	private static void NNHIBGENBLC(IHKKALDEJFL BBEOOCDDOEN, DIBCBJLEDOH MAJPGMDBMIO, DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E640", Offset = "0x5D0DA40", VA = "0x185D0E640")]
	private static void NNHIBGENBLC(IHKKALDEJFL BBEOOCDDOEN, DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DE50", Offset = "0x5D0D250", VA = "0x185D0DE50")]
	public static void BMHMPFOLOHH(IHKKALDEJFL BBEOOCDDOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35FE9D0", Offset = "0x35FDDD0", VA = "0x1835FE9D0")]
	private static bool AFMGGIBIPMA(PLCOHLLKCIG HGBDKHPDBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E140", Offset = "0x5D0D540", VA = "0x185D0E140")]
	private static DIBCBJLEDOH CKLFLEBLOBJ(string DLGLMNAIPHH, [Optional] DIBCBJLEDOH MAJPGMDBMIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DF70", Offset = "0x5D0D370", VA = "0x185D0DF70")]
	private static void BMHMPFOLOHH(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E2B0", Offset = "0x5D0D6B0", VA = "0x185D0E2B0")]
	private static void KCHFCJPICKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D8B0", Offset = "0x5D0CCB0", VA = "0x185D0D8B0")]
	private static IEnumerable<FDPGECJICMI> BEFJMDPLKCD(IHKKALDEJFL BBEOOCDDOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E360", Offset = "0x5D0D760", VA = "0x185D0E360")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D38C30", Offset = "0x3D38030", VA = "0x183D38C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D38BF0", Offset = "0x3D37FF0", VA = "0x183D38BF0", Slot = "5")]
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
