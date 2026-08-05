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
		private sealed class JIOGKDKMFBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public JIOGKDKMFBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6A9FE30", Offset = "0x6A9E830", VA = "0x186A9FE30")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6A9FF00", Offset = "0x6A9E900", VA = "0x186A9FF00")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class OBNFAFDPAME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public OBNFAFDPAME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6A9FF70", Offset = "0x6A9E970", VA = "0x186A9FF70")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JIIFHBNILEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public JIIFHBNILEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A9FDE0", Offset = "0x6A9E7E0", VA = "0x186A9FDE0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string CPBNMNHHPNM = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string ACCBCIPLFAA = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<BMBGADEKIAB, IGrouping<BMBGADEKIAB, MethodInfo>> HNKDHPIHHIA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type IFHLHGABAOP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0470", Offset = "0x6A9EE70", VA = "0x186AA0470")]
		private static void FNDFBCJGKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1A40", Offset = "0x6AA0440", VA = "0x186AA1A40")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AA00C0", Offset = "0x6A9EAC0", VA = "0x186AA00C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AA01B0", Offset = "0x6A9EBB0", VA = "0x186AA01B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0160", Offset = "0x6A9EB60", VA = "0x186AA0160")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0110", Offset = "0x6A9EB10", VA = "0x186AA0110")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AA17B0", Offset = "0x6AA01B0", VA = "0x186AA17B0")]
		private static void NKMAJKADIGM(BMBGADEKIAB LKMBMKFJAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0290", Offset = "0x6A9EC90", VA = "0x186AA0290")]
		private static IEnumerable<MethodInfo> EFDGFIFICGO(Type GCPGHHMOFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1880", Offset = "0x6AA0280", VA = "0x186AA1880")]
		private static bool PAPMFKDIMCI(string BHGLNGNDDKA, out Dictionary<string, List<string>> FKLFIMFGOBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1030", Offset = "0x6A9FA30", VA = "0x186AA1030")]
		private static IEnumerable<Type> IEOFNDLLDGI(Dictionary<string, List<string>> FKLFIMFGOBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FFE0", Offset = "0x6A9E9E0", VA = "0x186A9FFE0")]
		private static IEnumerable<MethodInfo> ADDIFCKJJAE(IEnumerable<Type> AEENEACHPOE, Type GCPGHHMOFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0200", Offset = "0x6A9EC00", VA = "0x186AA0200")]
		internal static IEnumerable<MethodInfo> DFKEDNMANLC(BMBGADEKIAB LKMBMKFJAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0A60", Offset = "0x6A9F460", VA = "0x186AA0A60")]
		internal static void GENFPNKIFMD(IEnumerable<MethodInfo> LKDIAFHELPC, Type EMCKONAKOGC, [Optional] object[] PJBJFAJEGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0F70", Offset = "0x6A9F970", VA = "0x186AA0F70")]
		private static Dictionary<BMBGADEKIAB, IGrouping<BMBGADEKIAB, MethodInfo>> IAJFNNJCBIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0350", Offset = "0x6A9ED50", VA = "0x186AA0350")]
		private static bool FFCMEOADJOI(MethodInfo NMJIOPMCLCI, Type DIBGDAIFCMM, bool GAKELJJCJOO)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1BB0", Offset = "0x6AA05B0", VA = "0x186AA1BB0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IMIMOKMAOMK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct ALDPNHPGGLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo GIHPAFGIHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JDACKNHLALI JLBBGNKJBMF;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<JLEIDHHFJDB, List<ALDPNHPGGLJ>> AIBFBAHBBDK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DPALDOJEBJE MOJPGDJFGIB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static DPALDOJEBJE GENOLAHFGKG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static DPALDOJEBJE IDMBFKJICCK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DPALDOJEBJE ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FA80", Offset = "0x6A9E480", VA = "0x186A9FA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DPALDOJEBJE EONJDHLOJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EF70", Offset = "0x6A9D970", VA = "0x186A9EF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DPALDOJEBJE LKLEKFIINEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F960", Offset = "0x6A9E360", VA = "0x186A9F960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F8B0", Offset = "0x6A9E2B0", VA = "0x186A9F8B0")]
	[ONDDBLHHBEF]
	private static void JCHBJCKPLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FCF0", Offset = "0x6A9E6F0", VA = "0x186A9FCF0")]
	[ILPAJAIEFEA(BMBGADEKIAB.Unity_AfterAssembliesLoaded)]
	private static void HJGFDENPDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F0A0", Offset = "0x6A9DAA0", VA = "0x186A9F0A0")]
	public static DPALDOJEBJE EPHDDGKKADP(JLEIDHHFJDB KIDKECADOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F720", Offset = "0x6A9E120", VA = "0x186A9F720")]
	private static void EPHDDGKKADP(JLEIDHHFJDB KIDKECADOFL, DPALDOJEBJE OCHECCCIFGK, ref DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F2E0", Offset = "0x6A9DCE0", VA = "0x186A9F2E0")]
	private static void EPHDDGKKADP(JLEIDHHFJDB KIDKECADOFL, DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E8D0", Offset = "0x6A9D2D0", VA = "0x186A9E8D0")]
	public static void BPNODNGCBFP(JLEIDHHFJDB KIDKECADOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F9A0", Offset = "0x6A9E3A0", VA = "0x186A9F9A0")]
	private static bool GMGFHFPNNPG(JDACKNHLALI EHKFALKLJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FB70", Offset = "0x6A9E570", VA = "0x186A9FB70")]
	private static DPALDOJEBJE HGCGALMGNBK(string HFHMFHFFCPO, [Optional] DPALDOJEBJE OCHECCCIFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E6C0", Offset = "0x6A9D0C0", VA = "0x186A9E6C0")]
	private static void BPNODNGCBFP(ref DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F8B0", Offset = "0x6A9E2B0", VA = "0x186A9F8B0")]
	private static void FDAJEEGOBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E9E0", Offset = "0x6A9D3E0", VA = "0x186A9E9E0")]
	private static IEnumerable<ALDPNHPGGLJ> DAJLOJJMNGC(JLEIDHHFJDB KIDKECADOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EFB0", Offset = "0x6A9D9B0", VA = "0x186A9EFB0")]
	private static DPALDOJEBJE EBPGINIJEPF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MAJDOCMEMED<T> : IDisposable where T : global::MAJDOCMEMED<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T JCJDNADEMKM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T FINLHCLDLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4677D30", Offset = "0x4676730", VA = "0x184677D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
	protected MAJDOCMEMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4677CF0", Offset = "0x46766F0", VA = "0x184677CF0", Slot = "5")]
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
