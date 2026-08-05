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
		[Cpp2IlInjected.Address(RVA = "0x7B753C0", Offset = "0x7B739C0", VA = "0x187B753C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DLDJIEPIMHK("CoordinationBeacons")]
public enum OPBPBAAMDIH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[MHHIIIPBOPN("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[MHHIIIPBOPN("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[MHHIIIPBOPN("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[MHHIIIPBOPN("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[MHHIIIPBOPN("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[MHHIIIPBOPN("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[MHHIIIPBOPN("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[MHHIIIPBOPN("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[MHHIIIPBOPN("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[MHHIIIPBOPN("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[MHHIIIPBOPN("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[MHHIIIPBOPN("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[MHHIIIPBOPN("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[MHHIIIPBOPN("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[MHHIIIPBOPN("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[MHHIIIPBOPN("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[MHHIIIPBOPN("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[MHHIIIPBOPN("Another party member already has a party flag!", true)]
	WARNING_OTHER_PARTY_MEMBER_HAS_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[MHHIIIPBOPN("Placing a party flag is rate limited. Try again later!", true)]
	WARNING_PARTY_FLAG_RATE_LIMITED,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[MHHIIIPBOPN("Drop Party Flag", true)]
	BUTTON_DROP_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[MHHIIIPBOPN("Party Flag", true)]
	BUTTON_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[MHHIIIPBOPN("Cancel Party Flag", true)]
	BUTTON_CANCEL_PARTY_FLAG
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CJDKIBHCEOG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KJFFKDIOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIJOKDJKFOF(IFIDLCHBKLA GALIOFBFCFL, string LKJBOGFGCOL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DAFDHHHLGIB(Camera HJJMGNJIHHH, Vector3 AKBEFHDLMGE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIFMNLPCAJF(Camera HJJMGNJIHHH, Vector3 AKBEFHDLMGE, CoordinationBeaconBase LKPPMAPFCEC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGMALHHIMHB();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFPAPLOEJKA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ILJGFCNNGJN AGFPJDHAHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EEABKJEDODH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NAFFJOBPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int GBIOJHHKAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OILMEFALPEG(int GCOGPIGGCBB, Vector3 APCECHLOCAE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMLAIDGPLBM();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EPDCOLBAOIO();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OAONPEPFDOG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EBPIDPIHNFN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float OKLLLMIDGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float AEPGDCKHELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MBCKBAGGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HCMFHAFBONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float GCECMOFMADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float CCPDJGDNOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float DPHNJENBOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float HJAPFLNEEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int FMEHKHDBPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float GOFNHPIIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float DOJPFINJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float POMIMPAEJKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BKMINACMHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PDKPKPMINOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MCIHKOBAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KIAODIJOKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LLJABIMICIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float HAEHBFCJONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EADIJGNDHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DELFIAENEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PGPBFFBOHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float AMOPPAFDFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float OBPMCCFPABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float JKOPJLJGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	float NKANMBMNIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float FHCABHIONPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int BOOEKAFAFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	float NLADBIAMFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float NGKKJBKKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	float EMFPLJEFFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float HDIICDFNPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNAJAAFFILC();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NFJABJJFEMG
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	List<OABCOFCFIKD> FECHGGCOFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	List<PENBPAHBIPE> LNLCDFIGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> MJOOFHBMGJE(bool ANAFKDKEFCE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CoordinationPartyBeacon> CJAKGGDGECI();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFLMEBCIPOG(Guid OFNGADCKLGN, PFHAEAFHMPO.OHDHMMNANND NMFNKMDBHNK, JKEIPGGJDEI MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ALHOFKMOCNO(int LDLIMEJDJPJ, [Out] CoordinationBeaconBase JMLBGMCMIGI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> PJIPAJGLCAF();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MCBPHFOCBFA(int LDLIMEJDJPJ, [Out] CoordinationPartyBeacon EIMOJOAMHIK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CAGPALDGHGM(string BNDCCCLGIEP, [Out] CoordinationPartyBeacon DLCEOANDHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JHCGHNLIGPE
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PPDGMHPGOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LBEFLHHFOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHMDDGLLMKC();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HKMLEAAGCAI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFHNLNELCNH(BPLHNECCAPN MKIDPONBDDE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NAMMPHHBJMK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool FBHGHLICCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OOFKNHKKMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFFGJKEFPEF(BDMLCHKFOFH EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OPBPAKMEIJD(BDMLCHKFOFH EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFJHOALGADO(BDMLCHKFOFH EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JAPOOLFAOHF(BDMLCHKFOFH EJJDDFFADPC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BMGMILPGOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EALAMIMBPPI(Guid OFNGADCKLGN, int LDLIMEJDJPJ, Vector3 CMCKFCAAAHD, JKEIPGGJDEI INLEBAAACKH, string ECFKAHKGBEF, Canvas JJFAMNFFGIL);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIIOBCAIJMH(Guid OFNGADCKLGN, PFHAEAFHMPO.OHDHMMNANND NMFNKMDBHNK, JKEIPGGJDEI MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFNCLCOODDG(int LDLIMEJDJPJ, [Out] Guid KBPJBMDPFNI);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IBMLEJGBNDB(Guid OFNGADCKLGN, JKEIPGGJDEI MLCOGCMJLBB, [Out] CoordinationBeaconBase BDLFPPOIAAG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLABDBPEGOG(Vector3 AKBEFHDLMGE, Canvas JJFAMNFFGIL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKGFALFNPPH(CoordinationPartyBeacon ODMPGKEHPIA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IANBDJIIEFB();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FIMCNOEAPPB(Vector3 EJGAHOLJPGJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task NJMIDKNNPJE(Guid OFNGADCKLGN, int LDLIMEJDJPJ, string ECFKAHKGBEF, string BNDCCCLGIEP, Color? JPAJDAKNPCF, [Optional] ECEPGPDPDKI? KLJFMGPFHGL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HOFGONCDMOC();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HHONNDDABJB();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MCBPHFOCBFA(int LDLIMEJDJPJ, [Out] CoordinationPartyBeacon EIMOJOAMHIK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task GGEDGPDDBBK(Guid OFNGADCKLGN, int LDLIMEJDJPJ, string ECFKAHKGBEF, Vector3 CIPFGLLMADH, string BNDCCCLGIEP, Color? JPAJDAKNPCF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BJDOKDNKHJB(string BNDCCCLGIEP, [Out] CoordinationPartyBeacon DLCEOANDHGE);
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

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public AssetReference BeaconPrefabAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference PartyBeaconAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA20D90", Offset = "0xA1F390", VA = "0x180A20D90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AssetReference PartyBeaconBeginPlaceAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AssetReference PartyBeaconDropAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AssetReference PartyBeaconRemovalAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE58D60", Offset = "0xE57360", VA = "0x180E58D60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x10BFC90", Offset = "0x10BE290", VA = "0x1810BFC90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE2B0", VA = "0x1810BFCB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCA0", Offset = "0x10BE2A0", VA = "0x1810BFCA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x219E930", Offset = "0x219CF30", VA = "0x18219E930")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color DefaultPartyBeaconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xBD04F0", Offset = "0xBCEAF0", VA = "0x180BD04F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FD90", Offset = "0x7B6E390", VA = "0x187B6FD90")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AIHFHKAGBIN
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static CoordinationBeaconScriptableConfig MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6E700", Offset = "0x7B6CD00", VA = "0x187B6E700")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PFHAEAFHMPO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum OHDHMMNANND
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		REPLACED,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		CANCELED
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum JGDJNKPNNLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B75020", Offset = "0x7B73620", VA = "0x187B75020")]
	public static void KJDILGMEFML(int BEKCOFDFFEG, string APNPNAIPBDE, Guid OFNGADCKLGN, JKEIPGGJDEI DHEJIPHMHLC, IFIDLCHBKLA NFNAKBAHGMP, int CHDKPPAJMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B74AE0", Offset = "0x7B730E0", VA = "0x187B74AE0")]
	public static void EEHBKHAKIHJ(int BEKCOFDFFEG, string APNPNAIPBDE, Guid OFNGADCKLGN, JKEIPGGJDEI DHEJIPHMHLC, float OCFBJKPECHO, OHDHMMNANND NMFNKMDBHNK, bool FLAAKPHJMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B74EC0", Offset = "0x7B734C0", VA = "0x187B74EC0")]
	public static void IGPOEBOACDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B74F40", Offset = "0x7B73540", VA = "0x187B74F40")]
	public static void IIEJIPGCDPH(JGDJNKPNNLF DCOFOBDOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B74960", Offset = "0x7B72F60", VA = "0x187B74960")]
	private static string ECLJGCGHHBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FIGKIHAEDLC : CJDKIBHCEOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HNMNEHGDJBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FIGKIHAEDLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7B74430", Offset = "0x7B72A30", VA = "0x187B74430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EBPIDPIHNFN LHONADLOJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NFJABJJFEMG KMNLCCGICFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OALKBAEBPMC AAMLFGABKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MCBECFNAPLE LFOCELPFOPD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KJFFKDIOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B743C0", Offset = "0x7B729C0", VA = "0x187B743C0")]
	[AOJMKBDAFKB.IAGHHAMHDJE.CIJKAJPGPIJ]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xEDDB40", Offset = "0xEDC140", VA = "0x180EDDB40")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FIGKIHAEDLC([DJIFKCCBBND(null)][NotNull] EBPIDPIHNFN GGOHPPNJKBO, [DJIFKCCBBND(null)][NotNull] NFJABJJFEMG GLCDBCLKDAD, [DJIFKCCBBND(null)][NotNull] OALKBAEBPMC NGBPIDANFJD, [DJIFKCCBBND(null)][NotNull] MCBECFNAPLE DGHOCCPLOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B73E70", Offset = "0x7B72470", VA = "0x187B73E70", Slot = "5")]
	public void HIJOKDJKFOF(IFIDLCHBKLA GALIOFBFCFL, string LKJBOGFGCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B74080", Offset = "0x7B72680", VA = "0x187B74080", Slot = "7")]
	public bool IIFMNLPCAJF(Camera HJJMGNJIHHH, Vector3 AKBEFHDLMGE, CoordinationBeaconBase LKPPMAPFCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B73C60", Offset = "0x7B72260", VA = "0x187B73C60", Slot = "6")]
	public bool DAFDHHHLGIB(Camera HJJMGNJIHHH, Vector3 AKBEFHDLMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B74310", Offset = "0x7B72910", VA = "0x187B74310", Slot = "8")]
	[AsyncStateMachine(typeof(HNMNEHGDJBN))]
	public void NGMALHHIMHB()
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

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override RectTransform NPCPGPLHGDI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7B70020", Offset = "0x7B6E620", VA = "0x187B70020")]
		public void Initialize(Guid OFNGADCKLGN, int BBMONMEEFNK, JKEIPGGJDEI INLEBAAACKH, string ECFKAHKGBEF, Sprite HIMNHPCOJEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7B70810", Offset = "0x7B6EE10", VA = "0x187B70810")]
		public void SetVisibilityUsernameDepthIgnore(bool BGNGIHPLDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FDD0", Offset = "0x7B6E3D0", VA = "0x187B6FDD0")]
		private void EHAKGAGPGAI(Color GGNIDPPDGCF, bool MBIDBNODMMJ, bool EHJPHPMLDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
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
		private float MFCNIPPNDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool JAKKOEOMAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float EMBCAGGLEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid MLAPBHAJPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int CFIKHLDJDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private JKEIPGGJDEI JILCBMCCCCI;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Guid OJLJBFKDCDP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B454B0", Offset = "0x2B43AB0", VA = "0x182B454B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FOLAPHOHADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA088F0", Offset = "0xA06EF0", VA = "0x180A088F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public JKEIPGGJDEI JGEDCNIFGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
			get
			{
				return default(JKEIPGGJDEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JKEIPGGJDEI NIJHFEOEPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F2F0", Offset = "0x7B6D8F0", VA = "0x187B6F2F0")]
			get
			{
				return default(JKEIPGGJDEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public abstract RectTransform NPCPGPLHGDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, PFHAEAFHMPO.OHDHMMNANND, JKEIPGGJDEI> CPNFFEDJMHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F240", Offset = "0x7B6D840", VA = "0x187B6F240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F300", Offset = "0x7B6D900", VA = "0x187B6F300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F1C0", Offset = "0x7B6D7C0", VA = "0x187B6F1C0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F130", Offset = "0x7B6D730", VA = "0x187B6F130")]
		protected void ANJKPBDKBKO(Guid OFNGADCKLGN, int BBMONMEEFNK, JKEIPGGJDEI INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F190", Offset = "0x7B6D790", VA = "0x187B6F190")]
		public void StartTimer(float IALDFGLLCKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F1A0", Offset = "0x7B6D7A0", VA = "0x187B6F1A0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AF00", Offset = "0x1F89500", VA = "0x181F8AF00", Slot = "6")]
		public virtual void SetVisibility(bool BGNGIHPLDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AEE0", Offset = "0x1F894E0", VA = "0x181F8AEE0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F140", Offset = "0x7B6D740", VA = "0x187B6F140")]
		private void IMOCAENGPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		protected CoordinationBeaconBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBFNCGHNBFC : EBPIDPIHNFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JAHOCBPGMLL AKHJOFAOPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly DBENBDOGMLE JKHAOBGBNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LPGGOLFFKPF GEAOICMLNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? GJLDPIONHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private float? CHGEIDEBHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? OKFJPDODOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? DFNJKJJFPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private float? ELFCCBMFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private float? CGKPGIECOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private float? CIDKGGBPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? HEINAPOOGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int? DLCLBLBIEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private float? IKGJECEEEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private float? ECDPDLIHOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private float? LGCMBDPHMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool? NAEODHMONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool? JGPBBDDFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool? LDLFFNNNIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool? MKHFFOHGONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float? HADJGCKDMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private float? BGJANEDPOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float? KNOFPMMNAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float? FMJPBJHGACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float? CBJBJJHNAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int? NHAHFILLCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private float? FHJNIJKGJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float? HFAGEBLCANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private float? GJDDPEJOEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private float? JFFILBKBBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private bool? JJMMEBBLAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private bool? KMLEOFMOMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool? GHNOHLNBBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private float? BLHKOJCHHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool? CLFMPOICKDN;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float OKLLLMIDGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7B71830", Offset = "0x7B6FE30", VA = "0x187B71830", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float AEPGDCKHELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7B72B10", Offset = "0x7B71110", VA = "0x187B72B10", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MBCKBAGGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7B72520", Offset = "0x7B70B20", VA = "0x187B72520", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool HCMFHAFBONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B71A40", Offset = "0x7B70040", VA = "0x187B71A40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float GCECMOFMADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B727D0", Offset = "0x7B70DD0", VA = "0x187B727D0", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float CCPDJGDNOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B73190", Offset = "0x7B71790", VA = "0x187B73190", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public float DPHNJENBOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B71E90", Offset = "0x7B70490", VA = "0x187B71E90", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public float HJAPFLNEEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B71B20", Offset = "0x7B70120", VA = "0x187B71B20", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int FMEHKHDBPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B737F0", Offset = "0x7B71DF0", VA = "0x187B737F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public float GOFNHPIIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B71C00", Offset = "0x7B70200", VA = "0x187B71C00", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public float DOJPFINJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B72D20", Offset = "0x7B71320", VA = "0x187B72D20", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public float POMIMPAEJKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B72BF0", Offset = "0x7B711F0", VA = "0x187B72BF0", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool BKMINACMHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B728B0", Offset = "0x7B70EB0", VA = "0x187B728B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool PDKPKPMINOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B736C0", Offset = "0x7B71CC0", VA = "0x187B736C0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool MCIHKOBAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B72E70", Offset = "0x7B71470", VA = "0x187B72E70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool DELFIAENEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B715F0", Offset = "0x7B6FBF0", VA = "0x187B715F0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool PGPBFFBOHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B72F50", Offset = "0x7B71550", VA = "0x187B72F50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float AMOPPAFDFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B71F70", Offset = "0x7B70570", VA = "0x187B71F70", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public float OBPMCCFPABI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B71960", Offset = "0x7B6FF60", VA = "0x187B71960", Slot = "28")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float JKOPJLJGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B72990", Offset = "0x7B70F90", VA = "0x187B72990", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float NKANMBMNIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B72360", Offset = "0x7B70960", VA = "0x187B72360", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float FHCABHIONPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B733B0", Offset = "0x7B719B0", VA = "0x187B733B0", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int BOOEKAFAFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B72600", Offset = "0x7B70C00", VA = "0x187B72600", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public float NLADBIAMFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B72440", Offset = "0x7B70A40", VA = "0x187B72440", Slot = "33")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public float NGKKJBKKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B73570", Offset = "0x7B71B70", VA = "0x187B73570", Slot = "34")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float EMFPLJEFFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B726F0", Offset = "0x7B70CF0", VA = "0x187B726F0", Slot = "35")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float HDIICDFNPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B73490", Offset = "0x7B71A90", VA = "0x187B73490", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool EAFEBCFMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B72CD0", Offset = "0x7B712D0", VA = "0x187B72CD0", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool KIAODIJOKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B71910", Offset = "0x7B6FF10", VA = "0x187B71910", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B72050", Offset = "0x7B70650", VA = "0x187B72050", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool LLJABIMICIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B737A0", Offset = "0x7B71DA0", VA = "0x187B737A0", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B73270", Offset = "0x7B71870", VA = "0x187B73270", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public float HAEHBFCJONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B716D0", Offset = "0x7B6FCD0", VA = "0x187B716D0", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool EADIJGNDHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B717E0", Offset = "0x7B6FDE0", VA = "0x187B717E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7B738D0", Offset = "0x7B71ED0", VA = "0x187B738D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EBFNCGHNBFC([DJIFKCCBBND(null)] JAHOCBPGMLL AJHJEIPEGEF, [DJIFKCCBBND(null)] DBENBDOGMLE PPMDDIGBLON, [DJIFKCCBBND(null)] LPGGOLFFKPF FLHGABPGEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7B73650", Offset = "0x7B71C50", VA = "0x187B73650")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B72190", Offset = "0x7B70790", VA = "0x187B72190", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B72A70", Offset = "0x7B71070", VA = "0x187B72A70")]
	private void KJAGNDPLKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B726E0", Offset = "0x7B70CE0", VA = "0x187B726E0")]
	private void MFALNFFKHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B72A70", Offset = "0x7B71070", VA = "0x187B72A70")]
	private void MKNFOFIGHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B72A70", Offset = "0x7B71070", VA = "0x187B72A70")]
	private void KJPFBDMEODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B72E00", Offset = "0x7B71400", VA = "0x187B72E00", Slot = "19")]
	public void JNAJAAFFILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B71CE0", Offset = "0x7B702E0", VA = "0x187B71CE0")]
	private float CFEGGMPMGNH(string HGDIPJKJCIO, float? HOPGKAFMGJB, float JMMNJNFGHEP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B71DB0", Offset = "0x7B703B0", VA = "0x187B71DB0")]
	private bool CFEGGMPMGNH(string HGDIPJKJCIO, bool? HOPGKAFMGJB, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B732D0", Offset = "0x7B718D0", VA = "0x187B732D0")]
	private bool MEFEPEAGDBP(string JHLJNHKIINM, bool? HOPGKAFMGJB, bool JMMNJNFGHEP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B720B0", Offset = "0x7B706B0", VA = "0x187B720B0")]
	private void DGLOIOJMEOM(string JHLJNHKIINM, bool? HOPGKAFMGJB, bool DAIGGDIKJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B72A70", Offset = "0x7B71070", VA = "0x187B72A70")]
	private void IOMPGOMMDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B726E0", Offset = "0x7B70CE0", VA = "0x187B726E0")]
	private void GLNHFACGEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Flags]
public enum JKEIPGGJDEI
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	LOOK_AT_THIS = 1,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	COME_HERE = 2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	WATCH_OUT_RRO_ENEMY = 4,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	WATCH_OUT_PLAYER_ENEMY = 8,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	TAKE_THIS = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	ALLY = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	PARTY = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	CONTEXTUAL_TYPE = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	PARTY_TYPE = 0x40
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class CoordinationBeaconHUDElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private Transform chevronRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private RectTransform rootRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private Image recNetImageRootMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private TextMeshProUGUI distanceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private TextMeshProUGUI usernameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Image iconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Image directionalIcon;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public GameObject PMALBAHFMAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AF00", Offset = "0x1F89500", VA = "0x181F8AF00")]
		public void SetVisibility(bool BGNGIHPLDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F8AEE0", Offset = "0x1F894E0", VA = "0x181F8AEE0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F4D0", Offset = "0x7B6DAD0", VA = "0x187B6F4D0")]
		public void Initialize(int LDLIMEJDJPJ, JKEIPGGJDEI INLEBAAACKH, string ECFKAHKGBEF, Sprite HIMNHPCOJEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FAA0", Offset = "0x7B6E0A0", VA = "0x187B6FAA0")]
		public void UpdateVisualElements(Quaternion BFFCENDGCCC, Vector3 IHMLAPGNLCC, float PHOKMKANBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F3B0", Offset = "0x7B6D9B0", VA = "0x187B6F3B0")]
		private void EHAKGAGPGAI(Color GGNIDPPDGCF, bool MBIDBNODMMJ, bool EHJPHPMLDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class EIIEMIDJLNM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CoordinationBeaconRateLimitingFeedbackVisual <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
			[DebuggerHidden]
			public EIIEMIDJLNM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7B73AF0", Offset = "0x7B720F0", VA = "0x187B73AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B73C10", Offset = "0x7B72210", VA = "0x187B73C10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public float fadeDurationS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Color originalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float MFCNIPPNDCP;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FC60", Offset = "0x7B6E260", VA = "0x187B6FC60")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FD00", Offset = "0x7B6E300", VA = "0x187B6FD00")]
		[IteratorStateMachine(typeof(EIIEMIDJLNM))]
		private IEnumerator IJPANDBLNGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FD80", Offset = "0x7B6E380", VA = "0x187B6FD80")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CNMDOONKFIG : JHCGHNLIGPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly JJOKNLDHNDC EPBLAJDMMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IDisposable CHKBDLJOEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool NLCEDHKLBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool CMDIKKEDIOK;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool PPDGMHPGOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool LBEFLHHFOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xF59450", Offset = "0xF57A50", VA = "0x180F59450", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EFB0", Offset = "0x7B6D5B0", VA = "0x187B6EFB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CNMDOONKFIG([DJIFKCCBBND(null)] JJOKNLDHNDC DGGBKPBNENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7B6ED30", Offset = "0x7B6D330", VA = "0x187B6ED30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EF40", Offset = "0x7B6D540", VA = "0x187B6EF40")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EDF0", Offset = "0x7B6D3F0", VA = "0x187B6EDF0", Slot = "6")]
	public void HHMDDGLLMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EE00", Offset = "0x7B6D400", VA = "0x187B6EE00", Slot = "7")]
	public bool HKMLEAAGCAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EE10", Offset = "0x7B6D410", VA = "0x187B6EE10", Slot = "8")]
	public void JFHNLNELCNH(BPLHNECCAPN MKIDPONBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EE40", Offset = "0x7B6D440", VA = "0x187B6EE40")]
	private LFLPPHCMPGO NDHMFNIHOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B6ED80", Offset = "0x7B6D380", VA = "0x187B6ED80")]
	private void GFMAOOJILII(JOEFAEBJKIB GHLOCFNLAIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BKFFHJAJFPG : NAMMPHHBJMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JJOKNLDHNDC EPBLAJDMMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JDAIBCKBDGJ PAAMGPFMHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JDAIBCKBDGJ HHPFPGOCACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IDisposable CHKBDLJOEDB;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FBHGHLICCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B6E860", Offset = "0x7B6CE60", VA = "0x187B6E860", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool OOFKNHKKMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B6E7B0", Offset = "0x7B6CDB0", VA = "0x187B6E7B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EB40", Offset = "0x7B6D140", VA = "0x187B6EB40")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKFFHJAJFPG([DJIFKCCBBND(null)] JJOKNLDHNDC DGGBKPBNENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E730", Offset = "0x7B6CD30", VA = "0x187B6E730", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E9B0", Offset = "0x7B6CFB0", VA = "0x187B6E9B0")]
	[AOJMKBDAFKB.CMNMOAIAENM.GMCOOAPNBEN]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E780", Offset = "0x7B6CD80", VA = "0x187B6E780", Slot = "5")]
	public void FFFGJKEFPEF(BDMLCHKFOFH EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EA20", Offset = "0x7B6D020", VA = "0x187B6EA20", Slot = "6")]
	public bool OPBPAKMEIJD(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E830", Offset = "0x7B6CE30", VA = "0x187B6E830", Slot = "8")]
	public void JFJHOALGADO(BDMLCHKFOFH EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E800", Offset = "0x7B6CE00", VA = "0x187B6E800", Slot = "9")]
	public bool JAPOOLFAOHF(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E8B0", Offset = "0x7B6CEB0", VA = "0x187B6E8B0")]
	private LFLPPHCMPGO NDHMFNIHOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EA50", Offset = "0x7B6D050", VA = "0x187B6EA50")]
	private void PMFBJKOHKME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IFIDLCHBKLA
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	TEAM,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	ALWAYS
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class CoordinationPartyBeacon : CoordinationBeaconBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private GameObject toggleableButtonCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private GameObject alreadyInPartyCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private GameObject glowDisc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Transform partyUpEffectLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Image flagBaseRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private TextMeshPro titleRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private GCMHMMLIBDC BOGHCBGJHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private DNCKMDLLCNF BPDMOAKHHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private EBPIDPIHNFN LHONADLOJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EFPAPLOEJKA EHJHKCKJPMI;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override RectTransform NPCPGPLHGDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GameObject IBHKNFMDCHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string GLDEPBFAIJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xE6ABC0", Offset = "0xE691C0", VA = "0x180E6ABC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B71000", Offset = "0x7B6F600", VA = "0x187B71000")]
		public void Initialize(Guid OFNGADCKLGN, int BBMONMEEFNK, string ECFKAHKGBEF, string BNDCCCLGIEP, Color? JPAJDAKNPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B70930", Offset = "0x7B6EF30", VA = "0x187B70930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B71450", Offset = "0x7B6FA50", VA = "0x187B71450", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B71270", Offset = "0x7B6F870", VA = "0x187B71270", Slot = "6")]
		public override void SetVisibility(bool BGNGIHPLDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B71220", Offset = "0x7B6F820", VA = "0x187B71220")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B71400", Offset = "0x7B6FA00", VA = "0x187B71400")]
		public void UpdateParty(string MGAMDNBIKKG, Color? MKJDMCGDEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B70BF0", Offset = "0x7B6F1F0", VA = "0x187B70BF0")]
		private bool FPFDFINEIIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B70850", Offset = "0x7B6EE50", VA = "0x187B70850")]
		private bool ABHGCJEHMNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B71170", Offset = "0x7B6F770", VA = "0x187B71170")]
		private bool NCIELKAOJJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B70AF0", Offset = "0x7B6F0F0", VA = "0x187B70AF0")]
		private void EHAKGAGPGAI(Color? EHDJELKNEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B712C0", Offset = "0x7B6F8C0", VA = "0x187B712C0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public CoordinationPartyBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum ILJGFCNNGJN
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	INACTIVE,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	BEING_PLACED,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DROPPED
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PENBPAHBIPE
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public CoordinationBeaconBase CHPMLABOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public PENBPAHBIPE(CoordinationBeaconBase LKPPMAPFCEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OABCOFCFIKD : PENBPAHBIPE
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CoordinationBeaconHUDElement DCOLFGGCDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public OABCOFCFIKD(CoordinationBeaconBase LKPPMAPFCEC, CoordinationBeaconHUDElement MOIMPFLEMCA)
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
