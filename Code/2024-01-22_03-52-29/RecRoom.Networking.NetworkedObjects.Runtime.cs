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
public interface AGPJNGGKNOH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> GMAOGKCLODF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNHLLCOEOJE(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHGMGBMODOG(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCKAPAMPGLK(object KNOHBODGPLL, bool MJIFAMDFBLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable FLHAHFDALJH();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JKALDEEMDGB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LMKIIGKCIJM(StringBuilder NNKJMIOLDFB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DBPGECDGEEH(bool BJFGIECFNLO, [Out] string HNINMPIFBCK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MBGAMHPIKJN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GKPAPLEJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LOEMEMKGHLB ADCJDLGBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CKDHPEEANCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNBCNLIMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DBAKBCHNJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BLPIJHIPMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NOMKPFBJFAB EKEEPMHGAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OCAHLCGHEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LOEMEMKGHLB, LOEMEMKGHLB> HAJDKEDCKCB;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEINFEANNEM(MMINHFOHKIE AICHEBOPGIK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NLPHCJMFBFM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CNFBILBJBJF(string NCNGDIECCFF, HJIBPGJCLKM EOCHKPLEHDL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LJMAFPLGJKD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JFJJKEOFCIG(AppSettings CKHPOEFHLIM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LOEMEMKGHLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MHICJPFLJPF MIBENLAMJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	GCBHOOBCPBI ABGJLBEANKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BLPIJHIPMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool CKDHPEEANCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MICJAOLPJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception COFAODKBGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode JLPBCKLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MMINHFOHKIE.GLPGCPMCAKF MDNLPPOACKG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<MHICJPFLJPF, MHICJPFLJPF> PCFAMAOMOMN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FHONBPEDMEJ(object GOOANMNBGEP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KBJOHPABLBK(object LHEOAKILKNE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void KPJIIKBGKKO(byte BDHILNNIDIC, int LMKNMDIBABJ, object FILLDNNEIPF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DKGBAMEIMKM
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MMINHFOHKIE.GLPGCPMCAKF MDNLPPOACKG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KPJIIKBGKKO NJPCFCNINKG;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPNMHICPNHE(byte BDHILNNIDIC, Hashtable MHNGFGOPOBD, HJCNKEFGNPK KKAGEHONDNL, SendOptions IBJLDEOBJJG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BDPIAJLENML
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	LGNHMFCMNEG HAOLPOPCPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int OPJNAMHFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int MHMNPJNMONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool AECOKGLFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int PEEOMJKHHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<LGNHMFCMNEG> OMCHAHMHGOF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	LGNHMFCMNEG LJIBINPAHIL(int IENHMGCHNBA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NIBPODHBPEG
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action IHGAEMFKKAB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKACPMMMLNC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JMAOJLKJGNB : MBGAMHPIKJN, AGPJNGGKNOH, DKGBAMEIMKM, BDPIAJLENML, NIBPODHBPEG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int FHPKCEEHJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int HHJKIODAPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float MAJJNGMMNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float JCGBKGOOBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AFPENMAHBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HLBLOCIEAFE FLGGOKPBHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action BGEIHGBBBHO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLKMGCBLGFE();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDFHPDBPODH();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JMPOPDLAIIK(string KHMECCOFHJB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HLBLOCIEAFE
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool AHJJABBAGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BJOGCKJOKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<MOALNCLCADB> IMBLMIGMIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEMDKMHOLFF(Action NGPLCEEBCDL, string BHPPHNFFKMC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LIACPJHHNMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string EKCNOPOMBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 CNEKGDKGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion LABHFJHFGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 PDJIIHOINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int EMKCLJGCBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> FKHDMJNINDL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6069480", Offset = "0x6068880", VA = "0x186069480")]
	public object[] AMLFEMJHDDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public LIACPJHHNMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FFGIHGHEJKO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60692F0", Offset = "0x60686F0", VA = "0x1860692F0")]
	public static bool LGBLOMNOMLA(this MBGAMHPIKJN JNHICIBJDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6069220", Offset = "0x6068620", VA = "0x186069220")]
	public static bool GABHAGJCKAD(this MBGAMHPIKJN JNHICIBJDOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class MKPMNMMLHIJ : JMAOJLKJGNB, MBGAMHPIKJN, AGPJNGGKNOH, DKGBAMEIMKM, BDPIAJLENML, NIBPODHBPEG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class EGMLDKOLPNF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MKPMNMMLHIJ AOLNHIENEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BIPKAKIEIHN;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60691C0", Offset = "0x60685C0", VA = "0x1860691C0")]
		public EGMLDKOLPNF(MKPMNMMLHIJ AOLNHIENEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60690C0", Offset = "0x60684C0", VA = "0x1860690C0", Slot = "1")]
		~EGMLDKOLPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6069030", Offset = "0x6068430", VA = "0x186069030", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6069160", Offset = "0x6068560", VA = "0x186069160")]
		private void MGMGJJMKNCL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object LCMMIILDFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object HLBEBCEOKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float JKMOJNDAGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float OPGAMAFAHLJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool OCAHLCGHEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float JBIIGBFLOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int FHPKCEEHJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int HHJKIODAPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract LGNHMFCMNEG HAOLPOPCPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OPJNAMHFKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60696B0", Offset = "0x6068AB0", VA = "0x1860696B0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int MHMNPJNMONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int PEEOMJKHHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool AECOKGLFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x60695D0", Offset = "0x60689D0", VA = "0x1860695D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float MAJJNGMMNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E4340", Offset = "0x7E3740", VA = "0x1807E4340", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6069590", Offset = "0x6068990", VA = "0x186069590", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float JCGBKGOOBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EF0", Offset = "0x7E42F0", VA = "0x1807E4EF0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6069E70", Offset = "0x6069270", VA = "0x186069E70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool AFPENMAHBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract HLBLOCIEAFE FLGGOKPBHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool GKPAPLEJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract LOEMEMKGHLB ADCJDLGBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool CKDHPEEANCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool LNBCNLIMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool DBAKBCHNJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool BLPIJHIPMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract NOMKPFBJFAB EKEEPMHGAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private GDJEDKCANMC KIPHKNHIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private GDJEDKCANMC LKJOJCEPHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private EEIHPOEIPJJ<Func<float>> JIFBBDJLJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool OBNNDGMNBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC50F90", Offset = "0xC50390", VA = "0x180C50F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool OGEMDJPPBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x606A8D0", Offset = "0x6069CD0", VA = "0x18606A8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool MKPAOCLGGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x606A920", Offset = "0x6069D20", VA = "0x18606A920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event MMINHFOHKIE.GLPGCPMCAKF MDNLPPOACKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x606A080", Offset = "0x6069480", VA = "0x18606A080", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x606A680", Offset = "0x6069A80", VA = "0x18606A680", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event KPJIIKBGKKO NJPCFCNINKG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<LGNHMFCMNEG> OMCHAHMHGOF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<LOEMEMKGHLB, LOEMEMKGHLB> HAJDKEDCKCB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> GMAOGKCLODF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x606AA80", Offset = "0x6069E80", VA = "0x18606AA80", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x606A2A0", Offset = "0x60696A0", VA = "0x18606A2A0", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action BGEIHGBBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6069940", Offset = "0x6068D40", VA = "0x186069940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x606AB30", Offset = "0x6069F30", VA = "0x18606AB30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action IHGAEMFKKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x606A6F0", Offset = "0x6069AF0", VA = "0x18606A6F0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x606A1A0", Offset = "0x60695A0", VA = "0x18606A1A0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract LGNHMFCMNEG LJIBINPAHIL(int IENHMGCHNBA);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool JFJJKEOFCIG(AppSettings CKHPOEFHLIM);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void LJMAFPLGJKD();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool NLPHCJMFBFM();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void OPDMLMAMCNK();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool DPNMHICPNHE(byte BDHILNNIDIC, Hashtable MHNGFGOPOBD, HJCNKEFGNPK KKAGEHONDNL, SendOptions IBJLDEOBJJG);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool CNFBILBJBJF(string NCNGDIECCFF, HJIBPGJCLKM EOCHKPLEHDL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void JMPOPDLAIIK(string KHMECCOFHJB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void AEINFEANNEM(MMINHFOHKIE AICHEBOPGIK);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x606ABD0", Offset = "0x6069FD0", VA = "0x18606ABD0")]
	protected MKPMNMMLHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6069D30", Offset = "0x6069130", VA = "0x186069D30")]
	public void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x606A960", Offset = "0x6069D60", VA = "0x18606A960", Slot = "35")]
	public void PCKAPAMPGLK(object KNOHBODGPLL, bool MJIFAMDFBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x606A7D0", Offset = "0x6069BD0", VA = "0x18606A7D0", Slot = "33")]
	public void MNHLLCOEOJE(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x606A790", Offset = "0x6069B90", VA = "0x18606A790", Slot = "34")]
	public void MHGMGBMODOG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6069D50", Offset = "0x6069150", VA = "0x186069D50", Slot = "36")]
	public IDisposable FLHAHFDALJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6069720", Offset = "0x6068B20", VA = "0x186069720", Slot = "91")]
	public virtual bool DBPGECDGEEH(bool BJFGIECFNLO, [Out] string HNINMPIFBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6069B90", Offset = "0x6068F90", VA = "0x186069B90")]
	private bool FHDDPDICKGL([Out] string HNINMPIFBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6069F40", Offset = "0x6069340", VA = "0x186069F40")]
	private bool GNGFELDINDO([Out] string HNINMPIFBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x606A150", Offset = "0x6069550", VA = "0x18606A150", Slot = "37")]
	public bool JKALDEEMDGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x606A400", Offset = "0x6069800", VA = "0x18606A400", Slot = "38")]
	public void LMKIIGKCIJM(StringBuilder NNKJMIOLDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60699E0", Offset = "0x6068DE0", VA = "0x1860699E0")]
	private void FBECDIKKNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6069DE0", Offset = "0x60691E0", VA = "0x186069DE0")]
	private void GBDKELKHKHN(Func<float> KFCMIFACMLM, object KNOHBODGPLL, int OLBHFMHNDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x606A240", Offset = "0x6069640", VA = "0x18606A240", Slot = "92")]
	public void KFAEICMAKLA(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6069EB0", Offset = "0x60692B0", VA = "0x186069EB0", Slot = "8")]
	public void GLKMGCBLGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x606A0F0", Offset = "0x60694F0", VA = "0x18606A0F0", Slot = "9")]
	public void JDFHPDBPODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6069FD0", Offset = "0x60693D0", VA = "0x186069FD0")]
	private void GPAOLAODADP(float AEOPAJNOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EF0", Offset = "0x7E42F0", VA = "0x1807E4EF0")]
	private float NCDCDMKACAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E4340", Offset = "0x7E3740", VA = "0x1807E4340")]
	private float NFAEAKKGGED()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x606A350", Offset = "0x6069750", VA = "0x18606A350")]
	private void LKDKIGLMKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6069660", Offset = "0x6068A60", VA = "0x186069660", Slot = "55")]
	public void BKACPMMMLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class OJACFEPDLOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string LPJAEBAOIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool IPAFFOFDKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool HAALFMFLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int PDFLKDKNBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] EAFOKKHEBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte KPFMMHJAAHG;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random PNOGCANDFCA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x606AE70", Offset = "0x606A270", VA = "0x18606AE70", Slot = "5")]
	public virtual bool MHDDKFMCJAP(string JCGBAICAINI, int HKGKDHIIFJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x606ADD0", Offset = "0x606A1D0", VA = "0x18606ADD0", Slot = "6")]
	public virtual bool BPJOOHCJIPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x606AE20", Offset = "0x606A220", VA = "0x18606AE20", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x606AD50", Offset = "0x606A150", VA = "0x18606AD50")]
	protected internal void AFJDDCCJNFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x606AF40", Offset = "0x606A340", VA = "0x18606AF40")]
	protected OJACFEPDLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PDGAPEMFBJO : OJACFEPDLOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket PBABCOECECD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x606BAE0", Offset = "0x606AEE0", VA = "0x18606BAE0", Slot = "5")]
	public override bool MHDDKFMCJAP(string JCGBAICAINI, int HKGKDHIIFJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x606B8F0", Offset = "0x606ACF0", VA = "0x18606B8F0", Slot = "6")]
	public override bool BPJOOHCJIPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x56E5AE0", Offset = "0x56E4EE0", VA = "0x1856E5AE0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x606BD80", Offset = "0x606B180", VA = "0x18606BD80")]
	public PDGAPEMFBJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CPFLFAMMFMN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string MCPKJGHLFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LKGHGKALFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x792A30", Offset = "0x791E30", VA = "0x180792A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EIGCIOPBJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x792A40", Offset = "0x791E40", VA = "0x180792A40")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DEAEJOKOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x797290", Offset = "0x796690", VA = "0x180797290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7979E0", Offset = "0x796DE0", VA = "0x1807979E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6068F10", Offset = "0x6068310", VA = "0x186068F10")]
	public CPFLFAMMFMN(string FDOCGCEBHBF, string LBCMLBDKDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6068D40", Offset = "0x6068140", VA = "0x186068D40")]
	private void GFNODCKMMAB(string BEALPBMEONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6068E50", Offset = "0x6068250", VA = "0x186068E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6068C50", Offset = "0x6068050", VA = "0x186068C50")]
	public string CABKHHCLAFF(bool OJCDACOBNMA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PBBKNMLEOKM
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int HAPNOLEIJBL;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool BCDLJAGPDBO;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int CPIFJNFLDOK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int NBCLJGPFCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CPFLFAMMFMN BMAHEBFNJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string HJILAHHIFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int HGNIHDPCFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int KNBIKCBDBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<CPFLFAMMFMN> FCOOBFHLMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OJACFEPDLOJ NMELADAGDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> JLDIAMHHNDP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BPJOOHCJIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x87FB90", Offset = "0x87EF90", VA = "0x18087FB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x960E20", Offset = "0x960220", VA = "0x180960E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x606B840", Offset = "0x606AC40", VA = "0x18606B840")]
	public PBBKNMLEOKM(CPFLFAMMFMN BMAHEBFNJPN, Action<CPFLFAMMFMN> BBIOACNILMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x606B450", Offset = "0x606A850", VA = "0x18606B450")]
	public bool OFAAPPLMKAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x606B2D0", Offset = "0x606A6D0", VA = "0x18606B2D0")]
	public static string LEEHOAPHFMH(string PFEOCAKIJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x606B2C0", Offset = "0x606A6C0", VA = "0x18606B2C0")]
	protected internal void EFDEGJGJCNF(object AOGDICEMNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x606AFF0", Offset = "0x606A3F0", VA = "0x18606AFF0")]
	protected internal bool BFONKIOINIK()
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
