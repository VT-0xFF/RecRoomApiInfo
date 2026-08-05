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
public enum GDAMHBPJDKP
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
public enum MHGCDJFAEGO
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
public enum KEEIFNALKDH
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
public enum JAMGMCCPKBE
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ECCPBDJBLOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GMKINCMNLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OCOPJMCPGIB();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KIFJBAMODBN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LFBPDBFCDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KAHEAIDJCCD(object GFDDDAIMFOH, bool KGLILCLFEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IMELDALCABF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CELLAKOHBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 HLMKOPCLDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 IOCDPBPOOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Camera IKLEHCKGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Camera DDHLDFEEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GameObject CKINCAFMHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FMNOGFJIAGA FCPDMMPHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LELKCPPPMEI NDNONJCOLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NKOKLBGDDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float IOGKMEJIKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MLEHPOEFLAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PFPIDOHIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LELKCPPPMEI OFPKCNAOPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PPGOICMOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OIPNALOKIIJ(IALDHONKEJC HDFIDKNGPLP, IALDHONKEJC EKJALKPLJPG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PIENLNCECJC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	RegionInfo OADMFCCFIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EIGIKBOIADO KFDCDBGJEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NLJFAOJNHDJ LNMEBCAIECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool CKHGCMEGMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool GFJOMKJKAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string MFGEBNFAHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string JONMHKNHCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MGDAEHKIFBG : PGLIGOEGHJD, LEBCBPHLODN, DGIFEDFLGAO, EFAOPAFNJFN, PIENLNCECJC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LELKCPPPMEI EKFDMKBAADN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GDAMHBPJDKP KAMCHFMKJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IPOBGBLBFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PGJHCLMLKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EOGLJAFPBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LMIBHMCCPFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OGCOKJJKFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KCKFLJKIEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NOOGCACNGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KPIPLFECKNC<DateTime?> GetPlatformProfileDateOfBirth();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IsEULARequired();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string GetEULA();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AcceptEULA();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JCFICNGFDLA PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JCFICNGFDLA RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KPIPLFECKNC<JAMGMCCPKBE> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JCFICNGFDLA RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JCFICNGFDLA RequestContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HasContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool CanAskForContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool SupportsLinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool IsCrossPlatformWarningRequired();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AcceptCrossPlatformWarning();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool IsForcedIsolationByPlatformSettings([Out] string HGCDDIGCKLI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KPIPLFECKNC<bool> TryResolveForcedIsolationByPlatformSettings();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool IsSiloedMatchmakingEnabled();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool RequestCrossPlatformMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool RequestSiloedMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "29")]
	PHNCGCCJBCF<Texture2D> GetPlatformFriendPicture(string IMHEEBEEIJH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KPIPLFECKNC<PFKKBBBMJCN> GetPlatformPlayerAgeBucket();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<PFKKBBBMJCN> GetPlatformPlayerAgeBucketAsync([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FMNOGFJIAGA
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float KNEMCAELAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BBPDOCPMPJE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action POAIFJEFDCI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CMHGCGFFLAM.MJCFPPNLLCC> EPPIAJEBEHI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FDCAKPAEELK(FLMDJANAGJA EGNGCCDPPKD);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMMDBMDIFEP();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGHICDLABMI(CMHGCGFFLAM.MJCFPPNLLCC NBKNGNMDAJA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FIAPEONIDIG
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PIAHCKPGIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JDLFHCKLFBB
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LELKCPPPMEI GOINJHIIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(KNHAJHOEECB CJHEFGOEFNC, string PKPMHAOGPKK, float MFKAPIFDPJJ, [Optional] Action HCEFPMMOBCM, [Optional] object CGHBKFDIGOI);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable Play(KNHAJHOEECB CJHEFGOEFNC, string PKPMHAOGPKK, string CGCDHAKHMBO, float MFKAPIFDPJJ, [Optional] Action HCEFPMMOBCM, [Optional] object CGHBKFDIGOI);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable Play(KNHAJHOEECB CJHEFGOEFNC, float EJGMCHBICKN, JKEECBJAOEO GAABCJGNGFA, string PKPMHAOGPKK, Color? MOEIKHMNEBJ, string CGCDHAKHMBO, Color? DDFCHLOABDM, float MFKAPIFDPJJ, [Optional] Action HCEFPMMOBCM, [Optional] object CGHBKFDIGOI);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PlayProgressionEventWatchNotification(bool NEPLHIDFNBM, [Optional] string NPLBMAAHBCO, [Optional] string GMHKCOLPKHC, int HGNFLAAIMMP = -1, [Optional] Action HGPGFMAOOKL, [Optional] string KFPAOHEGDAA, bool OIHEBNNLKAM = true, [Optional] float? HOFEIHKCGGP, float OAFIOLHFDKA = 0f);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PlayVirtualWatchNotification(PDMHJMEKAGD OBCNAJEENCI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PlayPlayerProgressionWatchNotification(BOCCLHMLADI MBAGIDFJGJL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AddForceAllowNotifications(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RemoveForceAllowNotifications(object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool TryConsumeWatchNotification();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum JKEECBJAOEO
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum KNHAJHOEECB
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
public class AGFMANIFFPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool AJKBKOKIAOD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool PFMMCNOMGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xDB1510", Offset = "0xDB0510", VA = "0x180DB1510")]
	public void MPJNOBIKNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AGFMANIFFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CAFPNOLMOCK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NEDLIFPNAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<AGFMANIFFPP> FHEJBGANAOO;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAOAMLOGINP();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EEICIGIJNPM DEIBNFOFCFM();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHOIBEPBKBC(AIPNHDAKNPM MKOOPFGGHLN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNPIFIFPCIA(MIBODHPEFHP JNJNNNFIFFP, PNAGCNAKDLL DOANDHKGGIC, string BJBMIMHKOIK, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DCHDPHHDGPC(string FKEKDDCDBFP, AIPNHDAKNPM GPEEKEJMCAC, bool GHOMGMHHEIL = false);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPOAIPMAINB(int KJENEIANJDF, EKFPOCGIIEF NKCCBFALMHH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DOMJONJMJAA(MIBODHPEFHP JNJNNNFIFFP, PNAGCNAKDLL DOANDHKGGIC, int KJENEIANJDF, AIPNHDAKNPM GPEEKEJMCAC, bool IAPJNDMPHOG = false);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<DAFIFKKNPFP<GAAICFLNCNK, IKBDPILHDAP>> ECDCKFDGFNF(MIBODHPEFHP JNJNNNFIFFP, PNAGCNAKDLL DOANDHKGGIC, PDMHJMEKAGD FAKGCFNMKGF, AIPNHDAKNPM GPEEKEJMCAC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPCJOFKPODH(MIBODHPEFHP JNJNNNFIFFP, ChatMessage KALIPFKLJKA, long HIDGLKJGPDB, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NCGCCPAFCPC(PNAGCNAKDLL DOANDHKGGIC, AIPNHDAKNPM GPEEKEJMCAC, EKFPOCGIIEF NKCCBFALMHH, bool MNGLDCECKLA, string EECBOADPICL = "");

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	[Obsolete("Prefer using RunJoinRoom(RoomDTO, SubRoomDTO) or RunJoinRoom(roomId, subRoomId) where possible.")]
	void JPGMJDHOKAB(string NEEDNOPBPDA, string OEJGEBPCAEO, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPGMJDHOKAB(long DJJNJEHBMJK, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPGMJDHOKAB(string NEEDNOPBPDA, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JPGMJDHOKAB(MIBODHPEFHP JNJNNNFIFFP, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JPGMJDHOKAB(EJMKMMDMHKL JNJNNNFIFFP, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JLKIAMBGEDF(long DJJNJEHBMJK, long MNMAOOEOJPN, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, List<int> MJEMCPHFLLB, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JPGMJDHOKAB(MIBODHPEFHP JNJNNNFIFFP, PNAGCNAKDLL DOANDHKGGIC, EEICIGIJNPM LMHBBGDHPGC, bool GMGNOKDDNOD, [Optional] string BJBMIMHKOIK, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI, string EECBOADPICL = "", [Optional] OAPOJMIFJHN HGOABEOLHFC);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MFJIBELHFGM(EEICIGIJNPM LMHBBGDHPGC, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "21")]
	JCFICNGFDLA PMJBHGOJFBC(NBOMJFLBIGC FLJEKHEEELC, AIPNHDAKNPM GPEEKEJMCAC);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FALOGHODAOL(NEMBNIGCMFK JCHDOJFEEPP, AIPNHDAKNPM GPEEKEJMCAC, EFNIKCPHKHD LDIDFOHOMNE = EFNIKCPHKHD.PublicMatchmaking, bool FLCKKLEDKKA = true);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EJPJEFGCMGB(string DOFPOPJGELM, string POHEDJBONMO, EEICIGIJNPM LMHBBGDHPGC, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DMODMPDIDPB(IReadOnlyList<long> NBFHKMJHAHP, IReadOnlyList<long> AOAKMAIPICL, EEICIGIJNPM LMHBBGDHPGC, [Optional] Action<OCJOCFGAMDN> GCOFFIIIPPI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IKBDPILHDAP : JFHNFKOLNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly string PKCPPLKFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly JILFDCOLLLA? BKBKPPLMFLI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x81A6C80", Offset = "0x81A5C80", VA = "0x1881A6C80")]
	public IKBDPILHDAP(string OBCNAJEENCI, [Optional] JILFDCOLLLA? EKJLCBFKICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x81A6B60", Offset = "0x81A5B60", VA = "0x1881A6B60")]
	public static IKBDPILHDAP MPFKOOIPONO(string OBCNAJEENCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x81A6BE0", Offset = "0x81A5BE0", VA = "0x1881A6BE0")]
	public static IKBDPILHDAP MPFKOOIPONO(JFHNFKOLNEJ PFLBCFINGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x81A6A70", Offset = "0x81A5A70", VA = "0x1881A6A70")]
	public static IKBDPILHDAP MPFKOOIPONO(string OBCNAJEENCI, JILFDCOLLLA LEOFMJDKCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
	public override string OFBAEHEOPOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FOBJDDMGNHD
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KLJIOEKBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LELKCPPPMEI DKANBNGHBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Vector3 HPCMJOHDKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	long NFLPDMMJBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string LABBLAGNFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FFGFEBNPNAH
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPIPLFECKNC<LANKKABFAEB> KGEEJCLGHCA(int KJENEIANJDF, bool NILBLHMNHPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPIPLFECKNC<LANKKABFAEB> LGICGHMKPJO(int KJENEIANJDF);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KPIPLFECKNC<LANKKABFAEB> BLDDIJINLBB(int KJENEIANJDF);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KPIPLFECKNC<LANKKABFAEB> PECGJFLFANL(int KJENEIANJDF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AGHCEHMADPK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LELKCPPPMEI EKGGPBFKNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool OPBFCGCEDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool OJPLLBKEGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool EMJBEIDFIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool PFGLMHDECBE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool KDPCGMDIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> BPEDMFHLECC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JCFICNGFDLA JLOKEMBCHNC();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GPIDAAGDOLA(long CAIINIONEBG);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AFHDGMFPMIH(long CAIINIONEBG);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PIOMAINIHNG(MIBODHPEFHP JNJNNNFIFFP, bool OMINOMAKLBA = false);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GJKIAKHKHJM(MIBODHPEFHP JNJNNNFIFFP);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JFNOOGODOOA NEIBPPDGALL(int CAIINIONEBG, [Optional] string CJECJOGJHIC, bool AOMBINHBAJB = false, bool KAOCFCPIBOI = false, EKFPOCGIIEF FNOJIIAGNKE = EKFPOCGIIEF.None);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task FOLFIFEHKDC(int[] IJMOFECGMLL, bool AOMBINHBAJB = false, EKFPOCGIIEF FNOJIIAGNKE = EKFPOCGIIEF.None);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IJOLPICJGAC(int ADMJEODDOFE, PHCHGFEEEMG IMFCGBBJLBP, ADEDKDNDABF PEDKKOAEMLJ, [Optional] AIPNHDAKNPM? FOABLNKKHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EEICIGIJNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public AIPNHDAKNPM JONGEIBCKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public long OIGFOLEAJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public long EBBPJOPFODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string HBOJEALNHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string AFOKLJOAFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public string PIHKFIMHPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string IEHIPGAEHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid? FHDAEFCOBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public OPAEDGAGODF? FIGCINLIOOK;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OPAEDGAGODF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public string JPENNJFPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public string[] JMOEAOMEDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Dictionary<string, string> BBPELPGALGC;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum AIPNHDAKNPM
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
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[Obsolete]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[Obsolete]
	RISING_ROOMS_WATCH = 88,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	TITLESCREEN_ONLINE_FRIEND = 89,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	HOME_LOGIN = 121,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	HOME_ROOM = 122,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PLAY_MENU_BANNER = 123,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	QUICK_ORIENTATION_DOOR = 124,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	CAROUSEL_ENDPOINT_WATCH = 125,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	HEARTBEAT_TIMEOUT = 126,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	MULTIPLAYER_TESTING_COMMAND = 127,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[Obsolete]
	JOIN_NEW_FRIEND = 128,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	SIMILAR_ROOMS_LISTS_WATCH = 129,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FEATURED_CREATOR_CAROUSEL = 131,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	GENRE_BASED_CAROUSEL = 132,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	CIRCUITS_V2_GO_TO_PLAYER_EVENT = 133,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PARTY_CARD_GOTO_WATCH = 134,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MY_CREATED_DORMS_WATCH = 205,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	GENRE_CARDS_SEARCH_WATCH = 206,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	APPNAV_WIDGET = 207,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	CV2_SHOW_ROOM_DETAILS = 208,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	ROOMIE_AI = 209,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	OM_INITIALIZATION_ERROR = 210
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OCJOCFGAMDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool DFNABMLPDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public JILFDCOLLLA HBLAJNELBON;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x81A6CD0", Offset = "0x81A5CD0", VA = "0x1881A6CD0")]
	public OCJOCFGAMDN(JILFDCOLLLA LEOFMJDKCIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KBPPAOOMKPN
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMOLDEIPEEB(KDGPCLGNAFG NKJOOOHAMOB, List<KeepsakeInstanceDTO> EFAHJLLBOKL);
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
