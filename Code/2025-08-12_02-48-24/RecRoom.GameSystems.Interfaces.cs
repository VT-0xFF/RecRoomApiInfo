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
public enum AFNPEAFAPIE
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
public enum GLFJOMJLMKE
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
public enum GGKAFHJPPFK
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
public enum ADHJOEDJFJH
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NKCDPHGAENP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PBNJOCHJECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LJDCNOCKLGC();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NOIFIBMGHLD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ACJLPDMBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HFDDHFNBMIM(object HNGIMMGBLII, bool LFNCJNCODJM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MDPEENHBKJL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ALNAHEHLKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 FDDENOFJFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 IGEKGJLFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Camera OFBJLFCLLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Camera IBCGGMICPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GameObject BFIGJNMIBML
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MIEDMFFMCJI PKPIEIFDGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HBPNKKOKOOA GBLGBCJEEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GALILNPDFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JGADECLIHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CIGBGIBFCGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BBJPBOOBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HBPNKKOKOOA ELFIIKBEHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OPCOKPHKKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPPGKLOGJMP(NGPBJJLAELK EJPJBFDGOBO, NGPBJJLAELK MFHHHEEBJDN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DJNHFPBNLKO
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	RegionInfo GMEJFMKABKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PDFFPLHGGDJ JFEJFLFKMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PEHMMGGEDNB BCHFMOIGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool MGLBFLHGJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LPOFOFMGJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string ODCBDDKEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string CENBJHMFJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IPLADBHABLH : LJBJNEKAKNC, ONIHPNACPKI, LOKNMGKIMFJ, LKJCMDHKLDK, DJNHFPBNLKO
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HBPNKKOKOOA IMNBOFDAICK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AFNPEAFAPIE DOJPNFIILOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AEGMCLHHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GMFACDBGCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JAGAEOMEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HPIINCMDGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool APKDKKDPCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BJJJOJGMNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BFINCBILAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LDNIFFJFEMD<DateTime?> GetPlatformProfileDateOfBirth();

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
	CNOKEDEBLOH PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CNOKEDEBLOH RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LDNIFFJFEMD<ADHJOEDJFJH> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CNOKEDEBLOH RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CNOKEDEBLOH RequestContactsPermission();

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
	bool IsForcedIsolationByPlatformSettings([Out] string BEJLHJONDNM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LDNIFFJFEMD<bool> TryResolveForcedIsolationByPlatformSettings();

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
	LHNBHFNPODB<Texture2D> GetPlatformFriendPicture(string IFCAGKLINAN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "30")]
	LDNIFFJFEMD<NKFCPCAMPHO> GetPlatformPlayerAgeBucket();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<NKFCPCAMPHO> GetPlatformPlayerAgeBucketAsync([Optional] CancellationToken MEKNAIONNND);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MIEDMFFMCJI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float NIMCPGBFOJM
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
public interface AOJALDDEOBI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DACFMJMFBCO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IFDONJLMMKE.OHHHIEFNBIE> DCEJMBPOJEF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLNHMOGDIPL(FKDLHHCMNMO JIHGHFEMEHL);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMINHODOIMM();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJCLDANDJBP(IFDONJLMMKE.OHHHIEFNBIE OMJBEMCGGKE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ONOLEPKNCGF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NMDJFMJBFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EPIJPKKNJNE
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HBPNKKOKOOA NPFNBHEEBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(MFCJDHPLFIM HLMHGAPMGLF, string GCBKNMFMICD, float ECPJMMFGCIP, [Optional] Action GDMDDGECOJI, [Optional] object HMOGNOAMDND);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable Play(MFCJDHPLFIM HLMHGAPMGLF, string GCBKNMFMICD, string PKMFGDHIMNN, float ECPJMMFGCIP, [Optional] Action GDMDDGECOJI, [Optional] object HMOGNOAMDND);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable Play(MFCJDHPLFIM HLMHGAPMGLF, float HGPDEODGEOL, BOKFMLAIALH IFPJJLJCAIF, string GCBKNMFMICD, Color? LFGLHDGIPHK, string PKMFGDHIMNN, Color? NBGAFMDLNFO, float ECPJMMFGCIP, [Optional] Action GDMDDGECOJI, [Optional] object HMOGNOAMDND);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PlayProgressionEventWatchNotification(bool KJOAPEDOBHC, [Optional] string HGOEGACKJMI, [Optional] string LNIMIOCAIOL, int MAJMEEPMPNM = -1, [Optional] Action ELOCNANGHKE, [Optional] string CHJHDEFOMKI, bool PDCEJILEOAA = true, [Optional] float? EMLGCIIENMB, float KMBGCJBDPFP = 0f);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PlayVirtualWatchNotification(CHNDLEMEFFH IFEHDCDCFPK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PlayPlayerProgressionWatchNotification(OEACOFACPBM KMJEOGEJMHB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AddForceAllowNotifications(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RemoveForceAllowNotifications(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool TryConsumeWatchNotification();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum BOKFMLAIALH
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum MFCJDHPLFIM
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
public class FKCIHANEFHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool OENAIPCFHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool ICEAAAMLMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xE15B20", Offset = "0xE14120", VA = "0x180E15B20")]
	public void MDJOHPBKHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FKCIHANEFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NCMNAJPDEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LHLGAJPMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<FKCIHANEFHH> HGCMNIPEJKE;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLPNHGPLBKL();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCGEAOOPEOP LACJCFMLIMD();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPKLHFGHCNF(AFGONNGHPJE LBHNPIBFMBH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDKEKADIFBN(KJDFJAOFDEC JCDPBKLKOOO, DPBOCMIBIHD NECNGMCMIMB, string NGNEDPJBPGH, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IBIKDAMEMDB(string GJHEFLPCIGK, AFGONNGHPJE OHHKKKADIEL, bool KLBMBODALEA = false);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADIJPCLIDGD(int PDIOIHNCAEJ, FNOPHBHBEPB GLNMJDFDJCN);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDKPFNFLOJM(KJDFJAOFDEC JCDPBKLKOOO, DPBOCMIBIHD NECNGMCMIMB, int PDIOIHNCAEJ, AFGONNGHPJE OHHKKKADIEL, bool AMBHIKNCIDG = false);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<PKAAAAMEMEI<GDCHOBJFCMN, BNPKFDJPDPH>> FFIPEFMMJCO(KJDFJAOFDEC JCDPBKLKOOO, DPBOCMIBIHD NECNGMCMIMB, CHNDLEMEFFH NJGCLBJBEDO, AFGONNGHPJE OHHKKKADIEL);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ANOCAPDCLIK(KJDFJAOFDEC JCDPBKLKOOO, ChatMessage PFJCAHGEMBK, long CJJAKPFMCMG, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KGDCLDNNMEI(DPBOCMIBIHD NECNGMCMIMB, AFGONNGHPJE OHHKKKADIEL, FNOPHBHBEPB GLNMJDFDJCN, bool PPDDGMFMJDG, string ANBONEAIAGK = "");

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	[Obsolete("Prefer using RunJoinRoom(RoomDTO, SubRoomDTO) or RunJoinRoom(roomId, subRoomId) where possible.")]
	void MFBKLBFJJAK(string PKHEIMGDLAN, string GNGPKCJJIED, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MFBKLBFJJAK(long PANGCFBNCCJ, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MFBKLBFJJAK(string PKHEIMGDLAN, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MFBKLBFJJAK(KJDFJAOFDEC JCDPBKLKOOO, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MFBKLBFJJAK(DIDCGIAHLBC JCDPBKLKOOO, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BKAPLGOKOBO(long PANGCFBNCCJ, long IAKLDDCBNEB, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, List<int> BPBCIPIKPIM, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MFBKLBFJJAK(KJDFJAOFDEC JCDPBKLKOOO, DPBOCMIBIHD NECNGMCMIMB, DCGEAOOPEOP KGJPOBAAMOO, bool OIMJOLMGBNP, [Optional] string NGNEDPJBPGH, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ, string ANBONEAIAGK = "", [Optional] BFGFOIGEHDF OKPBMMPNCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MCHECLLOKBL(DCGEAOOPEOP KGJPOBAAMOO, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CNOKEDEBLOH MBFBLKKCGLM(CNGDHGGEKEJ CNDADPMPMOJ, AFGONNGHPJE OHHKKKADIEL);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool BDEFDKKHHME(AFPDAKCCPGL MJKECEGDPKL, AFGONNGHPJE OHHKKKADIEL, OLCKLEGJFHI PCJNLKBNPCF = OLCKLEGJFHI.PublicMatchmaking, bool NBPKECHMGCD = true);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KALKDLIFCNL(string EFIDJLFBNOI, string LBBCKIAKJNM, DCGEAOOPEOP KGJPOBAAMOO, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GAHFFFIDNKA(IReadOnlyList<long> ANNGPELBINM, IReadOnlyList<long> JJIDFLGHDGG, DCGEAOOPEOP KGJPOBAAMOO, [Optional] Action<KBBIOEBIJNA> NFLOJMMHDFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BNPKFDJPDPH : LJOOEKCBACG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly string OGPGDHDIMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly GNMEIBBBPHH? DGGHHPNNPCK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84979A0", Offset = "0x8495FA0", VA = "0x1884979A0")]
	public BNPKFDJPDPH(string IFEHDCDCFPK, [Optional] GNMEIBBBPHH? PJDLAIJGDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8497880", Offset = "0x8495E80", VA = "0x188497880")]
	public static BNPKFDJPDPH BPFPEFLIIPC(string IFEHDCDCFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8497900", Offset = "0x8495F00", VA = "0x188497900")]
	public static BNPKFDJPDPH BPFPEFLIIPC(LJOOEKCBACG GHDHAGOHOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8497790", Offset = "0x8495D90", VA = "0x188497790")]
	public static BNPKFDJPDPH BPFPEFLIIPC(string IFEHDCDCFPK, GNMEIBBBPHH DCHHIMINIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
	public override string JBIKIOHHBGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ONDFANAHFAP
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool ANHHLAMACIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HBPNKKOKOOA LGEENAAMACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Vector3 ODKCJOMJEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	long BEDBGKHDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string GJNCPLFJLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ABPKIPLJJBI
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDNIFFJFEMD<DFKGBBFPAFG> HMEIOCPANDI(int PDIOIHNCAEJ, bool JPFLFDGCNGG = false);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LDNIFFJFEMD<DFKGBBFPAFG> DHBKMDMKNCN(int PDIOIHNCAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LDNIFFJFEMD<DFKGBBFPAFG> GIJJOMFMPCO(int PDIOIHNCAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDNIFFJFEMD<DFKGBBFPAFG> OELPBFAGEJP(int PDIOIHNCAEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PPFLMJMMFMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HBPNKKOKOOA CJJHLFBOLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MAGPPLDAKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NEBAEEACKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool EBDKONGNNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool HJKCDOFFLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> LDBMDCGFGAL;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CNOKEDEBLOH BIPGPIKCCHK();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MKHOMHFDDIF(long KHIMBMGCNDL);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PCGFPHICGCA(long KHIMBMGCNDL);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OJDDILAGCCE(KJDFJAOFDEC JCDPBKLKOOO, bool PKIBIEFDMOK = false);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool ONCBGJOFKAP(KJDFJAOFDEC JCDPBKLKOOO);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CNNOOOMLHEJ BALGGEAAKAF(int KHIMBMGCNDL, [Optional] string OLNCPHGODIF, bool JKOKNHCEPCM = false, bool HIAIGCDLLHK = false, FNOPHBHBEPB GAOEKKNDCCO = FNOPHBHBEPB.None);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task EEJAHHOPLGI(int[] JHDGNJJJBGK, bool JKOKNHCEPCM = false, FNOPHBHBEPB GAOEKKNDCCO = FNOPHBHBEPB.None);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void POIEJMBEDFN(int PPFHIIIBKME, EEHAKGHDPAE KIKOMEHHJKA, DMJCCOJKJJC AKLIFLHEDBO, [Optional] AFGONNGHPJE? DDNONDLILEK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DCGEAOOPEOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public AFGONNGHPJE BEEOMNPDOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public long EMAPHIJPDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public long EEEEBBNLKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public string MEANENENDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public string MELLJCOAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public string GPEHFIKMMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public string OBEKMCLGJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid? JBEENMFJAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LFDGIBLADGJ? PKGEOKLMJCA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LFDGIBLADGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public string FFDGNJNFHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public string[] FJMJNJHIBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Dictionary<string, string> OAMLMOEGKMM;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum AFGONNGHPJE
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
public struct KBBIOEBIJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool GHKLCINDFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public GNMEIBBBPHH NNGFDELEFIP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x84979F0", Offset = "0x8495FF0", VA = "0x1884979F0")]
	public KBBIOEBIJNA(GNMEIBBBPHH DCHHIMINIKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MNKCCOPFLLA
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNJOBOCECND(CIMPCCNCPLH FDBMCBJJCPC, List<KeepsakeInstanceDTO> DNLCIDPFCJL);
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
