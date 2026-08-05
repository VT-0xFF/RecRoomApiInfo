using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OMJOGKFDDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IDFFNOKDGGC OBNJFMLFOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IDFFNOKDGGC MFCBLOJFAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IDFFNOKDGGC BFOKEMNMEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BLKEOCKCGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BHIEPNNEGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NHGKJABNDLI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HPKCBBOAJAB.DGCEPOPAIEE MCBGOABNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GJOCJNJCACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIGIJNCGKAO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JJCNKGGICID
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHGKJABNDLI ICANEFAACPC(HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHGKJABNDLI LBGIEPKALEH(float BJLBHCLGAFF, HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB = HPKCBBOAJAB.DGCEPOPAIEE.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NHGKJABNDLI IHLGBCOKADP(float BJLBHCLGAFF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHGKJABNDLI ENOJKJKGCJN(Func<bool> EBBDNDEIBIM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GLKFPPHBCFI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BHIEPNNEGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEPECMMDIGN Run(IEnumerator<NHGKJABNDLI> OIDGAEIBAOB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEPECMMDIGN Run(Behaviour NBOHPDEHCDB, IEnumerator<NHGKJABNDLI> OIDGAEIBAOB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JEPECMMDIGN : POAJLJLELOL, GDOLLDLAJJG, IEnumerator, NHGKJABNDLI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CMJOIFPAEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MCIEJPCKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float BBKPACIDDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MPDKBNGHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HPKCBBOAJAB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DFDPPGHBIID]
	public enum DGCEPOPAIEE
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
	private sealed class AOJALDOKNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GDOLLDLAJJG promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public AOJALDOKNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x323B080", Offset = "0x3239680", VA = "0x18323B080")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static JJCNKGGICID NILFLIHIJEP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<JJCNKGGICID> HCHIEOIPADF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CMJOIFPAEIA FEAHLKOCFHG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<CMJOIFPAEIA> APPCGKMNLGK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JJCNKGGICID MEOOINNDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x323BEE0", Offset = "0x323A4E0", VA = "0x18323BEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CMJOIFPAEIA CNDJECHBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x323BC70", Offset = "0x323A270", VA = "0x18323BC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static NHGKJABNDLI ICANEFAACPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x323C070", Offset = "0x323A670", VA = "0x18323C070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x323BE70", Offset = "0x323A470", VA = "0x18323BE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static NHGKJABNDLI JCFDGPCIDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x323BA50", Offset = "0x323A050", VA = "0x18323BA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x323B9E0", Offset = "0x3239FE0", VA = "0x18323B9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static NHGKJABNDLI FGKJPDCBBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x323B910", Offset = "0x3239F10", VA = "0x18323B910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x323BE00", Offset = "0x323A400", VA = "0x18323BE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static NHGKJABNDLI INPNLFBOALG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x323B8B0", Offset = "0x3239EB0", VA = "0x18323B8B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x323B970", Offset = "0x3239F70", VA = "0x18323B970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static NHGKJABNDLI OGLEFMIONMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x323B850", Offset = "0x3239E50", VA = "0x18323B850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x323C210", Offset = "0x323A810", VA = "0x18323C210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x323C280", Offset = "0x323A880", VA = "0x18323C280")]
	public static void OMHIAGIJPPK(JJCNKGGICID OPCLALGIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x323B130", Offset = "0x3239730", VA = "0x18323B130")]
	public static void AHPOHGOEPPA(CMJOIFPAEIA MMLLIGKKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x323B1D0", Offset = "0x32397D0", VA = "0x18323B1D0")]
	private static void BAMKOJGOCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x323C0D0", Offset = "0x323A6D0", VA = "0x18323C0D0")]
	public static NHGKJABNDLI LBGIEPKALEH(float BJLBHCLGAFF, DGCEPOPAIEE FFMFKENFGDB = DGCEPOPAIEE.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x323BF40", Offset = "0x323A540", VA = "0x18323BF40")]
	public static NHGKJABNDLI IHLGBCOKADP(float BJLBHCLGAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x323BCD0", Offset = "0x323A2D0", VA = "0x18323BCD0")]
	public static NHGKJABNDLI ENOJKJKGCJN(Func<bool> EBBDNDEIBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x323BAB0", Offset = "0x323A0B0", VA = "0x18323BAB0")]
	public static NHGKJABNDLI EJIMFDBGNEB(GDOLLDLAJJG HMGDBPCOADP)
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
