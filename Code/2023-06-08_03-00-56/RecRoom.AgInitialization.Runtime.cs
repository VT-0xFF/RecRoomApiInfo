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
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x18C37A0", Offset = "0x18C25A0", VA = "0x1818C37A0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BOECIHFGFCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public BOECIHFGFCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18C03B0", Offset = "0x18BF1B0", VA = "0x1818C03B0")]
			internal IEnumerable<MethodInfo> BMPAJOFHNBA(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x18C0480", Offset = "0x18BF280", VA = "0x1818C0480")]
			internal bool FIIECPEFPJJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JPJMNNCBDBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public JPJMNNCBDBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x18C1B60", Offset = "0x18C0960", VA = "0x1818C1B60")]
			internal bool LMCJDIMJNPG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class DPJLPDFCGCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public DPJLPDFCGCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x18C04F0", Offset = "0x18BF2F0", VA = "0x1818C04F0")]
			internal bool LMCJHIOHAOP(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string IIOAPPBIEIB = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string NIDAGOEOLIO = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<AFFOKNEDPGH, IGrouping<AFFOKNEDPGH, MethodInfo>> CDCOEFNLPDK;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type LNEDLOMOBGB;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x18C2800", Offset = "0x18C1600", VA = "0x1818C2800")]
		private static void OJONLNOCJIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x18C3630", Offset = "0x18C2430", VA = "0x1818C3630")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x18C1BD0", Offset = "0x18C09D0", VA = "0x1818C1BD0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x18C1CC0", Offset = "0x18C0AC0", VA = "0x1818C1CC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x18C1C70", Offset = "0x18C0A70", VA = "0x1818C1C70")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18C1C20", Offset = "0x18C0A20", VA = "0x1818C1C20")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x18C1FA0", Offset = "0x18C0DA0", VA = "0x1818C1FA0")]
		private static void FENKDJDABOA(AFFOKNEDPGH KDMEPPHLNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x18C3570", Offset = "0x18C2370", VA = "0x1818C3570")]
		private static IEnumerable<MethodInfo> OPEMLAHMKJN(Type MKGAIJKKGCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x18C2580", Offset = "0x18C1380", VA = "0x1818C2580")]
		private static bool HGGHBFKNKPM(string BAKJBDELAFK, out Dictionary<string, List<string>> LDEMGJMMGIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x18C2DF0", Offset = "0x18C1BF0", VA = "0x1818C2DF0")]
		private static IEnumerable<Type> ONBJFGPPOFJ(Dictionary<string, List<string>> LDEMGJMMGIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x18C1EC0", Offset = "0x18C0CC0", VA = "0x1818C1EC0")]
		private static IEnumerable<MethodInfo> EFAOFMHAPHM(IEnumerable<Type> MECLDLOMGDJ, Type MKGAIJKKGCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x18C1E30", Offset = "0x18C0C30", VA = "0x1818C1E30")]
		internal static IEnumerable<MethodInfo> DCANBDCAHFP(AFFOKNEDPGH KDMEPPHLNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x18C2070", Offset = "0x18C0E70", VA = "0x1818C2070")]
		internal static void FHEMFIIMLNL(IEnumerable<MethodInfo> HBODIIBPMOB, Type FGMKNDBEEKM, [Optional] object[] FBDHILNJDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x18C2740", Offset = "0x18C1540", VA = "0x1818C2740")]
		private static Dictionary<AFFOKNEDPGH, IGrouping<AFFOKNEDPGH, MethodInfo>> LGFLFNGELDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x18C1D10", Offset = "0x18C0B10", VA = "0x1818C1D10")]
		private static bool CPFKMBJHJBF(MethodInfo GBFGCJHDOFN, Type GHBGPMONHNO, bool LBFPKFIGMBA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FBFCMBAOCHM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct EOKHLMENKKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo PDMDEFBMHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PFHGMCKNAFN JAFOPMOJIOA;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<EMJNPDDLMAF, List<EOKHLMENKKM>> DGFOKKNCACI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OBEPLHILJNL KIFEBGNLKGN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static OBEPLHILJNL NBFCOHJOBOJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static OBEPLHILJNL IEBDOBNHOPB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OBEPLHILJNL EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x18C1080", Offset = "0x18BFE80", VA = "0x1818C1080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OBEPLHILJNL HCHBEHLLAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x18C0F50", Offset = "0x18BFD50", VA = "0x1818C0F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OBEPLHILJNL KFOAAPEBLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18C1A70", Offset = "0x18C0870", VA = "0x1818C1A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x18C1AB0", Offset = "0x18C08B0", VA = "0x1818C1AB0")]
	[JGALCKPLNMN]
	private static void PADBBIOLEFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x18C0F90", Offset = "0x18BFD90", VA = "0x1818C0F90")]
	[FEBAOGJMMKM(AFFOKNEDPGH.Unity_AfterAssembliesLoaded)]
	private static void GHBCFJLBLIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x18C1170", Offset = "0x18BFF70", VA = "0x1818C1170")]
	public static OBEPLHILJNL IEJMLKJFAMM(EMJNPDDLMAF DIMGCJACFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x18C1800", Offset = "0x18C0600", VA = "0x1818C1800")]
	private static void IEJMLKJFAMM(EMJNPDDLMAF DIMGCJACFHK, OBEPLHILJNL FMAOLKGCDLE, ref OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18C13C0", Offset = "0x18C01C0", VA = "0x1818C13C0")]
	private static void IEJMLKJFAMM(EMJNPDDLMAF DIMGCJACFHK, OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x18C0C50", Offset = "0x18BFA50", VA = "0x1818C0C50")]
	public static void DOBKAKGFAPG(EMJNPDDLMAF DIMGCJACFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x18C1990", Offset = "0x18C0790", VA = "0x1818C1990")]
	private static bool MAMEPOGFFNJ(PFHGMCKNAFN NABKNCMANOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x18C0540", Offset = "0x18BF340", VA = "0x1818C0540")]
	private static OBEPLHILJNL BCPJCINMMOF(string MKKMLJHFPAA, [Optional] OBEPLHILJNL FMAOLKGCDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x18C0D60", Offset = "0x18BFB60", VA = "0x1818C0D60")]
	private static void DOBKAKGFAPG(ref OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x18C1AB0", Offset = "0x18C08B0", VA = "0x1818C1AB0")]
	private static void OGPOABBKAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x18C06C0", Offset = "0x18BF4C0", VA = "0x1818C06C0")]
	private static IEnumerable<EOKHLMENKKM> BMEOKCAEEJO(EMJNPDDLMAF DIMGCJACFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x18C1080", Offset = "0x18BFE80", VA = "0x1818C1080")]
	private static OBEPLHILJNL OIEPJFCMLLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MLFIJLADFNN<T> : IDisposable where T : MLFIJLADFNN<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T EJBAOAKFGMC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T LNABDBHCENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x36127D0", Offset = "0x36115D0", VA = "0x1836127D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
	protected MLFIJLADFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3612790", Offset = "0x3611590", VA = "0x183612790", Slot = "5")]
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
