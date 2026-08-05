using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface LOIFKPOLLGP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JLGCOOKJBGD();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEGCKGDHHKN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface CINMFIJPFIM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJCJBGODPCK(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, Allocator GMMIODGPFPJ, out NativeArray<Entity> PGJLMFPAKDA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct NGMJNNOBIHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray CMCLOPFEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<CMFFIMLEPBE, int> BPEAFMFCBII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EHMEEIIOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5843AA0", Offset = "0x5842EA0", VA = "0x185843AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x12E63F0", Offset = "0x12E57F0", VA = "0x1812E63F0")]
	public NGMJNNOBIHE(NativeBitArray CMCLOPFEMNP, NativeParallelHashMap<CMFFIMLEPBE, int> BPEAFMFCBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58439A0", Offset = "0x5842DA0", VA = "0x1858439A0")]
	public bool HKNFLDAFCFK(CMFFIMLEPBE AIOICCOKGOP, GLFLLKHPAHK HNNIGEFAIIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface MJHECCLPBHE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid PEMKIMNLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BHKLEHKJHOO(Guid KFELFALCJLB, Guid MBHHEMBLMOK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task NHOIELGCIPC(KDLENLDMBAK GNFGGOOCOHA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBNJAHPMDEG(KDLENLDMBAK CDFHGECAPKI, KDLENLDMBAK ILDFJHMNOPJ, out Vector3 LPIMIOFOIOA, out Quaternion IFDCCCEDOFF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADEBCEOGEEF(NDPNDFLPOGF MLKFLBIMGKN, Vector3 LPIMIOFOIOA, Quaternion IFDCCCEDOFF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LJHGDPGPANM : KFFHHBDDKDC<KDLENLDMBAK>, COKGGJJNNDI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AOJLADIGKFN<T> : MHOBFBAOGME<KDLENLDMBAK, T>, KFFHHBDDKDC<KDLENLDMBAK>, COKGGJJNNDI, IDisposable, LJHGDPGPANM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LJFBHLAOLJO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2429B00", Offset = "0x2428F00", VA = "0x182429B00")]
	public static T IKHPLCCBENN<T>(this KFFHHBDDKDC<KDLENLDMBAK> HNNIGEFAIIM, KDLENLDMBAK LCODCOPGHJA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2429AD0", Offset = "0x2428ED0", VA = "0x182429AD0")]
	public static bool DADPJLGDIHI<T>(this KFFHHBDDKDC<KDLENLDMBAK> HNNIGEFAIIM, KDLENLDMBAK LCODCOPGHJA, in T NDKKBDCFLEC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface BGNPLHOEAII
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<ICOBLLMLJBN> HIHOLIJFJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KDLENLDMBAK, KDLENLDMBAK> BDMGLKFFOCP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KDLENLDMBAK, KDLENLDMBAK> FBDGMEGFMJF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KDLENLDMBAK, KDLENLDMBAK, KDLENLDMBAK> JNOJPOMHJKH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<KDLENLDMBAK> JENDLBAAIPE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color MKOIEIIEJMF(KDLENLDMBAK LCODCOPGHJA, int GCEEJDKIGOF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 JINKKIFJBDB(KDLENLDMBAK LCODCOPGHJA, int GCEEJDKIGOF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IPOLINNBOEF(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK FABBINCJJBF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KDLENLDMBAK MNMAJHDMHMK(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<KDLENLDMBAK> EFILPCJOIIA(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KDLENLDMBAK FDNIGEOEFFN(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IJOMAPONLCD(KDLENLDMBAK LCODCOPGHJA, Vector3 JMIHADOHNEA, Quaternion LJEJBFIKBIB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMEOHJEJBJN(KDLENLDMBAK LCODCOPGHJA, float JOHKAAPFFLA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IDJNFENJBAD(KDLENLDMBAK LCODCOPGHJA, out RigidTransform LCNILANGJMF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool FOPLPKIAPCH(KDLENLDMBAK LCODCOPGHJA, out float DKPLIGPPDDN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 IEFDEONLEEO(DNCIFCFDCBN EEBCOGPBBCB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion CILHEKNNIOB(DNCIFCFDCBN EEBCOGPBBCB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JHOEBHFCGMI
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface LJKNMEOKCJF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAPHNHIHJOB(Action FJBAKNFCPGP, bool KKNCPEJEKOM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBKGFFHOAFB(string DKPHPKDPBCM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface IJNHJLKNADD
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJCJBGODPCK(in NativeArray<Entity> PGJLMFPAKDA, in float3 OCPINBDMADB, in float3 KDLMOBCGODE, in NativeArray<BMJAGFBFJOH> PKCFIPFALAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface LEECIPHPBNO
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDGLMGBHCME(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMODDNBHENJ(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICPMDBABKPK(KDLENLDMBAK BGPCGOEKFEF, int KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[DefaultMember("Item")]
public interface JKPBDEIBINB : IEnumerable<OMADGHGGHJN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray BEKLCMJJOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> FLDMMOECGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OMADGHGGHJN OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OMADGHGGHJN OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OMADGHGGHJN IMOMPCNDOJA(NNHEPJDBKBI KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GLFLLKHPAHK ELFFHKHOAAN(NNHEPJDBKBI KKIJPENOLBP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BAAJOJPFAGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface KBLGMDKDIMA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int JFINKDLKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KEDBKDMODGO(GameObject GACFHLOJJGF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CDKILJNLHAC(out Vector3 OMFIFBMFGMG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LGOOMDJEDKO();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PPAICFPHGCO();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task MJACODMALGM();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLLJHBOAOEA();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FELHIMECNDB : IEquatable<FELHIMECNDB>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly FELHIMECNDB IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x583A370", Offset = "0x5839770", VA = "0x18583A370", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(FELHIMECNDB LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JHCKEODHCBA : IEquatable<JHCKEODHCBA>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly JHCKEODHCBA IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x583F150", Offset = "0x583E550", VA = "0x18583F150", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(JHCKEODHCBA LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface ILIBONIKHOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NGMJNNOBIHE FGOJMECAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKNFLDAFCFK(CMFFIMLEPBE AIOICCOKGOP, GLFLLKHPAHK HNNIGEFAIIM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INPFIBIHNMF(CMFFIMLEPBE AIOICCOKGOP, Span<GLFLLKHPAHK> NFDNHCCMBMJ, bool FJHKHBKNEEC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMFDEDBBEAF(NativeArray<CMFFIMLEPBE> MAEMAKOHEBK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NEKDPMFGEDH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5843770", Offset = "0x5842B70", VA = "0x185843770")]
	public static void INPFIBIHNMF(this ILIBONIKHOI CDIHHIPDEOD, CMFFIMLEPBE AIOICCOKGOP, GLFLLKHPAHK HNNIGEFAIIM, bool FJHKHBKNEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct EFBPNECENII : KNAEKBFOOHL, IEquatable<EFBPNECENII>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly EFBPNECENII IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GameObject GACFHLOJJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5839280", Offset = "0x5838680", VA = "0x185839280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public CMFFIMLEPBE MJAODDIMGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5839660", Offset = "0x5838A60", VA = "0x185839660")]
		get
		{
			return default(CMFFIMLEPBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CJNBAFDACBF CFBKDAJGMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5839150", Offset = "0x5838550", VA = "0x185839150")]
		get
		{
			return default(CJNBAFDACBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LENINMGJJHF LAGJFMPGBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5839560", Offset = "0x5838960", VA = "0x185839560")]
		get
		{
			return default(LENINMGJJHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FIMJFEKAKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5839DD0", Offset = "0x58391D0", VA = "0x185839DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BPMDAAFINKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5839CA0", Offset = "0x58390A0", VA = "0x185839CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BBCIHGAILLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5839BD0", Offset = "0x5838FD0", VA = "0x185839BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool NANEJAKMKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5839AC0", Offset = "0x5838EC0", VA = "0x185839AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EJMDCMNBKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x58390D0", Offset = "0x58384D0", VA = "0x1858390D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FDGNCCAHGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5839BF0", Offset = "0x5838FF0", VA = "0x185839BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PNIOMMAHNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5839640", Offset = "0x5838A40", VA = "0x185839640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NNDJEJGHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5839740", Offset = "0x5838B40", VA = "0x185839740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AFBPFNELAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5839950", Offset = "0x5838D50", VA = "0x185839950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FNFCOLDDMLG OEEHOLCBKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(FNFCOLDDMLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GFDHAOJNMHI JHALEAJFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(GFDHAOJNMHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KGMAJDMNJCI LLNIBAPEILO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KGMAJDMNJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public LMEDBJLJHHK GIGKNHEEKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(LMEDBJLJHHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public CEBIEIKPHJJ IIJFBCCMPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(CEBIEIKPHJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NHNIIGMMKJO DPNDBNAEFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(NHNIIGMMKJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public NDPNDFLPOGF HEGEJHABAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(NDPNDFLPOGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool CGEGNOGJDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5839CC0", Offset = "0x58390C0", VA = "0x185839CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HJMHDBDCLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5839230", Offset = "0x5838630", VA = "0x185839230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool OKDCGEEGKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0", Slot = "5")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HIBANDCMFGC GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(HIBANDCMFGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public PLEMBKHENGI HIGPLAHDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(PLEMBKHENGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public static EFBPNECENII PGDDHPNABOB(KDLENLDMBAK BGPCGOEKFEF)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5839C10", Offset = "0x5839010", VA = "0x185839C10")]
	public IPHCFGGLOCO OOPIBJKAHGG()
	{
		return default(IPHCFGGLOCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x58390F0", Offset = "0x58384F0", VA = "0x1858390F0")]
	public LPJBLNGGKAG AFIPDECECHD()
	{
		return default(LPJBLNGGKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5839460", Offset = "0x5838860", VA = "0x185839460")]
	public ECLENOGDKNG EPDDKPHPGKN()
	{
		return default(ECLENOGDKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5839970", Offset = "0x5838D70", VA = "0x185839970")]
	public DNCIFCFDCBN LPEJCHJLCCN()
	{
		return default(DNCIFCFDCBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5839AE0", Offset = "0x5838EE0", VA = "0x185839AE0")]
	public void MIPMPNEGLMG([Optional] object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5839790", Offset = "0x5838B90", VA = "0x185839790")]
	public bool IDHHCLLPEJO(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x58393A0", Offset = "0x58387A0", VA = "0x1858393A0")]
	public bool DDGMIIBELPN(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5839DF0", Offset = "0x58391F0", VA = "0x185839DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public EFBPNECENII(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(EFBPNECENII KKIAKNLLHIO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public static KDLENLDMBAK PGDDHPNABOB(EFBPNECENII KKIAKNLLHIO)
	{
		return default(KDLENLDMBAK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5839A00", Offset = "0x5838E00", VA = "0x185839A00")]
	public static bool MCJHDEKAHDI(EFBPNECENII EJOFMGLMADH, EFBPNECENII CMACFBOCONA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5839850", Offset = "0x5838C50", VA = "0x185839850")]
	public static bool JJOPDHABKNF(EFBPNECENII EJOFMGLMADH, EFBPNECENII CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x58394C0", Offset = "0x58388C0", VA = "0x1858394C0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "6")]
	public bool Equals(EFBPNECENII LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void NPBEDHNLGJD(NPCCBNHIEEP CNNOOFFNELP);
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct AOEDEKOFPJM : IList<KDLENLDMBAK>, ICollection<KDLENLDMBAK>, IEnumerable<KDLENLDMBAK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct BGJDGPCFMKM : IEnumerator<KDLENLDMBAK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly AOONNPAOEFB FHJACJEANIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator EOIJHGCOGLO;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public KDLENLDMBAK NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5835910", Offset = "0x5834D10", VA = "0x185835910", Slot = "4")]
			get
			{
				return default(KDLENLDMBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5835860", Offset = "0x5834C60", VA = "0x185835860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x16CEB90", Offset = "0x16CDF90", VA = "0x1816CEB90")]
		public BGJDGPCFMKM(AOONNPAOEFB FHJACJEANIP, NativeArray<LocalId>.Enumerator EOIJHGCOGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x58357A0", Offset = "0x5834BA0", VA = "0x1858357A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x58357E0", Offset = "0x5834BE0", VA = "0x1858357E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5835820", Offset = "0x5834C20", VA = "0x185835820", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> KOJOICDCDNK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KDLENLDMBAK OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5835470", Offset = "0x5834870", VA = "0x185835470", Slot = "4")]
		get
		{
			return default(KDLENLDMBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x58354F0", Offset = "0x58348F0", VA = "0x1858354F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x58350E0", Offset = "0x58344E0", VA = "0x1858350E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x58350E0", Offset = "0x58344E0", VA = "0x1858350E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PAJHIMACICC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x58353E0", Offset = "0x58347E0", VA = "0x1858353E0")]
	public AOEDEKOFPJM(AOONNPAOEFB FHJACJEANIP, int PGBALNGGNPG, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5834F80", Offset = "0x5834380", VA = "0x185834F80")]
	public PPACDBGDBCI GHBPHEPMJDO()
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5834BD0", Offset = "0x5833FD0", VA = "0x185834BD0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5834C10", Offset = "0x5834010", VA = "0x185834C10", Slot = "13")]
	public bool Contains(KDLENLDMBAK ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5834C70", Offset = "0x5834070", VA = "0x185834C70", Slot = "14")]
	public void CopyTo(KDLENLDMBAK[] KGHLGBOMEFA, int BHHKGKOCFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5834B70", Offset = "0x5833F70", VA = "0x185834B70", Slot = "11")]
	public void Add(KDLENLDMBAK ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5835060", Offset = "0x5834460", VA = "0x185835060", Slot = "7")]
	public void Insert(int NANJAGEOPJI, KDLENLDMBAK ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5835170", Offset = "0x5834570", VA = "0x185835170", Slot = "15")]
	public bool Remove(KDLENLDMBAK ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5835000", Offset = "0x5834400", VA = "0x185835000", Slot = "6")]
	public int IndexOf(KDLENLDMBAK ADJFAODNAMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5835120", Offset = "0x5834520", VA = "0x185835120", Slot = "8")]
	public void RemoveAt(int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5834EB0", Offset = "0x58342B0", VA = "0x185834EB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5834EF0", Offset = "0x58342F0", VA = "0x185834EF0")]
	public BGJDGPCFMKM FNKOJPGNHJL()
	{
		return default(BGJDGPCFMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5835200", Offset = "0x5834600", VA = "0x185835200", Slot = "16")]
	private IEnumerator<KDLENLDMBAK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x58352F0", Offset = "0x58346F0", VA = "0x1858352F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface LGOEJMHMEMO
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool MGIAMALJMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface AJDMCFNBEEO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CLBOFGEACDM KGGOPGPECLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MDEKHLOEFLD GKAACFPAABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHCKFFDBDLH(Transform FELEGEFPADK);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACGKKGDJJGB(Transform FELEGEFPADK, GEICHFJJNEH PJJOKPDKGGA);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNCMAADJGNN(Transform FELEGEFPADK, ACHEKCMGEOE DILPMIKBIBB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface CBFLHDPJONH
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJCJBGODPCK(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, out BMJAGFBFJOH LGKDBFIOHEG, out KDLENLDMBAK BMBJJEDFMKB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct BPHMAGJHJEM : IEquatable<BPHMAGJHJEM>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BPHMAGJHJEM IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private EBNGCKDPAGC BNCGELIECNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x58362D0", Offset = "0x58356D0", VA = "0x1858362D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LPJBLNGGKAG IECAPLODELL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(LPJBLNGGKAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NDDEKGODHLE CDGPABBKPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5836580", Offset = "0x5835980", VA = "0x185836580")]
		get
		{
			return default(NDDEKGODHLE);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5835E10", Offset = "0x5835210", VA = "0x185835E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerable<MDHLGBNMCCH> ECALLLJOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5835C30", Offset = "0x5835030", VA = "0x185835C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MDHLGBNMCCH OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5835A20", Offset = "0x5834E20", VA = "0x185835A20")]
		get
		{
			return default(MDHLGBNMCCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x58361F0", Offset = "0x58355F0", VA = "0x1858361F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HIBANDCMFGC GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(HIBANDCMFGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5836690", Offset = "0x5835A90", VA = "0x185836690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5836360", Offset = "0x5835760", VA = "0x185836360")]
	public MDHLGBNMCCH KCOGBPFIJEM(float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] Vector3? DBJGDGDHOMC)
	{
		return default(MDHLGBNMCCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5835FC0", Offset = "0x58353C0", VA = "0x185835FC0")]
	public MDHLGBNMCCH GJNOKPIPNHE(int NANJAGEOPJI, float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] Vector3? DBJGDGDHOMC)
	{
		return default(MDHLGBNMCCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5835B40", Offset = "0x5834F40", VA = "0x185835B40")]
	public void BGDKBCNNAHK(int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x58367C0", Offset = "0x5835BC0", VA = "0x1858367C0")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public BPHMAGJHJEM(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(BPHMAGJHJEM KKIAKNLLHIO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5836700", Offset = "0x5835B00", VA = "0x185836700")]
	public static bool MCJHDEKAHDI(BPHMAGJHJEM EJOFMGLMADH, BPHMAGJHJEM CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5835F20", Offset = "0x5835320", VA = "0x185835F20", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(BPHMAGJHJEM LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface HGCCGCKMNPO
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Type POHKINOEELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface DGDICPPMDDO
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JHJFJJLBANG(KDLENLDMBAK LCODCOPGHJA, out Collider JGLBLFOJFCH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OOCICAKKFHO(KDLENLDMBAK PEGGHLFAKOF, GameObject OCCJOMPABPO, Vector3 KLNBLJCMMCM, Quaternion EDHIFCBPMNM);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIGBIENJMDO(GameObject JGLBLFOJFCH);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider KGMGHOKKADC<TCollider>(GameObject AJOEPLFEHEE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJIMNACABAH(Collider JGLBLFOJFCH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject AIGLDMEDHNN<TCollider>(string DKPHPKDPBCM) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MLIEHECMNHI : KFFHHBDDKDC<CMFFIMLEPBE>, COKGGJJNNDI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CDGFPKEPFIC<T> : MHOBFBAOGME<CMFFIMLEPBE, T>, KFFHHBDDKDC<CMFFIMLEPBE>, COKGGJJNNDI, IDisposable, MLIEHECMNHI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NJHCBHMHNOK
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1812D70", Offset = "0x1812170", VA = "0x181812D70")]
	public static bool NALDPHOGDDM<T>(this KFFHHBDDKDC<CMFFIMLEPBE> HNNIGEFAIIM, CMFFIMLEPBE AIOICCOKGOP, out T KKIAKNLLHIO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xBC74D0", Offset = "0xBC68D0", VA = "0x180BC74D0")]
	public static bool DADPJLGDIHI<T>(this KFFHHBDDKDC<CMFFIMLEPBE> HNNIGEFAIIM, CMFFIMLEPBE AIOICCOKGOP, in T NDKKBDCFLEC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface HKFAIGLNOBD
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAIAEGPELJA();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct NDPNDFLPOGF : IEquatable<NDPNDFLPOGF>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly NDPNDFLPOGF IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private JAOEAHCDOAB PBMLMMKPNDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x58436A0", Offset = "0x5842AA0", VA = "0x1858436A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HIPMBPGLBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5842FE0", Offset = "0x58423E0", VA = "0x185842FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid ILAJAFGKAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5843240", Offset = "0x5842640", VA = "0x185843240")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NOOCHNBNFON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x58430C0", Offset = "0x58424C0", VA = "0x1858430C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid DKJBOGDCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5842D00", Offset = "0x5842100", VA = "0x185842D00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5843540", Offset = "0x5842940", VA = "0x185843540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5843340", Offset = "0x5842740", VA = "0x185843340")]
	public bool FOHEPMIDLHB(out Guid GHNPAEHCAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x58435A0", Offset = "0x58429A0", VA = "0x1858435A0")]
	public void LAGPEHNGOBH(Guid CPAHGHLMHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5842EE0", Offset = "0x58422E0", VA = "0x185842EE0")]
	public bool BODCJGNHGEP(out Guid AGMGFKBEKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5843440", Offset = "0x5842840", VA = "0x185843440")]
	public void GLIBCGGMKCG(Guid CPAHGHLMHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5842E00", Offset = "0x5842200", VA = "0x185842E00")]
	public void AMKCOFMHHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public NDPNDFLPOGF(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(NDPNDFLPOGF KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x58431A0", Offset = "0x58425A0", VA = "0x1858431A0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(NDPNDFLPOGF LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct GFDHAOJNMHI : IEquatable<GFDHAOJNMHI>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly GFDHAOJNMHI IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x583AB90", Offset = "0x5839F90", VA = "0x18583AB90")]
	public void FBDDBFFKADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x583AC70", Offset = "0x583A070", VA = "0x18583AC70")]
	public void FMEHBMDFEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public GFDHAOJNMHI(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x583AAF0", Offset = "0x5839EF0", VA = "0x18583AAF0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(GFDHAOJNMHI LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CJHAGIKCJCL : KNAEKBFOOHL
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	BIFEDELOJOL GLNIKJNLCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool ECBHPEOEFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GameObject GACFHLOJJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<CJHAGIKCJCL> KIMLDMDILJC;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(PFJMBDHJHAN BDLCNPMEDLI, KDLENLDMBAK BDNFNCMKEFH);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool MPMOJAKCGPE);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class HDJOCFKHHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x583B040", Offset = "0x583A440", VA = "0x18583B040")]
	public static bool CGEGNOGJDCD(this CJHAGIKCJCL FCGEAJNLBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x583B090", Offset = "0x583A490", VA = "0x18583B090")]
	public static bool EBMKHPKCOGD(this CJHAGIKCJCL FCGEAJNLBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x583B0E0", Offset = "0x583A4E0", VA = "0x18583B0E0")]
	public static bool JGEEOKDCCAM(this CJHAGIKCJCL FCGEAJNLBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x583B130", Offset = "0x583A530", VA = "0x18583B130")]
	public static bool MPIAMCJMFLB(this CJHAGIKCJCL FCGEAJNLBED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface IAMHJKNKNMA
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIOJLDEKLLA(GameObject GACFHLOJJGF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct HNAPLKLLLFL : IEquatable<HNAPLKLLLFL>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly HNAPLKLLLFL IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x583DB10", Offset = "0x583CF10", VA = "0x18583DB10", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(HNAPLKLLLFL LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface GIAAALCEHCB
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNPEMLPKEOI(NativeListAsync<Entity> MEHPHMAJOHC);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAKCGAECLBI(OCKLHPIJMNK GILHECFPBMJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIHAMNDAKFL(NativeListAsync<Entity> CIDGIPOACLG, bool LGACBDBKOHJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELCPLOFAOMH();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface GBLEIIIBOJL
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJMGKMCPHAB(KDLENLDMBAK LCODCOPGHJA, PHJBMACKBCD KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface ADBHPBOEEGG
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOJIAPMAHCO();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDDAHNAOGG();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMKDJKLHCDE();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INFMFOFLOFP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBKALKPGPNK();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KBBPJIBLDNI();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFOFEIPLCGA();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NAMNPCMKHML();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AIENBNGNHLI();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPKAMPAPJMN();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKPPGFIPBBB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct JODLCELHFNO : IEquatable<JODLCELHFNO>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal const int PIDGPPBEGLC = 1;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal const int KOIAPNGLPIB = 4;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal const int PODIPNKOHAA = 8;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal const int PCOFAPIEAMK = 24;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal const uint JIHAKAFOGHC = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal const uint MMLEIKJOLKN = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly uint PPCGBBAKOHO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static uint[] KFFIGCKCIIO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static AOONNPAOEFB[] PHPOLCBAEBM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static uint CKNNJHLPLKI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public AOONNPAOEFB AGKMAHLMPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x58400C0", Offset = "0x583F4C0", VA = "0x1858400C0")]
	static JODLCELHFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
	internal JODLCELHFNO(uint KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2C90", Offset = "0x3BD2090", VA = "0x183BD2C90", Slot = "4")]
	public bool Equals(JODLCELHFNO LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x583F950", Offset = "0x583ED50", VA = "0x18583F950", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x583FFC0", Offset = "0x583F3C0", VA = "0x18583FFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x583FBE0", Offset = "0x583EFE0", VA = "0x18583FBE0")]
	private AOONNPAOEFB IEONCLMABNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x583FFB0", Offset = "0x583F3B0", VA = "0x18583FFB0")]
	private static uint NDGBPOMPPGO(uint PPCGBBAKOHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x583FF50", Offset = "0x583F350", VA = "0x18583FF50")]
	private static (uint, uint) KHPNEDAFDIC(uint PPCGBBAKOHO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x583F940", Offset = "0x583ED40", VA = "0x18583F940")]
	private static uint EGPKEOKCAOF(uint HEGEMCIFGEI, uint NANJAGEOPJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x583F9E0", Offset = "0x583EDE0", VA = "0x18583F9E0")]
	internal static JODLCELHFNO FIMKNKKCEGK(AOONNPAOEFB OBOAIKCPODL)
	{
		return default(JODLCELHFNO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x583FDA0", Offset = "0x583F1A0", VA = "0x18583FDA0")]
	internal static void JOMNAIGJLOO(JODLCELHFNO PPCGBBAKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x583F6B0", Offset = "0x583EAB0", VA = "0x18583F6B0")]
	private static void CNFNHLDNKAI(int EPMEDFGLJOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LILHPPGJGND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int JGKLPOMFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> GMJBBLHMCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDLENLDMBAK JENKENCJDAG(KDLENLDMBAK KOJOICDCDNK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GNNPIIODDJM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LMEDBJLJHHK : IEquatable<LMEDBJLJHHK>
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly LMEDBJLJHHK IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private POOJHEKMOMM CIINPNGHJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5840FA0", Offset = "0x58403A0", VA = "0x185840FA0")]
		get
		{
			return default(POOJHEKMOMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool LEFLMJFCOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5841030", Offset = "0x5840430", VA = "0x185841030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool OAJOJMLGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x58411B0", Offset = "0x58405B0", VA = "0x1858411B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool PBGHHEPDFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5840ED0", Offset = "0x58402D0", VA = "0x185840ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool IPFDGOJDBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x58415A0", Offset = "0x58409A0", VA = "0x1858415A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool HPHNDJGNENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5841700", Offset = "0x5840B00", VA = "0x185841700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool NICEAAAPDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5841840", Offset = "0x5840C40", VA = "0x185841840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool JMHNMKFIKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5841590", Offset = "0x5840990", VA = "0x185841590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool PJKPAFIPJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x58414A0", Offset = "0x58408A0", VA = "0x1858414A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool EKGEIGFIIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5841130", Offset = "0x5840530", VA = "0x185841130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool HGFEPFBMEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5840EC0", Offset = "0x58402C0", VA = "0x185840EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool LLLADGJILMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5841020", Offset = "0x5840420", VA = "0x185841020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool KNMCOLJEMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x58411C0", Offset = "0x58405C0", VA = "0x1858411C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool BNNNGBLJAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5841010", Offset = "0x5840410", VA = "0x185841010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool MACGCHIKBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x58417A0", Offset = "0x5840BA0", VA = "0x1858417A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool DBFNCBEPICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x58416F0", Offset = "0x5840AF0", VA = "0x1858416F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5841710", Offset = "0x5840B10", VA = "0x185841710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool POBLLAFFGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5841300", Offset = "0x5840700", VA = "0x185841300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MLJJMANCKBM PEDNNNOLKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5841140", Offset = "0x5840540", VA = "0x185841140")]
		get
		{
			return default(MLJJMANCKBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool LGCPNCKBNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5841720", Offset = "0x5840B20", VA = "0x185841720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Vector3 POIGCCAMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5841610", Offset = "0x5840A10", VA = "0x185841610")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public Vector3 IMMKDNMAAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5840EE0", Offset = "0x58402E0", VA = "0x185840EE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool GEKEOAKFHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x58411D0", Offset = "0x58405D0", VA = "0x1858411D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x58415B0", Offset = "0x58409B0", VA = "0x1858415B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5841420", Offset = "0x5840820", VA = "0x185841420")]
	public bool HPPDCELJAEA(HIJJKEPGDCJ HJFEJJMKLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x58414B0", Offset = "0x58408B0", VA = "0x1858414B0")]
	public bool JMFIPLMPDOL(LOICABBCFFI HJFEJJMKLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x58417B0", Offset = "0x5840BB0", VA = "0x1858417B0")]
	public void PMAKDIDMLML(LOICABBCFFI HJFEJJMKLEL, bool FNDDHDLBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public LMEDBJLJHHK(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5841090", Offset = "0x5840490", VA = "0x185841090", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(LMEDBJLJHHK LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum DDKNJPLJEMG
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LCNFMHBPDNL
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xC224F0", Offset = "0xC218F0", VA = "0x180C224F0")]
	public static bool APGKHNGMOCA(this DDKNJPLJEMG PJAFLHHFBPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0xC22500", Offset = "0xC21900", VA = "0x180C22500")]
	public static bool MFJBNJMIGEK(this DDKNJPLJEMG PJAFLHHFBPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x421E090", Offset = "0x421D490", VA = "0x18421E090")]
	public static bool LOFCLGDLIIC(this DDKNJPLJEMG PJAFLHHFBPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface PFJMBDHJHAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	World DFKBAKJLNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	World DIMECBCAKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase IJCEMIAIIAL(Type JLNNFEOBAMK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MOHEKHKKMCM
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5842C70", Offset = "0x5842070", VA = "0x185842C70")]
	public static ComponentSystemBase JPCIDKOCLIE(this World BDLCNPMEDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x24B80D0", Offset = "0x24B74D0", VA = "0x1824B80D0")]
	public static T IJCEMIAIIAL<T>(this PFJMBDHJHAN GKACEDOEIPO) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct OJGPABLJLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NPCCBNHIEEP KJFNAECAHBA;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public PPACDBGDBCI HIDFMDLHCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x16CFA50", Offset = "0x16CEE50", VA = "0x1816CFA50")]
		get
		{
			return default(PPACDBGDBCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5844560", Offset = "0x5843960", VA = "0x185844560")]
	public OJGPABLJLLP(NPCCBNHIEEP KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5844490", Offset = "0x5843890", VA = "0x185844490")]
	public PPACDBGDBCI PEJJNBKOPBJ()
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5844230", Offset = "0x5843630", VA = "0x185844230")]
	public PPACDBGDBCI BLGBFPAEEBE()
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5844300", Offset = "0x5843700", VA = "0x185844300")]
	public (PPACDBGDBCI, PPACDBGDBCI, PPACDBGDBCI) IKHPLCCBENN()
	{
		return default((PPACDBGDBCI, PPACDBGDBCI, PPACDBGDBCI));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct PLEMBKHENGI : IEquatable<PLEMBKHENGI>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly PLEMBKHENGI IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private IIKMCLIAKNK DMKEHNBEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5844FB0", Offset = "0x58443B0", VA = "0x185844FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KDLENLDMBAK BKKBKFEEACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5845040", Offset = "0x5844440", VA = "0x185845040")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public EFBPNECENII CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5844E00", Offset = "0x5844200", VA = "0x185844E00")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EFBPNECENII KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x58451B0", Offset = "0x58445B0", VA = "0x1858451B0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5845150", Offset = "0x5844550", VA = "0x185845150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5844CE0", Offset = "0x58440E0", VA = "0x185844CE0")]
	public bool CIGBDIGMBAB(EFBPNECENII ILDFJHMNOPJ, bool IHNOCHJJPPJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x58452C0", Offset = "0x58446C0", VA = "0x1858452C0")]
	public bool OFOEOMJNIKA(EFBPNECENII MODHKGGCBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public PLEMBKHENGI(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5844F10", Offset = "0x5844310", VA = "0x185844F10", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(PLEMBKHENGI LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface IIONFMDPDBM
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGKHCLNJFDE(string HGJHDPGFLKO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct LCLHBJLEOJH : IEquatable<LCLHBJLEOJH>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LCLHBJLEOJH IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private NFLJDGLLLHI INGGCFLEMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5840C40", Offset = "0x5840040", VA = "0x185840C40")]
		get
		{
			return default(NFLJDGLLLHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public KKHDEPBDMGH LAIIGJPOMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5840BC0", Offset = "0x583FFC0", VA = "0x185840BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public LCLHBJLEOJH(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5840B20", Offset = "0x583FF20", VA = "0x185840B20", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(LCLHBJLEOJH LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface MILFLABAMPI
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string ABLJHENNODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] KKMFLEGGHJJ(IEnumerable<PIFKOMHKCPK> EECPPFPKBHF);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMFFIMLEPBE AKCOEECCHCA(Guid OKAOLBFOAIE);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEGJDCPMGJD(GameObject GACFHLOJJGF, out CMFFIMLEPBE AIOICCOKGOP);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LJIPFLDCIPD(GameObject GACFHLOJJGF, out int LAGECHEEJFG, out LENINMGJJHF MNOKFAHHNHH);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CJHAGIKCJCL DLBOKDJMCOM(PIFKOMHKCPK IPCJOMPDMMM);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CJHAGIKCJCL DLBOKDJMCOM(string EODCFKJDCMD, CMFFIMLEPBE AIOICCOKGOP, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, Vector3 DBJGDGDHOMC);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHLFEFACCMM(GameObject AGLOOKIFCOF, bool IDLFGFDILBE);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KLMAEGOFJIH(GameObject GACFHLOJJGF, bool EKLIDFHIGEM, bool PGOPPKOGOGB);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PHEKHLMGOHK
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5844590", Offset = "0x5843990", VA = "0x185844590")]
	public static CJHAGIKCJCL DLBOKDJMCOM(this MILFLABAMPI LEGFAAONKIB, CMFFIMLEPBE AIOICCOKGOP, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, Vector3 DBJGDGDHOMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface NIADIJCDEKB
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	ACHEKCMGEOE PJHGFKPOKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface EEFGHGFDIPG
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World NMGDIIEPECH();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World HNFNCHJDNHH();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World NMDNBCKPEDB();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World IADBJHLEJLC();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface MLIEFKPODIE
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	OCIGMOAGHIJ CBDOGBLGAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	MILFLABAMPI FKDHDBNPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	CMEBPNCBCMD PBEFJDJDDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	NIOKIOAHGMB AEBPHNIBJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	IAMHJKNKNMA KFANDOBJIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IIONFMDPDBM ALCFCGLIOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	KBLGMDKDIMA BDEFBAGPIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	LGOEJMHMEMO KEGIGPILKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	LOIFKPOLLGP MPDELMHGDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface OKNKNKENPLM
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct AJIEIAAKCCA : AJHCFBOLAKM, IEquatable<AJIEIAAKCCA>
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int BJNMAHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5834AD0", Offset = "0x5833ED0", VA = "0x185834AD0", Slot = "8")]
	public bool Equals(AJIEIAAKCCA LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5834B20", Offset = "0x5833F20", VA = "0x185834B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface EACJNKBBOAA
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMKNKKCEGK(NNHEPJDBKBI HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOMNAIGJLOO(NNHEPJDBKBI HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct EFFOMHNHCBO : EKKONKFFCGH, IEquatable<EFFOMHNHCBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public LENINMGJJHF MNOKFAHHNHH;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x583A010", Offset = "0x5839410", VA = "0x18583A010", Slot = "5")]
	public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5839FE0", Offset = "0x58393E0", VA = "0x185839FE0", Slot = "4")]
	public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x583A040", Offset = "0x5839440", VA = "0x18583A040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2C90", Offset = "0x3BD2090", VA = "0x183BD2C90", Slot = "6")]
	public bool Equals(EFFOMHNHCBO LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5839F50", Offset = "0x5839350", VA = "0x185839F50", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface LCDMECHMCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool MGIAMALJMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action MANDAMLLCMO;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIMIHEDCBKN();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLFCIAOAAHD();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBIKHGGLJIK(bool GDHKPCGLKJL);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GHOHIFDICAL(ByteString OEKDIKJACFK);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task LGOOMDJEDKO();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task PPAICFPHGCO();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task MJACODMALGM();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NBGGPFMKNJP();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface JCNEDKKCDCA
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	EKFCEBIIGNK HELJEIPNKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	List<LJHGDPGPANM> CMOINNDNKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCIICAGPEIN(LJHGDPGPANM HNNIGEFAIIM, out EKFCEBIIGNK IBAIAINEMLA);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIMKNKKCEGK(LJHGDPGPANM HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOMNAIGJLOO(LJHGDPGPANM HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface BGDEBHEFMNO
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	KONOGEGNBCI CKMFKIMOBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct DNCIFCFDCBN : IEquatable<DNCIFCFDCBN>
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DNCIFCFDCBN IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private BGNPLHOEAII EIHGKPFBNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x58386D0", Offset = "0x5837AD0", VA = "0x1858386D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public float3 JHMALLLNOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5838A90", Offset = "0x5837E90", VA = "0x185838A90")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public quaternion GCELDMAAPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5838860", Offset = "0x5837C60", VA = "0x185838860")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EFBPNECENII AMANCBGDCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5838960", Offset = "0x5837D60", VA = "0x185838960")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5838800", Offset = "0x5837C00", VA = "0x185838800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public DNCIFCFDCBN(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public static KDLENLDMBAK PGDDHPNABOB(DNCIFCFDCBN KKIAKNLLHIO)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5838760", Offset = "0x5837B60", VA = "0x185838760", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(DNCIFCFDCBN LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface BPJPLKILODH
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action NBGGPFMKNJP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action KNAAOKMKOEC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action OMPBBHFMBEH;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface EKFCEBIIGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string IAGIIMOLDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	EKFCEBIIGNK HMBOANPLIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	IEnumerable<EKFCEBIIGNK> JLIAMNCJPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DefaultMember("Item")]
public struct PPACDBGDBCI : IReadOnlyList<KDLENLDMBAK>, IEnumerable<KDLENLDMBAK>, IEnumerable, IReadOnlyCollection<KDLENLDMBAK>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OBHLAFCJEFF : IEnumerator<KDLENLDMBAK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly AOONNPAOEFB FHJACJEANIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeArray<LocalId>.Enumerator EOIJHGCOGLO;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public KDLENLDMBAK NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x58441C0", Offset = "0x58435C0", VA = "0x1858441C0", Slot = "4")]
			get
			{
				return default(KDLENLDMBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x5844110", Offset = "0x5843510", VA = "0x185844110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x16CEB90", Offset = "0x16CDF90", VA = "0x1816CEB90")]
		public OBHLAFCJEFF(AOONNPAOEFB FHJACJEANIP, NativeArray<LocalId>.Enumerator EOIJHGCOGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5844050", Offset = "0x5843450", VA = "0x185844050", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5844090", Offset = "0x5843490", VA = "0x185844090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x58440D0", Offset = "0x58434D0", VA = "0x1858440D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeArray<LocalId> KOJOICDCDNK;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public KDLENLDMBAK OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5845A60", Offset = "0x5844E60", VA = "0x185845A60", Slot = "4")]
		get
		{
			return default(KDLENLDMBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x58455C0", Offset = "0x58449C0", VA = "0x1858455C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int MNAGJMFCFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DDCIGFMHKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x58454B0", Offset = "0x58448B0", VA = "0x1858454B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public NativeArray<LocalId> IBJLCBOEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC40", Offset = "0x16CF040", VA = "0x1816CFC40")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	internal NativeArray<Entity> DLEOKIGAIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x58455D0", Offset = "0x58449D0", VA = "0x1858455D0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5845930", Offset = "0x5844D30", VA = "0x185845930")]
	public PPACDBGDBCI(int EPMEDFGLJOE, AOONNPAOEFB FHJACJEANIP, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x16CE690", Offset = "0x16CDA90", VA = "0x1816CE690")]
	public PPACDBGDBCI(AOONNPAOEFB FHJACJEANIP, NativeArray<LocalId> KOJOICDCDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x58458C0", Offset = "0x5844CC0", VA = "0x1858458C0")]
	internal PPACDBGDBCI(AOONNPAOEFB FHJACJEANIP, NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x58459C0", Offset = "0x5844DC0", VA = "0x1858459C0")]
	public PPACDBGDBCI(AOONNPAOEFB FHJACJEANIP, int PGBALNGGNPG, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5845810", Offset = "0x5844C10", VA = "0x185845810")]
	public PPACDBGDBCI(PPACDBGDBCI COBCBICOBCC, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5845410", Offset = "0x5844810", VA = "0x185845410")]
	public PPACDBGDBCI DGCDPJOAHEA(Allocator GMMIODGPFPJ = Allocator.Temp)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x58454F0", Offset = "0x58448F0", VA = "0x1858454F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5845530", Offset = "0x5844930", VA = "0x185845530")]
	public OBHLAFCJEFF FNKOJPGNHJL()
	{
		return default(OBHLAFCJEFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5845630", Offset = "0x5844A30", VA = "0x185845630", Slot = "6")]
	private IEnumerator<KDLENLDMBAK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5845720", Offset = "0x5844B20", VA = "0x185845720", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CMFFIMLEPBE : IComparable<CMFFIMLEPBE>, IEquatable<CMFFIMLEPBE>, EKKONKFFCGH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const uint ABMJILPDIBK = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const uint IKLCOJBBNMC = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CMFFIMLEPBE GBNLDGHKLNF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int PCOFAPIEAMK = 24;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private const uint JIHAKAFOGHC = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private const int CFBOGADILJH = 8;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const uint PMEFJJGJCFP = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly uint NCKLDJBDGMM;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public uint IPCGHILBHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x106D060", Offset = "0x106C460", VA = "0x18106D060")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public uint EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x58384A0", Offset = "0x58378A0", VA = "0x1858384A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public uint MJBMGPCMKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool MFCBPLJLPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x52B3C30", Offset = "0x52B3030", VA = "0x1852B3C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x142F0D0", Offset = "0x142E4D0", VA = "0x18142F0D0")]
	public static CMFFIMLEPBE KNHHHPOFMBB(uint NCKLDJBDGMM)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x58385E0", Offset = "0x58379E0", VA = "0x1858385E0")]
	public CMFFIMLEPBE(int IMMGGKGMOEF, int OFBJCGCFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x58385E0", Offset = "0x58379E0", VA = "0x1858385E0")]
	public CMFFIMLEPBE(uint IMMGGKGMOEF, int OFBJCGCFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x58385E0", Offset = "0x58379E0", VA = "0x1858385E0")]
	public CMFFIMLEPBE(uint IMMGGKGMOEF, uint OFBJCGCFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
	private CMFFIMLEPBE(uint NCKLDJBDGMM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x52B3CC0", Offset = "0x52B30C0", VA = "0x1852B3CC0")]
	public static bool MCJHDEKAHDI(CMFFIMLEPBE EJOFMGLMADH, CMFFIMLEPBE CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x58383E0", Offset = "0x58377E0", VA = "0x1858383E0", Slot = "5")]
	public bool Equals(CMFFIMLEPBE MLGAFKBKMCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5838310", Offset = "0x5837710", VA = "0x185838310", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x30F3360", Offset = "0x30F2760", VA = "0x1830F3360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5838510", Offset = "0x5837910", VA = "0x185838510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5838440", Offset = "0x5837840", VA = "0x185838440", Slot = "6")]
	public void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x58384B0", Offset = "0x58378B0", VA = "0x1858384B0", Slot = "7")]
	public void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5838300", Offset = "0x5837700", VA = "0x185838300", Slot = "4")]
	public int CompareTo(CMFFIMLEPBE LNOOAJJNCAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface PGKBPEGCPKO
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLLJBIFKDHL(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEFPLBIKJOF(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 KLGLGOFKLKK(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMDNKOPAAID(Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion OJALBBDGOLE(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNECNGGHHBL(Entity FKNFFDFGNMN, out float3 OMFIFBMFGMG, out quaternion PFHPGOOLCFP);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FNECNGGHHBL(Entity FKNFFDFGNMN, out RigidTransform FGPGCDAKBPB);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JHIFLLJCCAI(Entity FKNFFDFGNMN, out RigidTransform FGPGCDAKBPB);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 AKEMNHBHJLN(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IOHCNOFDJGP(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNFCJEOBJJG(Entity FKNFFDFGNMN, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float FJNJBFLENFO(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FNAHBLFDOOC(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 NCHOCFKCMEJ(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BJOOBAJCHIA(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 EBNIMCFMDDE(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MFOMCJMMBPP(Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion CCCAIKOJMAO(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 EAKMOACDLLI(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IKEICOPHCJK(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GOIKJJIMLKO(Entity FKNFFDFGNMN, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float EANEEINKPOJ(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CIOMNINEODE(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 JOFIOKOAPDD(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CLGHDJGBMCO(Entity FKNFFDFGNMN, out float4x4 EDPPOHIOEHO);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NEGGJLHLKNJ(Entity FKNFFDFGNMN, in float4x4 EDPPOHIOEHO);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JPGEJBJOLPN(Entity FKNFFDFGNMN, out float4x4 EDPPOHIOEHO);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool AMHGHJGADGN(Entity FKNFFDFGNMN, out Transform FELEGEFPADK);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EJCCDMCCDNF(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FECCAPKOEFF(Entity FKNFFDFGNMN, Entity KMKEMACKNKI, Entity GHLIBENNEBB);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ECIDFDMGEDJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct JLLNNHEPACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IEnumerable<PIFKOMHKCPK> EECPPFPKBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IReadOnlyList<GameObject> HHDHIJMHFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IReadOnlyList<int> JEEHNBOJABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IReadOnlyList<(CMFFIMLEPBE, CMFFIMLEPBE)> CBHMJIEBOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int BPALBLOKNHB;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool MFCBPLJLPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x583F230", Offset = "0x583E630", VA = "0x18583F230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int OLFELOIMDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IEnumerable<GameObject> CKOFFDFDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9C2D0", Offset = "0xA9B6D0", VA = "0x180A9C2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IEnumerable<(CMFFIMLEPBE src, CMFFIMLEPBE dst)> BMCKMADKAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x583F640", Offset = "0x583EA40", VA = "0x18583F640")]
	public JLLNNHEPACB(IEnumerable<PIFKOMHKCPK> EECPPFPKBHF, IReadOnlyList<GameObject> HHDHIJMHFNG, IReadOnlyList<int> JEEHNBOJABM, IReadOnlyList<(CMFFIMLEPBE src, CMFFIMLEPBE dst)> CBHMJIEBOKD, int BPALBLOKNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x583F290", Offset = "0x583E690", VA = "0x18583F290")]
	public (GameObject, int)[] EKNENLBLBBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct IPHCFGGLOCO : IEquatable<IPHCFGGLOCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly IPHCFGGLOCO IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private IIKMCLIAKNK DMKEHNBEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x583DFD0", Offset = "0x583D3D0", VA = "0x18583DFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public PPACDBGDBCI PGMIGOCDBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x583E3A0", Offset = "0x583D7A0", VA = "0x18583E3A0")]
		get
		{
			return default(PPACDBGDBCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IEnumerable<EFBPNECENII> MNIKMGFJGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x583E4E0", Offset = "0x583D8E0", VA = "0x18583E4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IEnumerable<EFBPNECENII> KEHLOEBFAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x583E880", Offset = "0x583DC80", VA = "0x18583E880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int IMMCGJDIMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x583E7A0", Offset = "0x583DBA0", VA = "0x18583E7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int IPGKPFOLEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x583DD70", Offset = "0x583D170", VA = "0x18583DD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string GHALHBJBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x583E6D0", Offset = "0x583DAD0", VA = "0x18583E6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public GLOKJOPHMOK BOCFBGHCIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x583E2A0", Offset = "0x583D6A0", VA = "0x18583E2A0")]
		get
		{
			return default(GLOKJOPHMOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x583DDC0", Offset = "0x583D1C0", VA = "0x18583DDC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EAMGDIDKDJL GFMBCFOHHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x583E320", Offset = "0x583D720", VA = "0x18583E320")]
		get
		{
			return default(EAMGDIDKDJL);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x583E0F0", Offset = "0x583D4F0", VA = "0x18583E0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool FAKEDDBJMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x583E4C0", Offset = "0x583D8C0", VA = "0x18583E4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KPMMIKIJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x583E650", Offset = "0x583DA50", VA = "0x18583E650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HPEGCPEOILL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x583DEE0", Offset = "0x583D2E0", VA = "0x18583DEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool ADBMCDJBBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x583DD40", Offset = "0x583D140", VA = "0x18583DD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool PKHBJPCJBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x583DD60", Offset = "0x583D160", VA = "0x18583DD60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x583E390", Offset = "0x583D790", VA = "0x18583E390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool KGGMEFKOAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x583E310", Offset = "0x583D710", VA = "0x18583E310")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x583E4B0", Offset = "0x583D8B0", VA = "0x18583E4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public HIBANDCMFGC GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(HIBANDCMFGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public PLEMBKHENGI HIGPLAHDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(PLEMBKHENGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x583E670", Offset = "0x583DA70", VA = "0x18583E670")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public static EFBPNECENII PGDDHPNABOB(IPHCFGGLOCO OHJGEOICJDB)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x583E9C0", Offset = "0x583DDC0", VA = "0x18583E9C0")]
	public bool NNLNKPJLKOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x583DF00", Offset = "0x583D300", VA = "0x18583DF00")]
	public bool FMGFIMAFNAJ(CPJLKGMKAHP HJFEJJMKLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x583E060", Offset = "0x583D460", VA = "0x18583E060")]
	public void GEGHNPPDKIA(CPJLKGMKAHP HJFEJJMKLEL, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x583E9E0", Offset = "0x583DDE0", VA = "0x18583E9E0")]
	public PPACDBGDBCI OAJEPEOJOCB(Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x583E170", Offset = "0x583D570", VA = "0x18583E170")]
	public void HMJKPLFHFJH(IPHCFGGLOCO LNOOAJJNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public IPHCFGGLOCO(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(IPHCFGGLOCO KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x583DE40", Offset = "0x583D240", VA = "0x18583DE40", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(IPHCFGGLOCO LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface EBCPMJGAKEI
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNJLEIKABKI(PPACDBGDBCI KOJOICDCDNK);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JINKKIFJBDB(GameObject GACFHLOJJGF, int GOPOCFHDHKM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct ENBHLEENBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly FFNGPNMBHLC GNBCIEFMNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly FFNGPNMBHLC IGMAELCNDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly uint NBBOAIKHHPE;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x583A0D0", Offset = "0x58394D0", VA = "0x18583A0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct BJOHLMPECOB
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly ENBHLEENBJD FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5835980", Offset = "0x5834D80", VA = "0x185835980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct IOFNELPJOED
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly ENBHLEENBJD FJBAKNFCPGP;

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5835980", Offset = "0x5834D80", VA = "0x185835980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct MFAKLBNKJPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly uint NBBOAIKHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly bool GDBLOAHBCNN;

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5842AF0", Offset = "0x5841EF0", VA = "0x185842AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface NIOKIOAHGMB
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool JLJPKNGFMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool ECGANMDLMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool CKNHKDAAKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool GKDCNDFALED
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDGIOAECIDB(object KBLLMJIHKAK);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJIPHBENJEP(object GDNOLIODDHJ);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAGMICHAJAO(object GDNOLIODDHJ);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NDFECBLKPII(GameObject BKJBFAHBGJH);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LBJKIPIEKEI(NativeArray<int> IABCNMODPJN);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface HNIPNFEMKKN
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POONOMKELDH(KDLENLDMBAK LCODCOPGHJA, ELAIMCPDFHF KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELAIMCPDFHF HNJEAIJMHBN(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHPKFCEIGDC(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGCNEKOCFFL(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JEONIAELMNM(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KDLENLDMBAK EOJCKGCFKPD(KDLENLDMBAK LCODCOPGHJA, int NANJAGEOPJI);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLKHAAMOCPF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JPOEKBEILCA(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK, KDLENLDMBAK KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BENPJPFGFKL(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JENLOODCAIE(KDLENLDMBAK LCODCOPGHJA, out KDLENLDMBAK KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIEPNGNODNH(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GKMLBOKHBGP(KDLENLDMBAK LCODCOPGHJA, out float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void INCMHCDJAJC(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FMDKCGFMHLD(KDLENLDMBAK LCODCOPGHJA, out float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EHKDALFLAIJ(KDLENLDMBAK LCODCOPGHJA, (Quaternion rot, Vector3 moments) KKLEBPJFJGN);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IFAMIFFPHOL(KDLENLDMBAK LCODCOPGHJA, out quaternion IFDCCCEDOFF, out float3 BBHGAMIEKKG);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OIPPDNGMOPI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HKOKHONODBB(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 HEKNMNIKLIH(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 EKNLDIAEDIL(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AFDKBPGBFOP(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IINDCHHCPBG(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float JNMHPMHDKNK(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float DAFCBPBOEFJ(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JENCFFBEKON(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FOBBEKKGLOD(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode BEGKKJLFPHM(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AJNNKGJLFBN(KDLENLDMBAK LCODCOPGHJA, CollisionDetectionMode KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PPADPBDPHGN AAJPPHGACBL(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PPFHMLBAOPK(KDLENLDMBAK LCODCOPGHJA, PPADPBDPHGN KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JHHFJHHPMNI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EKNEALNFDBM(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	KDLENLDMBAK HIJCLBEKBJN(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ONKICCKEALM(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	KDLENLDMBAK BGOPCJKFHEJ(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CIGBDIGMBAB(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	BFEGGBIPHDI MKPPFBJNEDF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void MKJNDPEEJKO(KDLENLDMBAK LCODCOPGHJA, BFEGGBIPHDI MCKIFIEILPL);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool NINDJMHMLHP(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void JCLEKBOHOEE(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool HABCIFAFHLP(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void EMPLLCLNICH(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool JHBDLEJMDML(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void PEMAJJBCNLH(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints KNJGAOPOOLK(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void ELKBALPBCDG(KDLENLDMBAK LCODCOPGHJA, RigidbodyConstraints KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float ALDJFBKMGIK(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void DHMMBIJIGCN(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float AIEOHGNHJKI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void IIDCOFDFJCO(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool BMLJEINJMMP(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void GOEPHFBLEIO(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool KICINIEFMJK(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void OKKNADNHCHH(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void IIKMPPBGOKE(KDLENLDMBAK LCODCOPGHJA, int KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object OGOBFKJIMLF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LIAFBCOCMHD(KDLENLDMBAK LCODCOPGHJA, object KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object HIKPELDOOCD(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void DLNBIIBMBIB(KDLENLDMBAK LCODCOPGHJA, object KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float JCPNDJFNKJP(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void BHBJAIOINPH(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void DHCKBHKDGOA(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void EDFJDPBIJCE(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool KKNMGGMOBHB(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void OAJFCJHCBKL(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void NNNDLBAIMJN(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool EOGCOOLDAAF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool IPGOBKJCEOD(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody ALONCOMHLHI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PMKAPGKELNJ(KDLENLDMBAK LCODCOPGHJA, Rigidbody HCHEOFCJLMB);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void FOEDBBCKFAI(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void GNGBJDCLCGN(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool LFALHCLOLNJ(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void GGIBEBDBOBI(KDLENLDMBAK LCODCOPGHJA, float3 CPDGHJJAFAA);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BCPGILPBCMJ(KDLENLDMBAK LCODCOPGHJA, float3 HNJKKMCILJI);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool BHGMIDANAFH(KDLENLDMBAK LCODCOPGHJA, out float3 CPDGHJJAFAA);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool KCJMGOOICDI(KDLENLDMBAK LCODCOPGHJA, out float3 HNJKKMCILJI);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool KHECNLMGIHO(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void JHAKEHDCGIK(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK, bool OLBFAGCJMOD);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void ANHHNAEHEAP(KDLENLDMBAK LCODCOPGHJA, bool DHMDHJJOHID);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void KPFDLNKKCBC(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool MJLLEOCCDKJ(KDLENLDMBAK LCODCOPGHJA);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface KGIPPHJNDDF
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJEDHFBPNKF(Entity NPIDDFCIBDJ);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IODLPDOICIP(Entity NPIDDFCIBDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct FNFCOLDDMLG : IEquatable<FNFCOLDDMLG>
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FNFCOLDDMLG IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string MCNCONKIDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x583A6A0", Offset = "0x5839AA0", VA = "0x18583A6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public string DINCPLDPNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x583A890", Offset = "0x5839C90", VA = "0x18583A890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public FNFCOLDDMLG(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x583A600", Offset = "0x5839A00", VA = "0x18583A600", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(FNFCOLDDMLG LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface OCIGMOAGHIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAJIMMKIMAO();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGEBDIOBJDF(bool JDKFIDJGOGL);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFBCOCPKPHG(GameObject GACFHLOJJGF);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct FNJNDAOKPMH : IEquatable<FNJNDAOKPMH>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FNJNDAOKPMH IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x583A970", Offset = "0x5839D70", VA = "0x18583A970", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(FNJNDAOKPMH LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct CEBIEIKPHJJ : IEquatable<CEBIEIKPHJJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CEBIEIKPHJJ IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private BKIGCJIBBEC JEHBMICDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5836E60", Offset = "0x5836260", VA = "0x185836E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool CHBFJLENKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x5837510", Offset = "0x5836910", VA = "0x185837510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool IDHPAJIKDID
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5837370", Offset = "0x5836770", VA = "0x185837370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool BPBHHLKCGMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5836F50", Offset = "0x5836350", VA = "0x185836F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool FHNIKGGIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x58368E0", Offset = "0x5835CE0", VA = "0x1858368E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool OCHPEBOAILI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5837130", Offset = "0x5836530", VA = "0x185837130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool PJIMIAIEEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5836BD0", Offset = "0x5835FD0", VA = "0x185836BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x5836EF0", Offset = "0x58362F0", VA = "0x185836EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5836F80", Offset = "0x5836380", VA = "0x185836F80")]
	public bool LGHIFENHGAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5836FC0", Offset = "0x58363C0", VA = "0x185836FC0")]
	public EFBPNECENII NMANOONOBAC(EFBPNECENII GDNOLIODDHJ)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5836A00", Offset = "0x5835E00", VA = "0x185836A00")]
	public KDLENLDMBAK BLHEDBKOOOK()
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public CEBIEIKPHJJ(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(CEBIEIKPHJJ KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5836DC0", Offset = "0x58361C0", VA = "0x185836DC0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(CEBIEIKPHJJ LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface JGJJAGMGKPI
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LENINMGJJHF DCOHCPNOGJP(GameObject BKJBFAHBGJH);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHHNAAJIGDI(GameObject GACFHLOJJGF, LOICABBCFFI MHBLJGCGANO, MLJJMANCKBM HKBDAKPECLG);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct GLFLLKHPAHK : IComparable<GLFLLKHPAHK>, IEquatable<GLFLLKHPAHK>
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly GLFLLKHPAHK GBNLDGHKLNF;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly GLFLLKHPAHK CGDIEAADOPD;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly GLFLLKHPAHK LCOOAHIICKG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly GLFLLKHPAHK BMKKICPPDCB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly GLFLLKHPAHK JHIIACOMIMJ;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly GLFLLKHPAHK OCMPAPGDDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int BJNMAHEDMNC;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool FDGDKJKGLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x583AEA0", Offset = "0x583A2A0", VA = "0x18583AEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int PDHLEDJLHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x583AEB0", Offset = "0x583A2B0", VA = "0x18583AEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
	public GLFLLKHPAHK(int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x583AE30", Offset = "0x583A230", VA = "0x18583AE30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x583ADA0", Offset = "0x583A1A0", VA = "0x18583ADA0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2C90", Offset = "0x3BD2090", VA = "0x183BD2C90", Slot = "5")]
	public bool Equals(GLFLLKHPAHK LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x583AD90", Offset = "0x583A190", VA = "0x18583AD90", Slot = "4")]
	public int CompareTo(GLFLLKHPAHK LNOOAJJNCAE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x142F0D0", Offset = "0x142E4D0", VA = "0x18142F0D0")]
	public static GLFLLKHPAHK PGDDHPNABOB(int NANJAGEOPJI)
	{
		return default(GLFLLKHPAHK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x142F0D0", Offset = "0x142E4D0", VA = "0x18142F0D0")]
	public static int PGDDHPNABOB(GLFLLKHPAHK KOAJDKDANHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x583AEC0", Offset = "0x583A2C0", VA = "0x18583AEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface ABLEKJPBMJE : IEnumerable<MLIEHECMNHI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	MLIEHECMNHI OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLIEHECMNHI IMOMPCNDOJA(NNHEPJDBKBI KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GLFLLKHPAHK ELFFHKHOAAN(NNHEPJDBKBI KKIJPENOLBP);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class GDJEKGFFMIA
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1970CF0", Offset = "0x19700F0", VA = "0x181970CF0")]
	public static GLFLLKHPAHK ELFFHKHOAAN<T>(this ABLEKJPBMJE NFDNHCCMBMJ, AFHAKKMHKHI<T> DKPHPKDPBCM) where T : struct
	{
		return default(GLFLLKHPAHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface JAOEAHCDOAB
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOOCHNBNFON(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIPMBPGLBJH(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FOHEPMIDLHB(KDLENLDMBAK LCODCOPGHJA, out Guid GHNPAEHCAPA);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GOEBDMKJCJI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAGPEHNGOBH(KDLENLDMBAK LCODCOPGHJA, Guid GHNPAEHCAPA);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BODCJGNHGEP(KDLENLDMBAK LCODCOPGHJA, out Guid AGMGFKBEKDG);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid PPFBJONDPEK(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLIBCGGMKCG(KDLENLDMBAK LCODCOPGHJA, Guid AGMGFKBEKDG);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AMKCOFMHHJO(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LCFAIMDJBOL(KDLENLDMBAK CDFHGECAPKI, KDLENLDMBAK ILDFJHMNOPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface MBJPBGDNNCH
{
	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAHFFFEGJHJ(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct APMGOACLPEO : IEquatable<APMGOACLPEO>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly APMGOACLPEO IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public LPJBLNGGKAG IECAPLODELL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(LPJBLNGGKAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private OHGCCAODDFB CLJEFLMHHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5835640", Offset = "0x5834A40", VA = "0x185835640")]
		get
		{
			return default(OHGCCAODDFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public EHKHPDFBEJD MGMOJPCHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x58356B0", Offset = "0x5834AB0", VA = "0x1858356B0")]
		get
		{
			return default(EHKHPDFBEJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public APMGOACLPEO(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(APMGOACLPEO KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5835550", Offset = "0x5834950", VA = "0x185835550", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(APMGOACLPEO LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface KKJECAIDLGC
{
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLAABHFDBKD(KDLENLDMBAK LCODCOPGHJA, GLOKJOPHMOK PIAMNDKENMK, bool KGPEAFEAABL, CPJLKGMKAHP CAJNPIDABDJ);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBLNFINDANN(KDLENLDMBAK LCODCOPGHJA, GLOKJOPHMOK PIAMNDKENMK, bool KGPEAFEAABL, bool APGLEAFLIOH, bool JEOFKEKHJFP);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FAAACEJLHBB PLNOEGBGHHK(KDLENLDMBAK COMCNEGAGFF, List<KDLENLDMBAK> IFDIAHPHOAE);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDHKKMNBBPJ(GameObject DEEPKBLHNMO, GameObject NJBMLNJHOFJ);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPCIAIHLABB(GameObject NJBMLNJHOFJ);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T KGMGHOKKADC<T>(GameObject AJOEPLFEHEE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJIMNACABAH(Collider JGLBLFOJFCH);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LBNGALCCILL<T>(string DKPHPKDPBCM) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface ANLJAEDMKMC
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	IReadOnlyCollection<GKAKPCKINHA> DGLNIIDFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIOKANDHIEG(int EPAJCDGEEKI, out GKAKPCKINHA BGHJBFABJHA);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKAKPCKINHA FGBNPDAOODO(Type JLNNFEOBAMK);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class FPEHOAPIBEC
{
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x19679E0", Offset = "0x1966DE0", VA = "0x1819679E0")]
	public static T FBCKBCGAFDP<T>(this ANLJAEDMKMC BCODCENCABJ, Entity FKNFFDFGNMN) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1967A80", Offset = "0x1966E80", VA = "0x181967A80")]
	public static GKAKPCKINHA FGBNPDAOODO<T>(this ANLJAEDMKMC BCODCENCABJ) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface CMEBPNCBCMD
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFNCGLCCALA(bool GDHKPCGLKJL);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface KNAEKBFOOHL
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface LPMPALGCIEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	bool FNOGJLCJGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool NJJLPDCMGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	PDOBJBPMLLM DGAIHMEADPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LJMLKHMFDNK KFFHJEIGHPH(bool LBACNOAIGNH = false);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LJMLKHMFDNK BIGJPCOPFJP(IEnumerable<KDLENLDMBAK> KOJOICDCDNK, in JHHGOKLOOPH NKJIKOHPNDP);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LLEIAOFCAJL FFKMLIIKPIG(ByteString FNOMKLBPLHC);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EGPAMILOEKO EGOMNFFJPKE(ByteString OEKDIKJACFK, KDLENLDMBAK ILDFJHMNOPJ, in JHHGOKLOOPH OHHNNICFOGI, NPKIHKJLIJM PCAJHGGKAME, bool KFBCEJHHGFP = true);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEEFMKMBIOA();

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MPIHIMJOKNI(bool NMGHCFGCMKO);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JLLNNHEPACB MIPHHPPEMHP(IEnumerable<PIFKOMHKCPK> EECPPFPKBHF);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class MJLNMBDAEOE
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface NBGOAKDNEPN : FDGKLMNACMK, GFGEKEKINCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	HKJKANBGCIL FNKCBJOHLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	MLIEFKPODIE MANJOJKJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	LCDMECHMCNI OEFCADIFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface GFGEKEKINCH
{
	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool EHMEEIIOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface BJPDMBGDPHK
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool FBLAJGHHONL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool BNCJBNENAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface CLNNDLPCIAD
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	Guid PEMKIMNLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FECECIKNMAI(Guid GHNPAEHCAPA, Guid AGMGFKBEKDG, string DKPHPKDPBCM);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FFNGPNMBHLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	internal int IFONHBAKCAB;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x583A450", Offset = "0x5839850", VA = "0x18583A450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class HPGADFGNBJM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private struct HNDJADEMEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Guid EBABBHGKMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FMIDMLOAELI KGCGBHIPBAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct FMIDMLOAELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int KKIAKNLLHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int ILJNHPJFGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int FFIJBKOCLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int IGJBIPDIIIB;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x583A540", Offset = "0x5839940", VA = "0x18583A540")]
		public bool LILHDCBNDHG(out CMFFIMLEPBE AIOICCOKGOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x583A5E0", Offset = "0x58399E0", VA = "0x18583A5E0")]
		public FMIDMLOAELI(CMFFIMLEPBE AIOICCOKGOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x583DC10", Offset = "0x583D010", VA = "0x18583DC10")]
	public static Guid IMFGAANFJCA(this CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x583DBF0", Offset = "0x583CFF0", VA = "0x18583DBF0")]
	public static bool GMJPIDKDBMC(this Guid EBABBHGKMJL, out CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(LNAIKKAAIPE))]
public readonly struct KDLENLDMBAK : IComparable<KDLENLDMBAK>, IEquatable<KDLENLDMBAK>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KDLENLDMBAK GBNLDGHKLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JODLCELHFNO PPCGBBAKOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LocalId LCODCOPGHJA;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public LocalId HALOCNPMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x13BF910", Offset = "0x13BED10", VA = "0x1813BF910")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool HABKCECLKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x5840330", Offset = "0x583F730", VA = "0x185840330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool MIOHFHBNBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x58405C0", Offset = "0x583F9C0", VA = "0x1858405C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool CBLPLGPAMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5840310", Offset = "0x583F710", VA = "0x185840310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5840810", Offset = "0x583FC10", VA = "0x185840810")]
	public KDLENLDMBAK(AOONNPAOEFB CHMPCCBMGKG, LocalId LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
	public EFBPNECENII BANGAMJFLLG()
	{
		return default(EFBPNECENII);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x13BF910", Offset = "0x13BED10", VA = "0x1813BF910")]
	public static LocalId PGDDHPNABOB(KDLENLDMBAK JJBBNOFEJFM)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5840700", Offset = "0x583FB00", VA = "0x185840700")]
	public static Entity PGDDHPNABOB(KDLENLDMBAK JJBBNOFEJFM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x58406A0", Offset = "0x583FAA0", VA = "0x1858406A0")]
	public static bool MCJHDEKAHDI(KDLENLDMBAK EJOFMGLMADH, KDLENLDMBAK CMACFBOCONA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x58405E0", Offset = "0x583F9E0", VA = "0x1858405E0")]
	public static bool JJOPDHABKNF(KDLENLDMBAK EJOFMGLMADH, KDLENLDMBAK CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5840710", Offset = "0x583FB10", VA = "0x185840710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5840410", Offset = "0x583F810", VA = "0x185840410", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x58402B0", Offset = "0x583F6B0", VA = "0x1858402B0", Slot = "4")]
	public int CompareTo(KDLENLDMBAK LNOOAJJNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x58404E0", Offset = "0x583F8E0", VA = "0x1858404E0", Slot = "5")]
	public bool Equals(KDLENLDMBAK LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PJELFCOPLOM
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5844BE0", Offset = "0x5843FE0", VA = "0x185844BE0")]
	public static CMFFIMLEPBE NLOPILAOEJF(this KDLENLDMBAK ICNDEPGFBMI)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x12D7F70", Offset = "0x12D7370", VA = "0x1812D7F70")]
	public static T PHBEADLJDEK<T>(this KDLENLDMBAK ICNDEPGFBMI) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class LNAIKKAAIPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface FKMCIKMFIDA
{
	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHEKLBGCINI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPCDMGCOEAP(KDLENLDMBAK LCODCOPGHJA, bool KGPEAFEAABL, bool APGLEAFLIOH, bool JDMEJOLPODA);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct NPCCBNHIEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PPACDBGDBCI AHGPNHPBGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NativeArray<byte> LCEOCHLKMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NativeArray<byte> OIKAFLDALHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly GLFLLKHPAHK KOAJDKDANHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int HJKBAIEDLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Type AAJLMBPLIGM;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public PPACDBGDBCI HIDFMDLHCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x16CFA50", Offset = "0x16CEE50", VA = "0x1816CFA50")]
		get
		{
			return default(PPACDBGDBCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5843FE0", Offset = "0x58433E0", VA = "0x185843FE0")]
	public NPCCBNHIEEP(PPACDBGDBCI AHGPNHPBGNL, NativeArray<byte> LCEOCHLKMEN, NativeArray<byte> OIKAFLDALHD, GLFLLKHPAHK KOAJDKDANHI, int HJKBAIEDLHM, Type AAJLMBPLIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9CC0", Offset = "0x2BD90C0", VA = "0x182BD9CC0")]
	public NativeArray<T> PEJJNBKOPBJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9B60", Offset = "0x2BD8F60", VA = "0x182BD9B60")]
	public NativeArray<T> BLGBFPAEEBE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9BA0", Offset = "0x2BD8FA0", VA = "0x182BD9BA0")]
	public (PPACDBGDBCI, NativeArray<T>, NativeArray<T>) IKHPLCCBENN<T>() where T : struct
	{
		return default((PPACDBGDBCI, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5843F40", Offset = "0x5843340", VA = "0x185843F40")]
	public OJGPABLJLLP CHIKJPECLLD()
	{
		return default(OJGPABLJLLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct NHNIIGMMKJO : IEquatable<NHNIIGMMKJO>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly NHNIIGMMKJO IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x5843CC0", Offset = "0x58430C0", VA = "0x185843CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5843D20", Offset = "0x5843120", VA = "0x185843D20")]
	public void LDGLMGBHCME(bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5843B60", Offset = "0x5842F60", VA = "0x185843B60")]
	public void KMODDNBHENJ(bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8430", Offset = "0x2BD7830", VA = "0x182BD8430")]
	public T HIGOOBJAOAL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public NHNIIGMMKJO(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5843AC0", Offset = "0x5842EC0", VA = "0x185843AC0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(NHNIIGMMKJO LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct CPNGBIGHKOL : IEquatable<CPNGBIGHKOL>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly CPNGBIGHKOL IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x58385F0", Offset = "0x58379F0", VA = "0x1858385F0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(CPNGBIGHKOL LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface AJMPOCCEJIG
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	DDKNJPLJEMG HCCILABALFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	DDKNJPLJEMG KNFLIILNBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	DDKNJPLJEMG DGCDPJOAHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	DDKNJPLJEMG EBMIPOGEBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	DDKNJPLJEMG ODGLNDCHDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	DDKNJPLJEMG LLNIBAPEILO
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	DDKNJPLJEMG AACPEKPIMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	DDKNJPLJEMG NIGNEOOFOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct BMJAGFBFJOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float LLNGFBAMAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 LHLKLIEJLPJ;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct LPJBLNGGKAG : IEquatable<LPJBLNGGKAG>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly LPJBLNGGKAG IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private DBLFFOKJPEC CNCBEFINCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5841F50", Offset = "0x5841350", VA = "0x185841F50")]
		get
		{
			return default(DBLFFOKJPEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public EBANBKPGGPC CJENPOMEMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5842120", Offset = "0x5841520", VA = "0x185842120")]
		get
		{
			return default(EBANBKPGGPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public IBFGOAFAJIC AMOPNPBDJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x5841EE0", Offset = "0x58412E0", VA = "0x185841EE0")]
		get
		{
			return default(IBFGOAFAJIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public GNLFEOODAEI KFEDDFKIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x58418F0", Offset = "0x5840CF0", VA = "0x1858418F0")]
		get
		{
			return default(GNLFEOODAEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public AKFHJJDFLNB IHHMMBMIGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5842040", Offset = "0x5841440", VA = "0x185842040")]
		get
		{
			return default(AKFHJJDFLNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public LIADJHCPFLA KDNJICPHKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5841C70", Offset = "0x5841070", VA = "0x185841C70")]
		get
		{
			return default(LIADJHCPFLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5841AD0", Offset = "0x5840ED0", VA = "0x185841AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public DCEBDMIDHCN BECJDGLKCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x5841A60", Offset = "0x5840E60", VA = "0x185841A60")]
		get
		{
			return default(DCEBDMIDHCN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x5841BF0", Offset = "0x5840FF0", VA = "0x185841BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float HCHGIECAOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5841DE0", Offset = "0x58411E0", VA = "0x185841DE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5841CE0", Offset = "0x58410E0", VA = "0x185841CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 HBFANJKKOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5841E50", Offset = "0x5841250", VA = "0x185841E50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x58419D0", Offset = "0x5840DD0", VA = "0x1858419D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float FGJALMOGHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x5841FC0", Offset = "0x58413C0", VA = "0x185841FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public IDHJHPGNCJM.MONOIEELGHF ADNFAEPLNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x5841960", Offset = "0x5840D60", VA = "0x185841960")]
		get
		{
			return default(IDHJHPGNCJM.MONOIEELGHF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5841D60", Offset = "0x5841160", VA = "0x185841D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public HIBANDCMFGC GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(HIBANDCMFGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5841890", Offset = "0x5840C90", VA = "0x185841890")]
	public APMGOACLPEO AAMGDNHMOMB()
	{
		return default(APMGOACLPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x58420C0", Offset = "0x58414C0", VA = "0x1858420C0")]
	public BPHMAGJHJEM OCOPPDCJHDL()
	{
		return default(BPHMAGJHJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public LPJBLNGGKAG(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5835720", Offset = "0x5834B20", VA = "0x185835720")]
	public static bool PGDDHPNABOB(LPJBLNGGKAG KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5841B50", Offset = "0x5840F50", VA = "0x185841B50", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(LPJBLNGGKAG LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface GIFAPDPEGID
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	EMFBCBAOENA FNKCBJOHLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	MLIEFKPODIE MANJOJKJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	PFJMBDHJHAN AIOAKOJFGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	IIKMCLIAKNK HIGPLAHDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	PGKBPEGCPKO CJICLLCCKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	LPMPALGCIEF CLMJPLGKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	EACJNKBBOAA CKABAILNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	EBNGCKDPAGC BNCGELIECNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	CBFLHDPJONH DNBFJLILFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	BKIGCJIBBEC IIJFBCCMPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	DGDICPPMDDO LLNIBAPEILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	MBJPBGDNNCH MMCANDAFKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	LEECIPHPBNO OPCNKLIEFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	JAOEAHCDOAB MBGPLLABIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	BGNPLHOEAII KLBCJPHKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	HNIPNFEMKKN OOGPGPFEINH
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	AJMPOCCEJIG LFCPLAFINOB
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	ANLJAEDMKMC COPHCJCEHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface DOAELEMMHCE
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	object IIALHHECNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNJLEIKABKI(PPACDBGDBCI KOJOICDCDNK);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface IIKMCLIAKNK
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<OJGPABLJLLP> MBBDIEJLJIP;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDLENLDMBAK HIJCLBEKBJN(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBEEHEFECLP(ref List<KDLENLDMBAK> OLLDFGPFFGN);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KDLENLDMBAK BGOPCJKFHEJ(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CIGBDIGMBAB(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK ILDFJHMNOPJ, bool IHNOCHJJPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBKKOGFBAGN(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK ILDFJHMNOPJ);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int JEONIAELMNM(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PPACDBGDBCI FBEOMFECMBG(KDLENLDMBAK BGPCGOEKFEF);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MGKPNBNCMAF(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK BHKMKEODELA);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OFOEOMJNIKA(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK MODHKGGCBAP);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KDLENLDMBAK JDMHPFIMIIA(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NECHJOFNONE(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD, out KDLENLDMBAK DCAFPIJMBKH);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class KBBDCOFAIPH
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x58401C0", Offset = "0x583F5C0", VA = "0x1858401C0")]
	public static List<KDLENLDMBAK> JBEEHEFECLP(this IIKMCLIAKNK FEJKNPAOBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x58400D0", Offset = "0x583F4D0", VA = "0x1858400D0")]
	public static bool ICNFEAKJBJI(this IIKMCLIAKNK FEJKNPAOBGO, KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum BIFEDELOJOL
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface EBNGCKDPAGC
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<KDLENLDMBAK> KBIPLGCLKGL(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KDLENLDMBAK GNJNHGDOJCM(KDLENLDMBAK LCODCOPGHJA, int NANJAGEOPJI);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BMNEOBLEHMD(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NDDEKGODHLE KLHIGFCJEJJ(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POMLPAGDIHL(KDLENLDMBAK LCODCOPGHJA, NDDEKGODHLE ANKHOKAAJLH);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KDLENLDMBAK MMACMFDAAGD(KDLENLDMBAK LCODCOPGHJA, [Optional] float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] float3? DBJGDGDHOMC);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDLENLDMBAK LNLGPDFEDJP(KDLENLDMBAK LCODCOPGHJA, int NANJAGEOPJI, [Optional] float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] float3? DBJGDGDHOMC);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPICEFIMCPJ(KDLENLDMBAK LCODCOPGHJA, int NANJAGEOPJI);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGKJKLFHPAN(KDLENLDMBAK LCODCOPGHJA);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface OBMMBDFHEPO
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLDMMDFLOBL(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AACDFIMAHAA(KDLENLDMBAK LCODCOPGHJA, Transform FELEGEFPADK);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface ICOBLLMLJBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	LocalId ECAHBJCILML
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	LocalId BCPAIIGFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBFFBANEOMJ(float3 LPIMIOFOIOA);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGJLLIIIDIE(float3 LPIMIOFOIOA);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BADJMKAFIHN(out float3 GNBCIEFMNKN, out float3 IGMAELCNDHD);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GLHIJFEPFDG(float3 GNBCIEFMNKN, float3 IGMAELCNDHD);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POODCHJNECF(Color GNBCIEFMNKN, Color IGMAELCNDHD);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICOBLLMLJBN Instantiate(Transform FELEGEFPADK);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface PBGCLCMFAKB
{
	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEFDPLAELIH(Transform FELEGEFPADK, ICOBLLMLJBN OGLAPIKAFNO);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICOBLLMLJBN HIHOLIJFJGM();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct ECLENOGDKNG : IEquatable<ECLENOGDKNG>
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly ECLENOGDKNG IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private DELKLMJDJON KIFILJGIPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5838F00", Offset = "0x5838300", VA = "0x185838F00")]
		get
		{
			return default(DELKLMJDJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CJECAANJEGO PBENBDDCCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5838F70", Offset = "0x5838370", VA = "0x185838F70")]
		get
		{
			return default(CJECAANJEGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5838FE0", Offset = "0x58383E0", VA = "0x185838FE0")]
	public LCLHBJLEOJH OCKDMMECFHE()
	{
		return default(LCLHBJLEOJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public ECLENOGDKNG(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x5838E60", Offset = "0x5838260", VA = "0x185838E60", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(ECLENOGDKNG LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct MOHDIFGEOGC : IEquatable<MOHDIFGEOGC>
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly MOHDIFGEOGC IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5842B90", Offset = "0x5841F90", VA = "0x185842B90", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(MOHDIFGEOGC LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct KGMAJDMNJCI : IEquatable<KGMAJDMNJCI>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly KGMAJDMNJCI IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public KGMAJDMNJCI(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5840900", Offset = "0x583FD00", VA = "0x185840900", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(KGMAJDMNJCI LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x58409A0", Offset = "0x583FDA0", VA = "0x1858409A0")]
	public bool GALDINGMDLE(out Collider JGLBLFOJFCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct MDHLGBNMCCH : IEquatable<MDHLGBNMCCH>
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly MDHLGBNMCCH IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public BPHMAGJHJEM JKBGAGEDPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x58426E0", Offset = "0x5841AE0", VA = "0x1858426E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float3 MOMDFBGEOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5842420", Offset = "0x5841820", VA = "0x185842420")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5842920", Offset = "0x5841D20", VA = "0x185842920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public quaternion LBNLHCEIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x5842390", Offset = "0x5841790", VA = "0x185842390")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5842890", Offset = "0x5841C90", VA = "0x185842890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public float3 CBLGHKALIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x58421D0", Offset = "0x58415D0", VA = "0x1858421D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5842300", Offset = "0x5841700", VA = "0x185842300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public CMGJAEOCGHK CLEBKEKEJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5842660", Offset = "0x5841A60", VA = "0x185842660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private CPJOBJPNIGK POFEEHGNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x58427B0", Offset = "0x5841BB0", VA = "0x1858427B0")]
		get
		{
			return default(CPJOBJPNIGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private MILAILKAOFA GBGAMCLDPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x58429B0", Offset = "0x5841DB0", VA = "0x1858429B0")]
		get
		{
			return default(MILAILKAOFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private IEEJIMJBFHM DFNKDGEDFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x58424B0", Offset = "0x58418B0", VA = "0x1858424B0")]
		get
		{
			return default(IEEJIMJBFHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private PGCFHLAFGCL PELDPGEMNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5842820", Offset = "0x5841C20", VA = "0x185842820")]
		get
		{
			return default(PGCFHLAFGCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private NILIBEMDKLO EPMKDJGMHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x58425F0", Offset = "0x58419F0", VA = "0x1858425F0")]
		get
		{
			return default(NILIBEMDKLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public MDHLGBNMCCH(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5842260", Offset = "0x5841660", VA = "0x185842260", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(MDHLGBNMCCH LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5842520", Offset = "0x5841920", VA = "0x185842520")]
	public void JPHMJBMHHOD(BPHMAGJHJEM KKIAKNLLHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct HIBANDCMFGC : IEquatable<HIBANDCMFGC>
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly HIBANDCMFGC IBAHPDAAEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public EFBPNECENII BHABMIFKNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x58366F0", Offset = "0x5835AF0", VA = "0x1858366F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private PGKBPEGCPKO EEHDHCHADFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x583C190", Offset = "0x583B590", VA = "0x18583C190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool JJFGELIMHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x583D0B0", Offset = "0x583C4B0", VA = "0x18583D0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 MOMDFBGEOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x583C5C0", Offset = "0x583B9C0", VA = "0x18583C5C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x583D9E0", Offset = "0x583CDE0", VA = "0x18583D9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Quaternion LBNLHCEIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x583C210", Offset = "0x583B610", VA = "0x18583C210")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x583D350", Offset = "0x583C750", VA = "0x18583D350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 EAJGLLBNNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x583CA60", Offset = "0x583BE60", VA = "0x18583CA60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x583D6B0", Offset = "0x583CAB0", VA = "0x18583D6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Quaternion FINBMEHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x583D890", Offset = "0x583CC90", VA = "0x18583D890")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x583C360", Offset = "0x583B760", VA = "0x18583C360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public float DFLNGLEFOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x583C450", Offset = "0x583B850", VA = "0x18583C450")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x583B1D0", Offset = "0x583A5D0", VA = "0x18583B1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public float GECDAEFNECM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x583B9B0", Offset = "0x583ADB0", VA = "0x18583B9B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 CBLGHKALIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x583BA60", Offset = "0x583AE60", VA = "0x18583BA60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x583BE30", Offset = "0x583B230", VA = "0x18583BE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 GHFANCNMPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x583CED0", Offset = "0x583C2D0", VA = "0x18583CED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 PBPJPDEIJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x583BC70", Offset = "0x583B070", VA = "0x18583BC70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Matrix4x4 ANACLEMDNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x583D100", Offset = "0x583C500", VA = "0x18583D100")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2046010", Offset = "0x2045410", VA = "0x182046010")]
	public HIBANDCMFGC(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5835620", Offset = "0x5834A20", VA = "0x185835620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x583BB70", Offset = "0x583AF70", VA = "0x18583BB70", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x58355F0", Offset = "0x58349F0", VA = "0x1858355F0", Slot = "4")]
	public bool Equals(HIBANDCMFGC LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5835730", Offset = "0x5834B30", VA = "0x185835730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x583BC10", Offset = "0x583B010", VA = "0x18583BC10")]
	public BCHJJGNIBBC FEGJKICDEOJ()
	{
		return default(BCHJJGNIBBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x583CD90", Offset = "0x583C190", VA = "0x18583CD90")]
	public void LJCDGLFDDIK(out Matrix4x4 EDPPOHIOEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x583C010", Offset = "0x583B410", VA = "0x18583C010")]
	public void FNECNGGHHBL(out Vector3 LNCPPCOHHGG, out Quaternion DFECNHDKPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x583C9A0", Offset = "0x583BDA0", VA = "0x18583C9A0")]
	public void JHIFLLJCCAI(out RigidTransform KKPJEDKJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x583D510", Offset = "0x583C910", VA = "0x18583D510")]
	public JHHGOKLOOPH OCMCKHGNHEP()
	{
		return default(JHHGOKLOOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x583D440", Offset = "0x583C840", VA = "0x18583D440")]
	public void OCMCKHGNHEP(out JHHGOKLOOPH GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x583B450", Offset = "0x583A850", VA = "0x18583B450")]
	public JHHGOKLOOPH BNIOPGADPMO()
	{
		return default(JHHGOKLOOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x583B380", Offset = "0x583A780", VA = "0x18583B380")]
	public void BNIOPGADPMO(out JHHGOKLOOPH KKPJEDKJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x583CC80", Offset = "0x583C080", VA = "0x18583CC80")]
	public Vector3 KLGLGOFKLKK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x583D7A0", Offset = "0x583CBA0", VA = "0x18583D7A0")]
	public void PEFPLBIKJOF(in Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x583B8A0", Offset = "0x583ACA0", VA = "0x18583B8A0")]
	public Vector3 EBNIMCFMDDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x583B290", Offset = "0x583A690", VA = "0x18583B290")]
	public void BJOOBAJCHIA(in Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x583D560", Offset = "0x583C960", VA = "0x18583D560")]
	public Quaternion OJALBBDGOLE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x583C7C0", Offset = "0x583BBC0", VA = "0x18583C7C0")]
	public void IMDNKOPAAID(in Quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x583B4A0", Offset = "0x583A8A0", VA = "0x18583B4A0")]
	public Quaternion CCCAIKOJMAO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x583CFC0", Offset = "0x583C3C0", VA = "0x18583CFC0")]
	public void MFOMCJMMBPP(in Quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x583BD80", Offset = "0x583B180", VA = "0x18583BD80")]
	public float FJNJBFLENFO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x583D290", Offset = "0x583C690", VA = "0x18583D290")]
	public void NNFCJEOBJJG(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x583B7F0", Offset = "0x583ABF0", VA = "0x18583B7F0")]
	public float EANEEINKPOJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x583C500", Offset = "0x583B900", VA = "0x18583C500")]
	public void GOIKJJIMLKO(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x583C8B0", Offset = "0x583BCB0", VA = "0x18583C8B0")]
	public void IOHCNOFDJGP(in Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x583B6E0", Offset = "0x583AAE0", VA = "0x18583B6E0")]
	public Vector3 EAKMOACDLLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x583C6D0", Offset = "0x583BAD0", VA = "0x18583C6D0")]
	public void IKEICOPHCJK(in Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x583D180", Offset = "0x583C580", VA = "0x18583D180")]
	public Vector3 NCHOCFKCMEJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x583BF20", Offset = "0x583B320", VA = "0x18583BF20")]
	public void FNAHBLFDOOC(in Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x583CB70", Offset = "0x583BF70", VA = "0x18583CB70")]
	public Vector3 JOFIOKOAPDD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x583B5F0", Offset = "0x583A9F0", VA = "0x18583B5F0")]
	public void CIOMNINEODE(in Vector3 KKIAKNLLHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface AOONNPAOEFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	JODLCELHFNO FCDPIDPOEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PPACDBGDBCI, NativeArray<LENINMGJJHF>> HFAEMBOIGMI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<PPACDBGDBCI> NNKPECFFFIK;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CJNBAFDACBF DODEMOFAKND(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LENINMGJJHF KKPCNJHFKAF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FIMKNKKCEGK(CMFFIMLEPBE AIOICCOKGOP, CJHAGIKCJCL FCGEAJNLBED);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EFBPNECENII MIPMPNEGLMG(KDLENLDMBAK LCODCOPGHJA, [Optional] object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BDGDJOEOFJD(KDLENLDMBAK LCODCOPGHJA, out CJHAGIKCJCL FCGEAJNLBED);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AMHGHJGADGN(KDLENLDMBAK LCODCOPGHJA, out Transform FELEGEFPADK);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CGEGNOGJDCD(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CLGLMEJAHPF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IDHHCLLPEJO(LocalId LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DDGMIIBELPN(LocalId LCODCOPGHJA, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KDLENLDMBAK OIPIJNOEBKM(CMFFIMLEPBE AIOICCOKGOP);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NAGMLCICLNG(CMFFIMLEPBE AIOICCOKGOP, out KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CMFFIMLEPBE NLOPILAOEJF(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	PPACDBGDBCI OIPIJNOEBKM(NativeArray<CMFFIMLEPBE> AIOICCOKGOP, Allocator GMMIODGPFPJ);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	PPACDBGDBCI DHDMDNFIBGC(NativeArray<CMFFIMLEPBE> AIOICCOKGOP, NativeArray<EFFOMHNHCBO> JONOBDJBMLJ, Allocator GMMIODGPFPJ);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	EFBPNECENII CGDIEAADOPD(LENINMGJJHF MNOKFAHHNHH, bool LKMELNGEJFK);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	EFBPNECENII CGDIEAADOPD(LENINMGJJHF MNOKFAHHNHH);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	EFBPNECENII KNDJPPIAOGM(LENINMGJJHF MNOKFAHHNHH);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EFBPNECENII OBMHIMMNIBM(LENINMGJJHF MNOKFAHHNHH);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EFBPNECENII DHDMDNFIBGC(CMFFIMLEPBE AIOICCOKGOP, LENINMGJJHF MNOKFAHHNHH);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IPHCFGGLOCO GJEGPKDJIKJ();

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BPHMAGJHJEM BIMCGJHILGA();

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "28")]
	APMGOACLPEO BNHELOPAIOO(EHKHPDFBEJD PHLACDEENBP);

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FMEHBMDFEDJ(PPACDBGDBCI KOJOICDCDNK);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FBDDBFFKADI(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EHKGCEAOOAN(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FMEHBMDFEDJ(KDLENLDMBAK LCODCOPGHJA);

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "33")]
	PPACDBGDBCI MOCOOKLAOJK(PPACDBGDBCI GEKPNOHHCDG, Allocator GMMIODGPFPJ);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HABKCECLKEN(KDLENLDMBAK LCODCOPGHJA);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class CIBBEBHMMIB
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5837670", Offset = "0x5836A70", VA = "0x185837670")]
	public static void CLGLMEJAHPF(this AOONNPAOEFB FHJACJEANIP, CJHAGIKCJCL FCGEAJNLBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5837630", Offset = "0x5836A30", VA = "0x185837630")]
	public static EFBPNECENII ANBJDPECJGN(this AOONNPAOEFB FHJACJEANIP, LocalId LCODCOPGHJA)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5838190", Offset = "0x5837590", VA = "0x185838190")]
	public static KDLENLDMBAK OIPIJNOEBKM(this AOONNPAOEFB FHJACJEANIP, LocalId LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x58380A0", Offset = "0x58374A0", VA = "0x1858380A0")]
	public static CMFFIMLEPBE NLOPILAOEJF(this AOONNPAOEFB FHJACJEANIP, LocalId LCODCOPGHJA)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5837C00", Offset = "0x5837000", VA = "0x185837C00")]
	public static bool HABKCECLKEN(this AOONNPAOEFB FHJACJEANIP, CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9340", Offset = "0x1CE8740", VA = "0x181CE9340")]
	public static T PHBEADLJDEK<T>(this AOONNPAOEFB FHJACJEANIP, LocalId LCODCOPGHJA) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5837770", Offset = "0x5836B70", VA = "0x185837770")]
	public static IPHCFGGLOCO CLJEJFJPOGB(this AOONNPAOEFB FHJACJEANIP, RigidTransform GKMKJBANBPJ, [Optional] object GAOLOMEJCOK)
	{
		return default(IPHCFGGLOCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x58381C0", Offset = "0x58375C0", VA = "0x1858381C0")]
	public static APMGOACLPEO OOCCBBLMFBM(this AOONNPAOEFB FHJACJEANIP, EHKHPDFBEJD HFPOIIFKOCE, RigidTransform GKMKJBANBPJ, [Optional] object GAOLOMEJCOK)
	{
		return default(APMGOACLPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5837D60", Offset = "0x5837160", VA = "0x185837D60")]
	public static BPHMAGJHJEM JOCDIICEBEC(this AOONNPAOEFB FHJACJEANIP, RigidTransform GKMKJBANBPJ, [Optional] object GAOLOMEJCOK)
	{
		return default(BPHMAGJHJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x58378B0", Offset = "0x5836CB0", VA = "0x1858378B0")]
	private static void EPACEJICLAF(EFBPNECENII BOJEJLGNBBG, RigidTransform GKMKJBANBPJ, [Optional] object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5837EA0", Offset = "0x58372A0", VA = "0x185837EA0")]
	internal static LCLHBJLEOJH NEPBBOJLOBC(this AOONNPAOEFB FHJACJEANIP, KKHDEPBDMGH EGBCBLDCFOA, [Optional] object GAOLOMEJCOK)
	{
		return default(LCLHBJLEOJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface HAGBJEJOLJL
{
	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CDKLBNCPIGE(GameObject GACFHLOJJGF);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KEMOPGCNCNN(GameObject GACFHLOJJGF);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object DCFNIKJMPAL(KDLENLDMBAK LCODCOPGHJA, GameObject GACFHLOJJGF, Action<KDLENLDMBAK, int> GBCKPIBLKJM);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COIHNDCOIFG(GameObject GACFHLOJJGF, object HEHNBNFPLMB);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal static class LHHEAOAADGJ
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5840E60", Offset = "0x5840260", VA = "0x185840E60")]
	public static GIFAPDPEGID PMIDMGFEIFO(this KDLENLDMBAK MLGAFKBKMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5840CF0", Offset = "0x58400F0", VA = "0x185840CF0")]
	public static PFJMBDHJHAN AIOAKOJFGNH(this KDLENLDMBAK MLGAFKBKMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5840D90", Offset = "0x5840190", VA = "0x185840D90")]
	public static EntityManager FCLKPLIBOOP(this KDLENLDMBAK MLGAFKBKMCE)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2428570", Offset = "0x2427970", VA = "0x182428570")]
	public static T MBLNHLDPNHC<T>(this KDLENLDMBAK MLGAFKBKMCE) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x24284F0", Offset = "0x24278F0", VA = "0x1824284F0")]
	public static bool FPDMFOJFMCP<T>(this KDLENLDMBAK MLGAFKBKMCE) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
internal interface GHEMABPOFFC
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<OJGPABLJLLP> MBBDIEJLJIP;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public interface BKIGCJIBBEC
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	bool CHHFBBKAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	KDLENLDMBAK JGEMJAJAFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	EFBPNECENII JADINPGHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event GEOHHBJAGFH AGEJNEJCHBN;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KDLENLDMBAK JDMHPFIMIIA(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NECHJOFNONE(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD, out KDLENLDMBAK DCAFPIJMBKH);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDLPFGIDGID();

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GEKJMNCIDDC();

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CHBFJLENKOF(KDLENLDMBAK GDNOLIODDHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public delegate void GEOHHBJAGFH(EFBPNECENII KKAPFOFGHBN, EFBPNECENII EHPDPFMPFKE);
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class JEKOKKGLBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x583ED40", Offset = "0x583E140", VA = "0x18583ED40")]
	public static bool NKFFEADPFNK(this BKIGCJIBBEC KPHJKKGHHEA, KDLENLDMBAK GDNOLIODDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x583EC40", Offset = "0x583E040", VA = "0x18583EC40")]
	public static bool FHNIKGGIGNP(this BKIGCJIBBEC KPHJKKGHHEA, KDLENLDMBAK GDNOLIODDHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[DefaultMember("Item")]
public interface KHCHBOKCLCH : IEnumerable<LJHGDPGPANM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000143")]
	int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	LJHGDPGPANM OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJHGDPGPANM IMOMPCNDOJA(NNHEPJDBKBI KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GLFLLKHPAHK ELFFHKHOAAN(NNHEPJDBKBI KKIJPENOLBP);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class NOFMIAMNEOA
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2BD98F0", Offset = "0x2BD8CF0", VA = "0x182BD98F0")]
	public static AOJLADIGKFN<T> IMOMPCNDOJA<T>(this KHCHBOKCLCH NFDNHCCMBMJ, NNHEPJDBKBI DKPHPKDPBCM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9A10", Offset = "0x2BD8E10", VA = "0x182BD9A10")]
	public static AOJLADIGKFN<T> IMOMPCNDOJA<T>(this KHCHBOKCLCH NFDNHCCMBMJ, AFHAKKMHKHI<T> DKPHPKDPBCM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9800", Offset = "0x2BD8C00", VA = "0x182BD9800")]
	public static GLFLLKHPAHK ELFFHKHOAAN<T>(this KHCHBOKCLCH NFDNHCCMBMJ, AFHAKKMHKHI<T> DKPHPKDPBCM) where T : struct
	{
		return default(GLFLLKHPAHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface PGEMHDJNMBJ : CINMFIJPFIM
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJIEIAAKCCA JEDEDABKHGE(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDGINFALDOO(NativeArray<AJIEIAAKCCA> KFFIGCKCIIO, NativeArray<FIKOEBGBDLM> LJFLOLJGCND);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFGGHHMDFIL(AJIEIAAKCCA PPCGBBAKOHO);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPDODEHBCLM(AJIEIAAKCCA PPCGBBAKOHO, out Collider JGLBLFOJFCH);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct FIKOEBGBDLM : ISystemStateComponentData, IComponentData, IEquatable<FIKOEBGBDLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float3 BDIHNGLLDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float3 EPENCEAKPPB;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x583A4B0", Offset = "0x58398B0", VA = "0x18583A4B0", Slot = "4")]
	public bool Equals(FIKOEBGBDLM LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct PIFKOMHKCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Guid EBABBHGKMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public string EODCFKJDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 OMFIFBMFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Quaternion PFHPGOOLCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3 DBJGDGDHOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int JBBMBDBLCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Dictionary<string, object> ANKHOKAAJLH;

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x58448F0", Offset = "0x5843CF0", VA = "0x1858448F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5844760", Offset = "0x5843B60", VA = "0x185844760")]
	private static string NOFKGMJKGJJ(Dictionary<string, object> HNFFJIBONPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum DJLGGHMIKCI
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum OBAEFFAKPIM
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class IPMKJOECLAH
{
	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7840", Offset = "0x4BE6C40", VA = "0x184BE7840")]
	public static bool MDLHOOBEIMH(this OBAEFFAKPIM JLNNFEOBAMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface LLEIAOFCAJL : PDOBJBPMLLM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum LBPKNEPPDAM
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	NotifyEnabledState = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	NotifyInstantiated = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DisposeProtobuf = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	NotifyCompleted = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesMaster = 0xFF,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WorldPhasesClient = 0xF7,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	AdditivePhases = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum EKBLDLBAJFE
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SetEnabledInRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PostInstantiate = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	LoadCompleted = 0xC0,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	All = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface EGPAMILOEKO : PDOBJBPMLLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	NPKIHKJLIJM LHOFHPLHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHDJLENCJMM();

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MILFNNDJCMM();
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface NPKIHKJLIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJCPMKCLCNL(Guid CDNLFOGBLLG, out Guid OPMNDBPHMGG);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface LJMLKHMFDNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	LILHPPGJGND NMPAJDKKPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString AFMFBLIACIM();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface PDOBJBPMLLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	IEnumerable<PIFKOMHKCPK> EAGGBJJMICA
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	JLLNNHEPACB OGOCPGCJELL
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	LocalId CNJBNLEIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	LILHPPGJGND PGKIOADFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	Task MJNPEKKLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GFPNCFCIMGJ(LBPKNEPPDAM GKOGFPHIKMK);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface LCMOEGKNFDM
{
	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NDGBPOMPPGO(int EPAJCDGEEKI);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface FMHENAEHCJH
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	IEnumerable<PKOHIJKDADP> MOBJPGNHINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPNDMBNJMDG(int EPAJCDGEEKI, out PKOHIJKDADP BGHJBFABJHA);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface EAPCDDKOAHP
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	List<(ACBMDIMIIAP nameHash, ILPAELJEFKD stableTypeHash, Type type)> EAEECCJMMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface OKPGNAADCIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACBMDIMIIAP GAHBLMCANFI(int EPAJCDGEEKI);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FMLBEHHFHNP(ACBMDIMIIAP DCDKOALONMG);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface MGGIKJGDIFI
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMHHMMDEGLF(CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK KOAJDKDANHI, ReadOnlySpan<byte> EBBFFECDKCH, ReadOnlySpan<byte> MKKPKAKGCKF);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APOGAKKJDFP(CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK KOAJDKDANHI);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIJDMGPCPAN(CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK KOAJDKDANHI, ReadOnlySpan<byte> MKKPKAKGCKF);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKGEJCODJKP(CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK KOAJDKDANHI, Span<byte> EBBFFECDKCH, Span<byte> MKKPKAKGCKF);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class AALGMNEDPJK
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1D67E60", Offset = "0x1D67260", VA = "0x181D67E60")]
	public static bool PKGEJCODJKP<T>(this MGGIKJGDIFI FCKACOOHOKO, CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK KOAJDKDANHI, out T EBBFFECDKCH, out T MKKPKAKGCKF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1D67D40", Offset = "0x1D67140", VA = "0x181D67D40")]
	public static bool BIJDMGPCPAN<T>(this MGGIKJGDIFI FCKACOOHOKO, CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK KOAJDKDANHI, T MKKPKAKGCKF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum OFILEDLLICG
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface NMANAGPHMFF : HDFALLAHAME<NMANAGPHMFF>
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NALDPHOGDDM(GLFLLKHPAHK MLGAFKBKMCE, out ALDCMKEKMHG BGHJBFABJHA);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class LNFJDOPBMKB
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface CJNHILKEKFP
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	uint JCNOHLGLKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct IFKCDEDMMOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public EBBOOPFABOA CANIEFMHGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public ReadOnlyMemory<byte> KBLLMJIHKAK;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface FHGIEPBNGKE
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBABJJKIAOP(EBBOOPFABOA CANIEFMHGCA, ReadOnlySpan<byte> KBLLMJIHKAK);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate bool MEGKNEHDLON(MGGIKJGDIFI DBOMOFCMPIC, in NBOENLAPDFO KKIAKNLLHIO);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public delegate bool LECKDIOAMNG<T>(MGGIKJGDIFI DBOMOFCMPIC, in T KKIAKNLLHIO);
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface EHFICGMFONF
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIMKNKKCEGK(GLFLLKHPAHK KOAJDKDANHI, Type MAFHOOIMPEH, MEGKNEHDLON HKOCODKCJEO);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHAFFDDLPBM(GLFLLKHPAHK KOAJDKDANHI, out MEGKNEHDLON HKOCODKCJEO);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class EACNJIDEPKE
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class BIBDNOOHMBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LECKDIOAMNG<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public BIBDNOOHMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x24CA7E0", Offset = "0x24C9BE0", VA = "0x1824CA7E0")]
		internal bool OGKLLOFMBNK(MGGIKJGDIFI pendingList, in NBOENLAPDFO value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C050", Offset = "0x1F8B450", VA = "0x181F8C050")]
	public static void FIMKNKKCEGK<T>(this EHFICGMFONF OBOAIKCPODL, GLFLLKHPAHK KOAJDKDANHI, LECKDIOAMNG<T> HKOCODKCJEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5838BE0", Offset = "0x5837FE0", VA = "0x185838BE0")]
	public static bool GBGGNHLHFCN(this EHFICGMFONF OBOAIKCPODL, MGGIKJGDIFI DBOMOFCMPIC, GLFLLKHPAHK KOAJDKDANHI, in NBOENLAPDFO KKIAKNLLHIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct EBBOOPFABOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public uint IMMGGKGMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int OJPJJMLJBCA;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	public EBBOOPFABOA(uint IMMGGKGMOEF, int OJPJJMLJBCA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5838DA0", Offset = "0x58381A0", VA = "0x185838DA0")]
	public static bool MCJHDEKAHDI(in EBBOOPFABOA LLKHFJFGFIB, in EBBOOPFABOA LDJLPHFLLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5838CE0", Offset = "0x58380E0", VA = "0x185838CE0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5838D70", Offset = "0x5838170", VA = "0x185838D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5838DC0", Offset = "0x58381C0", VA = "0x185838DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface CPCDMMFNECK
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBBOOPFABOA AMPNCDLCDAG(ReadOnlySpan<byte> KBLLMJIHKAK);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface ALDCMKEKMHG
{
	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	Type BNMJEFLPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG, Span<byte> GDNOLIODDHJ);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK, ReadOnlySpan<byte> CANIEFMHGCA);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class OBEIIINNFGE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public interface IKINGBNPGOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDGIOAECIDB(EBBOOPFABOA KOFPKIJDAMC, ReadOnlySpan<byte> KBLLMJIHKAK);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class CBCPDCNEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBCPDCNEBEL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
