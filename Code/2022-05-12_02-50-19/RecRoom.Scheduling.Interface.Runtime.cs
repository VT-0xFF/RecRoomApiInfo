using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PCJIKCJIJJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CDMOJAPFDMP ANDCDIFAJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CDMOJAPFDMP IOCFJEKGPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CDMOJAPFDMP PELPMCACCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CDKPNABJCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ADOKNHFGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HBFHEEBHGHK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CAAFEHPDHLJ.JNBDMIONNKP JJGMBDAPHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BBEJLGHBNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFGNBBALCFF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DOIIBLJPHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBFHEEBHGHK GNLOEFGDCKH(CAAFEHPDHLJ.JNBDMIONNKP BBMDGGMAJMM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HBFHEEBHGHK BJCBNIOACFA(float LHAKMINEFIH, CAAFEHPDHLJ.JNBDMIONNKP LOBKENMFHDL = CAAFEHPDHLJ.JNBDMIONNKP.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBFHEEBHGHK FBNINIKILGK(float LHAKMINEFIH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HBFHEEBHGHK ABJGMIIIMBH(Func<bool> NGHFOONOFMA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PFEFCOEOGLF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ADOKNHFGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BHFIPLDLAEJ Run(IEnumerator<HBFHEEBHGHK> HJEHFEJBFDO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BHFIPLDLAEJ Run(Behaviour IJBCJIEGGIM, IEnumerator<HBFHEEBHGHK> HJEHFEJBFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BHFIPLDLAEJ : BBCAEAMDHCM, DCCNBCFBHAJ, IEnumerator, HBFHEEBHGHK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PNHOFALDJLH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float KMKPKHPMENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float AJPNMHBOPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double NKICCIKKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CAAFEHPDHLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[NPONLNAGJAA]
	public enum JNBDMIONNKP
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
	private sealed class GJOILFJDMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DCCNBCFBHAJ promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public GJOILFJDMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4DB9840", Offset = "0x4DB8C40", VA = "0x184DB9840")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static DOIIBLJPHGK APDLDFEGGIA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<DOIIBLJPHGK> AKEFAFEENAP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static PNHOFALDJLH OEJHCDFKCAP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<PNHOFALDJLH> FHHLINLKGEM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static DOIIBLJPHGK BBCLHFDCHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8B10", Offset = "0x4DB7F10", VA = "0x184DB8B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static PNHOFALDJLH MMEJLMJHLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8B70", Offset = "0x4DB7F70", VA = "0x184DB8B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static HBFHEEBHGHK GNLOEFGDCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4DB9360", Offset = "0x4DB8760", VA = "0x184DB9360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4DB96C0", Offset = "0x4DB8AC0", VA = "0x184DB96C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static HBFHEEBHGHK DICBAEOFLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4DB9490", Offset = "0x4DB8890", VA = "0x184DB9490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4DB93C0", Offset = "0x4DB87C0", VA = "0x184DB93C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static HBFHEEBHGHK IDACFPGJDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4DB9430", Offset = "0x4DB8830", VA = "0x184DB9430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4DB95F0", Offset = "0x4DB89F0", VA = "0x184DB95F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static HBFHEEBHGHK ADLKMGPAAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB94F0", Offset = "0x4DB88F0", VA = "0x184DB94F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8BD0", Offset = "0x4DB7FD0", VA = "0x184DB8BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static HBFHEEBHGHK CJJHLKEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4DB9660", Offset = "0x4DB8A60", VA = "0x184DB9660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4DB9730", Offset = "0x4DB8B30", VA = "0x184DB9730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DB9550", Offset = "0x4DB8950", VA = "0x184DB9550")]
	public static void KNOOHPCNDDA(DOIIBLJPHGK OKLGOFCODIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DB92C0", Offset = "0x4DB86C0", VA = "0x184DB92C0")]
	public static void HGJHCPJLDKD(PNHOFALDJLH AICPJBNFKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DB8C40", Offset = "0x4DB8040", VA = "0x184DB8C40")]
	private static void HADHLLPIGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4DB86E0", Offset = "0x4DB7AE0", VA = "0x184DB86E0")]
	public static HBFHEEBHGHK BJCBNIOACFA(float LHAKMINEFIH, JNBDMIONNKP LOBKENMFHDL = JNBDMIONNKP.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4DB8820", Offset = "0x4DB7C20", VA = "0x184DB8820")]
	public static HBFHEEBHGHK FBNINIKILGK(float LHAKMINEFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DB85B0", Offset = "0x4DB79B0", VA = "0x184DB85B0")]
	public static HBFHEEBHGHK ABJGMIIIMBH(Func<bool> NGHFOONOFMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DB8950", Offset = "0x4DB7D50", VA = "0x184DB8950")]
	public static HBFHEEBHGHK FDCHPIBNFJM(DCCNBCFBHAJ OJCDBLDFDBK)
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
