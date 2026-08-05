using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Foundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BAKDCDBCJGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GEBKKCMHICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MKBAPFGMAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BJCCECIKIFB BECACBNOINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int DLODNOBBFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JKOIDKPJBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LAPGFHBFEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BBABNOCKIPH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPDPDLLABMM();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BPMBMIHELCF(object HEDGIMBCGHA, bool MCFADIAKPKJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FAKNBMCJCOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ODPNKHICGED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string JOMDPKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ELMMBGGKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ACMDAAKJFGK<T> : ODPNKHICGED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T GCLCELGFKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBAFLOEECHH(T LFLPFMMDGLM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ECKLEAGCICH<T> : ACMDAAKJFGK<T>, ODPNKHICGED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PJKJLIKNEPK<T> GJIDLDGPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PJKJLIKNEPK<T> IMCFIPHGBJA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string JOMDPKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB20", Offset = "0xE9C720", VA = "0x180E9DB20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BPKHAIECPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x47182F0", Offset = "0x4716EF0", VA = "0x1847182F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T CMPPNNHMNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4717900", Offset = "0x4716500", VA = "0x184717900", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x47188F0", Offset = "0x47174F0", VA = "0x1847188F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T GCLCELGFKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4717B30", Offset = "0x4716730", VA = "0x184717B30", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x47186F0", Offset = "0x47172F0", VA = "0x1847186F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4717B30", Offset = "0x4716730", VA = "0x184717B30")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x47179F0", Offset = "0x47165F0", VA = "0x1847179F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ELMMBGGKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4717BD0", Offset = "0x47167D0", VA = "0x184717BD0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4717EA0", Offset = "0x4716AA0", VA = "0x184717EA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x47178A0", Offset = "0x47164A0", VA = "0x1847178A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4718430", Offset = "0x4717030", VA = "0x184718430", Slot = "10")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4719590", Offset = "0x4718190", VA = "0x184719590")]
	public ECKLEAGCICH([In] KNONDDEMAGD PEDMEJIDLNB, T IEPFBBNOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4717C50", Offset = "0x4716850", VA = "0x184717C50")]
	private void LFPPKHBIMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4718720", Offset = "0x4717320", VA = "0x184718720", Slot = "5")]
	public void OBAFLOEECHH(T LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4718740", Offset = "0x4717340", VA = "0x184718740")]
	public void OBAFLOEECHH(T LFLPFMMDGLM, bool DPILOMJFJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47178C0", Offset = "0x47164C0", VA = "0x1847178C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BCFBNLECFBF<T1, T2> : ACMDAAKJFGK<(T1, T2)>, ODPNKHICGED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PPBCPDJCLFL<T1, T2> GJIDLDGPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PPBCPDJCLFL<T1, T2> IMCFIPHGBJA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string JOMDPKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB20", Offset = "0xE9C720", VA = "0x180E9DB20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BPKHAIECPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61D3290", Offset = "0x61D1E90", VA = "0x1861D3290", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PDFOMFGCFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x52CC590", Offset = "0x52CB190", VA = "0x1852CC590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CIMLDANGCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61D2FE0", Offset = "0x61D1BE0", VA = "0x1861D2FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) CMPPNNHMNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61D2450", Offset = "0x61D1050", VA = "0x1861D2450", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61D3C10", Offset = "0x61D2810", VA = "0x1861D3C10", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) GCLCELGFKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61D2860", Offset = "0x61D1460", VA = "0x1861D2860", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61D37A0", Offset = "0x61D23A0", VA = "0x1861D37A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61D2EC0", Offset = "0x61D1AC0", VA = "0x1861D2EC0")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x61D25E0", Offset = "0x61D11E0", VA = "0x1861D25E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 PAKHOBMPNJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61D3E40", Offset = "0x61D2A40", VA = "0x1861D3E40")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61D1C90", Offset = "0x61D0890", VA = "0x1861D1C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 GGALCMNHPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61D2060", Offset = "0x61D0C60", VA = "0x1861D2060")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 PCDBLMJDBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61D2060", Offset = "0x61D0C60", VA = "0x1861D2060")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61D1C90", Offset = "0x61D0890", VA = "0x1861D1C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 PEBAIFODDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61D3DB0", Offset = "0x61D29B0", VA = "0x1861D3DB0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61D1C20", Offset = "0x61D0820", VA = "0x1861D1C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 BMEGGAIBMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61D1D00", Offset = "0x61D0900", VA = "0x1861D1D00")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 NJIOPPAKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x61D1D00", Offset = "0x61D0900", VA = "0x1861D1D00")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61D1C20", Offset = "0x61D0820", VA = "0x1861D1C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ELMMBGGKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4717BD0", Offset = "0x47167D0", VA = "0x184717BD0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4717EA0", Offset = "0x4716AA0", VA = "0x184717EA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61D3520", Offset = "0x61D2120", VA = "0x1861D3520", Slot = "10")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61D4090", Offset = "0x61D2C90", VA = "0x1861D4090")]
	public BCFBNLECFBF([In] KNONDDEMAGD PEDMEJIDLNB, T1 EEBHJMHPAMF, T2 DBBFODMPBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61D2DC0", Offset = "0x61D19C0", VA = "0x1861D2DC0")]
	private void LFPPKHBIMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61D1E50", Offset = "0x61D0A50", VA = "0x1861D1E50")]
	public void DOEFEMDBNKA(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61D3880", Offset = "0x61D2480", VA = "0x1861D3880")]
	public void OBAFLOEECHH(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61D3680", Offset = "0x61D2280", VA = "0x1861D3680", Slot = "5")]
	private void NHPJIPEIGCD((T1, T2) GCKEIIMJEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x47178C0", Offset = "0x47164C0", VA = "0x1847178C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LNBFCLGKELI<T1, T2, T3> : ACMDAAKJFGK<(T1, T2, T3)>, ODPNKHICGED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HDENFIGPFIH<T1, T2, T3> GJIDLDGPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HDENFIGPFIH<T1, T2, T3> IMCFIPHGBJA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string JOMDPKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB20", Offset = "0xE9C720", VA = "0x180E9DB20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BPKHAIECPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4718030", Offset = "0x4716C30", VA = "0x184718030", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool PDFOMFGCFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x52CC590", Offset = "0x52CB190", VA = "0x1852CC590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CIMLDANGCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x52CD4B0", Offset = "0x52CC0B0", VA = "0x1852CD4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BOJDNDEDHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x52CBFD0", Offset = "0x52CABD0", VA = "0x1852CBFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) CMPPNNHMNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x52CC870", Offset = "0x52CB470", VA = "0x1852CC870", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x52CDCE0", Offset = "0x52CC8E0", VA = "0x1852CDCE0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) GCLCELGFKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x52CCDA0", Offset = "0x52CB9A0", VA = "0x1852CCDA0", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x52CD830", Offset = "0x52CC430", VA = "0x1852CD830", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 PAKHOBMPNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x52CDEB0", Offset = "0x52CCAB0", VA = "0x1852CDEB0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 GGALCMNHPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x52CC550", Offset = "0x52CB150", VA = "0x1852CC550")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 PCDBLMJDBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x52CC550", Offset = "0x52CB150", VA = "0x1852CC550")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x52CC240", Offset = "0x52CAE40", VA = "0x1852CC240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 PEBAIFODDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x52CDE70", Offset = "0x52CCA70", VA = "0x1852CDE70")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 BMEGGAIBMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x52CC270", Offset = "0x52CAE70", VA = "0x1852CC270")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 NJIOPPAKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x52CC270", Offset = "0x52CAE70", VA = "0x1852CC270")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x52CC210", Offset = "0x52CAE10", VA = "0x1852CC210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 PIGOCNCEJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52CC830", Offset = "0x52CB430", VA = "0x1852CC830")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 BIGBCKMHDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x52CBF90", Offset = "0x52CAB90", VA = "0x1852CBF90")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 COAPDIAOHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x52CBF90", Offset = "0x52CAB90", VA = "0x1852CBF90")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x52CC7D0", Offset = "0x52CB3D0", VA = "0x1852CC7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ELMMBGGKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4717BD0", Offset = "0x47167D0", VA = "0x184717BD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x52CD780", Offset = "0x52CC380", VA = "0x1852CD780", Slot = "10")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x52CE110", Offset = "0x52CCD10", VA = "0x1852CE110")]
	public LNBFCLGKELI([In] KNONDDEMAGD PEDMEJIDLNB, T1 EEBHJMHPAMF, T2 DBBFODMPBDO, T3 MCMLIKOOECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x52CCEB0", Offset = "0x52CBAB0", VA = "0x1852CCEB0")]
	private void LFPPKHBIMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x52CC390", Offset = "0x52CAF90", VA = "0x1852CC390")]
	public void DOEFEMDBNKA(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x52CD2F0", Offset = "0x52CBEF0", VA = "0x1852CD2F0")]
	public void LKINAMGMGGJ(T2 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x52CDA30", Offset = "0x52CC630", VA = "0x1852CDA30")]
	public void OBOAEAALKOM(T3 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x52CD910", Offset = "0x52CC510", VA = "0x1852CD910")]
	public void OBAFLOEECHH(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE, T3 DKKNCMHBJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x52CD1E0", Offset = "0x52CBDE0", VA = "0x1852CD1E0", Slot = "5")]
	private void LGCDPCGCDAH((T1, T2, T3) GCKEIIMJEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47178C0", Offset = "0x47164C0", VA = "0x1847178C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AAIGDHDODII<T1, T2, T3, T4> : ACMDAAKJFGK<(T1, T2, T3, T4)>, ODPNKHICGED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GKONNCIIGCM<T1, T2, T3, T4> GJIDLDGPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GKONNCIIGCM<T1, T2, T3, T4> IMCFIPHGBJA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JOMDPKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB20", Offset = "0xE9C720", VA = "0x180E9DB20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) GCLCELGFKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4CDED70", Offset = "0x4CDD970", VA = "0x184CDED70", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4CDF270", Offset = "0x4CDDE70", VA = "0x184CDF270", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 BMEGGAIBMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4C123E0", Offset = "0x4C10FE0", VA = "0x184C123E0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 BIGBCKMHDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4C12B00", Offset = "0x4C11700", VA = "0x184C12B00")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 GJJANIECLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4CDEAA0", Offset = "0x4CDD6A0", VA = "0x184CDEAA0")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ELMMBGGKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4717BD0", Offset = "0x47167D0", VA = "0x184717BD0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4717EA0", Offset = "0x4716AA0", VA = "0x184717EA0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4CDF590", Offset = "0x4CDE190", VA = "0x184CDF590")]
	public AAIGDHDODII([In] KNONDDEMAGD PEDMEJIDLNB, T1 EEBHJMHPAMF, T2 DBBFODMPBDO, T3 MCMLIKOOECM, T4 MKLCGKLDLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4CDF100", Offset = "0x4CDDD00", VA = "0x184CDF100")]
	private void LFPPKHBIMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4CDEAE0", Offset = "0x4CDD6E0", VA = "0x184CDEAE0")]
	public void DOEFEMDBNKA(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4CDF310", Offset = "0x4CDDF10", VA = "0x184CDF310")]
	public void OBAFLOEECHH(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE, T3 DKKNCMHBJIJ, T4 FPLEPPOHFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4CDED30", Offset = "0x4CDD930", VA = "0x184CDED30", Slot = "5")]
	private void GHODBOCAADP((T1, T2, T3, T4) GCKEIIMJEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47178C0", Offset = "0x47164C0", VA = "0x1847178C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ECHJBFJMCJF
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F139B0", Offset = "0x7F125B0", VA = "0x187F139B0")]
	public static string PCFFJOFAMJP(this KNONDDEMAGD PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xC78550", Offset = "0xC77150", VA = "0x180C78550")]
	public static KOIOFPLKNJB DGEIBBHALPJ(this KNONDDEMAGD PEDMEJIDLNB)
	{
		return default(KOIOFPLKNJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PJKJLIKNEPK<T> : EHBNCHCMDJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x474F580", Offset = "0x474E180", VA = "0x18474F580")]
	public PJKJLIKNEPK([In] KNONDDEMAGD PEDMEJIDLNB, T IPOLOHBNCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x57DF730", Offset = "0x57DE330", VA = "0x1857DF730")]
	public PJKJLIKNEPK(LMDGBFCAGOP CBLPKFIJGLH, BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, T IPOLOHBNCGD, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57DDD70", Offset = "0x57DC970", VA = "0x1857DDD70")]
	public PJKJLIKNEPK(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T IPOLOHBNCGD, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57DF480", Offset = "0x57DE080", VA = "0x1857DF480")]
	public PJKJLIKNEPK(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T IPOLOHBNCGD, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PPBCPDJCLFL<T1, T2> : JKFGNILAJPE<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57ECD50", Offset = "0x57EB950", VA = "0x1857ECD50")]
	public PPBCPDJCLFL([In] KNONDDEMAGD PEDMEJIDLNB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x57EE210", Offset = "0x57ECE10", VA = "0x1857EE210")]
	public PPBCPDJCLFL(LMDGBFCAGOP CBLPKFIJGLH, BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x57EEB30", Offset = "0x57ED730", VA = "0x1857EEB30")]
	public PPBCPDJCLFL(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57ED5E0", Offset = "0x57EC1E0", VA = "0x1857ED5E0")]
	public PPBCPDJCLFL(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HDENFIGPFIH<T1, T2, T3> : PBKBPPNBOON<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42C4B90", Offset = "0x42C3790", VA = "0x1842C4B90")]
	public HDENFIGPFIH([In] KNONDDEMAGD PEDMEJIDLNB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BC40", Offset = "0x4D8A840", VA = "0x184D8BC40")]
	public HDENFIGPFIH(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GKONNCIIGCM<T1, T2, T3, T4> : BDLPMHPCCDL<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4D20200", Offset = "0x4D1EE00", VA = "0x184D20200")]
	public GKONNCIIGCM([In] KNONDDEMAGD PEDMEJIDLNB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA, T4 LFNOKCPFCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FFC0", Offset = "0x4D1EBC0", VA = "0x184D1FFC0")]
	public GKONNCIIGCM(LMDGBFCAGOP CBLPKFIJGLH, BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA, T4 LFNOKCPFCGG, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FDD0", Offset = "0x4D1E9D0", VA = "0x184D1FDD0")]
	public GKONNCIIGCM(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA, T4 LFNOKCPFCGG, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EADCMLFFLGE<T1, T2, T3, T4, T5> : LMDPCKJPJEG<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4709F20", Offset = "0x4708B20", VA = "0x184709F20")]
	public EADCMLFFLGE(LMDGBFCAGOP CBLPKFIJGLH, BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA, T4 LFNOKCPFCGG, T5 DIGCDJECBKA, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x470A130", Offset = "0x4708D30", VA = "0x18470A130")]
	public EADCMLFFLGE(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 HMONMCCCJNE, T2 NMDBJMIKGMM, T3 BNOJGOENJNA, T4 LFNOKCPFCGG, T5 DIGCDJECBKA, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NFCFCEIHOPG<T> : EHBNCHCMDJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5520400", Offset = "0x551F000", VA = "0x185520400")]
	public NFCFCEIHOPG(BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, T IPOLOHBNCGD, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NMAOBPCMCGA<T1, T2> : JKFGNILAJPE<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5534130", Offset = "0x5532D30", VA = "0x185534130")]
	public NMAOBPCMCGA(BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HAAIAOLBPGB
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PJKJLIKNEPK<T1> EDPCBFPPILD<T1>(string MEPFFFGIFGB, T1 FLHMKBKIKPA, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LMPNBJIGAKA : HAAIAOLBPGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EBCEOOFDNNE EMNJOLHMJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LMDGBFCAGOP CBLPKFIJGLH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public LMPNBJIGAKA(EBCEOOFDNNE EMNJOLHMJGO, LMDGBFCAGOP ECLOGDFKDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B990D0", Offset = "0x3B97CD0", VA = "0x183B990D0", Slot = "4")]
	public PJKJLIKNEPK<T1> EDPCBFPPILD<T1>(string MEPFFFGIFGB, T1 FLHMKBKIKPA, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BCLMGNMMIPD : LMDGBFCAGOP
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId ICMGGAFJNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LMDGBFCAGOP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool PLHJIOBGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool KPJCJJMKALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string BBKNACGELMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LGMFLLPKACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(PCIEBPKKENL BGDIJBGKCDF);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(PCIEBPKKENL BGDIJBGKCDF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FDHAFCEDHEE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F139F0", Offset = "0x7F125F0", VA = "0x187F139F0")]
	public static bool OHCPKPPHPFC(this LMDGBFCAGOP CBLPKFIJGLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBCEOOFDNNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BJCCECIKIFB PPMLHENPPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool BLNDBJDBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEIJOMGLGOC();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object IDIOLADKBLH(string MEPFFFGIFGB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object BHFFMCENKNC(BJCCECIKIFB JEHLDBHABMD, string MEPFFFGIFGB);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMDOLJCPHEO(string MEPFFFGIFGB, object LFLPFMMDGLM);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCJENNCBJHM(BJCCECIKIFB JEHLDBHABMD, string MEPFFFGIFGB, object LFLPFMMDGLM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPCJNMLLBOL<T>(string MEPFFFGIFGB, T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HPPPCACAAPB([CanBeNull] BJCCECIKIFB JEHLDBHABMD, string MEPFFFGIFGB, ONGOEAKCKGC KICBCNJMOFC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CNKAEADLEPO([CanBeNull] BJCCECIKIFB JEHLDBHABMD, string MEPFFFGIFGB, ONGOEAKCKGC KICBCNJMOFC);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T LKHJBMBEDKC<T>(object OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object LIICBILFPGG<T>(T IPOLOHBNCGD);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NHPLIJOFAKD();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LCHHPICBEOA();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJILAOJMIKH(string BGBBINOABDF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KNONDDEMAGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public BJCCECIKIFB NEOGODNGJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public LMDGBFCAGOP CBLPKFIJGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string MEPFFFGIFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public KOIOFPLKNJB HOHHOHENLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool OGAAMLCPPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action LKGGIMHKLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EBCEOOFDNNE EMNJOLHMJGO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F16330", Offset = "0x7F14F30", VA = "0x187F16330")]
	public KNONDDEMAGD(KNONDDEMAGD GMNGNCHKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F163B0", Offset = "0x7F14FB0", VA = "0x187F163B0")]
	public KNONDDEMAGD(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F162E0", Offset = "0x7F14EE0", VA = "0x187F162E0")]
	public static KNONDDEMAGD AFAOJPNNAAP(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, KOIOFPLKNJB HOHHOHENLLI, [Optional] Action LKGGIMHKLEG, [Optional] EBCEOOFDNNE EMNJOLHMJGO)
	{
		return default(KNONDDEMAGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FLGBIJHNKCE
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3A65770", Offset = "0x3A64370", VA = "0x183A65770")]
	public static PJKJLIKNEPK<T> CAPFBKCFBJJ<T>(this KNONDDEMAGD PEDMEJIDLNB, T IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3A65620", Offset = "0x3A64220", VA = "0x183A65620")]
	public static PPBCPDJCLFL<T1, T2> CAPFBKCFBJJ<T1, T2>(this KNONDDEMAGD PEDMEJIDLNB, T1 LKJIEEKDALK, T2 LJHMIPHFKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A656C0", Offset = "0x3A642C0", VA = "0x183A656C0")]
	public static HDENFIGPFIH<T1, T2, T3> CAPFBKCFBJJ<T1, T2, T3>(this KNONDDEMAGD PEDMEJIDLNB, T1 LKJIEEKDALK, T2 LJHMIPHFKFO, T3 PEEOPCAKFJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A65A30", Offset = "0x3A64630", VA = "0x183A65A30")]
	public static GKONNCIIGCM<T1, T2, T3, T4> CAPFBKCFBJJ<T1, T2, T3, T4>(this KNONDDEMAGD PEDMEJIDLNB, T1 LKJIEEKDALK, T2 LJHMIPHFKFO, T3 PEEOPCAKFJP, T4 LJFOPNEBKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A65770", Offset = "0x3A64370", VA = "0x183A65770")]
	public static ECKLEAGCICH<T> PMIHAHALBMO<T>(this KNONDDEMAGD PEDMEJIDLNB, T IPOLOHBNCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A65620", Offset = "0x3A64220", VA = "0x183A65620")]
	public static BCFBNLECFBF<T1, T2> PMIHAHALBMO<T1, T2>(this KNONDDEMAGD PEDMEJIDLNB, T1 LKJIEEKDALK, T2 LJHMIPHFKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A656C0", Offset = "0x3A642C0", VA = "0x183A656C0")]
	public static LNBFCLGKELI<T1, T2, T3> PMIHAHALBMO<T1, T2, T3>(this KNONDDEMAGD PEDMEJIDLNB, T1 LKJIEEKDALK, T2 LJHMIPHFKFO, T3 PEEOPCAKFJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A65A30", Offset = "0x3A64630", VA = "0x183A65A30")]
	public static AAIGDHDODII<T1, T2, T3, T4> PMIHAHALBMO<T1, T2, T3, T4>(this KNONDDEMAGD PEDMEJIDLNB, T1 LKJIEEKDALK, T2 LJHMIPHFKFO, T3 PEEOPCAKFJP, T4 LJFOPNEBKIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ONGOEAKCKGC : PCIEBPKKENL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum EKLJECBPHOL
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Disposed = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		LastSetLocally = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Synchronizing = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ModifiedOffline = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 4
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static Stack<EBCEOOFDNNE> IACFPOPLKFK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool PNLGPPHINHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly BJCCECIKIFB NEOGODNGJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly LMDGBFCAGOP CBLPKFIJGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string MEPFFFGIFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly KOIOFPLKNJB HOHHOHENLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action LKGGIMHKLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected EBCEOOFDNNE FBGGECHAIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private EKLJECBPHOL GEFKHBLJENB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static EBCEOOFDNNE NEGLOCAIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F16F40", Offset = "0x7F15B40", VA = "0x187F16F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool ACOEMJJIKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F16B90", Offset = "0x7F15790", VA = "0x187F16B90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F17900", Offset = "0x7F16500", VA = "0x187F17900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool LPFALOHFAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F16B80", Offset = "0x7F15780", VA = "0x187F16B80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F16BA0", Offset = "0x7F157A0", VA = "0x187F16BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool LGKMJAIFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F168A0", Offset = "0x7F154A0", VA = "0x187F168A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F17620", Offset = "0x7F16220", VA = "0x187F17620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool ELMMBGGKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F170F0", Offset = "0x7F15CF0", VA = "0x187F170F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F173E0", Offset = "0x7F15FE0", VA = "0x187F173E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object FHLOHBNEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA24890", Offset = "0xA23490", VA = "0x180A24890", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool MDLLAPKJPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F17100", Offset = "0x7F15D00", VA = "0x187F17100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NOGLOAIEFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xDCF4D0", Offset = "0xDCE0D0", VA = "0x180DCF4D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xF20A10", Offset = "0xF1F610", VA = "0x180F20A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string JOMDPKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F16660", Offset = "0x7F15260", VA = "0x187F16660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F17920", Offset = "0x7F16520", VA = "0x187F17920")]
	public static void PLBHEDKBDMD(EBCEOOFDNNE KNBBCEAPFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HBKHOOAAOPP();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F17C10", Offset = "0x7F16810", VA = "0x187F17C10")]
	protected ONGOEAKCKGC(BJCCECIKIFB NEOGODNGJJE, LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, KOIOFPLKNJB HOHHOHENLLI, Action LKGGIMHKLEG, EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F16BC0", Offset = "0x7F157C0", VA = "0x187F16BC0", Slot = "1")]
	~ONGOEAKCKGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F168B0", Offset = "0x7F154B0", VA = "0x187F168B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F17860", Offset = "0x7F16460", VA = "0x187F17860")]
	private void PJGJNEOFNHI(bool LPMOFKACFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F16730", Offset = "0x7F15330", VA = "0x187F16730")]
	private object CLMGAFLPKEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F17150", Offset = "0x7F15D50", VA = "0x187F17150")]
	protected void LEIJOMGLGOC(bool OGAAMLCPPGF, object IEPFBBNOGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F17820", Offset = "0x7F16420", VA = "0x187F17820")]
	protected void PEPEIECOOBP(object LFLPFMMDGLM, bool DEEMMJHBOHO = true, bool IOPPIJJALFP = false, bool DPILOMJFJBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F16C20", Offset = "0x7F15820", VA = "0x187F16C20")]
	protected void HECLGIIMMJA(object LFLPFMMDGLM, bool GPFEBMKIGAI, bool DEEMMJHBOHO, bool IOPPIJJALFP = false, bool DPILOMJFJBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F166B0", Offset = "0x7F152B0", VA = "0x187F166B0")]
	internal void CIFDLAMJKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F16EE0", Offset = "0x7F15AE0", VA = "0x187F16EE0")]
	private void HMHLPPAIFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F17B10", Offset = "0x7F16710", VA = "0x187F17B10")]
	private void PPPIALKCOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F16E70", Offset = "0x7F15A70", VA = "0x187F16E70", Slot = "4")]
	private void HHIHPJCGHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F17800", Offset = "0x7F16400", VA = "0x187F17800", Slot = "5")]
	private void PBBJHLKBING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F16FB0", Offset = "0x7F15BB0", VA = "0x187F16FB0")]
	public bool JMCODLCJLDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F17640", Offset = "0x7F16240", VA = "0x187F17640")]
	public bool PADLLLBFLPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F179C0", Offset = "0x7F165C0", VA = "0x187F179C0")]
	private bool PNPLHMEAPCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F17310", Offset = "0x7F15F10", VA = "0x187F17310")]
	internal void LNNPMHNOADE(object LFLPFMMDGLM, int JENOBCBPAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F16550", Offset = "0x7F15150", VA = "0x187F16550")]
	private void ADBIEECIJNB(object LFLPFMMDGLM, bool IOPPIJJALFP, bool DPILOMJFJBK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F17810", Offset = "0x7F16410", VA = "0x187F17810")]
	private bool PCMJOFJMEHO(EKLJECBPHOL FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F173C0", Offset = "0x7F15FC0", VA = "0x187F173C0")]
	private void MLHCMJKHLDJ(EKLJECBPHOL FCCNKGNGPGC, bool OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F174A0", Offset = "0x7F160A0", VA = "0x187F174A0")]
	public static string NECBMJFIDCF(BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F17540", Offset = "0x7F16140", VA = "0x187F17540")]
	public static string NMEKHIEEOCH(LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F16A20", Offset = "0x7F15620", VA = "0x187F16A20")]
	public static bool EGDKKOJCIPB(object ABBBJFPFEKP, object KLKIJPOLHDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class JPDPDOCHPLI : EBCEOOFDNNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> APNHEJEKBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> IBHMHILIILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> FPLBHCOENME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> AKAEPDNLDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool OCBGCPNOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> GGGLIGBGOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<BJCCECIKIFB, Dictionary<string, object>> DBKIMIHCCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> AOJACENDECA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> KBFJPDCMEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int MGCKPJHLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract BJCCECIKIFB PPMLHENPPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool BLNDBJDBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool BKFAFNGBOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B37350", Offset = "0x3B35F50", VA = "0x183B37350", Slot = "12")]
	public void NPCJNMLLBOL<T>(string MEPFFFGIFGB, T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F15C80", Offset = "0x7F14880", VA = "0x187F15C80", Slot = "11")]
	public void MCJENNCBJHM(BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB, object OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F13A40", Offset = "0x7F12640", VA = "0x187F13A40", Slot = "9")]
	public object BHFFMCENKNC(BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F13DD0", Offset = "0x7F129D0", VA = "0x187F13DD0", Slot = "10")]
	public void CMDOLJCPHEO(string MEPFFFGIFGB, object OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F14830", Offset = "0x7F13430", VA = "0x187F14830", Slot = "8")]
	public object IDIOLADKBLH(string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F14720", Offset = "0x7F13320", VA = "0x187F14720", Slot = "13")]
	public void HPPPCACAAPB(BJCCECIKIFB JEHLDBHABMD, string MEPFFFGIFGB, ONGOEAKCKGC KICBCNJMOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F13EF0", Offset = "0x7F12AF0", VA = "0x187F13EF0", Slot = "14")]
	public void CNKAEADLEPO(BJCCECIKIFB JEHLDBHABMD, string MEPFFFGIFGB, ONGOEAKCKGC KICBCNJMOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F14590", Offset = "0x7F13190", VA = "0x187F14590")]
	private void EKMNJMMFCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F145E0", Offset = "0x7F131E0", VA = "0x187F145E0")]
	private void EOMKIBFFACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F15F80", Offset = "0x7F14B80", VA = "0x187F15F80")]
	private void PBLEDFOJDLN(BJCCECIKIFB NEOGODNGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F148D0", Offset = "0x7F134D0", VA = "0x187F148D0")]
	protected void IJHIFKAPNNI(BJCCECIKIFB PALFCPJOMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F14630", Offset = "0x7F13230", VA = "0x187F14630")]
	protected void GIOCIHJFEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F15F70", Offset = "0x7F14B70", VA = "0x187F15F70")]
	protected void NLPGCCOMMKP(IDictionary<object, object> NIPKBGOKPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F15C10", Offset = "0x7F14810", VA = "0x187F15C10")]
	protected void LNAFHCOLKPN(BJCCECIKIFB NJCDGENKHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F14500", Offset = "0x7F13100", VA = "0x187F14500")]
	protected void EKIAIBMJADF(BJCCECIKIFB NEOGODNGJJE, IDictionary<object, object> NIPKBGOKPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F14C20", Offset = "0x7F13820", VA = "0x187F14C20")]
	private void JOBHEKNBGKD(IDictionary<object, object> NIPKBGOKPJD, Dictionary<string, object> FGHOKMBGJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F141A0", Offset = "0x7F12DA0", VA = "0x187F141A0")]
	private static void COFJNBNDEJN(object APMLNPNOMDO, object NMCGBFDKCMK, int JENOBCBPAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F14A00", Offset = "0x7F13600", VA = "0x187F14A00")]
	private static void JKABBJOFOIM(Dictionary<string, object> FGHOKMBGJKI, string MEPFFFGIFGB, ONGOEAKCKGC KICBCNJMOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F153C0", Offset = "0x7F13FC0", VA = "0x187F153C0")]
	private static void KMPJGDMGCHF(Dictionary<string, object> FGHOKMBGJKI, string MEPFFFGIFGB, ONGOEAKCKGC KICBCNJMOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F15E70", Offset = "0x7F14A70", VA = "0x187F15E70", Slot = "17")]
	public void NHPLIJOFAKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void FBHMNKGBLEE(Dictionary<object, object> APNHEJEKBNK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F15590", Offset = "0x7F14190", VA = "0x187F15590", Slot = "18")]
	public void LCHHPICBEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void LMPFOHPLPLF(Dictionary<object, object> FPLBHCOENME);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F15670", Offset = "0x7F14270", VA = "0x187F15670")]
	private void LFLGHBMNICB(Dictionary<object, object> DKAIEMLDAEK, List<string> PPEMCCLPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F15140", Offset = "0x7F13D40", VA = "0x187F15140")]
	private void KGMCFEAGCOL(IDictionary<object, object> NIPKBGOKPJD, [Out] int JENOBCBPAHG, [Out] string[] EOEIHCEIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F150B0", Offset = "0x7F13CB0", VA = "0x187F150B0")]
	public void KBEHMBBGLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F15FE0", Offset = "0x7F14BE0", VA = "0x187F15FE0")]
	public void PDKBOPOBOLO(BJCCECIKIFB NEOGODNGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F158A0", Offset = "0x7F144A0", VA = "0x187F158A0")]
	public void LFPMENNIFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> PKPDGGJDBCA(bool BAGDOFOCCDP, bool ICFOIGCANBA);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F13B40", Offset = "0x7F12740", VA = "0x187F13B40", Slot = "19")]
	public void CJILAOJMIKH(string BGBBINOABDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7F15DD0", Offset = "0x7F149D0", VA = "0x187F15DD0")]
	protected string NECBMJFIDCF(BJCCECIKIFB NEOGODNGJJE, string MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object LIICBILFPGG<T>(T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T LKHJBMBEDKC<T>(object OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "32")]
	public virtual void LEIJOMGLGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F143A0", Offset = "0x7F12FA0", VA = "0x187F143A0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "33")]
	protected virtual void NILEHFMODDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F160B0", Offset = "0x7F14CB0", VA = "0x187F160B0")]
	protected JPDPDOCHPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class EHBNCHCMDJH<T1> : ONGOEAKCKGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 FLHMKBKIKPA;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 GDHNDOGFGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1154520", Offset = "0x1153120", VA = "0x181154520", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1154540", Offset = "0x1153140", VA = "0x181154540", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object FHLOHBNEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4728960", Offset = "0x4727560", VA = "0x184728960", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4727280", Offset = "0x4725E80", VA = "0x184727280", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4727E60", Offset = "0x4726A60", VA = "0x184727E60", Slot = "9")]
	protected override bool HBKHOOAAOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x472B5A0", Offset = "0x472A1A0", VA = "0x18472B5A0")]
	protected EHBNCHCMDJH([In] KNONDDEMAGD PEDMEJIDLNB, T1 FLHMKBKIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x472C6A0", Offset = "0x472B2A0", VA = "0x18472C6A0")]
	protected EHBNCHCMDJH(BJCCECIKIFB NEOGODNGJJE, LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 FLHMKBKIKPA, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, Action LKGGIMHKLEG, EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4728850", Offset = "0x4727450", VA = "0x184728850")]
	public T1 LBDBFELEJGA()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4728980", Offset = "0x4727580", VA = "0x184728980")]
	public void PEPEIECOOBP(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4728BE0", Offset = "0x47277E0", VA = "0x184728BE0")]
	public void PEPEIECOOBP(T1 LFLPFMMDGLM, bool DEEMMJHBOHO, bool IOPPIJJALFP = false, bool DPILOMJFJBK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JKFGNILAJPE<T1, T2> : ONGOEAKCKGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 FLHMKBKIKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 HNHBBOILGID;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 GDHNDOGFGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xF78050", Offset = "0xF76C50", VA = "0x180F78050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1154530", Offset = "0x1153130", VA = "0x181154530", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 FENOFBHEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF6F830", Offset = "0xF6E430", VA = "0x180F6F830", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xF77D60", Offset = "0xF76960", VA = "0x180F77D60", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 IDLMPEGOFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5103800", Offset = "0x5102400", VA = "0x185103800")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object FHLOHBNEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4728960", Offset = "0x4727560", VA = "0x184728960", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x51035B0", Offset = "0x51021B0", VA = "0x1851035B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x51045F0", Offset = "0x51031F0", VA = "0x1851045F0", Slot = "9")]
	protected override bool HBKHOOAAOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5108B20", Offset = "0x5107720", VA = "0x185108B20")]
	protected JKFGNILAJPE([In] KNONDDEMAGD PEDMEJIDLNB, T1 FLHMKBKIKPA, T2 HNHBBOILGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5109AA0", Offset = "0x51086A0", VA = "0x185109AA0")]
	protected JKFGNILAJPE(BJCCECIKIFB NEOGODNGJJE, LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, Action LKGGIMHKLEG, EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4728850", Offset = "0x4727450", VA = "0x184728850")]
	public T1 ONGBLOENEPB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5103940", Offset = "0x5102540", VA = "0x185103940")]
	public void GHHMMHEIAKD(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5103800", Offset = "0x5102400", VA = "0x185103800")]
	public T2 GDHPAFLNBKB()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x51055F0", Offset = "0x51041F0", VA = "0x1851055F0")]
	public void OJLMJEBCOPN(T2 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5106B30", Offset = "0x5105730", VA = "0x185106B30")]
	public void PEPEIECOOBP(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE, bool DEEMMJHBOHO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class PBKBPPNBOON<T1, T2, T3> : ONGOEAKCKGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 FLHMKBKIKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 HNHBBOILGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 LLMDNENOBEN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 GDHNDOGFGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23230", VA = "0x180A24630", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA248B0", Offset = "0xA234B0", VA = "0x180A248B0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 FENOFBHEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xFB2570", Offset = "0xFB1170", VA = "0x180FB2570", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xFB05B0", Offset = "0xFAF1B0", VA = "0x180FB05B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 OLBHINODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA383A0", Offset = "0xA36FA0", VA = "0x180A383A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xD26AE0", Offset = "0xD256E0", VA = "0x180D26AE0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 BBJNHIFMEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4728850", Offset = "0x4727450", VA = "0x184728850")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 IDLMPEGOFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5103800", Offset = "0x5102400", VA = "0x185103800")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 OEOCNLDDDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x52C7D10", Offset = "0x52C6910", VA = "0x1852C7D10")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object FHLOHBNEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4728960", Offset = "0x4727560", VA = "0x184728960", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x57B6370", Offset = "0x57B4F70", VA = "0x1857B6370", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x57B7860", Offset = "0x57B6460", VA = "0x1857B7860", Slot = "9")]
	protected override bool HBKHOOAAOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x57BC830", Offset = "0x57BB430", VA = "0x1857BC830")]
	protected PBKBPPNBOON([In] KNONDDEMAGD PEDMEJIDLNB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, T3 LLMDNENOBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x57BBD00", Offset = "0x57BA900", VA = "0x1857BBD00")]
	protected PBKBPPNBOON(BJCCECIKIFB NEOGODNGJJE, LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, T3 LLMDNENOBEN, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, Action LKGGIMHKLEG, EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4728850", Offset = "0x4727450", VA = "0x184728850")]
	public T1 ONGBLOENEPB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x57B7370", Offset = "0x57B5F70", VA = "0x1857B7370")]
	public void GHHMMHEIAKD(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5103800", Offset = "0x5102400", VA = "0x185103800")]
	public T2 GDHPAFLNBKB()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x57B8FE0", Offset = "0x57B7BE0", VA = "0x1857B8FE0")]
	public void OJLMJEBCOPN(T2 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x52C7D10", Offset = "0x52C6910", VA = "0x1852C7D10")]
	public T3 JKHKGHCMJFO()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x57B5BC0", Offset = "0x57B47C0", VA = "0x1857B5BC0")]
	public void DKIHGBNNBMA(T3 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x57BAB50", Offset = "0x57B9750", VA = "0x1857BAB50")]
	public void PEPEIECOOBP(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE, T3 DKKNCMHBJIJ, bool DEEMMJHBOHO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class BDLPMHPCCDL<T1, T2, T3, T4> : ONGOEAKCKGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 FLHMKBKIKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 HNHBBOILGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 LLMDNENOBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 BFBALMJCMOM;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 GDHNDOGFGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xE57AA0", Offset = "0xE566A0", VA = "0x180E57AA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xF61060", Offset = "0xF5FC60", VA = "0x180F61060", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 FENOFBHEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF0A0", Offset = "0x1DBDCA0", VA = "0x181DBF0A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x52C50A0", Offset = "0x52C3CA0", VA = "0x1852C50A0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 OLBHINODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x61D9400", Offset = "0x61D8000", VA = "0x1861D9400", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x61D93F0", Offset = "0x61D7FF0", VA = "0x1861D93F0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 GAEGAENFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1537DB0", Offset = "0x15369B0", VA = "0x181537DB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x14CB500", Offset = "0x14CA100", VA = "0x1814CB500", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 IDLMPEGOFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5103820", Offset = "0x5102420", VA = "0x185103820")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 OEOCNLDDDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x57B7120", Offset = "0x57B5D20", VA = "0x1857B7120")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 ACAABNCKJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xC93150", Offset = "0xC91D50", VA = "0x180C93150")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object FHLOHBNEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4728960", Offset = "0x4727560", VA = "0x184728960", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x61D8AE0", Offset = "0x61D76E0", VA = "0x1861D8AE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61D8FE0", Offset = "0x61D7BE0", VA = "0x1861D8FE0", Slot = "9")]
	protected override bool HBKHOOAAOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x61D9A50", Offset = "0x61D8650", VA = "0x1861D9A50")]
	protected BDLPMHPCCDL([In] KNONDDEMAGD PEDMEJIDLNB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, T3 LLMDNENOBEN, T4 BFBALMJCMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x61D9B00", Offset = "0x61D8700", VA = "0x1861D9B00")]
	protected BDLPMHPCCDL(BJCCECIKIFB NEOGODNGJJE, LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, T3 LLMDNENOBEN, T4 BFBALMJCMOM, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, Action LKGGIMHKLEG, EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4728850", Offset = "0x4727450", VA = "0x184728850")]
	public T1 ONGBLOENEPB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x61D8EF0", Offset = "0x61D7AF0", VA = "0x1861D8EF0")]
	public void GHHMMHEIAKD(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5103820", Offset = "0x5102420", VA = "0x185103820")]
	public T2 GDHPAFLNBKB()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x61D9410", Offset = "0x61D8010", VA = "0x1861D9410")]
	public void OJLMJEBCOPN(T2 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x57B7120", Offset = "0x57B5D20", VA = "0x1857B7120")]
	public T3 JKHKGHCMJFO()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x61D8A00", Offset = "0x61D7600", VA = "0x1861D8A00")]
	public void DKIHGBNNBMA(T3 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xC93150", Offset = "0xC91D50", VA = "0x180C93150")]
	public T4 BLPPHMGGEDE()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x61D9300", Offset = "0x61D7F00", VA = "0x1861D9300")]
	public void IJBJPJJABFO(T4 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x61D94F0", Offset = "0x61D80F0", VA = "0x1861D94F0")]
	public void PEPEIECOOBP(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE, T3 DKKNCMHBJIJ, T4 FPLEPPOHFPF, bool DEEMMJHBOHO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class LMDPCKJPJEG<T1, T2, T3, T4, T5> : ONGOEAKCKGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 FLHMKBKIKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 HNHBBOILGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 LLMDNENOBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 BFBALMJCMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 KEAJIGCFDJC;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 GDHNDOGFGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xBE52E0", Offset = "0xBE3EE0", VA = "0x180BE52E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x13713B0", Offset = "0x136FFB0", VA = "0x1813713B0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 FENOFBHEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x147F050", Offset = "0x147DC50", VA = "0x18147F050", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x147E0A0", Offset = "0x147CCA0", VA = "0x18147E0A0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 OLBHINODCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA383A0", Offset = "0xA36FA0", VA = "0x180A383A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xD26AE0", Offset = "0xD256E0", VA = "0x180D26AE0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 GAEGAENFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA54660", Offset = "0xA53260", VA = "0x180A54660", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA546C0", Offset = "0xA532C0", VA = "0x180A546C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 BOJNFMCFOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x167D090", Offset = "0x167BC90", VA = "0x18167D090", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x167C420", Offset = "0x167B020", VA = "0x18167C420", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object FHLOHBNEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4728960", Offset = "0x4727560", VA = "0x184728960", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x52C5590", Offset = "0x52C4190", VA = "0x1852C5590", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x52C6A80", Offset = "0x52C5680", VA = "0x1852C6A80", Slot = "9")]
	protected override bool HBKHOOAAOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x52CA6B0", Offset = "0x52C92B0", VA = "0x1852CA6B0")]
	protected LMDPCKJPJEG(BJCCECIKIFB NEOGODNGJJE, LMDGBFCAGOP CBLPKFIJGLH, string MEPFFFGIFGB, T1 FLHMKBKIKPA, T2 HNHBBOILGID, T3 LLMDNENOBEN, T4 BFBALMJCMOM, T5 KEAJIGCFDJC, KOIOFPLKNJB HOHHOHENLLI, bool OGAAMLCPPGF, Action LKGGIMHKLEG, EBCEOOFDNNE EMNJOLHMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4728850", Offset = "0x4727450", VA = "0x184728850")]
	public T1 ONGBLOENEPB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x52C67F0", Offset = "0x52C53F0", VA = "0x1852C67F0")]
	public void GHHMMHEIAKD(T1 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5103800", Offset = "0x5102400", VA = "0x185103800")]
	public T2 GDHPAFLNBKB()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x52C80F0", Offset = "0x52C6CF0", VA = "0x1852C80F0")]
	public void OJLMJEBCOPN(T2 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x52C7D10", Offset = "0x52C6910", VA = "0x1852C7D10")]
	public T3 JKHKGHCMJFO()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x52C52C0", Offset = "0x52C3EC0", VA = "0x1852C52C0")]
	public void DKIHGBNNBMA(T3 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xC93150", Offset = "0xC91D50", VA = "0x180C93150")]
	public T4 BLPPHMGGEDE()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x52C7A90", Offset = "0x52C6690", VA = "0x1852C7A90")]
	public void IJBJPJJABFO(T4 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x52C7D30", Offset = "0x52C6930", VA = "0x1852C7D30")]
	public T5 NBLECBIDFCE()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x52C6090", Offset = "0x52C4C90", VA = "0x1852C6090")]
	public void FNPNNGNLOAM(T5 LFLPFMMDGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x52C8E00", Offset = "0x52C7A00", VA = "0x1852C8E00")]
	public void PEPEIECOOBP(T1 EIIFDKPIIFI, T2 DMPNOJEIBOE, T3 DKKNCMHBJIJ, T4 FPLEPPOHFPF, T5 MOMDFNHDMFC)
	{
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
