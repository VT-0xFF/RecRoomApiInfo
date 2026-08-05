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
		[Cpp2IlInjected.Address(RVA = "0x9920A70", Offset = "0x991FA70", VA = "0x189920A70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AssetReference XNMXYQIBGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AssetReference FYBIZIGZLWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AssetReference XWPPQITGCUR
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AssetReference QZOSOFXPSBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AssetReference ZOPETQGQDXG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public AssetReference HPCBYEORPUR
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AssetReference KAZVMPKTHGA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public AssetReference ZTTFKCHBBXT
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD09150", Offset = "0xD08150", VA = "0x180D09150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AnimationCurve AZGRPDOWVTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD09130", Offset = "0xD08130", VA = "0x180D09130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AnimationCurve WHNNQLXGALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float PEISODMOWUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD25180", Offset = "0xD24180", VA = "0x180D25180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AssetReference HHYBKTOFALY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD12820", Offset = "0xD11820", VA = "0x180D12820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AssetReference NFFXVOSQRNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD12E90", Offset = "0xD11E90", VA = "0x180D12E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AssetReference YIBNYRAECUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xD12870", Offset = "0xD11870", VA = "0x180D12870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Color AOMWDOHIVWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1029A80", Offset = "0x1028A80", VA = "0x181029A80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Color ZSJLANYRKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12D45F0", Offset = "0x12D35F0", VA = "0x1812D45F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Color WUVZZPZKKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1056890", Offset = "0x1055890", VA = "0x181056890")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color YPEFYCNYLKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x12D4600", Offset = "0x12D3600", VA = "0x1812D4600")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color JXGIGMIIYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8190", Offset = "0x8DF7190", VA = "0x188DF8190")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Color TTMMMHJPCRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x21A8B70", Offset = "0x21A7B70", VA = "0x1821A8B70")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x991B740", Offset = "0x991A740", VA = "0x18991B740")]
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
			[Cpp2IlInjected.Address(RVA = "0x991CFA0", Offset = "0x991BFA0", VA = "0x18991CFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x991FC40", Offset = "0x991EC40", VA = "0x18991FC40")]
		public static void HQHCRWJHFYF(int a, string b, Guid c, CoordinationBeaconContext d, CoordinationBeaconVisibilityGroup e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9920030", Offset = "0x991F030", VA = "0x189920030")]
		public static void SMHOJMXJHST(int a, string b, Guid c, CoordinationBeaconContext d, float e, RemovalReason f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x991FFB0", Offset = "0x991EFB0", VA = "0x18991FFB0")]
		public static void IYVHOZBEYPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x991FB60", Offset = "0x991EB60", VA = "0x18991FB60")]
		public static void DTDQUZCQXXO(TutorialType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99203E0", Offset = "0x991F3E0", VA = "0x1899203E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9920550", Offset = "0x991F550", VA = "0x189920550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD6E050", Offset = "0xD6D050", VA = "0x180D6E050", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD69190", Offset = "0xD68190", VA = "0x180D69190", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD6A4F0", Offset = "0xD694F0", VA = "0x180D6A4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x991F3A0", Offset = "0x991E3A0", VA = "0x18991F3A0")]
		[GEPWJNEAFDW.Room.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x113C300", Offset = "0x113B300", VA = "0x18113C300")]
		[RecRoom.NoEngine.Common.Preserve]
		internal RXANHIUDCHV([Inject(null)][NotNull] WUGWXWQKRET beaconConfigs, [Inject(null)][NotNull] RATRHZOQZEB beaconPoolService, [Inject(null)][NotNull] HZMQRERDGQL notificationManager, [Inject(null)][NotNull] IRRUIPlayerShim rruiPlayerShim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x991EC30", Offset = "0x991DC30", VA = "0x18991EC30", Slot = "5")]
		public void BLJMDEFKXTT(CoordinationBeaconVisibilityGroup a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x991EE50", Offset = "0x991DE50", VA = "0x18991EE50", Slot = "7")]
		public bool BXWGOYZZHXT(Camera a, Vector3 b, CoordinationBeaconBase c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x991F190", Offset = "0x991E190", VA = "0x18991F190", Slot = "6")]
		public bool DOCDGVOZBHL(Camera a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x991F0E0", Offset = "0x991E0E0", VA = "0x18991F0E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09150", Offset = "0xD08150", VA = "0x180D09150", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x991B9D0", Offset = "0x991A9D0", VA = "0x18991B9D0")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x991C1C0", Offset = "0x991B1C0", VA = "0x18991C1C0")]
		public void SetVisibilityUsernameDepthIgnore(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x991B780", Offset = "0x991A780", VA = "0x18991B780")]
		private void IEEQCUQYPXV(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
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
			[Cpp2IlInjected.Address(RVA = "0xEEF520", Offset = "0xEEE520", VA = "0x180EEF520")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int URUQWQKSCKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xD27F90", Offset = "0xD26F90", VA = "0x180D27F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CoordinationBeaconContext AEOZTIYAYYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD82430", Offset = "0xD81430", VA = "0x180D82430")]
			get
			{
				return default(CoordinationBeaconContext);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public CoordinationBeaconContext GMSMJAAJRJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x991ACC0", Offset = "0x9919CC0", VA = "0x18991ACC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x991AC10", Offset = "0x9919C10", VA = "0x18991AC10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x991ACD0", Offset = "0x9919CD0", VA = "0x18991ACD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x991AB90", Offset = "0x9919B90", VA = "0x18991AB90", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x991AB60", Offset = "0x9919B60", VA = "0x18991AB60")]
		protected void Initialize(Guid beaconId, int playerOwnerUserId, CoordinationBeaconContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0B70", Offset = "0x1AAFB70", VA = "0x181AB0B70")]
		public void StartTimer(float timerIntervalS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x991AB70", Offset = "0x9919B70", VA = "0x18991AB70")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x235B6C0", Offset = "0x235A6C0", VA = "0x18235B6C0", Slot = "6")]
		public virtual void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x235B6A0", Offset = "0x235A6A0", VA = "0x18235B6A0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x991AB10", Offset = "0x9919B10", VA = "0x18991AB10")]
		private void AZDRJXQJVRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0x991D960", Offset = "0x991C960", VA = "0x18991D960", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float IPSDVYAVIZX
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x991DE50", Offset = "0x991CE50", VA = "0x18991DE50", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool PEEOEHSHCOG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x991D820", Offset = "0x991C820", VA = "0x18991D820", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool YUJOHBFFLXY
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x991D4B0", Offset = "0x991C4B0", VA = "0x18991D4B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float BSJXRIPAXVU
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x991DB60", Offset = "0x991CB60", VA = "0x18991DB60", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float VAEYIZMFHIA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x991D600", Offset = "0x991C600", VA = "0x18991D600", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float JEJTSZRRHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x991E8A0", Offset = "0x991D8A0", VA = "0x18991E8A0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float NYQRHBEZVPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x991D520", Offset = "0x991C520", VA = "0x18991D520", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int JSWJUCVKMUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x991E0E0", Offset = "0x991D0E0", VA = "0x18991E0E0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float FNVSMEPWHRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x991DD90", Offset = "0x991CD90", VA = "0x18991DD90", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float QUZDJRSQMFW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x991E450", Offset = "0x991D450", VA = "0x18991E450", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float PLGEIWKAOQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x991DF30", Offset = "0x991CF30", VA = "0x18991DF30", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool BERFYDISSDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x991E980", Offset = "0x991D980", VA = "0x18991E980", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool ERRGNPYZYXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x991DFA0", Offset = "0x991CFA0", VA = "0x18991DFA0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool GLNYLRIDGBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x991E310", Offset = "0x991D310", VA = "0x18991E310", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool ZZLDAJUTDMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x991D9D0", Offset = "0x991C9D0", VA = "0x18991D9D0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public float VFWMODJVXCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x991D890", Offset = "0x991C890", VA = "0x18991D890", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float KALBAVINLIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x991E070", Offset = "0x991D070", VA = "0x18991E070", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public float NIKKAFKKZGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x991E4C0", Offset = "0x991D4C0", VA = "0x18991E4C0", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool BWVVWYFBQBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x991DC40", Offset = "0x991CC40", VA = "0x18991DC40", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float BCJKVECYFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x991DBD0", Offset = "0x991CBD0", VA = "0x18991DBD0", Slot = "30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public float XIQSDUHNDVD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x991D590", Offset = "0x991C590", VA = "0x18991D590", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public float AMMFWVOTIIR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x991D3D0", Offset = "0x991C3D0", VA = "0x18991D3D0", Slot = "32")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public float GLIALVBOIOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x991DCB0", Offset = "0x991CCB0", VA = "0x18991DCB0", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float RYJRPSENQME
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x991D440", Offset = "0x991C440", VA = "0x18991D440", Slot = "34")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int AKFPUQCAZUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x991E590", Offset = "0x991D590", VA = "0x18991E590", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float OFYUFBZVVHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x991E910", Offset = "0x991D910", VA = "0x18991E910", Slot = "36")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float JNQUGVLDCGU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x991E370", Offset = "0x991D370", VA = "0x18991E370", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float VOLDZPPTTTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x991DEC0", Offset = "0x991CEC0", VA = "0x18991DEC0", Slot = "38")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float GCOREIQDWQI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x991E3E0", Offset = "0x991D3E0", VA = "0x18991E3E0", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool UUIJLYTLIRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x991E600", Offset = "0x991D600", VA = "0x18991E600", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool KNDBLGZHJRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x991E530", Offset = "0x991D530", VA = "0x18991E530", Slot = "42")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x991E150", Offset = "0x991D150", VA = "0x18991E150", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool DUZLMBKPGRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x991D900", Offset = "0x991C900", VA = "0x18991D900", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x991E670", Offset = "0x991D670", VA = "0x18991E670", Slot = "22")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public float KSLBEOKQYLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x991E1C0", Offset = "0x991D1C0", VA = "0x18991E1C0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool HBHKGEWOFEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x991DAF0", Offset = "0x991CAF0", VA = "0x18991DAF0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x991E9F0", Offset = "0x991D9F0", VA = "0x18991E9F0")]
		[RecRoom.NoEngine.Common.Preserve]
		public GHVXFELMLLY([Inject(null)] CQTKPAWHYMF gameConfigsProvider, [Inject(null)] LLJFKJJXSMP preferencesProvider, [Inject(null)] KBMIQUZVWZE statsigProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x991DD20", Offset = "0x991CD20", VA = "0x18991DD20")]
		[GEPWJNEAFDW.Session.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x991D670", Offset = "0x991C670", VA = "0x18991D670", Slot = "40")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x991E010", Offset = "0x991D010", VA = "0x18991E010")]
		private void MIMEDEKJBSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x991DE00", Offset = "0x991CE00", VA = "0x18991DE00")]
		private void XRKISDBTAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x991E010", Offset = "0x991D010", VA = "0x18991E010")]
		private void VHBUYTWAYYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x991E010", Offset = "0x991D010", VA = "0x18991E010")]
		private void PETYOAOAVJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x991E6E0", Offset = "0x991D6E0", VA = "0x18991E6E0", Slot = "19")]
		public void XFZOMLCGTDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDD20", Offset = "0x3AECD20", VA = "0x183AEDD20")]
		private a SOQMVUMBFQX<a>(string a, a? b, a c) where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x991E750", Offset = "0x991D750", VA = "0x18991E750")]
		private bool XHDAIWNAMNE(string a, bool? b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x991E230", Offset = "0x991D230", VA = "0x18991E230")]
		private void RMQQVEXAFRU(string a, bool? b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x991E010", Offset = "0x991D010", VA = "0x18991E010")]
		private void XHLAPYTCSKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x991DE00", Offset = "0x991CE00", VA = "0x18991DE00")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x235B6C0", Offset = "0x235A6C0", VA = "0x18235B6C0")]
		public void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x235B6A0", Offset = "0x235A6A0", VA = "0x18235B6A0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x991AEA0", Offset = "0x9919EA0", VA = "0x18991AEA0")]
		public void Initialize(int ownerRecNetAccountId, CoordinationBeaconContext context, string displayName, Sprite contextualSprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x991B470", Offset = "0x991A470", VA = "0x18991B470")]
		public void UpdateVisualElements(Quaternion chevronLocalRotation, Vector3 localPosition, float distance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x991AD80", Offset = "0x9919D80", VA = "0x18991AD80")]
		private void IEEQCUQYPXV(Color a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public SNFVRJEFJDD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x991FA40", Offset = "0x991EA40", VA = "0x18991FA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x991FA00", Offset = "0x991EA00", VA = "0x18991FA00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x991B620", Offset = "0x991A620", VA = "0x18991B620")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x991B6C0", Offset = "0x991A6C0", VA = "0x18991B6C0")]
		[IteratorStateMachine(typeof(SNFVRJEFJDD))]
		private IEnumerator GKRMUORDSEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x991B730", Offset = "0x991A730", VA = "0x18991B730")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0FCE0", Offset = "0xD0ECE0", VA = "0x180D0FCE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool IFGGLDHLFUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x16101C0", Offset = "0x160F1C0", VA = "0x1816101C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x991D250", Offset = "0x991C250", VA = "0x18991D250")]
		[RecRoom.NoEngine.Common.Preserve]
		public GGPBSDYMNYX([Inject(null)] ZJTKXXHCJZZ roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x991D0D0", Offset = "0x991C0D0", VA = "0x18991D0D0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x991D120", Offset = "0x991C120", VA = "0x18991D120")]
		[GEPWJNEAFDW.Session.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x991D200", Offset = "0x991C200", VA = "0x18991D200", Slot = "6")]
		public void SGYDITMSRNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x991D240", Offset = "0x991C240", VA = "0x18991D240", Slot = "7")]
		public bool WBWGDPVZRTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x991D210", Offset = "0x991C210", VA = "0x18991D210", Slot = "8")]
		public void SerializeTo(PersistedRoomData roomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x991CFD0", Offset = "0x991BFD0", VA = "0x18991CFD0")]
		private UELIVBOERHZ CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x991D190", Offset = "0x991C190", VA = "0x18991D190")]
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
			[Cpp2IlInjected.Address(RVA = "0x991F410", Offset = "0x991E410", VA = "0x18991F410", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool TAKUAHEVGTF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x991F490", Offset = "0x991E490", VA = "0x18991F490", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x991F820", Offset = "0x991E820", VA = "0x18991F820")]
		[RecRoom.NoEngine.Common.Preserve]
		public SCTBAMRQOQL([Inject(null)] ZJTKXXHCJZZ roomLoader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x991F5E0", Offset = "0x991E5E0", VA = "0x18991F5E0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x991F660", Offset = "0x991E660", VA = "0x18991F660")]
		[GEPWJNEAFDW.Session.GameOnly]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x991F7C0", Offset = "0x991E7C0", VA = "0x18991F7C0", Slot = "5")]
		public void UOGAZCCDKGC(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x991F630", Offset = "0x991E630", VA = "0x18991F630", Slot = "6")]
		public bool HSAWUXMFBFF(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x991F7F0", Offset = "0x991E7F0", VA = "0x18991F7F0", Slot = "8")]
		public void VYIOHGGCMIX(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x991F460", Offset = "0x991E460", VA = "0x18991F460", Slot = "9")]
		public bool AUBJSCEGTUS(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x991F4E0", Offset = "0x991E4E0", VA = "0x18991F4E0")]
		private UELIVBOERHZ CreateDeserializationHandler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x991F6D0", Offset = "0x991E6D0", VA = "0x18991F6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public GameObject QJMVCYMVBSA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD09730", Offset = "0xD08730", VA = "0x180D09730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string QZMQATXMOLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xF03BA0", Offset = "0xF02BA0", VA = "0x180F03BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x173FBF0", Offset = "0x173EBF0", VA = "0x18173FBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x991C8E0", Offset = "0x991B8E0", VA = "0x18991C8E0")]
		public void Initialize(Guid beaconId, int playerOwnerUserId, string displayName, string partyId, Color? flagColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x991C200", Offset = "0x991B200", VA = "0x18991C200")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x991CE00", Offset = "0x991BE00", VA = "0x18991CE00", Slot = "5")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x991CC20", Offset = "0x991BC20", VA = "0x18991CC20", Slot = "6")]
		public override void SetVisibility(bool visible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x991CBE0", Offset = "0x991BBE0", VA = "0x18991CBE0")]
		public void ResetProfilePicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x991CDB0", Offset = "0x991BDB0", VA = "0x18991CDB0")]
		public void UpdateParty(string newPartyId, Color? newPartyColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x991C3D0", Offset = "0x991B3D0", VA = "0x18991C3D0")]
		private bool FARGIDEJZSM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x991CA50", Offset = "0x991BA50", VA = "0x18991CA50")]
		private bool OMYFQJLFNAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x991CB30", Offset = "0x991BB30", VA = "0x18991CB30")]
		private bool QQIXKYZYFZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x991C7E0", Offset = "0x991B7E0", VA = "0x18991C7E0")]
		private void IEEQCUQYPXV(Color? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x991CC70", Offset = "0x991BC70", VA = "0x18991CC70")]
		public void TriggerJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
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
