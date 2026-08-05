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
		private sealed class BPNLJGAKHDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public BPNLJGAKHDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5B7D700", Offset = "0x5B7CB00", VA = "0x185B7D700")]
			internal IEnumerable<MethodInfo> BEGNBGCDNCG(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5B7D7C0", Offset = "0x5B7CBC0", VA = "0x185B7D7C0")]
			internal bool FMOMPJBLCGG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FIGGECJKCDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public FIGGECJKCDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5B7D820", Offset = "0x5B7CC20", VA = "0x185B7D820")]
			internal bool INNBCPHDLIK(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KKFDEACCKID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public KKFDEACCKID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5B7ED80", Offset = "0x5B7E180", VA = "0x185B7ED80")]
			internal bool LDFJODMMFHJ(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<MIKPKJFIPHI, IGrouping<MIKPKJFIPHI, MethodInfo>> KEOFOFNCPIB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type OECBMKCCKHG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5B801A0", Offset = "0x5B7F5A0", VA = "0x185B801A0")]
		private static void LNJJLIFKEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B80710", Offset = "0x5B7FB10", VA = "0x185B80710")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EE90", Offset = "0x5B7E290", VA = "0x185B7EE90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F4A0", Offset = "0x5B7E8A0", VA = "0x185B7F4A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F450", Offset = "0x5B7E850", VA = "0x185B7F450")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EEE0", Offset = "0x5B7E2E0", VA = "0x185B7EEE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B800E0", Offset = "0x5B7F4E0", VA = "0x185B800E0")]
		private static void KPIOCNGAOBO(MIKPKJFIPHI GAMOFNCCPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5B7FEE0", Offset = "0x5B7F2E0", VA = "0x185B7FEE0")]
		private static IEnumerable<MethodInfo> FFGEKDNFIOI(Type OGJOJGHHMNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F4F0", Offset = "0x5B7E8F0", VA = "0x185B7F4F0")]
		private static bool DIDKKEGNIAL(string PJPGCKEEFAD, [Out] Dictionary<string, List<string>> NHILINEIHLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F7D0", Offset = "0x5B7EBD0", VA = "0x185B7F7D0")]
		private static IEnumerable<Type> FBHEJOKAOCL(Dictionary<string, List<string>> NHILINEIHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5B80000", Offset = "0x5B7F400", VA = "0x185B80000")]
		private static IEnumerable<MethodInfo> HNFONKMCEJE(IEnumerable<Type> GFPDCNEBAJJ, Type OGJOJGHHMNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7FF70", Offset = "0x5B7F370", VA = "0x185B7FF70")]
		internal static IEnumerable<MethodInfo> GPKDHHGGLFA(MIKPKJFIPHI GAMOFNCCPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EF30", Offset = "0x5B7E330", VA = "0x185B7EF30")]
		internal static void BJGLAKCIOGE(IEnumerable<MethodInfo> NEDFLDAILIP, Type GNCOMCANFLA, [Optional] object[] ILKHBODBFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F730", Offset = "0x5B7EB30", VA = "0x185B7F730")]
		private static Dictionary<MIKPKJFIPHI, IGrouping<MIKPKJFIPHI, MethodInfo>> ECMHPBOENPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F610", Offset = "0x5B7EA10", VA = "0x185B7F610")]
		private static bool EBOPAOKLPMK(MethodInfo GDNNMEAGABC, Type LALAGFBJEEG, bool MFOEOJIIKDG)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NFJJIOPDDDI
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> DDBABEOLOGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EAEKJFGFJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EDD0", Offset = "0x5B7E1D0", VA = "0x185B7EDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B80870", Offset = "0x5B7FC70", VA = "0x185B80870")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HHEHOBMDHJH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EMPOMFKDBDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo KBEEEIGGOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OPIGPDFNEON AFECFJFAMPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<POEFLILDONI, List<EMPOMFKDBDP>> CJPEKAKKKJL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static HLDKHDLHDPB IBIJGLIFLLL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static HLDKHDLHDPB MBBAFLPHDOH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static HLDKHDLHDPB AIHLCKBBIPF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HLDKHDLHDPB DFDPGOHHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E210", Offset = "0x5B7D610", VA = "0x185B7E210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HLDKHDLHDPB HMDEHIPNEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E760", Offset = "0x5B7DB60", VA = "0x185B7E760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HLDKHDLHDPB NAKEPHABMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E7A0", Offset = "0x5B7DBA0", VA = "0x185B7E7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E160", Offset = "0x5B7D560", VA = "0x185B7E160")]
	[KKBKPAPAECG]
	private static void CKCBKAFDLIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E5D0", Offset = "0x5B7D9D0", VA = "0x185B7E5D0")]
	[NPHAAKAPCJA(MIKPKJFIPHI.Unity_AfterAssembliesLoaded)]
	private static void DDCFOEKLAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5B7DDE0", Offset = "0x5B7D1E0", VA = "0x185B7DDE0")]
	public static HLDKHDLHDPB BDDOKDFJNAL(POEFLILDONI JBJLEHHJIMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E020", Offset = "0x5B7D420", VA = "0x185B7E020")]
	private static void BDDOKDFJNAL(POEFLILDONI JBJLEHHJIMI, HLDKHDLHDPB MDGHJCLHJJD, HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D9F0", Offset = "0x5B7CDF0", VA = "0x185B7D9F0")]
	private static void BDDOKDFJNAL(POEFLILDONI JBJLEHHJIMI, HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E2E0", Offset = "0x5B7D6E0", VA = "0x185B7E2E0")]
	public static void DABEHNHFLJJ(POEFLILDONI JBJLEHHJIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34FE570", Offset = "0x34FD970", VA = "0x1834FE570")]
	private static bool ECFNFNMDAJL(OPIGPDFNEON ODCLJACGNBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D880", Offset = "0x5B7CC80", VA = "0x185B7D880")]
	private static HLDKHDLHDPB AJAACPDOBFL(string JKNFCNJKFGF, [Optional] HLDKHDLHDPB MDGHJCLHJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E400", Offset = "0x5B7D800", VA = "0x185B7E400")]
	private static void DABEHNHFLJJ(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E160", Offset = "0x5B7D560", VA = "0x185B7E160")]
	private static void PEDMHCANHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E7E0", Offset = "0x5B7DBE0", VA = "0x185B7E7E0")]
	private static IEnumerable<EMPOMFKDBDP> POCMOHNAKIB(POEFLILDONI JBJLEHHJIMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E6A0", Offset = "0x5B7DAA0", VA = "0x185B7E6A0")]
	private static HLDKHDLHDPB FJLNLBNHPMO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FAJAIOPKKMB<T> : IDisposable where T : FAJAIOPKKMB<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T LDFPHDMIKMC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T PFONNHJIIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x33BBE90", Offset = "0x33BB290", VA = "0x1833BBE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected FAJAIOPKKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x33BBE50", Offset = "0x33BB250", VA = "0x1833BBE50", Slot = "5")]
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
