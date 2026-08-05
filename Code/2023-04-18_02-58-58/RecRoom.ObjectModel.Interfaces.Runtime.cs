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
public interface PHCICIGDDPA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALCBOOGGMHC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CFOOEEGJILB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CBEAA0", Offset = "0x5CBDCA0", VA = "0x185CBEAA0")]
	public static void ALCBOOGGMHC(this GameObject HKPJJHILEBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NCIOIFNNEKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> HEGDIFHFONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPHBHAKAACD CJDCAFAGCBH(HPHBHAKAACD GGDPNBMCEHC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Entity CJDCAFAGCBH(Entity GGDPNBMCEHC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface LKANKDBMEPH : FGPHKGGABON, MFNEEGAKIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IALMMDHPOBI EOEDHGLEEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MLOAKDLKONO KNPHKPIJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LCMPGMKLFLC EDPPCONEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KIMMKIKOLAA NEHHDIGHMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface MFNEEGAKIKC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OKNMIKICIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NDFCMAINEAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public float3 INLGLHIPOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public quaternion HEGBBJCMANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float3 JDFDFBKKBPO;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface MLOAKDLKONO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IDCJFNFFACN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ACCFFPJFKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int JKHPBEIJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KMHDMCEGGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AJPGDEKAKGN GNFIABACBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PLKCJIPEDIM BDBLDIONDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool APAOPCKHKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NCGOKJIJEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string HFDFHBFHLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ACAKHENDGNL(GameObject BMNLOPDIJGF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IKANJGBCHOA(IEnumerable<GKJFAKANILO> GDKJDDCKGLO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HCIIHJLICJK GNEHKEABMGP(Guid AOFNLFNEJAB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ACPBHPEJKKH MGECIAIDCLM(GKJFAKANILO BEODCPFFPCC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ACPBHPEJKKH MGECIAIDCLM(string PEGANFDBJPA, HCIIHJLICJK MIBPNJCOIHL, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH, Vector3 JDFDFBKKBPO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NJOGHHKGALA(bool BFDBCMGIOBG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JLBICJLGLBP();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AGKPBHGPHJP(GameObject BMNLOPDIJGF, out HCIIHJLICJK MIBPNJCOIHL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NJCOAJBLBCB(GameObject BMNLOPDIJGF, out int GKAPDGEAPAN, out CNKGPKGDJHD FNGBDAJENGB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OCKMJLDPNOJ(GameObject BMNLOPDIJGF, bool DHIHGJKBLHN, bool KFAOIJBOEPG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CGIAPJOCPMM(GameObject BMNLOPDIJGF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task PCOMLEKKAGE();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task LCBGPKHHMGL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NPIMCOFBLHG(object GFCPAMJILIO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JNPPMFBFKML(object GFCPAMJILIO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CKJLOOOHIHJ(object KHKGGNHOCOE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool ANLEABHGKAM(object BBBOEOJJCHM, [Optional] object OHHMJDNAEKG);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DCEFJAMJADE(Transform FGNGGLFNLIP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IGHOBKNFGFF(Transform FGNGGLFNLIP, PPKCAMHKMLL LIHCICHMNHE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AEFPPOHGOCN(Transform FGNGGLFNLIP, LMKFOACECEG IEMMIFODLAI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JLPIEPFJIDO(GameObject BMNLOPDIJGF, MGILGFFDBGH DJJGPBOHDAO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OBLHOONGEAP(GameObject BMNLOPDIJGF, int APFNAOPENNF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool KECPLKANJEB(out Vector3 INLGLHIPOMC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DEEOILGICMI();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CEPKDMGEBIH(GameObject BKBFAHMJCAL, bool FBHDABEFLKL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	CNKGPKGDJHD MIOCIEEKCDD(GameObject HKPJJHILEBG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "35")]
	int BIPFLOEPGLP(GameObject BMNLOPDIJGF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "36")]
	object FHDPJCIGFHA(HPHBHAKAACD EHNNHDBEJOG, GameObject BMNLOPDIJGF, Action<HPHBHAKAACD, int> ONAFALABHKI);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JFMKILDOEEJ(GameObject BMNLOPDIJGF, object OHCNCHBJJIP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JKACEPJEHJN(GameObject BMNLOPDIJGF);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void JPGKLDPJCFK(GNFJJEDLPLM GGDPNBMCEHC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ELKJGNANKPE(GameObject BMNLOPDIJGF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void PGJNLKJFOJP(string OFCFPGACNJB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "42")]
	int AKCFKHIDPNO(GameObject HKPJJHILEBG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void AELIGADFGMN(NativeArray<int> NBMAMFKLAFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DALDICNCFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CBED40", Offset = "0x5CBDF40", VA = "0x185CBED40")]
	public static ACPBHPEJKKH MGECIAIDCLM(this MLOAKDLKONO FPLPHBFOJPL, HCIIHJLICJK EHNNHDBEJOG, Vector3 INLGLHIPOMC, Quaternion HEGBBJCMANH, Vector3 JDFDFBKKBPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface KIMMKIKOLAA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ALJFMIDGDDB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJPNMKKOHCP();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNCHFHCCEFK();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAGKFDBKKAJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHOCKFEHAIH();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOENGPJNKOD();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EJEAHJJADOE(IEnumerable<GKJFAKANILO> GDKJDDCKGLO);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ALDNDHFJDLN();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPFGKOHNMLC();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MJFMJJDNBPG();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EANEPEKPFMA(bool KBMEGKLHBND);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface LCMPGMKLFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ByteString IIADKJHBOIN(out IDisposable KABCFBBDMBC);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBCFAILGGHN(ByteString PCPEJHIMHJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface LHKILEMFMKD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BLBDINABANB EOEDHGLEEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MLOAKDLKONO KNPHKPIJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DGHIBPMIJHM JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GBMEAEPJCNJ ILLFGBFMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	EFDNEMMCCPM OMBLPNIMJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KNMAKEFNGNA EDPPCONEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IKAKIKODLMN KGNKAEJHADC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MPKKBBECOPF PLAPCFBIIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CNBEKDOCLNI NCJCMAENIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IDEMJNMNAMN PGOMDBENJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	AMOFKKLJHLA HHDJKMFNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MBILFEPAMHC HKMHLHOIPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	DGBAPALLGDE JFLMOMMCBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	EINBFFEIBHO OHKONPJMECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OCPAEOMCMPM CDMBEMGJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	APGPGBLMNNP MBNJPHPBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JMILGIFBIEP<TKey> : IDisposable where TKey : struct, IEquatable<TKey>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct BLLCMNNNIKO
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeHashMap<TKey, BLLCMNNNIKO> GHKLFJFOHKO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x23455D0", Offset = "0x23447D0", VA = "0x1823455D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2345610", Offset = "0x2344810", VA = "0x182345610")]
	public JMILGIFBIEP(int FAPOEIDOLFP, Allocator HCEMBCPANJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23454C0", Offset = "0x23446C0", VA = "0x1823454C0")]
	public bool OIACEIIALAO(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2345510", Offset = "0x2344710", VA = "0x182345510")]
	public bool OPHJCIKACBI(TKey FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2345480", Offset = "0x2344680", VA = "0x182345480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2345560", Offset = "0x2344760", VA = "0x182345560")]
	public NativeArray<TKey> PMJAACLKAAO(Allocator HCEMBCPANJM)
	{
		return default(NativeArray<TKey>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public struct GNFJJEDLPLM : IReadOnlyList<HPHBHAKAACD>, IEnumerable<HPHBHAKAACD>, IEnumerable, IReadOnlyCollection<HPHBHAKAACD>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct BCBHPGPHCLI : IEnumerator<HPHBHAKAACD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly FMAHBOCPDMM GLPABBNKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<Entity>.Enumerator LLMPKJJCKGH;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public HPHBHAKAACD DMBDEPMHMNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5CBC2D0", Offset = "0x5CBB4D0", VA = "0x185CBC2D0", Slot = "4")]
			get
			{
				return default(HPHBHAKAACD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5CBC200", Offset = "0x5CBB400", VA = "0x185CBC200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1BFA110", Offset = "0x1BF9310", VA = "0x181BFA110")]
		public BCBHPGPHCLI(FMAHBOCPDMM GLPABBNKNEO, NativeArray<Entity>.Enumerator LLMPKJJCKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC140", Offset = "0x5CBB340", VA = "0x185CBC140", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC180", Offset = "0x5CBB380", VA = "0x185CBC180", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC1C0", Offset = "0x5CBB3C0", VA = "0x185CBC1C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FMAHBOCPDMM GLPABBNKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeArray<Entity> EJIAHCPIPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HPHBHAKAACD POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CC20E0", Offset = "0x5CC12E0", VA = "0x185CC20E0", Slot = "4")]
		get
		{
			return default(HPHBHAKAACD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1D30", Offset = "0x5CC0F30", VA = "0x185CC1D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private int ENOGMPCNCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ODCOGNPDKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OEPEEFKGKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1D80", Offset = "0x5CC0F80", VA = "0x185CC1D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public NativeArray<Entity> JFJGIMNFMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1BFAB90", Offset = "0x1BF9D90", VA = "0x181BFAB90")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2050", Offset = "0x5CC1250", VA = "0x185CC2050")]
	public GNFJJEDLPLM(int FAPOEIDOLFP, FMAHBOCPDMM GLPABBNKNEO, Allocator HCEMBCPANJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9B60", Offset = "0x1BF8D60", VA = "0x181BF9B60")]
	public GNFJJEDLPLM(FMAHBOCPDMM GLPABBNKNEO, NativeArray<Entity> EJIAHCPIPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1FA0", Offset = "0x5CC11A0", VA = "0x185CC1FA0")]
	public GNFJJEDLPLM(GNFJJEDLPLM DPKMEEGECFL, Allocator HCEMBCPANJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1D40", Offset = "0x5CC0F40", VA = "0x185CC1D40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1CA0", Offset = "0x5CC0EA0", VA = "0x185CC1CA0")]
	public BCBHPGPHCLI BECNODPGHJK()
	{
		return default(BCBHPGPHCLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1DC0", Offset = "0x5CC0FC0", VA = "0x185CC1DC0", Slot = "6")]
	private IEnumerator<HPHBHAKAACD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1EB0", Offset = "0x5CC10B0", VA = "0x185CC1EB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DebuggerTypeProxy(typeof(MAOMOAIIBOF))]
public struct HPHBHAKAACD : IComparable<HPHBHAKAACD>, IEquatable<HPHBHAKAACD>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HPHBHAKAACD IGHAJOOKIHP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Entity NOIJKFBLFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7AF900", Offset = "0x7AEB00", VA = "0x1807AF900")]
		[CompilerGenerated]
		readonly get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4E90", Offset = "0x2EC4090", VA = "0x182EC4E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3EC0", Offset = "0x5CC30C0", VA = "0x185CC3EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KNCJAMEBMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3E30", Offset = "0x5CC3030", VA = "0x185CC3E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NHKKABBPFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3FC0", Offset = "0x5CC31C0", VA = "0x185CC3FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4100", Offset = "0x5CC3300", VA = "0x185CC4100")]
	public HPHBHAKAACD(FMAHBOCPDMM GJKIKCBADCF, Entity LHCPLOHKBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
	public DBJMAFIOFFK PPLOHPNLIAE()
	{
		return default(DBJMAFIOFFK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF900", Offset = "0x7AEB00", VA = "0x1807AF900")]
	public static Entity GJGPFJHFLAE(HPHBHAKAACD GBLABNBBAPL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4090", Offset = "0x5CC3290", VA = "0x185CC4090")]
	public static bool IGOCGGBJBII(HPHBHAKAACD NNMPJECKECI, HPHBHAKAACD EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CBEFE0", Offset = "0x5CBE1E0", VA = "0x185CBEFE0")]
	public static bool BHBKJCPJNJN(HPHBHAKAACD NNMPJECKECI, HPHBHAKAACD EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC40E0", Offset = "0x5CC32E0", VA = "0x185CC40E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3F10", Offset = "0x5CC3110", VA = "0x185CC3F10", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1448B70", Offset = "0x1447D70", VA = "0x181448B70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3E60", Offset = "0x5CC3060", VA = "0x185CC3E60", Slot = "4")]
	public int CompareTo(HPHBHAKAACD HNPEBINPOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "5")]
	public bool Equals(HPHBHAKAACD HNPEBINPOBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DKODCPPMJCN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0150", Offset = "0x5CBF350", VA = "0x185CC0150")]
	public static HCIIHJLICJK ANDMDOJLAPG(this HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(HCIIHJLICJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class MAOMOAIIBOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct OBMMNPLGDMK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const uint EELHHMPKJNO = 2147483648u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly FGAJIMHPGCD EBEICGFALNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal readonly FGAJIMHPGCD OGINPOLMPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly uint OJHDPMDDEOP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5CC67A0", Offset = "0x5CC59A0", VA = "0x185CC67A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public uint JNCEIIPHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D170", Offset = "0x2B7C370", VA = "0x182B7D170")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6A90", Offset = "0x5CC5C90", VA = "0x185CC6A90")]
	public OBMMNPLGDMK(FGAJIMHPGCD EBEICGFALNG, FGAJIMHPGCD OGINPOLMPBC, uint OJHDPMDDEOP, bool AOAPFLPCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CC67B0", Offset = "0x5CC59B0", VA = "0x185CC67B0")]
	public bool EMCMLFAPGPN(OBMMNPLGDMK HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CC67F0", Offset = "0x5CC59F0", VA = "0x185CC67F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CGDKNMKPKIP(OOBCCNCEGNI.History)]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal readonly OBMMNPLGDMK IBKGKDECOEG;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PJAJGNFHPGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5CC67A0", Offset = "0x5CC59A0", VA = "0x185CC67A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26F0E20", Offset = "0x26F0020", VA = "0x1826F0E20")]
		internal UndoAction(OBMMNPLGDMK IBKGKDECOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9DB0", Offset = "0x5CC8FB0", VA = "0x185CC9DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CGDKNMKPKIP(OOBCCNCEGNI.History)]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly OBMMNPLGDMK IBKGKDECOEG;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PJAJGNFHPGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5CC67A0", Offset = "0x5CC59A0", VA = "0x185CC67A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x26F0E20", Offset = "0x26F0020", VA = "0x1826F0E20")]
		internal RedoAction(OBMMNPLGDMK IBKGKDECOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9DB0", Offset = "0x5CC8FB0", VA = "0x185CC9DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct NKKFENONCCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	internal readonly uint OJHDPMDDEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal readonly bool FNGPKCONAPD;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6700", Offset = "0x5CC5900", VA = "0x185CC6700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FGAJIMHPGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal int MOHMCFDNHKH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0")]
	public FGAJIMHPGCD(int MOHMCFDNHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5CC15D0", Offset = "0x5CC07D0", VA = "0x185CC15D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum EAIPGNKLHFL
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
public interface ACPBHPEJKKH : KGDFHOFBJJO
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EAIPGNKLHFL MLHPFDHGDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool PJIFOONKJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GameObject BMNLOPDIJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ACPBHPEJKKH> JLBICJLGLBP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(DGHIBPMIJHM PHAHHGAAFFH, HPHBHAKAACD HANPNGMGPBP);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool IOLDCDJPLDG);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JJLJCJHPGDB
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4AD0", Offset = "0x5CC3CD0", VA = "0x185CC4AD0")]
	public static bool FEMFMLHCJLP(this ACPBHPEJKKH MICPPHDEBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4BB0", Offset = "0x5CC3DB0", VA = "0x185CC4BB0")]
	public static bool MNHHKONEENN(this ACPBHPEJKKH MICPPHDEBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4C00", Offset = "0x5CC3E00", VA = "0x185CC4C00")]
	public static bool OLPKLAPPDHO(this ACPBHPEJKKH MICPPHDEBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4B20", Offset = "0x5CC3D20", VA = "0x185CC4B20")]
	public static bool ICJICHLKHIE(this ACPBHPEJKKH MICPPHDEBFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KGDFHOFBJJO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HGIJDEJFJEI : global::ALBPNJDJEPD<HCIIHJLICJK>, CFMFMFJNBJM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JHBGFDOFOMF<T> : global::FMBDPECPAID<HCIIHJLICJK, T>, global::ALBPNJDJEPD<HCIIHJLICJK>, CFMFMFJNBJM, IDisposable, HGIJDEJFJEI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MJKODEONKJC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x13B89C0", Offset = "0x13B7BC0", VA = "0x1813B89C0")]
	public static bool IJDPOKFHBJA<T>(this global::ALBPNJDJEPD<HCIIHJLICJK> IDBLFHOOMPH, HCIIHJLICJK MIBPNJCOIHL, out T IPMIIEAGJKC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x13B89D0", Offset = "0x13B7BD0", VA = "0x1813B89D0")]
	public static bool PLCAKFAMFIL<T>(this global::ALBPNJDJEPD<HCIIHJLICJK> IDBLFHOOMPH, HCIIHJLICJK MIBPNJCOIHL, in T DLEMNBPMGBG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KFBCGBKCDNN : global::ALBPNJDJEPD<HPHBHAKAACD>, CFMFMFJNBJM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NOBICPNOIDE<T> : global::FMBDPECPAID<HPHBHAKAACD, T>, global::ALBPNJDJEPD<HPHBHAKAACD>, CFMFMFJNBJM, IDisposable, KFBCGBKCDNN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class LDNPIIKHOBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x220D670", Offset = "0x220C870", VA = "0x18220D670")]
	public static T HHCPOGCCGNF<T>(this global::ALBPNJDJEPD<HPHBHAKAACD> IDBLFHOOMPH, HPHBHAKAACD EHNNHDBEJOG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x220D770", Offset = "0x220C970", VA = "0x18220D770")]
	public static bool PLCAKFAMFIL<T>(this global::ALBPNJDJEPD<HPHBHAKAACD> IDBLFHOOMPH, HPHBHAKAACD EHNNHDBEJOG, in T DLEMNBPMGBG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GFCMOFDOMMJ : IComparable<GFCMOFDOMMJ>, IEquatable<GFCMOFDOMMJ>
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly GFCMOFDOMMJ IGHAJOOKIHP;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly GFCMOFDOMMJ CCGLPNCJJMM;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly GFCMOFDOMMJ IJFKMLMPNKM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly GFCMOFDOMMJ MAHFEFGMLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly GFCMOFDOMMJ PGJKHKIIGCK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly GFCMOFDOMMJ CHNLJKDLLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int BCGMDEIHEMI;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KEKFBEHOLJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1970", Offset = "0x5CC0B70", VA = "0x185CC1970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0")]
	public GFCMOFDOMMJ(int GMEHLIHLGEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x865EB0", Offset = "0x8650B0", VA = "0x180865EB0")]
	public static bool IGOCGGBJBII(GFCMOFDOMMJ NNMPJECKECI, GFCMOFDOMMJ EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1900", Offset = "0x5CC0B00", VA = "0x185CC1900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1880", Offset = "0x5CC0A80", VA = "0x185CC1880", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x865E70", Offset = "0x865070", VA = "0x180865E70", Slot = "5")]
	public bool Equals(GFCMOFDOMMJ HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xD92D00", Offset = "0xD91F00", VA = "0x180D92D00", Slot = "4")]
	public int CompareTo(GFCMOFDOMMJ HNPEBINPOBO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E10", Offset = "0x7A5010", VA = "0x1807A5E10")]
	public static GFCMOFDOMMJ GJGPFJHFLAE(int GMEHLIHLGEH)
	{
		return default(GFCMOFDOMMJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E10", Offset = "0x7A5010", VA = "0x1807A5E10")]
	public static int GJGPFJHFLAE(GFCMOFDOMMJ CHIEJFHOPDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1980", Offset = "0x5CC0B80", VA = "0x185CC1980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct DBJMAFIOFFK : IEquatable<DBJMAFIOFFK>, KGDFHOFBJJO
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly DBJMAFIOFFK ADAPMOOKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600", Slot = "6")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PLDNGPACMIH DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(PLDNGPACMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DENFCDHNAGC ILLFGBFMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DENFCDHNAGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GameObject BMNLOPDIJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF7A0", Offset = "0x5CBE9A0", VA = "0x185CBF7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HCIIHJLICJK GOBLGMKIAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF530", Offset = "0x5CBE730", VA = "0x185CBF530")]
		get
		{
			return default(HCIIHJLICJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JGDLLGICJJP CMIIJGJABEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF8A0", Offset = "0x5CBEAA0", VA = "0x185CBF8A0")]
		get
		{
			return default(JGDLLGICJJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CNKGPKGDJHD EIADAKNKJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF250", Offset = "0x5CBE450", VA = "0x185CBF250")]
		get
		{
			return default(CNKGPKGDJHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool NBKKJIPHLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF230", Offset = "0x5CBE430", VA = "0x185CBF230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool BCDNCMPAHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF4F0", Offset = "0x5CBE6F0", VA = "0x185CBF4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool IIGLIDPAOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF510", Offset = "0x5CBE710", VA = "0x185CBF510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool GHEOMEKLDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF760", Offset = "0x5CBE960", VA = "0x185CBF760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KHLOPDKPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF780", Offset = "0x5CBE980", VA = "0x185CBF780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool HEMAFACHFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF030", Offset = "0x5CBE230", VA = "0x185CBF030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool BGBKGLMHPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF050", Offset = "0x5CBE250", VA = "0x185CBF050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IBNMIOFHJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF380", Offset = "0x5CBE580", VA = "0x185CBF380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public BDIPKNNGDEN CGIOKCMHPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(BDIPKNNGDEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public FJNLJCBKCKP DOBGBNHMJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(FJNLJCBKCKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CAPIAMLEFGN HHDJKMFNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(CAPIAMLEFGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public EDMBFBJIJJA KFBOKNHGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(EDMBFBJIJJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public BIEMMEJOFMC NCJCMAENIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(BIEMMEJOFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JCPBLLCDLGO OJKJKEBAAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(JCPBLLCDLGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public MGLKJGICKPJ BNFLPGDEKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(MGLKJGICKPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool FEMFMLHCJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CBF410", Offset = "0x5CBE610", VA = "0x185CBF410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool EIMMPBDOLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public DBJMAFIOFFK(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCEF0", Offset = "0x5CBC0F0", VA = "0x185CBCEF0")]
	public static bool GJGPFJHFLAE(DBJMAFIOFFK IPMIIEAGJKC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
	public static HPHBHAKAACD GJGPFJHFLAE(DBJMAFIOFFK IPMIIEAGJKC)
	{
		return default(HPHBHAKAACD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10")]
	public static bool IGOCGGBJBII(DBJMAFIOFFK NNMPJECKECI, DBJMAFIOFFK EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CBEFE0", Offset = "0x5CBE1E0", VA = "0x185CBEFE0")]
	public static bool BHBKJCPJNJN(DBJMAFIOFFK NNMPJECKECI, DBJMAFIOFFK EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF180", Offset = "0x5CBE380", VA = "0x185CBF180", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(DBJMAFIOFFK HNPEBINPOBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
	public static DBJMAFIOFFK GJGPFJHFLAE(HPHBHAKAACD FLKGABKFAPI)
	{
		return default(DBJMAFIOFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CBEF80", Offset = "0x5CBE180", VA = "0x185CBEF80")]
	public CCHAJLMBAFD ANKMCFCKJIP()
	{
		return default(CCHAJLMBAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF970", Offset = "0x5CBEB70", VA = "0x185CBF970")]
	public BOOKKDFKHEC POCLGEBJDHJ()
	{
		return default(BOOKKDFKHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF600", Offset = "0x5CBE800", VA = "0x185CBF600")]
	public CJFJLIBCADD MAHIFEFADLH()
	{
		return default(CJFJLIBCADD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF320", Offset = "0x5CBE520", VA = "0x185CBF320")]
	public HMEJANCBHEK GFLAPLNMGBK()
	{
		return default(HMEJANCBHEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF660", Offset = "0x5CBE860", VA = "0x185CBF660")]
	public PAOFKDGAONA MEDJKNKEDCK()
	{
		return default(PAOFKDGAONA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF0A0", Offset = "0x5CBE2A0", VA = "0x185CBF0A0")]
	public void DDGNNJCHMPH([Optional] object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF3A0", Offset = "0x5CBE5A0", VA = "0x185CBF3A0")]
	public bool KMOEKAMFDFB(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF6F0", Offset = "0x5CBE8F0", VA = "0x185CBF6F0")]
	public bool NIPPIJKNOFO(object IALNODEHBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF9E0", Offset = "0x5CBEBE0", VA = "0x185CBF9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct MGLKJGICKPJ : IEquatable<MGLKJGICKPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CC60D0", Offset = "0x5CC52D0", VA = "0x185CC60D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private EINBFFEIBHO NAPMAOHCBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC62F0", Offset = "0x5CC54F0", VA = "0x185CC62F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool GAHJEFOONOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5E20", Offset = "0x5CC5020", VA = "0x185CC5E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Guid PENGDHINDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5AB0", Offset = "0x5CC4CB0", VA = "0x185CC5AB0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool BGCOMFEFMMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6210", Offset = "0x5CC5410", VA = "0x185CC6210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Guid EOJGBOJCNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5CC59C0", Offset = "0x5CC4BC0", VA = "0x185CC59C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public MGLKJGICKPJ(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5BA0", Offset = "0x5CC4DA0", VA = "0x185CC5BA0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(MGLKJGICKPJ HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6120", Offset = "0x5CC5320", VA = "0x185CC6120")]
	public bool KEOODBJEIIM(out Guid GLLFFIFLOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5FE0", Offset = "0x5CC51E0", VA = "0x185CC5FE0")]
	public void JGMOKMHAFHK(Guid DGAGNFOEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CC58D0", Offset = "0x5CC4AD0", VA = "0x185CC58D0")]
	public bool AGMBHECIJAE(out Guid KKBFAENPLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5D30", Offset = "0x5CC4F30", VA = "0x185CC5D30")]
	public void HEMBEKEAHGB(Guid DGAGNFOEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5F00", Offset = "0x5CC5100", VA = "0x185CC5F00")]
	public bool ILFFNACOIKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5C50", Offset = "0x5CC4E50", VA = "0x185CC5C50")]
	public void FFPBNIBKPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PAOFKDGAONA : IEquatable<PAOFKDGAONA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6E50", Offset = "0x5CC6050", VA = "0x185CC6E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private OCPAEOMCMPM BGDBOGNPMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6EA0", Offset = "0x5CC60A0", VA = "0x185CC6EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float3 KAAODHLKEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6F20", Offset = "0x5CC6120", VA = "0x185CC6F20")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public quaternion IIKKJFEJAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6CB0", Offset = "0x5CC5EB0", VA = "0x185CC6CB0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DBJMAFIOFFK OONOPMILDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6BB0", Offset = "0x5CC5DB0", VA = "0x185CC6BB0")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public PAOFKDGAONA(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
	public static HPHBHAKAACD GJGPFJHFLAE(PAOFKDGAONA IPMIIEAGJKC)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6DA0", Offset = "0x5CC5FA0", VA = "0x185CC6DA0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(PAOFKDGAONA HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct CCHAJLMBAFD : IEquatable<CCHAJLMBAFD>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly CCHAJLMBAFD ADAPMOOKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PLDNGPACMIH DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(PLDNGPACMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DENFCDHNAGC ILLFGBFMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DENFCDHNAGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE5E0", Offset = "0x5CBD7E0", VA = "0x185CBE5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private GBMEAEPJCNJ PLFEIEMHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE630", Offset = "0x5CBD830", VA = "0x185CBE630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GNFJJEDLPLM HCHBKPMPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE4E0", Offset = "0x5CBD6E0", VA = "0x185CBE4E0")]
		get
		{
			return default(GNFJJEDLPLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<DBJMAFIOFFK> NCLNEDAIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE250", Offset = "0x5CBD450", VA = "0x185CBE250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<DBJMAFIOFFK> NELNEPENNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE6B0", Offset = "0x5CBD8B0", VA = "0x185CBE6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int LAGCNLOMINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE170", Offset = "0x5CBD370", VA = "0x185CBE170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int GIKKAPCPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE490", Offset = "0x5CBD690", VA = "0x185CBE490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string PALADLMJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE0C0", Offset = "0x5CBD2C0", VA = "0x185CBE0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public CCHAJLMBAFD(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCEF0", Offset = "0x5CBC0F0", VA = "0x185CBCEF0")]
	public static bool GJGPFJHFLAE(CCHAJLMBAFD IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CBE3C0", Offset = "0x5CBD5C0", VA = "0x185CBE3C0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(CCHAJLMBAFD HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
	public static DBJMAFIOFFK GJGPFJHFLAE(CCHAJLMBAFD FMPHDMAKDKP)
	{
		return default(DBJMAFIOFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5CBE470", Offset = "0x5CBD670", VA = "0x185CBE470")]
	public bool GIFOGKHOLIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CBE7F0", Offset = "0x5CBD9F0", VA = "0x185CBE7F0")]
	public GNFJJEDLPLM OKAPEFBNBPC(Allocator HCEMBCPANJM)
	{
		return default(GNFJJEDLPLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct AEMDBBKOHFB : IEquatable<AEMDBBKOHFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF60", Offset = "0x5CBB160", VA = "0x185CBBF60", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(AEMDBBKOHFB HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct FJNLJCBKCKP : IEquatable<FJNLJCBKCKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public FJNLJCBKCKP(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1700", Offset = "0x5CC0900", VA = "0x185CC1700", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(FJNLJCBKCKP HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1630", Offset = "0x5CC0830", VA = "0x185CC1630")]
	public void DPHICADNPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CC17B0", Offset = "0x5CC09B0", VA = "0x185CC17B0")]
	public void JIMJGJIDNNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct CJFJLIBCADD : IEquatable<CJFJLIBCADD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public CJFJLIBCADD(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBEBF0", Offset = "0x5CBDDF0", VA = "0x185CBEBF0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(CJFJLIBCADD HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct MEKMLIDMKPM : IEquatable<MEKMLIDMKPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5780", Offset = "0x5CC4980", VA = "0x185CC5780", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(MEKMLIDMKPM HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct BLGGEKAIKLL : IEquatable<BLGGEKAIKLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5CBD310", Offset = "0x5CBC510", VA = "0x185CBD310", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(BLGGEKAIKLL HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AMJHOOIILNB : IEquatable<AMJHOOIILNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC090", Offset = "0x5CBB290", VA = "0x185CBC090", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(AMJHOOIILNB HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DENFCDHNAGC : IEquatable<DENFCDHNAGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5CBFF80", Offset = "0x5CBF180", VA = "0x185CBFF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private GBMEAEPJCNJ PLFEIEMHGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5CBFFD0", Offset = "0x5CBF1D0", VA = "0x185CBFFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public HPHBHAKAACD KEKHMGGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5CBFCD0", Offset = "0x5CBEED0", VA = "0x185CBFCD0")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public DBJMAFIOFFK HKAHNOCIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5CBFBC0", Offset = "0x5CBEDC0", VA = "0x185CBFBC0")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DBJMAFIOFFK CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0050", Offset = "0x5CBF250", VA = "0x185CC0050")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public DENFCDHNAGC(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5CBFDC0", Offset = "0x5CBEFC0", VA = "0x185CBFDC0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(DENFCDHNAGC HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBFE70", Offset = "0x5CBF070", VA = "0x185CBFE70")]
	public bool HMBNJDPGAJN(DBJMAFIOFFK HHFDFFDPCGO, bool GBDGBMCMBHI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBFAD0", Offset = "0x5CBECD0", VA = "0x185CBFAD0")]
	public bool BAPHEPNKIJH(DBJMAFIOFFK MIONKFPACCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct BDIPKNNGDEN : IEquatable<BDIPKNNGDEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public string HGHLBCLFGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC360", Offset = "0x5CBB560", VA = "0x185CBC360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string BIIMMHFNGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC6A0", Offset = "0x5CBB8A0", VA = "0x185CBC6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public BDIPKNNGDEN(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC5F0", Offset = "0x5CBB7F0", VA = "0x185CBC5F0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(BDIPKNNGDEN HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct NAJGKHGICDG : IEquatable<NAJGKHGICDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6370", Offset = "0x5CC5570", VA = "0x185CC6370", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(NAJGKHGICDG HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct CAPIAMLEFGN : IEquatable<CAPIAMLEFGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private APGPGBLMNNP MBNJPHPBJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5CBE050", Offset = "0x5CBD250", VA = "0x185CBE050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public float EHLCHKMKGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDD30", Offset = "0x5CBCF30", VA = "0x185CBDD30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Vector3 CMPGKEOHLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDBB0", Offset = "0x5CBCDB0", VA = "0x185CBDBB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public CAPIAMLEFGN(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBDE60", Offset = "0x5CBD060", VA = "0x185CBDE60", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(CAPIAMLEFGN HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5CBDF10", Offset = "0x5CBD110", VA = "0x185CBDF10")]
	public bool HCPAIKONJJB(out Collider ADMCDJKKCIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct EDMBFBJIJJA : IEquatable<EDMBFBJIJJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0BF0", Offset = "0x5CBFDF0", VA = "0x185CC0BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private GNJOOJLEHCD NJGLHDEMBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC09D0", Offset = "0x5CBFBD0", VA = "0x185CC09D0")]
		get
		{
			return default(GNJOOJLEHCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool FHDCDOJMPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0B80", Offset = "0x5CBFD80", VA = "0x185CC0B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool MHHKDEDLDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0F90", Offset = "0x5CC0190", VA = "0x185CC0F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool COOKOGODEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0B10", Offset = "0x5CBFD10", VA = "0x185CC0B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool HLNAAGBDKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5CC08F0", Offset = "0x5CBFAF0", VA = "0x185CC08F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool EIBJOMIHALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0460", Offset = "0x5CBF660", VA = "0x185CC0460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool DOKNFMLHGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5CC06F0", Offset = "0x5CBF8F0", VA = "0x185CC06F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool LPNPNKNAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0540", Offset = "0x5CBF740", VA = "0x185CC0540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool AGMDNHPCFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0760", Offset = "0x5CBF960", VA = "0x185CC0760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PIEIAAGANCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5CC07D0", Offset = "0x5CBF9D0", VA = "0x185CC07D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CNBECICLFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0AA0", Offset = "0x5CBFCA0", VA = "0x185CC0AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool AKDDNAPJMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0680", Offset = "0x5CBF880", VA = "0x185CC0680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool LIMEDIEEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5CC04D0", Offset = "0x5CBF6D0", VA = "0x185CC04D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool KFFDPKNLNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0960", Offset = "0x5CBFB60", VA = "0x185CC0960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KKMEMHIMMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0E50", Offset = "0x5CC0050", VA = "0x185CC0E50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0A30", Offset = "0x5CBFC30", VA = "0x185CC0A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool NFLCGAPBBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0DE0", Offset = "0x5CBFFE0", VA = "0x185CC0DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LIEILDDHIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC05B0", Offset = "0x5CBF7B0", VA = "0x185CC05B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 BNHMHOOFJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0D20", Offset = "0x5CBFF20", VA = "0x185CC0D20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool PPGHDENALIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0EB0", Offset = "0x5CC00B0", VA = "0x185CC0EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public EDMBFBJIJJA(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0840", Offset = "0x5CBFA40", VA = "0x185CC0840", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(EDMBFBJIJJA HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1000", Offset = "0x5CC0200", VA = "0x185CC1000")]
	public bool PINFEOJLFPE(PAGFBHMIHAM NCJCLJGCIMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5CC0C40", Offset = "0x5CBFE40", VA = "0x185CC0C40")]
	public void KOHKICGDDFL(PAGFBHMIHAM NCJCLJGCIMF, bool OBFHBDLKFPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct HMEJANCBHEK : IEquatable<HMEJANCBHEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private CJCPBBGOJPP MGELICMIFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3D70", Offset = "0x5CC2F70", VA = "0x185CC3D70")]
		get
		{
			return default(CJCPBBGOJPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public CBKNPKNKCOO IJCBDEPAFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3DD0", Offset = "0x5CC2FD0", VA = "0x185CC3DD0")]
		get
		{
			return default(CBKNPKNKCOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public HMEJANCBHEK(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3CC0", Offset = "0x5CC2EC0", VA = "0x185CC3CC0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(HMEJANCBHEK HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3C10", Offset = "0x5CC2E10", VA = "0x185CC3C10")]
	public EAEIAPNPECI DNKEPIIOOMM()
	{
		return default(EAEIAPNPECI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct EAEIAPNPECI : IEquatable<EAEIAPNPECI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private HPJHNFINEOP ECCOLDFLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0370", Offset = "0x5CBF570", VA = "0x185CC0370")]
		get
		{
			return default(HPJHNFINEOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GCALDJOLPHE NFJABKPKDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5CC0250", Offset = "0x5CBF450", VA = "0x185CC0250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public EAEIAPNPECI(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC02C0", Offset = "0x5CBF4C0", VA = "0x185CC02C0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(EAEIAPNPECI HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct JCPBLLCDLGO : IEquatable<JCPBLLCDLGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4340", Offset = "0x5CC3540", VA = "0x185CC4340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public JCPBLLCDLGO(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4150", Offset = "0x5CC3350", VA = "0x185CC4150", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(JCPBLLCDLGO HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4200", Offset = "0x5CC3400", VA = "0x185CC4200")]
	public void HOIGBGNFADA(bool IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4390", Offset = "0x5CC3590", VA = "0x185CC4390")]
	public void PDDJMDKFHON(bool IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct BIEMMEJOFMC : IEquatable<BIEMMEJOFMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD150", Offset = "0x5CBC350", VA = "0x185CBD150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private CNBEKDOCLNI EANFAJGNPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CBCC90", Offset = "0x5CBBE90", VA = "0x185CBCC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EFAMJNCIJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5CBCAB0", Offset = "0x5CBBCB0", VA = "0x185CBCAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool CMFLMPFMDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC780", Offset = "0x5CBB980", VA = "0x185CBC780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GCEGKKPGLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC750", Offset = "0x5CBB950", VA = "0x185CBC750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool GDGEHDFCINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5CBCF30", Offset = "0x5CBC130", VA = "0x185CBCF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool DPMKPCHDKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5CBCB90", Offset = "0x5CBBD90", VA = "0x185CBCB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool HLDGIHEPLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD1A0", Offset = "0x5CBC3A0", VA = "0x185CBD1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool ABNDBJMAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC880", Offset = "0x5CBBA80", VA = "0x185CBC880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public BIEMMEJOFMC(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCEF0", Offset = "0x5CBC0F0", VA = "0x185CBCEF0")]
	public static bool GJGPFJHFLAE(BIEMMEJOFMC IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCE40", Offset = "0x5CBC040", VA = "0x185CBCE40", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(BIEMMEJOFMC HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCF60", Offset = "0x5CBC160", VA = "0x185CBCF60")]
	public bool JJDEIGIJPFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCD10", Offset = "0x5CBBF10", VA = "0x185CBCD10")]
	public DBJMAFIOFFK DLFAHIDLBEF(DBJMAFIOFFK GFCPAMJILIO)
	{
		return default(DBJMAFIOFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCF90", Offset = "0x5CBC190", VA = "0x185CBCF90")]
	public HPHBHAKAACD JPIHHPCKFCI()
	{
		return default(HPHBHAKAACD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct BOOKKDFKHEC : IEquatable<BOOKKDFKHEC>
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly BOOKKDFKHEC ADAPMOOKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PLDNGPACMIH DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(PLDNGPACMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private ALPEGHAAMJD ONLIEEJBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD710", Offset = "0x5CBC910", VA = "0x185CBD710")]
		get
		{
			return default(ALPEGHAAMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DJHGJHOJPIM FICPFOJBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD3C0", Offset = "0x5CBC5C0", VA = "0x185CBD3C0")]
		get
		{
			return default(DJHGJHOJPIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public LFKHAHOCIEA NMGCKJOHLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDB50", Offset = "0x5CBCD50", VA = "0x185CBDB50")]
		get
		{
			return default(LFKHAHOCIEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public AMLLOBJBMGK EBGLIDMNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD490", Offset = "0x5CBC690", VA = "0x185CBD490")]
		get
		{
			return default(AMLLOBJBMGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public LPHMIKOKCPK KPJCOOGLFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD7E0", Offset = "0x5CBC9E0", VA = "0x185CBD7E0")]
		get
		{
			return default(LPHMIKOKCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public KGHPJHLCKAG OHPPOFOLCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDA10", Offset = "0x5CBCC10", VA = "0x185CBDA10")]
		get
		{
			return default(KGHPJHLCKAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD420", Offset = "0x5CBC620", VA = "0x185CBD420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public INNDHCKIDAD LJDLKAAOHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD8E0", Offset = "0x5CBCAE0", VA = "0x185CBD8E0")]
		get
		{
			return default(INNDHCKIDAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD9A0", Offset = "0x5CBCBA0", VA = "0x185CBD9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MEHBAOACGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDA70", Offset = "0x5CBCC70", VA = "0x185CBDA70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD630", Offset = "0x5CBC830", VA = "0x185CBD630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 GLGFHKOKCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD4F0", Offset = "0x5CBC6F0", VA = "0x185CBD4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public float KICAFNMBEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDAD0", Offset = "0x5CBCCD0", VA = "0x185CBDAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ShapeConfigData.Flags GPDLABDIKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD6B0", Offset = "0x5CBC8B0", VA = "0x185CBD6B0")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD770", Offset = "0x5CBC970", VA = "0x185CBD770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public BOOKKDFKHEC(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCEF0", Offset = "0x5CBC0F0", VA = "0x185CBCEF0")]
	public static bool GJGPFJHFLAE(BOOKKDFKHEC IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CBD580", Offset = "0x5CBC780", VA = "0x185CBD580", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(BOOKKDFKHEC HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBD880", Offset = "0x5CBCA80", VA = "0x185CBD880")]
	public MAIEHBDIIPL KJJHKEHPBFB()
	{
		return default(MAIEHBDIIPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5CBD940", Offset = "0x5CBCB40", VA = "0x185CBD940")]
	public HHHGBHBOEAD LPAJHBPJEBI()
	{
		return default(HHHGBHBOEAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct MAIEHBDIIPL : IEquatable<MAIEHBDIIPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public BOOKKDFKHEC OIGLIODJABF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(BOOKKDFKHEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private NPFFBGHJIGL AICAMFLPHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CC56C0", Offset = "0x5CC48C0", VA = "0x185CC56C0")]
		get
		{
			return default(NPFFBGHJIGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public HAGCJKKHBBM OBFLIFIOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5720", Offset = "0x5CC4920", VA = "0x185CC5720")]
		get
		{
			return default(HAGCJKKHBBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public MAIEHBDIIPL(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCEF0", Offset = "0x5CBC0F0", VA = "0x185CBCEF0")]
	public static bool GJGPFJHFLAE(MAIEHBDIIPL IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5610", Offset = "0x5CC4810", VA = "0x185CC5610", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(MAIEHBDIIPL HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DefaultMember("Item")]
public readonly struct HHHGBHBOEAD : IEquatable<HHHGBHBOEAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public PLDNGPACMIH DHGHIDOLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(PLDNGPACMIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CC33C0", Offset = "0x5CC25C0", VA = "0x185CC33C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private IKAKIKODLMN KGNKAEJHADC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CC30B0", Offset = "0x5CC22B0", VA = "0x185CC30B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public BOOKKDFKHEC OIGLIODJABF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(BOOKKDFKHEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public FCILLPHFLHB DLAHEAEMFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3410", Offset = "0x5CC2610", VA = "0x185CC3410")]
		get
		{
			return default(FCILLPHFLHB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3210", Offset = "0x5CC2410", VA = "0x185CC3210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public IEnumerable<LKOMCMKAJJM> PMNILIDIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3A30", Offset = "0x5CC2C30", VA = "0x185CC3A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public LKOMCMKAJJM POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3910", Offset = "0x5CC2B10", VA = "0x185CC3910")]
		get
		{
			return default(LKOMCMKAJJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3130", Offset = "0x5CC2330", VA = "0x185CC3130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public HHHGBHBOEAD(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CBCEF0", Offset = "0x5CBC0F0", VA = "0x185CBCEF0")]
	public static bool GJGPFJHFLAE(HHHGBHBOEAD IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3310", Offset = "0x5CC2510", VA = "0x185CC3310", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(HHHGBHBOEAD HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3510", Offset = "0x5CC2710", VA = "0x185CC3510")]
	public LKOMCMKAJJM MMKCGEKAABF(Vector3? INLGLHIPOMC, [Optional] Quaternion? HEGBBJCMANH, [Optional] Vector3? JDFDFBKKBPO)
	{
		return default(LKOMCMKAJJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CC36A0", Offset = "0x5CC28A0", VA = "0x185CC36A0")]
	public LKOMCMKAJJM MMKCGEKAABF()
	{
		return default(LKOMCMKAJJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3820", Offset = "0x5CC2A20", VA = "0x185CC3820")]
	public void PDJCDCJJNPH(int GMEHLIHLGEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct LKOMCMKAJJM : IEquatable<LKOMCMKAJJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public HPHBHAKAACD GGFLINHGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xE7E600", Offset = "0xE7D800", VA = "0x180E7E600")]
		get
		{
			return default(HPHBHAKAACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public HHHGBHBOEAD IBCFLKDJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5330", Offset = "0x5CC4530", VA = "0x185CC5330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public float3 KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4EB0", Offset = "0x5CC40B0", VA = "0x185CC4EB0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5020", Offset = "0x5CC4220", VA = "0x185CC5020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public quaternion NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5110", Offset = "0x5CC4310", VA = "0x185CC5110")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4FA0", Offset = "0x5CC41A0", VA = "0x185CC4FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float3 IBAAELLOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CC52A0", Offset = "0x5CC44A0", VA = "0x185CC52A0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5470", Offset = "0x5CC4670", VA = "0x185CC5470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public PJACOCAIIAH AJJCKEFBNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5500", Offset = "0x5CC4700", VA = "0x185CC5500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private OBDGJOIIDPM IANHDMJOEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5CC53B0", Offset = "0x5CC45B0", VA = "0x185CC53B0")]
		get
		{
			return default(OBDGJOIIDPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private GFLOCLKFGFM EMMGIEJJAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5240", Offset = "0x5CC4440", VA = "0x185CC5240")]
		get
		{
			return default(GFLOCLKFGFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private BCLGPHIBHLJ MHOKOCFMNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5CC50B0", Offset = "0x5CC42B0", VA = "0x185CC50B0")]
		get
		{
			return default(BCLGPHIBHLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private EHMLAGDLEFH KFFDABHHAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5410", Offset = "0x5CC4610", VA = "0x185CC5410")]
		get
		{
			return default(EHMLAGDLEFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private EJOAGIILJLC FNPILCHLDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4F40", Offset = "0x5CC4140", VA = "0x185CC4F40")]
		get
		{
			return default(EJOAGIILJLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public LKOMCMKAJJM(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5190", Offset = "0x5CC4390", VA = "0x185CC5190", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(LKOMCMKAJJM HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5330", Offset = "0x5CC4530", VA = "0x185CC5330")]
	public void PPHHFLNGDHG(HHHGBHBOEAD IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5020", Offset = "0x5CC4220", VA = "0x185CC5020")]
	public void DAHMNDIEKOJ(float3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4FA0", Offset = "0x5CC41A0", VA = "0x185CC4FA0")]
	public void CCIMDIMBMEJ(quaternion IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct PLDNGPACMIH : IEquatable<PLDNGPACMIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HPHBHAKAACD FLKGABKFAPI;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public DBJMAFIOFFK EBCMHCLDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5CBC030", Offset = "0x5CBB230", VA = "0x185CBC030")]
		get
		{
			return default(DBJMAFIOFFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private FMAHBOCPDMM EFPODGDKADC
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private EFDNEMMCCPM FNFBEOJCBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8300", Offset = "0x5CC7500", VA = "0x185CC8300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool GCNJJMNHBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8670", Offset = "0x5CC7870", VA = "0x185CC8670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 KIJJFLMPGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7060", Offset = "0x5CC6260", VA = "0x185CC7060")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7FB0", Offset = "0x5CC71B0", VA = "0x185CC7FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion NELEDPLLGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7B90", Offset = "0x5CC6D90", VA = "0x185CC7B90")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8F40", Offset = "0x5CC8140", VA = "0x185CC8F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Vector3 ABELHODFPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9C60", Offset = "0x5CC8E60", VA = "0x185CC9C60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8CB0", Offset = "0x5CC7EB0", VA = "0x185CC8CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Quaternion MIDFMPBGHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8B60", Offset = "0x5CC7D60", VA = "0x185CC8B60")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5CC71B0", Offset = "0x5CC63B0", VA = "0x185CC71B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float FDENPIIEFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8370", Offset = "0x5CC7570", VA = "0x185CC8370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 IBAAELLOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7D90", Offset = "0x5CC6F90", VA = "0x185CC7D90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9390", Offset = "0x5CC8590", VA = "0x185CC9390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 DDDOMPOHDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7440", Offset = "0x5CC6640", VA = "0x185CC7440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 KHLPNDCAGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC88C0", Offset = "0x5CC7AC0", VA = "0x185CC88C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Matrix4x4 ACABEODONJC
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC94E0", Offset = "0x5CC86E0", VA = "0x185CC94E0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x192FF80", Offset = "0x192F180", VA = "0x18192FF80")]
	public PLDNGPACMIH(HPHBHAKAACD EHNNHDBEJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC010", Offset = "0x5CBB210", VA = "0x185CBC010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7CE0", Offset = "0x5CC6EE0", VA = "0x185CC7CE0", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBF10", Offset = "0x5CBB110", VA = "0x185CBBF10", Slot = "4")]
	public bool Equals(PLDNGPACMIH HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBC050", Offset = "0x5CBB250", VA = "0x185CBC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9320", Offset = "0x5CC8520", VA = "0x185CC9320")]
	public NCANNFMMHDJ MHMGJDBMFJP()
	{
		return default(NCANNFMMHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC98D0", Offset = "0x5CC8AD0", VA = "0x185CC98D0")]
	public RigidTransform OLCPEINIHHH()
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9A30", Offset = "0x5CC8C30", VA = "0x185CC9A30")]
	public void OLCPEINIHHH(out Vector3 ADJINPMOILO, out Quaternion LLJPMBHCKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8440", Offset = "0x5CC7640", VA = "0x185CC8440")]
	public void GOLAGHCCLGF(out Vector3 EGJKEDKNNAD, out Quaternion IBHAEICNMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5CC81B0", Offset = "0x5CC73B0", VA = "0x185CC81B0")]
	public Vector3 GALIDLPMDIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5CC78F0", Offset = "0x5CC6AF0", VA = "0x185CC78F0")]
	public void DAHMNDIEKOJ(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8520", Offset = "0x5CC7720", VA = "0x185CC8520")]
	public Vector3 HIOOMKMFAEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5CC91D0", Offset = "0x5CC83D0", VA = "0x185CC91D0")]
	public void MHCIPMAEJHH(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7A40", Offset = "0x5CC6C40", VA = "0x185CC7A40")]
	public Quaternion DIBFIDPIMBO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7590", Offset = "0x5CC6790", VA = "0x185CC7590")]
	public void CCIMDIMBMEJ(Quaternion IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9080", Offset = "0x5CC8280", VA = "0x185CC9080")]
	public Quaternion LNEBNHNAFJL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8E00", Offset = "0x5CC8000", VA = "0x185CC8E00")]
	public void LCGLLJKOBHG(Quaternion IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8100", Offset = "0x5CC7300", VA = "0x185CC8100")]
	public float FOMNBFLBFHN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC76D0", Offset = "0x5CC68D0", VA = "0x185CC76D0")]
	public void CHMABLGOIJL(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC86C0", Offset = "0x5CC78C0", VA = "0x185CC86C0")]
	public float IHPDJPNINJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7EE0", Offset = "0x5CC70E0", VA = "0x185CC7EE0")]
	public void FHPENJKEEBM(float IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9B10", Offset = "0x5CC8D10", VA = "0x185CC9B10")]
	public void OMOHCCEOCEO(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC77A0", Offset = "0x5CC69A0", VA = "0x185CC77A0")]
	public Vector3 CLLDHEOIHOG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9780", Offset = "0x5CC8980", VA = "0x185CC9780")]
	public void OHLPFAEGBCE(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8A10", Offset = "0x5CC7C10", VA = "0x185CC8A10")]
	public Vector3 KDEIALMOCID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9630", Offset = "0x5CC8830", VA = "0x185CC9630")]
	public void OGNICNBBMCJ(Vector3 IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5CC72F0", Offset = "0x5CC64F0", VA = "0x185CC72F0")]
	public Vector3 BFGFDDADEDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8770", Offset = "0x5CC7970", VA = "0x185CC8770")]
	public void JGKNOBBJHNB(Vector3 IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class PCPDAIKHJBK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct IFDDPLCHKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Guid JMIFIJDBMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public COEDGMMIBLH CKHGBLBCMOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct COEDGMMIBLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int IPMIIEAGJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int FEHFEJEGMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int IOMEDMKFKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int KNGANOGPDOJ;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5CBECA0", Offset = "0x5CBDEA0", VA = "0x185CBECA0")]
		public bool MCAPBOCFAMP(out HCIIHJLICJK MIBPNJCOIHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5CBED20", Offset = "0x5CBDF20", VA = "0x185CBED20")]
		public COEDGMMIBLH(HCIIHJLICJK MIBPNJCOIHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7040", Offset = "0x5CC6240", VA = "0x185CC7040")]
	public static Guid JEFGHAKNIEM(this HCIIHJLICJK MIBPNJCOIHL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7020", Offset = "0x5CC6220", VA = "0x185CC7020")]
	public static bool HOAEIJHDDOM(this Guid JMIFIJDBMNM, out HCIIHJLICJK MIBPNJCOIHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal static class HDJKJJECGFO
{
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2430", Offset = "0x5CC1630", VA = "0x185CC2430")]
	public static DGHIBPMIJHM JCJGOFJEAMC(this HPHBHAKAACD IKHNIJKGJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC24A0", Offset = "0x5CC16A0", VA = "0x185CC24A0")]
	public static EntityManager KBDBPGCEONM(this HPHBHAKAACD IKHNIJKGJFD)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x226F4C0", Offset = "0x226E6C0", VA = "0x18226F4C0")]
	public static T AELDMOLLHGB<T>(this HPHBHAKAACD IKHNIJKGJFD) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x226F460", Offset = "0x226E660", VA = "0x18226F460")]
	public static bool ABCHCNLGCGF<T>(this HPHBHAKAACD IKHNIJKGJFD) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface CBKODGDOCOH
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Guid IEPLDIMNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHGPBJNJGMD(Guid EAHJDNJHMMP, Guid BILLJKNHJPG);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MKFPKDFEGIP(HPHBHAKAACD DKPDAEGCGOM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface EINBFFEIBHO
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGCOMFEFMMH(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAHJEFOONOH(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEOODBJEIIM(HPHBHAKAACD EHNNHDBEJOG, out Guid GLLFFIFLOAG);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid EHBGLDJHJDP(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGMOKMHAFHK(HPHBHAKAACD EHNNHDBEJOG, Guid GLLFFIFLOAG);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AGMBHECIJAE(HPHBHAKAACD EHNNHDBEJOG, out Guid KKBFAENPLID);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid ANANIBBDAHN(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HEMBEKEAHGB(HPHBHAKAACD EHNNHDBEJOG, Guid KKBFAENPLID);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ILFFNACOIKA(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FFPBNIBKPKF(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DIGINCDEJIN(HPHBHAKAACD AAFNLLCIFBP, HPHBHAKAACD HHFDFFDPCGO);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface OCPAEOMCMPM
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	Func<KEEAFCDJANP> NIMCAGONIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HPHBHAKAACD, HPHBHAKAACD> DCCMBGCMHLA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HPHBHAKAACD, HPHBHAKAACD> LHPMHJJNDJJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<HPHBHAKAACD, HPHBHAKAACD, HPHBHAKAACD> ANBLDJAHFLM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<HPHBHAKAACD> KOFMAOKOPGK;

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HPHBHAKAACD OMKNFCHFCOL(HPHBHAKAACD EHNNHDBEJOG, int BPBJFGFFFPK);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Color GLOOJNEBOPK(HPHBHAKAACD EHNNHDBEJOG, int BPBJFGFFFPK);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 OBLHOONGEAP(HPHBHAKAACD EHNNHDBEJOG, int BPBJFGFFFPK);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PBBNMDMDELB(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD PFEBBONNCEI);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HPHBHAKAACD MFNLLJHOJJL(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<HPHBHAKAACD> PPAHCGDHGEO(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HPHBHAKAACD CNJKGJDMLFO(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IKHBKMODIJM(HPHBHAKAACD EHNNHDBEJOG, Vector3 GJGMLLFCOAD, Quaternion FLINFHACPCC);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NDGLBMLNJHA(HPHBHAKAACD EHNNHDBEJOG, out RigidTransform EDOPNMHALFL);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 GGEOIKLDDPB(PAOFKDGAONA BGDMKGJPDBD);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	quaternion LAKLCPPGIDG(PAOFKDGAONA BGDMKGJPDBD);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class INMDHNNHIDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface BPDKAHOMBHL
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	object NKHNIHGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPGKLDPJCFK(GNFJJEDLPLM GGDPNBMCEHC);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KEEAFCDJANP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	Entity LLLEAGDJICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	Entity GBBACMKCINL
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
	void HJGFEDOGLMH(float3 BAGMHHCMNNF);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONEJCALFHKB(float3 BAGMHHCMNNF);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMMIKHABGMD(out float3 EBEICGFALNG, out float3 OGINPOLMPBC);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGGLFGCDIKM(float3 EBEICGFALNG, float3 OGINPOLMPBC);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AINCGHHLEKH(Color EBEICGFALNG, Color OGINPOLMPBC);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KEEAFCDJANP Instantiate(Transform FGNGGLFNLIP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DIHHKGEEOEF
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHEKMEOIBOI(Transform FGNGGLFNLIP, KEEAFCDJANP KMLCALDBFGK);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KEEAFCDJANP NIMCAGONIOD();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface PJLDDPKOLDE
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	Guid IEPLDIMNDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDEDGIJHLDK(Guid GLLFFIFLOAG, Guid KKBFAENPLID, string KNOPFGAGMCN);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface GBMEAEPJCNJ
{
	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPHBHAKAACD DMOICBPEOLI(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPHBHAKAACD FONBPFGIHGB(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMBNJDPGAJN(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD HHFDFFDPCGO, bool GBDGBMCMBHI);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ACEDFEGBPAB(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD HHFDFFDPCGO);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IDHBDBMGFID(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GNFJJEDLPLM BCILFEBJLHL(HPHBHAKAACD FLKGABKFAPI);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NLKLELJEKDK(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IHEBNKKPFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BAPHEPNKIJH(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD MIONKFPACCE);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HPHBHAKAACD INDFLLMAOHH(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GDHBJPCNPAN(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC, out HPHBHAKAACD LCFGMFPMPCN);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NIOFDBLKODA
{
	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5CC65F0", Offset = "0x5CC57F0", VA = "0x185CC65F0")]
	public static bool LLNINBLBFFN(this GBMEAEPJCNJ HKPONLMBIIB, HPHBHAKAACD EHNNHDBEJOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface IDEMJNMNAMN
{
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UndoAction OALDIOFDAAO();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	RedoAction MEMHFKACBBA(UndoAction GFCPAMJILIO);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	UndoAction IGOOBJPABCM(RedoAction GFCPAMJILIO);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable KDNNCEJPDKJ();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface ACCGKJEOBEB
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool MFCCFFPEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface FMAHBOCPDMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	LHKILEMFMKD FIFLKDCJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<HPHBHAKAACD, CNKGPKGDJHD> LDLKENKALDH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<HPHBHAKAACD> HMAFJEGIFHG;

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JGDLLGICJJP ABHILIGPOAO(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CNKGPKGDJHD KIFHAIDEHFN(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNAKCAAHHPA(HCIIHJLICJK MIBPNJCOIHL, ACPBHPEJKKH MICPPHDEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DBJMAFIOFFK DDGNNJCHMPH(HPHBHAKAACD EHNNHDBEJOG, [Optional] object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MLOGCIOJFGP(HPHBHAKAACD EHNNHDBEJOG, out ACPBHPEJKKH MICPPHDEBFL);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AGBINPBGJOB(ACPBHPEJKKH MICPPHDEBFL);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BGEAIJHMDMH(HPHBHAKAACD EHNNHDBEJOG, out Transform FGNGGLFNLIP);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FEMFMLHCJLP(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KMOEKAMFDFB(Entity LHCPLOHKBCE, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NIPPIJKNOFO(Entity LHCPLOHKBCE, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HPHBHAKAACD ADIDIKPFHIK(HCIIHJLICJK MIBPNJCOIHL);

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HCIIHJLICJK ANDMDOJLAPG(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DBJMAFIOFFK CCGLPNCJJMM(CNKGPKGDJHD FNGBDAJENGB, bool GFHAAPIGHIF);

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DBJMAFIOFFK CCGLPNCJJMM(CNKGPKGDJHD FNGBDAJENGB);

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DBJMAFIOFFK NFOGFCJILOM(CNKGPKGDJHD FNGBDAJENGB);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DBJMAFIOFFK OADPHDJIIGP(HCIIHJLICJK MIBPNJCOIHL, CNKGPKGDJHD FNGBDAJENGB);

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CCHAJLMBAFD OBAIKOPBHAP();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HHHGBHBOEAD JFFGKANLKKJ();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MAIEHBDIIPL MEMDCEONKOF(HAGCJKKHBBM HPLLCKFCOCM);

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DPHICADNPGH(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DANFAKHLGOC(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JIMJGJIDNNL(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NativeArray<(HPHBHAKAACD, HPHBHAKAACD)> CLKBEFKLIOC(NativeArray<HPHBHAKAACD> KLBGBDPJKJM, Allocator HCEMBCPANJM);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool NHKKABBPFMM(HPHBHAKAACD EHNNHDBEJOG);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HDMMJGCKIIH
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC26C0", Offset = "0x5CC18C0", VA = "0x185CC26C0")]
	public static bool BGEAIJHMDMH(this FMAHBOCPDMM GLPABBNKNEO, Entity LHCPLOHKBCE, out Transform FGNGGLFNLIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2C70", Offset = "0x5CC1E70", VA = "0x185CC2C70")]
	public static DBJMAFIOFFK KLIHLLAPIOO(this FMAHBOCPDMM GLPABBNKNEO, Entity LHCPLOHKBCE)
	{
		return default(DBJMAFIOFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2550", Offset = "0x5CC1750", VA = "0x185CC2550")]
	public static HPHBHAKAACD ADIDIKPFHIK(this FMAHBOCPDMM GLPABBNKNEO, Entity LHCPLOHKBCE)
	{
		return default(HPHBHAKAACD);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC25B0", Offset = "0x5CC17B0", VA = "0x185CC25B0")]
	public static HCIIHJLICJK ANDMDOJLAPG(this FMAHBOCPDMM GLPABBNKNEO, Entity LHCPLOHKBCE)
	{
		return default(HCIIHJLICJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2E50", Offset = "0x5CC2050", VA = "0x185CC2E50")]
	public static bool NHKKABBPFMM(this FMAHBOCPDMM GLPABBNKNEO, HCIIHJLICJK MIBPNJCOIHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2D10", Offset = "0x5CC1F10", VA = "0x185CC2D10")]
	public static CCHAJLMBAFD NGCJIEEMPDG(this FMAHBOCPDMM GLPABBNKNEO, RigidTransform LFDBEEJGILN, [Optional] object IALNODEHBNN)
	{
		return default(CCHAJLMBAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2B30", Offset = "0x5CC1D30", VA = "0x185CC2B30")]
	public static MAIEHBDIIPL KAMFJJAPAII(this FMAHBOCPDMM GLPABBNKNEO, HAGCJKKHBBM GEMFNAKGAEI, RigidTransform LFDBEEJGILN, [Optional] object IALNODEHBNN)
	{
		return default(MAIEHBDIIPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CC27E0", Offset = "0x5CC19E0", VA = "0x185CC27E0")]
	public static HHHGBHBOEAD IDJAKDMNHHC(this FMAHBOCPDMM GLPABBNKNEO, RigidTransform LFDBEEJGILN, [Optional] object IALNODEHBNN)
	{
		return default(HHHGBHBOEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2FA0", Offset = "0x5CC21A0", VA = "0x185CC2FA0")]
	private static void PJHMADCFBOA(DBJMAFIOFFK BAJMPEGNGGE, RigidTransform LFDBEEJGILN, [Optional] object IALNODEHBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2920", Offset = "0x5CC1B20", VA = "0x185CC2920")]
	internal static EAEIAPNPECI IMMGFLCGNKE(this FMAHBOCPDMM GLPABBNKNEO, GCALDJOLPHE HKPGBGBJNID, [Optional] object IALNODEHBNN)
	{
		return default(EAEIAPNPECI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface AMOFKKLJHLA
{
	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HPHBHAKAACD, IOBENKLLONM> DPLCFKMACEM;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CIFKFPIACKF(HPHBHAKAACD EHNNHDBEJOG, out Collider ADMCDJKKCIA);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGCCKHLANPB(HPHBHAKAACD EHNNHDBEJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface CNBEKDOCLNI
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool NEDBNEJNCML
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	HPHBHAKAACD ADDFEGOCCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	DBJMAFIOFFK KANOFNBOLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	DBJMAFIOFFK NNNBFIFNHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MFGDFMIFIGG FKGJCGANBPC;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HPHBHAKAACD INDFLLMAOHH(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GDHBJPCNPAN(HPHBHAKAACD IHEBNKKPFLJ, HPHBHAKAACD NBOGDLHPFJC, out HPHBHAKAACD LCFGMFPMPCN);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MHLBJJGEBMP();

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LNAJOFELJGG();

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EFAMJNCIJCP(HPHBHAKAACD GFCPAMJILIO);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void MFGDFMIFIGG(DBJMAFIOFFK JCNEOMGJFBL, DBJMAFIOFFK APOPENKHGDL);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EGHMOLFBAMD
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5CC14B0", Offset = "0x5CC06B0", VA = "0x185CC14B0")]
	public static bool HLNBPDNFGJL(this CNBEKDOCLNI KLPFPLFLOKD, DBJMAFIOFFK GFCPAMJILIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1080", Offset = "0x5CC0280", VA = "0x185CC1080")]
	public static bool BKFEFDDFOPA(this CNBEKDOCLNI KLPFPLFLOKD, HPHBHAKAACD GFCPAMJILIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5CC13C0", Offset = "0x5CC05C0", VA = "0x185CC13C0")]
	public static bool DPMKPCHDKDM(this CNBEKDOCLNI KLPFPLFLOKD, HPHBHAKAACD GFCPAMJILIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface APGPGBLMNNP
{
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPJGOJKPNKJ(HPHBHAKAACD EHNNHDBEJOG, AEPAMCILECN IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEPAMCILECN CPJGOANNMJM(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDJNLHIMONE(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFCNILODFON(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IDHBDBMGFID(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPHBHAKAACD LADEPLKBNAJ(HPHBHAKAACD EHNNHDBEJOG, int GMEHLIHLGEH);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBJNPLCDNJF(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGHECGHAHKM(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN, HPHBHAKAACD IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJAHCGGIIAI(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HLMHFGGPCMG(HPHBHAKAACD EHNNHDBEJOG, out HPHBHAKAACD IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IAILMMHIPKD(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LHOHDDIHCMH(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KAIBLONLEMF(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DKKHDIICHIF(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NANOMGOMOMK(HPHBHAKAACD EHNNHDBEJOG, float3 HFDCPHCEPFP);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IJPMJPOBMAP(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OGLCICJFMJG(HPHBHAKAACD EHNNHDBEJOG, quaternion LNJNMDKKOIK);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BDBDBPPNLJN(HPHBHAKAACD EHNNHDBEJOG, out quaternion LNJNMDKKOIK);

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NCPHJKFMPLP(HPHBHAKAACD EHNNHDBEJOG, out float3 IPMIIEAGJKC, out quaternion LNJNMDKKOIK);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DDAPJOFALFP(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ELFGEDNJOHG(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float3 CMKCECKOJDE(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KEDJCFDKLAO(HPHBHAKAACD EHNNHDBEJOG, float3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float GGHCAIBPPPB(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IMILCKKKLDJ(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float APCBLGMFNNL(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KCLPHGPBFDD(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool BMDPIOBCEOF(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EHDNGJHICCN(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode BBHICCDMIFA(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AKBFIGPDPJN(HPHBHAKAACD EHNNHDBEJOG, CollisionDetectionMode IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HHLALPMEMBB HOGJJDNADNP(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ELAJLMOAJAA(HPHBHAKAACD EHNNHDBEJOG, HHLALPMEMBB IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PPDMHENLJKC(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void DHPOFPJGDDJ(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	HPHBHAKAACD DMOICBPEOLI(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IOJGOGBBBID(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	HPHBHAKAACD FONBPFGIHGB(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HMBNJDPGAJN(HPHBHAKAACD EHNNHDBEJOG, HPHBHAKAACD IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	MGFMFIIFDMD NOALHDPHGKG(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void LCMMOJICDNP(HPHBHAKAACD EHNNHDBEJOG, MGFMFIIFDMD BGNILMBFPPE);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool OFEKMPDHJBE(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void LPDEOIDAPMA(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool NHOHKAJPMCF(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GOLEGNPABKP(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool PLKFMDOHIDP(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void ADKABFNFOFB(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints EFACEONLCII(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void BNPIBPBPNJJ(HPHBHAKAACD EHNNHDBEJOG, RigidbodyConstraints IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float EPJIGOPKPLJ(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void NDOLIFDNNNK(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float PFHNGKICJNG(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void BCIGBIKMDBM(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool FBGGENNDMPM(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void LCNHEEJHCED(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool EJLNGPPPAIP(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GDEFKJEDPPO(HPHBHAKAACD EHNNHDBEJOG, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int GEPGKPGDJJL(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void PFDJCCMOIFP(HPHBHAKAACD EHNNHDBEJOG, int IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Rigidbody HNIOLIALEDA(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EKJPDKGKBJN(HPHBHAKAACD EHNNHDBEJOG, Rigidbody FNBMGBEMKPE);

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object POICFMLBOGJ(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void KGFBOGLIPPA(HPHBHAKAACD EHNNHDBEJOG, object IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "63")]
	object NNICFMOMNEA(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AIICIANDKMJ(HPHBHAKAACD EHNNHDBEJOG, object IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "65")]
	float IEDDPADLONC(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void FGCECCNOHHA(HPHBHAKAACD EHNNHDBEJOG, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void PKLMIPICLLK(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void HOJNIFMBFPG(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "69")]
	bool HPJCMOMNJJH(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void NMECDPHOCAF(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void PFBMFGOOPAJ(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool DEKCADMNEAF(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void HHFDBEGAOCA(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void HNCPNLIICFC(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool FNKCDILFPMO(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void GIOPKNLCCBA(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void IIDIBDNJFAB(HPHBHAKAACD EHNNHDBEJOG, object IALNODEHBNN);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "78")]
	bool PABAHAFNIGD(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "79")]
	IEnumerable<object> IENENNBOKAF(HPHBHAKAACD EHNNHDBEJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface FPOFHEKDION
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNMMHOMBDMC(HPHBHAKAACD EHNNHDBEJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface LECDHLNJOEO
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	LMKFOACECEG JNFIBPBCNCD
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
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface AGGPPPAPABE
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNCFLLMJPFG(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBBCCHEHOAG(HPHBHAKAACD EHNNHDBEJOG, Transform FGNGGLFNLIP);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface DGBAPALLGDE
{
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOIGBGNFADA(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDDJMDKFHON(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface IKAKIKODLMN
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<HPHBHAKAACD> KMNABEBBBIK(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPHBHAKAACD OPGMOHIDPFL(HPHBHAKAACD EHNNHDBEJOG, int GMEHLIHLGEH);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DNGBIEGCECA(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCILLPHFLHB EKGNDHHKMGK(HPHBHAKAACD EHNNHDBEJOG);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPNJEPENEBD(HPHBHAKAACD EHNNHDBEJOG, FCILLPHFLHB HMJOKPKOPCN);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPHBHAKAACD ANKDFLBBJOM(HPHBHAKAACD EHNNHDBEJOG, [Optional] Vector3? INLGLHIPOMC, [Optional] Quaternion? HEGBBJCMANH, [Optional] Vector3? JDFDFBKKBPO);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHIKBCLEFPO(HPHBHAKAACD EHNNHDBEJOG, int GMEHLIHLGEH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface AEOPHBOKNJI
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJNKIGLGIIC();

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEFHGBFEACM();

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJEPIJINDON();

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPACPCLKKJF();

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBHENKHGBHG();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PCODEBEMIBB();

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GDPHKOCOMJI();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MFIBFLOKJKG();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPBNOMFGFBE();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EOOLFFNBHLF();

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGFKENHCNCI();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface EFDNEMMCCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIMDMKNAADM(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAHMNDIEKOJ(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Vector3 GALIDLPMDIJ(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCIMDIMBMEJ(Entity LHCPLOHKBCE, Quaternion IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Quaternion DIBFIDPIMBO(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDNBMELGOGH(Entity LHCPLOHKBCE, out Vector3 INLGLHIPOMC, out Quaternion HEGBBJCMANH);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBBGBLNGHNF(Entity LHCPLOHKBCE, out Vector3 INLGLHIPOMC, out Quaternion HEGBBJCMANH);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector3 JDMEKEJNKID(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OMOHCCEOCEO(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CHMABLGOIJL(Entity LHCPLOHKBCE, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float FOMNBFLBFHN(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OGNICNBBMCJ(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Vector3 KDEIALMOCID(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MHCIPMAEJHH(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Vector3 HIOOMKMFAEI(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LCGLLJKOBHG(Entity LHCPLOHKBCE, Quaternion IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Quaternion LNEBNHNAFJL(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 CLLDHEOIHOG(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OHLPFAEGBCE(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FHPENJKEEBM(Entity LHCPLOHKBCE, float IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float IHPDJPNINJD(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JGKNOBBJHNB(Entity LHCPLOHKBCE, Vector3 IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Vector3 BFGFDDADEDE(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GLECOPJMCMG(Entity LHCPLOHKBCE, out Matrix4x4 OMHDLHAHJCK);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MCGIOOEPIDG(Entity LHCPLOHKBCE, in Matrix4x4 OMHDLHAHJCK);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MKBDAOGLDNJ(Entity LHCPLOHKBCE, out Matrix4x4 OMHDLHAHJCK);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool BGEAIJHMDMH(Entity LHCPLOHKBCE, out Transform FGNGGLFNLIP);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CJDAFAFEAIC(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BNMDIPAOMFL(Entity LHCPLOHKBCE, Entity FLHBBDGHDCM, Entity BDBBMBMDCFP);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class CGLOKLPKDPA
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface MBILFEPAMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMCJGPGHPPH(HPHBHAKAACD FLKGABKFAPI, bool IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface DGHIBPMIJHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	NNHDOGKABEI JCJGOFJEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	DKCBHGMJMEO GHECNMHOJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	EntityManager KBDBPGCEONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	bool ICJICHLKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase BFGAGKFLBOH(Type NIFOGEBEDNG);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class CFFKOFOJKGN
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBE9F0", Offset = "0x5CBDBF0", VA = "0x185CBE9F0")]
	public static World EDAMOJICJJG(this DGHIBPMIJHM HIJDILOKICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1152EA0", Offset = "0x11520A0", VA = "0x181152EA0")]
	public static T BFGAGKFLBOH<T>(this DGHIBPMIJHM HIJDILOKICJ) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface OHHINBMLFAA : AAKFCNNNLEL
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKNJLMLFPKH MLEHOKPOHJC(Entity LHCPLOHKBCE);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLFMLIAKMFJ(NativeArray<EKNJLMLFPKH> OBDCNEMMCJC, NativeArray<DBFJJBPOONO> DBPFJELGIGI);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEEDFOICKPB(EKNJLMLFPKH PLFCHHKILCM);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OGHENDLJIOJ(EKNJLMLFPKH PLFCHHKILCM, out Collider ADMCDJKKCIA);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface AAKFCNNNLEL
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHDIAAGJBJI(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, Allocator HCEMBCPANJM, out NativeArray<Entity> EJIAHCPIPFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface MPKKBBECOPF
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHDIAAGJBJI(in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, float GKJHODLJDHD, out GGLOEKDBMCM BBOLIJMGKDH, out Entity EGHGAHNDMAA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[OHBLGBNBPGG(IHBBGOJDEFH.LoadInstance)]
public interface GNAIBKODMII
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHDIAAGJBJI(in NativeArray<Entity> EJIAHCPIPFJ, in float3 EDGHCIEJHLG, in float3 HLFIBIDOLEF, in NativeArray<GGLOEKDBMCM> HDNIHMEOOJD);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct EKNJLMLFPKH : global::ECNPNPKOHHG<EKNJLMLFPKH>, ONMCCIDPEOK, IEquatable<EKNJLMLFPKH>
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int BCGMDEIHEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public int OLGKJALIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x18C7A20", Offset = "0x18C6C20", VA = "0x1818C7A20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1530", Offset = "0x5CC0730", VA = "0x185CC1530", Slot = "8")]
	public bool Equals(EKNJLMLFPKH HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1580", Offset = "0x5CC0780", VA = "0x185CC1580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct GGLOEKDBMCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float DAMOGGANOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float3 CHEKLLFMKBP;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface PBKJFIBPHPK
{
	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string ECNPIJJFGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	PBKJFIBPHPK HLKBCFCIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	IEnumerable<PBKJFIBPHPK> ICAFHKPCPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface MELJJCPNELB
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	PBKJFIBPHPK KFHJECENHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	List<KFBCGBKCDNN> IMPKGELLDBK
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ODJDDAKCLIP(KFBCGBKCDNN IDBLFHOOMPH, out PBKJFIBPHPK CIFHMNKCLNG);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface IIEGBNJCKEO : IEnumerable<NDGJEHEDOED>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	NDGJEHEDOED POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	NDGJEHEDOED POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NDGJEHEDOED KKIABONBAGM(JECBEPMPMHJ OPCKJKNEHGA);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ OPCKJKNEHGA);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class DHAALKKMDJG
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	public static global::KMBPFGIABCP<T> KKIABONBAGM<T>(this IIEGBNJCKEO BBBOEOJJCHM, JECBEPMPMHJ KNOPFGAGMCN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[DefaultMember("Item")]
public interface CCAADMLFLBF : IEnumerable<HGIJDEJFJEI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	HGIJDEJFJEI POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HGIJDEJFJEI KKIABONBAGM(JECBEPMPMHJ OPCKJKNEHGA);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ OPCKJKNEHGA);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class FOILHPCDIFA
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	public static global::JHBGFDOFOMF<T> KKIABONBAGM<T>(this CCAADMLFLBF BBBOEOJJCHM, JECBEPMPMHJ KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x149AF20", Offset = "0x149A120", VA = "0x18149AF20")]
	public static global::JHBGFDOFOMF<T> KKIABONBAGM<T>(this CCAADMLFLBF BBBOEOJJCHM, global::LEMPDKIOGJO<T> KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x149AC20", Offset = "0x1499E20", VA = "0x18149AC20")]
	public static GFCMOFDOMMJ HINDCPDHIJG<T>(this CCAADMLFLBF BBBOEOJJCHM, global::LEMPDKIOGJO<T> KNOPFGAGMCN) where T : struct
	{
		return default(GFCMOFDOMMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
[DefaultMember("Item")]
public interface BPDDKPBGCMN : IEnumerable<KFBCGBKCDNN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int BPIIJGBNBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	KFBCGBKCDNN POFBPBHJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KFBCGBKCDNN KKIABONBAGM(JECBEPMPMHJ OPCKJKNEHGA);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class HPHHNIHMHEP
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2276EB0", Offset = "0x22760B0", VA = "0x182276EB0")]
	public static global::NOBICPNOIDE<T> KKIABONBAGM<T>(this BPDDKPBGCMN BBBOEOJJCHM, JECBEPMPMHJ KNOPFGAGMCN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2276D60", Offset = "0x2275F60", VA = "0x182276D60")]
	public static global::NOBICPNOIDE<T> KKIABONBAGM<T>(this BPDDKPBGCMN BBBOEOJJCHM, global::LEMPDKIOGJO<T> KNOPFGAGMCN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface BCHEBEJHIBE
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJLIAMIICOC(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPCBHIOIPOJ(HCIIHJLICJK MIBPNJCOIHL, Span<GFCMOFDOMMJ> BBBOEOJJCHM, bool LJAANIMCAKA);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface KNMAKEFNGNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool AFKIDFCDNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOGAKOGIFFE(bool BFDBCMGIOBG);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KJEDDNOFLEJ(bool BFDBCMGIOBG);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ByteString IIADKJHBOIN(out IDisposable KABCFBBDMBC);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPEPHLCNLOH();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BBCFAILGGHN(ByteString KPEMNJPDMIK, ABKDLOMDPKF PANELIGGJGM = ABKDLOMDPKF.All);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JOENGPJNKOD();

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EJEAHJJADOE(IEnumerable<GKJFAKANILO> GDKJDDCKGLO);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ALDNDHFJDLN();

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MJFMJJDNBPG();

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EANEPEKPFMA(bool KBMEGKLHBND);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface IIBDPIPACMB
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ByteString AIBJBMGLFMD();

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGLNBMALNKN();

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MICFFOHBDMO(IEnumerable<GKJFAKANILO> GDKJDDCKGLO);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALDNDHFJDLN();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[OHBLGBNBPGG(IHBBGOJDEFH.Application)]
public interface DAHJGPKAIEK
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action HNCHFHCCEFK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action NDAEHHPCPMN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KAFOLEIAEPB;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[Flags]
public enum ABKDLOMDPKF
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
public struct LHNKALDLHDD : LLPAFDMOEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public CNKGPKGDJHD FNGBDAJENGB;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4DA0", Offset = "0x5CC3FA0", VA = "0x185CC4DA0", Slot = "5")]
	public void BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4DE0", Offset = "0x5CC3FE0", VA = "0x185CC4DE0", Slot = "4")]
	public void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4E20", Offset = "0x5CC4020", VA = "0x185CC4E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HCIIHJLICJK : IComparable<HCIIHJLICJK>, IEquatable<HCIIHJLICJK>, LLPAFDMOEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly HCIIHJLICJK IGHAJOOKIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly uint ODBGNNDKAMK;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public uint KPDIAABIMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCA90", Offset = "0x8CBC90", VA = "0x1808CCA90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public uint LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1BDB9E0", Offset = "0x1BDABE0", VA = "0x181BDB9E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public uint OLKBPBDDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3360", Offset = "0x8C2560", VA = "0x1808C3360")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool PJAJGNFHPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x22E3820", Offset = "0x22E2A20", VA = "0x1822E3820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool BENEKNKBHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2310", Offset = "0x5CC1510", VA = "0x185CC2310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E10", Offset = "0x7A5010", VA = "0x1807A5E10")]
	public static HCIIHJLICJK GNHBPDABPEL(uint DFLMOPOGPOK)
	{
		return default(HCIIHJLICJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2420", Offset = "0x5CC1620", VA = "0x185CC2420")]
	public HCIIHJLICJK(int AFLLDBEPJII, int INHMDHJILFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2420", Offset = "0x5CC1620", VA = "0x185CC2420")]
	public HCIIHJLICJK(uint AFLLDBEPJII, uint INHMDHJILFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x865EA0", Offset = "0x8650A0", VA = "0x180865EA0")]
	private HCIIHJLICJK(uint ODBGNNDKAMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x865EB0", Offset = "0x8650B0", VA = "0x180865EB0")]
	public static bool IGOCGGBJBII(HCIIHJLICJK NNMPJECKECI, HCIIHJLICJK EFNJCAIBDLA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x865EC0", Offset = "0x8650C0", VA = "0x180865EC0")]
	public static bool BHBKJCPJNJN(HCIIHJLICJK NNMPJECKECI, HCIIHJLICJK EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x865E70", Offset = "0x865070", VA = "0x180865E70", Slot = "5")]
	public bool Equals(HCIIHJLICJK IKHNIJKGJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2220", Offset = "0x5CC1420", VA = "0x185CC2220", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2419F00", Offset = "0x2419100", VA = "0x182419F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2390", Offset = "0x5CC1590", VA = "0x185CC2390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC22A0", Offset = "0x5CC14A0", VA = "0x185CC22A0")]
	public static void FNFCABPAEJF(LGCEMMAIGML ALCBODINOLM, HCIIHJLICJK IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC21C0", Offset = "0x5CC13C0", VA = "0x185CC21C0")]
	public static HCIIHJLICJK BEECPJCJDAA(LGCEMMAIGML ALCBODINOLM)
	{
		return default(HCIIHJLICJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2320", Offset = "0x5CC1520", VA = "0x185CC2320", Slot = "6")]
	public void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2150", Offset = "0x5CC1350", VA = "0x185CC2150", Slot = "7")]
	public void BBCFAILGGHN(LGCEMMAIGML ALCBODINOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4A2AF40", Offset = "0x4A2A140", VA = "0x184A2AF40", Slot = "4")]
	public int CompareTo(HCIIHJLICJK HNPEBINPOBO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public enum ICDFPFFNIEP
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
public interface CFMAAJNLCIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GKJFAKANILO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Guid JMIFIJDBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string PEGANFDBJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector3 INLGLHIPOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Quaternion HEGBBJCMANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Vector3 JDFDFBKKBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int CHMFPFHLENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Dictionary<string, object> HMJOKPKOPCN;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CC1B00", Offset = "0x5CC0D00", VA = "0x185CC1B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate bool ECJHBFPIFBA(FAAFLFNFNCP NGJEDKCNODL, in NFKEKJGDLJI IPMIIEAGJKC);
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate bool ABAMLODDMJB<T>(FAAFLFNFNCP NGJEDKCNODL, in T IPMIIEAGJKC);
[Cpp2IlInjected.Token(Token = "0x200007A")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface CKPGAFBPNIH
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNAKCAAHHPA(GFCMOFDOMMJ CHIEJFHOPDP, Type JLKBHACBDKM, ECJHBFPIFBA IJOOBFMHDJI);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJJBAMDMMFJ(GFCMOFDOMMJ CHIEJFHOPDP, out ECJHBFPIFBA IJOOBFMHDJI);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class OKAGIIAJCNE
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class NEHGFLPPJCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::ABAMLODDMJB<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public NEHGFLPPJCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x20520F0", Offset = "0x20512F0", VA = "0x1820520F0")]
	public static void BNAKCAAHHPA<T>(this CKPGAFBPNIH BDIJLBAAEHA, GFCMOFDOMMJ CHIEJFHOPDP, global::ABAMLODDMJB<T> IJOOBFMHDJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6AB0", Offset = "0x5CC5CB0", VA = "0x185CC6AB0")]
	public static bool GGHDKCJIIBH(this CKPGAFBPNIH BDIJLBAAEHA, FAAFLFNFNCP NGJEDKCNODL, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI IPMIIEAGJKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct IMGPICEEMGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public KKNKFLFFIBB FDAIMOMOHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ReadOnlyMemory<byte> KHKGGNHOCOE;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x1BFA370", Offset = "0x1BF9570", VA = "0x181BFA370")]
	public IMGPICEEMGH(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> KHKGGNHOCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct KKNKFLFFIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public uint AFLLDBEPJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int IBNFADMMLLG;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
	public KKNKFLFFIBB(uint AFLLDBEPJII, int IBNFADMMLLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4CE0", Offset = "0x5CC3EE0", VA = "0x185CC4CE0")]
	public static bool IGOCGGBJBII(in KKNKFLFFIBB BLFKABPCHLN, in KKNKFLFFIBB NPFMAENOPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4C50", Offset = "0x5CC3E50", VA = "0x185CC4C50", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x95CE80", Offset = "0x95C080", VA = "0x18095CE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4D00", Offset = "0x5CC3F00", VA = "0x185CC4D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface LBBGGLOPDDJ
{
	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOLHFBKFBNB(int CAPKFCHDLFA);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPIOOLLACCM(in ReadOnlyMemory<byte> KAEDAICECGN, out ReadOnlyMemory<byte> KJJLBOFMMEH);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JACLPGPMPCM(in ReadOnlyMemory<byte> KAEDAICECGN, out ReadOnlyMemory<byte> KJJLBOFMMEH);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface JCBLJONLIJJ : PKANIJGLOMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface PKANIJGLOMG
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPOCHIGPPIK(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> KHKGGNHOCOE);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface COFGPHLIKIE : PKANIJGLOMG
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int AJCIBMHICOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KKNKFLFFIBB CPAHNHMLFKI();

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLBPPAIACJF();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface NJOKIGJIBCI
{
	[Cpp2IlInjected.Token(Token = "0x17000114")]
	int LHIJLIAMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public delegate void LNKCJKLHADP(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> KHKGGNHOCOE);
[Cpp2IlInjected.Token(Token = "0x2000085")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface NOOFCIGCLAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKJLOOOHIHJ(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> KHKGGNHOCOE);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface ENAPFMDMCLI
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	LGCEMMAIGML BLKFHAKHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMAEKHDLIAN();

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAJEKMNAIOA();

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLBPPAIACJF();
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface PFHJIODBPOA
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHHAJKMMHIK(KKNKFLFFIBB FDAIMOMOHIG, ReadOnlyMemory<byte> DMDHEKMOMJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface DJMKPBLGCLB
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKABJOILCDK(HCIIHJLICJK FIOAPGCPMFK, in LHNKALDLHDD PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBDNONAKDJ(HCIIHJLICJK FIOAPGCPMFK);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAGNDIHJLPG(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class JFHHHDAOKON
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x12D9010", Offset = "0x12D8210", VA = "0x1812D9010")]
	public static void GAGNDIHJLPG<T>(this DJMKPBLGCLB KOODAEDNKIK, HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, T IPMIIEAGJKC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface FMDJGPOAGPA
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGOLCMLNKIB();
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface JEDGFCHEAOG
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	uint CGBNEINCONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface FGBFDIFKLHF
{
	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCOBPCKGINB();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface OPBHIFMFAKO
{
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJMLIJPGNPC(HCIIHJLICJK FLKGABKFAPI, in LHNKALDLHDD PCPEJHIMHJJ, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBAAPDJPILF(HCIIHJLICJK FLKGABKFAPI, bool BGMGDCJKJDB);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKECCGNLKGP(HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC, bool BGMGDCJKJDB);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class PHBBLPEJEGE
{
	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x25B5A80", Offset = "0x25B4C80", VA = "0x1825B5A80")]
	public static void LKECCGNLKGP<T>(this OPBHIFMFAKO LPHOEJICCFI, HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ IDBLFHOOMPH, T IPMIIEAGJKC, bool BGMGDCJKJDB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface POBKBOKNKBJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBNLGGCGMPE(HCIIHJLICJK FIOAPGCPMFK, in LHNKALDLHDD PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDEGCKAHEOA(HCIIHJLICJK FIOAPGCPMFK);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFCEEGLMMKC(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI FELOBKHBENM, in NFKEKJGDLJI DLEMNBPMGBG);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class ANGGEMLIPNH
{
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x2784670", Offset = "0x2783870", VA = "0x182784670")]
	public static void CFCEEGLMMKC<T>(this POBKBOKNKBJ LPHOEJICCFI, HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ IDBLFHOOMPH, T JMJKKGAMABE, T DLEMNBPMGBG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface FAAFLFNFNCP
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDLJLMIFCAN(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI FELOBKHBENM, in NFKEKJGDLJI NEDPHIONALD);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LLAGNJIJFNC(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, in OANIPIMDODC FELOBKHBENM, in OANIPIMDODC NEDPHIONALD);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHJMEKOANNN(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LANLOJLFCKJ(HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, in NFKEKJGDLJI NEDPHIONALD);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class ILHHKBHKLOI
{
	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F55FD0", Offset = "0x1F551D0", VA = "0x181F55FD0")]
	public static bool LLAGNJIJFNC<T>(this FAAFLFNFNCP JMDKGMLODLO, HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, out T FELOBKHBENM, out T NEDPHIONALD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F55EC0", Offset = "0x1F550C0", VA = "0x181F55EC0")]
	public static bool LANLOJLFCKJ<T>(this FAAFLFNFNCP JMDKGMLODLO, HCIIHJLICJK FIOAPGCPMFK, GFCMOFDOMMJ CHIEJFHOPDP, T NEDPHIONALD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface LLJOLCFMNOE
{
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIENIDJEAMM(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, in OANIPIMDODC IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIMMHKLFOIE(HCIIHJLICJK MIBPNJCOIHL, CMIHDJOHIOH MPAPMLANIKB, [Optional] object DELCOFCGDFF);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPCBHIOIPOJ(HCIIHJLICJK MIBPNJCOIHL, Span<GFCMOFDOMMJ> IDBLFHOOMPH, bool LJAANIMCAKA);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DBJMAFIOFFK CCGLPNCJJMM(HCIIHJLICJK MIBPNJCOIHL, in LHNKALDLHDD PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJFKMLMPNKM(HCIIHJLICJK MIBPNJCOIHL);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HCJCBAMJKMA(HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GGHDKCJIIBH(FAAFLFNFNCP NGJEDKCNODL, GFCMOFDOMMJ IDBLFHOOMPH, in NFKEKJGDLJI IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class NNGBADJCIKD
{
	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C80A20", Offset = "0x1C7FC20", VA = "0x181C80A20")]
	public static T CIENIDJEAMM<T>(this LLJOLCFMNOE AECGBKJAICN, HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C80B40", Offset = "0x1C7FD40", VA = "0x181C80B40")]
	public static bool HCJCBAMJKMA<T>(this LLJOLCFMNOE AECGBKJAICN, HCIIHJLICJK MIBPNJCOIHL, GFCMOFDOMMJ IDBLFHOOMPH, T IPMIIEAGJKC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum AKNLEMIGMCN
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
public delegate void JJKIMFMCPME(OPBHIFMFAKO LPHOEJICCFI, LGCEMMAIGML ALCBODINOLM, HCIIHJLICJK FLKGABKFAPI, GFCMOFDOMMJ CHIEJFHOPDP, bool BGMGDCJKJDB);
[Cpp2IlInjected.Token(Token = "0x2000097")]
public delegate void DDCALLONOAG<T>(LGCEMMAIGML ALCBODINOLM, T IPMIIEAGJKC) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000098")]
public delegate T BOMFKHNNBPB<T>(LGCEMMAIGML ALCBODINOLM) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000099")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface COBIKEAKJLB : global::LABIJAEFOFO<COBIKEAKJLB>
{
	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GFCMOFDOMMJ HINDCPDHIJG(JECBEPMPMHJ KNOPFGAGMCN);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNAKCAAHHPA(GFCMOFDOMMJ IKHNIJKGJFD, DHDBPBONHFF CMCBBMOIFHP);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJDPOKFHBJA(GFCMOFDOMMJ IKHNIJKGJFD, out DHDBPBONHFF CMCBBMOIFHP);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class GPBBCDADBKD
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2267AA0", Offset = "0x2266CA0", VA = "0x182267AA0")]
	public static GFCMOFDOMMJ HINDCPDHIJG<T>(this COBIKEAKJLB BBBOEOJJCHM, global::LEMPDKIOGJO<T> KNOPFGAGMCN)
	{
		return default(GFCMOFDOMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x22679A0", Offset = "0x2266BA0", VA = "0x1822679A0")]
	public static GFCMOFDOMMJ BNAKCAAHHPA<T>(this COBIKEAKJLB BBBOEOJJCHM, global::LEMPDKIOGJO<T> KNOPFGAGMCN, DHDBPBONHFF CMCBBMOIFHP) where T : struct
	{
		return default(GFCMOFDOMMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface GOCGCCCLMFN
{
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPDHHPNOPFF<T>(in T IPMIIEAGJKC, [Optional] object DELCOFCGDFF) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface DHDBPBONHFF
{
	[Cpp2IlInjected.Token(Token = "0x17000117")]
	Type CDGKEOJOFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIADKJHBOIN(LGCEMMAIGML ALCBODINOLM, in NFKEKJGDLJI GLLFHCCFIGK);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGHFLJJPKHF(LGCEMMAIGML ALCBODINOLM, GOCGCCCLMFN MPAPMLANIKB, [Optional] object DELCOFCGDFF);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class NCKIBLPHJNE
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface PEODABAMNAP
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	bool FLNAAPGINJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ONHJDDCIKBC([Optional] CancellationToken NDKAKDJMDIF);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface DMAKDOMAGHF : OPBHIFMFAKO
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[OHBLGBNBPGG(IHBBGOJDEFH.OMRoom)]
public interface PMIBLGEJEMO
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ANNFKAACPGE(ReadOnlySpan<byte> IPMIIEAGJKC, CancellationToken NDKAKDJMDIF);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct DBFJJBPOONO : ISystemStateComponentData, IComponentData, IEquatable<DBFJJBPOONO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float3 PLKCNIBDCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 IFBOOFMKFHJ;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CBEF00", Offset = "0x5CBE100", VA = "0x185CBEF00", Slot = "4")]
	public bool Equals(DBFJJBPOONO HNPEBINPOBO)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Interfaces.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Preserve]
	internal class _RRAssemblyIndex : HDLOHLLNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9F60", Offset = "0x5CC9160", VA = "0x185CC9F60", Slot = "4")]
		public sealed override void GAJKJBJLBCF()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
