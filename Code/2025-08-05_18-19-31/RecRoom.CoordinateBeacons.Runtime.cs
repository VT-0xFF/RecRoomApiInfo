using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoordinateBeacons.Concretes;
using CoordinateBeacons.Configs;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RRUI;
using RecRoom.Configs;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_CoordinateBeacons_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81DEBC0", Offset = "0x81DDFC0", VA = "0x1881DEBC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[LOGPLGEBKNL("CoordinationBeacons")]
public enum GECKMOJCMMB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[OPDFOHNHGNB("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[OPDFOHNHGNB("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[OPDFOHNHGNB("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[OPDFOHNHGNB("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[OPDFOHNHGNB("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[OPDFOHNHGNB("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[OPDFOHNHGNB("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[OPDFOHNHGNB("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[OPDFOHNHGNB("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[OPDFOHNHGNB("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[OPDFOHNHGNB("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[OPDFOHNHGNB("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[OPDFOHNHGNB("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[OPDFOHNHGNB("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[OPDFOHNHGNB("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[OPDFOHNHGNB("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[OPDFOHNHGNB("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[OPDFOHNHGNB("Another party member already has a party flag!", true)]
	WARNING_OTHER_PARTY_MEMBER_HAS_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[OPDFOHNHGNB("Placing a party flag is rate limited. Try again later!", true)]
	WARNING_PARTY_FLAG_RATE_LIMITED,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[OPDFOHNHGNB("Drop Party Flag", true)]
	BUTTON_DROP_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[OPDFOHNHGNB("Party Flag", true)]
	BUTTON_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[OPDFOHNHGNB("Cancel Party Flag", true)]
	BUTTON_CANCEL_PARTY_FLAG
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KKIPHHAEHGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JGEOIMLIKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFMDNAMOPDC(HOBCDNMALJG KLAJHEKPKMI, string DPBKALNGIKA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ACMKEGGIIGM(Camera MLFNHNIBMNH, Vector3 DKACAPNFHBO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBCJKLPCPJF(Camera MLFNHNIBMNH, Vector3 DKACAPNFHBO, CoordinationBeaconBase AIMBDKCMNDK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBPMFPIDEIK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NBAEIFIEMDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PJLJLBMMICN HFFIBENFFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PNCHAJKEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MFMGALENOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int ILNNCPJONEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFAKLIGKBKB(int BHMNMAFFGPM, Vector3 FKDLNAHLFEO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHIMJMNMGKF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIMGMPNKGIE();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPLCMAKLNCF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MKEEEPGAMPI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float BMHKIADANMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NEAGOOFLPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LBDIHOFGODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GEGGGBAAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float JBLNIPMJKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float ABEDCCLMKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float ACGBOOELIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float HFCIGFBMDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int HCPDBELHNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float IOCIFFGECPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float MNFFAHPHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float GNDPIONAOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool KAGHELAGCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PJCNLHCLGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MEGFLKDONLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IGMAIPABEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JJJGGEHIJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float JGDCCCOIKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NLDBHKAEIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OPOHDGEBLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float CDLNDJDLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float ICDBBPKCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float HOMEEIIMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool CFKOKCFBDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	float HJDBLNLFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float GHAHJPHLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float LBPMKKDPLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	float KENAFFCLHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float ALJIDMHEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int BBONKKBMCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float NPEAHHHFMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float OCFIJKFAFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	float CCDLMEKGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	float KFLFFPNPCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NOCMEBHFDJH();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GAEGIMLBHMK
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	List<NCOLAEFGMJC> NANINBDMCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	List<IOLKMJMPJFB> HDKMMLBEABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> KBPKGGIOLJB(bool FDPDGICECNN);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CoordinationPartyBeacon> AGHHICKMLBL();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLFHNPBBFDP(Guid GFNMCFDJMGK, GGBCGKGOAKI.IMPGAMDPKGH BBDALAGLAAL, HBMALBBABGM IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOBENANGNKJ(int JFAMMKOLNIJ, [Out] CoordinationBeaconBase MJEPHLOPIHM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> ENPMMFBFGLA();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OFJNJCNGJKE(int JFAMMKOLNIJ, [Out] CoordinationPartyBeacon CFJDFFJMFIM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HAFDGMJINGH(string EKHBOAMLNOI, [Out] CoordinationPartyBeacon BJNHIMLHMDF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BALMPHCBGIC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HMKDAHDFAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DELKKIJECEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHKJEOPAKJN();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMGGPBPKFGH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLPLOKEBGHK(LCCHGCBPFIP PHIIDLOGBDN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OGLMLCIGKMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KAGIAMPJOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool PHJLHKNLDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHMAAMBEEDE(ACAHCPOBLDI MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OBAAGLONNBE(ACAHCPOBLDI MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAMOKBGJIAO(ACAHCPOBLDI MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HBMDGGLHFIG(ACAHCPOBLDI MONGIMOHLAO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HAFMBGFAPIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EOMDDADCGNJ(Guid GFNMCFDJMGK, int JFAMMKOLNIJ, Vector3 LLLDJELNCPH, HBMALBBABGM HFJHENFIDEF, string GIFIGBNILAK, Canvas CGJBKLGCDFC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOPDAEICHNA(Guid GFNMCFDJMGK, GGBCGKGOAKI.IMPGAMDPKGH BBDALAGLAAL, HBMALBBABGM IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AGDADINFNFP(int JFAMMKOLNIJ, [Out] Guid GNEGMLFBNAJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENIMLCDDGGO(Guid GFNMCFDJMGK, HBMALBBABGM IIHAKBEOLJD, [Out] CoordinationBeaconBase LEIDJIGIHLH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPFMPEJKNNH(Vector3 DKACAPNFHBO, Canvas CGJBKLGCDFC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHOCAHCMDPI(CoordinationPartyBeacon MDMDOMAGKAC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMGOLPCMKCE();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task PKGJNMKMMFH(Vector3 MEAJMLNHFDI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task EINLBNFPDMC(Guid GFNMCFDJMGK, int JFAMMKOLNIJ, string GIFIGBNILAK, string EKHBOAMLNOI, Color? NKEFKPOJKND, [Optional] OIFJCNJMBMH? HAKECKGGBIF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GPFDFDJODNK();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLHGBGGBMAB();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OFJNJCNGJKE(int JFAMMKOLNIJ, [Out] CoordinationPartyBeacon CFJDFFJMFIM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task JNFBCNCCMJE(Guid GFNMCFDJMGK, int JFAMMKOLNIJ, string GIFIGBNILAK, Vector3 LCGNBAHJOFH, string EKHBOAMLNOI, Color? NKEFKPOJKND);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PFBILLJHCEC(string EKHBOAMLNOI, [Out] CoordinationPartyBeacon BJNHIMLHMDF);
}
namespace CoordinateBeacons.Configs
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CoordinationBeaconScriptableConfig : SingletonScriptableObject<CoordinationBeaconScriptableConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Header("Prefabs of Visual Components")]
		[Tooltip("World space beacon")]
		private AssetReference _beaconPrefabAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("HUD beacon shown when world space beacon is not in fov")]
		[SerializeField]
		private AssetReference beaconHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("VR HUD beacon shown when world space beacon is not in fov")]
		[SerializeField]
		private AssetReference beaconVRHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Tooltip("Rate limiting visual feedback")]
		[SerializeField]
		private AssetReference beaconRateLimitingFeedbackVisualAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("World space party beacon")]
		[SerializeField]
		private AssetReference _partyBeaconPrefabAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Header("Canvases for HUD Visual Component")]
		[SerializeField]
		private AssetReference beaconScreensCanvasAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private AssetReference beaconVRCanvasAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Header("Audio")]
		[Tooltip("Audio that plays when the local player drops a beacon")]
		[SerializeField]
		private AssetReference beaconAudioSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Audio that plays when another player drops a beacon")]
		[SerializeField]
		private AssetReference beaconAudioOthers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("Rolloff for audio that plays when the local player drops a beacon")]
		[SerializeField]
		private AnimationCurve beaconDropAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Rolloff for audio that plays another player drops a beacon")]
		[SerializeField]
		private AnimationCurve beaconDropFromOthersAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("The maximum distance the other player can be from the local player for the beaconAudioOthers audio clip to play. This should match the cutoff point for beaconDropFromOthersAudioCustomRolloff")]
		[SerializeField]
		private float beaconDropFromOthersAudioMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("Audio that plays when the local player begins placing a party beacon")]
		[SerializeField]
		private AssetReference partyBeaconBeginPlaceAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("Audio that plays when the local player drops a party beacon")]
		[SerializeField]
		private AssetReference partyBeaconDropAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("Audio that plays when a party beacon gets removed")]
		[SerializeField]
		private AssetReference partyBeaconRemovalAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Header("Color Scheme")]
		[Tooltip("Color of visual components when the beacon has the Look At This context (default)")]
		[SerializeField]
		private Color lookAtThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("Color of visual components when the beacon has the Watch Out context")]
		[SerializeField]
		private Color watchOutColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("Color of visual components when the beacon has the Take This context")]
		[SerializeField]
		private Color takeThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("Color of visual components when the beacon has the Come Here context")]
		[SerializeField]
		private Color comeHereColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("Color of visual components when the beacon has the Ally context")]
		[FormerlySerializedAs("fallbackAllyColor")]
		[SerializeField]
		private Color allyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("Color of Party Beacon flag if player is not in a party")]
		[SerializeField]
		private Color defaultPartyBeaconColor;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AssetReference BeaconPrefabAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference PartyBeaconAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA53B0", Offset = "0xAA47B0", VA = "0x180AA53B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference PartyBeaconBeginPlaceAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference PartyBeaconDropAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference PartyBeaconRemovalAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xF91030", Offset = "0xF90430", VA = "0x180F91030")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1246800", Offset = "0x1245C00", VA = "0x181246800")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xFD5B10", Offset = "0xFD4F10", VA = "0x180FD5B10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1246810", Offset = "0x1245C10", VA = "0x181246810")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB59580", Offset = "0xB58980", VA = "0x180B59580")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color DefaultPartyBeaconColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCEDED0", Offset = "0xCED2D0", VA = "0x180CEDED0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81DB050", Offset = "0x81DA450", VA = "0x1881DB050")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FNNPHDBMLDC
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static CoordinationBeaconScriptableConfig NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81DC8D0", Offset = "0x81DBCD0", VA = "0x1881DC8D0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GGBCGKGOAKI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum IMPGAMDPKGH
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		REPLACED,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		CANCELED
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum EHDKGHHOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x81DC900", Offset = "0x81DBD00", VA = "0x1881DC900")]
	public static void DBNGAFCEIEC(int MNAACFOHONJ, string BNOFFNPEJHF, Guid GFNMCFDJMGK, HBMALBBABGM KKMJBGKCOBK, HOBCDNMALJG JLLAEJBJFOF, int ECPJAKPCBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x81DCE10", Offset = "0x81DC210", VA = "0x1881DCE10")]
	public static void MNKKBFLIJBC(int MNAACFOHONJ, string BNOFFNPEJHF, Guid GFNMCFDJMGK, HBMALBBABGM KKMJBGKCOBK, float FCFGKFEACHB, IMPGAMDPKGH BBDALAGLAAL, bool FHLBNHGBHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x81DD1F0", Offset = "0x81DC5F0", VA = "0x1881DD1F0")]
	public static void MOHCBAKIJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x81DD270", Offset = "0x81DC670", VA = "0x1881DD270")]
	public static void OIHBBEIPLOK(EHDKGHHOKFB HGKBPOJBJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x81DCCA0", Offset = "0x81DC0A0", VA = "0x1881DCCA0")]
	private static string IDEIABKPBHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KGBAJDDEEAF : KKIPHHAEHGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OELDDJODGCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KGBAJDDEEAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81DE690", Offset = "0x81DDA90", VA = "0x1881DE690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MKEEEPGAMPI AMAMJFHNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GAEGIMLBHMK FPFJNBJPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LIOPEKKCMPE LHICPJENFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PHBMGMFGODN MPGHDJPEJLO;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool JGEOIMLIKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x81DDB60", Offset = "0x81DCF60", VA = "0x1881DDB60")]
	[MKODAOGKIAA.PONKMEEEKBE.CEKDFGPCPEP]
	internal static void CBKEIPHIAFB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x10BB460", Offset = "0x10BA860", VA = "0x1810BB460")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KGBAJDDEEAF([PKIHAALFADL(null)][NotNull] MKEEEPGAMPI DBBCAGAJCLL, [PKIHAALFADL(null)][NotNull] GAEGIMLBHMK JMPELNCNDBH, [PKIHAALFADL(null)][NotNull] LIOPEKKCMPE BEEJIMKKBFF, [PKIHAALFADL(null)][NotNull] PHBMGMFGODN ADAAJNKKEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81DDBD0", Offset = "0x81DCFD0", VA = "0x1881DDBD0", Slot = "5")]
	public void EFMDNAMOPDC(HOBCDNMALJG KLAJHEKPKMI, string DPBKALNGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81DDDE0", Offset = "0x81DD1E0", VA = "0x1881DDDE0", Slot = "7")]
	public bool LBCJKLPCPJF(Camera MLFNHNIBMNH, Vector3 DKACAPNFHBO, CoordinationBeaconBase AIMBDKCMNDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81DD950", Offset = "0x81DCD50", VA = "0x1881DD950", Slot = "6")]
	public bool ACMKEGGIIGM(Camera MLFNHNIBMNH, Vector3 DKACAPNFHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81DE070", Offset = "0x81DD470", VA = "0x1881DE070", Slot = "8")]
	[AsyncStateMachine(typeof(OELDDJODGCP))]
	public void MBPMFPIDEIK()
	{
	}
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CoordinationBeacon : CoordinationBeaconBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private RecNetRawImage recNetImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Image recNetImageBaseCircleImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Image recNetImageBaseCircleImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Material depthIgnoreMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private TextMeshPro accountTMPRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private TextMeshPro accountTMPDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Image iconRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Image iconDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Image directionalArrowRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Image directionalArrowDepthIgnore;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override RectTransform JHAJGIILCGE
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81DB2E0", Offset = "0x81DA6E0", VA = "0x1881DB2E0")]
		public void Initialize(Guid GFNMCFDJMGK, int GHIDJPLIKMJ, HBMALBBABGM HFJHENFIDEF, string GIFIGBNILAK, Sprite DKAFCMLEOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81DBAD0", Offset = "0x81DAED0", VA = "0x1881DBAD0")]
		public void SetVisibilityUsernameDepthIgnore(bool MLIAKBCNAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81DB090", Offset = "0x81DA490", VA = "0x1881DB090")]
		private void FEBHBPCBCFF(Color GPLEFOPHPJA, bool LDGDCNAAAIM, bool GOICDKCDHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public CoordinationBeacon()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class CoordinationBeaconBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float IGKBIHIDEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool EDGIFDCIOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float NGGBDFGKCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid NHMIEJAJDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int DPPFNPAKLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private HBMALBBABGM KJPNDFJEGAF;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid NGBODNHEHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7FE0", Offset = "0x2EC73E0", VA = "0x182EC7FE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int JHLBHCGPGBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA8CC60", Offset = "0xA8C060", VA = "0x180A8CC60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HBMALBBABGM DDEDGOAKMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
			get
			{
				return default(HBMALBBABGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public HBMALBBABGM ILKINEPOHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x81DA5B0", Offset = "0x81D99B0", VA = "0x1881DA5B0")]
			get
			{
				return default(HBMALBBABGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform JHAJGIILCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, GGBCGKGOAKI.IMPGAMDPKGH, HBMALBBABGM> FCMOKPPBLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x81DA500", Offset = "0x81D9900", VA = "0x1881DA500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x81DA5C0", Offset = "0x81D99C0", VA = "0x1881DA5C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81DA480", Offset = "0x81D9880", VA = "0x1881DA480", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x81DA3F0", Offset = "0x81D97F0", VA = "0x1881DA3F0")]
		protected void PJOFCLDPLJB(Guid GFNMCFDJMGK, int GHIDJPLIKMJ, HBMALBBABGM HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81DA450", Offset = "0x81D9850", VA = "0x1881DA450")]
		public void StartTimer(float PEKEHNECNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81DA460", Offset = "0x81D9860", VA = "0x1881DA460")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2255460", Offset = "0x2254860", VA = "0x182255460", Slot = "6")]
		public virtual void SetVisibility(bool MLIAKBCNAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2255440", Offset = "0x2254840", VA = "0x182255440")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x81DA400", Offset = "0x81D9800", VA = "0x1881DA400")]
		private void PNPLKECCEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		protected CoordinationBeaconBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CFDLACBNOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float? BMHKIADANMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float? NEAGOOFLPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public bool? LBDIHOFGODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool? GEGGGBAAIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float? JBLNIPMJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float? ABEDCCLMKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float? ACGBOOELIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float? HFCIGFBMDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int? HCPDBELHNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float? IOCIFFGECPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float? MNFFAHPHEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float? GNDPIONAOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool? KAGHELAGCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool? PJCNLHCLGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float? CDLNDJDLLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float? ICDBBPKCBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float? HOMEEIIMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool? CFKOKCFBDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float? HJDBLNLFJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float? GHAHJPHLAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float? LBPMKKDPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float? KENAFFCLHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float? ALJIDMHEFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int? BBONKKBMCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float? NPEAHHHFMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float? OCFIJKFAFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float? CCDLMEKGNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float? KFLFFPNPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool? FNCOKHOECAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float? JGDCCCOIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool? NLDBHKAEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool? MEGFLKDONLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool? FDPDAKOMFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool? JJJGGEHIJBL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CFDLACBNOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BKMDPOKPJLL : MKEEEPGAMPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LFMDEIGOMOD NBDLCEGBBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IPONJNHEOIB MDCECICCKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly FEGLFIFLMGC KEHCHIMGIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CFDLACBNOFF FCAHLJLEKDF;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float BMHKIADANMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x81DA0B0", Offset = "0x81D94B0", VA = "0x1881DA0B0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float NEAGOOFLPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81D90A0", Offset = "0x81D84A0", VA = "0x1881D90A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LBDIHOFGODH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x81D9720", Offset = "0x81D8B20", VA = "0x1881D9720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GEGGGBAAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81D9D30", Offset = "0x81D9130", VA = "0x1881D9D30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public float JBLNIPMJKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x81D9A90", Offset = "0x81D8E90", VA = "0x1881D9A90", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float ABEDCCLMKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x81D8EF0", Offset = "0x81D82F0", VA = "0x1881D8EF0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public float ACGBOOELIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x81D9260", Offset = "0x81D8660", VA = "0x1881D9260", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public float HFCIGFBMDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81D9940", Offset = "0x81D8D40", VA = "0x1881D9940", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int HCPDBELHNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81D9EF0", Offset = "0x81D92F0", VA = "0x1881D9EF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public float IOCIFFGECPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81D99B0", Offset = "0x81D8DB0", VA = "0x1881D99B0", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public float MNFFAHPHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81D9F60", Offset = "0x81D9360", VA = "0x1881D9F60", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public float GNDPIONAOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81D8D30", Offset = "0x81D8130", VA = "0x1881D8D30", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool KAGHELAGCMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81D9E80", Offset = "0x81D9280", VA = "0x1881D9E80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool PJCNLHCLGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81D9FD0", Offset = "0x81D93D0", VA = "0x1881D9FD0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool MEGFLKDONLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81D9800", Offset = "0x81D8C00", VA = "0x1881D9800", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool OPOHDGEBLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x81D8C10", Offset = "0x81D8010", VA = "0x1881D8C10", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float CDLNDJDLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x81D9A20", Offset = "0x81D8E20", VA = "0x1881D9A20", Slot = "26")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float ICDBBPKCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x81D9580", Offset = "0x81D8980", VA = "0x1881D9580", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float HOMEEIIMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x81D9DA0", Offset = "0x81D91A0", VA = "0x1881D9DA0", Slot = "28")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CFKOKCFBDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x81D8E80", Offset = "0x81D8280", VA = "0x1881D8E80", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public float HJDBLNLFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x81D9110", Offset = "0x81D8510", VA = "0x1881D9110", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public float GHAHJPHLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x81D8DA0", Offset = "0x81D81A0", VA = "0x1881D8DA0", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float LBPMKKDPLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81D9180", Offset = "0x81D8580", VA = "0x1881D9180", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float KENAFFCLHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x81D9510", Offset = "0x81D8910", VA = "0x1881D9510", Slot = "33")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float ALJIDMHEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x81D9860", Offset = "0x81D8C60", VA = "0x1881D9860", Slot = "34")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int BBONKKBMCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81D9790", Offset = "0x81D8B90", VA = "0x1881D9790", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public float NPEAHHHFMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81D98D0", Offset = "0x81D8CD0", VA = "0x1881D98D0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public float OCFIJKFAFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81D9CC0", Offset = "0x81D90C0", VA = "0x1881D9CC0", Slot = "37")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float CCDLMEKGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x81D9C50", Offset = "0x81D9050", VA = "0x1881D9C50", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public float KFLFFPNPCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x81D8B30", Offset = "0x81D7F30", VA = "0x1881D8B30", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool FNCOKHOECAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x81D8BA0", Offset = "0x81D7FA0", VA = "0x1881D8BA0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool IGMAIPABEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81DA120", Offset = "0x81D9520", VA = "0x1881DA120", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x81D9E10", Offset = "0x81D9210", VA = "0x1881D9E10", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool JJJGGEHIJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81D8F60", Offset = "0x81D8360", VA = "0x1881D8F60", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x81D94A0", Offset = "0x81D88A0", VA = "0x1881D94A0", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public float JGDCCCOIKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x81D8E10", Offset = "0x81D8210", VA = "0x1881D8E10", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool NLDBHKAEIII
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x81D91F0", Offset = "0x81D85F0", VA = "0x1881D91F0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x81DA180", Offset = "0x81D9580", VA = "0x1881DA180")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKMDPOKPJLL([PKIHAALFADL(null)] LFMDEIGOMOD HPKDJJIICKF, [PKIHAALFADL(null)] IPONJNHEOIB HBKDOFKNAFB, [PKIHAALFADL(null)] FEGLFIFLMGC DCJCCAHLOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x81D9030", Offset = "0x81D8430", VA = "0x1881D9030")]
	[MKODAOGKIAA.LAFEFHEHFHN.PPBCBBDKDNB]
	internal static void CBKEIPHIAFB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x81D92D0", Offset = "0x81D86D0", VA = "0x1881D92D0", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x81D8FC0", Offset = "0x81D83C0", VA = "0x1881D8FC0")]
	private void BNNPMGAFMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x81D96D0", Offset = "0x81D8AD0", VA = "0x1881D96D0")]
	private void FAKOANBCCIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81D8FC0", Offset = "0x81D83C0", VA = "0x1881D8FC0")]
	private void FEHGJABLFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x81D8FC0", Offset = "0x81D83C0", VA = "0x1881D8FC0")]
	private void KLJNLMNNABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81DA040", Offset = "0x81D9440", VA = "0x1881DA040", Slot = "19")]
	public void NOCMEBHFDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A422E0", Offset = "0x3A416E0", VA = "0x183A422E0")]
	private T HJAOLEKHFBM<T>(string DEBELIHKPHH, T? GAMAAOLDGEM, T ABINAMGBLJP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x81D9B00", Offset = "0x81D8F00", VA = "0x1881D9B00")]
	private bool JCJIGBMONBK(string NKDMOIHNBAG, bool? GAMAAOLDGEM, bool ABINAMGBLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x81D95F0", Offset = "0x81D89F0", VA = "0x1881D95F0")]
	private void EOLEIFECAFE(string NKDMOIHNBAG, bool? GAMAAOLDGEM, bool LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81D8FC0", Offset = "0x81D83C0", VA = "0x1881D8FC0")]
	private void ECNAFBDFPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81D96D0", Offset = "0x81D8AD0", VA = "0x1881D96D0")]
	private void KLKGGMIPEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum HBMALBBABGM
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	LOOK_AT_THIS = 1,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	COME_HERE = 2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	WATCH_OUT_RRO_ENEMY = 4,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	WATCH_OUT_PLAYER_ENEMY = 8,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	TAKE_THIS = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	ALLY = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	PARTY = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CONTEXTUAL_TYPE = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	PARTY_TYPE = 0x40
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CoordinationBeaconHUDElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private Transform chevronRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private RectTransform rootRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Image recNetImageRootMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private TextMeshProUGUI distanceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private TextMeshProUGUI usernameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private Image iconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Image directionalIcon;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public GameObject EJCFFHIILMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2255460", Offset = "0x2254860", VA = "0x182255460")]
		public void SetVisibility(bool MLIAKBCNAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2255440", Offset = "0x2254840", VA = "0x182255440")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x81DA790", Offset = "0x81D9B90", VA = "0x1881DA790")]
		public void Initialize(int JFAMMKOLNIJ, HBMALBBABGM HFJHENFIDEF, string GIFIGBNILAK, Sprite DKAFCMLEOAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x81DAD60", Offset = "0x81DA160", VA = "0x1881DAD60")]
		public void UpdateVisualElements(Quaternion DEKAJOAKFEC, Vector3 IPGNGMJBFOL, float CCIMPAJPNEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81DA670", Offset = "0x81D9A70", VA = "0x1881DA670")]
		private void FEBHBPCBCFF(Color GPLEFOPHPJA, bool LDGDCNAAAIM, bool GOICDKCDHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NNDBKAGPBFB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public CoordinationBeaconRateLimitingFeedbackVisual <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public NNDBKAGPBFB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x81DE520", Offset = "0x81DD920", VA = "0x1881DE520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x81DE640", Offset = "0x81DDA40", VA = "0x1881DE640", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public float fadeDurationS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Color originalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private float IGKBIHIDEDF;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x81DAFA0", Offset = "0x81DA3A0", VA = "0x1881DAFA0")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x81DAF20", Offset = "0x81DA320", VA = "0x1881DAF20")]
		[IteratorStateMachine(typeof(NNDBKAGPBFB))]
		private IEnumerator BIBFPNEDDEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x81DB040", Offset = "0x81DA440", VA = "0x1881DB040")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NMNNLOEFKFN : BALMPHCBGIC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ECFCPGIOFGO OKFKBKGCFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IDisposable MFAFAJIMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool PHLGJCIGGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool IAAEHCIAIIP;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool HMKDAHDFAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool DELKKIJECEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x15552D0", Offset = "0x15546D0", VA = "0x1815552D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x81DE3A0", Offset = "0x81DD7A0", VA = "0x1881DE3A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NMNNLOEFKFN([PKIHAALFADL(null)] ECFCPGIOFGO KPJGMLONPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x81DE210", Offset = "0x81DD610", VA = "0x1881DE210", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x81DE1A0", Offset = "0x81DD5A0", VA = "0x1881DE1A0")]
	[MKODAOGKIAA.LAFEFHEHFHN.PPBCBBDKDNB]
	internal static void CBKEIPHIAFB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x81DE360", Offset = "0x81DD760", VA = "0x1881DE360", Slot = "6")]
	public void KHKJEOPAKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x81DE120", Offset = "0x81DD520", VA = "0x1881DE120", Slot = "7")]
	public bool AMGGPBPKFGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x81DE370", Offset = "0x81DD770", VA = "0x1881DE370", Slot = "8")]
	public void PLPLOKEBGHK(LCCHGCBPFIP PHIIDLOGBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x81DE260", Offset = "0x81DD660", VA = "0x1881DE260")]
	private HGKAPEFBFIF IIFHAEHMEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x81DE130", Offset = "0x81DD530", VA = "0x1881DE130")]
	private void BDPOBLFCFOL(PJKBEIHEIIE CBACLCMNDEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GKMHHCLBJMF : OGLMLCIGKMJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly ECFCPGIOFGO OKFKBKGCFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JPBKNFHFEPN MEFJPGCJIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly JPBKNFHFEPN JEICFPAPKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IDisposable MFAFAJIMIGP;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool KAGIAMPJOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x81DD710", Offset = "0x81DCB10", VA = "0x1881DD710", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool PHJLHKNLDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81DD350", Offset = "0x81DC750", VA = "0x1881DD350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x81DD760", Offset = "0x81DCB60", VA = "0x1881DD760")]
	[RecRoom.NoEngine.Common.Preserve]
	public GKMHHCLBJMF([PKIHAALFADL(null)] ECFCPGIOFGO KPJGMLONPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x81DD410", Offset = "0x81DC810", VA = "0x1881DD410", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x81DD3A0", Offset = "0x81DC7A0", VA = "0x1881DD3A0")]
	[MKODAOGKIAA.LAFEFHEHFHN.PPBCBBDKDNB]
	internal static void CBKEIPHIAFB(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x81DD6B0", Offset = "0x81DCAB0", VA = "0x1881DD6B0", Slot = "5")]
	public void LHMAAMBEEDE(ACAHCPOBLDI MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x81DD6E0", Offset = "0x81DCAE0", VA = "0x1881DD6E0", Slot = "6")]
	public bool OBAAGLONNBE(ACAHCPOBLDI MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x81DD460", Offset = "0x81DC860", VA = "0x1881DD460", Slot = "8")]
	public void GAMOKBGJIAO(ACAHCPOBLDI MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x81DD490", Offset = "0x81DC890", VA = "0x1881DD490", Slot = "9")]
	public bool HBMDGGLHFIG(ACAHCPOBLDI MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x81DD4C0", Offset = "0x81DC8C0", VA = "0x1881DD4C0")]
	private HGKAPEFBFIF IIFHAEHMEMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x81DD5C0", Offset = "0x81DC9C0", VA = "0x1881DD5C0")]
	private void JCHMAJMMEIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum HOBCDNMALJG
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	TEAM,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	ALWAYS
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class CoordinationPartyBeacon : CoordinationBeaconBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private GameObject toggleableButtonCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private GameObject alreadyInPartyCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private GameObject glowDisc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform partyUpEffectLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Image flagBaseRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private TextMeshPro titleRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private LNANLCMJBOJ FEHAJHNBKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private OBCFCHOGKEJ BCEIBFLJKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MKEEEPGAMPI AMAMJFHNGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private NBAEIFIEMDJ MKGIHPBLINN;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform JHAJGIILCGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject KEPJAIDCGOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string EHOEAPKBFBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB1F130", Offset = "0xB1E530", VA = "0x180B1F130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x81DBF70", Offset = "0x81DB370", VA = "0x1881DBF70")]
		public void Initialize(Guid GFNMCFDJMGK, int GHIDJPLIKMJ, string GIFIGBNILAK, string EKHBOAMLNOI, Color? NKEFKPOJKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x81DBB10", Offset = "0x81DAF10", VA = "0x1881DBB10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x81DC730", Offset = "0x81DBB30", VA = "0x1881DC730", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x81DC550", Offset = "0x81DB950", VA = "0x1881DC550", Slot = "6")]
		public override void SetVisibility(bool MLIAKBCNAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x81DC4F0", Offset = "0x81DB8F0", VA = "0x1881DC4F0")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81DC6E0", Offset = "0x81DBAE0", VA = "0x1881DC6E0")]
		public void UpdateParty(string AGENKFDMPIN, Color? IHABKLALPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x81DC0E0", Offset = "0x81DB4E0", VA = "0x1881DC0E0")]
		private bool MHNJMOJIDNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x81DBE90", Offset = "0x81DB290", VA = "0x1881DBE90")]
		private bool GJNNNFMAEPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x81DBCE0", Offset = "0x81DB0E0", VA = "0x1881DBCE0")]
		private bool ECPJNFLLCCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x81DBD90", Offset = "0x81DB190", VA = "0x1881DBD90")]
		private void FEBHBPCBCFF(Color? JJLMIHCJPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x81DC5A0", Offset = "0x81DB9A0", VA = "0x1881DC5A0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public CoordinationPartyBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PJLJLBMMICN
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	INACTIVE,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	BEING_PLACED,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DROPPED
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IOLKMJMPJFB
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public CoordinationBeaconBase OMCPCDADGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public IOLKMJMPJFB(CoordinationBeaconBase AIMBDKCMNDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NCOLAEFGMJC : IOLKMJMPJFB
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CoordinationBeaconHUDElement BNKPBBGEAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public NCOLAEFGMJC(CoordinationBeaconBase AIMBDKCMNDK, CoordinationBeaconHUDElement KDHBEPHAPLC)
	{
	}
}
namespace Cpp2IlInjected
{
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
}
