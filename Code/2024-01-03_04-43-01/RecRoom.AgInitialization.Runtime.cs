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
		private sealed class PECFOEPPCDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public PECFOEPPCDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5D0F480", Offset = "0x5D0E080", VA = "0x185D0F480")]
			internal IEnumerable<MethodInfo> OCJDBAHILDA(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5D0F540", Offset = "0x5D0E140", VA = "0x185D0F540")]
			internal bool PMIKMMAFEDP(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BMPPLDJPKIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public BMPPLDJPKIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5D0DE10", Offset = "0x5D0CA10", VA = "0x185D0DE10")]
			internal bool PENGCJKOIMD(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FLGOAGKPAJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public FLGOAGKPAJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5D0F430", Offset = "0x5D0E030", VA = "0x185D0F430")]
			internal bool LGKLCHMMJJN(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<IOENMJMEHBM, IGrouping<IOENMJMEHBM, MethodInfo>> PLKMCPGHPAG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type NKEHDMAMMHE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D108B0", Offset = "0x5D0F4B0", VA = "0x185D108B0")]
		private static void OCCHCPKPOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D10E20", Offset = "0x5D0FA20", VA = "0x185D10E20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FAC0", Offset = "0x5D0E6C0", VA = "0x185D0FAC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FBB0", Offset = "0x5D0E7B0", VA = "0x185D0FBB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FB60", Offset = "0x5D0E760", VA = "0x185D0FB60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FB10", Offset = "0x5D0E710", VA = "0x185D0FB10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D103B0", Offset = "0x5D0EFB0", VA = "0x185D103B0")]
		private static void IJMDEOPBIGF(IOENMJMEHBM CFJHJJFBGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D10500", Offset = "0x5D0F100", VA = "0x185D10500")]
		private static IEnumerable<MethodInfo> KNPDNLIOHHH(Type IGBNFDGBKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D10590", Offset = "0x5D0F190", VA = "0x185D10590")]
		private static bool LHIKALMJCOD(string DILAEIJIPLF, [Out] Dictionary<string, List<string>> BJHCPJOJKCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FC00", Offset = "0x5D0E800", VA = "0x185D0FC00")]
		private static IEnumerable<Type> CNKMLLIAGIC(Dictionary<string, List<string>> BJHCPJOJKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D107D0", Offset = "0x5D0F3D0", VA = "0x185D107D0")]
		private static IEnumerable<MethodInfo> MCFCLFBILFD(IEnumerable<Type> MAKCJNFJGFC, Type IGBNFDGBKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D10470", Offset = "0x5D0F070", VA = "0x185D10470")]
		internal static IEnumerable<MethodInfo> JGIJOMMEBMK(IOENMJMEHBM CFJHJJFBGKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F5A0", Offset = "0x5D0E1A0", VA = "0x185D0F5A0")]
		internal static void AGHKPHHHIOA(IEnumerable<MethodInfo> IOEMGGCGGLH, Type EAGGAAPEGMJ, [Optional] object[] OCFPIAIMFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D10310", Offset = "0x5D0EF10", VA = "0x185D10310")]
		private static Dictionary<IOENMJMEHBM, IGrouping<IOENMJMEHBM, MethodInfo>> DBIJHAPCHEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D106B0", Offset = "0x5D0F2B0", VA = "0x185D106B0")]
		private static bool MCCKIHMLEDH(MethodInfo AEELPNCBMPD, Type GAFCDBEBDJA, bool MGGPCIGNNAO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DFLIJFHPINM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> PLNGAOKHDDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> PDPGFDMOINI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DE70", Offset = "0x5D0CA70", VA = "0x185D0DE70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D10F80", Offset = "0x5D0FB80", VA = "0x185D10F80")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EKDHJFAHPIM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct GCPBJKANCGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo HFNKPLFDGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CDPNEOMLNDL EADDGEIDEGF;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<MGPIABHDDAF, List<GCPBJKANCGF>> OMLEOCKHIPB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static OKOCNPPIKGG EAAHBMOPGHH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OKOCNPPIKGG JFGLGJNPJPJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static OKOCNPPIKGG AHHANGAGKNK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OKOCNPPIKGG EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DF30", Offset = "0x5D0CB30", VA = "0x185D0DF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OKOCNPPIKGG AENBKPMBIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E000", Offset = "0x5D0CC00", VA = "0x185D0E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OKOCNPPIKGG FBLBCHLDEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EE50", Offset = "0x5D0DA50", VA = "0x185D0EE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E870", Offset = "0x5D0D470", VA = "0x185D0E870")]
	[DAABEDBJNNM]
	private static void IPNHMLHIACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EC10", Offset = "0x5D0D810", VA = "0x185D0EC10")]
	[DGIJNOPMGJE(IOENMJMEHBM.Unity_AfterAssembliesLoaded)]
	private static void LGPDANDILHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E040", Offset = "0x5D0CC40", VA = "0x185D0E040")]
	public static OKOCNPPIKGG FCJGKIDNHAE(MGPIABHDDAF FMPGCLHCGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E280", Offset = "0x5D0CE80", VA = "0x185D0E280")]
	private static void FCJGKIDNHAE(MGPIABHDDAF FMPGCLHCGFJ, OKOCNPPIKGG LCEIFJPLPAL, OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E3C0", Offset = "0x5D0CFC0", VA = "0x185D0E3C0")]
	private static void FCJGKIDNHAE(MGPIABHDDAF FMPGCLHCGFJ, OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EAF0", Offset = "0x5D0D6F0", VA = "0x185D0EAF0")]
	public static void KLGMOEDCACM(MGPIABHDDAF FMPGCLHCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D290B0", Offset = "0x3D27CB0", VA = "0x183D290B0")]
	private static bool DKJINLKADOA(CDPNEOMLNDL LHFBONCKPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D0ECE0", Offset = "0x5D0D8E0", VA = "0x185D0ECE0")]
	private static OKOCNPPIKGG LMAKPKLLHID(string MFHNOLPBNAK, [Optional] OKOCNPPIKGG LCEIFJPLPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E920", Offset = "0x5D0D520", VA = "0x185D0E920")]
	private static void KLGMOEDCACM(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E870", Offset = "0x5D0D470", VA = "0x185D0E870")]
	private static void GHKBIJPOKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EE90", Offset = "0x5D0DA90", VA = "0x185D0EE90")]
	private static IEnumerable<GCPBJKANCGF> NPLHENKBLIG(MGPIABHDDAF FMPGCLHCGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E7B0", Offset = "0x5D0D3B0", VA = "0x185D0E7B0")]
	private static OKOCNPPIKGG GHEGGEKGHCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ALPCJODCABC<T> : IDisposable where T : ALPCJODCABC<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T BJMIJNLECJK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T IDAIJJLMAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x371D630", Offset = "0x371C230", VA = "0x18371D630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected ALPCJODCABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x371D5F0", Offset = "0x371C1F0", VA = "0x18371D5F0", Slot = "5")]
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
