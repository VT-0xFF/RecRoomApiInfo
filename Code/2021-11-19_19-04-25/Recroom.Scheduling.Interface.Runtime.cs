using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface APKDMFAAHKI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IDIKKKGOEOH EHBMCJOPNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IDIKKKGOEOH EADNBNOCLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IDIKKKGOEOH ABIGMIMOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CKCFNFJDEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GKPBFKDODII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MKDOJLNJHKD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JLHCHGPAHDJ.JOKKMFMHBPB PBEIGDCCEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float FKMNPGMGLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKHMNAKNAJK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BOOAFKHIHFO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKDOJLNJHKD HHJLDGAJILH(JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKDOJLNJHKD PIDLFEAADAK(float GLLDPBBBJJN, JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ = JLHCHGPAHDJ.JOKKMFMHBPB.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MKDOJLNJHKD OGLKBOIHBMN(Func<bool> OHKNCIKKDKL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DKCJOHCPMCK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GKPBFKDODII
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PPJBCEPCKCN Run(IEnumerator<MKDOJLNJHKD> PGEOLKHEDBG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PPJBCEPCKCN Run(Behaviour LJKCBGIFJKE, IEnumerator<MKDOJLNJHKD> PGEOLKHEDBG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPJBCEPCKCN : DPOOMLLAPDH, EBJFPPEJHJH, IEnumerator, MKDOJLNJHKD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GPLBBAOPPJD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float CBPJDPBGGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float LAKFBCGGJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double EGPDCCINGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JLHCHGPAHDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[FIHEDJPGLFA]
	public enum JOKKMFMHBPB
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		EndOfFrame
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class INAPGMBOHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EBJFPPEJHJH promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public INAPGMBOHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DEF0", Offset = "0x3D9CEF0", VA = "0x183D9DEF0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static BOOAFKHIHFO JLLLHJJJIKN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<BOOAFKHIHFO> AFPKPOIMGJA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GPLBBAOPPJD FJDJNGOLNLF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<GPLBBAOPPJD> HOBHPFENLBK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BOOAFKHIHFO GMGNPHENMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EF60", Offset = "0x3D9DF60", VA = "0x183D9EF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GPLBBAOPPJD AOOEJNKGHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D9ECA0", Offset = "0x3D9DCA0", VA = "0x183D9ECA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MKDOJLNJHKD HHJLDGAJILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E9C0", Offset = "0x3D9D9C0", VA = "0x183D9E9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E8A0", Offset = "0x3D9D8A0", VA = "0x183D9E8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MKDOJLNJHKD HMDLFHPCIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EE30", Offset = "0x3D9DE30", VA = "0x183D9EE30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EBB0", Offset = "0x3D9DBB0", VA = "0x183D9EBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static MKDOJLNJHKD DJGGOAGNAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DFA0", Offset = "0x3D9CFA0", VA = "0x183D9DFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EB50", Offset = "0x3D9DB50", VA = "0x183D9EB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MKDOJLNJHKD BLPCPBJCGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E960", Offset = "0x3D9D960", VA = "0x183D9E960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E7B0", Offset = "0x3D9D7B0", VA = "0x183D9E7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static MKDOJLNJHKD GCFIKOIFJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EA20", Offset = "0x3D9DA20", VA = "0x183D9EA20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E900", Offset = "0x3D9D900", VA = "0x183D9E900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D9EC10", Offset = "0x3D9DC10", VA = "0x183D9EC10")]
	public static void KKFKFFMFOOI(BOOAFKHIHFO LPAGLDIAODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E810", Offset = "0x3D9D810", VA = "0x183D9E810")]
	public static void DCIEOAACHNE(GPLBBAOPPJD IJHFLNGBNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E1C0", Offset = "0x3D9D1C0", VA = "0x183D9E1C0")]
	private static void BFMAAKEAOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D9EE90", Offset = "0x3D9DE90", VA = "0x183D9EE90")]
	public static MKDOJLNJHKD PIDLFEAADAK(float GLLDPBBBJJN, JOKKMFMHBPB AOKMLIKJOIJ = JOKKMFMHBPB.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D9EA80", Offset = "0x3D9DA80", VA = "0x183D9EA80")]
	public static MKDOJLNJHKD JFGDFBIKGMK(float GLLDPBBBJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D9ED00", Offset = "0x3D9DD00", VA = "0x183D9ED00")]
	public static MKDOJLNJHKD OGLKBOIHBMN(Func<bool> OHKNCIKKDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E000", Offset = "0x3D9D000", VA = "0x183D9E000")]
	public static MKDOJLNJHKD AOEHIENHOLK(EBJFPPEJHJH GIEFOJPBPGE)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
