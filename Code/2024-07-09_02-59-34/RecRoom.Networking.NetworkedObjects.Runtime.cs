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
public interface HBNFDPLNIPP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> NCNBNLDCODM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMCOGODNNJJ(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGJOFHGONMF(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APJJAOHNBEK(object GBENACPKFNA, bool KFFCPJKPHBF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable OHFCDHAGMID();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LPAGBICLMCI();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AEJBCHAAMKJ(StringBuilder GFJGLBPCJNO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HGPMEHFDDMC(bool AGAOAILDEME, [Out] string JMMBJIBOIFP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DALGBEALHGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BLOFKJCIENK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BCENENNMGFP MBDHLFGPJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MJEPNJKHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DNJAAIGABDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool INJOIEDBEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JCAPMNOFICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KFCPGEMLJBB CILKPPBHJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KBMGAIALPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BCENENNMGFP, BCENENNMGFP> GFDCGKOPLGI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNJIMMCBHDD(OOAHIFPHOGI ECIHEOBBGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DNBDIMNPNJL();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool ADCFEGOIEML(string OBOACAFDHFA, NJEHNGDPMNJ PPOBPAIEHPP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LGCHJKLOFLL();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AICPLGNEDCF(AppSettings MOBBMNGPNAL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BCENENNMGFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GHKPGFBCPHO DKBONGIOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	MHKFHIANCLJ NECFBBDINFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JCAPMNOFICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MJEPNJKHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KKJOEIGDAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception CBGCELPBCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode FBCODFDKPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OOAHIFPHOGI.KHEJCLBEAID PIIFHAKDBDL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<GHKPGFBCPHO, GHKPGFBCPHO> CNPFJHKEBCC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CHCFCFGGPFJ(object EEOLDJILHGA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONLAJHDAFOH(object HNFMKKAIPDC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KKHPEIPCDNC(byte INJNDNCLLIE, int AHCALNILMPH, object JBAJGONDFIO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KBMNBMIJCON
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OOAHIFPHOGI.KHEJCLBEAID PIIFHAKDBDL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KKHPEIPCDNC DNPPEGJDICC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDJOOEKHDEB(byte INJNDNCLLIE, Hashtable JIEKNJMCGFP, OEGNPGMBLHF MOFCHHGCFLB, SendOptions CCCOJKFMICE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OCHHHIDLNCF
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MLFBKPIOFCD CJDPMHBENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MINDBLDNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int GCCLMKCPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EIFGBLGGAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int KLCLBODHANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MLFBKPIOFCD> MKJOLOIGLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	MLFBKPIOFCD OFDEAIFOHKH(int DBNMHEADMBD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GHBJCBEFCGI
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action CPODMKAFPNE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPAPMNPJGMH();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LNOBPBGOOIO : DALGBEALHGH, HBNFDPLNIPP, KBMNBMIJCON, OCHHHIDLNCF, GHBJCBEFCGI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int NPIOEHEJNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int JEILEKKBPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float GMLKNHFANIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float CKIELBAJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MAKMFFPNNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	PKHBCMAFPCA ALCOFGKEGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MNIOLMCPFNI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFIBCIIOAFN();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKDJAECPKKP();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IEPBFBOPADH(string LIDFDFPDHGI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PKHBCMAFPCA
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PHJGMJCIMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PBEBEHLDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<JOGDJEJCDPG> DGLAKMALMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHGPLEAMBKN(Action NLBHMDEBKKB, string ONJABGFKMDK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OCEBHCCGGKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string EJEEENONBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 MMKDAECKHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion BHKKDEGOAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 GDGBLDGCHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int IOHGDEAOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> FGFGFEEKBDH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A711E0", Offset = "0x6A6FDE0", VA = "0x186A711E0")]
	public object[] GOBJONDBMKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public OCEBHCCGGKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OJDPBPONACD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A713D0", Offset = "0x6A6FFD0", VA = "0x186A713D0")]
	public static bool OKNCMCGENFC(this DALGBEALHGH IHMBONNJPGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A71300", Offset = "0x6A6FF00", VA = "0x186A71300")]
	public static bool KOEDILCGLJE(this DALGBEALHGH IHMBONNJPGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class PJEIBCOMEAF : LNOBPBGOOIO, DALGBEALHGH, HBNFDPLNIPP, KBMNBMIJCON, OCHHHIDLNCF, GHBJCBEFCGI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GJLKFKAPKED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PJEIBCOMEAF DIGDNEOHMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KLBJCIGNEHB;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A704F0", Offset = "0x6A6F0F0", VA = "0x186A704F0")]
		public GJLKFKAPKED(PJEIBCOMEAF DIGDNEOHMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A70450", Offset = "0x6A6F050", VA = "0x186A70450", Slot = "1")]
		~GJLKFKAPKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A70360", Offset = "0x6A6EF60", VA = "0x186A70360", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A703F0", Offset = "0x6A6EFF0", VA = "0x186A703F0")]
		private void EPKECGGBPCD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object KAEBIECCOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object CCBCFDGOMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float CFDBLOKPOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float DEONOMNPGOC;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool KBMGAIALPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float FKABDLGFNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int NPIOEHEJNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int JEILEKKBPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract MLFBKPIOFCD CJDPMHBENLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MINDBLDNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A71470", Offset = "0x6A70070", VA = "0x186A71470", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int GCCLMKCPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int KLCLBODHANA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool EIFGBLGGAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A714E0", Offset = "0x6A700E0", VA = "0x186A714E0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float GMLKNHFANIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D14B0", Offset = "0x8D00B0", VA = "0x1808D14B0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A72780", Offset = "0x6A71380", VA = "0x186A72780", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float CKIELBAJCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D15C0", Offset = "0x8D01C0", VA = "0x1808D15C0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A71D00", Offset = "0x6A70900", VA = "0x186A71D00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool MAKMFFPNNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract PKHBCMAFPCA ALCOFGKEGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool BLOFKJCIENK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BCENENNMGFP MBDHLFGPJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool MJEPNJKHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool DNJAAIGABDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool INJOIEDBEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool JCAPMNOFICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract KFCPGEMLJBB CILKPPBHJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private IHJBDENMBEB FIJJFKPDJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private IHJBDENMBEB PHIPMPOLOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private CJMPCOCFKOM<Func<float>> KLCMHNNMJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool HIMCLINFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xE782B0", Offset = "0xE76EB0", VA = "0x180E782B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool FFCNEFDFFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A72A50", Offset = "0x6A71650", VA = "0x186A72A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool EAEDEEOGPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A72960", Offset = "0x6A71560", VA = "0x186A72960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event OOAHIFPHOGI.KHEJCLBEAID PIIFHAKDBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A72860", Offset = "0x6A71460", VA = "0x186A72860", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A71B50", Offset = "0x6A70750", VA = "0x186A71B50", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event KKHPEIPCDNC DNPPEGJDICC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<MLFBKPIOFCD> MKJOLOIGLFJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<BCENENNMGFP, BCENENNMGFP> GFDCGKOPLGI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> NCNBNLDCODM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A72080", Offset = "0x6A70C80", VA = "0x186A72080", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A71D40", Offset = "0x6A70940", VA = "0x186A71D40", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action MNIOLMCPFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A719A0", Offset = "0x6A705A0", VA = "0x186A719A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A726E0", Offset = "0x6A712E0", VA = "0x186A726E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action CPODMKAFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A71FE0", Offset = "0x6A70BE0", VA = "0x186A71FE0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A717E0", Offset = "0x6A703E0", VA = "0x186A717E0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract MLFBKPIOFCD OFDEAIFOHKH(int DBNMHEADMBD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool AICPLGNEDCF(AppSettings MOBBMNGPNAL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void LGCHJKLOFLL();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool DNBDIMNPNJL();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void KANAMGKBFAL();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool EDJOOEKHDEB(byte INJNDNCLLIE, Hashtable JIEKNJMCGFP, OEGNPGMBLHF MOFCHHGCFLB, SendOptions CCCOJKFMICE);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool ADCFEGOIEML(string OBOACAFDHFA, NJEHNGDPMNJ PPOBPAIEHPP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void IEPBFBOPADH(string LIDFDFPDHGI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void FNJIMMCBHDD(OOAHIFPHOGI ECIHEOBBGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A72AA0", Offset = "0x6A716A0", VA = "0x186A72AA0")]
	protected PJEIBCOMEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A729A0", Offset = "0x6A715A0", VA = "0x186A729A0")]
	public void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A71880", Offset = "0x6A70480", VA = "0x186A71880", Slot = "35")]
	public void APJJAOHNBEK(object GBENACPKFNA, bool KFFCPJKPHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A72350", Offset = "0x6A70F50", VA = "0x186A72350", Slot = "33")]
	public void HMCOGODNNJJ(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A71FA0", Offset = "0x6A70BA0", VA = "0x186A71FA0", Slot = "34")]
	public void GGJOFHGONMF(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A729C0", Offset = "0x6A715C0", VA = "0x186A729C0", Slot = "36")]
	public IDisposable OHFCDHAGMID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A72130", Offset = "0x6A70D30", VA = "0x186A72130", Slot = "91")]
	public virtual bool HGPMEHFDDMC(bool AGAOAILDEME, [Out] string JMMBJIBOIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A72540", Offset = "0x6A71140", VA = "0x186A72540")]
	private bool KJOIEGHLKFD([Out] string JMMBJIBOIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A71C70", Offset = "0x6A70870", VA = "0x186A71C70")]
	private bool DNMFOHPPIOP([Out] string JMMBJIBOIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A727C0", Offset = "0x6A713C0", VA = "0x186A727C0", Slot = "37")]
	public bool LPAGBICLMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A71570", Offset = "0x6A70170", VA = "0x186A71570", Slot = "38")]
	public void AEJBCHAAMKJ(StringBuilder GFJGLBPCJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A71DF0", Offset = "0x6A709F0", VA = "0x186A71DF0")]
	private void FLNIJLDGNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A72450", Offset = "0x6A71050", VA = "0x186A72450")]
	private void HOBFGEGHGNN(Func<float> JJOHLENKOJL, object GBENACPKFNA, int BOCMOELLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A71A40", Offset = "0x6A70640", VA = "0x186A71A40", Slot = "92")]
	public void CMIJEKKJEOF(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A728D0", Offset = "0x6A714D0", VA = "0x186A728D0", Slot = "8")]
	public void MFIBCIIOAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A724E0", Offset = "0x6A710E0", VA = "0x186A724E0", Slot = "9")]
	public void IKDJAECPKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A71AA0", Offset = "0x6A706A0", VA = "0x186A71AA0")]
	private void COPAJDMENBC(float PLJAGHNHKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8D15C0", Offset = "0x8D01C0", VA = "0x1808D15C0")]
	private float KKKNGCKNOCH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8D14B0", Offset = "0x8D00B0", VA = "0x1808D14B0")]
	private float HFIJFGKGEKI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A71BC0", Offset = "0x6A707C0", VA = "0x186A71BC0")]
	private void DMBHPMIMFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A72810", Offset = "0x6A71410", VA = "0x186A72810", Slot = "55")]
	public void LPAPMNPJGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class GKAEBICOLHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string GAFFIONHDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool DCOCBLEHGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool BCLHIFHDGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int CIHFKNJEMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] JKMIAHMJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte BEDCGIBBPKE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random AIICEACNMCB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A70550", Offset = "0x6A6F150", VA = "0x186A70550", Slot = "5")]
	public virtual bool BIHLNOEAHGA(string LANGKLHABJK, int IKPNOAEKCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A705F0", Offset = "0x6A6F1F0", VA = "0x186A705F0", Slot = "6")]
	public virtual bool IGGECEAOKDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A705A0", Offset = "0x6A6F1A0", VA = "0x186A705A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A70640", Offset = "0x6A6F240", VA = "0x186A70640")]
	protected internal void KCBMKHLALEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A70740", Offset = "0x6A6F340", VA = "0x186A70740")]
	protected GKAEBICOLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CJPGIOPGMFG : GKAEBICOLHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket DJNBJGNILLG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FA10", Offset = "0x6A6E610", VA = "0x186A6FA10", Slot = "5")]
	public override bool BIHLNOEAHGA(string LANGKLHABJK, int IKPNOAEKCNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FCB0", Offset = "0x6A6E8B0", VA = "0x186A6FCB0", Slot = "6")]
	public override bool IGGECEAOKDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x600BFB0", Offset = "0x600ABB0", VA = "0x18600BFB0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FEA0", Offset = "0x6A6EAA0", VA = "0x186A6FEA0")]
	public CJPGIOPGMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DEDHKLCCNNF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string MMNPOHPFLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string KOGFBCJFJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string AJHKFDGHADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LPLPEIIJNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x867CE0", Offset = "0x8668E0", VA = "0x180867CE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x867CD0", Offset = "0x8668D0", VA = "0x180867CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A70240", Offset = "0x6A6EE40", VA = "0x186A70240")]
	public DEDHKLCCNNF(string GNNOHLIDBFM, string OCLHDMKBGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FF80", Offset = "0x6A6EB80", VA = "0x186A6FF80")]
	private void KBELBJCJLJE(string ALPBHBIDHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A70180", Offset = "0x6A6ED80", VA = "0x186A70180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A70090", Offset = "0x6A6EC90", VA = "0x186A70090")]
	public string ONIFFEIBJJK(bool FKBLKKBHOLM = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IGIOIIHAKFD
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int DDGAJFAIBAF;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool INEBEMLPBMO;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int NCPHHKDCPGP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int MGFMGKEMIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private DEDHKLCCNNF KGMHBMCMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string MBBINKLLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int BEIFCFDEGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MOLKIJCKFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<DEDHKLCCNNF> IEMFJEOFCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private GKAEBICOLHG BAIEMELLBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> CGFKFLPCNFN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IGGECEAOKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D6B0", VA = "0x180A7EAB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB55D80", Offset = "0xB54980", VA = "0x180B55D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A71040", Offset = "0x6A6FC40", VA = "0x186A71040")]
	public IGIOIIHAKFD(DEDHKLCCNNF KGMHBMCMGDN, Action<DEDHKLCCNNF> LAKOEOJFOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A70970", Offset = "0x6A6F570", VA = "0x186A70970")]
	public bool CBAJJELMFPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A707F0", Offset = "0x6A6F3F0", VA = "0x186A707F0")]
	public static string BPLBMJHADBI(string JBDKONGGBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A70CE0", Offset = "0x6A6F8E0", VA = "0x186A70CE0")]
	protected internal void CJBHIDALHIF(object NGDLPEOFMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A70CF0", Offset = "0x6A6F8F0", VA = "0x186A70CF0")]
	protected internal bool KGKNHBOCIGG()
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
