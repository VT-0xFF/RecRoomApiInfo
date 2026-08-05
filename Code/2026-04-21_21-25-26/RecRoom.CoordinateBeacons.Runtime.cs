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
		[Cpp2IlInjected.Address(RVA = "0x98E7600", Offset = "0x98E6000", VA = "0x1898E7600", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
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
	public interface LOJQYASGOTF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CLPMNPJMMYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MBXVCOBERIM(CoordinationBeaconVisibilityGroup a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VDHPIBFFKSE(Camera a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZFVEMSSVJFQ(Camera a, Vector3 b, CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZBSHYGILUYV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HRVLGMZNMMF
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		LocalCoordinationPartyBeaconState APTSMGUQXGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool UUCFGGFKDIX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool AYXPKTREMBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int XTOIJETAHUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MDXEPSAYBCP(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VFRSTKSQLGK();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MCBOUMHOXHV();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PEURPPIGRYK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface DZAJQUWWKFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		float QNHBXXCBRIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float CEOZEMPEHGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool AQZVFXDMQIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool QUZKHPEWBXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		float UMRRNTNVUVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		float WFFKWNNATFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float NHQRRRRFGLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		float SGLSNIUZRIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int ZYGOTOWIJKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		float UGZCIYTHJDR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float VKSAQYWHGEL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float BNGNXBVENQE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool SCJRWLKKLRP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool FHHJLHHGVWY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool IPHXFVVXYQX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool DVFPWMXLJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool AGZKGGSZSRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float HYROSIXDDSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool ONFXDEGYIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool AMLLYKRESCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		float JWFWKPFKXQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		float FIFIFZNTTAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		float EMABPVMXZCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool ICFGGCIDQTO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float JEAZIHMXGZU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float NTLPCJVNFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		float QHKZFFOPKYE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		float XQAHSZLLMZG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		float KDYRELFFBIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int FVBMDSLIKZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float NYKUMFYYLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		float VYFGAAFUISZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		float VKGWBWFJGTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		float ZTQDTYGIEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CIWJYVIOTDV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface VRQAXDNMKYE
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		List<ZJSRHHAWIYV> PVDGPSBZVSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		List<RSUDMCGDKGO> IDITEXLKSUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> LWCDFFOAVZE(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CoordinationPartyBeacon> SPESDVXCRQP();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OJHXIXKBQAG(Guid a, CLAPPTEZCZP.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BDAIOMSXQCF(int a, [Out] CoordinationBeaconBase b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<CoordinationBeaconRateLimitingFeedbackVisual> AQXHSWNKTZT();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IPBUKOAUYSQ(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JLAZRULWSWU(string a, [Out] CoordinationPartyBeacon b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface JJZKZVGUSIT
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool CLROBDUUHEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool QVQOAHYJKCX
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NBIIIVZFIBJ();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JLSSVZJXQNP();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SerializeTo(PersistedRoomData roomData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface LWVVUYDVQJB
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool JSJWXAZGDOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool JLLACYWAGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KJSBSAEYENJ(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RQMCLYXMRGU(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MUCCDKDLCZE(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ZNASXHBPNMJ(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface VJNAXUOSUJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task UQSQTCLLWBB(Guid a, int b, Vector3 c, CoordinationBeaconContext d, string e, Canvas f);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KDNWBKKJQVL(Guid a, CLAPPTEZCZP.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BYXQSIDIUGR(int a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BCCOGCOTYEU(Guid a, CoordinationBeaconContext b, [Out] CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DZAXFVLVQCU(Vector3 a, Canvas b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CKOPWOYMUUR(CoordinationPartyBeacon a);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UIRUNQSNQAZ();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task JHZODOBZZPD(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task TQEQILXEBDS(Guid a, int b, string c, string d, Color? e, [Optional] HandType? f);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GUTNTUJVOLK();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YYEWBEJXTNC();

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool IPBUKOAUYSQ(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task GLXZJBQMWWI(Guid a, int b, string c, Vector3 d, string e, Color? f);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool JMOYSQZGJNT(string a, [Out] CoordinationPartyBeacon b);
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
		public AssetReference CKTMZUIIFPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference XGDSEUCYTWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference LGBYSZEYLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference CMWPSEIKRHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference XARZSRLKKNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference CWERKSZPBTB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference VUOAYKQXJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference HMPFHFEWFDR
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference GFKEQNIZSZU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve BIGLREMRCHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve ROYDNFJSSYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float SHPHUPHSNPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD2AF40", Offset = "0xD29940", VA = "0x180D2AF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference MLVKILTKOIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8A0", Offset = "0xD1D2A0", VA = "0x180D1E8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference KKPZYJKMBXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD1E850", Offset = "0xD1D250", VA = "0x180D1E850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference MWKMMIVWCPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD1E900", Offset = "0xD1D300", VA = "0x180D1E900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color BEQQJBZVRFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1016DB0", Offset = "0x10157B0", VA = "0x181016DB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color ZHFLZRFBLNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12EA6F0", Offset = "0x12E90F0", VA = "0x1812EA6F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color QHPHMAPKZFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x10773F0", Offset = "0x1075DF0", VA = "0x1810773F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color MDDCBIWYYOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x12EA700", Offset = "0x12E9100", VA = "0x1812EA700")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color GAPOVLEWICW
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8DC0820", Offset = "0x8DBF220", VA = "0x188DC0820")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color TIGBNAFEXFX
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x21BF140", Offset = "0x21BDB40", VA = "0x1821BF140")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98E2CC0", Offset = "0x98E16C0", VA = "0x1898E2CC0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class PHCXVELLFUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static CoordinationBeaconScriptableConfig GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x98E6560", Offset = "0x98E4F60", VA = "0x1898E6560")]
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
	public static class CLAPPTEZCZP
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
		[Cpp2IlInjected.Address(RVA = "0x98E1CA0", Offset = "0x98E06A0", VA = "0x1898E1CA0")]
		public static void TAPLSQTEINI(int a, string b, Guid c, CoordinationBeaconContext d, CoordinationBeaconVisibilityGroup e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98E18F0", Offset = "0x98E02F0", VA = "0x1898E18F0")]
		public static void RCKSKZPOWWQ(int a, string b, Guid c, CoordinationBeaconContext d, float e, RemovalReason f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x98E2010", Offset = "0x98E0A10", VA = "0x1898E2010")]
		public static void XFNMSPWZWRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x98E1810", Offset = "0x98E0210", VA = "0x1898E1810")]
		public static void LRXYEAPHQGT(TutorialType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x98E1690", Offset = "0x98E0090", VA = "0x1898E1690")]
		private static string CQEZQRSZELG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class NEAOTZXOWYM : LOJQYASGOTF
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
			public NEAOTZXOWYM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x98E70E0", Offset = "0x98E5AE0", VA = "0x1898E70E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD74370", Offset = "0xD72D70", VA = "0x180D74370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly DZAJQUWWKFI LXHAHFYCION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly VRQAXDNMKYE NLJYMQMADDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CZCWLLIVLZI KBHLMLOZSIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly IRRUIPlayerShim SVTSHXVZVSI;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool CLPMNPJMMYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD6EFC0", Offset = "0xD6D9C0", VA = "0x180D6EFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x98E5D80", Offset = "0x98E4780", VA = "0x1898E5D80")]
		[CXDXQIFYXBD.Room.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x112CF00", Offset = "0x112B900", VA = "0x18112CF00")]
		[RecRoom.NoEngine.Common.Preserve]
		internal NEAOTZXOWYM([Inject(null)][NotNull] DZAJQUWWKFI beaconConfigs, [Inject(null)][NotNull] VRQAXDNMKYE beaconPoolService, [Inject(null)][NotNull] CZCWLLIVLZI notificationManager, [Inject(null)][NotNull] IRRUIPlayerShim rruiPlayerShim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98E5DF0", Offset = "0x98E47F0", VA = "0x1898E5DF0", Slot = "5")]
		public void MBXVCOBERIM(CoordinationBeaconVisibilityGroup a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98E62D0", Offset = "0x98E4CD0", VA = "0x1898E62D0", Slot = "7")]
		public bool ZFVEMSSVJFQ(Camera a, Vector3 b, CoordinationBeaconBase c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x98E6010", Offset = "0x98E4A10", VA = "0x1898E6010", Slot = "6")]
		public bool VDHPIBFFKSE(Camera a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98E6220", Offset = "0x98E4C20", VA = "0x1898E6220", Slot = "8")]
		[AsyncStateMachine(typeof(<TryShowHintPage>d__13))]
		public void ZBSHYGILUYV()
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
		public override RectTransform TSSYMPUNXBX
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x98E2D00", Offset = "0x98E1700", VA = "0x1898E2D00")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98E34F0", Offset = "0x98E1EF0", VA = "0x1898E34F0")]
		public void SetVisibilityUsernameDepthIgnore(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98E3530", Offset = "0x98E1F30", VA = "0x1898E3530")]
		private void ZXHLQYKLNRY(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
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
		private float FWJHKXTQWGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool SUGTNVXYQAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float YGKUUFJAXIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid LOUSXGFJLDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int VQUOLOWWIDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CoordinationBeaconContext EHIXTGCCBAJ;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid CRWLHSKOIBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E10", Offset = "0xEF1810", VA = "0x180EF2E10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int IYWDGGXNHNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xD2DD50", Offset = "0xD2C750", VA = "0x180D2DD50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CoordinationBeaconContext PFRIRGORMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD88420", Offset = "0xD86E20", VA = "0x180D88420")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CoordinationBeaconContext EXEIOPEVQUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x98E2240", Offset = "0x98E0C40", VA = "0x1898E2240")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform TSSYMPUNXBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, CLAPPTEZCZP.RemovalReason, CoordinationBeaconContext> DKGGYEATEVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x98E2190", Offset = "0x98E0B90", VA = "0x1898E2190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x98E2250", Offset = "0x98E0C50", VA = "0x1898E2250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x98E20C0", Offset = "0x98E0AC0", VA = "0x1898E20C0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x98E2090", Offset = "0x98E0A90", VA = "0x1898E2090")]
		protected void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1690", Offset = "0x1AB0090", VA = "0x181AB1690")]
		public void StartTimer(float timerIntervalS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x98E20A0", Offset = "0x98E0AA0", VA = "0x1898E20A0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2379660", Offset = "0x2378060", VA = "0x182379660", Slot = "6")]
		public virtual void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2379640", Offset = "0x2378040", VA = "0x182379640")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x98E2140", Offset = "0x98E0B40", VA = "0x1898E2140")]
		private void XNPJPQXROUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		protected CoordinationBeaconBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DXAFZKYVNQR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? QNHBXXCBRIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? CEOZEMPEHGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool? AQZVFXDMQIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public bool? QUZKHPEWBXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? UMRRNTNVUVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? WFFKWNNATFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float? NHQRRRRFGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float? SGLSNIUZRIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int? ZYGOTOWIJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float? UGZCIYTHJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float? VKSAQYWHGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float? BNGNXBVENQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool? SCJRWLKKLRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public bool? FHHJLHHGVWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float? JWFWKPFKXQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float? FIFIFZNTTAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float? EMABPVMXZCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public bool? ICFGGCIDQTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float? JEAZIHMXGZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public float? NTLPCJVNFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float? QHKZFFOPKYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float? XQAHSZLLMZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float? KDYRELFFBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int? FVBMDSLIKZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float? NYKUMFYYLOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float? VYFGAAFUISZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float? VKGWBWFJGTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float? ZTQDTYGIEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public bool? RUHQMBJNGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float? HYROSIXDDSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool? ONFXDEGYIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool? IPHXFVVXYQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public bool? NUVWCOUIMFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool? AGZKGGSZSRY;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public DXAFZKYVNQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FMOWSZYKKQF : DZAJQUWWKFI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly OTIPMTGRWOI KRPTVXKHQYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly UTDSXNMOWWG XGUUPILXZEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly SOLRGSEENKD ISVSOJAYABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private DXAFZKYVNQR TFTNHZIGYVF;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float QNHBXXCBRIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x98E50A0", Offset = "0x98E3AA0", VA = "0x1898E50A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float CEOZEMPEHGW
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x98E52D0", Offset = "0x98E3CD0", VA = "0x1898E52D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool AQZVFXDMQIH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x98E5180", Offset = "0x98E3B80", VA = "0x1898E5180", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool QUZKHPEWBXL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x98E4720", Offset = "0x98E3120", VA = "0x1898E4720", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float UMRRNTNVUVN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x98E56A0", Offset = "0x98E40A0", VA = "0x1898E56A0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float WFFKWNNATFH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x98E4790", Offset = "0x98E3190", VA = "0x1898E4790", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NHQRRRRFGLN
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x98E5AD0", Offset = "0x98E44D0", VA = "0x1898E5AD0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float SGLSNIUZRIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x98E4C50", Offset = "0x98E3650", VA = "0x1898E4C50", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int ZYGOTOWIJKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x98E4E70", Offset = "0x98E3870", VA = "0x1898E4E70", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float UGZCIYTHJDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x98E4D30", Offset = "0x98E3730", VA = "0x1898E4D30", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float VKSAQYWHGEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x98E55D0", Offset = "0x98E3FD0", VA = "0x1898E55D0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float BNGNXBVENQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x98E54F0", Offset = "0x98E3EF0", VA = "0x1898E54F0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool SCJRWLKKLRP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x98E5910", Offset = "0x98E4310", VA = "0x1898E5910", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool FHHJLHHGVWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x98E51F0", Offset = "0x98E3BF0", VA = "0x1898E51F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IPHXFVVXYQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x98E5640", Offset = "0x98E4040", VA = "0x1898E5640", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool AMLLYKRESCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x98E5780", Offset = "0x98E4180", VA = "0x1898E5780", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public float JWFWKPFKXQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x98E4EE0", Offset = "0x98E38E0", VA = "0x1898E4EE0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float FIFIFZNTTAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x98E4580", Offset = "0x98E2F80", VA = "0x1898E4580", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float EMABPVMXZCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x98E5110", Offset = "0x98E3B10", VA = "0x1898E5110", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool ICFGGCIDQTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x98E4800", Offset = "0x98E3200", VA = "0x1898E4800", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float JEAZIHMXGZU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x98E4B70", Offset = "0x98E3570", VA = "0x1898E4B70", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float NTLPCJVNFAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x98E45F0", Offset = "0x98E2FF0", VA = "0x1898E45F0", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float QHKZFFOPKYE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x98E4A90", Offset = "0x98E3490", VA = "0x1898E4A90", Slot = "32")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public float XQAHSZLLMZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x98E4BE0", Offset = "0x98E35E0", VA = "0x1898E4BE0", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float KDYRELFFBIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x98E4CC0", Offset = "0x98E36C0", VA = "0x1898E4CC0", Slot = "34")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int FVBMDSLIKZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x98E4B00", Offset = "0x98E3500", VA = "0x1898E4B00", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float NYKUMFYYLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x98E59F0", Offset = "0x98E43F0", VA = "0x1898E59F0", Slot = "36")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float VYFGAAFUISZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x98E5A60", Offset = "0x98E4460", VA = "0x1898E5A60", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float VKGWBWFJGTX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x98E58A0", Offset = "0x98E42A0", VA = "0x1898E58A0", Slot = "38")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float ZTQDTYGIEMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x98E5980", Offset = "0x98E4380", VA = "0x1898E5980", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool RUHQMBJNGNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x98E5560", Offset = "0x98E3F60", VA = "0x1898E5560", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool DVFPWMXLJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x98E4E10", Offset = "0x98E3810", VA = "0x1898E4E10", Slot = "42")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x98E5710", Offset = "0x98E4110", VA = "0x1898E5710", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool AGZKGGSZSRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x98E4520", Offset = "0x98E2F20", VA = "0x1898E4520", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x98E4DA0", Offset = "0x98E37A0", VA = "0x1898E4DA0", Slot = "22")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public float HYROSIXDDSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x98E5340", Offset = "0x98E3D40", VA = "0x1898E5340", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool ONFXDEGYIFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x98E5260", Offset = "0x98E3C60", VA = "0x1898E5260", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x98E5B40", Offset = "0x98E4540", VA = "0x1898E5B40")]
		[RecRoom.NoEngine.Common.Preserve]
		public FMOWSZYKKQF([Inject(null)] OTIPMTGRWOI gameConfigsProvider, [Inject(null)] UTDSXNMOWWG preferencesProvider, [Inject(null)] SOLRGSEENKD statsigProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x98E4A20", Offset = "0x98E3420", VA = "0x1898E4A20")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x98E4870", Offset = "0x98E3270", VA = "0x1898E4870", Slot = "40")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x98E5490", Offset = "0x98E3E90", VA = "0x1898E5490")]
		private void OOVMHVKPGZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x98E4660", Offset = "0x98E3060", VA = "0x1898E4660")]
		private void CBHZTHOUXMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x98E5490", Offset = "0x98E3E90", VA = "0x1898E5490")]
		private void OCXUTFNCUFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x98E5490", Offset = "0x98E3E90", VA = "0x1898E5490")]
		private void YDZQAKZGFNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x98E46B0", Offset = "0x98E30B0", VA = "0x1898E46B0", Slot = "19")]
		public void CIWJYVIOTDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC190", Offset = "0x3AEAB90", VA = "0x183AEC190")]
		private a HQIXWAZHGUU<a>(string a, a? b, a c) where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x98E4F50", Offset = "0x98E3950", VA = "0x1898E4F50")]
		private bool JKWUDXMIPZZ(string a, bool? b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x98E53B0", Offset = "0x98E3DB0", VA = "0x1898E53B0")]
		private void MIXJLDRMQSP(string a, bool? b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x98E5490", Offset = "0x98E3E90", VA = "0x1898E5490")]
		private void XEQTWJZNAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x98E4660", Offset = "0x98E3060", VA = "0x1898E4660")]
		private void MTUAHFJKAGB()
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
		public GameObject IHBQBPQDPZX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2379660", Offset = "0x2378060", VA = "0x182379660")]
		public void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2379640", Offset = "0x2378040", VA = "0x182379640")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x98E2300", Offset = "0x98E0D00", VA = "0x1898E2300")]
		public void Initialize(int ownerRecNetAccountId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x98E28D0", Offset = "0x98E12D0", VA = "0x1898E28D0")]
		public void UpdateVisualElements(Quaternion chevronLocalRotation, Vector3 localPosition, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x98E2A80", Offset = "0x98E1480", VA = "0x1898E2A80")]
		private void ZXHLQYKLNRY(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PUHNOAMSQWS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public CoordinationBeaconRateLimitingFeedbackVisual XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			private object QSADFOSKZQW
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public PUHNOAMSQWS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x98E6590", Offset = "0x98E4F90", VA = "0x1898E6590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x98E66B0", Offset = "0x98E50B0", VA = "0x1898E66B0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
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
		private float FWJHKXTQWGP;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x98E2BA0", Offset = "0x98E15A0", VA = "0x1898E2BA0")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x98E2C40", Offset = "0x98E1640", VA = "0x1898E2C40")]
		[IteratorStateMachine(typeof(PUHNOAMSQWS))]
		private IEnumerator WTKXVNFDCQB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x98E2CB0", Offset = "0x98E16B0", VA = "0x1898E2CB0")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class QXRKTUOOEWE : JJZKZVGUSIT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly UHLWHYEMXQU ZJJXXVVPZSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly IDisposable AMARSCJFUKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool RLZBQYZKDLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool BECNOWNJKAG;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool CLROBDUUHEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool QVQOAHYJKCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1620000", Offset = "0x161EA00", VA = "0x181620000", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x98E6970", Offset = "0x98E5370", VA = "0x1898E6970")]
		[RecRoom.NoEngine.Common.Preserve]
		public QXRKTUOOEWE([Inject(null)] UHLWHYEMXQU roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x98E67F0", Offset = "0x98E51F0", VA = "0x1898E67F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x98E6840", Offset = "0x98E5240", VA = "0x1898E6840")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x98E6930", Offset = "0x98E5330", VA = "0x1898E6930", Slot = "6")]
		public void NBIIIVZFIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x98E68B0", Offset = "0x98E52B0", VA = "0x1898E68B0", Slot = "7")]
		public bool JLSSVZJXQNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x98E6940", Offset = "0x98E5340", VA = "0x1898E6940", Slot = "8")]
		public void SerializeTo(PersistedRoomData roomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x98E66F0", Offset = "0x98E50F0", VA = "0x1898E66F0")]
		private NHRYEKMJTSC CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x98E68C0", Offset = "0x98E52C0", VA = "0x1898E68C0")]
		private void JZJBZBANJVE(TDQXTVJIXNU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class RCGQQJPDNTE : LWVVUYDVQJB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly UHLWHYEMXQU ZJJXXVVPZSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly RTAJIPHILMW KNOZHTSZFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly RTAJIPHILMW QOWEHYEWCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IDisposable AMARSCJFUKM;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool JSJWXAZGDOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x98E6D90", Offset = "0x98E5790", VA = "0x1898E6D90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool JLLACYWAGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x98E6CE0", Offset = "0x98E56E0", VA = "0x1898E6CE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x98E6F00", Offset = "0x98E5900", VA = "0x1898E6F00")]
		[RecRoom.NoEngine.Common.Preserve]
		public RCGQQJPDNTE([Inject(null)] UHLWHYEMXQU roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x98E6BF0", Offset = "0x98E55F0", VA = "0x1898E6BF0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x98E6C40", Offset = "0x98E5640", VA = "0x1898E6C40")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x98E6CB0", Offset = "0x98E56B0", VA = "0x1898E6CB0", Slot = "5")]
		public void KJSBSAEYENJ(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x98E6D60", Offset = "0x98E5760", VA = "0x1898E6D60", Slot = "6")]
		public bool RQMCLYXMRGU(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x98E6D30", Offset = "0x98E5730", VA = "0x1898E6D30", Slot = "8")]
		public void MUCCDKDLCZE(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x98E6ED0", Offset = "0x98E58D0", VA = "0x1898E6ED0", Slot = "9")]
		public bool ZNASXHBPNMJ(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x98E6AF0", Offset = "0x98E54F0", VA = "0x1898E6AF0")]
		private NHRYEKMJTSC CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x98E6DE0", Offset = "0x98E57E0", VA = "0x1898E6DE0")]
		private void TMSSKJGXROM()
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
		private WMRBMAENJVZ BYZALMQSKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private KROGZNLLANA GFWEBCUYWNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private DZAJQUWWKFI LXHAHFYCION;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HRVLGMZNMMF ONGMXUHPYTL;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform TSSYMPUNXBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject MZVRXOCCEAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string JWXEKUKWJAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xF1FCA0", Offset = "0xF1E6A0", VA = "0x180F1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x174DFF0", Offset = "0x174C9F0", VA = "0x18174DFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x98E3E10", Offset = "0x98E2810", VA = "0x1898E3E10")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, string displayName, string partyId, Color? flagColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x98E3780", Offset = "0x98E2180", VA = "0x1898E3780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x98E4280", Offset = "0x98E2C80", VA = "0x1898E4280", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x98E40A0", Offset = "0x98E2AA0", VA = "0x1898E40A0", Slot = "6")]
		public override void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x98E4060", Offset = "0x98E2A60", VA = "0x1898E4060")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x98E4230", Offset = "0x98E2C30", VA = "0x1898E4230")]
		public void UpdateParty(string newPartyId, Color? newPartyColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x98E3950", Offset = "0x98E2350", VA = "0x1898E3950")]
		private bool CTTMGWUIKUD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x98E3F80", Offset = "0x98E2980", VA = "0x1898E3F80")]
		private bool QNKPZTEUAIV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x98E3D60", Offset = "0x98E2760", VA = "0x1898E3D60")]
		private bool IZLWFYFKBYO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x98E4420", Offset = "0x98E2E20", VA = "0x1898E4420")]
		private void ZXHLQYKLNRY(Color? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x98E40F0", Offset = "0x98E2AF0", VA = "0x1898E40F0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
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
	public class RSUDMCGDKGO
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CoordinationBeaconBase BFFPMYSNINL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public RSUDMCGDKGO(CoordinationBeaconBase a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ZJSRHHAWIYV : RSUDMCGDKGO
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public CoordinationBeaconHUDElement FPPPGMNFBVA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public ZJSRHHAWIYV(CoordinationBeaconBase a, CoordinationBeaconHUDElement b)
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
