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
		private sealed class LCKAAIIHMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public LCKAAIIHMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6872650", Offset = "0x6870C50", VA = "0x186872650")]
			internal IEnumerable<MethodInfo> GHGNDCIIANK(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x68725F0", Offset = "0x6870BF0", VA = "0x1868725F0")]
			internal bool CJCANJHDMLB(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class IOPBKLPFEFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public IOPBKLPFEFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6871000", Offset = "0x686F600", VA = "0x186871000")]
			internal bool EEBPFHCKADG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class IPFHCHJLMMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public IPFHCHJLMMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6871060", Offset = "0x686F660", VA = "0x186871060")]
			internal bool EKNPFFALKPE(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<GACAEABCFNO, IGrouping<GACAEABCFNO, MethodInfo>> FGLGAJCCCBE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type POCKMCJIKPA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68731A0", Offset = "0x68717A0", VA = "0x1868731A0")]
		private static void FNNEFAOLPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6874070", Offset = "0x6872670", VA = "0x186874070")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6872860", Offset = "0x6870E60", VA = "0x186872860")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6872A30", Offset = "0x6871030", VA = "0x186872A30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68729E0", Offset = "0x6870FE0", VA = "0x1868729E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68728B0", Offset = "0x6870EB0", VA = "0x1868728B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6872A80", Offset = "0x6871080", VA = "0x186872A80")]
		private static void EBIHCJCLCGB(GACAEABCFNO CHOJKHFAOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6873110", Offset = "0x6871710", VA = "0x186873110")]
		private static IEnumerable<MethodInfo> FMDKCOEBMAD(Type MNHBDLPEJLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6873F50", Offset = "0x6872550", VA = "0x186873F50")]
		private static bool LCCGEGNCENP(string JIECKKHOAKK, [Out] Dictionary<string, List<string>> IBNEILCEGOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6873710", Offset = "0x6871D10", VA = "0x186873710")]
		private static IEnumerable<Type> IDBAEHNPPCL(Dictionary<string, List<string>> IBNEILCEGOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6872900", Offset = "0x6870F00", VA = "0x186872900")]
		private static IEnumerable<MethodInfo> BFFEDFKKCAO(IEnumerable<Type> LFIJBJGDKFA, Type MNHBDLPEJLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68727D0", Offset = "0x6870DD0", VA = "0x1868727D0")]
		internal static IEnumerable<MethodInfo> ADNILPBNFKD(GACAEABCFNO CHOJKHFAOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6872BE0", Offset = "0x68711E0", VA = "0x186872BE0")]
		internal static void FKMAGOHEHAH(IEnumerable<MethodInfo> DMMFIFNCLHF, Type FILEJEECPIF, [Optional] object[] FPAICILAIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6872B40", Offset = "0x6871140", VA = "0x186872B40")]
		private static Dictionary<GACAEABCFNO, IGrouping<GACAEABCFNO, MethodInfo>> EJKFPEPCEEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6873E30", Offset = "0x6872430", VA = "0x186873E30")]
		private static bool IEEIPPDJFOJ(MethodInfo JPMJJIAAAOD, Type BJGOOODBEIK, bool NFCBFEOJAKJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LDKHPNAIHLD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> FKJPPLMNCCN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> OLBPCNFKHED
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6872710", Offset = "0x6870D10", VA = "0x186872710")]
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
		[Cpp2IlInjected.Address(RVA = "0x68741D0", Offset = "0x68727D0", VA = "0x1868741D0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KBMGENCAOLD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct DHHBOMMIINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo GLCHEMFGDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IAFNNCJJPGN AMNEBDLKEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<LIEKAGJMIGB, List<DHHBOMMIINI>> IGHBJHMFHPJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static GLOPJKBGAFG NBLGJLEKKEL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GLOPJKBGAFG HOLBOHHEGDP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static GLOPJKBGAFG PPOBBMCEHJL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GLOPJKBGAFG DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6872270", Offset = "0x6870870", VA = "0x186872270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GLOPJKBGAFG MBHJCLFDPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68724F0", Offset = "0x6870AF0", VA = "0x1868724F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static GLOPJKBGAFG AADNBKEFIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6871160", Offset = "0x686F760", VA = "0x186871160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool ALOAMOMJMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68724B0", Offset = "0x6870AB0", VA = "0x1868724B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68710B0", Offset = "0x686F6B0", VA = "0x1868710B0")]
	[LCBKKPOKICD]
	private static void PNBEIICBDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68721A0", Offset = "0x68707A0", VA = "0x1868721A0")]
	[LBGCFGAFOMG(GACAEABCFNO.Unity_AfterAssembliesLoaded)]
	private static void IHAKHJCGCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68719C0", Offset = "0x686FFC0", VA = "0x1868719C0")]
	public static GLOPJKBGAFG HBFKMBMGMGE(LIEKAGJMIGB CBOBOHHEGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6871880", Offset = "0x686FE80", VA = "0x186871880")]
	private static void HBFKMBMGMGE(LIEKAGJMIGB CBOBOHHEGOG, GLOPJKBGAFG EFCPBEBIJHK, GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6871490", Offset = "0x686FA90", VA = "0x186871490")]
	private static void HBFKMBMGMGE(LIEKAGJMIGB CBOBOHHEGOG, GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6871370", Offset = "0x686F970", VA = "0x186871370")]
	public static void FLBPAECPENF(LIEKAGJMIGB CBOBOHHEGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25ADE30", Offset = "0x25AC430", VA = "0x1825ADE30")]
	private static bool MGFABLDMNCM(IAFNNCJJPGN ADMDAKJLHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6872340", Offset = "0x6870940", VA = "0x186872340")]
	private static GLOPJKBGAFG LDCFBNPDKOP(string AADHHMECCPN, [Optional] GLOPJKBGAFG EFCPBEBIJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68711A0", Offset = "0x686F7A0", VA = "0x1868711A0")]
	private static void FLBPAECPENF(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68710B0", Offset = "0x686F6B0", VA = "0x1868710B0")]
	private static void BJHCCKBJPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6871C00", Offset = "0x6870200", VA = "0x186871C00")]
	private static IEnumerable<DHHBOMMIINI> IACDNEKOHNP(LIEKAGJMIGB CBOBOHHEGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6872530", Offset = "0x6870B30", VA = "0x186872530")]
	private static GLOPJKBGAFG ODLBDOEHGOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KGJGEDMLBJO<T> : IDisposable where T : KGJGEDMLBJO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T ADJKKNJDKEH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T CFNNMJAMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4197990", Offset = "0x4195F90", VA = "0x184197990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected KGJGEDMLBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4197950", Offset = "0x4195F50", VA = "0x184197950", Slot = "5")]
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
