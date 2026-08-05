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
public interface LMBHPFDPKGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> EDLAJABALMJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APJEHBBLCLG(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHDMDPDFHDH(object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NILJDNGIGCP(object DJIBMMAIGPE, bool CLACCHGMAEE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable AMCBHBOEGEP();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EEPJOADCCGE();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILMKKOCDBDN(StringBuilder GLMEBNDONIG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MHLGKCOFBIP(bool BLCFBAEGPCO, [Out] string EHELKEOJPOO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EBOACCHNLCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ADFKDDNMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	CBAIMFKKAGL LFMLPDMKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OCEAGEMFABG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PFMCJFNGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GJLDECIEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KJIBFCILNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MOAOKHPGJMM EANPFDGKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AEGLBMIJKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CBAIMFKKAGL, CBAIMFKKAGL> JMNDNIAABAI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGPHKIMNMJN(BCLFFFPJFPJ KHPBGKMELMP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HGBKIHNNHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NKFKLNMOBNI(string BNGNFKENNIN, FPFNJLKMBOD CEBNDNAEMOE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CGMCPKIJKKA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LOJOCIBALLB(AppSettings IKDHLKNBJPD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CBAIMFKKAGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OCLCADDIFDD INHGOAIPOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	DAGJBDDCHIC CNBCHHEKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KJIBFCILNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OCEAGEMFABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PBFAEHLMCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception FOFPMEMFPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode PAOAOEPAFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BCLFFFPJFPJ.FONDPIANDIE PJPAGDNPOEL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<OCLCADDIFDD, OCLCADDIFDD> FFHPONHMDNC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKICPJEIAMJ(object KAEDHDLBKFF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GHHMLLLFIOE(object KMNHLDINMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ADEMFPPICOH(byte KNDLICIEHED, int OIGBOPKMBBG, object AOIHJKDLECK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHGPOLHNGOK
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BCLFFFPJFPJ.FONDPIANDIE PJPAGDNPOEL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ADEMFPPICOH PJMFNLOEHKK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JBEFCMDOBLA(byte KNDLICIEHED, Hashtable DPOMCMMELEP, KDBJHGPGGMN HDCDPDDPEHF, SendOptions EENGILGBAPE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GCGMGNAOHCB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EEPDJJKFILM MCDLKPFDKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int GPMEKKPHCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int HNKCAGAPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool DAEPGHIJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int OCFMNEJIOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<EEPDJJKFILM> GHFLOCOECKD;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	EEPDJJKFILM FAHPJBKEMIM(int KFDCPIPJNMG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FDIGNGAOFAD
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action MKAOLAPPFOC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJBAANLGMPM();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EIHCBOIGFHH : EBOACCHNLCM, LMBHPFDPKGJ, HHGPOLHNGOK, GCGMGNAOHCB, FDIGNGAOFAD
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int MMIFHCEDBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int BMPMFNLMJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float IEHIBFEMALD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float BIAGCJNKDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OLFGGNKDFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	DPCPOPGPFOO NCANAGOOFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action IHPCCKFPCFK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADKGNDMKPOL();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFFLCHCPMLF();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NLLMKOLDMPE(string LCHMKBEAIMP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DPCPOPGPFOO
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OLDCFNCNNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CDNAHCBHLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IReadOnlyList<AIOFMJODIPI> GGDOCEGJAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJAPLILPNIA(Action EEICMJOMPBL, string EJGHJHJJGGI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OOEMAMLCALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string MAOFBEBAFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 ANCEDMGEKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion MBJIPAAIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 NIOEAOFFDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CCFJCDEEPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> AHJGMBOHJIL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A197A0", Offset = "0x6A187A0", VA = "0x186A197A0")]
	public object[] AFPKPNAILPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public OOEMAMLCALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JCBFPOPMDJB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A19510", Offset = "0x6A18510", VA = "0x186A19510")]
	public static bool MGIKLAPKKBL(this EBOACCHNLCM GIBFGCBBGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A19440", Offset = "0x6A18440", VA = "0x186A19440")]
	public static bool DPFNCLJBEHN(this EBOACCHNLCM GIBFGCBBGNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class IFAEIKIHLHE : EIHCBOIGFHH, EBOACCHNLCM, LMBHPFDPKGJ, HHGPOLHNGOK, GCGMGNAOHCB, FDIGNGAOFAD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class OFLHGLHFCOG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IFAEIKIHLHE FLJAHNGNBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool OJOGLGJEHMD;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A19740", Offset = "0x6A18740", VA = "0x186A19740")]
		public OFLHGLHFCOG(IFAEIKIHLHE FLJAHNGNBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A196A0", Offset = "0x6A186A0", VA = "0x186A196A0", Slot = "1")]
		~OFLHGLHFCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A19610", Offset = "0x6A18610", VA = "0x186A19610", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A195B0", Offset = "0x6A185B0", VA = "0x186A195B0")]
		private void CEBILDHGNHC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly object OGKOINACMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly object AOADJEGNDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private float OEOHFJKOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float MEDEDGIHBPD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public abstract bool AEGLBMIJKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public abstract float OMPIECLCFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public abstract int MMIFHCEDBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract int BMPMFNLMJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract EEPDJJKFILM MCDLKPFDKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GPMEKKPHCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A183B0", Offset = "0x6A173B0", VA = "0x186A183B0", Slot = "48")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int HNKCAGAPKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int OCFMNEJIOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DAEPGHIJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A17C80", Offset = "0x6A16C80", VA = "0x186A17C80", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float IEHIBFEMALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x95D9D0", Offset = "0x95C9D0", VA = "0x18095D9D0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A19080", Offset = "0x6A18080", VA = "0x186A19080", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float BIAGCJNKDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x95D980", Offset = "0x95C980", VA = "0x18095D980", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A180C0", Offset = "0x6A170C0", VA = "0x186A180C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract bool OLFGGNKDFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "76")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public abstract DPCPOPGPFOO NCANAGOOFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "77")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract bool ADFKDDNMLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract CBAIMFKKAGL LFMLPDMKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract bool OCEAGEMFABG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool PFMCJFNGOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract bool GJLDECIEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool KJIBFCILNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract MOAOKHPGJMM EANPFDGKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private MBGIGHPFJLL MKINHNMBEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MBGIGHPFJLL AMNGMGJCKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private HPFJCHKIACC<Func<float>> NPCCPEBGAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JOKFALFFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF49690", Offset = "0xF48690", VA = "0x180F49690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected bool LABBCFPBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A18150", Offset = "0x6A17150", VA = "0x186A18150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected bool EDAGPABDGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A18EB0", Offset = "0x6A17EB0", VA = "0x186A18EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event BCLFFFPJFPJ.FONDPIANDIE PJPAGDNPOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A19010", Offset = "0x6A18010", VA = "0x186A19010", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A19210", Offset = "0x6A18210", VA = "0x186A19210", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600004E")]
	[method: Cpp2IlInjected.Address(Slot = "56")]
	public abstract event ADEMFPPICOH PJMFNLOEHKK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x6000050")]
	[method: Cpp2IlInjected.Address(Slot = "58")]
	public abstract event Action<EEPDJJKFILM> GHFLOCOECKD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000068")]
	[method: Cpp2IlInjected.Address(Slot = "78")]
	public abstract event Action<CBAIMFKKAGL, CBAIMFKKAGL> JMNDNIAABAI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> EDLAJABALMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A19160", Offset = "0x6A18160", VA = "0x186A19160", Slot = "31")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A18920", Offset = "0x6A17920", VA = "0x186A18920", Slot = "32")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action IHPCCKFPCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A18880", Offset = "0x6A17880", VA = "0x186A18880", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A190C0", Offset = "0x6A180C0", VA = "0x186A190C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action MKAOLAPPFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A189D0", Offset = "0x6A179D0", VA = "0x186A189D0", Slot = "53")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A187E0", Offset = "0x6A177E0", VA = "0x186A187E0", Slot = "54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract EEPDJJKFILM FAHPJBKEMIM(int KFDCPIPJNMG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract bool LOJOCIBALLB(AppSettings IKDHLKNBJPD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract void CGMCPKIJKKA();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract bool HGBKIHNNHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract void PJNENCHLAJP();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "73")]
	public abstract bool JBEFCMDOBLA(byte KNDLICIEHED, Hashtable DPOMCMMELEP, KDBJHGPGGMN HDCDPDDPEHF, SendOptions EENGILGBAPE);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract bool NKFKLNMOBNI(string BNGNFKENNIN, FPFNJLKMBOD CEBNDNAEMOE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "89")]
	public abstract void NLLMKOLDMPE(string LCHMKBEAIMP);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "90")]
	public abstract void LGPHKIMNMJN(BCLFFFPJFPJ KHPBGKMELMP);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A192C0", Offset = "0x6A182C0", VA = "0x186A192C0")]
	protected IFAEIKIHLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A18C70", Offset = "0x6A17C70", VA = "0x186A18C70")]
	public void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6A18EF0", Offset = "0x6A17EF0", VA = "0x186A18EF0", Slot = "35")]
	public void NILJDNGIGCP(object DJIBMMAIGPE, bool CLACCHGMAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A17E30", Offset = "0x6A16E30", VA = "0x186A17E30", Slot = "33")]
	public void APJEHBBLCLG(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A19280", Offset = "0x6A18280", VA = "0x186A19280", Slot = "34")]
	public void PHDMDPDFHDH(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A17DA0", Offset = "0x6A16DA0", VA = "0x186A17DA0", Slot = "36")]
	public IDisposable AMCBHBOEGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A18C90", Offset = "0x6A17C90", VA = "0x186A18C90", Slot = "91")]
	public virtual bool MHLGKCOFBIP(bool BLCFBAEGPCO, [Out] string EHELKEOJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A18A70", Offset = "0x6A17A70", VA = "0x186A18A70")]
	private bool KNIKDENCEHO([Out] string EHELKEOJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A18420", Offset = "0x6A17420", VA = "0x186A18420")]
	private bool IJPMFHAMAED([Out] string EHELKEOJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A18100", Offset = "0x6A17100", VA = "0x186A18100", Slot = "37")]
	public bool EEPJOADCCGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A184B0", Offset = "0x6A174B0", VA = "0x186A184B0", Slot = "38")]
	public void ILMKKOCDBDN(StringBuilder GLMEBNDONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A18200", Offset = "0x6A17200", VA = "0x186A18200")]
	private void HLNGDFEGKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A18030", Offset = "0x6A17030", VA = "0x186A18030")]
	private void DBKPEHEJEBA(Func<float> COGILGPAJLG, object DJIBMMAIGPE, int NGLFEFNBMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A181A0", Offset = "0x6A171A0", VA = "0x186A181A0", Slot = "92")]
	public void EHKEEIJIMHG(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A17D10", Offset = "0x6A16D10", VA = "0x186A17D10", Slot = "8")]
	public void ADKGNDMKPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A18C10", Offset = "0x6A17C10", VA = "0x186A18C10", Slot = "9")]
	public void LFFLCHCPMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A17F30", Offset = "0x6A16F30", VA = "0x186A17F30")]
	private void BDBNGBODDCK(float AOBFBAOECKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x95D980", Offset = "0x95C980", VA = "0x18095D980")]
	private float GBAILMLHAOA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x95D9D0", Offset = "0x95C9D0", VA = "0x18095D9D0")]
	private float PBILHLGPAOL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A18730", Offset = "0x6A17730", VA = "0x186A18730")]
	private void JAKEKHDOCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A17FE0", Offset = "0x6A16FE0", VA = "0x186A17FE0", Slot = "55")]
	public void CJBAANLGMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class EPHEDCMEGPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public string LFGLEAKONKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool MGBJHDALKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected internal bool DMFLNMALKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected internal int ODNMDDAPAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected internal byte[] EABPLMJACKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected internal byte OBGHNBCDGKK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly System.Random HCGFHNAGJFD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A176D0", Offset = "0x6A166D0", VA = "0x186A176D0", Slot = "5")]
	public virtual bool KGIJOJDIMLO(string PFDGPBHNNNB, int APLBJFAIJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A17720", Offset = "0x6A16720", VA = "0x186A17720", Slot = "6")]
	public virtual bool OKPAGKPNENH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A17680", Offset = "0x6A16680", VA = "0x186A17680", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A17600", Offset = "0x6A16600", VA = "0x186A17600")]
	protected internal void BEDHOPCKIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A177F0", Offset = "0x6A167F0", VA = "0x186A177F0")]
	protected EPHEDCMEGPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DGMNAAKAICI : EPHEDCMEGPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Socket HJLBNIHGLAM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A17090", Offset = "0x6A16090", VA = "0x186A17090", Slot = "5")]
	public override bool KGIJOJDIMLO(string PFDGPBHNNNB, int APLBJFAIJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A17330", Offset = "0x6A16330", VA = "0x186A17330", Slot = "6")]
	public override bool OKPAGKPNENH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA70C0", Offset = "0x5FA60C0", VA = "0x185FA70C0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A17520", Offset = "0x6A16520", VA = "0x186A17520")]
	public DGMNAAKAICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IALHKHIGGKD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string KAKDFNCFBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JDLAALCLJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string INMBIJCLMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int CNEPOGPJPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x854680", Offset = "0x853680", VA = "0x180854680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A17B60", Offset = "0x6A16B60", VA = "0x186A17B60")]
	public IALHKHIGGKD(string KLHABFFOPGM, string JPMKJCMAIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A17990", Offset = "0x6A16990", VA = "0x186A17990")]
	private void FNODBMHHOAJ(string ALLLIEKKMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A17AA0", Offset = "0x6A16AA0", VA = "0x186A17AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A178A0", Offset = "0x6A168A0", VA = "0x186A178A0")]
	public string BCFBGMECKOG(bool GONKKHJKPAN = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DFHBNLJPDBE
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static int LGKMEDPGDFH;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool NHEDKNMHPCD;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static int KEEDKKHJMII;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static int IGAJOKOFCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IALHKHIGGKD MBAIHNLEPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private string GIFHJKIDLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int LDCIMHEENIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int HHCGEJIOPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Action<IALHKHIGGKD> FCDHJNMFHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EPHEDCMEGPC LEAGJDIKGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<int> LBKFIOKMJAH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OKPAGKPNENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49400", VA = "0x180B4A400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC42BC0", Offset = "0xC41BC0", VA = "0x180C42BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A16FE0", Offset = "0x6A15FE0", VA = "0x186A16FE0")]
	public DFHBNLJPDBE(IALHKHIGGKD MBAIHNLEPJK, Action<IALHKHIGGKD> NKFKFGFNIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A16790", Offset = "0x6A15790", VA = "0x186A16790")]
	public bool BHMAKOOBFHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A16B00", Offset = "0x6A15B00", VA = "0x186A16B00")]
	public static string JGMCJOLFAJJ(string LNBFJCNOBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A16F50", Offset = "0x6A15F50", VA = "0x186A16F50")]
	protected internal void OMOAMNDJLEE(object PDLLDMABKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A16C80", Offset = "0x6A15C80", VA = "0x186A16C80")]
	protected internal bool LCEJLGOGEBL()
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
