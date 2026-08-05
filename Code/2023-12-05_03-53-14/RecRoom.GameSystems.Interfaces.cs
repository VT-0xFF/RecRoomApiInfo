using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Avatars.Face;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ADOKICCMPON
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
public enum CPLCONBMAEI
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
public enum DIKEBKPBPIC
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
public enum EHDPOGMOLJD
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NEDLPONFJLF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FOKFIKJIMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMNMDFMPKEH(object NOEAHPPKHNC, bool LIODHPEEDEI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LOJGJANFOID
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ENDMJOIOGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Vector3 NBLKKPOONNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 HAJEIIBPJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Camera IKNCMOPMJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GameObject CAPEJOEDFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DKBFBGCKGOP KODDPLJIFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FCJKIAIKOOM FGABDJNGFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EBDPEKGONPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float GOLJEPCPHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DPMHBIDJOME
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CDPIJJFMPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FCJKIAIKOOM JPIHGDPGDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PNPNBHMDJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JDEFGHMMOEI(MCGPJKMOCMD AIHPMFJFPFL, MCGPJKMOCMD DPDOJJDCAOP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HEHEJMPHDCF : HNLFHOMIPNE, CDLCEHEDMBF, HMDEKLFJFPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FCJKIAIKOOM MOLMHBIGNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	RegionInfo JPNKINIPBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NMGNHIGAAPA JJNFJKODGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CIAEEKCPLAL NGKFEIAAAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ADOKICCMPON CMDBONJNBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EHJCHDLGKEC FBAHKLGCBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HOLGBNIHEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KNOJBNONAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ALOPHMIPIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PPMIJHHJDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IDMFCHJOFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool INLBCMNILKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HPHKKJAENGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EEBHGPAMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetUnityLauncherToDefault();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CJNEKNCGBDK<DateTime?> GetPlatformProfileDateOfBirth();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool IsEULARequired();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "17")]
	string GetEULA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AcceptEULA();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AIDJGFFPANM PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AIDJGFFPANM RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "22")]
	CJNEKNCGBDK<EHDPOGMOLJD> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AIDJGFFPANM RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "24")]
	AIDJGFFPANM RequestContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool HasContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool CanAskForContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool SupportsLinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IsCrossPlatformWarningRequired();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AcceptCrossPlatformWarning();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool IsForcedIsolationByPlatformSettings([Out] string FNIBNHIEFDM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool IsSiloedMatchmakingEnabled();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool RequestCrossPlatformMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool RequestSiloedMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "35")]
	MDOEGOLIMLI.DFLDEKPIAGJ GetPlatformFriendPicture(string GLPHFKBONKA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "36")]
	CJNEKNCGBDK<EKLGJNIPBCK> GetPlatformPlayerAgeBucket();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DKBFBGCKGOP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float ALBADHHIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MLKFABGJHCI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DAIEJFCNCMG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KGOIAMPEMFO.JHMHMIAGJLJ> BNLGGGFGBIC;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DIIAADOGPAA(HPNNMGEIFJE AECAKKOCJMM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKNCAAGLEBI();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHKDLKINCPK(KGOIAMPEMFO.JHMHMIAGJLJ NGPIEDKICPP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JMONLPDCAMO
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JAFHPHEBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IDGHIPLHLML
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 FPDIFGICEKN(FaceFeatureType HOFCNILJIBL, bool PMMDGIOPMDK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float KHLHEHLJNLB(FaceFeatureType HOFCNILJIBL, bool PMMDGIOPMDK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DFCFAEJDCHE
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(DLLLLHBFCDF HIOMLLGKNDE, string OKBHHGEOCMH, float EMNJLCFBMME, [Optional] Action PDECDCHNHMC, [Optional] object MCDBGGHPLJC);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(DLLLLHBFCDF HIOMLLGKNDE, float AFOEEHJOLOB, PGLFLCLIMEG EFAMANIIGGH, string OKBHHGEOCMH, Color? IPBCFDLMLAN, string NECFOFLBJFI, Color? GIGFFNDDHCC, float EMNJLCFBMME, [Optional] Action PDECDCHNHMC, [Optional] object MCDBGGHPLJC);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PlayVirtualWatchNotification(ANNCEDLOMNK KCFFPPIEBHH);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PlayPlayerProgressionWatchNotification(GHHCEOIPIBO LJIMLOGOIHA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum PGLFLCLIMEG
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum DLLLLHBFCDF
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
public class JGIFANCLOMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private bool BMHELBFDCDN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OBFKMFDKGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C5050", Offset = "0x7C4450", VA = "0x1807C5050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA7A180", Offset = "0xA79580", VA = "0x180A7A180")]
	public void PAMDMJEBANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JGIFANCLOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GEPHCIOCDNF
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HDHKJCICFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<JGIFANCLOMJ> JOOBIEICILN;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIGMILFJEKK();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJINPKMKGBO IFGEDANIBEN();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OKINELNDJNA(AJKEJNGMGDI HFLNDIDMJFD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHPJNMMCNAL(CBKMKOLJPCM ABMDCKAMOCK, MGJLHNELGPC LJCJMACLAJP, string MEFFHKHNBPE, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMJPDMMPJHH(string AECCBCNMEMC, AJKEJNGMGDI IHMCEFGPAEA, bool FFBFCOGNJPA = false);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BPJNDIKHLKK(int IALHMHAHPIN, NKPCOFGMHDA OBKJAKKMMKK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MAKLPPKOBMF(CBKMKOLJPCM ABMDCKAMOCK, MGJLHNELGPC LJCJMACLAJP, int IALHMHAHPIN, AJKEJNGMGDI IHMCEFGPAEA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, ALIKIDLGEJH>> CMLFKEEAMHH(CBKMKOLJPCM ABMDCKAMOCK, MGJLHNELGPC LJCJMACLAJP, ANNCEDLOMNK EPAEPNHHLAM, AJKEJNGMGDI IHMCEFGPAEA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EBDDEHOCFHE(CBKMKOLJPCM ABMDCKAMOCK, ChatMessage PJMLNICOAFE, long ANKPKBEAKOO, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PHGJGELFOEF(MGJLHNELGPC LJCJMACLAJP, AJKEJNGMGDI IHMCEFGPAEA, NKPCOFGMHDA OBKJAKKMMKK, bool LAOBGICKJIJ, string MGGKECIJJMO = "");

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NMHDGKNEMDA(long IIAJMJMGGCI, JJINPKMKGBO OOPLGAICBFI, bool FGKOEBIDLML, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NMHDGKNEMDA(string KDFBAMJFEIC, JJINPKMKGBO OOPLGAICBFI, bool FGKOEBIDLML, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NMHDGKNEMDA(CBKMKOLJPCM ABMDCKAMOCK, JJINPKMKGBO OOPLGAICBFI, bool FGKOEBIDLML, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NMHDGKNEMDA(MDEJODNGOHE ABMDCKAMOCK, JJINPKMKGBO OOPLGAICBFI, bool FGKOEBIDLML, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LOLHOFCKAOP(long IIAJMJMGGCI, long LNBMOIBCHHF, JJINPKMKGBO OOPLGAICBFI, bool FGKOEBIDLML, List<int> JPOBICGHKFF, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NMHDGKNEMDA(CBKMKOLJPCM ABMDCKAMOCK, MGJLHNELGPC LJCJMACLAJP, JJINPKMKGBO OOPLGAICBFI, bool FGKOEBIDLML, [Optional] string MEFFHKHNBPE, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH, string MGGKECIJJMO = "", [Optional] BNAMLNBGCJE NFGNHKIJCDE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BOOICNCAHLA(JJINPKMKGBO OOPLGAICBFI, [Optional] Action<GLGNLPEEOPK> HEDIMOJILOH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AIDJGFFPANM PEPPAKODKGK(GFLOBAIOPBF AHINDHHCHFA, AJKEJNGMGDI IHMCEFGPAEA);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JHHJHOHMCOI(MCOLNNONCKK LLGABENEFOL, AJKEJNGMGDI IHMCEFGPAEA, BEJIEALPOAP NLPBBBFDFFE = BEJIEALPOAP.PublicMatchmaking, bool OGANPODJHAL = true);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ALIKIDLGEJH : CKLCFGGMCDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly string DGGOMFECFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LHBDKHMCEPG? AGEAFPHLBNG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E185C0", Offset = "0x5E179C0", VA = "0x185E185C0")]
	public ALIKIDLGEJH(string KCFFPPIEBHH, [Optional] LHBDKHMCEPG? KDDNHLADLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E184A0", Offset = "0x5E178A0", VA = "0x185E184A0")]
	public static ALIKIDLGEJH PBDMNAJCIOP(string KCFFPPIEBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E18520", Offset = "0x5E17920", VA = "0x185E18520")]
	public static ALIKIDLGEJH PBDMNAJCIOP(CKLCFGGMCDD OIMLEIJKDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E183B0", Offset = "0x5E177B0", VA = "0x185E183B0")]
	public static ALIKIDLGEJH PBDMNAJCIOP(string KCFFPPIEBHH, LHBDKHMCEPG FIBEPNMHCEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
	public override string KHDKMLPELIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OHFGILFIECP
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ALLBKFLILAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	FCJKIAIKOOM HOIIEBDMPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NDCNGKFFFNM
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJNEKNCGBDK<ENACDDOAAGO> APCDHBLCDBC(int IALHMHAHPIN, bool ODEMDGPGGEG = false);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJNEKNCGBDK<ENACDDOAAGO> BHDMEHLHHDJ(int IALHMHAHPIN);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CJNEKNCGBDK<ENACDDOAAGO> JJNFALCCOKD(int IALHMHAHPIN);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJNEKNCGBDK<ENACDDOAAGO> LCDPOADDDHF(int IALHMHAHPIN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MKEBMMDCPPL
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	FCJKIAIKOOM PKGFEBDJNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PIMAMHCHJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AIDFKHMIKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool OGCHNPDNENL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MJNHLOIAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> FKCBDPADNJI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AIDJGFFPANM FEKMIAHEGDC();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FLKPIIKBIHA(long FHHGFCIPGPE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EBBGLAFELMK(long FHHGFCIPGPE);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DOAEACDBPEA(int IALHMHAHPIN, string IKGKFMOFIIK, [Optional] CBKMKOLJPCM NBMFCNKPGLC);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OCOCLAPKMFB(CBKMKOLJPCM ABMDCKAMOCK, bool KOEAMIHCODC = false);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EEHGCOKPFNA(CBKMKOLJPCM ABMDCKAMOCK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JJINPKMKGBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public AJKEJNGMGDI EHCGCJFAGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public long MBPPFFFOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public long BHBFPPJJOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public string BFCHDGFPGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public string OONCGMOALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public CLNMJCEEDOD? ALHAABMKMIC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CLNMJCEEDOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string BOGPAHCKLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public string[] NMKGEGLGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Dictionary<string, string> CKLNEONCGEG;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum AJKEJNGMGDI
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	NOT_SET = 0,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	BOOT = 1,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	GAME_LOADING_NEXT_LEVEL = 2,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	PORTAL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	AFK = 4,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	VOTE_KICKED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CHEAT = 6,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ROOM_BANNED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	ACCEPTED_GAME_INVITE = 8,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	PARTY_ACTIVITY_SWITCH = 9,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	NOTIFICATION_PLAYER_EVENT = 11,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	PEOPLE_MENU = 12,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	ACTIVITY_SELECT_MENU = 13,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PERSISTENCE_ERROR = 14,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CIRCUIT_REINITIALIZE_ERROR = 15,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BULLETIN_BOARD_FEATURED_ROOMS = 16,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[Obsolete]
	__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	QUIT = 19,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	EVENT_DIRECT_GOTO = 20,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	EVENT_NOTIFICATION = 21,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	REC_CENTER_SLIDESHOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	COHORT_NUX = 23,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	QUICK_LAUNCH_MENU = 24,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	ANNOUNCEMENT = 25,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	DEPRECATED_1 = 26,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	DELAYED_ROOM_WARNING = 27,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ROOM_CODE = 28,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_COMMENT_NOTIFICATION = 29,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CLUBHOUSE_DIRECT_GOTO = 30,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	FORCE_THROUGH_ADMIN_SITE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RECOMMENDED_ROOMS_WATCH = 33,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	INSTANCE_FORCE_CLOSED = 34,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	HOT_ROOMS_WATCH = 35,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	LIVE_ROOMS_WATCH = 36,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	SEARCH_ROOMS_WATCH = 37,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	FAVORITE_ROOMS_WATCH = 38,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	DOOR_SELECT_WATCH = 39,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	FEATURED_ROOMS_WATCH = 40,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	RECNET_ROOMS_WATCH = 41,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	NEW_ROOMS_WATCH = 42,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	ROOM_COMMENT_TELEPORT = 43,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURATED_PLAYLISTS_WATCH = 44,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PLAYER_EVENT_CODE = 45,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	ROOM_REJOIN_WATCH = 47,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	PLAYER_EVENT_DETAILS_WATCH = 48,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	RECENT_ROOMS_WATCH = 49,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	FRIEND_PRESENCE_ROOMS_WATCH = 50,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MY_CLUBHOUSE_ROOMS_WATCH = 51,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	TOP_CREATORS_ROOMS_WATCH = 53,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[Obsolete]
	RISING_ROOMS_WATCH = 88,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	HOME_LOGIN = 121,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	HOME_ROOM = 122,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	PLAY_MENU_BANNER = 123,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	QUICK_ORIENTATION_DOOR = 124,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	CAROUSEL_ENDPOINT_WATCH = 125,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	HEARTBEAT_TIMEOUT = 126,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MULTIPLAYER_TESTING_COMMAND = 127,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	JOIN_NEW_FRIEND = 128,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GLGNLPEEOPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool PIEJJPFODEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public LHBDKHMCEPG ALDFCLBILLB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E18610", Offset = "0x5E17A10", VA = "0x185E18610")]
	public GLGNLPEEOPK(LHBDKHMCEPG FIBEPNMHCEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GJFINIAKKAM
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFGAHHFFGNL(LBKGIILDFAD PAJBCDBKKAO, List<KeepsakeInstanceDTO> DPLCEAGBOAE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum EHJCHDLGKEC
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
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
