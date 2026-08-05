using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HOEGHIODPEM
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
	PicoPhoenix,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	NintendoSwitch
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum ONIACCCCCHB
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Desktop_Valve = 1,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Desktop_Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	PS4 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Desktop_MicrosoftVR = 8,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Desktop_VRMissing = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	OculusQuest = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	iOS = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	XboxOne = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	AndroidMobile = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	PS5 = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	XboxSeries = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	PicoNeo3 = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	PicoPhoenix = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	NintendoSwitch = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FEGPGDPLNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	PlayerEvents
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PHAHCAIFIJM
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OKGFMKONIBK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KCDENLKFCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MKIODLGHOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FHNCMDBIKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADNGLMNFEGP(object OEDJKICDDGA, bool CHDBOODKJNA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BHEDPLAABGA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BCGGPHCCNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 EINPPMDJAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 NLBJIAKNOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Camera MPFDIACNMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GameObject PIDMIFPAGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OILBMDOKJIH HMKPNNIOGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BGECMLEGDCD EIIMJFKEEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CPCJDOKKHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float NNKOEIEAKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KGCDDKAEBNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool EDBDFOEEGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BGECMLEGDCD FIIHCPCLAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JLLKMBEAJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLLOEMIFPNA(NMCPPAKMEBO JMBFFECKPBA, NMCPPAKMEBO AHPDJCLOFLM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JGHMECAAHPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	RegionInfo GKIPJPILKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EFBAGCFBLLD IBCPBEMOOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	KAJLIHHEFAG LJGAJMKGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PBDKLFHOFGP DLDJJFDHGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OIBLCKMFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KMOGDKKNNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DNAIJDPEJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KOKFMNJDMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NGJCBNICPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string AFELAGEOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string DILPIEFCAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetUnityLauncherToDefault();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DADJJBDFHFC : IBGBEJBFKDE, OBJIAHPFFNB, LEOHJJDOBED, JGHMECAAHPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	BGECMLEGDCD HBLMKLFNFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HOEGHIODPEM OMPBBJGMHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JCEAHNNFGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DGBHANDODIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LOAJBDFFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OGMAHGJNOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PFHJOLPPKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MEECLMMMFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HCGNNEJAOHI<DateTime?> GetPlatformProfileDateOfBirth();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IsEULARequired();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string GetEULA();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AcceptEULA();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PGILFKJEHOF PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PGILFKJEHOF RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HCGNNEJAOHI<PHAHCAIFIJM> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PGILFKJEHOF RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PGILFKJEHOF RequestContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HasContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool CanAskForContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool SupportsLinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool IsCrossPlatformWarningRequired();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AcceptCrossPlatformWarning();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool IsForcedIsolationByPlatformSettings([Out] string KAECEGEHALB);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HCGNNEJAOHI<bool> TryResolveForcedIsolationByPlatformSettings();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool IsSiloedMatchmakingEnabled();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool RequestCrossPlatformMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool RequestSiloedMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "29")]
	FMHOFFFMGIN<Texture2D> GetPlatformFriendPicture(string BOAMEGEOPOJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool SupportsMeshDataStruct();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HCGNNEJAOHI<NNFPLCAADEK> GetPlatformPlayerAgeBucket();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<NNFPLCAADEK> GetPlatformPlayerAgeBucketAsync([Optional] CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OILBMDOKJIH
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float IHHKEDJIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CNEKBHJMAJE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CIKCHFCBJCK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CCNKMMMOCCJ.PPPHJKEDCAM> HKDMGEOFCCF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFEDKCCJHDH(EEHJIAIGNPA OIPODNIBADE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILGDMHFFGDE();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NICNFOLBHPG(CCNKMMMOCCJ.PPPHJKEDCAM GFOFEHJPOLP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PKJOKIEMHHM
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FOOIJOAAAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OBMFJMGOLJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	BGECMLEGDCD NBPJHAEDBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(FFBKCBPMKIC PFLBMFACDJJ, string CFEMFGIMFDK, float DACHNPNJPDB, [Optional] Action AHJILKLLLDE, [Optional] object NCDAIMLFAAE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable Play(FFBKCBPMKIC PFLBMFACDJJ, string CFEMFGIMFDK, string GNEIKENNGPK, float DACHNPNJPDB, [Optional] Action AHJILKLLLDE, [Optional] object NCDAIMLFAAE);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable Play(FFBKCBPMKIC PFLBMFACDJJ, float DEOOBEMHLLL, DADJOBGOFDD OAPKKGNNDOJ, string CFEMFGIMFDK, Color? ELJOJJJHBHD, string GNEIKENNGPK, Color? LHKKNCGHLLM, float DACHNPNJPDB, [Optional] Action AHJILKLLLDE, [Optional] object NCDAIMLFAAE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PlayVirtualWatchNotification(CKBCFIELKMM NFOHONOFFAP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PlayPlayerProgressionWatchNotification(BNCPCJPMJBF HJCJCIIFPJE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AddForceAllowNotifications(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RemoveForceAllowNotifications(object OEDJKICDDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum DADJOBGOFDD
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum FFBKCBPMKIC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Max
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MHOFHHHKLBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool HKJBPNHEHAF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HHIPOFHOGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B8780", Offset = "0x8B7780", VA = "0x1808B8780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xCBB340", Offset = "0xCBA340", VA = "0x180CBB340")]
	public void PJLLGFACDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public MHOFHHHKLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GIHACBABNFG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ANIHGFOPDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<MHOFHHHKLBK> OOINDHAHHFP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNDNCBMFLEI();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EBDKLNLDMFK GKFDPMLNACO();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGNOKDNAIFI(EIAGMJEHGKL CHNGFEKJHON);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BENFKFJLGHK(ENMNGNJNNLB CANBHFHBMDA, OONHFDBOICP CFKFJPKPBBG, string HEALIKDMNIA, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JAEMMMJFKKM(string JPCLHFGBEKI, EIAGMJEHGKL EFBPOMFCBCE, bool PMMOJCBPFNK = false);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IIDGMKEHIEK(int AOKMKNGFNPG, ADPCAOHJLHK GJDMLCOEHMP);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OIOHHOFPEOL(ENMNGNJNNLB CANBHFHBMDA, OONHFDBOICP CFKFJPKPBBG, int AOKMKNGFNPG, EIAGMJEHGKL EFBPOMFCBCE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<PIJKHLBEMKP<HNKFFDNJINI, CJENEOELDLH>> CEKLEFPJALJ(ENMNGNJNNLB CANBHFHBMDA, OONHFDBOICP CFKFJPKPBBG, CKBCFIELKMM CHDEFBKAKDD, EIAGMJEHGKL EFBPOMFCBCE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGBNCBIENOP(ENMNGNJNNLB CANBHFHBMDA, ChatMessage IMJCDMCANNF, long LAKBCGAKBOA, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LCHCANJKBIA(OONHFDBOICP CFKFJPKPBBG, EIAGMJEHGKL EFBPOMFCBCE, ADPCAOHJLHK GJDMLCOEHMP, bool GEFEMBGFAHE, string HAPEMCMCCFP = "");

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CODLANDGPFH(long NBDDMFOIEKN, EBDKLNLDMFK ICHBJBHAGMK, bool DKPDKAMCINJ, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CODLANDGPFH(string LJJOFJIKNDL, EBDKLNLDMFK ICHBJBHAGMK, bool DKPDKAMCINJ, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CODLANDGPFH(ENMNGNJNNLB CANBHFHBMDA, EBDKLNLDMFK ICHBJBHAGMK, bool DKPDKAMCINJ, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CODLANDGPFH(MAJDNFCMCPK CANBHFHBMDA, EBDKLNLDMFK ICHBJBHAGMK, bool DKPDKAMCINJ, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IGLOGEIHELO(long NBDDMFOIEKN, long ILOMCKJOFJN, EBDKLNLDMFK ICHBJBHAGMK, bool DKPDKAMCINJ, List<int> BGJFJHINOGP, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CODLANDGPFH(ENMNGNJNNLB CANBHFHBMDA, OONHFDBOICP CFKFJPKPBBG, EBDKLNLDMFK ICHBJBHAGMK, bool DKPDKAMCINJ, [Optional] string HEALIKDMNIA, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA, string HAPEMCMCCFP = "", [Optional] CJHMBLDOBAH GMIOPCIMFKL, [Optional] List<int> JGDMAOHJJFD);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EOEBNCMNBJM(EBDKLNLDMFK ICHBJBHAGMK, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "20")]
	PGILFKJEHOF GBGONMPGCMN(LHGJAFMEKAK FPHGOBABGCL, EIAGMJEHGKL EFBPOMFCBCE);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PHBPEKFFAKJ(ECEKJCDPLNJ OCHPFOPPJKP, EIAGMJEHGKL EFBPOMFCBCE, LCJCODECONA IGPLIHHCDIO = LCJCODECONA.PublicMatchmaking, bool IMOBGBGCANM = true);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HGNGEDBAODM(string MDPNBDELBHE, IReadOnlyList<long> LPNADHOHNPB, EBDKLNLDMFK ICHBJBHAGMK, [Optional] Action<AFPGDBDCGLE> POPHAIKBPKA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CJENEOELDLH : FNFMNGCMHCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly string CANNEAPCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KDOECNFBAGL? BCEMGIJPDHP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x698C8C0", Offset = "0x698B8C0", VA = "0x18698C8C0")]
	public CJENEOELDLH(string NFOHONOFFAP, [Optional] KDOECNFBAGL? HJPBCEGABCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x698C840", Offset = "0x698B840", VA = "0x18698C840")]
	public static CJENEOELDLH HCLFOFEHDJP(string NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x698C7A0", Offset = "0x698B7A0", VA = "0x18698C7A0")]
	public static CJENEOELDLH HCLFOFEHDJP(FNFMNGCMHCP DBJNGIIJNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x698C6B0", Offset = "0x698B6B0", VA = "0x18698C6B0")]
	public static CJENEOELDLH HCLFOFEHDJP(string NFOHONOFFAP, KDOECNFBAGL NIEIPBDODCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IEGNMNFMPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EKGDBOHPAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BGECMLEGDCD BJGAALEENJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AKDKBBGIJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HCGNNEJAOHI<BLACLJFOFIM> GLEBKFHDCHC(int AOKMKNGFNPG, bool KDHELHJCDKN = false);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCGNNEJAOHI<BLACLJFOFIM> PKAKFDBINJH(int AOKMKNGFNPG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCGNNEJAOHI<BLACLJFOFIM> KJBCNHCJLNP(int AOKMKNGFNPG);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HCGNNEJAOHI<BLACLJFOFIM> LMHEIJJGFLN(int AOKMKNGFNPG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CNDOKOPMJPL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	BGECMLEGDCD CCBDLDIAOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FDIONNFIGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool EGLCIIIFBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool FBHHKECDDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool LELMADPBHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> KAAMIDJHBBI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PGILFKJEHOF JKNGDHLBKID();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BBPDNMMBPBD(long DBHJBHHFOJA);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GBNECJJADLN(long DBHJBHHFOJA);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NLIIMPAKNHO(int AOKMKNGFNPG, string IBAJKJPCMHD, [Optional] ENMNGNJNNLB NINJHIDIJNE);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LIJJNGJMPEK(ENMNGNJNNLB CANBHFHBMDA, bool GIBJBLLIDJH = false);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NBOEPODILMD(ENMNGNJNNLB CANBHFHBMDA);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NIIIJMDBGHD BBBLFGJMIMM(int DBHJBHHFOJA, [Optional] string JOPGHMFMAEA, bool ACDOAPEHFAA = false, bool HAOEOPHAEHO = false, ADPCAOHJLHK EDFLENGMALA = ADPCAOHJLHK.None);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EOJNNANELKG(int EGHHENCPOKH, MFKCBOOGHPL OKABCACGDAD, APFHDOCKBNE KIKNPHKDMHM, [Optional] EIAGMJEHGKL? DGELPIMDKLN);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AOABEAIGPON(Func<bool> JIFIAIJEGCB);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HMBCKEKDHNH();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EBDKLNLDMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public EIAGMJEHGKL DHPDJBINGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public long KEBDOHFCJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public long EGMHNEHHBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string CHDACLNHNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string IGLOKKKLPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public string HGOPBOJOOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string BMJPAMDJEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid? HDKBBJHDACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public OPBDFHCAAEK? HEOPJPKFPFM;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OPBDFHCAAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public string GFNLMHKNFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public string[] BJAGGNHHPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Dictionary<string, string> ANMLBFFHHNI;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EIAGMJEHGKL
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	NOT_SET = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	BOOT = 1,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	GAME_LOADING_NEXT_LEVEL = 2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	PORTAL = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AFK = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	VOTE_KICKED = 5,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CHEAT = 6,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ROOM_BANNED = 7,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	ACCEPTED_GAME_INVITE = 8,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PARTY_ACTIVITY_SWITCH = 9,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	NOTIFICATION_PLAYER_EVENT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	PEOPLE_MENU = 12,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	ACTIVITY_SELECT_MENU = 13,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PERSISTENCE_ERROR = 14,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CIRCUIT_REINITIALIZE_ERROR = 15,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	BULLETIN_BOARD_FEATURED_ROOMS = 16,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[Obsolete]
	__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	QUIT = 19,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	EVENT_DIRECT_GOTO = 20,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	EVENT_NOTIFICATION = 21,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	REC_CENTER_SLIDESHOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COHORT_NUX = 23,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	QUICK_LAUNCH_MENU = 24,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ANNOUNCEMENT = 25,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DEPRECATED_1 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	DELAYED_ROOM_WARNING = 27,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROOM_CODE = 28,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ROOM_COMMENT_NOTIFICATION = 29,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CLUBHOUSE_DIRECT_GOTO = 30,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	FORCE_THROUGH_ADMIN_SITE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	RECOMMENDED_ROOMS_WATCH = 33,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	INSTANCE_FORCE_CLOSED = 34,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	HOT_ROOMS_WATCH = 35,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	LIVE_ROOMS_WATCH = 36,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	SEARCH_ROOMS_WATCH = 37,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	FAVORITE_ROOMS_WATCH = 38,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	DOOR_SELECT_WATCH = 39,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	FEATURED_ROOMS_WATCH = 40,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	RECNET_ROOMS_WATCH = 41,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NEW_ROOMS_WATCH = 42,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	ROOM_COMMENT_TELEPORT = 43,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	CURATED_PLAYLISTS_WATCH = 44,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	PLAYER_EVENT_CODE = 45,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	ROOM_REJOIN_WATCH = 47,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	PLAYER_EVENT_DETAILS_WATCH = 48,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	RECENT_ROOMS_WATCH = 49,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	FRIEND_PRESENCE_ROOMS_WATCH = 50,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	MY_CLUBHOUSE_ROOMS_WATCH = 51,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	TOP_CREATORS_ROOMS_WATCH = 53,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[Obsolete]
	RISING_ROOMS_WATCH = 88,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[Obsolete]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	HOME_LOGIN = 121,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	HOME_ROOM = 122,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	PLAY_MENU_BANNER = 123,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	QUICK_ORIENTATION_DOOR = 124,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	CAROUSEL_ENDPOINT_WATCH = 125,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	HEARTBEAT_TIMEOUT = 126,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	MULTIPLAYER_TESTING_COMMAND = 127,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[Obsolete]
	JOIN_NEW_FRIEND = 128,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	SIMILAR_ROOMS_LISTS_WATCH = 129,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FRIEND_ONLINE_NOTIFICATION_CARD = 130,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FRIEND_ONLINE_DIALOG = 131,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	GENRE_BASED_CAROUSEL = 132,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AFPGDBDCGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool FBHLPLPHNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public KDOECNFBAGL MOEMFHOLLIH;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x698C6A0", Offset = "0x698B6A0", VA = "0x18698C6A0")]
	public AFPGDBDCGLE(KDOECNFBAGL NIEIPBDODCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CCDCFNAAPEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGBEFJOAKGE(EIGMLKEEHNM ECFPMBIFHFL, List<KeepsakeInstanceDTO> PPMPNIIHPEE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PBDKLFHOFGP
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
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
