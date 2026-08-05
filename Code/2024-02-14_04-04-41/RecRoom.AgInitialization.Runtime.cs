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
		private sealed class IFGHHCHKFCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public IFGHHCHKFCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5DF2E40", Offset = "0x5DF2240", VA = "0x185DF2E40")]
			internal IEnumerable<MethodInfo> DKJNJKEPGJC(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5DF2F00", Offset = "0x5DF2300", VA = "0x185DF2F00")]
			internal bool GDBDCNKFLIF(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class KONFLAKIMMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public KONFLAKIMMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5DF3070", Offset = "0x5DF2470", VA = "0x185DF3070")]
			internal bool CNKPNNMOJMN(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KELOJCPKBAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public KELOJCPKBAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5DF2F60", Offset = "0x5DF2360", VA = "0x185DF2F60")]
			internal bool FIACDGCDDJH(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<PCHEJJBEMBB, IGrouping<PCHEJJBEMBB, MethodInfo>> EOLFEFNFDOB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type MNKGJOLOLHH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5DF30D0", Offset = "0x5DF24D0", VA = "0x185DF30D0")]
		private static void AEAFFBBHMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4950", Offset = "0x5DF3D50", VA = "0x185DF4950")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3700", Offset = "0x5DF2B00", VA = "0x185DF3700")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5DF37F0", Offset = "0x5DF2BF0", VA = "0x185DF37F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5DF37A0", Offset = "0x5DF2BA0", VA = "0x185DF37A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3750", Offset = "0x5DF2B50", VA = "0x185DF3750")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3640", Offset = "0x5DF2A40", VA = "0x185DF3640")]
		private static void APPPGDCJJHJ(PCHEJJBEMBB FPGGHBIMBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3840", Offset = "0x5DF2C40", VA = "0x185DF3840")]
		private static IEnumerable<MethodInfo> EGCHLMKOAPA(Type BBCGMIJMIND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3960", Offset = "0x5DF2D60", VA = "0x185DF3960")]
		private static bool LOECODEBDJF(string EFDOONEIEPD, [Out] Dictionary<string, List<string>> FCDFMIENDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4240", Offset = "0x5DF3640", VA = "0x185DF4240")]
		private static IEnumerable<Type> PLFJPFKHEAA(Dictionary<string, List<string>> FCDFMIENDFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3BA0", Offset = "0x5DF2FA0", VA = "0x185DF3BA0")]
		private static IEnumerable<MethodInfo> NCPOAMPPFME(IEnumerable<Type> MIOOPNHKJID, Type BBCGMIJMIND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF38D0", Offset = "0x5DF2CD0", VA = "0x185DF38D0")]
		internal static IEnumerable<MethodInfo> KICMLDHPOCH(PCHEJJBEMBB FPGGHBIMBBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3C80", Offset = "0x5DF3080", VA = "0x185DF3C80")]
		internal static void NJAAOANHKCJ(IEnumerable<MethodInfo> FJLJICCCFMA, Type KLFKBHEDPEL, [Optional] object[] BOJHHCEEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF41A0", Offset = "0x5DF35A0", VA = "0x185DF41A0")]
		private static Dictionary<PCHEJJBEMBB, IGrouping<PCHEJJBEMBB, MethodInfo>> NOLAIEOCKEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3A80", Offset = "0x5DF2E80", VA = "0x185DF3A80")]
		private static bool MKBMIDCBIKC(MethodInfo DEIILLNONCA, Type CFCAPMCPIND, bool NCNBPPJELMP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KNDJLONAFGK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> BLDEGGPLJHK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> BFJGODFGJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2FB0", Offset = "0x5DF23B0", VA = "0x185DF2FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DF4AB0", Offset = "0x5DF3EB0", VA = "0x185DF4AB0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HGBLKFPDDGH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct OEAEBMBABFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo BENGLOILPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OJLOCLENGNC NELEMBNGHJO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<DIKIGLGFNNP, List<OEAEBMBABFH>> IKIBOFFDMGC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static BHJKECHLECD JJBNLPLMIAK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BHJKECHLECD OPJGLJGMPIH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static BHJKECHLECD LICFEDKGCLL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BHJKECHLECD MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1AB0", Offset = "0x5DF0EB0", VA = "0x185DF1AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BHJKECHLECD BBLLBJNOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2B80", Offset = "0x5DF1F80", VA = "0x185DF2B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static BHJKECHLECD GJLIEHEFCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2BC0", Offset = "0x5DF1FC0", VA = "0x185DF2BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A00", Offset = "0x5DF0E00", VA = "0x185DF1A00")]
	[GOHLDELPFPM]
	private static void LGKODDLJGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2D70", Offset = "0x5DF2170", VA = "0x185DF2D70")]
	[DDPIKLHKBPE(PCHEJJBEMBB.Unity_AfterAssembliesLoaded)]
	private static void PBHDGFCKIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DF20B0", Offset = "0x5DF14B0", VA = "0x185DF20B0")]
	public static BHJKECHLECD GBJPJHBPKFG(DIKIGLGFNNP HBADOCMFBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1F70", Offset = "0x5DF1370", VA = "0x185DF1F70")]
	private static void GBJPJHBPKFG(DIKIGLGFNNP HBADOCMFBJB, BHJKECHLECD FAHHHGHBKDP, BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B80", Offset = "0x5DF0F80", VA = "0x185DF1B80")]
	private static void GBJPJHBPKFG(DIKIGLGFNNP HBADOCMFBJB, BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DF24C0", Offset = "0x5DF18C0", VA = "0x185DF24C0")]
	public static void HFAGFGKHMDK(DIKIGLGFNNP HBADOCMFBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21D4B00", Offset = "0x21D3F00", VA = "0x1821D4B00")]
	private static bool FFMINOBGBHD(OJLOCLENGNC OCEOFPMEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2C00", Offset = "0x5DF2000", VA = "0x185DF2C00")]
	private static BHJKECHLECD MHNOGNEFBJC(string OIAOGLNNKIH, [Optional] BHJKECHLECD FAHHHGHBKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF22F0", Offset = "0x5DF16F0", VA = "0x185DF22F0")]
	private static void HFAGFGKHMDK(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A00", Offset = "0x5DF0E00", VA = "0x185DF1A00")]
	private static void DPJHCOCDHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF25E0", Offset = "0x5DF19E0", VA = "0x185DF25E0")]
	private static IEnumerable<OEAEBMBABFH> IIBFBAPIBIB(DIKIGLGFNNP HBADOCMFBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1940", Offset = "0x5DF0D40", VA = "0x185DF1940")]
	private static BHJKECHLECD DCALAEEMNLG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MJLCEJODJMC<T> : IDisposable where T : MJLCEJODJMC<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T CONPDDCOPOE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D72D30", Offset = "0x3D72130", VA = "0x183D72D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected MJLCEJODJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D72CF0", Offset = "0x3D720F0", VA = "0x183D72CF0", Slot = "5")]
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
