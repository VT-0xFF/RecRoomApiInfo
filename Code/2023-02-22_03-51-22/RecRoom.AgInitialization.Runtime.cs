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
		private sealed class GFDJNCKDKEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public GFDJNCKDKEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x641E080", Offset = "0x641D280", VA = "0x18641E080")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x641E150", Offset = "0x641D350", VA = "0x18641E150")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class NLGCCOBMOHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public NLGCCOBMOHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x641E1C0", Offset = "0x641D3C0", VA = "0x18641E1C0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class PKLHKOAMNHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public PKLHKOAMNHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x641E230", Offset = "0x641D430", VA = "0x18641E230")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string NHAIILIGAOK = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string OINCBNDFDGI = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<PAIIGJKJFJG, IGrouping<PAIIGJKJFJG, MethodInfo>> CKJJDEODDDE;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type JGBDDPMNIGG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x641F6F0", Offset = "0x641E8F0", VA = "0x18641F6F0")]
		private static void PNGLIAHBFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x641FCE0", Offset = "0x641EEE0", VA = "0x18641FCE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x641E790", Offset = "0x641D990", VA = "0x18641E790")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x641EA40", Offset = "0x641DC40", VA = "0x18641EA40")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x641E9F0", Offset = "0x641DBF0", VA = "0x18641E9F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x641E7E0", Offset = "0x641D9E0", VA = "0x18641E7E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x641F620", Offset = "0x641E820", VA = "0x18641F620")]
		private static void JJCKIGFDDBN(PAIIGJKJFJG FIPJDNEJEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x641ED50", Offset = "0x641DF50", VA = "0x18641ED50")]
		private static IEnumerable<MethodInfo> HDKDCADAHBM(Type DHNPHPPMOMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x641E830", Offset = "0x641DA30", VA = "0x18641E830")]
		private static bool BPCNFCLBCIN(string IGKMDEJJGMM, out Dictionary<string, List<string>> FMNFJDKBCOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x641EEA0", Offset = "0x641E0A0", VA = "0x18641EEA0")]
		private static IEnumerable<Type> JEGHHDPAKON(Dictionary<string, List<string>> FMNFJDKBCOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x641EBB0", Offset = "0x641DDB0", VA = "0x18641EBB0")]
		private static IEnumerable<MethodInfo> FMLOHBLDMEC(IEnumerable<Type> CDFICLLHOEC, Type DHNPHPPMOMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x641EE10", Offset = "0x641E010", VA = "0x18641EE10")]
		internal static IEnumerable<MethodInfo> HHKLJGJJJFE(PAIIGJKJFJG FIPJDNEJEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x641E280", Offset = "0x641D480", VA = "0x18641E280")]
		internal static void ABLLEMGOIKK(IEnumerable<MethodInfo> FPALNGNIOOM, Type KOPMGCCEJEF, [Optional] object[] OOMECLFFJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x641EC90", Offset = "0x641DE90", VA = "0x18641EC90")]
		private static Dictionary<PAIIGJKJFJG, IGrouping<PAIIGJKJFJG, MethodInfo>> GIBDFGJOIME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x641EA90", Offset = "0x641DC90", VA = "0x18641EA90")]
		private static bool DDDLGIJIHGL(MethodInfo DJMIEBAMKDF, Type FIHJKJOIDGH, bool INIENDCANKO)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x641FE50", Offset = "0x641F050", VA = "0x18641FE50")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ADEOLNIKJAL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct HALLFLPPLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo IGHNFPOKNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LBAHANGFDMJ DICJCEAKGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool LLDFKNPJBAM;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<IKNAGCBCHKP, List<HALLFLPPLFD>> CFKCCFPOAFH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LECENBDGBAK NJBKKNLLLMA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static LECENBDGBAK HLJMOLNEPEO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LECENBDGBAK BPMFJEECEDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LECENBDGBAK MDHMHFAIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x641D630", Offset = "0x641C830", VA = "0x18641D630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LECENBDGBAK NMIEFNEEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x641DF60", Offset = "0x641D160", VA = "0x18641DF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LECENBDGBAK AAICMPGMAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x641D5F0", Offset = "0x641C7F0", VA = "0x18641D5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x641C770", Offset = "0x641B970", VA = "0x18641C770")]
	[LAHEKPKOBGA]
	private static void ANECFFILJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x641C680", Offset = "0x641B880", VA = "0x18641C680")]
	[NHJENIDEHPD(PAIIGJKJFJG.Unity_AfterAssembliesLoaded)]
	private static void AIBJNOKELCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x641C9B0", Offset = "0x641BBB0", VA = "0x18641C9B0")]
	public static LECENBDGBAK CKMNCNIAGLK(IKNAGCBCHKP ANHJKOHMIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x641C820", Offset = "0x641BA20", VA = "0x18641C820")]
	private static void CKMNCNIAGLK(IKNAGCBCHKP ANHJKOHMIKM, LECENBDGBAK EEMEKCBAKEI, ref LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x641CBF0", Offset = "0x641BDF0", VA = "0x18641CBF0")]
	private static void CKMNCNIAGLK(IKNAGCBCHKP ANHJKOHMIKM, LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x641D4E0", Offset = "0x641C6E0", VA = "0x18641D4E0")]
	public static void GMKHNNDLKCC(IKNAGCBCHKP ANHJKOHMIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x641DFA0", Offset = "0x641D1A0", VA = "0x18641DFA0")]
	private static bool LNHKJDPHDMB(LBAHANGFDMJ PEMHMFHKGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x641D810", Offset = "0x641CA10", VA = "0x18641D810")]
	private static LECENBDGBAK IEIDJDJHKHA(string ONCBJLOOHLF, [Optional] LECENBDGBAK EEMEKCBAKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x641D2E0", Offset = "0x641C4E0", VA = "0x18641D2E0")]
	private static void GMKHNNDLKCC(ref LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x641C770", Offset = "0x641B970", VA = "0x18641C770")]
	private static void IKIBFIIJADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x641D990", Offset = "0x641CB90", VA = "0x18641D990")]
	private static IEnumerable<HALLFLPPLFD> IFGELAEEMLO(IKNAGCBCHKP ANHJKOHMIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x641D720", Offset = "0x641C920", VA = "0x18641D720")]
	private static LECENBDGBAK HMEMBEDHPGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OKBJGGGHLHO<T> : IDisposable where T : global::OKBJGGGHLHO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static T MPOGNODCFNK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T HNEIEBONIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x264D0A0", Offset = "0x264C2A0", VA = "0x18264D0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
	protected OKBJGGGHLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x264D060", Offset = "0x264C260", VA = "0x18264D060", Slot = "5")]
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
