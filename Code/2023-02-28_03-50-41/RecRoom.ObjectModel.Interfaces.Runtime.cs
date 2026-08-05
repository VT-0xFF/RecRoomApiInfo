using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MMAFHJBAKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKPKBPKPKOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EKMKCCPFDIG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B440F0", Offset = "0x5B42AF0", VA = "0x185B440F0")]
	public static void IKPKBPKPKOJ(this GameObject ICDBBFEMLLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AENEDCLILGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> JDLCDBDGLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFKOJFHJBPL BLIALODHHOH(DFKOJFHJBPL BPPOAHFNBEH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Entity BLIALODHHOH(Entity BPPOAHFNBEH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface LFHKDFGBJPJ : HFHAMBGAEFF, CGCFBBFKDEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IGIBMKFLGBD OHOAOEJOHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LFIFNADKAEF KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IHIPHIAICBG FMHHHIIODEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PEIGBAPLOKK JDNLHKJJKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface CGCFBBFKDEL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FCANJHPHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AFHCJEOAGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public float3 OAALNDIAAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public quaternion HOOCPOKGFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float3 HKGHFAPJIOG;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface LFIFNADKAEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GFGMJCNFBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LLHDPIAHEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int IHJGACOMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MDONBCFIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EBEJFCLDEIC IFFAELLCKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LFGMJEOHHGI KJANKCDKECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GNBBKGFMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KCDLEKLCOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string MLMIBPNLEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CHCGLLFNBKK(GameObject KEHOIMKGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JMJDNPHAMEB(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AKLFKNOOHJC GHFHNGHECAI(Guid AACMDIJLDMO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HBIBAGENGHJ ICNJJFCDMDM(DMEOMGPBNBN NONPDGFJDAK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HBIBAGENGHJ ICNJJFCDMDM(string PDKJCGANJMP, AKLFKNOOHJC AOCEENCOLMM, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC, Vector3 HKGHFAPJIOG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PDJHKHCCOBL(bool JECBMIHPMOH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MAAOMMKEHJA();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MEFDPMGEFOM(GameObject KEHOIMKGHCH, out AKLFKNOOHJC AOCEENCOLMM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GCAHNAHBNLG(GameObject KEHOIMKGHCH, out int FMBFLNGODMI, out AOIKBHJMDBO GDAJCNKPBDC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HLLKCOHOFDM(GameObject KEHOIMKGHCH, bool BEJBHLCKAAH, bool MDAAFJCELDJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FAJIGAFNHFG(GameObject KEHOIMKGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task BIKGCMLAKGH();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task INMPIHAMOCF();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GHBEAPOKEBC(object JNODNCHMALF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HGBHGAOPNGG(object JNODNCHMALF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KPJPHGKGNGP(object EONCDECCEBA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CBBPMFJKHEM(object PDPOLFACNJC, [Optional] object KHJJOLAGOEH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JLOAKBGNCCI(Transform CLHKPCIOCGF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KPMODEOBENF(Transform CLHKPCIOCGF, ECAGGLGKIMN KIJDDEBDFKL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OBGNAOKFGKK(Transform CLHKPCIOCGF, BDFOGDLNFAP GIKLJDACLBE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MEGCFBPFAMJ(GameObject KEHOIMKGHCH, GOEIALOHLHM EOGIJAEEHPI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OCCFDHJKJGK(GameObject KEHOIMKGHCH, int PACLGCIADGA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool EKFKGEIJMGE(out Vector3 OAALNDIAAOB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PEJNLCALJGK();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ALMKIGHFILO(GameObject KJFNLHIDIKE, bool MHJJEDNLELL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	AOIKBHJMDBO AGKAJBKJIBL(GameObject ICDBBFEMLLL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "35")]
	int GCOIGBOPDKD(GameObject KEHOIMKGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "36")]
	object LLABOLCCMEB(DFKOJFHJBPL PMMCMCPNCLD, GameObject KEHOIMKGHCH, Action<DFKOJFHJBPL, int> JOIALDGLEAK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FEKBDKKDMAH(GameObject KEHOIMKGHCH, object CEPFNNLNFOB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BOPIKDDNPDP(GameObject KEHOIMKGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void ODNLJFIDJAE(EIIMNNHCANF BPPOAHFNBEH);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BJIPFMGLHBE(GameObject KEHOIMKGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void OFLIGKPKGDA(string EJEIJOMMNGK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int HCOGJDHFLON(GameObject ICDBBFEMLLL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void MFJCLDFEMBM(NativeArray<int> NAGFMBOBMJG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NHIAEHBFNDF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B5D0", Offset = "0x5B49FD0", VA = "0x185B4B5D0")]
	public static HBIBAGENGHJ ICNJJFCDMDM(this LFIFNADKAEF EDFOBNPNANH, AKLFKNOOHJC PMMCMCPNCLD, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC, Vector3 HKGHFAPJIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface PEIGBAPLOKK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GIEPDDFBBIL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCEINNNJCGF();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCGCLIKNJON();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDCMICPECIG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKDGDIOHBGB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDDCFGJOPOD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PBEDEGPKDBA(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGBFGGFLFPL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNENNPPILDK();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JHKPODDCHJH();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GENFMKINDFO(bool KODHDLHLAIN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface IHIPHIAICBG
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ByteString JHPOCMCIPNJ(out IDisposable DBHMONFNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJGJBLGJHIK(ByteString NIPBPKPBPPP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface DPKHLNGAONH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NKLKBAHCHOA OHOAOEJOHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LFIFNADKAEF KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DEAGKEFEBKN CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LAIKDFLJMKI NHHBDODJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JOHEJCALJIO AJCEPDOMKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	FCADPKIAEAJ FMHHHIIODEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	JFFIFAIOBGL ABOICNGPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HIOHMPHFJEM BALFGABDJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DGINFINNHOA CLMKLDLCBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EBIDIPICLGG NBHKGKINMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MNMIJEOGALA GLLNJCEHHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DIOGGBHHPCP MCMEIKFCIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HOHEDKHFMCC EKALPMIIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OFJGIHJMMMN FHBDODLFDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	CPMCACBEBDN AHFMIIFADFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GHMLCJKOGGN HNAEGLAMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BJBEMKAEBCB<TKey> : IDisposable where TKey : struct, IEquatable<TKey>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct LFKDMKLLGFH
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeHashMap<TKey, LFKDMKLLGFH> INLJGFGAJKF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x318CC80", Offset = "0x318B680", VA = "0x18318CC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x318CD80", Offset = "0x318B780", VA = "0x18318CD80")]
	public BJBEMKAEBCB(int ADCMDGEMNDH, Allocator GGPAKDMJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x318CCC0", Offset = "0x318B6C0", VA = "0x18318CCC0")]
	public bool MMAIIPOKGMB(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x318CBF0", Offset = "0x318B5F0", VA = "0x18318CBF0")]
	public bool CKGLBKMGGPC(TKey AJPNMLHDHNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x318CC40", Offset = "0x318B640", VA = "0x18318CC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x318CD10", Offset = "0x318B710", VA = "0x18318CD10")]
	public NativeArray<TKey> NPMBFCHHPDO(Allocator GGPAKDMJHLJ)
	{
		return default(NativeArray<TKey>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public struct EIIMNNHCANF : IReadOnlyList<DFKOJFHJBPL>, IEnumerable<DFKOJFHJBPL>, IEnumerable, IReadOnlyCollection<DFKOJFHJBPL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OAONHDOPCPC : IEnumerator<DFKOJFHJBPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<Entity>.Enumerator LFLDNGCNAAO;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public DFKOJFHJBPL PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5B4BE30", Offset = "0x5B4A830", VA = "0x185B4BE30", Slot = "4")]
			get
			{
				return default(DFKOJFHJBPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5B4BD60", Offset = "0x5B4A760", VA = "0x185B4BD60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4810", Offset = "0x1FE3210", VA = "0x181FE4810")]
		public OAONHDOPCPC(HGFGJIKNIPL CPFOJDHADNE, NativeArray<Entity>.Enumerator LFLDNGCNAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BCA0", Offset = "0x5B4A6A0", VA = "0x185B4BCA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BCE0", Offset = "0x5B4A6E0", VA = "0x185B4BCE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BD20", Offset = "0x5B4A720", VA = "0x185B4BD20", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeArray<Entity> CGCCIONMJJA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public DFKOJFHJBPL NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5B43F70", Offset = "0x5B42970", VA = "0x185B43F70", Slot = "4")]
		get
		{
			return default(DFKOJFHJBPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5B43B30", Offset = "0x5B42530", VA = "0x185B43B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private int BCJCOOCJNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5B43B80", Offset = "0x5B42580", VA = "0x185B43B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public NativeArray<Entity> JHLGFCFCAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FE52B0", Offset = "0x1FE3CB0", VA = "0x181FE52B0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5B43EE0", Offset = "0x5B428E0", VA = "0x185B43EE0")]
	public EIIMNNHCANF(int ADCMDGEMNDH, HGFGJIKNIPL CPFOJDHADNE, Allocator GGPAKDMJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FE41D0", Offset = "0x1FE2BD0", VA = "0x181FE41D0")]
	public EIIMNNHCANF(HGFGJIKNIPL CPFOJDHADNE, NativeArray<Entity> CGCCIONMJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B43E30", Offset = "0x5B42830", VA = "0x185B43E30")]
	public EIIMNNHCANF(EIIMNNHCANF LALGBCPBBJH, Allocator GGPAKDMJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5B43B40", Offset = "0x5B42540", VA = "0x185B43B40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5B43BC0", Offset = "0x5B425C0", VA = "0x185B43BC0")]
	public OAONHDOPCPC OGILHMGHFKK()
	{
		return default(OAONHDOPCPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5B43C50", Offset = "0x5B42650", VA = "0x185B43C50", Slot = "6")]
	private IEnumerator<DFKOJFHJBPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5B43D40", Offset = "0x5B42740", VA = "0x185B43D40", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DebuggerTypeProxy(typeof(KNAPLJPFJHB))]
public struct DFKOJFHJBPL : IComparable<DFKOJFHJBPL>, IEquatable<DFKOJFHJBPL>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DFKOJFHJBPL EBOAMDEGHNP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Entity BHDJCIPFNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x717B00", Offset = "0x716500", VA = "0x180717B00")]
		[CompilerGenerated]
		readonly get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9ECF90", Offset = "0x9EB990", VA = "0x1809ECF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5B42950", Offset = "0x5B41350", VA = "0x185B42950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EKHKNECPEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5B42870", Offset = "0x5B41270", VA = "0x185B42870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FDOEJMJEMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5B427A0", Offset = "0x5B411A0", VA = "0x185B427A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5B42A60", Offset = "0x5B41460", VA = "0x185B42A60")]
	public DFKOJFHJBPL(HGFGJIKNIPL FKCONKIFMHL, Entity GOANOLJBHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
	public POPHLPHEEBM OEABAFIJKCP()
	{
		return default(POPHLPHEEBM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x717B00", Offset = "0x716500", VA = "0x180717B00")]
	public static Entity EGMKMIPNLBF(DFKOJFHJBPL DKICGOFCIAM)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5B429F0", Offset = "0x5B413F0", VA = "0x185B429F0")]
	public static bool NENBKMMGKMN(DFKOJFHJBPL PKEMCIANHMO, DFKOJFHJBPL DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5B429A0", Offset = "0x5B413A0", VA = "0x185B429A0")]
	public static bool HCCIHOFGPHE(DFKOJFHJBPL PKEMCIANHMO, DFKOJFHJBPL DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5B42A40", Offset = "0x5B41440", VA = "0x185B42A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5B428A0", Offset = "0x5B412A0", VA = "0x185B428A0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EE0", Offset = "0x7E08E0", VA = "0x1807E1EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5B42740", Offset = "0x5B41140", VA = "0x185B42740", Slot = "4")]
	public int CompareTo(DFKOJFHJBPL DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "5")]
	public bool Equals(DFKOJFHJBPL DFHJPOKNFFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ENHPIOHFHCM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5B44240", Offset = "0x5B42C40", VA = "0x185B44240")]
	public static AKLFKNOOHJC OOMNOMGKKMO(this DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(AKLFKNOOHJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class KNAPLJPFJHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct KJBMIFDIHHB
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const uint ABKPCKODMIE = 2147483648u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly LJKDLPPCHKH AGNHLFMCFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal readonly LJKDLPPCHKH PGDLDMBJJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly uint HJOABHDPJEH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A780", Offset = "0x5B49180", VA = "0x185B4A780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public uint ENJHKDMACCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x30452B0", Offset = "0x3043CB0", VA = "0x1830452B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AA70", Offset = "0x5B49470", VA = "0x185B4AA70")]
	public KJBMIFDIHHB(LJKDLPPCHKH AGNHLFMCFOJ, LJKDLPPCHKH PGDLDMBJJEP, uint HJOABHDPJEH, bool GBGFENMFOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A790", Offset = "0x5B49190", VA = "0x185B4A790")]
	public bool LODLFEJENGK(KJBMIFDIHHB DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A7D0", Offset = "0x5B491D0", VA = "0x185B4A7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[LOEOGANCBGC(EDPDLGMLNHJ.History)]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal readonly KJBMIFDIHHB CKAPOBIDCEI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MPANJOCJMHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5B4A780", Offset = "0x5B49180", VA = "0x185B4A780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xE22310", Offset = "0xE20D10", VA = "0x180E22310")]
		internal UndoAction(KJBMIFDIHHB CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FF40", Offset = "0x5B4E940", VA = "0x185B4FF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[LOEOGANCBGC(EDPDLGMLNHJ.History)]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly KJBMIFDIHHB CKAPOBIDCEI;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool MPANJOCJMHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5B4A780", Offset = "0x5B49180", VA = "0x185B4A780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xE22310", Offset = "0xE20D10", VA = "0x180E22310")]
		internal RedoAction(KJBMIFDIHHB CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FF40", Offset = "0x5B4E940", VA = "0x185B4FF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LOMEPAEHMFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	internal readonly uint HJOABHDPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal readonly bool NGFLJPBOIEG;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B0B0", Offset = "0x5B49AB0", VA = "0x185B4B0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LJKDLPPCHKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal int JFKBHBKKACD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90")]
	public LJKDLPPCHKH(int JFKBHBKKACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5B4ABA0", Offset = "0x5B495A0", VA = "0x185B4ABA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ICBHOPCBAFI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HBIBAGENGHJ : NGDEDBHGIBI
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ICBHOPCBAFI MFLHBGHJMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CKHFNGINNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GameObject KEHOIMKGHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HBIBAGENGHJ> MAAOMMKEHJA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(DEAGKEFEBKN HDJFKDANOCN, DFKOJFHJBPL MLCKDIODPBO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool EHDMKDFKFEP);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NDBDNCJJAGH
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B4F0", Offset = "0x5B49EF0", VA = "0x185B4B4F0")]
	public static bool HNGDLAAAHJE(this HBIBAGENGHJ MIDDDIBGPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B4A0", Offset = "0x5B49EA0", VA = "0x185B4B4A0")]
	public static bool CKNKBOMJFGB(this HBIBAGENGHJ MIDDDIBGPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B450", Offset = "0x5B49E50", VA = "0x185B4B450")]
	public static bool ALDFEDMHHJD(this HBIBAGENGHJ MIDDDIBGPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B540", Offset = "0x5B49F40", VA = "0x185B4B540")]
	public static bool JDCINNHHEGM(this HBIBAGENGHJ MIDDDIBGPID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NGDEDBHGIBI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool HNCHBAEIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface ABCMNOFLGBA : global::DOCNCNKJBDA<AKLFKNOOHJC>, HBMFMFPPKEB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DPGNOJNMADF<T> : global::DABFAGPIBGD<AKLFKNOOHJC, T>, global::DOCNCNKJBDA<AKLFKNOOHJC>, HBMFMFPPKEB, IDisposable, ABCMNOFLGBA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MNALNPMIJPN
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x26133A0", Offset = "0x2611DA0", VA = "0x1826133A0")]
	public static bool BHPOPCGLBJN<T>(this global::DOCNCNKJBDA<AKLFKNOOHJC> OPPPBNFKNOC, AKLFKNOOHJC AOCEENCOLMM, out T MNIAGKNOHEJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x23E89A0", Offset = "0x23E73A0", VA = "0x1823E89A0")]
	public static bool NLANNFAIKGA<T>(this global::DOCNCNKJBDA<AKLFKNOOHJC> OPPPBNFKNOC, AKLFKNOOHJC AOCEENCOLMM, in T ONFBDMEKEAL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KNCBBMLNKLK : global::DOCNCNKJBDA<DFKOJFHJBPL>, HBMFMFPPKEB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NENALMGBADL<T> : global::DABFAGPIBGD<DFKOJFHJBPL, T>, global::DOCNCNKJBDA<DFKOJFHJBPL>, HBMFMFPPKEB, IDisposable, KNCBBMLNKLK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class BKFDLPHEEJG
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2678AC0", Offset = "0x26774C0", VA = "0x182678AC0")]
	public static T AGGAFJIIBKL<T>(this global::DOCNCNKJBDA<DFKOJFHJBPL> OPPPBNFKNOC, DFKOJFHJBPL PMMCMCPNCLD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2678BC0", Offset = "0x26775C0", VA = "0x182678BC0")]
	public static bool NLANNFAIKGA<T>(this global::DOCNCNKJBDA<DFKOJFHJBPL> OPPPBNFKNOC, DFKOJFHJBPL PMMCMCPNCLD, in T ONFBDMEKEAL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JBNNELNIDOD : IComparable<JBNNELNIDOD>, IEquatable<JBNNELNIDOD>
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JBNNELNIDOD EBOAMDEGHNP;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly JBNNELNIDOD LNCOMHGPOAE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly JBNNELNIDOD FAKDAIKDHFD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly JBNNELNIDOD FOKLHKDGDLA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly JBNNELNIDOD DCGEALCEIMA;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly JBNNELNIDOD IHJDGBAFNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int FOHLPAKJEGJ;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PONPLMHMEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5B48EC0", Offset = "0x5B478C0", VA = "0x185B48EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90")]
	public JBNNELNIDOD(int GFDMFLGCBKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x13CB770", Offset = "0x13CA170", VA = "0x1813CB770")]
	public static bool NENBKMMGKMN(JBNNELNIDOD PKEMCIANHMO, JBNNELNIDOD DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B48E50", Offset = "0x5B47850", VA = "0x185B48E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B48DD0", Offset = "0x5B477D0", VA = "0x185B48DD0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x868560", Offset = "0x866F60", VA = "0x180868560", Slot = "5")]
	public bool Equals(JBNNELNIDOD DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E73B60", Offset = "0x1E72560", VA = "0x181E73B60", Slot = "4")]
	public int CompareTo(JBNNELNIDOD DFHJPOKNFFB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x86A120", Offset = "0x868B20", VA = "0x18086A120")]
	public static JBNNELNIDOD EGMKMIPNLBF(int GFDMFLGCBKB)
	{
		return default(JBNNELNIDOD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x86A120", Offset = "0x868B20", VA = "0x18086A120")]
	public static int EGMKMIPNLBF(JBNNELNIDOD ILFNNAAOJHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B48ED0", Offset = "0x5B478D0", VA = "0x185B48ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct POPHLPHEEBM : IEquatable<POPHLPHEEBM>, NGDEDBHGIBI
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly POPHLPHEEBM OAGGFOALBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900", Slot = "6")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FGJDKLLMCEC ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(FGJDKLLMCEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DMENCOIAJNL NHHBDODJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(DMENCOIAJNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GameObject KEHOIMKGHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FC10", Offset = "0x5B4E610", VA = "0x185B4FC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AKLFKNOOHJC PBPFJNKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F530", Offset = "0x5B4DF30", VA = "0x185B4F530")]
		get
		{
			return default(AKLFKNOOHJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JBPFPNIOEPH KFFCCLHBOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FA00", Offset = "0x5B4E400", VA = "0x185B4FA00")]
		get
		{
			return default(JBPFPNIOEPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public AOIKBHJMDBO LPOHJDOAOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FB40", Offset = "0x5B4E540", VA = "0x185B4FB40")]
		get
		{
			return default(AOIKBHJMDBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool JPKEEFGMDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FD50", Offset = "0x5B4E750", VA = "0x185B4FD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ANOOJBOFPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F900", Offset = "0x5B4E300", VA = "0x185B4F900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool GGGEGIEHHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F600", Offset = "0x5B4E000", VA = "0x185B4F600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool LOLEKOEMHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F4B0", Offset = "0x5B4DEB0", VA = "0x185B4F4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool POEDICOHFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FD10", Offset = "0x5B4E710", VA = "0x185B4FD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GDGLEAINFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FD30", Offset = "0x5B4E730", VA = "0x185B4FD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IGIACKGGKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F920", Offset = "0x5B4E320", VA = "0x185B4F920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PHEHEGGNGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F800", Offset = "0x5B4E200", VA = "0x185B4F800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public HLEEIHCAIFO NKLKAKMMDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(HLEEIHCAIFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MDCBJLBAIKP ILOAGMBKJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(MDCBJLBAIKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EGECLHEMNFM GLLNJCEHHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(EGECLHEMNFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public OIHFEALDBPN IFDJIHIEHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(OIHFEALDBPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public KHMCGHBHAJG CLMKLDLCBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(KHMCGHBHAJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public PEHPMIHEEMG DGNBINJBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(PEHPMIHEEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public OPGCAADJABC EFCDHLMMECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(OPGCAADJABC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool HNGDLAAAHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F820", Offset = "0x5B4E220", VA = "0x185B4F820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool AGJNOOLKKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public POPHLPHEEBM(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B43980", Offset = "0x5B42380", VA = "0x185B43980")]
	public static bool EGMKMIPNLBF(POPHLPHEEBM MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
	public static DFKOJFHJBPL EGMKMIPNLBF(POPHLPHEEBM MNIAGKNOHEJ)
	{
		return default(DFKOJFHJBPL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470")]
	public static bool NENBKMMGKMN(POPHLPHEEBM PKEMCIANHMO, POPHLPHEEBM DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B429A0", Offset = "0x5B413A0", VA = "0x185B429A0")]
	public static bool HCCIHOFGPHE(POPHLPHEEBM PKEMCIANHMO, POPHLPHEEBM DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F690", Offset = "0x5B4E090", VA = "0x185B4F690", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(POPHLPHEEBM DFHJPOKNFFB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
	public static POPHLPHEEBM EGMKMIPNLBF(DFKOJFHJBPL EFHLICFAAGO)
	{
		return default(POPHLPHEEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F740", Offset = "0x5B4E140", VA = "0x185B4F740")]
	public KAEJCOGFAOC GBMHDLJFACB()
	{
		return default(KAEJCOGFAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B4FAD0", Offset = "0x5B4E4D0", VA = "0x185B4FAD0")]
	public PMKCLINLEDB MHOIBMAPKID()
	{
		return default(PMKCLINLEDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F4D0", Offset = "0x5B4DED0", VA = "0x185B4F4D0")]
	public BOLPDANFPGC DABCELCPCIE()
	{
		return default(BOLPDANFPGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F7A0", Offset = "0x5B4E1A0", VA = "0x185B4F7A0")]
	public HLEHCPLKODD GEGBEMFOONO()
	{
		return default(HLEHCPLKODD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F970", Offset = "0x5B4E370", VA = "0x185B4F970")]
	public NNINMABELDO KCINOLKACNG()
	{
		return default(NNINMABELDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5B4FD70", Offset = "0x5B4E770", VA = "0x185B4FD70")]
	public void PIKENIAFHJF([Optional] object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F440", Offset = "0x5B4DE40", VA = "0x185B4F440")]
	public bool CDAPIFCKPGM(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F620", Offset = "0x5B4E020", VA = "0x185B4F620")]
	public bool ENAJODIBMIM(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B4FE50", Offset = "0x5B4E850", VA = "0x185B4FE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct OPGCAADJABC : IEquatable<OPGCAADJABC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D810", Offset = "0x5B4C210", VA = "0x185B4D810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private OFJGIHJMMMN LDCGGKNJBBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D940", Offset = "0x5B4C340", VA = "0x185B4D940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FMOPPCGJAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5B4DB90", Offset = "0x5B4C590", VA = "0x185B4DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Guid MFJCMPGEHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D9C0", Offset = "0x5B4C3C0", VA = "0x185B4D9C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool ODFNLHBOEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D860", Offset = "0x5B4C260", VA = "0x185B4D860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Guid NKNFDGBDDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B4DC70", Offset = "0x5B4C670", VA = "0x185B4DC70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public OPGCAADJABC(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D580", Offset = "0x5B4BF80", VA = "0x185B4D580", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(OPGCAADJABC DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D490", Offset = "0x5B4BE90", VA = "0x185B4D490")]
	public bool DGHNIPAPIAI(out Guid LDLPOFLCBNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D630", Offset = "0x5B4C030", VA = "0x185B4D630")]
	public void FDKCEKDJMBJ(Guid NJHLDPLGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D720", Offset = "0x5B4C120", VA = "0x185B4D720")]
	public bool FHIDGNNLHIP(out Guid OIGKBPKEMEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D3A0", Offset = "0x5B4BDA0", VA = "0x185B4D3A0")]
	public void CAKOKKBAGCP(Guid NJHLDPLGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D2C0", Offset = "0x5B4BCC0", VA = "0x185B4D2C0")]
	public bool BIKHPIIDDEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DAB0", Offset = "0x5B4C4B0", VA = "0x185B4DAB0")]
	public void KPFMHMGEEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NNINMABELDO : IEquatable<NNINMABELDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BAB0", Offset = "0x5B4A4B0", VA = "0x185B4BAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private CPMCACBEBDN BODCIAKDEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B880", Offset = "0x5B4A280", VA = "0x185B4B880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float3 KIENHHCCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BB00", Offset = "0x5B4A500", VA = "0x185B4BB00")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public quaternion GJJCDNDBOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B790", Offset = "0x5B4A190", VA = "0x185B4B790")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public POPHLPHEEBM PLADGPCJDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B9B0", Offset = "0x5B4A3B0", VA = "0x185B4B9B0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public NNINMABELDO(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
	public static DFKOJFHJBPL EGMKMIPNLBF(NNINMABELDO MNIAGKNOHEJ)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B900", Offset = "0x5B4A300", VA = "0x185B4B900", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(NNINMABELDO DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct KAEJCOGFAOC : IEquatable<KAEJCOGFAOC>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KAEJCOGFAOC OAGGFOALBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FGJDKLLMCEC ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(FGJDKLLMCEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DMENCOIAJNL NHHBDODJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(DMENCOIAJNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B495A0", Offset = "0x5B47FA0", VA = "0x185B495A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private LAIKDFLJMKI GLIJFKPEFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5B49520", Offset = "0x5B47F20", VA = "0x185B49520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public EIIMNNHCANF JLBKANNJBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5B495F0", Offset = "0x5B47FF0", VA = "0x185B495F0")]
		get
		{
			return default(EIIMNNHCANF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<POPHLPHEEBM> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5B49300", Offset = "0x5B47D00", VA = "0x185B49300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<POPHLPHEEBM> MPBGGELDKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5B496F0", Offset = "0x5B480F0", VA = "0x185B496F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int MPNBEBKBMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5B49830", Offset = "0x5B48230", VA = "0x185B49830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int BPEOCHHNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5B49910", Offset = "0x5B48310", VA = "0x185B49910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5B49050", Offset = "0x5B47A50", VA = "0x185B49050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public KAEJCOGFAOC(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B43980", Offset = "0x5B42380", VA = "0x185B43980")]
	public static bool EGMKMIPNLBF(KAEJCOGFAOC MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5B49470", Offset = "0x5B47E70", VA = "0x185B49470", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(KAEJCOGFAOC DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
	public static POPHLPHEEBM EGMKMIPNLBF(KAEJCOGFAOC KCKJCMPILDG)
	{
		return default(POPHLPHEEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B49960", Offset = "0x5B48360", VA = "0x185B49960")]
	public bool PGLFAMNGCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5B49100", Offset = "0x5B47B00", VA = "0x185B49100")]
	public EIIMNNHCANF DIDFPGIAGFH(Allocator GGPAKDMJHLJ)
	{
		return default(EIIMNNHCANF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct HEIBGGLBLNO : IEquatable<HEIBGGLBLNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5B47980", Offset = "0x5B46380", VA = "0x185B47980", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(HEIBGGLBLNO DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct MDCBJLBAIKP : IEquatable<MDCBJLBAIKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public MDCBJLBAIKP(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B200", Offset = "0x5B49C00", VA = "0x185B4B200", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(MDCBJLBAIKP DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B2B0", Offset = "0x5B49CB0", VA = "0x185B4B2B0")]
	public void NJKFKCNNMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B380", Offset = "0x5B49D80", VA = "0x185B4B380")]
	public void ODELNGMKLPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct BOLPDANFPGC : IEquatable<BOLPDANFPGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public BOLPDANFPGC(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5B425F0", Offset = "0x5B40FF0", VA = "0x185B425F0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(BOLPDANFPGC DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct KHBONPNLADM : IEquatable<KHBONPNLADM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5B49B50", Offset = "0x5B48550", VA = "0x185B49B50", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(KHBONPNLADM DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct MDAGJCBDHHC : IEquatable<MDAGJCBDHHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B150", Offset = "0x5B49B50", VA = "0x185B4B150", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(MDAGJCBDHHC DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AMPPKKIKNAH : IEquatable<AMPPKKIKNAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5B423C0", Offset = "0x5B40DC0", VA = "0x185B423C0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(AMPPKKIKNAH DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DMENCOIAJNL : IEquatable<DMENCOIAJNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B42DE0", Offset = "0x5B417E0", VA = "0x185B42DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private LAIKDFLJMKI GLIJFKPEFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5B42C70", Offset = "0x5B41670", VA = "0x185B42C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public DFKOJFHJBPL GPFMBDKCEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B42CF0", Offset = "0x5B416F0", VA = "0x185B42CF0")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public POPHLPHEEBM NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B43020", Offset = "0x5B41A20", VA = "0x185B43020")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public POPHLPHEEBM PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5B42E30", Offset = "0x5B41830", VA = "0x185B42E30")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public DMENCOIAJNL(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5B42BC0", Offset = "0x5B415C0", VA = "0x185B42BC0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(DMENCOIAJNL DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5B42AB0", Offset = "0x5B414B0", VA = "0x185B42AB0")]
	public bool DGJAMCMEJGD(POPHLPHEEBM ELGBIOMPEHN, bool FMMHJBAPDJF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5B42F30", Offset = "0x5B41930", VA = "0x185B42F30")]
	public bool KOAJBNHNOIK(POPHLPHEEBM OBNNKPFGMNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct HLEEIHCAIFO : IEquatable<HLEEIHCAIFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public string CFJGBOECNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5B47B90", Offset = "0x5B46590", VA = "0x185B47B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string NLELKEIIMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5B47A30", Offset = "0x5B46430", VA = "0x185B47A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public HLEEIHCAIFO(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5B47AE0", Offset = "0x5B464E0", VA = "0x185B47AE0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(HLEEIHCAIFO DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct ANFNFAFMADL : IEquatable<ANFNFAFMADL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5B42540", Offset = "0x5B40F40", VA = "0x185B42540", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(ANFNFAFMADL DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct EGECLHEMNFM : IEquatable<EGECLHEMNFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private GHMLCJKOGGN HNAEGLAMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5B43810", Offset = "0x5B42210", VA = "0x185B43810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5B434B0", Offset = "0x5B41EB0", VA = "0x185B434B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5B435E0", Offset = "0x5B41FE0", VA = "0x185B435E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public EGECLHEMNFM(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5B43760", Offset = "0x5B42160", VA = "0x185B43760", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(EGECLHEMNFM DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5B43370", Offset = "0x5B41D70", VA = "0x185B43370")]
	public bool ANMNLHNLLME(out Collider FGPOCJNLNLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct OIHFEALDBPN : IEquatable<OIHFEALDBPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CB50", Offset = "0x5B4B550", VA = "0x185B4CB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private OOOJALCPIHG MODAKIGBPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D000", Offset = "0x5B4BA00", VA = "0x185B4D000")]
		get
		{
			return default(OOOJALCPIHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool IHMMDCDHBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CE30", Offset = "0x5B4B830", VA = "0x185B4CE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool OFDGOLFFLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C810", Offset = "0x5B4B210", VA = "0x185B4C810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool LNNFDJPKIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CDC0", Offset = "0x5B4B7C0", VA = "0x185B4CDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IAEGNKKAFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C650", Offset = "0x5B4B050", VA = "0x185B4C650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CJFCFEJAIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C7A0", Offset = "0x5B4B1A0", VA = "0x185B4C7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool DLCJPFAPFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C520", Offset = "0x5B4AF20", VA = "0x185B4C520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool IHDEFNKOJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CF10", Offset = "0x5B4B910", VA = "0x185B4CF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DKHOLPLCJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C6C0", Offset = "0x5B4B0C0", VA = "0x185B4C6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HHFGKDJHFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CA00", Offset = "0x5B4B400", VA = "0x185B4CA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NKGCIBIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C730", Offset = "0x5B4B130", VA = "0x185B4C730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BJDODEKNOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D060", Offset = "0x5B4BA60", VA = "0x185B4D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool EALMPIMDCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CCE0", Offset = "0x5B4B6E0", VA = "0x185B4CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool CCFHHOJFIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CD50", Offset = "0x5B4B750", VA = "0x185B4CD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool ADKEIDIFENG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CC80", Offset = "0x5B4B680", VA = "0x185B4CC80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C4B0", Offset = "0x5B4AEB0", VA = "0x185B4C4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool FDHDFHEMBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CEA0", Offset = "0x5B4B8A0", VA = "0x185B4CEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 IDFFFFIMCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C930", Offset = "0x5B4B330", VA = "0x185B4C930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 JEGJHKBFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C590", Offset = "0x5B4AF90", VA = "0x185B4C590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JKEJMCCIALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B4CBA0", Offset = "0x5B4B5A0", VA = "0x185B4CBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public OIHFEALDBPN(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C880", Offset = "0x5B4B280", VA = "0x185B4C880", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(OIHFEALDBPN DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CF80", Offset = "0x5B4B980", VA = "0x185B4CF80")]
	public bool ODDFKCILGCM(HNBLHADGJHF FEPNGKFEELL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CA70", Offset = "0x5B4B470", VA = "0x185B4CA70")]
	public void HBJBKHEPDJF(HNBLHADGJHF FEPNGKFEELL, bool PLOAPGLMHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct HLEHCPLKODD : IEquatable<HLEHCPLKODD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private OHGDLKLKOAJ MHNJEMPCJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5B47ED0", Offset = "0x5B468D0", VA = "0x185B47ED0")]
		get
		{
			return default(OHGDLKLKOAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BMEOLDGIHFJ LEKANNEOPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5B47FE0", Offset = "0x5B469E0", VA = "0x185B47FE0")]
		get
		{
			return default(BMEOLDGIHFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public HLEHCPLKODD(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5B47F30", Offset = "0x5B46930", VA = "0x185B47F30", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(HLEHCPLKODD DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5B47E20", Offset = "0x5B46820", VA = "0x185B47E20")]
	public FFLAHOBFCAD AABLFCFGKAL()
	{
		return default(FFLAHOBFCAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct FFLAHOBFCAD : IEquatable<FFLAHOBFCAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private PMKCIFELMKG ALAAKEAIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5B44460", Offset = "0x5B42E60", VA = "0x185B44460")]
		get
		{
			return default(PMKCIFELMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KDAOBJAJCNI CKHGPFECKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5B443F0", Offset = "0x5B42DF0", VA = "0x185B443F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public FFLAHOBFCAD(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5B44340", Offset = "0x5B42D40", VA = "0x185B44340", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(FFLAHOBFCAD DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct PEHPMIHEEMG : IEquatable<PEHPMIHEEMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5B4DE10", Offset = "0x5B4C810", VA = "0x185B4DE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public PEHPMIHEEMG(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DD60", Offset = "0x5B4C760", VA = "0x185B4DD60", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(PEHPMIHEEMG DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DFB0", Offset = "0x5B4C9B0", VA = "0x185B4DFB0")]
	public void KOGFLHNCOKL(bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DE60", Offset = "0x5B4C860", VA = "0x185B4DE60")]
	public void IIDBFMCDFLO(bool MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct KHMCGHBHAJG : IEquatable<KHMCGHBHAJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A100", Offset = "0x5B48B00", VA = "0x185B4A100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private DGINFINNHOA LEBMGCOFLNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5B49EA0", Offset = "0x5B488A0", VA = "0x185B49EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EONMGNFOEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A2B0", Offset = "0x5B48CB0", VA = "0x185B4A2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool ADAMOFHJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A1B0", Offset = "0x5B48BB0", VA = "0x185B4A1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MFBJKEMMJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5B49E70", Offset = "0x5B48870", VA = "0x185B49E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DFMKLBIDNNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A180", Offset = "0x5B48B80", VA = "0x185B4A180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PLBFJFCBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5B49C00", Offset = "0x5B48600", VA = "0x185B49C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool AHDOHGICEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5B49D00", Offset = "0x5B48700", VA = "0x185B49D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool CJOIAFLJELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A550", Offset = "0x5B48F50", VA = "0x185B4A550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public KHMCGHBHAJG(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B43980", Offset = "0x5B42380", VA = "0x185B43980")]
	public static bool EGMKMIPNLBF(KHMCGHBHAJG MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B49F20", Offset = "0x5B48920", VA = "0x185B49F20", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(KHMCGHBHAJG DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A150", Offset = "0x5B48B50", VA = "0x185B4A150")]
	public bool INJEMBBDJFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B49FD0", Offset = "0x5B489D0", VA = "0x185B49FD0")]
	public POPHLPHEEBM GDJPIBALCOP(POPHLPHEEBM JNODNCHMALF)
	{
		return default(POPHLPHEEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A390", Offset = "0x5B48D90", VA = "0x185B4A390")]
	public DFKOJFHJBPL NGLCACDDDHF()
	{
		return default(DFKOJFHJBPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct PMKCLINLEDB : IEquatable<PMKCLINLEDB>
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly PMKCLINLEDB OAGGFOALBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public FGJDKLLMCEC ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(FGJDKLLMCEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private DBEGGFPHCFH CGOLNCPFMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F060", Offset = "0x5B4DA60", VA = "0x185B4F060")]
		get
		{
			return default(DBEGGFPHCFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public JMFKBBCFPDF FNLOBJDBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5B4EE10", Offset = "0x5B4D810", VA = "0x185B4EE10")]
		get
		{
			return default(JMFKBBCFPDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IMBACMHHHNP NCHGBOCEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F380", Offset = "0x5B4DD80", VA = "0x185B4F380")]
		get
		{
			return default(IMBACMHHHNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public FEFFDIHKBFP NCKDKHHANEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F3E0", Offset = "0x5B4DDE0", VA = "0x185B4F3E0")]
		get
		{
			return default(FEFFDIHKBFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public CGPCKAPOAOD KBCFHHEOHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B4ED10", Offset = "0x5B4D710", VA = "0x185B4ED10")]
		get
		{
			return default(CGPCKAPOAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public MEDMHGMHFAO HLAJMIKEBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B4ECB0", Offset = "0x5B4D6B0", VA = "0x185B4ECB0")]
		get
		{
			return default(MEDMHGMHFAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B4EF20", Offset = "0x5B4D920", VA = "0x185B4EF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public KAKHMHPIMPH LHOKJLFNHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F000", Offset = "0x5B4DA00", VA = "0x185B4F000")]
		get
		{
			return default(KAKHMHPIMPH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B4EF90", Offset = "0x5B4D990", VA = "0x185B4EF90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float POCDOEABKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B4EDB0", Offset = "0x5B4D7B0", VA = "0x185B4EDB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F2A0", Offset = "0x5B4DCA0", VA = "0x185B4F2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 MFFPMJNKGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F130", Offset = "0x5B4DB30", VA = "0x185B4F130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public float PDPMOKILJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F1C0", Offset = "0x5B4DBC0", VA = "0x185B4F1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ShapeConfigData.Flags KHBCGGDADKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F320", Offset = "0x5B4DD20", VA = "0x185B4F320")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F0C0", Offset = "0x5B4DAC0", VA = "0x185B4F0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public PMKCLINLEDB(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B43980", Offset = "0x5B42380", VA = "0x185B43980")]
	public static bool EGMKMIPNLBF(PMKCLINLEDB MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EE70", Offset = "0x5B4D870", VA = "0x185B4EE70", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(PMKCLINLEDB DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EC50", Offset = "0x5B4D650", VA = "0x185B4EC50")]
	public EHLGLNMBADB BICPDHFABAA()
	{
		return default(EHLGLNMBADB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F240", Offset = "0x5B4DC40", VA = "0x185B4F240")]
	public IHPFPPKPCHF MHMBHHMHKJB()
	{
		return default(IHPFPPKPCHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct EHLGLNMBADB : IEquatable<EHLGLNMBADB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public PMKCLINLEDB GJFJCGHIBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(PMKCLINLEDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private KEHGIHILAIH DHJLFICJOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B43AD0", Offset = "0x5B424D0", VA = "0x185B43AD0")]
		get
		{
			return default(KEHGIHILAIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public MGHIFAKDBDN DMLPEBNKKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5B43A70", Offset = "0x5B42470", VA = "0x185B43A70")]
		get
		{
			return default(MGHIFAKDBDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public EHLGLNMBADB(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5B43980", Offset = "0x5B42380", VA = "0x185B43980")]
	public static bool EGMKMIPNLBF(EHLGLNMBADB MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5B439C0", Offset = "0x5B423C0", VA = "0x185B439C0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(EHLGLNMBADB DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DefaultMember("Item")]
public readonly struct IHPFPPKPCHF : IEquatable<IHPFPPKPCHF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public FGJDKLLMCEC ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(FGJDKLLMCEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B48BA0", Offset = "0x5B475A0", VA = "0x185B48BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private JFFIFAIOBGL ABOICNGPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B48270", Offset = "0x5B46C70", VA = "0x185B48270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public PMKCLINLEDB GJFJCGHIBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(PMKCLINLEDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public MJPONBKEEHJ MMPANJJDHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5B48CD0", Offset = "0x5B476D0", VA = "0x185B48CD0")]
		get
		{
			return default(MJPONBKEEHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B48410", Offset = "0x5B46E10", VA = "0x185B48410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public IEnumerable<GIABPMHBLPJ> CNIOPPJHNJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B48510", Offset = "0x5B46F10", VA = "0x185B48510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public GIABPMHBLPJ NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5B482F0", Offset = "0x5B46CF0", VA = "0x185B482F0")]
		get
		{
			return default(GIABPMHBLPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5B48BF0", Offset = "0x5B475F0", VA = "0x185B48BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public IHPFPPKPCHF(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B43980", Offset = "0x5B42380", VA = "0x185B43980")]
	public static bool EGMKMIPNLBF(IHPFPPKPCHF MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B486F0", Offset = "0x5B470F0", VA = "0x185B486F0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(IHPFPPKPCHF DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B487A0", Offset = "0x5B471A0", VA = "0x185B487A0")]
	public GIABPMHBLPJ GKDAJDIKJCK(Vector3? OAALNDIAAOB, [Optional] Quaternion? HOOCPOKGFMC, [Optional] Vector3? HKGHFAPJIOG)
	{
		return default(GIABPMHBLPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B48930", Offset = "0x5B47330", VA = "0x185B48930")]
	public GIABPMHBLPJ GKDAJDIKJCK()
	{
		return default(GIABPMHBLPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B48AB0", Offset = "0x5B474B0", VA = "0x185B48AB0")]
	public void GNBOGKPOKGD(int GFDMFLGCBKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct GIABPMHBLPJ : IEquatable<GIABPMHBLPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public IHPFPPKPCHF OEHCLMCMNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B47480", Offset = "0x5B45E80", VA = "0x185B47480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public float3 IOJJLJDINFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5B47710", Offset = "0x5B46110", VA = "0x185B47710")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B47890", Offset = "0x5B46290", VA = "0x185B47890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public quaternion MBFBKKLCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5B47400", Offset = "0x5B45E00", VA = "0x185B47400")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B47320", Offset = "0x5B45D20", VA = "0x185B47320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float3 DLCNFDJOIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B47800", Offset = "0x5B46200", VA = "0x185B47800")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B47500", Offset = "0x5B45F00", VA = "0x185B47500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LMFAJIFDCEJ NEIOBMAAIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5B47640", Offset = "0x5B46040", VA = "0x185B47640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private NBFPJHAPDEN AKEDIGFOICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5B473A0", Offset = "0x5B45DA0", VA = "0x185B473A0")]
		get
		{
			return default(NBFPJHAPDEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private MIDKGEJMDBG JCOIKICLPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5B476B0", Offset = "0x5B460B0", VA = "0x185B476B0")]
		get
		{
			return default(MIDKGEJMDBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private KJJHLOPHEOC CPMCILDOBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5B472C0", Offset = "0x5B45CC0", VA = "0x185B472C0")]
		get
		{
			return default(KJJHLOPHEOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private HKMGDFKLDBI CPKDOIDDKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5B477A0", Offset = "0x5B461A0", VA = "0x185B477A0")]
		get
		{
			return default(HKMGDFKLDBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private ALNBDGAPDCF FEPAKLCPGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5B47920", Offset = "0x5B46320", VA = "0x185B47920")]
		get
		{
			return default(ALNBDGAPDCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public GIABPMHBLPJ(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B47590", Offset = "0x5B45F90", VA = "0x185B47590", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(GIABPMHBLPJ DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B47480", Offset = "0x5B45E80", VA = "0x185B47480")]
	public void OMJNIDGCMAA(IHPFPPKPCHF MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5B47890", Offset = "0x5B46290", VA = "0x185B47890")]
	public void OIKLGIPKJJN(float3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5B47320", Offset = "0x5B45D20", VA = "0x185B47320")]
	public void FCDOPBINEBB(quaternion MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct FGJDKLLMCEC : IEquatable<FGJDKLLMCEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public POPHLPHEEBM DGOIOLAFIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5B424E0", Offset = "0x5B40EE0", VA = "0x185B424E0")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private JOHEJCALJIO CHJJBHMIKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5B471A0", Offset = "0x5B45BA0", VA = "0x185B471A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool AIFDOKHIDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5B44E50", Offset = "0x5B43850", VA = "0x185B44E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 IOJJLJDINFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5B46580", Offset = "0x5B44F80", VA = "0x185B46580")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5B46A40", Offset = "0x5B45440", VA = "0x185B46A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion MBFBKKLCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5B44A60", Offset = "0x5B43460", VA = "0x185B44A60")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5B44530", Offset = "0x5B42F30", VA = "0x185B44530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Vector3 NJJBCKOHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5B44BB0", Offset = "0x5B435B0", VA = "0x185B44BB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5B460A0", Offset = "0x5B44AA0", VA = "0x185B460A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Quaternion KKEIEPMJOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5B459E0", Offset = "0x5B443E0", VA = "0x185B459E0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5B45750", Offset = "0x5B44150", VA = "0x185B45750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float LMOFGOGBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5B45DD0", Offset = "0x5B447D0", VA = "0x185B45DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 DLCNFDJOIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5B468F0", Offset = "0x5B452F0", VA = "0x185B468F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5B44D00", Offset = "0x5B43700", VA = "0x185B44D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 NONIDKAINNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5B46E30", Offset = "0x5B45830", VA = "0x185B46E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 BBPLHKICOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5B44670", Offset = "0x5B43070", VA = "0x185B44670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Matrix4x4 MLECCGOMAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5B467A0", Offset = "0x5B451A0", VA = "0x185B467A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89700", VA = "0x182A8AD00")]
	public FGJDKLLMCEC(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5B424C0", Offset = "0x5B40EC0", VA = "0x185B424C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5B45480", Offset = "0x5B43E80", VA = "0x185B45480", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B40E70", VA = "0x185B42470", Slot = "4")]
	public bool Equals(FGJDKLLMCEC DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5B42500", Offset = "0x5B40F00", VA = "0x185B42500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5B444C0", Offset = "0x5B42EC0", VA = "0x185B444C0")]
	public CKMHCCNBJAM AEOIFMPKLND()
	{
		return default(CKMHCCNBJAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5B46340", Offset = "0x5B44D40", VA = "0x185B46340")]
	public RigidTransform JNHIJIDHDEB()
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5B464A0", Offset = "0x5B44EA0", VA = "0x185B464A0")]
	public void JNHIJIDHDEB(out Vector3 CBHMJLKLIAE, out Quaternion MAHCHBHJJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5B45670", Offset = "0x5B44070", VA = "0x185B45670")]
	public void FDBPDLCFODF(out Vector3 GBGEGEKJOFF, out Quaternion HLMPNEAIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5B44910", Offset = "0x5B43310", VA = "0x185B44910")]
	public Vector3 CDHMJLLPFOH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5B46B90", Offset = "0x5B45590", VA = "0x185B46B90")]
	public void OIKLGIPKJJN(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5B45890", Offset = "0x5B44290", VA = "0x185B45890")]
	public Vector3 FPMGKAGIODP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5B450A0", Offset = "0x5B43AA0", VA = "0x185B450A0")]
	public void ECAJNKONNEH(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5B44EA0", Offset = "0x5B438A0", VA = "0x185B44EA0")]
	public Quaternion DIJINLDKEFE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5B45530", Offset = "0x5B43F30", VA = "0x185B45530")]
	public void FCDOPBINEBB(Quaternion MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5B46CE0", Offset = "0x5B456E0", VA = "0x185B46CE0")]
	public Quaternion OKLKHJOJHEA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5B451F0", Offset = "0x5B43BF0", VA = "0x185B451F0")]
	public void EEJLMNEBFOP(Quaternion MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5B45EA0", Offset = "0x5B448A0", VA = "0x185B45EA0")]
	public float IJEHGCNMIII()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5B46F80", Offset = "0x5B45980", VA = "0x185B46F80")]
	public void OMBJFGGMNME(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5B44FF0", Offset = "0x5B439F0", VA = "0x185B44FF0")]
	public float DNBEKFAEPDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5B466D0", Offset = "0x5B450D0", VA = "0x185B466D0")]
	public void LNOHOBMEHFL(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5B461F0", Offset = "0x5B44BF0", VA = "0x185B461F0")]
	public void JLAHOJLKKDE(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5B45B30", Offset = "0x5B44530", VA = "0x185B45B30")]
	public Vector3 GMDPNHMFDDK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5B47050", Offset = "0x5B45A50", VA = "0x185B47050")]
	public void PJAGCBMOGCF(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5B447C0", Offset = "0x5B431C0", VA = "0x185B447C0")]
	public Vector3 BPAJOKKJFHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5B45F50", Offset = "0x5B44950", VA = "0x185B45F50")]
	public void IMPGJHCKNLH(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5B45C80", Offset = "0x5B44680", VA = "0x185B45C80")]
	public Vector3 HBPPDKACENN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5B45330", Offset = "0x5B43D30", VA = "0x185B45330")]
	public void ELJDFADFNNL(Vector3 MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class AGLGCOAGAJD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct NHFEKHPOPLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Guid CKAFGMOJCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ONPJAHOPLNO PDKGGBJOOCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct ONPJAHOPLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int MNIAGKNOHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int ONNNJCPGIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int PBPCAHCBPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int JJICCJJNAGD;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D220", Offset = "0x5B4BC20", VA = "0x185B4D220")]
		public bool BEHAOLGAHEA(out AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D2A0", Offset = "0x5B4BCA0", VA = "0x185B4D2A0")]
		public ONPJAHOPLNO(AKLFKNOOHJC AOCEENCOLMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5B420A0", Offset = "0x5B40AA0", VA = "0x185B420A0")]
	public static Guid FNFNEIDOLEH(this AKLFKNOOHJC AOCEENCOLMM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5B420C0", Offset = "0x5B40AC0", VA = "0x185B420C0")]
	public static bool ILMKPBGBPNM(this Guid CKAFGMOJCKA, out AKLFKNOOHJC AOCEENCOLMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal static class HMGDCNGKBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5B48040", Offset = "0x5B46A40", VA = "0x185B48040")]
	public static DEAGKEFEBKN CIFPLKLELPL(this DFKOJFHJBPL OGGLMCNMCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5B480B0", Offset = "0x5B46AB0", VA = "0x185B480B0")]
	public static EntityManager FLHDGCEBOEE(this DFKOJFHJBPL OGGLMCNMCLJ)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x222E5F0", Offset = "0x222CFF0", VA = "0x18222E5F0")]
	public static T GIKNLDPPABE<T>(this DFKOJFHJBPL OGGLMCNMCLJ) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x222F230", Offset = "0x222DC30", VA = "0x18222F230")]
	public static bool ICAEOOBIMHM<T>(this DFKOJFHJBPL OGGLMCNMCLJ) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface PEDCBEJAKGP
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Guid HIIIHGDPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCIDDFOIFJP(Guid PDPEDDGLLKB, Guid IIEPEDPEOPD);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPFEFMLFJFJ(DFKOJFHJBPL EINBJLALBGN);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface OFJGIHJMMMN
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODFNLHBOEEC(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FMOPPCGJAFL(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGHNIPAPIAI(DFKOJFHJBPL PMMCMCPNCLD, out Guid LDLPOFLCBNI);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PLLMEPDDHNN(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDKCEKDJMBJ(DFKOJFHJBPL PMMCMCPNCLD, Guid LDLPOFLCBNI);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHIDGNNLHIP(DFKOJFHJBPL PMMCMCPNCLD, out Guid OIGKBPKEMEL);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid LBKJNAEBHMJ(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CAKOKKBAGCP(DFKOJFHJBPL PMMCMCPNCLD, Guid OIGKBPKEMEL);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BIKHPIIDDEH(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPFMHMGEEPN(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCEBCIAEALA(DFKOJFHJBPL DDLMBHAEKGH, DFKOJFHJBPL ELGBIOMPEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface CPMCACBEBDN
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	Func<OILFFIBNFMI> DFNFJBENIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<DFKOJFHJBPL, DFKOJFHJBPL> LAFCHHLEOGK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<DFKOJFHJBPL, DFKOJFHJBPL> AEIKDLAFHHM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DFKOJFHJBPL, DFKOJFHJBPL, DFKOJFHJBPL> FBIJMAJAKCN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<DFKOJFHJBPL> LDFDFIFCLHI;

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DFKOJFHJBPL NMFLIPCIPEC(DFKOJFHJBPL PMMCMCPNCLD, int CDMHHELDENI);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Color LMHLENJAFLI(DFKOJFHJBPL PMMCMCPNCLD, int CDMHHELDENI);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 OCCFDHJKJGK(DFKOJFHJBPL PMMCMCPNCLD, int CDMHHELDENI);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MGMJBECAIEC(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL BPIPBLPIHDC);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DFKOJFHJBPL LKOJBNOAMID(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<DFKOJFHJBPL> IIIIKGEJAOB(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DFKOJFHJBPL CEBAMPKELFM(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OBOCFKLPPGD(DFKOJFHJBPL PMMCMCPNCLD, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NLOCCADHLLD(DFKOJFHJBPL PMMCMCPNCLD, out RigidTransform GEHMBECKLCM);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LOCKKGIHGAE(NNINMABELDO MMKMHECDHFO);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	quaternion GAFGHHFJLEA(NNINMABELDO MMKMHECDHFO);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BEFHBEAILEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface EMFKELAKBNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	object FICMOFNJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODNLJFIDJAE(EIIMNNHCANF BPPOAHFNBEH);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OILFFIBNFMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	Entity OKIJCMMIHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	Entity ABNHJDJIAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APHPOPBCCOG(float3 LGGBCCHKBJD);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODKFJKFOHMN(float3 LGGBCCHKBJD);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKEEFENEAME(out float3 AGNHLFMCFOJ, out float3 PGDLDMBJJEP);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFBBFHPAGHD(float3 AGNHLFMCFOJ, float3 PGDLDMBJJEP);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KOFLPOLJPMF(Color AGNHLFMCFOJ, Color PGDLDMBJJEP);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OILFFIBNFMI Instantiate(Transform CLHKPCIOCGF);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LBOODBLHBKE
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGKFDHOAMGH(Transform CLHKPCIOCGF, OILFFIBNFMI EOAAKGAPBDB);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OILFFIBNFMI DFNFJBENIEB();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface IBAGHJGNPCO
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	Guid HIIIHGDPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBHKCICMBAB(Guid LDLPOFLCBNI, Guid OIGKBPKEMEL, string ANJJEPIBAGI);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface LAIKDFLJMKI
{
	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFKOJFHJBPL EDPENGKDDJF(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFKOJFHJBPL CBCDGOOOFFP(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGJAMCMEJGD(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL ELGBIOMPEHN, bool FMMHJBAPDJF);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MIGAOKLMMPE(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL ELGBIOMPEHN);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NLFFKMDNFBA(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EIIMNNHCANF CFOGOOEEEBP(DFKOJFHJBPL EFHLICFAAGO);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CNEEDNJDFHP(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL KFMKMKEGGGJ);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KOAJBNHNOIK(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL OBNNKPFGMNE);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DFKOJFHJBPL BPIDCKMFGNC(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LONLDNKLGBI(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI, out DFKOJFHJBPL ENIDPPCMOFM);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class EJCEKOFLHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5B43FE0", Offset = "0x5B429E0", VA = "0x185B43FE0")]
	public static bool GOECHKKAMDL(this LAIKDFLJMKI HKHMGAMGNMF, DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface EBIDIPICLGG
{
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UndoAction HHPEGPECABM();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	RedoAction ABFABJHKBPA(UndoAction JNODNCHMALF);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	UndoAction AHLFPHBNKGH(RedoAction JNODNCHMALF);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable FBBLPPCJNDF();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface DJAEBDNKOIG
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool DMGAHOLJMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface HGFGJIKNIPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<DFKOJFHJBPL, AOIKBHJMDBO> NIEIHPJBMLK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<DFKOJFHJBPL> OJOJFJMPPIB;

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBPFPNIOEPH GPCPPGBINOB(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOIKBHJMDBO MGDPAKACCKF(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGMDKKEHOIN(AKLFKNOOHJC AOCEENCOLMM, HBIBAGENGHJ MIDDDIBGPID);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "8")]
	POPHLPHEEBM PIKENIAFHJF(DFKOJFHJBPL PMMCMCPNCLD, [Optional] object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HAAHLPEEGIO(DFKOJFHJBPL PMMCMCPNCLD, out HBIBAGENGHJ MIDDDIBGPID);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MNJLLHMJPCE(HBIBAGENGHJ MIDDDIBGPID);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GOEJCHMLHHD(DFKOJFHJBPL PMMCMCPNCLD, out Transform CLHKPCIOCGF);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HNGDLAAAHJE(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CDAPIFCKPGM(Entity GOANOLJBHPF, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool ENAJODIBMIM(Entity GOANOLJBHPF, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DFKOJFHJBPL DHDNGOHCFIF(AKLFKNOOHJC AOCEENCOLMM);

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AKLFKNOOHJC OOMNOMGKKMO(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "17")]
	POPHLPHEEBM LNCOMHGPOAE(AOIKBHJMDBO GDAJCNKPBDC, bool PCDCBPLMECK);

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "18")]
	POPHLPHEEBM LNCOMHGPOAE(AOIKBHJMDBO GDAJCNKPBDC);

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "19")]
	POPHLPHEEBM EMPCNAPPLAH(AOIKBHJMDBO GDAJCNKPBDC);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "20")]
	POPHLPHEEBM NELDJHBEBDP(AKLFKNOOHJC AOCEENCOLMM, AOIKBHJMDBO GDAJCNKPBDC);

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "21")]
	KAEJCOGFAOC CBDGNLKCMJD();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IHPFPPKPCHF LIJHNKECALI();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "23")]
	EHLGLNMBADB FEKOEOBMBGE(MGHIFAKDBDN PMAPGJKGONM);

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NJKFKCNNMGK(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void FFMAALCHNFN(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ODELNGMKLPF(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)> GKODLOMCAKJ(NativeArray<DFKOJFHJBPL> NNPEDNPMEIC, Allocator GGPAKDMJHLJ);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool FDOEJMJEMDK(DFKOJFHJBPL PMMCMCPNCLD);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PLNPKICHBNM
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E7A0", Offset = "0x5B4D1A0", VA = "0x185B4E7A0")]
	public static bool GOEJCHMLHHD(this HGFGJIKNIPL CPFOJDHADNE, Entity GOANOLJBHPF, out Transform CLHKPCIOCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E4A0", Offset = "0x5B4CEA0", VA = "0x185B4E4A0")]
	public static POPHLPHEEBM EPBPAFABDJA(this HGFGJIKNIPL CPFOJDHADNE, Entity GOANOLJBHPF)
	{
		return default(POPHLPHEEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E440", Offset = "0x5B4CE40", VA = "0x185B4E440")]
	public static DFKOJFHJBPL DHDNGOHCFIF(this HGFGJIKNIPL CPFOJDHADNE, Entity GOANOLJBHPF)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EB40", Offset = "0x5B4D540", VA = "0x185B4EB40")]
	public static AKLFKNOOHJC OOMNOMGKKMO(this HGFGJIKNIPL CPFOJDHADNE, Entity GOANOLJBHPF)
	{
		return default(AKLFKNOOHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E650", Offset = "0x5B4D050", VA = "0x185B4E650")]
	public static bool FDOEJMJEMDK(this HGFGJIKNIPL CPFOJDHADNE, AKLFKNOOHJC AOCEENCOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E0F0", Offset = "0x5B4CAF0", VA = "0x185B4E0F0")]
	public static KAEJCOGFAOC CCOLNNDGAAF(this HGFGJIKNIPL CPFOJDHADNE, RigidTransform BLCFJOFFEFD, [Optional] object DEGCIHEAIBD)
	{
		return default(KAEJCOGFAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E8C0", Offset = "0x5B4D2C0", VA = "0x185B4E8C0")]
	public static EHLGLNMBADB JJIBJFFJPHK(this HGFGJIKNIPL CPFOJDHADNE, MGHIFAKDBDN BNGELBIJGCI, RigidTransform BLCFJOFFEFD, [Optional] object DEGCIHEAIBD)
	{
		return default(EHLGLNMBADB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EA00", Offset = "0x5B4D400", VA = "0x185B4EA00")]
	public static IHPFPPKPCHF NGMHPNLEOOD(this HGFGJIKNIPL CPFOJDHADNE, RigidTransform BLCFJOFFEFD, [Optional] object DEGCIHEAIBD)
	{
		return default(IHPFPPKPCHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E540", Offset = "0x5B4CF40", VA = "0x185B4E540")]
	private static void FCLEHPLMLND(POPHLPHEEBM ONABNFHJKBC, RigidTransform BLCFJOFFEFD, [Optional] object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E230", Offset = "0x5B4CC30", VA = "0x185B4E230")]
	internal static FFLAHOBFCAD CNHOHPGEAPN(this HGFGJIKNIPL CPFOJDHADNE, KDAOBJAJCNI HOGFGIKBHGJ, [Optional] object DEGCIHEAIBD)
	{
		return default(FFLAHOBFCAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface MNMIJEOGALA
{
	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DFKOJFHJBPL, LJOEKOFPECD> FCDDPDJBKEP;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HIKPOGCHOCE(DFKOJFHJBPL PMMCMCPNCLD, out Collider FGPOCJNLNLF);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKBKOAAHGLL(DFKOJFHJBPL PMMCMCPNCLD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface DGINFINNHOA
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool LPBEELCKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	DFKOJFHJBPL IGBEIJAJIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	POPHLPHEEBM EPPEEBLENIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	POPHLPHEEBM BHFGHFHGKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event COILGKAGPMO OABGDDDFKDJ;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DFKOJFHJBPL BPIDCKMFGNC(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LONLDNKLGBI(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI, out DFKOJFHJBPL ENIDPPCMOFM);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GDPKFEMKHPB();

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGJLIJCILCH();

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EONMGNFOEPG(DFKOJFHJBPL JNODNCHMALF);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void COILGKAGPMO(POPHLPHEEBM KFKCIBIFILP, POPHLPHEEBM CEPBFJKJFIE);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LLPEGEEPKBE
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AF40", Offset = "0x5B49940", VA = "0x185B4AF40")]
	public static bool MENHAOOINEL(this DGINFINNHOA KGLBMDPKPFL, POPHLPHEEBM JNODNCHMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AC00", Offset = "0x5B49600", VA = "0x185B4AC00")]
	public static bool KJNNECEOJCI(this DGINFINNHOA KGLBMDPKPFL, DFKOJFHJBPL JNODNCHMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AFC0", Offset = "0x5B499C0", VA = "0x185B4AFC0")]
	public static bool PLBFJFCBCLD(this DGINFINNHOA KGLBMDPKPFL, DFKOJFHJBPL JNODNCHMALF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface GHMLCJKOGGN
{
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJLPFLNDBAA(DFKOJFHJBPL PMMCMCPNCLD, AJLHDLPKFOJ MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AJLHDLPKFOJ OJNLFBAEICK(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBAFGGCIFCB(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONHPMCGNOEF(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NLFFKMDNFBA(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DFKOJFHJBPL KADGDGJNBPA(DFKOJFHJBPL PMMCMCPNCLD, int GFDMFLGCBKB);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MMHPOHCMKNI(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BDBCJIDBAKL(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD, DFKOJFHJBPL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FPAMLDLBGAM(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GIOPNDLOMAB(DFKOJFHJBPL PMMCMCPNCLD, out DFKOJFHJBPL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OOOCFMLLNCA(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LPLCBIHMCDE(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NAEAPNJPOFC(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CANGNKNIGIB(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GLJHHGNCMIP(DFKOJFHJBPL PMMCMCPNCLD, float3 COEKEIABEDK);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OHCDCFEMMHN(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KNPPMCFEHLG(DFKOJFHJBPL PMMCMCPNCLD, quaternion LEBLACCFLIO);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BHHMAONJEBM(DFKOJFHJBPL PMMCMCPNCLD, out quaternion LEBLACCFLIO);

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MHHFPFAJBHJ(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ, out quaternion LEBLACCFLIO);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CLDGNHJJLOF(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ONKHPDLIBFO(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float3 MAPFGENNBGE(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KLHFKODODKK(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float ENODHFLJJJH(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OFALDBALNCH(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float IPAFIJDAGND(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LOAMHNJDNGE(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EEGFPLAGGBB(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KGIPKAJKCEE(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode DKEHNMAKBMN(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KAMEEIPFMAB(DFKOJFHJBPL PMMCMCPNCLD, CollisionDetectionMode MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FHGIMEJNAKL OGJONGFNFMK(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HMCDILOIAIL(DFKOJFHJBPL PMMCMCPNCLD, FHGIMEJNAKL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JHHPIFOEOLL(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void OFAPPAFLAMC(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	DFKOJFHJBPL EDPENGKDDJF(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AHFAOJLGMLP(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	DFKOJFHJBPL CBCDGOOOFFP(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DGJAMCMEJGD(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IHGNHGBDMIK LKCOGGMBFPM(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BHJELIPHEFA(DFKOJFHJBPL PMMCMCPNCLD, IHGNHGBDMIK JEFJOFCHGBL);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool IOKECMIFPJO(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void OEKMAFIIPNC(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool PJMDLLFDBGG(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void PBLFACHHCDF(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool JAHIJMPPKHP(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void FNGDFNGLCKH(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints IPPKINOEALC(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void OKNFIEIGOLN(DFKOJFHJBPL PMMCMCPNCLD, RigidbodyConstraints MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float ACGHHLKHFGF(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void KPLKGDIDEDC(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float GDNNBMJHCPA(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void JKBLDOMNELK(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool HPKGGMLANHC(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AKNPAHDPKHC(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool GDPDEMPDMDC(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PPFGLDEDDMJ(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int ADHOHDPMKLA(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void OPFNLFMFAMO(DFKOJFHJBPL PMMCMCPNCLD, int MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Rigidbody GIGCCLLKFPJ(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EFMPBCOLNJE(DFKOJFHJBPL PMMCMCPNCLD, Rigidbody NIGLNONICLM);

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object LNNHDIFPPEI(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BLOOOPDAFCN(DFKOJFHJBPL PMMCMCPNCLD, object MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "63")]
	object EKDCDCCBCMO(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IOJKJPLIKPC(DFKOJFHJBPL PMMCMCPNCLD, object MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "65")]
	float EGFBANNMNBE(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void OKNAAJMEFPA(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void PLGMLLNHEEC(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FIHFGPAAHAA(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "69")]
	bool KDCCDPDAHLO(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void JLJBLNPMNBL(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void BLBMOHDCAEI(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool KCAMJICICMP(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void MHNCHAHDOAL(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void IDGEAMHIIOJ(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool OELPHIMKEME(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void COHPBIMGGHJ(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void EOGDKCBFICD(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "78")]
	bool AHBPCAGBENM(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "79")]
	IEnumerable<object> POBHMGBPEOP(DFKOJFHJBPL PMMCMCPNCLD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface GEIPPHFKOBG
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEPHKDOHKHK(DFKOJFHJBPL PMMCMCPNCLD);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface BEAGJCJPBDO
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	BDFOGDLNFAP MBEDNIJFHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface KJFLPHKBABP
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFBFMNAAHAD(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKFEOEDEOBJ(DFKOJFHJBPL PMMCMCPNCLD, Transform CLHKPCIOCGF);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface HOHEDKHFMCC
{
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KOGFLHNCOKL(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDBFMCDFLO(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface JFFIFAIOBGL
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<DFKOJFHJBPL> KBCPHGKJLGB(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFKOJFHJBPL KBEKEOPFACM(DFKOJFHJBPL PMMCMCPNCLD, int GFDMFLGCBKB);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HMPAHAOLOJL(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MJPONBKEEHJ EAMFJKAEEGI(DFKOJFHJBPL PMMCMCPNCLD);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANDAHFJEMDI(DFKOJFHJBPL PMMCMCPNCLD, MJPONBKEEHJ HKHEDELGBLL);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DFKOJFHJBPL GBCKOCKIAIL(DFKOJFHJBPL PMMCMCPNCLD, [Optional] Vector3? OAALNDIAAOB, [Optional] Quaternion? HOOCPOKGFMC, [Optional] Vector3? HKGHFAPJIOG);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPILEPIHBDK(DFKOJFHJBPL PMMCMCPNCLD, int GFDMFLGCBKB);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface ODIDMGCABMI
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNCKJBGOMFM();

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLBBPPGMJPP();

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMIJFMMNNED();

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJPCFLEPKAF();

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBLAABLNICJ();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPBIOOPBHHE();

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGEPBKNBMLP();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOOKKCOHGMJ();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LALKIDCIEDJ();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AEIELPFFFNM();

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LHLECKKGEIC();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface JOHEJCALJIO
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EILLAGKIDEO(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIKLGIPKJJN(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Vector3 CDHMJLLPFOH(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCDOPBINEBB(Entity GOANOLJBHPF, Quaternion MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Quaternion DIJINLDKEFE(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAKJNFOLHCP(Entity GOANOLJBHPF, out Vector3 OAALNDIAAOB, out Quaternion HOOCPOKGFMC);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCLKFJNIGFD(Entity GOANOLJBHPF, out Vector3 OAALNDIAAOB, out Quaternion HOOCPOKGFMC);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector3 COLINAFGHKL(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JLAHOJLKKDE(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMBJFGGMNME(Entity GOANOLJBHPF, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float IJEHGCNMIII(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IMPGJHCKNLH(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Vector3 BPAJOKKJFHG(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECAJNKONNEH(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Vector3 FPMGKAGIODP(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEJLMNEBFOP(Entity GOANOLJBHPF, Quaternion MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Quaternion OKLKHJOJHEA(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 GMDPNHMFDDK(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PJAGCBMOGCF(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LNOHOBMEHFL(Entity GOANOLJBHPF, float MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float DNBEKFAEPDA(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ELJDFADFNNL(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Vector3 HBPPDKACENN(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FBPCELOJMCB(Entity GOANOLJBHPF, out Matrix4x4 JOMJHADBJOD);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BCANCOGCMDN(Entity GOANOLJBHPF, in Matrix4x4 JOMJHADBJOD);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BBNEHAIAGAD(Entity GOANOLJBHPF, out Matrix4x4 JOMJHADBJOD);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool GOEJCHMLHHD(Entity GOANOLJBHPF, out Transform CLHKPCIOCGF);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LNMPPIPCKEH(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CJFHPOOPMHC(Entity GOANOLJBHPF, Entity PMJEABCAKDM, Entity DILGNCFGGHK);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LNDPMJIKCND
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface DIOGGBHHPCP
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKHBPKCBCDA(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface DEAGKEFEBKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	EAPDPHILGKF CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	JEHPLMMOFBJ MLKKJKMLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase NFLGFLGDLGA(Type MAHAMGBPDNB);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FIIHCKNJGIG
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5B47210", Offset = "0x5B45C10", VA = "0x185B47210")]
	public static World LLNMOHPPJNB(this DEAGKEFEBKN ALIKEONHNHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE460", Offset = "0x2DACE60", VA = "0x182DAE460")]
	public static T NFLGFLGDLGA<T>(this DEAGKEFEBKN ALIKEONHNHI) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface FEKPIDGPAOL : HJNCNJMLHIG
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DNIHOJPPGJK DBDGKDHDKEP(Entity GOANOLJBHPF);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACPFDPGIMEH(NativeArray<DNIHOJPPGJK> ODGNPDGECIO, NativeArray<IDMLAGGFJCC> NFOBGIKPBLF);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIOIAPODBNB(DNIHOJPPGJK BIONDBIGACN);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HEKMCKKNMIP(DNIHOJPPGJK BIONDBIGACN, out Collider FGPOCJNLNLF);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface HJNCNJMLHIG
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAOOJLNOKIK(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, Allocator GGPAKDMJHLJ, out NativeArray<Entity> CGCCIONMJJA);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface HIOHMPHFJEM
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAOOJLNOKIK(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, out PEGPNOJBJNL LLAEOCBHPAM, out Entity BACOHNNEACN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public interface ACDGEFNBFLP
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAOOJLNOKIK(in NativeArray<Entity> CGCCIONMJJA, in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, in NativeArray<PEGPNOJBJNL> EHJEDFKHHBG);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct DNIHOJPPGJK : global::HFJJIJCEKGL<DNIHOJPPGJK>, HOKCJDBMKAA, IEquatable<DNIHOJPPGJK>
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5B432D0", Offset = "0x5B41CD0", VA = "0x185B432D0", Slot = "8")]
	public bool Equals(DNIHOJPPGJK DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5B43320", Offset = "0x5B41D20", VA = "0x185B43320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct PEGPNOJBJNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float EFJMJHLOKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float3 PIELFIAEDGN;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DHNPEMGDPLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string LOFFIGMBIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	DHNPEMGDPLJ AIELMMPAMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	IEnumerable<DHNPEMGDPLJ> LAMJMBKENMP
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface KEPHDBCLKDO
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	DHNPEMGDPLJ HHHNDDHIHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	List<KNCBBMLNKLK> IBMMPJGCOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EFIEMPOLKNI(KNCBBMLNKLK OPPPBNFKNOC, out DHNPEMGDPLJ EAGMPINEKBM);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface BPDJHFAPEAG : IEnumerable<FBPCPDKHEOJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	FBPCPDKHEOJ NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	FBPCPDKHEOJ NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FBPCPDKHEOJ BBNMBMIAFFD(GFANKPDBBJN IJEJFFCLBDM);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN IJEJFFCLBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class HABKIJGGFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	public static global::AMIANIJFHOJ<T> BBNMBMIAFFD<T>(this BPDJHFAPEAG PDPOLFACNJC, GFANKPDBBJN ANJJEPIBAGI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DefaultMember("Item")]
public interface MFCBDCIMKGI : IEnumerable<ABCMNOFLGBA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	ABCMNOFLGBA NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABCMNOFLGBA BBNMBMIAFFD(GFANKPDBBJN IJEJFFCLBDM);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN IJEJFFCLBDM);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MLEJHNGBPMI
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	public static global::DPGNOJNMADF<T> BBNMBMIAFFD<T>(this MFCBDCIMKGI PDPOLFACNJC, GFANKPDBBJN ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x260FB70", Offset = "0x260E570", VA = "0x18260FB70")]
	public static global::DPGNOJNMADF<T> BBNMBMIAFFD<T>(this MFCBDCIMKGI PDPOLFACNJC, global::BBEGIGBIOHM<T> ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x260FCC0", Offset = "0x260E6C0", VA = "0x18260FCC0")]
	public static JBNNELNIDOD MFJEOJEBIAI<T>(this MFCBDCIMKGI PDPOLFACNJC, global::BBEGIGBIOHM<T> ANJJEPIBAGI) where T : struct
	{
		return default(JBNNELNIDOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DefaultMember("Item")]
public interface BJKMJANDEAI : IEnumerable<KNCBBMLNKLK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	KNCBBMLNKLK NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KNCBBMLNKLK BBNMBMIAFFD(GFANKPDBBJN IJEJFFCLBDM);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class NGAPBKACFOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3310BF0", Offset = "0x330F5F0", VA = "0x183310BF0")]
	public static global::NENALMGBADL<T> BBNMBMIAFFD<T>(this BJKMJANDEAI PDPOLFACNJC, GFANKPDBBJN ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3310D20", Offset = "0x330F720", VA = "0x183310D20")]
	public static global::NENALMGBADL<T> BBNMBMIAFFD<T>(this BJKMJANDEAI PDPOLFACNJC, global::BBEGIGBIOHM<T> ANJJEPIBAGI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface JLBBIMNDMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJGLPDIBFBE(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBNKLMKLJKD(AKLFKNOOHJC AOCEENCOLMM, Span<JBNNELNIDOD> PDPOLFACNJC, bool FJBLBFMGAPB);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface FCADPKIAEAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool PHPKKMNEHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHGOLKFGALJ(bool JECBMIHPMOH);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JNILELMEKNP(bool JECBMIHPMOH);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ByteString JHPOCMCIPNJ(out IDisposable DBHMONFNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCIGFAOHNIM();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AJGJBLGJHIK(ByteString AKOIJLIIFEA, IIICADJMPPL HLCFNPLAIJP = IIICADJMPPL.All);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MDDCFGJOPOD();

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PBEDEGPKDBA(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DGBFGGFLFPL();

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JHKPODDCHJH();

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GENFMKINDFO(bool KODHDLHLAIN);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface CNKLABGKIMB
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ByteString EOPJHDNOGBH();

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OABJFBAJFGK();

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MEDIFIIJCIK(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGBFGGFLFPL();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface GCELLPHAFPH
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action BCGCLIKNJON;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action MNMNCNCNHNC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NHABFBDGMDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[Flags]
public enum IIICADJMPPL
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Settings = 1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	LoadCompleted = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	All = 0x1F
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LDJLMGPDHCO : PHKDHEJMAMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public AOIKBHJMDBO GDAJCNKPBDC;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AA90", Offset = "0x5B49490", VA = "0x185B4AA90", Slot = "5")]
	public void AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AAD0", Offset = "0x5B494D0", VA = "0x185B4AAD0", Slot = "4")]
	public void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AB10", Offset = "0x5B49510", VA = "0x185B4AB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct AKLFKNOOHJC : IComparable<AKLFKNOOHJC>, IEquatable<AKLFKNOOHJC>, PHKDHEJMAMA
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly AKLFKNOOHJC EBOAMDEGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly uint FMIGDHLBIKP;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public uint APMFINLAKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xD4B510", Offset = "0xD49F10", VA = "0x180D4B510")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public uint ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1C3FA40", Offset = "0x1C3E440", VA = "0x181C3FA40")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public uint JFPCHLLCAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2961B70", Offset = "0x2960570", VA = "0x182961B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool CJLMDCDHLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5B42310", Offset = "0x5B40D10", VA = "0x185B42310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x86A120", Offset = "0x868B20", VA = "0x18086A120")]
	public static AKLFKNOOHJC DCNFNDJHKLO(uint HNKMHNDGFIO)
	{
		return default(AKLFKNOOHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5B423B0", Offset = "0x5B40DB0", VA = "0x185B423B0")]
	public AKLFKNOOHJC(int CHNNBDJLLJA, int CKEGHBDNJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5B423B0", Offset = "0x5B40DB0", VA = "0x185B423B0")]
	public AKLFKNOOHJC(uint CHNNBDJLLJA, uint CKEGHBDNJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90")]
	private AKLFKNOOHJC(uint FMIGDHLBIKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x13CB770", Offset = "0x13CA170", VA = "0x1813CB770")]
	public static bool NENBKMMGKMN(AKLFKNOOHJC PKEMCIANHMO, AKLFKNOOHJC DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x15A67D0", Offset = "0x15A51D0", VA = "0x1815A67D0")]
	public static bool HCCIHOFGPHE(AKLFKNOOHJC PKEMCIANHMO, AKLFKNOOHJC DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x868560", Offset = "0x866F60", VA = "0x180868560", Slot = "5")]
	public bool Equals(AKLFKNOOHJC OGGLMCNMCLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x5B42220", Offset = "0x5B40C20", VA = "0x185B42220", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xDB1280", Offset = "0xDAFC80", VA = "0x180DB1280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x5B42320", Offset = "0x5B40D20", VA = "0x185B42320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5B42150", Offset = "0x5B40B50", VA = "0x185B42150")]
	public static void CFFNEOCFOHG(FCMEKODKCDO FNNADNFGBNJ, AKLFKNOOHJC MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5B421C0", Offset = "0x5B40BC0", VA = "0x185B421C0")]
	public static AKLFKNOOHJC CONOPAGLNLI(FCMEKODKCDO FNNADNFGBNJ)
	{
		return default(AKLFKNOOHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x5B422A0", Offset = "0x5B40CA0", VA = "0x185B422A0", Slot = "6")]
	public void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5B420E0", Offset = "0x5B40AE0", VA = "0x185B420E0", Slot = "7")]
	public void AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4BB0DA0", Offset = "0x4BAF7A0", VA = "0x184BB0DA0", Slot = "4")]
	public int CompareTo(AKLFKNOOHJC DFHJPOKNFFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public enum NLIKFEONGJB
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Mark = 1,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	GroupBegin = 2,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	GroupEnd = 3,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	EntCreate = 4,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	EntDestroy = 5,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	EntSetParent = 6,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	EntCreateInstance = 7,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	XfmSetLocalPosition = 8,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	XfmSetLocalRotation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	XfmSetLocalScale = 10,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUNT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MAX = 10
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface KMKMAENAPDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct DMEOMGPBNBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Guid CKAFGMOJCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string PDKJCGANJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector3 OAALNDIAAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Quaternion HOOCPOKGFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Vector3 HKGHFAPJIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int FBLEPGOKDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Dictionary<string, object> HKHEDELGBLL;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B43130", Offset = "0x5B41B30", VA = "0x185B43130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate bool IBEEOABNALJ(FIBFBJPKNCP CPLEKHLBDBH, in DHBMIEMIIHO MNIAGKNOHEJ);
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate bool DNIGGLMEDLO<T>(FIBFBJPKNCP CPLEKHLBDBH, in T MNIAGKNOHEJ);
[Cpp2IlInjected.Token(Token = "0x200007A")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface GPJMLDLMFCI
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGMDKKEHOIN(JBNNELNIDOD ILFNNAAOJHE, Type PEFGKHIJHAC, IBEEOABNALJ BIHNFLHANJD);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLCLDEKAPKC(JBNNELNIDOD ILFNNAAOJHE, out IBEEOABNALJ BIHNFLHANJD);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class EHDIFBCOHOE
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class FDPLDBJIJMK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::DNIGGLMEDLO<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public FDPLDBJIJMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x22F8480", Offset = "0x22F6E80", VA = "0x1822F8480")]
	public static void OGMDKKEHOIN<T>(this GPJMLDLMFCI DMALFCEFIJB, JBNNELNIDOD ILFNNAAOJHE, global::DNIGGLMEDLO<T> BIHNFLHANJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B43880", Offset = "0x5B42280", VA = "0x185B43880")]
	public static bool NHNMAHBOADJ(this GPJMLDLMFCI DMALFCEFIJB, FIBFBJPKNCP CPLEKHLBDBH, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO MNIAGKNOHEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct JFEFPKAOHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public OLDOIHNNAEE AJPNMLHDHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ReadOnlyMemory<byte> EONCDECCEBA;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4400", Offset = "0x1FE2E00", VA = "0x181FE4400")]
	public JFEFPKAOHEG(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> EONCDECCEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OLDOIHNNAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public uint CHNNBDJLLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int FPHKIGFPIFO;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
	public OLDOIHNNAEE(uint CHNNBDJLLJA, int FPHKIGFPIFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D160", Offset = "0x5B4BB60", VA = "0x185B4D160")]
	public static bool NENBKMMGKMN(in OLDOIHNNAEE CIEDPJMPBGL, in OLDOIHNNAEE FAJJLJONDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D0D0", Offset = "0x5B4BAD0", VA = "0x185B4D0D0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1398880", Offset = "0x1397280", VA = "0x181398880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D180", Offset = "0x5B4BB80", VA = "0x185B4D180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface GHKAFPPHNFE
{
	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLCMHIMPLMN(int HGBOOPNCHBL);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFNBAMHMOKD(in ReadOnlyMemory<byte> CAADCBIMIIP, out ReadOnlyMemory<byte> FHFLHFNGINK);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDJBPAOPGJM(in ReadOnlyMemory<byte> CAADCBIMIIP, out ReadOnlyMemory<byte> FHFLHFNGINK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface AGPIMFLJMLC : HGHOKJLEPGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface HGHOKJLEPGD
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHEPGLKLJLO(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> EONCDECCEBA);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface BJCHEKJFAPD : HGHOKJLEPGD
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int DAICHCHKOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OLDOIHNNAEE EDMMPHOAJMI();

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMFIICNHENP();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface EKACPKPEDOE
{
	[Cpp2IlInjected.Token(Token = "0x17000114")]
	int ACMIKHOFMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public delegate void OACMBGFEPMN(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> EONCDECCEBA);
[Cpp2IlInjected.Token(Token = "0x2000085")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface JOPCKLGEMKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPJPHGKGNGP(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> EONCDECCEBA);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface FCFANDMHIEM
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	FCMEKODKCDO KDIFAMBJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNDBMODCMFD();

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOAAFONMPLD();

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMFIICNHENP();
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface IAEHENPKCEG
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDOEEOLDMCC(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> MHMFPFMJMPM);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface AMIDHLKBFKD
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOAOHPCEGKC(AKLFKNOOHJC OKAADMJPNLO, in LDJLMGPDHCO NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCIGAKMNPIF(AKLFKNOOHJC OKAADMJPNLO);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHJHLGGEJGG(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class DMHLNBHPAEH
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x22E0ED0", Offset = "0x22DF8D0", VA = "0x1822E0ED0")]
	public static void EHJHLGGEJGG<T>(this AMIDHLKBFKD LHGJJBFKNCG, AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, T MNIAGKNOHEJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface GBJHOKFKJNF
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBFIAGJDIHG();
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface DHGIMBCJOIN
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	uint ELLJEMAPNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface MICBEGMKIKM
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEDABECPIPL();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface BKDLNIFFGNN
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOEIPNLFFDD(AKLFKNOOHJC EFHLICFAAGO, in LDJLMGPDHCO NIPBPKPBPPP, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEEFEBBHPPP(AKLFKNOOHJC EFHLICFAAGO, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGJLHOEJDDB(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ, bool HIFDMDCKIDG);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class PDOHBGONGKC
{
	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2918890", Offset = "0x2917290", VA = "0x182918890")]
	public static void AGJLHOEJDDB<T>(this BKDLNIFFGNN DICLGEOGLMC, AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD OPPPBNFKNOC, T MNIAGKNOHEJ, bool HIFDMDCKIDG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface MMLIDNKEONJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPLKEALEADF(AKLFKNOOHJC OKAADMJPNLO, in LDJLMGPDHCO NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLBPJKMEGLK(AKLFKNOOHJC OKAADMJPNLO);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJLAHBCJAGN(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO OPDCHLGAPDP, in DHBMIEMIIHO ONFBDMEKEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class PIHLCECOJMG
{
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x291E590", Offset = "0x291CF90", VA = "0x18291E590")]
	public static void HJLAHBCJAGN<T>(this MMLIDNKEONJ DICLGEOGLMC, AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD OPPPBNFKNOC, T FAAGLIPDKEL, T ONFBDMEKEAL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface FIBFBJPKNCP
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPNMCNGELLO(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO OPDCHLGAPDP, in DHBMIEMIIHO NKKDJOBIHGN);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIHMNMDMNCL(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, in BOPFHHNILGH OPDCHLGAPDP, in BOPFHHNILGH NKKDJOBIHGN);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHDFHCFAEBH(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOFMIKICDOO(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO NKKDJOBIHGN);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class DHGNBNJMGHL
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x22DC1C0", Offset = "0x22DABC0", VA = "0x1822DC1C0")]
	public static bool GIHMNMDMNCL<T>(this FIBFBJPKNCP OKBFAEKBAFK, AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, out T OPDCHLGAPDP, out T NKKDJOBIHGN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x22DC320", Offset = "0x22DAD20", VA = "0x1822DC320")]
	public static bool OOFMIKICDOO<T>(this FIBFBJPKNCP OKBFAEKBAFK, AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD ILFNNAAOJHE, T NKKDJOBIHGN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface PDDEKMBPLOK
{
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCPLCPGABGA(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, in BOPFHHNILGH MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBAFBPOPDBL(AKLFKNOOHJC AOCEENCOLMM, PGGKBIPLEDG OFPIDICLDMA, [Optional] object CGFEOLDGFLJ);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBNKLMKLJKD(AKLFKNOOHJC AOCEENCOLMM, Span<JBNNELNIDOD> OPPPBNFKNOC, bool FJBLBFMGAPB);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	POPHLPHEEBM LNCOMHGPOAE(AKLFKNOOHJC AOCEENCOLMM, in LDJLMGPDHCO NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAKDAIKDHFD(AKLFKNOOHJC AOCEENCOLMM);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PEBCBPJPKKH(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NHNMAHBOADJ(FIBFBJPKNCP CPLEKHLBDBH, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class ENKMFEPFPCM
{
	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2171CD0", Offset = "0x21706D0", VA = "0x182171CD0")]
	public static T PCPLCPGABGA<T>(this PDDEKMBPLOK GNNMJPOKEFN, AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2171DF0", Offset = "0x21707F0", VA = "0x182171DF0")]
	public static bool PEBCBPJPKKH<T>(this PDDEKMBPLOK GNNMJPOKEFN, AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, T MNIAGKNOHEJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum FIGJEGKDICC
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public delegate void OEOHGIPDCAA(BKDLNIFFGNN DICLGEOGLMC, FCMEKODKCDO FNNADNFGBNJ, AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, bool HIFDMDCKIDG);
[Cpp2IlInjected.Token(Token = "0x2000097")]
public delegate void GAPEKLNJAML<T>(FCMEKODKCDO FNNADNFGBNJ, T MNIAGKNOHEJ) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000098")]
public delegate T NFJCIIMFIEB<T>(FCMEKODKCDO FNNADNFGBNJ) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000099")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface DOHECIMNHKO : global::CCBGOOILJBP<DOHECIMNHKO>
{
	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN ANJJEPIBAGI);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGMDKKEHOIN(JBNNELNIDOD OGGLMCNMCLJ, IOJPBBFOGCI BAMJJNCDPBB);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHPOPCGLBJN(JBNNELNIDOD OGGLMCNMCLJ, out IOJPBBFOGCI BAMJJNCDPBB);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class PAEKBPLIPDE
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2916F40", Offset = "0x2915940", VA = "0x182916F40")]
	public static JBNNELNIDOD MFJEOJEBIAI<T>(this DOHECIMNHKO PDPOLFACNJC, global::BBEGIGBIOHM<T> ANJJEPIBAGI)
	{
		return default(JBNNELNIDOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2917140", Offset = "0x2915B40", VA = "0x182917140")]
	public static JBNNELNIDOD OGMDKKEHOIN<T>(this DOHECIMNHKO PDPOLFACNJC, global::BBEGIGBIOHM<T> ANJJEPIBAGI, IOJPBBFOGCI BAMJJNCDPBB) where T : struct
	{
		return default(JBNNELNIDOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface CAJMDJAFFLI
{
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDNIFDPKFPO<T>(in T MNIAGKNOHEJ, [Optional] object CGFEOLDGFLJ) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface IOJPBBFOGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000117")]
	Type DFGNPGBMDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ, in DHBMIEMIIHO MMPIIAHIKHE);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIOHKMIJCIH(FCMEKODKCDO FNNADNFGBNJ, CAJMDJAFFLI OFPIDICLDMA, [Optional] object CGFEOLDGFLJ);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class MPNCMODFMBC
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface NOKIAPLIPDL
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	bool PAFJEDCBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ACMAGBGDDJN([Optional] CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface GHICFPFLJAF : BKDLNIFFGNN
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface NPNAKJAOKIJ
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CGFACBMJBOK(ReadOnlySpan<byte> MNIAGKNOHEJ, CancellationToken KAKEKEHNCME);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct IDMLAGGFJCC : ISystemStateComponentData, IComponentData, IEquatable<IDMLAGGFJCC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float3 DIJOEKCHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 HPMLHNFJEIP;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B481F0", Offset = "0x5B46BF0", VA = "0x185B481F0", Slot = "4")]
	public bool Equals(IDMLAGGFJCC DFHJPOKNFFB)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Interfaces.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B500F0", Offset = "0x5B4EAF0", VA = "0x185B500F0", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
