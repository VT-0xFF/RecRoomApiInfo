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
		private sealed class JMIJJNJADHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public JMIJJNJADHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67E4190", Offset = "0x67E3190", VA = "0x1867E4190")]
			internal IEnumerable<MethodInfo> HEHIEACAHKE(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67E4250", Offset = "0x67E3250", VA = "0x1867E4250")]
			internal bool KOCEOKINNCB(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class MPOHMDKFFBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public MPOHMDKFFBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67E4370", Offset = "0x67E3370", VA = "0x1867E4370")]
			internal bool EOLAIHHNLKI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class AFMNBAJMOCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public AFMNBAJMOCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67E2C00", Offset = "0x67E1C00", VA = "0x1867E2C00")]
			internal bool HFGEILGOKDL(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<LONMDOPJFCD, IGrouping<LONMDOPJFCD, MethodInfo>> JDPBPNKALGN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type NNLKCBHCKPP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67E55B0", Offset = "0x67E45B0", VA = "0x1867E55B0")]
		private static void MPAPCLCHPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67E5C50", Offset = "0x67E4C50", VA = "0x1867E5C50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67E43D0", Offset = "0x67E33D0", VA = "0x1867E43D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67E44C0", Offset = "0x67E34C0", VA = "0x1867E44C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67E4470", Offset = "0x67E3470", VA = "0x1867E4470")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67E4420", Offset = "0x67E3420", VA = "0x1867E4420")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67E4C20", Offset = "0x67E3C20", VA = "0x1867E4C20")]
		private static void FFGLOIOLBJD(LONMDOPJFCD CNMGPMNNAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67E5BC0", Offset = "0x67E4BC0", VA = "0x1867E5BC0")]
		private static IEnumerable<MethodInfo> PPGLCGKFBCF(Type AOPENDJMMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67E4CE0", Offset = "0x67E3CE0", VA = "0x1867E4CE0")]
		private static bool GHLMKOHCNLH(string IALENCLHHBM, [Out] Dictionary<string, List<string>> LGJDLGDGDEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67E4510", Offset = "0x67E3510", VA = "0x1867E4510")]
		private static IEnumerable<Type> DHDELKHCDOD(Dictionary<string, List<string>> LGJDLGDGDEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67E5320", Offset = "0x67E4320", VA = "0x1867E5320")]
		private static IEnumerable<MethodInfo> HINGLHIGDPH(IEnumerable<Type> KDDDEHNDNIG, Type AOPENDJMMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67E5520", Offset = "0x67E4520", VA = "0x1867E5520")]
		internal static IEnumerable<MethodInfo> IHOCDDADBGB(LONMDOPJFCD CNMGPMNNAPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67E4E00", Offset = "0x67E3E00", VA = "0x1867E4E00")]
		internal static void HHEEMHLDFKA(IEnumerable<MethodInfo> DFFGIMEPJOD, Type EDIADHMNBEF, [Optional] object[] LIIDINHCICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67E5B20", Offset = "0x67E4B20", VA = "0x1867E5B20")]
		private static Dictionary<LONMDOPJFCD, IGrouping<LONMDOPJFCD, MethodInfo>> NMDPFJAJOCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67E5400", Offset = "0x67E4400", VA = "0x1867E5400")]
		private static bool ICNICBNEGCD(MethodInfo IGHHGENEOAB, Type OGAHOBINIDP, bool MEGGKIHOJKL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KDHIPIPOCJJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> LLEOEOEOAIJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> FDKHCCHHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67E42B0", Offset = "0x67E32B0", VA = "0x1867E42B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E5DB0", Offset = "0x67E4DB0", VA = "0x1867E5DB0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JGLJFPGMKPO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct HJODJDANPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo IJBKACAJOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BOIKMOKIOJG BHMFMGCEIBP;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<HCAAGBIMBOB, List<HJODJDANPDP>> ELHKIDKIJGI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static DIIANKCHAHD ICFIABIMINL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DIIANKCHAHD AECOAAKFNBM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static DIIANKCHAHD LAAOJEKBMBK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DIIANKCHAHD JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67E3430", Offset = "0x67E2430", VA = "0x1867E3430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DIIANKCHAHD PPHMFMJJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67E3E20", Offset = "0x67E2E20", VA = "0x1867E3E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DIIANKCHAHD PFKNNFNKMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67E3C70", Offset = "0x67E2C70", VA = "0x1867E3C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PDHBBKAPJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67E4150", Offset = "0x67E3150", VA = "0x1867E4150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67E31F0", Offset = "0x67E21F0", VA = "0x1867E31F0")]
	[EEALECDGIFD]
	private static void BNAHLFHBLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67E32A0", Offset = "0x67E22A0", VA = "0x1867E32A0")]
	[JCLEFGKHEPL(LONMDOPJFCD.Unity_AfterAssembliesLoaded)]
	private static void EGFJGAIFBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67E38F0", Offset = "0x67E28F0", VA = "0x1867E38F0")]
	public static DIIANKCHAHD HMOHIEPLGCA(HCAAGBIMBOB ODIBOOMLDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67E3B30", Offset = "0x67E2B30", VA = "0x1867E3B30")]
	private static void HMOHIEPLGCA(HCAAGBIMBOB ODIBOOMLDNB, DIIANKCHAHD HPJLCLBLBCC, DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67E3500", Offset = "0x67E2500", VA = "0x1867E3500")]
	private static void HMOHIEPLGCA(HCAAGBIMBOB ODIBOOMLDNB, DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67E3E60", Offset = "0x67E2E60", VA = "0x1867E3E60")]
	public static void MEJKJIENBNI(HCAAGBIMBOB ODIBOOMLDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2571D00", Offset = "0x2570D00", VA = "0x182571D00")]
	private static bool FHEJNMGODIK(BOIKMOKIOJG KOCLEKCECHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67E3CB0", Offset = "0x67E2CB0", VA = "0x1867E3CB0")]
	private static DIIANKCHAHD JHKCKAIEKBM(string BDIPNKNBNCJ, [Optional] DIIANKCHAHD HPJLCLBLBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67E3F80", Offset = "0x67E2F80", VA = "0x1867E3F80")]
	private static void MEJKJIENBNI(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67E31F0", Offset = "0x67E21F0", VA = "0x1867E31F0")]
	private static void KFICIBBKCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67E2C50", Offset = "0x67E1C50", VA = "0x1867E2C50")]
	private static IEnumerable<HJODJDANPDP> BGPDOHLCJEF(HCAAGBIMBOB ODIBOOMLDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67E3370", Offset = "0x67E2370", VA = "0x1867E3370")]
	private static DIIANKCHAHD FPGBCDOJKDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MJIACEAGNAM<T> : IDisposable where T : MJIACEAGNAM<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T MGNNEDNHDBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x44F54B0", Offset = "0x44F44B0", VA = "0x1844F54B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	protected MJIACEAGNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44F5470", Offset = "0x44F4470", VA = "0x1844F5470", Slot = "5")]
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
