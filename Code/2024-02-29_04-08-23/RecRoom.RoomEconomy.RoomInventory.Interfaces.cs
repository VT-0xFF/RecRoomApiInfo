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
public class GNOMJNELBFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LKDGAHAPKLI PKHEOGNPMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long DDMEKBICEFI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NNOLHOOOMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x657ABF0", Offset = "0x65799F0", VA = "0x18657ABF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x657AC00", Offset = "0x6579A00", VA = "0x18657AC00")]
	public GNOMJNELBFE(LKDGAHAPKLI BGCCPJGDEGH, long BPFMGMBDOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NHDKANHFMJF
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
public interface MLNGFPMOKEL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BHHPLLLFBGO MCLKCHALIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	EOPEMIILONN<CLCMFNBBMOD> GHAFNALMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EOPEMIILONN<Guid> KPLMIIKLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FOEHHLKMAJF<HIBMLJHJECJ, int> KDLFOMNDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BHHPLLLFBGO ICDLEPKEDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<FBEPHKHKLJE<CLCMFNBBMOD, string>> GBIEDJOMOKB(long CGIDLDOBHII, string OHHBGJPCFJD, string JFBABPIJMOE, string DCHICAAFAFA, RoomInventoryItemProperties GGBBBBDBDBA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<FBEPHKHKLJE<CLCMFNBBMOD, string>> PMDNCNONHHM(Guid HPIMOBDLJLG, [Optional] string OHHBGJPCFJD, [Optional] string JFBABPIJMOE, [Optional] string DCHICAAFAFA, [Optional] List<long> JHJCPGOOBJG, [Optional] RoomInventoryItemProperties GGBBBBDBDBA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<FBEPHKHKLJE<bool, string>> HPKHPHCEFLA(Guid HPIMOBDLJLG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<CLCMFNBBMOD> GGCJHLGEDDN();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<CLCMFNBBMOD> GAMJABHACGD();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OHJLBIGLGFC();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NMDNHLAOGHC(Guid HPIMOBDLJLG, [Out] CLCMFNBBMOD ICJLNODCCIC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IIDPACLHAID(string IAOGLEHICNL, [Out] CLCMFNBBMOD ICJLNODCCIC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<HIBMLJHJECJ> NHGKPOAHMCK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool PALCBCNLNNP(Guid HPIMOBDLJLG, [Out] HIBMLJHJECJ PHFLPJPFAHA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<int> JIGLOPACEMH(MNFCKJNKANA ACNHNLBOPON, Guid HPIMOBDLJLG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<GNOMJNELBFE> NADBDCDPDEP(MNFCKJNKANA ACNHNLBOPON, Guid HPIMOBDLJLG, int LBCEMAMCEGO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OPIFCLEOKBO(LKDGAHAPKLI BGCCPJGDEGH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool EEAMMDAGBAF();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HLJGGPKNINM : MLNGFPMOKEL
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDNLDAHEEOK(IEnumerable<PAIGFBGCFNP> OPKCFFKGCDI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HIBMLJHJECJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid NJFACKIPIIE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x657AC40", Offset = "0x6579A40", VA = "0x18657AC40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NNOLHOOOMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x657AC50", Offset = "0x6579A50", VA = "0x18657AC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long NLKFABKLAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF90", Offset = "0x7ABD90", VA = "0x1807ACF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long ACKEOOPHJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B50", Offset = "0x7B3950", VA = "0x1807B4B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? MKBLGJGIFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D90", Offset = "0x7B2B90", VA = "0x1807B3D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DF0", Offset = "0x7B2BF0", VA = "0x1807B3DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool IDNDKHCNNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84F330", Offset = "0x84E130", VA = "0x18084F330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x19FB250", Offset = "0x19FA050", VA = "0x1819FB250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x657AEC0", Offset = "0x6579CC0", VA = "0x18657AEC0")]
	public HIBMLJHJECJ(PAIGFBGCFNP MCIJEAMJACL, bool GNPINHJKHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1ABA0E0", Offset = "0x1AB8EE0", VA = "0x181ABA0E0")]
	public HIBMLJHJECJ(Guid HPIMOBDLJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x657AC70", Offset = "0x6579A70", VA = "0x18657AC70")]
	internal bool LLIADGIKINC(PAIGFBGCFNP MCIJEAMJACL, long MDNEEJEEMPJ, Action<HIBMLJHJECJ, int> HMLNJOEFKGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x657AE60", Offset = "0x6579C60", VA = "0x18657AE60")]
	internal void NLNOPFCGAAA(long NNEONHACIPF, Action<HIBMLJHJECJ, int> HMLNJOEFKGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CLCMFNBBMOD : IEquatable<CLCMFNBBMOD>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int IHGALJOGOIJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int FDLBPIOFEEI = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int GPCAMJBMBFH = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int MKKLPNIPLMF = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid NJFACKIPIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1C33E90", Offset = "0x1C32C90", VA = "0x181C33E90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long HLEBPLLIAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE64300", Offset = "0xE63100", VA = "0x180E64300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ILHPKCMLCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string OLCMOIJLBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime HDIFAMBGDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19D3B40", Offset = "0x19D2940", VA = "0x1819D3B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime NOJBHDHFFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x19FFE10", Offset = "0x19FEC10", VA = "0x1819FFE10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HashSet<long> OPGNFAKFOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public RoomInventoryItemProperties MABGAKOHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x657AAB0", Offset = "0x65798B0", VA = "0x18657AAB0")]
	public CLCMFNBBMOD(PEOMHNHBAFF MCIJEAMJACL, [Optional] RoomInventoryItemProperties GGBBBBDBDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x657A850", Offset = "0x6579650", VA = "0x18657A850", Slot = "4")]
	public bool Equals(CLCMFNBBMOD FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x657A670", Offset = "0x6579470", VA = "0x18657A670", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x657A9D0", Offset = "0x65797D0", VA = "0x18657A9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x657A380", Offset = "0x6579180", VA = "0x18657A380")]
	private HashSet<long> DGBLNBEEELD(PEOMHNHBAFF MCIJEAMJACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PCMOKIFDKGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private HIBMLJHJECJ PHFLPJPFAHA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CLCMFNBBMOD JFPCLNGGPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HIBMLJHJECJ CKACBAAGBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x657AFD0", Offset = "0x6579DD0", VA = "0x18657AFD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x657B060", Offset = "0x6579E60", VA = "0x18657B060")]
	public PCMOKIFDKGG(CLCMFNBBMOD ICJLNODCCIC, [Optional] HIBMLJHJECJ PHFLPJPFAHA)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x657B5F0", Offset = "0x657A3F0", VA = "0x18657B5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2BB0", VA = "0x1807B3DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x91FB50", Offset = "0x91E950", VA = "0x18091FB50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x91FB60", Offset = "0x91E960", VA = "0x18091FB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NHDKANHFMJF Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
			[CompilerGenerated]
			get
			{
				return default(NHDKANHFMJF);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7B77F0", Offset = "0x7B65F0", VA = "0x1807B77F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x657B530", Offset = "0x657A330", VA = "0x18657B530", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x657B4B0", Offset = "0x657A2B0", VA = "0x18657B4B0")]
		public static RoomInventoryItemProperties CGCPFECLPOJ(RoomInventoryItemProperties GGBBBBDBDBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1A5F760", Offset = "0x1A5E560", VA = "0x181A5F760")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PFLJAPLHCPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const int DBFHOPPLEDP = 10;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public long JFDDIGKJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12A3400", Offset = "0x12A2200", VA = "0x1812A3400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public RoomInventoryTagClientProperties MABGAKOHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DCDGGCKIMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x657B3B0", Offset = "0x657A1B0", VA = "0x18657B3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x657B3D0", Offset = "0x657A1D0", VA = "0x18657B3D0")]
	public PFLJAPLHCPJ(IJAKEMICEPB MCIJEAMJACL, [Optional] RoomInventoryTagClientProperties GGBBBBDBDBA)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x657B840", Offset = "0x657A640", VA = "0x18657B840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2BB0", VA = "0x1807B3DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x657B640", Offset = "0x657A440", VA = "0x18657B640")]
		public void EPCCAACMDAJ(Dictionary<string, object> DLLLAJJCCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class LGBIOHGFMIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x657AF70", Offset = "0x6579D70", VA = "0x18657AF70")]
	public static int CKPNPCIGOCE(long JGLMBGFBBCA)
	{
		return default(int);
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
