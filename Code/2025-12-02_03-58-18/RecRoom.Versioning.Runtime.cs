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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D6A730", Offset = "0x8D69330", VA = "0x188D6A730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class AKDXFXBBAWL
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface HGULJDEHQOI : VRUABHGORIK<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class FTHXRLGPSAN : HGULJDEHQOI, VRUABHGORIK<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static FTHXRLGPSAN PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			public PersistedRoomVersion AXKGKNHQEXW()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8D67880", Offset = "0x8D66480", VA = "0x188D67880", Slot = "5")]
			public PersistedRoomVersion YWUJIKQMILA()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x17DA690", Offset = "0x17D9290", VA = "0x1817DA690", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2C37510", Offset = "0x2C36110", VA = "0x182C37510", Slot = "7")]
			public bool MEVUIEHYGBT(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D67830", Offset = "0x8D66430", VA = "0x188D67830", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FTHXRLGPSAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class DDDWLJACLMC
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static Dictionary<Guid, string[]> UZHEVWKMJZO;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D549B0", Offset = "0x8D535B0", VA = "0x188D549B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class RNRKCKCKOAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D71110", Offset = "0x8D6FD10", VA = "0x188D71110")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class ROMLRLDZZTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D713D0", Offset = "0x8D6FFD0", VA = "0x188D713D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class YODIDVQPUHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D72760", Offset = "0x8D71360", VA = "0x188D72760")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class YNYBGOWSKWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D72530", Offset = "0x8D71130", VA = "0x188D72530")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class ETDZDDLUDHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D67670", Offset = "0x8D66270", VA = "0x188D67670")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class KTHKWTNEEVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D69EF0", Offset = "0x8D68AF0", VA = "0x188D69EF0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class NPGVYURWLKW
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A410", Offset = "0x8D69010", VA = "0x188D6A410")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class NPBPBNXZBZN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A240", Offset = "0x8D68E40", VA = "0x188D6A240")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class HOSWKRCRRAE
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly Dictionary<Guid, int> YCWQPYMDDEB;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D67900", Offset = "0x8D66500", VA = "0x188D67900")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D68070", Offset = "0x8D66C70", VA = "0x188D68070")]
			private static Dictionary<Guid, NOEXDRYNADI> TXDFMUNQUUE(NOEXDRYNADI a, Dictionary<Guid, NOEXDRYNADI> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class HQTNJGTRHJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8D69B10", Offset = "0x8D68710", VA = "0x188D69B10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DCTIQVMHSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D547F0", Offset = "0x8D533F0", VA = "0x188D547F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class VMZLDSWEVWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D71990", Offset = "0x8D70590", VA = "0x188D71990")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D71C70", Offset = "0x8D70870", VA = "0x188D71C70")]
			private static void VULUFCHIPNW(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class VNJYYGJZOTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D71C80", Offset = "0x8D70880", VA = "0x188D71C80")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class VMOXJFIKCZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D715A0", Offset = "0x8D701A0", VA = "0x188D715A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class VOPOHUZJTJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D721C0", Offset = "0x8D70DC0", VA = "0x188D721C0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class VOKHKOFMJYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8D71E90", Offset = "0x8D70A90", VA = "0x188D71E90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class DDYYAKBRXFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8D674B0", Offset = "0x8D660B0", VA = "0x188D674B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class PLVQXUZHZDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A7B0", Offset = "0x8D693B0", VA = "0x188D6A7B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class PNBGHJOSDTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D70EC0", Offset = "0x8D6FAC0", VA = "0x188D70EC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class PMQSMWAXKXG
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
			private static class QAQHBNBMDLP
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid YRIRBVUDAEO
				{
					[Cpp2IlInjected.Token(Token = "0x600002C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D8A0", Offset = "0x8D7C4A0", VA = "0x188D7D8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid DHHDJPOLGZQ
				{
					[Cpp2IlInjected.Token(Token = "0x600002D")]
					[Cpp2IlInjected.Address(RVA = "0x8D827F0", Offset = "0x8D813F0", VA = "0x188D827F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid SHIBJEIOUPL
				{
					[Cpp2IlInjected.Token(Token = "0x600002E")]
					[Cpp2IlInjected.Address(RVA = "0x8D78820", Offset = "0x8D77420", VA = "0x188D78820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid PMXXXHNWYTR
				{
					[Cpp2IlInjected.Token(Token = "0x600002F")]
					[Cpp2IlInjected.Address(RVA = "0x8D850F0", Offset = "0x8D83CF0", VA = "0x188D850F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid OWJDVFEDTFL
				{
					[Cpp2IlInjected.Token(Token = "0x6000030")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CA20", Offset = "0x8D7B620", VA = "0x188D7CA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid IONSOLJIXCZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x8D83DF0", Offset = "0x8D829F0", VA = "0x188D83DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid IJLTQQWJIJC
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x8D84B70", Offset = "0x8D83770", VA = "0x188D84B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid JZWXQUVPOEX
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8D7ECF0", Offset = "0x8D7D8F0", VA = "0x188D7ECF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid LYFRBCMZNMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x8D803F0", Offset = "0x8D7EFF0", VA = "0x188D803F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid JCWKWYHAKCX
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8D84D70", Offset = "0x8D83970", VA = "0x188D84D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid QNXUGLEAANK
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x8D79EA0", Offset = "0x8D78AA0", VA = "0x188D79EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid SOWLQMXZASM
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x8D782A0", Offset = "0x8D76EA0", VA = "0x188D782A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid YRVOORDUOUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000038")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EE70", Offset = "0x8D7DA70", VA = "0x188D7EE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid XSFRTWQTGYT
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AF20", Offset = "0x8D79B20", VA = "0x188D7AF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid RGUAFKIIDYL
				{
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B820", Offset = "0x8D7A420", VA = "0x188D7B820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid OXEEVDNVXKU
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B8A0", Offset = "0x8D7A4A0", VA = "0x188D7B8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid INXDWVMHXNX
				{
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EEF0", Offset = "0x8D7DAF0", VA = "0x188D7EEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid PHSRWTJBRXV
				{
					[Cpp2IlInjected.Token(Token = "0x600003D")]
					[Cpp2IlInjected.Address(RVA = "0x8D84270", Offset = "0x8D82E70", VA = "0x188D84270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid ONAFYXTIRHQ
				{
					[Cpp2IlInjected.Token(Token = "0x600003E")]
					[Cpp2IlInjected.Address(RVA = "0x8D812F0", Offset = "0x8D7FEF0", VA = "0x188D812F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid QVBUIAVTSAS
				{
					[Cpp2IlInjected.Token(Token = "0x600003F")]
					[Cpp2IlInjected.Address(RVA = "0x8D84F70", Offset = "0x8D83B70", VA = "0x188D84F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid AFHEKFTAWZM
				{
					[Cpp2IlInjected.Token(Token = "0x6000040")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B6A0", Offset = "0x8D7A2A0", VA = "0x188D7B6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid TIUGZKSBISA
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x8D84E70", Offset = "0x8D83A70", VA = "0x188D84E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid OEVPWSWRBOE
				{
					[Cpp2IlInjected.Token(Token = "0x6000042")]
					[Cpp2IlInjected.Address(RVA = "0x8D833F0", Offset = "0x8D81FF0", VA = "0x188D833F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid TLZYHBMDAZO
				{
					[Cpp2IlInjected.Token(Token = "0x6000043")]
					[Cpp2IlInjected.Address(RVA = "0x8D83AF0", Offset = "0x8D826F0", VA = "0x188D83AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid CFNLRQGAYEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000044")]
					[Cpp2IlInjected.Address(RVA = "0x8D811F0", Offset = "0x8D7FDF0", VA = "0x188D811F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid SJSLVINNOVM
				{
					[Cpp2IlInjected.Token(Token = "0x6000045")]
					[Cpp2IlInjected.Address(RVA = "0x8D81EF0", Offset = "0x8D80AF0", VA = "0x188D81EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid DKRTHDMNSKY
				{
					[Cpp2IlInjected.Token(Token = "0x6000046")]
					[Cpp2IlInjected.Address(RVA = "0x8D856F0", Offset = "0x8D842F0", VA = "0x188D856F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid QJUVNCSDTJQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000047")]
					[Cpp2IlInjected.Address(RVA = "0x8D771A0", Offset = "0x8D75DA0", VA = "0x188D771A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid LJSIPJPLUPQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x8D774A0", Offset = "0x8D760A0", VA = "0x188D774A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid VGIEWHQPOJV
				{
					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x8D83F70", Offset = "0x8D82B70", VA = "0x188D83F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid VXOGVBPBTVH
				{
					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x8D81BF0", Offset = "0x8D807F0", VA = "0x188D81BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid VVRMXDXGOCS
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F770", Offset = "0x8D7E370", VA = "0x188D7F770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid BRHHBZPRLRQ
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AD20", Offset = "0x8D79920", VA = "0x188D7AD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid CKLUOQCOSER
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x8D80E70", Offset = "0x8D7FA70", VA = "0x188D80E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid OMIFFCTWPGF
				{
					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E1F0", Offset = "0x8D7CDF0", VA = "0x188D7E1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid XKCBREHAYHW
				{
					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x8D845F0", Offset = "0x8D831F0", VA = "0x188D845F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid AQWHODGNWYY
				{
					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8D77820", Offset = "0x8D76420", VA = "0x188D77820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid QZRGTWESMTL
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8D839F0", Offset = "0x8D825F0", VA = "0x188D839F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid KUKLRBMFSQV
				{
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x8D84A70", Offset = "0x8D83670", VA = "0x188D84A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid LKJYGKJKLXU
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8D832F0", Offset = "0x8D81EF0", VA = "0x188D832F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid NXPVTZGTVLP
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A320", Offset = "0x8D78F20", VA = "0x188D7A320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid XEBBOUJQYHQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000055")]
					[Cpp2IlInjected.Address(RVA = "0x8D78320", Offset = "0x8D76F20", VA = "0x188D78320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid VRABWQLJRCY
				{
					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x8D792A0", Offset = "0x8D77EA0", VA = "0x188D792A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid QURAKWQNZLA
				{
					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D970", Offset = "0x8D7C570", VA = "0x188D7D970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid OLIPREGCDWU
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BD20", Offset = "0x8D7A920", VA = "0x188D7BD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid ESISVUVKUPN
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CFA0", Offset = "0x8D7BBA0", VA = "0x188D7CFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid VOOJMZHHXKC
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x8D79BA0", Offset = "0x8D787A0", VA = "0x188D79BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid JPXGRZYOCID
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8D86DF0", Offset = "0x8D859F0", VA = "0x188D86DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid RTJDXKZSMWO
				{
					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8D775A0", Offset = "0x8D761A0", VA = "0x188D775A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid ENDSSIIKNJK
				{
					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C420", Offset = "0x8D7B020", VA = "0x188D7C420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid RCDAZHJLPPN
				{
					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8D816F0", Offset = "0x8D802F0", VA = "0x188D816F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid RJRBZKBNKSB
				{
					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A020", Offset = "0x8D78C20", VA = "0x188D7A020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid DQZFKUEXMSB
				{
					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8D777A0", Offset = "0x8D763A0", VA = "0x188D777A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid CTFKFHCVAXT
				{
					[Cpp2IlInjected.Token(Token = "0x6000061")]
					[Cpp2IlInjected.Address(RVA = "0x8D86AF0", Offset = "0x8D856F0", VA = "0x188D86AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid LEXDTJUUZTK
				{
					[Cpp2IlInjected.Token(Token = "0x6000062")]
					[Cpp2IlInjected.Address(RVA = "0x8D834F0", Offset = "0x8D820F0", VA = "0x188D834F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid APFKALXWDAO
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8D80170", Offset = "0x8D7ED70", VA = "0x188D80170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid JHWTPSYLUBR
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8D83C70", Offset = "0x8D82870", VA = "0x188D83C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid WXTWHWTCBPM
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8D84070", Offset = "0x8D82C70", VA = "0x188D84070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid OKEOWPZCYNC
				{
					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8D81370", Offset = "0x8D7FF70", VA = "0x188D81370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid DDRYVEGLALX
				{
					[Cpp2IlInjected.Token(Token = "0x6000067")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C720", Offset = "0x8D7B320", VA = "0x188D7C720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid QZPVIVBLARA
				{
					[Cpp2IlInjected.Token(Token = "0x6000068")]
					[Cpp2IlInjected.Address(RVA = "0x8D84970", Offset = "0x8D83570", VA = "0x188D84970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid GSDHHHTEOGB
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0x8D85E70", Offset = "0x8D84A70", VA = "0x188D85E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid TFUQWFSQNUD
				{
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0x8D80870", Offset = "0x8D7F470", VA = "0x188D80870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid UXZYLIIPURV
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C320", Offset = "0x8D7AF20", VA = "0x188D7C320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid JPPJVUNLVFP
				{
					[Cpp2IlInjected.Token(Token = "0x600006C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E7F0", Offset = "0x8D7D3F0", VA = "0x188D7E7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid EGAKOMHZULJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006D")]
					[Cpp2IlInjected.Address(RVA = "0x8D87570", Offset = "0x8D86170", VA = "0x188D87570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid CHLWSBBDKEP
				{
					[Cpp2IlInjected.Token(Token = "0x600006E")]
					[Cpp2IlInjected.Address(RVA = "0x8D82A70", Offset = "0x8D81670", VA = "0x188D82A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid FZSPGIQENJJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006F")]
					[Cpp2IlInjected.Address(RVA = "0x8D86E70", Offset = "0x8D85A70", VA = "0x188D86E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid EDSTCYKSWNE
				{
					[Cpp2IlInjected.Token(Token = "0x6000070")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A420", Offset = "0x8D79020", VA = "0x188D7A420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid WWCPPNDJYZB
				{
					[Cpp2IlInjected.Token(Token = "0x6000071")]
					[Cpp2IlInjected.Address(RVA = "0x8D796A0", Offset = "0x8D782A0", VA = "0x188D796A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid ICRIKVYRRAV
				{
					[Cpp2IlInjected.Token(Token = "0x6000072")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AA20", Offset = "0x8D79620", VA = "0x188D7AA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid KODQWYSAAKG
				{
					[Cpp2IlInjected.Token(Token = "0x6000073")]
					[Cpp2IlInjected.Address(RVA = "0x8D83A70", Offset = "0x8D82670", VA = "0x188D83A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid SZDYMWJFBBA
				{
					[Cpp2IlInjected.Token(Token = "0x6000074")]
					[Cpp2IlInjected.Address(RVA = "0x8D78F20", Offset = "0x8D77B20", VA = "0x188D78F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid DRJSSQUWYFT
				{
					[Cpp2IlInjected.Token(Token = "0x6000075")]
					[Cpp2IlInjected.Address(RVA = "0x8D805F0", Offset = "0x8D7F1F0", VA = "0x188D805F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid MURJIFKBTFK
				{
					[Cpp2IlInjected.Token(Token = "0x6000076")]
					[Cpp2IlInjected.Address(RVA = "0x8D80070", Offset = "0x8D7EC70", VA = "0x188D80070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid AMCUYLTLYBB
				{
					[Cpp2IlInjected.Token(Token = "0x6000077")]
					[Cpp2IlInjected.Address(RVA = "0x8D83E70", Offset = "0x8D82A70", VA = "0x188D83E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid DADXOCOWOFL
				{
					[Cpp2IlInjected.Token(Token = "0x6000078")]
					[Cpp2IlInjected.Address(RVA = "0x8D7ABA0", Offset = "0x8D797A0", VA = "0x188D7ABA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid WDBBLQSUFXG
				{
					[Cpp2IlInjected.Token(Token = "0x6000079")]
					[Cpp2IlInjected.Address(RVA = "0x8D838F0", Offset = "0x8D824F0", VA = "0x188D838F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid RRAODVQXIQG
				{
					[Cpp2IlInjected.Token(Token = "0x600007A")]
					[Cpp2IlInjected.Address(RVA = "0x8D80A70", Offset = "0x8D7F670", VA = "0x188D80A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid NKYXGDKRCDI
				{
					[Cpp2IlInjected.Token(Token = "0x600007B")]
					[Cpp2IlInjected.Address(RVA = "0x8D84170", Offset = "0x8D82D70", VA = "0x188D84170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid GRYXDVELIBJ
				{
					[Cpp2IlInjected.Token(Token = "0x600007C")]
					[Cpp2IlInjected.Address(RVA = "0x8D786A0", Offset = "0x8D772A0", VA = "0x188D786A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid JVSCQCNOZGG
				{
					[Cpp2IlInjected.Token(Token = "0x600007D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DF70", Offset = "0x8D7CB70", VA = "0x188D7DF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid NJFWKFQZYGB
				{
					[Cpp2IlInjected.Token(Token = "0x600007E")]
					[Cpp2IlInjected.Address(RVA = "0x8D85470", Offset = "0x8D84070", VA = "0x188D85470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid COJHCVAPYBD
				{
					[Cpp2IlInjected.Token(Token = "0x600007F")]
					[Cpp2IlInjected.Address(RVA = "0x8D843F0", Offset = "0x8D82FF0", VA = "0x188D843F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid KVRSJOFYTRB
				{
					[Cpp2IlInjected.Token(Token = "0x6000080")]
					[Cpp2IlInjected.Address(RVA = "0x8D78AA0", Offset = "0x8D776A0", VA = "0x188D78AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid HOAVFVUEICU
				{
					[Cpp2IlInjected.Token(Token = "0x6000081")]
					[Cpp2IlInjected.Address(RVA = "0x8D82E70", Offset = "0x8D81A70", VA = "0x188D82E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid FYCYCAXKJTS
				{
					[Cpp2IlInjected.Token(Token = "0x6000082")]
					[Cpp2IlInjected.Address(RVA = "0x8D86570", Offset = "0x8D85170", VA = "0x188D86570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid IAAXPHIIOOH
				{
					[Cpp2IlInjected.Token(Token = "0x6000083")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B7A0", Offset = "0x8D7A3A0", VA = "0x188D7B7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid AVXJFOJCHIM
				{
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F4F0", Offset = "0x8D7E0F0", VA = "0x188D7F4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid YOSNJUREOPZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000085")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A120", Offset = "0x8D78D20", VA = "0x188D7A120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid ZUYPGFKSBBZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000086")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E570", Offset = "0x8D7D170", VA = "0x188D7E570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid QIRSRAPQIQE
				{
					[Cpp2IlInjected.Token(Token = "0x6000087")]
					[Cpp2IlInjected.Address(RVA = "0x8D86A70", Offset = "0x8D85670", VA = "0x188D86A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid FUCTBQSKSKK
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0x8D82C70", Offset = "0x8D81870", VA = "0x188D82C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid WYNHBCNWFUZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0x8D85F70", Offset = "0x8D84B70", VA = "0x188D85F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid EGPHVDZGOWZ
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0x8D83CF0", Offset = "0x8D828F0", VA = "0x188D83CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid WUCARHPZNID
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0x8D82D70", Offset = "0x8D81970", VA = "0x188D82D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid DBKFNXSGMFG
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CDA0", Offset = "0x8D7B9A0", VA = "0x188D7CDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid MYGYEADOOIL
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0x8D86170", Offset = "0x8D84D70", VA = "0x188D86170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid TDCIGBEVNXM
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0x8D837F0", Offset = "0x8D823F0", VA = "0x188D837F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid TCRULNRAVAU
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D822F0", VA = "0x188D836F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid LLTRUGRSFDR
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0x8D82770", Offset = "0x8D81370", VA = "0x188D82770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid LOPKHXKHHGN
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0x8D828F0", Offset = "0x8D814F0", VA = "0x188D828F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid LOEWNJWMOJV
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0x8D82970", Offset = "0x8D81570", VA = "0x188D82970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid CYCNQQJXQUX
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0x8D801F0", Offset = "0x8D7EDF0", VA = "0x188D801F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid MJLNTPQHFSJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0x8D79CA0", Offset = "0x8D788A0", VA = "0x188D79CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid XFLAARICREV
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D8F0", Offset = "0x8D7C4F0", VA = "0x188D7D8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid XMLXLKTILZO
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0x8D82CF0", Offset = "0x8D818F0", VA = "0x188D82CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid EHOXIMNMVTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0x8D85EF0", Offset = "0x8D84AF0", VA = "0x188D85EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid QQRTEPGUTSX
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0x8D778A0", Offset = "0x8D764A0", VA = "0x188D778A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid RQRHSSFNLOO
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E2F0", Offset = "0x8D7CEF0", VA = "0x188D7E2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid PAPQJIZZZRF
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0x8D788A0", Offset = "0x8D774A0", VA = "0x188D788A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid QRKAPJMGAOE
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0x8D858F0", Offset = "0x8D844F0", VA = "0x188D858F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid ZEJZBDUITRW
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0x8D81470", Offset = "0x8D80070", VA = "0x188D81470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid QJWJNIWSAPS
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D220", Offset = "0x8D7BE20", VA = "0x188D7D220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid IWQFCLPJXWZ
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BAA0", Offset = "0x8D7A6A0", VA = "0x188D7BAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid AJRMBEBIAHO
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0x8D80F70", Offset = "0x8D7FB70", VA = "0x188D80F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid UTEYOMLTUDZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0x8D802F0", Offset = "0x8D7EEF0", VA = "0x188D802F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid TPFNRVPNQQI
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B020", Offset = "0x8D79C20", VA = "0x188D7B020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid YFLRZVWFVAA
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0x8D82DF0", Offset = "0x8D819F0", VA = "0x188D82DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid GJKMROISLXB
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0x8D854F0", Offset = "0x8D840F0", VA = "0x188D854F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid BKUTCNBUSJM
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BE20", Offset = "0x8D7AA20", VA = "0x188D7BE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid GDSQLBIFCVK
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0x8D847F0", Offset = "0x8D833F0", VA = "0x188D847F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid LTBFYSEZOSA
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A1A0", Offset = "0x8D78DA0", VA = "0x188D7A1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid PPWGDETZOZE
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0x8D842F0", Offset = "0x8D82EF0", VA = "0x188D842F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid BLPNOJYXOLJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D020", Offset = "0x8D7BC20", VA = "0x188D7D020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid KVFLNONGSYB
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0x8D87170", Offset = "0x8D85D70", VA = "0x188D87170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid LOGONNYWGOO
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0x8D82370", Offset = "0x8D80F70", VA = "0x188D82370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid JUGOLGWTAZF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x8D86B70", Offset = "0x8D85770", VA = "0x188D86B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid VVPZQRELTJL
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x8D861F0", Offset = "0x8D84DF0", VA = "0x188D861F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid XLVLDBLJXDL
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x8D83570", Offset = "0x8D82170", VA = "0x188D83570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid CDQWZUFEDQN
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D320", Offset = "0x8D7BF20", VA = "0x188D7D320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid WVXCTVQCBXY
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F870", Offset = "0x8D7E470", VA = "0x188D7F870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid IHWPTCUWJWD
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x8D84FF0", Offset = "0x8D83BF0", VA = "0x188D84FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid ZHXFPEVROKU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x8D85FF0", Offset = "0x8D84BF0", VA = "0x188D85FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid PEQYVASMCOQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x8D78C20", Offset = "0x8D77820", VA = "0x188D78C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid ENVGXSOFHPE
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x8D77EA0", Offset = "0x8D76AA0", VA = "0x188D77EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid AUHFZYTKAFN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x8D821F0", Offset = "0x8D80DF0", VA = "0x188D821F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid PNGHUIMVBNM
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x8D82EF0", Offset = "0x8D81AF0", VA = "0x188D82EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid ERZPHZELNBL
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x8D781A0", Offset = "0x8D76DA0", VA = "0x188D781A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid PEKSDMZHRDO
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x8D77920", Offset = "0x8D76520", VA = "0x188D77920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid EGPAISSRKAB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x8D871F0", Offset = "0x8D85DF0", VA = "0x188D871F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid ZZVIPJYJUBJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x8D81DF0", Offset = "0x8D809F0", VA = "0x188D81DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid TSATUAHMGLF
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EB70", Offset = "0x8D7D770", VA = "0x188D7EB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid PUOBECKQRQG
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0x8D82070", Offset = "0x8D80C70", VA = "0x188D82070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid LCTMUWPFORR
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AAA0", Offset = "0x8D796A0", VA = "0x188D7AAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid RNPNBUTZEPK
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0x8D789A0", Offset = "0x8D775A0", VA = "0x188D789A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid BUJFEDQEKFJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DBF0", Offset = "0x8D7C7F0", VA = "0x188D7DBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid FZAYEEEDWQW
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0x8D804F0", Offset = "0x8D7F0F0", VA = "0x188D804F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid JSFBLZSIFIB
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C3A0", Offset = "0x8D7AFA0", VA = "0x188D7C3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid IAIENUHYOAN
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0x8D795A0", Offset = "0x8D781A0", VA = "0x188D795A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid XQDLTCLIJSF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A820", Offset = "0x8D79420", VA = "0x188D7A820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid RRWTZFOSRHT
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E770", Offset = "0x8D7D370", VA = "0x188D7E770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid KUCHYAUOTAL
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0x8D79B20", Offset = "0x8D78720", VA = "0x188D79B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid ESDUIWWVRAE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0x8D79820", Offset = "0x8D78420", VA = "0x188D79820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid OPZHWXBEVAZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0x8D862F0", Offset = "0x8D84EF0", VA = "0x188D862F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid DTQCXZWZDSZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D720", Offset = "0x8D7C320", VA = "0x188D7D720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid LZEJHTUOTBM
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0x8D77420", Offset = "0x8D76020", VA = "0x188D77420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid XEWYLEDQDVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0x8D81A70", Offset = "0x8D80670", VA = "0x188D81A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid WVITWLMDYWZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0x8D83670", Offset = "0x8D82270", VA = "0x188D83670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid PTTKXCWAETP
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DD70", Offset = "0x8D7C970", VA = "0x188D7DD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid HZLUOBLANFK
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0x8D80AF0", Offset = "0x8D7F6F0", VA = "0x188D80AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid KYMYKHTTTSQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CF20", Offset = "0x8D7BB20", VA = "0x188D7CF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid BKIMOFCHPYO
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DAF0", Offset = "0x8D7C6F0", VA = "0x188D7DAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid ZSNCPVOFVDF
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B420", Offset = "0x8D7A020", VA = "0x188D7B420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid RWHGQXDAJZX
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x8D87470", Offset = "0x8D86070", VA = "0x188D87470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid HAXJVILYTFY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0x8D86370", Offset = "0x8D84F70", VA = "0x188D86370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid NVRTHMOBHWM
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0x8D87070", Offset = "0x8D85C70", VA = "0x188D87070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid JLZBYQBZTUY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x8D873F0", Offset = "0x8D85FF0", VA = "0x188D873F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid STYKZRGTUIE
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0x8D78B20", Offset = "0x8D77720", VA = "0x188D78B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid POTHJXACGWC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0x8D79120", Offset = "0x8D77D20", VA = "0x188D79120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid YCEJEBPVLKL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0x8D79420", Offset = "0x8D78020", VA = "0x188D79420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid VMJIYZUTBHJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0x8D780A0", Offset = "0x8D76CA0", VA = "0x188D780A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid VKUBFNWPZUY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0x8D86FF0", Offset = "0x8D85BF0", VA = "0x188D86FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid WZIJRSWINYW
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0x8D794A0", Offset = "0x8D780A0", VA = "0x188D794A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid WHVMKQJJCOE
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F8F0", Offset = "0x8D7E4F0", VA = "0x188D7F8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid VQTRMZRKOXR
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0x8D86CF0", Offset = "0x8D858F0", VA = "0x188D86CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid IOXGUSHDLCD
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0x8D841F0", Offset = "0x8D82DF0", VA = "0x188D841F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid DMHKDEVNYDG
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FBF0", Offset = "0x8D7E7F0", VA = "0x188D7FBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid ZOPDTLTDMSX
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0x8D79920", Offset = "0x8D78520", VA = "0x188D79920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid LQSDXPYXYMD
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0x8D83D70", Offset = "0x8D82970", VA = "0x188D83D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid HONDHITTSHH
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0x8D81CF0", Offset = "0x8D808F0", VA = "0x188D81CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid SATMJEQTDNO
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A2A0", Offset = "0x8D78EA0", VA = "0x188D7A2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid VABTQKEVNAS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0x8D81970", Offset = "0x8D80570", VA = "0x188D81970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid DNDMWVRNEEI
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0x8D81AF0", Offset = "0x8D806F0", VA = "0x188D81AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid JWRGTYKIWLW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A8A0", Offset = "0x8D794A0", VA = "0x188D7A8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid RBMJRLGOILN
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0x8D84370", Offset = "0x8D82F70", VA = "0x188D84370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid IBKVZAZRKHR
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0x8D844F0", Offset = "0x8D830F0", VA = "0x188D844F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid EAHTINXJSMQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B0A0", Offset = "0x8D79CA0", VA = "0x188D7B0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid KZYJZQBIADA
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CE20", Offset = "0x8D7BA20", VA = "0x188D7CE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid TCWRBQURPLX
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0x8D80B70", Offset = "0x8D7F770", VA = "0x188D80B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid ESPWPOSYMZQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0x8D80370", Offset = "0x8D7EF70", VA = "0x188D80370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid CLFUSUBJCXJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B5A0", Offset = "0x8D7A1A0", VA = "0x188D7B5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid CULTZTQYQXK
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0x8D83770", Offset = "0x8D82370", VA = "0x188D83770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid XSYCGSDVCME
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0x8D866F0", Offset = "0x8D852F0", VA = "0x188D866F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid VBTGVUDMJFT
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DA70", Offset = "0x8D7C670", VA = "0x188D7DA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid FFYZFDKBSTH
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0x8D86EF0", Offset = "0x8D85AF0", VA = "0x188D86EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid EDOQHIWYKKQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0x8D859F0", Offset = "0x8D845F0", VA = "0x188D859F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid LKWUGRBEXPG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0x8D77520", Offset = "0x8D76120", VA = "0x188D77520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid ELGWKQROFVL
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0x8D84670", Offset = "0x8D83270", VA = "0x188D84670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid VHQUKDIFPZN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0x8D82AF0", Offset = "0x8D816F0", VA = "0x188D82AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid ISKNOIAJLSD
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0x8D776A0", Offset = "0x8D762A0", VA = "0x188D776A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid WPZDJIPUYAW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CEA0", Offset = "0x8D7BAA0", VA = "0x188D7CEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid BHVLERRHNRN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0x8D85BF0", Offset = "0x8D847F0", VA = "0x188D85BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid TPFPOAANVNN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DCF0", Offset = "0x8D7C8F0", VA = "0x188D7DCF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid DAXPFSTGQCX
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8D79DA0", Offset = "0x8D789A0", VA = "0x188D79DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid DKIHKJQWEFW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E470", Offset = "0x8D7D070", VA = "0x188D7E470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid TLOKQCYRCKG
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C820", Offset = "0x8D7B420", VA = "0x188D7C820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid ZPWGKKGHBVT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CC20", Offset = "0x8D7B820", VA = "0x188D7CC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid JIUABQFHJFB
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A5A0", Offset = "0x8D791A0", VA = "0x188D7A5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid DXQQMYWEZRR
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B3A0", Offset = "0x8D79FA0", VA = "0x188D7B3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid DSQKFWSHDTP
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0x8D85170", Offset = "0x8D83D70", VA = "0x188D85170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid PPJZKLLDZCT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0x8D819F0", Offset = "0x8D805F0", VA = "0x188D819F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid HPTLLSNVYUT
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0x8D809F0", Offset = "0x8D7F5F0", VA = "0x188D809F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid RTIDIBYBYMR
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D420", Offset = "0x8D7C020", VA = "0x188D7D420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid ATJGAVUQMDI
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0x8D78220", Offset = "0x8D76E20", VA = "0x188D78220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid ZNVXISGJXWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0x8D86070", Offset = "0x8D84C70", VA = "0x188D86070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid AKVDVHQDSZF
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0x8D799A0", Offset = "0x8D785A0", VA = "0x188D799A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid IQATTCGLWWH
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0x8D82470", Offset = "0x8D81070", VA = "0x188D82470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid FLTFQMVGZLL
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0x8D78DA0", Offset = "0x8D779A0", VA = "0x188D78DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid UEPMYRFLOAY
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0x8D83BF0", Offset = "0x8D827F0", VA = "0x188D83BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid XHWHEXBKYNQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x8D85CF0", Offset = "0x8D848F0", VA = "0x188D85CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid SMCIEYMIFUU
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BFA0", Offset = "0x8D7ABA0", VA = "0x188D7BFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid JRZRNMGUARO
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D9F0", Offset = "0x8D7C5F0", VA = "0x188D7D9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid UZITDSVECDN
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DDF0", Offset = "0x8D7C9F0", VA = "0x188D7DDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid NZQNSLRHDWF
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0x8D86D70", Offset = "0x8D85970", VA = "0x188D86D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid LURTLBRNYJJ
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0x8D79E20", Offset = "0x8D78A20", VA = "0x188D79E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid EMWBCLJNIRM
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0x8D81070", Offset = "0x8D7FC70", VA = "0x188D81070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid WTQUSLLDAQJ
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B620", Offset = "0x8D7A220", VA = "0x188D7B620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid RXNTVEQBCAC
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0x8D83EF0", Offset = "0x8D82AF0", VA = "0x188D83EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid VZLADLBJXFL
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F3F0", Offset = "0x8D7DFF0", VA = "0x188D7F3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid NVWMDHMNALH
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DE70", Offset = "0x8D7CA70", VA = "0x188D7DE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid LRWWIBMSMEC
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0x8D875F0", Offset = "0x8D861F0", VA = "0x188D875F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid KLLLLSBBRLG
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0x8D85D70", Offset = "0x8D84970", VA = "0x188D85D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid RXFHPHTKXDX
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A220", Offset = "0x8D78E20", VA = "0x188D7A220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid FUZNBRIXFPP
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DC70", Offset = "0x8D7C870", VA = "0x188D7DC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid VBUVJBZURKF
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AC20", Offset = "0x8D79820", VA = "0x188D7AC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid BQLFHENCGQI
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D520", Offset = "0x8D7C120", VA = "0x188D7D520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid QLBSZHHJPCL
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0x8D797A0", Offset = "0x8D783A0", VA = "0x188D797A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid KDTQIKXSVKY
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0x8D80770", Offset = "0x8D7F370", VA = "0x188D80770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid HETXTTCQONI
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FE70", Offset = "0x8D7EA70", VA = "0x188D7FE70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid HUQLQRRHQLO
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E5F0", Offset = "0x8D7D1F0", VA = "0x188D7E5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid SVUKICHHTBT
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x8D82670", Offset = "0x8D81270", VA = "0x188D82670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid DRFPIDZZIEJ
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0x8D791A0", Offset = "0x8D77DA0", VA = "0x188D791A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid GIHWHFGDBAZ
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AE20", Offset = "0x8D79A20", VA = "0x188D7AE20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid ZHPKEMXPGTM
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x8D835F0", Offset = "0x8D821F0", VA = "0x188D835F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid LAOCIJVBXNK
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C020", Offset = "0x8D7AC20", VA = "0x188D7C020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid QLUFLWVNBPT
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0x8D779A0", Offset = "0x8D765A0", VA = "0x188D779A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid RHKCCIYWESH
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x8D87370", Offset = "0x8D85F70", VA = "0x188D87370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid YEYSKPPJVUT
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D5A0", Offset = "0x8D7C1A0", VA = "0x188D7D5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid IGHXTLQKNHD
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x8D79F20", Offset = "0x8D78B20", VA = "0x188D79F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid CAMKMSCOFLK
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0x8D80FF0", Offset = "0x8D7FBF0", VA = "0x188D80FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid AMXBFOCLQRX
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0x8D826F0", Offset = "0x8D812F0", VA = "0x188D826F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid JEFVSIYXEOT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0x8D84AF0", Offset = "0x8D836F0", VA = "0x188D84AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid GIDYIZQYAEQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x8D80C70", Offset = "0x8D7F870", VA = "0x188D80C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid FJSBGIPXWSI
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E3F0", Offset = "0x8D7CFF0", VA = "0x188D7E3F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid QFNXVNBILTJ
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BC20", Offset = "0x8D7A820", VA = "0x188D7BC20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid CJDNTXGKNEI
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0x8D85DF0", Offset = "0x8D849F0", VA = "0x188D85DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid JTQCAYEYXEB
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AFA0", Offset = "0x8D79BA0", VA = "0x188D7AFA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid OOQDXAKIWKC
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0x8D87670", Offset = "0x8D86270", VA = "0x188D87670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid JJWHDIDHJGJ
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F970", Offset = "0x8D7E570", VA = "0x188D7F970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid ITKWDKAHNRM
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0x8D78E20", Offset = "0x8D77A20", VA = "0x188D78E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid TXLYOTABXBP
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0x8D79C20", Offset = "0x8D78820", VA = "0x188D79C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid VATNSLHOCZC
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F670", Offset = "0x8D7E270", VA = "0x188D7F670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid YQKRTBZASQL
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0x8D77620", Offset = "0x8D76220", VA = "0x188D77620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid RXEAWDJDYRS
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FB70", Offset = "0x8D7E770", VA = "0x188D7FB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid LUSYKGSSIDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x8D84770", Offset = "0x8D83370", VA = "0x188D84770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid FCYOIPRZAGZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x8D817F0", Offset = "0x8D803F0", VA = "0x188D817F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid KSZROTKGGTI
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A520", Offset = "0x8D79120", VA = "0x188D7A520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid ZLVGSUTWYVV
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x8D83970", Offset = "0x8D82570", VA = "0x188D83970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid IOMANMFSJMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x8D82570", Offset = "0x8D81170", VA = "0x188D82570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid YKYCPEOYRZB
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BBA0", Offset = "0x8D7A7A0", VA = "0x188D7BBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid NRWLOULOVXU
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x8D851F0", Offset = "0x8D83DF0", VA = "0x188D851F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid EDPWYSZQYPM
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0x8D84BF0", Offset = "0x8D837F0", VA = "0x188D84BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid OPJRNDLQQDA
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D2A0", Offset = "0x8D7BEA0", VA = "0x188D7D2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid HNKBKKUGQTG
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8D87870", Offset = "0x8D86470", VA = "0x188D87870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid UXYQNYWIDMS
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8D80970", Offset = "0x8D7F570", VA = "0x188D80970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid TMAQGHAWMFL
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0x8D785A0", Offset = "0x8D771A0", VA = "0x188D785A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid UXTJQSCKUBJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0x8D807F0", Offset = "0x8D7F3F0", VA = "0x188D807F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid UXOCTLINKQA
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0x8D808F0", Offset = "0x8D7F4F0", VA = "0x188D808F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid FCZBZEAKHBY
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BA20", Offset = "0x8D7A620", VA = "0x188D7BA20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid GGHLSJUUQVX
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F2F0", Offset = "0x8D7DEF0", VA = "0x188D7F2F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid GFRRAPNCONW
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F270", Offset = "0x8D7DE70", VA = "0x188D7F270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid JCUNTVKGHDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x8D863F0", Offset = "0x8D84FF0", VA = "0x188D863F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid WIOJGEFNFYE
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x8D846F0", Offset = "0x8D832F0", VA = "0x188D846F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid JGNQZEOBYVJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EDF0", Offset = "0x8D7D9F0", VA = "0x188D7EDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid ACHNHACIEMU
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x8D793A0", Offset = "0x8D77FA0", VA = "0x188D793A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid DWZXCLKNDTI
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F070", Offset = "0x8D7DC70", VA = "0x188D7F070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid DNYJSUPCLCB
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0x8D874F0", Offset = "0x8D860F0", VA = "0x188D874F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid NMBZULMIQUP
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B320", Offset = "0x8D79F20", VA = "0x188D7B320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid NVSYGGTBOZN
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A9A0", Offset = "0x8D795A0", VA = "0x188D7A9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid WROKKNPOPRW
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CAA0", Offset = "0x8D7B6A0", VA = "0x188D7CAA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid VCUDLOGJYTH
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0x8D818F0", Offset = "0x8D804F0", VA = "0x188D818F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid MTCBJJEARVB
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0x8D790A0", Offset = "0x8D77CA0", VA = "0x188D790A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid KEGSAFSAGBT
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0x8D79FA0", Offset = "0x8D78BA0", VA = "0x188D79FA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid VXMSTLZFCZK
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0x8D78BA0", Offset = "0x8D777A0", VA = "0x188D78BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid NLWQPZDFDPB
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0x8D784A0", Offset = "0x8D770A0", VA = "0x188D784A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid LXXATJVQYNM
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0x8D869F0", Offset = "0x8D855F0", VA = "0x188D869F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid DSTYZOVQRFA
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0x8D79AA0", Offset = "0x8D786A0", VA = "0x188D79AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid FUWTPFVARCU
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0x8D80DF0", Offset = "0x8D7F9F0", VA = "0x188D80DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid QLQFNNHALJD
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0x8D81E70", Offset = "0x8D80A70", VA = "0x188D81E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid TWNWBLQNLZC
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D7A0", Offset = "0x8D7C3A0", VA = "0x188D7D7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid TQYZKKQRCBN
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C520", Offset = "0x8D7B120", VA = "0x188D7C520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid AZIYTMTASCQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C1A0", Offset = "0x8D7ADA0", VA = "0x188D7C1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid WITPHJHNRJT
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0x8D864F0", Offset = "0x8D850F0", VA = "0x188D864F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid WDFAWQQYKJH
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0x8D79720", Offset = "0x8D78320", VA = "0x188D79720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid PJGTGVUGMIV
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B120", Offset = "0x8D79D20", VA = "0x188D7B120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid VYGLWRGFBFE
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DFF0", Offset = "0x8D7CBF0", VA = "0x188D7DFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid SLDEGXOVFEW
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0x8D85AF0", Offset = "0x8D846F0", VA = "0x188D85AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid YSVOVJKQWAP
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0x8D870F0", Offset = "0x8D85CF0", VA = "0x188D870F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid AWAELGFXQYN
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0x8D85970", Offset = "0x8D84570", VA = "0x188D85970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid JDYPXDBKTBG
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0x8D85870", Offset = "0x8D84470", VA = "0x188D85870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid IYSDAGSHPQF
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F170", Offset = "0x8D7DD70", VA = "0x188D7F170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid BMTZXWGMHNB
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0x8D79020", Offset = "0x8D77C20", VA = "0x188D79020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid OAGBCXXSECX
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BF20", Offset = "0x8D7AB20", VA = "0x188D7BF20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid RQEBQVBYXVP
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0x8D78EA0", Offset = "0x8D77AA0", VA = "0x188D78EA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid FAFDZZQLVDS
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0x8D78720", Offset = "0x8D77320", VA = "0x188D78720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid TWFROSKUYIF
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0x8D86470", Offset = "0x8D85070", VA = "0x188D86470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid OTVUYQAESVX
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0x8D815F0", Offset = "0x8D801F0", VA = "0x188D815F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid TLQZGCPTRXX
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0x8D830F0", Offset = "0x8D81CF0", VA = "0x188D830F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid VVSYICMRMQB
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0x8D86670", Offset = "0x8D85270", VA = "0x188D86670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid DVWOQZYSGVL
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0x8D857F0", Offset = "0x8D843F0", VA = "0x188D857F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid ZAENIXBPQZN
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0x8D80D70", Offset = "0x8D7F970", VA = "0x188D80D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid FSLFPJHFXAZ
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EFF0", Offset = "0x8D7DBF0", VA = "0x188D7EFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid DUHKJNQFZWQ
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D120", Offset = "0x8D7BD20", VA = "0x188D7D120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid WIXBQXDBGIP
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C8A0", Offset = "0x8D7B4A0", VA = "0x188D7C8A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid ZVMWBTFWFAC
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E270", Offset = "0x8D7CE70", VA = "0x188D7E270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid EATWBMCCKJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0x8D77B20", Offset = "0x8D76720", VA = "0x188D77B20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid PZLKLLSFBBQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F1F0", Offset = "0x8D7DDF0", VA = "0x188D7F1F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid QKSAJJKYBBP
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0x8D868F0", Offset = "0x8D854F0", VA = "0x188D868F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid EBXEIOLPPYE
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0x8D81F70", Offset = "0x8D80B70", VA = "0x188D81F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid DCQIBWMUNMD
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0x8D798A0", Offset = "0x8D784A0", VA = "0x188D798A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid VIADOQCSXRM
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BEA0", Offset = "0x8D7AAA0", VA = "0x188D7BEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid GZYEULXNMYH
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0x8D86BF0", Offset = "0x8D857F0", VA = "0x188D86BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid XYKIEIAEYMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0x8D840F0", Offset = "0x8D82CF0", VA = "0x188D840F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid ZJMJGIJGPSJ
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0x8D77720", Offset = "0x8D76320", VA = "0x188D77720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid MZZQULXZBKY
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0x8D82170", Offset = "0x8D80D70", VA = "0x188D82170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid XYDZSZKLCFB
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0x8D82B70", Offset = "0x8D81770", VA = "0x188D82B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid VQQNPLYWDFR
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F9F0", Offset = "0x8D7E5F0", VA = "0x188D7F9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid TMKHGMZJSVR
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0x8D77DA0", Offset = "0x8D769A0", VA = "0x188D77DA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid VHLOTNEVRTG
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0x8D81C70", Offset = "0x8D80870", VA = "0x188D81C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid JDNPGCIJDKQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0x8D78020", Offset = "0x8D76C20", VA = "0x188D78020")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid ZWINIRYJHBM
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x8D86F70", Offset = "0x8D85B70", VA = "0x188D86F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid TOKGCURNCPL
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0x8D79320", Offset = "0x8D77F20", VA = "0x188D79320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid JZWHLEUONXP
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0x8D876F0", Offset = "0x8D862F0", VA = "0x188D876F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid XQZMFGFFSAG
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0x8D848F0", Offset = "0x8D834F0", VA = "0x188D848F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid KJFQMVHTSIJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B220", Offset = "0x8D79E20", VA = "0x188D7B220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid RUDTPCVYQLA
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B4A0", Offset = "0x8D7A0A0", VA = "0x188D7B4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid OBVLATOGFOV
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0x8D813F0", Offset = "0x8D7FFF0", VA = "0x188D813F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid GXWKPNXEANX
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0x8D85570", Offset = "0x8D84170", VA = "0x188D85570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid CCGZCGPSSYV
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F7F0", Offset = "0x8D7E3F0", VA = "0x188D7F7F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid ERATJCEIQYO
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F5F0", Offset = "0x8D7E1F0", VA = "0x188D7F5F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid CSASMVCJYGY
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BB20", Offset = "0x8D7A720", VA = "0x188D7BB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid KSGUSBJEKCX
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E8F0", Offset = "0x8D7D4F0", VA = "0x188D7E8F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid WXZJOZADDBR
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C0A0", Offset = "0x8D7ACA0", VA = "0x188D7C0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid HKHCRIJTKRK
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0x8D825F0", Offset = "0x8D811F0", VA = "0x188D825F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid UWWXPXUDNKO
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B720", Offset = "0x8D7A320", VA = "0x188D7B720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid QUBAJFPXSIG
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E170", Offset = "0x8D7CD70", VA = "0x188D7E170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid CGEWQOFJTET
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FFF0", Offset = "0x8D7EBF0", VA = "0x188D7FFF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid VXGFVMVPCIH
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FAF0", Offset = "0x8D7E6F0", VA = "0x188D7FAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid SHWOAZIOVSS
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D1A0", Offset = "0x8D7BDA0", VA = "0x188D7D1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid OZBTTCQFIPW
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0x8D831F0", Offset = "0x8D81DF0", VA = "0x188D831F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid EIPNZHSDBWL
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0x8D79520", Offset = "0x8D78120", VA = "0x188D79520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid IUSBGANCYTK
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0x8D81870", Offset = "0x8D80470", VA = "0x188D81870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid ZPSZIZMINJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0x8D78A20", Offset = "0x8D77620", VA = "0x188D78A20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid POMOOBSENAH
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0x8D810F0", Offset = "0x8D7FCF0", VA = "0x188D810F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid QTEKGHCXVBO
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E970", Offset = "0x8D7D570", VA = "0x188D7E970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid OUUFCQJQAIY
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0x8D877F0", Offset = "0x8D863F0", VA = "0x188D877F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid KNIJJBXBYOG
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0x8D79A20", Offset = "0x8D78620", VA = "0x188D79A20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid ESRJCLAIQWA
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x8D79D20", Offset = "0x8D78920", VA = "0x188D79D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid CRIVZLYVHAO
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0x8D806F0", Offset = "0x8D7F2F0", VA = "0x188D806F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid TUCOYFLHYDH
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x8D86270", Offset = "0x8D84E70", VA = "0x188D86270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid QOGRFWTJRCD
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0x8D86870", Offset = "0x8D85470", VA = "0x188D86870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid QJQMIVRTNFM
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EF70", Offset = "0x8D7DB70", VA = "0x188D7EF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid NESBBRSULUB
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0x8D80270", Offset = "0x8D7EE70", VA = "0x188D80270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid CRRMRLMLLEJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0x8D84C70", Offset = "0x8D83870", VA = "0x188D84C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid RYKLGIKZHQW
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A920", Offset = "0x8D79520", VA = "0x188D7A920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid EBXSRLLDOAH
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0x8D77FA0", Offset = "0x8D76BA0", VA = "0x188D77FA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid KIRYMIXYYDF
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x8D867F0", Offset = "0x8D853F0", VA = "0x188D867F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid NLWGHZPISFJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0x8D7ED70", Offset = "0x8D7D970", VA = "0x188D7ED70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid FIOGLZVTBRA
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0x8D81270", Offset = "0x8D7FE70", VA = "0x188D81270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid SPOLQZKQWVV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0x8D82870", Offset = "0x8D81470", VA = "0x188D82870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid VZYWMTLUQCN
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0x8D87270", Offset = "0x8D85E70", VA = "0x188D87270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid NRZYJPTBHSO
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0x8D855F0", Offset = "0x8D841F0", VA = "0x188D855F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid KJOBUKHWMLV
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0x8D85A70", Offset = "0x8D84670", VA = "0x188D85A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid AWFJBRDBBAS
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0x8D80570", Offset = "0x8D7F170", VA = "0x188D80570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid XWOZBJVNDPE
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0x8D85670", Offset = "0x8D84270", VA = "0x188D85670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid XTHSMPVFNMC
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A7A0", Offset = "0x8D793A0", VA = "0x188D7A7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid RLGTAZFHHKR
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0x8D85770", Offset = "0x8D84370", VA = "0x188D85770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid SKWRZYXVDQL
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0x8D83B70", Offset = "0x8D82770", VA = "0x188D83B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid QUEGOZYWQLJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E370", Offset = "0x8D7CF70", VA = "0x188D7E370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid VSLGSZGFJOT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FD70", Offset = "0x8D7E970", VA = "0x188D7FD70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid CMAAFSPXOPJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0x8D872F0", Offset = "0x8D85EF0", VA = "0x188D872F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid RLYSTUEQOKF
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E6F0", Offset = "0x8D7D2F0", VA = "0x188D7E6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid WAQTYBPRDNL
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CB20", Offset = "0x8D7B720", VA = "0x188D7CB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid DNLGJCUKJBN
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F470", Offset = "0x8D7E070", VA = "0x188D7F470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid MPINUTWHBWG
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x8D78FA0", Offset = "0x8D77BA0", VA = "0x188D78FA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid HBANKNWMQZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0x8D86C70", Offset = "0x8D85870", VA = "0x188D86C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid DUSJJHDJOPZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x8D849F0", Offset = "0x8D835F0", VA = "0x188D849F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid VVNUECTLOIJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0x8D83870", Offset = "0x8D82470", VA = "0x188D83870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid AAXXGYUTBAB
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DEF0", Offset = "0x8D7CAF0", VA = "0x188D7DEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid CUGQTRMFRQK
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0x8D878F0", Offset = "0x8D864F0", VA = "0x188D878F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid SIGEHUWHCIJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x8D77AA0", Offset = "0x8D766A0", VA = "0x188D77AA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid HFLGWPOSQXW
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EBF0", Offset = "0x8D7D7F0", VA = "0x188D7EBF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid FUYWIYSBATQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0x8D78520", Offset = "0x8D77120", VA = "0x188D78520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid ZFSFQEDGQOK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0x8D865F0", Offset = "0x8D851F0", VA = "0x188D865F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid LYNOAQAIPJM
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0x8D773A0", Offset = "0x8D75FA0", VA = "0x188D773A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid QOKDZMRHEWE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x8D79620", Offset = "0x8D78220", VA = "0x188D79620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid VPBNEQTLMLH
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C120", Offset = "0x8D7AD20", VA = "0x188D7C120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid DIDJCZSWOQX
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F370", Offset = "0x8D7DF70", VA = "0x188D7F370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid CYKWHCCBQHB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E070", Offset = "0x8D7CC70", VA = "0x188D7E070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid YXMBJWNGZJS
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0x8D77CA0", Offset = "0x8D768A0", VA = "0x188D77CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid KFKRXELVDIV
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0x8D829F0", Offset = "0x8D815F0", VA = "0x188D829F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid EARGSRKYZNE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0x8D85070", Offset = "0x8D83C70", VA = "0x188D85070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid SBUFZUYMVYF
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B1A0", Offset = "0x8D79DA0", VA = "0x188D7B1A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid NUWWSAFOBKQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0x8D77C20", Offset = "0x8D76820", VA = "0x188D77C20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid YDPOEUHMXRH
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C920", Offset = "0x8D7B520", VA = "0x188D7C920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid ANYXJNPXCNS
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0x8D824F0", Offset = "0x8D810F0", VA = "0x188D824F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid STNKCIKPZLT
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C4A0", Offset = "0x8D7B0A0", VA = "0x188D7C4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid QZFPGGOHBFP
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0x8D85C70", Offset = "0x8D84870", VA = "0x188D85C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid JXTABWSFBBM
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0x8D83170", Offset = "0x8D81D70", VA = "0x188D83170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid VDEYLEXUXHQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0x8D82F70", Offset = "0x8D81B70", VA = "0x188D82F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid AHZZKBEHJKB
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0x8D77220", Offset = "0x8D75E20", VA = "0x188D77220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid DTXWLDZOUQX
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C220", Offset = "0x8D7AE20", VA = "0x188D7C220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid NLVAQCMACZR
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0x8D84DF0", Offset = "0x8D839F0", VA = "0x188D84DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid KNOHFINMWCU
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C7A0", Offset = "0x8D7B3A0", VA = "0x188D7C7A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid KOOPRQIZRHN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C5A0", Offset = "0x8D7B1A0", VA = "0x188D7C5A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid VRWIQLQJQHZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0x8D81770", Offset = "0x8D80370", VA = "0x188D81770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid VXZQOGVLBOU
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FDF0", Offset = "0x8D7E9F0", VA = "0x188D7FDF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid QAUDMJEOJYA
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0x8D823F0", Offset = "0x8D80FF0", VA = "0x188D823F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid QBEWQVMBZGD
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0x8D78420", Offset = "0x8D77020", VA = "0x188D78420")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid RKWMEPETYYW
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A4A0", Offset = "0x8D790A0", VA = "0x188D7A4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid CVERBXWTOBC
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0x8D814F0", Offset = "0x8D800F0", VA = "0x188D814F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid PSVWIAOHNYD
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C2A0", Offset = "0x8D7AEA0", VA = "0x188D7C2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid ERPNZEEXUQY
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0x8D81B70", Offset = "0x8D80770", VA = "0x188D81B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid HUXCLROCNCM
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FCF0", Offset = "0x8D7E8F0", VA = "0x188D7FCF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid EAJVIOSZAHY
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0x8D83FF0", Offset = "0x8D82BF0", VA = "0x188D83FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid YREWCHKWZGE
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0x8D77F20", Offset = "0x8D76B20", VA = "0x188D77F20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid QQWGTGENIPD
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0x8D78120", Offset = "0x8D76D20", VA = "0x188D78120")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid RNISENVHDIS
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C6A0", Offset = "0x8D7B2A0", VA = "0x188D7C6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid SDXYCUMFXDH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D4A0", Offset = "0x8D7C0A0", VA = "0x188D7D4A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid FSESSFFNURO
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F570", Offset = "0x8D7E170", VA = "0x188D7F570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid YLNSQKSRLDR
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0x8D852F0", Offset = "0x8D83EF0", VA = "0x188D852F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid MYAPLAAYLVH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0x8D80670", Offset = "0x8D7F270", VA = "0x188D80670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid IHTEVBDLAPH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0x8D800F0", Offset = "0x8D7ECF0", VA = "0x188D800F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid CHFRDKVFVTD
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D6A0", Offset = "0x8D7C2A0", VA = "0x188D7D6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid JUFUDCVPPZO
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D620", Offset = "0x8D7C220", VA = "0x188D7D620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid QCABIGZFGWM
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0x8D787A0", Offset = "0x8D773A0", VA = "0x188D787A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid WGSNYJCGLSN
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E0F0", Offset = "0x8D7CCF0", VA = "0x188D7E0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid YODMWRPNEFW
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0x8D81570", Offset = "0x8D80170", VA = "0x188D81570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid UJMUTZFZUDT
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0x8D83470", Offset = "0x8D82070", VA = "0x188D83470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid PAERCRXRHVM
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0x8D77D20", Offset = "0x8D76920", VA = "0x188D77D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid BWZBBRWBAYS
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FF70", Offset = "0x8D7EB70", VA = "0x188D7FF70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid RQUXRGHMUGX
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0x8D80BF0", Offset = "0x8D7F7F0", VA = "0x188D80BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid SITPPLNXBTT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0x8D84870", Offset = "0x8D83470", VA = "0x188D84870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid KZDKVAEJJZE
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AEA0", Offset = "0x8D79AA0", VA = "0x188D7AEA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid RJQUXZSIMHX
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0x8D81170", Offset = "0x8D7FD70", VA = "0x188D81170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid PVLSFKJEXRU
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C9A0", Offset = "0x8D7B5A0", VA = "0x188D7C9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid KLQBDMNCVVD
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0x8D77BA0", Offset = "0x8D767A0", VA = "0x188D77BA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid CTFPEMFNVDO
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FA70", Offset = "0x8D7E670", VA = "0x188D7FA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid XBGKSDJJQWN
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CD20", Offset = "0x8D7B920", VA = "0x188D7CD20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid FTKNKBVSUOJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A0A0", Offset = "0x8D78CA0", VA = "0x188D7A0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid MCRBNNTEOXB
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0x8D81D70", Offset = "0x8D80970", VA = "0x188D81D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid PQKINNXTOHR
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0x8D7DB70", Offset = "0x8D7C770", VA = "0x188D7DB70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid AYWMIUUXGZC
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0x8D84470", Offset = "0x8D83070", VA = "0x188D84470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid YIXMSTFXOXO
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0x8D84570", Offset = "0x8D83170", VA = "0x188D84570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid VKKPPZNBRTP
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B920", Offset = "0x8D7A520", VA = "0x188D7B920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid ICUDTUNWJST
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EA70", Offset = "0x8D7D670", VA = "0x188D7EA70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid LYQBFJVGSIQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0x8D85B70", Offset = "0x8D84770", VA = "0x188D85B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid JGNFAOFVBUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E4F0", Offset = "0x8D7D0F0", VA = "0x188D7E4F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid SQYOPSVDDZR
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0x8D83370", Offset = "0x8D81F70", VA = "0x188D83370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid WIOYLERQPPH
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CCA0", Offset = "0x8D7B8A0", VA = "0x188D7CCA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid PUNLGETGIUF
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0x8D85370", Offset = "0x8D83F70", VA = "0x188D85370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid CSJAMOTICHR
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0x8D820F0", Offset = "0x8D80CF0", VA = "0x188D820F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid JDAAELVQFDR
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0x8D860F0", Offset = "0x8D84CF0", VA = "0x188D860F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid NAUPBZJGESY
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0x8D7ACA0", Offset = "0x8D798A0", VA = "0x188D7ACA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid FOJREJXCSCD
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F0F0", Offset = "0x8D7DCF0", VA = "0x188D7F0F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid DRAZXLDTOQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E870", Offset = "0x8D7D470", VA = "0x188D7E870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid QCEKGTSVOEQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D820", Offset = "0x8D7C420", VA = "0x188D7D820")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid QTSUOIHXXEE
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0x8D80EF0", Offset = "0x8D7FAF0", VA = "0x188D80EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid NRFYBVNAKTG
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0x8D82270", Offset = "0x8D80E70", VA = "0x188D82270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid HDXGYQENPLD
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BDA0", Offset = "0x8D7A9A0", VA = "0x188D7BDA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid EOXUBUYHNQS
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0x8D82FF0", Offset = "0x8D81BF0", VA = "0x188D82FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid WEYQMXZGXWR
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0x8D85270", Offset = "0x8D83E70", VA = "0x188D85270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid JOIODGUMDKA
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0x8D77320", Offset = "0x8D75F20", VA = "0x188D77320")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid EBMVRXSSQGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0x8D86970", Offset = "0x8D85570", VA = "0x188D86970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid AWADMVYHDYS
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0x8D822F0", Offset = "0x8D80EF0", VA = "0x188D822F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid QVALXUPJIFT
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0x8D783A0", Offset = "0x8D76FA0", VA = "0x188D783A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid WDKRYKZYIEG
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0x8D84EF0", Offset = "0x8D83AF0", VA = "0x188D84EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid FEGTKNHKSLH
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0x8D78620", Offset = "0x8D77220", VA = "0x188D78620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid XNSCUDNYCHW
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0x8D82BF0", Offset = "0x8D817F0", VA = "0x188D82BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid EAUJCQYIBGW
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0x8D77E20", Offset = "0x8D76A20", VA = "0x188D77E20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid IGBIOQKFNSI
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FC70", Offset = "0x8D7E870", VA = "0x188D7FC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid OBHRKHJRGWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E9F0", Offset = "0x8D7D5F0", VA = "0x188D7E9F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid ISRSMTZIREA
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0x8D7F6F0", Offset = "0x8D7E2F0", VA = "0x188D7F6F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid EHYEEVPGTMV
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0x8D86770", Offset = "0x8D85370", VA = "0x188D86770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid BFFFYZDJPLS
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7ADA0", Offset = "0x8D799A0", VA = "0x188D7ADA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid LALRJPHWHOY
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7CBA0", Offset = "0x8D7B7A0", VA = "0x188D7CBA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid LLGPENDJKJO
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0x8D87770", Offset = "0x8D86370", VA = "0x188D87770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid ZPZWSBGVZUU
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0x8D84CF0", Offset = "0x8D838F0", VA = "0x188D84CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid KAXZKFFZVPU
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EAF0", Offset = "0x8D7D6F0", VA = "0x188D7EAF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid ZZQRGBRQKWY
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0x8D772A0", Offset = "0x8D75EA0", VA = "0x188D772A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid VWDYXUVCNRJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0x8D853F0", Offset = "0x8D83FF0", VA = "0x188D853F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid QOOWEZYBNDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0x8D7EC70", Offset = "0x8D7D870", VA = "0x188D7EC70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid VBJNSNHDLOB
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B520", Offset = "0x8D7A120", VA = "0x188D7B520")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid ALZXSGTUIYR
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A3A0", Offset = "0x8D78FA0", VA = "0x188D7A3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid KSHMVRZBHNS
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0x8D83070", Offset = "0x8D81C70", VA = "0x188D83070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid CESDBWNSHLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0x8D78CA0", Offset = "0x8D778A0", VA = "0x188D78CA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid JZEEFAUEPDF
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0x8D7BCA0", Offset = "0x8D7A8A0", VA = "0x188D7BCA0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid MILYWKOVLGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0x8D7AB20", Offset = "0x8D79720", VA = "0x188D7AB20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid ENPLISTLTSM
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0x8D83270", Offset = "0x8D81E70", VA = "0x188D83270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid TQKMUBSSRVV
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B2A0", Offset = "0x8D79EA0", VA = "0x188D7B2A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid EBPEAZRFJHU
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A6A0", Offset = "0x8D792A0", VA = "0x188D7A6A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid VBOTEEMLZLE
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0x8D7E670", Offset = "0x8D7D270", VA = "0x188D7E670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid GVGYIBUWQJU
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0x8D77A20", Offset = "0x8D76620", VA = "0x188D77A20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid RARWNUPPTQH
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0x8D7B9A0", Offset = "0x8D7A5A0", VA = "0x188D7B9A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid CCLOMMTODJJ
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0x8D78920", Offset = "0x8D77520", VA = "0x188D78920")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid OBFOHPJJIHC
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0x8D7FEF0", Offset = "0x8D7EAF0", VA = "0x188D7FEF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid DJQZIMCBRBY
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D0A0", Offset = "0x8D7BCA0", VA = "0x188D7D0A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid XMYNTQFKJSP
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0x8D81670", Offset = "0x8D80270", VA = "0x188D81670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid JNHXTSTBGVN
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A620", Offset = "0x8D79220", VA = "0x188D7A620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid JNNEQZMYQGW
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0x8D7A720", Offset = "0x8D79320", VA = "0x188D7A720")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid HLCIRHJHICD
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0x8D7C620", Offset = "0x8D7B220", VA = "0x188D7C620")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid TLQPSMJKFQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0x8D80CF0", Offset = "0x8D7F8F0", VA = "0x188D80CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid SXTBOQRIZFA
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0x8D79220", Offset = "0x8D77E20", VA = "0x188D79220")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid OUNUBCABRMY
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0x8D7D3A0", Offset = "0x8D7BFA0", VA = "0x188D7D3A0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid ZBKQHRQWHDP
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0x8D78D20", Offset = "0x8D77920", VA = "0x188D78D20")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid HMCMNWSACLE
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0x8D80470", Offset = "0x8D7F070", VA = "0x188D80470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid WHXQGNHTOXN
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0x8D81FF0", Offset = "0x8D80BF0", VA = "0x188D81FF0")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8D70AE0", Offset = "0x8D6F6E0", VA = "0x188D70AE0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A980", Offset = "0x8D69580", VA = "0x188D6A980")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> AYYWPCGPYAF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class PMVZKCUUUIP
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x8D76DC0", Offset = "0x8D759C0", VA = "0x188D76DC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class IRLRSEKBPZG
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x8D76090", Offset = "0x8D74C90", VA = "0x188D76090")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class BQZTQSVWJSG
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8D74680", Offset = "0x8D73280", VA = "0x188D74680")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class XKJHRUFFVIZ
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private static readonly Dictionary<Guid, float> IXOXLQIHMLR;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private static readonly Dictionary<Guid, float> MOXADLESXWC;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private static readonly Dictionary<Guid, bool> IMDGPOYVWWJ;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8BE40", Offset = "0x8D8AA40", VA = "0x188D8BE40")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class XKEAUNLILXQ
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private static readonly Dictionary<Guid, float> EHSYHXKPJWM;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private static readonly Dictionary<Guid, float> SVKISFJCQMT;

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8D8A9A0", Offset = "0x8D895A0", VA = "0x188D8A9A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class DETZPLDHIYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8D748B0", Offset = "0x8D734B0", VA = "0x188D748B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class QOYZZVUMQZQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private static readonly Dictionary<Guid, int> SWSDGRQTNDK;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private static readonly Dictionary<Guid, bool> SDVBJTWPWLA;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private static readonly Dictionary<Guid, bool> UHJWEWAGWNV;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private static readonly Dictionary<Guid, int> IMCBHCHGPJT;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private static readonly Dictionary<Guid, bool> VDDETTWBCVW;

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8D87B30", Offset = "0x8D86730", VA = "0x188D87B30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class QOOMFIGRYCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8D87970", Offset = "0x8D86570", VA = "0x188D87970")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<HGULJDEHQOI, PersistedRoomData, PersistedRoomVersion> TTGSKXFFSVB;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Dictionary<Guid, int> NJBQKDEQYUM;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Guid VJBQSYJGJVG;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Guid HHFJNQHEOCS;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly float HLNXYYZBIMY;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D53A90", Offset = "0x8D52690", VA = "0x188D53A90")]
		public static PersistedRoomData OTVNUPSXFTF(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D53620", Offset = "0x8D52220", VA = "0x188D53620")]
		public static Result<ParseResult<PersistedRoomData>, DOTNMKZGUXE> GOTBFFFCGLZ(HGULJDEHQOI a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D53270", Offset = "0x8D51E70", VA = "0x188D53270")]
		public static Result<ParseResult<PersistedRoomData>, DOTNMKZGUXE> GOTBFFFCGLZ(HGULJDEHQOI a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D53750", Offset = "0x8D52350", VA = "0x188D53750")]
		public static Result<None, DOTNMKZGUXE> LVESDNBBXPI(HGULJDEHQOI a, PersistedRoomData b)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D53BB0", Offset = "0x8D527B0", VA = "0x188D53BB0")]
		public static Guid XFSUUZEMPAL(NOEXDRYNADI a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class ATNMPXLYDDR
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public interface HGULJDEHQOI : VRUABHGORIK<OHPGYSJVQRZ, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public sealed class FTHXRLGPSAN : HGULJDEHQOI, VRUABHGORIK<OHPGYSJVQRZ, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static FTHXRLGPSAN PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			public PlayerSaveVersion AXKGKNHQEXW()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xB54950", Offset = "0xB53550", VA = "0x180B54950", Slot = "5")]
			public PlayerSaveVersion YWUJIKQMILA()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x17DA690", Offset = "0x17D9290", VA = "0x1817DA690", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2C37510", Offset = "0x2C36110", VA = "0x182C37510", Slot = "7")]
			public bool MEVUIEHYGBT(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8D74C50", Offset = "0x8D73850", VA = "0x188D74C50", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FTHXRLGPSAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private static Versioner<HGULJDEHQOI, OHPGYSJVQRZ, PlayerSaveVersion> TTGSKXFFSVB;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8D74300", Offset = "0x8D72F00", VA = "0x188D74300")]
		public static OHPGYSJVQRZ? XKKDNMYGFRN([Optional] ZJTKVOJZUJJ? a, [Optional] XUHHJVJFBED? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D73A30", Offset = "0x8D72630", VA = "0x188D73A30")]
		public static Result<ParseResult<OHPGYSJVQRZ>, DOTNMKZGUXE> GOTBFFFCGLZ(HGULJDEHQOI a, byte[]? bytes)
		{
			return default(Result<ParseResult<OHPGYSJVQRZ>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8D735B0", Offset = "0x8D721B0", VA = "0x188D735B0")]
		public static Result<ParseResult<OHPGYSJVQRZ>, DOTNMKZGUXE> GOTBFFFCGLZ(HGULJDEHQOI deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<OHPGYSJVQRZ>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8D73BD0", Offset = "0x8D727D0", VA = "0x188D73BD0")]
		public static Result<None, DOTNMKZGUXE> LVESDNBBXPI(HGULJDEHQOI a, OHPGYSJVQRZ b)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8D73070", Offset = "0x8D71C70", VA = "0x188D73070")]
		public static void DDDWLJACLMC(OHPGYSJVQRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8D72E30", Offset = "0x8D71A30", VA = "0x188D72E30")]
		public static void DCYPOCGFCAT(OHPGYSJVQRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8D72990", Offset = "0x8D71590", VA = "0x188D72990")]
		public static void DCTIQVMHSPK(OHPGYSJVQRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8D733E0", Offset = "0x8D71FE0", VA = "0x188D733E0")]
		public static void DEEEXQVPGQV(OHPGYSJVQRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8D73370", Offset = "0x8D71F70", VA = "0x188D73370")]
		public static void DDYYAKBRXFM(OHPGYSJVQRZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8D741D0", Offset = "0x8D72DD0", VA = "0x188D741D0")]
		private static XUHHJVJFBED UZEWMTXMHNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8D740F0", Offset = "0x8D72CF0", VA = "0x188D740F0")]
		private static XUHHJVJFBED UYZPPNDOYCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8D73D00", Offset = "0x8D72900", VA = "0x188D73D00")]
		[CompilerGenerated]
		internal static bool MAMWBGEMKUE(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8D73E80", Offset = "0x8D72A80", VA = "0x188D73E80")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM QOGHBGXBAFI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8D742B0", Offset = "0x8D72EB0", VA = "0x188D742B0")]
		[CompilerGenerated]
		internal static float VMJTANGCGKM(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8D743F0", Offset = "0x8D72FF0", VA = "0x188D743F0")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM YMGFUUGRQTW(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8D73FD0", Offset = "0x8D72BD0", VA = "0x188D73FD0")]
		[CompilerGenerated]
		internal static int RZKPFHSVXWF(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8D74080", Offset = "0x8D72C80", VA = "0x188D74080")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM UALIETUUFBD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8D73D30", Offset = "0x8D72930", VA = "0x188D73D30")]
		[CompilerGenerated]
		internal static CircuitsQuat NVZWGYBCTJE(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8D73E00", Offset = "0x8D72A00", VA = "0x188D73E00")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM QMQXIBJRVTC(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8D742E0", Offset = "0x8D72EE0", VA = "0x188D742E0")]
		[CompilerGenerated]
		internal static string VNKMKYGTWBX(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8D73B60", Offset = "0x8D72760", VA = "0x188D73B60")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM LOFQYOEPFQT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8D73EF0", Offset = "0x8D72AF0", VA = "0x188D73EF0")]
		[CompilerGenerated]
		internal static CircuitsVec3 QROKESHUWIN(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8D74000", Offset = "0x8D72C00", VA = "0x188D74000")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM SHMUAMRKJGX(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8D72920", Offset = "0x8D71520", VA = "0x188D72920")]
		[CompilerGenerated]
		internal static int APIJVIHCXDE(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8D73510", Offset = "0x8D72110", VA = "0x188D73510")]
		[CompilerGenerated]
		internal static CNZTBOLWPUM ETKMOWKHJZS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x304DE50", Offset = "0x304CA50", VA = "0x18304DE50")]
		[CompilerGenerated]
		internal static void XSAUCWAKKLY<a>(RepeatedField<AYFTMPCQHCV> a, Func<ByteString, a> deserialize, Func<a, CNZTBOLWPUM> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class XSOHMFMHIUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E0E0", Offset = "0x8D8CCE0", VA = "0x188D8E0E0")]
		public static GHOHWWZOAOV KXHBPTNWIEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DFF0", Offset = "0x8D8CBF0", VA = "0x188D8DFF0")]
		public static Result<ParseResult<GHOHWWZOAOV>, DOTNMKZGUXE> GOTBFFFCGLZ(AKDXFXBBAWL.HGULJDEHQOI a, byte[] b)
		{
			return default(Result<ParseResult<GHOHWWZOAOV>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DCA0", Offset = "0x8D8C8A0", VA = "0x188D8DCA0")]
		public static Result<ParseResult<GHOHWWZOAOV>, DOTNMKZGUXE> GOTBFFFCGLZ(AKDXFXBBAWL.HGULJDEHQOI a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<GHOHWWZOAOV>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E130", Offset = "0x8D8CD30", VA = "0x188D8E130")]
		public static Result<None, DOTNMKZGUXE> LVESDNBBXPI(AKDXFXBBAWL.HGULJDEHQOI a, GHOHWWZOAOV b)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class IYXBBJEZRKM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8D767E0", Offset = "0x8D753E0", VA = "0x188D767E0")]
		public static SpawnableTemplateData OWIXLBZIUYA([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8D76250", Offset = "0x8D74E50", VA = "0x188D76250")]
		public static Result<ParseResult<SpawnableTemplateData>, DOTNMKZGUXE> GOTBFFFCGLZ(AKDXFXBBAWL.HGULJDEHQOI a, HHTWMHJSOSZ.HGULJDEHQOI b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8D76570", Offset = "0x8D75170", VA = "0x188D76570")]
		public static Result<None, DOTNMKZGUXE> LVESDNBBXPI(AKDXFXBBAWL.HGULJDEHQOI a, HHTWMHJSOSZ.HGULJDEHQOI b, SpawnableTemplateData c)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8D76860", Offset = "0x8D75460", VA = "0x188D76860")]
		private static Result<None, DOTNMKZGUXE> RIAMDOJCXJG(AKDXFXBBAWL.HGULJDEHQOI a, SpawnableTemplateData b)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8D76C20", Offset = "0x8D75820", VA = "0x188D76C20")]
		private static Result<None, DOTNMKZGUXE> YAXCQYFHFSW(HHTWMHJSOSZ.HGULJDEHQOI a, SpawnableTemplateData b)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class HHTWMHJSOSZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public interface HGULJDEHQOI : VRUABHGORIK<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public sealed class FTHXRLGPSAN : HGULJDEHQOI, VRUABHGORIK<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static FTHXRLGPSAN PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			public SuperRoomVersion AXKGKNHQEXW()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB44D60", Offset = "0xB43960", VA = "0x180B44D60", Slot = "5")]
			public SuperRoomVersion YWUJIKQMILA()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x17DA690", Offset = "0x17D9290", VA = "0x1817DA690", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x2C37510", Offset = "0x2C36110", VA = "0x182C37510", Slot = "7")]
			public bool MEVUIEHYGBT(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8D74CA0", Offset = "0x8D738A0", VA = "0x188D74CA0", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FTHXRLGPSAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static Versioner<HGULJDEHQOI, SuperRoomData, SuperRoomVersion> TTGSKXFFSVB;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8D755A0", Offset = "0x8D741A0", VA = "0x188D755A0")]
		public static SuperRoomData LVCMSUWIMZP([Optional] TOZHMZXCWWB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D751A0", Offset = "0x8D73DA0", VA = "0x188D751A0")]
		public static Result<ParseResult<SuperRoomData>, DOTNMKZGUXE> GOTBFFFCGLZ(HGULJDEHQOI a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8D752D0", Offset = "0x8D73ED0", VA = "0x188D752D0")]
		public static Result<ParseResult<SuperRoomData>, DOTNMKZGUXE> GOTBFFFCGLZ(HGULJDEHQOI a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8D756A0", Offset = "0x8D742A0", VA = "0x188D756A0")]
		public static Result<None, DOTNMKZGUXE> LVESDNBBXPI(HGULJDEHQOI a, SuperRoomData b)
		{
			return default(Result<None, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D74F60", Offset = "0x8D73B60", VA = "0x188D74F60")]
		private static void DDDWLJACLMC(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D74E60", Offset = "0x8D73A60", VA = "0x188D74E60")]
		private static void DCYPOCGFCAT(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D74DD0", Offset = "0x8D739D0", VA = "0x188D74DD0")]
		private static void DCTIQVMHSPK(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D75120", Offset = "0x8D73D20", VA = "0x188D75120")]
		private static void DEEEXQVPGQV(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8D757D0", Offset = "0x8D743D0", VA = "0x188D757D0")]
		public static DataTableData OHMWRYGWKIU(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D75AF0", Offset = "0x8D746F0", VA = "0x188D75AF0")]
		public static ProgressionManagerData SFOLGOMATUD(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8D75D00", Offset = "0x8D74900", VA = "0x188D75D00")]
		[CompilerGenerated]
		internal static void XZQSJEQDGGV(RepeatedField<WTQOKWWMPHZ> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class ULLUIZNOEPJ : KLYRWOGOSJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A860", Offset = "0x8D89460", VA = "0x188D8A860", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28D3520", Offset = "0x28D2120", VA = "0x1828D3520")]
		public ULLUIZNOEPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface VRUABHGORIK<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b AXKGKNHQEXW();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b YWUJIKQMILA();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MEVUIEHYGBT(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class VEPHQOWLPEP : KLYRWOGOSJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private string YXEFWTLVNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private string TLIUQUWBRDU;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8D74AD0", Offset = "0x8D736D0", VA = "0x188D74AD0")]
		public VEPHQOWLPEP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A940", Offset = "0x8D89540", VA = "0x188D8A940", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x59BC8B0", Offset = "0x59BB4B0", VA = "0x1859BC8B0")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class YFWWHICWOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6880", Offset = "0x3BF5480", VA = "0x183BF6880")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class FQZJAQQCSJQ : KLYRWOGOSJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string YXEFWTLVNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private string TLIUQUWBRDU;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8D74AD0", Offset = "0x8D736D0", VA = "0x188D74AD0")]
		public FQZJAQQCSJQ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8D74A70", Offset = "0x8D73670", VA = "0x188D74A70", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A890", Offset = "0x8D89490", VA = "0x188D8A890")]
		public static Guid? RVDTMLNAIVA(JEXJFGQTHAX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : VRUABHGORIK<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6499F40", Offset = "0x6498B40", VA = "0x186499F40")]
		public Result<TVersion, DOTNMKZGUXE> LVESDNBBXPI(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x649BE80", Offset = "0x649AA80", VA = "0x18649BE80")]
		public static VersionerFactory<TDeps, TData, TVersion> QMWBYPAHZIM()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public VersioningPhaseVoidDelegate<TData> LYTTLWSNMHU;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5E13F90", Offset = "0x5E12B90", VA = "0x185E13F90")]
			internal Result<None, DOTNMKZGUXE> LISDSAPGHPA(TDeps a, TData b)
			{
				return default(Result<None, DOTNMKZGUXE>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6499950", Offset = "0x6498550", VA = "0x186499950")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6499A80", Offset = "0x6498680", VA = "0x186499A80")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class XKDKUHNCMVC
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x33A0720", Offset = "0x339F320", VA = "0x1833A0720")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : VRUABHGORIK<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FRUOWBBIOAV : KLYRWOGOSJY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public readonly Exception GBFQXRONCFI;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x18DE620", Offset = "0x18DD220", VA = "0x1818DE620")]
		public FRUOWBBIOAV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D74C20", Offset = "0x8D73820", VA = "0x188D74C20", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D74B20", Offset = "0x8D73720", VA = "0x188D74B20", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class KLYRWOGOSJY : DOTNMKZGUXE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x28D3520", Offset = "0x28D2120", VA = "0x1828D3520")]
		protected KLYRWOGOSJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate Result<None, DOTNMKZGUXE> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
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
