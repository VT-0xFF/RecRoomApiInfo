using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ADIFEAAPNPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AMNHKKJOBOK KOOIMBCOBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AMNHKKJOBOK COKNMJGIKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	AMNHKKJOBOK IDABAANDBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KGFFDKBPMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool INJIGLBOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FEEMOJCDGJP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FEILFOOICNG.KEGPNCJFLFJ APCNPIOJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float IOHBBEBJCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NIIDNGHHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KGKMKNJGIBO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AINCEMGEEDM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FEEMOJCDGJP BFKODLDPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FEEMOJCDGJP POKCDAFPDGM(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ = FEILFOOICNG.KEGPNCJFLFJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FEEMOJCDGJP BKPNFKJHMIL(float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ = FEILFOOICNG.KEGPNCJFLFJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEEMOJCDGJP FENCFIBJNEB(Func<bool> MLBBCPJIFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GELMFPINIAK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable DCNAHEKJLMF(float FOOKFHONNOI, Action<float> PEPHBHFBJFE, bool MPEGNHBLLBF = true);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AICFMGNKEOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FEILFOOICNG.KEGPNCJFLFJ MJFAKMBBGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JAOAOODOEOH HONBHIFJHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ALMNDBMKBBN LDGDMJHFFKN(IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ALMNDBMKBBN LDGDMJHFFKN(Behaviour MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ALMNDBMKBBN PGCHPKMGCOO(ADIFEAAPNPC MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFEJCMBFABG();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKINEIFADPD();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ALMNDBMKBBN : GKOIHBKMELE, LLEFGLIPMKI, IEnumerator, FEEMOJCDGJP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JAOAOODOEOH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float OKADPEMLCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float APJLDCLNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double AIHJKLDBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FEILFOOICNG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[OGPGFLJADJF]
	public enum KEGPNCJFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		LatePreRender,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		EndOfFrame
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JEDJJEBJKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public LLEFGLIPMKI promise;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JEDJJEBJKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x672C960", Offset = "0x672BD60", VA = "0x18672C960")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static FEEMOJCDGJP EFBABOPGMDA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static FEEMOJCDGJP EMDOIHNMOKO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FEEMOJCDGJP FAHFLFHHHAO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FEEMOJCDGJP NLOEDBMHLGD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FEEMOJCDGJP DEMNACCGKDA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly KEGPNCJFLFJ[] KMFNMPDKLAN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static FEEMOJCDGJP POKCDAFPDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x672C5A0", Offset = "0x672B9A0", VA = "0x18672C5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static FEEMOJCDGJP OGPLPNJPBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x672C100", Offset = "0x672B500", VA = "0x18672C100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static FEEMOJCDGJP JLFEBMFMLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x672C2C0", Offset = "0x672B6C0", VA = "0x18672C2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FEEMOJCDGJP BFKODLDPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x672C260", Offset = "0x672B660", VA = "0x18672C260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static FEEMOJCDGJP LMNJHFNCJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x672C7F0", Offset = "0x672BBF0", VA = "0x18672C7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x672C600", Offset = "0x672BA00", VA = "0x18672C600")]
	private static void LIMPIHMCNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x672C160", Offset = "0x672B560", VA = "0x18672C160")]
	public static FEEMOJCDGJP BKPNFKJHMIL(float FCCAADEIJOC, KEGPNCJFLFJ FBAFAIACKJJ = KEGPNCJFLFJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x672C320", Offset = "0x672B720", VA = "0x18672C320")]
	public static FEEMOJCDGJP FENCFIBJNEB(Func<bool> MLBBCPJIFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x672C400", Offset = "0x672B800", VA = "0x18672C400")]
	public static FEEMOJCDGJP JGPGJJHNJLF(LLEFGLIPMKI LHCEHKBEGOH)
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
