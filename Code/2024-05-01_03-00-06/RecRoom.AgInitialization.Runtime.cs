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
		private sealed class PMHCOPBPNPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public PMHCOPBPNPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x609BE90", Offset = "0x609AC90", VA = "0x18609BE90")]
			internal IEnumerable<MethodInfo> KMDNGEGPGLP(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x609BF50", Offset = "0x609AD50", VA = "0x18609BF50")]
			internal bool LAEKJIPNCLG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BKOFHFEOOPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public BKOFHFEOOPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x609BDE0", Offset = "0x609ABE0", VA = "0x18609BDE0")]
			internal bool DEAPIDLFFHA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FBEPBFNECCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public FBEPBFNECCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x609BE40", Offset = "0x609AC40", VA = "0x18609BE40")]
			internal bool IMNGHBNBMGA(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<PHCHACMKDPF, IGrouping<PHCHACMKDPF, MethodInfo>> FEPNIKJCAFN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type EEJCCCCJEIP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x609C860", Offset = "0x609B660", VA = "0x18609C860")]
		private static void JFDCEIBOOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x609D820", Offset = "0x609C620", VA = "0x18609D820")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x609BFB0", Offset = "0x609ADB0", VA = "0x18609BFB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x609C160", Offset = "0x609AF60", VA = "0x18609C160")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x609C110", Offset = "0x609AF10", VA = "0x18609C110")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x609C000", Offset = "0x609AE00", VA = "0x18609C000")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x609C050", Offset = "0x609AE50", VA = "0x18609C050")]
		private static void BMHLPFHBNIN(PHCHACMKDPF HGFCHNPAKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x609C1B0", Offset = "0x609AFB0", VA = "0x18609C1B0")]
		private static IEnumerable<MethodInfo> FNCPHHBGLFB(Type LIFNGBABIMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x609CE30", Offset = "0x609BC30", VA = "0x18609CE30")]
		private static bool LCDHDKAIAIB(string IPKMFHJOLAG, [Out] Dictionary<string, List<string>> PJKOHFMIKEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x609CFE0", Offset = "0x609BDE0", VA = "0x18609CFE0")]
		private static IEnumerable<Type> PBBJAAPENBJ(Dictionary<string, List<string>> PJKOHFMIKEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x609C240", Offset = "0x609B040", VA = "0x18609C240")]
		private static IEnumerable<MethodInfo> IHAFMFIBIBL(IEnumerable<Type> CHDGAFJKNGH, Type LIFNGBABIMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609CF50", Offset = "0x609BD50", VA = "0x18609CF50")]
		internal static IEnumerable<MethodInfo> OELJMMFHAKJ(PHCHACMKDPF HGFCHNPAKKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x609C320", Offset = "0x609B120", VA = "0x18609C320")]
		internal static void JCBJOONIIBM(IEnumerable<MethodInfo> IIIEPJKMOLH, Type EGHMIJKOKMB, [Optional] object[] AHMCCAODOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x609CDA0", Offset = "0x609BBA0", VA = "0x18609CDA0")]
		private static Dictionary<PHCHACMKDPF, IGrouping<PHCHACMKDPF, MethodInfo>> LBHGMAOBLCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x609D700", Offset = "0x609C500", VA = "0x18609D700")]
		private static bool PPBGFGKEAGA(MethodInfo FPPGEGCPFFB, Type JKHHENELANE, bool PHLCACKMHEP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AEBHNAOOIMG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> FIJGBLBGMGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> LANEKEGJLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x609BD20", Offset = "0x609AB20", VA = "0x18609BD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x609D970", Offset = "0x609C770", VA = "0x18609D970")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ABMEAHNLPDP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct HAOELLPOHHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo NDIEIMAFLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OHNOEEJKPCM HGCDIKBFONG;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<FMOBJKPMAGC, List<HAOELLPOHHB>> FNLENDKLIID;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static NAINNGGFMLM HFICMLMPBLB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static NAINNGGFMLM KIALKEGMJCC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static NAINNGGFMLM BOJGHGJOFJL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static NAINNGGFMLM OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x609B9C0", Offset = "0x609A7C0", VA = "0x18609B9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NAINNGGFMLM MJCEABPDGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x609BCE0", Offset = "0x609AAE0", VA = "0x18609BCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static NAINNGGFMLM BCCPAGBPAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x609BA80", Offset = "0x609A880", VA = "0x18609BA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool KNKOGNLGHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x609B050", Offset = "0x6099E50", VA = "0x18609B050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x609A870", Offset = "0x6099670", VA = "0x18609A870")]
	[PDDBNOCHDBA]
	private static void PHOCPOOKMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x609B8F0", Offset = "0x609A6F0", VA = "0x18609B8F0")]
	[MCGCGJJLKLL(PHCHACMKDPF.Unity_AfterAssembliesLoaded)]
	private static void JMNAHPBBCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x609AE30", Offset = "0x6099C30", VA = "0x18609AE30")]
	public static NAINNGGFMLM EJAHECDDCEP(FMOBJKPMAGC EIOIKGLLBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x609A910", Offset = "0x6099710", VA = "0x18609A910")]
	private static void EJAHECDDCEP(FMOBJKPMAGC EIOIKGLLBPG, NAINNGGFMLM NCOAFEMCDOP, NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x609AA50", Offset = "0x6099850", VA = "0x18609AA50")]
	private static void EJAHECDDCEP(FMOBJKPMAGC EIOIKGLLBPG, NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x609B090", Offset = "0x6099E90", VA = "0x18609B090")]
	public static void HOLDPNHLGBG(FMOBJKPMAGC EIOIKGLLBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x238CE40", Offset = "0x238BC40", VA = "0x18238CE40")]
	private static bool AMGFIIHIMCB(OHNOEEJKPCM MMOFPNBCHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x609BAC0", Offset = "0x609A8C0", VA = "0x18609BAC0")]
	private static NAINNGGFMLM NAOPBMJONLF(string GDJIHPFNIAO, [Optional] NAINNGGFMLM NCOAFEMCDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x609B1A0", Offset = "0x6099FA0", VA = "0x18609B1A0")]
	private static void HOLDPNHLGBG(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x609A870", Offset = "0x6099670", VA = "0x18609A870")]
	private static void BOHHHLMMKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x609B360", Offset = "0x609A160", VA = "0x18609B360")]
	private static IEnumerable<HAOELLPOHHB> JBCKCCGBMJH(FMOBJKPMAGC EIOIKGLLBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x609BC30", Offset = "0x609AA30", VA = "0x18609BC30")]
	private static NAINNGGFMLM NKIPGOJOJKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IDPKKEAJBCC<T> : IDisposable where T : IDPKKEAJBCC<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T LOMIFCBLBKN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T LLCJIHIKEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F6B0", Offset = "0x3A6E4B0", VA = "0x183A6F6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected IDPKKEAJBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F950", Offset = "0x3A6E750", VA = "0x183A6F950", Slot = "5")]
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
