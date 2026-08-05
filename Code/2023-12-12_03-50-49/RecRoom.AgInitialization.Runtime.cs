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
		private sealed class JMHMGIHDFEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public JMHMGIHDFEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5D0C380", Offset = "0x5D0AB80", VA = "0x185D0C380")]
			internal IEnumerable<MethodInfo> CACKPEEBOHK(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5D0C440", Offset = "0x5D0AC40", VA = "0x185D0C440")]
			internal bool FCJBNPNLBDP(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class PNHNGIHDOCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public PNHNGIHDOCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5D0D9A0", Offset = "0x5D0C1A0", VA = "0x185D0D9A0")]
			internal bool OECCHBENPFD(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JMGGEEOFOJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public JMGGEEOFOJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5D0C330", Offset = "0x5D0AB30", VA = "0x185D0C330")]
			internal bool PAFOLCEKBGH(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<BIHOHBMMECD, IGrouping<BIHOHBMMECD, MethodInfo>> KKODMACNPDF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type HHIEFDDHGCA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DE10", Offset = "0x5D0C610", VA = "0x185D0DE10")]
		private static void IADOBKNJPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F280", Offset = "0x5D0DA80", VA = "0x185D0F280")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DAE0", Offset = "0x5D0C2E0", VA = "0x185D0DAE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DBD0", Offset = "0x5D0C3D0", VA = "0x185D0DBD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DB80", Offset = "0x5D0C380", VA = "0x185D0DB80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DB30", Offset = "0x5D0C330", VA = "0x185D0DB30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DD50", Offset = "0x5D0C550", VA = "0x185D0DD50")]
		private static void FFLDKJBGHFP(BIHOHBMMECD NPFOADCKBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E9C0", Offset = "0x5D0D1C0", VA = "0x185D0E9C0")]
		private static IEnumerable<MethodInfo> JMKJPDAPEKJ(Type CCNNKKJKPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EA50", Offset = "0x5D0D250", VA = "0x185D0EA50")]
		private static bool NHAJCCMCDJL(string EHNEENPMEKE, [Out] Dictionary<string, List<string>> MKLPDNKAALB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D0EB70", Offset = "0x5D0D370", VA = "0x185D0EB70")]
		private static IEnumerable<Type> NIDKFBJLGLD(Dictionary<string, List<string>> MKLPDNKAALB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DA00", Offset = "0x5D0C200", VA = "0x185D0DA00")]
		private static IEnumerable<MethodInfo> AMFHPCKHIEK(IEnumerable<Type> KDMJPDFGHPA, Type CCNNKKJKPJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DCC0", Offset = "0x5D0C4C0", VA = "0x185D0DCC0")]
		internal static IEnumerable<MethodInfo> FCPDKKIOIKA(BIHOHBMMECD NPFOADCKBKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E4A0", Offset = "0x5D0CCA0", VA = "0x185D0E4A0")]
		internal static void JAPFMMIOFDM(IEnumerable<MethodInfo> CBAJEHBLJEC, Type FDNEFDGFBJA, [Optional] object[] ICGNFMFDOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D0DC20", Offset = "0x5D0C420", VA = "0x185D0DC20")]
		private static Dictionary<BIHOHBMMECD, IGrouping<BIHOHBMMECD, MethodInfo>> ELMCKJIMPJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E380", Offset = "0x5D0CB80", VA = "0x185D0E380")]
		private static bool IGIBAMOLFOH(MethodInfo COFHIDPLIJI, Type DNKPGPFKELD, bool KBMFMKMCGKM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DLNLDICJOBH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> JKJKAMNACAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> JLDODOMJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C270", Offset = "0x5D0AA70", VA = "0x185D0C270")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0F3E0", Offset = "0x5D0DBE0", VA = "0x185D0F3E0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NJMGLCNIEHF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EBINJNLOHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo COOOMEHFIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FICJCHGEBPC AKDGDLJDIMD;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<JJAMOFEKMEH, List<EBINJNLOHJL>> PGBLIDIBJOE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static PHIPPCBHDOE FHGEBDDDAFP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static PHIPPCBHDOE CENLHIMAPEL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static PHIPPCBHDOE KIODKDLNPCG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PHIPPCBHDOE NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D430", Offset = "0x5D0BC30", VA = "0x185D0D430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PHIPPCBHDOE BDCDMJFGHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D500", Offset = "0x5D0BD00", VA = "0x185D0D500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static PHIPPCBHDOE EBCCELADKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C550", Offset = "0x5D0AD50", VA = "0x185D0C550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C4A0", Offset = "0x5D0ACA0", VA = "0x185D0C4A0")]
	[ADKBCGBADCN]
	private static void AIJHEFDPKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D360", Offset = "0x5D0BB60", VA = "0x185D0D360")]
	[LCKMJKIGHKB(BIHOHBMMECD.Unity_AfterAssembliesLoaded)]
	private static void JMBPLPCIFMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CFE0", Offset = "0x5D0B7E0", VA = "0x185D0CFE0")]
	public static PHIPPCBHDOE FKKLLCNNBKG(JJAMOFEKMEH ALHFPIOCMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D220", Offset = "0x5D0BA20", VA = "0x185D0D220")]
	private static void FKKLLCNNBKG(JJAMOFEKMEH ALHFPIOCMFF, PHIPPCBHDOE JPFLHFFBHBM, PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CBF0", Offset = "0x5D0B3F0", VA = "0x185D0CBF0")]
	private static void FKKLLCNNBKG(JJAMOFEKMEH ALHFPIOCMFF, PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D6B0", Offset = "0x5D0BEB0", VA = "0x185D0D6B0")]
	public static void NMDOJNNDHCF(JJAMOFEKMEH ALHFPIOCMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3458830", Offset = "0x3457030", VA = "0x183458830")]
	private static bool NDHEEHBHBAF(FICJCHGEBPC OKOKMGDNFEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D540", Offset = "0x5D0BD40", VA = "0x185D0D540")]
	private static PHIPPCBHDOE MFMBEEMNPGH(string DMLFLMHKPIJ, [Optional] PHIPPCBHDOE JPFLHFFBHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D7D0", Offset = "0x5D0BFD0", VA = "0x185D0D7D0")]
	private static void NMDOJNNDHCF(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C4A0", Offset = "0x5D0ACA0", VA = "0x185D0C4A0")]
	private static void AICJBKBDOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C590", Offset = "0x5D0AD90", VA = "0x185D0C590")]
	private static IEnumerable<EBINJNLOHJL> CGDCGGHJAHO(JJAMOFEKMEH ALHFPIOCMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CB30", Offset = "0x5D0B330", VA = "0x185D0CB30")]
	private static PHIPPCBHDOE ENHDGFDJIKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MDIAECAPNDD<T> : IDisposable where T : MDIAECAPNDD<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T PIOFGCGEFCD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T ODCBNHJKAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C47810", Offset = "0x3C46010", VA = "0x183C47810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected MDIAECAPNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C47AD0", Offset = "0x3C462D0", VA = "0x183C47AD0", Slot = "5")]
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
