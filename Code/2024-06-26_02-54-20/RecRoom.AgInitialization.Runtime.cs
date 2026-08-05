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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public JMIJJNJADHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67B4530", Offset = "0x67B2B30", VA = "0x1867B4530")]
			internal IEnumerable<MethodInfo> HEHIEACAHKE(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67B45F0", Offset = "0x67B2BF0", VA = "0x1867B45F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public MPOHMDKFFBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67B4710", Offset = "0x67B2D10", VA = "0x1867B4710")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public AFMNBAJMOCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67B2FA0", Offset = "0x67B15A0", VA = "0x1867B2FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B5950", Offset = "0x67B3F50", VA = "0x1867B5950")]
		private static void MPAPCLCHPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67B5FF0", Offset = "0x67B45F0", VA = "0x1867B5FF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67B4770", Offset = "0x67B2D70", VA = "0x1867B4770")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67B4860", Offset = "0x67B2E60", VA = "0x1867B4860")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67B4810", Offset = "0x67B2E10", VA = "0x1867B4810")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67B47C0", Offset = "0x67B2DC0", VA = "0x1867B47C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67B4FC0", Offset = "0x67B35C0", VA = "0x1867B4FC0")]
		private static void FFGLOIOLBJD(LONMDOPJFCD CNMGPMNNAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67B5F60", Offset = "0x67B4560", VA = "0x1867B5F60")]
		private static IEnumerable<MethodInfo> PPGLCGKFBCF(Type AOPENDJMMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67B5080", Offset = "0x67B3680", VA = "0x1867B5080")]
		private static bool GHLMKOHCNLH(string IALENCLHHBM, [Out] Dictionary<string, List<string>> LGJDLGDGDEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67B48B0", Offset = "0x67B2EB0", VA = "0x1867B48B0")]
		private static IEnumerable<Type> DHDELKHCDOD(Dictionary<string, List<string>> LGJDLGDGDEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67B56C0", Offset = "0x67B3CC0", VA = "0x1867B56C0")]
		private static IEnumerable<MethodInfo> HINGLHIGDPH(IEnumerable<Type> KDDDEHNDNIG, Type AOPENDJMMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67B58C0", Offset = "0x67B3EC0", VA = "0x1867B58C0")]
		internal static IEnumerable<MethodInfo> IHOCDDADBGB(LONMDOPJFCD CNMGPMNNAPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67B51A0", Offset = "0x67B37A0", VA = "0x1867B51A0")]
		internal static void HHEEMHLDFKA(IEnumerable<MethodInfo> DFFGIMEPJOD, Type EDIADHMNBEF, [Optional] object[] LIIDINHCICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67B5EC0", Offset = "0x67B44C0", VA = "0x1867B5EC0")]
		private static Dictionary<LONMDOPJFCD, IGrouping<LONMDOPJFCD, MethodInfo>> NMDPFJAJOCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67B57A0", Offset = "0x67B3DA0", VA = "0x1867B57A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B4650", Offset = "0x67B2C50", VA = "0x1867B4650")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B6150", Offset = "0x67B4750", VA = "0x1867B6150")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B37D0", Offset = "0x67B1DD0", VA = "0x1867B37D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DIIANKCHAHD PPHMFMJJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67B41C0", Offset = "0x67B27C0", VA = "0x1867B41C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DIIANKCHAHD PFKNNFNKMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67B4010", Offset = "0x67B2610", VA = "0x1867B4010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PDHBBKAPJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67B44F0", Offset = "0x67B2AF0", VA = "0x1867B44F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67B3590", Offset = "0x67B1B90", VA = "0x1867B3590")]
	[EEALECDGIFD]
	private static void BNAHLFHBLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67B3640", Offset = "0x67B1C40", VA = "0x1867B3640")]
	[JCLEFGKHEPL(LONMDOPJFCD.Unity_AfterAssembliesLoaded)]
	private static void EGFJGAIFBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67B3C90", Offset = "0x67B2290", VA = "0x1867B3C90")]
	public static DIIANKCHAHD HMOHIEPLGCA(HCAAGBIMBOB ODIBOOMLDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67B3ED0", Offset = "0x67B24D0", VA = "0x1867B3ED0")]
	private static void HMOHIEPLGCA(HCAAGBIMBOB ODIBOOMLDNB, DIIANKCHAHD HPJLCLBLBCC, DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67B38A0", Offset = "0x67B1EA0", VA = "0x1867B38A0")]
	private static void HMOHIEPLGCA(HCAAGBIMBOB ODIBOOMLDNB, DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67B4200", Offset = "0x67B2800", VA = "0x1867B4200")]
	public static void MEJKJIENBNI(HCAAGBIMBOB ODIBOOMLDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25630F0", Offset = "0x25616F0", VA = "0x1825630F0")]
	private static bool FHEJNMGODIK(BOIKMOKIOJG KOCLEKCECHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67B4050", Offset = "0x67B2650", VA = "0x1867B4050")]
	private static DIIANKCHAHD JHKCKAIEKBM(string BDIPNKNBNCJ, [Optional] DIIANKCHAHD HPJLCLBLBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67B4320", Offset = "0x67B2920", VA = "0x1867B4320")]
	private static void MEJKJIENBNI(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67B3590", Offset = "0x67B1B90", VA = "0x1867B3590")]
	private static void KFICIBBKCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67B2FF0", Offset = "0x67B15F0", VA = "0x1867B2FF0")]
	private static IEnumerable<HJODJDANPDP> BGPDOHLCJEF(HCAAGBIMBOB ODIBOOMLDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67B3710", Offset = "0x67B1D10", VA = "0x1867B3710")]
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
		[Cpp2IlInjected.Address(RVA = "0x44D4E70", Offset = "0x44D3470", VA = "0x1844D4E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected MJIACEAGNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44D4E30", Offset = "0x44D3430", VA = "0x1844D4E30", Slot = "5")]
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
