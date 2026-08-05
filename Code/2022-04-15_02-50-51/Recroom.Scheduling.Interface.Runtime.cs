using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EIFMBKIIJEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MHBAOJKAIFE JGLPJKDGNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MHBAOJKAIFE EFMCBNHDKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MHBAOJKAIFE BGOGIIONLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NOOFBFMFOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BLBLDKDCJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MKGJCNMEMBO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FJHMKDNGCFF.EOBLANAGKJH NNNNOJPKPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float CMLHNFECHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGAHLCMOKLK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FHPNFPKPEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKGJCNMEMBO EACGGENONEE(FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKGJCNMEMBO PEOGKOGOCPC(float GPFDONCHLCL, FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO = FJHMKDNGCFF.EOBLANAGKJH.Update);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MKGJCNMEMBO PALFGMHMAMJ(float GPFDONCHLCL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MKGJCNMEMBO PEHAIMFJPMP(Func<bool> OMHHJLHPANH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IKOCECLGGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BLBLDKDCJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONFMLALHBOC Run(IEnumerator<MKGJCNMEMBO> DDLHNJGLMNF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ONFMLALHBOC Run(Behaviour FLMJHFDBGLA, IEnumerator<MKGJCNMEMBO> DDLHNJGLMNF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ONFMLALHBOC : HJLPNCBIIPA, GGJFLBABPCA, IEnumerator, MKGJCNMEMBO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LGDKBEOPAIK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float OOMFJBBPMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float BMJLGAOEAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double GBNGNFOJKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FJHMKDNGCFF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[HCNLEGABBHB]
	public enum EOBLANAGKJH
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
	private sealed class CFBAFOMPMHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GGJFLBABPCA promise;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public CFBAFOMPMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3AF0", Offset = "0x1AC28F0", VA = "0x181AC3AF0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static FHPNFPKPEKM PDNHFHOPKBD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Stack<FHPNFPKPEKM> NDLJIPLOJIN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LGDKBEOPAIK HHKLBMMHDHI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly Stack<LGDKBEOPAIK> CBMOIPGAKLO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static FHPNFPKPEKM DALELIAPOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4D30", Offset = "0x1AC3B30", VA = "0x181AC4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LGDKBEOPAIK LGBEODCEOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1AC43F0", Offset = "0x1AC31F0", VA = "0x181AC43F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MKGJCNMEMBO EACGGENONEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4820", Offset = "0x1AC3620", VA = "0x181AC4820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4670", Offset = "0x1AC3470", VA = "0x181AC4670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MKGJCNMEMBO FMFLDEOLKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC46E0", Offset = "0x1AC34E0", VA = "0x181AC46E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4740", Offset = "0x1AC3540", VA = "0x181AC4740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static MKGJCNMEMBO OJLLALMCBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3C70", Offset = "0x1AC2A70", VA = "0x181AC3C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3BA0", Offset = "0x1AC29A0", VA = "0x181AC3BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static MKGJCNMEMBO OIPOMACAJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3C10", Offset = "0x1AC2A10", VA = "0x181AC3C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4920", Offset = "0x1AC3720", VA = "0x181AC4920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static MKGJCNMEMBO LNFGMGCKHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4450", Offset = "0x1AC3250", VA = "0x181AC4450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AC47B0", Offset = "0x1AC35B0", VA = "0x181AC47B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1AC3CD0", Offset = "0x1AC2AD0", VA = "0x181AC3CD0")]
	public static void DIFNKFNEMNK(FHPNFPKPEKM FEHLDFFONNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4880", Offset = "0x1AC3680", VA = "0x181AC4880")]
	public static void NMDICHFMDCH(LGDKBEOPAIK DJJLNBLBBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1AC3D70", Offset = "0x1AC2B70", VA = "0x181AC3D70")]
	private static void EHGNHMFAKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4BF0", Offset = "0x1AC39F0", VA = "0x181AC4BF0")]
	public static MKGJCNMEMBO PEOGKOGOCPC(float GPFDONCHLCL, EOBLANAGKJH IIHEDPNBEFO = EOBLANAGKJH.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4990", Offset = "0x1AC3790", VA = "0x181AC4990")]
	public static MKGJCNMEMBO PALFGMHMAMJ(float GPFDONCHLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1AC4AC0", Offset = "0x1AC38C0", VA = "0x181AC4AC0")]
	public static MKGJCNMEMBO PEHAIMFJPMP(Func<bool> OMHHJLHPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1AC44B0", Offset = "0x1AC32B0", VA = "0x181AC44B0")]
	public static MKGJCNMEMBO IEBGCLCHDBC(GGJFLBABPCA EKLJEEAJMIC)
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
