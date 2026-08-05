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
		[Cpp2IlInjected.Address(RVA = "0x977D9C0", Offset = "0x977C3C0", VA = "0x18977D9C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F6EF0", Offset = "0x29F58F0", VA = "0x1829F6EF0")]
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
	public interface XMUJQPKWQNQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool VXLLTIJIRIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BLJMDEFKXTT(CoordinationBeaconVisibilityGroup a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DOCDGVOZBHL(Camera a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BXWGOYZZHXT(Camera a, Vector3 b, CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CRLBYUNNHSC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface JBWJIVXRATE
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		LocalCoordinationPartyBeaconState DBMHRLLSVIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool EWYJGPMEDMM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool QXYDBUJDAAU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int YFPQLJMVWVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PKLSZVHABGA(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VHFGDKSNQFZ();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IBQAKDTUWXE();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AGFYDMETYEH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface WUGWXWQKRET
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		float UIAWPOJPKXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float IPSDVYAVIZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool PEEOEHSHCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool YUJOHBFFLXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		float BSJXRIPAXVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		float VAEYIZMFHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float JEJTSZRRHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		float NYQRHBEZVPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		int JSWJUCVKMUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		float FNVSMEPWHRG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float QUZDJRSQMFW
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float PLGEIWKAOQH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool BERFYDISSDI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool ERRGNPYZYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool GLNYLRIDGBE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool KNDBLGZHJRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool DUZLMBKPGRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float KSLBEOKQYLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool HBHKGEWOFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool ZZLDAJUTDMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		float VFWMODJVXCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		float KALBAVINLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		float NIKKAFKKZGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool BWVVWYFBQBX
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float BCJKVECYFDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float XIQSDUHNDVD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		float AMMFWVOTIIR
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		float GLIALVBOIOV
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		float RYJRPSENQME
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int AKFPUQCAZUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float OFYUFBZVVHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		float JNQUGVLDCGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		float VOLDZPPTTTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		float GCOREIQDWQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void XFZOMLCGTDM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface RATRHZOQZEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		List<QGRSPOPBOEY> TWJLURRKSUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		List<LWYSOMZZUCP> ZJNDQZGRMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> LLCPRKXAXSP(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CoordinationPartyBeacon> FIBIEAVCZIA();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EWYKOYRAZEV(Guid a, TZUMIBKNFTQ.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LTZQFHHCIQC(int a, [Out] CoordinationBeaconBase b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<CoordinationBeaconRateLimitingFeedbackVisual> FTNJBSZJDWM();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool VVRDGIVNPVV(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OIKDWYKQWRB(string a, [Out] CoordinationPartyBeacon b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface SNNRVAJHWPA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool POHZQMIZGRM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool IFGGLDHLFUA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SGYDITMSRNK();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WBWGDPVZRTO();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SerializeTo(PersistedRoomData roomData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ANBQTIQMEAE
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool WVZWFBYTQTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool TAKUAHEVGTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UOGAZCCDKGC(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HSAWUXMFBFF(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VYIOHGGCMIX(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AUBJSCEGTUS(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface WYVADRTQJNV
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task AUEOHMDHVYO(Guid a, int b, Vector3 c, CoordinationBeaconContext d, string e, Canvas f);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FIXHWITOVLS(Guid a, TZUMIBKNFTQ.RemovalReason b, CoordinationBeaconContext c);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SUCAEKLZTBM(int a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PNGGQQHOWLD(Guid a, CoordinationBeaconContext b, [Out] CoordinationBeaconBase c);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PDGJTMMKCBD(Vector3 a, Canvas b);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XPXFBGHZLKM(CoordinationPartyBeacon a);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QPYYPXQNUWE();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task JLZHLZYXDEW(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task PGXZLIQRGXX(Guid a, int b, string c, string d, Color? e, [Optional] HandType? f);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool CBODSCOIEAV();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NUSNRSELTXR();

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool VVRDGIVNPVV(int a, [Out] CoordinationPartyBeacon b);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task CDLCKOOEYAT(Guid a, int b, string c, Vector3 d, string e, Color? f);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool ZZLVUSJAMNU(string a, [Out] CoordinationPartyBeacon b);
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
		public AssetReference UIATAEJHLHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference XNMXYQIBGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference FYBIZIGZLWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference XWPPQITGCUR
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference QZOSOFXPSBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference ZOPETQGQDXG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference HPCBYEORPUR
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference KAZVMPKTHGA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECB20", VA = "0x180CEE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference ZTTFKCHBBXT
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECB50", VA = "0x180CEE150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve AZGRPDOWVTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECB30", VA = "0x180CEE130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve WHNNQLXGALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED140", VA = "0x180CEE740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float PEISODMOWUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD09F60", Offset = "0xD08960", VA = "0x180D09F60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference HHYBKTOFALY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xCF7720", Offset = "0xCF6120", VA = "0x180CF7720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference NFFXVOSQRNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D90", Offset = "0xCF6790", VA = "0x180CF7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference YIBNYRAECUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xCF7770", Offset = "0xCF6170", VA = "0x180CF7770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color AOMWDOHIVWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x100DF20", Offset = "0x100C920", VA = "0x18100DF20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color ZSJLANYRKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12B8480", Offset = "0x12B6E80", VA = "0x1812B8480")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color WUVZZPZKKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039690", VA = "0x18103AC90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color YPEFYCNYLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x12B8490", Offset = "0x12B6E90", VA = "0x1812B8490")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color JXGIGMIIYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8C581C0", Offset = "0x8C56BC0", VA = "0x188C581C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color TTMMMHJPCRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x218C5F0", Offset = "0x218AFF0", VA = "0x18218C5F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9778690", Offset = "0x9777090", VA = "0x189778690")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class EALGLCHDNBS
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static CoordinationBeaconScriptableConfig UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9779EF0", Offset = "0x97788F0", VA = "0x189779EF0")]
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
	public static class TZUMIBKNFTQ
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
		[Cpp2IlInjected.Address(RVA = "0x977CB90", Offset = "0x977B590", VA = "0x18977CB90")]
		public static void HQHCRWJHFYF(int a, string b, Guid c, CoordinationBeaconContext d, CoordinationBeaconVisibilityGroup e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x977CF80", Offset = "0x977B980", VA = "0x18977CF80")]
		public static void SMHOJMXJHST(int a, string b, Guid c, CoordinationBeaconContext d, float e, RemovalReason f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x977CF00", Offset = "0x977B900", VA = "0x18977CF00")]
		public static void IYVHOZBEYPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x977CAB0", Offset = "0x977B4B0", VA = "0x18977CAB0")]
		public static void DTDQUZCQXXO(TutorialType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x977D330", Offset = "0x977BD30", VA = "0x18977D330")]
		private static string ZAPURUDCNWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RXANHIUDCHV : XMUJQPKWQNQ
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
			public RXANHIUDCHV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x977D4A0", Offset = "0x977BEA0", VA = "0x18977D4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51630", VA = "0x180D52C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly WUGWXWQKRET YGSGRGBUGVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly RATRHZOQZEB OPPYTNYWJYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HZMQRERDGQL RWMOCXNBFUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly IRRUIPlayerShim AUNWRUKKCHR;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool VXLLTIJIRIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C770", VA = "0x180D4DD70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DAD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x977C2F0", Offset = "0x977ACF0", VA = "0x18977C2F0")]
		[GEPWJNEAFDW.Room.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1120590", Offset = "0x111EF90", VA = "0x181120590")]
		[RecRoom.NoEngine.Common.Preserve]
		internal RXANHIUDCHV([Inject(null)][NotNull] WUGWXWQKRET beaconConfigs, [Inject(null)][NotNull] RATRHZOQZEB beaconPoolService, [Inject(null)][NotNull] HZMQRERDGQL notificationManager, [Inject(null)][NotNull] IRRUIPlayerShim rruiPlayerShim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x977BB80", Offset = "0x977A580", VA = "0x18977BB80", Slot = "5")]
		public void BLJMDEFKXTT(CoordinationBeaconVisibilityGroup a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x977BDA0", Offset = "0x977A7A0", VA = "0x18977BDA0", Slot = "7")]
		public bool BXWGOYZZHXT(Camera a, Vector3 b, CoordinationBeaconBase c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x977C0E0", Offset = "0x977AAE0", VA = "0x18977C0E0", Slot = "6")]
		public bool DOCDGVOZBHL(Camera a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x977C030", Offset = "0x977AA30", VA = "0x18977C030", Slot = "8")]
		[AsyncStateMachine(typeof(<TryShowHintPage>d__13))]
		public void CRLBYUNNHSC()
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
		public override RectTransform UFNRHWSYPAS
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECB50", VA = "0x180CEE150", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9778920", Offset = "0x9777320", VA = "0x189778920")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9779110", Offset = "0x9777B10", VA = "0x189779110")]
		public void SetVisibilityUsernameDepthIgnore(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x97786D0", Offset = "0x97770D0", VA = "0x1897786D0")]
		private void IEEQCUQYPXV(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
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
		private float WJTUDVNMHHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool FXVZQYTHNZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private float INHZHRDHZBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid PJJRKHCGOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int USIYFRNRXCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CoordinationBeaconContext PPIGMJOIIRK;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Guid JQCTFOCWOYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xED3CA0", Offset = "0xED26A0", VA = "0x180ED3CA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int URUQWQKSCKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD70", Offset = "0xD0B770", VA = "0x180D0CD70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CoordinationBeaconContext AEOZTIYAYYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD659C0", VA = "0x180D66FC0")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CoordinationBeaconContext GMSMJAAJRJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9777C10", Offset = "0x9776610", VA = "0x189777C10")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RectTransform UFNRHWSYPAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, TZUMIBKNFTQ.RemovalReason, CoordinationBeaconContext> DPICWIXUYMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9777B60", Offset = "0x9776560", VA = "0x189777B60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9777C20", Offset = "0x9776620", VA = "0x189777C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9777AE0", Offset = "0x97764E0", VA = "0x189777AE0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9777AB0", Offset = "0x97764B0", VA = "0x189777AB0")]
		protected void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1A946C0", Offset = "0x1A930C0", VA = "0x181A946C0")]
		public void StartTimer(float timerIntervalS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9777AC0", Offset = "0x97764C0", VA = "0x189777AC0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x233EFA0", Offset = "0x233D9A0", VA = "0x18233EFA0", Slot = "6")]
		public virtual void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x233EF80", Offset = "0x233D980", VA = "0x18233EF80")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9777A60", Offset = "0x9776460", VA = "0x189777A60")]
		private void AZDRJXQJVRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		protected CoordinationBeaconBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UYRZQQJISII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float? UIAWPOJPKXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float? IPSDVYAVIZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool? PEEOEHSHCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public bool? YUJOHBFFLXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float? BSJXRIPAXVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float? VAEYIZMFHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float? JEJTSZRRHTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float? NYQRHBEZVPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int? JSWJUCVKMUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float? FNVSMEPWHRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float? QUZDJRSQMFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float? PLGEIWKAOQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool? BERFYDISSDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public bool? ERRGNPYZYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float? VFWMODJVXCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float? KALBAVINLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float? NIKKAFKKZGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public bool? BWVVWYFBQBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float? BCJKVECYFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public float? XIQSDUHNDVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float? AMMFWVOTIIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float? GLIALVBOIOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float? RYJRPSENQME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int? AKFPUQCAZUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float? OFYUFBZVVHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float? JNQUGVLDCGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float? VOLDZPPTTTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float? GCOREIQDWQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public bool? UUIJLYTLIRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float? KSLBEOKQYLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool? HBHKGEWOFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE2")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool? GLNYLRIDGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public bool? WYOZXZSMSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool? DUZLMBKPGRF;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public UYRZQQJISII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class GHVXFELMLLY : WUGWXWQKRET, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly CQTKPAWHYMF OQHADQKIFSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly LLJFKJJXSMP MIRGJPSENLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly KBMIQUZVWZE KJXPEWUVZTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private UYRZQQJISII VMTJSFQIURQ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float UIAWPOJPKXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x977A8B0", Offset = "0x97792B0", VA = "0x18977A8B0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float IPSDVYAVIZX
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x977ADA0", Offset = "0x97797A0", VA = "0x18977ADA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool PEEOEHSHCOG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x977A770", Offset = "0x9779170", VA = "0x18977A770", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool YUJOHBFFLXY
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x977A400", Offset = "0x9778E00", VA = "0x18977A400", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float BSJXRIPAXVU
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x977AAB0", Offset = "0x97794B0", VA = "0x18977AAB0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float VAEYIZMFHIA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x977A550", Offset = "0x9778F50", VA = "0x18977A550", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float JEJTSZRRHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x977B7F0", Offset = "0x977A1F0", VA = "0x18977B7F0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float NYQRHBEZVPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x977A470", Offset = "0x9778E70", VA = "0x18977A470", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int JSWJUCVKMUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x977B030", Offset = "0x9779A30", VA = "0x18977B030", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float FNVSMEPWHRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x977ACE0", Offset = "0x97796E0", VA = "0x18977ACE0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float QUZDJRSQMFW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x977B3A0", Offset = "0x9779DA0", VA = "0x18977B3A0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float PLGEIWKAOQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x977AE80", Offset = "0x9779880", VA = "0x18977AE80", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool BERFYDISSDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x977B8D0", Offset = "0x977A2D0", VA = "0x18977B8D0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool ERRGNPYZYXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x977AEF0", Offset = "0x97798F0", VA = "0x18977AEF0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool GLNYLRIDGBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x977B260", Offset = "0x9779C60", VA = "0x18977B260", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool ZZLDAJUTDMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x977A920", Offset = "0x9779320", VA = "0x18977A920", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public float VFWMODJVXCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x977A7E0", Offset = "0x97791E0", VA = "0x18977A7E0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float KALBAVINLIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x977AFC0", Offset = "0x97799C0", VA = "0x18977AFC0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float NIKKAFKKZGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x977B410", Offset = "0x9779E10", VA = "0x18977B410", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool BWVVWYFBQBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x977AB90", Offset = "0x9779590", VA = "0x18977AB90", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float BCJKVECYFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x977AB20", Offset = "0x9779520", VA = "0x18977AB20", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float XIQSDUHNDVD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x977A4E0", Offset = "0x9778EE0", VA = "0x18977A4E0", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float AMMFWVOTIIR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x977A320", Offset = "0x9778D20", VA = "0x18977A320", Slot = "32")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public float GLIALVBOIOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x977AC00", Offset = "0x9779600", VA = "0x18977AC00", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float RYJRPSENQME
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x977A390", Offset = "0x9778D90", VA = "0x18977A390", Slot = "34")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int AKFPUQCAZUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x977B4E0", Offset = "0x9779EE0", VA = "0x18977B4E0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float OFYUFBZVVHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x977B860", Offset = "0x977A260", VA = "0x18977B860", Slot = "36")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float JNQUGVLDCGU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x977B2C0", Offset = "0x9779CC0", VA = "0x18977B2C0", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float VOLDZPPTTTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x977AE10", Offset = "0x9779810", VA = "0x18977AE10", Slot = "38")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float GCOREIQDWQI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x977B330", Offset = "0x9779D30", VA = "0x18977B330", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool UUIJLYTLIRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x977B550", Offset = "0x9779F50", VA = "0x18977B550", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool KNDBLGZHJRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x977B480", Offset = "0x9779E80", VA = "0x18977B480", Slot = "42")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x977B0A0", Offset = "0x9779AA0", VA = "0x18977B0A0", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool DUZLMBKPGRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x977A850", Offset = "0x9779250", VA = "0x18977A850", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x977B5C0", Offset = "0x9779FC0", VA = "0x18977B5C0", Slot = "22")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public float KSLBEOKQYLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x977B110", Offset = "0x9779B10", VA = "0x18977B110", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool HBHKGEWOFEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x977AA40", Offset = "0x9779440", VA = "0x18977AA40", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x977B940", Offset = "0x977A340", VA = "0x18977B940")]
		[RecRoom.NoEngine.Common.Preserve]
		public GHVXFELMLLY([Inject(null)] CQTKPAWHYMF gameConfigsProvider, [Inject(null)] LLJFKJJXSMP preferencesProvider, [Inject(null)] KBMIQUZVWZE statsigProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x977AC70", Offset = "0x9779670", VA = "0x18977AC70")]
		[GEPWJNEAFDW.Session.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x977A5C0", Offset = "0x9778FC0", VA = "0x18977A5C0", Slot = "40")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x977AF60", Offset = "0x9779960", VA = "0x18977AF60")]
		private void MIMEDEKJBSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x977AD50", Offset = "0x9779750", VA = "0x18977AD50")]
		private void XRKISDBTAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x977AF60", Offset = "0x9779960", VA = "0x18977AF60")]
		private void VHBUYTWAYYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x977AF60", Offset = "0x9779960", VA = "0x18977AF60")]
		private void PETYOAOAVJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x977B630", Offset = "0x977A030", VA = "0x18977B630", Slot = "19")]
		public void XFZOMLCGTDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4E00", Offset = "0x3AD3800", VA = "0x183AD4E00")]
		private a SOQMVUMBFQX<a>(string a, a? b, a c) where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x977B6A0", Offset = "0x977A0A0", VA = "0x18977B6A0")]
		private bool XHDAIWNAMNE(string a, bool? b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x977B180", Offset = "0x9779B80", VA = "0x18977B180")]
		private void RMQQVEXAFRU(string a, bool? b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x977AF60", Offset = "0x9779960", VA = "0x18977AF60")]
		private void XHLAPYTCSKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x977AD50", Offset = "0x9779750", VA = "0x18977AD50")]
		private void KUUPEUJRSWW()
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
		public GameObject VALDCRWGYBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x233EFA0", Offset = "0x233D9A0", VA = "0x18233EFA0")]
		public void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x233EF80", Offset = "0x233D980", VA = "0x18233EF80")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9777DF0", Offset = "0x97767F0", VA = "0x189777DF0")]
		public void Initialize(int ownerRecNetAccountId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x97783C0", Offset = "0x9776DC0", VA = "0x1897783C0")]
		public void UpdateVisualElements(Quaternion chevronLocalRotation, Vector3 localPosition, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9777CD0", Offset = "0x97766D0", VA = "0x189777CD0")]
		private void IEEQCUQYPXV(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class SNFVRJEFJDD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public CoordinationBeaconRateLimitingFeedbackVisual DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public SNFVRJEFJDD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x977C990", Offset = "0x977B390", VA = "0x18977C990", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x977C950", Offset = "0x977B350", VA = "0x18977C950", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
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
		private float WJTUDVNMHHY;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9778570", Offset = "0x9776F70", VA = "0x189778570")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9778610", Offset = "0x9777010", VA = "0x189778610")]
		[IteratorStateMachine(typeof(SNFVRJEFJDD))]
		private IEnumerator GKRMUORDSEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9778680", Offset = "0x9777080", VA = "0x189778680")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class GGPBSDYMNYX : SNNRVAJHWPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ZJTKXXHCJZZ AEMWCVQQDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly IDisposable VYQCUEZOPRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool ONJBMVJRIZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool VCZFLZFNPWX;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool POHZQMIZGRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF3630", VA = "0x180CF4C30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool IFGGLDHLFUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x15F4570", Offset = "0x15F2F70", VA = "0x1815F4570", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x977A1A0", Offset = "0x9778BA0", VA = "0x18977A1A0")]
		[RecRoom.NoEngine.Common.Preserve]
		public GGPBSDYMNYX([Inject(null)] ZJTKXXHCJZZ roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x977A020", Offset = "0x9778A20", VA = "0x18977A020", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x977A070", Offset = "0x9778A70", VA = "0x18977A070")]
		[GEPWJNEAFDW.Session.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x977A150", Offset = "0x9778B50", VA = "0x18977A150", Slot = "6")]
		public void SGYDITMSRNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x977A190", Offset = "0x9778B90", VA = "0x18977A190", Slot = "7")]
		public bool WBWGDPVZRTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x977A160", Offset = "0x9778B60", VA = "0x18977A160", Slot = "8")]
		public void SerializeTo(PersistedRoomData roomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9779F20", Offset = "0x9778920", VA = "0x189779F20")]
		private UELIVBOERHZ CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x977A0E0", Offset = "0x9778AE0", VA = "0x18977A0E0")]
		private void RICLFMYYKDJ(EICHPLWXAPH a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class SCTBAMRQOQL : ANBQTIQMEAE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly ZJTKXXHCJZZ AEMWCVQQDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly QZWQEOPVQWN MRHRHPQWERV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly QZWQEOPVQWN JOFLBBPIIDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IDisposable VYQCUEZOPRN;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool WVZWFBYTQTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x977C360", Offset = "0x977AD60", VA = "0x18977C360", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool TAKUAHEVGTF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x977C3E0", Offset = "0x977ADE0", VA = "0x18977C3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x977C770", Offset = "0x977B170", VA = "0x18977C770")]
		[RecRoom.NoEngine.Common.Preserve]
		public SCTBAMRQOQL([Inject(null)] ZJTKXXHCJZZ roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x977C530", Offset = "0x977AF30", VA = "0x18977C530", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x977C5B0", Offset = "0x977AFB0", VA = "0x18977C5B0")]
		[GEPWJNEAFDW.Session.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x977C710", Offset = "0x977B110", VA = "0x18977C710", Slot = "5")]
		public void UOGAZCCDKGC(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x977C580", Offset = "0x977AF80", VA = "0x18977C580", Slot = "6")]
		public bool HSAWUXMFBFF(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x977C740", Offset = "0x977B140", VA = "0x18977C740", Slot = "8")]
		public void VYIOHGGCMIX(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x977C3B0", Offset = "0x977ADB0", VA = "0x18977C3B0", Slot = "9")]
		public bool AUBJSCEGTUS(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x977C430", Offset = "0x977AE30", VA = "0x18977C430")]
		private UELIVBOERHZ CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x977C620", Offset = "0x977B020", VA = "0x18977C620")]
		private void QJYYWYFQBFX()
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
		private TTDNZSUZDGK YLXRXHNWMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private ZORYLYZVEXV MZXHUZKEBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private WUGWXWQKRET YGSGRGBUGVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private JBWJIVXRATE MLNLCVNZQVQ;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override RectTransform UFNRHWSYPAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED140", VA = "0x180CEE740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject QJMVCYMVBSA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED120", VA = "0x180CEE720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string QZMQATXMOLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xEE82E0", Offset = "0xEE6CE0", VA = "0x180EE82E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1723FA0", Offset = "0x17229A0", VA = "0x181723FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9779830", Offset = "0x9778230", VA = "0x189779830")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, string displayName, string partyId, Color? flagColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9779150", Offset = "0x9777B50", VA = "0x189779150")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9779D50", Offset = "0x9778750", VA = "0x189779D50", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9779B70", Offset = "0x9778570", VA = "0x189779B70", Slot = "6")]
		public override void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9779B30", Offset = "0x9778530", VA = "0x189779B30")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9779D00", Offset = "0x9778700", VA = "0x189779D00")]
		public void UpdateParty(string newPartyId, Color? newPartyColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9779320", Offset = "0x9777D20", VA = "0x189779320")]
		private bool FARGIDEJZSM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x97799A0", Offset = "0x97783A0", VA = "0x1897799A0")]
		private bool OMYFQJLFNAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9779A80", Offset = "0x9778480", VA = "0x189779A80")]
		private bool QQIXKYZYFZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9779730", Offset = "0x9778130", VA = "0x189779730")]
		private void IEEQCUQYPXV(Color? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9779BC0", Offset = "0x97785C0", VA = "0x189779BC0")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
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
	public class LWYSOMZZUCP
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CoordinationBeaconBase ZRAEPKJPZOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public LWYSOMZZUCP(CoordinationBeaconBase a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class QGRSPOPBOEY : LWYSOMZZUCP
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public CoordinationBeaconHUDElement QZPEHRBVPPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1360", VA = "0x180CF2960")]
		public QGRSPOPBOEY(CoordinationBeaconBase a, CoordinationBeaconHUDElement b)
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
