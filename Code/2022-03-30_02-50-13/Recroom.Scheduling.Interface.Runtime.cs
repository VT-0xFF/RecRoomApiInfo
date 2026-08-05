using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LELHKPJPEMH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OIHPFCMDIMH MPLMKEDIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OIHPFCMDIMH NJBLOKOJBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OIHPFCMDIMH DNCNFOIFGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JGPFNJLBKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PFENBKHLJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KBDFKOBHGAA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FFDEBDDLCFI.FHDHOFKEFAO AMGKGKAGHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float ELABGCOJJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IBNGMOMLBAP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HNDGJLOAFPC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBDFKOBHGAA PLLCOPDMIID(FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBDFKOBHGAA IEAEIHHDLKM(float CNCOADFHGCC, FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH = FFDEBDDLCFI.FHDHOFKEFAO.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KBDFKOBHGAA LONKDCLPAOI(float CNCOADFHGCC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KBDFKOBHGAA MFFDPCHFLGK(Func<bool> OKBKPNJGBAE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MEIEDPJCKCH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PFENBKHLJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JHKLLFHDHJL Run(IEnumerator<KBDFKOBHGAA> MOMJKFOCMHC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHKLLFHDHJL Run(Behaviour POJPEFNIBPF, IEnumerator<KBDFKOBHGAA> MOMJKFOCMHC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JHKLLFHDHJL : IDAIALKIMHE, HAMIGNOLDMC, IEnumerator, KBDFKOBHGAA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BGMLMBKNDAC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float ANLKFIPPOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float IOCKOHIGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double BAPHKLKAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FFDEBDDLCFI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[BFFGPEIIHNO]
	public enum FHDHOFKEFAO
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
	private sealed class FLEMHGENAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HAMIGNOLDMC promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public FLEMHGENAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4B45EE0", Offset = "0x4B444E0", VA = "0x184B45EE0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static HNDGJLOAFPC PGMBKDCBOPN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<HNDGJLOAFPC> BCJOCPOIHMN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BGMLMBKNDAC JEOCLLIDGKA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<BGMLMBKNDAC> ACIIOFMAGHC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static HNDGJLOAFPC FBDGODFLDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B450A0", Offset = "0x4B436A0", VA = "0x184B450A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BGMLMBKNDAC KOMCCMEIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4B44DB0", Offset = "0x4B433B0", VA = "0x184B44DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static KBDFKOBHGAA PLLCOPDMIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B44D50", Offset = "0x4B43350", VA = "0x184B44D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B45D30", Offset = "0x4B44330", VA = "0x184B45D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static KBDFKOBHGAA PMIADLMPBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B45650", Offset = "0x4B43C50", VA = "0x184B45650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4B45240", Offset = "0x4B43840", VA = "0x184B45240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static KBDFKOBHGAA CFMLJAIDONP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4B452B0", Offset = "0x4B438B0", VA = "0x184B452B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4B45310", Offset = "0x4B43910", VA = "0x184B45310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static KBDFKOBHGAA FDDHBKIABDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B45040", Offset = "0x4B43640", VA = "0x184B45040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B44E10", Offset = "0x4B43410", VA = "0x184B44E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KBDFKOBHGAA DAJMKMOLOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B44CF0", Offset = "0x4B432F0", VA = "0x184B44CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4B454B0", Offset = "0x4B43AB0", VA = "0x184B454B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B44C50", Offset = "0x4B43250", VA = "0x184B44C50")]
	public static void AHOOJOKGCCH(HNDGJLOAFPC NHHPOKCDFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B45DA0", Offset = "0x4B443A0", VA = "0x184B45DA0")]
	public static void PFPPGDPNOFI(BGMLMBKNDAC JFHFCGKNEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B456B0", Offset = "0x4B43CB0", VA = "0x184B456B0")]
	private static void OLCNBNELBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B45100", Offset = "0x4B43700", VA = "0x184B45100")]
	public static KBDFKOBHGAA IEAEIHHDLKM(float CNCOADFHGCC, FHDHOFKEFAO JOBBNEMILCH = FHDHOFKEFAO.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B45380", Offset = "0x4B43980", VA = "0x184B45380")]
	public static KBDFKOBHGAA LONKDCLPAOI(float CNCOADFHGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B45520", Offset = "0x4B43B20", VA = "0x184B45520")]
	public static KBDFKOBHGAA MFFDPCHFLGK(Func<bool> OKBKPNJGBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4B44E80", Offset = "0x4B43480", VA = "0x184B44E80")]
	public static KBDFKOBHGAA EMPCIAHDANF(HAMIGNOLDMC IKPCHBIFCLH)
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
