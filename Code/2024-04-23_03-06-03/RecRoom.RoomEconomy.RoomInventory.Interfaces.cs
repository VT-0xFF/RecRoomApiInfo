using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BKBFEBFOLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly OFNGBMBINJK MIFKFNANLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long JFLFCJGPPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IGLGGNHIMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68A5200", Offset = "0x68A4200", VA = "0x1868A5200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68A5210", Offset = "0x68A4210", VA = "0x1868A5210")]
	public BKBFEBFOLKF(OFNGBMBINJK NIKEINPNLMA, long MJMIIGGLEFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GHGKCHPHDOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FLBNEICBMFL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ONDMBBPPJJI KPPPNMELLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MIADACEFMCK<MFCOBPENAHE> MNMNHFDNKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MIADACEFMCK<Guid> EKGJBKOEELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EFKALDPIAIL<ICEEACBIJLM, int> DBCEFGLHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MIADACEFMCK<GGHODFNPAIM> GDAEOIKLECO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MIADACEFMCK<long> IOICCAGFDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ONDMBBPPJJI IJEFFPHCJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<PGLGENBDGKP<MFCOBPENAHE, string>> ANNDOEIDAMG(long CFLPHBNCGDP, string ONGJKHHOIAM, string OCBNPBFKEJE, string PGHOFOPCAFH, RoomInventoryItemProperties OJBDIKJIJPD, byte FMEBIBHEFLO, int IODHIPGGADP, [Optional] List<long> FBOMDLJOBNN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<PGLGENBDGKP<MFCOBPENAHE, string>> KCBLAGCPPFH(Guid MIPLHHGEGFK, [Optional] string ONGJKHHOIAM, [Optional] string OCBNPBFKEJE, [Optional] string PGHOFOPCAFH, [Optional] List<long> FBOMDLJOBNN, [Optional] RoomInventoryItemProperties OJBDIKJIJPD, [Optional] byte? FMEBIBHEFLO, [Optional] int? IODHIPGGADP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PGLGENBDGKP<bool, string>> OBDLJLCDMBM(Guid MIPLHHGEGFK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<MFCOBPENAHE> NNLJEIMEKEL();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<MFCOBPENAHE> MICEDIFILLK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool HANDLONIAGH();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool FPLBPKKEJMJ(Guid MIPLHHGEGFK, [Out] MFCOBPENAHE CNLNMMDJGGM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OCNDBHBEBKP(string ANAFMJPCHJB, [Out] MFCOBPENAHE CNLNMMDJGGM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<ICEEACBIJLM> OKDDDLPFPAD();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool DNLBENLLHMN(Guid MIPLHHGEGFK, [Out] ICEEACBIJLM MFFCCOICKEE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	long? JJKONLKFOFB(Guid MIPLHHGEGFK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<int> CCGIHHMPNGG(JGGIBKMOPKC HDKCFFEMGLH, Guid MIPLHHGEGFK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<BKBFEBFOLKF> MDPPBNPFHLL(JGGIBKMOPKC HDKCFFEMGLH, Guid MIPLHHGEGFK, int LFAFBKEKCHP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	string DPNONOHFENG(OFNGBMBINJK NIKEINPNLMA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool MMJGJNOCMEI();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<PGLGENBDGKP<GGHODFNPAIM, string>> HDNCCLICNEL(long CFLPHBNCGDP, string ONGJKHHOIAM, RoomInventoryTagClientProperties OJBDIKJIJPD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool JDFMENGPGGK(long ALFKPIECIHH, [Out] GGHODFNPAIM HAEBGAEEPDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HGBDHAGCEFA : FLBNEICBMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEMOJOJJHNF(IEnumerable<EEFPKGHKONJ> ECGKKBPFJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JGOFDHEODLF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ICEEACBIJLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid ELDPMFAHODM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68A5560", Offset = "0x68A4560", VA = "0x1868A5560")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IGLGGNHIMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68A5540", Offset = "0x68A4540", VA = "0x1868A5540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long MKOGPGPGDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C6590", Offset = "0x7C5590", VA = "0x1807C6590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long GAAMAHHCKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4320", Offset = "0x7C3320", VA = "0x1807C4320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? OBMPDJGDCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D90", Offset = "0x7C1D90", VA = "0x1807C2D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DB0", Offset = "0x7C1DB0", VA = "0x1807C2DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool AAIBLLDCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CB360", Offset = "0x8CA360", VA = "0x1808CB360")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD160F0", Offset = "0xD150F0", VA = "0x180D160F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68A55D0", Offset = "0x68A45D0", VA = "0x1868A55D0")]
	public ICEEACBIJLM(EEFPKGHKONJ APCECOEOHDN, bool KLBMDAENCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1BE9E40", Offset = "0x1BE8E40", VA = "0x181BE9E40")]
	public ICEEACBIJLM(Guid MIPLHHGEGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68A5350", Offset = "0x68A4350", VA = "0x1868A5350")]
	internal bool ACILEHIEJCJ(EEFPKGHKONJ APCECOEOHDN, long GGDCHNKICIB, Action<ICEEACBIJLM, int> NPLNEOHBDGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68A5570", Offset = "0x68A4570", VA = "0x1868A5570")]
	internal void PJKJONAHLFJ(long IOKMNNNBNHE, Action<ICEEACBIJLM, int> NPLNEOHBDGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MFCOBPENAHE : IEquatable<MFCOBPENAHE>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int EDCKFPBJHGM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int LBILEIAFEKH = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int LHHPGPAIPJG = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int PJNKAOKFINN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int NMHIBAGIGOP = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid ELDPMFAHODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85AF30", Offset = "0x859F30", VA = "0x18085AF30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long AEOCFDNBAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xF226D0", Offset = "0xF216D0", VA = "0x180F226D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NOJHAHGILOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ICGIALAOHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C65A0", Offset = "0x7C55A0", VA = "0x1807C65A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime FFDOBAEIMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C3300", VA = "0x1807C4300")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB240", Offset = "0x1ADA240", VA = "0x181ADB240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime BDNAHODNDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1B0B4A0", Offset = "0x1B0A4A0", VA = "0x181B0B4A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> BOKIHPBLDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C79B0", Offset = "0x7C69B0", VA = "0x1807C79B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C7970", Offset = "0x7C6970", VA = "0x1807C7970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties MIHGDPONHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C79C0", Offset = "0x7C69C0", VA = "0x1807C79C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6950", VA = "0x1807C7950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte FCBILDBGFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C8640", Offset = "0x7C7640", VA = "0x1807C8640")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C84E0", Offset = "0x7C74E0", VA = "0x1807C84E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BPMNKHLKDDH FBIBJOLBPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD34350", Offset = "0xD33350", VA = "0x180D34350")]
		[CompilerGenerated]
		get
		{
			return default(BPMNKHLKDDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD33C70", Offset = "0xD32C70", VA = "0x180D33C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x68A6180", Offset = "0x68A5180", VA = "0x1868A6180")]
	public MFCOBPENAHE(LJEIIELDHNP APCECOEOHDN, [Optional] RoomInventoryItemProperties OJBDIKJIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68A5A60", Offset = "0x68A4A60", VA = "0x1868A5A60", Slot = "4")]
	public bool Equals(MFCOBPENAHE JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68A5BE0", Offset = "0x68A4BE0", VA = "0x1868A5BE0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x68A60A0", Offset = "0x68A50A0", VA = "0x1868A60A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68A5DB0", Offset = "0x68A4DB0", VA = "0x1868A5DB0")]
	private HashSet<long> FNAOIAMGCIP(LJEIIELDHNP APCECOEOHDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IHKAPJGICBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private ICEEACBIJLM MFFCCOICKEE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MFCOBPENAHE DBOHBNAIAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICEEACBIJLM APDAFAPHOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68A5680", Offset = "0x68A4680", VA = "0x1868A5680")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68A5710", Offset = "0x68A4710", VA = "0x1868A5710")]
	public IHKAPJGICBJ(MFCOBPENAHE CNLNMMDJGGM, [Optional] ICEEACBIJLM MFFCCOICKEE)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x68A6560", Offset = "0x68A5560", VA = "0x1868A6560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D50", Offset = "0x7C1D50", VA = "0x1807C2D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9BE4E0", Offset = "0x9BD4E0", VA = "0x1809BE4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9BE4D0", Offset = "0x9BD4D0", VA = "0x1809BE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public GHGKCHPHDOJ Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
			[CompilerGenerated]
			get
			{
				return default(GHGKCHPHDOJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7C5850", Offset = "0x7C4850", VA = "0x1807C5850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB83310", Offset = "0xB82310", VA = "0x180B83310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4098760", Offset = "0x4097760", VA = "0x184098760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9057B0", Offset = "0x9047B0", VA = "0x1809057B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9F95D0", Offset = "0x9F85D0", VA = "0x1809F95D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68A62E0", Offset = "0x68A52E0", VA = "0x1868A62E0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68A6360", Offset = "0x68A5360", VA = "0x1868A6360")]
		public static RoomInventoryItemProperties HKOPKLJMPAD(RoomInventoryItemProperties OJBDIKJIJPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68A6500", Offset = "0x68A5500", VA = "0x1868A6500")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GGHODFNPAIM
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const int BNHIIFLJDPI = 10;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long HHPGKACIHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x136EEF0", Offset = "0x136DEF0", VA = "0x18136EEF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public RoomInventoryTagClientProperties MIHGDPONHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool HNEIIMGKLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68A5250", Offset = "0x68A4250", VA = "0x1868A5250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68A5270", Offset = "0x68A4270", VA = "0x1868A5270")]
	public GGHODFNPAIM(AKFMEIPBKEE APCECOEOHDN, [Optional] RoomInventoryTagClientProperties OJBDIKJIJPD)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x68A67B0", Offset = "0x68A57B0", VA = "0x1868A67B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D50", Offset = "0x7C1D50", VA = "0x1807C2D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68A65B0", Offset = "0x68A55B0", VA = "0x1868A65B0")]
		public void JFAOGJEHFKJ(Dictionary<string, object> LBFBEADLMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
namespace Cpp2IlInjected
{
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
}
