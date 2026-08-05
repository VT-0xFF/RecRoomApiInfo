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
public interface OBDMGCOMFAH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> DEPPKAFBEID;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDHNODFDDLI(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGCBNFMLIHO(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLGFFLONGHE(object OEDJKICDDGA, bool JLJBKAOLCLE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable EBFOPLAPBCA();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GBMHPEFCNCM();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJEHDPNJPJG(StringBuilder HMLOLOIKMIM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GOJIOADOOGK(bool ECPPLGGAAEK, [Out] string JCBCIJOKIDD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DDBLMCBJFFN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GLMCHCFHMND
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	KDCBBOMBFHA PIKCAPHALEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EJOFKFAKOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KFFFOBNAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MGKHINFIJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MAFHPAEHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PMFKPMAIGDD BFKNPIBDEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NIJMHJFMGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KDCBBOMBFHA, KDCBBOMBFHA> GKJODMMABCL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGEFAJCNAPA(PCBLDEMOMCD PEGGANACAPA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FICABKJLAEE();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DKFBAACOBFO(string NHEGDNOFGCH, AEGMFPOLEHB NOBNGLDNMOL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NAHHOKAIFHL();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JHBMKDPMEPF(AppSettings LFCDMOIICNP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KDCBBOMBFHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HMFAFNPKFNK FNLHCDHBBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	ICGHPMPFHFO NIBNDFMCGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MAFHPAEHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool EJOFKFAKOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JLOJHJHLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception JACOOJILMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode INBLHHMJAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PCBLDEMOMCD.HLABFCAGEJI LJBKOPHCGIA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HMFAFNPKFNK, HMFAFNPKFNK> BJKOFOCFOGP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void APKNLAEFCMM(object PKMPGPJICGL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFLLPPCKKPL(object KAKCOBAHAOH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LHPCHHNCOEE(byte DKBJDCFDNLF, int DGMGNCFDIHK, object PHGGMGHAANF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KKAINCKHGJC
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event PCBLDEMOMCD.HLABFCAGEJI LJBKOPHCGIA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LHPCHHNCOEE NHFALKKMGMJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FBEOAGDFCNN(byte DKBJDCFDNLF, Hashtable KFFHIDGGIJK, BEDMKFCADEJ LANJHNJOOBH, SendOptions IBGCLNOPPFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IBFOKJMNDNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NMCPPAKMEBO EGNMAFKFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int DMAAPFEGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int OKKEHECKHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OGPLEDGKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int ILILDIGGIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<NMCPPAKMEBO> APAHHADGACM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	NMCPPAKMEBO NEKOHLLMEPI(int EGHHENCPOKH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BNBMPGKPEIB
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action NKINGNCGJIE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHPLKFNGCLI();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFABGGACIHJ : DDBLMCBJFFN, OBDMGCOMFAH, KKAINCKHGJC, IBFOKJMNDNJ, BNBMPGKPEIB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int MBFJLOOFAML
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int KPKEEIJDJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float DHHEFKENBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float LGMDHIFNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ODOKGBIIDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CFOJONKAPCA NBNHOLKJIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MCLPIIJHDNE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHMNEAADCDB();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBDCGNONPBP();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DKNFLHDFPFC(string DCDCFPGPEPM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CFOJONKAPCA
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DEKOENIMPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EJGPILGIEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<OJJCNALPDGO> OFKHBBIEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JEHHJENPMEL(Action JJFPBOKIAAA, string GJPNECFOFAM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MFPPACECHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string MKEPBKDFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 KBHBDHIEKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion JAFLFHHIBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 KHHMHIKNGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int ILMHFFKPBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> OLIBDNBLNHP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A14390", Offset = "0x6A13390", VA = "0x186A14390")]
	public object[] IDIDPLMLDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public MFPPACECHFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FEILPMPECCF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A11BD0", Offset = "0x6A10BD0", VA = "0x186A11BD0")]
	public static bool GOHOKHGPLHA(this DDBLMCBJFFN LMADLGBLPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A11B00", Offset = "0x6A10B00", VA = "0x186A11B00")]
	public static bool FFHJGKHNAOH(this DDBLMCBJFFN LMADLGBLPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GLHCEEBGIJB : BFABGGACIHJ, DDBLMCBJFFN, OBDMGCOMFAH, KKAINCKHGJC, IBFOKJMNDNJ, BNBMPGKPEIB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class DAFNOAENCJG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GLHCEEBGIJB PNJAJBOEOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool MMNAIEEGDFD;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A11AA0", Offset = "0x6A10AA0", VA = "0x186A11AA0")]
		public DAFNOAENCJG(GLHCEEBGIJB PNJAJBOEOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A119A0", Offset = "0x6A109A0", VA = "0x186A119A0", Slot = "1")]
		~DAFNOAENCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A11910", Offset = "0x6A10910", VA = "0x186A11910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A11A40", Offset = "0x6A10A40", VA = "0x186A11A40")]
		private void KAPHNELGMLK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object HIFIENHMFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object DGJOEMCPPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float LMNNCGNDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float BKOANONDICN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool NIJMHJFMGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float OGMLKNPBDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int MBFJLOOFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int KPKEEIJDJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract NMCPPAKMEBO EGNMAFKFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DMAAPFEGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A11C70", Offset = "0x6A10C70", VA = "0x186A11C70", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int OKKEHECKHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int ILILDIGGIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OGPLEDGKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A11F60", Offset = "0x6A10F60", VA = "0x186A11F60", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float DHHEFKENBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D0A50", Offset = "0x8CFA50", VA = "0x1808D0A50", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B40", Offset = "0x6A11B40", VA = "0x186A12B40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float LGMDHIFNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B60", Offset = "0x8CFB60", VA = "0x1808D0B60", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A11F20", Offset = "0x6A10F20", VA = "0x186A11F20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool ODOKGBIIDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract CFOJONKAPCA NBNHOLKJIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool GLMCHCFHMND
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract KDCBBOMBFHA PIKCAPHALEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool EJOFKFAKOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool KFFFOBNAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool MGKHINFIJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool MAFHPAEHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract PMFKPMAIGDD BFKNPIBDEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private GENPGFDOLOA BOLMIAGDEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private GENPGFDOLOA ADFBDEHKIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BBAKHMHBGDD<Func<float>> DFGFDDFPPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool DPJAFKOPFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xE73040", Offset = "0xE72040", VA = "0x180E73040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool GNNMLFLFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A12300", Offset = "0x6A11300", VA = "0x186A12300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool FNKAOKOAOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A12910", Offset = "0x6A11910", VA = "0x186A12910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event PCBLDEMOMCD.HLABFCAGEJI LJBKOPHCGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A12E80", Offset = "0x6A11E80", VA = "0x186A12E80", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A129F0", Offset = "0x6A119F0", VA = "0x186A129F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event LHPCHHNCOEE NHFALKKMGMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<NMCPPAKMEBO> APAHHADGACM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<KDCBBOMBFHA, KDCBBOMBFHA> GKJODMMABCL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> DEPPKAFBEID
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A12EF0", Offset = "0x6A11EF0", VA = "0x186A12EF0", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A131A0", Offset = "0x6A121A0", VA = "0x186A131A0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action MCLPIIJHDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B80", Offset = "0x6A11B80", VA = "0x186A12B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A12950", Offset = "0x6A11950", VA = "0x186A12950", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action NKINGNCGJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A12AA0", Offset = "0x6A11AA0", VA = "0x186A12AA0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A13000", Offset = "0x6A12000", VA = "0x186A13000", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract NMCPPAKMEBO NEKOHLLMEPI(int EGHHENCPOKH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool JHBMKDPMEPF(AppSettings LFCDMOIICNP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void NAHHOKAIFHL();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool FICABKJLAEE();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void GANDOLOEDGP();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool FBEOAGDFCNN(byte DKBJDCFDNLF, Hashtable KFFHIDGGIJK, BEDMKFCADEJ LANJHNJOOBH, SendOptions IBGCLNOPPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool DKFBAACOBFO(string NHEGDNOFGCH, AEGMFPOLEHB NOBNGLDNMOL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void DKNFLHDFPFC(string DCDCFPGPEPM);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void DGEFAJCNAPA(PCBLDEMOMCD PEGGANACAPA);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A132B0", Offset = "0x6A122B0", VA = "0x186A132B0")]
	protected GLHCEEBGIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A11DE0", Offset = "0x6A10DE0", VA = "0x186A11DE0")]
	public void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A11E00", Offset = "0x6A10E00", VA = "0x186A11E00", Slot = "35")]
	public void BLGFFLONGHE(object OEDJKICDDGA, bool JLJBKAOLCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A11CE0", Offset = "0x6A10CE0", VA = "0x186A11CE0", Slot = "33")]
	public void BDHNODFDDLI(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A12A60", Offset = "0x6A11A60", VA = "0x186A12A60", Slot = "34")]
	public void IGCBNFMLIHO(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A11FF0", Offset = "0x6A10FF0", VA = "0x186A11FF0", Slot = "36")]
	public IDisposable EBFOPLAPBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A126F0", Offset = "0x6A116F0", VA = "0x186A126F0", Slot = "91")]
	public virtual bool GOJIOADOOGK(bool ECPPLGGAAEK, [Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A124C0", Offset = "0x6A114C0", VA = "0x186A124C0")]
	private bool GHNBKPMBMPK([Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A12350", Offset = "0x6A11350", VA = "0x186A12350")]
	private bool FBIPHGNKOBD([Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A123E0", Offset = "0x6A113E0", VA = "0x186A123E0", Slot = "37")]
	public bool GBMHPEFCNCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A12080", Offset = "0x6A11080", VA = "0x186A12080", Slot = "38")]
	public void EJEHDPNJPJG(StringBuilder HMLOLOIKMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A12CD0", Offset = "0x6A11CD0", VA = "0x186A12CD0")]
	private void MJDKJFBFLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A12660", Offset = "0x6A11660", VA = "0x186A12660")]
	private void GLOFABCFNLF(Func<float> IBJEMOBFCID, object OEDJKICDDGA, int NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A13250", Offset = "0x6A12250", VA = "0x186A13250", Slot = "92")]
	public void OIPNFIMMAGH(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A12430", Offset = "0x6A11430", VA = "0x186A12430", Slot = "8")]
	public void GHMNEAADCDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A12FA0", Offset = "0x6A11FA0", VA = "0x186A12FA0", Slot = "9")]
	public void NBDCGNONPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A130F0", Offset = "0x6A120F0", VA = "0x186A130F0")]
	private void OEEAEEHOEBF(float MNIKPDPFHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8D0B60", Offset = "0x8CFB60", VA = "0x1808D0B60")]
	private float OBJNBDIDNOE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8D0A50", Offset = "0x8CFA50", VA = "0x1808D0A50")]
	private float NGPHMHLGKFM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A12C20", Offset = "0x6A11C20", VA = "0x186A12C20")]
	private void LCJDNNANNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A130A0", Offset = "0x6A120A0", VA = "0x186A130A0", Slot = "55")]
	public void NHPLKFNGCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class BCOADPHLCNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string CLCNLGMDLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool IKICIPKAOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool LGIMBMGLDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int POIDIEEAOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] DAGHODLLKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte MFCBIPHDFDA;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random CDGMDGMDCPN;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A116C0", Offset = "0x6A106C0", VA = "0x186A116C0", Slot = "5")]
	public virtual bool FECGEBAHKME(string LCHNGFIJOBI, int JCEBAOIBEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A11790", Offset = "0x6A10790", VA = "0x186A11790", Slot = "6")]
	public virtual bool MCCMKIGDPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A11670", Offset = "0x6A10670", VA = "0x186A11670", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A11710", Offset = "0x6A10710", VA = "0x186A11710")]
	protected internal void IPJLDPAJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A11860", Offset = "0x6A10860", VA = "0x186A11860")]
	protected BCOADPHLCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HACPNOJABMI : BCOADPHLCNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket IBHHCOBJOPB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A13430", Offset = "0x6A12430", VA = "0x186A13430", Slot = "5")]
	public override bool FECGEBAHKME(string LCHNGFIJOBI, int JCEBAOIBEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A136D0", Offset = "0x6A126D0", VA = "0x186A136D0", Slot = "6")]
	public override bool MCCMKIGDPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FACCF0", Offset = "0x5FABCF0", VA = "0x185FACCF0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A138C0", Offset = "0x6A128C0", VA = "0x186A138C0")]
	public HACPNOJABMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NLBIJKLKHLB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string KLFOAHAAGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string DNNKKDBJAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string PHLCPJMEAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int INMKFNGPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x868830", Offset = "0x867830", VA = "0x180868830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x868810", Offset = "0x867810", VA = "0x180868810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A14760", Offset = "0x6A13760", VA = "0x186A14760")]
	public NLBIJKLKHLB(string KEFHKMFECFI, string FHOAFCBIOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A14590", Offset = "0x6A13590", VA = "0x186A14590")]
	private void OCGAGCEJLFK(string EDBNEDIEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A146A0", Offset = "0x6A136A0", VA = "0x186A146A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A144A0", Offset = "0x6A134A0", VA = "0x186A144A0")]
	public string MMCPJIPKLNO(bool ABNLLHBDPJG = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IAPJDDJGPAI
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int LMJANPJGHOA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool GINNDGEIFMO;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int AKFFEFHHDJF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int FKDCILOCENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NLBIJKLKHLB EMFFDDIOLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string OGAPINECDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int BGKNBNHPDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int HOHBOOOPNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<NLBIJKLKHLB> NDDECKDIFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BCOADPHLCNP HNMNKJBJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> DHBIPNPHLLI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MCCMKIGDPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7BEE0", Offset = "0xA7AEE0", VA = "0x180A7BEE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB508C0", Offset = "0xB4F8C0", VA = "0x180B508C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A141F0", Offset = "0x6A131F0", VA = "0x186A141F0")]
	public IAPJDDJGPAI(NLBIJKLKHLB EMFFDDIOLKK, Action<NLBIJKLKHLB> AAHAHOMGDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A139A0", Offset = "0x6A129A0", VA = "0x186A139A0")]
	public bool BKDEJNGAEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A13FE0", Offset = "0x6A12FE0", VA = "0x186A13FE0")]
	public static string MNBMIPPPOOO(string OBFIKMEDILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A14160", Offset = "0x6A13160", VA = "0x186A14160")]
	protected internal void OBOAEEDFDLF(object FFHIJMOJNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A13D10", Offset = "0x6A12D10", VA = "0x186A13D10")]
	protected internal bool JPHFIBMBKBM()
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
