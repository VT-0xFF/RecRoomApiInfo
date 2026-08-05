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
		private sealed class JMBGOEHFFLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public JMBGOEHFFLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x681F3A0", Offset = "0x681D9A0", VA = "0x18681F3A0")]
			internal IEnumerable<MethodInfo> GBDELBHKOMM(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x681F460", Offset = "0x681DA60", VA = "0x18681F460")]
			internal bool HOIMDMKKGAB(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class IGDDBJIFBFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public IGDDBJIFBFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x681F340", Offset = "0x681D940", VA = "0x18681F340")]
			internal bool ACALEKKAOFO(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class OBKCMONIMPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public OBKCMONIMPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6820960", Offset = "0x681EF60", VA = "0x186820960")]
			internal bool HLCDABIKPAK(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<DIEKPBJOOBM, IGrouping<DIEKPBJOOBM, MethodInfo>> FMIGMLOCHJO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type KMGFHAAOEMG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6821790", Offset = "0x681FD90", VA = "0x186821790")]
		private static void MCLCAGJOOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68221F0", Offset = "0x68207F0", VA = "0x1868221F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6820A90", Offset = "0x681F090", VA = "0x186820A90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6820C40", Offset = "0x681F240", VA = "0x186820C40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6820BF0", Offset = "0x681F1F0", VA = "0x186820BF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6820AE0", Offset = "0x681F0E0", VA = "0x186820AE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6820B30", Offset = "0x681F130", VA = "0x186820B30")]
		private static void BNPJPIPJDMO(DIEKPBJOOBM PHMEHODEJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6820ED0", Offset = "0x681F4D0", VA = "0x186820ED0")]
		private static IEnumerable<MethodInfo> IACDDOPBPFM(Type JDMJAPILEJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6821670", Offset = "0x681FC70", VA = "0x186821670")]
		private static bool ILIBODKBMDC(string LLNECMGNPDG, [Out] Dictionary<string, List<string>> EODHKPMPPBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6820F60", Offset = "0x681F560", VA = "0x186820F60")]
		private static IEnumerable<Type> IJFAEPJBPLM(Dictionary<string, List<string>> EODHKPMPPBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68209B0", Offset = "0x681EFB0", VA = "0x1868209B0")]
		private static IEnumerable<MethodInfo> AKCEDBPPDIC(IEnumerable<Type> NPALJOOCNBD, Type JDMJAPILEJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6820E40", Offset = "0x681F440", VA = "0x186820E40")]
		internal static IEnumerable<MethodInfo> HKIHKDDNPEO(DIEKPBJOOBM PHMEHODEJDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6821CD0", Offset = "0x68202D0", VA = "0x186821CD0")]
		internal static void MKDNNNLDPIL(IEnumerable<MethodInfo> BJCHAKABNBL, Type MEKAPAGEDFL, [Optional] object[] MBKNFOKFHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6820C90", Offset = "0x681F290", VA = "0x186820C90")]
		private static Dictionary<DIEKPBJOOBM, IGrouping<DIEKPBJOOBM, MethodInfo>> EMPFAMOGCCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6820D20", Offset = "0x681F320", VA = "0x186820D20")]
		private static bool HCGCHEMDLGH(MethodInfo LONCGGIKIOL, Type FGKHPCBGHMA, bool OHFMLBONKCD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FABPFFMLLMB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> HNOBAPEIGNJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> OHCAGNCBKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x681F280", Offset = "0x681D880", VA = "0x18681F280")]
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
		[Cpp2IlInjected.Address(RVA = "0x6822340", Offset = "0x6820940", VA = "0x186822340")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LOHNGCFHDMM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BPMGCDABAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo HLMAOCJBNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CFIDNIINJOK KBOCKGFFPKI;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<GIKFHLNFMKF, List<BPMGCDABAMG>> MMDAIINLEJG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static JJHPIOCMJGA FCEHNOHMPBL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static JJHPIOCMJGA CEJBLIEHIBI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static JJHPIOCMJGA BMDHLFEOFFN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JJHPIOCMJGA OCNEBKEFEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6820860", Offset = "0x681EE60", VA = "0x186820860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JJHPIOCMJGA JHLCNCJPFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x681FDA0", Offset = "0x681E3A0", VA = "0x18681FDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JJHPIOCMJGA MOMPCIHDOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6820920", Offset = "0x681EF20", VA = "0x186820920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool CIINJDFNBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x681FD60", Offset = "0x681E360", VA = "0x18681FD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x681FBF0", Offset = "0x681E1F0", VA = "0x18681FBF0")]
	[CEGCKIMEJAC]
	private static void ADFCKGCPJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x681FC90", Offset = "0x681E290", VA = "0x18681FC90")]
	[MMFLCHFLHAE(DIEKPBJOOBM.Unity_AfterAssembliesLoaded)]
	private static void AGHCAKDOGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x681F890", Offset = "0x681DE90", VA = "0x18681F890")]
	public static JJHPIOCMJGA ADAFFDDNLKG(GIKFHLNFMKF NNJPNNPMOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x681FAB0", Offset = "0x681E0B0", VA = "0x18681FAB0")]
	private static void ADAFFDDNLKG(GIKFHLNFMKF NNJPNNPMOPE, JJHPIOCMJGA LICOOADAAEP, JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x681F4C0", Offset = "0x681DAC0", VA = "0x18681F4C0")]
	private static void ADAFFDDNLKG(GIKFHLNFMKF NNJPNNPMOPE, JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6820050", Offset = "0x681E650", VA = "0x186820050")]
	public static void HDHNPBDAIPM(GIKFHLNFMKF NNJPNNPMOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2590070", Offset = "0x258E670", VA = "0x182590070")]
	private static bool PHCIHLNDNBB(CFIDNIINJOK KOGILELBMCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68206F0", Offset = "0x681ECF0", VA = "0x1868206F0")]
	private static JJHPIOCMJGA HKHKFMMAAMC(string LNAAJHMMGBO, [Optional] JJHPIOCMJGA LICOOADAAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x681FE90", Offset = "0x681E490", VA = "0x18681FE90")]
	private static void HDHNPBDAIPM(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x681FBF0", Offset = "0x681E1F0", VA = "0x18681FBF0")]
	private static void ONPKPJMGHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6820160", Offset = "0x681E760", VA = "0x186820160")]
	private static IEnumerable<BPMGCDABAMG> HENGLIHDNIH(GIKFHLNFMKF NNJPNNPMOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x681FDE0", Offset = "0x681E3E0", VA = "0x18681FDE0")]
	private static JJHPIOCMJGA GAIBCHJPFPH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OLGBIFHLNFL<T> : IDisposable where T : OLGBIFHLNFL<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T GCEDGJIKNEO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x472F6D0", Offset = "0x472DCD0", VA = "0x18472F6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected OLGBIFHLNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x472F690", Offset = "0x472DC90", VA = "0x18472F690", Slot = "5")]
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
