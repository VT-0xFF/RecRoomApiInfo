using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoordinateBeacons.Concretes;
using CoordinateBeacons.Interfaces;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RRUI;
using RRUI.Data;
using RecNet;
using RecRoom;
using RecRoom.Analytics.Statsig;
using RecRoom.Configs;
using RecRoom.Core;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Localization;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.Notifications;
using RecRoom.Persistence;
using RecRoom.Preferences;
using RecRoom.Protobuf;
using TMPro;
using UJect;
using UJect.Injection;
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
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x827CDD0", Offset = "0x827B7D0", VA = "0x18827CDD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746F30", VA = "0x182748530")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace CoordinateBeacons.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[LocalizedKeys("CoordinationBeacons")]
	public enum CoordinationBeaconStrings
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[StringValue("You joined a party!", true)]
		JOINED_PARTY_HEADS_UP_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[StringValue("You joined a team!", true)]
		JOINED_TEAM_HEADS_UP_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[StringValue("Double-tap Screen to place a Beacon.", true)]
		TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[StringValue("Middle-click Mouse to place a Beacon.", true)]
		KBM_CONTROLS_HEADS_UP_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[StringValue("Double-tap Right Shoulder to place a Beacon.", true)]
		GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[StringValue("Point and Tap Main Trigger to place a Beacon.", true)]
		VR_CONTROLS_HEADS_UP_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[StringValue("What's This?", true)]
		BUTTON_ACCESS_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[StringValue("This is a Beacon", true)]
		THIS_IS_BEACON_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[StringValue("Beacons can only be placed by players in a Party or on the same Team.", true)]
		BEACON_RULES_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[StringValue("Try placing a Beacon of your own!", true)]
		TRY_YOURSELF_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[StringValue("Double-tap the Screen", true)]
		TOUCH_CONTROLS_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[StringValue("Middle-click the Mouse", true)]
		KBM_CONTROLS_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[StringValue("Double-tap Right Shoulder", true)]
		GAMEPAD_CONTROLS_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[StringValue("Point and Tap Main Trigger", true)]
		VR_CONTROLS_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[StringValue("once you close the dialogue window.", true)]
		ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[StringValue("Don't show me again", true)]
		DONT_SHOW_AGAIN_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[StringValue("Okay!", true)]
		BUTTON_OKAY_HINT_TUTORIAL,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[StringValue("Another party member already has a party flag!", true)]
		WARNING_OTHER_PARTY_MEMBER_HAS_PARTY_FLAG,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[StringValue("Placing a party flag is rate limited. Try again later!", true)]
		WARNING_PARTY_FLAG_RATE_LIMITED,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[StringValue("Drop Party Flag", true)]
		BUTTON_DROP_PARTY_FLAG,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[StringValue("Party Flag", true)]
		BUTTON_PARTY_FLAG,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[StringValue("Cancel Party Flag", true)]
		BUTTON_CANCEL_PARTY_FLAG
	}
}
namespace CoordinateBeacons.Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface TQYWYLMCAKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool WYICIMWRGQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EXJRMSGNDMG(CoordinationBeaconVisibilityGroup a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XPCHUVYQIWS(Camera a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QVGDHTMDMAI(Camera a, Vector3 b, CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FLZNWPFKBIX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface EXLWZCTPXOH
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		LocalCoordinationPartyBeaconState RNSVAYBOQIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool FNANJQRAEJD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool HQNPPJEZQHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int HPICOHOQPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PGPBLEREJCR(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JPJGYRXZHQE();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PUGAPOTFHJP();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DUBDLOTUNFS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface GFAIMXDRYEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		float OCTPEIFVEXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float TVKPTPACSYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool PGDYVTNCXKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool YJXMHCKYLQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		float HJZHLAJVXNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		float DSZQDBFZCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float JVNCUVYAQHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		float UROZCKODLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int MXHAMGDZEUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		float DQITUGGDILX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float OOZLXKPNDXH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float ESTVRLFLQJU
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool ITUZZMUYHKP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool XLRNAARSGKS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool RYOJEKXAMCB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool RUJDUVUPTZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool SMXWIGMLLSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float ZXGIOVPYGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool VKYNQBFXXVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool YTSXXQWKUEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		float OOVFFSGIKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		float NANIWUAHGWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		float XASVTXLKTHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool VEAEAAQUUJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float BOJWLIKHTUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float FODUASCQLXY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		float HHKKUZYZMEW
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		float JAROPOUKKYG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		float MBDTEJWDBSL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int CMFUYFPYDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float CYGXRQVOMMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		float XIZHJOUENCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		float FSITOGGGTYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		float SJFQPVMBPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void BTLRUQYNVZH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NZBAZFOBPLY
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		List<DCQXPCQSEVB> FTGIAVNLERJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		List<PFTJOXTTLCM> RNFQKVSCDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> VTWJMNBYBRW(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CoordinationPartyBeacon> BSSYDCNIWYR();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DKWNLIYMNKE(Guid a, RZDQVODJOMX.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LNFKWKBHBWP(int a, [Out] CoordinationBeaconBase b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<CoordinationBeaconRateLimitingFeedbackVisual> TYBRVHIUYYL();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool RMYWESGQIBM(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ROFDRSKTBKK(string a, [Out] CoordinationPartyBeacon b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface EJDXMSNPSYF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool TBLVGUTNHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool GWKWVOKBLBX
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EEARSTOTAPL();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EBMOAWCTQAX();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SerializeTo(PersistedRoomData roomData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface OUHPCTMMMDH
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool URCXWUYEGLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool EUPNWGGPDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RMBXFNSNNGB(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RNRCUANTRYG(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EVZPMGBCIME(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GDAYASLEABJ(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QHNNQLJIPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task FBPGTVZEPEN(Guid a, int b, Vector3 c, CoordinationBeaconContext d, string e, Canvas f);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DQRHKXSJULV(Guid a, RZDQVODJOMX.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BUSHKNRMWRF(int a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UPMUBVLBMPQ(Guid a, CoordinationBeaconContext b, [Out] CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CMIXSWUSXCS(Vector3 a, Canvas b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZACIVVTPEIH(CoordinationPartyBeacon a);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QZLCATCFQTB();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task DQVCUSJALWL(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task RUODJLOCXPE(Guid a, int b, string c, string d, Color? e, [Optional] HandType? f);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GAYERUCFRTU();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IAKFUIACALE();

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool RMYWESGQIBM(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task KLPXNAYGLJA(Guid a, int b, string c, Vector3 d, string e, Color? f);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool FDPUHJUWCAD(string a, [Out] CoordinationPartyBeacon b);
	}
}
namespace CoordinateBeacons.Configs
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CoordinationBeaconScriptableConfig : SingletonScriptableObject<CoordinationBeaconScriptableConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Header("Prefabs of Visual Components")]
		[TooltipAttribute("World space beacon")]
		[SerializeField]
		private AssetReference _beaconPrefabAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[TooltipAttribute("HUD beacon shown when world space beacon is not in fov")]
		[SerializeField]
		private AssetReference beaconHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[TooltipAttribute("VR HUD beacon shown when world space beacon is not in fov")]
		[SerializeField]
		private AssetReference beaconVRHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[TooltipAttribute("Rate limiting visual feedback")]
		[SerializeField]
		private AssetReference beaconRateLimitingFeedbackVisualAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[TooltipAttribute("World space party beacon")]
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
		[TooltipAttribute("Audio that plays when the local player drops a beacon")]
		[SerializeField]
		private AssetReference beaconAudioSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[TooltipAttribute("Audio that plays when another player drops a beacon")]
		[SerializeField]
		private AssetReference beaconAudioOthers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[TooltipAttribute("Rolloff for audio that plays when the local player drops a beacon")]
		[SerializeField]
		private AnimationCurve beaconDropAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[TooltipAttribute("Rolloff for audio that plays another player drops a beacon")]
		[SerializeField]
		private AnimationCurve beaconDropFromOthersAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[TooltipAttribute("The maximum distance the other player can be from the local player for the beaconAudioOthers audio clip to play. This should match the cutoff point for beaconDropFromOthersAudioCustomRolloff")]
		[SerializeField]
		private float beaconDropFromOthersAudioMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[TooltipAttribute("Audio that plays when the local player begins placing a party beacon")]
		[SerializeField]
		private AssetReference partyBeaconBeginPlaceAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[TooltipAttribute("Audio that plays when the local player drops a party beacon")]
		[SerializeField]
		private AssetReference partyBeaconDropAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[TooltipAttribute("Audio that plays when a party beacon gets removed")]
		[SerializeField]
		private AssetReference partyBeaconRemovalAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Header("Color Scheme")]
		[TooltipAttribute("Color of visual components when the beacon has the Look At This context (default)")]
		[SerializeField]
		private Color lookAtThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[TooltipAttribute("Color of visual components when the beacon has the Watch Out context")]
		[SerializeField]
		private Color watchOutColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[TooltipAttribute("Color of visual components when the beacon has the Take This context")]
		[SerializeField]
		private Color takeThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[TooltipAttribute("Color of visual components when the beacon has the Come Here context")]
		[SerializeField]
		private Color comeHereColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[TooltipAttribute("Color of visual components when the beacon has the Ally context")]
		[FormerlySerializedAs("fallbackAllyColor")]
		[SerializeField]
		private Color allyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[TooltipAttribute("Color of Party Beacon flag if player is not in a party")]
		[SerializeField]
		private Color defaultPartyBeaconColor;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AssetReference XHGRPCTUHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference WIHNEKVOUIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference TRATXPFJNMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference ASMOVXPBKNU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference RLHSBLOVOYU
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference FCENYMOHPTP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference USKHDXVJEGS
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference BZTLPBWPFNP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference VQJZELWLVUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve VIYLZAINUIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve DAVZOEEAJJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float LEWEDFAOOMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAD17B0", Offset = "0xAD01B0", VA = "0x180AD17B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference TGZERCXFBUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xABA280", Offset = "0xAB8C80", VA = "0x180ABA280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference MLZKADWSSTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference OLSOSBKISHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color ZWMCELEFUPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD3D050", Offset = "0xD3BA50", VA = "0x180D3D050")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color PLYRBPLSMQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1004520", Offset = "0x1002F20", VA = "0x181004520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color HWPKHSSHWHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD66AE0", Offset = "0xD654E0", VA = "0x180D66AE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color FGXFPCARFWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1004530", Offset = "0x1002F30", VA = "0x181004530")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color FULHVEHGGUA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x77941A0", Offset = "0x7792BA0", VA = "0x1877941A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color RGBYTCXSNFV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1EA10D0", Offset = "0x1E9FAD0", VA = "0x181EA10D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8277AB0", Offset = "0x82764B0", VA = "0x188277AB0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class SEVEQWBSSOZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static CoordinationBeaconScriptableConfig GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x827C290", Offset = "0x827AC90", VA = "0x18827C290")]
			get
			{
				return null;
			}
		}
	}
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class RZDQVODJOMX
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum RemovalReason
		{
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			EXPIRED,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			REPLACED,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			CANCELED
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum TutorialType
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			HINT,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			HEADS_UP
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x827BF20", Offset = "0x827A920", VA = "0x18827BF20")]
		public static void ZFBDSUINMRK(int a, string b, Guid c, CoordinationBeaconContext d, CoordinationBeaconVisibilityGroup e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x827BB70", Offset = "0x827A570", VA = "0x18827BB70")]
		public static void ZDVAGDBJZQW(int a, string b, Guid c, CoordinationBeaconContext d, float e, RemovalReason f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x827B890", Offset = "0x827A290", VA = "0x18827B890")]
		public static void LEZIDQXGMZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x827BA90", Offset = "0x827A490", VA = "0x18827BA90")]
		public static void RAKDRSZWJVH(TutorialType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x827B910", Offset = "0x827A310", VA = "0x18827B910")]
		private static string OAKWEUHRDDM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FKUSQEGWEES : TQYWYLMCAKB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <TryShowHintPage>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public FKUSQEGWEES <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x827C2C0", Offset = "0x827ACC0", VA = "0x18827C2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB16840", Offset = "0xB15240", VA = "0x180B16840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly GFAIMXDRYEA FHLTPJBVZZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly NZBAZFOBPLY EHZPIUWQHQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CIVZYHVYQKY OSUDUFMAUQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly IRRUIPlayerShim OFSAHDZSPPA;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool WYICIMWRGQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82799B0", Offset = "0x82783B0", VA = "0x1882799B0")]
		[UKOBXVXKPZF.Room.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE73850", Offset = "0xE72250", VA = "0x180E73850")]
		[RecRoom.NoEngine.Common.Preserve]
		internal FKUSQEGWEES([Inject(null)][NotNull] GFAIMXDRYEA beaconConfigs, [Inject(null)][NotNull] NZBAZFOBPLY beaconPoolService, [Inject(null)][NotNull] CIVZYHVYQKY notificationManager, [Inject(null)][NotNull] IRRUIPlayerShim rruiPlayerShim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8279450", Offset = "0x8277E50", VA = "0x188279450", Slot = "5")]
		public void EXJRMSGNDMG(CoordinationBeaconVisibilityGroup a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8279720", Offset = "0x8278120", VA = "0x188279720", Slot = "7")]
		public bool QVGDHTMDMAI(Camera a, Vector3 b, CoordinationBeaconBase c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8279A20", Offset = "0x8278420", VA = "0x188279A20", Slot = "6")]
		public bool XPCHUVYQIWS(Camera a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8279670", Offset = "0x8278070", VA = "0x188279670", Slot = "8")]
		[AsyncStateMachine(typeof(<TryShowHintPage>d__13))]
		public void FLZNWPFKBIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CoordinationBeacon : CoordinationBeaconBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private RecNetRawImage recNetImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Image recNetImageBaseCircleImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Image recNetImageBaseCircleImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Material depthIgnoreMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private TextMeshPro accountTMPRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private TextMeshPro accountTMPDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Image iconRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Image iconDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Image directionalArrowRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Image directionalArrowDepthIgnore;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override RectTransform PJJGQRUFFYL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8277D40", Offset = "0x8276740", VA = "0x188277D40")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8278530", Offset = "0x8276F30", VA = "0x188278530")]
		public void SetVisibilityUsernameDepthIgnore(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8277AF0", Offset = "0x82764F0", VA = "0x188277AF0")]
		private void AYNJZXDGWOQ(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public CoordinationBeacon()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class CoordinationBeaconBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float OWDQOWXVFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool AAJJOALUBHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float VDGOURUEYGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid PBEBWEBAWYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int SLVCRTWOLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CoordinationBeaconContext KKZVEULAXOP;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid CXQIBDZHUDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xBF6ED0", Offset = "0xBF58D0", VA = "0x180BF6ED0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int DCQWTXUJLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAD45C0", Offset = "0xAD2FC0", VA = "0x180AD45C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CoordinationBeaconContext CZBFJPEOKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CoordinationBeaconContext FOLLTFWJEDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8277030", Offset = "0x8275A30", VA = "0x188277030")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform PJJGQRUFFYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, RZDQVODJOMX.RemovalReason, CoordinationBeaconContext> JTOSQZNUXJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8276F80", Offset = "0x8275980", VA = "0x188276F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8277040", Offset = "0x8275A40", VA = "0x188277040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8276F00", Offset = "0x8275900", VA = "0x188276F00", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8276ED0", Offset = "0x82758D0", VA = "0x188276ED0")]
		protected void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x17BF470", Offset = "0x17BDE70", VA = "0x1817BF470")]
		public void StartTimer(float timerIntervalS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8276EE0", Offset = "0x82758E0", VA = "0x188276EE0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2071090", Offset = "0x206FA90", VA = "0x182071090", Slot = "6")]
		public virtual void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2071070", Offset = "0x206FA70", VA = "0x182071070")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8276E80", Offset = "0x8275880", VA = "0x188276E80")]
		private void ESPDNVRAGSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		protected CoordinationBeaconBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class BLBRRNXBCXZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? OCTPEIFVEXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? TVKPTPACSYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool? PGDYVTNCXKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public bool? YJXMHCKYLQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? HJZHLAJVXNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? DSZQDBFZCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float? JVNCUVYAQHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float? UROZCKODLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int? MXHAMGDZEUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float? DQITUGGDILX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float? OOZLXKPNDXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float? ESTVRLFLQJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool? ITUZZMUYHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public bool? XLRNAARSGKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float? OOVFFSGIKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float? NANIWUAHGWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float? XASVTXLKTHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public bool? VEAEAAQUUJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float? BOJWLIKHTUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public float? FODUASCQLXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float? HHKKUZYZMEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float? JAROPOUKKYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float? MBDTEJWDBSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int? CMFUYFPYDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float? CYGXRQVOMMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float? XIZHJOUENCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float? FSITOGGGTYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float? SJFQPVMBPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public bool? WTZVPHFGZHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float? ZXGIOVPYGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool? VKYNQBFXXVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool? RYOJEKXAMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public bool? RARYTHAUPVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool? SMXWIGMLLSE;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public BLBRRNXBCXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LJFSLEODBED : GFAIMXDRYEA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly VPWSVWWBFFU XTFGFXBOCBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly ILBIZEMNXBW QHSXNRVIOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly XXWNNZHXIHL DBSYSIKSSPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private BLBRRNXBCXZ TLKEHWZAFND;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float OCTPEIFVEXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x827B1F0", Offset = "0x8279BF0", VA = "0x18827B1F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float TVKPTPACSYU
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x827B570", Offset = "0x8279F70", VA = "0x18827B570", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool PGDYVTNCXKN
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x827A4F0", Offset = "0x8278EF0", VA = "0x18827A4F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool YJXMHCKYLQL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x827B500", Offset = "0x8279F00", VA = "0x18827B500", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float HJZHLAJVXNX
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x827B3B0", Offset = "0x8279DB0", VA = "0x18827B3B0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float DSZQDBFZCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x827AA40", Offset = "0x8279440", VA = "0x18827AA40", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float JVNCUVYAQHL
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x827A6A0", Offset = "0x82790A0", VA = "0x18827A6A0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float UROZCKODLCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x827A410", Offset = "0x8278E10", VA = "0x18827A410", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int MXHAMGDZEUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x827AE20", Offset = "0x8279820", VA = "0x18827AE20", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float DQITUGGDILX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x827A960", Offset = "0x8279360", VA = "0x18827A960", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float OOZLXKPNDXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x827A0A0", Offset = "0x8278AA0", VA = "0x18827A0A0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float ESTVRLFLQJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x827B120", Offset = "0x8279B20", VA = "0x18827B120", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool ITUZZMUYHKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x827A760", Offset = "0x8279160", VA = "0x18827A760", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool XLRNAARSGKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x827B5E0", Offset = "0x8279FE0", VA = "0x18827B5E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool RYOJEKXAMCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x827B190", Offset = "0x8279B90", VA = "0x18827B190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool YTSXXQWKUEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x827A840", Offset = "0x8279240", VA = "0x18827A840", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public float OOVFFSGIKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x827B0B0", Offset = "0x8279AB0", VA = "0x18827B0B0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float NANIWUAHGWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x827B2D0", Offset = "0x8279CD0", VA = "0x18827B2D0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float XASVTXLKTHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x827A7D0", Offset = "0x82791D0", VA = "0x18827A7D0", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool VEAEAAQUUJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x827AB20", Offset = "0x8279520", VA = "0x18827AB20", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float BOJWLIKHTUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x827B260", Offset = "0x8279C60", VA = "0x18827B260", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float FODUASCQLXY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x827A030", Offset = "0x8278A30", VA = "0x18827A030", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float HHKKUZYZMEW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x827ACE0", Offset = "0x82796E0", VA = "0x18827ACE0", Slot = "32")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public float JAROPOUKKYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x827AAB0", Offset = "0x82794B0", VA = "0x18827AAB0", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float MBDTEJWDBSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x827AD50", Offset = "0x8279750", VA = "0x18827AD50", Slot = "34")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int CMFUYFPYDHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x827A3A0", Offset = "0x8278DA0", VA = "0x18827A3A0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float CYGXRQVOMMT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x827B420", Offset = "0x8279E20", VA = "0x18827B420", Slot = "36")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float XIZHJOUENCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x827B490", Offset = "0x8279E90", VA = "0x18827B490", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float FSITOGGGTYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x827A110", Offset = "0x8278B10", VA = "0x18827A110", Slot = "38")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float SJFQPVMBPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x827A9D0", Offset = "0x82793D0", VA = "0x18827A9D0", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool WTZVPHFGZHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x827B340", Offset = "0x8279D40", VA = "0x18827B340", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool RUJDUVUPTZP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x827ADC0", Offset = "0x82797C0", VA = "0x18827ADC0", Slot = "42")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x827A630", Offset = "0x8279030", VA = "0x18827A630", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool SMXWIGMLLSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x827AFE0", Offset = "0x82799E0", VA = "0x18827AFE0", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x827A5C0", Offset = "0x8278FC0", VA = "0x18827A5C0", Slot = "22")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public float ZXGIOVPYGJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x827AE90", Offset = "0x8279890", VA = "0x18827AE90", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool VKYNQBFXXVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x827A480", Offset = "0x8278E80", VA = "0x18827A480", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x827B650", Offset = "0x827A050", VA = "0x18827B650")]
		[RecRoom.NoEngine.Common.Preserve]
		public LJFSLEODBED([Inject(null)] VPWSVWWBFFU gameConfigsProvider, [Inject(null)] ILBIZEMNXBW preferencesProvider, [Inject(null)] XXWNNZHXIHL statsigProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x827B040", Offset = "0x8279A40", VA = "0x18827B040")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x827A1F0", Offset = "0x8278BF0", VA = "0x18827A1F0", Slot = "40")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x827A560", Offset = "0x8278F60", VA = "0x18827A560")]
		private void GIYYDEAPEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x827A710", Offset = "0x8279110", VA = "0x18827A710")]
		private void IZTVMRMBMCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x827A560", Offset = "0x8278F60", VA = "0x18827A560")]
		private void ORQRVPXTVSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x827A560", Offset = "0x8278F60", VA = "0x18827A560")]
		private void MIYWOPCYAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x827A180", Offset = "0x8278B80", VA = "0x18827A180", Slot = "19")]
		public void BTLRUQYNVZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3762940", Offset = "0x3761340", VA = "0x183762940")]
		private a JZGHFGHSYXE<a>(string a, a? b, a c) where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x827AB90", Offset = "0x8279590", VA = "0x18827AB90")]
		private bool OLFZULMSXVH(string a, bool? b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x827AF00", Offset = "0x8279900", VA = "0x18827AF00")]
		private void RFLDTWQJRCB(string a, bool? b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x827A560", Offset = "0x8278F60", VA = "0x18827A560")]
		private void WHFJRTYAMYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x827A710", Offset = "0x8279110", VA = "0x18827A710")]
		private void OSDHBZMERPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Flags]
	public enum CoordinationBeaconContext
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
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CoordinationBeaconHUDElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private Transform chevronRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private RectTransform rootRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Image recNetImageRootMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private TextMeshProUGUI distanceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private TextMeshProUGUI usernameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private Image iconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Image directionalIcon;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public GameObject ECKIHAGXEWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2071090", Offset = "0x206FA90", VA = "0x182071090")]
		public void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2071070", Offset = "0x206FA70", VA = "0x182071070")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8277210", Offset = "0x8275C10", VA = "0x188277210")]
		public void Initialize(int ownerRecNetAccountId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x82777E0", Offset = "0x82761E0", VA = "0x1882777E0")]
		public void UpdateVisualElements(Quaternion chevronLocalRotation, Vector3 localPosition, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x82770F0", Offset = "0x8275AF0", VA = "0x1882770F0")]
		private void AYNJZXDGWOQ(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ENTKQHJNKWE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public CoordinationBeaconRateLimitingFeedbackVisual VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public ENTKQHJNKWE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x82792F0", Offset = "0x8277CF0", VA = "0x1882792F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8279410", Offset = "0x8277E10", VA = "0x188279410", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public float fadeDurationS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Color originalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private float OWDQOWXVFXT;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8277990", Offset = "0x8276390", VA = "0x188277990")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8277A30", Offset = "0x8276430", VA = "0x188277A30")]
		[IteratorStateMachine(typeof(ENTKQHJNKWE))]
		private IEnumerator OEYADRBMOQP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8277AA0", Offset = "0x82764A0", VA = "0x188277AA0")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class IGRTEKXYUWS : EJDXMSNPSYF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly MXHAAQVHJOK MCSMFOYERGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly IDisposable HPLLQCHDPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool CQNUFJQFQME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool MEGMEUVWBRC;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool TBLVGUTNHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool GWKWVOKBLBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1318800", Offset = "0x1317200", VA = "0x181318800", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8279EB0", Offset = "0x82788B0", VA = "0x188279EB0")]
		[RecRoom.NoEngine.Common.Preserve]
		public IGRTEKXYUWS([Inject(null)] MXHAAQVHJOK roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8279D30", Offset = "0x8278730", VA = "0x188279D30", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8279E10", Offset = "0x8278810", VA = "0x188279E10")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8279D90", Offset = "0x8278790", VA = "0x188279D90", Slot = "6")]
		public void EEARSTOTAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8279D80", Offset = "0x8278780", VA = "0x188279D80", Slot = "7")]
		public bool EBMOAWCTQAX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8279E80", Offset = "0x8278880", VA = "0x188279E80", Slot = "8")]
		public void SerializeTo(PersistedRoomData roomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8279C30", Offset = "0x8278630", VA = "0x188279C30")]
		private JMBICUHFYPC CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8279DA0", Offset = "0x82787A0", VA = "0x188279DA0")]
		private void EFBLJWVIBUU(KQLCQATBHLS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ZNNFOHPBAXO : OUHPCTMMMDH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly MXHAAQVHJOK MCSMFOYERGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MNMZBJHNWPC AELJXUEDAZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MNMZBJHNWPC ULDXJPGCEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IDisposable HPLLQCHDPIC;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool URCXWUYEGLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x827C990", Offset = "0x827B390", VA = "0x18827C990", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool EUPNWGGPDCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x827CAD0", Offset = "0x827B4D0", VA = "0x18827CAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x827CBF0", Offset = "0x827B5F0", VA = "0x18827CBF0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZNNFOHPBAXO([Inject(null)] MXHAAQVHJOK roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x827C8E0", Offset = "0x827B2E0", VA = "0x18827C8E0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x827CB80", Offset = "0x827B580", VA = "0x18827CB80")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x827CB20", Offset = "0x827B520", VA = "0x18827CB20", Slot = "5")]
		public void RMBXFNSNNGB(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x827CB50", Offset = "0x827B550", VA = "0x18827CB50", Slot = "6")]
		public bool RNRCUANTRYG(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x827C930", Offset = "0x827B330", VA = "0x18827C930", Slot = "8")]
		public void EVZPMGBCIME(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x827C960", Offset = "0x827B360", VA = "0x18827C960", Slot = "9")]
		public bool GDAYASLEABJ(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x827C7E0", Offset = "0x827B1E0", VA = "0x18827C7E0")]
		private JMBICUHFYPC CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x827C9E0", Offset = "0x827B3E0", VA = "0x18827C9E0")]
		private void KRMYNGFIOJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum CoordinationBeaconVisibilityGroup
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
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class CoordinationPartyBeacon : CoordinationBeaconBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private GameObject toggleableButtonCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private GameObject alreadyInPartyCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private GameObject glowDisc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform partyUpEffectLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Image flagBaseRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private TextMeshPro titleRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private XCFBXCJGNRT UPKHCADWUCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private INGMKIEJMOM UOPIYHQCBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private GFAIMXDRYEA FHLTPJBVZZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private EXLWZCTPXOH GIWQYACJNTR;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform PJJGQRUFFYL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject SPAQGIQRHEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string PSHQBXVXEQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xC28940", Offset = "0xC27340", VA = "0x180C28940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x14629A0", Offset = "0x14613A0", VA = "0x1814629A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8278CF0", Offset = "0x82776F0", VA = "0x188278CF0")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, string displayName, string partyId, Color? flagColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8278670", Offset = "0x8277070", VA = "0x188278670")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8279070", Offset = "0x8277A70", VA = "0x188279070", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8278E90", Offset = "0x8277890", VA = "0x188278E90", Slot = "6")]
		public override void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8278E60", Offset = "0x8277860", VA = "0x188278E60")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8279020", Offset = "0x8277A20", VA = "0x188279020")]
		public void UpdateParty(string newPartyId, Color? newPartyColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8278830", Offset = "0x8277230", VA = "0x188278830")]
		private bool BYQMKWQQMZD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8279210", Offset = "0x8277C10", VA = "0x188279210")]
		private bool ZNVQGVOANHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8278C40", Offset = "0x8277640", VA = "0x188278C40")]
		private bool FGURYVOGZGU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8278570", Offset = "0x8276F70", VA = "0x188278570")]
		private void AYNJZXDGWOQ(Color? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8278EE0", Offset = "0x82778E0", VA = "0x188278EE0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public CoordinationPartyBeacon()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum LocalCoordinationPartyBeaconState
	{
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		INACTIVE,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		BEING_PLACED,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		DROPPED
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PFTJOXTTLCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CoordinationBeaconBase TBJUKGEHROP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public PFTJOXTTLCM(CoordinationBeaconBase a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DCQXPCQSEVB : PFTJOXTTLCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public CoordinationBeaconHUDElement OBDJWTXVDFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		public DCQXPCQSEVB(CoordinationBeaconBase a, CoordinationBeaconHUDElement b)
		{
		}
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
