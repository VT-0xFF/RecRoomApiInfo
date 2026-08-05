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
		private sealed class ADKABJIGKDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public ADKABJIGKDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x69BAD80", Offset = "0x69BA180", VA = "0x1869BAD80")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69BAE50", Offset = "0x69BA250", VA = "0x1869BAE50")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BHPMBGHNJFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public BHPMBGHNJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x69BAEC0", Offset = "0x69BA2C0", VA = "0x1869BAEC0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KJGKHIFDEFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public KJGKHIFDEFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69BC650", Offset = "0x69BBA50", VA = "0x1869BC650")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string COGICBELLON = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string HFLLGOFADFC = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<BAHKGFILFFP, IGrouping<BAHKGFILFFP, MethodInfo>> KEFJMCOLMFE;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type HGCFABHHMNK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69BC7E0", Offset = "0x69BBBE0", VA = "0x1869BC7E0")]
		private static void DFMJMCHLIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69BE100", Offset = "0x69BD500", VA = "0x1869BE100")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69BC6A0", Offset = "0x69BBAA0", VA = "0x1869BC6A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69BC790", Offset = "0x69BBB90", VA = "0x1869BC790")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69BC740", Offset = "0x69BBB40", VA = "0x1869BC740")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69BC6F0", Offset = "0x69BBAF0", VA = "0x1869BC6F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69BDF50", Offset = "0x69BD350", VA = "0x1869BDF50")]
		private static void PCHLJFIBPKO(BAHKGFILFFP PDCDBLMJOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69BCE90", Offset = "0x69BC290", VA = "0x1869BCE90")]
		private static IEnumerable<MethodInfo> FMLDBNDJDCB(Type FPDCPEHOLLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69BD880", Offset = "0x69BCC80", VA = "0x1869BD880")]
		private static bool JIJKLKHBDLE(string EONJLFKAPKG, out Dictionary<string, List<string>> AAIIPLCELHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69BD100", Offset = "0x69BC500", VA = "0x1869BD100")]
		private static IEnumerable<Type> IJAIJGJCGJO(Dictionary<string, List<string>> AAIIPLCELHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69BE020", Offset = "0x69BD420", VA = "0x1869BE020")]
		private static IEnumerable<MethodInfo> PIJHEAHIKCB(IEnumerable<Type> OFGCLOACCDN, Type FPDCPEHOLLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69BCF50", Offset = "0x69BC350", VA = "0x1869BCF50")]
		internal static IEnumerable<MethodInfo> FPPHOHIDAGL(BAHKGFILFFP PDCDBLMJOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69BDA40", Offset = "0x69BCE40", VA = "0x1869BDA40")]
		internal static void NKCGBIPLIGG(IEnumerable<MethodInfo> JOEJGOEBMOG, Type NHCMIDLJAIE, [Optional] object[] BHGFJLDJJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69BCDD0", Offset = "0x69BC1D0", VA = "0x1869BCDD0")]
		private static Dictionary<BAHKGFILFFP, IGrouping<BAHKGFILFFP, MethodInfo>> EPKHGHCJNMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69BCFE0", Offset = "0x69BC3E0", VA = "0x1869BCFE0")]
		private static bool GJELOHPFLJM(MethodInfo EIPDGEHJIMJ, Type HHJOOLAJIID, bool JCGNIENIAFC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69BE270", Offset = "0x69BD670", VA = "0x1869BE270")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ILIPGJAEFBH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct OAKNAMDBJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo LOGHEHHCJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GHILFLKBMBN JOKCBJALNCF;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<JMBPMAGFLED, List<OAKNAMDBJJA>> FJFDDJLDKLG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static AOONKACGDKK PGBBHMMBPLO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static AOONKACGDKK JHECPHIDKEI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AOONKACGDKK FCOLMAPPEAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AOONKACGDKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69BB250", Offset = "0x69BA650", VA = "0x1869BB250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AOONKACGDKK JBODINJNCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69BB340", Offset = "0x69BA740", VA = "0x1869BB340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AOONKACGDKK MLIMPCGENLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69BB460", Offset = "0x69BA860", VA = "0x1869BB460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69BAF30", Offset = "0x69BA330", VA = "0x1869BAF30")]
	[FHKIMKMNPFP]
	private static void HGKNDKJOILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69BBA30", Offset = "0x69BAE30", VA = "0x1869BBA30")]
	[DKOCLKLDKBJ(BAHKGFILFFP.Unity_AfterAssembliesLoaded)]
	private static void FPOPGLDFDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69BC410", Offset = "0x69BB810", VA = "0x1869BC410")]
	public static AOONKACGDKK LJMEEDAIOHE(JMBPMAGFLED MCPBHLPAFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69BBE40", Offset = "0x69BB240", VA = "0x1869BBE40")]
	private static void LJMEEDAIOHE(JMBPMAGFLED MCPBHLPAFGP, AOONKACGDKK IAAJAFHICGC, ref AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69BBFD0", Offset = "0x69BB3D0", VA = "0x1869BBFD0")]
	private static void LJMEEDAIOHE(JMBPMAGFLED MCPBHLPAFGP, AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69BBB20", Offset = "0x69BAF20", VA = "0x1869BBB20")]
	public static void JIHJGLFLGDJ(JMBPMAGFLED MCPBHLPAFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69BB380", Offset = "0x69BA780", VA = "0x1869BB380")]
	private static bool EAFNGPMKNMN(GHILFLKBMBN DNBBJGKAGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69BB0D0", Offset = "0x69BA4D0", VA = "0x1869BB0D0")]
	private static AOONKACGDKK CIPMNLGHOOM(string DLHDIKGEIFJ, [Optional] AOONKACGDKK IAAJAFHICGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69BBC30", Offset = "0x69BB030", VA = "0x1869BBC30")]
	private static void JIHJGLFLGDJ(ref AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69BAF30", Offset = "0x69BA330", VA = "0x1869BAF30")]
	private static void BHAEDPFBFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69BB4A0", Offset = "0x69BA8A0", VA = "0x1869BB4A0")]
	private static IEnumerable<OAKNAMDBJJA> FKAHLCJDNGC(JMBPMAGFLED MCPBHLPAFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69BAFE0", Offset = "0x69BA3E0", VA = "0x1869BAFE0")]
	private static AOONKACGDKK CHMPIIEGHOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LLCJBHJOIDP<T> : IDisposable where T : global::LLCJBHJOIDP<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T MLLKBCFLFJE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T AGBLMGNNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AB50", Offset = "0x1F89F50", VA = "0x181F8AB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
	protected LLCJBHJOIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F8ADE0", Offset = "0x1F8A1E0", VA = "0x181F8ADE0", Slot = "5")]
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
