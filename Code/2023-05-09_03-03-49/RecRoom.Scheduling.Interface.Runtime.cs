using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KMEJPHPLGLO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JAENCPCNABI LLPNKHFDMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JAENCPCNABI HBPPNFPCFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JAENCPCNABI JLKKIAKHMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MDEHKJLEMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MOCCFKODCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FJMKJDOKGFB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CBLODFENING.BNAPEOFIEGJ OCLEPAEHBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float MIPCMNFCBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ANPIKHECLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIGGHPCCPLM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EPMJIKMOIPD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FJMKJDOKGFB FGOLGKDFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJMKJDOKGFB DMDHCHIAAJB(CBLODFENING.BNAPEOFIEGJ ACPBNDAJKOM = CBLODFENING.BNAPEOFIEGJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJMKJDOKGFB LMDNKNOADJG(float GOMMNCLFDIF, CBLODFENING.BNAPEOFIEGJ ACPBNDAJKOM = CBLODFENING.BNAPEOFIEGJ.Update);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJMKJDOKGFB BBMPIAPHEEN(Func<bool> NEMBILNJMDF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PIJBAEGMOCF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable JCCNAKGHKDE(float MINNAJJJILB, Action<float> KFICNKMCGGK, bool IPICHJAOEPD = true);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HAFHGIHHCEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CBLODFENING.BNAPEOFIEGJ BAJECNDFNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KGKPDCEGGBJ NKGIMIGJBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LLDNPBCCADD MCLENAJGMPM(IEnumerator<FJMKJDOKGFB> CGMKEJLDFAO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LLDNPBCCADD MCLENAJGMPM(Behaviour BKJKDPLKCNE, IEnumerator<FJMKJDOKGFB> CGMKEJLDFAO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LLDNPBCCADD PEDIOHHJFIH(KMEJPHPLGLO BKJKDPLKCNE, IEnumerator<FJMKJDOKGFB> CGMKEJLDFAO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPBMMKEAFHI();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIPJLEDKNPD();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LLDNPBCCADD : FNGFMMGLOOC, OFEHPCFKLFI, IEnumerator, FJMKJDOKGFB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KGKPDCEGGBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float EOBHIBKCOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float MGMHPNENJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DIDPFJCKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CBLODFENING
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HGHNALMAJGN]
	public enum BNAPEOFIEGJ
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
	private sealed class OHIGACGIBFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public OFEHPCFKLFI promise;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public OHIGACGIBFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9600", Offset = "0x6AC8000", VA = "0x186AC9600")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static FJMKJDOKGFB LKEHDECHLOC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static FJMKJDOKGFB GEOIKNMBCGA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FJMKJDOKGFB AECGALEBLFG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FJMKJDOKGFB HNEGECFLPKI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FJMKJDOKGFB GLKLAFCMGIN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly BNAPEOFIEGJ[] MHKEKPEEMJP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static FJMKJDOKGFB DMDHCHIAAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8EE0", Offset = "0x6AC78E0", VA = "0x186AC8EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static FJMKJDOKGFB ODIIKLNPCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8DA0", Offset = "0x6AC77A0", VA = "0x186AC8DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static FJMKJDOKGFB OBFLCMEOBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9430", Offset = "0x6AC7E30", VA = "0x186AC9430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FJMKJDOKGFB FGOLGKDFBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC93D0", Offset = "0x6AC7DD0", VA = "0x186AC93D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static FJMKJDOKGFB FMNNHBAJKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9490", Offset = "0x6AC7E90", VA = "0x186AC9490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8F40", Offset = "0x6AC7940", VA = "0x186AC8F40")]
	private static void IHMJKMIIBIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC92D0", Offset = "0x6AC7CD0", VA = "0x186AC92D0")]
	public static FJMKJDOKGFB LMDNKNOADJG(float GOMMNCLFDIF, BNAPEOFIEGJ ACPBNDAJKOM = BNAPEOFIEGJ.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8E00", Offset = "0x6AC7800", VA = "0x186AC8E00")]
	public static FJMKJDOKGFB BBMPIAPHEEN(Func<bool> NEMBILNJMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9130", Offset = "0x6AC7B30", VA = "0x186AC9130")]
	public static FJMKJDOKGFB KFCNBMGLOAG(OFEHPCFKLFI GJNBJOAMMAA)
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
