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
		[Cpp2IlInjected.Address(RVA = "0x80332A0", Offset = "0x8031EA0", VA = "0x1880332A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[HPDGMOCLOMK("CoordinationBeacons")]
public enum OLFAKANNDPG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[APHEKPEJLGB("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[APHEKPEJLGB("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[APHEKPEJLGB("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[APHEKPEJLGB("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[APHEKPEJLGB("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[APHEKPEJLGB("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[APHEKPEJLGB("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[APHEKPEJLGB("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[APHEKPEJLGB("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[APHEKPEJLGB("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[APHEKPEJLGB("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[APHEKPEJLGB("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[APHEKPEJLGB("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[APHEKPEJLGB("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[APHEKPEJLGB("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[APHEKPEJLGB("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[APHEKPEJLGB("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[APHEKPEJLGB("Another party member already has a party flag!", true)]
	WARNING_OTHER_PARTY_MEMBER_HAS_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[APHEKPEJLGB("Placing a party flag is rate limited. Try again later!", true)]
	WARNING_PARTY_FLAG_RATE_LIMITED,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[APHEKPEJLGB("Drop Party Flag", true)]
	BUTTON_DROP_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[APHEKPEJLGB("Party Flag", true)]
	BUTTON_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[APHEKPEJLGB("Cancel Party Flag", true)]
	BUTTON_CANCEL_PARTY_FLAG
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MNNCPBIKJNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AIMHDDMPIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKIGDOLLLFD(JKDGBNIPGDN HGNMIEOADHO, string ECPMFGOMPAP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LHMDMEBNGJE(Camera LOAIHMJNEEH, Vector3 BDCECLIJKNN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NMFFHHAHECE(Camera LOAIHMJNEEH, Vector3 BDCECLIJKNN, CoordinationBeaconBase BIMOANFNHEI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCMJGENJLJM();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JKNOFFCKFCD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JNMJFLJHMNB HCFCAKMLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LOICFKMLFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MIFKNFHJKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int KKBAJJGJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCOKKMNKPNM(int JGCECIEIGLF, Vector3 DBJHIELJGEC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLLLGBOEIBP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FIFMMGOLIIN();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DHOIGPEINPM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IKNKLEMJBGG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float OIABMGGPOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float CDJKDGJMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IJPHEOGPCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ACHPLMBNBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float AHGJOFOMFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float MNJHFKPMADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float PGMLDGJCPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float GMLGHODOMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int JKKNNOBOJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float IJEHFHNPFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float PMFFBBEKGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float LIMCPIOEGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool EMENIPEBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool HOEPODFIPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool AHIPOMODLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JLINONBHCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FLOGMDIPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float BGCKPACDBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IEMFNAFKIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NMPHLMPMKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float PLJOFEOKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float NOAGAIMDKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float PDGMEHMMGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DLOCJGOFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	float PMFNPODOLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float MAABHMLCOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float OKBKDFJLMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	float CGAHOFDLPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float CNLEADGNGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KJGDOLDHEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float FJHEMMBKPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	float AIIGCPJNNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	float NFCFJLNPBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	float EIFCCBLFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEFNMIKONOE();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AAEANEJHHHO
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	List<PDAAENGBLAJ> FPEGHJLMGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	List<GHLPLCGEAKB> NFPBEPFELOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> NKPCAKKGAEC(bool JOGGDGHGGPI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CoordinationPartyBeacon> HPHJCBDHCHB();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INAMOCPADGO(Guid KJJAAPACGMF, IOEGGLLHNNA.GAPDMLDADIC GNMODIHLNOM, NHMBHOFHCHN MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HFOHMMLPKCN(int DCDEMJBPAID, [Out] CoordinationBeaconBase BLLFNHPKJOP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> GMHHJLJAGBE();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FKBGDNEAFOK(int DCDEMJBPAID, [Out] CoordinationPartyBeacon JHKMHKOGLPG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PNPECHDDOMF(string IECJLDOGCIF, [Out] CoordinationPartyBeacon PHJGNJEAKGC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KKHGKCGPCGO
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PHLAEHCOKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HOPBDKGNHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBCKAGELHAK();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMDMJCEHCPH();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FIPJFAMKCBG(HEBHGEKOEHP NBKNOAMHHFE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BDIBJLNGJLC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IFNFLPDLOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool FAHKFFPMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAJAEFBNDFN(HDJJBEMDFDP DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BDEKHHCGNIK(HDJJBEMDFDP DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOAADDIOBIG(HDJJBEMDFDP DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BKFBDJEPCAJ(HDJJBEMDFDP DANCOEFIHDF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PICJEKCLJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OBHLFMKLNKB(Guid KJJAAPACGMF, int DCDEMJBPAID, Vector3 OAAPODCLADO, NHMBHOFHCHN PBHLPKLGFAP, string FJBKBIPCKPA, Canvas PFMOKDJMLLB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEJPFBOKMFG(Guid KJJAAPACGMF, IOEGGLLHNNA.GAPDMLDADIC GNMODIHLNOM, NHMBHOFHCHN MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FPMGNEMONCM(int DCDEMJBPAID, [Out] Guid MLICHJPNBHO);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMBFNENDDEM(Guid KJJAAPACGMF, NHMBHOFHCHN MDCDODCGNEK, [Out] CoordinationBeaconBase FCPDDDLJIPA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOPOIGHFIFM(Vector3 BDCECLIJKNN, Canvas PFMOKDJMLLB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCAFCGCLGEG(CoordinationPartyBeacon FNKADEJBEKD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IJJGJABDONP();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task LICIIOCOAEG(Vector3 HFAKKPAKCIA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task AKNELMGIHBB(Guid KJJAAPACGMF, int DCDEMJBPAID, string FJBKBIPCKPA, string IECJLDOGCIF, Color? OJFHCGKFCCF, [Optional] HFDBLEOKNJB? NLMLOPBNDAG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NEBEGOFELGP();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPPEPPJFKBO();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FKBGDNEAFOK(int DCDEMJBPAID, [Out] CoordinationPartyBeacon JHKMHKOGLPG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LMHKNCFBFLM(Guid KJJAAPACGMF, int DCDEMJBPAID, string FJBKBIPCKPA, Vector3 HBMPGJLLJCN, string IECJLDOGCIF, Color? OJFHCGKFCCF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PKOGLPNIAOO(string IECJLDOGCIF, [Out] CoordinationPartyBeacon PHJGNJEAKGC);
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference PartyBeaconAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA633E0", Offset = "0xA61FE0", VA = "0x180A633E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA944F0", Offset = "0xA930F0", VA = "0x180A944F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference PartyBeaconBeginPlaceAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBE0", Offset = "0xA5D7E0", VA = "0x180A5EBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference PartyBeaconDropAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB40", Offset = "0xA5D740", VA = "0x180A5EB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference PartyBeaconRemovalAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA70", Offset = "0xA5D670", VA = "0x180A5EA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xF7F050", Offset = "0xF7DC50", VA = "0x180F7F050")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12057F0", Offset = "0x12043F0", VA = "0x1812057F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1205810", Offset = "0x1204410", VA = "0x181205810")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1205800", Offset = "0x1204400", VA = "0x181205800")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB416C0", Offset = "0xB402C0", VA = "0x180B416C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color DefaultPartyBeaconColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCE1870", Offset = "0xCE0470", VA = "0x180CE1870")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x802DE60", Offset = "0x802CA60", VA = "0x18802DE60")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OOGIFOKAHCF
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static CoordinationBeaconScriptableConfig MFAGMJBMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8033270", Offset = "0x8031E70", VA = "0x188033270")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IOEGGLLHNNA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum GAPDMLDADIC
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		REPLACED,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		CANCELED
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum IMICHHFKGDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x80315F0", Offset = "0x80301F0", VA = "0x1880315F0")]
	public static void FCJLJDEFCNE(int IOIEACLIHPH, string KLNHLHPKAHD, Guid KJJAAPACGMF, NHMBHOFHCHN NFBCDCPBPHB, JKDGBNIPGDN IGEHBEOONMF, int BHKNCPAMFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8031B90", Offset = "0x8030790", VA = "0x188031B90")]
	public static void PJIKLJFNMBF(int IOIEACLIHPH, string KLNHLHPKAHD, Guid KJJAAPACGMF, NHMBHOFHCHN NFBCDCPBPHB, float NCCBPLEEPFF, GAPDMLDADIC GNMODIHLNOM, bool IKIFALOMDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8031990", Offset = "0x8030590", VA = "0x188031990")]
	public static void GHIPCKHCIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8031510", Offset = "0x8030110", VA = "0x188031510")]
	public static void EDHMAFBLIBJ(IMICHHFKGDK AHMJDEJLLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8031A10", Offset = "0x8030610", VA = "0x188031A10")]
	private static string MFPFHLPHEAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKAIBKFCAKC : MNNCPBIKJNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JLBGAAHFNNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JKAIBKFCAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8032740", Offset = "0x8031340", VA = "0x188032740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IKNKLEMJBGG GLDEBCMCMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AAEANEJHHHO LHPBGIFCKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GNNHJGKDEMF PFILGGACBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PPCFOICNNDO GNGDDCKMJLA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool AIMHDDMPIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8031F70", Offset = "0x8030B70", VA = "0x188031F70")]
	[HHMPGEJNNFC.FBIGHDDEPNK.JGJBEHOIDHJ]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x107AF70", Offset = "0x1079B70", VA = "0x18107AF70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JKAIBKFCAKC([HAKCNCGPHPD(null)][NotNull] IKNKLEMJBGG GMCBDPFCPCI, [HAKCNCGPHPD(null)][NotNull] AAEANEJHHHO IBGJDMOCGDP, [HAKCNCGPHPD(null)][NotNull] GNNHJGKDEMF PANHMDCENKO, [HAKCNCGPHPD(null)][NotNull] PPCFOICNNDO ILDAMLPPGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80321F0", Offset = "0x8030DF0", VA = "0x1880321F0", Slot = "5")]
	public void LKIGDOLLLFD(JKDGBNIPGDN HGNMIEOADHO, string ECPMFGOMPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8032400", Offset = "0x8031000", VA = "0x188032400", Slot = "7")]
	public bool NMFFHHAHECE(Camera LOAIHMJNEEH, Vector3 BDCECLIJKNN, CoordinationBeaconBase BIMOANFNHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8031FE0", Offset = "0x8030BE0", VA = "0x188031FE0", Slot = "6")]
	public bool LHMDMEBNGJE(Camera LOAIHMJNEEH, Vector3 BDCECLIJKNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8032690", Offset = "0x8031290", VA = "0x188032690", Slot = "8")]
	[AsyncStateMachine(typeof(JLBGAAHFNNA))]
	public void PCMJGENJLJM()
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
		public override RectTransform FMFMJEBEJFH
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x802E0F0", Offset = "0x802CCF0", VA = "0x18802E0F0")]
		public void Initialize(Guid KJJAAPACGMF, int BNLEBJOKLJB, NHMBHOFHCHN PBHLPKLGFAP, string FJBKBIPCKPA, Sprite OMIOJCNOIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x802E8E0", Offset = "0x802D4E0", VA = "0x18802E8E0")]
		public void SetVisibilityUsernameDepthIgnore(bool HOAKHBIFGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x802DEA0", Offset = "0x802CAA0", VA = "0x18802DEA0")]
		private void GFGHMNGGOEK(Color DKNKKENMJJJ, bool OFEEBOOMNLN, bool KOGIOMLMFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
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
		private float INDILPOECPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool AGLEHCPEPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float CAICGAGHAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid HMCGMCNOGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int HPCMPLCPPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private NHMBHOFHCHN OMLHMMMGABI;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid CKHNJNJFACM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2E442C0", Offset = "0x2E42EC0", VA = "0x182E442C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int OOMEBCODEIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA7B170", Offset = "0xA79D70", VA = "0x180A7B170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public NHMBHOFHCHN NFMCACNMIGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD050B0", Offset = "0xD03CB0", VA = "0x180D050B0")]
			get
			{
				return default(NHMBHOFHCHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public NHMBHOFHCHN PPCJCELELFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x802D3C0", Offset = "0x802BFC0", VA = "0x18802D3C0")]
			get
			{
				return default(NHMBHOFHCHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform FMFMJEBEJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, IOEGGLLHNNA.GAPDMLDADIC, NHMBHOFHCHN> JJFIKPJNFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x802D310", Offset = "0x802BF10", VA = "0x18802D310")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x802D3D0", Offset = "0x802BFD0", VA = "0x18802D3D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x802D290", Offset = "0x802BE90", VA = "0x18802D290", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x802D200", Offset = "0x802BE00", VA = "0x18802D200")]
		protected void BFHPBJMBKJO(Guid KJJAAPACGMF, int BNLEBJOKLJB, NHMBHOFHCHN PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x802D260", Offset = "0x802BE60", VA = "0x18802D260")]
		public void StartTimer(float GFHIKNNNGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x802D270", Offset = "0x802BE70", VA = "0x18802D270")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x21F85C0", Offset = "0x21F71C0", VA = "0x1821F85C0", Slot = "6")]
		public virtual void SetVisibility(bool HOAKHBIFGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x21F85A0", Offset = "0x21F71A0", VA = "0x1821F85A0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x802D210", Offset = "0x802BE10", VA = "0x18802D210")]
		private void NKDCMIGDFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		protected CoordinationBeaconBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MLNOFGFDACA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float? OIABMGGPOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float? CDJKDGJMAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public bool? IJPHEOGPCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool? ACHPLMBNBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float? AHGJOFOMFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float? MNJHFKPMADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float? PGMLDGJCPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float? GMLGHODOMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int? JKKNNOBOJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float? IJEHFHNPFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float? PMFFBBEKGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float? LIMCPIOEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool? EMENIPEBDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool? HOEPODFIPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float? PLJOFEOKFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float? NOAGAIMDKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float? PDGMEHMMGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool? DLOCJGOFJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float? PMFNPODOLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float? MAABHMLCOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float? OKBKDFJLMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float? CGAHOFDLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float? CNLEADGNGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int? KJGDOLDHEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float? FJHEMMBKPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float? AIIGCPJNNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float? NFCFJLNPBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float? EIFCCBLFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool? MNLKELMCFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float? BGCKPACDBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool? IEMFNAFKIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool? AHIPOMODLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool? KAMHKICMGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool? FLOGMDIPJGE;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MLNOFGFDACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GPKDGCJKAOD : IKNKLEMJBGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CEDFNINGHPN PIDNHNDJLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IFMJLEBMFFE BKPDIHIOJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly PEHHKHACOAC HCNKJOLAEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private MLNOFGFDACA INBBDJAKBIF;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float OIABMGGPOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80309F0", Offset = "0x802F5F0", VA = "0x1880309F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float CDJKDGJMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x802FF70", Offset = "0x802EB70", VA = "0x18802FF70", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool IJPHEOGPCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x80307C0", Offset = "0x802F3C0", VA = "0x1880307C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool ACHPLMBNBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8030B40", Offset = "0x802F740", VA = "0x188030B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public float AHGJOFOMFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8030670", Offset = "0x802F270", VA = "0x188030670", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float MNJHFKPMADA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8030D00", Offset = "0x802F900", VA = "0x188030D00", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public float PGMLDGJCPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8030440", Offset = "0x802F040", VA = "0x188030440", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public float GMLGHODOMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80306E0", Offset = "0x802F2E0", VA = "0x1880306E0", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int JKKNNOBOJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8030830", Offset = "0x802F430", VA = "0x188030830", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public float IJEHFHNPFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8030590", Offset = "0x802F190", VA = "0x188030590", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public float PMFFBBEKGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x802FE90", Offset = "0x802EA90", VA = "0x18802FE90", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public float LIMCPIOEGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x802FE20", Offset = "0x802EA20", VA = "0x18802FE20", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool EMENIPEBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x802FF00", Offset = "0x802EB00", VA = "0x18802FF00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool HOEPODFIPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x802FBA0", Offset = "0x802E7A0", VA = "0x18802FBA0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool AHIPOMODLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x802FB40", Offset = "0x802E740", VA = "0x18802FB40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool NMPHLMPMKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8030E50", Offset = "0x802FA50", VA = "0x188030E50", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float PLJOFEOKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8030D70", Offset = "0x802F970", VA = "0x188030D70", Slot = "26")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float NOAGAIMDKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8030980", Offset = "0x802F580", VA = "0x188030980", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float PDGMEHMMGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8030F70", Offset = "0x802FB70", VA = "0x188030F70", Slot = "28")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool DLOCJGOFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x802FC10", Offset = "0x802E810", VA = "0x18802FC10", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public float PMFNPODOLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8030C20", Offset = "0x802F820", VA = "0x188030C20", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public float MAABHMLCOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x80310C0", Offset = "0x802FCC0", VA = "0x1880310C0", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float OKBKDFJLMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8031050", Offset = "0x802FC50", VA = "0x188031050", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float CGAHOFDLPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x802FCF0", Offset = "0x802E8F0", VA = "0x18802FCF0", Slot = "33")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float CNLEADGNGLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8030750", Offset = "0x802F350", VA = "0x188030750", Slot = "34")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int KJGDOLDHEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8030C90", Offset = "0x802F890", VA = "0x188030C90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public float FJHEMMBKPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8030520", Offset = "0x802F120", VA = "0x188030520", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public float AIIGCPJNNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x80304B0", Offset = "0x802F0B0", VA = "0x1880304B0", Slot = "37")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float NFCFJLNPBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8030600", Offset = "0x802F200", VA = "0x188030600", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public float EIFCCBLFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8030BB0", Offset = "0x802F7B0", VA = "0x188030BB0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool MNLKELMCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8030040", Offset = "0x802EC40", VA = "0x188030040", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool JLINONBHCMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x802FFE0", Offset = "0x802EBE0", VA = "0x18802FFE0", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8030910", Offset = "0x802F510", VA = "0x188030910", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool FLOGMDIPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x802FAE0", Offset = "0x802E6E0", VA = "0x18802FAE0", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8030FE0", Offset = "0x802FBE0", VA = "0x188030FE0", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public float BGCKPACDBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x802FC80", Offset = "0x802E880", VA = "0x18802FC80", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool IEMFNAFKIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8030DE0", Offset = "0x802F9E0", VA = "0x188030DE0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8031130", Offset = "0x802FD30", VA = "0x188031130")]
	[RecRoom.NoEngine.Common.Preserve]
	public GPKDGCJKAOD([HAKCNCGPHPD(null)] CEDFNINGHPN NCAMCGOHDNP, [HAKCNCGPHPD(null)] IFMJLEBMFFE HBFAHNDJMNB, [HAKCNCGPHPD(null)] PEHHKHACOAC LAHHFPMLHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x80308A0", Offset = "0x802F4A0", VA = "0x1880308A0")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8030200", Offset = "0x802EE00", VA = "0x188030200", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x802FDB0", Offset = "0x802E9B0", VA = "0x18802FDB0")]
	private void DFKHOGIPIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x802FD60", Offset = "0x802E960", VA = "0x18802FD60")]
	private void JAPFNKKCABN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x802FDB0", Offset = "0x802E9B0", VA = "0x18802FDB0")]
	private void BKGGDOHKDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x802FDB0", Offset = "0x802E9B0", VA = "0x18802FDB0")]
	private void BHHOGMCMGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80303D0", Offset = "0x802EFD0", VA = "0x1880303D0", Slot = "19")]
	public void EEFNMIKONOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F860", Offset = "0x3C4E460", VA = "0x183C4F860")]
	private T PJAPEADAIIB<T>(string IELIEMDMNNF, T? GFFLPNHOMHA, T PLEDLJICBFM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80300B0", Offset = "0x802ECB0", VA = "0x1880300B0")]
	private bool DFBOEEKENCK(string PKIKOHHCFOI, bool? GFFLPNHOMHA, bool PLEDLJICBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8030A60", Offset = "0x802F660", VA = "0x188030A60")]
	private void MEPPOAKHCGJ(string PKIKOHHCFOI, bool? GFFLPNHOMHA, bool CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x802FDB0", Offset = "0x802E9B0", VA = "0x18802FDB0")]
	private void IAGCKGBEOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x802FD60", Offset = "0x802E960", VA = "0x18802FD60")]
	private void BFGAPHLJGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum NHMBHOFHCHN
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
		public GameObject NAPFDNKALIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x21F85C0", Offset = "0x21F71C0", VA = "0x1821F85C0")]
		public void SetVisibility(bool HOAKHBIFGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x21F85A0", Offset = "0x21F71A0", VA = "0x1821F85A0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x802D5A0", Offset = "0x802C1A0", VA = "0x18802D5A0")]
		public void Initialize(int DCDEMJBPAID, NHMBHOFHCHN PBHLPKLGFAP, string FJBKBIPCKPA, Sprite OMIOJCNOIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x802DB70", Offset = "0x802C770", VA = "0x18802DB70")]
		public void UpdateVisualElements(Quaternion FDOCHCMDEOP, Vector3 COLBAOBOGCI, float LFCDOMKLNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x802D480", Offset = "0x802C080", VA = "0x18802D480")]
		private void GFGHMNGGOEK(Color DKNKKENMJJJ, bool OFEEBOOMNLN, bool KOGIOMLMFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class IBDLLHKPEFM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public IBDLLHKPEFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x80313A0", Offset = "0x802FFA0", VA = "0x1880313A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x80314C0", Offset = "0x80300C0", VA = "0x1880314C0", Slot = "8")]
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
		private float INDILPOECPG;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x802DD30", Offset = "0x802C930", VA = "0x18802DD30")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x802DDD0", Offset = "0x802C9D0", VA = "0x18802DDD0")]
		[IteratorStateMachine(typeof(IBDLLHKPEFM))]
		private IEnumerator POBNJBIHNDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x802DE50", Offset = "0x802CA50", VA = "0x18802DE50")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FIBLEOFEHCB : KKHGKCGPCGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CGIGLIONEGJ BPMJDLBGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IDisposable AOELBBFCKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool OHBGAKHBNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool CKPOIEIEKBD;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool PHLAEHCOKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool HOPBDKGNHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x14FF3E0", Offset = "0x14FDFE0", VA = "0x1814FF3E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x802F960", Offset = "0x802E560", VA = "0x18802F960")]
	[RecRoom.NoEngine.Common.Preserve]
	public FIBLEOFEHCB([HAKCNCGPHPD(null)] CGIGLIONEGJ GIPGNPNHAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x802F6E0", Offset = "0x802E2E0", VA = "0x18802F6E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x802F870", Offset = "0x802E470", VA = "0x18802F870")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x802F950", Offset = "0x802E550", VA = "0x18802F950", Slot = "6")]
	public void NBCKAGELHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x802F860", Offset = "0x802E460", VA = "0x18802F860", Slot = "7")]
	public bool GMDMJCEHCPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x802F830", Offset = "0x802E430", VA = "0x18802F830", Slot = "8")]
	public void FIPJFAMKCBG(HEBHGEKOEHP NBKNOAMHHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x802F730", Offset = "0x802E330", VA = "0x18802F730")]
	private EMINEFLFECB EFGEKNPAPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x802F8E0", Offset = "0x802E4E0", VA = "0x18802F8E0")]
	private void MDMACLOICPK(KMDFPIFPLDI CNAOAEFKFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MKMNEHDGJGB : BDIBJLNGJLC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CGIGLIONEGJ BPMJDLBGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly GPPIOPCLACN OHPJNDCKAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly GPPIOPCLACN HMKLAMDJGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IDisposable AOELBBFCKKP;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool IFNFLPDLOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8033000", Offset = "0x8031C00", VA = "0x188033000", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool FAHKFFPMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8032E50", Offset = "0x8031A50", VA = "0x188032E50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8033080", Offset = "0x8031C80", VA = "0x188033080")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKMNEHDGJGB([HAKCNCGPHPD(null)] CGIGLIONEGJ GIPGNPNHAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8032CD0", Offset = "0x80318D0", VA = "0x188032CD0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8032F90", Offset = "0x8031B90", VA = "0x188032F90")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8033050", Offset = "0x8031C50", VA = "0x188033050", Slot = "5")]
	public void OAJAEFBNDFN(HDJJBEMDFDP DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8032C70", Offset = "0x8031870", VA = "0x188032C70", Slot = "6")]
	public bool BDEKHHCGNIK(HDJJBEMDFDP DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8032E20", Offset = "0x8031A20", VA = "0x188032E20", Slot = "8")]
	public void EOAADDIOBIG(HDJJBEMDFDP DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8032CA0", Offset = "0x80318A0", VA = "0x188032CA0", Slot = "9")]
	public bool BKFBDJEPCAJ(HDJJBEMDFDP DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8032D20", Offset = "0x8031920", VA = "0x188032D20")]
	private EMINEFLFECB EFGEKNPAPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8032EA0", Offset = "0x8031AA0", VA = "0x188032EA0")]
	private void HIGCJDHLBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum JKDGBNIPGDN
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
		private HPEIIEJIDII JCMNMPGPEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private MPIIOEGAGLP DHAOPJDHFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private IKNKLEMJBGG GLDEBCMCMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private JKNOFFCKFCD LGHMFDMDOMH;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform FMFMJEBEJFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA633E0", Offset = "0xA61FE0", VA = "0x180A633E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject JNJHANPNAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string OOEFNLGKPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB0CA10", Offset = "0xB0B610", VA = "0x180B0CA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB0CA60", Offset = "0xB0B660", VA = "0x180B0CA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x802ECD0", Offset = "0x802D8D0", VA = "0x18802ECD0")]
		public void Initialize(Guid KJJAAPACGMF, int BNLEBJOKLJB, string FJBKBIPCKPA, string IECJLDOGCIF, Color? OJFHCGKFCCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x802E920", Offset = "0x802D520", VA = "0x18802E920")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x802F540", Offset = "0x802E140", VA = "0x18802F540", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x802F360", Offset = "0x802DF60", VA = "0x18802F360", Slot = "6")]
		public override void SetVisibility(bool HOAKHBIFGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x802F300", Offset = "0x802DF00", VA = "0x18802F300")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x802F4F0", Offset = "0x802E0F0", VA = "0x18802F4F0")]
		public void UpdateParty(string HDCOAEGDBNC, Color? NMJGFALLLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x802EE40", Offset = "0x802DA40", VA = "0x18802EE40")]
		private bool PMEMEALDLKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x802EAF0", Offset = "0x802D6F0", VA = "0x18802EAF0")]
		private bool CHLKMMIIMCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x802F250", Offset = "0x802DE50", VA = "0x18802F250")]
		private bool POHOKMPOBHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x802EBD0", Offset = "0x802D7D0", VA = "0x18802EBD0")]
		private void GFGHMNGGOEK(Color? CFEGHHAMHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x802F3B0", Offset = "0x802DFB0", VA = "0x18802F3B0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public CoordinationPartyBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JNMJFLJHMNB
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	INACTIVE,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	BEING_PLACED,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DROPPED
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GHLPLCGEAKB
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public CoordinationBeaconBase LDINHJBCCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public GHLPLCGEAKB(CoordinationBeaconBase BIMOANFNHEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PDAAENGBLAJ : GHLPLCGEAKB
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CoordinationBeaconHUDElement EOBEHGKOOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
	public PDAAENGBLAJ(CoordinationBeaconBase BIMOANFNHEI, CoordinationBeaconHUDElement MEEDHLPGNJC)
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
