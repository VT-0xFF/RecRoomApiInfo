using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Photon.Realtime;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PPBBDOOAMKG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> OCJEMJAEHBM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKIDGLHCFKM(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLBMJGOMFIE(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDPKDACFHOI(object NBGOKNOECBH, bool CNHKBPCNOAG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable AGEPAADLHBG();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OPLPIEINEAA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BGDCPLFLPIJ(StringBuilder GOKFJHEEHGE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LIADFDKJKPJ(bool HPJMGJOBPHM, [Out] string OLGJDMIGDKI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CNPMNAGCOEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PNJCPNGOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HCEFDHNJOHF GPOHKKNGIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ALLOEPJPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AIDMAOKFLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OEFJAEMAJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CABOCANJIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PPDGAFFKCKE PHOOOAJLCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DCHKFDEGOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HCEFDHNJOHF, HCEFDHNJOHF> GGCJICLOCJB;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIEMLOHGDKC(CJACIFMIPIJ OCMODBFFHKK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CAJIACILFFN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PGLFKEIKJHD(string GOCCIFLLPMI, MIFFHMPELLL EDIGNDBNEON);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IIKJAMKHBBL();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NOMDNPFCHMK(AppSettings ABJNAHMIOAG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HCEFDHNJOHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JANBBBAENCD IMKCBOFJFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	KDINCDNPLLB JEAHNGMJEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CABOCANJIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ALLOEPJPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FIPNCELANHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception FCEEBOLPMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode DPFNBLADPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CJACIFMIPIJ.OKHPHMMDGAN CJAKBCIOPKI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<JANBBBAENCD, JANBBBAENCD> ELKEPLJOFDC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OKKJJOOEDJA(object KAKJJOAALHM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PJOMFPDMPEB(object DABOAPMKLGH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GCHONKCAOAD(byte IJHAGMKPHPE, int NGBMJIKJPPO, object BBMDMLIDKCP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CFGNMIKKGMK
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CJACIFMIPIJ.OKHPHMMDGAN CJAKBCIOPKI;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event GCHONKCAOAD JIGAJABBEKF;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GJGFJGADPLD(byte IJHAGMKPHPE, Hashtable LBNDKCHFJJG, INJOLKENMBK EFGHADEHKHE, SendOptions GPMLIFMGFDB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ABPLIGPPDCL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MNFCKJNKANA EDMAPIBKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int GNOPNFOCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int MEEBPEDFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JBGIEENIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MJLIOKMNCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MNFCKJNKANA> CHKLGPCKCOG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	MNFCKJNKANA KNGKMKMHILE(int IAADOHAINLN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GPJCCKLCOOB
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BMAGMCAGFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDNOIKBMCOL();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IPFJJJBMNCG : CNPMNAGCOEH, PPBBDOOAMKG, CFGNMIKKGMK, ABPLIGPPDCL, GPJCCKLCOOB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int AIIFNEDCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int JHAMBHECOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float KHKEDFMDMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float PLNFGKDOLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AMPKGMBFCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BJHNJLHAAMB PEOGLKPPNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action AEMOBNLAKDJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOHDCKFHFNL();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKKMFAPILFH();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BJGOONGMMNM(string AFEOKKHPIJF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJHNJLHAAMB
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MGHDGBJNPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MBPDEBECGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<NKAEHOJMDMA> DAKCBILAPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HLLGHJAEJNC(Action LDLNONJECHG, string AKFEENBMJDO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GFELEJKEJMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string EDDPKMJEOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 CDFOMBDMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion DMOAIFFPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 BEFNNNFPHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int LCDGHENGKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> OILLODHHHAK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x606C1C0", Offset = "0x606AFC0", VA = "0x18606C1C0")]
	public object[] MOLFGEOALFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GFELEJKEJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JFEMNFGAGAE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x606C2D0", Offset = "0x606B0D0", VA = "0x18606C2D0")]
	public static bool KMJFMGIGDKH(this CNPMNAGCOEH KKDAPIIJKDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x606C370", Offset = "0x606B170", VA = "0x18606C370")]
	public static bool NILKBGAOJKP(this CNPMNAGCOEH KKDAPIIJKDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class MNKGMCMJBKM : IPFJJJBMNCG, CNPMNAGCOEH, PPBBDOOAMKG, CFGNMIKKGMK, ABPLIGPPDCL, GPJCCKLCOOB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FKDBJLGEJJH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MNKGMCMJBKM KMLLEDMBIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool FCGEEBKFDBI;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x606C070", Offset = "0x606AE70", VA = "0x18606C070")]
		public FKDBJLGEJJH(MNKGMCMJBKM KMLLEDMBIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x606BF70", Offset = "0x606AD70", VA = "0x18606BF70", Slot = "1")]
		~FKDBJLGEJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x606BEE0", Offset = "0x606ACE0", VA = "0x18606BEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x606C010", Offset = "0x606AE10", VA = "0x18606C010")]
		private void OLEDMLMOJFN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object LGPADFGAGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object JJFHNBAHJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float HKPIIIEGEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float CDFMOBHJJHL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool DCHKFDEGOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float DFCCIPHKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int AIIFNEDCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int JHAMBHECOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract MNFCKJNKANA EDMAPIBKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GNOPNFOCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x606DC00", Offset = "0x606CA00", VA = "0x18606DC00", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int MEEBPEDFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int MJLIOKMNCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool JBGIEENIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x606D510", Offset = "0x606C310", VA = "0x18606D510", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float KHKEDFMDMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x800B50", Offset = "0x7FF950", VA = "0x180800B50", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x606CD40", Offset = "0x606BB40", VA = "0x18606CD40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float PLNFGKDOLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x800B60", Offset = "0x7FF960", VA = "0x180800B60", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x606CF40", Offset = "0x606BD40", VA = "0x18606CF40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool AMPKGMBFCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract BJHNJLHAAMB PEOGLKPPNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool PNJCPNGOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract HCEFDHNJOHF GPOHKKNGIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool ALLOEPJPEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool AIDMAOKFLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool OEFJAEMAJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool CABOCANJIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract PPDGAFFKCKE PHOOOAJLCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private HENOHJNKMME EHHCFAGMGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private HENOHJNKMME HPMIECLBANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private LLMLGPPEOMI<Func<float>> EFLNEOKDLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JPDDFOODEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC80490", Offset = "0xC7F290", VA = "0x180C80490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool PMCNBMBLOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x606CE20", Offset = "0x606BC20", VA = "0x18606CE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool DLBHMIJPLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x606CF00", Offset = "0x606BD00", VA = "0x18606CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event CJACIFMIPIJ.OKHPHMMDGAN CJAKBCIOPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x606CE70", Offset = "0x606BC70", VA = "0x18606CE70", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x606C820", Offset = "0x606B620", VA = "0x18606C820", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event GCHONKCAOAD JIGAJABBEKF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<MNFCKJNKANA> CHKLGPCKCOG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<HCEFDHNJOHF, HCEFDHNJOHF> GGCJICLOCJB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> OCJEMJAEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x606D130", Offset = "0x606BF30", VA = "0x18606D130", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x606DAC0", Offset = "0x606C8C0", VA = "0x18606DAC0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action AEMOBNLAKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x606D9C0", Offset = "0x606C7C0", VA = "0x18606D9C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x606D230", Offset = "0x606C030", VA = "0x18606D230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action BMAGMCAGFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x606CD80", Offset = "0x606BB80", VA = "0x18606CD80", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x606CCA0", Offset = "0x606BAA0", VA = "0x18606CCA0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract MNFCKJNKANA KNGKMKMHILE(int IAADOHAINLN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool NOMDNPFCHMK(AppSettings ABJNAHMIOAG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void IIKJAMKHBBL();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool CAJIACILFFN();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void GLHLDGOPLNF();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool GJGFJGADPLD(byte IJHAGMKPHPE, Hashtable LBNDKCHFJJG, INJOLKENMBK EFGHADEHKHE, SendOptions GPMLIFMGFDB);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool PGLFKEIKJHD(string GOCCIFLLPMI, MIFFHMPELLL EDIGNDBNEON);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void BJGOONGMMNM(string AFEOKKHPIJF);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void GIEMLOHGDKC(CJACIFMIPIJ OCMODBFFHKK);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x606DE60", Offset = "0x606CC60", VA = "0x18606DE60")]
	protected MNKGMCMJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x606CEE0", Offset = "0x606BCE0", VA = "0x18606CEE0")]
	public void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x606D010", Offset = "0x606BE10", VA = "0x18606D010", Slot = "35")]
	public void GDPKDACFHOI(object NBGOKNOECBH, bool CNHKBPCNOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x606C920", Offset = "0x606B720", VA = "0x18606C920", Slot = "33")]
	public void AKIDGLHCFKM(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x606D980", Offset = "0x606C780", VA = "0x18606D980", Slot = "34")]
	public void MLBMJGOMFIE(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x606C890", Offset = "0x606B690", VA = "0x18606C890", Slot = "36")]
	public IDisposable AGEPAADLHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x606D5A0", Offset = "0x606C3A0", VA = "0x18606D5A0", Slot = "91")]
	public virtual bool LIADFDKJKPJ(bool HPJMGJOBPHM, [Out] string OLGJDMIGDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x606DCC0", Offset = "0x606CAC0", VA = "0x18606DCC0")]
	private bool PDHOALLBMNO([Out] string OLGJDMIGDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x606CF80", Offset = "0x606BD80", VA = "0x18606CF80")]
	private bool FHGPFOKBEDE([Out] string OLGJDMIGDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x606DC70", Offset = "0x606CA70", VA = "0x18606DC70", Slot = "37")]
	public bool OPLPIEINEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x606CA20", Offset = "0x606B820", VA = "0x18606CA20", Slot = "38")]
	public void BGDCPLFLPIJ(StringBuilder GOKFJHEEHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x606D360", Offset = "0x606C160", VA = "0x18606D360")]
	private void LAIFAMDAFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x606DB70", Offset = "0x606C970", VA = "0x18606DB70")]
	private void OJLNDMPJAJJ(Func<float> BGEFJBLAGMO, object NBGOKNOECBH, int EHKNDMCNKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x606DA60", Offset = "0x606C860", VA = "0x18606DA60", Slot = "92")]
	public void OGLCCBOHFFC(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x606D2D0", Offset = "0x606C0D0", VA = "0x18606D2D0", Slot = "8")]
	public void KOHDCKFHFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x606D920", Offset = "0x606C720", VA = "0x18606D920", Slot = "9")]
	public void MKKMFAPILFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x606D7C0", Offset = "0x606C5C0", VA = "0x18606D7C0")]
	private void LKFHIEBDCED(float GAODDMEEHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x800B60", Offset = "0x7FF960", VA = "0x180800B60")]
	private float JJJNFKBBCLG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x800B50", Offset = "0x7FF950", VA = "0x180800B50")]
	private float MMJAKPBEIBJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x606D870", Offset = "0x606C670", VA = "0x18606D870")]
	private void MCCFNGOHKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x606D1E0", Offset = "0x606BFE0", VA = "0x18606D1E0", Slot = "55")]
	public void HDNOIKBMCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class MONGOFBBIOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string FKLKONFKAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool LGJPHFBBPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool BPGJEMDABND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int BENNJEGCOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] MBALPLCKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte BPNJNFHGLLC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random ICNKIMFJODM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x606E100", Offset = "0x606CF00", VA = "0x18606E100", Slot = "5")]
	public virtual bool NGAPCHPGHOJ(string BKFABPHJMEI, int FAMNEKFAODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x606E0B0", Offset = "0x606CEB0", VA = "0x18606E0B0", Slot = "6")]
	public virtual bool EJGBEKDODGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x606E060", Offset = "0x606CE60", VA = "0x18606E060", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x606DFE0", Offset = "0x606CDE0", VA = "0x18606DFE0")]
	protected internal void AFGFMMMFKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x606E1D0", Offset = "0x606CFD0", VA = "0x18606E1D0")]
	protected MONGOFBBIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EDNADGPLNEL : MONGOFBBIOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket PCLFIJABGOO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x606BB60", Offset = "0x606A960", VA = "0x18606BB60", Slot = "5")]
	public override bool NGAPCHPGHOJ(string BKFABPHJMEI, int FAMNEKFAODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x606B970", Offset = "0x606A770", VA = "0x18606B970", Slot = "6")]
	public override bool EJGBEKDODGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x56B9960", Offset = "0x56B8760", VA = "0x1856B9960", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x606BE00", Offset = "0x606AC00", VA = "0x18606BE00")]
	public EDNADGPLNEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KDJGENINOEC
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string IJADOMHMOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string DBLOJKKACGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string MALCDDLJIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DIBNMFGNPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E00", Offset = "0x7B2C00", VA = "0x1807B3E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D80", Offset = "0x7B2B80", VA = "0x1807B3D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x606C700", Offset = "0x606B500", VA = "0x18606C700")]
	public KDJGENINOEC(string IAOHADBACOG, string EHNFDGMHPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x606C440", Offset = "0x606B240", VA = "0x18606C440")]
	private void ANOMKBDGDKD(string CIEMFECDAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x606C640", Offset = "0x606B440", VA = "0x18606C640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x606C550", Offset = "0x606B350", VA = "0x18606C550")]
	public string CKKGHPLPGGI(bool NMONKFONPDB = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PKMIACHIPEK
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int CPPLJKLKMLO;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool CKGBGKNJGFB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int LGJDEBKPBGH;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int IBPHOJKMFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KDJGENINOEC NHJNBDGCLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string LBHOIBOFLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int CLMFCFCBACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int PFANJKAGCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<KDJGENINOEC> CBGNDDPCLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MONGOFBBIOD EBKNHKBPNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> FHEGGNIIOKD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EJGBEKDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E7F0", VA = "0x18088F9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x949130", Offset = "0x947F30", VA = "0x180949130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x606EAD0", Offset = "0x606D8D0", VA = "0x18606EAD0")]
	public PKMIACHIPEK(KDJGENINOEC NHJNBDGCLOJ, Action<KDJGENINOEC> JBIFHLFIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x606E290", Offset = "0x606D090", VA = "0x18606E290")]
	public bool KJBAIGHFNON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x606E8D0", Offset = "0x606D6D0", VA = "0x18606E8D0")]
	public static string OKIGGODMBOE(string GOICIPPDPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x606E280", Offset = "0x606D080", VA = "0x18606E280")]
	protected internal void CPGHPLGIEJF(object HOLFPPNPJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x606E600", Offset = "0x606D400", VA = "0x18606E600")]
	protected internal bool KMNOLCKDHJG()
	{
		return default(bool);
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
