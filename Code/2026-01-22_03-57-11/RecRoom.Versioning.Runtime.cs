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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E8AD50", Offset = "0x8E89550", VA = "0x188E8AD50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HGQDAUCDXMH
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface ZVDGYJVWQXS : LRSGRJVHVHQ<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class VOHKIDOFRIF : ZVDGYJVWQXS, LRSGRJVHVHQ<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static VOHKIDOFRIF QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			public PersistedRoomVersion MZTEVLQTFHG()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8D850", Offset = "0x8E8C050", VA = "0x188E8D850", Slot = "5")]
			public PersistedRoomVersion QGCPQEOQHFM()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1840760", Offset = "0x183EF60", VA = "0x181840760", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2C713E0", Offset = "0x2C6FBE0", VA = "0x182C713E0", Slot = "7")]
			public bool YZGBABOODXH(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8E8D860", Offset = "0x8E8C060", VA = "0x188E8D860", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VOHKIDOFRIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class WATFZETHJNE
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static Dictionary<Guid, string[]> SYEKZPIJVFC;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8E8DCA0", Offset = "0x8E8C4A0", VA = "0x188E8DCA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class UTRWHETZDPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E8D590", Offset = "0x8E8BD90", VA = "0x188E8D590")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class USWUSDSJRWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8E8D3C0", Offset = "0x8E8BBC0", VA = "0x188E8D3C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class BVTXMSLJHJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8E881C0", Offset = "0x8E869C0", VA = "0x188E881C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class BVOQPLRLXYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8E87F90", Offset = "0x8E86790", VA = "0x188E87F90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class GSUAEHRORBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8E88380", Offset = "0x8E86B80", VA = "0x188E88380")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class NSVKLFRZEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8E8AA10", Offset = "0x8E89210", VA = "0x188E8AA10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class BAOTGOYDEPU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8E87C70", Offset = "0x8E86470", VA = "0x188E87C70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class BAJMJIEFVEL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8E87AA0", Offset = "0x8E862A0", VA = "0x188E87AA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class UEZERJTMQVC
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly Dictionary<Guid, int> ECOUTDVLJSR;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8B1B0", Offset = "0x8E899B0", VA = "0x188E8B1B0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8E8B920", Offset = "0x8E8A120", VA = "0x188E8B920")]
			private static Dictionary<Guid, HDPCUABSWTU> ZUGKAEFJQGM(HDPCUABSWTU a, Dictionary<Guid, HDPCUABSWTU> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class UDTPHVECMFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8E8ADD0", Offset = "0x8E895D0", VA = "0x188E8ADD0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class WAISERFMQQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8E8DAE0", Offset = "0x8E8C2E0", VA = "0x188E8DAE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class HEENZBJZZOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8E88BD0", Offset = "0x8E873D0", VA = "0x188E88BD0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8E88BC0", Offset = "0x8E873C0", VA = "0x188E88BC0")]
			private static void GRBEWNAMQEI(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class HEPBTOXUSLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8E88EB0", Offset = "0x8E876B0", VA = "0x188E88EB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class HFKDIPZKEEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8E890C0", Offset = "0x8E878C0", VA = "0x188E890C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class HCOKUZGVCBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8E88860", Offset = "0x8E87060", VA = "0x188E88860")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class HCJDXSMXSQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8E88540", Offset = "0x8E86D40", VA = "0x188E88540")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class VZYEKDRRXTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8E8D920", Offset = "0x8E8C120", VA = "0x188E8D920")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class ADCVFVOCQZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8E878D0", Offset = "0x8E860D0", VA = "0x188E878D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class ACSHLIAHYDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8E87680", Offset = "0x8E85E80", VA = "0x188E87680")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class ACHTQUMNFGI
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
			private static class RQTVGFWCUXP
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid KMXINHBQVRM
				{
					[Cpp2IlInjected.Token(Token = "0x600002C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0620", Offset = "0x8EAEE20", VA = "0x188EB0620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid GFJKQANCEWS
				{
					[Cpp2IlInjected.Token(Token = "0x600002D")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA420", Offset = "0x8EA8C20", VA = "0x188EAA420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid TETCIMWAYHX
				{
					[Cpp2IlInjected.Token(Token = "0x600002E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7460", Offset = "0x8EB5C60", VA = "0x188EB7460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid YWPQTECRHDZ
				{
					[Cpp2IlInjected.Token(Token = "0x600002F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB37E0", Offset = "0x8EB1FE0", VA = "0x188EB37E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid LDACHWBAHGF
				{
					[Cpp2IlInjected.Token(Token = "0x6000030")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD920", Offset = "0x8EAC120", VA = "0x188EAD920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid HKZJUPJAKUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x8EB28E0", Offset = "0x8EB10E0", VA = "0x188EB28E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid IIPDLBSVABW
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD720", Offset = "0x8EABF20", VA = "0x188EAD720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid ZBTOXPXBFXR
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEF20", Offset = "0x8EAD720", VA = "0x188EAEF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid DYGAHNMQOSG
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6EE0", Offset = "0x8EB56E0", VA = "0x188EB6EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid BXZNHVRBJAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0760", Offset = "0x8EAEF60", VA = "0x188EB0760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid IHMHYSSCMPC
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x8EB19E0", Offset = "0x8EB01E0", VA = "0x188EB19E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid TBFYPEYQTMQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7D60", Offset = "0x8EB6560", VA = "0x188EB7D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid ZXVPQDAXBCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000038")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2C60", Offset = "0x8EB1460", VA = "0x188EB2C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid ASYJEZFRBKX
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8FA0", Offset = "0x8EA77A0", VA = "0x188EA8FA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid WRAITBRRXTZ
				{
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE820", Offset = "0x8EAD020", VA = "0x188EAE820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid OISWFLFKRBK
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1B60", Offset = "0x8EB0360", VA = "0x188EB1B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid NNCALCOZGYZ
				{
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB74E0", Offset = "0x8EB5CE0", VA = "0x188EB74E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid TLUPNROEQTV
				{
					[Cpp2IlInjected.Token(Token = "0x600003D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2CE0", Offset = "0x8EB14E0", VA = "0x188EB2CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid JGDXEXUXMNU
				{
					[Cpp2IlInjected.Token(Token = "0x600003E")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE5A0", Offset = "0x8EACDA0", VA = "0x188EAE5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid SRZTJOEYQDY
				{
					[Cpp2IlInjected.Token(Token = "0x600003F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3E60", Offset = "0x8EB2660", VA = "0x188EB3E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid CYNOQLQDXDY
				{
					[Cpp2IlInjected.Token(Token = "0x6000040")]
					[Cpp2IlInjected.Address(RVA = "0x8EB31E0", Offset = "0x8EB19E0", VA = "0x188EB31E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid QMSTSQWDMHS
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8320", Offset = "0x8EA6B20", VA = "0x188EA8320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid HUKXDKSCWAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000042")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA020", Offset = "0x8EA8820", VA = "0x188EAA020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid MLMSYSZUQTW
				{
					[Cpp2IlInjected.Token(Token = "0x6000043")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3C60", Offset = "0x8EB2460", VA = "0x188EB3C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid XDJWIYVWNEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000044")]
					[Cpp2IlInjected.Address(RVA = "0x8EB23E0", Offset = "0x8EB0BE0", VA = "0x188EB23E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid RJYJIVWVKVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000045")]
					[Cpp2IlInjected.Address(RVA = "0x8EB18E0", Offset = "0x8EB00E0", VA = "0x188EB18E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid JYUTAWLTCHS
				{
					[Cpp2IlInjected.Token(Token = "0x6000046")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE420", Offset = "0x8EACC20", VA = "0x188EAE420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid CUOSWSVKYDM
				{
					[Cpp2IlInjected.Token(Token = "0x6000047")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5860", Offset = "0x8EB4060", VA = "0x188EB5860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid RSVRFDJQEZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5D60", Offset = "0x8EB4560", VA = "0x188EB5D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid AZKKJBQWRXR
				{
					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA1A0", Offset = "0x8EA89A0", VA = "0x188EAA1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid FMCLTRMCMAR
				{
					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB30E0", Offset = "0x8EB18E0", VA = "0x188EB30E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid LUMHPQJYXBM
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7BE0", Offset = "0x8EB63E0", VA = "0x188EB7BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid UGOTARDFDPI
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB59E0", Offset = "0x8EB41E0", VA = "0x188EB59E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid CYMZUANEOGB
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6D60", Offset = "0x8EB5560", VA = "0x188EB6D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid NLODBQKVAWF
				{
					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF920", Offset = "0x8EAE120", VA = "0x188EAF920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid XLLREHCBLXW
				{
					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB20E0", Offset = "0x8EB08E0", VA = "0x188EB20E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid PJSJOVHXPCE
				{
					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9720", Offset = "0x8EA7F20", VA = "0x188EA9720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid FNBXLDAPULH
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAAA0", Offset = "0x8EA92A0", VA = "0x188EAAAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid CFDJGBULQZP
				{
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x8EB73E0", Offset = "0x8EB5BE0", VA = "0x188EB73E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid FUXSRXHWMFA
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8EB10E0", Offset = "0x8EAF8E0", VA = "0x188EB10E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid HEICGQTHBSF
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x8EA88A0", Offset = "0x8EA70A0", VA = "0x188EA88A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid HSARFTWIFIO
				{
					[Cpp2IlInjected.Token(Token = "0x6000055")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0320", Offset = "0x8EAEB20", VA = "0x188EB0320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid YPXYMNCRDOM
				{
					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3FE0", Offset = "0x8EB27E0", VA = "0x188EB3FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid RUAWQHVAOZE
				{
					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8EABBA0", Offset = "0x8EAA3A0", VA = "0x188EABBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid QKOYNCTTDSQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA3A0", Offset = "0x8EA8BA0", VA = "0x188EAA3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid AZOCDSMDHRZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8EABD20", Offset = "0x8EAA520", VA = "0x188EABD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid HJRZUKHHGPY
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF620", Offset = "0x8EADE20", VA = "0x188EAF620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid RZZDGINKORN
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2360", Offset = "0x8EB0B60", VA = "0x188EB2360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid SDLFTTDREYW
				{
					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE7A0", Offset = "0x8EACFA0", VA = "0x188EAE7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid UMPTVWNWHVG
				{
					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0AE0", Offset = "0x8EAF2E0", VA = "0x188EB0AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid PZCLTUGYVXZ
				{
					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE020", Offset = "0x8EAC820", VA = "0x188EAE020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid EZXHKRJKGTL
				{
					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE1A0", Offset = "0x8EAC9A0", VA = "0x188EAE1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid OSRRIQTJNHP
				{
					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7860", Offset = "0x8EB6060", VA = "0x188EB7860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid TVJJCCATKLP
				{
					[Cpp2IlInjected.Token(Token = "0x6000061")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD1A0", Offset = "0x8EAB9A0", VA = "0x188EAD1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid MQWZCGGVIWU
				{
					[Cpp2IlInjected.Token(Token = "0x6000062")]
					[Cpp2IlInjected.Address(RVA = "0x8EADFA0", Offset = "0x8EAC7A0", VA = "0x188EADFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid MKRWKRHAELQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8EABCA0", Offset = "0x8EAA4A0", VA = "0x188EABCA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid ZQFIBXJWHFR
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD420", Offset = "0x8EABC20", VA = "0x188EAD420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid FRBGEBZNKOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8260", Offset = "0x8EB6A60", VA = "0x188EB8260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid HZZRTLLAXUM
				{
					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8EB22E0", Offset = "0x8EB0AE0", VA = "0x188EB22E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid FRMKMRYJYQB
				{
					[Cpp2IlInjected.Token(Token = "0x6000067")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC1A0", Offset = "0x8EAA9A0", VA = "0x188EAC1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid WQGEZMOOCIG
				{
					[Cpp2IlInjected.Token(Token = "0x6000068")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4A60", Offset = "0x8EB3260", VA = "0x188EB4A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid DDPJWLEWLBL
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0x8EA94A0", Offset = "0x8EA7CA0", VA = "0x188EA94A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid JUWNTMZNTPZ
				{
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFB20", Offset = "0x8EAE320", VA = "0x188EAFB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid YDGYMSNSIQD
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB29E0", Offset = "0x8EB11E0", VA = "0x188EB29E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid NXRABMQCUSN
				{
					[Cpp2IlInjected.Token(Token = "0x600006C")]
					[Cpp2IlInjected.Address(RVA = "0x8EADC20", Offset = "0x8EAC420", VA = "0x188EADC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid XXQOTRYZFEP
				{
					[Cpp2IlInjected.Token(Token = "0x600006D")]
					[Cpp2IlInjected.Address(RVA = "0x8EADF20", Offset = "0x8EAC720", VA = "0x188EADF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid NSZOAUIIBWD
				{
					[Cpp2IlInjected.Token(Token = "0x600006E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0F60", Offset = "0x8EAF760", VA = "0x188EB0F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid WDRKTQXSBFV
				{
					[Cpp2IlInjected.Token(Token = "0x600006F")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFA20", Offset = "0x8EAE220", VA = "0x188EAFA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid JGBYDXYVSBQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000070")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5760", Offset = "0x8EB3F60", VA = "0x188EB5760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid FDUYSWHSBTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000071")]
					[Cpp2IlInjected.Address(RVA = "0x8EADAA0", Offset = "0x8EAC2A0", VA = "0x188EADAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid UIBTLSNEGKR
				{
					[Cpp2IlInjected.Token(Token = "0x6000072")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2DE0", Offset = "0x8EB15E0", VA = "0x188EB2DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid UXCBVAFCQOK
				{
					[Cpp2IlInjected.Token(Token = "0x6000073")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1CE0", Offset = "0x8EB04E0", VA = "0x188EB1CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid ZDFMEXXZWZI
				{
					[Cpp2IlInjected.Token(Token = "0x6000074")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFF20", Offset = "0x8EAE720", VA = "0x188EAFF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid UROGLTPMJVD
				{
					[Cpp2IlInjected.Token(Token = "0x6000075")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF1A0", Offset = "0x8EAD9A0", VA = "0x188EAF1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid GMVRAFCJTOM
				{
					[Cpp2IlInjected.Token(Token = "0x6000076")]
					[Cpp2IlInjected.Address(RVA = "0x8EB87E0", Offset = "0x8EB6FE0", VA = "0x188EB87E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid KAQVVMJIGPR
				{
					[Cpp2IlInjected.Token(Token = "0x6000077")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9EA0", Offset = "0x8EA86A0", VA = "0x188EA9EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid FIRDNVHGJKZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000078")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA6A0", Offset = "0x8EA8EA0", VA = "0x188EAA6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid KRHCJPPJPTK
				{
					[Cpp2IlInjected.Token(Token = "0x6000079")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0420", Offset = "0x8EAEC20", VA = "0x188EB0420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid RCADPCROYHU
				{
					[Cpp2IlInjected.Token(Token = "0x600007A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB16E0", Offset = "0x8EAFEE0", VA = "0x188EB16E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid QAYMQTGHNYW
				{
					[Cpp2IlInjected.Token(Token = "0x600007B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6960", Offset = "0x8EB5160", VA = "0x188EB6960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid QZEPJFGWMXR
				{
					[Cpp2IlInjected.Token(Token = "0x600007C")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8820", Offset = "0x8EA7020", VA = "0x188EA8820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid RTCDBQNFHIO
				{
					[Cpp2IlInjected.Token(Token = "0x600007D")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8CA0", Offset = "0x8EA74A0", VA = "0x188EA8CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid PCWZMFGGAGF
				{
					[Cpp2IlInjected.Token(Token = "0x600007E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2160", Offset = "0x8EB0960", VA = "0x188EB2160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid MQNCIDBZMTD
				{
					[Cpp2IlInjected.Token(Token = "0x600007F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4560", Offset = "0x8EB2D60", VA = "0x188EB4560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid KPWFJQPCQML
				{
					[Cpp2IlInjected.Token(Token = "0x6000080")]
					[Cpp2IlInjected.Address(RVA = "0x8EB52E0", Offset = "0x8EB3AE0", VA = "0x188EB52E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid OJBYPYXZNTS
				{
					[Cpp2IlInjected.Token(Token = "0x6000081")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE920", Offset = "0x8EAD120", VA = "0x188EAE920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid PYXCPDILVME
				{
					[Cpp2IlInjected.Token(Token = "0x6000082")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB3A0", Offset = "0x8EA9BA0", VA = "0x188EAB3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid TPRUCHUWRZZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000083")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3DE0", Offset = "0x8EB25E0", VA = "0x188EB3DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid YNUDLFZHZBW
				{
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9AA0", Offset = "0x8EA82A0", VA = "0x188EA9AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid XZTKYIJOFMX
				{
					[Cpp2IlInjected.Token(Token = "0x6000085")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD820", Offset = "0x8EAC020", VA = "0x188EAD820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid FCWIRCXKMZR
				{
					[Cpp2IlInjected.Token(Token = "0x6000086")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1860", Offset = "0x8EB0060", VA = "0x188EB1860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid BHYIZNXSPBC
				{
					[Cpp2IlInjected.Token(Token = "0x6000087")]
					[Cpp2IlInjected.Address(RVA = "0x8EA91A0", Offset = "0x8EA79A0", VA = "0x188EA91A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid TYYGVDSNZRE
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8060", Offset = "0x8EB6860", VA = "0x188EB8060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid FPXBKYTUTKR
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA8A0", Offset = "0x8EA90A0", VA = "0x188EAA8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid EKGQEYSUKYR
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0x8EACEA0", Offset = "0x8EAB6A0", VA = "0x188EACEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid MZUZKXYPGED
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE0A0", Offset = "0x8EAC8A0", VA = "0x188EAE0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid HYHYEPMYGCQ
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF020", Offset = "0x8EAD820", VA = "0x188EAF020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid JXPKEJVQSWD
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB9A0", Offset = "0x8EAA1A0", VA = "0x188EAB9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid PVYHQCKECMC
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB85E0", Offset = "0x8EB6DE0", VA = "0x188EB85E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid PVNTVOWJJPK
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB84E0", Offset = "0x8EB6CE0", VA = "0x188EB84E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid FJGZVKJXPBB
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8D20", Offset = "0x8EA7520", VA = "0x188EA8D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid FKMPEYZHTRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8E20", Offset = "0x8EA7620", VA = "0x188EA8E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid FKCBKLLNAUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8F20", Offset = "0x8EA7720", VA = "0x188EA8F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid QMGHSVSJTVN
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE4A0", Offset = "0x8EACCA0", VA = "0x188EAE4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid DDVEGNIFASR
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE3A0", Offset = "0x8EACBA0", VA = "0x188EAE3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid HKWTBLOBNRX
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB520", Offset = "0x8EA9D20", VA = "0x188EAB520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid TLXNGRGEAQA
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0E60", Offset = "0x8EAF660", VA = "0x188EB0E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid FWDBYIQSKNZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7B60", Offset = "0x8EB6360", VA = "0x188EB7B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid AFFPMNSBKML
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB2A0", Offset = "0x8EA9AA0", VA = "0x188EAB2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid INTXMLIXVZE
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFBA0", Offset = "0x8EAE3A0", VA = "0x188EAFBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid HTBUKMKUDGX
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1C60", Offset = "0x8EB0460", VA = "0x188EB1C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid IWRPTIXGYBC
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB020", Offset = "0x8EA9820", VA = "0x188EAB020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid GQPCCELJBHW
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6CE0", Offset = "0x8EB54E0", VA = "0x188EB6CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid LJPDTWZJPZW
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC5A0", Offset = "0x8EAADA0", VA = "0x188EAC5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid AMMLVURHMFL
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4460", Offset = "0x8EB2C60", VA = "0x188EB4460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid BCUBZVSBOLC
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE6A0", Offset = "0x8EACEA0", VA = "0x188EAE6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid VHNZEZOWMWP
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4660", Offset = "0x8EB2E60", VA = "0x188EB4660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid ARAMENLVDPS
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4760", Offset = "0x8EB2F60", VA = "0x188EB4760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid AKJRVOTYURG
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0x8EACC20", Offset = "0x8EAB420", VA = "0x188EACC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid YTAYKENVNYD
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8560", Offset = "0x8EB6D60", VA = "0x188EB8560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid JAXJKGHLABI
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5660", Offset = "0x8EB3E60", VA = "0x188EB5660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid BXPITNDYLFK
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFE20", Offset = "0x8EAE620", VA = "0x188EAFE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid AHABAZCNLPW
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB21E0", Offset = "0x8EB09E0", VA = "0x188EB21E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid QJKLLPSPJAG
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB1A0", Offset = "0x8EA99A0", VA = "0x188EAB1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid FIDQERQJJVN
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2860", Offset = "0x8EB1060", VA = "0x188EB2860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid KGMTVWNDISZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4BE0", Offset = "0x8EB33E0", VA = "0x188EB4BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid IGMBXMHYXMS
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9820", Offset = "0x8EA8020", VA = "0x188EA9820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid PJEWHNTQVFN
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x8EACDA0", Offset = "0x8EAB5A0", VA = "0x188EACDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid WQLSPQNSUUV
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0CE0", Offset = "0x8EAF4E0", VA = "0x188EB0CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid EGRGYZFABRD
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6660", Offset = "0x8EB4E60", VA = "0x188EB6660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid SDSPFKXCTGN
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0520", Offset = "0x8EAED20", VA = "0x188EB0520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid BUYRKQZYCQG
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB15E0", Offset = "0x8EAFDE0", VA = "0x188EB15E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid WYDVRTWIRGH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5560", Offset = "0x8EB3D60", VA = "0x188EB5560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid ANQRNRBJYUM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x8EB81E0", Offset = "0x8EB69E0", VA = "0x188EB81E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid ZSWGRCQAEKE
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB67E0", Offset = "0x8EB4FE0", VA = "0x188EB67E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid AEGNPDFCNSC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9020", Offset = "0x8EA7820", VA = "0x188EA9020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid JGAJRZWMUSX
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA920", Offset = "0x8EA9120", VA = "0x188EAA920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid XCZGKBYCHAK
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA220", Offset = "0x8EA8A20", VA = "0x188EAA220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid PMXDUYUEXBX
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB65E0", Offset = "0x8EB4DE0", VA = "0x188EB65E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid PPFAIKDWULW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7EE0", Offset = "0x8EB66E0", VA = "0x188EB7EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid JVQUDLRMYVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x8EA86A0", Offset = "0x8EA6EA0", VA = "0x188EA86A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid ZQYTXIUPXOP
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB36E0", Offset = "0x8EB1EE0", VA = "0x188EB36E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid DWKSQBIGWOD
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC6A0", Offset = "0x8EAAEA0", VA = "0x188EAC6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid KICUYFTZMIW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5C60", Offset = "0x8EB4460", VA = "0x188EB5C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid YCMDFJLYGTJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC7A0", Offset = "0x8EAAFA0", VA = "0x188EAC7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid OEGYMMOYHVO
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5CE0", Offset = "0x8EB44E0", VA = "0x188EB5CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid DYKKNNMOSYX
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0x8EA95A0", Offset = "0x8EA7DA0", VA = "0x188EA95A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid EQTQHSHZMZI
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1060", Offset = "0x8EAF860", VA = "0x188EB1060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid JANANWPQGKV
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC420", Offset = "0x8EAAC20", VA = "0x188EAC420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid JAZFNMBSQGF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEC20", Offset = "0x8EAD420", VA = "0x188EAEC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid UGFDGQXXFHX
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6260", Offset = "0x8EB4A60", VA = "0x188EB6260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid QRDXEONKFDH
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7FE0", Offset = "0x8EB67E0", VA = "0x188EB7FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid CFDXIBGNEFR
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4C60", Offset = "0x8EB3460", VA = "0x188EB4C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid UAWDEPDEBIY
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0x8EB76E0", Offset = "0x8EB5EE0", VA = "0x188EB76E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid RMNOQHWDNSB
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0x8EABEA0", Offset = "0x8EAA6A0", VA = "0x188EABEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid LDFGJDWCDJP
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7360", Offset = "0x8EB5B60", VA = "0x188EB7360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid DHXIHFGXHQS
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAE20", Offset = "0x8EA9620", VA = "0x188EAAE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid YKIJGXULSXF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0x8EABA20", Offset = "0x8EAA220", VA = "0x188EABA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid LARDYCGBPQN
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8460", Offset = "0x8EB6C60", VA = "0x188EB8460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid CTHLAHDNWXD
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEBA0", Offset = "0x8EAD3A0", VA = "0x188EAEBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid GPCORJWXHCM
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4E60", Offset = "0x8EB3660", VA = "0x188EB4E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid JYDPASWBPUA
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC320", Offset = "0x8EAAB20", VA = "0x188EAC320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid KUSBDDGGCYG
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB53E0", Offset = "0x8EB3BE0", VA = "0x188EB53E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid WLCRTQGGQEL
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0860", Offset = "0x8EAF060", VA = "0x188EB0860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid VOIJQABZONH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x8EB24E0", Offset = "0x8EB0CE0", VA = "0x188EB24E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid ECWZNBLQMSG
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD520", Offset = "0x8EABD20", VA = "0x188EAD520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid OLDDMXSENZK
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA2A0", Offset = "0x8EA8AA0", VA = "0x188EAA2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid EURKOXYQFIE
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8360", Offset = "0x8EB6B60", VA = "0x188EB8360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid ABCZMNYKZHG
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6FE0", Offset = "0x8EB57E0", VA = "0x188EB6FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid LBNZKPGXXKS
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE620", Offset = "0x8EACE20", VA = "0x188EAE620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid WDMJHTBMDLV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4AE0", Offset = "0x8EB32E0", VA = "0x188EB4AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid SDBQNBTYLJB
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0x8EA90A0", Offset = "0x8EA78A0", VA = "0x188EA90A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid MIPOOPZVTCY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5160", Offset = "0x8EB3960", VA = "0x188EB5160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid QKOOUYUNWTI
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE2A0", Offset = "0x8EACAA0", VA = "0x188EAE2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid YVGUXSQVPMY
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA5A0", Offset = "0x8EA8DA0", VA = "0x188EAA5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid EYEVSZONPTZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2BE0", Offset = "0x8EB13E0", VA = "0x188EB2BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid SQZNMRIKVGH
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1360", Offset = "0x8EAFB60", VA = "0x188EB1360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid QRJASFMOBAM
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1460", Offset = "0x8EAFC60", VA = "0x188EB1460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid PRGOFWRYGLZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0A60", Offset = "0x8EAF260", VA = "0x188EB0A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid UIRMDYUPXPF
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB04A0", Offset = "0x8EAECA0", VA = "0x188EB04A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid ARCDBCDYJZL
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0x8EABE20", Offset = "0x8EAA620", VA = "0x188EABE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid JZINPGDNFJK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF520", Offset = "0x8EADD20", VA = "0x188EAF520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid THTAUCBAAEK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB03A0", Offset = "0x8EAEBA0", VA = "0x188EB03A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid IMBRBLMYAWQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4960", Offset = "0x8EB3160", VA = "0x188EB4960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid CCNXEIUCIPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0660", Offset = "0x8EAEE60", VA = "0x188EB0660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid IXZXPKXLOAP
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC3A0", Offset = "0x8EAABA0", VA = "0x188EAC3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid ALLHQFPGCXF
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7160", Offset = "0x8EB5960", VA = "0x188EB7160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid EMLIBLMAJTS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8860", Offset = "0x8EB7060", VA = "0x188EB8860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid PNDTAQZRNAG
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEDA0", Offset = "0x8EAD5A0", VA = "0x188EAEDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid SFVVRSQBIDX
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3660", Offset = "0x8EB1E60", VA = "0x188EB3660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid OJIDLWJGIEW
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8AA0", Offset = "0x8EA72A0", VA = "0x188EA8AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid CWIOBCWUNIP
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB47E0", Offset = "0x8EB2FE0", VA = "0x188EB47E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid VRLNIYFNBKE
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB51E0", Offset = "0x8EB39E0", VA = "0x188EB51E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid VHPDPWHLTEM
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0x8EA97A0", Offset = "0x8EA7FA0", VA = "0x188EA97A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid SIDCBPTLAXH
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2EE0", Offset = "0x8EB16E0", VA = "0x188EB2EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid MXUERJSLDKB
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1760", Offset = "0x8EAFF60", VA = "0x188EB1760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid JXCSMEMPWXK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA620", Offset = "0x8EA8E20", VA = "0x188EAA620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid IPFDLCYJULG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0x8EADDA0", Offset = "0x8EAC5A0", VA = "0x188EADDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid ZHFRJFOQYEN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB80E0", Offset = "0x8EB68E0", VA = "0x188EB80E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid SPUAJMIOCXB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0x8EADD20", Offset = "0x8EAC520", VA = "0x188EADD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid SWVFUFZVFMD
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB320", Offset = "0x8EA9B20", VA = "0x188EAB320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid DNFLREZQSAS
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4CE0", Offset = "0x8EB34E0", VA = "0x188EB4CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid OYLKWRMRWRF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8DA0", Offset = "0x8EA75A0", VA = "0x188EA8DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid OLMRMVCZNWP
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0x8EB42E0", Offset = "0x8EB2AE0", VA = "0x188EB42E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid UYELKZILPAD
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1960", Offset = "0x8EB0160", VA = "0x188EB1960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid XKFWFKROESY
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB54E0", Offset = "0x8EB3CE0", VA = "0x188EB54E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid KMBFFYAQBEK
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB820", Offset = "0x8EAA020", VA = "0x188EAB820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid FGWULSOTAVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9CA0", Offset = "0x8EA84A0", VA = "0x188EA9CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid WRZDUPGVUXF
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7AE0", Offset = "0x8EB62E0", VA = "0x188EB7AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid TECFGKDEAMD
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5EE0", Offset = "0x8EB46E0", VA = "0x188EB5EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid FZJDDBSINZX
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA7A0", Offset = "0x8EA8FA0", VA = "0x188EAA7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid MVKQNVVCUUX
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6B60", Offset = "0x8EB5360", VA = "0x188EB6B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid YUMVNKZKJET
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE120", Offset = "0x8EAC920", VA = "0x188EAE120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid WZFZOKPBBYB
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3AE0", Offset = "0x8EB22E0", VA = "0x188EB3AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid TLZEKSULMBI
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0x8EB58E0", Offset = "0x8EB40E0", VA = "0x188EB58E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid BFGXVXWTQLD
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9DA0", Offset = "0x8EA85A0", VA = "0x188EA9DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid IKBVFZXIHSL
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2D60", Offset = "0x8EB1560", VA = "0x188EB2D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid RGVOQTGNHPF
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0x8EAADA0", Offset = "0x8EA95A0", VA = "0x188EAADA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid AYQOKHNFIFH
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2A60", Offset = "0x8EB1260", VA = "0x188EB2A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid XBSGTJFAMRS
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0x8EADB20", Offset = "0x8EAC320", VA = "0x188EADB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid PJFDWHOOCFU
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x8EABFA0", Offset = "0x8EAA7A0", VA = "0x188EABFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid NHCBNKFSTQQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9120", Offset = "0x8EA7920", VA = "0x188EA9120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid NNBAPKOWPUA
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7CE0", Offset = "0x8EB64E0", VA = "0x188EB7CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid ATVHASGJTMD
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7960", Offset = "0x8EB6160", VA = "0x188EB7960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid SQKVITPTZHX
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2560", Offset = "0x8EB0D60", VA = "0x188EB2560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid DDHUSEKPRLV
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0960", Offset = "0x8EAF160", VA = "0x188EB0960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid MNHTRQSAVUW
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA320", Offset = "0x8EA8B20", VA = "0x188EAA320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid WEKGFTLACND
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6BE0", Offset = "0x8EB53E0", VA = "0x188EB6BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid OQDUSHFVXUS
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF0A0", Offset = "0x8EAD8A0", VA = "0x188EAF0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid BFFHIJHCKQV
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8EB63E0", Offset = "0x8EB4BE0", VA = "0x188EB63E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid ZLRLZBOEANP
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x8EABC20", Offset = "0x8EAA420", VA = "0x188EABC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid ZZDFVBOKNIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC520", Offset = "0x8EAAD20", VA = "0x188EAC520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid IFQKVSGQMWI
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0x8EABF20", Offset = "0x8EAA720", VA = "0x188EABF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid XDSICOMHBTL
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAD20", Offset = "0x8EA9520", VA = "0x188EAAD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid LJLZSVIZQLX
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD8A0", Offset = "0x8EAC0A0", VA = "0x188EAD8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid ZMHFWNNEXFD
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0x8EABAA0", Offset = "0x8EAA2A0", VA = "0x188EABAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid XZPEMQDQJSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0x8EB50E0", Offset = "0x8EB38E0", VA = "0x188EB50E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid TZDIRKOMTRZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5360", Offset = "0x8EB3B60", VA = "0x188EB5360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid YFVXNUKCGSY
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF320", Offset = "0x8EADB20", VA = "0x188EAF320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid WXXSYARYSCK
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD6A0", Offset = "0x8EABEA0", VA = "0x188EAD6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid CBAQECSMNNC
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x8EAECA0", Offset = "0x8EAD4A0", VA = "0x188EAECA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid SGBCSFHXRMB
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5DE0", Offset = "0x8EB45E0", VA = "0x188EB5DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid HYSFZJPHVAJ
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD320", Offset = "0x8EABB20", VA = "0x188EAD320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid BIPIPKEIQDD
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4B60", Offset = "0x8EB3360", VA = "0x188EB4B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid ZBYUOXWXMXA
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF2A0", Offset = "0x8EADAA0", VA = "0x188EAF2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid OXDTNHOGYPW
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x8EB62E0", Offset = "0x8EB4AE0", VA = "0x188EB62E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid AKSLDHMGNXH
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB7A0", Offset = "0x8EA9FA0", VA = "0x188EAB7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid FVJXKLNJXXV
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9920", Offset = "0x8EA8120", VA = "0x188EA9920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid TFOYVAIDAYD
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x8EB00A0", Offset = "0x8EAE8A0", VA = "0x188EB00A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid IMGOECLWXVD
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3260", Offset = "0x8EB1A60", VA = "0x188EB3260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid WFOYNHVQIEA
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5E60", Offset = "0x8EB4660", VA = "0x188EB5E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid BHBGUXXBWMN
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3CE0", Offset = "0x8EB24E0", VA = "0x188EB3CE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid JXYSTYIWEYT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0x8EB43E0", Offset = "0x8EB2BE0", VA = "0x188EB43E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid YPEBAGLSGMU
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3960", Offset = "0x8EB2160", VA = "0x188EB3960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid PWWFRCPXDJC
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB60E0", Offset = "0x8EB48E0", VA = "0x188EB60E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid CXJZXGOQTZZ
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0x8EACCA0", Offset = "0x8EAB4A0", VA = "0x188EACCA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid PRMBCQQRQSU
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7760", Offset = "0x8EB5F60", VA = "0x188EB7760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid AETYXPLXWDD
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD7A0", Offset = "0x8EABFA0", VA = "0x188EAD7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid QBHHLYYOBSS
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1160", Offset = "0x8EAF960", VA = "0x188EB1160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid JDRPHIWXPKN
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB39E0", Offset = "0x8EB21E0", VA = "0x188EB39E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid BIXNOOTKRIC
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0x8EB86E0", Offset = "0x8EB6EE0", VA = "0x188EB86E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid XYKEEJWYEKF
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE320", Offset = "0x8EACB20", VA = "0x188EAE320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid MKJWHJPCDNC
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9520", Offset = "0x8EA7D20", VA = "0x188EA9520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid ROAKOZMKNHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFCA0", Offset = "0x8EAE4A0", VA = "0x188EAFCA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid HXCPTBNKZWQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9C20", Offset = "0x8EA8420", VA = "0x188EA9C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid QEKCABJGAXA
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x8EB68E0", Offset = "0x8EB50E0", VA = "0x188EB68E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid DMIPCLPBSKV
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x8EB40E0", Offset = "0x8EB28E0", VA = "0x188EB40E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid XDLEWLBDQBI
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x8EA92A0", Offset = "0x8EA7AA0", VA = "0x188EA92A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid USRSEXHZDVF
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE720", Offset = "0x8EACF20", VA = "0x188EAE720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid KMEKBGJBNLU
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9B20", Offset = "0x8EA8320", VA = "0x188EA9B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid MYPOOAZMNFF
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB44E0", Offset = "0x8EB2CE0", VA = "0x188EB44E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid BRMNTIUWDDA
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6DE0", Offset = "0x8EB55E0", VA = "0x188EB6DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid YXAFYYEIICK
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8520", Offset = "0x8EA6D20", VA = "0x188EA8520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid NLKSRZRZOJI
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1AE0", Offset = "0x8EB02E0", VA = "0x188EB1AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid EFZOWTENCMA
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8160", Offset = "0x8EB6960", VA = "0x188EB8160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid UTLNKAQJOLU
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB35E0", Offset = "0x8EB1DE0", VA = "0x188EB35E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid ULCYLQYQPWB
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF7A0", Offset = "0x8EADFA0", VA = "0x188EAF7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid UTGGMTWMFAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0x8EB34E0", Offset = "0x8EB1CE0", VA = "0x188EB34E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid UTAZPNCOVPC
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3560", Offset = "0x8EB1D60", VA = "0x188EB3560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid SCKGKCWYJMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0C60", Offset = "0x8EAF460", VA = "0x188EB0C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid FAGDPRMRKXH
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6760", Offset = "0x8EB4F60", VA = "0x188EB6760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid EZQIXXEZIPG
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0x8EB66E0", Offset = "0x8EB4EE0", VA = "0x188EB66E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid SRZVIACYJMG
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4D60", Offset = "0x8EB3560", VA = "0x188EB4D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid KWLYCQZMBCE
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3D60", Offset = "0x8EB2560", VA = "0x188EB3D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid HTWDMIOVWEX
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2960", Offset = "0x8EB1160", VA = "0x188EB2960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid JXSJOBJFAGE
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3A60", Offset = "0x8EB2260", VA = "0x188EB3A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid OBMTXAJTXTE
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0x8EA83A0", Offset = "0x8EA6BA0", VA = "0x188EA83A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid MHZAGFLOCZT
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4860", Offset = "0x8EB3060", VA = "0x188EB4860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid XBQDLWRFNGD
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB6A0", Offset = "0x8EA9EA0", VA = "0x188EAB6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid UGLZNXDVGJR
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0120", Offset = "0x8EAE920", VA = "0x188EB0120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid EWTPSNEMBAU
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6360", Offset = "0x8EB4B60", VA = "0x188EB6360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid JIDJFSIQOGF
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0x8EADE20", Offset = "0x8EAC620", VA = "0x188EADE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid FVYYUJMENVV
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8760", Offset = "0x8EB6F60", VA = "0x188EB8760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid MLXIHSIGQFX
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3EE0", Offset = "0x8EB26E0", VA = "0x188EB3EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid WNIWGHYRYPK
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6860", Offset = "0x8EB5060", VA = "0x188EB6860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid LQKWHRSOBNZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9620", Offset = "0x8EA7E20", VA = "0x188EA9620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid KNBZXBZCDTI
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0x8EB41E0", Offset = "0x8EB29E0", VA = "0x188EB41E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid HNMDBNCEZAO
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0x8EB14E0", Offset = "0x8EAFCE0", VA = "0x188EB14E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid YAIFTXPYNPG
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2260", Offset = "0x8EB0A60", VA = "0x188EB2260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid JFJHDRHZCJT
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0x8EB48E0", Offset = "0x8EB30E0", VA = "0x188EB48E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid MBGKFBOPFBO
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1A60", Offset = "0x8EB0260", VA = "0x188EB1A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid EZGSBVTNGDN
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0x8EB26E0", Offset = "0x8EB0EE0", VA = "0x188EB26E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid OMHUOEDNMLC
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD020", Offset = "0x8EAB820", VA = "0x188EAD020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid FFVAKDJMYCB
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB38E0", Offset = "0x8EB20E0", VA = "0x188EB38E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid XJRLFGGCKSR
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4EE0", Offset = "0x8EB36E0", VA = "0x188EB4EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid DFUHVCDTLCR
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB78E0", Offset = "0x8EB60E0", VA = "0x188EB78E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid ZNAKVTCNOKS
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB07E0", Offset = "0x8EAEFE0", VA = "0x188EB07E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid QHYWCJRNZZA
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0x8EADCA0", Offset = "0x8EAC4A0", VA = "0x188EADCA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid NLORBGXFWMD
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD0A0", Offset = "0x8EAB8A0", VA = "0x188EAD0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid BYRJNRVPFSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9A20", Offset = "0x8EA8220", VA = "0x188EA9A20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid KZCOKHVNEXS
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0x8EB71E0", Offset = "0x8EB59E0", VA = "0x188EB71E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid TDBXSFDDRGN
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4260", Offset = "0x8EB2A60", VA = "0x188EB4260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid MJQYUASZZUH
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0x8EB09E0", Offset = "0x8EAF1E0", VA = "0x188EB09E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid LXFKIPTTKXZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0x8EB27E0", Offset = "0x8EB0FE0", VA = "0x188EB27E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid JWSYXMLMKKV
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF720", Offset = "0x8EADF20", VA = "0x188EAF720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid PNALCVUGOFW
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2E60", Offset = "0x8EB1660", VA = "0x188EB2E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid TEHBXWFPIUJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0x8EB05A0", Offset = "0x8EAEDA0", VA = "0x188EB05A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid IETJLOFNUVD
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF9A0", Offset = "0x8EAE1A0", VA = "0x188EAF9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid EMHNDGMOABD
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8920", Offset = "0x8EA7120", VA = "0x188EA8920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid CYOEKTQAMPP
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9320", Offset = "0x8EA7B20", VA = "0x188EA9320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid QSZLJQQRCXT
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAC20", Offset = "0x8EA9420", VA = "0x188EAAC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid OXXMKRMPHPZ
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4FE0", Offset = "0x8EB37E0", VA = "0x188EB4FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid DRHBXBLEFRL
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB75E0", Offset = "0x8EB5DE0", VA = "0x188EB75E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid HBOEKKECTMI
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB83E0", Offset = "0x8EB6BE0", VA = "0x188EB83E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid TSEBNAZTSXN
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF5A0", Offset = "0x8EADDA0", VA = "0x188EAF5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid GFPMAFRYODE
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4160", Offset = "0x8EB2960", VA = "0x188EB4160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid CYBSKUWASRU
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3860", Offset = "0x8EB2060", VA = "0x188EB3860")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid JIFBVWQZFJE
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD4A0", Offset = "0x8EABCA0", VA = "0x188EAD4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid QESKDPNIWAZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0x8EACA20", Offset = "0x8EAB220", VA = "0x188EACA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid NDDPRIHQYBS
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF120", Offset = "0x8EAD920", VA = "0x188EAF120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid WCGVNUKFPNV
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2060", Offset = "0x8EB0860", VA = "0x188EB2060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid MMEOQWEYYKS
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFD20", Offset = "0x8EAE520", VA = "0x188EAFD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid RYQUINODTMP
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0x8EA99A0", Offset = "0x8EA81A0", VA = "0x188EA99A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid BBRKJKDNUZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD3A0", Offset = "0x8EABBA0", VA = "0x188EAD3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid BKKAIJCZDFX
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA120", Offset = "0x8EA8920", VA = "0x188EAA120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid ZSLBWNJZRPC
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF6A0", Offset = "0x8EADEA0", VA = "0x188EAF6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid CPBFOWVWSRF
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB25E0", Offset = "0x8EB0DE0", VA = "0x188EB25E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid NNJCGLJJABR
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC120", Offset = "0x8EAA920", VA = "0x188EAC120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid XMNMMDHKEOT
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4060", Offset = "0x8EB2860", VA = "0x188EB4060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid WWRTAJQIUGQ
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB8A0", Offset = "0x8EAA0A0", VA = "0x188EAB8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid BLFNSNGLHZG
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9220", Offset = "0x8EA7A20", VA = "0x188EA9220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid HNSXIOTODRQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF8A0", Offset = "0x8EAE0A0", VA = "0x188EAF8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid VNNKXEWBWLX
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7A60", Offset = "0x8EB6260", VA = "0x188EB7A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid BMQQILRVCRT
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7660", Offset = "0x8EB5E60", VA = "0x188EB7660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid TTKWZWGAUJQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0x8EB49E0", Offset = "0x8EB31E0", VA = "0x188EB49E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid SIPLSCAEGOZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE220", Offset = "0x8EACA20", VA = "0x188EAE220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid YIVEETWPLPA
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9E20", Offset = "0x8EA8620", VA = "0x188EA9E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid HGUZXVQKYUZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFC20", Offset = "0x8EAE420", VA = "0x188EAFC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid APUXFUPILSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0x8EB33E0", Offset = "0x8EB1BE0", VA = "0x188EB33E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid HLWPYLNARWR
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3760", Offset = "0x8EB1F60", VA = "0x188EB3760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid NBJTDLAABJE
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5B60", Offset = "0x8EB4360", VA = "0x188EB5B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid PXHALRMHOTK
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0FE0", Offset = "0x8EAF7E0", VA = "0x188EB0FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid AEDUFWBZVLF
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0x8EACFA0", Offset = "0x8EAB7A0", VA = "0x188EACFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid FZFPIKJLCOP
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB46E0", Offset = "0x8EB2EE0", VA = "0x188EB46E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid HXXOCJFAFKY
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9D20", Offset = "0x8EA8520", VA = "0x188EA9D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid PXLNPVNJFUG
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7260", Offset = "0x8EB5A60", VA = "0x188EB7260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid TRNUUCMZBHQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEA20", Offset = "0x8EAD220", VA = "0x188EAEA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid ENZWJSAQMTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0x8EACB20", Offset = "0x8EAB320", VA = "0x188EACB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid AJYZPMRCETN
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8620", Offset = "0x8EA6E20", VA = "0x188EA8620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid MDZAJLTWKZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6E60", Offset = "0x8EB5660", VA = "0x188EB6E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid MNWPHNBEZJS
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB720", Offset = "0x8EA9F20", VA = "0x188EAB720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid GJYDTUMNNET
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6060", Offset = "0x8EB4860", VA = "0x188EB6060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid NDIMTOSRBLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC820", Offset = "0x8EAB020", VA = "0x188EAC820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid LDCVAVUMMNQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4F60", Offset = "0x8EB3760", VA = "0x188EB4F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid JSQRIXKETTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0x8EB56E0", Offset = "0x8EB3EE0", VA = "0x188EB56E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid KRBPQQBBYOM
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9FA0", Offset = "0x8EA87A0", VA = "0x188EA9FA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid WIJCASPSRFO
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB220", Offset = "0x8EA9A20", VA = "0x188EAB220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid KWUIZBUAMZU
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEAA0", Offset = "0x8EAD2A0", VA = "0x188EAEAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid SYALWQMNCXC
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3460", Offset = "0x8EB1C60", VA = "0x188EB3460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid KDMEPQYCEMW
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5F60", Offset = "0x8EB4760", VA = "0x188EB5F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid UZYBQWVMHRD
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8B20", Offset = "0x8EA7320", VA = "0x188EA8B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid SCGWCAJOGTB
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0x8EACBA0", Offset = "0x8EAB3A0", VA = "0x188EACBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid IPFDESKRHKG
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0x8EAABA0", Offset = "0x8EA93A0", VA = "0x188EAABA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid CWRAUASIGWV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0x8EB88E0", Offset = "0x8EB70E0", VA = "0x188EB88E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid UIFDHRADOGN
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3060", Offset = "0x8EB1860", VA = "0x188EB3060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid BQRGYGXSIAW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB45E0", Offset = "0x8EB2DE0", VA = "0x188EB45E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid GCDLVZAMFCL
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5260", Offset = "0x8EB3A60", VA = "0x188EB5260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid OXVELJWAXVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6560", Offset = "0x8EB4D60", VA = "0x188EB6560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid WZMWGLNUTXF
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5A60", Offset = "0x8EB4260", VA = "0x188EB5A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid BEROCOBTXMG
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0x8EACE20", Offset = "0x8EAB620", VA = "0x188EACE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid ETCQWUFYXWD
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0x8EA93A0", Offset = "0x8EA7BA0", VA = "0x188EA93A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid IYINNMKLMTH
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6160", Offset = "0x8EB4960", VA = "0x188EB6160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid PDIFPFQYYBQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3160", Offset = "0x8EB1960", VA = "0x188EB3160")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid FSPSYGLYSRF
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2AE0", Offset = "0x8EB12E0", VA = "0x188EB2AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid VUWTYEJKWNA
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0x8EABB20", Offset = "0x8EAA320", VA = "0x188EABB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid SYWRQPEPAYC
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8C20", Offset = "0x8EA7420", VA = "0x188EA8C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid IOJEXMZTGSG
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB82E0", Offset = "0x8EB6AE0", VA = "0x188EB82E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid UWMLRAPHKWR
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6F60", Offset = "0x8EB5760", VA = "0x188EB6F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid HVVNZBHCMVZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA0A0", Offset = "0x8EA88A0", VA = "0x188EAA0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid PUNOBDHPJSD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6A60", Offset = "0x8EB5260", VA = "0x188EB6A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid ILVINUSFSWD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0220", Offset = "0x8EAEA20", VA = "0x188EB0220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid NFUDUCYOUPF
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1FE0", Offset = "0x8EB07E0", VA = "0x188EB1FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid BDCOKZZFVXT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD220", Offset = "0x8EABA20", VA = "0x188EAD220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid XOWLLUFNDAR
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1EE0", Offset = "0x8EB06E0", VA = "0x188EB1EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid KZIVPOPADEL
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1F60", Offset = "0x8EB0760", VA = "0x188EB1F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid YXWDNVKZJBE
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4DE0", Offset = "0x8EB35E0", VA = "0x188EB4DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid GKAABTILQUA
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9BA0", Offset = "0x8EA83A0", VA = "0x188EA9BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid ZTHRZYSXZXB
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1D60", Offset = "0x8EB0560", VA = "0x188EB1D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid EOYRUHJWSVL
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB0A0", Offset = "0x8EA98A0", VA = "0x188EAB0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid UGZSZQTWTQF
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1DE0", Offset = "0x8EB05E0", VA = "0x188EB1DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid ZOQQCCVJORQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB64E0", Offset = "0x8EB4CE0", VA = "0x188EB64E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid XZFHHMBJNZH
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF820", Offset = "0x8EAE020", VA = "0x188EAF820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid AQNBNDRJXFS
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2460", Offset = "0x8EB0C60", VA = "0x188EB2460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid WAVLFUDBVTI
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1260", Offset = "0x8EAFA60", VA = "0x188EB1260")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid ABAADOOCYUC
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAF20", Offset = "0x8EA9720", VA = "0x188EAAF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid BDKRSGHVRQC
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB920", Offset = "0x8EAA120", VA = "0x188EAB920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid LHWHCIGCBHS
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEEA0", Offset = "0x8EAD6A0", VA = "0x188EAEEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid JAKVIMDEIDD
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB57E0", Offset = "0x8EB3FE0", VA = "0x188EB57E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid WFDZJQRSNIH
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA4A0", Offset = "0x8EA8CA0", VA = "0x188EAA4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid YTEKCVNZGHF
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFDA0", Offset = "0x8EAE5A0", VA = "0x188EAFDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid QKDWUXZROZK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7F60", Offset = "0x8EB6760", VA = "0x188EB7F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid JNHJHCCLHMJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF420", Offset = "0x8EADC20", VA = "0x188EAF420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid QJPGBRPDRCO
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0x8EB02A0", Offset = "0x8EAEAA0", VA = "0x188EB02A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid MTMCQMQEJQZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB55E0", Offset = "0x8EB3DE0", VA = "0x188EB55E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid QYDJNZTBKEM
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3F60", Offset = "0x8EB2760", VA = "0x188EB3F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid HLCOUHDKCGF
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8660", Offset = "0x8EB6E60", VA = "0x188EB8660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid SGKEEZYGLSI
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0B60", Offset = "0x8EAF360", VA = "0x188EB0B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid QXUIMNQFBUN
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2FE0", Offset = "0x8EB17E0", VA = "0x188EB2FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid SYHIFGRSXZT
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD120", Offset = "0x8EAB920", VA = "0x188EAD120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid KJPCXMZIFHU
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC720", Offset = "0x8EAAF20", VA = "0x188EAC720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid ZDGLWPWJFMK
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0x8EB72E0", Offset = "0x8EB5AE0", VA = "0x188EB72E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid UBTHBVCYSLP
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA720", Offset = "0x8EA8F20", VA = "0x188EAA720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid DWVYSHATCQL
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC4A0", Offset = "0x8EAACA0", VA = "0x188EAC4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid RWFAVLGZMST
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3360", Offset = "0x8EB1B60", VA = "0x188EB3360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid TWLSPDDKPHK
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFEA0", Offset = "0x8EAE6A0", VA = "0x188EAFEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid TVVXXIVSMZJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFFA0", Offset = "0x8EAE7A0", VA = "0x188EAFFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid XAXZEZGACED
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0020", Offset = "0x8EAE820", VA = "0x188EB0020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid XSWVWEHGGEA
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0x8EACAA0", Offset = "0x8EAB2A0", VA = "0x188EACAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid KUTLXLKFULS
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0x8EAFAA0", Offset = "0x8EAE2A0", VA = "0x188EAFAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid AZHYOUJLJJJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB620", Offset = "0x8EA9E20", VA = "0x188EAB620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid UUWCVGVMALM
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5AE0", Offset = "0x8EB42E0", VA = "0x188EB5AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid LXUIAKUMNGI
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEB20", Offset = "0x8EAD320", VA = "0x188EAEB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid QNZHRFZPECH
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC020", Offset = "0x8EAA820", VA = "0x188EAC020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid GKHBTZDMWDO
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0x8EB12E0", Offset = "0x8EAFAE0", VA = "0x188EB12E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid NNMBVAFLKUI
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7E60", Offset = "0x8EB6660", VA = "0x188EB7E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid GLUUKYFQJYW
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7560", Offset = "0x8EB5D60", VA = "0x188EB7560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid XYNXWEWGWJW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1BE0", Offset = "0x8EB03E0", VA = "0x188EB1BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid ZJBBFRTPFFX
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0x8EB06E0", Offset = "0x8EAEEE0", VA = "0x188EB06E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid QEAHGAMLUYC
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0x8EB79E0", Offset = "0x8EB61E0", VA = "0x188EB79E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid VPSELYPGUWB
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5960", Offset = "0x8EB4160", VA = "0x188EB5960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid NVRGVENJNLK
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEE20", Offset = "0x8EAD620", VA = "0x188EAEE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid MMYDBQOSZKX
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0x8EA98A0", Offset = "0x8EA80A0", VA = "0x188EA98A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid YXTPTGYSWYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2B60", Offset = "0x8EB1360", VA = "0x188EB2B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid BPXQEUXPAZX
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0x8EA85A0", Offset = "0x8EA6DA0", VA = "0x188EA85A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid TJHZXYRAMRH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0x8EB69E0", Offset = "0x8EB51E0", VA = "0x188EB69E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid PQNUCKTNFOQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0x8EA89A0", Offset = "0x8EA71A0", VA = "0x188EA89A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid TLOTXRVVMAU
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0x8EAED20", Offset = "0x8EAD520", VA = "0x188EAED20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid EMKTAFQYMNX
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6460", Offset = "0x8EB4C60", VA = "0x188EB6460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid RMQFNABXOZC
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD620", Offset = "0x8EABE20", VA = "0x188EAD620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid DZBXPEDXCND
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0x8EB4360", Offset = "0x8EB2B60", VA = "0x188EB4360")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid XRUQZXJAZOG
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6C60", Offset = "0x8EB5460", VA = "0x188EB6C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid GKXLDXYUPVI
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8420", Offset = "0x8EA6C20", VA = "0x188EA8420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid AXANQCMRDXV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0x8EB01A0", Offset = "0x8EAE9A0", VA = "0x188EB01A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid GUKUQKYHRUN
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC220", Offset = "0x8EAAA20", VA = "0x188EAC220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid DMJIQUBTHES
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF220", Offset = "0x8EADA20", VA = "0x188EAF220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid PUZYFTLVAGN
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2660", Offset = "0x8EB0E60", VA = "0x188EB2660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid XPLCZSQSSGC
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1560", Offset = "0x8EAFD60", VA = "0x188EB1560")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid ORFJGILRPSN
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC2A0", Offset = "0x8EAAAA0", VA = "0x188EAC2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid QBDPLVWYEEM
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0D60", Offset = "0x8EAF560", VA = "0x188EB0D60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid QEGEVSQYNPD
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0x8EB77E0", Offset = "0x8EB5FE0", VA = "0x188EB77E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid MWONEJQWZUF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC620", Offset = "0x8EAAE20", VA = "0x188EAC620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid BFXVDDMQAWH
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7060", Offset = "0x8EB5860", VA = "0x188EB7060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid EWFBLPPZJTZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0x8EA84A0", Offset = "0x8EA6CA0", VA = "0x188EA84A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid LJHVGPWFZLW
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0DE0", Offset = "0x8EAF5E0", VA = "0x188EB0DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid BXZQBQWKTWY
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7DE0", Offset = "0x8EB65E0", VA = "0x188EB7DE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid WCXEFEUEVZX
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0x8EAEFA0", Offset = "0x8EAD7A0", VA = "0x188EAEFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid YBPTEZJGCVV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5460", Offset = "0x8EB3C60", VA = "0x188EB5460")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid DGMTZQXQFYI
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB4A0", Offset = "0x8EA9CA0", VA = "0x188EAB4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid VCTDDAUXOZL
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0x8EB6AE0", Offset = "0x8EB52E0", VA = "0x188EB6AE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid SOMDHBKMZBN
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD9A0", Offset = "0x8EAC1A0", VA = "0x188EAD9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid SJHJPHJRHNX
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0x8EB32E0", Offset = "0x8EB1AE0", VA = "0x188EB32E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid PJOZRPLCPVL
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5BE0", Offset = "0x8EB43E0", VA = "0x188EB5BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid PAFMQEPYBRN
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC0A0", Offset = "0x8EAA8A0", VA = "0x188EAC0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid DCVQBHRMBUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA520", Offset = "0x8EA8D20", VA = "0x188EAA520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid SAWHPCROUBG
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE8A0", Offset = "0x8EAD0A0", VA = "0x188EAE8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid HYOLOVMKBTB
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0x8EB13E0", Offset = "0x8EAFBE0", VA = "0x188EB13E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid GWSXJUKJPKU
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0x8EADBA0", Offset = "0x8EAC3A0", VA = "0x188EADBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid FPEGWXHVHQI
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD2A0", Offset = "0x8EABAA0", VA = "0x188EAD2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid SQOAAPWUKCY
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2760", Offset = "0x8EB0F60", VA = "0x188EB2760")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid OUAYEWLUZEE
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0x8EA87A0", Offset = "0x8EA6FA0", VA = "0x188EA87A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid DHOXTSTTCCF
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAFA0", Offset = "0x8EA97A0", VA = "0x188EAAFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid MSFPYGOQKXU
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB70E0", Offset = "0x8EB58E0", VA = "0x188EB70E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid ARHUOAMJBRP
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3B60", Offset = "0x8EB2360", VA = "0x188EB3B60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid MJNCPIYJSCY
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0x8EACD20", Offset = "0x8EAB520", VA = "0x188EACD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid KENCNHEWOIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA9A0", Offset = "0x8EA91A0", VA = "0x188EAA9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid CEFSPXAZNEO
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8EA0", Offset = "0x8EA76A0", VA = "0x188EA8EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid TRPYYLSOXSJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8720", Offset = "0x8EA6F20", VA = "0x188EA8720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid UAGJINTBQJA
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB120", Offset = "0x8EA9920", VA = "0x188EAB120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid TNZAGCOUWVP
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5FE0", Offset = "0x8EB47E0", VA = "0x188EB5FE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid QBMWITVRSKU
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB420", Offset = "0x8EA9C20", VA = "0x188EAB420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid JAPHOHWBVKK
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0x8EADA20", Offset = "0x8EAC220", VA = "0x188EADA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid IIWMOXPPHDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8960", Offset = "0x8EB7160", VA = "0x188EB8960")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid PVUAWCSFAEV
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE520", Offset = "0x8EACD20", VA = "0x188EAE520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid XZTGLIGBTQU
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0x8EAE9A0", Offset = "0x8EAD1A0", VA = "0x188EAE9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid ZNNBWXLVWQN
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB11E0", Offset = "0x8EAF9E0", VA = "0x188EB11E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid QRJTXHPWWOM
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAB5A0", Offset = "0x8EA9DA0", VA = "0x188EAB5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid QPDMRKERXKU
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8A20", Offset = "0x8EA7220", VA = "0x188EA8A20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid QTLFWVOBPTK
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1660", Offset = "0x8EAFE60", VA = "0x188EB1660")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid UILWUPTXWVC
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0x8EB08E0", Offset = "0x8EAF0E0", VA = "0x188EB08E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid EGSUKUJFIXE
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB1E60", Offset = "0x8EB0660", VA = "0x188EB1E60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid UGRQQEDPNDG
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC9A0", Offset = "0x8EAB1A0", VA = "0x188EAC9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid ZFLPZBDCEOH
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0x8EA96A0", Offset = "0x8EA7EA0", VA = "0x188EA96A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid SGVUPSOUXHW
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0x8EAACA0", Offset = "0x8EA94A0", VA = "0x188EAACA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid PENCGYFFGHX
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAB20", Offset = "0x8EA9320", VA = "0x188EAAB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid DVXHLNJDOOR
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAEA0", Offset = "0x8EA96A0", VA = "0x188EAAEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid TROMATTFEDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0BE0", Offset = "0x8EAF3E0", VA = "0x188EB0BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid GTAIWHUKBSB
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0x8EB8A60", Offset = "0x8EB7260", VA = "0x188EB8A60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid MIWEWIJCZIP
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0x8EADEA0", Offset = "0x8EAC6A0", VA = "0x188EADEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid EPHFCMGGICM
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0x8EB17E0", Offset = "0x8EAFFE0", VA = "0x188EB17E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid XVMHEKBFUQA
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0x8EB0EE0", Offset = "0x8EAF6E0", VA = "0x188EB0EE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid FZIZIUVWHDN
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0x8EB2F60", Offset = "0x8EB1760", VA = "0x188EB2F60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid PSHHCNBGBLY
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAA820", Offset = "0x8EA9020", VA = "0x188EAA820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid QGRRWDLEJZE
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0x8EB89E0", Offset = "0x8EB71E0", VA = "0x188EB89E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid ILCOLTSDDLI
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0x8EACF20", Offset = "0x8EAB720", VA = "0x188EACF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid EFRVDBCVXMD
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0x8EAD5A0", Offset = "0x8EABDA0", VA = "0x188EAD5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid LQZYUVIIZNN
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0x8EB7C60", Offset = "0x8EB6460", VA = "0x188EB7C60")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid ZAXSTSPBHCE
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9420", Offset = "0x8EA7C20", VA = "0x188EA9420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid DHJZKIYOLBU
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0x8EAAA20", Offset = "0x8EA9220", VA = "0x188EAAA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid WRTFKMPTMKH
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0x8EABDA0", Offset = "0x8EAA5A0", VA = "0x188EABDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid BVDWJCFNXNF
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF3A0", Offset = "0x8EADBA0", VA = "0x188EAF3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid BVJDGIZLGYO
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0x8EAF4A0", Offset = "0x8EADCA0", VA = "0x188EAF4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid VIMFFIVBQNJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0x8EA8BA0", Offset = "0x8EA73A0", VA = "0x188EA8BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid TWMMQRDIBVC
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0x8EB5060", Offset = "0x8EB3860", VA = "0x188EB5060")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid WGYUFSTJJVM
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0x8EB3BE0", Offset = "0x8EB23E0", VA = "0x188EB3BE0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid BPHNSEMMFTG
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC920", Offset = "0x8EAB120", VA = "0x188EAC920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid YKTQYNYNIOJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0x8EB61E0", Offset = "0x8EB49E0", VA = "0x188EB61E0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid NGAQHFOIXBQ
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0x8EA9F20", Offset = "0x8EA8720", VA = "0x188EA9F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid UOGAPVMMHPN
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0x8EAC8A0", Offset = "0x8EAB0A0", VA = "0x188EAC8A0")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8E872A0", Offset = "0x8E85AA0", VA = "0x188E872A0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8E81140", Offset = "0x8E7F940", VA = "0x188E81140")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> BWTQUXIRGLT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class ACNAOBGKORR
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0790", Offset = "0x8E9EF90", VA = "0x188EA0790")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class TCGJJWMCRWA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x8EB8AE0", Offset = "0x8EB72E0", VA = "0x188EB8AE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class MDKOMNBCJBU
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8EA6E40", Offset = "0x8EA5640", VA = "0x188EA6E40")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class JYZMUKSVXRD
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private static readonly Dictionary<Guid, float> LEHWZYDYDVN;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private static readonly Dictionary<Guid, float> XIXHJSSFBIK;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private static readonly Dictionary<Guid, bool> TIIZRCPNQAJ;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8EA5000", Offset = "0x8EA3800", VA = "0x188EA5000")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class JYUFXDYYOFU
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private static readonly Dictionary<Guid, float> RJBPLDKGVZK;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private static readonly Dictionary<Guid, float> YOBSAKTLLWP;

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8EA3B60", Offset = "0x8EA2360", VA = "0x188EA3B60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class WCJJDGWMGZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8EB8FB0", Offset = "0x8EB77B0", VA = "0x188EB8FB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class CYSVQFYOAVM
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private static readonly Dictionary<Guid, int> GGLODYDRSNO;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private static readonly Dictionary<Guid, bool> DNDPZYAKXKS;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private static readonly Dictionary<Guid, bool> VMTPBXYJVHR;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private static readonly Dictionary<Guid, int> BROXQZMXREB;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private static readonly Dictionary<Guid, bool> PEUEBSWDQAU;

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0E90", Offset = "0x8E9F690", VA = "0x188EA0E90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class CYIHVSKTHYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0CD0", Offset = "0x8E9F4D0", VA = "0x188EA0CD0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<ZVDGYJVWQXS, PersistedRoomData, PersistedRoomVersion> INDNQYCKUTZ;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Dictionary<Guid, int> QGYAJMRHIAY;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Guid ICVMEJRYCMY;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Guid QZCWJLARZRU;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly float NBRRXPCUAJC;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E898C0", Offset = "0x8E880C0", VA = "0x188E898C0")]
		public static PersistedRoomData QSZFGBHMUNR(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E89D90", Offset = "0x8E88590", VA = "0x188E89D90")]
		public static Result<ParseResult<PersistedRoomData>, GPJDWMBBLWO> RWKBMYDQNDR(ZVDGYJVWQXS a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E899E0", Offset = "0x8E881E0", VA = "0x188E899E0")]
		public static Result<ParseResult<PersistedRoomData>, GPJDWMBBLWO> RWKBMYDQNDR(ZVDGYJVWQXS a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E89580", Offset = "0x8E87D80", VA = "0x188E89580")]
		public static Result<None, GPJDWMBBLWO> MOHUAGDLCJE(ZVDGYJVWQXS a, PersistedRoomData b)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E894A0", Offset = "0x8E87CA0", VA = "0x188E894A0")]
		public static Guid FPTOIPOTHTR(HDPCUABSWTU a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class YUAUVZEXDED
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public interface ZVDGYJVWQXS : LRSGRJVHVHQ<TJUJUSPIWTZ, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public sealed class VOHKIDOFRIF : ZVDGYJVWQXS, LRSGRJVHVHQ<TJUJUSPIWTZ, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static VOHKIDOFRIF QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			public PlayerSaveVersion MZTEVLQTFHG()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xBBBDE0", Offset = "0xBBA5E0", VA = "0x180BBBDE0", Slot = "5")]
			public PlayerSaveVersion QGCPQEOQHFM()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1840760", Offset = "0x183EF60", VA = "0x181840760", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2C713E0", Offset = "0x2C6FBE0", VA = "0x182C713E0", Slot = "7")]
			public bool YZGBABOODXH(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8EB8E30", Offset = "0x8EB7630", VA = "0x188EB8E30", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VOHKIDOFRIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private static Versioner<ZVDGYJVWQXS, TJUJUSPIWTZ, PlayerSaveVersion> INDNQYCKUTZ;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9FB0", Offset = "0x8EB87B0", VA = "0x188EB9FB0")]
		public static TJUJUSPIWTZ? MLHXPUPWITR([Optional] QTKPTGGAORV? a, [Optional] EYHREWALFBN? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8EBAA70", Offset = "0x8EB9270", VA = "0x188EBAA70")]
		public static Result<ParseResult<TJUJUSPIWTZ>, GPJDWMBBLWO> RWKBMYDQNDR(ZVDGYJVWQXS a, byte[]? bytes)
		{
			return default(Result<ParseResult<TJUJUSPIWTZ>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA5F0", Offset = "0x8EB8DF0", VA = "0x188EBA5F0")]
		public static Result<ParseResult<TJUJUSPIWTZ>, GPJDWMBBLWO> RWKBMYDQNDR(ZVDGYJVWQXS deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<TJUJUSPIWTZ>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA0A0", Offset = "0x8EB88A0", VA = "0x188EBA0A0")]
		public static Result<None, GPJDWMBBLWO> MOHUAGDLCJE(ZVDGYJVWQXS a, TJUJUSPIWTZ b)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB420", Offset = "0x8EB9C20", VA = "0x188EBB420")]
		public static void WATFZETHJNE(TJUJUSPIWTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB1E0", Offset = "0x8EB99E0", VA = "0x188EBB1E0")]
		public static void WANZBXZKABV(TJUJUSPIWTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBAD40", Offset = "0x8EB9540", VA = "0x188EBAD40")]
		public static void WAISERFMQQM(TJUJUSPIWTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8EBAC10", Offset = "0x8EB9410", VA = "0x188EBAC10")]
		public static void WADLHKLPHFD(TJUJUSPIWTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBABA0", Offset = "0x8EB93A0", VA = "0x188EBABA0")]
		public static void VZYEKDRRXTU(TJUJUSPIWTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA400", Offset = "0x8EB8C00", VA = "0x188EBA400")]
		private static EYHREWALFBN NKHBTIGMVNV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA320", Offset = "0x8EB8B20", VA = "0x188EBA320")]
		private static EYHREWALFBN NKBUWBMPMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9F50", Offset = "0x8EB8750", VA = "0x188EB9F50")]
		[CompilerGenerated]
		internal static bool LTJNVIPQMCM(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA560", Offset = "0x8EB8D60", VA = "0x188EBA560")]
		[CompilerGenerated]
		internal static JURBOQXQJTS QOOLWNWPJHM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9EB0", Offset = "0x8EB86B0", VA = "0x188EB9EB0")]
		[CompilerGenerated]
		internal static float FEWOEJBPYVK(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB720", Offset = "0x8EB9F20", VA = "0x188EBB720")]
		[CompilerGenerated]
		internal static JURBOQXQJTS WKFJFFOFDDG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9F80", Offset = "0x8EB8780", VA = "0x188EB9F80")]
		[CompilerGenerated]
		internal static int MIMDOOKTBSZ(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB790", Offset = "0x8EB9F90", VA = "0x188EBB790")]
		[CompilerGenerated]
		internal static JURBOQXQJTS YVZLSWZLIPX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9D40", Offset = "0x8EB8540", VA = "0x188EB9D40")]
		[CompilerGenerated]
		internal static CircuitsQuat CYIBQXPOOOS(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA4E0", Offset = "0x8EB8CE0", VA = "0x188EBA4E0")]
		[CompilerGenerated]
		internal static JURBOQXQJTS QKUGACDYSZW(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA5D0", Offset = "0x8EB8DD0", VA = "0x188EBA5D0")]
		[CompilerGenerated]
		internal static string RLUZTLFJGLP(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9EE0", Offset = "0x8EB86E0", VA = "0x188EB9EE0")]
		[CompilerGenerated]
		internal static JURBOQXQJTS HOHEPPCQIBB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA240", Offset = "0x8EB8A40", VA = "0x188EBA240")]
		[CompilerGenerated]
		internal static CircuitsVec3 NDNSSHOKWTT(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB800", Offset = "0x8EBA000", VA = "0x188EBB800")]
		[CompilerGenerated]
		internal static JURBOQXQJTS YYFIQDIZKET(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBA1D0", Offset = "0x8EB89D0", VA = "0x188EBA1D0")]
		[CompilerGenerated]
		internal static int MPELGWHWOHM(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9E10", Offset = "0x8EB8610", VA = "0x188EB9E10")]
		[CompilerGenerated]
		internal static JURBOQXQJTS DWDGJOBBNII(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D080", Offset = "0x3C3B880", VA = "0x183C3D080")]
		[CompilerGenerated]
		internal static void QQVRLGSECES<a>(RepeatedField<HJXDSXBRHPP> a, Func<ByteString, a> deserialize, Func<a, JURBOQXQJTS> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class ZJMIRBEFRKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBAA0", Offset = "0x8EBA2A0", VA = "0x188EBBAA0")]
		public static GCACGDNUCYN MAMDZJXAUXP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBBC0", Offset = "0x8EBA3C0", VA = "0x188EBBBC0")]
		public static Result<ParseResult<GCACGDNUCYN>, GPJDWMBBLWO> RWKBMYDQNDR(HGQDAUCDXMH.ZVDGYJVWQXS a, byte[] b)
		{
			return default(Result<ParseResult<GCACGDNUCYN>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBCB0", Offset = "0x8EBA4B0", VA = "0x188EBBCB0")]
		public static Result<ParseResult<GCACGDNUCYN>, GPJDWMBBLWO> RWKBMYDQNDR(HGQDAUCDXMH.ZVDGYJVWQXS a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<GCACGDNUCYN>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBAF0", Offset = "0x8EBA2F0", VA = "0x188EBBAF0")]
		public static Result<None, GPJDWMBBLWO> MOHUAGDLCJE(HGQDAUCDXMH.ZVDGYJVWQXS a, GCACGDNUCYN b)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class WGCKNVOYIQI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9170", Offset = "0x8EB7970", VA = "0x188EB9170")]
		public static SpawnableTemplateData IRJDHEDKZQY([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8EB99C0", Offset = "0x8EB81C0", VA = "0x188EB99C0")]
		public static Result<ParseResult<SpawnableTemplateData>, GPJDWMBBLWO> RWKBMYDQNDR(HGQDAUCDXMH.ZVDGYJVWQXS a, NXBDBQDMYIZ.ZVDGYJVWQXS b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9390", Offset = "0x8EB7B90", VA = "0x188EB9390")]
		public static Result<None, GPJDWMBBLWO> MOHUAGDLCJE(HGQDAUCDXMH.ZVDGYJVWQXS a, NXBDBQDMYIZ.ZVDGYJVWQXS b, SpawnableTemplateData c)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9600", Offset = "0x8EB7E00", VA = "0x188EB9600")]
		private static Result<None, GPJDWMBBLWO> MUJNMLPZYBW(HGQDAUCDXMH.ZVDGYJVWQXS a, SpawnableTemplateData b)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8EB91F0", Offset = "0x8EB79F0", VA = "0x188EB91F0")]
		private static Result<None, GPJDWMBBLWO> KSQWHSONGOG(NXBDBQDMYIZ.ZVDGYJVWQXS a, SpawnableTemplateData b)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class NXBDBQDMYIZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public interface ZVDGYJVWQXS : LRSGRJVHVHQ<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public sealed class VOHKIDOFRIF : ZVDGYJVWQXS, LRSGRJVHVHQ<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static VOHKIDOFRIF QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			public SuperRoomVersion MZTEVLQTFHG()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xBB6D70", Offset = "0xBB5570", VA = "0x180BB6D70", Slot = "5")]
			public SuperRoomVersion QGCPQEOQHFM()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x1840760", Offset = "0x183EF60", VA = "0x181840760", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x2C713E0", Offset = "0x2C6FBE0", VA = "0x182C713E0", Slot = "7")]
			public bool YZGBABOODXH(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8EB8E80", Offset = "0x8EB7680", VA = "0x188EB8E80", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VOHKIDOFRIF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static Versioner<ZVDGYJVWQXS, SuperRoomData, SuperRoomVersion> INDNQYCKUTZ;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7880", Offset = "0x8EA6080", VA = "0x188EA7880")]
		public static SuperRoomData NELGNJPIXQR([Optional] EIZETXMNBMV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7980", Offset = "0x8EA6180", VA = "0x188EA7980")]
		public static Result<ParseResult<SuperRoomData>, GPJDWMBBLWO> RWKBMYDQNDR(ZVDGYJVWQXS a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7AB0", Offset = "0x8EA62B0", VA = "0x188EA7AB0")]
		public static Result<ParseResult<SuperRoomData>, GPJDWMBBLWO> RWKBMYDQNDR(ZVDGYJVWQXS a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7750", Offset = "0x8EA5F50", VA = "0x188EA7750")]
		public static Result<None, GPJDWMBBLWO> MOHUAGDLCJE(ZVDGYJVWQXS a, SuperRoomData b)
		{
			return default(Result<None, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7F90", Offset = "0x8EA6790", VA = "0x188EA7F90")]
		private static void WATFZETHJNE(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7E90", Offset = "0x8EA6690", VA = "0x188EA7E90")]
		private static void WANZBXZKABV(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7E00", Offset = "0x8EA6600", VA = "0x188EA7E00")]
		private static void WAISERFMQQM(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7D80", Offset = "0x8EA6580", VA = "0x188EA7D80")]
		private static void WADLHKLPHFD(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7440", Offset = "0x8EA5C40", VA = "0x188EA7440")]
		public static DataTableData FMKCGMZVETS(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7070", Offset = "0x8EA5870", VA = "0x188EA7070")]
		public static ProgressionManagerData ALYBBSEONPR(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7280", Offset = "0x8EA5A80", VA = "0x188EA7280")]
		[CompilerGenerated]
		internal static void BWUALWBPYOJ(RepeatedField<QGBKXLRIRXF> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class AFMOFOZIEAD : PLKCEVFUOFU
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0B70", Offset = "0x8E9F370", VA = "0x188EA0B70", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x290C1F0", Offset = "0x290A9F0", VA = "0x18290C1F0")]
		public AFMOFOZIEAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface LRSGRJVHVHQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b MZTEVLQTFHG();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b QGCPQEOQHFM();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool YZGBABOODXH(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class XSHJYEBEODB : PLKCEVFUOFU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private string DCZZXESDTNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private string WXTKQQQXLDI;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3B10", Offset = "0x8EA2310", VA = "0x188EA3B10")]
		public XSHJYEBEODB(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9CE0", Offset = "0x8EB84E0", VA = "0x188EB9CE0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AAD1C0", Offset = "0x5AAB9C0", VA = "0x185AAD1C0")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class EYZIZMKCMST
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x35D3880", Offset = "0x35D2080", VA = "0x1835D3880")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class FKFNWFTPJXE : PLKCEVFUOFU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string DCZZXESDTNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private string WXTKQQQXLDI;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3B10", Offset = "0x8EA2310", VA = "0x188EA3B10")]
		public FKFNWFTPJXE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3AB0", Offset = "0x8EA22B0", VA = "0x188EA3AB0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8EB8D80", Offset = "0x8EB7580", VA = "0x188EB8D80")]
		public static Guid? HGOJSJQHFXE(PHWYRKJBQIP a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : LRSGRJVHVHQ<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6685BC0", Offset = "0x66843C0", VA = "0x186685BC0")]
		public Result<TVersion, GPJDWMBBLWO> MOHUAGDLCJE(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6685B10", Offset = "0x6684310", VA = "0x186685B10")]
		public static VersionerFactory<TDeps, TData, TVersion> CYOPTWCDXLK()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class TPKTMYRKYMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public VersioningPhaseVoidDelegate<TData> DPPACFAHURU;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TPKTMYRKYMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5FAA250", Offset = "0x5FA8A50", VA = "0x185FAA250")]
			internal Result<None, GPJDWMBBLWO> NQEKQSTRVDE(TDeps a, TData b)
			{
				return default(Result<None, GPJDWMBBLWO>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6685450", Offset = "0x6683C50", VA = "0x186685450")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6685580", Offset = "0x6683D80", VA = "0x186685580")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class NAOHFRGDVZS
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x33E3B50", Offset = "0x33E2350", VA = "0x1833E3B50")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : LRSGRJVHVHQ<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class BCCZUYFDCDL : PLKCEVFUOFU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public readonly Exception XVQVQBCHTKO;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1917690", Offset = "0x1915E90", VA = "0x181917690")]
		public BCCZUYFDCDL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0CA0", Offset = "0x8E9F4A0", VA = "0x188EA0CA0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0BA0", Offset = "0x8E9F3A0", VA = "0x188EA0BA0", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class PLKCEVFUOFU : GPJDWMBBLWO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x290C1F0", Offset = "0x290A9F0", VA = "0x18290C1F0")]
		protected PLKCEVFUOFU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate Result<None, GPJDWMBBLWO> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
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
