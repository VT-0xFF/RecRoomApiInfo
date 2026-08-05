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
		private sealed class IMIGGACOFBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public IMIGGACOFBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5E94ED0", Offset = "0x5E938D0", VA = "0x185E94ED0")]
			internal IEnumerable<MethodInfo> CEMCLBEHJLN(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E94F90", Offset = "0x5E93990", VA = "0x185E94F90")]
			internal bool PIGMBMIBLCJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class OADEAGFABCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public OADEAGFABCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5E95100", Offset = "0x5E93B00", VA = "0x185E95100")]
			internal bool BKAICIGFNMB(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MEPDGCBHJJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public MEPDGCBHJJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E950B0", Offset = "0x5E93AB0", VA = "0x185E950B0")]
			internal bool JDIJGCDFJFK(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<LIAHCPEMJMG, IGrouping<LIAHCPEMJMG, MethodInfo>> FOFIGCCBJEJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type KJCNJHGKFMD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E96470", Offset = "0x5E94E70", VA = "0x185E96470")]
		private static void PGKAGKLHCKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E969E0", Offset = "0x5E953E0", VA = "0x185E969E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E95280", Offset = "0x5E93C80", VA = "0x185E95280")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E95370", Offset = "0x5E93D70", VA = "0x185E95370")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E95320", Offset = "0x5E93D20", VA = "0x185E95320")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E952D0", Offset = "0x5E93CD0", VA = "0x185E952D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E95AE0", Offset = "0x5E944E0", VA = "0x185E95AE0")]
		private static void MAGPEAGLOPE(LIAHCPEMJMG OEMHGNMDAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E95CD0", Offset = "0x5E946D0", VA = "0x185E95CD0")]
		private static IEnumerable<MethodInfo> MJEPGOGALFF(Type GEAGLLEBCPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E953C0", Offset = "0x5E93DC0", VA = "0x185E953C0")]
		private static bool DHDMNDBOODC(string OKCMOIDDGJN, [Out] Dictionary<string, List<string>> AEKNKKCHPJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E95D60", Offset = "0x5E94760", VA = "0x185E95D60")]
		private static IEnumerable<Type> NMKIPDEKCDN(Dictionary<string, List<string>> AEKNKKCHPJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E95A00", Offset = "0x5E94400", VA = "0x185E95A00")]
		private static IEnumerable<MethodInfo> LILPIBENFKP(IEnumerable<Type> AOAJJFJCMOH, Type GEAGLLEBCPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E95C40", Offset = "0x5E94640", VA = "0x185E95C40")]
		internal static IEnumerable<MethodInfo> MFEBALEKKPN(LIAHCPEMJMG OEMHGNMDAND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E954E0", Offset = "0x5E93EE0", VA = "0x185E954E0")]
		internal static void JOGFNBDONCB(IEnumerable<MethodInfo> PFMEHFKAOPI, Type EOAPNJBCFNI, [Optional] object[] FLHMGGNKGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E95BA0", Offset = "0x5E945A0", VA = "0x185E95BA0")]
		private static Dictionary<LIAHCPEMJMG, IGrouping<LIAHCPEMJMG, MethodInfo>> MCGGGNAEOBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E95160", Offset = "0x5E93B60", VA = "0x185E95160")]
		private static bool AFMKAHKEOPL(MethodInfo HGBIKNAGECF, Type GNDACHJOGNO, bool PAOIJACJPJK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KABPCBODKLA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> HMIJMLGIIII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EGOEHEGMLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E94FF0", Offset = "0x5E939F0", VA = "0x185E94FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E96B40", Offset = "0x5E95540", VA = "0x185E96B40")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CIIDJAIBIPO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct MFBBKMKEAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo JHIMGMMFFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public HLEKCCEDPHP BBGDAMIOFNO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<JFAJKKONDHJ, List<MFBBKMKEAFL>> DPAAFONIEMH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static AFDLAPABCDH OKMMGPDCBGJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static AFDLAPABCDH AJJFGFELDEI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static AFDLAPABCDH HBOPPLPBLAD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AFDLAPABCDH DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E94B00", Offset = "0x5E93500", VA = "0x185E94B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AFDLAPABCDH NNDJHHLCGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E94A10", Offset = "0x5E93410", VA = "0x185E94A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static AFDLAPABCDH OAIPKKLABDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E93F70", Offset = "0x5E92970", VA = "0x185E93F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E94A50", Offset = "0x5E93450", VA = "0x185E94A50")]
	[KCJCFIKOMDI]
	private static void IAJCOPNOJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E94E00", Offset = "0x5E93800", VA = "0x185E94E00")]
	[DLKEJLMCDAC(LIAHCPEMJMG.Unity_AfterAssembliesLoaded)]
	private static void MILPECJOOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E947D0", Offset = "0x5E931D0", VA = "0x185E947D0")]
	public static AFDLAPABCDH GAEFPOHKBML(JFAJKKONDHJ GLJIEKOMAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E94690", Offset = "0x5E93090", VA = "0x185E94690")]
	private static void GAEFPOHKBML(JFAJKKONDHJ GLJIEKOMAMF, AFDLAPABCDH JMMFFGICJCF, AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E942A0", Offset = "0x5E92CA0", VA = "0x185E942A0")]
	private static void GAEFPOHKBML(JFAJKKONDHJ GLJIEKOMAMF, AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E94180", Offset = "0x5E92B80", VA = "0x185E94180")]
	public static void FCCBCKEAPIG(JFAJKKONDHJ GLJIEKOMAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x217DB10", Offset = "0x217C510", VA = "0x18217DB10")]
	private static bool FCMBBDAAHFH(HLEKCCEDPHP AEJHHNGFDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E94C90", Offset = "0x5E93690", VA = "0x185E94C90")]
	private static AFDLAPABCDH LODJJCFFIHE(string POIPBHPAPKL, [Optional] AFDLAPABCDH JMMFFGICJCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E93FB0", Offset = "0x5E929B0", VA = "0x185E93FB0")]
	private static void FCCBCKEAPIG(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E94A50", Offset = "0x5E93450", VA = "0x185E94A50")]
	private static void NDAJBPMLHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E939D0", Offset = "0x5E923D0", VA = "0x185E939D0")]
	private static IEnumerable<MFBBKMKEAFL> DNECPJOJAGG(JFAJKKONDHJ GLJIEKOMAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E94BD0", Offset = "0x5E935D0", VA = "0x185E94BD0")]
	private static AFDLAPABCDH JKMKLBEPGCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ALGLKBAOLDG<T> : IDisposable where T : ALGLKBAOLDG<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T BDFKMGIHPBP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T KHPIFBDMEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x389B330", Offset = "0x3899D30", VA = "0x18389B330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected ALGLKBAOLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x389B2F0", Offset = "0x3899CF0", VA = "0x18389B2F0", Slot = "5")]
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
