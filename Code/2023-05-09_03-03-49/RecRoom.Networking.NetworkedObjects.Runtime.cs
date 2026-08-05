using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using Photon.Realtime;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JBCOPJLAOBK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<bool> AKFIMGFMJMI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOLDJHNJIFL(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DINPCKKKMDP(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOGKLPHEKGF(object HMAOAMDKNDD, bool LGEKOMMHEKE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDisposable HDCJELFGGOH();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HFDMMNJIODG();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAHDJDKBPBB(StringBuilder BJOLBOBHNOM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DKOJJDLGMFF(bool EIAFOPMBJND, out string MCCDEFDHGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HHHOMAALJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MGMANCALBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	CMNPGAGDAKP KCPDPNPLOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GNHJIMPBMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FOPFDIKGDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MKGHBDLBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BBEMOCBECHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OEIFPALANCF IGJBLKGEEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NLAJOJDPNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CMNPGAGDAKP, CMNPGAGDAKP> PBIANGKABGG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKKNAGLECPB(GFDFLGJJFAD PNHFHFEKKEI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BPEDAFKJKKO();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KJCKHIGDKJI(string HCGJDMCKKKP, IKNLJFKFIHI ALCJHBMOGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EBMLJJAJAJG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PAJANPADOOO(AppSettings GJMLGFOOEIH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CMNPGAGDAKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HABHKOJGFGD LBEHOBEJOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[CanBeNull]
	DIJKNHKOCAG EPONNLPICFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BBEMOCBECHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GNHJIMPBMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FLAHAOOKAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[CanBeNull]
	Exception AAKJIAFFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	StatusCode BNEKEGFJJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GFDFLGJJFAD.LDPKPINOAGO JKJFKGGHBKF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HABHKOJGFGD, HABHKOJGFGD> BHDDNEPAPEK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GMLLNMFBECH(object BJCKADBMKDM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AFPBGOFEGEK(object CLHAJLFIOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ANJAJNHAKMM(byte HOMHFHCGLFH, int EHNJPBPFDKD, object JBCBBGBMKAI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AMENDGDHLBN
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GFDFLGJJFAD.LDPKPINOAGO JKJFKGGHBKF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event ANJAJNHAKMM FMAAOJJBNPO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FLNEICPGKKN(byte HOMHFHCGLFH, Hashtable CAHJAILBJPF, LAEEIOHLCNI JNEIDDLHNGJ, SendOptions KJCFEGHLLML);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IDNDKOAELLL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DLMMMHADHKF JDEBACJMPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int IAEOJHPMEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int EBGANJMOALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool JIKGPIEGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MGKGOEAHEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<DLMMMHADHKF> BMKFMOLMHOI;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[CanBeNull]
	DLMMMHADHKF LAKGDNLNFHD(int GCMFMJNNEBK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HPBJOLPLAOL
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action ADLMOJEKEMI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGABEGAJHDE();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OCLEBINCMDF : HHHOMAALJBC, JBCOPJLAOBK, AMENDGDHLBN, IDNDKOAELLL, HPBJOLPLAOL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int OBENCNOJNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int FEDPLGJHPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float OOAKJIOMEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float AOIFFDOILDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MMMEKOCPNJE LACHNAHFIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action EKHHJNAOHKG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENHLJLAPAAB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOBODIBLKMN();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GIMDDBGIANB(string HHEHFPCELMD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMMEKOCPNJE
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CPAJGBDMAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CCKEMJAKAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<GNOGEIDJAOD> IFKGNPKPLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CIDPNHKGOFG(Action OKAPGOOFJHM, string EBOKANCJDBD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FLEAHHDHCDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string BLMFNJICLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Vector3 NKAKGAAIHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Quaternion POCEHKCMLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Vector3 PEMIOODAJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int POOBEKKEMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Dictionary<string, object> DFGFJECBADF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E11350", Offset = "0x1E0FD50", VA = "0x181E11350")]
	public object[] FEFDANPAKEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public FLEAHHDHCDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class FOHNKICACJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public string ECAIGHDDBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public bool EECCEFFCGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected internal bool FOCLJAJJDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected internal int GIFKEKEICDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected internal byte[] IALNFKBEPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected internal byte KGBMENCLPOL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static readonly System.Random HHKCAIMNNLA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1E11480", Offset = "0x1E0FE80", VA = "0x181E11480", Slot = "5")]
	public virtual bool DCDJGPEPGFB(string JGJDMACFHOP, int HACMNJOLGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E11590", Offset = "0x1E0FF90", VA = "0x181E11590", Slot = "6")]
	public virtual bool OEJCKKEFKLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E114C0", Offset = "0x1E0FEC0", VA = "0x181E114C0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1E11500", Offset = "0x1E0FF00", VA = "0x181E11500")]
	protected internal void LFPDFEJCFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E11640", Offset = "0x1E10040", VA = "0x181E11640")]
	protected FOHNKICACJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KBEKGHFFLFN : FOHNKICACJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Socket KACODDANBGC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1E11860", Offset = "0x1E10260", VA = "0x181E11860", Slot = "5")]
	public override bool DCDJGPEPGFB(string JGJDMACFHOP, int HACMNJOLGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E11B20", Offset = "0x1E10520", VA = "0x181E11B20", Slot = "6")]
	public override bool OEJCKKEFKLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x18885A0", Offset = "0x1886FA0", VA = "0x1818885A0", Slot = "7")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E11D10", Offset = "0x1E10710", VA = "0x181E11D10")]
	public KBEKGHFFLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LFEMLGAOFIL
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string JKBBIHHAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string CKHHMIPILFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string AMFBJKDNABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EGOEAKGCCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4060", VA = "0x1807E5660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5650", Offset = "0x7E4050", VA = "0x1807E5650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E120B0", Offset = "0x1E10AB0", VA = "0x181E120B0")]
	public LFEMLGAOFIL(string NPLNFGPIAPP, string IHILHEFJHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E11DF0", Offset = "0x1E107F0", VA = "0x181E11DF0")]
	private void HMAMBDGAFMP(string HACBJHBFMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E11FF0", Offset = "0x1E109F0", VA = "0x181E11FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F00", Offset = "0x1E10900", VA = "0x181E11F00")]
	public string KJFLIDJFKCI(bool FDGCPGLLOPA = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MPGCHIGNEEG
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static int ICMDANJFANP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static bool OHHDDHOGEHH;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static int NDMADBBJMFG;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static int POJKDNACFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private LFEMLGAOFIL IOAFPEBHIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private string MKODMBGGMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int ACAGHCKDKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int PPJDACDKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Action<LFEMLGAOFIL> LJEDPCJDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private FOHNKICACJE AOMNIEIFIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<int> ADGHMLKNJDC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool OEJCKKEFKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1E12A80", Offset = "0x1E11480", VA = "0x181E12A80")]
	public MPGCHIGNEEG(LFEMLGAOFIL IOAFPEBHIEA, Action<LFEMLGAOFIL> DGNKIEFBPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1E121D0", Offset = "0x1E10BD0", VA = "0x181E121D0")]
	public bool AJFOCJFBCII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E12880", Offset = "0x1E11280", VA = "0x181E12880")]
	public static string NAPKDPFCNAM(string PJOOFAJJMAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E129F0", Offset = "0x1E113F0", VA = "0x181E129F0")]
	protected internal void OCDLMIHDJGB(object BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E12580", Offset = "0x1E10F80", VA = "0x181E12580")]
	protected internal bool LILLKHFANHC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HFLMDFKODAC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E116F0", Offset = "0x1E100F0", VA = "0x181E116F0")]
	public static bool ECGDGPFMIDO(this HHHOMAALJBC MGDCPAJLLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E11790", Offset = "0x1E10190", VA = "0x181E11790")]
	public static bool EFOJEPIDLJP(this HHHOMAALJBC MGDCPAJLLOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PBLBLNDHIKN : OCLEBINCMDF, HHHOMAALJBC, JBCOPJLAOBK, AMENDGDHLBN, IDNDKOAELLL, HPBJOLPLAOL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class CCGEDMFLLOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly PBLBLNDHIKN KKHHCIGPHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E112F0", Offset = "0x1E0FCF0", VA = "0x181E112F0")]
		public CCGEDMFLLOI(PBLBLNDHIKN KKHHCIGPHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E11260", Offset = "0x1E0FC60", VA = "0x181E11260", Slot = "1")]
		~CCGEDMFLLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E111D0", Offset = "0x1E0FBD0", VA = "0x181E111D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1E11170", Offset = "0x1E0FB70", VA = "0x181E11170")]
		private void DICBPJDPLNJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly object EPFDEGLKHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly object NGEFFONJHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float DDEGDDNEOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float OPFGGJOEIIK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract bool NLAJOJDPNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract float FMHGIBPAGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract int OBENCNOJNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public abstract int FEDPLGJHPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public abstract DLMMMHADHKF JDEBACJMPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int IAEOJHPMEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E13910", Offset = "0x1E12310", VA = "0x181E13910", Slot = "47")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract int EBGANJMOALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract int MGKGOEAHEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JIKGPIEGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E13E60", Offset = "0x1E12860", VA = "0x181E13E60", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float OOAKJIOMEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AD0", Offset = "0x7D14D0", VA = "0x1807D2AD0", Slot = "73")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1E13C80", Offset = "0x1E12680", VA = "0x181E13C80", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float AOIFFDOILDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E44F0", Offset = "0x7E2EF0", VA = "0x1807E44F0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E132E0", Offset = "0x1E11CE0", VA = "0x181E132E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract MMMEKOCPNJE LACHNAHFIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "75")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public abstract bool MGMANCALBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public abstract CMNPGAGDAKP KCPDPNPLOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public abstract bool GNHJIMPBMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public abstract bool FOPFDIKGDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "81")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "82")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract bool MKGHBDLBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "83")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public abstract bool BBEMOCBECHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract OEIFPALANCF IGJBLKGEEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private MLJMKOJHCLB ACFJGBMJMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private MLJMKOJHCLB FDLLCAEMFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private global::HCFBMAIGBGM<Func<float>> FPIKCHFAIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool JKENEPJHKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D17B60", Offset = "0x1D16560", VA = "0x181D17B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected bool EPBEDDFDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E136E0", Offset = "0x1E120E0", VA = "0x181E136E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	protected bool MFMJLABBKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E13A50", Offset = "0x1E12450", VA = "0x181E13A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event GFDFLGJJFAD.LDPKPINOAGO JKJFKGGHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E13320", Offset = "0x1E11D20", VA = "0x181E13320", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E14020", Offset = "0x1E12A20", VA = "0x181E14020", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	[method: Cpp2IlInjected.Token(Token = "0x600006D")]
	[method: Cpp2IlInjected.Address(Slot = "55")]
	public abstract event ANJAJNHAKMM FMAAOJJBNPO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	[method: Cpp2IlInjected.Token(Token = "0x600006F")]
	[method: Cpp2IlInjected.Address(Slot = "57")]
	public abstract event Action<DLMMMHADHKF> BMKFMOLMHOI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	[method: Cpp2IlInjected.Token(Token = "0x6000086")]
	[method: Cpp2IlInjected.Address(Slot = "76")]
	public abstract event Action<CMNPGAGDAKP, CMNPGAGDAKP> PBIANGKABGG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<bool> AKFIMGFMJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E137D0", Offset = "0x1E121D0", VA = "0x181E137D0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1E13B40", Offset = "0x1E12540", VA = "0x181E13B40", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action EKHHJNAOHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E13D20", Offset = "0x1E12720", VA = "0x181E13D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E13DC0", Offset = "0x1E127C0", VA = "0x181E13DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action ADLMOJEKEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E13AA0", Offset = "0x1E124A0", VA = "0x181E13AA0", Slot = "52")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E13BE0", Offset = "0x1E125E0", VA = "0x181E13BE0", Slot = "53")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	public abstract DLMMMHADHKF LAKGDNLNFHD(int GCMFMJNNEBK);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "68")]
	public abstract bool PAJANPADOOO(AppSettings GJMLGFOOEIH);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	public abstract void EBMLJJAJAJG();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	public abstract bool BPEDAFKJKKO();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	public abstract void MHMINBOJOCE();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "72")]
	public abstract bool FLNEICPGKKN(byte HOMHFHCGLFH, Hashtable CAHJAILBJPF, LAEEIOHLCNI JNEIDDLHNGJ, SendOptions KJCFEGHLLML);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "86")]
	public abstract bool KJCKHIGDKJI(string HCGJDMCKKKP, IKNLJFKFIHI ALCJHBMOGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "87")]
	public abstract void GIMDDBGIANB(string HHEHFPCELMD);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "88")]
	public abstract void BKKNAGLECPB(GFDFLGJJFAD PNHFHFEKKEI);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1E14150", Offset = "0x1E12B50", VA = "0x181E14150")]
	protected PBLBLNDHIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E14000", Offset = "0x1E12A00", VA = "0x181E14000")]
	public void NCBKDFJCMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1E13EE0", Offset = "0x1E128E0", VA = "0x181E13EE0", Slot = "34")]
	public void KOGKLPHEKGF(object HMAOAMDKNDD, bool LGEKOMMHEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1E131E0", Offset = "0x1E11BE0", VA = "0x181E131E0", Slot = "32")]
	public void BOLDJHNJIFL(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E13420", Offset = "0x1E11E20", VA = "0x181E13420", Slot = "33")]
	public void DINPCKKKMDP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1E13970", Offset = "0x1E12370", VA = "0x181E13970", Slot = "35")]
	public IDisposable HDCJELFGGOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E13460", Offset = "0x1E11E60", VA = "0x181E13460", Slot = "89")]
	public virtual bool DKOJJDLGMFF(bool EIAFOPMBJND, out string MCCDEFDHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1E12FB0", Offset = "0x1E119B0", VA = "0x181E12FB0")]
	private bool BINAIFIIOGE(out string MCCDEFDHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1E13150", Offset = "0x1E11B50", VA = "0x181E13150")]
	private bool BNJNJPCCFFD(out string MCCDEFDHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1E13A00", Offset = "0x1E12400", VA = "0x181E13A00", Slot = "36")]
	public bool HFDMMNJIODG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1E12CF0", Offset = "0x1E116F0", VA = "0x181E12CF0", Slot = "37")]
	public void BAHDJDKBPBB(StringBuilder BJOLBOBHNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1E12B40", Offset = "0x1E11540", VA = "0x181E12B40")]
	private void AKIEBAFDKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1E13390", Offset = "0x1E11D90", VA = "0x181E13390")]
	private void CKMAFFELAMM(Func<float> ODJJEDNAJKP, object HMAOAMDKNDD, int ALIOAOHFFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1E13680", Offset = "0x1E12080", VA = "0x181E13680", Slot = "90")]
	public void DNPPGOMKFHA(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1E13730", Offset = "0x1E12130", VA = "0x181E13730", Slot = "8")]
	public void ENHLJLAPAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1E13CC0", Offset = "0x1E126C0", VA = "0x181E13CC0", Slot = "9")]
	public void IOBODIBLKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1E13870", Offset = "0x1E12270", VA = "0x181E13870")]
	private void FHBLGJPBBCM(float BELNMJHFEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E44F0", Offset = "0x7E2EF0", VA = "0x1807E44F0")]
	private float BDOIEHJNNFD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D2AD0", Offset = "0x7D14D0", VA = "0x1807D2AD0")]
	private float IHEGJLBKAIH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E14090", Offset = "0x1E12A90", VA = "0x181E14090")]
	private void PIJCCANIIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B300", Offset = "0x1D19D00", VA = "0x181D1B300", Slot = "54")]
	public void MGABEGAJHDE()
	{
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
