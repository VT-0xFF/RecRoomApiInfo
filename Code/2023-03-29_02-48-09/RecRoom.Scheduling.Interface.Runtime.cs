using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LCPJFIPJNDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CPHLPGCHIIP MIEBBBIBGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CPHLPGCHIIP GJDABOBHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CPHLPGCHIIP NEJLBAONGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JDKKPKNDJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ODKLDFKOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FFIMBIIMMMD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FNNACPPACGP.KCEPDILKHND JFONCKCJHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NNLHCACLIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DNICNMEBCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDHFAIKCPFK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MOBMIKGCGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FFIMBIIMMMD BNBJNAIAOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FFIMBIIMMMD AKHOAHCCMNA(FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN = FNNACPPACGP.KCEPDILKHND.Update);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FFIMBIIMMMD CIGBHPPBBIA(float IHNJKOANCPJ, FNNACPPACGP.KCEPDILKHND BAPHNFLMDKN = FNNACPPACGP.KCEPDILKHND.Update);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FFIMBIIMMMD CFGKLEALJAA(Func<bool> JBMKOCDICIN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HBNIHCBKEFL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable KKIAAGEEJJL(float OBGBOJHKCAO, Action<float> JDLJMIHPPKE, bool LGKFKCOIKAH = true);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPENLAHPKHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FNNACPPACGP.KCEPDILKHND HMHMGPEGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IONPAFOCMFL PHALNIELKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OMJDCAMIDEI BEHKAEOBGKH(IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OMJDCAMIDEI BEHKAEOBGKH(Behaviour KPEPJOHCOMD, IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OMJDCAMIDEI JGKDNALJFLP(LCPJFIPJNDD KPEPJOHCOMD, IEnumerator<FFIMBIIMMMD> LAPJPKJGLKL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BALBDFFIPKJ();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CELKGMNMMPF();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OMJDCAMIDEI : ILDCKENHFOE, LMAPELGHNPL, IEnumerator, FFIMBIIMMMD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IONPAFOCMFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float EOILNLNFDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float GAOACEMGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DOIAMEFHOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FNNACPPACGP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[JNIDHNELDBK]
	public enum KCEPDILKHND
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
	private sealed class NIEDAPMHKCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public LMAPELGHNPL promise;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public NIEDAPMHKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66412C0", Offset = "0x66400C0", VA = "0x1866412C0")]
		internal bool <AfterCompleted>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static FFIMBIIMMMD MAJPJLFHBPD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static FFIMBIIMMMD HMKKCKDKPFD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FFIMBIIMMMD CCMCLCLDFDI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FFIMBIIMMMD DOHFKJPGCGA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FFIMBIIMMMD EGAJLHHFCDK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly KCEPDILKHND[] GDNBPDOPOLE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static FFIMBIIMMMD AKHOAHCCMNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6640C40", Offset = "0x663FA40", VA = "0x186640C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static FFIMBIIMMMD KFBPJKKECKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6640F60", Offset = "0x663FD60", VA = "0x186640F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static FFIMBIIMMMD JLFKMBBEMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6640CA0", Offset = "0x663FAA0", VA = "0x186640CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FFIMBIIMMMD BNBJNAIAOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6640F00", Offset = "0x663FD00", VA = "0x186640F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static FFIMBIIMMMD GMNGLOPNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6640EA0", Offset = "0x663FCA0", VA = "0x186640EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6640FC0", Offset = "0x663FDC0", VA = "0x186640FC0")]
	private static void OENCGMCJPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6640B40", Offset = "0x663F940", VA = "0x186640B40")]
	public static FFIMBIIMMMD CIGBHPPBBIA(float IHNJKOANCPJ, KCEPDILKHND BAPHNFLMDKN = KCEPDILKHND.Update)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6640A60", Offset = "0x663F860", VA = "0x186640A60")]
	public static FFIMBIIMMMD CFGKLEALJAA(Func<bool> JBMKOCDICIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6640D00", Offset = "0x663FB00", VA = "0x186640D00")]
	public static FFIMBIIMMMD MBOPGACEONC(LMAPELGHNPL DFJCJFEOFBE)
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
