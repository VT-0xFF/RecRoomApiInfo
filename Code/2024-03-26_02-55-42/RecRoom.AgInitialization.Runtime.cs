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
		private sealed class BGCDBFJLGFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public BGCDBFJLGFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x605A160", Offset = "0x6059560", VA = "0x18605A160")]
			internal IEnumerable<MethodInfo> KINHBCNOHHB(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x605A100", Offset = "0x6059500", VA = "0x18605A100")]
			internal bool JGMCGGFFDGE(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class LJDPKHOHDOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public LJDPKHOHDOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x605B720", Offset = "0x605AB20", VA = "0x18605B720")]
			internal bool KPFGLBPICFF(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class LPDLCBHFBIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public LPDLCBHFBIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x605B780", Offset = "0x605AB80", VA = "0x18605B780")]
			internal bool LDNNIIPHMAB(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<BCAGKJLFEFM, IGrouping<BCAGKJLFEFM, MethodInfo>> FOCPBGMBBFI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type PJBADPDPFPP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x605BF90", Offset = "0x605B390", VA = "0x18605BF90")]
		private static void CCDCBFDCHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x605D110", Offset = "0x605C510", VA = "0x18605D110")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x605B930", Offset = "0x605AD30", VA = "0x18605B930")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x605BF40", Offset = "0x605B340", VA = "0x18605BF40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x605BEF0", Offset = "0x605B2F0", VA = "0x18605BEF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x605B980", Offset = "0x605AD80", VA = "0x18605B980")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x605CE10", Offset = "0x605C210", VA = "0x18605CE10")]
		private static void MGMBAOIAGBD(BCAGKJLFEFM HPGJEDBDFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x605C5E0", Offset = "0x605B9E0", VA = "0x18605C5E0")]
		private static IEnumerable<MethodInfo> DMNLBLJEHAF(Type JPOMFEMFGMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x605CFF0", Offset = "0x605C3F0", VA = "0x18605CFF0")]
		private static bool OPLAKDBPKBF(string NNNIBCOAFKD, [Out] Dictionary<string, List<string>> AIHCLMGECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x605C700", Offset = "0x605BB00", VA = "0x18605C700")]
		private static IEnumerable<Type> LMANELJAIFC(Dictionary<string, List<string>> AIHCLMGECEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x605C500", Offset = "0x605B900", VA = "0x18605C500")]
		private static IEnumerable<MethodInfo> DDMGOCMBDFM(IEnumerable<Type> LHBKDAFFEBF, Type JPOMFEMFGMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x605C670", Offset = "0x605BA70", VA = "0x18605C670")]
		internal static IEnumerable<MethodInfo> GAHBFDANCKH(BCAGKJLFEFM HPGJEDBDFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x605B9D0", Offset = "0x605ADD0", VA = "0x18605B9D0")]
		internal static void BFAKLBOOIFI(IEnumerable<MethodInfo> ILFHECGIHKG, Type NHDFLIDEGBF, [Optional] object[] PJAECDPFFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x605B890", Offset = "0x605AC90", VA = "0x18605B890")]
		private static Dictionary<BCAGKJLFEFM, IGrouping<BCAGKJLFEFM, MethodInfo>> ABKHFCGBCDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x605CED0", Offset = "0x605C2D0", VA = "0x18605CED0")]
		private static bool ODLGGPNEGNE(MethodInfo HIPMGPBBMLF, Type GFBPKGNNJBK, bool KGBAKGHBAJP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NBECAPPENDN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> LHHMGFPEAPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> CKLEHAKAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x605B7D0", Offset = "0x605ABD0", VA = "0x18605B7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x605D270", Offset = "0x605C670", VA = "0x18605D270")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KOIBBGGAPKM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PODPJIBKILL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo EOKKDMHOFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public HENHDGEOMOC IEIFGCNPBFA;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<FDMHFCDINAO, List<PODPJIBKILL>> PKNMJKDNJOK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static BNDLKDEPBDF DIHKGIGIBIK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BNDLKDEPBDF HNADCFJEAEJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static BNDLKDEPBDF IPOBMCJDPEO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BNDLKDEPBDF DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x605B650", Offset = "0x605AA50", VA = "0x18605B650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BNDLKDEPBDF GNLOLNLKLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x605B540", Offset = "0x605A940", VA = "0x18605B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static BNDLKDEPBDF HLGGFNHIOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x605B500", Offset = "0x605A900", VA = "0x18605B500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x605AB70", Offset = "0x6059F70", VA = "0x18605AB70")]
	[LLOMJDEPCBK]
	private static void FAPNBLADFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x605B580", Offset = "0x605A980", VA = "0x18605B580")]
	[MPOHMOIKDIC(BCAGKJLFEFM.Unity_AfterAssembliesLoaded)]
	private static void PFAOJCDDINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x605B010", Offset = "0x605A410", VA = "0x18605B010")]
	public static BNDLKDEPBDF FOPCOLNJLNF(FDMHFCDINAO GJDONIDEPKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x605B250", Offset = "0x605A650", VA = "0x18605B250")]
	private static void FOPCOLNJLNF(FDMHFCDINAO GJDONIDEPKC, BNDLKDEPBDF PGBANCNKIFL, BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x605AC20", Offset = "0x605A020", VA = "0x18605AC20")]
	private static void FOPCOLNJLNF(FDMHFCDINAO GJDONIDEPKC, BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x605A3F0", Offset = "0x60597F0", VA = "0x18605A3F0")]
	public static void ABKJDMPFLME(FDMHFCDINAO GJDONIDEPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x22B1000", Offset = "0x22B0400", VA = "0x1822B1000")]
	private static bool GLPMBCOBNDB(HENHDGEOMOC COHAEJKOELL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x605B390", Offset = "0x605A790", VA = "0x18605B390")]
	private static BNDLKDEPBDF GDAHDFMENAM(string KMFBPHLCABB, [Optional] BNDLKDEPBDF PGBANCNKIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x605A220", Offset = "0x6059620", VA = "0x18605A220")]
	private static void ABKJDMPFLME(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x605AB70", Offset = "0x6059F70", VA = "0x18605AB70")]
	private static void PGPFBEAPMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x605A5D0", Offset = "0x60599D0", VA = "0x18605A5D0")]
	private static IEnumerable<PODPJIBKILL> FAKJLMPPPBI(FDMHFCDINAO GJDONIDEPKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x605A510", Offset = "0x6059910", VA = "0x18605A510")]
	private static BNDLKDEPBDF CJEHFDEFPPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NGGCKBOMOOC<T> : IDisposable where T : NGGCKBOMOOC<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T DLKEBALDMPC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3FACF70", Offset = "0x3FAC370", VA = "0x183FACF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected NGGCKBOMOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3FACF30", Offset = "0x3FAC330", VA = "0x183FACF30", Slot = "5")]
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
