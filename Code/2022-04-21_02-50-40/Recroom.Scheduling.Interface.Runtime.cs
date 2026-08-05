using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IOCAABDHIFD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EKMBLIFIIOC JGCBLMKHPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EKMBLIFIIOC PDFAFJJLIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	EKMBLIFIIOC CEGBDJDAOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BLELGMHNLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OOCPJDDBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OKFJJPCKHDN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CBMBJKAIKNP.EBEPLJKMFIO OEFKEIOOICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float FCFEFJMBDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCLNGIIJNFK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMCMAOEELBL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKFJJPCKHDN HMLILLLMLFK(CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKFJJPCKHDN JEOGECKPKGA(float CBMIPCMFOCE, CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC = CBMBJKAIKNP.EBEPLJKMFIO.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OKFJJPCKHDN PBKFOCAIGIF(float CBMIPCMFOCE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OKFJJPCKHDN BDMHAPLFKKH(Func<bool> EHLHCGPEFKO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FJBOGPOIKDI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OOCPJDDBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PHEIIEMLJCG Run(IEnumerator<OKFJJPCKHDN> AADCFPPBCFD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PHEIIEMLJCG Run(Behaviour JBPOCMHHIBO, IEnumerator<OKFJJPCKHDN> AADCFPPBCFD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PHEIIEMLJCG : JOJICMOJBFA, FPHLJBABNHP, IEnumerator, OKFJJPCKHDN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EPPLDEKGEEK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float JGHPALMECCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float EOKHAMDNKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double EKHAANLGPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CBMBJKAIKNP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[FHPAAFFOHJI]
	public enum EBEPLJKMFIO
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
	private sealed class BJAHKPDCKCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FPHLJBABNHP promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public BJAHKPDCKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD550", Offset = "0x4BFC550", VA = "0x184BFD550")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static KMCMAOEELBL IADKEJNAPPG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<KMCMAOEELBL> MMALNGBLABA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EPPLDEKGEEK DHCOGPKIHFP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<EPPLDEKGEEK> CFMKCDPKNMP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static KMCMAOEELBL NHLBCNLMJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD800", Offset = "0x4BFC800", VA = "0x184BFD800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static EPPLDEKGEEK PMIOGNKJPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE2E0", Offset = "0x4BFD2E0", VA = "0x184BFE2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OKFJJPCKHDN HMLILLLMLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE480", Offset = "0x4BFD480", VA = "0x184BFE480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE040", Offset = "0x4BFD040", VA = "0x184BFE040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static OKFJJPCKHDN COLMOLFELEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD7A0", Offset = "0x4BFC7A0", VA = "0x184BFD7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE5E0", Offset = "0x4BFD5E0", VA = "0x184BFE5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static OKFJJPCKHDN LEMLGHJHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD900", Offset = "0x4BFC900", VA = "0x184BFD900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE780", Offset = "0x4BFD780", VA = "0x184BFE780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static OKFJJPCKHDN AJGGBOJNOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE4E0", Offset = "0x4BFD4E0", VA = "0x184BFE4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD600", Offset = "0x4BFC600", VA = "0x184BFD600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static OKFJJPCKHDN JAGOMOIHFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD960", Offset = "0x4BFC960", VA = "0x184BFD960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE270", Offset = "0x4BFD270", VA = "0x184BFE270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD860", Offset = "0x4BFC860", VA = "0x184BFD860")]
	public static void DAILPFPMICL(KMCMAOEELBL FGMGNFJIIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE540", Offset = "0x4BFD540", VA = "0x184BFE540")]
	public static void MBIOAHLGFAK(EPPLDEKGEEK HOAMFPLJCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD9C0", Offset = "0x4BFC9C0", VA = "0x184BFD9C0")]
	private static void EKBOCFHIJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE340", Offset = "0x4BFD340", VA = "0x184BFE340")]
	public static OKFJJPCKHDN JEOGECKPKGA(float CBMIPCMFOCE, EBEPLJKMFIO AJHLNLNFPBC = EBEPLJKMFIO.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE650", Offset = "0x4BFD650", VA = "0x184BFE650")]
	public static OKFJJPCKHDN PBKFOCAIGIF(float CBMIPCMFOCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD670", Offset = "0x4BFC670", VA = "0x184BFD670")]
	public static OKFJJPCKHDN BDMHAPLFKKH(Func<bool> EHLHCGPEFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE0B0", Offset = "0x4BFD0B0", VA = "0x184BFE0B0")]
	public static OKFJJPCKHDN FLFPKHGEBHK(FPHLJBABNHP OEPJIAOCMFO)
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
