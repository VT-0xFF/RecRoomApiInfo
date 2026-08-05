using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Avatars.Face;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CILLLPGOPDN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Desktop_Valve,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Desktop_Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	PS4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Desktop_MicrosoftVR,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Desktop_VRMissing,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OculusQuest,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	iOS,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AndroidMobile,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PicoNeo3,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PicoPhoenix
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum DGDPJJINGJE
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Desktop_Valve = 1,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Desktop_Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	PS4 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Desktop_MicrosoftVR = 8,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Desktop_VRMissing = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OculusQuest = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	iOS = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	XboxOne = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	AndroidMobile = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	PS5 = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	XboxSeries = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	PicoNeo3 = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	PicoPhoenix = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BHEHMMDICBG
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PlayerEvents
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OLBOGHBBEMG
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NDBLGLFMHMP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OCIJFNEFLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPEADHEOPHA(object PIPCHJCEPPJ, bool KCONFHICJHG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OLLNIJMHDDG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HKBLLKNLFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Vector3 OGKOIHAKEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 LKJOGCFGDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Camera BKJCIFDCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GameObject CCNNOMNBKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LHHMAIMCEBF NKAHMJBJKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CAPEMHJDAJL FDINDLMBDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KIHFBMEPPCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float FNCMOEBCCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ABFNBGFDLCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DEMHKNBOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CAPEMHJDAJL LEHBCAMIMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NJKJJEHKKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DKAAMDDNMIJ(OGIKDEMJHKP PHIJDHKACIA, OGIKDEMJHKP MLMBCBKCGCH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GELJIACMLLN : ILBNIHNMGNA, MEDNDKGIJOJ, AAGBFKOLLGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CAPEMHJDAJL OILKINBGKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	RegionInfo CKNNOOGLHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HDDHCHHIKGN CCACNEELKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CJGCPDFJPEI IJMCOECJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CILLLPGOPDN AJGHPPFIBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BPKIGNHCIKC HNBMLCFHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool GLAIELAGJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool AGMCMEICDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MCKGHCJHPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CNCKDMILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BDOODKJGCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JDAANHHFIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ONHPGCKFMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GAHJNACJOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FNFCBJEHDPL<DateTime?> GetPlatformProfileDateOfBirth();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IsEULARequired();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string GetEULA();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AcceptEULA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DFJLMOHJECJ PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DFJLMOHJECJ RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "21")]
	FNFCBJEHDPL<OLBOGHBBEMG> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "22")]
	DFJLMOHJECJ RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "23")]
	DFJLMOHJECJ RequestContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool HasContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanAskForContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool SupportsLinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool IsCrossPlatformWarningRequired();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AcceptCrossPlatformWarning();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool IsForcedIsolationByPlatformSettings([Out] string KHJKFGCKLBG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool IsSiloedMatchmakingEnabled();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool RequestCrossPlatformMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool RequestSiloedMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "34")]
	PIOBKANCBOH.FHBOGFLHJPA GetPlatformFriendPicture(string CIKHJBGMPII);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LHHMAIMCEBF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float AMFCKBFODPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AOEFFMLCCIP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BLBDOCGMJEO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KIMPBFHCGIN.NHNLCHEMPLA> DPGFODFCAMG;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOFOFJGDBNF(LOJJHHLEGKF FIPLAFPJPLO);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJFPHKNFCNB();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGODPBNICHB(KIMPBFHCGIN.NHNLCHEMPLA EKGFFBBHBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AELAGNGNIKD
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GIDCMHKOCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LLOOCEOEBKF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 BMNEHJDJDGN(FaceFeatureType EFJKIIGCNEI);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float OFICBEPKNGC(FaceFeatureType EFJKIIGCNEI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JEOAPOHNDJE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(GDKACJAAJHN DFCJJMKLPII, string KDAEMHOMKOL, float AIKHKAOPEOH, [Optional] Action ELLFKJCIDIE, [Optional] object MGKMEDKPKNC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(GDKACJAAJHN DFCJJMKLPII, float LBHDNFMOILI, GFDLNIDJHGM ALAAHHKHLGB, string KDAEMHOMKOL, Color? ADAEPGIJJGD, string CNBIMICNCNJ, Color? DMLIAACJJEM, float AIKHKAOPEOH, [Optional] Action ELLFKJCIDIE, [Optional] object MGKMEDKPKNC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PlayVirtualWatchNotification(IBDPDDCJGLH LACIBLEADOC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum GFDLNIDJHGM
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum GDKACJAAJHN
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Max
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKONEOAOHBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private bool DOGOENLNADA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DGMONEEDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B28A0", Offset = "0x7B10A0", VA = "0x1807B28A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA403E0", Offset = "0xA3EBE0", VA = "0x180A403E0")]
	public void IAGLHCAFIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public CKONEOAOHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HGNEMBOBOLH
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HMOLCCMKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CKONEOAOHBP> EFHJJAKLPPB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMIEBMKOJNG();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HJNDDJAKGAN EAOGMGEDMEC();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDNDOIPMMEH(FKPFAMNLICF MOHHJLIGFPM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBLGBFGADMN(HPLHBCMKJGK BMIBLOMHPBB, MDHHLNLKLJD DKIOOMJDCMJ, string EPPHGHMBDEO, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGLEKBODOKB(string HFOHFDFIFLC, FKPFAMNLICF HPFBLJCCNJH, bool NMGLNKCHPEH = false);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EOFBODOBBLC(int AJEJCPPFLLB, Matchmaking.PKALBMBGFEO GEKMFBADGBG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BBLFFLBIAKM(HPLHBCMKJGK BMIBLOMHPBB, MDHHLNLKLJD DKIOOMJDCMJ, int AJEJCPPFLLB, FKPFAMNLICF HPFBLJCCNJH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGKJCJEBCOP(HPLHBCMKJGK BMIBLOMHPBB, MDHHLNLKLJD DKIOOMJDCMJ, IBDPDDCJGLH BLIIPADADPE, FKPFAMNLICF HPFBLJCCNJH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AKFIFKEMIDL(HPLHBCMKJGK BMIBLOMHPBB, ChatMessage DINJFPADOAN, long MBFNOGNPBLB, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FMIBJJDGFKJ(MDHHLNLKLJD DKIOOMJDCMJ, FKPFAMNLICF HPFBLJCCNJH, Matchmaking.PKALBMBGFEO GEKMFBADGBG, bool DJOAKICNANJ, string GBHPJFAHHAA = "");

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NDPJDLEBMDE(long EJLCNJNHKAA, HJNDDJAKGAN LOOHHHNKMDN, bool CFNPDIDJOCC, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NDPJDLEBMDE(string MPHFJKEFEEA, HJNDDJAKGAN LOOHHHNKMDN, bool CFNPDIDJOCC, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDPJDLEBMDE(HPLHBCMKJGK BMIBLOMHPBB, HJNDDJAKGAN LOOHHHNKMDN, bool CFNPDIDJOCC, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NDPJDLEBMDE(IJALLNAAJOE BMIBLOMHPBB, HJNDDJAKGAN LOOHHHNKMDN, bool CFNPDIDJOCC, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JOMJOONLJOG(long EJLCNJNHKAA, long KEECHBIDKCE, HJNDDJAKGAN LOOHHHNKMDN, bool CFNPDIDJOCC, List<int> PLCDBMKCONB, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NDPJDLEBMDE(HPLHBCMKJGK BMIBLOMHPBB, MDHHLNLKLJD DKIOOMJDCMJ, HJNDDJAKGAN LOOHHHNKMDN, bool CFNPDIDJOCC, [Optional] string EPPHGHMBDEO, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE, string GBHPJFAHHAA = "", [Optional] FNDAMPCNFND GBFJAJLHCCO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ALEIEKIGLFA(HJNDDJAKGAN LOOHHHNKMDN, [Optional] Action<BFOAKAFINEI> HPDAOKFBLPE);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DFJLMOHJECJ NKCFAEGDHGM(OBFAKAGJLIH EOCPKOPFDLA, FKPFAMNLICF HPFBLJCCNJH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool GEJLBKMIKEH(NJGJMBFILMP CFLFPBLHKIG, FKPFAMNLICF HPFBLJCCNJH, Matchmaking.JODFLDNEGJF MJGHAAKKGHA = Matchmaking.JODFLDNEGJF.PublicMatchmaking, bool LKMANAPEGOA = true);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JBHHJMIFLBP
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CHBJDEDBAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OMPADHDKEJI
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	CAPEMHJDAJL EPNEKJBMJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DFFPCGOGBND
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NGJNJHDCLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool IHELJNGLAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GKJJKCKJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> MGFOLOHNFNN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DFJLMOHJECJ BEOOEHJNGDH();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EIINKABGMIM(long JGDOGIDPOOC);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LHCIMGJFOIK(int AJEJCPPFLLB, string EGCCGOIMLDH, [Optional] HPLHBCMKJGK LCPPCFEJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HLBBNJFGOCF(HPLHBCMKJGK BMIBLOMHPBB, bool FFBCPCBHCGA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HJNDDJAKGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FKPFAMNLICF MEHKFOPKLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public long CJCGIODPEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public long INJBNOAJIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public string NKACIDKLMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public string MKBLIIOAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public CHMKHLJJAAF? ONAHIBLAAIP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CHMKHLJJAAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public string OBDPEEDKENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string[] LGOAOABHCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Dictionary<string, string> GAIDDPFINLN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FKPFAMNLICF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	NOT_SET = 0,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	BOOT = 1,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	GAME_LOADING_NEXT_LEVEL = 2,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	PORTAL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	AFK = 4,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	VOTE_KICKED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CHEAT = 6,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	ROOM_BANNED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	ACCEPTED_GAME_INVITE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	PARTY_ACTIVITY_SWITCH = 9,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	NOTIFICATION_PLAYER_EVENT = 11,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	PEOPLE_MENU = 12,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ACTIVITY_SELECT_MENU = 13,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	PERSISTENCE_ERROR = 14,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CIRCUIT_REINITIALIZE_ERROR = 15,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BULLETIN_BOARD_FEATURED_ROOMS = 16,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Obsolete]
	__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	QUIT = 19,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	EVENT_DIRECT_GOTO = 20,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	EVENT_NOTIFICATION = 21,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	REC_CENTER_SLIDESHOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	COHORT_NUX = 23,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	QUICK_LAUNCH_MENU = 24,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	ANNOUNCEMENT = 25,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	DEPRECATED_1 = 26,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	DELAYED_ROOM_WARNING = 27,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ROOM_CODE = 28,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ROOM_COMMENT_NOTIFICATION = 29,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CLUBHOUSE_DIRECT_GOTO = 30,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	FORCE_THROUGH_ADMIN_SITE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RECOMMENDED_ROOMS_WATCH = 33,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	INSTANCE_FORCE_CLOSED = 34,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	HOT_ROOMS_WATCH = 35,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	LIVE_ROOMS_WATCH = 36,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	SEARCH_ROOMS_WATCH = 37,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	FAVORITE_ROOMS_WATCH = 38,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	DOOR_SELECT_WATCH = 39,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	FEATURED_ROOMS_WATCH = 40,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	RECNET_ROOMS_WATCH = 41,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	NEW_ROOMS_WATCH = 42,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	ROOM_COMMENT_TELEPORT = 43,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CURATED_PLAYLISTS_WATCH = 44,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PLAYER_EVENT_CODE = 45,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ROOM_REJOIN_WATCH = 47,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PLAYER_EVENT_DETAILS_WATCH = 48,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	RECENT_ROOMS_WATCH = 49,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	FRIEND_PRESENCE_ROOMS_WATCH = 50,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	MY_CLUBHOUSE_ROOMS_WATCH = 51,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	TOP_CREATORS_ROOMS_WATCH = 53,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[Obsolete]
	RISING_ROOMS_WATCH = 88,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	HOME_LOGIN = 121,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	HOME_ROOM = 122,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PLAY_MENU_BANNER = 123,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	QUICK_ORIENTATION_DOOR = 124,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CAROUSEL_ENDPOINT_WATCH = 125,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HEARTBEAT_TIMEOUT = 126,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	MULTIPLAYER_TESTING_COMMAND = 127,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	JOIN_NEW_FRIEND = 128,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BFOAKAFINEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool LLDHAJMNLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Matchmaking.DFAOLODLOLP FMBLEEBJFJG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9A20", Offset = "0x5CA8220", VA = "0x185CA9A20")]
	public BFOAKAFINEI(Matchmaking.DFAOLODLOLP GDLCNBAFCBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NICKOKPDGLB
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDMJLJHLDOM(NHKJOGGKLGM LLFKACGECFF, List<KeepsakeInstanceDTO> GLKHMHLCLBL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BPKIGNHCIKC
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Portrait
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
