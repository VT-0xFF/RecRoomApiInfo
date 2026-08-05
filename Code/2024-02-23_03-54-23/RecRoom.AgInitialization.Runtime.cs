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
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public IFGHHCHKFCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5E6BF50", Offset = "0x5E6A950", VA = "0x185E6BF50")]
			internal IEnumerable<MethodInfo> DKJNJKEPGJC(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C010", Offset = "0x5E6AA10", VA = "0x185E6C010")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public KONFLAKIMMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C180", Offset = "0x5E6AB80", VA = "0x185E6C180")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public KELOJCPKBAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C070", Offset = "0x5E6AA70", VA = "0x185E6C070")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E6C1E0", Offset = "0x5E6ABE0", VA = "0x185E6C1E0")]
		private static void AEAFFBBHMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DA60", Offset = "0x5E6C460", VA = "0x185E6DA60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C810", Offset = "0x5E6B210", VA = "0x185E6C810")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C900", Offset = "0x5E6B300", VA = "0x185E6C900")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C8B0", Offset = "0x5E6B2B0", VA = "0x185E6C8B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C860", Offset = "0x5E6B260", VA = "0x185E6C860")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C750", Offset = "0x5E6B150", VA = "0x185E6C750")]
		private static void APPPGDCJJHJ(PCHEJJBEMBB FPGGHBIMBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C950", Offset = "0x5E6B350", VA = "0x185E6C950")]
		private static IEnumerable<MethodInfo> EGCHLMKOAPA(Type BBCGMIJMIND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CA70", Offset = "0x5E6B470", VA = "0x185E6CA70")]
		private static bool LOECODEBDJF(string EFDOONEIEPD, [Out] Dictionary<string, List<string>> FCDFMIENDFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D350", Offset = "0x5E6BD50", VA = "0x185E6D350")]
		private static IEnumerable<Type> PLFJPFKHEAA(Dictionary<string, List<string>> FCDFMIENDFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CCB0", Offset = "0x5E6B6B0", VA = "0x185E6CCB0")]
		private static IEnumerable<MethodInfo> NCPOAMPPFME(IEnumerable<Type> MIOOPNHKJID, Type BBCGMIJMIND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C9E0", Offset = "0x5E6B3E0", VA = "0x185E6C9E0")]
		internal static IEnumerable<MethodInfo> KICMLDHPOCH(PCHEJJBEMBB FPGGHBIMBBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CD90", Offset = "0x5E6B790", VA = "0x185E6CD90")]
		internal static void NJAAOANHKCJ(IEnumerable<MethodInfo> FJLJICCCFMA, Type KLFKBHEDPEL, [Optional] object[] BOJHHCEEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D2B0", Offset = "0x5E6BCB0", VA = "0x185E6D2B0")]
		private static Dictionary<PCHEJJBEMBB, IGrouping<PCHEJJBEMBB, MethodInfo>> NOLAIEOCKEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CB90", Offset = "0x5E6B590", VA = "0x185E6CB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E6C0C0", Offset = "0x5E6AAC0", VA = "0x185E6C0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E6DBC0", Offset = "0x5E6C5C0", VA = "0x185E6DBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E6ABC0", Offset = "0x5E695C0", VA = "0x185E6ABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BHJKECHLECD BBLLBJNOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BC90", Offset = "0x5E6A690", VA = "0x185E6BC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static BHJKECHLECD GJLIEHEFCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BCD0", Offset = "0x5E6A6D0", VA = "0x185E6BCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB10", Offset = "0x5E69510", VA = "0x185E6AB10")]
	[GOHLDELPFPM]
	private static void LGKODDLJGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BE80", Offset = "0x5E6A880", VA = "0x185E6BE80")]
	[DDPIKLHKBPE(PCHEJJBEMBB.Unity_AfterAssembliesLoaded)]
	private static void PBHDGFCKIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B1C0", Offset = "0x5E69BC0", VA = "0x185E6B1C0")]
	public static BHJKECHLECD GBJPJHBPKFG(DIKIGLGFNNP HBADOCMFBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B080", Offset = "0x5E69A80", VA = "0x185E6B080")]
	private static void GBJPJHBPKFG(DIKIGLGFNNP HBADOCMFBJB, BHJKECHLECD FAHHHGHBKDP, BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AC90", Offset = "0x5E69690", VA = "0x185E6AC90")]
	private static void GBJPJHBPKFG(DIKIGLGFNNP HBADOCMFBJB, BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B5D0", Offset = "0x5E69FD0", VA = "0x185E6B5D0")]
	public static void HFAGFGKHMDK(DIKIGLGFNNP HBADOCMFBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21F51B0", Offset = "0x21F3BB0", VA = "0x1821F51B0")]
	private static bool FFMINOBGBHD(OJLOCLENGNC OCEOFPMEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BD10", Offset = "0x5E6A710", VA = "0x185E6BD10")]
	private static BHJKECHLECD MHNOGNEFBJC(string OIAOGLNNKIH, [Optional] BHJKECHLECD FAHHHGHBKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B400", Offset = "0x5E69E00", VA = "0x185E6B400")]
	private static void HFAGFGKHMDK(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB10", Offset = "0x5E69510", VA = "0x185E6AB10")]
	private static void DPJHCOCDHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B6F0", Offset = "0x5E6A0F0", VA = "0x185E6B6F0")]
	private static IEnumerable<OEAEBMBABFH> IIBFBAPIBIB(DIKIGLGFNNP HBADOCMFBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AA50", Offset = "0x5E69450", VA = "0x185E6AA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DA9140", Offset = "0x3DA7B40", VA = "0x183DA9140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected MJLCEJODJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3DA9100", Offset = "0x3DA7B00", VA = "0x183DA9100", Slot = "5")]
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
