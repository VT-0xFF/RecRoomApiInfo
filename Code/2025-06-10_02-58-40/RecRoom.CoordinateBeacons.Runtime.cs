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
		[Cpp2IlInjected.Address(RVA = "0x7B98300", Offset = "0x7B97500", VA = "0x187B98300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[FALHOBPHIBJ("CoordinationBeacons")]
public enum MFIFNCLKJEF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[FIEKLLLAEKF("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[FIEKLLLAEKF("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[FIEKLLLAEKF("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[FIEKLLLAEKF("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[FIEKLLLAEKF("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[FIEKLLLAEKF("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[FIEKLLLAEKF("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[FIEKLLLAEKF("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[FIEKLLLAEKF("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[FIEKLLLAEKF("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[FIEKLLLAEKF("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[FIEKLLLAEKF("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[FIEKLLLAEKF("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[FIEKLLLAEKF("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FIEKLLLAEKF("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[FIEKLLLAEKF("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[FIEKLLLAEKF("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[FIEKLLLAEKF("Another party member already has a party flag!", true)]
	WARNING_OTHER_PARTY_MEMBER_HAS_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[FIEKLLLAEKF("Placing a party flag is rate limited. Try again later!", true)]
	WARNING_PARTY_FLAG_RATE_LIMITED,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[FIEKLLLAEKF("Drop Party Flag", true)]
	BUTTON_DROP_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[FIEKLLLAEKF("Party Flag", true)]
	BUTTON_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[FIEKLLLAEKF("Cancel Party Flag", true)]
	BUTTON_CANCEL_PARTY_FLAG
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MNKFAKDMIHF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ACMIAMDFEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHHAAEJOLJP(KNOPDJCOOMJ HMABFAOEGCI, string BKNLBNLOBGA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGNMAOKHCGK(Camera HEKBGKAPFJN, Vector3 CCJIHADDIKC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GGFINIAJGMH(Camera HEKBGKAPFJN, Vector3 CCJIHADDIKC, CoordinationBeaconBase PEJPNEOLPDH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDIAKCANNPI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FHBACHBCIGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OBNLHPJCNMA BFGLIANOANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GIFEKBGOMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CNDGJAKICGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int KHMPHILKMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FFNDKEMAGMH(int KJHLBBDMPBL, Vector3 FGOKDCELOKB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJNNMHBMAJE();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DOFEFOJENIE();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GNFDFCOAGGA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DEOAAGCMEFC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float LCBBEKDHAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float PGLOJOFIHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FFPKBDCKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DCBIHLNCJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HNGJOGEDBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float JMPKBHFABPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float PEKFKABMNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float BPONKJMNDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int OBMDCHCHLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float DNKOKMDNOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float GDLENCLJJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float FKGAJPNGHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HKDBMJFAAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OAGJKFAHCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NJPHJELPICA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GENOBBMBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FEPLIOJLFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float LOONEKCGCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JPNFLLDOOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DDEIPJKNJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float JAKBLHAPCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float CFECJKNLIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float NJMIFDNMBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JCJONCLAKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	float LDECEJDLNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float OMCGAJMCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float INCDNHPHGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	float DFCACKOEGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float CNMNLDMBODB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FHGEGONJKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float ALBHAHOEELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float FLOHFKCDIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	float CELHKALPDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	float CBAOHONAAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OIFILAGFAFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ANAMDPHPCEG
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	List<DPMAIOKOJLC> BKEBCOBGFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	List<JNKEOILECMH> KLCAHBCMGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> DAIEMALLHEC(bool PGLMENLMIIK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CoordinationPartyBeacon> OFDMJOHKCOD();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJFHDKLLLKO(Guid NGLMGFMLMJI, FMMKEKKMEFE.HCLMBJBOHAN NHAIMNLMGPI, MMGNNIEBMEO GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HJJIJCGMIHL(int KAHALLPNDLJ, [Out] CoordinationBeaconBase HAHDNFBDCPB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> DNDDFPINCCO();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NLEGCAHNFFI(int KAHALLPNDLJ, [Out] CoordinationPartyBeacon FMFHLLFOIEP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DJBNOKOJFLF(string DFNHCMECEBO, [Out] CoordinationPartyBeacon PPJEOMAALKG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JHCOOKGIFBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool EGMMCJFIBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AICLPMJKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMCFMAJHOAI();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GCEKHKMHHAH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNPEGDNMJOD(OJIMHFCMHLE JCFOMPGDMKN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PBDGLPOMDIP
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NAFIIIPLBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool BJGJIHAAECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAEFEFIBHOF(JPIJMPDMIDF CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCDKCFAKAKF(JPIJMPDMIDF CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEDPAOKFLGK(JPIJMPDMIDF CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NOPPFFKENAP(JPIJMPDMIDF CCLFNPCGNED);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NFDDINCJEKE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CHKEEDIEMPN(Guid NGLMGFMLMJI, int KAHALLPNDLJ, Vector3 AODDFCAEBMK, MMGNNIEBMEO BKDMJHGCDEA, string LGLONFHKOCI, Canvas MGDNBMJBLBP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BADHFJNJFMH(Guid NGLMGFMLMJI, FMMKEKKMEFE.HCLMBJBOHAN NHAIMNLMGPI, MMGNNIEBMEO GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHIGIJANLLG(int KAHALLPNDLJ, [Out] Guid AOBNKGELCNN);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PIDHIMDMCMG(Guid NGLMGFMLMJI, MMGNNIEBMEO GDHKDBJPDLG, [Out] CoordinationBeaconBase ANAONAHDJLB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOEIPNOOHHJ(Vector3 CCJIHADDIKC, Canvas MGDNBMJBLBP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIFJKELAPKE(CoordinationPartyBeacon CEHDAKJEFMO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNDGHNCIOFA();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DBDIBLPGJCK(Vector3 OBIMLLNKNDL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task IPHIAIIHOEP(Guid NGLMGFMLMJI, int KAHALLPNDLJ, string LGLONFHKOCI, string DFNHCMECEBO, Color? OOOHAABPOGD, [Optional] LOPBLGBJOCJ? MKEHFLDOAPC);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KHJHLBLGPHG();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OMNEEOHILJA();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NLEGCAHNFFI(int KAHALLPNDLJ, [Out] CoordinationPartyBeacon FMFHLLFOIEP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task EHIGKKHFOIK(Guid NGLMGFMLMJI, int KAHALLPNDLJ, string LGLONFHKOCI, Vector3 EKALBEGEFNA, string DFNHCMECEBO, Color? OOOHAABPOGD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool JAIHNLBDOHI(string DFNHCMECEBO, [Out] CoordinationPartyBeacon PPJEOMAALKG);
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference PartyBeaconAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA00390", Offset = "0x9FF590", VA = "0x180A00390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA38230", Offset = "0xA37430", VA = "0x180A38230")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference PartyBeaconBeginPlaceAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA0E420", Offset = "0xA0D620", VA = "0x180A0E420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference PartyBeaconDropAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA0E4A0", Offset = "0xA0D6A0", VA = "0x180A0E4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference PartyBeaconRemovalAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA0E520", Offset = "0xA0D720", VA = "0x180A0E520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xED05E0", Offset = "0xECF7E0", VA = "0x180ED05E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1105600", Offset = "0x1104800", VA = "0x181105600")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1105620", Offset = "0x1104820", VA = "0x181105620")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1105610", Offset = "0x1104810", VA = "0x181105610")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA9F2F0", Offset = "0xA9E4F0", VA = "0x180A9F2F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color DefaultPartyBeaconColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xC30290", Offset = "0xC2F490", VA = "0x180C30290")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B93030", Offset = "0x7B92230", VA = "0x187B93030")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MMLGIOENJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static CoordinationBeaconScriptableConfig AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B982D0", Offset = "0x7B974D0", VA = "0x187B982D0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FMMKEKKMEFE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum HCLMBJBOHAN
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		REPLACED,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		CANCELED
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum NCOBFCADOAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B94DE0", Offset = "0x7B93FE0", VA = "0x187B94DE0")]
	public static void AJOBEOEGFPD(int LJKLNEIKJAJ, string DIHPKKBOIOE, Guid NGLMGFMLMJI, MMGNNIEBMEO LGCEKFPEEIJ, KNOPDJCOOMJ AMLIJNCLBHD, int BGGNHFAJAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B95380", Offset = "0x7B94580", VA = "0x187B95380")]
	public static void EAOCHNDBADL(int LJKLNEIKJAJ, string DIHPKKBOIOE, Guid NGLMGFMLMJI, MMGNNIEBMEO LGCEKFPEEIJ, float DCCNAGGONCE, HCLMBJBOHAN NHAIMNLMGPI, bool OHOPMOOIPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B95180", Offset = "0x7B94380", VA = "0x187B95180")]
	public static void CJBMKGMGGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B95760", Offset = "0x7B94960", VA = "0x187B95760")]
	public static void IMOPMACMJJH(NCOBFCADOAF CCHKIDEGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B95200", Offset = "0x7B94400", VA = "0x187B95200")]
	private static string DIDFMEDNGGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GGEGLFKHIFO : MNKFAKDMIHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EHALAHBGLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GGEGLFKHIFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7B948B0", Offset = "0x7B93AB0", VA = "0x187B948B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DEOAAGCMEFC INBOOBFCDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ANAMDPHPCEG PFOPEFBCALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AMKPCHCHDLI OOPJCEDFCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DPBLHMMMNNM FAGGDKNNDEO;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ACMIAMDFEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B95B00", Offset = "0x7B94D00", VA = "0x187B95B00")]
	[MGCKGAIBEHC.JIJDPEMKHNE.MLLBAPEMCDB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xFB3B90", Offset = "0xFB2D90", VA = "0x180FB3B90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GGEGLFKHIFO([NGLIAOPBMFM(null)][NotNull] DEOAAGCMEFC DDJBECGKGGI, [NGLIAOPBMFM(null)][NotNull] ANAMDPHPCEG NKMNEOHCKDB, [NGLIAOPBMFM(null)][NotNull] AMKPCHCHDLI ADABLGGDMDI, [NGLIAOPBMFM(null)][NotNull] DPBLHMMMNNM DKICAHPGMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B95E00", Offset = "0x7B95000", VA = "0x187B95E00", Slot = "5")]
	public void MHHAAEJOLJP(KNOPDJCOOMJ HMABFAOEGCI, string BKNLBNLOBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B95B70", Offset = "0x7B94D70", VA = "0x187B95B70", Slot = "7")]
	public bool GGFINIAJGMH(Camera HEKBGKAPFJN, Vector3 CCJIHADDIKC, CoordinationBeaconBase PEJPNEOLPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B958F0", Offset = "0x7B94AF0", VA = "0x187B958F0", Slot = "6")]
	public bool BGNMAOKHCGK(Camera HEKBGKAPFJN, Vector3 CCJIHADDIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B95840", Offset = "0x7B94A40", VA = "0x187B95840", Slot = "8")]
	[AsyncStateMachine(typeof(EHALAHBGLNB))]
	public void BDIAKCANNPI()
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
		public override RectTransform JEADNILFJHO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B93070", Offset = "0x7B92270", VA = "0x187B93070")]
		public void Initialize(Guid NGLMGFMLMJI, int LJHIDJOOBJE, MMGNNIEBMEO BKDMJHGCDEA, string LGLONFHKOCI, Sprite NIIPHENHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7B93AB0", Offset = "0x7B92CB0", VA = "0x187B93AB0")]
		public void SetVisibilityUsernameDepthIgnore(bool DMHGIJPNHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7B93860", Offset = "0x7B92A60", VA = "0x187B93860")]
		private void LINPJBKGDNE(Color DOPKELKPGGA, bool KNJKLCHNIFN, bool NFLDCMJGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
		private float LNKAPENPOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool KDDCLDHNGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float NDJBOPPGDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid GEGMIEHMEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int JAIKJKNOMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MMGNNIEBMEO IIEEBMDCMLP;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid HHPKMABLCHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2CADC90", Offset = "0x2CACE90", VA = "0x182CADC90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int PEMFENLALCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7F0", Offset = "0xA1E9F0", VA = "0x180A1F7F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public MMGNNIEBMEO ODILGJPAECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xC535A0", Offset = "0xC527A0", VA = "0x180C535A0")]
			get
			{
				return default(MMGNNIEBMEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public MMGNNIEBMEO PMNCOINEHLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7B92590", Offset = "0x7B91790", VA = "0x187B92590")]
			get
			{
				return default(MMGNNIEBMEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform JEADNILFJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, FMMKEKKMEFE.HCLMBJBOHAN, MMGNNIEBMEO> JCJCEKIGINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7B924E0", Offset = "0x7B916E0", VA = "0x187B924E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B925A0", Offset = "0x7B917A0", VA = "0x187B925A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B92460", Offset = "0x7B91660", VA = "0x187B92460", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B923D0", Offset = "0x7B915D0", VA = "0x187B923D0")]
		protected void AFLILFPIJAH(Guid NGLMGFMLMJI, int LJHIDJOOBJE, MMGNNIEBMEO BKDMJHGCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B92430", Offset = "0x7B91630", VA = "0x187B92430")]
		public void StartTimer(float KACHJFMCKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B92440", Offset = "0x7B91640", VA = "0x187B92440")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x208D0D0", Offset = "0x208C2D0", VA = "0x18208D0D0", Slot = "6")]
		public virtual void SetVisibility(bool DMHGIJPNHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x208D0B0", Offset = "0x208C2B0", VA = "0x18208D0B0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B923E0", Offset = "0x7B915E0", VA = "0x187B923E0")]
		private void FACABJGDCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		protected CoordinationBeaconBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DKCPOIPHJLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float? LCBBEKDHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float? PGLOJOFIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public bool? FFPKBDCKFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool? DCBIHLNCJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float? HNGJOGEDBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float? JMPKBHFABPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float? PEKFKABMNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float? BPONKJMNDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int? OBMDCHCHLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float? DNKOKMDNOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float? GDLENCLJJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float? FKGAJPNGHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool? HKDBMJFAAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool? OAGJKFAHCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float? JAKBLHAPCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float? CFECJKNLIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float? NJMIFDNMBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool? JCJONCLAKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float? LDECEJDLNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float? OMCGAJMCPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float? INCDNHPHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float? DFCACKOEGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float? CNMNLDMBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int? FHGEGONJKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float? ALBHAHOEELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float? FLOHFKCDIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float? CELHKALPDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float? CBAOHONAAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool? GJNNFNOILGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float? LOONEKCGCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool? JPNFLLDOOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool? NJPHJELPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool? MLCAJKBDPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool? FEPLIOJLFFP;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DKCPOIPHJLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MMCHACOJDMN : DEOAAGCMEFC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IIOGDLIHHEO FPOMNNFIDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PGCLBGKNLGG PALGFHMNBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ABCAKKCKJPM NMGAHLPDIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DKCPOIPHJLG OEJGOBGNABG;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float LCBBEKDHAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B97DC0", Offset = "0x7B96FC0", VA = "0x187B97DC0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float PGLOJOFIHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B96A70", Offset = "0x7B95C70", VA = "0x187B96A70", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool FFPKBDCKFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B97320", Offset = "0x7B96520", VA = "0x187B97320", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DCBIHLNCJII
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B96C10", Offset = "0x7B95E10", VA = "0x187B96C10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public float HNGJOGEDBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B96DD0", Offset = "0x7B95FD0", VA = "0x187B96DD0", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float JMPKBHFABPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B975C0", Offset = "0x7B967C0", VA = "0x187B975C0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public float PEKFKABMNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B97C00", Offset = "0x7B96E00", VA = "0x187B97C00", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public float BPONKJMNDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B97D50", Offset = "0x7B96F50", VA = "0x187B97D50", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int OBMDCHCHLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B96EB0", Offset = "0x7B960B0", VA = "0x187B96EB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public float DNKOKMDNOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B97000", Offset = "0x7B96200", VA = "0x187B97000", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public float GDLENCLJJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B97850", Offset = "0x7B96A50", VA = "0x187B97850", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public float FKGAJPNGHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B96F20", Offset = "0x7B96120", VA = "0x187B96F20", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool HKDBMJFAAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B96B30", Offset = "0x7B95D30", VA = "0x187B96B30", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool OAGJKFAHCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B97710", Offset = "0x7B96910", VA = "0x187B97710", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool NJPHJELPICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B977F0", Offset = "0x7B969F0", VA = "0x187B977F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool DDEIPJKNJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B97A70", Offset = "0x7B96C70", VA = "0x187B97A70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float JAKBLHAPCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B97780", Offset = "0x7B96980", VA = "0x187B97780", Slot = "26")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float CFECJKNLIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B97A00", Offset = "0x7B96C00", VA = "0x187B97A00", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float NJMIFDNMBNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B97630", Offset = "0x7B96830", VA = "0x187B97630", Slot = "28")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool JCJONCLAKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B976A0", Offset = "0x7B968A0", VA = "0x187B976A0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public float LDECEJDLNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B97990", Offset = "0x7B96B90", VA = "0x187B97990", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public float OMCGAJMCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B97550", Offset = "0x7B96750", VA = "0x187B97550", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float INCDNHPHGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B972B0", Offset = "0x7B964B0", VA = "0x187B972B0", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float DFCACKOEGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B96D60", Offset = "0x7B95F60", VA = "0x187B96D60", Slot = "33")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float CNMNLDMBODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B974E0", Offset = "0x7B966E0", VA = "0x187B974E0", Slot = "34")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int FHGEGONJKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B97CE0", Offset = "0x7B96EE0", VA = "0x187B97CE0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public float ALBHAHOEELD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B978C0", Offset = "0x7B96AC0", VA = "0x187B978C0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public float FLOHFKCDIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B96F90", Offset = "0x7B96190", VA = "0x187B96F90", Slot = "37")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float CELHKALPDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B97390", Offset = "0x7B96590", VA = "0x187B97390", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public float CBAOHONAAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B97400", Offset = "0x7B96600", VA = "0x187B97400", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool GJNNFNOILGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B96BA0", Offset = "0x7B95DA0", VA = "0x187B96BA0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool GENOBBMBCBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B96A10", Offset = "0x7B95C10", VA = "0x187B96A10", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B96CF0", Offset = "0x7B95EF0", VA = "0x187B96CF0", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool FEPLIOJLFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B97930", Offset = "0x7B96B30", VA = "0x187B97930", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B97470", Offset = "0x7B96670", VA = "0x187B97470", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public float LOONEKCGCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B96E40", Offset = "0x7B96040", VA = "0x187B96E40", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool JPNFLLDOOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B97B90", Offset = "0x7B96D90", VA = "0x187B97B90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B98060", Offset = "0x7B97260", VA = "0x187B98060")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMCHACOJDMN([NGLIAOPBMFM(null)] IIOGDLIHHEO GKOIAJLIOIJ, [NGLIAOPBMFM(null)] PGCLBGKNLGG CBHLIBHMIJC, [NGLIAOPBMFM(null)] ABCAKKCKJPM MHPIJLIEOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B97240", Offset = "0x7B96440", VA = "0x187B97240")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B97070", Offset = "0x7B96270", VA = "0x187B97070", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B96C80", Offset = "0x7B95E80", VA = "0x187B96C80")]
	private void JHMMANAOGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B96AE0", Offset = "0x7B95CE0", VA = "0x187B96AE0")]
	private void HMFCMPCMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B96C80", Offset = "0x7B95E80", VA = "0x187B96C80")]
	private void JMONAFCKJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B96C80", Offset = "0x7B95E80", VA = "0x187B96C80")]
	private void CACNFANALDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B97C70", Offset = "0x7B96E70", VA = "0x187B97C70", Slot = "19")]
	public void OIFILAGFAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B024D0", Offset = "0x3B016D0", VA = "0x183B024D0")]
	private T KIEFHCEOMOI<T>(string AGOJJHAIPHP, T? MOJCFEGIIKM, T FEOJADDJKIL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B97E30", Offset = "0x7B97030", VA = "0x187B97E30")]
	private bool PMLDPHKHHEI(string OJCINIOPMLA, bool? MOJCFEGIIKM, bool FEOJADDJKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B97F80", Offset = "0x7B97180", VA = "0x187B97F80")]
	private void POPCPMEELCN(string OJCINIOPMLA, bool? MOJCFEGIIKM, bool KMHJHNJDCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B96C80", Offset = "0x7B95E80", VA = "0x187B96C80")]
	private void FADIPLMMGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7B96AE0", Offset = "0x7B95CE0", VA = "0x187B96AE0")]
	private void ACCFNPMCKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum MMGNNIEBMEO
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
		public GameObject CICMBECDLEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x208D0D0", Offset = "0x208C2D0", VA = "0x18208D0D0")]
		public void SetVisibility(bool DMHGIJPNHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x208D0B0", Offset = "0x208C2B0", VA = "0x18208D0B0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B92650", Offset = "0x7B91850", VA = "0x187B92650")]
		public void Initialize(int KAHALLPNDLJ, MMGNNIEBMEO BKDMJHGCDEA, string LGLONFHKOCI, Sprite NIIPHENHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B92D40", Offset = "0x7B91F40", VA = "0x187B92D40")]
		public void UpdateVisualElements(Quaternion MLEANMEGFAB, Vector3 JCHDHELBFIA, float BBDIDNFIGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B92C20", Offset = "0x7B91E20", VA = "0x187B92C20")]
		private void LINPJBKGDNE(Color DOPKELKPGGA, bool KNJKLCHNIFN, bool NFLDCMJGCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class BENIDMNGJOA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
			[DebuggerHidden]
			public BENIDMNGJOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B92260", Offset = "0x7B91460", VA = "0x187B92260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B92380", Offset = "0x7B91580", VA = "0x187B92380", Slot = "8")]
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
		private float LNKAPENPOJI;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B92F00", Offset = "0x7B92100", VA = "0x187B92F00")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B92FA0", Offset = "0x7B921A0", VA = "0x187B92FA0")]
		[IteratorStateMachine(typeof(BENIDMNGJOA))]
		private IEnumerator OGNGKNLDDKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B93020", Offset = "0x7B92220", VA = "0x187B93020")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KFGIDIFBLLB : JHCOOKGIFBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly FAMJNCFEMOB INKJOLONDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IDisposable BNGBOACIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool DLAGLEMJAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool DBAEIAJPGMP;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool EGMMCJFIBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3F0", Offset = "0xA0C5F0", VA = "0x180A0D3F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool AICLPMJKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x129EEE0", Offset = "0x129E0E0", VA = "0x18129EEE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B96290", Offset = "0x7B95490", VA = "0x187B96290")]
	[RecRoom.NoEngine.Common.Preserve]
	public KFGIDIFBLLB([NGLIAOPBMFM(null)] FAMJNCFEMOB NNPMIHDHFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B96180", Offset = "0x7B95380", VA = "0x187B96180", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B961D0", Offset = "0x7B953D0", VA = "0x187B961D0")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B96280", Offset = "0x7B95480", VA = "0x187B96280", Slot = "6")]
	public void LMCFMAJHOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B96270", Offset = "0x7B95470", VA = "0x187B96270", Slot = "7")]
	public bool GCEKHKMHHAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B96240", Offset = "0x7B95440", VA = "0x187B96240", Slot = "8")]
	public void FNPEGDNMJOD(OJIMHFCMHLE JCFOMPGDMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B96080", Offset = "0x7B95280", VA = "0x187B96080")]
	private CBFAMDHOPFE DEPGNCMFMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B96010", Offset = "0x7B95210", VA = "0x187B96010")]
	private void CEBJMEHNPFH(IMGOPGMMMDH LIPMOGGMBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MBOMLKKDIBG : PBDGLPOMDIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FAMJNCFEMOB INKJOLONDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly DOBKDOOJHFM PHIAKMOHMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly DOBKDOOJHFM PGNNAENLHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IDisposable BNGBOACIFJO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool NAFIIIPLBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B96650", Offset = "0x7B95850", VA = "0x187B96650", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool BJGJIHAAECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B96410", Offset = "0x7B95610", VA = "0x187B96410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B96820", Offset = "0x7B95A20", VA = "0x187B96820")]
	[RecRoom.NoEngine.Common.Preserve]
	public MBOMLKKDIBG([NGLIAOPBMFM(null)] FAMJNCFEMOB NNPMIHDHFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7B96590", Offset = "0x7B95790", VA = "0x187B96590", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B965E0", Offset = "0x7B957E0", VA = "0x187B965E0")]
	[MGCKGAIBEHC.MJEHAAIJGKF.HELJMGKJDLB]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B966A0", Offset = "0x7B958A0", VA = "0x187B966A0", Slot = "5")]
	public void MAEFEFIBHOF(JPIJMPDMIDF CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B96700", Offset = "0x7B95900", VA = "0x187B96700", Slot = "6")]
	public bool PCDKCFAKAKF(JPIJMPDMIDF CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B96460", Offset = "0x7B95660", VA = "0x187B96460", Slot = "8")]
	public void CEDPAOKFLGK(JPIJMPDMIDF CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B966D0", Offset = "0x7B958D0", VA = "0x187B966D0", Slot = "9")]
	public bool NOPPFFKENAP(JPIJMPDMIDF CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B96490", Offset = "0x7B95690", VA = "0x187B96490")]
	private CBFAMDHOPFE DEPGNCMFMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B96730", Offset = "0x7B95930", VA = "0x187B96730")]
	private void PMIMFMAOCIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum KNOPDJCOOMJ
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
		private MILMNEKAHPH DGNGONOAHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private DJKIFPNGNHF OHIAANKJKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private DEOAAGCMEFC INBOOBFCDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FHBACHBCIGJ OPIEEAFDKLC;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform JEADNILFJHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA00390", Offset = "0x9FF590", VA = "0x180A00390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject BMBKACHDODE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string LEJMLGBFMLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xDC9B70", Offset = "0xDC8D70", VA = "0x180DC9B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECDFD0", VA = "0x180ECEDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B941B0", Offset = "0x7B933B0", VA = "0x187B941B0")]
		public void Initialize(Guid NGLMGFMLMJI, int LJHIDJOOBJE, string LGLONFHKOCI, string DFNHCMECEBO, Color? OOOHAABPOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B93AF0", Offset = "0x7B92CF0", VA = "0x187B93AF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B94710", Offset = "0x7B93910", VA = "0x187B94710", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B94520", Offset = "0x7B93720", VA = "0x187B94520", Slot = "6")]
		public override void SetVisibility(bool DMHGIJPNHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B944D0", Offset = "0x7B936D0", VA = "0x187B944D0")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B946C0", Offset = "0x7B938C0", VA = "0x187B946C0")]
		public void UpdateParty(string EJHJBECLHOC, Color? DIGBFJLKCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B93CB0", Offset = "0x7B92EB0", VA = "0x187B93CB0")]
		private bool GPAOEPBCKMM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B940D0", Offset = "0x7B932D0", VA = "0x187B940D0")]
		private bool HIPMNFPMPPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B94320", Offset = "0x7B93520", VA = "0x187B94320")]
		private bool KKCPKPHPJPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B943D0", Offset = "0x7B935D0", VA = "0x187B943D0")]
		private void LINPJBKGDNE(Color? HJEDIIOLNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B94570", Offset = "0x7B93770", VA = "0x187B94570")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public CoordinationPartyBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OBNLHPJCNMA
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	INACTIVE,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	BEING_PLACED,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DROPPED
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JNKEOILECMH
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public CoordinationBeaconBase NHJDAOPLLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public JNKEOILECMH(CoordinationBeaconBase PEJPNEOLPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DPMAIOKOJLC : JNKEOILECMH
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CoordinationBeaconHUDElement FOLHEKOACLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public DPMAIOKOJLC(CoordinationBeaconBase PEJPNEOLPDH, CoordinationBeaconHUDElement MANELENOIKP)
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
