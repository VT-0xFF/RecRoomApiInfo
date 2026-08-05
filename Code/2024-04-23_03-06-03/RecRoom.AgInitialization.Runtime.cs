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
		private sealed class MLCDBHNLFMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public MLCDBHNLFMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6148F10", Offset = "0x6147F10", VA = "0x186148F10")]
			internal IEnumerable<MethodInfo> AJEMNCLGCNE(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6148FD0", Offset = "0x6147FD0", VA = "0x186148FD0")]
			internal bool FHFJMGEDJOF(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class KKLLJGFLMGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public KKLLJGFLMGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6148EB0", Offset = "0x6147EB0", VA = "0x186148EB0")]
			internal bool CKHLIHLMCKH(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class DEDCLEOINIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public DEDCLEOINIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6148E60", Offset = "0x6147E60", VA = "0x186148E60")]
			internal bool IIMCBIEGJEI(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<CDBPKHMDHEP, IGrouping<CDBPKHMDHEP, MethodInfo>> IFCDEEKDHGO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type FMELFGBMNII;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x614AFB0", Offset = "0x6149FB0", VA = "0x18614AFB0")]
		private static void DMBAOIKPAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x614BE10", Offset = "0x614AE10", VA = "0x18614BE10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x614AC90", Offset = "0x6149C90", VA = "0x18614AC90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x614AD80", Offset = "0x6149D80", VA = "0x18614AD80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x614AD30", Offset = "0x6149D30", VA = "0x18614AD30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x614ACE0", Offset = "0x6149CE0", VA = "0x18614ACE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x614ADD0", Offset = "0x6149DD0", VA = "0x18614ADD0")]
		private static void DBHPLHBDBBC(CDBPKHMDHEP EFLMBMDAGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x614BD80", Offset = "0x614AD80", VA = "0x18614BD80")]
		private static IEnumerable<MethodInfo> NBIAPJMPGHN(Type JKCODFNDKIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x614AE90", Offset = "0x6149E90", VA = "0x18614AE90")]
		private static bool DEEHAGCDFIJ(string FPLMDJJNJHL, [Out] Dictionary<string, List<string>> CKDEDKKDBID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x614A570", Offset = "0x6149570", VA = "0x18614A570")]
		private static IEnumerable<Type> AJELHOOAKLA(Dictionary<string, List<string>> CKDEDKKDBID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x614B520", Offset = "0x614A520", VA = "0x18614B520")]
		private static IEnumerable<MethodInfo> KMFKPMAKCNJ(IEnumerable<Type> MOKPJAIHOEE, Type JKCODFNDKIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x614B7C0", Offset = "0x614A7C0", VA = "0x18614B7C0")]
		internal static IEnumerable<MethodInfo> MLDKFDKEFLD(CDBPKHMDHEP EFLMBMDAGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x614B850", Offset = "0x614A850", VA = "0x18614B850")]
		internal static void MPJNHCAKCPF(IEnumerable<MethodInfo> EKIOBGEAIGD, Type CIGBCMGNBKB, [Optional] object[] FBCKOOIGNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x614B600", Offset = "0x614A600", VA = "0x18614B600")]
		private static Dictionary<CDBPKHMDHEP, IGrouping<CDBPKHMDHEP, MethodInfo>> MFDLCJFDDNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x614B6A0", Offset = "0x614A6A0", VA = "0x18614B6A0")]
		private static bool MFFBCGOGKOD(MethodInfo EGNLFADIFFG, Type DBEBEGBMMIP, bool NGJINDNNJKA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CEDKGCEFHII
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> JDIDEMNKHIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> PECEACPKDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6148DA0", Offset = "0x6147DA0", VA = "0x186148DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x614BF70", Offset = "0x614AF70", VA = "0x18614BF70")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OOHJABCDNOC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct NCJADJOKKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo OHDCHHHCLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public DIDBPCEENMM HPGJMEPIDGP;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<ENLFMENACGP, List<NCJADJOKKBA>> KBGDNBJBPBI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static OIEDECFCIPC FLKDFIOIOFO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OIEDECFCIPC POPCCIIKOJC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static OIEDECFCIPC BOPDHOHNDGD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OIEDECFCIPC NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61490F0", Offset = "0x61480F0", VA = "0x1861490F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OIEDECFCIPC PFJJDJLJHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61491C0", Offset = "0x61481C0", VA = "0x1861491C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OIEDECFCIPC PFMPIFACGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x614A460", Offset = "0x6149460", VA = "0x18614A460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool ACHJJCOKPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x614A420", Offset = "0x6149420", VA = "0x18614A420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x614A370", Offset = "0x6149370", VA = "0x18614A370")]
	[EEOALAIEBHP]
	private static void NEDCLNBHMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x614A4A0", Offset = "0x61494A0", VA = "0x18614A4A0")]
	[JONKOHOJNNC(CDBPKHMDHEP.Unity_AfterAssembliesLoaded)]
	private static void PCPOKCNCOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6149200", Offset = "0x6148200", VA = "0x186149200")]
	public static OIEDECFCIPC DEAFLAPCPMC(ENLFMENACGP LPGBKAPDFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6149830", Offset = "0x6148830", VA = "0x186149830")]
	private static void DEAFLAPCPMC(ENLFMENACGP LPGBKAPDFFL, OIEDECFCIPC NNLLFEJPNEF, OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6149440", Offset = "0x6148440", VA = "0x186149440")]
	private static void DEAFLAPCPMC(ENLFMENACGP LPGBKAPDFFL, OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x614A250", Offset = "0x6149250", VA = "0x18614A250")]
	public static void JGCNMAKJMLF(ENLFMENACGP LPGBKAPDFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23AF1F0", Offset = "0x23AE1F0", VA = "0x1823AF1F0")]
	private static bool DJEFECNFFMO(DIDBPCEENMM NHAHBPAICKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6149F10", Offset = "0x6148F10", VA = "0x186149F10")]
	private static OIEDECFCIPC HGCMGNLJNNA(string ANJJMFGOLFO, [Optional] OIEDECFCIPC NNLLFEJPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x614A080", Offset = "0x6149080", VA = "0x18614A080")]
	private static void JGCNMAKJMLF(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x614A370", Offset = "0x6149370", VA = "0x18614A370")]
	private static void LHDPFBDNAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6149970", Offset = "0x6148970", VA = "0x186149970")]
	private static IEnumerable<NCJADJOKKBA> FPBCEAGMCBA(ENLFMENACGP LPGBKAPDFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6149030", Offset = "0x6148030", VA = "0x186149030")]
	private static OIEDECFCIPC ABNLLGNFDFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PMNLAPOIHKG<T> : IDisposable where T : PMNLAPOIHKG<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T ILCIGJJMCEH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T AFPJCELPLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x429AB00", Offset = "0x4299B00", VA = "0x18429AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected PMNLAPOIHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x429ADC0", Offset = "0x4299DC0", VA = "0x18429ADC0", Slot = "5")]
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
