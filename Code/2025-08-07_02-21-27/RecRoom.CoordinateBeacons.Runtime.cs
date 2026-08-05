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
		[Cpp2IlInjected.Address(RVA = "0x892B2F0", Offset = "0x8929EF0", VA = "0x18892B2F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
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
	public interface DIEVMNWTGWL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CIYMAZOJKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YCZIJIYNPUQ(CoordinationBeaconVisibilityGroup a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AUXKZENJOWY(Camera a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool XJMCDECSJOS(Camera a, Vector3 b, CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZMRQNOLBJNL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface NJRHCLDAHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		LocalCoordinationPartyBeaconState ZDBNMNZOKHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool PCWSSCRYOKT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool OPTKCRCZZGR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int QTFDLWXVJFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BEBGLCQHCAD(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CLTVBFRZIDI();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LUELUNLOVWL();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MDDMVLRYRUO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface AEHHMRKDWDA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		float AXLADTFRMRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float FAKYMIPQXHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool BUTQPTMJJGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool RQVIUXLMNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		float QWHTSNQPJJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		float EDLQSAVIVWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float RXBXGBGADVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		float YAJCZCZELWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int PBNBRGJPVQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		float YMWKVFDLDWP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float AGMEXIYSQZF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float QKPAAILMESI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool FLOQSUXLANH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool YFTECVWXHZW
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool WGLWUZMXOIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool DSZHEWAZYHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool OAEERGAQTQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float UKOXSJXZCXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IEQTCYTRAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool AZSDPKVJOTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		float DRSRISVYZZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		float AYJNFJSXFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		float EQWKREBVNXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool KPCYDOTLXHO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float ZEUUSZZPZWS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float VUUWXNWLYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		float JMJBBYRREBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		float ZKFDOEITCJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		float TSJMUUXRALX
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int ISDYBSYTDXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float OFIAFUEZDXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		float PHLBHRGSNGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		float DFWNVONCCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		float EMZYNOKACRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void YTSTPUYWDJF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BIFGUYMODJS
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		List<MCFKFWSGDMV> LEXRIERNCJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		List<TNOSAYAFKOK> QWYWQBPJBAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> SGMRVUBHBVY(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CoordinationPartyBeacon> QWCPQARTJBJ();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CAUWWHOAOVQ(Guid a, FHCNGEXUAGR.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool THJCCTGOUTH(int a, [Out] CoordinationBeaconBase b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<CoordinationBeaconRateLimitingFeedbackVisual> RJYJWWUAMFL();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ROYKGFYRPPG(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool XRONPCXXZQA(string a, [Out] CoordinationPartyBeacon b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface EOJOPKCMNAT
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool OUWOMWGCNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool MRQKZQEXRSH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MFYYOFECXHV();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZJAPTZFFRQJ();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SerializeTo(PersistedRoomData roomData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ZQWEOHVXJHV
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool JHXSVVPMXJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool UDHXTHRWKEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UIKNKSVUNYD(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MHPXXIVFZFC(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZPEYLZWJTCK(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PPEXQPVWDGJ(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface UAZWAXHJULI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task QJPMJCVPKPB(Guid a, int b, Vector3 c, CoordinationBeaconContext d, string e, Canvas f);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NUEBXCZZFJL(Guid a, FHCNGEXUAGR.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MAAQATZNZYN(int a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool YYOLYRAVKTS(Guid a, CoordinationBeaconContext b, [Out] CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ILDFQTPVCKQ(Vector3 a, Canvas b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AKRAWIBVOGJ(CoordinationPartyBeacon a);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DOTVTGQLBCN();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task XQFZEDCXBMF(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task AKDNBYNLBNC(Guid a, int b, string c, string d, Color? e, [Optional] HandType? f);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool XAPHORWZNYQ();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QIIGHRXVJWE();

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ROYKGFYRPPG(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task MOWKCHQCBEE(Guid a, int b, string c, Vector3 d, string e, Color? f);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool WSSPRRZNCRT(string a, [Out] CoordinationPartyBeacon b);
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
		public AssetReference DVYUJZELHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference YGMMEJOCZFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference YHRZKUBLRBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference WDCVBSSXIJW
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference QEDIVVSATFM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference IAIOENSZMKT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference RFJNSMWGGDO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference AYEIAOVCDTF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference JRGAHNIVSJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve BAAFTDIWLOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve WBFXPGHTRZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float IUMKLRRVWDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB2EEA0", Offset = "0xB2DAA0", VA = "0x180B2EEA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference DOATFZMCXHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference SHJUKFKYVKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference BTJKAASCBEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color IDZLHHRDVIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1050F60", Offset = "0x104FB60", VA = "0x181050F60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color KHRFLCIOOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1371C90", Offset = "0x1370890", VA = "0x181371C90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color BCNVNXKMKIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1123F80", Offset = "0x1122B80", VA = "0x181123F80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color GSAMYTMZSMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1371CA0", Offset = "0x13708A0", VA = "0x181371CA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color YFBJVUVNSYW
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8927FA0", Offset = "0x8926BA0", VA = "0x188927FA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color PPLCACYDIXD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2607EC0", Offset = "0x2606AC0", VA = "0x182607EC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8927F60", Offset = "0x8926B60", VA = "0x188927F60")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RKCTIFXNRXN
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static CoordinationBeaconScriptableConfig CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x892A250", Offset = "0x8928E50", VA = "0x18892A250")]
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
	public static class FHCNGEXUAGR
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
		[Cpp2IlInjected.Address(RVA = "0x8929BD0", Offset = "0x89287D0", VA = "0x188929BD0")]
		public static void MMTIUCAOTQS(int a, string b, Guid c, CoordinationBeaconContext d, CoordinationBeaconVisibilityGroup e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89297F0", Offset = "0x89283F0", VA = "0x1889297F0")]
		public static void CHLSCYOAAXK(int a, string b, Guid c, CoordinationBeaconContext d, float e, RemovalReason f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x892A1D0", Offset = "0x8928DD0", VA = "0x18892A1D0")]
		public static void ZBCUYZJPWIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x892A0F0", Offset = "0x8928CF0", VA = "0x18892A0F0")]
		public static void YMDQZBNZATN(TutorialType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8929F70", Offset = "0x8928B70", VA = "0x188929F70")]
		private static string OKTZJANCYYQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CGFKJMSRVHG : DIEVMNWTGWL
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
			public CGFKJMSRVHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x892A280", Offset = "0x8928E80", VA = "0x18892A280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly AEHHMRKDWDA EJJQHDBPWOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly BIFGUYMODJS FGJPKRJTDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly UUHHFVJYLXY YGSIYPTANDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly MZFJCVYVTUW UDIURFRCZJW;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool CIYMAZOJKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8926D60", Offset = "0x8925960", VA = "0x188926D60")]
		[IFIZWETSKCB.Room.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x11F0770", Offset = "0x11EF370", VA = "0x1811F0770")]
		[RecRoom.NoEngine.Common.Preserve]
		internal CGFKJMSRVHG([Inject(null)][NotNull] AEHHMRKDWDA beaconConfigs, [Inject(null)][NotNull] BIFGUYMODJS beaconPoolService, [Inject(null)][NotNull] UUHHFVJYLXY notificationManager, [Inject(null)][NotNull] MZFJCVYVTUW rruiPlayerShim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8927060", Offset = "0x8925C60", VA = "0x188927060", Slot = "5")]
		public void YCZIJIYNPUQ(CoordinationBeaconVisibilityGroup a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8926DD0", Offset = "0x89259D0", VA = "0x188926DD0", Slot = "7")]
		public bool XJMCDECSJOS(Camera a, Vector3 b, CoordinationBeaconBase c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8926B50", Offset = "0x8925750", VA = "0x188926B50", Slot = "6")]
		public bool AUXKZENJOWY(Camera a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8927280", Offset = "0x8925E80", VA = "0x188927280", Slot = "8")]
		[AsyncStateMachine(typeof(<TryShowHintPage>d__13))]
		public void ZMRQNOLBJNL()
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
		public override RectTransform RMYVCMOGHAN
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8928200", Offset = "0x8926E00", VA = "0x188928200")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89289F0", Offset = "0x89275F0", VA = "0x1889289F0")]
		public void SetVisibilityUsernameDepthIgnore(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8927FB0", Offset = "0x8926BB0", VA = "0x188927FB0")]
		private void IYTLBXBFPYO(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
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
		private float ZHGDEZNFQST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool HRAGPQIFSMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float WSXITXOOPRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid RCREIWQDNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int FMUFORJVWVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CoordinationBeaconContext GZPJVTHTNZD;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xF31B00", Offset = "0xF30700", VA = "0x180F31B00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int ENVWGGULSCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB31CB0", Offset = "0xB308B0", VA = "0x180B31CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CoordinationBeaconContext VAVZNXDXCGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D40", Offset = "0xBB2940", VA = "0x180BB3D40")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CoordinationBeaconContext WETHWNGAPUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x89274E0", Offset = "0x89260E0", VA = "0x1889274E0")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform RMYVCMOGHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, FHCNGEXUAGR.RemovalReason, CoordinationBeaconContext> VPKEVHUSJWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8927430", Offset = "0x8926030", VA = "0x188927430")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x89274F0", Offset = "0x89260F0", VA = "0x1889274F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89273B0", Offset = "0x8925FB0", VA = "0x1889273B0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8927380", Offset = "0x8925F80", VA = "0x188927380")]
		protected void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1D6AF00", Offset = "0x1D69B00", VA = "0x181D6AF00")]
		public void StartTimer(float timerIntervalS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8927390", Offset = "0x8925F90", VA = "0x188927390")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2595430", Offset = "0x2594030", VA = "0x182595430", Slot = "6")]
		public virtual void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2595410", Offset = "0x2594010", VA = "0x182595410")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8927330", Offset = "0x8925F30", VA = "0x188927330")]
		private void DVOJYMMHHTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		protected CoordinationBeaconBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class QMJKQGEWRSB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? AXLADTFRMRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? FAKYMIPQXHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool? BUTQPTMJJGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public bool? RQVIUXLMNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? QWHTSNQPJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? EDLQSAVIVWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float? RXBXGBGADVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float? YAJCZCZELWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int? PBNBRGJPVQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float? YMWKVFDLDWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float? AGMEXIYSQZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float? QKPAAILMESI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool? FLOQSUXLANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public bool? YFTECVWXHZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float? DRSRISVYZZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float? AYJNFJSXFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float? EQWKREBVNXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public bool? KPCYDOTLXHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float? ZEUUSZZPZWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public float? VUUWXNWLYCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float? JMJBBYRREBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float? ZKFDOEITCJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float? TSJMUUXRALX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int? ISDYBSYTDXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float? OFIAFUEZDXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float? PHLBHRGSNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float? DFWNVONCCMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float? EMZYNOKACRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public bool? XSMWCPMXEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float? UKOXSJXZCXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool? IEQTCYTRAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool? WGLWUZMXOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public bool? YAJAQUVJPLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool? OAEERGAQTQS;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QMJKQGEWRSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ASQGSFQZWCN : AEHHMRKDWDA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly EDFELDUZHLG XLMRJPQOBRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly PPDHWZWSJQC NDSGUVGHDHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NADKVDSFRLV QBATHOSLVQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private QMJKQGEWRSB TMTUPFVQVBF;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static bool HQWPJFANCPN;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float AXLADTFRMRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8926300", Offset = "0x8924F00", VA = "0x188926300", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float FAKYMIPQXHI
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8925B20", Offset = "0x8924720", VA = "0x188925B20", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool BUTQPTMJJGT
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8925CE0", Offset = "0x89248E0", VA = "0x188925CE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool RQVIUXLMNMN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x89263E0", Offset = "0x8924FE0", VA = "0x1889263E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float QWHTSNQPJJN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8924AF0", Offset = "0x89236F0", VA = "0x188924AF0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float EDLQSAVIVWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8925B90", Offset = "0x8924790", VA = "0x188925B90", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float RXBXGBGADVB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8926030", Offset = "0x8924C30", VA = "0x188926030", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float YAJCZCZELWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8924FB0", Offset = "0x8923BB0", VA = "0x188924FB0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int PBNBRGJPVQG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8925DC0", Offset = "0x89249C0", VA = "0x188925DC0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float YMWKVFDLDWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8926110", Offset = "0x8924D10", VA = "0x188926110", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float AGMEXIYSQZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8926180", Offset = "0x8924D80", VA = "0x188926180", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float QKPAAILMESI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8925FC0", Offset = "0x8924BC0", VA = "0x188925FC0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool FLOQSUXLANH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8925E30", Offset = "0x8924A30", VA = "0x188925E30", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool YFTECVWXHZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8926530", Offset = "0x8925130", VA = "0x188926530", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool WGLWUZMXOIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8925F10", Offset = "0x8924B10", VA = "0x188925F10", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool AZSDPKVJOTK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x89261F0", Offset = "0x8924DF0", VA = "0x1889261F0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public float DRSRISVYZZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8924E70", Offset = "0x8923A70", VA = "0x188924E70", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float AYJNFJSXFFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8925D50", Offset = "0x8924950", VA = "0x188925D50", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float EQWKREBVNXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8926610", Offset = "0x8925210", VA = "0x188926610", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool KPCYDOTLXHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8926830", Offset = "0x8925430", VA = "0x188926830", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float ZEUUSZZPZWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8924D90", Offset = "0x8923990", VA = "0x188924D90", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float VUUWXNWLYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x89268A0", Offset = "0x89254A0", VA = "0x1889268A0", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float JMJBBYRREBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8926450", Offset = "0x8925050", VA = "0x188926450", Slot = "32")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public float ZKFDOEITCJS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8924EE0", Offset = "0x8923AE0", VA = "0x188924EE0", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float TSJMUUXRALX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x89267C0", Offset = "0x89253C0", VA = "0x1889267C0", Slot = "34")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int ISDYBSYTDXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8925AB0", Offset = "0x89246B0", VA = "0x188925AB0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float OFIAFUEZDXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8924B60", Offset = "0x8923760", VA = "0x188924B60", Slot = "36")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float PHLBHRGSNGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8924D20", Offset = "0x8923920", VA = "0x188924D20", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float DFWNVONCCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8925A40", Offset = "0x8924640", VA = "0x188925A40", Slot = "38")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float EMZYNOKACRX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8924E00", Offset = "0x8923A00", VA = "0x188924E00", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool XSMWCPMXEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x89264C0", Offset = "0x89250C0", VA = "0x1889264C0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool DSZHEWAZYHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8926680", Offset = "0x8925280", VA = "0x188926680", Slot = "42")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8926370", Offset = "0x8924F70", VA = "0x188926370", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool OAEERGAQTQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8925020", Offset = "0x8923C20", VA = "0x188925020", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8926750", Offset = "0x8925350", VA = "0x188926750", Slot = "22")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public float UKOXSJXZCXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x89265A0", Offset = "0x89251A0", VA = "0x1889265A0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IEQTCYTRAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8925EA0", Offset = "0x8924AA0", VA = "0x188925EA0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8926910", Offset = "0x8925510", VA = "0x188926910")]
		[RecRoom.NoEngine.Common.Preserve]
		public ASQGSFQZWCN([Inject(null)] EDFELDUZHLG gameConfigsProvider, [Inject(null)] PPDHWZWSJQC preferencesProvider, [Inject(null)] NADKVDSFRLV statsigProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89260A0", Offset = "0x8924CA0", VA = "0x1889260A0")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8925890", Offset = "0x8924490", VA = "0x188925890", Slot = "40")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8924F50", Offset = "0x8923B50", VA = "0x188924F50")]
		private void TDKQCBADNXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8925F70", Offset = "0x8924B70", VA = "0x188925F70")]
		private void NCCLOGKOKRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8924F50", Offset = "0x8923B50", VA = "0x188924F50")]
		private void RGGNGWXDXNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8924F50", Offset = "0x8923B50", VA = "0x188924F50")]
		private void KRQLDGUNLOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89266E0", Offset = "0x89252E0", VA = "0x1889266E0", Slot = "19")]
		public void YTSTPUYWDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x355CD50", Offset = "0x355B950", VA = "0x18355CD50")]
		private a MTMWZKRUBUE<a>(string a, a? b, a c) where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8924BD0", Offset = "0x89237D0", VA = "0x188924BD0")]
		private bool AMJZFCLXVHB(string a, bool? b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8925C00", Offset = "0x8924800", VA = "0x188925C00")]
		private void HOSFYHHSLJJ(string a, bool? b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8924F50", Offset = "0x8923B50", VA = "0x188924F50")]
		private void BZTFPNPYJKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8925F70", Offset = "0x8924B70", VA = "0x188925F70")]
		private void TPCQIFFAGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8925650", Offset = "0x8924250", VA = "0x188925650")]
		[DebugConsoleCommand("ClearBeaconTutorialVars", "Clears beacon tutorial pref keys for both the hint and head's up as well as its cached value counterparts.", new KeyCode[] { })]
		public static void DebugClearBeaconTutorialVars()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x89257F0", Offset = "0x89243F0", VA = "0x1889257F0")]
		[DebugConsoleCommand("EZHintBeaconTutorialTest", "Allows for the beacon hint tutorial prompt without checking if the local player has dropped a beacon.", new KeyCode[] { })]
		public static string DebugEZHintBeaconTutorialTest(bool value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8925080", Offset = "0x8923C80", VA = "0x188925080")]
		[DebugConsoleCommand("BeaconTutorialStatus", "Displays a status message of the current beacon tutorial state.", new KeyCode[] { })]
		public static string DebugBeaconTutorialStatus()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Flags]
	public enum CoordinationBeaconContext
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		LOOK_AT_THIS = 1,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		COME_HERE = 2,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		WATCH_OUT_RRO_ENEMY = 4,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		WATCH_OUT_PLAYER_ENEMY = 8,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		TAKE_THIS = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		ALLY = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		PARTY = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		CONTEXTUAL_TYPE = 0x3F,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		PARTY_TYPE = 0x40
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CoordinationBeaconHUDElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private Transform chevronRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private RectTransform rootRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private Image recNetImageRootMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private TextMeshProUGUI distanceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private TextMeshProUGUI usernameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Image iconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private Image directionalIcon;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public GameObject YJRUJGZAHRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2595430", Offset = "0x2594030", VA = "0x182595430")]
		public void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2595410", Offset = "0x2594010", VA = "0x182595410")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x89276C0", Offset = "0x89262C0", VA = "0x1889276C0")]
		public void Initialize(int ownerRecNetAccountId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8927C90", Offset = "0x8926890", VA = "0x188927C90")]
		public void UpdateVisualElements(Quaternion chevronLocalRotation, Vector3 localPosition, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x89275A0", Offset = "0x89261A0", VA = "0x1889275A0")]
		private void IYTLBXBFPYO(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class XBZJVPLWBOS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private object DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public CoordinationBeaconRateLimitingFeedbackVisual VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			private object ZSSKJTBBAKS
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public XBZJVPLWBOS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x892AD90", Offset = "0x8929990", VA = "0x18892AD90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x892AEB0", Offset = "0x8929AB0", VA = "0x18892AEB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public float fadeDurationS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Color originalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private float ZHGDEZNFQST;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8927E40", Offset = "0x8926A40", VA = "0x188927E40")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8927EE0", Offset = "0x8926AE0", VA = "0x188927EE0")]
		[IteratorStateMachine(typeof(XBZJVPLWBOS))]
		private IEnumerator VMPTUUAEDKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8927F50", Offset = "0x8926B50", VA = "0x188927F50")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class XKUIPWTHIZC : EOJOPKCMNAT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly BFGWYOYOWEM CYTZLBEPWOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly IDisposable UGQNOYMHXUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool IEKDTXFVRIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool IOXGHBIUPHA;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool OUWOMWGCNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool MRQKZQEXRSH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1697C10", Offset = "0x1696810", VA = "0x181697C10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x892B170", Offset = "0x8929D70", VA = "0x18892B170")]
		[RecRoom.NoEngine.Common.Preserve]
		public XKUIPWTHIZC([Inject(null)] BFGWYOYOWEM roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x892AFF0", Offset = "0x8929BF0", VA = "0x18892AFF0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x892B0C0", Offset = "0x8929CC0", VA = "0x18892B0C0")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x892B040", Offset = "0x8929C40", VA = "0x18892B040", Slot = "6")]
		public void MFYYOFECXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x892B160", Offset = "0x8929D60", VA = "0x18892B160", Slot = "7")]
		public bool ZJAPTZFFRQJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x892B130", Offset = "0x8929D30", VA = "0x18892B130", Slot = "8")]
		public void SerializeTo(PersistedRoomData roomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x892AEF0", Offset = "0x8929AF0", VA = "0x18892AEF0")]
		private FDPRMABNSIO CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x892B050", Offset = "0x8929C50", VA = "0x18892B050")]
		private void ONXDDYXDEWK(APQTHAEMUEW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class UGZOSEJPQVA : ZQWEOHVXJHV, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly BFGWYOYOWEM CYTZLBEPWOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly OKOYROTTXMC TOXONVJGYCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly OKOYROTTXMC BFJQMXALHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly IDisposable UGQNOYMHXUI;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool JHXSVVPMXJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x892A8A0", Offset = "0x89294A0", VA = "0x18892A8A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool UDHXTHRWKEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x892A940", Offset = "0x8929540", VA = "0x18892A940", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x892ABB0", Offset = "0x89297B0", VA = "0x18892ABB0")]
		[RecRoom.NoEngine.Common.Preserve]
		public UGZOSEJPQVA([Inject(null)] BFGWYOYOWEM roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x892A8F0", Offset = "0x89294F0", VA = "0x18892A8F0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x892A9F0", Offset = "0x89295F0", VA = "0x18892A9F0")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x892AA60", Offset = "0x8929660", VA = "0x18892AA60", Slot = "5")]
		public void UIKNKSVUNYD(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x892A990", Offset = "0x8929590", VA = "0x18892A990", Slot = "6")]
		public bool MHPXXIVFZFC(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x892AB80", Offset = "0x8929780", VA = "0x18892AB80", Slot = "8")]
		public void ZPEYLZWJTCK(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x892A9C0", Offset = "0x89295C0", VA = "0x18892A9C0", Slot = "9")]
		public bool PPEXQPVWDGJ(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x892A7A0", Offset = "0x89293A0", VA = "0x18892A7A0")]
		private FDPRMABNSIO CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x892AA90", Offset = "0x8929690", VA = "0x18892AA90")]
		private void YSCEXAIKOZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum CoordinationBeaconVisibilityGroup
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		UNKNOWN,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		PARTY,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		TEAM,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		ALWAYS
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class CoordinationPartyBeacon : CoordinationBeaconBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private GameObject toggleableButtonCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private GameObject alreadyInPartyCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private GameObject glowDisc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform partyUpEffectLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Image flagBaseRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private TextMeshPro titleRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private SQLLGURPDAX PZOCGDCNCSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private XGIVEQTISWK FNSGKYOOENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AEHHMRKDWDA EJJQHDBPWOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private NJRHCLDAHCJ XVMLBPMTNUZ;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform RMYVCMOGHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject ROYHWKMQNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string DLNTUFTPWPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x15B4DF0", Offset = "0x15B39F0", VA = "0x1815B4DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8928DE0", Offset = "0x89279E0", VA = "0x188928DE0")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, string displayName, string partyId, Color? flagColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8928A30", Offset = "0x8927630", VA = "0x188928A30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8929180", Offset = "0x8927D80", VA = "0x188929180", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8928F90", Offset = "0x8927B90", VA = "0x188928F90", Slot = "6")]
		public override void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8928F50", Offset = "0x8927B50", VA = "0x188928F50")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8929130", Offset = "0x8927D30", VA = "0x188929130")]
		public void UpdateParty(string newPartyId, Color? newPartyColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8929320", Offset = "0x8927F20", VA = "0x188929320")]
		private bool WXPTIBFPPWH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8928C00", Offset = "0x8927800", VA = "0x188928C00")]
		private bool GGIJJGTNCGV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8929740", Offset = "0x8928340", VA = "0x188929740")]
		private bool ZTQTSJUKLZQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8928CE0", Offset = "0x89278E0", VA = "0x188928CE0")]
		private void IYTLBXBFPYO(Color? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8928FE0", Offset = "0x8927BE0", VA = "0x188928FE0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public CoordinationPartyBeacon()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum LocalCoordinationPartyBeaconState
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		INACTIVE,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		BEING_PLACED,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		DROPPED
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TNOSAYAFKOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CoordinationBeaconBase AFPHWUKMJRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public TNOSAYAFKOK(CoordinationBeaconBase a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MCFKFWSGDMV : TNOSAYAFKOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public CoordinationBeaconHUDElement TPCGONTUAXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public MCFKFWSGDMV(CoordinationBeaconBase a, CoordinationBeaconHUDElement b)
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
