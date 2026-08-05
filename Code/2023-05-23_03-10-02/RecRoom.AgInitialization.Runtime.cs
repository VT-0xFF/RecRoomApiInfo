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
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1689460", Offset = "0x1688860", VA = "0x181689460")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class NHMPMPABHIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public NHMPMPABHIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1687750", Offset = "0x1686B50", VA = "0x181687750")]
			internal IEnumerable<MethodInfo> FNDEBBJHEKP(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1687820", Offset = "0x1686C20", VA = "0x181687820")]
			internal bool OLCEICOAFJG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ANCBEIANPNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public ANCBEIANPNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1686070", Offset = "0x1685470", VA = "0x181686070")]
			internal bool EMACPCABHOJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MNPEJILMMHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public MNPEJILMMHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1687700", Offset = "0x1686B00", VA = "0x181687700")]
			internal bool NODAJEADENH(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string CMJKEMHLHCG = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string BGGPCHAGEHI = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<EDOPKLDLJNF, IGrouping<EDOPKLDLJNF, MethodInfo>> PIOEILAKDFP;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type EONDEAGFCBK;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1688810", Offset = "0x1687C10", VA = "0x181688810")]
		private static void ILGGHCOOKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x16892F0", Offset = "0x16886F0", VA = "0x1816892F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1687890", Offset = "0x1686C90", VA = "0x181687890")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1687980", Offset = "0x1686D80", VA = "0x181687980")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1687930", Offset = "0x1686D30", VA = "0x181687930")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16878E0", Offset = "0x1686CE0", VA = "0x1816878E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1688740", Offset = "0x1687B40", VA = "0x181688740")]
		private static void HGMAGGLKIKL(EDOPKLDLJNF CPFDDMDBNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1689230", Offset = "0x1688630", VA = "0x181689230")]
		private static IEnumerable<MethodInfo> PGNFKKGPMJJ(Type JBBGIPBCJFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1688EC0", Offset = "0x16882C0", VA = "0x181688EC0")]
		private static bool MACNCJOEEPH(string JOGJCDLCLKG, out Dictionary<string, List<string>> ENBNBFJMAJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x16879D0", Offset = "0x1686DD0", VA = "0x1816879D0")]
		private static IEnumerable<Type> FDOCCGPFJGF(Dictionary<string, List<string>> ENBNBFJMAJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1688660", Offset = "0x1687A60", VA = "0x181688660")]
		private static IEnumerable<MethodInfo> HAHMLNLKCMN(IEnumerable<Type> FKOMPPKIBLI, Type JBBGIPBCJFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16891A0", Offset = "0x16885A0", VA = "0x1816891A0")]
		internal static IEnumerable<MethodInfo> PCLFNNLNEMO(EDOPKLDLJNF CPFDDMDBNME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1688150", Offset = "0x1687550", VA = "0x181688150")]
		internal static void GMCBFDHNLKG(IEnumerable<MethodInfo> FOADMAFDCIG, Type NCNENBBEGJH, [Optional] object[] IHHAIAFPENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1688E00", Offset = "0x1688200", VA = "0x181688E00")]
		private static Dictionary<EDOPKLDLJNF, IGrouping<EDOPKLDLJNF, MethodInfo>> JDOFOGABHHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1689080", Offset = "0x1688480", VA = "0x181689080")]
		private static bool NFBOOFHFMII(MethodInfo FEIEPOJCGLN, Type MFLAOHNMHCB, bool LAGPKPDHAOH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LIMAOAIIODF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct HKLFFNLNKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo EGNNHKLMKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JCKMLGOOEHJ BGPGDDPOEEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<OEAABDENEKP, List<HKLFFNLNKDM>> FLALNFNBABF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static HECDEIOAEPJ BAGCNHGHGEJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static HECDEIOAEPJ KKJFBFONENB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HECDEIOAEPJ GGOLIJIKFLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HECDEIOAEPJ GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x16871F0", Offset = "0x16865F0", VA = "0x1816871F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HECDEIOAEPJ DIFPGFMOGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1686260", Offset = "0x1685660", VA = "0x181686260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HECDEIOAEPJ NAKLPHAMKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16876C0", Offset = "0x1686AC0", VA = "0x1816876C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1687140", Offset = "0x1686540", VA = "0x181687140")]
	[HPBMKBPOEKA]
	private static void HKGAIHALFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1686830", Offset = "0x1685C30", VA = "0x181686830")]
	[NGKMFPOGHAJ(EDOPKLDLJNF.Unity_AfterAssembliesLoaded)]
	private static void BNIFBOMDHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1686920", Offset = "0x1685D20", VA = "0x181686920")]
	public static HECDEIOAEPJ GCEKJHDOGBI(OEAABDENEKP LPNLPDNDHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1686FB0", Offset = "0x16863B0", VA = "0x181686FB0")]
	private static void GCEKJHDOGBI(OEAABDENEKP LPNLPDNDHLO, HECDEIOAEPJ GGEGMNEAHKE, ref HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1686B70", Offset = "0x1685F70", VA = "0x181686B70")]
	private static void GCEKJHDOGBI(OEAABDENEKP LPNLPDNDHLO, HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x16874D0", Offset = "0x16868D0", VA = "0x1816874D0")]
	public static void JOPKBMKANAL(OEAABDENEKP LPNLPDNDHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x16875E0", Offset = "0x16869E0", VA = "0x1816875E0")]
	private static bool NEGJKJELEAA(JCKMLGOOEHJ DJJAHJPKOLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x16860E0", Offset = "0x16854E0", VA = "0x1816860E0")]
	private static HECDEIOAEPJ APFHHINCIBL(string ENPNNHDGAHM, [Optional] HECDEIOAEPJ GGEGMNEAHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x16872E0", Offset = "0x16866E0", VA = "0x1816872E0")]
	private static void JOPKBMKANAL(ref HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1687140", Offset = "0x1686540", VA = "0x181687140")]
	private static void PEDKGJPPPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x16862A0", Offset = "0x16856A0", VA = "0x1816862A0")]
	private static IEnumerable<HKLFFNLNKDM> BEEFEPFPOIC(OEAABDENEKP LPNLPDNDHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x16871F0", Offset = "0x16865F0", VA = "0x1816871F0")]
	private static HECDEIOAEPJ OPFLCPLOGIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class APKDDFHCLJF<T> : IDisposable where T : global::APKDDFHCLJF<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T NNJMKDFAIHH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T BGHJOACDLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39B9770", Offset = "0x39B8B70", VA = "0x1839B9770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
	protected APKDDFHCLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x39B9730", Offset = "0x39B8B30", VA = "0x1839B9730", Slot = "5")]
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
