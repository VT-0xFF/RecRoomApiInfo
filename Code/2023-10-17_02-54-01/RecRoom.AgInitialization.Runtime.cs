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
		private sealed class NEHJOHGPNHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public NEHJOHGPNHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5BDDE10", Offset = "0x5BDC610", VA = "0x185BDDE10")]
			internal IEnumerable<MethodInfo> CJFODDOJILE(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5BDDED0", Offset = "0x5BDC6D0", VA = "0x185BDDED0")]
			internal bool KDENNFIOBLH(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CMBOHFKMCPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public CMBOHFKMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5BDC7A0", Offset = "0x5BDAFA0", VA = "0x185BDC7A0")]
			internal bool AMEKHCELKCD(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MFIFMHMMJOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public MFIFMHMMJOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5BDDDC0", Offset = "0x5BDC5C0", VA = "0x185BDDDC0")]
			internal bool IIDINMJMCII(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<EDLHBKHFALL, IGrouping<EDLHBKHFALL, MethodInfo>> MKOEPMKAHKF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type AGLJNMKIKKA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE8A0", Offset = "0x5BDD0A0", VA = "0x185BDE8A0")]
		private static void JJEBJAMGMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF7B0", Offset = "0x5BDDFB0", VA = "0x185BDF7B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE050", Offset = "0x5BDC850", VA = "0x185BDE050")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE1D0", Offset = "0x5BDC9D0", VA = "0x185BDE1D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE180", Offset = "0x5BDC980", VA = "0x185BDE180")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE0A0", Offset = "0x5BDC8A0", VA = "0x185BDE0A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE220", Offset = "0x5BDCA20", VA = "0x185BDE220")]
		private static void GDKEJCGNMDG(EDLHBKHFALL LDFOJAJCNMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE0F0", Offset = "0x5BDC8F0", VA = "0x185BDE0F0")]
		private static IEnumerable<MethodInfo> BLKKHMHNNOK(Type NFPDFEKHPKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEE10", Offset = "0x5BDD610", VA = "0x185BDEE10")]
		private static bool KEFOMEEAKCP(string JBIDMEOBOIB, [Out] Dictionary<string, List<string>> NFLHFGJFPAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEF30", Offset = "0x5BDD730", VA = "0x185BDEF30")]
		private static IEnumerable<Type> LLKACDJGPNF(Dictionary<string, List<string>> NFLHFGJFPAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF640", Offset = "0x5BDDE40", VA = "0x185BDF640")]
		private static IEnumerable<MethodInfo> NENKDOGGPJN(IEnumerable<Type> EEDANEDEDBD, Type NFPDFEKHPKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BDF720", Offset = "0x5BDDF20", VA = "0x185BDF720")]
		internal static IEnumerable<MethodInfo> PDJAHEOFNGP(EDLHBKHFALL LDFOJAJCNMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE2E0", Offset = "0x5BDCAE0", VA = "0x185BDE2E0")]
		internal static void GLNBDONPGBH(IEnumerable<MethodInfo> NBMGAHOKFIJ, Type NENDPDKPJLM, [Optional] object[] GCMLNHCMFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5BDE800", Offset = "0x5BDD000", VA = "0x185BDE800")]
		private static Dictionary<EDLHBKHFALL, IGrouping<EDLHBKHFALL, MethodInfo>> HLLLLDKPGJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDF30", Offset = "0x5BDC730", VA = "0x185BDDF30")]
		private static bool APAGKJOIABH(MethodInfo FNPBALCELLO, Type DCHPCGLAGCL, bool JJBOANFCFME)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HIFBKCNNLON
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> ECNNHALHOGB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> CJLBBAIMPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BDC800", Offset = "0x5BDB000", VA = "0x185BDC800")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BDF910", Offset = "0x5BDE110", VA = "0x185BDF910")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JKILKKOHEFN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EAKIDIKJICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo DKJBJBAFHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AFMDLPKJFNK MPAJMDODINK;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<CEDKDBJGKHF, List<EAKIDIKJICC>> JEILOKEAPNI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static LLKIHBKOOLA BBPIOAFEKBN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LLKIHBKOOLA EKONLBCEPCJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static LLKIHBKOOLA GABABDGPJJM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LLKIHBKOOLA IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BDD360", Offset = "0x5BDBB60", VA = "0x185BDD360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LLKIHBKOOLA BJBNOIEHOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BDDA90", Offset = "0x5BDC290", VA = "0x185BDDA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static LLKIHBKOOLA NDAIEONPICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCBB0", Offset = "0x5BDB3B0", VA = "0x185BDCBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC990", Offset = "0x5BDB190", VA = "0x185BDC990")]
	[MHIDAHIOIND]
	private static void PJIFJLAPMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC8C0", Offset = "0x5BDB0C0", VA = "0x185BDC8C0")]
	[MPOGKHKBIDF(EDLHBKHFALL.Unity_AfterAssembliesLoaded)]
	private static void BAOFCOHIBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD120", Offset = "0x5BDB920", VA = "0x185BDD120")]
	public static LLKIHBKOOLA GJGLJMLMKJO(CEDKDBJGKHF LFMHBCJEMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCFE0", Offset = "0x5BDB7E0", VA = "0x185BDCFE0")]
	private static void GJGLJMLMKJO(CEDKDBJGKHF LFMHBCJEMNB, LLKIHBKOOLA LKGGHPMDMAA, LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCBF0", Offset = "0x5BDB3F0", VA = "0x185BDCBF0")]
	private static void GJGLJMLMKJO(CEDKDBJGKHF LFMHBCJEMNB, LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BDDAD0", Offset = "0x5BDC2D0", VA = "0x185BDDAD0")]
	public static void MGLIKFBAGCA(CEDKDBJGKHF LFMHBCJEMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34AE930", Offset = "0x34AD130", VA = "0x1834AE930")]
	private static bool HBCKMEBGPMP(AFMDLPKJFNK HHJNAANOFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BDCA40", Offset = "0x5BDB240", VA = "0x185BDCA40")]
	private static LLKIHBKOOLA EFLFDBPICDF(string LJJEMHNCAIP, [Optional] LLKIHBKOOLA LKGGHPMDMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BDDBF0", Offset = "0x5BDC3F0", VA = "0x185BDDBF0")]
	private static void MGLIKFBAGCA(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC990", Offset = "0x5BDB190", VA = "0x185BDC990")]
	private static void DEGCNPNPCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD4F0", Offset = "0x5BDBCF0", VA = "0x185BDD4F0")]
	private static IEnumerable<EAKIDIKJICC> HHGFEDEFLKC(CEDKDBJGKHF LFMHBCJEMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDD430", Offset = "0x5BDBC30", VA = "0x185BDD430")]
	private static LLKIHBKOOLA GPOHPGGBHAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BPNKDMKFGBE<T> : IDisposable where T : BPNKDMKFGBE<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T IALEADLNNLH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T FLMPJFHFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4898D00", Offset = "0x4897500", VA = "0x184898D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected BPNKDMKFGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4898CC0", Offset = "0x48974C0", VA = "0x184898CC0", Slot = "5")]
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
