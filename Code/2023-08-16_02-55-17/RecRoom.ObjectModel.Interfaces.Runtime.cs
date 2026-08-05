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
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface DFGILHNBIEM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BGDGPIDLDHD();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDNEDNFLBMN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface PLEFLDKFGFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIKLJPGBGIK(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, Allocator KPFKDHLBOGB, out NativeArray<Entity> IBGFBPGPJKP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct JJACLKAAFCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray OGIGPDCFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<NACALKPEILN, int> BFFKGOKEKBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JLHLDBCJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5886730", Offset = "0x5885930", VA = "0x185886730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15BD640", Offset = "0x15BC840", VA = "0x1815BD640")]
	public JJACLKAAFCB(NativeBitArray OGIGPDCFLCE, NativeParallelHashMap<NACALKPEILN, int> BFFKGOKEKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5886750", Offset = "0x5885950", VA = "0x185886750")]
	public bool HDOHHONGEII(NACALKPEILN EPGIOGIKNGK, MCNHINHNBBI BGOCDAGKFNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface DKEFNOMEIGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid BIEOKOIHBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KPHOFCBCNAK(Guid GFBHILKOLEH, Guid JIILCNGCGEO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FMNJKPKHJGF(BMDJOHDFBDL HIALOBOBBNK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPGLLKCBAAG(BMDJOHDFBDL PPANDIPJOLP, BMDJOHDFBDL OJEMCPHOKBP, out Vector3 MKEBBICDMDG, out Quaternion IBNMCFBIENP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKAPKCGGMFA(IBOPAMBBGDD IBIIEDLJFCE, Vector3 MKEBBICDMDG, Quaternion IBNMCFBIENP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HADCJDEHJDC : GCIMBJDHENP<BMDJOHDFBDL>, AELOMMACAOB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HAMPBFOIKKB<T> : FLNCDPNCALM<BMDJOHDFBDL, T>, GCIMBJDHENP<BMDJOHDFBDL>, AELOMMACAOB, IDisposable, HADCJDEHJDC where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KHPJOFKGGNG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4A40", Offset = "0x1CD3C40", VA = "0x181CD4A40")]
	public static T MCKGCJAFOEM<T>(this GCIMBJDHENP<BMDJOHDFBDL> BGOCDAGKFNE, BMDJOHDFBDL JHJPAJMEGAG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4A10", Offset = "0x1CD3C10", VA = "0x181CD4A10")]
	public static bool BNDJKAKDCIM<T>(this GCIMBJDHENP<BMDJOHDFBDL> BGOCDAGKFNE, BMDJOHDFBDL JHJPAJMEGAG, in T FDDLNHNDPFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface GDAEOFPGCHD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<JPHECNJHLAN> EDLHFIHAJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BMDJOHDFBDL, BMDJOHDFBDL> NMKJLEOPNBD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BMDJOHDFBDL, BMDJOHDFBDL> JJCLCLKJGLL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<BMDJOHDFBDL, BMDJOHDFBDL, BMDJOHDFBDL> KLFEIKOABPE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<BMDJOHDFBDL> IHMFBEHIIGG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GBKKILMJHEP(BMDJOHDFBDL JHJPAJMEGAG, int KGKCEFEHGDE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 CLNIHBFJNMJ(BMDJOHDFBDL JHJPAJMEGAG, int KGKCEFEHGDE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IBCGFLHIBHD(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL EHOPIGAHKCG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BMDJOHDFBDL EEOIOLEHPLN(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<BMDJOHDFBDL> FJDFEOBEIEA(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BMDJOHDFBDL OJMDJGIMIDI(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FJJEDFIKMJP(BMDJOHDFBDL JHJPAJMEGAG, Vector3 MIBJEBFEADH, Quaternion LPLCNLNEJLI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EMHBCLPLOHJ(BMDJOHDFBDL JHJPAJMEGAG, float MELLDFCPCOJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EHCFCCILFNP(BMDJOHDFBDL JHJPAJMEGAG, out RigidTransform JBACNHIBOEH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool OBDCNBJDBDF(BMDJOHDFBDL JHJPAJMEGAG, out float INAPAEPPFOE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 IKLBCHLJCAE(DHOAHHJIBFN AHLGFMHKKGF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion FNHCOICKBNE(DHOAHHJIBFN AHLGFMHKKGF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BNKEENBJIAA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface AFKHAAIJADF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBABCNKOAKP(Action AMEKOPCKNIK, bool EOAJDPBANKO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool COLPCNPJFGA(string JPKENOAMLIN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface EAECNFFNPIO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIKLJPGBGIK(in NativeArray<Entity> IBGFBPGPJKP, in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, in NativeArray<EIPOHBGDCNM> HLJMBHGAANB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface BODOIGGIMGD
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANKMCEGBNDG(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDLJALAKIGD(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCJBNLGGOBJ(BMDJOHDFBDL KHBBAOCDKFN, int NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DefaultMember("Item")]
public interface EIFIFHHKJPI : IEnumerable<PLBLNCEJEDA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray APKLEHCPEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> HMIFNMMDHAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PLBLNCEJEDA JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PLBLNCEJEDA JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PLBLNCEJEDA LMABDHPJKGG(FAODENBHDMK LPNKBGEMCBF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCNHINHNBBI HKIJCBIHCIH(FAODENBHDMK LPNKBGEMCBF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NLGMMLGFEAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface LGMPOOCECDN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int AMPNAPEACJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BGJHOENPBPM(GameObject HAAGKPEGEHP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJHDGBLDKLD(out Vector3 BOEKENJNLKP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task OEPDCGJGIKE();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HGOGONEOKDI();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HDONPMFCPHJ();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GGPCDIELDNO();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MLGFNIDBLPH : IEquatable<MLGFNIDBLPH>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly MLGFNIDBLPH AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x588AC30", Offset = "0x5889E30", VA = "0x18588AC30", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(MLGFNIDBLPH JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JHCAMFPFIKL : IEquatable<JHCAMFPFIKL>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly JHCAMFPFIKL AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5885D10", Offset = "0x5884F10", VA = "0x185885D10", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(JHCAMFPFIKL JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface GGPANEIKFII
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JJACLKAAFCB JHGBPDNOPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDOHHONGEII(NACALKPEILN EPGIOGIKNGK, MCNHINHNBBI BGOCDAGKFNE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPHBIMCGGOO(NACALKPEILN EPGIOGIKNGK, Span<MCNHINHNBBI> EAAEGPDMONP, bool JDEANBFNBKF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOMCOLJJABD(NativeArray<NACALKPEILN> FIPCNCFGHMC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GACLOAEDPDD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5882B50", Offset = "0x5881D50", VA = "0x185882B50")]
	public static void BPHBIMCGGOO(this GGPANEIKFII JGDGCNOJDID, NACALKPEILN EPGIOGIKNGK, MCNHINHNBBI BGOCDAGKFNE, bool JDEANBFNBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct OCHPAAEIANL : HOFBHJGKIFM, IEquatable<OCHPAAEIANL>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly OCHPAAEIANL AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GameObject HAAGKPEGEHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x588B660", Offset = "0x588A860", VA = "0x18588B660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NACALKPEILN GCKILBMNMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x588BF30", Offset = "0x588B130", VA = "0x18588BF30")]
		get
		{
			return default(NACALKPEILN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FHOKMDLBODC CJKDJPBGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x588B460", Offset = "0x588A660", VA = "0x18588B460")]
		get
		{
			return default(FHOKMDLBODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IANCKMHPHEB GHBADNICFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x588B540", Offset = "0x588A740", VA = "0x18588B540")]
		get
		{
			return default(IANCKMHPHEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool IBPBPDAKLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x588B620", Offset = "0x588A820", VA = "0x18588B620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BJLOBJIDNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x588B950", Offset = "0x588AB50", VA = "0x18588B950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OKADFKFICDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x588B640", Offset = "0x588A840", VA = "0x18588B640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool ILBIKAMLKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x588BDE0", Offset = "0x588AFE0", VA = "0x18588BDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GPLJJAOILKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x588B930", Offset = "0x588AB30", VA = "0x18588B930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AAFDCFKNMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x588BE00", Offset = "0x588B000", VA = "0x18588BE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HJBFGGGKPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x588B440", Offset = "0x588A640", VA = "0x18588B440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ONFKHMDOJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x588C110", Offset = "0x588B310", VA = "0x18588C110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JABPCEAJPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x588B970", Offset = "0x588AB70", VA = "0x18588B970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LNOLOHONMMO LAFLOOCDPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(LNOLOHONMMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AMDAPLEBELL DNEDEFMNCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(AMDAPLEBELL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BNKGFIHKCGA LCFKIDEHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BNKGFIHKCGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public HNEAPHOMCPI PBALGHGHEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(HNEAPHOMCPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AAFIBKJBLKE EDBIJJOPMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(AAFIBKJBLKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public KLCJGEEOKGD JOMGODHHICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(KLCJGEEOKGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IBOPAMBBGDD KHEAIHCAMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(IBOPAMBBGDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool IDPBDNBNHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x588B780", Offset = "0x588A980", VA = "0x18588B780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IOCLPIAIEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x588BE20", Offset = "0x588B020", VA = "0x18588BE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool FCKHIEEBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640", Slot = "5")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ECENFDBMBPF JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(ECENFDBMBPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LDMMBHKIKCB NMACKCAFKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(LDMMBHKIKCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public static OCHPAAEIANL OMHOCPNBHHH(BMDJOHDFBDL KHBBAOCDKFN)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x588B990", Offset = "0x588AB90", VA = "0x18588B990")]
	public LMELMGLGCDI GPNNMEFLCKP()
	{
		return default(LMELMGLGCDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x588BA80", Offset = "0x588AC80", VA = "0x18588BA80")]
	public JHKHBEEBAIA HBPHFHANMBM()
	{
		return default(JHKHBEEBAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x588BA20", Offset = "0x588AC20", VA = "0x18588BA20")]
	public MHGKHGJKFPB HAIPFIEHAGC()
	{
		return default(MHGKHGJKFPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x588BD50", Offset = "0x588AF50", VA = "0x18588BD50")]
	public DHOAHHJIBFN LNGBBBLNDDF()
	{
		return default(DHOAHHJIBFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x588BC60", Offset = "0x588AE60", VA = "0x18588BC60")]
	public void KJNINLFGCFK([Optional] object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x588BE70", Offset = "0x588B070", VA = "0x18588BE70")]
	public bool NEEIPHPAMEG(object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x588BBA0", Offset = "0x588ADA0", VA = "0x18588BBA0")]
	public bool JEJLPBHJMJA(object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x588C160", Offset = "0x588B360", VA = "0x18588C160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public OCHPAAEIANL(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(OCHPAAEIANL NABCGCEIEGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public static BMDJOHDFBDL OMHOCPNBHHH(OCHPAAEIANL NABCGCEIEGG)
	{
		return default(BMDJOHDFBDL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x588BAE0", Offset = "0x588ACE0", VA = "0x18588BAE0")]
	public static bool IJMFMDJGAHN(OCHPAAEIANL GGFLAOCNMAP, OCHPAAEIANL PIINDHALINJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x588C010", Offset = "0x588B210", VA = "0x18588C010")]
	public static bool PFFDPAELFMB(OCHPAAEIANL GGFLAOCNMAP, OCHPAAEIANL PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x588B890", Offset = "0x588AA90", VA = "0x18588B890", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "6")]
	public bool Equals(OCHPAAEIANL JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void ABPCAMPCFCK(DNPJHPKBIAD LKHBFALOPDE);
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct ACONENDHEEA : IList<BMDJOHDFBDL>, ICollection<BMDJOHDFBDL>, IEnumerable<BMDJOHDFBDL>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct LKHNMHJKEAC : IEnumerator<BMDJOHDFBDL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JPLJDCFLDIF KPFCGANDCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator LMCDAHACENA;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BMDJOHDFBDL JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5887AD0", Offset = "0x5886CD0", VA = "0x185887AD0", Slot = "4")]
			get
			{
				return default(BMDJOHDFBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5887A20", Offset = "0x5886C20", VA = "0x185887A20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x15BCE20", Offset = "0x15BC020", VA = "0x1815BCE20")]
		public LKHNMHJKEAC(JPLJDCFLDIF KPFCGANDCJL, NativeArray<LocalId>.Enumerator LMCDAHACENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5887960", Offset = "0x5886B60", VA = "0x185887960", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x58879A0", Offset = "0x5886BA0", VA = "0x1858879A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x58879E0", Offset = "0x5886BE0", VA = "0x1858879E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> BOIJHJLHIPE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public BMDJOHDFBDL JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x587E0C0", Offset = "0x587D2C0", VA = "0x18587E0C0", Slot = "4")]
		get
		{
			return default(BMDJOHDFBDL);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x587E140", Offset = "0x587D340", VA = "0x18587E140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x587DC50", Offset = "0x587CE50", VA = "0x18587DC50", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x587DC50", Offset = "0x587CE50", VA = "0x18587DC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool HPJMOKLCNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x587E030", Offset = "0x587D230", VA = "0x18587E030")]
	public ACONENDHEEA(JPLJDCFLDIF KPFCGANDCJL, int AAALINBAMFJ, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x587DBD0", Offset = "0x587CDD0", VA = "0x18587DBD0")]
	public ILOOFJFGECE ICCHCPPDAJL()
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x587D820", Offset = "0x587CA20", VA = "0x18587D820", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x587D860", Offset = "0x587CA60", VA = "0x18587D860", Slot = "13")]
	public bool Contains(BMDJOHDFBDL JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x587D8C0", Offset = "0x587CAC0", VA = "0x18587D8C0", Slot = "14")]
	public void CopyTo(BMDJOHDFBDL[] LMFDNLBGHBA, int PAENDODKMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x587D7C0", Offset = "0x587C9C0", VA = "0x18587D7C0", Slot = "11")]
	public void Add(BMDJOHDFBDL JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x587DCF0", Offset = "0x587CEF0", VA = "0x18587DCF0", Slot = "7")]
	public void Insert(int NNAODBDJDNJ, BMDJOHDFBDL JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x587DDC0", Offset = "0x587CFC0", VA = "0x18587DDC0", Slot = "15")]
	public bool Remove(BMDJOHDFBDL JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x587DC90", Offset = "0x587CE90", VA = "0x18587DC90", Slot = "6")]
	public int IndexOf(BMDJOHDFBDL JJJLNAPHHCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x587DD70", Offset = "0x587CF70", VA = "0x18587DD70", Slot = "8")]
	public void RemoveAt(int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x587DB00", Offset = "0x587CD00", VA = "0x18587DB00", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x587DB40", Offset = "0x587CD40", VA = "0x18587DB40")]
	public LKHNMHJKEAC EEOIHAEEMHN()
	{
		return default(LKHNMHJKEAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x587DE50", Offset = "0x587D050", VA = "0x18587DE50", Slot = "16")]
	private IEnumerator<BMDJOHDFBDL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x587DF40", Offset = "0x587D140", VA = "0x18587DF40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface CHIIOLBAOJH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool ILEECDDANLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface FALEHKILAHO
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	CADEDIIOKBN MHGKALCFEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CEFCOHEOOAA LPNBEPLLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGOEDKNIKCH(Transform LNNHFELGMNI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPJPOMIGFLK(Transform LNNHFELGMNI, LLKOGLCAJBN NIJHBGJILMD);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMEOGMJJOFI(Transform LNNHFELGMNI, BLPFGIECEBB DPBBKDNKPAE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface OOMBIJKANHD
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIKLJPGBGIK(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, out EIPOHBGDCNM GMKMPBEKJDH, out BMDJOHDFBDL IEFMFCGPBPC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct LOBHMBEDOPE : IEquatable<LOBHMBEDOPE>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly LOBHMBEDOPE AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private DBIJIJBKMMK MIHPOMIGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5889020", Offset = "0x5888220", VA = "0x185889020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JHKHBEEBAIA NFIJLFBFAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(JHKHBEEBAIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MGOHIBGGGFF GDHOAFNGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x58897A0", Offset = "0x58889A0", VA = "0x1858897A0")]
		get
		{
			return default(MGOHIBGGGFF);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x58898B0", Offset = "0x5888AB0", VA = "0x1858898B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerable<HEGEJLONGIB> FBECCMJIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5888E40", Offset = "0x5888040", VA = "0x185888E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HEGEJLONGIB JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5889AA0", Offset = "0x5888CA0", VA = "0x185889AA0")]
		get
		{
			return default(HEGEJLONGIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x58899C0", Offset = "0x5888BC0", VA = "0x1858899C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ECENFDBMBPF JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(ECENFDBMBPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5889150", Offset = "0x5888350", VA = "0x185889150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5889580", Offset = "0x5888780", VA = "0x185889580")]
	public HEGEJLONGIB KKMBNPJAOML(float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] Vector3? KIJNMGBKNIP)
	{
		return default(HEGEJLONGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x58891B0", Offset = "0x58883B0", VA = "0x1858891B0")]
	public HEGEJLONGIB HMBGKLGIBGE(int NNAODBDJDNJ, float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] Vector3? KIJNMGBKNIP)
	{
		return default(HEGEJLONGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5889BC0", Offset = "0x5888DC0", VA = "0x185889BC0")]
	public void ODEIAKEFOAE(int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x58893E0", Offset = "0x58885E0", VA = "0x1858893E0")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public LOBHMBEDOPE(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(LOBHMBEDOPE NABCGCEIEGG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x58894C0", Offset = "0x58886C0", VA = "0x1858894C0")]
	public static bool IJMFMDJGAHN(LOBHMBEDOPE GGFLAOCNMAP, LOBHMBEDOPE PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x58890B0", Offset = "0x58882B0", VA = "0x1858890B0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(LOBHMBEDOPE JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface NBMHDDHKDOO
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Type GMLMJACCPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface DDHMFKIBELN
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PHBLIOAHLKM(BMDJOHDFBDL JHJPAJMEGAG, out Collider NAKCMDMIPAF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HHINJPNHDNM(BMDJOHDFBDL AAJNDACPHJM, GameObject NJPHBJKHIEL, Vector3 DGDMDKFMBBA, Quaternion KGFPECIFPNA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAFGGJCGLJM(GameObject NAKCMDMIPAF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider JKBAICIJLLE<TCollider>(GameObject BKGNPKPLLFD) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIMNLOHMINO(Collider NAKCMDMIPAF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KPDGEBPAHOG<TCollider>(string JPKENOAMLIN) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GHANKHPHMBP : GCIMBJDHENP<NACALKPEILN>, AELOMMACAOB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AMOLHCFCJBC<T> : FLNCDPNCALM<NACALKPEILN, T>, GCIMBJDHENP<NACALKPEILN>, AELOMMACAOB, IDisposable, GHANKHPHMBP where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FGAOLJJEMII
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E206F0", Offset = "0x1E1F8F0", VA = "0x181E206F0")]
	public static bool FCPLDEOENIG<T>(this GCIMBJDHENP<NACALKPEILN> BGOCDAGKFNE, NACALKPEILN EPGIOGIKNGK, out T NABCGCEIEGG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E206E0", Offset = "0x1E1F8E0", VA = "0x181E206E0")]
	public static bool BNDJKAKDCIM<T>(this GCIMBJDHENP<NACALKPEILN> BGOCDAGKFNE, NACALKPEILN EPGIOGIKNGK, in T FDDLNHNDPFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface FBGEPJKMLBI
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BILNOGEGDKL();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IBOPAMBBGDD : IEquatable<IBOPAMBBGDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly IBOPAMBBGDD AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private HKGANBMDICA GKCNDLNMIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5884BB0", Offset = "0x5883DB0", VA = "0x185884BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IOAJOBJCEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5884810", Offset = "0x5883A10", VA = "0x185884810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid NAHPHGJADGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5884C40", Offset = "0x5883E40", VA = "0x185884C40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BKLJBAOLMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x58849D0", Offset = "0x5883BD0", VA = "0x1858849D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid EKMCEGABMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5884D40", Offset = "0x5883F40", VA = "0x185884D40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x58847B0", Offset = "0x58839B0", VA = "0x1858847B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5884AB0", Offset = "0x5883CB0", VA = "0x185884AB0")]
	public bool KJICLCGOGDA(out Guid MKJGAIOAKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5884510", Offset = "0x5883710", VA = "0x185884510")]
	public void CKKFNDIKEIA(Guid OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x58846B0", Offset = "0x58838B0", VA = "0x1858846B0")]
	public bool FKDIKHEBIJB(out Guid ICCMHBOIOOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5884E40", Offset = "0x5884040", VA = "0x185884E40")]
	public void PDKOCIGBIGH(Guid OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x58848F0", Offset = "0x5883AF0", VA = "0x1858848F0")]
	public void HLMACHCJLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public IBOPAMBBGDD(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(IBOPAMBBGDD NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5884610", Offset = "0x5883810", VA = "0x185884610", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(IBOPAMBBGDD JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct AMDAPLEBELL : IEquatable<AMDAPLEBELL>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly AMDAPLEBELL AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x587E5C0", Offset = "0x587D7C0", VA = "0x18587E5C0")]
	public void NDBCAEEMEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x587E440", Offset = "0x587D640", VA = "0x18587E440")]
	public void DOHCNDEFFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public AMDAPLEBELL(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x587E520", Offset = "0x587D720", VA = "0x18587E520", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(AMDAPLEBELL JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BGNCONALOOG : HOFBHJGKIFM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ACNKOFALKFG GGNFHLDOMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KDNGCINBFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GameObject HAAGKPEGEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<BGNCONALOOG> KOHMGGFFLEE;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(MMIPKKPAOLG OOHHGMIKJFD, BMDJOHDFBDL PODPIDDLOCF);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool HABHBALDBDC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class PNGBCEKADNA
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x588D640", Offset = "0x588C840", VA = "0x18588D640")]
	public static bool IDPBDNBNHFE(this BGNCONALOOG OJKDJMFOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x588D5F0", Offset = "0x588C7F0", VA = "0x18588D5F0")]
	public static bool FOPIBAALPGP(this BGNCONALOOG OJKDJMFOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x588D730", Offset = "0x588C930", VA = "0x18588D730")]
	public static bool PJFDEOBCIOK(this BGNCONALOOG OJKDJMFOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x588D690", Offset = "0x588C890", VA = "0x18588D690")]
	public static bool IFJLJEPJEPD(this BGNCONALOOG OJKDJMFOHNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface GKMACPCGMIC
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMGEBEEDMJP(GameObject HAAGKPEGEHP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct KCAOJMAANIJ : IEquatable<KCAOJMAANIJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly KCAOJMAANIJ AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5886850", Offset = "0x5885A50", VA = "0x185886850", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(KCAOJMAANIJ JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface PMDPEMDAEAF
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDILOGOPGKH(NativeListAsync<Entity> DEEEJAKPJJL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CONIMFHHKGE(CGAPDPKGPAD PJPMLDAICFB);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBGKNDGHEDC(NativeListAsync<Entity> HBEBJLPLOPH, bool NACIOIJPHMO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEFFCFBCKJN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface KFNNAOJKODP
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAALAMJEPKN(BMDJOHDFBDL JHJPAJMEGAG, PMJFNECPFPH NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface KNKOHPGNOPB
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCAJOLMOOKL();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDDELGHBEIM();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OELFDBNFEGP();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJMMILMAJDK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNDFOCLEHEA();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPBPDOCAILK();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AENGHJMKIFJ();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKPNAGFAPCN();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DCBBIJOJAJO();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMEOGDJPPKN();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FBCLJBKDJIF();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct LOGMGCPJHJB : IEquatable<LOGMGCPJHJB>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal const int ALEFPDFLCEP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal const int ENDGLIPMPCN = 4;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal const int EOPGIHNBNBE = 8;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal const int NLEGOMAMCPA = 24;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal const uint NPJNFCAJIIM = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal const uint PIPJONMJDLO = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly uint EMCKGOPIABN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static uint[] IBJHJABBAML;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static JPLJDCFLDIF[] DAJKBHKJPOA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static uint GMHMHDHKOKC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JPLJDCFLDIF PHOKKPOKNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x588A700", Offset = "0x5889900", VA = "0x18588A700")]
	static LOGMGCPJHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
	internal LOGMGCPJHJB(uint NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2CB0", Offset = "0x3AC1EB0", VA = "0x183AC2CB0", Slot = "4")]
	public bool Equals(LOGMGCPJHJB JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5889F80", Offset = "0x5889180", VA = "0x185889F80", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x588A600", Offset = "0x5889800", VA = "0x18588A600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x588A440", Offset = "0x5889640", VA = "0x18588A440")]
	private JPLJDCFLDIF LJEJOGOPLEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x588A1C0", Offset = "0x58893C0", VA = "0x18588A1C0")]
	private static uint HFLLCEAHCAL(uint EMCKGOPIABN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x588A1D0", Offset = "0x58893D0", VA = "0x18588A1D0")]
	private static (uint, uint) JDBPBFAPGIK(uint EMCKGOPIABN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x588A430", Offset = "0x5889630", VA = "0x18588A430")]
	private static uint LIAIFBINHCB(uint KBIJDJHCEBH, uint NNAODBDJDNJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x588A230", Offset = "0x5889430", VA = "0x18588A230")]
	internal static LOGMGCPJHJB JJOABFDKIHC(JPLJDCFLDIF INBMBKDICBE)
	{
		return default(LOGMGCPJHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x588A010", Offset = "0x5889210", VA = "0x18588A010")]
	internal static void FPJBABEEDGM(LOGMGCPJHJB EMCKGOPIABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5889CF0", Offset = "0x5888EF0", VA = "0x185889CF0")]
	private static void CPCGPDJEEHF(int HCKHKGKDPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BDNEDPOFMOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int GDLPBMDOFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> GFOFCACBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMDJOHDFBDL MHDKDDDADDG(BMDJOHDFBDL BOIJHJLHIPE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JIEDLBNHGAH : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct HNEAPHOMCPI : IEquatable<HNEAPHOMCPI>
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly HNEAPHOMCPI AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private KNKPLJDCBPO LCAFGBOOPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5883FA0", Offset = "0x58831A0", VA = "0x185883FA0")]
		get
		{
			return default(KNKPLJDCBPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool LMDFGHLGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5884470", Offset = "0x5883670", VA = "0x185884470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool DOIINGLMEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5883ED0", Offset = "0x58830D0", VA = "0x185883ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool EAHGPPLNIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5883CE0", Offset = "0x5882EE0", VA = "0x185883CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool KDOIFEKNHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5884460", Offset = "0x5883660", VA = "0x185884460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool NGDKKEAIJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5884240", Offset = "0x5883440", VA = "0x185884240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IIMDOPFJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x58843D0", Offset = "0x58835D0", VA = "0x1858843D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool NGOJNNCLENE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5884340", Offset = "0x5883540", VA = "0x185884340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool KLMLFDBJJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5883EE0", Offset = "0x58830E0", VA = "0x185883EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FLMJEBBPFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5883EC0", Offset = "0x58830C0", VA = "0x185883EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool HOPHOFDMHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5884100", Offset = "0x5883300", VA = "0x185884100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool HNOEPALBCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5883EB0", Offset = "0x58830B0", VA = "0x185883EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool KPFCOFJFHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5883DC0", Offset = "0x5882FC0", VA = "0x185883DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EGNBBJCOHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5884330", Offset = "0x5883530", VA = "0x185884330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool KEKGLALDCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5883CF0", Offset = "0x5882EF0", VA = "0x185883CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool PIAGNFFONFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5883F90", Offset = "0x5883190", VA = "0x185883F90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5883CD0", Offset = "0x5882ED0", VA = "0x185883CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool GJGDHGPHELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x58843E0", Offset = "0x58835E0", VA = "0x1858843E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Vector3 IMFLJNBGLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5883DD0", Offset = "0x5882FD0", VA = "0x185883DD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Vector3 HABBKMDGIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5883D00", Offset = "0x5882F00", VA = "0x185883D00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GHFCDLPKODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5884110", Offset = "0x5883310", VA = "0x185884110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5884010", Offset = "0x5883210", VA = "0x185884010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5884350", Offset = "0x5883550", VA = "0x185884350")]
	public bool NOLLNNPMAOF(IBLIHOJHMNC NEPBCPCCOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5884250", Offset = "0x5883450", VA = "0x185884250")]
	public bool JOMPADJPCIH(ACNNOHILHOO NEPBCPCCOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5884070", Offset = "0x5883270", VA = "0x185884070")]
	public void HGPLLHKBCCH(ACNNOHILHOO NEPBCPCCOKF, bool AICOLMFCHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public HNEAPHOMCPI(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5883EF0", Offset = "0x58830F0", VA = "0x185883EF0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(HNEAPHOMCPI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum IFDCBBODBGC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OPNGOCLPGOO
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x183D4F0", Offset = "0x183C6F0", VA = "0x18183D4F0")]
	public static bool HGBBADMGDOI(this IFDCBBODBGC NJGLKOBADEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x183D510", Offset = "0x183C710", VA = "0x18183D510")]
	public static bool BIBAEGJOBBH(this IFDCBBODBGC NJGLKOBADEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x410D680", Offset = "0x410C880", VA = "0x18410D680")]
	public static bool GFGKFKPGKNP(this IFDCBBODBGC NJGLKOBADEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface MMIPKKPAOLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	World OFIFOCNNODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	World EPJHBKFCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase CIKABCGCJMD(Type FBNKHAJKFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KHLPDMAJHAM
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5886930", Offset = "0x5885B30", VA = "0x185886930")]
	public static ComponentSystemBase NLFGKJKHBKG(this World OOHHGMIKJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4840", Offset = "0x1CD3A40", VA = "0x181CD4840")]
	public static T CIKABCGCJMD<T>(this MMIPKKPAOLG JEAODICNNBO) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct IIJEOPOHPBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DNPJHPKBIAD JFGIPFOFKHL;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public ILOOFJFGECE LHEKDANEIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x15BDAC0", Offset = "0x15BCCC0", VA = "0x1815BDAC0")]
		get
		{
			return default(ILOOFJFGECE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5885480", Offset = "0x5884680", VA = "0x185885480")]
	public IIJEOPOHPBE(DNPJHPKBIAD JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5885150", Offset = "0x5884350", VA = "0x185885150")]
	public ILOOFJFGECE JNEJJIHMOMI()
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5885220", Offset = "0x5884420", VA = "0x185885220")]
	public ILOOFJFGECE KJHICLPEELE()
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x58852F0", Offset = "0x58844F0", VA = "0x1858852F0")]
	public (ILOOFJFGECE, ILOOFJFGECE, ILOOFJFGECE) MCKGCJAFOEM()
	{
		return default((ILOOFJFGECE, ILOOFJFGECE, ILOOFJFGECE));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct LDMMBHKIKCB : IEquatable<LDMMBHKIKCB>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly LDMMBHKIKCB AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private ALOPNKJDLEE AHHCEAMJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5887200", Offset = "0x5886400", VA = "0x185887200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public BMDJOHDFBDL ANJCEMJLKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5886EC0", Offset = "0x58860C0", VA = "0x185886EC0")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public OCHPAAEIANL OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5886DB0", Offset = "0x5885FB0", VA = "0x185886DB0")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OCHPAAEIANL NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5886FD0", Offset = "0x58861D0", VA = "0x185886FD0")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5887440", Offset = "0x5886640", VA = "0x185887440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x58870E0", Offset = "0x58862E0", VA = "0x1858870E0")]
	public bool BPMJPILKAOG(OCHPAAEIANL OJEMCPHOKBP, bool BJCOCCDMHLD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5887330", Offset = "0x5886530", VA = "0x185887330")]
	public bool FGHHNJKOBON(OCHPAAEIANL FMMAMOIMPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public LDMMBHKIKCB(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5887290", Offset = "0x5886490", VA = "0x185887290", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(LDMMBHKIKCB JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface POFDHBBBAEI
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJBEOJMPGNC(string JPOEHOENKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct IEKCAMLNMBL : IEquatable<IEKCAMLNMBL>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IEKCAMLNMBL AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private EDLKEKDOHGO OHGNHFGKJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x58850A0", Offset = "0x58842A0", VA = "0x1858850A0")]
		get
		{
			return default(EDLKEKDOHGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public LGOCNEHIALI MLGIJGNFKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5885020", Offset = "0x5884220", VA = "0x185885020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public IEKCAMLNMBL(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5884F80", Offset = "0x5884180", VA = "0x185884F80", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(IEKCAMLNMBL JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface FLAEPGHGFAB
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string IKGHODIKJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] JIAPMEGOAPF(IEnumerable<EHDODNDLPHI> BKLFKAMPCOO);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NACALKPEILN PDMDDIPJFDA(Guid AAPLOGLAMKH);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKMEELDFCOI(GameObject HAAGKPEGEHP, out NACALKPEILN EPGIOGIKNGK);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PDAAKPIGGNG(GameObject HAAGKPEGEHP, out int EAKAOAFMCGM, out IANCKMHPHEB GLKDKMADKLI);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BGNCONALOOG LHEHBKDBHCA(EHDODNDLPHI DMFMJBFFPPI);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BGNCONALOOG LHEHBKDBHCA(string CEIPDMHAAOM, NACALKPEILN EPGIOGIKNGK, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, Vector3 KIJNMGBKNIP);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECCABMDLGJC(GameObject PHJINOEJCFK, bool GMKKJGOMPLH);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMOANCMBMFA(GameObject HAAGKPEGEHP, bool ANCHCKHGFLH, bool HKDNOCICFIH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JAFBMOMOJFC
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5885B40", Offset = "0x5884D40", VA = "0x185885B40")]
	public static BGNCONALOOG LHEHBKDBHCA(this FLAEPGHGFAB LJKHADFBIKG, NACALKPEILN EPGIOGIKNGK, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, Vector3 KIJNMGBKNIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface BHBBKGDGLNN
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	BLPFGIECEBB ELFPBEDNOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface MNCDKBBELAG
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World MLEMFBKEIPJ();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World BCDPIFHGLBE();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World HFCAFFPLGPM();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World HKLEOENPOOJ();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface OEFLNLBOHFB
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	CPJBOBMOPIJ MELFIOLJGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	FLAEPGHGFAB JMJFNMJIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	CIBCMPCFKJH LJPOGGEAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	AOIKACBNBJM MHJMCLBLOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	GKMACPCGMIC NFCNKHJNIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	POFDHBBBAEI BIGFODCNCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	LGMPOOCECDN JDAGHOBEHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	CHIIOLBAOJH IKOCBPPJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	DFGILHNBIEM GPMDLAFIEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface DFCLHDMPBKF
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct AOAANDAGBNG : GBHJAOJCEHA, IEquatable<AOAANDAGBNG>
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x587E6E0", Offset = "0x587D8E0", VA = "0x18587E6E0", Slot = "8")]
	public bool Equals(AOAANDAGBNG JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x587E730", Offset = "0x587D930", VA = "0x18587E730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface JLJMMGONAJH
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJOABFDKIHC(FAODENBHDMK BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPJBABEEDGM(FAODENBHDMK BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DLGBACOGEKM : INGMBGOCEKO, IEquatable<DLGBACOGEKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public IANCKMHPHEB GLKDKMADKLI;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x587F840", Offset = "0x587EA40", VA = "0x18587F840", Slot = "5")]
	public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x587F810", Offset = "0x587EA10", VA = "0x18587F810", Slot = "4")]
	public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x587F870", Offset = "0x587EA70", VA = "0x18587F870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2CB0", Offset = "0x3AC1EB0", VA = "0x183AC2CB0", Slot = "6")]
	public bool Equals(DLGBACOGEKM JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x587F780", Offset = "0x587E980", VA = "0x18587F780", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface GFNGPKFFJEL
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool ILEECDDANLI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action EGBHDCJEJBE;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAMEPKNIOGG();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GENJNDHFMLO();

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOAPFNKGENF(bool EECCCGAOPOH);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OMHHDPFHBOM(ByteString CCBKAEHNCPH);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OEPDCGJGIKE();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task HGOGONEOKDI();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task HDONPMFCPHJ();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LFDHBMCCKOI();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface JGJKKEPGAGN
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	GGMDGLIEABN CEDOLNJMLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	List<HADCJDEHJDC> MLEDKIPJDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJPAPGAIKGL(HADCJDEHJDC BGOCDAGKFNE, out GGMDGLIEABN MFKCFHJMFME);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJOABFDKIHC(HADCJDEHJDC BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPJBABEEDGM(HADCJDEHJDC BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface KDBHDOONEIL
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	OFJIKECJGJK OICIKMEIGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct DHOAHHJIBFN : IEquatable<DHOAHHJIBFN>
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DHOAHHJIBFN AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private GDAEOFPGCHD EPFKNCAAHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x587F6B0", Offset = "0x587E8B0", VA = "0x18587F6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public float3 MJPGPIDGPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x587F270", Offset = "0x587E470", VA = "0x18587F270")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public quaternion FMICFEKMFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x587F480", Offset = "0x587E680", VA = "0x18587F480")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public OCHPAAEIANL DNINBLEOLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x587F580", Offset = "0x587E780", VA = "0x18587F580")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x587F420", Offset = "0x587E620", VA = "0x18587F420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public DHOAHHJIBFN(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public static BMDJOHDFBDL OMHOCPNBHHH(DHOAHHJIBFN NABCGCEIEGG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x587F380", Offset = "0x587E580", VA = "0x18587F380", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(DHOAHHJIBFN JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface CHOMHKHHFDB
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LFDHBMCCKOI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BLOMAOGEMFJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MDMPALHBKIK;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GGMDGLIEABN
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	string CFMIKOIFIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	GGMDGLIEABN NNONAMBMKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	IEnumerable<GGMDGLIEABN> EIOPDDCPIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DefaultMember("Item")]
public struct ILOOFJFGECE : IReadOnlyList<BMDJOHDFBDL>, IEnumerable<BMDJOHDFBDL>, IEnumerable, IReadOnlyCollection<BMDJOHDFBDL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OAJINIOJHOL : IEnumerator<BMDJOHDFBDL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly JPLJDCFLDIF KPFCGANDCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeArray<LocalId>.Enumerator LMCDAHACENA;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public BMDJOHDFBDL JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x588B3D0", Offset = "0x588A5D0", VA = "0x18588B3D0", Slot = "4")]
			get
			{
				return default(BMDJOHDFBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x588B320", Offset = "0x588A520", VA = "0x18588B320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x15BCE20", Offset = "0x15BC020", VA = "0x1815BCE20")]
		public OAJINIOJHOL(JPLJDCFLDIF KPFCGANDCJL, NativeArray<LocalId>.Enumerator LMCDAHACENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x588B260", Offset = "0x588A460", VA = "0x18588B260", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x588B2A0", Offset = "0x588A4A0", VA = "0x18588B2A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x588B2E0", Offset = "0x588A4E0", VA = "0x18588B2E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeArray<LocalId> BOIJHJLHIPE;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public BMDJOHDFBDL JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5885B00", Offset = "0x5884D00", VA = "0x185885B00", Slot = "4")]
		get
		{
			return default(BMDJOHDFBDL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5885680", Offset = "0x5884880", VA = "0x185885680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private int BOOCECDLHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BNBLLGADOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5885690", Offset = "0x5884890", VA = "0x185885690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public NativeArray<LocalId> OJLFFLJAFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC00", Offset = "0x15BCE00", VA = "0x1815BDC00")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	internal NativeArray<Entity> FHOFPCEBBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5885620", Offset = "0x5884820", VA = "0x185885620")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x58859D0", Offset = "0x5884BD0", VA = "0x1858859D0")]
	public ILOOFJFGECE(int HCKHKGKDPCJ, JPLJDCFLDIF KPFCGANDCJL, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x15BC7D0", Offset = "0x15BB9D0", VA = "0x1815BC7D0")]
	public ILOOFJFGECE(JPLJDCFLDIF KPFCGANDCJL, NativeArray<LocalId> BOIJHJLHIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5885960", Offset = "0x5884B60", VA = "0x185885960")]
	internal ILOOFJFGECE(JPLJDCFLDIF KPFCGANDCJL, NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5885A60", Offset = "0x5884C60", VA = "0x185885A60")]
	public ILOOFJFGECE(JPLJDCFLDIF KPFCGANDCJL, int AAALINBAMFJ, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x58858B0", Offset = "0x5884AB0", VA = "0x1858858B0")]
	public ILOOFJFGECE(ILOOFJFGECE OMEGDENBJAH, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x58854B0", Offset = "0x58846B0", VA = "0x1858854B0")]
	public ILOOFJFGECE DLOFCDEOECF(Allocator KPFKDHLBOGB = Allocator.Temp)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5885550", Offset = "0x5884750", VA = "0x185885550", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5885590", Offset = "0x5884790", VA = "0x185885590")]
	public OAJINIOJHOL EEOIHAEEMHN()
	{
		return default(OAJINIOJHOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x58856D0", Offset = "0x58848D0", VA = "0x1858856D0", Slot = "6")]
	private IEnumerator<BMDJOHDFBDL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x58857C0", Offset = "0x58849C0", VA = "0x1858857C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct NACALKPEILN : IComparable<NACALKPEILN>, IEquatable<NACALKPEILN>, INGMBGOCEKO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const uint JJNKEACICCH = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const uint JKPJMMLBHKK = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly NACALKPEILN MOBOMNFBKHP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int NLEGOMAMCPA = 24;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private const uint NPJNFCAJIIM = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private const int DOIILFGIHNO = 8;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const uint BIHDFCBLHMD = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly uint NDONHPGBMNB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public uint AIEPGHAIJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA97410", Offset = "0xA96610", VA = "0x180A97410")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public uint HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x588AFA0", Offset = "0x588A1A0", VA = "0x18588AFA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public uint BEAOIMDEANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x52142E0", Offset = "0x52134E0", VA = "0x1852142E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
	public static NACALKPEILN NMHPLAOLJAC(uint NDONHPGBMNB)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x588B080", Offset = "0x588A280", VA = "0x18588B080")]
	public NACALKPEILN(int CMEFNIKNDFM, int MGDDLADFJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x588B080", Offset = "0x588A280", VA = "0x18588B080")]
	public NACALKPEILN(uint CMEFNIKNDFM, int MGDDLADFJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x588B080", Offset = "0x588A280", VA = "0x18588B080")]
	public NACALKPEILN(uint CMEFNIKNDFM, uint MGDDLADFJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
	private NACALKPEILN(uint NDONHPGBMNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5214370", Offset = "0x5213570", VA = "0x185214370")]
	public static bool IJMFMDJGAHN(NACALKPEILN GGFLAOCNMAP, NACALKPEILN PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x588ADB0", Offset = "0x5889FB0", VA = "0x18588ADB0", Slot = "5")]
	public bool Equals(NACALKPEILN CJNGPAPKKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x588AE10", Offset = "0x588A010", VA = "0x18588AE10", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x259C520", Offset = "0x259B720", VA = "0x18259C520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x588AFB0", Offset = "0x588A1B0", VA = "0x18588AFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x588AEE0", Offset = "0x588A0E0", VA = "0x18588AEE0", Slot = "6")]
	public void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x588AF40", Offset = "0x588A140", VA = "0x18588AF40", Slot = "7")]
	public void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x588ADA0", Offset = "0x5889FA0", VA = "0x18588ADA0", Slot = "4")]
	public int CompareTo(NACALKPEILN JMNBIHILIIC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface HNMHAJLPHMH
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBGPJNHGHCH(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFJMDJGLEDF(Entity BLNICJMKCEF, in float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 ACMHBINOKCP(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKOIHALOCIP(Entity BLNICJMKCEF, in quaternion NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion HMFNAHFKGJD(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KANMFOJNIKE(Entity BLNICJMKCEF, out float3 BOEKENJNLKP, out quaternion ELGEECMLAMI);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KANMFOJNIKE(Entity BLNICJMKCEF, out RigidTransform JMLNOEBANEC);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGAMEEBKDIH(Entity BLNICJMKCEF, out RigidTransform JMLNOEBANEC);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 ACMFOJKOGHF(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FCAHDNKELNN(Entity BLNICJMKCEF, in float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FKPDMGOHFMC(Entity BLNICJMKCEF, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float GKKLEPNPMII(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MOPJNNFCKCP(Entity BLNICJMKCEF, in float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 KNPJMCMOEDL(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FLCLONCKBII(Entity BLNICJMKCEF, in float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 OFCLBOMLFLK(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ECHMCPKNDDE(Entity BLNICJMKCEF, in quaternion NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion KBPBNFKMDEB(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 CPIGLLAIOHB(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CEKLBAMACNE(Entity BLNICJMKCEF, in float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HOLBLMIEKBF(Entity BLNICJMKCEF, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float CJJFPGBIEOK(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BDONNKCHBEP(Entity BLNICJMKCEF, in float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 OFJJPGKOJOP(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NCGBHDOACHC(Entity BLNICJMKCEF, out float4x4 CELAMPCHIFA);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EAIMFEAJCJB(Entity BLNICJMKCEF, in float4x4 CELAMPCHIFA);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MNMJOEKBIGF(Entity BLNICJMKCEF, out float4x4 CELAMPCHIFA);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool ELAJOLEBEAL(Entity BLNICJMKCEF, out Transform LNNHFELGMNI);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JANNHKCNGPB(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NOFCIMJIFCL(Entity BLNICJMKCEF, Entity IFMGHGFKKAF, Entity PCCOHMIFFHJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MKPHJKFMBOM
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct LGMOGAKCIAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IEnumerable<EHDODNDLPHI> BKLFKAMPCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IReadOnlyList<GameObject> GBKEEACBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IReadOnlyList<int> BLHCBNMJABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IReadOnlyList<(NACALKPEILN, NACALKPEILN)> HGJOIGMIPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int MOCMBBPCENF;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x58874E0", Offset = "0x58866E0", VA = "0x1858874E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int CAIFMBLNJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IEnumerable<GameObject> ODIPOMEOHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x902ED0", Offset = "0x9020D0", VA = "0x180902ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public IEnumerable<(NACALKPEILN src, NACALKPEILN dst)> FAEPLLJAGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x58878F0", Offset = "0x5886AF0", VA = "0x1858878F0")]
	public LGMOGAKCIAN(IEnumerable<EHDODNDLPHI> BKLFKAMPCOO, IReadOnlyList<GameObject> GBKEEACBDGP, IReadOnlyList<int> BLHCBNMJABF, IReadOnlyList<(NACALKPEILN src, NACALKPEILN dst)> HGJOIGMIPOJ, int MOCMBBPCENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5887540", Offset = "0x5886740", VA = "0x185887540")]
	public (GameObject, int)[] HDDJFEFDNLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct LMELMGLGCDI : IEquatable<LMELMGLGCDI>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly LMELMGLGCDI AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private ALOPNKJDLEE AHHCEAMJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5887F90", Offset = "0x5887190", VA = "0x185887F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public ILOOFJFGECE AEGEPHKKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x58881F0", Offset = "0x58873F0", VA = "0x1858881F0")]
		get
		{
			return default(ILOOFJFGECE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<OCHPAAEIANL> IELDKDGLEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5887C00", Offset = "0x5886E00", VA = "0x185887C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public IEnumerable<OCHPAAEIANL> OMJOEAGMAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5888300", Offset = "0x5887500", VA = "0x185888300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public int DAEHLKEFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5887EB0", Offset = "0x58870B0", VA = "0x185887EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int GENEHPOOPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5887BB0", Offset = "0x5886DB0", VA = "0x185887BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x58880C0", Offset = "0x58872C0", VA = "0x1858880C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public BCCEBHKEABG KEMKMMBPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5887B40", Offset = "0x5886D40", VA = "0x185887B40")]
		get
		{
			return default(BCCEBHKEABG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5888690", Offset = "0x5887890", VA = "0x185888690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LNFLOBOMJKO DCGFJPHHJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5888910", Offset = "0x5887B10", VA = "0x185888910")]
		get
		{
			return default(LNFLOBOMJKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5888980", Offset = "0x5887B80", VA = "0x185888980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GNGLAFCNIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5888670", Offset = "0x5887870", VA = "0x185888670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OOHIOEAGFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5888720", Offset = "0x5887920", VA = "0x185888720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool BLPDKJEFLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5887DC0", Offset = "0x5886FC0", VA = "0x185887DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool FFIFHOAHBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5887D70", Offset = "0x5886F70", VA = "0x185887D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool JHKCMACEDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5888660", Offset = "0x5887860", VA = "0x185888660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5888740", Offset = "0x5887940", VA = "0x185888740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LAIGJPKGAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5887DB0", Offset = "0x5886FB0", VA = "0x185887DB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5888710", Offset = "0x5887910", VA = "0x185888710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public ECENFDBMBPF JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(ECENFDBMBPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public LDMMBHKIKCB NMACKCAFKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(LDMMBHKIKCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5888190", Offset = "0x5887390", VA = "0x185888190")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public static OCHPAAEIANL OMHOCPNBHHH(LMELMGLGCDI AKLNKNCLGHB)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5887D90", Offset = "0x5886F90", VA = "0x185887D90")]
	public bool AMBOEDJGJBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5887DE0", Offset = "0x5886FE0", VA = "0x185887DE0")]
	public bool EKMJODAGJPO(AFCPMJNOFLE NEPBCPCCOKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5888880", Offset = "0x5887A80", VA = "0x185888880")]
	public void NMJHIIDCLCE(AFCPMJNOFLE NEPBCPCCOKF, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5888440", Offset = "0x5887640", VA = "0x185888440")]
	public ILOOFJFGECE JGKFBNJNBII(Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5888750", Offset = "0x5887950", VA = "0x185888750")]
	public void NJFBHMNJBGG(LMELMGLGCDI JMNBIHILIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public LMELMGLGCDI(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(LMELMGLGCDI NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5888020", Offset = "0x5887220", VA = "0x185888020", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(LMELMGLGCDI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface EEAHAAKHGLK
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOPIADCFDMM(ILOOFJFGECE BOIJHJLHIPE);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 CLNIHBFJNMJ(GameObject HAAGKPEGEHP, int LGEIGOHADBA);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct ONPDJNBGCLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly GHHOFPJDBDC KACNNGPFBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly GHHOFPJDBDC GLFOLGBEBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly uint JJJOLCMNICG;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x588C460", Offset = "0x588B660", VA = "0x18588C460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct HFEBMIPFKPB
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly ONPDJNBGCLP AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x587E780", Offset = "0x587D980", VA = "0x18587E780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct BBEANBLGGNA
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly ONPDJNBGCLP AMEKOPCKNIK;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x587E780", Offset = "0x587D980", VA = "0x18587E780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct EMDHDFIBNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly uint JJJOLCMNICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly bool COKOMCPDPIN;

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x58828B0", Offset = "0x5881AB0", VA = "0x1858828B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface AOIKACBNBJM
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	bool AAMCNANIGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	bool MAJHLEHMHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool OAEGJLDNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool DODLLHLNAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKCHLIGMBFG(object GJNKBDPFGGF);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIPICDGOJFG(object BJPEGONLJEK);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMHBDOCKEIB(object BJPEGONLJEK);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int ANGOECGOFLJ(GameObject AEMIIPGDKOE);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCPPJADPEJL(NativeArray<int> CFLKHJOINNA);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface HEJIKGNEDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHOEIKBIHAG(BMDJOHDFBDL JHJPAJMEGAG, JGABCBFOGEC NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGABCBFOGEC FBJALINOBAA(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIBGAGBKMNG(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOEHEOKPEGA(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PIEOLGNFKFJ(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMDJOHDFBDL KLAGIJJDGIC(BMDJOHDFBDL JHJPAJMEGAG, int NNAODBDJDNJ);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNFLFELDMEP(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NDPAJAFHMPE(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD, BMDJOHDFBDL NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GDMDNBEIBPC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ECPOGCDEBGK(BMDJOHDFBDL JHJPAJMEGAG, out BMDJOHDFBDL NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFPFFJACKDF(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GKLGHHEPEBO(BMDJOHDFBDL JHJPAJMEGAG, out float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BDHDBELPBPJ(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EHHKMNJKPGO(BMDJOHDFBDL JHJPAJMEGAG, out float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JDAFPEBJHGA(BMDJOHDFBDL JHJPAJMEGAG, (Quaternion rot, Vector3 moments) BCLEDNCILCC);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GCFAPJMKALL(BMDJOHDFBDL JHJPAJMEGAG, out quaternion IBNMCFBIENP, out float3 KCCJNFIBEPH);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NPFOLLCFNHC(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DMCEHMDDAHP(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 DEFMICGMPPK(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 JAAJAOMLGGD(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DLLJDJDFPMK(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LPBIPCDHPIP(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float IEFAPLEBGNL(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float FLJCDOENPMN(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GLNLPFFODII(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void KNKFOBAGPOL(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode IIDFOHGNLBA(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MPDHMFFBPAG(BMDJOHDFBDL JHJPAJMEGAG, CollisionDetectionMode NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LGJDBCELJGC DJAEPIIKALA(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LLONFBJMMBJ(BMDJOHDFBDL JHJPAJMEGAG, LGJDBCELJGC NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FLCPCOPJENH(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JJPGMBPJOAJ(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "32")]
	BMDJOHDFBDL ELNKALNLELD(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void LBCEDGFJDLM(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	BMDJOHDFBDL FOMIAGBPCIG(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BPMJPILKAOG(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	FOILGMPPBAK AAOBFABDJFP(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void OMMCNFDKKAH(BMDJOHDFBDL JHJPAJMEGAG, FOILGMPPBAK NPMHEGCJEAG);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool BIKHMAMCJMM(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void EIONPDFCPOD(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool OIBAMAGOGML(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GJKMMPMFFGE(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool LNELKMFIFKK(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void GNOMLDJNCII(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints IBOIHIHHFHP(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void NGKFOFGOIHN(BMDJOHDFBDL JHJPAJMEGAG, RigidbodyConstraints NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float HJIEKHJCAPC(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void MHKBILMMHKD(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float PKECNDBOBCK(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void OMDFFHILOPG(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool CLBCGODNJNN(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void FAJDCMECNIM(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool JHDCCFGPCJA(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NMBAEDECDIC(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void OMPJINNPJJB(BMDJOHDFBDL JHJPAJMEGAG, int NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object ECGFEDDLFGJ(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void AGHIIAFLCKB(BMDJOHDFBDL JHJPAJMEGAG, object NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object NOLDBAJDEOI(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BIECLLDHNPB(BMDJOHDFBDL JHJPAJMEGAG, object NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float BLDDFLBNCBO(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ADCPGHCAFFF(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void AIGLBFDNNFC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void DCKNMMOKNPI(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool OFHJOBAELCI(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void OEALKPKHMIB(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GJLLHDMDJNG(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool GHBPACDFHBK(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JDNFKAPCCPN(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody HEFLGOHHBBE(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void OMCLGMIMMBJ(BMDJOHDFBDL JHJPAJMEGAG, Rigidbody JPHDKFDHOEE);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void AGNJHCMHGPC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void PDDIPNMKOKI(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool JOGDCHOKMLI(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void MCJIJBOFDJD(BMDJOHDFBDL JHJPAJMEGAG, float3 NHADPEGDINF);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MKKIGJGGOHG(BMDJOHDFBDL JHJPAJMEGAG, float3 FDDOLPLJELI);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool CBBIDNNAKFH(BMDJOHDFBDL JHJPAJMEGAG, out float3 NHADPEGDINF);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool JBBPENCGCPL(BMDJOHDFBDL JHJPAJMEGAG, out float3 FDDOLPLJELI);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool HLNAEHOELNP(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void KKGFEBAHIGL(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD, bool ALGGMCABHBG);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void MMGIAHLBPJK(BMDJOHDFBDL JHJPAJMEGAG, bool HPKMDNDEEJG);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void CFGAJHAHGDK(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool CBPLKBHHKNO(BMDJOHDFBDL JHJPAJMEGAG);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface MPENABBNJNJ
{
	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFOMMCKNDHN(Entity AMBJIIKIPJO);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HINMJEHEIMG(Entity AMBJIIKIPJO);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct LNOLOHONMMO : IEquatable<LNOLOHONMMO>
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LNOLOHONMMO AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public string POPEMGEEHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5888AD0", Offset = "0x5887CD0", VA = "0x185888AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public string CHEBHNBPHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5888D60", Offset = "0x5887F60", VA = "0x185888D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public LNOLOHONMMO(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5888CC0", Offset = "0x5887EC0", VA = "0x185888CC0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(LNOLOHONMMO JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface CPJBOBMOPIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAGGFAMOJDC();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCOMOJIEENG(bool OOFEGJGIJLP);

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMEANIJFHFL(GameObject HAAGKPEGEHP);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct EGOIFGIGLHP : IEquatable<EGOIFGIGLHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly EGOIFGIGLHP AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5882350", Offset = "0x5881550", VA = "0x185882350", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(EGOIFGIGLHP JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct AAFIBKJBLKE : IEquatable<AAFIBKJBLKE>
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly AAFIBKJBLKE AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private CFHHLPHHLOO MLLAJNIMAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x587CA20", Offset = "0x587BC20", VA = "0x18587CA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MEMOHFIGJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x587C940", Offset = "0x587BB40", VA = "0x18587C940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool DBPCKBDOFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x587CC60", Offset = "0x587BE60", VA = "0x18587CC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool DKKEKPNLPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x587D680", Offset = "0x587C880", VA = "0x18587D680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool BHOEBACGHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x587D560", Offset = "0x587C760", VA = "0x18587D560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool FAFMKOEMEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x587D320", Offset = "0x587C520", VA = "0x18587D320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool KKLGGJPDAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x587D120", Offset = "0x587C320", VA = "0x18587D120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x587D0A0", Offset = "0x587C2A0", VA = "0x18587D0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x587CAB0", Offset = "0x587BCB0", VA = "0x18587CAB0")]
	public bool DOELNDNLGDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x587CAF0", Offset = "0x587BCF0", VA = "0x18587CAF0")]
	public OCHPAAEIANL EAEJDFBAIGA(OCHPAAEIANL BJPEGONLJEK)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x587CED0", Offset = "0x587C0D0", VA = "0x18587CED0")]
	public BMDJOHDFBDL GENPFNKPHIM()
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public AAFIBKJBLKE(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(AAFIBKJBLKE NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x587CE30", Offset = "0x587C030", VA = "0x18587CE30", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(AAFIBKJBLKE JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface HJKDEOOCPAC
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IANCKMHPHEB DHLIEPINNJF(GameObject AEMIIPGDKOE);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIELPHHKCHD(GameObject HAAGKPEGEHP, ACNNOHILHOO ANOHOLCMCFN);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct MCNHINHNBBI : IComparable<MCNHINHNBBI>, IEquatable<MCNHINHNBBI>
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly MCNHINHNBBI MOBOMNFBKHP;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly MCNHINHNBBI DDDBLPKECIO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly MCNHINHNBBI OELNAFIGENL;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly MCNHINHNBBI MGHDMFFEDOK;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly MCNHINHNBBI IHIENPGJOOC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly MCNHINHNBBI DELBNGHIKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int BBOMBIMAMPK;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool DMHELKPCLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x588A7B0", Offset = "0x58899B0", VA = "0x18588A7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int FJBECBMIJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x588A830", Offset = "0x5889A30", VA = "0x18588A830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
	public MCNHINHNBBI(int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x588A7C0", Offset = "0x58899C0", VA = "0x18588A7C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x588A720", Offset = "0x5889920", VA = "0x18588A720", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2CB0", Offset = "0x3AC1EB0", VA = "0x183AC2CB0", Slot = "5")]
	public bool Equals(MCNHINHNBBI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x588A710", Offset = "0x5889910", VA = "0x18588A710", Slot = "4")]
	public int CompareTo(MCNHINHNBBI JMNBIHILIIC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
	public static MCNHINHNBBI OMHOCPNBHHH(int NNAODBDJDNJ)
	{
		return default(MCNHINHNBBI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x146B210", Offset = "0x146A410", VA = "0x18146B210")]
	public static int OMHOCPNBHHH(MCNHINHNBBI HAGDCDMAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x588A840", Offset = "0x5889A40", VA = "0x18588A840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface JOHINJPAKCH : IEnumerable<GHANKHPHMBP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	GHANKHPHMBP JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GHANKHPHMBP LMABDHPJKGG(FAODENBHDMK LPNKBGEMCBF);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCNHINHNBBI HKIJCBIHCIH(FAODENBHDMK LPNKBGEMCBF);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class NCMOEAKHEHD
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x380D6F0", Offset = "0x380C8F0", VA = "0x18380D6F0")]
	public static MCNHINHNBBI HKIJCBIHCIH<T>(this JOHINJPAKCH EAAEGPDMONP, CPFKEJJKDHF<T> JPKENOAMLIN) where T : struct
	{
		return default(MCNHINHNBBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface HKGANBMDICA
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKLJBAOLMEH(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOAJOBJCEBC(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJICLCGOGDA(BMDJOHDFBDL JHJPAJMEGAG, out Guid MKJGAIOAKMJ);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ANNAFJLDFLG(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKKFNDIKEIA(BMDJOHDFBDL JHJPAJMEGAG, Guid MKJGAIOAKMJ);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FKDIKHEBIJB(BMDJOHDFBDL JHJPAJMEGAG, out Guid ICCMHBOIOOM);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid AMOJHEKNAHA(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDKOCIGBIGH(BMDJOHDFBDL JHJPAJMEGAG, Guid ICCMHBOIOOM);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HLMACHCJLFO(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBMLGEMFOCG(BMDJOHDFBDL PPANDIPJOLP, BMDJOHDFBDL OJEMCPHOKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface CFNPKKKFCDJ
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFEKFOALLEK(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct AEGPJNKHODP : IEquatable<AEGPJNKHODP>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly AEGPJNKHODP AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public JHKHBEEBAIA NFIJLFBFAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(JHKHBEEBAIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private OHAIHFJONNP POANNABGOED
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x587E2B0", Offset = "0x587D4B0", VA = "0x18587E2B0")]
		get
		{
			return default(OHAIHFJONNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public EKGFPCGJLIK PMAHBCGECDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x587E240", Offset = "0x587D440", VA = "0x18587E240")]
		get
		{
			return default(EKGFPCGJLIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public AEGPJNKHODP(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(AEGPJNKHODP NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x587E1A0", Offset = "0x587D3A0", VA = "0x18587E1A0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(AEGPJNKHODP JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface EIKGLGIJAHC
{
	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGBACEKOOMI(BMDJOHDFBDL JHJPAJMEGAG, BCCEBHKEABG IBNAGLHFLOO, bool HAFHGDFKLEP, AFCPMJNOFLE CLHDIKEPHKI);

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJOJMLGEDDC(BMDJOHDFBDL JHJPAJMEGAG, BCCEBHKEABG IBNAGLHFLOO, bool HAFHGDFKLEP, bool BOPJHDIEMNC, bool CIIGMBGDPCG);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IFMFKMLAHFG HINFNNLBLFP(BMDJOHDFBDL MKADPIPCNMO, List<BMDJOHDFBDL> JHINBIDBNNB);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCCOPHIFHOF(GameObject FMDDJHAPLPD, GameObject HKIKCCDILHI);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMAFPEPFKFK(GameObject HKIKCCDILHI);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T JKBAICIJLLE<T>(GameObject BKGNPKPLLFD) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BIMNLOHMINO(Collider NAKCMDMIPAF);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject HOIBEKEIJOL<T>(string JPKENOAMLIN) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface LFBNOCAADDA
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	IReadOnlyCollection<DCLNFEIOJHB> LHBAIFFNKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABDIFJJOHAK(int CNBPDHPGPFI, out DCLNFEIOJHB KADEEFPKHJE);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCLNFEIOJHB IOFJGFADENK(Type FBNKHAJKFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class BKANEBMIJDP
{
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2448300", Offset = "0x2447500", VA = "0x182448300")]
	public static T LOABNIPDDML<T>(this LFBNOCAADDA KGNNKALBBFF, Entity BLNICJMKCEF) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2447720", Offset = "0x2446920", VA = "0x182447720")]
	public static DCLNFEIOJHB IOFJGFADENK<T>(this LFBNOCAADDA KGNNKALBBFF) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface CIBCMPCFKJH
{
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJOALNICEPJ(bool EECCCGAOPOH);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface HOFBHJGKIFM
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface DFFEELNDGLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool GAKKDGNNPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	bool HJGBLHHMELN
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	JHFDKBHOKBE LGOIABLEFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JONKJOHGAPG FDOAEHLNAKO(bool FCKAPKLMOAF = false);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JONKJOHGAPG DBCKJGNHKIP(IEnumerable<BMDJOHDFBDL> BOIJHJLHIPE, in LBIKKMMNADH CPAEGLDKAOP);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KPICKPJENBH INIAGPEAOOE(ByteString LMFGKLMAMJJ);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JNHLGEOHJON EBNJLKABHDP(ByteString CCBKAEHNCPH, BMDJOHDFBDL OJEMCPHOKBP, in LBIKKMMNADH LLCBNCMAJAP, KEAMHPDKNJO NEAPKBOPGJI, bool DAIHICNGAAA = true);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IJJOAOJLFKK();

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMOECHPPGIP(bool HOPKILAOGFF);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LGMOGAKCIAN EEOIJHPMINF(IEnumerable<EHDODNDLPHI> BKLFKAMPCOO);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class NFNBBMJHNEL
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface FLFMIDDEJIH : FHBJALEEHFO, PKKEKIECBNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	BHIKEJGKPLP FBCEAFFBAED
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	OEFLNLBOHFB OIIAJNFHDML
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	GFNGPKFFJEL BGLACJCFDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface PKKEKIECBNE
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool JLHLDBCJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface HAGLBAACHAP
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool DLAGIBDBBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool JBOGNGNFOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface AIGDDGKGBKN
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	Guid BIEOKOIHBOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLIOKLCNJEK(Guid MKJGAIOAKMJ, Guid ICCMHBOIOOM, string JPKENOAMLIN);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GHHOFPJDBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	internal int MLHOBKJDKGI;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5882D80", Offset = "0x5881F80", VA = "0x185882D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class OHFJNLPFBEO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private struct CKGJALJIBKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Guid BHKAMCELBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GNJFGJJGHCL PFHOPENCOMO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct GNJFGJJGHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int NABCGCEIEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int KIFKGKDKKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int BNMFODDLCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int HFGAHEABLKC;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x58832F0", Offset = "0x58824F0", VA = "0x1858832F0")]
		public bool DOEHNFEKPNC(out NACALKPEILN EPGIOGIKNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x5883390", Offset = "0x5882590", VA = "0x185883390")]
		public GNJFGJJGHCL(NACALKPEILN EPGIOGIKNGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x588C3A0", Offset = "0x588B5A0", VA = "0x18588C3A0")]
	public static Guid FIHEFHHNHKD(this NACALKPEILN EPGIOGIKNGK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x588C440", Offset = "0x588B640", VA = "0x18588C440")]
	public static bool GLPKBNIEIFA(this Guid BHKAMCELBPN, out NACALKPEILN EPGIOGIKNGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(EFPFGNPBHIN))]
public readonly struct BMDJOHDFBDL : IComparable<BMDJOHDFBDL>, IEquatable<BMDJOHDFBDL>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BMDJOHDFBDL MOBOMNFBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly LOGMGCPJHJB EMCKGOPIABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LocalId JHJPAJMEGAG;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public LocalId NMECEMGGBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x15BDD30", Offset = "0x15BCF30", VA = "0x1815BDD30")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool CCLPLAGPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x587EAD0", Offset = "0x587DCD0", VA = "0x18587EAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool JBPEEDJFFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x587EA50", Offset = "0x587DC50", VA = "0x18587EA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool GPLEELJKKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x587E880", Offset = "0x587DA80", VA = "0x18587E880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x587ED80", Offset = "0x587DF80", VA = "0x18587ED80")]
	public BMDJOHDFBDL(JPLJDCFLDIF MGJNGMCEJIM, LocalId JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
	public OCHPAAEIANL NHDPPJDPGFC()
	{
		return default(OCHPAAEIANL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x15BDD30", Offset = "0x15BCF30", VA = "0x1815BDD30")]
	public static LocalId OMHOCPNBHHH(BMDJOHDFBDL DIEFHONGKFI)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x587EBB0", Offset = "0x587DDB0", VA = "0x18587EBB0")]
	public static Entity OMHOCPNBHHH(BMDJOHDFBDL DIEFHONGKFI)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x587EA70", Offset = "0x587DC70", VA = "0x18587EA70")]
	public static bool IJMFMDJGAHN(BMDJOHDFBDL GGFLAOCNMAP, BMDJOHDFBDL PIINDHALINJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x587EBC0", Offset = "0x587DDC0", VA = "0x18587EBC0")]
	public static bool PFFDPAELFMB(BMDJOHDFBDL GGFLAOCNMAP, BMDJOHDFBDL PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x587EC80", Offset = "0x587DE80", VA = "0x18587EC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x587E980", Offset = "0x587DB80", VA = "0x18587E980", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x587E820", Offset = "0x587DA20", VA = "0x18587E820", Slot = "4")]
	public int CompareTo(BMDJOHDFBDL JMNBIHILIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x587E8A0", Offset = "0x587DAA0", VA = "0x18587E8A0", Slot = "5")]
	public bool Equals(BMDJOHDFBDL JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class FBOICLMJNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5882950", Offset = "0x5881B50", VA = "0x185882950")]
	public static NACALKPEILN NHPDIBJHNEF(this BMDJOHDFBDL PPNJOAJJOFF)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x19330D0", Offset = "0x19322D0", VA = "0x1819330D0")]
	public static T IHKJEMCDOKK<T>(this BMDJOHDFBDL PPNJOAJJOFF) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class EFPFGNPBHIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface BDHDJNEMBDK
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPEJLEKGJIO(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PAIDDININKM(BMDJOHDFBDL JHJPAJMEGAG, bool HAFHGDFKLEP, bool BOPJHDIEMNC, bool BBKCDHCHMML);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct DNPJHPKBIAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly ILOOFJFGECE IJPPGDHIGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NativeArray<byte> CNPGLHEDJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NativeArray<byte> KJOKOFBOJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly MCNHINHNBBI HAGDCDMAFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int FLKOIGFFCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Type NGEFKAFIPOP;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public ILOOFJFGECE LHEKDANEIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x15BDAC0", Offset = "0x15BCCC0", VA = "0x1815BDAC0")]
		get
		{
			return default(ILOOFJFGECE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x587F9A0", Offset = "0x587EBA0", VA = "0x18587F9A0")]
	public DNPJHPKBIAD(ILOOFJFGECE IJPPGDHIGGN, NativeArray<byte> CNPGLHEDJDI, NativeArray<byte> KJOKOFBOJIE, MCNHINHNBBI HAGDCDMAFAF, int FLKOIGFFCND, Type NGEFKAFIPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x29D5300", Offset = "0x29D4500", VA = "0x1829D5300")]
	public NativeArray<T> JNEJJIHMOMI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x29D5340", Offset = "0x29D4540", VA = "0x1829D5340")]
	public NativeArray<T> KJHICLPEELE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x29D5380", Offset = "0x29D4580", VA = "0x1829D5380")]
	public (ILOOFJFGECE, NativeArray<T>, NativeArray<T>) MCKGCJAFOEM<T>() where T : struct
	{
		return default((ILOOFJFGECE, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x587F900", Offset = "0x587EB00", VA = "0x18587F900")]
	public IIJEOPOHPBE OJFKGGOMBNO()
	{
		return default(IIJEOPOHPBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct KLCJGEEOKGD : IEquatable<KLCJGEEOKGD>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly KLCJGEEOKGD AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x5886BB0", Offset = "0x5885DB0", VA = "0x185886BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x58869C0", Offset = "0x5885BC0", VA = "0x1858869C0")]
	public void ANKMCEGBNDG(bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5886C10", Offset = "0x5885E10", VA = "0x185886C10")]
	public void IDLJALAKIGD(bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5AD0", Offset = "0x1CD4CD0", VA = "0x181CD5AD0")]
	public T HDDILPHNEBH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public KLCJGEEOKGD(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5886B10", Offset = "0x5885D10", VA = "0x185886B10", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(KLCJGEEOKGD JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct OHCKAODANNI : IEquatable<OHCKAODANNI>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly OHCKAODANNI AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x588C2C0", Offset = "0x588B4C0", VA = "0x18588C2C0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(OHCKAODANNI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface MKDGDMAKODP
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	IFDCBBODBGC OLOKFOACKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	IFDCBBODBGC FMFDGLMFPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	IFDCBBODBGC DLOFCDEOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	IFDCBBODBGC OMDGIJHMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	IFDCBBODBGC FHIECECDLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	IFDCBBODBGC LCFKIDEHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	IFDCBBODBGC KJJAKHBHFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	IFDCBBODBGC BJFMFAJHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EIPOHBGDCNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float JDDNLHFCOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 AHEOGBFEFAD;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct JHKHBEEBAIA : IEquatable<JHKHBEEBAIA>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly JHKHBEEBAIA AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private GGPILNMKIEB KDGJFHGJLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5885EE0", Offset = "0x58850E0", VA = "0x185885EE0")]
		get
		{
			return default(GGPILNMKIEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public MCPNFDKBNGL KDDDDKHOJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x5886340", Offset = "0x5885540", VA = "0x185886340")]
		get
		{
			return default(MCPNFDKBNGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public JJMGLOFFLFN LJOKKPNMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5885DF0", Offset = "0x5884FF0", VA = "0x185885DF0")]
		get
		{
			return default(JJMGLOFFLFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NLANDBIEMON DCJPOPHJLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5885F50", Offset = "0x5885150", VA = "0x185885F50")]
		get
		{
			return default(NLANDBIEMON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public IKAFEOPNGGL IABDELPLIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x5885E60", Offset = "0x5885060", VA = "0x185885E60")]
		get
		{
			return default(IKAFEOPNGGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public GLADLPGDHJF LAGNIFEAPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5886510", Offset = "0x5885710", VA = "0x185886510")]
		get
		{
			return default(GLADLPGDHJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5886490", Offset = "0x5885690", VA = "0x185886490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public ONNAFMGNPOD CDHAIOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x58862D0", Offset = "0x58854D0", VA = "0x1858862D0")]
		get
		{
			return default(ONNAFMGNPOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5886250", Offset = "0x5885450", VA = "0x185886250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public float KNJFPDJKGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x5886170", Offset = "0x5885370", VA = "0x185886170")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x58860F0", Offset = "0x58852F0", VA = "0x1858860F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 HFLIPHPKDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5886580", Offset = "0x5885780", VA = "0x185886580")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5885FC0", Offset = "0x58851C0", VA = "0x185885FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float OMFHJGDKHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5886670", Offset = "0x5885870", VA = "0x185886670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public NEDOPGBAPGB.LHCPCKCFDHP OFLHNMKKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x58861E0", Offset = "0x58853E0", VA = "0x1858861E0")]
		get
		{
			return default(NEDOPGBAPGB.LHCPCKCFDHP);
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x5886410", Offset = "0x5885610", VA = "0x185886410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public ECENFDBMBPF JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(ECENFDBMBPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x58863B0", Offset = "0x58855B0", VA = "0x1858863B0")]
	public AEGPJNKHODP JJJPPBLIKCA()
	{
		return default(AEGPJNKHODP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5886610", Offset = "0x5885810", VA = "0x185886610")]
	public LOBHMBEDOPE MDPOGDMCAPA()
	{
		return default(LOBHMBEDOPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public JHKHBEEBAIA(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x587D6B0", Offset = "0x587C8B0", VA = "0x18587D6B0")]
	public static bool OMHOCPNBHHH(JHKHBEEBAIA NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5886050", Offset = "0x5885250", VA = "0x185886050", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(JHKHBEEBAIA JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface HEDLOJKNBDM
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	POCHLGNFBCE FBCEAFFBAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	OEFLNLBOHFB OIIAJNFHDML
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	MMIPKKPAOLG IJIGCGEAIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	ALOPNKJDLEE NMACKCAFKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	HNMHAJLPHMH OACPGOFIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	DFFEELNDGLN BOKIONJFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	JLJMMGONAJH CNPFIIIKGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	DBIJIJBKMMK MIHPOMIGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	OOMBIJKANHD NFEANMEALDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	CFHHLPHHLOO EDBIJJOPMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	DDHMFKIBELN LCFKIDEHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	CFNPKKKFCDJ KNMILDHLGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	BODOIGGIMGD LNNHHFJGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	HKGANBMDICA AEHOKEFKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	GDAEOFPGCHD GAHNAGGKJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	HEJIKGNEDOI BDHLLNEAOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	MKDGDMAKODP GFMMJHEFHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	LFBNOCAADDA BLIIDALJLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface OPFIHGCEBIO
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	object LHGMBGMDCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOPIADCFDMM(ILOOFJFGECE BOIJHJLHIPE);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface ALOPNKJDLEE
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<IIJEOPOHPBE> LFHCJLBBJPB;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMDJOHDFBDL ELNKALNLELD(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LANDOEMDGKM(ref List<BMDJOHDFBDL> EBANKOKIHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BMDJOHDFBDL FOMIAGBPCIG(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BPMJPILKAOG(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL OJEMCPHOKBP, bool BJCOCCDMHLD);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LKLFJDNGDMK(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL OJEMCPHOKBP);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int PIEOLGNFKFJ(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ILOOFJFGECE COLLMPJBLJN(BMDJOHDFBDL KHBBAOCDKFN);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OOGFDOGPFLJ(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL FGNNHDMBMMD);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FGHHNJKOBON(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL FMMAMOIMPOM);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BMDJOHDFBDL LOBKECFHJIB(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DFLGDIJJHGG(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE, out BMDJOHDFBDL ILDPFGGCFGP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class CCOKMHJNADJ
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x587F180", Offset = "0x587E380", VA = "0x18587F180")]
	public static List<BMDJOHDFBDL> LANDOEMDGKM(this ALOPNKJDLEE HBHMCMADCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x587F090", Offset = "0x587E290", VA = "0x18587F090")]
	public static bool AKIBOJKDGFM(this ALOPNKJDLEE HBHMCMADCAL, BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum ACNKOFALKFG
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
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface DBIJIJBKMMK
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<BMDJOHDFBDL> FEODAKODAKJ(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMDJOHDFBDL CAMCIOPGOPO(BMDJOHDFBDL JHJPAJMEGAG, int NNAODBDJDNJ);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int COIMGBHJOOI(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGOHIBGGGFF ODFEEHOPACB(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIJOKBMLGHJ(BMDJOHDFBDL JHJPAJMEGAG, MGOHIBGGGFF HPANENBGKED);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BMDJOHDFBDL FAAKGEHJAGC(BMDJOHDFBDL JHJPAJMEGAG, [Optional] float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] float3? KIJNMGBKNIP);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BMDJOHDFBDL HIHKFLKFCLP(BMDJOHDFBDL JHJPAJMEGAG, int NNAODBDJDNJ, [Optional] float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] float3? KIJNMGBKNIP);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEOBJJBAAOD(BMDJOHDFBDL JHJPAJMEGAG, int NNAODBDJDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IBAHCEONIEP(BMDJOHDFBDL JHJPAJMEGAG);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface JKNDJOAONLH
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIMJGOMAKFK(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMHDMFGBCPD(BMDJOHDFBDL JHJPAJMEGAG, Transform LNNHFELGMNI);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface JPHECNJHLAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	LocalId IGMAGHFMMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	LocalId JHHHDEOPKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDPGLIIPMPI(float3 MKEBBICDMDG);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNMDJHFPFKJ(float3 MKEBBICDMDG);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BAFOLPFFDKI(out float3 KACNNGPFBFG, out float3 GLFOLGBEBEM);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PONMBCFMNAK(float3 KACNNGPFBFG, float3 GLFOLGBEBEM);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FEDDCPIJAPD(Color KACNNGPFBFG, Color GLFOLGBEBEM);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JPHECNJHLAN Instantiate(Transform LNNHFELGMNI);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface EIKJMBKBODP
{
	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCEHONPEIFO(Transform LNNHFELGMNI, JPHECNJHLAN AIOJEGAPAHJ);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPHECNJHLAN EDLHFIHAJEO();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct MHGKHGJKFPB : IEquatable<MHGKHGJKFPB>
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly MHGKHGJKFPB AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private NJOEJIPCHHO AKNODMHALAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x588AB10", Offset = "0x5889D10", VA = "0x18588AB10")]
		get
		{
			return default(NJOEJIPCHHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public HBANKPKIGIN IJHJOJNGFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x588AB80", Offset = "0x5889D80", VA = "0x18588AB80")]
		get
		{
			return default(HBANKPKIGIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x588AA60", Offset = "0x5889C60", VA = "0x18588AA60")]
	public IEKCAMLNMBL FKIHIKJKAMA()
	{
		return default(IEKCAMLNMBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public MHGKHGJKFPB(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x588A9C0", Offset = "0x5889BC0", VA = "0x18588A9C0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(MHGKHGJKFPB JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct AIFOIOMPKFP : IEquatable<AIFOIOMPKFP>
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly AIFOIOMPKFP AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x587E360", Offset = "0x587D560", VA = "0x18587E360", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(AIFOIOMPKFP JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct BNKGFIHKCGA : IEquatable<BNKGFIHKCGA>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly BNKGFIHKCGA AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public BNKGFIHKCGA(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x587EE70", Offset = "0x587E070", VA = "0x18587EE70", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(BNKGFIHKCGA JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x587EF10", Offset = "0x587E110", VA = "0x18587EF10")]
	public bool NDIAJCMPOLK(out Collider NAKCMDMIPAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct HEGEJLONGIB : IEquatable<HEGEJLONGIB>
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly HEGEJLONGIB AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public LOBHMBEDOPE IMMOPINALKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x58834F0", Offset = "0x58826F0", VA = "0x1858834F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public float3 IEOOHOKMJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5883A50", Offset = "0x5882C50", VA = "0x185883A50")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x5883650", Offset = "0x5882850", VA = "0x185883650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public quaternion NDNFEPKHJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x58836E0", Offset = "0x58828E0", VA = "0x1858836E0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5883AE0", Offset = "0x5882CE0", VA = "0x185883AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float3 EHNEPJCMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x58835C0", Offset = "0x58827C0", VA = "0x1858835C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5883B70", Offset = "0x5882D70", VA = "0x185883B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public HNPMAFNAGGH KGGLIJGBAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5883880", Offset = "0x5882A80", VA = "0x185883880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private LIJFEOLGKNI NIDPPEFHELN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5883970", Offset = "0x5882B70", VA = "0x185883970")]
		get
		{
			return default(LIJFEOLGKNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private EDFGEIIFMEK DCPEKMOEGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5883480", Offset = "0x5882680", VA = "0x185883480")]
		get
		{
			return default(EDFGEIIFMEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private PHGMMBLLEKA BLKFFCIGBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5883900", Offset = "0x5882B00", VA = "0x185883900")]
		get
		{
			return default(PHGMMBLLEKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private CLALLPFFFON DJMOFKHDOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5883770", Offset = "0x5882970", VA = "0x185883770")]
		get
		{
			return default(CLALLPFFFON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private EKCMJLKFOPG EJBBNJKCPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x58839E0", Offset = "0x5882BE0", VA = "0x1858839E0")]
		get
		{
			return default(EKCMJLKFOPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public HEGEJLONGIB(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x58837E0", Offset = "0x58829E0", VA = "0x1858837E0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(HEGEJLONGIB JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x58833B0", Offset = "0x58825B0", VA = "0x1858833B0")]
	public void ADOMEJFGJLF(LOBHMBEDOPE NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct ECENFDBMBPF : IEquatable<ECENFDBMBPF>
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly ECENFDBMBPF AHLBMOKDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public OCHPAAEIANL GCHLLMNMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C840", VA = "0x180E6D640")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x587D310", Offset = "0x587C510", VA = "0x18587D310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private HNMHAJLPHMH LHKGCCFKBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x58802F0", Offset = "0x587F4F0", VA = "0x1858802F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool BFFAPNOMBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5881060", Offset = "0x5880260", VA = "0x185881060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public Vector3 IEOOHOKMJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5881990", Offset = "0x5880B90", VA = "0x185881990")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5880480", Offset = "0x587F680", VA = "0x185880480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public Quaternion NDNFEPKHJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x58805F0", Offset = "0x587F7F0", VA = "0x1858805F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5881E20", Offset = "0x5881020", VA = "0x185881E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 FNJEBECGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x58809C0", Offset = "0x587FBC0", VA = "0x1858809C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x587FF30", Offset = "0x587F130", VA = "0x18587FF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Quaternion LJIKOHIAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5881840", Offset = "0x5880A40", VA = "0x185881840")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5881BE0", Offset = "0x5880DE0", VA = "0x185881BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public float HOONDNJHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x587FCD0", Offset = "0x587EED0", VA = "0x18587FCD0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x587FD80", Offset = "0x587EF80", VA = "0x18587FD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public float FHGKACAELGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5881290", Offset = "0x5880490", VA = "0x185881290")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Vector3 EHNEPJCMOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5880370", Offset = "0x587F570", VA = "0x185880370")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5882130", Offset = "0x5881330", VA = "0x185882130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 EBBDDLIHJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x58811A0", Offset = "0x58803A0", VA = "0x1858811A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 OCCHGFIFFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x58800D0", Offset = "0x587F2D0", VA = "0x1858800D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Matrix4x4 CDHADPMPPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5880570", Offset = "0x587F770", VA = "0x185880570")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public ECENFDBMBPF(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x587D100", Offset = "0x587C300", VA = "0x18587D100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5880830", Offset = "0x587FA30", VA = "0x185880830", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x587CE00", Offset = "0x587C000", VA = "0x18587CE00", Slot = "4")]
	public bool Equals(ECENFDBMBPF JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x587D6C0", Offset = "0x587C8C0", VA = "0x18587D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5881DC0", Offset = "0x5880FC0", VA = "0x185881DC0")]
	public HCKALGFFMDC NHEFPNNFJDJ()
	{
		return default(HCKALGFFMDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5881AA0", Offset = "0x5880CA0", VA = "0x185881AA0")]
	public void LPAKDCOMLDG(out Matrix4x4 CELAMPCHIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5881340", Offset = "0x5880540", VA = "0x185881340")]
	public void KANMFOJNIKE(out Vector3 JNKAKBEJPPE, out Quaternion FNJGIMGLGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x587FC10", Offset = "0x587EE10", VA = "0x18587FC10")]
	public void BGAMEEBKDIH(out RigidTransform FHOIDBKJJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x58817F0", Offset = "0x58809F0", VA = "0x1858817F0")]
	public LBIKKMMNADH LMIDJDPHLLJ()
	{
		return default(LBIKKMMNADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5881720", Offset = "0x5880920", VA = "0x185881720")]
	public void LMIDJDPHLLJ(out LBIKKMMNADH BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5880E80", Offset = "0x5880080", VA = "0x185880E80")]
	public LBIKKMMNADH HOKCOEAEDFG()
	{
		return default(LBIKKMMNADH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5880ED0", Offset = "0x58800D0", VA = "0x185880ED0")]
	public void HOKCOEAEDFG(out LBIKKMMNADH FHOIDBKJJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x587FA10", Offset = "0x587EC10", VA = "0x18587FA10")]
	public Vector3 ACMHBINOKCP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5882220", Offset = "0x5881420", VA = "0x185882220")]
	public void PFJMDJGLEDF(in Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5881F10", Offset = "0x5881110", VA = "0x185881F10")]
	public Vector3 OFCLBOMLFLK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5880B90", Offset = "0x587FD90", VA = "0x185880B90")]
	public void FLCLONCKBII(in Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5880D30", Offset = "0x587FF30", VA = "0x185880D30")]
	public Quaternion HMFNAHFKGJD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x58810B0", Offset = "0x58802B0", VA = "0x1858810B0")]
	public void IKOIHALOCIP(in Quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x58814C0", Offset = "0x58806C0", VA = "0x1858814C0")]
	public Quaternion KBPBNFKMDEB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5880740", Offset = "0x587F940", VA = "0x185880740")]
	public void ECHMCPKNDDE(in Quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5880C80", Offset = "0x587FE80", VA = "0x185880C80")]
	public float GKKLEPNPMII()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5880AD0", Offset = "0x587FCD0", VA = "0x185880AD0")]
	public void FKPDMGOHFMC(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5880020", Offset = "0x587F220", VA = "0x185880020")]
	public float CJJFPGBIEOK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5880FA0", Offset = "0x58801A0", VA = "0x185880FA0")]
	public void HOLBLMIEKBF(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x58808D0", Offset = "0x587FAD0", VA = "0x1858808D0")]
	public void FCAHDNKELNN(in Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x58801E0", Offset = "0x587F3E0", VA = "0x1858801E0")]
	public Vector3 CPIGLLAIOHB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x587FE40", Offset = "0x587F040", VA = "0x18587FE40")]
	public void CEKLBAMACNE(in Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5881610", Offset = "0x5880810", VA = "0x185881610")]
	public Vector3 KNPJMCMOEDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5881CD0", Offset = "0x5880ED0", VA = "0x185881CD0")]
	public void MOPJNNFCKCP(in Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5882020", Offset = "0x5881220", VA = "0x185882020")]
	public Vector3 OFJJPGKOJOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x587FB20", Offset = "0x587ED20", VA = "0x18587FB20")]
	public void BDONNKCHBEP(in Vector3 NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface JPLJDCFLDIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	LOGMGCPJHJB OMMPADAGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ILOOFJFGECE, NativeArray<IANCKMHPHEB>> JOOPAPLBMPE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ILOOFJFGECE> BLEHOEMJDDC;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHOKMDLBODC FAFBPKCECOE(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IANCKMHPHEB NFFGGPDBEPF(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJOABFDKIHC(NACALKPEILN EPGIOGIKNGK, BGNCONALOOG OJKDJMFOHNB);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OCHPAAEIANL KJNINLFGCFK(BMDJOHDFBDL JHJPAJMEGAG, [Optional] object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BEEFCOHBNDM(BMDJOHDFBDL JHJPAJMEGAG, out BGNCONALOOG OJKDJMFOHNB);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ELAJOLEBEAL(BMDJOHDFBDL JHJPAJMEGAG, out Transform LNNHFELGMNI);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IDPBDNBNHFE(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ECAIDIAPEHP(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NEEIPHPAMEG(LocalId JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JEJLPBHJMJA(LocalId JHJPAJMEGAG, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BMDJOHDFBDL NEEBBCDLDON(NACALKPEILN EPGIOGIKNGK);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NACALKPEILN NHPDIBJHNEF(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ILOOFJFGECE NEEBBCDLDON(NativeArray<NACALKPEILN> EPGIOGIKNGK, Allocator KPFKDHLBOGB);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "19")]
	ILOOFJFGECE IMHJGEENMOL(NativeArray<NACALKPEILN> EPGIOGIKNGK, NativeArray<DLGBACOGEKM> NBHGMLCGCLE, Allocator KPFKDHLBOGB);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OCHPAAEIANL DDDBLPKECIO(IANCKMHPHEB GLKDKMADKLI, bool FHGCFHCOHHO);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	OCHPAAEIANL DDDBLPKECIO(IANCKMHPHEB GLKDKMADKLI);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	OCHPAAEIANL MFJDPGPEFOM(IANCKMHPHEB GLKDKMADKLI);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	OCHPAAEIANL NAIKANDMOOF(IANCKMHPHEB GLKDKMADKLI);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OCHPAAEIANL IMHJGEENMOL(NACALKPEILN EPGIOGIKNGK, IANCKMHPHEB GLKDKMADKLI);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LMELMGLGCDI OKBLFOPMDOP();

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LOBHMBEDOPE EMFECKAHCMJ();

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "27")]
	AEGPJNKHODP DPKJFINENPM(EKGFPCGJLIK BPHJHLGFAHM);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DOHCNDEFFMO(ILOOFJFGECE BOIJHJLHIPE);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NDBCAEEMEJN(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PFGELJGDKOG(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DOHCNDEFFMO(BMDJOHDFBDL JHJPAJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ILOOFJFGECE OGHNPGAIFHF(ILOOFJFGECE LIKELALOOEJ, Allocator KPFKDHLBOGB);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool CCLPLAGPKBK(BMDJOHDFBDL JHJPAJMEGAG);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class PIEDCAPHCKM
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x588CE90", Offset = "0x588C090", VA = "0x18588CE90")]
	public static void ECAIDIAPEHP(this JPLJDCFLDIF KPFCGANDCJL, BGNCONALOOG OJKDJMFOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x588CE50", Offset = "0x588C050", VA = "0x18588CE50")]
	public static OCHPAAEIANL EBJLDAHNILL(this JPLJDCFLDIF KPFCGANDCJL, LocalId JHJPAJMEGAG)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x588D350", Offset = "0x588C550", VA = "0x18588D350")]
	public static BMDJOHDFBDL NEEBBCDLDON(this JPLJDCFLDIF KPFCGANDCJL, LocalId JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x588D380", Offset = "0x588C580", VA = "0x18588D380")]
	public static NACALKPEILN NHPDIBJHNEF(this JPLJDCFLDIF KPFCGANDCJL, LocalId JHJPAJMEGAG)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x588CAF0", Offset = "0x588BCF0", VA = "0x18588CAF0")]
	public static bool CCLPLAGPKBK(this JPLJDCFLDIF KPFCGANDCJL, NACALKPEILN EPGIOGIKNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2349D30", Offset = "0x2348F30", VA = "0x182349D30")]
	public static T IHKJEMCDOKK<T>(this JPLJDCFLDIF KPFCGANDCJL, LocalId JHJPAJMEGAG) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x588CF90", Offset = "0x588C190", VA = "0x18588CF90")]
	public static LMELMGLGCDI GAKHFOCMIBA(this JPLJDCFLDIF KPFCGANDCJL, RigidTransform BMFIICIOLJA, [Optional] object FDCOCHLAHJD)
	{
		return default(LMELMGLGCDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x588D210", Offset = "0x588C410", VA = "0x18588D210")]
	public static AEGPJNKHODP KOPFLFILLNC(this JPLJDCFLDIF KPFCGANDCJL, EKGFPCGJLIK HMOCEANPFEE, RigidTransform BMFIICIOLJA, [Optional] object FDCOCHLAHJD)
	{
		return default(AEGPJNKHODP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x588D0D0", Offset = "0x588C2D0", VA = "0x18588D0D0")]
	public static LOBHMBEDOPE HMJBHDPEPAN(this JPLJDCFLDIF KPFCGANDCJL, RigidTransform BMFIICIOLJA, [Optional] object FDCOCHLAHJD)
	{
		return default(LOBHMBEDOPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x588C7A0", Offset = "0x588B9A0", VA = "0x18588C7A0")]
	private static void BNIPFIEHMJP(OCHPAAEIANL JCDBHHLLFEJ, RigidTransform BMFIICIOLJA, [Optional] object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x588CC50", Offset = "0x588BE50", VA = "0x18588CC50")]
	internal static IEKCAMLNMBL DJPILKNFJPG(this JPLJDCFLDIF KPFCGANDCJL, LGOCNEHIALI GKKBCECKKHN, [Optional] object FDCOCHLAHJD)
	{
		return default(IEKCAMLNMBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface JHLOBONCNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FADJEBIEENG(GameObject HAAGKPEGEHP);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHHGLEDDHGG(GameObject HAAGKPEGEHP);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object BLNNAACBIPM(BMDJOHDFBDL JHJPAJMEGAG, GameObject HAAGKPEGEHP, Action<BMDJOHDFBDL, int> JHGMNDBGFFP);

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFJKKBICAHF(GameObject HAAGKPEGEHP, object AFNLGFCFBCL);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal static class NLOCJGCJPCE
{
	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x588B200", Offset = "0x588A400", VA = "0x18588B200")]
	public static HEDLOJKNBDM KINNDLLBLJA(this BMDJOHDFBDL CJNGPAPKKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x588B090", Offset = "0x588A290", VA = "0x18588B090")]
	public static MMIPKKPAOLG IJIGCGEAIBP(this BMDJOHDFBDL CJNGPAPKKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x588B130", Offset = "0x588A330", VA = "0x18588B130")]
	public static EntityManager JENBOMFEDGP(this BMDJOHDFBDL CJNGPAPKKID)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x26EC950", Offset = "0x26EBB50", VA = "0x1826EC950")]
	public static T IFCFEFCFLPA<T>(this BMDJOHDFBDL CJNGPAPKKID) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x26EC8D0", Offset = "0x26EBAD0", VA = "0x1826EC8D0")]
	public static bool DLKGIOFHMLE<T>(this BMDJOHDFBDL CJNGPAPKKID) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
internal interface ODALGMFMJHI
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IIJEOPOHPBE> LFHCJLBBJPB;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public interface CFHHLPHHLOO
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	bool CABKPJABLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	BMDJOHDFBDL DPBGHLBFFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	OCHPAAEIANL KJFJNDPMFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event PBGAIMDLAHE EIOJNCNDJBC;

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BMDJOHDFBDL LOBKECFHJIB(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE);

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DFLGDIJJHGG(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE, out BMDJOHDFBDL ILDPFGGCFGP);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HLCJBDOONLM();

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KOMAIKIKCFM();

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MEMOHFIGJLO(BMDJOHDFBDL BJPEGONLJEK);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public delegate void PBGAIMDLAHE(OCHPAAEIANL JPHMMPLCANP, OCHPAAEIANL DJACLBNAKNM);
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class GMKJFNONJEO
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5882EE0", Offset = "0x58820E0", VA = "0x185882EE0")]
	public static bool IHGINIIMOLJ(this CFHHLPHHLOO MNFEDONOPCM, BMDJOHDFBDL BJPEGONLJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5882DE0", Offset = "0x5881FE0", VA = "0x185882DE0")]
	public static bool BHOEBACGHPA(this CFHHLPHHLOO MNFEDONOPCM, BMDJOHDFBDL BJPEGONLJEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DefaultMember("Item")]
public interface IHPPALHFKFG : IEnumerable<HADCJDEHJDC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	HADCJDEHJDC JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HADCJDEHJDC LMABDHPJKGG(FAODENBHDMK LPNKBGEMCBF);

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCNHINHNBBI HKIJCBIHCIH(FAODENBHDMK LPNKBGEMCBF);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class GGJCNHBEILN
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1E28E10", Offset = "0x1E28010", VA = "0x181E28E10")]
	public static HAMPBFOIKKB<T> LMABDHPJKGG<T>(this IHPPALHFKFG EAAEGPDMONP, FAODENBHDMK JPKENOAMLIN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1E28F30", Offset = "0x1E28130", VA = "0x181E28F30")]
	public static HAMPBFOIKKB<T> LMABDHPJKGG<T>(this IHPPALHFKFG EAAEGPDMONP, CPFKEJJKDHF<T> JPKENOAMLIN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x1E28D20", Offset = "0x1E27F20", VA = "0x181E28D20")]
	public static MCNHINHNBBI HKIJCBIHCIH<T>(this IHPPALHFKFG EAAEGPDMONP, CPFKEJJKDHF<T> JPKENOAMLIN) where T : struct
	{
		return default(MCNHINHNBBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface FOEBEFHCPPN : PLEFLDKFGFP
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOAANDAGBNG OIFCGEHGFMG(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMHJMNPGEIH(NativeArray<AOAANDAGBNG> IBJHJABBAML, NativeArray<LMHFDKFEBHE> GOCOAPIJJOG);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDOKMMAPEDE(AOAANDAGBNG EMCKGOPIABN);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BGIOPOJCEPG(AOAANDAGBNG EMCKGOPIABN, out Collider NAKCMDMIPAF);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LMHFDKFEBHE : ISystemStateComponentData, IComponentData, IEquatable<LMHFDKFEBHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float3 IDPJMJNIGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float3 DGBALAEOPBN;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5888A40", Offset = "0x5887C40", VA = "0x185888A40", Slot = "4")]
	public bool Equals(LMHFDKFEBHE JMNBIHILIIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct EHDODNDLPHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Guid BHKAMCELBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public string CEIPDMHAAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 BOEKENJNLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Quaternion ELGEECMLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3 KIJNMGBKNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int FKIPBIPMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Dictionary<string, object> HPANENBGKED;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x58825C0", Offset = "0x58817C0", VA = "0x1858825C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5882430", Offset = "0x5881630", VA = "0x185882430")]
	private static string GKACCHOCNOF(Dictionary<string, object> PNAKIENPNBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum KFNGOAOOLPO
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum NHIMFAGPJEC
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class LDIOCHPHMOK
{
	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x364C0A0", Offset = "0x364B2A0", VA = "0x18364C0A0")]
	public static bool NGBMGJJBPKB(this NHIMFAGPJEC FBNKHAJKFLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface KPICKPJENBH : JHFDKBHOKBE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum KMMLKGKMKMM
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
public enum ALJKOJGNIFI
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
public interface JNHLGEOHJON : JHFDKBHOKBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000143")]
	KEAMHPDKNJO EKKMIBCAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNJLBDDANJL();

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCPFNIHJNLI();
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface KEAMHPDKNJO
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNPFCOJFECM(Guid LBIBKCFHCIL, out Guid GLDKECDCJGE);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface JONKJOHGAPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	BDNEDPOFMOK NBMLOFPALLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString PDFKDPENEKN();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface JHFDKBHOKBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	IEnumerable<EHDODNDLPHI> ABAOCMOJMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	LGMOGAKCIAN KBDMAINAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	LocalId NNDIAMNJMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	BDNEDPOFMOK BDNFJHHFADD
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	Task NKHCGNBKOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HJLCKJBAGNL(KMMLKGKMKMM DLHBAJIIOKJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface IMCMCGKOBCF
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HFLLCEAHCAL(int CNBPDHPGPFI);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface FIADFNDFLMG
{
	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	IEnumerable<HDGGNFNNNFC> PLNMDHMDDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EACPFECEPDP(int CNBPDHPGPFI, out HDGGNFNNNFC KADEEFPKHJE);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface FNEPHKJNOJC
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	List<(LOBNDPHFMLE nameHash, DPOIMOJBLLE stableTypeHash, Type type)> AHPFAMBCHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface JHBOCIKNAIN
{
	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOBNDPHFMLE KHNMHOLHNNE(int CNBPDHPGPFI);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CGALLAMFFOC(LOBNDPHFMLE HNCGIJMEPDF);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface KDHIEDDFGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIFIFDBNBPK(NACALKPEILN NLILKIKKNLO, MCNHINHNBBI HAGDCDMAFAF, ReadOnlySpan<byte> LLKIDGKPJPD, ReadOnlySpan<byte> HIKFJBBEHDB);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFKOFILDNBF(NACALKPEILN NLILKIKKNLO, MCNHINHNBBI HAGDCDMAFAF);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIFJKCODHOM(NACALKPEILN NLILKIKKNLO, MCNHINHNBBI HAGDCDMAFAF, ReadOnlySpan<byte> HIKFJBBEHDB);

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHOFJHBMDAN(NACALKPEILN NLILKIKKNLO, MCNHINHNBBI HAGDCDMAFAF, Span<byte> LLKIDGKPJPD, Span<byte> HIKFJBBEHDB);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class CDGOAAIKCNA
{
	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2234F00", Offset = "0x2234100", VA = "0x182234F00")]
	public static bool OHOFJHBMDAN<T>(this KDHIEDDFGEM MLKHNICICJN, NACALKPEILN NLILKIKKNLO, MCNHINHNBBI HAGDCDMAFAF, out T LLKIDGKPJPD, out T HIKFJBBEHDB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2234DE0", Offset = "0x2233FE0", VA = "0x182234DE0")]
	public static bool BIFJKCODHOM<T>(this KDHIEDDFGEM MLKHNICICJN, NACALKPEILN NLILKIKKNLO, MCNHINHNBBI HAGDCDMAFAF, T HIKFJBBEHDB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum ELNGKCAOLBF
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
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface LJMLPOJGJJE : JOECCMCPHLC<LJMLPOJGJJE>
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCPLDEOENIG(MCNHINHNBBI CJNGPAPKKID, out ILODKGMDNJL KADEEFPKHJE);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class FCJIKEFHHBN
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface EMNPBOOGNLC
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	uint GFEICLPCFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct HHPHAECFDFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public PKINEBOAGLJ FGIADOJFAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public ReadOnlyMemory<byte> GJNKBDPFGGF;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface JCPMCJOEMDC
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKKCHDBOPML(PKINEBOAGLJ FGIADOJFAEB, ReadOnlySpan<byte> GJNKBDPFGGF);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate bool MNJPLNLGGHG(KDHIEDDFGEM KPMBDOJKLKM, in LKEBNILDCHH NABCGCEIEGG);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public delegate bool IHKIFCOGPNN<T>(KDHIEDDFGEM KPMBDOJKLKM, in T NABCGCEIEGG);
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface IFABAGNNEHF
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJOABFDKIHC(MCNHINHNBBI HAGDCDMAFAF, Type HFJFBKDLIFC, MNJPLNLGGHG HPCHEPAMAJN);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAABIBMCOEN(MCNHINHNBBI HAGDCDMAFAF, out MNJPLNLGGHG HPCHEPAMAJN);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class FJMAHCLCAHP
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class ILBAAIPIOJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public IHKIFCOGPNN<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public ILBAAIPIOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2540AC0", Offset = "0x253FCC0", VA = "0x182540AC0")]
		internal bool JJLDLKHELDC(KDHIEDDFGEM pendingList, in LKEBNILDCHH value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1E22A80", Offset = "0x1E21C80", VA = "0x181E22A80")]
	public static void JJOABFDKIHC<T>(this IFABAGNNEHF INBMBKDICBE, MCNHINHNBBI HAGDCDMAFAF, IHKIFCOGPNN<T> HPCHEPAMAJN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5882A50", Offset = "0x5881C50", VA = "0x185882A50")]
	public static bool ANFMDDEIHJM(this IFABAGNNEHF INBMBKDICBE, KDHIEDDFGEM KPMBDOJKLKM, MCNHINHNBBI HAGDCDMAFAF, in LKEBNILDCHH NABCGCEIEGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct PKINEBOAGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public uint CMEFNIKNDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int PMFPGGNBJJI;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	public PKINEBOAGLJ(uint CMEFNIKNDFM, int PMFPGGNBJJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x588D530", Offset = "0x588C730", VA = "0x18588D530")]
	public static bool IJMFMDJGAHN(in PKINEBOAGLJ MHFLHKLCNGM, in PKINEBOAGLJ NKPGENLIMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x588D470", Offset = "0x588C670", VA = "0x18588D470", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x588D500", Offset = "0x588C700", VA = "0x18588D500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x588D550", Offset = "0x588C750", VA = "0x18588D550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface AEAIJMEJGNK
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKINEBOAGLJ DLFIHHHEMBL(ReadOnlySpan<byte> GJNKBDPFGGF);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface ILODKGMDNJL
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	Type MKEOKAGBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD, Span<byte> BJPEGONLJEK);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP, ReadOnlySpan<byte> FGIADOJFAEB);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class CKICGIJLLBJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public interface JOIPDLIOENJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKCHLIGMBFG(PKINEBOAGLJ JCEGKCPOPDM, ReadOnlySpan<byte> GJNKBDPFGGF);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class MDBJHPDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBJHPDEIOP()
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
