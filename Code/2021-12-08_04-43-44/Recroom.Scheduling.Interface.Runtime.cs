using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AINBJHDGDII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CEOJNOHEPFJ HHHBCIAALDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CEOJNOHEPFJ BFHKOKPPGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CEOJNOHEPFJ NIHOMLPKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NEJILJDMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LEJMCBJJBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LEPJMEIDDOC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HNMINGFKGHL.GNBOPFKGIKH EEOFIHPNJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float GDDLCAHCNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHPOJPAGFPA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LHAHFMJJCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LEPJMEIDDOC FLIOAPAIBPN(HNMINGFKGHL.GNBOPFKGIKH DEPEIHEBOMP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LEPJMEIDDOC HGBNILDIPNF(float EOIMJPDIPBB, HNMINGFKGHL.GNBOPFKGIKH INAEGPHOHJP = HNMINGFKGHL.GNBOPFKGIKH.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LEPJMEIDDOC PKIPFBKELAK(Func<bool> EMNPDECDGKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KPLDIAICJNB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LEJMCBJJBGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AAEMKIFCBKD Run(IEnumerator<LEPJMEIDDOC> HLGCHGGHPIG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAEMKIFCBKD Run(Behaviour HKKAAOILAFH, IEnumerator<LEPJMEIDDOC> HLGCHGGHPIG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AAEMKIFCBKD : DLIEPAHNDMA, IDJKGJMBBAG, IEnumerator, LEPJMEIDDOC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NAAFMHPAOPI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float BJKNACBJPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float JJFGJALCBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double GPPLABLILMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HNMINGFKGHL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[MOICCOGBEMF]
	public enum GNBOPFKGIKH
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
	private sealed class GHBCEPIOCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IDJKGJMBBAG promise;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public GHBCEPIOCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43EA340", Offset = "0x43E9740", VA = "0x1843EA340")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LHAHFMJJCGH BCHMBEBFLPF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<LHAHFMJJCGH> GCNHKHDDELL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NAAFMHPAOPI EOPAKFELILD;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<NAAFMHPAOPI> NNEGFMEKBFG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static LHAHFMJJCGH OOGAGOFAFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x43EB0F0", Offset = "0x43EA4F0", VA = "0x1843EB0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NAAFMHPAOPI OJDBLGDGBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43EAC60", Offset = "0x43EA060", VA = "0x1843EAC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LEPJMEIDDOC FLIOAPAIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43EB000", Offset = "0x43EA400", VA = "0x1843EB000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43EB220", Offset = "0x43EA620", VA = "0x1843EB220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static LEPJMEIDDOC NCBAAENKGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43EADB0", Offset = "0x43EA1B0", VA = "0x1843EADB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43EAE70", Offset = "0x43EA270", VA = "0x1843EAE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static LEPJMEIDDOC FODHDPFFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43EAE10", Offset = "0x43EA210", VA = "0x1843EAE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43EAD50", Offset = "0x43EA150", VA = "0x1843EAD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static LEPJMEIDDOC LCMOJAAPNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43EAFA0", Offset = "0x43EA3A0", VA = "0x1843EAFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43EB3B0", Offset = "0x43EA7B0", VA = "0x1843EB3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static LEPJMEIDDOC LFBKMOJEBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43EAC00", Offset = "0x43EA000", VA = "0x1843EAC00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x43EABA0", Offset = "0x43E9FA0", VA = "0x1843EABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x43EB060", Offset = "0x43EA460", VA = "0x1843EB060")]
	public static void MJNEJJNJKAO(LHAHFMJJCGH EKLBKGLOFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x43EACC0", Offset = "0x43EA0C0", VA = "0x1843EACC0")]
	public static void EGLAPDLMAMI(NAAFMHPAOPI CLCOEDPLNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x43EA3F0", Offset = "0x43E97F0", VA = "0x1843EA3F0")]
	private static void ABHJLEFEBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43EAED0", Offset = "0x43EA2D0", VA = "0x1843EAED0")]
	public static LEPJMEIDDOC HGBNILDIPNF(float EOIMJPDIPBB, GNBOPFKGIKH INAEGPHOHJP = GNBOPFKGIKH.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43EB150", Offset = "0x43EA550", VA = "0x1843EB150")]
	public static LEPJMEIDDOC NEGOCAKJHEN(float EOIMJPDIPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43EB280", Offset = "0x43EA680", VA = "0x1843EB280")]
	public static LEPJMEIDDOC PKIPFBKELAK(Func<bool> EMNPDECDGKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x43EA9E0", Offset = "0x43E9DE0", VA = "0x1843EA9E0")]
	public static LEPJMEIDDOC BGJDKINOKFO(IDJKGJMBBAG JDMAEGNPLGI)
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
