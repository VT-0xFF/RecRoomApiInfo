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
		private sealed class HPIMHCINHGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public HPIMHCINHGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5F85090", Offset = "0x5F83E90", VA = "0x185F85090")]
			internal IEnumerable<MethodInfo> NCLHBOACDJM(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5F85030", Offset = "0x5F83E30", VA = "0x185F85030")]
			internal bool GLCBLIIOBDP(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class APJNMIHACNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public APJNMIHACNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5F83A80", Offset = "0x5F82880", VA = "0x185F83A80")]
			internal bool OMACMGKLAED(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GNDJLHDNHBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public GNDJLHDNHBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5F84FE0", Offset = "0x5F83DE0", VA = "0x185F84FE0")]
			internal bool GPDOKODFLFK(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<OPNAEKDCKEJ, IGrouping<OPNAEKDCKEJ, MethodInfo>> KBCEJIGOCJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type JGJOKHGIKLH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F85D30", Offset = "0x5F84B30", VA = "0x185F85D30")]
		private static void NKBKJEDCAEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F86A90", Offset = "0x5F85890", VA = "0x185F86A90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F85210", Offset = "0x5F84010", VA = "0x185F85210")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F85300", Offset = "0x5F84100", VA = "0x185F85300")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F852B0", Offset = "0x5F840B0", VA = "0x185F852B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F85260", Offset = "0x5F84060", VA = "0x185F85260")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F85B50", Offset = "0x5F84950", VA = "0x185F85B50")]
		private static void LELBAHALFCN(OPNAEKDCKEJ FGIEAHMCJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F85AC0", Offset = "0x5F848C0", VA = "0x185F85AC0")]
		private static IEnumerable<MethodInfo> KKABEFMGNHJ(Type IOFDMMGNAMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F85350", Offset = "0x5F84150", VA = "0x185F85350")]
		private static bool DBHBHMIKDEI(string BDJCCJPLCCI, [Out] Dictionary<string, List<string>> HDHHFMFEKNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F862A0", Offset = "0x5F850A0", VA = "0x185F862A0")]
		private static IEnumerable<Type> OKABIAOIDPE(Dictionary<string, List<string>> HDHHFMFEKNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F869B0", Offset = "0x5F857B0", VA = "0x185F869B0")]
		private static IEnumerable<MethodInfo> PCBENBAOFHE(IEnumerable<Type> EJDFNOEHKOE, Type IOFDMMGNAMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F85990", Offset = "0x5F84790", VA = "0x185F85990")]
		internal static IEnumerable<MethodInfo> GCKIFNFIDEG(OPNAEKDCKEJ FGIEAHMCJJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F85470", Offset = "0x5F84270", VA = "0x185F85470")]
		internal static void FAIEPMCOAJK(IEnumerable<MethodInfo> ONCJJPPENEE, Type KDEGIMFEBJK, [Optional] object[] JCKJBGDNIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F85A20", Offset = "0x5F84820", VA = "0x185F85A20")]
		private static Dictionary<OPNAEKDCKEJ, IGrouping<OPNAEKDCKEJ, MethodInfo>> JJHKNMNBDLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F85C10", Offset = "0x5F84A10", VA = "0x185F85C10")]
		private static bool NBIPLEGDLDL(MethodInfo NJAGOKEEGNN, Type EDAAKANLDKI, bool KDDHJOGIIDN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IFKLIFJFJKM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> CMANOEHOGKJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> DMGNBNLOOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F85150", Offset = "0x5F83F50", VA = "0x185F85150")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F86BF0", Offset = "0x5F859F0", VA = "0x185F86BF0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BOFILENNCGA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct FGNMNJPJGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo IECBJINNHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BHCECOANHAK LOLMFLJCDEA;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<EOCHJKOJDMN, List<FGNMNJPJGHA>> OLCNIDPDOCB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static CMADEFPIMOE EFMKPPLEEHE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static CMADEFPIMOE NKOEMKOABIK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static CMADEFPIMOE AHCDBCIKFJC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CMADEFPIMOE IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F83C10", Offset = "0x5F82A10", VA = "0x185F83C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static CMADEFPIMOE DKLAFHLKNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5F83B20", Offset = "0x5F82920", VA = "0x185F83B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static CMADEFPIMOE GMFOAOHDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F83AE0", Offset = "0x5F828E0", VA = "0x185F83AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F83B60", Offset = "0x5F82960", VA = "0x185F83B60")]
	[PJPOBLBIFHJ]
	private static void IAIHBIELAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F84E50", Offset = "0x5F83C50", VA = "0x185F84E50")]
	[GJCBJFIHOBA(OPNAEKDCKEJ.Unity_AfterAssembliesLoaded)]
	private static void NLAEKBKPAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F83F90", Offset = "0x5F82D90", VA = "0x185F83F90")]
	public static CMADEFPIMOE KHCMLHFPCGE(EOCHJKOJDMN CPHONJNPBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F83E50", Offset = "0x5F82C50", VA = "0x185F83E50")]
	private static void KHCMLHFPCGE(EOCHJKOJDMN CPHONJNPBNC, CMADEFPIMOE BIHHCHIDNDI, CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F841D0", Offset = "0x5F82FD0", VA = "0x185F841D0")]
	private static void KHCMLHFPCGE(EOCHJKOJDMN CPHONJNPBNC, CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F845C0", Offset = "0x5F833C0", VA = "0x185F845C0")]
	public static void KIINNNDIAMM(EOCHJKOJDMN CPHONJNPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x224E4E0", Offset = "0x224D2E0", VA = "0x18224E4E0")]
	private static bool FGDKPJBDGME(BHCECOANHAK HHAFJIMNJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F83CE0", Offset = "0x5F82AE0", VA = "0x185F83CE0")]
	private static CMADEFPIMOE IAJBLMGFBAK(string CLIHCHLLICL, [Optional] CMADEFPIMOE BIHHCHIDNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F846E0", Offset = "0x5F834E0", VA = "0x185F846E0")]
	private static void KIINNNDIAMM(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F83B60", Offset = "0x5F82960", VA = "0x185F83B60")]
	private static void FIHCEBMLPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F848B0", Offset = "0x5F836B0", VA = "0x185F848B0")]
	private static IEnumerable<FGNMNJPJGHA> LBNCEINDOHN(EOCHJKOJDMN CPHONJNPBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F84F20", Offset = "0x5F83D20", VA = "0x185F84F20")]
	private static CMADEFPIMOE NPHCIPDMGLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MOEIHILJAAG<T> : IDisposable where T : MOEIHILJAAG<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T DIPPNLOGDJL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T ACHMAPLCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3E36710", Offset = "0x3E35510", VA = "0x183E36710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected MOEIHILJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E366D0", Offset = "0x3E354D0", VA = "0x183E366D0", Slot = "5")]
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
