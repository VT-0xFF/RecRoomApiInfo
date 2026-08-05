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
		private sealed class OBDAKMNHBGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public OBDAKMNHBGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x642BFB0", Offset = "0x642A9B0", VA = "0x18642BFB0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x642C080", Offset = "0x642AA80", VA = "0x18642C080")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FFDDCHKENFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public FFDDCHKENFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x642BF40", Offset = "0x642A940", VA = "0x18642BF40")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class OMFCJKMNEKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public OMFCJKMNEKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x642C0F0", Offset = "0x642AAF0", VA = "0x18642C0F0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string BDCLOACJEEN = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string OGOBDPCDBKN = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<BKOJJJFAHIH, IGrouping<BKOJJJFAHIH, MethodInfo>> OLCNADNJDPJ;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type CNOIMEDBOHJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x642D5B0", Offset = "0x642BFB0", VA = "0x18642D5B0")]
		private static void NPECBEOONFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x642DBA0", Offset = "0x642C5A0", VA = "0x18642DBA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x642C140", Offset = "0x642AB40", VA = "0x18642C140")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x642C9B0", Offset = "0x642B3B0", VA = "0x18642C9B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x642C960", Offset = "0x642B360", VA = "0x18642C960")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x642C190", Offset = "0x642AB90", VA = "0x18642C190")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x642CD10", Offset = "0x642B710", VA = "0x18642CD10")]
		private static void FCCMGPCDHNE(BKOJJJFAHIH DMALDCKBMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x642CBC0", Offset = "0x642B5C0", VA = "0x18642CBC0")]
		private static IEnumerable<MethodInfo> EAEBCPAMJHE(Type BOLPFEELCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x642CA00", Offset = "0x642B400", VA = "0x18642CA00")]
		private static bool DCCIEDBIJFL(string PANFCKCMCFO, out Dictionary<string, List<string>> AEFAFICCHHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x642C1E0", Offset = "0x642ABE0", VA = "0x18642C1E0")]
		private static IEnumerable<Type> BNHFMPKCMNF(Dictionary<string, List<string>> AEFAFICCHHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x642CDE0", Offset = "0x642B7E0", VA = "0x18642CDE0")]
		private static IEnumerable<MethodInfo> FICFMMCAOMD(IEnumerable<Type> LJPCAFALCCO, Type BOLPFEELCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x642CC80", Offset = "0x642B680", VA = "0x18642CC80")]
		internal static IEnumerable<MethodInfo> EPPIFNAGABC(BKOJJJFAHIH DMALDCKBMLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x642CEC0", Offset = "0x642B8C0", VA = "0x18642CEC0")]
		internal static void KCOCBPMMPGI(IEnumerable<MethodInfo> KAFPEIBLCOK, Type NOPMPDNHDJK, [Optional] object[] HKHEDELGBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x642D4F0", Offset = "0x642BEF0", VA = "0x18642D4F0")]
		private static Dictionary<BKOJJJFAHIH, IGrouping<BKOJJJFAHIH, MethodInfo>> KJOJKIEBGBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x642D3D0", Offset = "0x642BDD0", VA = "0x18642D3D0")]
		private static bool KHDFIFMCACO(MethodInfo OMMEMGJEKPF, Type AIMIBDEIHPP, bool PIDGGOEDGCN)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x642DD10", Offset = "0x642C710", VA = "0x18642DD10")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ANMBJDCIOCA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct LEDFGKJPOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo FHAPGFJGOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HFKENCJEONK IJIPHDNNPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool JDPNCMBAPJD;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<LIKMDIKCKMO, List<LEDFGKJPOBC>> KBGMEKCBKNK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static PLIBOCMCGIC BMKIKOMOFMO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static PLIBOCMCGIC CDHICPLGBON;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PLIBOCMCGIC BMGCOEAOGCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PLIBOCMCGIC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x642B140", Offset = "0x6429B40", VA = "0x18642B140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PLIBOCMCGIC DAAADKCPHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x642B230", Offset = "0x6429C30", VA = "0x18642B230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PLIBOCMCGIC ANMFNNCPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x642B270", Offset = "0x6429C70", VA = "0x18642B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x642AAC0", Offset = "0x64294C0", VA = "0x18642AAC0")]
	[LDJJMHLINKF]
	private static void EOAIAHDEKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x642A540", Offset = "0x6428F40", VA = "0x18642A540")]
	[GGMCOFEBBAE(BKOJJJFAHIH.Unity_AfterAssembliesLoaded)]
	private static void AMBMIJALNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x642B520", Offset = "0x6429F20", VA = "0x18642B520")]
	public static PLIBOCMCGIC MNJGGPCHOKP(LIKMDIKCKMO EFJBLLLGAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x642B390", Offset = "0x6429D90", VA = "0x18642B390")]
	private static void MNJGGPCHOKP(LIKMDIKCKMO EFJBLLLGAMK, PLIBOCMCGIC JDCEOEILIMC, ref PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x642B760", Offset = "0x642A160", VA = "0x18642B760")]
	private static void MNJGGPCHOKP(LIKMDIKCKMO EFJBLLLGAMK, PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x642A7B0", Offset = "0x64291B0", VA = "0x18642A7B0")]
	public static void CDPIHMENOAA(LIKMDIKCKMO EFJBLLLGAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x642B2B0", Offset = "0x6429CB0", VA = "0x18642B2B0")]
	private static bool KMFFHLMIIOF(HFKENCJEONK HFBMMABJAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x642A630", Offset = "0x6429030", VA = "0x18642A630")]
	private static PLIBOCMCGIC CBDGNLKCMJD(string GBGIAGGNPDH, [Optional] PLIBOCMCGIC JDCEOEILIMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x642A8C0", Offset = "0x64292C0", VA = "0x18642A8C0")]
	private static void CDPIHMENOAA(ref PLIBOCMCGIC KCKJCMPILDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x642AAC0", Offset = "0x64294C0", VA = "0x18642AAC0")]
	private static void HHIDKLKANKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x642AB70", Offset = "0x6429570", VA = "0x18642AB70")]
	private static IEnumerable<LEDFGKJPOBC> HFIMICCPAJB(LIKMDIKCKMO EFJBLLLGAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x642BE50", Offset = "0x642A850", VA = "0x18642BE50")]
	private static PLIBOCMCGIC NDDGJJJKOKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FMFOENMFOGB<T> : IDisposable where T : global::FMFOENMFOGB<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static T AIDJCJOCGNF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T FMAHKEPPCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0CE0", Offset = "0x2F9F6E0", VA = "0x182FA0CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	protected FMFOENMFOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0CA0", Offset = "0x2F9F6A0", VA = "0x182FA0CA0", Slot = "5")]
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
