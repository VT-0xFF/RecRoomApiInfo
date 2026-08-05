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
		private sealed class CBBPLBGEKGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public CBBPLBGEKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x61BB630", Offset = "0x61BA030", VA = "0x1861BB630")]
			internal IEnumerable<MethodInfo> CMLGJJAEELC(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x61BB6F0", Offset = "0x61BA0F0", VA = "0x1861BB6F0")]
			internal bool PMLAKPEIEEM(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CGPBAKJDDKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public CGPBAKJDDKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x61BB750", Offset = "0x61BA150", VA = "0x1861BB750")]
			internal bool NNPPJKDPHGF(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class OFCCDACLCBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public OFCCDACLCBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x61BCDB0", Offset = "0x61BB7B0", VA = "0x1861BCDB0")]
			internal bool IMOFNHFDKNL(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<HAIMIFDEJBI, IGrouping<HAIMIFDEJBI, MethodInfo>> BHFMMBJCJDI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type HNIDBHLCBHL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x61BD500", Offset = "0x61BBF00", VA = "0x1861BD500")]
		private static void GPABONMOFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61BE690", Offset = "0x61BD090", VA = "0x1861BE690")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61BCE00", Offset = "0x61BB800", VA = "0x1861BCE00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61BCEF0", Offset = "0x61BB8F0", VA = "0x1861BCEF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61BCEA0", Offset = "0x61BB8A0", VA = "0x1861BCEA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61BCE50", Offset = "0x61BB850", VA = "0x1861BCE50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61BDA70", Offset = "0x61BC470", VA = "0x1861BDA70")]
		private static void HMDKBFDIIEG(HAIMIFDEJBI BHFHGECMJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61BD470", Offset = "0x61BBE70", VA = "0x1861BD470")]
		private static IEnumerable<MethodInfo> GHJMHCDKLLN(Type PCLMPBNAFKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61BE570", Offset = "0x61BCF70", VA = "0x1861BE570")]
		private static bool PDLOCCNIPIO(string ACJJDLDBCJN, [Out] Dictionary<string, List<string>> PFDMNCPJJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61BDC50", Offset = "0x61BC650", VA = "0x1861BDC50")]
		private static IEnumerable<Type> OACPEKGBAIH(Dictionary<string, List<string>> PFDMNCPJJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61BE490", Offset = "0x61BCE90", VA = "0x1861BE490")]
		private static IEnumerable<MethodInfo> OOAMHJPELMP(IEnumerable<Type> EIDHNKEHKMD, Type PCLMPBNAFKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61BE360", Offset = "0x61BCD60", VA = "0x1861BE360")]
		internal static IEnumerable<MethodInfo> OEEJPBMKHBL(HAIMIFDEJBI BHFHGECMJJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61BCF40", Offset = "0x61BB940", VA = "0x1861BCF40")]
		internal static void FJPHEFBEGHO(IEnumerable<MethodInfo> JPKFFCLDCII, Type GGECKEDEMGA, [Optional] object[] BJIJPHEEEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61BE3F0", Offset = "0x61BCDF0", VA = "0x1861BE3F0")]
		private static Dictionary<HAIMIFDEJBI, IGrouping<HAIMIFDEJBI, MethodInfo>> OHOKLOOLMJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61BDB30", Offset = "0x61BC530", VA = "0x1861BDB30")]
		private static bool JMOOBODCAEO(MethodInfo MAOOCEKJFEA, Type CDLAKJEIHLE, bool BODGODPEPOM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CPFJIFGLMBE
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> DAAHEFCDEBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> FDLAADCLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x61BB7B0", Offset = "0x61BA1B0", VA = "0x1861BB7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x61BE7F0", Offset = "0x61BD1F0", VA = "0x1861BE7F0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MNJADGMLOLL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct NPCBEDEDGHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo LNBEFBPIONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AOHDMBIABEL JCOONMJGFHO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<EEKBGOJGGBC, List<NPCBEDEDGHF>> DCNFIHIFEMJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static ICKBMMGCCPN PBCEMGGJPCL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static ICKBMMGCCPN PKKPHBHMKMC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static ICKBMMGCCPN HDGFEFNCDMI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ICKBMMGCCPN PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61BC480", Offset = "0x61BAE80", VA = "0x1861BC480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ICKBMMGCCPN HBENIJJNNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61BC140", Offset = "0x61BAB40", VA = "0x1861BC140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static ICKBMMGCCPN PCDOLHEIAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61BC100", Offset = "0x61BAB00", VA = "0x1861BC100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool EODGHMIAOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61BC550", Offset = "0x61BAF50", VA = "0x1861BC550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61BC590", Offset = "0x61BAF90", VA = "0x1861BC590")]
	[OFLPAPKPLDL]
	private static void MKPNEDHKJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61BC3B0", Offset = "0x61BADB0", VA = "0x1861BC3B0")]
	[APKIKNFAKCC(HAIMIFDEJBI.Unity_AfterAssembliesLoaded)]
	private static void IGELLGIGMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61BC640", Offset = "0x61BB040", VA = "0x1861BC640")]
	public static ICKBMMGCCPN NFJDAGLMGKJ(EEKBGOJGGBC KBAHOBJMEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61BCC70", Offset = "0x61BB670", VA = "0x1861BCC70")]
	private static void NFJDAGLMGKJ(EEKBGOJGGBC KBAHOBJMEEB, ICKBMMGCCPN BILADBMKLJB, ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61BC880", Offset = "0x61BB280", VA = "0x1861BC880")]
	private static void NFJDAGLMGKJ(EEKBGOJGGBC KBAHOBJMEEB, ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61BBA40", Offset = "0x61BA440", VA = "0x1861BBA40")]
	public static void BPDBCGCLPAN(EEKBGOJGGBC KBAHOBJMEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23EAD70", Offset = "0x23E9770", VA = "0x1823EAD70")]
	private static bool BMIOIEJIBPJ(AOHDMBIABEL CBOFEHMGPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61BC180", Offset = "0x61BAB80", VA = "0x1861BC180")]
	private static ICKBMMGCCPN GIHKNFHGDOJ(string FNAFFGHHLJE, [Optional] ICKBMMGCCPN BILADBMKLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61BB870", Offset = "0x61BA270", VA = "0x1861BB870")]
	private static void BPDBCGCLPAN(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61BC590", Offset = "0x61BAF90", VA = "0x1861BC590")]
	private static void OMFKJKMAIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61BBB60", Offset = "0x61BA560", VA = "0x1861BBB60")]
	private static IEnumerable<NPCBEDEDGHF> CJCNGBKEPHG(EEKBGOJGGBC KBAHOBJMEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61BC2F0", Offset = "0x61BACF0", VA = "0x1861BC2F0")]
	private static ICKBMMGCCPN HPIAKIPPAGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IDOPKLPMEIJ<T> : IDisposable where T : IDOPKLPMEIJ<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T CCFMNFKDGPF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T AINFBDJPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9910", Offset = "0x3AA8310", VA = "0x183AA9910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected IDOPKLPMEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3AA98D0", Offset = "0x3AA82D0", VA = "0x183AA98D0", Slot = "5")]
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
