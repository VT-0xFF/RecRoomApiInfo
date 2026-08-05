using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IBNJGIOKIDC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CMKPDMCLCCC MCANIPBEHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CMKPDMCLCCC LNABHPNIPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CMKPDMCLCCC MPPPIMKJCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FFCFGKOLMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GKDLBEAHEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MDIGCEIKMFK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LLJFHNCPJIB.CNGEIHNEJPD IMKLKCGMHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float FMJOFPMBJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHJCANJJFCC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BNEPKBLEFNI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDIGCEIKMFK JJIGADCAMNA(LLJFHNCPJIB.CNGEIHNEJPD FCJBAFPEMAA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDIGCEIKMFK IIOOPOOFGLA(float MGGKFHFIBDI, LLJFHNCPJIB.CNGEIHNEJPD NBDHFAHBBPO = LLJFHNCPJIB.CNGEIHNEJPD.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MDIGCEIKMFK KMMCNHNFHFA(Func<bool> OLILCMHGKEF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AEHPLGAMHJF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GKDLBEAHEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CLMDINKCDBN Run(IEnumerator<MDIGCEIKMFK> IFMLGMPBAAK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CLMDINKCDBN Run(Behaviour GHILNBJMAHO, IEnumerator<MDIGCEIKMFK> IFMLGMPBAAK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CLMDINKCDBN : EALELCKGONO, DPJKDCDGPPB, IEnumerator, MDIGCEIKMFK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EKBFHIEFDBB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OJOOFPKNAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float NBOCLONKJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double AFJFJBLNOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LLJFHNCPJIB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[OIEDFMKNPIJ]
	public enum CNGEIHNEJPD
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
	private sealed class ENLNBDGBALC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DPJKDCDGPPB promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public ENLNBDGBALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43F2C50", Offset = "0x43F1850", VA = "0x1843F2C50")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static BNEPKBLEFNI LOLGNMBKNLP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<BNEPKBLEFNI> KCBDFHKMCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EKBFHIEFDBB CHALNJGBFGH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<EKBFHIEFDBB> PBNABPPELBJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BNEPKBLEFNI HIFKCDHOKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x43F38B0", Offset = "0x43F24B0", VA = "0x1843F38B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static EKBFHIEFDBB GBCPKAIJHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43F3AA0", Offset = "0x43F26A0", VA = "0x1843F3AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MDIGCEIKMFK JJIGADCAMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43F3720", Offset = "0x43F2320", VA = "0x1843F3720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43F3780", Offset = "0x43F2380", VA = "0x1843F3780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MDIGCEIKMFK EHMGMDGBMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43F3410", Offset = "0x43F2010", VA = "0x1843F3410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43F3CC0", Offset = "0x43F28C0", VA = "0x1843F3CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static MDIGCEIKMFK GKDGIFCFDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43F32F0", Offset = "0x43F1EF0", VA = "0x1843F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43F3910", Offset = "0x43F2510", VA = "0x1843F3910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MDIGCEIKMFK OKAENAALBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43F3350", Offset = "0x43F1F50", VA = "0x1843F3350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43F3630", Offset = "0x43F2230", VA = "0x1843F3630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static MDIGCEIKMFK NGIAKNAANNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43F3470", Offset = "0x43F2070", VA = "0x1843F3470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x43F33B0", Offset = "0x43F1FB0", VA = "0x1843F33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x43F35A0", Offset = "0x43F21A0", VA = "0x1843F35A0")]
	public static void FKLKLNPKMKF(BNEPKBLEFNI BCACPGIGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x43F3690", Offset = "0x43F2290", VA = "0x1843F3690")]
	public static void GJBLLMFFHPB(EKBFHIEFDBB LPMAMIKAELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x43F2D00", Offset = "0x43F1900", VA = "0x1843F2D00")]
	private static void AGGMJNCCFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43F37E0", Offset = "0x43F23E0", VA = "0x1843F37E0")]
	public static MDIGCEIKMFK IIOOPOOFGLA(float MGGKFHFIBDI, CNGEIHNEJPD NBDHFAHBBPO = CNGEIHNEJPD.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43F34D0", Offset = "0x43F20D0", VA = "0x1843F34D0")]
	public static MDIGCEIKMFK FELDCFMADFA(float MGGKFHFIBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43F3970", Offset = "0x43F2570", VA = "0x1843F3970")]
	public static MDIGCEIKMFK KMMCNHNFHFA(Func<bool> OLILCMHGKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x43F3B00", Offset = "0x43F2700", VA = "0x1843F3B00")]
	public static MDIGCEIKMFK OBKAKEOCGMB(DPJKDCDGPPB MCNCEECLNLB)
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
