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
		[Cpp2IlInjected.Address(RVA = "0x7A6C9B0", Offset = "0x7A6B1B0", VA = "0x187A6C9B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[NPOJJHJIOOH("CoordinationBeacons")]
public enum FCNKFKNMFGE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[LGLOKBKNADF("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[LGLOKBKNADF("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[LGLOKBKNADF("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[LGLOKBKNADF("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[LGLOKBKNADF("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[LGLOKBKNADF("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[LGLOKBKNADF("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[LGLOKBKNADF("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[LGLOKBKNADF("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[LGLOKBKNADF("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[LGLOKBKNADF("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[LGLOKBKNADF("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[LGLOKBKNADF("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[LGLOKBKNADF("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[LGLOKBKNADF("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[LGLOKBKNADF("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[LGLOKBKNADF("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[LGLOKBKNADF("Another party member already has a party flag!", true)]
	WARNING_OTHER_PARTY_MEMBER_HAS_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[LGLOKBKNADF("Placing a party flag is rate limited. Try again later!", true)]
	WARNING_PARTY_FLAG_RATE_LIMITED,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[LGLOKBKNADF("Drop Party Flag", true)]
	BUTTON_DROP_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[LGLOKBKNADF("Party Flag", true)]
	BUTTON_PARTY_FLAG,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[LGLOKBKNADF("Cancel Party Flag", true)]
	BUTTON_CANCEL_PARTY_FLAG
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LNCEFFAEHAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ONDMHCGNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFKDCBIMHFN(EJCHDFDOAKM NHCGKKPOIFC, string MCAAABKKBIB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHBAEAHCFJC(Camera DJHBAGBEEIN, Vector3 BCEAHLNFANP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CADOHMBOOPN(Camera DJHBAGBEEIN, Vector3 BCEAHLNFANP, CoordinationBeaconBase CHKEOOIOKIP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBCOEFKJHIA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DKGBBMJPAOL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HIBIKABDKAK KJCPJFPNCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DBLJLAPOFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HFGOPEJELIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int GNBPOIKIPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JICNPDGIJHH(int NOHABMGHFKJ, Vector3 NEMJNJCMGJC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJMNLIFGJOO();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NBHCMPOLGPL();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEOEKLDOIPA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LMLAGBACPMD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float IIMLFONNBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float DMDLMOCHGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NLNBLBFCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FHDEKFMGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HLPHCGCDLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float COIBDKHEJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JGPDEIGPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float ACBBABKFMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int PMIKCOFIEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float BFNDHNKJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float FKHBNGLKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float IFDFNOENPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LKHJCDBDNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool EMHIILBFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MMGBHJEDAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EGAOMLHMAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FBFNJGIKGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float DMPCBJLBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KGMCFNJGPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GJKFJKPPCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool APHCCLGMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float BJDFCNPBCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float JINBCJHBONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float IMPJIPBAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	float EEPBOHPOBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float KCCBEGNHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int HKEODJFMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	float BLODIDLBLCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	float LKDBADOBKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	float FMHHOJNALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	float KAHBACCEILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJBFKKGPOMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LFDHOACPILI
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	List<FFLJMPFJICK> MIBBPFEKGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	List<DBODBNHJBOM> JDIDHAHHOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> MDOFAIKCFMM(bool IPDHKEAJFAN);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CoordinationPartyBeacon> DOFFNLNGEII();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNLMMOFICJL(Guid MMIFKMJPJKG, MNJJHJLJLIH.JCNOFAKBGGA AOJDIIDMNOL, IEMNFFDDDBH PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ECJPFPODHFN(int CHKPDAGNJBI, [Out] CoordinationBeaconBase ILGODOACIHG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> BECONCIFDNE();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KAMAKJHHMPK(int CHKPDAGNJBI, [Out] CoordinationPartyBeacon IPOFOAIGPED);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NKCKPOBCCDD(string FOJHMPNBFJA, [Out] CoordinationPartyBeacon NBMIOAPBNDD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KKAJMOJBBFD
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MCOOGPPLDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool JFKCDHKGPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKPEHNKGOEC();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHMMPKPBDHI();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJLBMLBKJKK(IOKANKGCBIH PDNEBCPKAAP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JLCHPEHCBKB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CGJCNILLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BIICEBDKELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBKCIAFOHLF(GKLIALCKGHC JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDNOCDBPEKH(GKLIALCKGHC JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOEDPGGBPCA(GKLIALCKGHC JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JNKAALGGJJN(GKLIALCKGHC JILOCOLKOMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EIIIMFGJEDP
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BKAEOBPKLOE(Guid MMIFKMJPJKG, int CHKPDAGNJBI, Vector3 LHJPIAFPGIH, IEMNFFDDDBH KLNHOILIBHH, string OEGCLIKLIKC, Canvas MEPOACKCMJL);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHOKJCLOKML(Guid MMIFKMJPJKG, MNJJHJLJLIH.JCNOFAKBGGA AOJDIIDMNOL, IEMNFFDDDBH PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IKHDLKAFLEB(int CHKPDAGNJBI, [Out] Guid MHPIAJBGBEA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBCDNOOEOCB(Guid MMIFKMJPJKG, IEMNFFDDDBH PIJHKCJDAHO, [Out] CoordinationBeaconBase JBFGCFFNCMI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDPNLBDOBIB(Vector3 BCEAHLNFANP, Canvas MEPOACKCMJL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHFNDBMIJJH(CoordinationPartyBeacon LNBEIEEMHCD);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMDKBEODEBH();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NIILMJBNPPO(Vector3 LADJDLBEEKF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task APCLPJNOIHP(Guid MMIFKMJPJKG, int CHKPDAGNJBI, string OEGCLIKLIKC, string FOJHMPNBFJA, Color? PLGKPAFMCIC, [Optional] ELGEGIFKKGD? BGJHJLOPKIA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FMPADDCEICE();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IODIDGICNLN();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KAMAKJHHMPK(int CHKPDAGNJBI, [Out] CoordinationPartyBeacon IPOFOAIGPED);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task PHDEDALNOME(Guid MMIFKMJPJKG, int CHKPDAGNJBI, string OEGCLIKLIKC, Vector3 DOMHKGNIIBA, string FOJHMPNBFJA, Color? PLGKPAFMCIC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GECOHHPNIIH(string FOJHMPNBFJA, [Out] CoordinationPartyBeacon NBMIOAPBNDD);
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference PartyBeaconAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA14D70", Offset = "0xA13570", VA = "0x180A14D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AssetReference PartyBeaconBeginPlaceAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AssetReference PartyBeaconDropAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AssetReference PartyBeaconRemovalAudio
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE28F30", Offset = "0xE27730", VA = "0x180E28F30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1093C20", Offset = "0x1092420", VA = "0x181093C20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1093C40", Offset = "0x1092440", VA = "0x181093C40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1093C30", Offset = "0x1092430", VA = "0x181093C30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x215C640", Offset = "0x215AE40", VA = "0x18215C640")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color DefaultPartyBeaconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB7B240", Offset = "0xB79A40", VA = "0x180B7B240")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A66950", Offset = "0x7A65150", VA = "0x187A66950")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KEMPHHAMACJ
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public static CoordinationBeaconScriptableConfig DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AAB0", Offset = "0x7A692B0", VA = "0x187A6AAB0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MNJJHJLJLIH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum JCNOFAKBGGA
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		REPLACED,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		CANCELED
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum MJCMKABGCEK
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BEA0", Offset = "0x7A6A6A0", VA = "0x187A6BEA0")]
	public static void OOAHKGADFEP(int DCILOEIKONN, string NIFHGPJDENK, Guid MMIFKMJPJKG, IEMNFFDDDBH PPOGLMEDEHP, EJCHDFDOAKM JPBODMDKJOP, int EIBHLMNEOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B7E0", Offset = "0x7A69FE0", VA = "0x187A6B7E0")]
	public static void IAKNIPMINGL(int DCILOEIKONN, string NIFHGPJDENK, Guid MMIFKMJPJKG, IEMNFFDDDBH PPOGLMEDEHP, float CCMNBOOODGI, JCNOFAKBGGA AOJDIIDMNOL, bool HBMNMANHEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BD40", Offset = "0x7A6A540", VA = "0x187A6BD40")]
	public static void KKDGIPMEKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BDC0", Offset = "0x7A6A5C0", VA = "0x187A6BDC0")]
	public static void KOCBMMKDGEG(MJCMKABGCEK EAJFDFAEAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BBC0", Offset = "0x7A6A3C0", VA = "0x187A6BBC0")]
	private static string IJDGCNMPFJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LBGOIKAPBLN : LNCEFFAEHAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MHAKNKJFKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LBGOIKAPBLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B2B0", Offset = "0x7A69AB0", VA = "0x187A6B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LMLAGBACPMD DNDLGBJFJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LFDHOACPILI COKLHFKNNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LFKAPAEDBDK KOAKKLDHIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CMNINFPLFCB GIBBHFGJCCK;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ONDMHCGNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7A6AAE0", Offset = "0x7A692E0", VA = "0x187A6AAE0")]
	[PJMOOJOMMCC.JJBJMJNFHOJ.MPEFJKJCLFN]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xEB4DB0", Offset = "0xEB35B0", VA = "0x180EB4DB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LBGOIKAPBLN([LDAFGEHKDJK(null)][NotNull] LMLAGBACPMD APOJCBFFHOF, [LDAFGEHKDJK(null)][NotNull] LFDHOACPILI KHJMNFCHJKG, [LDAFGEHKDJK(null)][NotNull] LFKAPAEDBDK CBJGPIJBJDI, [LDAFGEHKDJK(null)][NotNull] CMNINFPLFCB HMAGHABIDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7A6AB50", Offset = "0x7A69350", VA = "0x187A6AB50", Slot = "5")]
	public void BFKDCBIMHFN(EJCHDFDOAKM NHCGKKPOIFC, string MCAAABKKBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7A6AD60", Offset = "0x7A69560", VA = "0x187A6AD60", Slot = "7")]
	public bool CADOHMBOOPN(Camera DJHBAGBEEIN, Vector3 BCEAHLNFANP, CoordinationBeaconBase CHKEOOIOKIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B0A0", Offset = "0x7A698A0", VA = "0x187A6B0A0", Slot = "6")]
	public bool OHBAEAHCFJC(Camera DJHBAGBEEIN, Vector3 BCEAHLNFANP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A6AFF0", Offset = "0x7A697F0", VA = "0x187A6AFF0", Slot = "8")]
	[AsyncStateMachine(typeof(MHAKNKJFKMH))]
	public void NBCOEFKJHIA()
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
		public override RectTransform PAGKEKDNJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7A66BE0", Offset = "0x7A653E0", VA = "0x187A66BE0")]
		public void Initialize(Guid MMIFKMJPJKG, int OBBGENNEMFP, IEMNFFDDDBH KLNHOILIBHH, string OEGCLIKLIKC, Sprite HGPOPFMAJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7A673D0", Offset = "0x7A65BD0", VA = "0x187A673D0")]
		public void SetVisibilityUsernameDepthIgnore(bool LNLAKBHPGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7A66990", Offset = "0x7A65190", VA = "0x187A66990")]
		private void GNHKIJLCOIB(Color NHBFNLGICBC, bool FCFELGJCKBH, bool EDHFLIFGMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
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
		private float AMOFFAKIJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool HDEFJNNEBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float AONBNOEBDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid EOECEPJOAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int EPPAOPPFNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IEMNFFDDDBH LDHPOGHHJOI;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Guid NGHJMEDCGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2B14550", Offset = "0x2B12D50", VA = "0x182B14550")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int ANNPBLECHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9FCF90", Offset = "0x9FB790", VA = "0x1809FCF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public IEMNFFDDDBH KDJKGIPIFIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
			get
			{
				return default(IEMNFFDDDBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IEMNFFDDDBH CIIKDKAEHGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7A65EB0", Offset = "0x7A646B0", VA = "0x187A65EB0")]
			get
			{
				return default(IEMNFFDDDBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public abstract RectTransform PAGKEKDNJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, MNJJHJLJLIH.JCNOFAKBGGA, IEMNFFDDDBH> MCJINMECFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7A65E00", Offset = "0x7A64600", VA = "0x187A65E00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7A65EC0", Offset = "0x7A646C0", VA = "0x187A65EC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A65D80", Offset = "0x7A64580", VA = "0x187A65D80", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A65D40", Offset = "0x7A64540", VA = "0x187A65D40")]
		protected void NPIOKLMMDIH(Guid MMIFKMJPJKG, int OBBGENNEMFP, IEMNFFDDDBH KLNHOILIBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7A65D50", Offset = "0x7A64550", VA = "0x187A65D50")]
		public void StartTimer(float INGJMOGNMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A65D60", Offset = "0x7A64560", VA = "0x187A65D60")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D240", Offset = "0x1F4BA40", VA = "0x181F4D240", Slot = "6")]
		public virtual void SetVisibility(bool LNLAKBHPGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D220", Offset = "0x1F4BA20", VA = "0x181F4D220")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A65CF0", Offset = "0x7A644F0", VA = "0x187A65CF0")]
		private void HPNABGEAEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		protected CoordinationBeaconBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IEDJPKIFGLC : LMLAGBACPMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AGPOKEKNOGC FGGJONNJIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly EOEGNJFKOMG KLHMKPJHDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MKLIBFLPPKJ DACJOBKJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? PICMDBPFCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private float? JLCPPHHJPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? NLFCOIBJLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? IIBGIEMBJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private float? IGNIALEHOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private float? JDIHGIOJJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private float? DOFANICNEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? ACPOJAFCDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int? JPFPMDHAANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private float? KKOOOFEGNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private float? FOKOMAONKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private float? BJPHPFMNOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool? LPFJKGPHKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool? IBLFCJMPCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool? DBHFJBPOKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool? LFOEIHFKHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float? KGMHEDEHDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private float? AJGLOPJIAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float? FGABBEMAANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float? MFLLKPKJIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float? BHAGBPGBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int? CCHHALHCPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private float? GNLIPLBMBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float? LEDDMPGFHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private float? ECAKCIHOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private float? HMJHKLHCECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private bool? AKBKCBLAOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private bool? GCPFACNIJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool? KDGNPKAKKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private float? PNDDJPCEGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool? EDJJIENIAFO;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float IIMLFONNBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7A69B40", Offset = "0x7A68340", VA = "0x187A69B40", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float DMDLMOCHGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A210", Offset = "0x7A68A10", VA = "0x187A6A210", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NLNBLBFCPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A7B0", Offset = "0x7A68FB0", VA = "0x187A6A7B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool FHDEKFMGAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A130", Offset = "0x7A68930", VA = "0x187A6A130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float HLPHCGCDLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A69C20", Offset = "0x7A68420", VA = "0x187A69C20", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float COIBDKHEJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A69340", Offset = "0x7A67B40", VA = "0x187A69340", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public float JGPDEIGPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A69E80", Offset = "0x7A68680", VA = "0x187A69E80", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public float ACBBABKFMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7A696F0", Offset = "0x7A67EF0", VA = "0x187A696F0", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int PMIKCOFIEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7A69260", Offset = "0x7A67A60", VA = "0x187A69260", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public float BFNDHNKJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7A68E10", Offset = "0x7A67610", VA = "0x187A68E10", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public float FKHBNGLKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7A68A80", Offset = "0x7A67280", VA = "0x187A68A80", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public float IFDFNOENPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A2F0", Offset = "0x7A68AF0", VA = "0x187A6A2F0", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LKHJCDBDNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7A68670", Offset = "0x7A66E70", VA = "0x187A68670", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool EMHIILBFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A4B0", Offset = "0x7A68CB0", VA = "0x187A6A4B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool MMGBHJEDAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A040", Offset = "0x7A68840", VA = "0x187A6A040", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool GJKFJKPPCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A68F40", Offset = "0x7A67740", VA = "0x187A68F40", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool APHCCLGMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A69020", Offset = "0x7A67820", VA = "0x187A69020", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float BJDFCNPBCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A689A0", Offset = "0x7A671A0", VA = "0x187A689A0", Slot = "27")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public float JINBCJHBONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A3D0", Offset = "0x7A68BD0", VA = "0x187A6A3D0", Slot = "28")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public float IMPJIPBAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A69A60", Offset = "0x7A68260", VA = "0x187A69A60", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float EEPBOHPOBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A69980", Offset = "0x7A68180", VA = "0x187A69980", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float KCCBEGNHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A5F0", Offset = "0x7A68DF0", VA = "0x187A6A5F0", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int HKEODJFMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A69D50", Offset = "0x7A68550", VA = "0x187A69D50", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public float BLODIDLBLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A688C0", Offset = "0x7A670C0", VA = "0x187A688C0", Slot = "33")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public float LKDBADOBKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A68D30", Offset = "0x7A67530", VA = "0x187A68D30", Slot = "34")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float FMHHOJNALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A69F60", Offset = "0x7A68760", VA = "0x187A69F60", Slot = "35")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float KAHBACCEILO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7A69610", Offset = "0x7A67E10", VA = "0x187A69610", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool PGNGJOACKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A69E30", Offset = "0x7A68630", VA = "0x187A69E30", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool EGAOMLHMAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A69D00", Offset = "0x7A68500", VA = "0x187A69D00", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A590", Offset = "0x7A68D90", VA = "0x187A6A590", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool FBFNJGIKGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A68EF0", Offset = "0x7A676F0", VA = "0x187A68EF0", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A687F0", Offset = "0x7A66FF0", VA = "0x187A687F0", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public float DMPCBJLBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A69420", Offset = "0x7A67C20", VA = "0x187A69420", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool KGMCFNJGPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A68620", Offset = "0x7A66E20", VA = "0x187A68620", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A890", Offset = "0x7A69090", VA = "0x187A6A890")]
	[RecRoom.NoEngine.Common.Preserve]
	public IEDJPKIFGLC([LDAFGEHKDJK(null)] AGPOKEKNOGC HFMDFHLKMEB, [LDAFGEHKDJK(null)] EOEGNJFKOMG IBDAPGOKMJK, [LDAFGEHKDJK(null)] MKLIBFLPPKJ NLLDOCGGCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A685B0", Offset = "0x7A66DB0", VA = "0x187A685B0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A68B60", Offset = "0x7A67360", VA = "0x187A68B60", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A68750", Offset = "0x7A66F50", VA = "0x187A68750")]
	private void PLLGECAEFFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A120", Offset = "0x7A68920", VA = "0x187A6A120")]
	private void LIECBHLJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A68750", Offset = "0x7A66F50", VA = "0x187A68750")]
	private void PBHGNGKCIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7A68750", Offset = "0x7A66F50", VA = "0x187A68750")]
	private void CFKNFCAOKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A68850", Offset = "0x7A67050", VA = "0x187A68850", Slot = "19")]
	public void CJBFKKGPOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A697D0", Offset = "0x7A67FD0", VA = "0x187A697D0")]
	private float IDNIFHEMCLB(string EHGNBENPEBD, float? GDEOHNFFMMD, float LHCNPHOLELG = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A698A0", Offset = "0x7A680A0", VA = "0x187A698A0")]
	private bool IDNIFHEMCLB(string EHGNBENPEBD, bool? GDEOHNFFMMD, bool LHCNPHOLELG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A69530", Offset = "0x7A67D30", VA = "0x187A69530")]
	private bool HKOHONBHPAM(string OOEEHPIAMNJ, bool? GDEOHNFFMMD, bool LHCNPHOLELG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A6D0", Offset = "0x7A68ED0", VA = "0x187A6A6D0")]
	private void PLBBLLCGFKF(string OOEEHPIAMNJ, bool? GDEOHNFFMMD, bool BOCGDEDFMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A68750", Offset = "0x7A66F50", VA = "0x187A68750")]
	private void LBEGAALKDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A6A120", Offset = "0x7A68920", VA = "0x187A6A120")]
	private void MKNJGIOGPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Flags]
public enum IEMNFFDDDBH
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
		public GameObject AIMOKFMFBPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D240", Offset = "0x1F4BA40", VA = "0x181F4D240")]
		public void SetVisibility(bool LNLAKBHPGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D220", Offset = "0x1F4BA20", VA = "0x181F4D220")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A66090", Offset = "0x7A64890", VA = "0x187A66090")]
		public void Initialize(int CHKPDAGNJBI, IEMNFFDDDBH KLNHOILIBHH, string OEGCLIKLIKC, Sprite HGPOPFMAJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A66660", Offset = "0x7A64E60", VA = "0x187A66660")]
		public void UpdateVisualElements(Quaternion ONOFDHANLPC, Vector3 IKAECBBFJHO, float AKKGPFGELLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A65F70", Offset = "0x7A64770", VA = "0x187A65F70")]
		private void GNHKIJLCOIB(Color NHBFNLGICBC, bool FCFELGJCKBH, bool EDHFLIFGMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class OKIEIFBMLEL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public OKIEIFBMLEL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C240", Offset = "0x7A6AA40", VA = "0x187A6C240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C360", Offset = "0x7A6AB60", VA = "0x187A6C360", Slot = "8")]
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
		private float AMOFFAKIJNN;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A66820", Offset = "0x7A65020", VA = "0x187A66820")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A668C0", Offset = "0x7A650C0", VA = "0x187A668C0")]
		[IteratorStateMachine(typeof(OKIEIFBMLEL))]
		private IEnumerator KADAKJJLGJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A66940", Offset = "0x7A65140", VA = "0x187A66940")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FAGJLJDPJJE : KKAJMOJBBFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly KGOPFPAOFEK LMEEOKLPKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly IDisposable KEOIJAFBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool INIDPEOHNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool BGDGGHIJPKG;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool MCOOGPPLDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool JFKCDHKGPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x129E8E0", Offset = "0x129D0E0", VA = "0x18129E8E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A68430", Offset = "0x7A66C30", VA = "0x187A68430")]
	[RecRoom.NoEngine.Common.Preserve]
	public FAGJLJDPJJE([LDAFGEHKDJK(null)] KGOPFPAOFEK ILOBEJMDKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A68390", Offset = "0x7A66B90", VA = "0x187A68390", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A681B0", Offset = "0x7A669B0", VA = "0x187A681B0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7A683F0", Offset = "0x7A66BF0", VA = "0x187A683F0", Slot = "6")]
	public void JKPEHNKGOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A683E0", Offset = "0x7A66BE0", VA = "0x187A683E0", Slot = "7")]
	public bool GHMMPKPBDHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A68400", Offset = "0x7A66C00", VA = "0x187A68400", Slot = "8")]
	public void NJLBMLBKJKK(IOKANKGCBIH PDNEBCPKAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A68290", Offset = "0x7A66A90", VA = "0x187A68290")]
	private KOLLEJKBENP DGOGHFJKEID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A68220", Offset = "0x7A66A20", VA = "0x187A68220")]
	private void CDCKPKEIDMC(CCOEKIMEHPP EMNLDFCNCBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OODAJIDKBGG : JLCHPEHCBKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly KGOPFPAOFEK LMEEOKLPKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BBLFOPIOEDD MBCJNADDCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly BBLFOPIOEDD GDGGBFCFFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IDisposable KEOIJAFBMLD;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool CGJCNILLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C5C0", Offset = "0x7A6ADC0", VA = "0x187A6C5C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BIICEBDKELM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C570", Offset = "0x7A6AD70", VA = "0x187A6C570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C7C0", Offset = "0x7A6AFC0", VA = "0x187A6C7C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OODAJIDKBGG([LDAFGEHKDJK(null)] KGOPFPAOFEK ILOBEJMDKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C520", Offset = "0x7A6AD20", VA = "0x187A6C520", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C3B0", Offset = "0x7A6ABB0", VA = "0x187A6C3B0")]
	[PJMOOJOMMCC.IIIJEBEMPMI.HIHGDIHOODG]
	internal static void ADFMLLHPKEO(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C790", Offset = "0x7A6AF90", VA = "0x187A6C790", Slot = "5")]
	public void MBKCIAFOHLF(GKLIALCKGHC JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C610", Offset = "0x7A6AE10", VA = "0x187A6C610", Slot = "6")]
	public bool JDNOCDBPEKH(GKLIALCKGHC JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C670", Offset = "0x7A6AE70", VA = "0x187A6C670", Slot = "8")]
	public void JOEDPGGBPCA(GKLIALCKGHC JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C640", Offset = "0x7A6AE40", VA = "0x187A6C640", Slot = "9")]
	public bool JNKAALGGJJN(GKLIALCKGHC JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C420", Offset = "0x7A6AC20", VA = "0x187A6C420")]
	private KOLLEJKBENP DGOGHFJKEID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C6A0", Offset = "0x7A6AEA0", VA = "0x187A6C6A0")]
	private void LLAGKHDPFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum EJCHDFDOAKM
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
		private IJLJEIJLIKD KLMANDCFIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private JMBAALNOBMI CHIBKAOEJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private LMLAGBACPMD DNDLGBJFJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private DKGBBMJPAOL NIKLMKIOILK;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override RectTransform PAGKEKDNJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GameObject NGHIBGEDNPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string IMIAFPGDEHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xE28C10", Offset = "0xE27410", VA = "0x180E28C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A67C70", Offset = "0x7A66470", VA = "0x187A67C70")]
		public void Initialize(Guid MMIFKMJPJKG, int OBBGENNEMFP, string OEGCLIKLIKC, string FOJHMPNBFJA, Color? PLGKPAFMCIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A674C0", Offset = "0x7A65CC0", VA = "0x187A674C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A68010", Offset = "0x7A66810", VA = "0x187A68010", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A67E30", Offset = "0x7A66630", VA = "0x187A67E30", Slot = "6")]
		public override void SetVisibility(bool LNLAKBHPGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A67DE0", Offset = "0x7A665E0", VA = "0x187A67DE0")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7A67FC0", Offset = "0x7A667C0", VA = "0x187A67FC0")]
		public void UpdateParty(string FIBDBABBCHC, Color? KNGOKKPAONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A67860", Offset = "0x7A66060", VA = "0x187A67860")]
		private bool HKOMJIEFEOK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A67680", Offset = "0x7A65E80", VA = "0x187A67680")]
		private bool EMKCMFELLCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A67410", Offset = "0x7A65C10", VA = "0x187A67410")]
		private bool AGJBEECHGKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A67760", Offset = "0x7A65F60", VA = "0x187A67760")]
		private void GNHKIJLCOIB(Color? CJFBLAOPKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A67E80", Offset = "0x7A66680", VA = "0x187A67E80")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public CoordinationPartyBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum HIBIKABDKAK
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	INACTIVE,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	BEING_PLACED,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DROPPED
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DBODBNHJBOM
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public CoordinationBeaconBase IBHEECMGOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public DBODBNHJBOM(CoordinationBeaconBase CHKEOOIOKIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FFLJMPFJICK : DBODBNHJBOM
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CoordinationBeaconHUDElement ADEKHMKJHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public FFLJMPFJICK(CoordinationBeaconBase CHKEOOIOKIP, CoordinationBeaconHUDElement CCEFDCKPHPE)
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
