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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public GFDJNCKDKEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6437D80", Offset = "0x6437180", VA = "0x186437D80")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6437E50", Offset = "0x6437250", VA = "0x186437E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public NLGCCOBMOHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6437EC0", Offset = "0x64372C0", VA = "0x186437EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public PKLHKOAMNHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6437F30", Offset = "0x6437330", VA = "0x186437F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x64393F0", Offset = "0x64387F0", VA = "0x1864393F0")]
		private static void PNGLIAHBFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64399E0", Offset = "0x6438DE0", VA = "0x1864399E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6438490", Offset = "0x6437890", VA = "0x186438490")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6438740", Offset = "0x6437B40", VA = "0x186438740")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64386F0", Offset = "0x6437AF0", VA = "0x1864386F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64384E0", Offset = "0x64378E0", VA = "0x1864384E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6439320", Offset = "0x6438720", VA = "0x186439320")]
		private static void JJCKIGFDDBN(PAIIGJKJFJG FIPJDNEJEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6438A50", Offset = "0x6437E50", VA = "0x186438A50")]
		private static IEnumerable<MethodInfo> HDKDCADAHBM(Type DHNPHPPMOMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6438530", Offset = "0x6437930", VA = "0x186438530")]
		private static bool BPCNFCLBCIN(string IGKMDEJJGMM, out Dictionary<string, List<string>> FMNFJDKBCOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6438BA0", Offset = "0x6437FA0", VA = "0x186438BA0")]
		private static IEnumerable<Type> JEGHHDPAKON(Dictionary<string, List<string>> FMNFJDKBCOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64388B0", Offset = "0x6437CB0", VA = "0x1864388B0")]
		private static IEnumerable<MethodInfo> FMLOHBLDMEC(IEnumerable<Type> CDFICLLHOEC, Type DHNPHPPMOMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6438B10", Offset = "0x6437F10", VA = "0x186438B10")]
		internal static IEnumerable<MethodInfo> HHKLJGJJJFE(PAIIGJKJFJG FIPJDNEJEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6437F80", Offset = "0x6437380", VA = "0x186437F80")]
		internal static void ABLLEMGOIKK(IEnumerable<MethodInfo> FPALNGNIOOM, Type KOPMGCCEJEF, [Optional] object[] OOMECLFFJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6438990", Offset = "0x6437D90", VA = "0x186438990")]
		private static Dictionary<PAIIGJKJFJG, IGrouping<PAIIGJKJFJG, MethodInfo>> GIBDFGJOIME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6438790", Offset = "0x6437B90", VA = "0x186438790")]
		private static bool DDDLGIJIHGL(MethodInfo DJMIEBAMKDF, Type FIHJKJOIDGH, bool INIENDCANKO)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6439B50", Offset = "0x6438F50", VA = "0x186439B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6437330", Offset = "0x6436730", VA = "0x186437330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LECENBDGBAK NMIEFNEEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6437C60", Offset = "0x6437060", VA = "0x186437C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LECENBDGBAK AAICMPGMAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64372F0", Offset = "0x64366F0", VA = "0x1864372F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6436470", Offset = "0x6435870", VA = "0x186436470")]
	[LAHEKPKOBGA]
	private static void ANECFFILJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6436380", Offset = "0x6435780", VA = "0x186436380")]
	[NHJENIDEHPD(PAIIGJKJFJG.Unity_AfterAssembliesLoaded)]
	private static void AIBJNOKELCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x64366B0", Offset = "0x6435AB0", VA = "0x1864366B0")]
	public static LECENBDGBAK CKMNCNIAGLK(IKNAGCBCHKP ANHJKOHMIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6436520", Offset = "0x6435920", VA = "0x186436520")]
	private static void CKMNCNIAGLK(IKNAGCBCHKP ANHJKOHMIKM, LECENBDGBAK EEMEKCBAKEI, ref LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x64368F0", Offset = "0x6435CF0", VA = "0x1864368F0")]
	private static void CKMNCNIAGLK(IKNAGCBCHKP ANHJKOHMIKM, LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64371E0", Offset = "0x64365E0", VA = "0x1864371E0")]
	public static void GMKHNNDLKCC(IKNAGCBCHKP ANHJKOHMIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6437CA0", Offset = "0x64370A0", VA = "0x186437CA0")]
	private static bool LNHKJDPHDMB(LBAHANGFDMJ PEMHMFHKGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6437510", Offset = "0x6436910", VA = "0x186437510")]
	private static LECENBDGBAK IEIDJDJHKHA(string ONCBJLOOHLF, [Optional] LECENBDGBAK EEMEKCBAKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6436FE0", Offset = "0x64363E0", VA = "0x186436FE0")]
	private static void GMKHNNDLKCC(ref LECENBDGBAK LNELKNMCOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6436470", Offset = "0x6435870", VA = "0x186436470")]
	private static void IKIBFIIJADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6437690", Offset = "0x6436A90", VA = "0x186437690")]
	private static IEnumerable<HALLFLPPLFD> IFGELAEEMLO(IKNAGCBCHKP ANHJKOHMIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6437420", Offset = "0x6436820", VA = "0x186437420")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF8F50", Offset = "0x2DF8350", VA = "0x182DF8F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
	protected OKBJGGGHLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8F10", Offset = "0x2DF8310", VA = "0x182DF8F10", Slot = "5")]
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
