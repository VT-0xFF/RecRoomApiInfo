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
public interface MIDKGLAMACK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> CGGPMLDOBFI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCPJPKMDLNJ(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKEADAGLCJJ(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNGPABAPNMC(object ICNJFMMNIKL, bool HFFHJCKPPOB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable IJNECMPKKGF();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BNMPLBNODOA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MAHKKGEIHIJ(StringBuilder ABCGDFCFHDH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GLINPBEBBGC(bool HOGCCGJJHID, [Out] string NBDBHDLNPOA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AECJFPCHIKO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IKAIIFCKLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DDHLBHKGDOH DGDHJEOJMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OPDIJAKKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHFLLHBCAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HBFHJOIGJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LHNKEFMGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NLFGFHMOBMH HKOCPIMJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DLCELLFEKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DDHLBHKGDOH, DDHLBHKGDOH> ECIKADBOMEI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLHACKBEGNO(NMKDINPJMFI DHCPEELKIPN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JOEGLDPALMB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool ECCJHMAFBJH(string OABOBACJGBF, CPGEMGMMHGM KJFPDLDGGKO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OBOLMEBAKPG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IKILCCEFCIL(AppSettings NCNIMCNONPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DDHLBHKGDOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EODGKJMDMOP DOLCFNDFKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	LFBPEJPMPMC OHMPHKMANPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LHNKEFMGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OPDIJAKKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FAJCBCPPJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception NFCEPFMHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode IJMFNJMGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NMKDINPJMFI.LHEOJDCMAFI DGMMFJJFLAC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<EODGKJMDMOP, EODGKJMDMOP> GEOFEFMPANO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MAFJEAIFLKJ(object NDIKGOAJKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NJLIKJECOLA(object DPNGMEFAPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LINFFCIIKOO(byte AOKJGDOHJKF, int OJFHGENBFGL, object LMBNCDMECGI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NOAEFICHGNF
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NMKDINPJMFI.LHEOJDCMAFI DGMMFJJFLAC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LINFFCIIKOO GPLGOONPEKP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FMAAIOJGADE(byte AOKJGDOHJKF, Hashtable PEIJDDPODFJ, KHPGHDNGJCL FKNBJDFLNEI, SendOptions DALOOFKKEBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NAHCCHAGEKA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MKFCBDEMMMH FMIBLLPPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int PIOLMEPBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int NOMLHLNGGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool HJDGMNKJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int AKIPPAKADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MKFCBDEMMMH> EDJJIGKHNBB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	MKFCBDEMMMH BAFILHMCLPP(int OLDNHJFKKLH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DBJJBGLBHHI
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PLLHMPLJGJH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCMIMBCNALA();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EBJMBPHPLIM : AECJFPCHIKO, MIDKGLAMACK, NOAEFICHGNF, NAHCCHAGEKA, DBJJBGLBHHI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int KMDHKEKLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int BBMNCLFBOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float KFLKBBLCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float DKACMKBIIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DPJJLCIBFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	ABEHBAPOKBD IFAJHDNDBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action EGLMDBLAFCG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBJLOFEGCML();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEEKGODGJEF();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FKMPKPPOBCJ(string IJGCOBGOFIN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ABEHBAPOKBD
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OGEPBNBDMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MCCEBCLCJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<LFBJFOJCANL> ALGPLHBCOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOOPOMKOOEF(Action OANCCDEPOPM, string PJKAGPOCAFD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PEGLAKOENNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string JOLMNNFHCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 COHFCEILEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion NMAJBJOMEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 LDOPBPLJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int BOCMKJLAFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> FCAABEBHNIE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62323E0", Offset = "0x62317E0", VA = "0x1862323E0")]
	public object[] KCLFFEFFGPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public PEGLAKOENNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EJPNPIECBGB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x622F2E0", Offset = "0x622E6E0", VA = "0x18622F2E0")]
	public static bool EBNJMFABCIG(this AECJFPCHIKO CENOJODAGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x622F380", Offset = "0x622E780", VA = "0x18622F380")]
	public static bool MIEAICAAGDP(this AECJFPCHIKO CENOJODAGEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class ONIGAFHBAKP : EBJMBPHPLIM, AECJFPCHIKO, MIDKGLAMACK, NOAEFICHGNF, NAHCCHAGEKA, DBJJBGLBHHI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class IIPDJOHEIOE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ONIGAFHBAKP DGHANHNGCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HFCDDCNLIBB;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x622FDF0", Offset = "0x622F1F0", VA = "0x18622FDF0")]
		public IIPDJOHEIOE(ONIGAFHBAKP DGHANHNGCKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x622FCF0", Offset = "0x622F0F0", VA = "0x18622FCF0", Slot = "1")]
		~IIPDJOHEIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x622FC60", Offset = "0x622F060", VA = "0x18622FC60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x622FD90", Offset = "0x622F190", VA = "0x18622FD90")]
		private void IOLLHBHMLLO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object OMLDAMIHKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object FPHIACMGAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float NJBKJFOFEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float KADBFBAHEKP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool DLCELLFEKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float OJKEEHFEAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int KMDHKEKLFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int BBMNCLFBOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract MKFCBDEMMMH FMIBLLPPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PIOLMEPBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6231070", Offset = "0x6230470", VA = "0x186231070", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int NOMLHLNGGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int AKIPPAKADKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool HJDGMNKJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62312D0", Offset = "0x62306D0", VA = "0x1862312D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float KFLKBBLCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9811C0", Offset = "0x9805C0", VA = "0x1809811C0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6231E30", Offset = "0x6231230", VA = "0x186231E30", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float DKACMKBIIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB850", VA = "0x1808FC450", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6231DF0", Offset = "0x62311F0", VA = "0x186231DF0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool DPJJLCIBFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract ABEHBAPOKBD IFAJHDNDBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool IKAIIFCKLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DDHLBHKGDOH DGDHJEOJMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool OPDIJAKKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool EHFLLHBCAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool HBFHJOIGJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool LHNKEFMGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract NLFGFHMOBMH HKOCPIMJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private LEPMAMFFPJF LDPDGBEGKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private LEPMAMFFPJF FPNAEMDOGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IDJBKGEFNLO<Func<float>> HNBGFLKEMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JDNMHGCJDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCDF8B0", Offset = "0xCDECB0", VA = "0x180CDF8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool BAHPAOKBMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6231B20", Offset = "0x6230F20", VA = "0x186231B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool LILEJABJABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62316A0", Offset = "0x6230AA0", VA = "0x1862316A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event NMKDINPJMFI.LHEOJDCMAFI DGMMFJJFLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6231A10", Offset = "0x6230E10", VA = "0x186231A10", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62321F0", Offset = "0x62315F0", VA = "0x1862321F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event LINFFCIIKOO GPLGOONPEKP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<MKFCBDEMMMH> EDJJIGKHNBB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<DDHLBHKGDOH, DDHLBHKGDOH> ECIKADBOMEI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> CGGPMLDOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6230CB0", Offset = "0x62300B0", VA = "0x186230CB0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6231170", Offset = "0x6230570", VA = "0x186231170", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action EGLMDBLAFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6231A80", Offset = "0x6230E80", VA = "0x186231A80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6231E70", Offset = "0x6231270", VA = "0x186231E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action PLLHMPLJGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6230D60", Offset = "0x6230160", VA = "0x186230D60", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6231FA0", Offset = "0x62313A0", VA = "0x186231FA0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract MKFCBDEMMMH BAFILHMCLPP(int OLDNHJFKKLH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool IKILCCEFCIL(AppSettings NCNIMCNONPJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void OBOLMEBAKPG();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool JOEGLDPALMB();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void OPBJLFGKHMG();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool FMAAIOJGADE(byte AOKJGDOHJKF, Hashtable PEIJDDPODFJ, KHPGHDNGJCL FKNBJDFLNEI, SendOptions DALOOFKKEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool ECCJHMAFBJH(string OABOBACJGBF, CPGEMGMMHGM KJFPDLDGGKO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void FKMPKPPOBCJ(string IJGCOBGOFIN);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void BLHACKBEGNO(NMKDINPJMFI DHCPEELKIPN);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6232260", Offset = "0x6231660", VA = "0x186232260")]
	protected ONIGAFHBAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6230E00", Offset = "0x6230200", VA = "0x186230E00")]
	public void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6231580", Offset = "0x6230980", VA = "0x186231580", Slot = "35")]
	public void HNGPABAPNMC(object ICNJFMMNIKL, bool HFFHJCKPPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62320F0", Offset = "0x62314F0", VA = "0x1862320F0", Slot = "33")]
	public void PCPJPKMDLNJ(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6230C70", Offset = "0x6230070", VA = "0x186230C70", Slot = "34")]
	public void DKEADAGLCJJ(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62316E0", Offset = "0x6230AE0", VA = "0x1862316E0", Slot = "36")]
	public IDisposable IJNECMPKKGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6231360", Offset = "0x6230760", VA = "0x186231360", Slot = "91")]
	public virtual bool GLINPBEBBGC(bool HOGCCGJJHID, [Out] string NBDBHDLNPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6230ED0", Offset = "0x62302D0", VA = "0x186230ED0")]
	private bool FJFGCINKANO([Out] string NBDBHDLNPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6231F10", Offset = "0x6231310", VA = "0x186231F10")]
	private bool MKAEMDOJJBE([Out] string NBDBHDLNPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6230C20", Offset = "0x6230020", VA = "0x186230C20", Slot = "37")]
	public bool BNMPLBNODOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6231B70", Offset = "0x6230F70", VA = "0x186231B70", Slot = "38")]
	public void MAHKKGEIHIJ(StringBuilder ABCGDFCFHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6231770", Offset = "0x6230B70", VA = "0x186231770")]
	private void JNNPJACCDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62310E0", Offset = "0x62304E0", VA = "0x1862310E0")]
	private void FOFPCMAKOMK(Func<float> OEMGFBPIBGB, object ICNJFMMNIKL, int FEOEIKFIFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6232040", Offset = "0x6231440", VA = "0x186232040", Slot = "92")]
	public void OAHHFLLPLJI(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6231920", Offset = "0x6230D20", VA = "0x186231920", Slot = "8")]
	public void KBJLOFEGCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x62319B0", Offset = "0x6230DB0", VA = "0x1862319B0", Slot = "9")]
	public void KEEKGODGJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6231220", Offset = "0x6230620", VA = "0x186231220")]
	private void GDBALKKGBAP(float KCLHELHGLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB850", VA = "0x1808FC450")]
	private float OOHIOFBJKJJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9811C0", Offset = "0x9805C0", VA = "0x1809811C0")]
	private float PGGNIHGEMEC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6230E20", Offset = "0x6230220", VA = "0x186230E20")]
	private void EPLLOKNJCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x62320A0", Offset = "0x62314A0", VA = "0x1862320A0", Slot = "55")]
	public void PCMIMBCNALA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HJLHIKGCCGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string ENECABGDFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool AICIHIDOBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool GNBLLOBEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int IDHPMNBGDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] FCGGLBJJNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte MJDLBLAHCBC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random MFNKCPELMBH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x622F4A0", Offset = "0x622E8A0", VA = "0x18622F4A0", Slot = "5")]
	public virtual bool EPHLHFNILJL(string GHPHKOHJHEF, int EOAJDOPMJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x622F4F0", Offset = "0x622E8F0", VA = "0x18622F4F0", Slot = "6")]
	public virtual bool OCOOLPECODE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x622F450", Offset = "0x622E850", VA = "0x18622F450", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x622F540", Offset = "0x622E940", VA = "0x18622F540")]
	protected internal void PJKLBDDMIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x622F640", Offset = "0x622EA40", VA = "0x18622F640")]
	protected HJLHIKGCCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IBLELDIIJEM : HJLHIKGCCGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket OCOINIOPCDB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x622F6F0", Offset = "0x622EAF0", VA = "0x18622F6F0", Slot = "5")]
	public override bool EPHLHFNILJL(string GHPHKOHJHEF, int EOAJDOPMJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x622F990", Offset = "0x622ED90", VA = "0x18622F990", Slot = "6")]
	public override bool OCOOLPECODE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x585E990", Offset = "0x585DD90", VA = "0x18585E990", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x622FB80", Offset = "0x622EF80", VA = "0x18622FB80")]
	public IBLELDIIJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NDLDFPLBAOK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string BKEJABFGBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string EGEBPIGPBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string GIMHBIAPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HHCCJMBJGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6770", Offset = "0x7C5B70", VA = "0x1807C6770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6230B00", Offset = "0x622FF00", VA = "0x186230B00")]
	public NDLDFPLBAOK(string ILHEFLOIBFO, string HNJLDECIPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6230840", Offset = "0x622FC40", VA = "0x186230840")]
	private void CPOLOHCPGGL(string OPBCBNFJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6230A40", Offset = "0x622FE40", VA = "0x186230A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6230950", Offset = "0x622FD50", VA = "0x186230950")]
	public string KIJFHAJCMBG(bool NPFFKGKOELD = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IPBPCIKFPOL
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int CDFMPIBDHBP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool LFILDPECIEH;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int HPDCJICOANF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int KELEKKKOBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NDLDFPLBAOK DCFEINJJCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string BMNJDPDNKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int FJPBFLPGDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MMHLPAELLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<NDLDFPLBAOK> PCIHHOPEAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HJLHIKGCCGF PDEECGFLPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> PNOAHDLJHII;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OCOOLPECODE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x900930", Offset = "0x8FFD30", VA = "0x180900930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F4100", Offset = "0x9F3500", VA = "0x1809F4100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62306A0", Offset = "0x622FAA0", VA = "0x1862306A0")]
	public IPBPCIKFPOL(NDLDFPLBAOK DCFEINJJCHK, Action<NDLDFPLBAOK> AAJMCLBBDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6230130", Offset = "0x622F530", VA = "0x186230130")]
	public bool OEBPOHMGJLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62304A0", Offset = "0x622F8A0", VA = "0x1862304A0")]
	public static string PJIGGFIHMHF(string EKMILMONAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x622FE50", Offset = "0x622F250", VA = "0x18622FE50")]
	protected internal void ALNCLCFPIKK(object APOKKKDAFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x622FE60", Offset = "0x622F260", VA = "0x18622FE60")]
	protected internal bool IOCGCLPFFJB()
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
