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
			[Cpp2IlInjected.Address(RVA = "0x5D0F3F0", Offset = "0x5D0DFF0", VA = "0x185D0F3F0")]
			internal IEnumerable<MethodInfo> OCJDBAHILDA(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5D0F4B0", Offset = "0x5D0E0B0", VA = "0x185D0F4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D0DD80", Offset = "0x5D0C980", VA = "0x185D0DD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D0F3A0", Offset = "0x5D0DFA0", VA = "0x185D0F3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D10820", Offset = "0x5D0F420", VA = "0x185D10820")]
		private static void OCCHCPKPOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D10D90", Offset = "0x5D0F990", VA = "0x185D10D90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FA30", Offset = "0x5D0E630", VA = "0x185D0FA30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FB20", Offset = "0x5D0E720", VA = "0x185D0FB20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FAD0", Offset = "0x5D0E6D0", VA = "0x185D0FAD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FA80", Offset = "0x5D0E680", VA = "0x185D0FA80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D10320", Offset = "0x5D0EF20", VA = "0x185D10320")]
		private static void IJMDEOPBIGF(IOENMJMEHBM CFJHJJFBGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D10470", Offset = "0x5D0F070", VA = "0x185D10470")]
		private static IEnumerable<MethodInfo> KNPDNLIOHHH(Type IGBNFDGBKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D10500", Offset = "0x5D0F100", VA = "0x185D10500")]
		private static bool LHIKALMJCOD(string DILAEIJIPLF, [Out] Dictionary<string, List<string>> BJHCPJOJKCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0FB70", Offset = "0x5D0E770", VA = "0x185D0FB70")]
		private static IEnumerable<Type> CNKMLLIAGIC(Dictionary<string, List<string>> BJHCPJOJKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D10740", Offset = "0x5D0F340", VA = "0x185D10740")]
		private static IEnumerable<MethodInfo> MCFCLFBILFD(IEnumerable<Type> MAKCJNFJGFC, Type IGBNFDGBKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D103E0", Offset = "0x5D0EFE0", VA = "0x185D103E0")]
		internal static IEnumerable<MethodInfo> JGIJOMMEBMK(IOENMJMEHBM CFJHJJFBGKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F510", Offset = "0x5D0E110", VA = "0x185D0F510")]
		internal static void AGHKPHHHIOA(IEnumerable<MethodInfo> IOEMGGCGGLH, Type EAGGAAPEGMJ, [Optional] object[] OCFPIAIMFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D10280", Offset = "0x5D0EE80", VA = "0x185D10280")]
		private static Dictionary<IOENMJMEHBM, IGrouping<IOENMJMEHBM, MethodInfo>> DBIJHAPCHEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D10620", Offset = "0x5D0F220", VA = "0x185D10620")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0DDE0", Offset = "0x5D0C9E0", VA = "0x185D0DDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D10EF0", Offset = "0x5D0FAF0", VA = "0x185D10EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0DEA0", Offset = "0x5D0CAA0", VA = "0x185D0DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OKOCNPPIKGG AENBKPMBIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DF70", Offset = "0x5D0CB70", VA = "0x185D0DF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OKOCNPPIKGG FBLBCHLDEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EDC0", Offset = "0x5D0D9C0", VA = "0x185D0EDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E7E0", Offset = "0x5D0D3E0", VA = "0x185D0E7E0")]
	[DAABEDBJNNM]
	private static void IPNHMLHIACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EB80", Offset = "0x5D0D780", VA = "0x185D0EB80")]
	[DGIJNOPMGJE(IOENMJMEHBM.Unity_AfterAssembliesLoaded)]
	private static void LGPDANDILHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DFB0", Offset = "0x5D0CBB0", VA = "0x185D0DFB0")]
	public static OKOCNPPIKGG FCJGKIDNHAE(MGPIABHDDAF FMPGCLHCGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E1F0", Offset = "0x5D0CDF0", VA = "0x185D0E1F0")]
	private static void FCJGKIDNHAE(MGPIABHDDAF FMPGCLHCGFJ, OKOCNPPIKGG LCEIFJPLPAL, OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E330", Offset = "0x5D0CF30", VA = "0x185D0E330")]
	private static void FCJGKIDNHAE(MGPIABHDDAF FMPGCLHCGFJ, OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EA60", Offset = "0x5D0D660", VA = "0x185D0EA60")]
	public static void KLGMOEDCACM(MGPIABHDDAF FMPGCLHCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D29020", Offset = "0x3D27C20", VA = "0x183D29020")]
	private static bool DKJINLKADOA(CDPNEOMLNDL LHFBONCKPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EC50", Offset = "0x5D0D850", VA = "0x185D0EC50")]
	private static OKOCNPPIKGG LMAKPKLLHID(string MFHNOLPBNAK, [Optional] OKOCNPPIKGG LCEIFJPLPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E890", Offset = "0x5D0D490", VA = "0x185D0E890")]
	private static void KLGMOEDCACM(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E7E0", Offset = "0x5D0D3E0", VA = "0x185D0E7E0")]
	private static void GHKBIJPOKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EE00", Offset = "0x5D0DA00", VA = "0x185D0EE00")]
	private static IEnumerable<GCPBJKANCGF> NPLHENKBLIG(MGPIABHDDAF FMPGCLHCGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E720", Offset = "0x5D0D320", VA = "0x185D0E720")]
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
		[Cpp2IlInjected.Address(RVA = "0x371D5A0", Offset = "0x371C1A0", VA = "0x18371D5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x371D560", Offset = "0x371C160", VA = "0x18371D560", Slot = "5")]
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
