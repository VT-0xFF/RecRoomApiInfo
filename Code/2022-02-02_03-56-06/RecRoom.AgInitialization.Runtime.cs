using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Method)]
public class CCDNIMICDFI : NMNJOAAFGME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x46991C0", Offset = "0x46981C0", VA = "0x1846991C0")]
	public CCDNIMICDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class NECNNIDGOFF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly IELBKHEMIMD OGJDEJGGAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int HIPCDHNIJFJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46993C0", Offset = "0x46983C0", VA = "0x1846993C0")]
	public NECNNIDGOFF(IELBKHEMIMD BJFJJAEEHGI = IELBKHEMIMD.ExitingPlayMode, int OPIJGMPOOOO = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IELBKHEMIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class NMNJOAAFGME : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly JBHEEJLDOJG BMINGGMIPBG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4699400", Offset = "0x4698400", VA = "0x184699400")]
	public NMNJOAAFGME(JBHEEJLDOJG MBJNLOEJBIG = JBHEEJLDOJG.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JBHEEJLDOJG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Unity_AfterSceneLoad,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Unity_BeforeSceneLoad,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Unity_AfterAssembliesLoaded,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_BeforeSplashScreen,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_SubsystemRegistration
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CMEOJIKEIIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public CMEOJIKEIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x46991E0", Offset = "0x46981E0", VA = "0x1846991E0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4699290", Offset = "0x4698290", VA = "0x184699290")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HIPKIAKLIJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public HIPKIAKLIJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4699350", Offset = "0x4698350", VA = "0x184699350")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class COLIOENLHPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public COLIOENLHPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4699300", Offset = "0x4698300", VA = "0x184699300")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string NELJPDMFMLC = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string EPJBKJPGHGP = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<JBHEEJLDOJG, IGrouping<JBHEEJLDOJG, MethodInfo>> GCFGGGOHEHK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type ECCDMIFLBHC;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4699B20", Offset = "0x4698B20", VA = "0x184699B20")]
		private static void HKJLNFGHHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x469A9B0", Offset = "0x46999B0", VA = "0x18469A9B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4699430", Offset = "0x4698430", VA = "0x184699430")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4699520", Offset = "0x4698520", VA = "0x184699520")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x46994D0", Offset = "0x46984D0", VA = "0x1846994D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4699480", Offset = "0x4698480", VA = "0x184699480")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x469A730", Offset = "0x4699730", VA = "0x18469A730")]
		private static void MLPAGKLNCDC(JBHEEJLDOJG MBJNLOEJBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x469A800", Offset = "0x4699800", VA = "0x18469A800")]
		private static IEnumerable<MethodInfo> NNEMPCBKNEO(Type LEDOIBGLJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x469A020", Offset = "0x4699020", VA = "0x18469A020")]
		private static bool JHJJAINAKLM(string PNJCOBMJPLG, out Dictionary<string, List<string>> JCJDHDDEJNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4699570", Offset = "0x4698570", VA = "0x184699570")]
		private static IEnumerable<Type> DHMCGJKJKDD(Dictionary<string, List<string>> JCJDHDDEJNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x469A1E0", Offset = "0x46991E0", VA = "0x18469A1E0")]
		private static IEnumerable<MethodInfo> KFFFNMIEHNB(IEnumerable<Type> DGFADDPDCGL, Type LEDOIBGLJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x469A290", Offset = "0x4699290", VA = "0x18469A290")]
		private static void LEPGJOMPAPA(IEnumerable<MethodInfo> HGBGLOPFPCH, Type MCBHBICMDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x469A8C0", Offset = "0x46998C0", VA = "0x18469A8C0")]
		private static bool PLNAOEBKHOP(MethodInfo OMEJCDADCFA, Type CAMHAGFCGNJ)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x469AAC0", Offset = "0x4699AC0", VA = "0x18469AAC0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BDMMAOIOHAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DCBGOMFLPPO FEOJFLNDPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4699100", Offset = "0x4698100", VA = "0x184699100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AHPNKFHCGEP<T> : IDisposable where T : global::AHPNKFHCGEP<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static T IPCMECKIACN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T BGMCCDCKKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1BFFEF0", Offset = "0x1BFEEF0", VA = "0x181BFFEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
	protected AHPNKFHCGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1BFFEB0", Offset = "0x1BFEEB0", VA = "0x181BFFEB0", Slot = "5")]
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
