using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.EV.Protobuf;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;
using RecRoom.Versioning.Framework;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1040", Offset = "0x8DA0440", VA = "0x188DA1040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JTLQATILOJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface VUJTJJOWWBJ : GORVDLHLGVR<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class AVQHDSVSHCE : VUJTJJOWWBJ, GORVDLHLGVR<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static AVQHDSVSHCE ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			public PersistedRoomVersion MQUXSWYUJNT()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B720", Offset = "0x8D8AB20", VA = "0x188D8B720", Slot = "5")]
			public PersistedRoomVersion KEWCHRQDFBB()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1807A10", Offset = "0x1806E10", VA = "0x181807A10", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D790", Offset = "0x2C4CB90", VA = "0x182C4D790", Slot = "7")]
			public bool AHSAYKOIMSM(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B730", Offset = "0x8D8AB30", VA = "0x188D8B730", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public AVQHDSVSHCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class MBNKKQQQWHZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static Dictionary<Guid, string[]> VHZQYGLYBVD;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E1D0", Offset = "0x8D8D5D0", VA = "0x188D8E1D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class ARABCFQJTUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B460", Offset = "0x8D8A860", VA = "0x188D8B460")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class AQEZNEOUIBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B290", Offset = "0x8D8A690", VA = "0x188D8B290")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class TQODAUCENNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8DA7F20", Offset = "0x8DA7320", VA = "0x188DA7F20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class TQTJYAWBWZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8DA80E0", Offset = "0x8DA74E0", VA = "0x188DA80E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class MVTQAPZDLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0E80", Offset = "0x8DA0280", VA = "0x188DA0E80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class FVSFTRYSYCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B7F0", Offset = "0x8D8ABF0", VA = "0x188D8B7F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class RRWQGTVDFGR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8DA7BF0", Offset = "0x8DA6FF0", VA = "0x188DA7BF0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class RRGVOZNLCYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA7A20", Offset = "0x8DA6E20", VA = "0x188DA7A20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class YTDPXGKXXHB
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly Dictionary<Guid, int> SSHCOAAWXQY;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8DA89C0", Offset = "0x8DA7DC0", VA = "0x188DA89C0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8DA86F0", Offset = "0x8DA7AF0", VA = "0x188DA86F0")]
			private static Dictionary<Guid, EQKDAXAXTVB> HOBPWALWIZH(EQKDAXAXTVB a, Dictionary<Guid, EQKDAXAXTVB> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class YRYANRVNSQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8310", Offset = "0x8DA7710", VA = "0x188DA8310")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class MBXYFEELPER
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0CC0", Offset = "0x8DA00C0", VA = "0x188DA0CC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class JVUEFXTZSHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D740", Offset = "0x8D8CB40", VA = "0x188D8D740")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D730", Offset = "0x8D8CB30", VA = "0x188D8D730")]
			private static void EXCUXFQLZYB(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class JWESALHULEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D8DA20", Offset = "0x8D8CE20", VA = "0x188D8DA20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class JWZTPMJJWXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D8DC20", Offset = "0x8D8D020", VA = "0x188D8DC20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class JUEBBVQUUUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D0B0", Offset = "0x8D8C4B0", VA = "0x188D8D0B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class JUJHZCKSEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D410", Offset = "0x8D8C810", VA = "0x188D8D410")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class MASIVPPBKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E010", Offset = "0x8D8D410", VA = "0x188D8E010")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class QWAVKCOHPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8DA10C0", Offset = "0x8DA04C0", VA = "0x188DA10C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class QXGKTRDRTTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8DA77D0", Offset = "0x8DA6BD0", VA = "0x188DA77D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class QWVWZDPXAWT
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			private enum LegacyStableSpawnableToolType
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				INVALID = -1,
				[Cpp2IlInjected.Token(Token = "0x400000D")]
				PAINTBALL_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				PAINTBALL_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				PAINTBALL_SNIPER_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x4000010")]
				PAINTBALL_ASSAULT_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				PAINTBALL_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				PAINTBALL_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				PADDLEBALL_PADDLE,
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				PAINTBALL_GRENADE_LAUNCHER,
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				MAKER_PEN_CHARADES,
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				SOCCER_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				ROTJ_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				ROTJ_RAILGUN,
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				ROTJ_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				ROTJ_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				ROTJ_SMG,
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				GT_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				GT_BOW,
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				GT_SWORD,
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				CANDLE,
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				BELL,
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				WELCOME_MAT,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				GT_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				BASKETBALL,
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				DODGEBALL,
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				DISCGOLF_DISC,
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				SOLOCUP,
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				WATERBOTTLE,
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				DART,
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				DIE,
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				DEPRECATED_FLAG_RED,
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				DEPRECATED_FLAG_BLUE,
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				DEPRECATED_FLAG_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				DEPRECATED_FLAG_GREEN,
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				STICKY_NOTE,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				STICKY_POSTER,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				DRAWABLE_CLIPBOARD,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				MARKER_BLACK,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				MARKER_RED,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				MARKER_BLUE,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				MARKER_GREEN,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				MARKER_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				MARKER_ORANGE,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				MARKER_PINK,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				MARKER_PURPLE,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				MARKER_SKYBLUE,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				MARKER_BROWN,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				ERASER,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				MARKER_ERASER,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				CHAIR,
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				MICROPHONE,
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				SANDBOX_TOOL_GOAL_SMALL,
				[Cpp2IlInjected.Token(Token = "0x4000040")]
				SANDBOX_TOOL_GOAL_MEDIUM,
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				SANDBOX_TOOL_GOAL_LARGE,
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				SANDBOX_PLAYER_GOAL,
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				CONFETTI_GUN,
				[Cpp2IlInjected.Token(Token = "0x4000044")]
				PING_PONG_PADDLE,
				[Cpp2IlInjected.Token(Token = "0x4000045")]
				PING_PONG_BALL,
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				CC_WAND,
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				CC_HUNTER_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				RADIO,
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				BUCKET,
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				ARENA_EMP,
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				PROPBOX_SQUARE,
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				PROPBOX_RECTANGLE,
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				FLATTREESMALL,
				[Cpp2IlInjected.Token(Token = "0x400004E")]
				FLATTREEMEDIUM,
				[Cpp2IlInjected.Token(Token = "0x400004F")]
				FLATTREELARGE,
				[Cpp2IlInjected.Token(Token = "0x4000050")]
				MARSHMALLOWSTICK,
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				HORIZONTALWALL,
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				VERTICALWALL,
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				BACKSTOPSHORT,
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				WINEBARREL,
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				CONCRETEBLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				STONEPILLAR,
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				LOGBENCH,
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				SITTINGLOG,
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				CONE,
				[Cpp2IlInjected.Token(Token = "0x400005A")]
				CAMPFIRE,
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				STOOL,
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				GLOWSTICK_BLUE,
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				GLOWSTICK_RED,
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				GLOWSTICK_PURPLE,
				[Cpp2IlInjected.Token(Token = "0x400005F")]
				GLOWSTICK_ORANGE,
				[Cpp2IlInjected.Token(Token = "0x4000060")]
				COUCH,
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				COUCHCHAIR,
				[Cpp2IlInjected.Token(Token = "0x4000062")]
				ARENA_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x4000063")]
				ARENA_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				ARENA_SMG,
				[Cpp2IlInjected.Token(Token = "0x4000065")]
				ARENA_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000066")]
				ARENA_RAILGUN,
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				ARENA_ROCKET_LAUNCHER,
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				RC_CAR_SET,
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				RC_CAR,
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				RC_REMOTE_CONTROL,
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				CC_MEAT_SWORD,
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				CC_FIRE_POTION,
				[Cpp2IlInjected.Token(Token = "0x400006D")]
				D20,
				[Cpp2IlInjected.Token(Token = "0x400006E")]
				D12,
				[Cpp2IlInjected.Token(Token = "0x400006F")]
				D10,
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				D8,
				[Cpp2IlInjected.Token(Token = "0x4000071")]
				D6,
				[Cpp2IlInjected.Token(Token = "0x4000072")]
				D4,
				[Cpp2IlInjected.Token(Token = "0x4000073")]
				DICE_SET,
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				POKERCHAIR,
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				PLANT_FIG,
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				PLANT_DRACAENA,
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				PLANT_SNAKE,
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				TABLE_MEETING,
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				TABLE_COFFEE_LARGE,
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				HAM,
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				TABLE_PINGPONG,
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				SPEAKER,
				[Cpp2IlInjected.Token(Token = "0x400007D")]
				MICROPHONE_STAND,
				[Cpp2IlInjected.Token(Token = "0x400007E")]
				TABLE_TALL,
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				TABLE_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				BOOKSHELF_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				BOOKSHELF_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				LOCKERS,
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				BOOK_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				BOOK_GREEN,
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				MOCKTAIL_SHAKER,
				[Cpp2IlInjected.Token(Token = "0x4000086")]
				MOCKTAIL_STEMLESS,
				[Cpp2IlInjected.Token(Token = "0x4000087")]
				MOCKTAIL_MARTINI,
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				MOCKTAIL_MILKSHAKE,
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				MOCKTAIL_GOBLET,
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				MOCKTAIL_MARGARITA,
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				MOCKTAIL_TALL,
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				MINIFRIDGE,
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				DEPRECATED_ROOM_DOOR,
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				SNOWBALL,
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				SNOWBALL_PILE,
				[Cpp2IlInjected.Token(Token = "0x4000090")]
				POLAROID,
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				PIRATE_CUTLASS,
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				PIRATE_RUM_JUG,
				[Cpp2IlInjected.Token(Token = "0x4000093")]
				PIRATE_BEER_BOTTLE,
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000095")]
				COMBINATOR_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000096")]
				COMPARER_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				VARIABLE_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				TIMER_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				DELAY_NODE,
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				MESSAGE_NODE,
				[Cpp2IlInjected.Token(Token = "0x400009B")]
				BOOLEAN_NODE,
				[Cpp2IlInjected.Token(Token = "0x400009C")]
				IMPULSE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x400009D")]
				DISCGOLF_GOAL,
				[Cpp2IlInjected.Token(Token = "0x400009E")]
				PLAYER_CREATED_SIGN,
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				GAME_STATE_OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				GAME_STATE_INPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				SCORE_INPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				SET_SCORE_OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				PIRATE_FLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				PIRATE_COCONUT_BOMB,
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				MOVEABLE_WHITEBOARD,
				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				RANDOM_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				PLAYER_HIT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				PIRATE_SMALL_LOOT_PILE,
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				SFX_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				DEPRECATED_HOLOTAR_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				PIRATE_PUSH_BROOM,
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				PIRATE_BAR_STOOL,
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				PIRATE_PLUSH_FISH,
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				PIRATE_FRYING_PAN,
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				PIRATE_OAR,
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				PIRATE_PLATE,
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				PIRATE_MUG,
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				PIRATE_LOST_LOOT,
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				WHITEBOARD_MARKERS,
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				PIRATE_HOOK_HAND,
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				PLAYER_RESPAWN_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				SANDBOX_FLOOR,
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				SANDBOX_WALL,
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				PLAYER_RESPAWN_POINT,
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				SANDBOX_CEILING,
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				SANDBOX_WALL_WINDOW,
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				AMBIENCE_RADIO,
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				INDICATOR_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				SANDBOX_AUDIO_SAMPLER,
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				SELECTOR_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				DEPRECATED_SANDBOX_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				ROTATOR_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				TRIGGER_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				ROYALE_ISLAND_MAP,
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				GAME_GET_SCORE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				GAME_SET_SCORE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				GET_PLAYER_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				SET_PLAYER_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				PLAYER_TEAM_MAPPING_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				PLAYER_EVENT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				GAME_SET_STATE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				ROYALE_HEALTH_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				ROYALE_SHIELD_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				ROYALE_HEALTH_AND_SHIELD_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				CIRCUIT_STAGE_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				ROYALE_AMMUNITION_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				ROYALE_AMMUNITION_AUTOMATIC,
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				ROYALE_AMMUNITION_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				ROYALE_AMMUNITION_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				ROYALE_AMMUNITION_EXPLOSIVE,
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				SMOOTH_LOOK_AT,
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				PISTON_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				MICROPHONE_CONFERENCE,
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				WAVE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				PLAYER_ROLE_MAP_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				CLAMP_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				OBJECT_RESPAWNER,
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				OBJECT_PLAYER_MAP_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				ARENA_BEAM_GUN,
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				COFFEE_POT,
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				COFFEE_MUG,
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				CAFE_PLATE,
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				QUEST_POT,
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				QUEST_POT_LARGE,
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				SCIFI_POT,
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				OBJECT_SET_TAGS_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				SANDBOX_GAMING_TABLE,
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				SANDBOX_MEEPLE,
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				PAINTBRUSH,
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				SANDBOX_GAMING_TABLE_SMALL,
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				SOCCER_BALL,
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				DRACULA_BONE,
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				PARTICLE_EMITTER,
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				COSTUME_DUMMY,
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				DRACULA_BLUNDERBUSS,
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				DRACULA_MINIBOSS_BONE,
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				DRACULA_SHOVEL,
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				DRACULA_PITCHFORK,
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				DRACULA_RAKE,
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				DRACULA_WHIP,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				DRACULA_WALL_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				DRACULA_PUMPKIN_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				DRACULA_LOOT_SMALL,
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				SHAPE_CONTAINER,
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				DRACULA_CHESTCOINS_SMALL,
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				DRACULA_CHESTCOINS_MEDIUM,
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				DRACULA_CHESTCOINS_LARGE,
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				DRACULA_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				DRACULA_HUNTER_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				DRACULA_MINIBOSSCOINS_BAT,
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				DRACULA_MINIBOSSCOINS_BONETHROWER,
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				DRACULA_MINIBOSSCOINS_MUSKET,
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				DRACULA_MINIBOSSCOINS_WOLF,
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				DRACULA_MINIBOSSCOINS_BONEMELEE,
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				DRACULA_STANDING_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				DRACULA_SMALL_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				DRACULA_FLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				DRACULA_BOSS_PLUSHY,
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				DRACULA_HOOKSHOT,
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				BOWLING_BALL,
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				BOWLING_PIN,
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				ROYALE_BACKPACK,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				HANDHELD_STREAMER_CAMERA,
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				STACKABLE_BLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				RECROYALE_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				GAME_CONFIGURATION,
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				BOWLING_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				DISC_GOLF_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				DODGEBALL_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				LASER_TAG_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				PADDLEBALL_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				SOCCER_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				CIRCUIT_GROUP,
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				STATE_MACHINE,
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				STATE_MACHINE_STATE,
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				STANDEE_FEMALE_01,
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				STANDEE_MALE_01,
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				STANDEE_FEMALE_02,
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				STANDEE_FEMALE_03,
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				STANDEE_PIRATE_PHOTO,
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				STANDEE_PIRATE_01,
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				STANDEE_PIRATE_02,
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				STANDEE_PIRATE_DRUMMER,
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				STANDEE_PIRATE_FIDDLE,
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				STANDEE_PIRATE_SQUEEZEBOX,
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				STANDEE_BEAR_01,
				[Cpp2IlInjected.Token(Token = "0x400012A")]
				SCOREBOARD_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x400012B")]
				CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400012C")]
				SANDBOX_CIRCUIT_BEACON,
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				MAKER_PEN_TROPHY_GOLD,
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				MAKER_PEN_TROPHY_SILVER,
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				MAKER_PEN_TROPHY_BRONZE,
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				PLAYER_REVIVED_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				CONTEST_CATEGORY_TROPHY,
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				SCOREBOARD_SETUP_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				DYNAMIC_SPOTLIGHT,
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				DYNAMINC_POINT_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				MARKER_RECOLORABLE,
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				HOLO_HELPER,
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				STUNTRUNNER_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				STUNTRUNNER_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				ANIMATIONGIZMO,
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				TILEABLE_ROPE_NET,
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				LIGHT_STRIP_SHORT,
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				CHECKPOINT_SANDBOX,
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				BOUNCE_PAD,
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				LIGHT_CHEVRONS,
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				LIGHT_MARQUEE,
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				SCAFFOLDING_SHINY,
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				SCAFFOLDING_BLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				CRASHPAD_EXTRA_THICK,
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				CRASHPAD_THICK,
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				CRASHPAD_THIN,
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				CRASHPAD_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				SPEAKER_CONCERT,
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				STAGELIGHT_CAN,
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				SET_LEADERBOARD_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				GET_LEADERBOARD_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				LEADERBOARD_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				PLAYER_BOOSTER,
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				ART_CANVAS,
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				SPRINGBOARD_STUNTRUNNER,
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				IMPULSE_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x400014F")]
				STUNTRUNNER_JUMBOTRON,
				[Cpp2IlInjected.Token(Token = "0x4000150")]
				STUNTRUNNER_BASEROOM_FLOOR,
				[Cpp2IlInjected.Token(Token = "0x4000151")]
				STUNTRUNNER_BASEROOM_CEILING,
				[Cpp2IlInjected.Token(Token = "0x4000152")]
				STUNTRUNNER_BASEROOM_WALL_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000153")]
				STUNTRUNNER_BASEROOM_WALL_LONG,
				[Cpp2IlInjected.Token(Token = "0x4000154")]
				ART_CANVAS_SQUARE,
				[Cpp2IlInjected.Token(Token = "0x4000155")]
				STUNTRUNNER_PICKUP,
				[Cpp2IlInjected.Token(Token = "0x4000156")]
				STUNTRUNNER_CHECKPOINT_INVENTION,
				[Cpp2IlInjected.Token(Token = "0x4000157")]
				STUNTRUNNER_COMMENTATOR_BOOTH,
				[Cpp2IlInjected.Token(Token = "0x4000158")]
				STUNTRUNNER_ENDING_GATE,
				[Cpp2IlInjected.Token(Token = "0x4000159")]
				STUNTRUNNER_STARTING_GATE,
				[Cpp2IlInjected.Token(Token = "0x400015A")]
				STUNTRUNNER_COMMENTATOR_CAMERA,
				[Cpp2IlInjected.Token(Token = "0x400015B")]
				STUNTRUNNER_BOOM_MICROPHONE,
				[Cpp2IlInjected.Token(Token = "0x400015C")]
				GAME_ROLE_NODE,
				[Cpp2IlInjected.Token(Token = "0x400015D")]
				JACKOLANTERN,
				[Cpp2IlInjected.Token(Token = "0x400015E")]
				CLAPPERBOARD_VIDEO_TROPHY,
				[Cpp2IlInjected.Token(Token = "0x400015F")]
				SANDBOX_TOGGLE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000160")]
				SANDBOX_TEXT,
				[Cpp2IlInjected.Token(Token = "0x4000161")]
				POOL_TABLE,
				[Cpp2IlInjected.Token(Token = "0x4000162")]
				POOL_CUE,
				[Cpp2IlInjected.Token(Token = "0x4000163")]
				POOL_CUE_RACK,
				[Cpp2IlInjected.Token(Token = "0x4000164")]
				POOL_TRIANGLE,
				[Cpp2IlInjected.Token(Token = "0x4000165")]
				PAINT_THROWER,
				[Cpp2IlInjected.Token(Token = "0x4000166")]
				PROXIMITY_MINE,
				[Cpp2IlInjected.Token(Token = "0x4000167")]
				INVISIBLE_COLLISION,
				[Cpp2IlInjected.Token(Token = "0x4000168")]
				FLAG,
				[Cpp2IlInjected.Token(Token = "0x4000169")]
				FLAG_GOAL,
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				FOG_NODE,
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				SKYDOME_NODE,
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				BLOOM_NODE,
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				COLORGRADING_NODE,
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				SUN_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				BACKGROUNDOBJECTS_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				TABLE_UMBRELLA,
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				ROUND_PICNIC_TABLE,
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				BOOTH_SEAT,
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				TRASH_BAG,
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				CONCRETE_BARRIER,
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				GAS_PUMP,
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				DRIVEIN_SPEAKER,
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				CAR_TIRE,
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				CONCRETE_TUBE,
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				TELEPHONE_POLE,
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				MESH_FENCE,
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				TARGET,
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				CLASSIC_CAR,
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				TRUCK,
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				GUARD_RAIL,
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				LAWN_CHAIR,
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				FILM_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				TRACTOR_TIRE,
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				STEAM_VENT,
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				AC_UNIT,
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				METAL_BARREL,
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				DINER_SIGN,
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				DINER_SIGN_LARGE,
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				DRIVEIN_SIGN,
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				FRANKIES_FUEL_SIGN,
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				DUMPSTER,
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				BOOTH_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				FENCE_PLANK,
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				FENCE_FRAME,
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				PICNIC_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				TRASH_CAN,
				[Cpp2IlInjected.Token(Token = "0x400018F")]
				CARDBOARD_BOX,
				[Cpp2IlInjected.Token(Token = "0x4000190")]
				FLAG_AND_GOAL,
				[Cpp2IlInjected.Token(Token = "0x4000191")]
				DESKTOP_SHARING_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x4000192")]
				DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
				[Cpp2IlInjected.Token(Token = "0x4000193")]
				SANDBOX_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				ROOM_DOOR,
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				HOLOTAR_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				ROCK_PLATEAU,
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				ROCK_STUMP,
				[Cpp2IlInjected.Token(Token = "0x4000198")]
				ROCK_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				ROCK_WALL,
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				ROCK_WEDGE,
				[Cpp2IlInjected.Token(Token = "0x400019B")]
				WOODEN_SPOOL,
				[Cpp2IlInjected.Token(Token = "0x400019C")]
				WOODSTACK,
				[Cpp2IlInjected.Token(Token = "0x400019D")]
				WOOD_PALLET,
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				IBEAM_5M,
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				IBEAM_10M,
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				IBEAM_BRACKET,
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				HAY_BALE,
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				LOG_PILE,
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				TRASH_BIN,
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				TREE_STUMP,
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				WATER_JUG,
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				PIPE_BRACKET,
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				PIPE_CURVED,
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				PIPE_STRAIGHT,
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				PIPE_STRAIGHT_LONG,
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				CONTROL_PANEL_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				CONTROL_PANEL_TALL,
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				ELECTRICAL_UNIT,
				[Cpp2IlInjected.Token(Token = "0x40001AD")]
				PINE_TREE_DEAD,
				[Cpp2IlInjected.Token(Token = "0x40001AE")]
				SPORTS_CAR,
				[Cpp2IlInjected.Token(Token = "0x40001AF")]
				PVP_WHIP,
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				CURTAIN_TIED,
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				CURTAIN_WAVY,
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				NAPKIN_HOLDER,
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				BREAKER_BOX,
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				ROCK_01,
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				ROCK_04,
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				ROCK_CLIFF,
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				ROCK_CONE,
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				TENNIS_BALL,
				[Cpp2IlInjected.Token(Token = "0x40001B9")]
				DESKTOP_AUDIO_SHARING,
				[Cpp2IlInjected.Token(Token = "0x40001BA")]
				GOBLINBASICFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001BB")]
				AIPATHPOINT,
				[Cpp2IlInjected.Token(Token = "0x40001BC")]
				GOBLINBASICGROUNDMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001BD")]
				DRACULABONETHROWER,
				[Cpp2IlInjected.Token(Token = "0x40001BE")]
				SPAWNERCIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x40001BF")]
				NAVMESH_BAKE_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x40001C0")]
				SCFIFGROUNDEXPLOSIVE,
				[Cpp2IlInjected.Token(Token = "0x40001C1")]
				GOBLINKNIGHTSPIN,
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				GOBLINBASICGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				GOBLINBASICMELEEPIKE,
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				GOBLINELITEGROUNDMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				GOBLINELITEFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001C6")]
				SCIFIBASICFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001C7")]
				SCIFIBASICGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				SCIFIKNIGHTASSASSIN,
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				SCIFIELITEFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				SCIFIELITEGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				GOBLINVOLLEY,
				[Cpp2IlInjected.Token(Token = "0x40001CC")]
				PIRATEBASICMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001CD")]
				PIRATEEXPLOSIVETHROWING,
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				PIRATEBOTTLETHROWING,
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				PIRATEFLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				PIRATEGIBBET,
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				DRACULAMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				DRACULAMUSKET,
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				DRACULABATRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				DRACULABATLUNGING,
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				GOBLINKNIGHTCHARGE,
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				LINK_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				RANGEFINDER_GADGET,
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				COSTUME_DUMMY_PLUS,
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				CREATOR_FEEDBACK_BUTTONS,
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				CREATOR_FREEGIFT_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				BEAN_BAG,
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				CAFE_TABLE_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				CAFE_TABLE_TALL,
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				CAFE_CHAIR_ROUND,
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				COFFEE_TABLE_CURVY,
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				STOOL_WOODEN,
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				BULLETIN_BOARD,
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				CURTAIN_NO_TASSELS,
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				COUCH_WOOD,
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				STOOL_BOWLING_ALLEY,
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				JUKEBOX,
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				LIGHT_PENDANT,
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				ROOT_BEER_BOTTLE,
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				INKSPACE_STAGE,
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				INK_SPACE_ROOM_HULL,
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				AI_MOVE_ORDER,
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				UGC_AREA,
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				SPAWNERCIRCUIT_V2,
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				MODERATOR_PLAQUE_GOLD,
				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				MODERATOR_PLAQUE_SILVER,
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				MODERATOR_PLAQUE_BRONZE,
				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				SANDBOX_TOGGLE_BUTTON_CV2,
				[Cpp2IlInjected.Token(Token = "0x40001F1")]
				TRIGGER_VOLUME_CV2,
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				SANDBOX_BUTTON_CV2,
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				SHOWCASE_POSTER,
				[Cpp2IlInjected.Token(Token = "0x40001F4")]
				DRACULA_LUNGING_WOLF,
				[Cpp2IlInjected.Token(Token = "0x40001F5")]
				PISTON_GIZMO_V2,
				[Cpp2IlInjected.Token(Token = "0x40001F6")]
				ROTATOR_GIZMO_V2,
				[Cpp2IlInjected.Token(Token = "0x40001F7")]
				SFX_NODE_V2,
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				SANDBOX_TEXT_V2,
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				LOG_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				PARTICLE_EMITTER_V2,
				[Cpp2IlInjected.Token(Token = "0x40001FB")]
				DYNAMIC_SPOTLIGHT_V2,
				[Cpp2IlInjected.Token(Token = "0x40001FC")]
				DYNAMIC_POINTLIGHT_V2,
				[Cpp2IlInjected.Token(Token = "0x40001FD")]
				DICE_SET_V2,
				[Cpp2IlInjected.Token(Token = "0x40001FE")]
				D4_V2,
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				D6_V2,
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				D8_V2,
				[Cpp2IlInjected.Token(Token = "0x4000201")]
				D12_V2,
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				D20_V2,
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				D10_V2,
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				VECTOR_GADGET,
				[Cpp2IlInjected.Token(Token = "0x4000205")]
				AUDIO_EFFECT_ZONE,
				[Cpp2IlInjected.Token(Token = "0x4000206")]
				SANDBOX_GLASS,
				[Cpp2IlInjected.Token(Token = "0x4000207")]
				GREEN_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x4000208")]
				SANDBOX_MIRROR,
				[Cpp2IlInjected.Token(Token = "0x4000209")]
				STREAMING_CAMERA_POINT,
				[Cpp2IlInjected.Token(Token = "0x400020A")]
				ROOM_CURRENCY_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				SANDBOX_SEAT,
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				PUNCHING_BAG,
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				VENDING_MACHINE,
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				ICEBREAKERS,
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				MAGIC_DOOR,
				[Cpp2IlInjected.Token(Token = "0x4000210")]
				FULLBODYCOSTUMEDUMMY,
				[Cpp2IlInjected.Token(Token = "0x4000211")]
				SANDBOX_COC_POSTER,
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				FRIENDOTRON,
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				POP_UP_SHOP_1,
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				POP_UP_SHOP_2,
				[Cpp2IlInjected.Token(Token = "0x4000215")]
				ROOM_CONSUMABLE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000216")]
				RALLY_BUGGY,
				[Cpp2IlInjected.Token(Token = "0x4000217")]
				RECRALLY_PICKUP,
				[Cpp2IlInjected.Token(Token = "0x4000218")]
				TRIGGER_HANDLE,
				[Cpp2IlInjected.Token(Token = "0x4000219")]
				COSTUME_TROPHY_GOLD,
				[Cpp2IlInjected.Token(Token = "0x400021A")]
				COSTUME_TROPHY_SILVER,
				[Cpp2IlInjected.Token(Token = "0x400021B")]
				COSTUME_TROPHY_BRONZE
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			private static class AUAUHKGSFIQ
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid ZGDCGRFFVQN
				{
					[Cpp2IlInjected.Token(Token = "0x600002C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4C50", Offset = "0x8DB4050", VA = "0x188DB4C50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid SYOBLOQGHUD
				{
					[Cpp2IlInjected.Token(Token = "0x600002D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB14D0", Offset = "0x8DB08D0", VA = "0x188DB14D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid NPMPTTAJCXE
				{
					[Cpp2IlInjected.Token(Token = "0x600002E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5C10", Offset = "0x8DB5010", VA = "0x188DB5C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid FYFKAFHGXJM
				{
					[Cpp2IlInjected.Token(Token = "0x600002F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6F10", Offset = "0x8DB6310", VA = "0x188DB6F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid POCBOOJAMVE
				{
					[Cpp2IlInjected.Token(Token = "0x6000030")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8D90", Offset = "0x8DB8190", VA = "0x188DB8D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid YVYYOSODNOG
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4F90", Offset = "0x8DB4390", VA = "0x188DB4F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid DHOOHYKYVSB
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7190", Offset = "0x8DB6590", VA = "0x188DB7190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid SJIBVVLJKXO
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5310", Offset = "0x8DB4710", VA = "0x188DB5310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid DFZTADLJVOT
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7610", Offset = "0x8DB6A10", VA = "0x188DB7610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid OPQPWWRXIQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE550", Offset = "0x8DAD950", VA = "0x188DAE550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid SQUVEAOBZXR
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x8DBBA90", Offset = "0x8DBAE90", VA = "0x188DBBA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid SQVHOVLMYRZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF3D0", Offset = "0x8DAE7D0", VA = "0x188DAF3D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid BBJJPZTLRNQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000038")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB4D0", Offset = "0x8DAA8D0", VA = "0x188DAB4D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid VTHMPMEAWFE
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9590", Offset = "0x8DB8990", VA = "0x188DB9590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid GKSYIPJZANI
				{
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB49D0", Offset = "0x8DB3DD0", VA = "0x188DB49D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid KGXCHZZXILX
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3950", Offset = "0x8DB2D50", VA = "0x188DB3950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid HZMYYNJHQXY
				{
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0x8DABF50", Offset = "0x8DAB350", VA = "0x188DABF50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid RMDRQQHHSTY
				{
					[Cpp2IlInjected.Token(Token = "0x600003D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1ED0", Offset = "0x8DB12D0", VA = "0x188DB1ED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid DCYLXVJIRYT
				{
					[Cpp2IlInjected.Token(Token = "0x600003E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2A50", Offset = "0x8DB1E50", VA = "0x188DB2A50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid BYMLYVGDHQD
				{
					[Cpp2IlInjected.Token(Token = "0x600003F")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB310", Offset = "0x8DBA710", VA = "0x188DBB310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid RRFJYMSZLXF
				{
					[Cpp2IlInjected.Token(Token = "0x6000040")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7210", Offset = "0x8DB6610", VA = "0x188DB7210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid KZLVXLGQCDB
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9810", Offset = "0x8DB8C10", VA = "0x188DB9810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid JODNURCIBJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000042")]
					[Cpp2IlInjected.Address(RVA = "0x8DB33D0", Offset = "0x8DB27D0", VA = "0x188DB33D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid GDURLSRODXL
				{
					[Cpp2IlInjected.Token(Token = "0x6000043")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE9D0", Offset = "0x8DADDD0", VA = "0x188DAE9D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid HNCWCQQAXMI
				{
					[Cpp2IlInjected.Token(Token = "0x6000044")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7710", Offset = "0x8DB6B10", VA = "0x188DB7710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid LMHKNKLZWHH
				{
					[Cpp2IlInjected.Token(Token = "0x6000045")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFB50", Offset = "0x8DAEF50", VA = "0x188DAFB50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid CVYRWBSUVPV
				{
					[Cpp2IlInjected.Token(Token = "0x6000046")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFC50", Offset = "0x8DAF050", VA = "0x188DAFC50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid NMDHTOHIGXD
				{
					[Cpp2IlInjected.Token(Token = "0x6000047")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5510", Offset = "0x8DB4910", VA = "0x188DB5510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid GIJXYZKJVVB
				{
					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFED0", Offset = "0x8DAF2D0", VA = "0x188DAFED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid SWYQBLGNCOA
				{
					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8C90", Offset = "0x8DB8090", VA = "0x188DB8C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid RSLKAXLZCIK
				{
					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9A90", Offset = "0x8DB8E90", VA = "0x188DB9A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid VEJOBZCAQKL
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD5D0", Offset = "0x8DAC9D0", VA = "0x188DAD5D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid HBAPWSJCMWT
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7490", Offset = "0x8DB6890", VA = "0x188DB7490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid GSTPPXBNSZA
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4850", Offset = "0x8DB3C50", VA = "0x188DB4850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid VVZGSYOXSLQ
				{
					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3D50", Offset = "0x8DB3150", VA = "0x188DB3D50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid FFCKHGSAKNZ
				{
					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA210", Offset = "0x8DB9610", VA = "0x188DBA210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid GGZTCUCTSWB
				{
					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3C50", Offset = "0x8DB3050", VA = "0x188DB3C50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid GYZZTCLSKMU
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD850", Offset = "0x8DACC50", VA = "0x188DAD850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid SOCUKVROPFO
				{
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA290", Offset = "0x8DB9690", VA = "0x188DBA290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid QMBAXCPFUJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8DB21D0", Offset = "0x8DB15D0", VA = "0x188DB21D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid YPNJKEZRXJO
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x8DB10D0", Offset = "0x8DB04D0", VA = "0x188DB10D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid SEOWXWMWRQF
				{
					[Cpp2IlInjected.Token(Token = "0x6000055")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5D90", Offset = "0x8DB5190", VA = "0x188DB5D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid HEAAMXJQCQD
				{
					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC450", Offset = "0x8DAB850", VA = "0x188DAC450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid RKBXFYIXKCJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8DABB50", Offset = "0x8DAAF50", VA = "0x188DABB50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid IIFKFOMQDCP
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF850", Offset = "0x8DAEC50", VA = "0x188DAF850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid ENEAUGTSLDE
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4650", Offset = "0x8DB3A50", VA = "0x188DB4650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid XSZWMOUFFGH
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC8D0", Offset = "0x8DABCD0", VA = "0x188DAC8D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid QZQXRGLUEBE
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4AD0", Offset = "0x8DB3ED0", VA = "0x188DB4AD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid PHCXURCFACZ
				{
					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1650", Offset = "0x8DB0A50", VA = "0x188DB1650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid QVAAGLHGFIH
				{
					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2ED0", Offset = "0x8DB22D0", VA = "0x188DB2ED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid MWGJTQKKQYG
				{
					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8E90", Offset = "0x8DB8290", VA = "0x188DB8E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid ISKCWLKCGZA
				{
					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5F10", Offset = "0x8DB5310", VA = "0x188DB5F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid GEOVTRSDHII
				{
					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8490", Offset = "0x8DB7890", VA = "0x188DB8490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid JCDRSUBMYYO
				{
					[Cpp2IlInjected.Token(Token = "0x6000061")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFDD0", Offset = "0x8DAF1D0", VA = "0x188DAFDD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid ZJRZODKDJIH
				{
					[Cpp2IlInjected.Token(Token = "0x6000062")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0C50", Offset = "0x8DB0050", VA = "0x188DB0C50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid SFGJEHRJLKD
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5890", Offset = "0x8DB4C90", VA = "0x188DB5890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid SJGVZAGCJCG
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0E50", Offset = "0x8DB0250", VA = "0x188DB0E50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid WJZZOLIDJBR
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8410", Offset = "0x8DB7810", VA = "0x188DB8410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid KQIKMQYLRTN
				{
					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5190", Offset = "0x8DB4590", VA = "0x188DB5190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid XVUJTZBNROI
				{
					[Cpp2IlInjected.Token(Token = "0x6000067")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4350", Offset = "0x8DB3750", VA = "0x188DB4350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid JYVXJCRNABP
				{
					[Cpp2IlInjected.Token(Token = "0x6000068")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2AD0", Offset = "0x8DB1ED0", VA = "0x188DB2AD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid ILTKWKLVEME
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF750", Offset = "0x8DAEB50", VA = "0x188DAF750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid JOETDNTOKWI
				{
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD0D0", Offset = "0x8DAC4D0", VA = "0x188DAD0D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid WRJMGEPEBHQ
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA490", Offset = "0x8DB9890", VA = "0x188DBA490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid OAONBZVFOAK
				{
					[Cpp2IlInjected.Token(Token = "0x600006C")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB210", Offset = "0x8DBA610", VA = "0x188DBB210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid BTRJWWEBDZO
				{
					[Cpp2IlInjected.Token(Token = "0x600006D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0350", Offset = "0x8DAF750", VA = "0x188DB0350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid YPINMPQCTIK
				{
					[Cpp2IlInjected.Token(Token = "0x600006E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7910", Offset = "0x8DB6D10", VA = "0x188DB7910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid BPZSAPCWPIY
				{
					[Cpp2IlInjected.Token(Token = "0x600006F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB01D0", Offset = "0x8DAF5D0", VA = "0x188DB01D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid EULNEGKTFVJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000070")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5710", Offset = "0x8DB4B10", VA = "0x188DB5710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid OGLZTXVVIUO
				{
					[Cpp2IlInjected.Token(Token = "0x6000071")]
					[Cpp2IlInjected.Address(RVA = "0x8DB39D0", Offset = "0x8DB2DD0", VA = "0x188DB39D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid DLTVQCPAWKA
				{
					[Cpp2IlInjected.Token(Token = "0x6000072")]
					[Cpp2IlInjected.Address(RVA = "0x8DB41D0", Offset = "0x8DB35D0", VA = "0x188DB41D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid NAASNOQPNBT
				{
					[Cpp2IlInjected.Token(Token = "0x6000073")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5410", Offset = "0x8DB4810", VA = "0x188DB5410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid VJEXSSKCVWD
				{
					[Cpp2IlInjected.Token(Token = "0x6000074")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5690", Offset = "0x8DB4A90", VA = "0x188DB5690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid TNHKUSLUDXE
				{
					[Cpp2IlInjected.Token(Token = "0x6000075")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6C90", Offset = "0x8DB6090", VA = "0x188DB6C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid KGDLTKFGQIH
				{
					[Cpp2IlInjected.Token(Token = "0x6000076")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6390", Offset = "0x8DB5790", VA = "0x188DB6390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid CDRLCPSLDLE
				{
					[Cpp2IlInjected.Token(Token = "0x6000077")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7390", Offset = "0x8DB6790", VA = "0x188DB7390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid ROKRJQBSOLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000078")]
					[Cpp2IlInjected.Address(RVA = "0x8DBBB10", Offset = "0x8DBAF10", VA = "0x188DBBB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid UMXZECRMBXX
				{
					[Cpp2IlInjected.Token(Token = "0x6000079")]
					[Cpp2IlInjected.Address(RVA = "0x8DADAD0", Offset = "0x8DACED0", VA = "0x188DADAD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid EXLMKUCLLXF
				{
					[Cpp2IlInjected.Token(Token = "0x600007A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8690", Offset = "0x8DB7A90", VA = "0x188DB8690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid MCXJWPDKYHH
				{
					[Cpp2IlInjected.Token(Token = "0x600007B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6A90", Offset = "0x8DB5E90", VA = "0x188DB6A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid PODWNZMZQQK
				{
					[Cpp2IlInjected.Token(Token = "0x600007C")]
					[Cpp2IlInjected.Address(RVA = "0x8DACF50", Offset = "0x8DAC350", VA = "0x188DACF50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid BHIATSMCAUZ
				{
					[Cpp2IlInjected.Token(Token = "0x600007D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1BD0", Offset = "0x8DB0FD0", VA = "0x188DB1BD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid HPFBVJTXIEI
				{
					[Cpp2IlInjected.Token(Token = "0x600007E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3F50", Offset = "0x8DB3350", VA = "0x188DB3F50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid SWKNLGBRHNG
				{
					[Cpp2IlInjected.Token(Token = "0x600007F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8F10", Offset = "0x8DB8310", VA = "0x188DB8F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid LHYSAPZDXIE
				{
					[Cpp2IlInjected.Token(Token = "0x6000080")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0A50", Offset = "0x8DAFE50", VA = "0x188DB0A50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid RAONWWHAWYN
				{
					[Cpp2IlInjected.Token(Token = "0x6000081")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4E90", Offset = "0x8DB4290", VA = "0x188DB4E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid OJVNHKJNOKZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000082")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9410", Offset = "0x8DB8810", VA = "0x188DB9410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid BNOIEDIKSRC
				{
					[Cpp2IlInjected.Token(Token = "0x6000083")]
					[Cpp2IlInjected.Address(RVA = "0x8DADF50", Offset = "0x8DAD350", VA = "0x188DADF50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid AIECDAUOPKL
				{
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD450", Offset = "0x8DAC850", VA = "0x188DAD450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid RILLJGJXYAM
				{
					[Cpp2IlInjected.Token(Token = "0x6000085")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB990", Offset = "0x8DBAD90", VA = "0x188DBB990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid KEAHOSAFIAA
				{
					[Cpp2IlInjected.Token(Token = "0x6000086")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD1D0", Offset = "0x8DAC5D0", VA = "0x188DAD1D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid QPWCBTYJSOH
				{
					[Cpp2IlInjected.Token(Token = "0x6000087")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7790", Offset = "0x8DB6B90", VA = "0x188DB7790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid DKLTZWPPNPN
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFFD0", Offset = "0x8DAF3D0", VA = "0x188DAFFD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid GKNOQUCVRWU
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3B50", Offset = "0x8DB2F50", VA = "0x188DB3B50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid QRIGGWBDVEK
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAF10", Offset = "0x8DBA310", VA = "0x188DBAF10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid BUCXKNVVFEI
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0050", Offset = "0x8DAF450", VA = "0x188DB0050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid YBKIKEQACLH
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9290", Offset = "0x8DB8690", VA = "0x188DB9290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid ISJFCMPYZUE
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6890", Offset = "0x8DB5C90", VA = "0x188DB6890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid DUTHTDCBNTX
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAC10", Offset = "0x8DBA010", VA = "0x188DBAC10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid DUITYPOGUXF
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAB90", Offset = "0x8DB9F90", VA = "0x188DBAB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid DPFZFPUQZUC
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF150", Offset = "0x8DAE550", VA = "0x188DAF150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid DOAJWBFGVEA
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF0D0", Offset = "0x8DAE4D0", VA = "0x188DAF0D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid DOKXQOTBOAS
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF050", Offset = "0x8DAE450", VA = "0x188DAF050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid HBEQZJGFVNE
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0x8DACFD0", Offset = "0x8DAC3D0", VA = "0x188DACFD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid YSDZWPKGHIM
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE050", Offset = "0x8DAD450", VA = "0x188DAE050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid OOWTUBBQCZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB810", Offset = "0x8DBAC10", VA = "0x188DBB810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid NVKLGHRBDOJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0x8DB26D0", Offset = "0x8DB1AD0", VA = "0x188DB26D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid ZUYIZEAYJVC
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8B10", Offset = "0x8DB7F10", VA = "0x188DB8B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid JRCSNMJSMKI
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0CD0", Offset = "0x8DB00D0", VA = "0x188DB0CD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid KSPQCZUYSFN
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAE10", Offset = "0x8DBA210", VA = "0x188DBAE10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid FTSFJYLVPPW
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB550", Offset = "0x8DAA950", VA = "0x188DAB550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid LTQKVLTIPIR
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9510", Offset = "0x8DB8910", VA = "0x188DB9510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid PYYKHJZYWGX
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF9D0", Offset = "0x8DAEDD0", VA = "0x188DAF9D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid HITXJHHVWWZ
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0x8DABFD0", Offset = "0x8DAB3D0", VA = "0x188DABFD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid ZXBZGGCIKBK
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB19D0", Offset = "0x8DB0DD0", VA = "0x188DB19D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid CKYPIEQNCCX
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF8D0", Offset = "0x8DAECD0", VA = "0x188DAF8D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid CYFDJHLANDC
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2E50", Offset = "0x8DB2250", VA = "0x188DB2E50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid XTNUVHEIUHD
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9E10", Offset = "0x8DB9210", VA = "0x188DB9E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid OFIQJEWLKIX
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3850", Offset = "0x8DB2C50", VA = "0x188DB3850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid QLHFZVPGZLO
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0x8DADD50", Offset = "0x8DAD150", VA = "0x188DADD50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid CSWGALYICFB
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8C10", Offset = "0x8DB8010", VA = "0x188DB8C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid GHSXKDNRJZR
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB03D0", Offset = "0x8DAF7D0", VA = "0x188DB03D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid BXJLKEAPIID
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB32D0", Offset = "0x8DB26D0", VA = "0x188DB32D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid VTUHAXAIIVN
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0x8DABCD0", Offset = "0x8DAB0D0", VA = "0x188DABCD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid WHATBANGPFU
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7990", Offset = "0x8DB6D90", VA = "0x188DB7990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid RHWKIPEMHEC
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5090", Offset = "0x8DB4490", VA = "0x188DB5090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid OVTLLEDVDML
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6C10", Offset = "0x8DB6010", VA = "0x188DB6C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid PCTSTGJSTSU
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA390", Offset = "0x8DB9790", VA = "0x188DBA390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid GCBHGFHYZKE
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC3D0", Offset = "0x8DAB7D0", VA = "0x188DAC3D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid BNRXYBVZBQM
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4050", Offset = "0x8DB3450", VA = "0x188DB4050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid CHBEMKQJOXG
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7F90", Offset = "0x8DB7390", VA = "0x188DB7F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid ZOCFBNRHNGJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5590", Offset = "0x8DB4990", VA = "0x188DB5590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid EYNZCNEJSGW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAF90", Offset = "0x8DBA390", VA = "0x188DBAF90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid TOAWUVCQKXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD550", Offset = "0x8DAC950", VA = "0x188DAD550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid BUEBZCUGPDP
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB18D0", Offset = "0x8DB0CD0", VA = "0x188DB18D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid VZBBINKBHCD
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1CD0", Offset = "0x8DB10D0", VA = "0x188DB1CD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid RGMZNTVYRAM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9190", Offset = "0x8DB8590", VA = "0x188DB9190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid NRNNDOHJQNH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB31D0", Offset = "0x8DB25D0", VA = "0x188DB31D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid YMYWOFAQSEG
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9910", Offset = "0x8DB8D10", VA = "0x188DB9910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid EPOVUNSEQIL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEC50", Offset = "0x8DAE050", VA = "0x188DAEC50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid NLXIFSHVGAQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA310", Offset = "0x8DB9710", VA = "0x188DBA310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid BDJOTDDOKQS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB09D0", Offset = "0x8DAFDD0", VA = "0x188DB09D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid JPBPANXTSBE
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4F10", Offset = "0x8DB4310", VA = "0x188DB4F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid CNUBQHGGWIX
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEB50", Offset = "0x8DADF50", VA = "0x188DAEB50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid VWKMTCDLTKW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0x8DB35D0", Offset = "0x8DB29D0", VA = "0x188DB35D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid JVRRXZXMGTV
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB36D0", Offset = "0x8DB2AD0", VA = "0x188DB36D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid KJFDQFPQOXS
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFD50", Offset = "0x8DAF150", VA = "0x188DAFD50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid CHAKIVMQAAD
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5B90", Offset = "0x8DB4F90", VA = "0x188DB5B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid APPVSCNCGNM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB30D0", Offset = "0x8DB24D0", VA = "0x188DB30D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid LSEYEMEMIEA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2450", Offset = "0x8DB1850", VA = "0x188DB2450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid XEIMSLPMTRA
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8510", Offset = "0x8DB7910", VA = "0x188DB8510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid WWKERDEKQXG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6910", Offset = "0x8DB5D10", VA = "0x188DB6910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid EQMBDGFPMLK
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0x8DAED50", Offset = "0x8DAE150", VA = "0x188DAED50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid BNUWODQWQXR
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2DD0", Offset = "0x8DB21D0", VA = "0x188DB2DD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid ALCBJZLOAAS
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4BD0", Offset = "0x8DB3FD0", VA = "0x188DB4BD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid KOUCQUBBVWO
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0x8DACE50", Offset = "0x8DAC250", VA = "0x188DACE50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid ANBCMMNMBTF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9090", Offset = "0x8DB8490", VA = "0x188DB9090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid PCKVNYPDUQS
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8090", Offset = "0x8DB7490", VA = "0x188DB8090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid SORFLFENZPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9A10", Offset = "0x8DB8E10", VA = "0x188DB9A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid HCWORYAPDSO
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7A10", Offset = "0x8DB6E10", VA = "0x188DB7A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid SFBPURIQMRX
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8890", Offset = "0x8DB7C90", VA = "0x188DB8890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid TBNHZCJVWBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6B90", Offset = "0x8DB5F90", VA = "0x188DB6B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid BTKJBLXVTBX
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9C90", Offset = "0x8DB9090", VA = "0x188DB9C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid SVDBQPHQQMK
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB28D0", Offset = "0x8DB1CD0", VA = "0x188DB28D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid OGUAIIKACKA
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB8D0", Offset = "0x8DAACD0", VA = "0x188DAB8D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid ACCPABGLEHV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFF50", Offset = "0x8DAF350", VA = "0x188DAFF50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid FKPSYVJNPYR
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB44D0", Offset = "0x8DB38D0", VA = "0x188DB44D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid SIUGDKAMYSZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEA50", Offset = "0x8DADE50", VA = "0x188DAEA50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid HQBZBEXAHRL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0x8DACCD0", Offset = "0x8DAC0D0", VA = "0x188DACCD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid SJCCDULJCWJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB24D0", Offset = "0x8DB18D0", VA = "0x188DB24D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid MBLMGLBIEMQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0F50", Offset = "0x8DB0350", VA = "0x188DB0F50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid CQDFYALHHVA
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0x8DACAD0", Offset = "0x8DABED0", VA = "0x188DACAD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid CMWOVSVDZIN
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5790", Offset = "0x8DB4B90", VA = "0x188DB5790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid TOKHLHXKRPT
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6190", Offset = "0x8DB5590", VA = "0x188DB6190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid SJAUKENUCED
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4E10", Offset = "0x8DB4210", VA = "0x188DB4E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid GSXRHLVFQQW
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1DD0", Offset = "0x8DB11D0", VA = "0x188DB1DD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid NXEEMLHKEQM
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB610", Offset = "0x8DBAA10", VA = "0x188DBB610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid STKAUEBUATZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9490", Offset = "0x8DB8890", VA = "0x188DB9490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid SOKYASPOZEY
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0x8DB06D0", Offset = "0x8DAFAD0", VA = "0x188DB06D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid ZMTAQXIXSQY
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2F50", Offset = "0x8DB2350", VA = "0x188DB2F50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid NMAYRXWIFGS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5210", Offset = "0x8DB4610", VA = "0x188DB5210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid PQYRVZKPWFP
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5E10", Offset = "0x8DB5210", VA = "0x188DB5E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid GGLSCYKCGTL
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7010", Offset = "0x8DB6410", VA = "0x188DB7010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid NUHTDQAOUNV
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0BD0", Offset = "0x8DAFFD0", VA = "0x188DB0BD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid UGURFMTYYRR
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB38D0", Offset = "0x8DB2CD0", VA = "0x188DB38D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid MGLMEDNINEG
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA610", Offset = "0x8DB9A10", VA = "0x188DBA610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid JVCMYDAKTSW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD2D0", Offset = "0x8DAC6D0", VA = "0x188DAD2D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid TIJTXNSXQNT
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD050", Offset = "0x8DAC450", VA = "0x188DAD050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid CZINLVYRDMN
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9D90", Offset = "0x8DB9190", VA = "0x188DB9D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid EFZAQZGPJVI
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3FD0", Offset = "0x8DB33D0", VA = "0x188DB3FD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid MYEPPKMZNXJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1C50", Offset = "0x8DB1050", VA = "0x188DB1C50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid ZZWZIMZLNJY
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF6D0", Offset = "0x8DAEAD0", VA = "0x188DAF6D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid EBTWRGHOXCL
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9010", Offset = "0x8DB8410", VA = "0x188DB9010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid FPTETCXYEAX
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB790", Offset = "0x8DBAB90", VA = "0x188DBB790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid UTEDVJVVVWM
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE3D0", Offset = "0x8DAD7D0", VA = "0x188DAE3D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid UBNSBYXHRES
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3450", Offset = "0x8DB2850", VA = "0x188DB3450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid AVZLSMWQCKX
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF5D0", Offset = "0x8DAE9D0", VA = "0x188DAF5D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid FMDUVHASTCH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9B10", Offset = "0x8DB8F10", VA = "0x188DB9B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid ZFXQRLCKQOW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8110", Offset = "0x8DB7510", VA = "0x188DB8110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid CWVJFPASQVA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0x8DB00D0", Offset = "0x8DAF4D0", VA = "0x188DB00D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid ZKNMFJCJARQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0x8DAECD0", Offset = "0x8DAE0D0", VA = "0x188DAECD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid JTPUQVFOYRL
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2550", Offset = "0x8DB1950", VA = "0x188DB2550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid OGRMIJIFNFC
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1B50", Offset = "0x8DB0F50", VA = "0x188DB1B50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid THMNCYQILQG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA010", Offset = "0x8DB9410", VA = "0x188DBA010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid LUCRMFJRNWA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD4D0", Offset = "0x8DAC8D0", VA = "0x188DAD4D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid TFSLUCUXGEF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD7D0", Offset = "0x8DACBD0", VA = "0x188DAD7D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid WJFKZZKMHUT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD9D0", Offset = "0x8DACDD0", VA = "0x188DAD9D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid XNWMNSWBUGU
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6790", Offset = "0x8DB5B90", VA = "0x188DB6790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid UCELQYWJORY
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0x8DABED0", Offset = "0x8DAB2D0", VA = "0x188DABED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid QOZEDKTHFDU
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0AD0", Offset = "0x8DAFED0", VA = "0x188DB0AD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid GPLNWQQOMEE
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE750", Offset = "0x8DADB50", VA = "0x188DAE750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid NOYULZPVFGA
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA190", Offset = "0x8DB9590", VA = "0x188DBA190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid WOCXXDSMEZK
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFBD0", Offset = "0x8DAEFD0", VA = "0x188DAFBD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid SQFVVESHXSO
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA590", Offset = "0x8DB9990", VA = "0x188DBA590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid IIMTIFPDLTN
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB6D0", Offset = "0x8DAAAD0", VA = "0x188DAB6D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid GLOWAWLYXWM
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0x8DB45D0", Offset = "0x8DB39D0", VA = "0x188DB45D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid MADEFCVWQXA
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0x8DB07D0", Offset = "0x8DAFBD0", VA = "0x188DB07D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid FHTZGQXVSEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3350", Offset = "0x8DB2750", VA = "0x188DB3350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid YFJPMFHRWDK
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5F90", Offset = "0x8DB5390", VA = "0x188DB5F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid NBCAHDBTJXN
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFAD0", Offset = "0x8DAEED0", VA = "0x188DAFAD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid AXVFTKTEBSX
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF4D0", Offset = "0x8DAE8D0", VA = "0x188DAF4D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid JOXZWFQVUHD
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6410", Offset = "0x8DB5810", VA = "0x188DB6410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid ULRNHCDWTDB
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB010", Offset = "0x8DBA410", VA = "0x188DBB010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid IOLZDYGIKUE
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAA10", Offset = "0x8DB9E10", VA = "0x188DBAA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid UGHTGTNYCEK
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0x8DADDD0", Offset = "0x8DAD1D0", VA = "0x188DADDD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid PKVMXHVUJEK
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB510", Offset = "0x8DBA910", VA = "0x188DBB510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid LLZWSKABGEV
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1AD0", Offset = "0x8DB0ED0", VA = "0x188DB1AD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid IKMBJXUFUMQ
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE650", Offset = "0x8DADA50", VA = "0x188DAE650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid CXYOGXIPHVV
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1050", Offset = "0x8DB0450", VA = "0x188DB1050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid ZFVMRRZSQCU
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB090", Offset = "0x8DBA490", VA = "0x188DBB090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid QNEKGYGUIYW
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF950", Offset = "0x8DAED50", VA = "0x188DAF950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid CHVMUDYUSKT
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0x8DB48D0", Offset = "0x8DB3CD0", VA = "0x188DB48D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid TJORFPURYPJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA510", Offset = "0x8DB9910", VA = "0x188DBA510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid BVGKINXNXQU
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0x8DACED0", Offset = "0x8DAC2D0", VA = "0x188DACED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid OJNTENMXOCG
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0ED0", Offset = "0x8DB02D0", VA = "0x188DB0ED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid GUOZLDXPQJO
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8E10", Offset = "0x8DB8210", VA = "0x188DB8E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid JDWAFLNBJAF
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD350", Offset = "0x8DAC750", VA = "0x188DAD350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid PNILQKZVUWU
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE1D0", Offset = "0x8DAD5D0", VA = "0x188DAE1D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid OABMGWSAFZV
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5C90", Offset = "0x8DB5090", VA = "0x188DB5C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid DXVYHMHVJWB
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5A10", Offset = "0x8DB4E10", VA = "0x188DB5A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid IGBMDQZSFMR
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7B90", Offset = "0x8DB6F90", VA = "0x188DB7B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid YKCNIJIQROA
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8610", Offset = "0x8DB7A10", VA = "0x188DB8610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid TYOICTGYPCW
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0x8DADB50", Offset = "0x8DACF50", VA = "0x188DADB50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid TJWYBXHKBDW
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD650", Offset = "0x8DACA50", VA = "0x188DAD650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid TSWFGHQHUAN
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3250", Offset = "0x8DB2650", VA = "0x188DB3250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid WPPXMKWCDMD
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7E10", Offset = "0x8DB7210", VA = "0x188DB7E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid QRXWLMQOOVE
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6610", Offset = "0x8DB5A10", VA = "0x188DB6610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid SNUCYVQACRA
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3ED0", Offset = "0x8DB32D0", VA = "0x188DB3ED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid NDLNAXLHGZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9710", Offset = "0x8DB8B10", VA = "0x188DB9710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid LUWRCBPHDBY
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2D50", Offset = "0x8DB2150", VA = "0x188DB2D50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid LMTEZHODVOH
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC9D0", Offset = "0x8DABDD0", VA = "0x188DAC9D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid JMSDPPPZNLC
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6E90", Offset = "0x8DB6290", VA = "0x188DB6E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid MMLBBGOJVMQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7F10", Offset = "0x8DB7310", VA = "0x188DB7F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid LJOBJYZIPRV
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9C10", Offset = "0x8DB9010", VA = "0x188DB9C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid XJYCVPFBUBP
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE5D0", Offset = "0x8DAD9D0", VA = "0x188DAE5D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid ONSFCPOBGCA
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5990", Offset = "0x8DB4D90", VA = "0x188DB5990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid QVDYQOIUHSF
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA910", Offset = "0x8DB9D10", VA = "0x188DBA910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid EHUMLFDDHVA
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD250", Offset = "0x8DAC650", VA = "0x188DAD250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid QCADDOXWUUB
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9B90", Offset = "0x8DB8F90", VA = "0x188DB9B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid GQDHXMXAZCS
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC4D0", Offset = "0x8DAB8D0", VA = "0x188DAC4D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid NNPZYMWUZWN
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA110", Offset = "0x8DB9510", VA = "0x188DBA110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid UEPUXFUBQHA
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFCD0", Offset = "0x8DAF0D0", VA = "0x188DAFCD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid NCMYSTUWITZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0x8DADBD0", Offset = "0x8DACFD0", VA = "0x188DADBD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid QTEUDGSUKGY
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0550", Offset = "0x8DAF950", VA = "0x188DB0550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid OYTSMGKCJDP
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7A90", Offset = "0x8DB6E90", VA = "0x188DB7A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid UIYICWSLGOL
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEBD0", Offset = "0x8DADFD0", VA = "0x188DAEBD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid BANRDPBAITE
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3CD0", Offset = "0x8DB30D0", VA = "0x188DB3CD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid KPBNGWLIMQR
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF250", Offset = "0x8DAE650", VA = "0x188DAF250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid BXUUBRRKCNI
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x8DADED0", Offset = "0x8DAD2D0", VA = "0x188DADED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid EYMYRMNUAUN
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE250", Offset = "0x8DAD650", VA = "0x188DAE250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid QSDBSZKOCOI
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB46D0", Offset = "0x8DB3AD0", VA = "0x188DB46D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid VOYTFXEWAYL
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7D90", Offset = "0x8DB7190", VA = "0x188DB7D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid KRNSUHNYJFD
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9F90", Offset = "0x8DB9390", VA = "0x188DB9F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid BCVRQTBWZNX
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3A50", Offset = "0x8DB2E50", VA = "0x188DB3A50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid VYIBYMGSZJN
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2250", Offset = "0x8DB1650", VA = "0x188DB2250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid ZLIDPYYKXPH
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0650", Offset = "0x8DAFA50", VA = "0x188DB0650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid XNKBYZLPRPU
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2B50", Offset = "0x8DB1F50", VA = "0x188DB2B50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid ZKSIYEQSVHG
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0x8DB05D0", Offset = "0x8DAF9D0", VA = "0x188DB05D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid ZKXPVLKQESP
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0x8DB04D0", Offset = "0x8DAF8D0", VA = "0x188DB04D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid VCIMRRPPMVN
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB110", Offset = "0x8DBA510", VA = "0x188DBB110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid MUQQRJAIMJE
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8290", Offset = "0x8DB7690", VA = "0x188DB8290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid MULJUCGLCXV
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8190", Offset = "0x8DB7590", VA = "0x188DB8190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid UXYHWFOMNGL
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x8DBBA10", Offset = "0x8DBAE10", VA = "0x188DBBA10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid GCIHTYXIZPN
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC2D0", Offset = "0x8DAB6D0", VA = "0x188DAC2D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid AAEFOMIUXNG
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x8DACC50", Offset = "0x8DAC050", VA = "0x188DACC50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid NSXMXFIMBCT
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE850", Offset = "0x8DADC50", VA = "0x188DAE850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid YLDVBNZUVCL
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA090", Offset = "0x8DB9490", VA = "0x188DBA090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid HKOMZWLVGLW
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC150", Offset = "0x8DAB550", VA = "0x188DAC150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid BKHRBFGEGEG
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3150", Offset = "0x8DB2550", VA = "0x188DB3150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid TVTROFAZDTC
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8810", Offset = "0x8DB7C10", VA = "0x188DB8810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid ARBZSQRVCWX
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAB10", Offset = "0x8DB9F10", VA = "0x188DBAB10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid IMSUJIZOIJA
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2350", Offset = "0x8DB1750", VA = "0x188DB2350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid BJDFTSXZYEY
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0x8DADC50", Offset = "0x8DAD050", VA = "0x188DADC50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid BACSCPUABZU
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8F90", Offset = "0x8DB8390", VA = "0x188DB8F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid YPMNMOCOBAH
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5810", Offset = "0x8DB4C10", VA = "0x188DB5810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid ERATTMWMXXK
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6D10", Offset = "0x8DB6110", VA = "0x188DB6D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid EWCMILHUZMX
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6490", Offset = "0x8DB5890", VA = "0x188DB6490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid IMNUTPAFPLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9F10", Offset = "0x8DB9310", VA = "0x188DB9F10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid LOGLDJFKSST
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE450", Offset = "0x8DAD850", VA = "0x188DAE450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid SKSFHAAWADI
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0x8DB16D0", Offset = "0x8DB0AD0", VA = "0x188DB16D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid EVGQGMLPLIB
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFA50", Offset = "0x8DAEE50", VA = "0x188DAFA50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid RXPTXURBOOS
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9210", Offset = "0x8DB8610", VA = "0x188DB9210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid TECBYKMPGNB
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD750", Offset = "0x8DACB50", VA = "0x188DAD750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid QHXWZAYDFNQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1250", Offset = "0x8DB0650", VA = "0x188DB1250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid ACQGLFTIZFK
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9790", Offset = "0x8DB8B90", VA = "0x188DB9790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid HJRWESKYVYU
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7090", Offset = "0x8DB6490", VA = "0x188DB7090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid PMBNRFIJMVV
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2BD0", Offset = "0x8DB1FD0", VA = "0x188DB2BD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid WIWFUCFFOTT
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0FD0", Offset = "0x8DB03D0", VA = "0x188DB0FD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid FGHWIHWCFSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEE50", Offset = "0x8DAE250", VA = "0x188DAEE50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid DFYDFOHJPXE
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6B10", Offset = "0x8DB5F10", VA = "0x188DB6B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid WGNNLUYBTEF
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9990", Offset = "0x8DB8D90", VA = "0x188DB9990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid TURLVUPEWDG
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2CD0", Offset = "0x8DB20D0", VA = "0x188DB2CD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid OGLBQSMRLKA
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4750", Offset = "0x8DB3B50", VA = "0x188DB4750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid DAXXGMPZKCE
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0DD0", Offset = "0x8DB01D0", VA = "0x188DB0DD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid WVJDPXMYTXY
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1350", Offset = "0x8DB0750", VA = "0x188DB1350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid VEHLMQIUART
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB450", Offset = "0x8DAA850", VA = "0x188DAB450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid QAJKEMXKBRE
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8990", Offset = "0x8DB7D90", VA = "0x188DB8990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid PNNTHTMBLLE
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7510", Offset = "0x8DB6910", VA = "0x188DB7510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid UJOJWYPYUKC
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6F90", Offset = "0x8DB6390", VA = "0x188DB6F90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid NTWEAFUXKJS
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA810", Offset = "0x8DB9C10", VA = "0x188DBA810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid PVYPLMIGCIU
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC350", Offset = "0x8DAB750", VA = "0x188DAC350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid GAPNVTYWNSY
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2C50", Offset = "0x8DB2050", VA = "0x188DB2C50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid TYVVWTAEOII
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9110", Offset = "0x8DB8510", VA = "0x188DB9110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid WXWWIQTIEGT
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB02D0", Offset = "0x8DAF6D0", VA = "0x188DB02D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid ONJCFGHWVGO
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE4D0", Offset = "0x8DAD8D0", VA = "0x188DAE4D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid KBTSBSIAIXR
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE7D0", Offset = "0x8DADBD0", VA = "0x188DAE7D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid CUJRHGMBXOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0x8DACBD0", Offset = "0x8DABFD0", VA = "0x188DACBD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid AUWNRWKYNTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA410", Offset = "0x8DB9810", VA = "0x188DBA410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid RHOXBXEMSGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8010", Offset = "0x8DB7410", VA = "0x188DB8010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid VVJSXNCQDVL
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE350", Offset = "0x8DAD750", VA = "0x188DAE350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid TUDWJJFGDUG
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0x8DB43D0", Offset = "0x8DB37D0", VA = "0x188DB43D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid YPDNOPLMXEB
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD8D0", Offset = "0x8DACCD0", VA = "0x188DAD8D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid BZMKCQYFYVO
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0x8DB12D0", Offset = "0x8DB06D0", VA = "0x188DB12D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid MXNGVNZDQRP
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4D90", Offset = "0x8DB4190", VA = "0x188DB4D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid QNEOGDGJMME
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF550", Offset = "0x8DAE950", VA = "0x188DAF550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid ADURJNLRKNZ
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3E50", Offset = "0x8DB3250", VA = "0x188DB3E50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid ZWAHFOBAJGG
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0x8DAFE50", Offset = "0x8DAF250", VA = "0x188DAFE50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid COLAKOCQAIC
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3AD0", Offset = "0x8DB2ED0", VA = "0x188DB3AD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid HXSSRVNOTMY
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6010", Offset = "0x8DB5410", VA = "0x188DB6010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid VZCTMZSKKVB
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2650", Offset = "0x8DB1A50", VA = "0x188DB2650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid MSOKQZGFLDD
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3050", Offset = "0x8DB2450", VA = "0x188DB3050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid JDFLGONGBAD
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7310", Offset = "0x8DB6710", VA = "0x188DB7310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid WFOMRSSWANW
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2FD0", Offset = "0x8DB23D0", VA = "0x188DB2FD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid QMTYDANGTFE
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAC90", Offset = "0x8DBA090", VA = "0x188DBAC90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid FBNTHXZZSWB
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7590", Offset = "0x8DB6990", VA = "0x188DB7590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid HDQGISZPLGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4550", Offset = "0x8DB3950", VA = "0x188DB4550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid JSKPGFASJAH
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAD10", Offset = "0x8DBA110", VA = "0x188DBAD10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid LOWCWGNTNIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB890", Offset = "0x8DBAC90", VA = "0x188DBB890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid DJEFKCLLPGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC850", Offset = "0x8DABC50", VA = "0x188DAC850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid GPJDXJZUPZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7110", Offset = "0x8DB6510", VA = "0x188DB7110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid VDOKVMCZFEL
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5010", Offset = "0x8DB4410", VA = "0x188DB5010")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid CSXLIHOKMLL
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5610", Offset = "0x8DB4A10", VA = "0x188DB5610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid HSQEABJHEXM
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7B10", Offset = "0x8DB6F10", VA = "0x188DB7B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid ZRKXHSWLDUI
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8310", Offset = "0x8DB7710", VA = "0x188DB8310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid RUAKKFGWKDV
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7690", Offset = "0x8DB6A90", VA = "0x188DB7690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid TGPIUWOBTUH
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1850", Offset = "0x8DB0C50", VA = "0x188DB1850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid JDYGZZCATEX
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7C90", Offset = "0x8DB7090", VA = "0x188DB7C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid RMRRPNNSIOS
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9E90", Offset = "0x8DB9290", VA = "0x188DB9E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid GIOBMKYEQSS
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAD90", Offset = "0x8DBA190", VA = "0x188DBAD90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid VHEOQBJBGYR
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0x8DADE50", Offset = "0x8DAD250", VA = "0x188DADE50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid UHDAPDNOHAV
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1450", Offset = "0x8DB0850", VA = "0x188DB1450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid CKPCJRBLFLE
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB590", Offset = "0x8DBA990", VA = "0x188DBB590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid FQYQBAKEMQL
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6310", Offset = "0x8DB5710", VA = "0x188DB6310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid PFUGDQDTSAX
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0x8DB17D0", Offset = "0x8DB0BD0", VA = "0x188DB17D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid SYSFIZJPJCI
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4A50", Offset = "0x8DB3E50", VA = "0x188DB4A50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid SIPNVIWOWCV
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC650", Offset = "0x8DABA50", VA = "0x188DAC650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid URLNKSEMRYZ
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD150", Offset = "0x8DAC550", VA = "0x188DAD150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid COBUBLJKZPJ
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF450", Offset = "0x8DAE850", VA = "0x188DAF450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid GKFYJPSUVLZ
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB410", Offset = "0x8DBA810", VA = "0x188DBB410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid PXSNCUXMTXL
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4B50", Offset = "0x8DB3F50", VA = "0x188DB4B50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid MVRKYGSMIME
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB490", Offset = "0x8DBA890", VA = "0x188DBB490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid GMMZDFLUSDI
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE150", Offset = "0x8DAD550", VA = "0x188DAE150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid VWJDJDZYWTZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB37D0", Offset = "0x8DB2BD0", VA = "0x188DB37D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid RWYCDTSVJYQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD6D0", Offset = "0x8DACAD0", VA = "0x188DAD6D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid KVBFYXNVYDC
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF7D0", Offset = "0x8DAEBD0", VA = "0x188DAF7D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid RWZMWBSZIGF
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB690", Offset = "0x8DBAA90", VA = "0x188DBB690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid XIMTRFWQMSG
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6690", Offset = "0x8DB5A90", VA = "0x188DB6690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid NPPZYMIUQZU
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB950", Offset = "0x8DAAD50", VA = "0x188DAB950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid BTQJTZAGXQC
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1E50", Offset = "0x8DB1250", VA = "0x188DB1E50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid ZZVUACUTSUX
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4250", Offset = "0x8DB3650", VA = "0x188DB4250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid SOCCUCTAKHY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF2D0", Offset = "0x8DAE6D0", VA = "0x188DAF2D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid TOKHCJJHANK
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7E90", Offset = "0x8DB7290", VA = "0x188DB7E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid JEXXQCFTANX
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2750", Offset = "0x8DB1B50", VA = "0x188DB2750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid ZJOUGVSBUEU
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9610", Offset = "0x8DB8A10", VA = "0x188DB9610")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid VNKPFJWKULD
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0x8DABE50", Offset = "0x8DAB250", VA = "0x188DABE50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid TELCEYQXMDF
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5910", Offset = "0x8DB4D10", VA = "0x188DB5910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid RSJAWWOBRYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0x8DABC50", Offset = "0x8DAB050", VA = "0x188DABC50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid SJPOUQIANWS
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3750", Offset = "0x8DB2B50", VA = "0x188DB3750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid LHETZFEGTNK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB25D0", Offset = "0x8DB19D0", VA = "0x188DB25D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid WLCERWDRYXQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB11D0", Offset = "0x8DB05D0", VA = "0x188DB11D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid GYIOXQAHAKE
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE0D0", Offset = "0x8DAD4D0", VA = "0x188DAE0D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid ELLFMETKTLM
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0x8DADA50", Offset = "0x8DACE50", VA = "0x188DADA50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid LOMUPLLXRGO
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0x8DACB50", Offset = "0x8DABF50", VA = "0x188DACB50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid QTZXFNNVOBM
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7D10", Offset = "0x8DB7110", VA = "0x188DB7D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid KVEPXABUDXA
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB22D0", Offset = "0x8DB16D0", VA = "0x188DB22D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid FHNRDNWFDML
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEF50", Offset = "0x8DAE350", VA = "0x188DAEF50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid CGPNLVREUTF
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB390", Offset = "0x8DBA790", VA = "0x188DBB390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid GAHILJFMYGU
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x8DABAD0", Offset = "0x8DAAED0", VA = "0x188DABAD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid JRJVEOFKIVO
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0x8DADFD0", Offset = "0x8DAD3D0", VA = "0x188DADFD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid CLWKRDMFAJS
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7410", Offset = "0x8DB6810", VA = "0x188DB7410")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid QRFLJIRUGSB
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3550", Offset = "0x8DB2950", VA = "0x188DB3550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid ZJQYDJNGDGG
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8B90", Offset = "0x8DB7F90", VA = "0x188DB8B90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid GNOQZGQPTEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA990", Offset = "0x8DB9D90", VA = "0x188DBA990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid CDNNIKOMYDX
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6590", Offset = "0x8DB5990", VA = "0x188DB6590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid FXFRYJBLCOJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5390", Offset = "0x8DB4790", VA = "0x188DB5390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid FKRTPVEAFZF
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF1D0", Offset = "0x8DAE5D0", VA = "0x188DAF1D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid ANWZUXSFUAV
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1750", Offset = "0x8DB0B50", VA = "0x188DB1750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid XOBBLXHCSYG
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF650", Offset = "0x8DAEA50", VA = "0x188DAF650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid OEJNMNCRBEC
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5110", Offset = "0x8DB4510", VA = "0x188DB5110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid QIAOUWVNRGU
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB7D0", Offset = "0x8DAABD0", VA = "0x188DAB7D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid SGSWMZDFCDH
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB710", Offset = "0x8DBAB10", VA = "0x188DBB710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid JTQZCAMSAKW
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0x8DB27D0", Offset = "0x8DB1BD0", VA = "0x188DB27D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid NWZIOHQYJQV
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7C10", Offset = "0x8DB7010", VA = "0x188DB7C10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid FUNAPFMQPHK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0450", Offset = "0x8DAF850", VA = "0x188DB0450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid FOHOJHYEITN
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6810", Offset = "0x8DB5C10", VA = "0x188DB6810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid GXWSVWAFYHO
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6090", Offset = "0x8DB5490", VA = "0x188DB6090")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid DBCJPOXGBDV
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB910", Offset = "0x8DBAD10", VA = "0x188DBB910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid BLSMKESCWVO
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE6D0", Offset = "0x8DADAD0", VA = "0x188DAE6D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid SHYAEYZELBS
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB290", Offset = "0x8DBA690", VA = "0x188DBB290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid NPDULQFDZAX
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1550", Offset = "0x8DB0950", VA = "0x188DB1550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid THSKILVXHLJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5490", Offset = "0x8DB4890", VA = "0x188DB5490")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid AABQVEGBIAM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4D10", Offset = "0x8DB4110", VA = "0x188DB4D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid ZNDZAJUXESQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9390", Offset = "0x8DB8790", VA = "0x188DB9390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid TYCWAYHRIIA
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8210", Offset = "0x8DB7610", VA = "0x188DB8210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid LSGHQAHNHTF
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC750", Offset = "0x8DABB50", VA = "0x188DAC750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid LRFZDSMAMOM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC6D0", Offset = "0x8DABAD0", VA = "0x188DAC6D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid POIUQISNWWG
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1D50", Offset = "0x8DB1150", VA = "0x188DB1D50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid WDPIGZJZOVN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAA90", Offset = "0x8DB9E90", VA = "0x188DBAA90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid PWGDASFGLXV
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6110", Offset = "0x8DB5510", VA = "0x188DB6110")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid MHTNOKQGXZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0x8DACDD0", Offset = "0x8DAC1D0", VA = "0x188DACDD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid MVKAESOWHVL
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5D10", Offset = "0x8DB5110", VA = "0x188DB5D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid GMKQBZPHUGL
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC1D0", Offset = "0x8DAB5D0", VA = "0x188DAC1D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid UPRSQHAEMGO
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0x8DBB190", Offset = "0x8DBA590", VA = "0x188DBB190")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid LZUCKYAJSTD
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB29D0", Offset = "0x8DB1DD0", VA = "0x188DB29D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid LHHGAHKTJIR
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8590", Offset = "0x8DB7990", VA = "0x188DB8590")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid WYRIXBZBRYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEAD0", Offset = "0x8DADED0", VA = "0x188DAEAD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid NSHGBDVNEJL
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8A90", Offset = "0x8DB7E90", VA = "0x188DB8A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid IBKBBDTBUYQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE8D0", Offset = "0x8DADCD0", VA = "0x188DAE8D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid GDKRJIRAMNP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB40D0", Offset = "0x8DB34D0", VA = "0x188DB40D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid NIHCOFIWTXG
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA710", Offset = "0x8DB9B10", VA = "0x188DBA710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid EGAZBBVITHT
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3650", Offset = "0x8DB2A50", VA = "0x188DB3650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid UUBMQPJUERW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC950", Offset = "0x8DABD50", VA = "0x188DAC950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid JOOBLHJSSCM
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0950", Offset = "0x8DAFD50", VA = "0x188DB0950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid EDRBQWSVAGY
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE2D0", Offset = "0x8DAD6D0", VA = "0x188DAE2D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid RFAXFNCWRDU
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB9D0", Offset = "0x8DAADD0", VA = "0x188DAB9D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid MLGXADJBIAB
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0850", Offset = "0x8DAFC50", VA = "0x188DB0850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid FTHOETLFMSF
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0150", Offset = "0x8DAF550", VA = "0x188DB0150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid QWOKCTTFJJC
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC050", Offset = "0x8DAB450", VA = "0x188DAC050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid ZXMXNSIQMNX
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC550", Offset = "0x8DAB950", VA = "0x188DAC550")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid AYWMPPEWIBA
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEDD0", Offset = "0x8DAE1D0", VA = "0x188DAEDD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid BWEFQDYBYJZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0250", Offset = "0x8DAF650", VA = "0x188DB0250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid YJYGPJVOOLT
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5E90", Offset = "0x8DB5290", VA = "0x188DB5E90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid LDKKFALQLSS
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB5D0", Offset = "0x8DAA9D0", VA = "0x188DAB5D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid XSRRHVQBZIY
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9890", Offset = "0x8DB8C90", VA = "0x188DB9890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid DLHMUDFKXMB
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0x8DB34D0", Offset = "0x8DB28D0", VA = "0x188DB34D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid PMXCHHTMAAM
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC0D0", Offset = "0x8DAB4D0", VA = "0x188DAC0D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid YGRHGZEUAEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0x8DB23D0", Offset = "0x8DB17D0", VA = "0x188DB23D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid XILXGXMGFEA
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1150", Offset = "0x8DB0550", VA = "0x188DB1150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid ANLIAQIPDBB
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0x8DABBD0", Offset = "0x8DAAFD0", VA = "0x188DABBD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid GHEFICLKQOU
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0D50", Offset = "0x8DB0150", VA = "0x188DB0D50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid PHPLIUFHFXK
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9310", Offset = "0x8DB8710", VA = "0x188DB9310")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid KUQSDJIUIPA
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0x8DB13D0", Offset = "0x8DB07D0", VA = "0x188DB13D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid QEEJRCHDWDK
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0B50", Offset = "0x8DAFF50", VA = "0x188DB0B50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid GZWFVZXGYJL
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6D90", Offset = "0x8DB6190", VA = "0x188DB6D90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid GIAUGGAQSXL
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6A10", Offset = "0x8DB5E10", VA = "0x188DB6A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid EABVVPZRZEW
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2950", Offset = "0x8DB1D50", VA = "0x188DB2950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid YLSAFXMHXFI
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEFD0", Offset = "0x8DAE3D0", VA = "0x188DAEFD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid DRNOIMWQGSZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6990", Offset = "0x8DB5D90", VA = "0x188DB6990")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid HZMQLPSYFBC
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4150", Offset = "0x8DB3550", VA = "0x188DB4150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid OJFIZUDVRXY
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3DD0", Offset = "0x8DB31D0", VA = "0x188DB3DD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid LZUVBWBVLQM
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7290", Offset = "0x8DB6690", VA = "0x188DB7290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid ADZVKTVGBWI
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8790", Offset = "0x8DB7B90", VA = "0x188DB8790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid VUBXFMSECFG
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2050", Offset = "0x8DB1450", VA = "0x188DB2050")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid YKXERXBAXEA
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0x8DBAE90", Offset = "0x8DBA290", VA = "0x188DBAE90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid KVNAEUMYDVR
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6710", Offset = "0x8DB5B10", VA = "0x188DB6710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid BUPBMKWQCIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8710", Offset = "0x8DB7B10", VA = "0x188DB8710")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid LMYCQKITUUB
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0x8DAF350", Offset = "0x8DAE750", VA = "0x188DAF350")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid WGEPGGCGUHR
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9D10", Offset = "0x8DB9110", VA = "0x188DB9D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid ZFGBUOKMMFZ
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6290", Offset = "0x8DB5690", VA = "0x188DB6290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid SQZZGMRWOGF
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1A50", Offset = "0x8DB0E50", VA = "0x188DB1A50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid FUDVFKEAZWG
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD3D0", Offset = "0x8DAC7D0", VA = "0x188DAD3D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid EZGBFJJNUVD
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1950", Offset = "0x8DB0D50", VA = "0x188DB1950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid EINSGWQYWPY
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0x8DAEED0", Offset = "0x8DAE2D0", VA = "0x188DAEED0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid KYPKCHKDORV
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB850", Offset = "0x8DAAC50", VA = "0x188DAB850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid TNKFEWZRHFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8910", Offset = "0x8DB7D10", VA = "0x188DB8910")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid WALGMIDODDF
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC250", Offset = "0x8DAB650", VA = "0x188DAC250")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid EPIBUHSNUUI
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0x8DB15D0", Offset = "0x8DB09D0", VA = "0x188DB15D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid ZBJKWKCPSLD
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0x8DB08D0", Offset = "0x8DAFCD0", VA = "0x188DB08D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid ZUMETNMYOQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8D10", Offset = "0x8DB8110", VA = "0x188DB8D10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid TIKPEXCKVHZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8390", Offset = "0x8DB7790", VA = "0x188DB8390")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid OZUQAZGPABR
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0x8DB20D0", Offset = "0x8DB14D0", VA = "0x188DB20D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid TVUAFZESMSX
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC5D0", Offset = "0x8DAB9D0", VA = "0x188DAC5D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid CMFEEXYTZTE
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0x8DB8A10", Offset = "0x8DB7E10", VA = "0x188DB8A10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid SWLLWSZSLFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0x8DB47D0", Offset = "0x8DB3BD0", VA = "0x188DB47D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid OLXLSWHGXSC
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1FD0", Offset = "0x8DB13D0", VA = "0x188DB1FD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid VPPHDNGJJDD
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6210", Offset = "0x8DB5610", VA = "0x188DB6210")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid OUXYJPBXYVB
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6510", Offset = "0x8DB5910", VA = "0x188DB6510")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid PAPXTHRPGKP
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0x8DAE950", Offset = "0x8DADD50", VA = "0x188DAE950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid PQVUAACPDUX
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5290", Offset = "0x8DB4690", VA = "0x188DB5290")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid YIFQUPJFRHL
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5B10", Offset = "0x8DB4F10", VA = "0x188DB5B10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid ZIGWEBRRYAP
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0x8DB0750", Offset = "0x8DAFB50", VA = "0x188DB0750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid MVKSFVYAPAG
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA890", Offset = "0x8DB9C90", VA = "0x188DBA890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid VQKNUDICJLX
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0x8DB3BD0", Offset = "0x8DB2FD0", VA = "0x188DB3BD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid ZCFPLUXBJTK
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0x8DB1F50", Offset = "0x8DB1350", VA = "0x188DB1F50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid OPSJVESDSMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0x8DACA50", Offset = "0x8DABE50", VA = "0x188DACA50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid POTIHEZLXRR
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0x8DABDD0", Offset = "0x8DAB1D0", VA = "0x188DABDD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid XBIGSMRFSZY
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0x8DACD50", Offset = "0x8DAC150", VA = "0x188DACD50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid VSKFFGJIIDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4450", Offset = "0x8DB3850", VA = "0x188DB4450")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid EGMWFWFRFVL
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4950", Offset = "0x8DB3D50", VA = "0x188DB4950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid UNFBLIORZCV
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB750", Offset = "0x8DAAB50", VA = "0x188DAB750")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid CQSPEITRVGC
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2850", Offset = "0x8DB1C50", VA = "0x188DB2850")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid UMFSANLZMTV
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0x8DB42D0", Offset = "0x8DB36D0", VA = "0x188DB42D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid FUFKDTMPKRN
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0x8DB6E10", Offset = "0x8DB6210", VA = "0x188DB6E10")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid PQVCODZICXX
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0x8DB4C90", Offset = "0x8DB4090", VA = "0x188DB4C90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid PIIAIBTBJVK
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA690", Offset = "0x8DB9A90", VA = "0x188DBA690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid BZDNFDFDGLA
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0x8DB2150", Offset = "0x8DB1550", VA = "0x188DB2150")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid BASQJIKSHRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0x8DABD50", Offset = "0x8DAB150", VA = "0x188DABD50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid MYKKHVIDUHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0x8DABA50", Offset = "0x8DAAE50", VA = "0x188DABA50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid FLLWKPLVQDK
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0x8DB5A90", Offset = "0x8DB4E90", VA = "0x188DB5A90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid EAEMMFPQAIQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7810", Offset = "0x8DB6C10", VA = "0x188DB7810")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid EAUHDZXICQR
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0x8DB7890", Offset = "0x8DB6C90", VA = "0x188DB7890")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid EYEIIAZRNPI
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0x8DBA790", Offset = "0x8DB9B90", VA = "0x188DBA790")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid QODRPWZVKNR
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0x8DB9690", Offset = "0x8DB8A90", VA = "0x188DB9690")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid HCVWHQIZZYB
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0x8DAC7D0", Offset = "0x8DABBD0", VA = "0x188DAC7D0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid BONDYRVXRJD
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0x8DAB650", Offset = "0x8DAAA50", VA = "0x188DAB650")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid PASSQYDXGYG
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0x8DAD950", Offset = "0x8DACD50", VA = "0x188DAD950")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid ILRCBNXULTX
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0x8DBBB90", Offset = "0x8DBAF90", VA = "0x188DBBB90")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid HKYDWSEPMUI
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0x8DADCD0", Offset = "0x8DAD0D0", VA = "0x188DADCD0")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8DA73F0", Offset = "0x8DA67F0", VA = "0x188DA73F0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1290", Offset = "0x8DA0690", VA = "0x188DA1290")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> NGEDXZFYEVW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class QWQQBWVZRLK
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC59B0", Offset = "0x8DC4DB0", VA = "0x188DC59B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class XWXHGBQHOHB
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x8DC5F80", Offset = "0x8DC5380", VA = "0x188DC5F80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class ESMVVGUYCBT
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8DBD590", Offset = "0x8DBC990", VA = "0x188DBD590")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class IZDHUFLOQLA
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private static readonly Dictionary<Guid, float> ONWYZRLBGUK;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private static readonly Dictionary<Guid, float> TUJQDPUEOZV;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private static readonly Dictionary<Guid, bool> UKMHHSDJVEA;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8DBD9D0", Offset = "0x8DBCDD0", VA = "0x188DBD9D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class IZIORMFLZWJ
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private static readonly Dictionary<Guid, float> AXKCZQFGNSX;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private static readonly Dictionary<Guid, float> BDIGPRVYMSG;

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8DBF810", Offset = "0x8DBEC10", VA = "0x188DBF810")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class LZXHGONLYVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2A10", Offset = "0x8DC1E10", VA = "0x188DC2A10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class QAFANLHLZAB
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private static readonly Dictionary<Guid, int> XHMFNCTXTRT;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private static readonly Dictionary<Guid, bool> VZODTMOKWNT;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private static readonly Dictionary<Guid, bool> MKLXQJMIITY;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private static readonly Dictionary<Guid, int> FMSFBZIKGRU;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private static readonly Dictionary<Guid, bool> VUFETZWEWJX;

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2D90", Offset = "0x8DC2190", VA = "0x188DC2D90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class PZUMSXTRGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2BD0", Offset = "0x8DC1FD0", VA = "0x188DC2BD0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<VUJTJJOWWBJ, PersistedRoomData, PersistedRoomVersion> QVIHUVKQAJI;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Dictionary<Guid, int> IITEYEMBVLT;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Guid ODKHMTJUYKD;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Guid QKOVWSQOSFL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly float CUINLCLXZOJ;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C440", Offset = "0x8D8B840", VA = "0x188D8C440")]
		public static PersistedRoomData TUNINPMWIVY(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BB40", Offset = "0x8D8AF40", VA = "0x188D8BB40")]
		public static Result<ParseResult<PersistedRoomData>, NBILMTLEEJL> FHIAMXOSVKY(VUJTJJOWWBJ a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BC70", Offset = "0x8D8B070", VA = "0x188D8BC70")]
		public static Result<ParseResult<PersistedRoomData>, NBILMTLEEJL> FHIAMXOSVKY(VUJTJJOWWBJ a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C020", Offset = "0x8D8B420", VA = "0x188D8C020")]
		public static Result<None, NBILMTLEEJL> JNKTTISNOAZ(VUJTJJOWWBJ a, PersistedRoomData b)
		{
			return default(Result<None, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C360", Offset = "0x8D8B760", VA = "0x188D8C360")]
		public static Guid QHFFNRKWHTI(EQKDAXAXTVB a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class JNZBZQNVDAS
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public interface VUJTJJOWWBJ : GORVDLHLGVR<ZBEHYKVOKWC, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public sealed class AVQHDSVSHCE : VUJTJJOWWBJ, GORVDLHLGVR<ZBEHYKVOKWC, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static AVQHDSVSHCE ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			public PlayerSaveVersion MQUXSWYUJNT()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xB87E50", Offset = "0xB87250", VA = "0x180B87E50", Slot = "5")]
			public PlayerSaveVersion KEWCHRQDFBB()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1807A10", Offset = "0x1806E10", VA = "0x181807A10", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D790", Offset = "0x2C4CB90", VA = "0x182C4D790", Slot = "7")]
			public bool AHSAYKOIMSM(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8DBBC10", Offset = "0x8DBB010", VA = "0x188DBBC10", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public AVQHDSVSHCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private static Versioner<VUJTJJOWWBJ, ZBEHYKVOKWC, PlayerSaveVersion> QVIHUVKQAJI;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1860", Offset = "0x8DC0C60", VA = "0x188DC1860")]
		public static ZBEHYKVOKWC? LZZGEXDYVCU([Optional] UJQZCTTXRFK? a, [Optional] RBOZBEIVXKI? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1250", Offset = "0x8DC0650", VA = "0x188DC1250")]
		public static Result<ParseResult<ZBEHYKVOKWC>, NBILMTLEEJL> FHIAMXOSVKY(VUJTJJOWWBJ a, byte[]? bytes)
		{
			return default(Result<ParseResult<ZBEHYKVOKWC>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0DD0", Offset = "0x8DC01D0", VA = "0x188DC0DD0")]
		public static Result<ParseResult<ZBEHYKVOKWC>, NBILMTLEEJL> FHIAMXOSVKY(VUJTJJOWWBJ deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<ZBEHYKVOKWC>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1700", Offset = "0x8DC0B00", VA = "0x188DC1700")]
		public static Result<None, NBILMTLEEJL> JNKTTISNOAZ(VUJTJJOWWBJ a, ZBEHYKVOKWC b)
		{
			return default(Result<None, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1AF0", Offset = "0x8DC0EF0", VA = "0x188DC1AF0")]
		public static void MBNKKQQQWHZ(ZBEHYKVOKWC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1DF0", Offset = "0x8DC11F0", VA = "0x188DC1DF0")]
		public static void MBSRHXKOFTI(ZBEHYKVOKWC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2030", Offset = "0x8DC1430", VA = "0x188DC2030")]
		public static void MBXYFEELPER(ZBEHYKVOKWC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1950", Offset = "0x8DC0D50", VA = "0x188DC1950")]
		public static void MANBYIVEBDG(ZBEHYKVOKWC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1A80", Offset = "0x8DC0E80", VA = "0x188DC1A80")]
		public static void MASIVPPBKOP(ZBEHYKVOKWC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1540", Offset = "0x8DC0940", VA = "0x188DC1540")]
		private static RBOZBEIVXKI ITJLYOWOMVE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1620", Offset = "0x8DC0A20", VA = "0x188DC1620")]
		private static RBOZBEIVXKI ITOSVVQLWGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2500", Offset = "0x8DC1900", VA = "0x188DC2500")]
		[CompilerGenerated]
		internal static bool SIQJBUOJGIB(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2530", Offset = "0x8DC1930", VA = "0x188DC2530")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD SLJZMWVIPYP(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8DC24D0", Offset = "0x8DC18D0", VA = "0x188DC24D0")]
		[CompilerGenerated]
		internal static float RARXNAOJTIX(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2780", Offset = "0x8DC1B80", VA = "0x188DC2780")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD ZQRKHFKLXMT(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1830", Offset = "0x8DC0C30", VA = "0x188DC1830")]
		[CompilerGenerated]
		internal static int KJEPSXUZVCC(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2640", Offset = "0x8DC1A40", VA = "0x188DC2640")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD WWICNSXWRWO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8DC26B0", Offset = "0x8DC1AB0", VA = "0x188DC26B0")]
		[CompilerGenerated]
		internal static CircuitsQuat XQTQSMPKHGT(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC25C0", Offset = "0x8DC19C0", VA = "0x188DC25C0")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD VVYFYLLZATL(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC25A0", Offset = "0x8DC19A0", VA = "0x188DC25A0")]
		[CompilerGenerated]
		internal static string TIFTDVDRRWQ(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC14D0", Offset = "0x8DC08D0", VA = "0x188DC14D0")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD IMMXSWWAMIC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC13F0", Offset = "0x8DC07F0", VA = "0x188DC13F0")]
		[CompilerGenerated]
		internal static CircuitsVec3 IFFGUPETQWE(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0CB0", Offset = "0x8DC00B0", VA = "0x188DC0CB0")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD AAKAKZXKJMS(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1380", Offset = "0x8DC0780", VA = "0x188DC1380")]
		[CompilerGenerated]
		internal static int GJYHDNDNURV(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0D30", Offset = "0x8DC0130", VA = "0x188DC0D30")]
		[CompilerGenerated]
		internal static QDYLFEOXBWD BTISWBTVPVP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3743400", Offset = "0x3742800", VA = "0x183743400")]
		[CompilerGenerated]
		internal static void IBAMXEWSTLH<a>(RepeatedField<OWLHDWQEQKE> a, Func<ByteString, a> deserialize, Func<a, QDYLFEOXBWD> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class BNWXMYFKDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC2A0", Offset = "0x8DBB6A0", VA = "0x188DBC2A0")]
		public static CIWNYAZZECE JXIJMWPOFEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBBD90", Offset = "0x8DBB190", VA = "0x188DBBD90")]
		public static Result<ParseResult<CIWNYAZZECE>, NBILMTLEEJL> FHIAMXOSVKY(JTLQATILOJG.VUJTJJOWWBJ a, byte[] b)
		{
			return default(Result<ParseResult<CIWNYAZZECE>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8DBBE80", Offset = "0x8DBB280", VA = "0x188DBBE80")]
		public static Result<ParseResult<CIWNYAZZECE>, NBILMTLEEJL> FHIAMXOSVKY(JTLQATILOJG.VUJTJJOWWBJ a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<CIWNYAZZECE>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC1D0", Offset = "0x8DBB5D0", VA = "0x188DBC1D0")]
		public static Result<None, NBILMTLEEJL> JNKTTISNOAZ(JTLQATILOJG.VUJTJJOWWBJ a, CIWNYAZZECE b)
		{
			return default(Result<None, NBILMTLEEJL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class ASBTWVRNDQD
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB010", Offset = "0x8DAA410", VA = "0x188DAB010")]
		public static SpawnableTemplateData OFZJEVTAFIZ([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAA80", Offset = "0x8DA9E80", VA = "0x188DAAA80")]
		public static Result<ParseResult<SpawnableTemplateData>, NBILMTLEEJL> FHIAMXOSVKY(JTLQATILOJG.VUJTJJOWWBJ a, CBYEQCUGMWS.VUJTJJOWWBJ b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8DAADA0", Offset = "0x8DAA1A0", VA = "0x188DAADA0")]
		public static Result<None, NBILMTLEEJL> JNKTTISNOAZ(JTLQATILOJG.VUJTJJOWWBJ a, CBYEQCUGMWS.VUJTJJOWWBJ b, SpawnableTemplateData c)
		{
			return default(Result<None, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB090", Offset = "0x8DAA490", VA = "0x188DAB090")]
		private static Result<None, NBILMTLEEJL> WYGRQZTTHMV(JTLQATILOJG.VUJTJJOWWBJ a, SpawnableTemplateData b)
		{
			return default(Result<None, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA8E0", Offset = "0x8DA9CE0", VA = "0x188DAA8E0")]
		private static Result<None, NBILMTLEEJL> COOKRTGVOVB(CBYEQCUGMWS.VUJTJJOWWBJ a, SpawnableTemplateData b)
		{
			return default(Result<None, NBILMTLEEJL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class CBYEQCUGMWS
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public interface VUJTJJOWWBJ : GORVDLHLGVR<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public sealed class AVQHDSVSHCE : VUJTJJOWWBJ, GORVDLHLGVR<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static AVQHDSVSHCE ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			public SuperRoomVersion MQUXSWYUJNT()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB78A10", Offset = "0xB77E10", VA = "0x180B78A10", Slot = "5")]
			public SuperRoomVersion KEWCHRQDFBB()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x1807A10", Offset = "0x1806E10", VA = "0x181807A10", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x2C4D790", Offset = "0x2C4CB90", VA = "0x182C4D790", Slot = "7")]
			public bool AHSAYKOIMSM(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8DBBC60", Offset = "0x8DBB060", VA = "0x188DBBC60", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public AVQHDSVSHCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static Versioner<VUJTJJOWWBJ, SuperRoomData, SuperRoomVersion> QVIHUVKQAJI;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC820", Offset = "0x8DBBC20", VA = "0x188DBC820")]
		public static SuperRoomData KQQRFHLCRAM([Optional] ZQTUGCQNYYO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC2F0", Offset = "0x8DBB6F0", VA = "0x188DBC2F0")]
		public static Result<ParseResult<SuperRoomData>, NBILMTLEEJL> FHIAMXOSVKY(VUJTJJOWWBJ a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC420", Offset = "0x8DBB820", VA = "0x188DBC420")]
		public static Result<ParseResult<SuperRoomData>, NBILMTLEEJL> FHIAMXOSVKY(VUJTJJOWWBJ a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC6F0", Offset = "0x8DBBAF0", VA = "0x188DBC6F0")]
		public static Result<None, NBILMTLEEJL> JNKTTISNOAZ(VUJTJJOWWBJ a, SuperRoomData b)
		{
			return default(Result<None, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC9A0", Offset = "0x8DBBDA0", VA = "0x188DBC9A0")]
		private static void MBNKKQQQWHZ(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCB60", Offset = "0x8DBBF60", VA = "0x188DBCB60")]
		private static void MBSRHXKOFTI(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCC60", Offset = "0x8DBC060", VA = "0x188DBCC60")]
		private static void MBXYFEELPER(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC920", Offset = "0x8DBBD20", VA = "0x188DBC920")]
		private static void MANBYIVEBDG(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCF00", Offset = "0x8DBC300", VA = "0x188DBCF00")]
		public static DataTableData WWGWOGXNXOD(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCCF0", Offset = "0x8DBC0F0", VA = "0x188DBCCF0")]
		public static ProgressionManagerData NHHVTADFNPG(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD210", Offset = "0x8DBC610", VA = "0x188DBD210")]
		[CompilerGenerated]
		internal static void ZAUCNHSNIWG(RepeatedField<BQJWYBCFMHQ> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class IOSHLQFUNMK : XEVVKEKTFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD9A0", Offset = "0x8DBCDA0", VA = "0x188DBD9A0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3F0", Offset = "0x28E97F0", VA = "0x1828EA3F0")]
		public IOSHLQFUNMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface GORVDLHLGVR<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b MQUXSWYUJNT();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b KEWCHRQDFBB();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AHSAYKOIMSM(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class IJRMMBIMETM : XEVVKEKTFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private string MKAJDVYWTFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private string DASZROIGRAR;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD950", Offset = "0x8DBCD50", VA = "0x188DBD950")]
		public IJRMMBIMETM(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD8F0", Offset = "0x8DBCCF0", VA = "0x188DBD8F0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct ParseResult<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public readonly bool IsNew;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5A3F430", Offset = "0x5A3E830", VA = "0x185A3F430")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class GXHPVPSRWTG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x36C83F0", Offset = "0x36C77F0", VA = "0x1836C83F0")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class QZNWLLBICYB : XEVVKEKTFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string MKAJDVYWTFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private string DASZROIGRAR;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD950", Offset = "0x8DBCD50", VA = "0x188DBD950")]
		public QZNWLLBICYB(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5D90", Offset = "0x8DC5190", VA = "0x188DC5D90", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8DC5ED0", Offset = "0x8DC52D0", VA = "0x188DC5ED0")]
		public static Guid? MOKSLFRUSLP(PJGKUFHRWDW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : GORVDLHLGVR<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x65A5850", Offset = "0x65A4C50", VA = "0x1865A5850")]
		public Result<TVersion, NBILMTLEEJL> JNKTTISNOAZ(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x65A77F0", Offset = "0x65A6BF0", VA = "0x1865A77F0")]
		public static VersionerFactory<TDeps, TData, TVersion> LUYAJHASGOD()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class KTYJSXNJOKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public VersioningPhaseVoidDelegate<TData> ERBAMXUPALD;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KTYJSXNJOKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5273C60", Offset = "0x5273060", VA = "0x185273C60")]
			internal Result<None, NBILMTLEEJL> DJIRIRJLQXD(TDeps a, TData b)
			{
				return default(Result<None, NBILMTLEEJL>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x65A5260", Offset = "0x65A4660", VA = "0x1865A5260")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x65A5390", Offset = "0x65A4790", VA = "0x1865A5390")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class UUINHSIHJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x35C1AF0", Offset = "0x35C0EF0", VA = "0x1835C1AF0")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : GORVDLHLGVR<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FUAFMFDYWFQ : XEVVKEKTFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public readonly Exception LCWDKZCGVKP;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x18EDE40", Offset = "0x18ED240", VA = "0x1818EDE40")]
		public FUAFMFDYWFQ(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD8C0", Offset = "0x8DBCCC0", VA = "0x188DBD8C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD7C0", Offset = "0x8DBCBC0", VA = "0x188DBD7C0", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class XEVVKEKTFPD : NBILMTLEEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3F0", Offset = "0x28E97F0", VA = "0x1828EA3F0")]
		protected XEVVKEKTFPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate Result<None, NBILMTLEEJL> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate void VersioningPhaseVoidDelegate<TData>(TData data);
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
