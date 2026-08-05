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
		private sealed class JCLICBCDNGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public JCLICBCDNGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5FD0C70", Offset = "0x5FCFE70", VA = "0x185FD0C70")]
			internal IEnumerable<MethodInfo> GEDOALLOADC(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5FD0C10", Offset = "0x5FCFE10", VA = "0x185FD0C10")]
			internal bool EPCHBNBIBHO(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class ADDPBNKKHBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public ADDPBNKKHBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5FCF640", Offset = "0x5FCE840", VA = "0x185FCF640")]
			internal bool GNJIOOGEIEA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CMIBNPGOGEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public CMIBNPGOGEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5FCF6A0", Offset = "0x5FCE8A0", VA = "0x185FCF6A0")]
			internal bool GKHCFLHEJOJ(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<NNKJNJFOFID, IGrouping<NNKJNJFOFID, MethodInfo>> FBICDHHIFNB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type KJEOILDEANG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0F90", Offset = "0x5FD0190", VA = "0x185FD0F90")]
		private static void DAACODMFDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2570", Offset = "0x5FD1770", VA = "0x185FD2570")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0D30", Offset = "0x5FCFF30", VA = "0x185FD0D30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0F40", Offset = "0x5FD0140", VA = "0x185FD0F40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0EF0", Offset = "0x5FD00F0", VA = "0x185FD0EF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0D80", Offset = "0x5FCFF80", VA = "0x185FD0D80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FD24B0", Offset = "0x5FD16B0", VA = "0x185FD24B0")]
		private static void PEPIHEJAJAM(NNKJNJFOFID KFAPLMPGCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FD15B0", Offset = "0x5FD07B0", VA = "0x185FD15B0")]
		private static IEnumerable<MethodInfo> FDMEEHOONBK(Type NGHFDJCOLBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0DD0", Offset = "0x5FCFFD0", VA = "0x185FD0DD0")]
		private static bool BGKABOFAEAD(string MDOFPIINHAP, [Out] Dictionary<string, List<string>> AFDAEDCOOPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD16D0", Offset = "0x5FD08D0", VA = "0x185FD16D0")]
		private static IEnumerable<Type> GFHEJMKKDEG(Dictionary<string, List<string>> AFDAEDCOOPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD14D0", Offset = "0x5FD06D0", VA = "0x185FD14D0")]
		private static IEnumerable<MethodInfo> DDGCGIJOBIG(IEnumerable<Type> FDFJAMKKLLE, Type NGHFDJCOLBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1640", Offset = "0x5FD0840", VA = "0x185FD1640")]
		internal static IEnumerable<MethodInfo> FFNMMHCMEFD(NNKJNJFOFID KFAPLMPGCKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1DE0", Offset = "0x5FD0FE0", VA = "0x185FD1DE0")]
		internal static void GGEKBMOMCMO(IEnumerable<MethodInfo> KGHLKGABKME, Type IDPBFEOLEFO, [Optional] object[] GLKCCNFHICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2300", Offset = "0x5FD1500", VA = "0x185FD2300")]
		private static Dictionary<NNKJNJFOFID, IGrouping<NNKJNJFOFID, MethodInfo>> OAOMGMGDEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2390", Offset = "0x5FD1590", VA = "0x185FD2390")]
		private static bool OHPBJKEJCIB(MethodInfo BIGFJMCEMCB, Type HAKEPHABHDM, bool IHEOIENNKJE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HEFDKLEFJDN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> IPFHECAFGDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> NOOHJBDPBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF6F0", Offset = "0x5FCE8F0", VA = "0x185FCF6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FD26C0", Offset = "0x5FD18C0", VA = "0x185FD26C0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HNMPAMEEMBD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IMHDIPGOPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo CCJENAFGEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CIJFMPALMOO CLBPAFAIFDO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<AILNDCKFLHJ, List<IMHDIPGOPIF>> JECOBHCLDMA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static JGBEMAKPOMJ KOEDOIBLIEJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static JGBEMAKPOMJ NEHIICBEKPN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static JGBEMAKPOMJ KBHGMLOBJBP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JGBEMAKPOMJ NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF9F0", Offset = "0x5FCEBF0", VA = "0x185FCF9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JGBEMAKPOMJ FHFJMCAFCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0BD0", Offset = "0x5FCFDD0", VA = "0x185FD0BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JGBEMAKPOMJ IAMPNIFGLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFB50", Offset = "0x5FCED50", VA = "0x185FCFB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFAB0", Offset = "0x5FCECB0", VA = "0x185FCFAB0")]
	[PPIIJCGPLMI]
	private static void GOAFCBHIGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF920", Offset = "0x5FCEB20", VA = "0x185FCF920")]
	[IAOBFDKCCEF(NNKJNJFOFID.Unity_AfterAssembliesLoaded)]
	private static void ELBEKHEAGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FD07C0", Offset = "0x5FCF9C0", VA = "0x185FD07C0")]
	public static JGBEMAKPOMJ LJDDOJOCKMN(AILNDCKFLHJ HJPJJCKGGPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FD09E0", Offset = "0x5FCFBE0", VA = "0x185FD09E0")]
	private static void LJDDOJOCKMN(AILNDCKFLHJ HJPJJCKGGPA, JGBEMAKPOMJ PCLGCNBMJAC, JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FD03F0", Offset = "0x5FCF5F0", VA = "0x185FD03F0")]
	private static void LJDDOJOCKMN(AILNDCKFLHJ HJPJJCKGGPA, JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FD02E0", Offset = "0x5FCF4E0", VA = "0x185FD02E0")]
	public static void INFKICHAIJB(AILNDCKFLHJ HJPJJCKGGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2357840", Offset = "0x2356A40", VA = "0x182357840")]
	private static bool DPNCNFAFLCG(CIJFMPALMOO OPECGMFELDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF7B0", Offset = "0x5FCE9B0", VA = "0x185FCF7B0")]
	private static JGBEMAKPOMJ BHLFHMEEGEB(string EOOCJLIPAGI, [Optional] JGBEMAKPOMJ PCLGCNBMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0120", Offset = "0x5FCF320", VA = "0x185FD0120")]
	private static void INFKICHAIJB(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFAB0", Offset = "0x5FCECB0", VA = "0x185FCFAB0")]
	private static void FNIHLFIIMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFB90", Offset = "0x5FCED90", VA = "0x185FCFB90")]
	private static IEnumerable<IMHDIPGOPIF> ICGPKFLHKLO(AILNDCKFLHJ HJPJJCKGGPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0B20", Offset = "0x5FCFD20", VA = "0x185FD0B20")]
	private static JGBEMAKPOMJ LKMHBKCIDGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FOEICEEEJDA<T> : IDisposable where T : FOEICEEEJDA<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T KLPCJKOHLOK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37C7860", Offset = "0x37C6A60", VA = "0x1837C7860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected FOEICEEEJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37C7830", Offset = "0x37C6A30", VA = "0x1837C7830", Slot = "5")]
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
