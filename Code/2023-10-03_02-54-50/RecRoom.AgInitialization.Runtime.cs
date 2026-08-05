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
		private sealed class IIDDBEIKFHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public IIDDBEIKFHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5BC4FA0", Offset = "0x5BC37A0", VA = "0x185BC4FA0")]
			internal IEnumerable<MethodInfo> FPMAIAMAMJH(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5BC5060", Offset = "0x5BC3860", VA = "0x185BC5060")]
			internal bool KHEMADEBLBA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class MNDIMCFNGGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public MNDIMCFNGGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5BC5110", Offset = "0x5BC3910", VA = "0x185BC5110")]
			internal bool KAFNJJCIPFI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class LFEEDHPPKFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public LFEEDHPPKFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5BC50C0", Offset = "0x5BC38C0", VA = "0x185BC50C0")]
			internal bool FBMDCHFBELE(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<KBJMBFFAEHK, IGrouping<KBJMBFFAEHK, MethodInfo>> DCFMICODJLP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type MCAMINOAGEO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5D20", Offset = "0x5BC4520", VA = "0x185BC5D20")]
		private static void JMOILKHALOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BC69F0", Offset = "0x5BC51F0", VA = "0x185BC69F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5170", Offset = "0x5BC3970", VA = "0x185BC5170")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5260", Offset = "0x5BC3A60", VA = "0x185BC5260")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5210", Offset = "0x5BC3A10", VA = "0x185BC5210")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BC51C0", Offset = "0x5BC39C0", VA = "0x185BC51C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5B80", Offset = "0x5BC4380", VA = "0x185BC5B80")]
		private static void IFPOPGGPBBJ(KBJMBFFAEHK ENPMDCIOJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BC6290", Offset = "0x5BC4A90", VA = "0x185BC6290")]
		private static IEnumerable<MethodInfo> KBNJCBPIHJM(Type JBAGMCPHDKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5BC6320", Offset = "0x5BC4B20", VA = "0x185BC6320")]
		private static bool NCDJNCCMPJJ(string NKBIHFHHEAL, [Out] Dictionary<string, List<string>> GJEBLGINLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5470", Offset = "0x5BC3C70", VA = "0x185BC5470")]
		private static IEnumerable<Type> GNFBGIIOPIJ(Dictionary<string, List<string>> GJEBLGINLHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5C40", Offset = "0x5BC4440", VA = "0x185BC5C40")]
		private static IEnumerable<MethodInfo> JCEPJIIJFIC(IEnumerable<Type> LHFELMDFGLA, Type JBAGMCPHDKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BC6440", Offset = "0x5BC4C40", VA = "0x185BC6440")]
		internal static IEnumerable<MethodInfo> OEHCIFNMMOD(KBJMBFFAEHK ENPMDCIOJOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5BC64D0", Offset = "0x5BC4CD0", VA = "0x185BC64D0")]
		internal static void PPKFBBNMOCK(IEnumerable<MethodInfo> KJHHILANHHH, Type LMBDKILBCJG, [Optional] object[] HIKDFDIFDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5BC53D0", Offset = "0x5BC3BD0", VA = "0x185BC53D0")]
		private static Dictionary<KBJMBFFAEHK, IGrouping<KBJMBFFAEHK, MethodInfo>> EJAMKADCEDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BC52B0", Offset = "0x5BC3AB0", VA = "0x185BC52B0")]
		private static bool CINOOCKNBFF(MethodInfo LKOKOFCJBDJ, Type ACOOLILJPKB, bool AKLCHNDDJLK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FEPIDFIDHJB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> FAGFGJFKGLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> LBGBMJHKJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4EE0", Offset = "0x5BC36E0", VA = "0x185BC4EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BC6B50", Offset = "0x5BC5350", VA = "0x185BC6B50")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BIJFPFIICHI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EOFAKKJLFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo NIKABFNBFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OIAOEFLOJIJ CFPJKCDLNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<CODKNAAEMCD, List<EOFAKKJLFAL>> POFAOBIKBBC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static MPCHBJGCNBP PFHJJEOBJAP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static MPCHBJGCNBP FNOGJCNEOAD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static MPCHBJGCNBP CEBAPIKJIOB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MPCHBJGCNBP AAPMKHJIGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3AD0", Offset = "0x5BC22D0", VA = "0x185BC3AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MPCHBJGCNBP EMKKMOEFLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4610", Offset = "0x5BC2E10", VA = "0x185BC4610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static MPCHBJGCNBP ILOMOHHPICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BC39E0", Offset = "0x5BC21E0", VA = "0x185BC39E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3A20", Offset = "0x5BC2220", VA = "0x185BC3A20")]
	[IHFKPAPPGMJ]
	private static void BMDPBIBLMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4480", Offset = "0x5BC2C80", VA = "0x185BC4480")]
	[OBMNFKLINDG(KBJMBFFAEHK.Unity_AfterAssembliesLoaded)]
	private static void EPOLIKDMOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3CE0", Offset = "0x5BC24E0", VA = "0x185BC3CE0")]
	public static MPCHBJGCNBP DABIKAMABNK(CODKNAAEMCD HFLLPKPPMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3BA0", Offset = "0x5BC23A0", VA = "0x185BC3BA0")]
	private static void DABIKAMABNK(CODKNAAEMCD HFLLPKPPMKJ, MPCHBJGCNBP GNIFGHPMHGL, MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3F20", Offset = "0x5BC2720", VA = "0x185BC3F20")]
	private static void DABIKAMABNK(CODKNAAEMCD HFLLPKPPMKJ, MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4BF0", Offset = "0x5BC33F0", VA = "0x185BC4BF0")]
	public static void NMDKFBOMIBG(CODKNAAEMCD HFLLPKPPMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4CEA800", Offset = "0x4CE9000", VA = "0x184CEA800")]
	private static bool PCMFHHCFPBM(OIAOEFLOJIJ DOKBGPAIACD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4310", Offset = "0x5BC2B10", VA = "0x185BC4310")]
	private static MPCHBJGCNBP EBDAPBIFBLO(string KGBPLGMFELL, [Optional] MPCHBJGCNBP GNIFGHPMHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4D10", Offset = "0x5BC3510", VA = "0x185BC4D10")]
	private static void NMDKFBOMIBG(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3A20", Offset = "0x5BC2220", VA = "0x185BC3A20")]
	private static void PEFLGLNBJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4650", Offset = "0x5BC2E50", VA = "0x185BC4650")]
	private static IEnumerable<EOFAKKJLFAL> NKHJEPAKDGN(CODKNAAEMCD HFLLPKPPMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4550", Offset = "0x5BC2D50", VA = "0x185BC4550")]
	private static MPCHBJGCNBP LFHGPKMDMKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OELHGMOBNCH<T> : IDisposable where T : OELHGMOBNCH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T AOCDGMDEJCJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T LNAOMADBHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D97190", Offset = "0x3D95990", VA = "0x183D97190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected OELHGMOBNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D97150", Offset = "0x3D95950", VA = "0x183D97150", Slot = "5")]
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
