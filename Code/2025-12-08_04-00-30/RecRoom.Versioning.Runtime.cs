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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DBDFF0", Offset = "0x8DBC7F0", VA = "0x188DBDFF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class RHKNGDSCLZV
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface HYKMXKQCBUU : EODZNSSPBFM<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public sealed class JKCUUNJHGIZ : HYKMXKQCBUU, EODZNSSPBFM<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static JKCUUNJHGIZ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			public PersistedRoomVersion DTWCZEXJDGA()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB560", Offset = "0x8DB9D60", VA = "0x188DBB560", Slot = "5")]
			public PersistedRoomVersion TLYCXURBGLE()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1802BC0", Offset = "0x18013C0", VA = "0x181802BC0", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2C445B0", Offset = "0x2C42DB0", VA = "0x182C445B0", Slot = "7")]
			public bool UPUAHVXNEJP(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB570", Offset = "0x8DB9D70", VA = "0x188DBB570", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JKCUUNJHGIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class RAEAXMTWMVY
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static Dictionary<Guid, string[]> WHVSDJNSCAA;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8DC5240", Offset = "0x8DC3A40", VA = "0x188DC5240")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class FXGOUPCFRCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB2A0", Offset = "0x8DB9AA0", VA = "0x188DBB2A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class FWLNFOAQFIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB0E0", Offset = "0x8DB98E0", VA = "0x188DBB0E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class MSWDJUGWEWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8DBDE30", Offset = "0x8DBC630", VA = "0x188DBDE30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class MSQWMNMYVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8DBDC00", Offset = "0x8DBC400", VA = "0x188DBDC00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class RWISRRZVEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8DD92A0", Offset = "0x8DD7AA0", VA = "0x188DD92A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class YWKCYQAFRYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA3B0", Offset = "0x8DD8BB0", VA = "0x188DDA3B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class QTETULIKOVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4BA0", Offset = "0x8DC33A0", VA = "0x188DC4BA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class QSZMXEONFKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8DC49D0", Offset = "0x8DC31D0", VA = "0x188DC49D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class JRCSOXRALBW
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly Dictionary<Guid, int> BWURMKLYASV;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB900", Offset = "0x8DBA100", VA = "0x188DBB900")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB630", Offset = "0x8DB9E30", VA = "0x188DBB630")]
			private static Dictionary<Guid, BESXCZTRGHM> AEBDRBRXIZG(BESXCZTRGHM a, Dictionary<Guid, BESXCZTRGHM> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class JTDJNNIABLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8DBD820", Offset = "0x8DBC020", VA = "0x188DBD820")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class QZTNCZGBTZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8DC5080", Offset = "0x8DC3880", VA = "0x188DC5080")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class VQKDJHINHZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DD9470", Offset = "0x8DD7C70", VA = "0x188DD9470")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8DD9460", Offset = "0x8DD7C60", VA = "0x188DD9460")]
			private static void ITNRXSITTYE(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class VQURDUWIAVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8DD9750", Offset = "0x8DD7F50", VA = "0x188DD9750")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class VRPSSVXXMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8DD9950", Offset = "0x8DD8150", VA = "0x188DD9950")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class VSAGNJLSFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA050", Offset = "0x8DD8850", VA = "0x188DDA050")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class VRUZQCRUWAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8DD9D30", Offset = "0x8DD8530", VA = "0x188DD9D30")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class QZIZILSHBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4EC0", Offset = "0x8DC36C0", VA = "0x188DC4EC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class OVUXGJZJPJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4800", Offset = "0x8DC3000", VA = "0x188DC4800")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class OVKJLWLOWMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8DC45B0", Offset = "0x8DC2DB0", VA = "0x188DC45B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class OUZVRIXUDPW
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
			private static class XLUBRSJVBDT
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid OZLDSSZBMYK
				{
					[Cpp2IlInjected.Token(Token = "0x600002C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2030", Offset = "0x8DF0830", VA = "0x188DF2030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid HLXXLSQBNRQ
				{
					[Cpp2IlInjected.Token(Token = "0x600002D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE87B0", Offset = "0x8DE6FB0", VA = "0x188DE87B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid KFDEQJTWNFP
				{
					[Cpp2IlInjected.Token(Token = "0x600002E")]
					[Cpp2IlInjected.Address(RVA = "0x8DED630", Offset = "0x8DEBE30", VA = "0x188DED630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid NNYKAPMXYJR
				{
					[Cpp2IlInjected.Token(Token = "0x600002F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF35F0", Offset = "0x8DF1DF0", VA = "0x188DF35F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid WYPUTTLBELP
				{
					[Cpp2IlInjected.Token(Token = "0x6000030")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE1B0", Offset = "0x8DEC9B0", VA = "0x188DEE1B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid HIHUKMAFNUJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5CF0", Offset = "0x8DF44F0", VA = "0x188DF5CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid SLGDPYSWECM
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x8DF01B0", Offset = "0x8DEE9B0", VA = "0x188DF01B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid UFFYLFYFTXR
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8DE99B0", Offset = "0x8DE81B0", VA = "0x188DE99B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid VXPRDGEEIHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x8DED430", Offset = "0x8DEBC30", VA = "0x188DED430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid PQFMXXSMMOT
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7F30", Offset = "0x8DE6730", VA = "0x188DE7F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid XHNRCMQNLIM
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x8DE73B0", Offset = "0x8DE5BB0", VA = "0x188DE73B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid GMKUSAJWVSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB230", Offset = "0x8DE9A30", VA = "0x188DEB230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid KZHFLHREVZR
				{
					[Cpp2IlInjected.Token(Token = "0x6000038")]
					[Cpp2IlInjected.Address(RVA = "0x8DECC30", Offset = "0x8DEB430", VA = "0x188DECC30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid MCQNBHFFCPZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5DF0", Offset = "0x8DF45F0", VA = "0x188DF5DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid AAQDGCYABXJ
				{
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF9B0", Offset = "0x8DEE1B0", VA = "0x188DEF9B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid PBGOQGGNCNO
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEAB0", Offset = "0x8DED2B0", VA = "0x188DEEAB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid LELEKOGXRJL
				{
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1730", Offset = "0x8DEFF30", VA = "0x188DF1730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid BXKWMCVVGNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600003D")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF730", Offset = "0x8DEDF30", VA = "0x188DEF730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid YSBISABOXZQ
				{
					[Cpp2IlInjected.Token(Token = "0x600003E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAEB0", Offset = "0x8DE96B0", VA = "0x188DEAEB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid TMPUBMALIHA
				{
					[Cpp2IlInjected.Token(Token = "0x600003F")]
					[Cpp2IlInjected.Address(RVA = "0x8DECCB0", Offset = "0x8DEB4B0", VA = "0x188DECCB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid DVZUBRXTBNE
				{
					[Cpp2IlInjected.Token(Token = "0x6000040")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9130", Offset = "0x8DE7930", VA = "0x188DE9130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid SYHZCXGGQGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6DB0", Offset = "0x8DE55B0", VA = "0x188DE6DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid CXLTWFTKGFW
				{
					[Cpp2IlInjected.Token(Token = "0x6000042")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC430", Offset = "0x8DEAC30", VA = "0x188DEC430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid GLOIUIIGHMI
				{
					[Cpp2IlInjected.Token(Token = "0x6000043")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB130", Offset = "0x8DE9930", VA = "0x188DEB130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid TAPOIXVDXPB
				{
					[Cpp2IlInjected.Token(Token = "0x6000044")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9D30", Offset = "0x8DE8530", VA = "0x188DE9D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid RQXVPZJEEQK
				{
					[Cpp2IlInjected.Token(Token = "0x6000045")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE930", Offset = "0x8DED130", VA = "0x188DEE930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid CVXAZXGJNDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000046")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF630", Offset = "0x8DEDE30", VA = "0x188DEF630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid XZYVTLTGHLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000047")]
					[Cpp2IlInjected.Address(RVA = "0x8DF05B0", Offset = "0x8DEEDB0", VA = "0x188DF05B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid NDFVMTIPTLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA130", Offset = "0x8DE8930", VA = "0x188DEA130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid RVVSTBWXFFV
				{
					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3F70", Offset = "0x8DF2770", VA = "0x188DF3F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid OPEPSVMBQJH
				{
					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7730", Offset = "0x8DE5F30", VA = "0x188DE7730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid BVTDCTQLMGW
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6030", Offset = "0x8DE4830", VA = "0x188DE6030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid XIYEAVXIWRI
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAE30", Offset = "0x8DE9630", VA = "0x188DEAE30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid UNEYYLPQRCV
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0930", Offset = "0x8DEF130", VA = "0x188DF0930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid SVOIVFIYROR
				{
					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC630", Offset = "0x8DEAE30", VA = "0x188DEC630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid PIZFVVKZSOM
				{
					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4470", Offset = "0x8DF2C70", VA = "0x188DF4470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid NHQYPBUIGRC
				{
					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8AB0", Offset = "0x8DE72B0", VA = "0x188DE8AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid ERXTTSKJUGR
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB3B0", Offset = "0x8DE9BB0", VA = "0x188DEB3B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid TKEXWYPWCNP
				{
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDB30", Offset = "0x8DEC330", VA = "0x188DEDB30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid FVUQKVKRZMG
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8DF10B0", Offset = "0x8DEF8B0", VA = "0x188DF10B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid BDFBLKZEFSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x8DE81B0", Offset = "0x8DE69B0", VA = "0x188DE81B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid GNNTUHXCANI
				{
					[Cpp2IlInjected.Token(Token = "0x6000055")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9BB0", Offset = "0x8DE83B0", VA = "0x188DE9BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid HGGCSJKPTLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBEB0", Offset = "0x8DEA6B0", VA = "0x188DEBEB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid UVTSJWNOGCC
				{
					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDA30", Offset = "0x8DEC230", VA = "0x188DEDA30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid ITDPQWXACSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA8B0", Offset = "0x8DE90B0", VA = "0x188DEA8B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid UKSGBTFGOSD
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2F70", Offset = "0x8DF1770", VA = "0x188DF2F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid MCOSVMVAXSW
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5730", Offset = "0x8DE3F30", VA = "0x188DE5730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid FIBGFQSXMEX
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0F30", Offset = "0x8DEF730", VA = "0x188DF0F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid LUCKUTLBUGS
				{
					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8730", Offset = "0x8DE6F30", VA = "0x188DE8730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid OJONBUHZRAA
				{
					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF57F0", Offset = "0x8DF3FF0", VA = "0x188DF57F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid WIDQBNJTZXJ
				{
					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF11B0", Offset = "0x8DEF9B0", VA = "0x188DF11B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid VDZWTMFCKOV
				{
					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7EB0", Offset = "0x8DE66B0", VA = "0x188DE7EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid AIXBCQNRZBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE9B0", Offset = "0x8DED1B0", VA = "0x188DEE9B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid AYUBQHFUSLP
				{
					[Cpp2IlInjected.Token(Token = "0x6000061")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4AF0", Offset = "0x8DF32F0", VA = "0x188DF4AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid KRQKYZKLGTC
				{
					[Cpp2IlInjected.Token(Token = "0x6000062")]
					[Cpp2IlInjected.Address(RVA = "0x8DE66B0", Offset = "0x8DE4EB0", VA = "0x188DE66B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid TQQHRRWVIBE
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1EB0", Offset = "0x8DF06B0", VA = "0x188DF1EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid QLCJLZZOPLN
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9630", Offset = "0x8DE7E30", VA = "0x188DE9630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid OTCWFSXWUIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEDB0", Offset = "0x8DED5B0", VA = "0x188DEEDB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid QMCSZCWKGGU
				{
					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8DE84B0", Offset = "0x8DE6CB0", VA = "0x188DE84B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid CZKCPUNEFLP
				{
					[Cpp2IlInjected.Token(Token = "0x6000067")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8830", Offset = "0x8DE7030", VA = "0x188DE8830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid PVEPSQQAGMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000068")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0330", Offset = "0x8DEEB30", VA = "0x188DF0330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid ZTFNQVWBOPT
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3AF0", Offset = "0x8DF22F0", VA = "0x188DF3AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid RPUTBGKFERZ
				{
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3BF0", Offset = "0x8DF23F0", VA = "0x188DF3BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid QCBBPRDZGNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE4B0", Offset = "0x8DECCB0", VA = "0x188DEE4B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid ZIQHGVOISUJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF28F0", Offset = "0x8DF10F0", VA = "0x188DF28F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid GKSJJZWBVKL
				{
					[Cpp2IlInjected.Token(Token = "0x600006D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE65B0", Offset = "0x8DE4DB0", VA = "0x188DE65B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid HFXTVCPWFDJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4CF0", Offset = "0x8DF34F0", VA = "0x188DF4CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid HZBMVQUMLRN
				{
					[Cpp2IlInjected.Token(Token = "0x600006F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4670", Offset = "0x8DF2E70", VA = "0x188DF4670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid BJQKXNIIEGW
				{
					[Cpp2IlInjected.Token(Token = "0x6000070")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8330", Offset = "0x8DE6B30", VA = "0x188DE8330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid EPRVRXATJZZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000071")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6430", Offset = "0x8DE4C30", VA = "0x188DE6430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid EGQJGEACQQV
				{
					[Cpp2IlInjected.Token(Token = "0x6000072")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC930", Offset = "0x8DEB130", VA = "0x188DEC930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid UWSYGUPJVOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000073")]
					[Cpp2IlInjected.Address(RVA = "0x8DF53F0", Offset = "0x8DF3BF0", VA = "0x188DF53F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid EVLZCNCLBNM
				{
					[Cpp2IlInjected.Token(Token = "0x6000074")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA730", Offset = "0x8DE8F30", VA = "0x188DEA730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid XBCJQHFODPP
				{
					[Cpp2IlInjected.Token(Token = "0x6000075")]
					[Cpp2IlInjected.Address(RVA = "0x8DED4B0", Offset = "0x8DEBCB0", VA = "0x188DED4B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid LUFPKJETKUM
				{
					[Cpp2IlInjected.Token(Token = "0x6000076")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEC30", Offset = "0x8DED430", VA = "0x188DEEC30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid WYAHVUMGCXZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000077")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3170", Offset = "0x8DF1970", VA = "0x188DF3170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid ZSVURZZHYKN
				{
					[Cpp2IlInjected.Token(Token = "0x6000078")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBAB0", Offset = "0x8DEA2B0", VA = "0x188DEBAB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid XVMQGXRXHAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000079")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBC30", Offset = "0x8DEA430", VA = "0x188DEBC30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid GSHBIYUWFJE
				{
					[Cpp2IlInjected.Token(Token = "0x600007A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7430", Offset = "0x8DE5C30", VA = "0x188DE7430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid ETJZPZUAPRE
				{
					[Cpp2IlInjected.Token(Token = "0x600007B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF51F0", Offset = "0x8DF39F0", VA = "0x188DF51F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid OGESOJIXVJZ
				{
					[Cpp2IlInjected.Token(Token = "0x600007C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0BB0", Offset = "0x8DEF3B0", VA = "0x188DF0BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid PGDGYNGFKZA
				{
					[Cpp2IlInjected.Token(Token = "0x600007D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0630", Offset = "0x8DEEE30", VA = "0x188DF0630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid RVKPACNVEBX
				{
					[Cpp2IlInjected.Token(Token = "0x600007E")]
					[Cpp2IlInjected.Address(RVA = "0x8DE82B0", Offset = "0x8DE6AB0", VA = "0x188DE82B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid NVZEHLXYJKZ
				{
					[Cpp2IlInjected.Token(Token = "0x600007F")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB7B0", Offset = "0x8DE9FB0", VA = "0x188DEB7B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid LRTPEUTLKKH
				{
					[Cpp2IlInjected.Token(Token = "0x6000080")]
					[Cpp2IlInjected.Address(RVA = "0x8DED8B0", Offset = "0x8DEC0B0", VA = "0x188DED8B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid KCUQXKZJJPS
				{
					[Cpp2IlInjected.Token(Token = "0x6000081")]
					[Cpp2IlInjected.Address(RVA = "0x8DECAB0", Offset = "0x8DEB2B0", VA = "0x188DECAB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid BRSWJJRFACU
				{
					[Cpp2IlInjected.Token(Token = "0x6000082")]
					[Cpp2IlInjected.Address(RVA = "0x8DF36F0", Offset = "0x8DF1EF0", VA = "0x188DF36F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid ZQXODKIOWZN
				{
					[Cpp2IlInjected.Token(Token = "0x6000083")]
					[Cpp2IlInjected.Address(RVA = "0x8DED1B0", Offset = "0x8DEB9B0", VA = "0x188DED1B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid SHZWTRFAFEY
				{
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5570", Offset = "0x8DF3D70", VA = "0x188DF5570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid ILMMCGAETNN
				{
					[Cpp2IlInjected.Token(Token = "0x6000085")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA030", Offset = "0x8DE8830", VA = "0x188DEA030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid CBFPKOBDDCL
				{
					[Cpp2IlInjected.Token(Token = "0x6000086")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB5B0", Offset = "0x8DE9DB0", VA = "0x188DEB5B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid GOZKBAPKIEI
				{
					[Cpp2IlInjected.Token(Token = "0x6000087")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5470", Offset = "0x8DF3C70", VA = "0x188DF5470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid NLWAUEKQFGC
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF930", Offset = "0x8DEE130", VA = "0x188DEF930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid MJIEGFEZNHX
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF830", Offset = "0x8DEE030", VA = "0x188DEF830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid UXJYYYHSZMF
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7C30", Offset = "0x8DE6430", VA = "0x188DE7C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid CZNMNXVLKSP
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7CB0", Offset = "0x8DE64B0", VA = "0x188DE7CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid FQMWJEOQXQY
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF22F0", Offset = "0x8DF0AF0", VA = "0x188DF22F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid FYUDHANDTDN
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3370", Offset = "0x8DF1B70", VA = "0x188DF3370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid LDROVTPKGWG
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF230", Offset = "0x8DEDA30", VA = "0x188DEF230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid LDHBBGBPNZO
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF0B0", Offset = "0x8DED8B0", VA = "0x188DEF0B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid JOFCAHKRVBB
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0x8DED0B0", Offset = "0x8DEB8B0", VA = "0x188DED0B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid JMELBRTSERP
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0x8DECEB0", Offset = "0x8DEB6B0", VA = "0x188DECEB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid JLTXHEFXLUX
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0x8DECF30", Offset = "0x8DEB730", VA = "0x188DECF30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid HHIPFTTAUWP
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5070", Offset = "0x8DF3870", VA = "0x188DF5070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid FOMTJCZSRTD
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5830", Offset = "0x8DE4030", VA = "0x188DE5830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid PNGUOFEEISR
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC830", Offset = "0x8DEB030", VA = "0x188DEC830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid JCLAEFDXATS
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8BB0", Offset = "0x8DE73B0", VA = "0x188DE8BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid XSSVTJPESLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA9B0", Offset = "0x8DE91B0", VA = "0x188DEA9B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid LCSPFYEGZRN
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFFB0", Offset = "0x8DEE7B0", VA = "0x188DEFFB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid QBOJRQAMMGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8030", Offset = "0x8DE6830", VA = "0x188DE8030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid EZBURXOZIGT
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8FB0", Offset = "0x8DE77B0", VA = "0x188DE8FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid GRPJQIRCKSI
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF25F0", Offset = "0x8DF0DF0", VA = "0x188DF25F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid YPBUVXJNXTO
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF09B0", Offset = "0x8DEF1B0", VA = "0x188DF09B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid HBMYEQHGIRC
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB930", Offset = "0x8DEA130", VA = "0x188DEB930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid GGOHFIRPKSJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA5B0", Offset = "0x8DE8DB0", VA = "0x188DEA5B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid JWJRLUYRQJG
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBCB0", Offset = "0x8DEA4B0", VA = "0x188DEBCB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid YMVDLIAQFEH
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0x8DEECB0", Offset = "0x8DED4B0", VA = "0x188DEECB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid LTPQXKSRVIY
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0x8DF13B0", Offset = "0x8DEFBB0", VA = "0x188DF13B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid QKHVYPDQCAQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5D70", Offset = "0x8DF4570", VA = "0x188DF5D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid OYBJZNLGPKX
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9530", Offset = "0x8DE7D30", VA = "0x188DE9530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid LAJJNCIJCDE
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0x8DE71B0", Offset = "0x8DE59B0", VA = "0x188DE71B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid CDVIKKHWZRC
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2B70", Offset = "0x8DF1370", VA = "0x188DF2B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid NUVRXHTMXME
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC2B0", Offset = "0x8DEAAB0", VA = "0x188DEC2B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid DDJSUMHDVEG
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6730", Offset = "0x8DE4F30", VA = "0x188DE6730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid QQRFXYWMAML
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0x8DF29F0", Offset = "0x8DF11F0", VA = "0x188DF29F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid EQEAOJBFJGV
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0x8DF00B0", Offset = "0x8DEE8B0", VA = "0x188DF00B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid TZYNUONXKFM
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6830", Offset = "0x8DE5030", VA = "0x188DE6830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid SXSACBOCDXZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEF30", Offset = "0x8DED730", VA = "0x188DEEF30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid OETJSLSZBSF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5970", Offset = "0x8DF4170", VA = "0x188DF5970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid LVUENVALREF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0FB0", Offset = "0x8DEF7B0", VA = "0x188DF0FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid EHXCINNOFSV
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1630", Offset = "0x8DEFE30", VA = "0x188DF1630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid GFLYLRCNICK
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3970", Offset = "0x8DF2170", VA = "0x188DF3970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid KASYZPLCOFV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x8DECD30", Offset = "0x8DEB530", VA = "0x188DECD30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid ZSRADFHQHHC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE6B0", Offset = "0x8DECEB0", VA = "0x188DEE6B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid TWTTRXCECHS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC530", Offset = "0x8DEAD30", VA = "0x188DEC530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid AOIEOJGURPY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE0B0", Offset = "0x8DEC8B0", VA = "0x188DEE0B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid YORXNYXYSXF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x8DE62B0", Offset = "0x8DE4AB0", VA = "0x188DE62B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid MYXUIXBBLSW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDDB0", Offset = "0x8DEC5B0", VA = "0x188DEDDB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid KXEZHGOCZAB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF530", Offset = "0x8DEDD30", VA = "0x188DEF530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid EYAEPJSQWAU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE030", Offset = "0x8DEC830", VA = "0x188DEE030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid WBMWPHAQCEN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x8DF56F0", Offset = "0x8DF3EF0", VA = "0x188DF56F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid WXLPHNOQJNR
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC230", Offset = "0x8DEAA30", VA = "0x188DEC230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid CZSXKZWUGGL
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x8DE90B0", Offset = "0x8DE78B0", VA = "0x188DE90B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid IWJCWANZXQS
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9C30", Offset = "0x8DE8430", VA = "0x188DE9C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid IRPKRJPQORF
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0x8DE64B0", Offset = "0x8DE4CB0", VA = "0x188DE64B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid PETVBBVTYHG
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0x8DE57B0", Offset = "0x8DE3FB0", VA = "0x188DE57B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid NWQIWCEMXZR
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0x8DF27F0", Offset = "0x8DF0FF0", VA = "0x188DF27F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid KRWDOKGPHCK
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3870", Offset = "0x8DF2070", VA = "0x188DF3870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid XLJOAGGHPFD
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEEB0", Offset = "0x8DED6B0", VA = "0x188DEEEB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid ZMJSEWEOTIN
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF6B0", Offset = "0x8DEDEB0", VA = "0x188DEF6B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid VTRETJDGHSB
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0x8DED3B0", Offset = "0x8DEBBB0", VA = "0x188DED3B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid WLYZRXGKSVX
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE630", Offset = "0x8DECE30", VA = "0x188DEE630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid EPSFWPDGJXJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDC30", Offset = "0x8DEC430", VA = "0x188DEDC30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid NNCXRVDOTSE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0530", Offset = "0x8DEED30", VA = "0x188DF0530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid DFHGJMQYXCJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3C70", Offset = "0x8DF2470", VA = "0x188DF3C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid IUGDCHVDRWF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1FB0", Offset = "0x8DF07B0", VA = "0x188DF1FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid QERUZHDBFLE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5CB0", Offset = "0x8DE44B0", VA = "0x188DE5CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid WFZFYQLFHAP
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7230", Offset = "0x8DE5A30", VA = "0x188DE7230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid XFDGBPWMIBP
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6B30", Offset = "0x8DE5330", VA = "0x188DE6B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid BXCGUDWXNAF
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFDB0", Offset = "0x8DEE5B0", VA = "0x188DEFDB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid HXAWYRMCBXS
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0x8DE97B0", Offset = "0x8DE7FB0", VA = "0x188DE97B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid TMWNNLXUGKI
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0x8DF41F0", Offset = "0x8DF29F0", VA = "0x188DF41F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid WPGUXGHVGWK
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5AF0", Offset = "0x8DF42F0", VA = "0x188DF5AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid IKEBPRCLAQD
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2C70", Offset = "0x8DF1470", VA = "0x188DF2C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid CLKXHMZEIWV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5BB0", Offset = "0x8DE43B0", VA = "0x188DE5BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid POOSKVMPWAC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF3B0", Offset = "0x8DEDBB0", VA = "0x188DEF3B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid RVHGZDCCKCE
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAC30", Offset = "0x8DE9430", VA = "0x188DEAC30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid ECIIFRERZOY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9330", Offset = "0x8DE7B30", VA = "0x188DE9330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid HWZLJKNTLKQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9FB0", Offset = "0x8DE87B0", VA = "0x188DE9FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid QXUQOMWINJU
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEFB0", Offset = "0x8DED7B0", VA = "0x188DEEFB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid HDQXLDNWBWX
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0x8DE85B0", Offset = "0x8DE6DB0", VA = "0x188DE85B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid FOVPLWXHSHJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0E30", Offset = "0x8DEF630", VA = "0x188DF0E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid DIVKLCEGLDO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1130", Offset = "0x8DEF930", VA = "0x188DF1130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid TGKAANXQWGK
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2070", Offset = "0x8DF0870", VA = "0x188DF2070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid SGBAJIGDCLO
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7E30", Offset = "0x8DE6630", VA = "0x188DE7E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid UQFRQORCMML
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFA30", Offset = "0x8DEE230", VA = "0x188DEFA30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid KODLDAIFRQT
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0x8DE76B0", Offset = "0x8DE5EB0", VA = "0x188DE76B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid OYJKERQRKPS
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDE30", Offset = "0x8DEC630", VA = "0x188DEDE30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid RMZIVECKGJV
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1CB0", Offset = "0x8DF04B0", VA = "0x188DF1CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid JROWVSQZJOP
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5EB0", Offset = "0x8DE46B0", VA = "0x188DE5EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid YNUGQFQCQYR
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE3B0", Offset = "0x8DECBB0", VA = "0x188DEE3B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid GGYVPIZEHUE
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAFB0", Offset = "0x8DE97B0", VA = "0x188DEAFB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid HJPGWOZCQSW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5FB0", Offset = "0x8DE47B0", VA = "0x188DE5FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid UQZQRYMZZXS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5170", Offset = "0x8DF3970", VA = "0x188DF5170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid MEOUZALINBC
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9B30", Offset = "0x8DE8330", VA = "0x188DE9B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid GTQAISQGDNZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6330", Offset = "0x8DE4B30", VA = "0x188DE6330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid IUIVBIYWSZZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0x8DEABB0", Offset = "0x8DE93B0", VA = "0x188DEABB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid DBLWMQTZEZK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0x8DED5B0", Offset = "0x8DEBDB0", VA = "0x188DED5B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid VXLVMJEWLEW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9030", Offset = "0x8DE7830", VA = "0x188DE9030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid IXUMYFOMQBL
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0830", Offset = "0x8DEF030", VA = "0x188DF0830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid JCSHBYBDTUK
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB6B0", Offset = "0x8DE9EB0", VA = "0x188DEB6B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid AHLTGYRKDXZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1330", Offset = "0x8DEFB30", VA = "0x188DF1330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid WTHSDWBVUGY
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF5B0", Offset = "0x8DEDDB0", VA = "0x188DEF5B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid DCCQLKUTNCQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEBB0", Offset = "0x8DED3B0", VA = "0x188DEEBB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid FKLDJMDMCVD
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFBB0", Offset = "0x8DEE3B0", VA = "0x188DEFBB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid FRHVGZGPTEF
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2AF0", Offset = "0x8DF12F0", VA = "0x188DF2AF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid NZWCITCXSNW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE530", Offset = "0x8DECD30", VA = "0x188DEE530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid UIGMJHMUETG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0730", Offset = "0x8DEEF30", VA = "0x188DF0730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid BLJEMTFDHAJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3670", Offset = "0x8DF1E70", VA = "0x188DF3670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid QDXREIAASLR
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDD30", Offset = "0x8DEC530", VA = "0x188DEDD30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid DKHEPOLSZLN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0x8DF55F0", Offset = "0x8DF3DF0", VA = "0x188DF55F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid RYVMFGCRUZA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0x8DE58B0", Offset = "0x8DE40B0", VA = "0x188DE58B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid THTQYSZHTBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0x8DE78B0", Offset = "0x8DE60B0", VA = "0x188DE78B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid TMOYLIISMHZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0130", Offset = "0x8DEE930", VA = "0x188DF0130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid GRHGXEARVWH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAD30", Offset = "0x8DE9530", VA = "0x188DEAD30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid EMFMQFZZUNK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB9B0", Offset = "0x8DEA1B0", VA = "0x188DEB9B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid DICDXPXCZIK
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1DB0", Offset = "0x8DF05B0", VA = "0x188DF1DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid DUCKZKPLUCZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1930", Offset = "0x8DF0130", VA = "0x188DF1930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid NLAJIGNLDOL
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8230", Offset = "0x8DE6A30", VA = "0x188DE8230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid PDNXWACNTZF
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x8DE67B0", Offset = "0x8DE4FB0", VA = "0x188DE67B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid QSPCOJJZFRX
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0x8DF52F0", Offset = "0x8DF3AF0", VA = "0x188DF52F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid XYPDFLNRFZR
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF39F0", Offset = "0x8DF21F0", VA = "0x188DF39F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid MYPESCOKZXN
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8DB0", Offset = "0x8DE75B0", VA = "0x188DE8DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid LJHWPAQZRMB
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0x8DF04B0", Offset = "0x8DEECB0", VA = "0x188DF04B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid VYUWXEVADMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0x8DECDB0", Offset = "0x8DEB5B0", VA = "0x188DECDB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid OVLWGDKOOPD
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5A70", Offset = "0x8DF4270", VA = "0x188DF5A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid JUJZSYCMCMT
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0x8DF30F0", Offset = "0x8DF18F0", VA = "0x188DF30F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid EBSRQIRCKGD
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE230", Offset = "0x8DECA30", VA = "0x188DEE230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid YBGGIGZYWLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6EB0", Offset = "0x8DE56B0", VA = "0x188DE6EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid WXGJLWASQIE
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6A30", Offset = "0x8DE5230", VA = "0x188DE6A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid ZFIUBOEHJIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4BF0", Offset = "0x8DF33F0", VA = "0x188DF4BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid BJCYKRVPGVS
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5C30", Offset = "0x8DE4430", VA = "0x188DE5C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid ERIQQYIKOFC
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFF30", Offset = "0x8DEE730", VA = "0x188DEFF30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid JJJKJMLEHOP
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8130", Offset = "0x8DE6930", VA = "0x188DE8130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid JXIVEDAKPMN
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE59B0", Offset = "0x8DE41B0", VA = "0x188DE59B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid DMYAOOXPWQH
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7830", Offset = "0x8DE6030", VA = "0x188DE7830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid SJMVWQTAYRA
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4370", Offset = "0x8DF2B70", VA = "0x188DF4370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid YUZQKHOQPRP
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1F30", Offset = "0x8DF0730", VA = "0x188DF1F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid DEUIFUSXDJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2370", Offset = "0x8DF0B70", VA = "0x188DF2370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid FYXXATAWHCV
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA530", Offset = "0x8DE8D30", VA = "0x188DEA530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid DZGEONDNTGJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x8DF42F0", Offset = "0x8DF2AF0", VA = "0x188DF42F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid PHKEGDRHXVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3D70", Offset = "0x8DF2570", VA = "0x188DF3D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid VDGPURFWUGA
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5B70", Offset = "0x8DF4370", VA = "0x188DF5B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid YBRVWUNVTON
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7330", Offset = "0x8DE5B30", VA = "0x188DE7330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid XJQJLNFVWSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6930", Offset = "0x8DE5130", VA = "0x188DE6930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid PUXTIBPGLSZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8D30", Offset = "0x8DE7530", VA = "0x188DE8D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid JHAMFHFIOYM
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8C30", Offset = "0x8DE7430", VA = "0x188DE8C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid FCVSGHGWETZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA2B0", Offset = "0x8DE8AB0", VA = "0x188DEA2B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid JSASRBGRFWE
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1BB0", Offset = "0x8DF03B0", VA = "0x188DF1BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid YVMYUFTPAFU
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF19B0", Offset = "0x8DF01B0", VA = "0x188DF19B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid HCQFUSIHAYY
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFB30", Offset = "0x8DEE330", VA = "0x188DEFB30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid FNIXYWHMAUF
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF03B0", Offset = "0x8DEEBB0", VA = "0x188DF03B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid KJVYQOODCUF
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4A70", Offset = "0x8DF3270", VA = "0x188DF4A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid BRZNSMABGUR
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0230", Offset = "0x8DEEA30", VA = "0x188DF0230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid FQJUGATAQLI
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6230", Offset = "0x8DE4A30", VA = "0x188DE6230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid RJEHPWSEDVW
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2170", Offset = "0x8DF0970", VA = "0x188DF2170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid KSHQGMUYFCB
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9CB0", Offset = "0x8DE84B0", VA = "0x188DE9CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid RHBDSDUDIWT
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x8DF17B0", Offset = "0x8DEFFB0", VA = "0x188DF17B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid GMWXHPEUNVN
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x8DEED30", Offset = "0x8DED530", VA = "0x188DEED30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid JRPPZWSMSWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAA30", Offset = "0x8DE9230", VA = "0x188DEAA30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid ECWSDOWEZJC
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBE30", Offset = "0x8DEA630", VA = "0x188DEBE30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid BWBISRHGBTL
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0x8DE69B0", Offset = "0x8DE51B0", VA = "0x188DE69B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid OFUWRNHJNGT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0x8DF06B0", Offset = "0x8DEEEB0", VA = "0x188DF06B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid FTVLEJHMRUQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1B30", Offset = "0x8DF0330", VA = "0x188DF1B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid OSDDVAYANJK
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6130", Offset = "0x8DE4930", VA = "0x188DE6130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid OKIDLTOFPOH
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9DB0", Offset = "0x8DE85B0", VA = "0x188DE9DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid CWWEYSPTZJS
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5F30", Offset = "0x8DE4730", VA = "0x188DE5F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid VVLXDLASXAN
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5B30", Offset = "0x8DE4330", VA = "0x188DE5B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid XQRSCWOZPEG
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC0B0", Offset = "0x8DEA8B0", VA = "0x188DEC0B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid EKPONHJQRJP
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0x8DE79B0", Offset = "0x8DE61B0", VA = "0x188DE79B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid CZKQXMFOYGC
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6530", Offset = "0x8DE4D30", VA = "0x188DE6530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid HZAXYPNVXOR
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0x8DF02B0", Offset = "0x8DEEAB0", VA = "0x188DF02B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid ZPVLVTFTFXG
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0x8DECFB0", Offset = "0x8DEB7B0", VA = "0x188DECFB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid TSTMCLOQRTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0x8DECE30", Offset = "0x8DEB630", VA = "0x188DECE30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid VQFQBABPIOE
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5C70", Offset = "0x8DF4470", VA = "0x188DF5C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid QZJQNWJDCBU
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8E30", Offset = "0x8DE7630", VA = "0x188DE8E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid ZHVORVCMTWZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x8DE98B0", Offset = "0x8DE80B0", VA = "0x188DE98B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid XREHIIKXOWG
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE130", Offset = "0x8DEC930", VA = "0x188DEE130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid CWGGIKTSFOD
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1830", Offset = "0x8DF0030", VA = "0x188DF1830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid LFGLRQZEVFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8B30", Offset = "0x8DE7330", VA = "0x188DE8B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid VCVUHAEZMSX
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDFB0", Offset = "0x8DEC7B0", VA = "0x188DEDFB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid UHFAOXFBNBM
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF16B0", Offset = "0x8DEFEB0", VA = "0x188DF16B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid EWERHGWYLFI
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE61B0", Offset = "0x8DE49B0", VA = "0x188DE61B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid OXXTMWNWSGG
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFAB0", Offset = "0x8DEE2B0", VA = "0x188DEFAB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid DKTDLXBWYRG
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1030", Offset = "0x8DEF830", VA = "0x188DF1030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid IEPNGYJJAOW
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4F70", Offset = "0x8DF3770", VA = "0x188DF4F70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid MEROENCEASN
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBBB0", Offset = "0x8DEA3B0", VA = "0x188DEBBB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid IEKGJRPLRDN
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4E70", Offset = "0x8DF3670", VA = "0x188DF4E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid IEEZMKVOHSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4EF0", Offset = "0x8DF36F0", VA = "0x188DF4EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid WVPUDDNRMDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5BF0", Offset = "0x8DF43F0", VA = "0x188DF5BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid GMCTENNQDKF
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0x8DED2B0", Offset = "0x8DEBAB0", VA = "0x188DED2B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid GLMYMTFYBCE
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0x8DED230", Offset = "0x8DEBA30", VA = "0x188DED230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid TEAEQWGTYOG
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB4B0", Offset = "0x8DE9CB0", VA = "0x188DEB4B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid ZUWUPAAHZGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x8DE60B0", Offset = "0x8DE48B0", VA = "0x188DE60B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid PUMGOBCBZHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x8DED7B0", Offset = "0x8DEBFB0", VA = "0x188DED7B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid LGVVNKSDTRC
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9A30", Offset = "0x8DE8230", VA = "0x188DE9A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid UHUQQRHCMOC
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC7B0", Offset = "0x8DEAFB0", VA = "0x188DEC7B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid IEIMJTKESUN
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF59F0", Offset = "0x8DF41F0", VA = "0x188DF59F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid PYPXXDYFJZN
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF12B0", Offset = "0x8DEFAB0", VA = "0x188DF12B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid AGVBQJIEPAX
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4970", Offset = "0x8DF3170", VA = "0x188DF4970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid TMRMESPTCFO
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBD30", Offset = "0x8DEA530", VA = "0x188DEBD30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid DICEEEBHSQB
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8EB0", Offset = "0x8DE76B0", VA = "0x188DE8EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid XEXFQJUBTXJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2970", Offset = "0x8DF1170", VA = "0x188DF2970")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid KQQMUCQYYLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0A30", Offset = "0x8DEF230", VA = "0x188DF0A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid ASVMIOETKIA
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0x8DED730", Offset = "0x8DEBF30", VA = "0x188DED730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid MNVCZZZKCEX
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2470", Offset = "0x8DF0C70", VA = "0x188DF2470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid GHVAVTWOSCO
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC730", Offset = "0x8DEAF30", VA = "0x188DEC730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid TYHWKUSRPQG
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB730", Offset = "0x8DE9F30", VA = "0x188DEB730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid TVXZLHIHPDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAAB0", Offset = "0x8DE92B0", VA = "0x188DEAAB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid UKBQZVYAJTD
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB630", Offset = "0x8DE9E30", VA = "0x188DEB630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid OESNWTSMJII
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDBB0", Offset = "0x8DEC3B0", VA = "0x188DEDBB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid VMKDFQHOBUH
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA4B0", Offset = "0x8DE8CB0", VA = "0x188DEA4B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid FRKRUJUNWUI
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0x8DF23F0", Offset = "0x8DF0BF0", VA = "0x188DF23F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid RPFZZQRZUSB
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF14B0", Offset = "0x8DEFCB0", VA = "0x188DF14B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid IWWJMDHTQJD
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5E30", Offset = "0x8DE4630", VA = "0x188DE5E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid WMFZYZXHLRD
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2570", Offset = "0x8DF0D70", VA = "0x188DF2570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid ZLOBXIGAFJQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBA30", Offset = "0x8DEA230", VA = "0x188DEBA30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid UKRUMRGUJLM
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB8B0", Offset = "0x8DEA0B0", VA = "0x188DEB8B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid BAKXHIFXQMT
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8530", Offset = "0x8DE6D30", VA = "0x188DE8530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid KMAARUUONPP
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0x8DF07B0", Offset = "0x8DEEFB0", VA = "0x188DF07B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid NFFAOYEZHOY
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0x8DECB30", Offset = "0x8DEB330", VA = "0x188DECB30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid QTGFHMVMDBX
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC6B0", Offset = "0x8DEAEB0", VA = "0x188DEC6B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid GRVIIUYTXZF
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7DB0", Offset = "0x8DE65B0", VA = "0x188DE7DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid AYUMCKNRVFJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4070", Offset = "0x8DF2870", VA = "0x188DF4070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid WRPCSSOMRAF
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0x8DEACB0", Offset = "0x8DE94B0", VA = "0x188DEACB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid GURGPEGNOQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4170", Offset = "0x8DF2970", VA = "0x188DF4170")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid AVYNYGWOTAF
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAF30", Offset = "0x8DE9730", VA = "0x188DEAF30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid CPFGBBKSMSB
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFD30", Offset = "0x8DEE530", VA = "0x188DEFD30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid QXCMZFOSUMN
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA230", Offset = "0x8DE8A30", VA = "0x188DEA230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid ZUDXJVCLSTP
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE7B0", Offset = "0x8DECFB0", VA = "0x188DEE7B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid NOWMENKLIGN
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE83B0", Offset = "0x8DE6BB0", VA = "0x188DE83B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid HPPPKELLKVJ
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6FB0", Offset = "0x8DE57B0", VA = "0x188DE6FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid OQCFMZINGHL
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0DB0", Offset = "0x8DEF5B0", VA = "0x188DF0DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid BJCFFROKDPC
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1E30", Offset = "0x8DF0630", VA = "0x188DF1E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid TFOVJIXJKED
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA930", Offset = "0x8DE9130", VA = "0x188DEA930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid VQBXFHTOHAG
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0x8DF24F0", Offset = "0x8DF0CF0", VA = "0x188DF24F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid IPPMEERLRQS
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC8B0", Offset = "0x8DEB0B0", VA = "0x188DEC8B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid WOOYQEAITGK
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9E30", Offset = "0x8DE8630", VA = "0x188DE9E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid ZKHMXBZIFRL
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3B70", Offset = "0x8DF2370", VA = "0x188DF3B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid QUXCUJZMEXO
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0D30", Offset = "0x8DEF530", VA = "0x188DF0D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid HWGNXCKDAXF
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9AB0", Offset = "0x8DE82B0", VA = "0x188DE9AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid QQXKDFMHYQG
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6AB0", Offset = "0x8DE52B0", VA = "0x188DE6AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid VXKACLFPLAP
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB1B0", Offset = "0x8DE99B0", VA = "0x188DEB1B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid ODXILSORHDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0x8DE95B0", Offset = "0x8DE7DB0", VA = "0x188DE95B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid ABDQNTRMJZH
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC9B0", Offset = "0x8DEB1B0", VA = "0x188DEC9B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid SSTTTILNRJW
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEB30", Offset = "0x8DED330", VA = "0x188DEEB30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid SXUEIZDWLPN
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDEB0", Offset = "0x8DEC6B0", VA = "0x188DEDEB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid JYISEZEPKWP
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2770", Offset = "0x8DF0F70", VA = "0x188DF2770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid VCUWTADKGSL
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7A30", Offset = "0x8DE6230", VA = "0x188DE7A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid GDPDGNBSPRO
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF130", Offset = "0x8DED930", VA = "0x188DEF130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid UKTEMEDBVKM
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA1B0", Offset = "0x8DE89B0", VA = "0x188DEA1B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid EIUYETIKMXY
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFE30", Offset = "0x8DEE630", VA = "0x188DEFE30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid LUIIMKHHCSZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9830", Offset = "0x8DE8030", VA = "0x188DE9830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid OSKFMWXMJJH
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0x8DE94B0", Offset = "0x8DE7CB0", VA = "0x188DE94B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid ARBUNMNTHQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEE30", Offset = "0x8DED630", VA = "0x188DEEE30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid DAXPDJMKKEF
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF7B0", Offset = "0x8DEDFB0", VA = "0x188DEF7B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid HFVDPMBEDEO
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDCB0", Offset = "0x8DEC4B0", VA = "0x188DEDCB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid SADKYTXDBXX
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1AB0", Offset = "0x8DF02B0", VA = "0x188DF1AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid PZJGGRFMCTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0x8DF32F0", Offset = "0x8DF1AF0", VA = "0x188DF32F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid IESBVPMEWNP
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x8DE96B0", Offset = "0x8DE7EB0", VA = "0x188DE96B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid LPGGIESOJTY
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9930", Offset = "0x8DE8130", VA = "0x188DE9930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid ZSHWJAWSKVG
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7630", Offset = "0x8DE5E30", VA = "0x188DE7630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid WUTYFOWWIZN
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE77B0", Offset = "0x8DE5FB0", VA = "0x188DE77B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid LRLATILLABB
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6D30", Offset = "0x8DE5530", VA = "0x188DE6D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid PAAIHFNTDQU
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBFB0", Offset = "0x8DEA7B0", VA = "0x188DEBFB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid PEPJHODELWK
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6630", Offset = "0x8DE4E30", VA = "0x188DE6630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid IBWTPEGYVTI
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB430", Offset = "0x8DE9C30", VA = "0x188DEB430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid TBQIJLMPORR
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3FF0", Offset = "0x8DF27F0", VA = "0x188DF3FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid VKOHTUOVHEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA0B0", Offset = "0x8DE88B0", VA = "0x188DEA0B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid OCCKRTEFTNQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF430", Offset = "0x8DEDC30", VA = "0x188DEF430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid TGTGKGKSOLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0x8DF54F0", Offset = "0x8DF3CF0", VA = "0x188DF54F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid VTZQJRGDFBZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDF30", Offset = "0x8DEC730", VA = "0x188DEDF30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid TEXGHSVKVUI
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0x8DE70B0", Offset = "0x8DE58B0", VA = "0x188DE70B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid KWSJAJTVWAK
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5870", Offset = "0x8DF4070", VA = "0x188DF5870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid QHMOVLFXTCP
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0x8DF26F0", Offset = "0x8DF0EF0", VA = "0x188DF26F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid QLBZITJJMQA
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5670", Offset = "0x8DF3E70", VA = "0x188DF5670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid PJNOQPJNPBO
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6CB0", Offset = "0x8DE54B0", VA = "0x188DE6CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid MXYEBCDRUMW
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF44F0", Offset = "0x8DF2CF0", VA = "0x188DF44F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid SXGQXKABXGQ
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3EF0", Offset = "0x8DF26F0", VA = "0x188DF3EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid UWYXRWFSFDU
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0x8DED830", Offset = "0x8DEC030", VA = "0x188DED830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid FPSFTHIDEJP
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3070", Offset = "0x8DF1870", VA = "0x188DF3070")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid NHRWMVYOSQH
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5AB0", Offset = "0x8DE42B0", VA = "0x188DE5AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid RUKHMSUJLPM
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0x8DED130", Offset = "0x8DEB930", VA = "0x188DED130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid UDEETEIWQEJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA830", Offset = "0x8DE9030", VA = "0x188DEA830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid OIDDXUSUNHH
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0x8DF34F0", Offset = "0x8DF1CF0", VA = "0x188DF34F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid UTQOTJYIBFY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x8DE93B0", Offset = "0x8DE7BB0", VA = "0x188DE93B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid VOIHWWLOPZV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBDB0", Offset = "0x8DEA5B0", VA = "0x188DEBDB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid WLNRIOMLMEP
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x8DE63B0", Offset = "0x8DE4BB0", VA = "0x188DE63B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid LCCUDLQNTOP
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE5B0", Offset = "0x8DECDB0", VA = "0x188DEE5B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid CLMVPFWPTDY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0x8DE74B0", Offset = "0x8DE5CB0", VA = "0x188DE74B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid NOVTWKIGGMT
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0x8DED330", Offset = "0x8DEBB30", VA = "0x188DED330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid LGRIBMSSUFT
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6F30", Offset = "0x8DE5730", VA = "0x188DE6F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid HVATULCNKVA
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2870", Offset = "0x8DF1070", VA = "0x188DF2870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid XCWOHUZARZB
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2270", Offset = "0x8DF0A70", VA = "0x188DF2270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid OEQHOMRAUAS
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0x8DF38F0", Offset = "0x8DF20F0", VA = "0x188DF38F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid FYBQDHZAJHY
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA3B0", Offset = "0x8DE8BB0", VA = "0x188DEA3B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid RQXYKXZFINY
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBB30", Offset = "0x8DEA330", VA = "0x188DEBB30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid ULPWFONCPTL
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5370", Offset = "0x8DF3B70", VA = "0x188DF5370")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid EKAMQBMZRSD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4B70", Offset = "0x8DF3370", VA = "0x188DF4B70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid SYRFZLQQUET
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3E70", Offset = "0x8DF2670", VA = "0x188DF3E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid OJJNYSSWNTF
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2EF0", Offset = "0x8DF16F0", VA = "0x188DF2EF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid JGFPOILDTYP
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3470", Offset = "0x8DF1C70", VA = "0x188DF3470")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid QGXTQHMIQJD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB330", Offset = "0x8DE9B30", VA = "0x188DEB330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid UDYGJKFRNEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7B30", Offset = "0x8DE6330", VA = "0x188DE7B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid KFPASNSFTXN
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8CB0", Offset = "0x8DE74B0", VA = "0x188DE8CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid QQJAHSHKQEK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x8DF15B0", Offset = "0x8DEFDB0", VA = "0x188DF15B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid ZZFUOFGAOQQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0x8DF37F0", Offset = "0x8DF1FF0", VA = "0x188DF37F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid UNQHDOIVMRJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x8DE92B0", Offset = "0x8DE7AB0", VA = "0x188DE92B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid XXPFHHWIWFT
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE730", Offset = "0x8DECF30", VA = "0x188DEE730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid UPOPXLZRXJL
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0EB0", Offset = "0x8DEF6B0", VA = "0x188DF0EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid FWNMDQOCQFQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1430", Offset = "0x8DEFC30", VA = "0x188DF1430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid BITBYNUMZYR
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA330", Offset = "0x8DE8B30", VA = "0x188DEA330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid MSQNBGTMAOU
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0x8DF45F0", Offset = "0x8DF2DF0", VA = "0x188DF45F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid HDZGCZFJBZU
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB2B0", Offset = "0x8DE9AB0", VA = "0x188DEB2B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid SMJNZRGZWTE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB030", Offset = "0x8DE9830", VA = "0x188DEB030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid COGIJIRLAEW
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7030", Offset = "0x8DE5830", VA = "0x188DE7030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid QHGZSCZMIKA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE830", Offset = "0x8DED030", VA = "0x188DEE830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid PGFGMQKRROB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFEB0", Offset = "0x8DEE6B0", VA = "0x188DEFEB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid SJLELABXEYL
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC330", Offset = "0x8DEAB30", VA = "0x188DEC330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid DFBNJSFNJVF
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8630", Offset = "0x8DE6E30", VA = "0x188DE8630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid HFXEPZAUWMM
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2CF0", Offset = "0x8DF14F0", VA = "0x188DF2CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid XONFTUNVBYB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0x8DE68B0", Offset = "0x8DE50B0", VA = "0x188DE68B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid PUMYDKPPQBE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4FF0", Offset = "0x8DF37F0", VA = "0x188DF4FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid LALVQEVNSGJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5DB0", Offset = "0x8DE45B0", VA = "0x188DE5DB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid WDJDSBUBVAQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9730", Offset = "0x8DE7F30", VA = "0x188DE9730")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid AWGDONHIWNX
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0x8DED6B0", Offset = "0x8DEBEB0", VA = "0x188DED6B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid UXVEPFHNQKU
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0x8DE72B0", Offset = "0x8DE5AB0", VA = "0x188DE72B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid ZIZNGEVCTUV
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8930", Offset = "0x8DE7130", VA = "0x188DE8930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid NNRNASGDLOR
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0x8DEAB30", Offset = "0x8DE9330", VA = "0x188DEAB30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid BKPVUTOTDRI
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0CB0", Offset = "0x8DEF4B0", VA = "0x188DF0CB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid PDYPUPQFWQG
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4770", Offset = "0x8DF2F70", VA = "0x188DF4770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid TJUDWUTXJIB
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC1B0", Offset = "0x8DEA9B0", VA = "0x188DEC1B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid FBYFAJNEVWD
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x8DE91B0", Offset = "0x8DE79B0", VA = "0x188DE91B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid VTFWXNVBLPN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4D70", Offset = "0x8DF3570", VA = "0x188DF4D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid ONTJEXMXDCM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0AB0", Offset = "0x8DEF2B0", VA = "0x188DF0AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid ONDONDFFAUL
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0B30", Offset = "0x8DEF330", VA = "0x188DF0B30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid VYBNKOIQRRN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2DF0", Offset = "0x8DF15F0", VA = "0x188DF2DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid REVEFRQPYUI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9430", Offset = "0x8DE7C30", VA = "0x188DE9430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid PDRJBPOPWKM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE2B0", Offset = "0x8DECAB0", VA = "0x188DEE2B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid LYTVOYQCWUX
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0x8DED930", Offset = "0x8DEC130", VA = "0x188DED930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid DYKQHSPUQTU
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5770", Offset = "0x8DF3F70", VA = "0x188DF5770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid EOWLNSFVNLW
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4870", Offset = "0x8DF3070", VA = "0x188DF4870")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid RTABKIHMTHZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4DF0", Offset = "0x8DF35F0", VA = "0x188DF4DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid WMKAJNEOOOI
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE430", Offset = "0x8DECC30", VA = "0x188DEE430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid CBOEODMFWKU
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFC30", Offset = "0x8DEE430", VA = "0x188DEFC30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid QSBADZYJQFY
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF58F0", Offset = "0x8DF40F0", VA = "0x188DF58F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid JZFLLMFEBFK
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3A70", Offset = "0x8DF2270", VA = "0x188DF3A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid BTWNPFYCRMR
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0x8DECBB0", Offset = "0x8DEB3B0", VA = "0x188DECBB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid PJHVCMTHXPI
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3270", Offset = "0x8DF1A70", VA = "0x188DF3270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid RRFQURFGIBL
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7530", Offset = "0x8DE5D30", VA = "0x188DE7530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid LUHEBQBCAZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0x8DF20F0", Offset = "0x8DF08F0", VA = "0x188DF20F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid ZTKNZBIUWIP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0x8DEDAB0", Offset = "0x8DEC2B0", VA = "0x188DEDAB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid HLYBBEQDBPH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0x8DE86B0", Offset = "0x8DE6EB0", VA = "0x188DE86B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid YADCSBOWBXH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0x8DF08B0", Offset = "0x8DEF0B0", VA = "0x188DF08B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid IPQNCDTNEWV
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF330", Offset = "0x8DEDB30", VA = "0x188DEF330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid RTNQJFFTAMA
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2E70", Offset = "0x8DF1670", VA = "0x188DF2E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid EJGFFLRTNVW
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6E30", Offset = "0x8DE5630", VA = "0x188DE6E30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid ZCABMDYIGUB
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF4B0", Offset = "0x8DEDCB0", VA = "0x188DEF4B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid ZXFLTFGBCBK
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0x8DF31F0", Offset = "0x8DF19F0", VA = "0x188DF31F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid GQOIHEVJPVX
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0x8DF47F0", Offset = "0x8DF2FF0", VA = "0x188DF47F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid GEXBLRNAHYC
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC4B0", Offset = "0x8DEACB0", VA = "0x188DEC4B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid GGEFREEGEZE
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0x8DED030", Offset = "0x8DEB830", VA = "0x188DED030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid DWVNPOTSCJV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0x8DF43F0", Offset = "0x8DF2BF0", VA = "0x188DF43F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid DJOIDVCFHVD
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1A30", Offset = "0x8DF0230", VA = "0x188DF1A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid IXXQZUSXBHU
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0x8DE80B0", Offset = "0x8DE68B0", VA = "0x188DE80B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid HXWXYIZZLYV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7AB0", Offset = "0x8DE62B0", VA = "0x188DE7AB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid YTBWJLYNWZU
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA430", Offset = "0x8DE8C30", VA = "0x188DEA430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid UTYXMNTTDJP
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0x8DF46F0", Offset = "0x8DF2EF0", VA = "0x188DF46F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid WIBJLUHZWSI
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5D30", Offset = "0x8DE4530", VA = "0x188DE5D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid WCWUHAOMRUZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9F30", Offset = "0x8DE8730", VA = "0x188DE9F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid BIVIMMZIAPT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2670", Offset = "0x8DF0E70", VA = "0x188DF2670")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid YQQNRYNFUIT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0x8DED530", Offset = "0x8DEBD30", VA = "0x188DED530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid DDZZISSKZCT
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF030", Offset = "0x8DED830", VA = "0x188DEF030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid LRDGCHLJWJO
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF8B0", Offset = "0x8DEE0B0", VA = "0x188DEF8B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid YBXKNGUHSUA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0x8DEADB0", Offset = "0x8DE95B0", VA = "0x188DEADB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid WANJUDTOCZL
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5930", Offset = "0x8DE4130", VA = "0x188DE5930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid IGGMQXPIGZV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0x8DED9B0", Offset = "0x8DEC1B0", VA = "0x188DED9B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid KHQGXXHUXEA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0C30", Offset = "0x8DEF430", VA = "0x188DF0C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid MOCESXPPKZD
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0030", Offset = "0x8DEE830", VA = "0x188DF0030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid ZXTHQMLJFGL
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4C70", Offset = "0x8DF3470", VA = "0x188DF4C70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid DVUSTUTNXOV
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0x8DEFCB0", Offset = "0x8DEE4B0", VA = "0x188DEFCB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid YLKUDUJKDDH
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0x8DEBF30", Offset = "0x8DEA730", VA = "0x188DEBF30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid FINOKOMNXLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2BF0", Offset = "0x8DF13F0", VA = "0x188DF2BF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid OFMIZOXCQCL
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0x8DF48F0", Offset = "0x8DF30F0", VA = "0x188DF48F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid SMRFFIUFVSY
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1C30", Offset = "0x8DF0430", VA = "0x188DF1C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid GCUJCEKPUJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB830", Offset = "0x8DEA030", VA = "0x188DEB830")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid MPPTXCLBUTO
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB0B0", Offset = "0x8DE98B0", VA = "0x188DEB0B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid UUWDHPRFKAU
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3770", Offset = "0x8DF1F70", VA = "0x188DF3770")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid FXPGCJEMJWM
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE8B0", Offset = "0x8DED0B0", VA = "0x188DEE8B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid GLOCWRGPCVW
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEEA30", Offset = "0x8DED230", VA = "0x188DEEA30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid NBVUEGGGMIR
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF18B0", Offset = "0x8DF00B0", VA = "0x188DF18B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid WIUWNFMCGIS
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7FB0", Offset = "0x8DE67B0", VA = "0x188DE7FB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid ZJLWLGKBMEN
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF33F0", Offset = "0x8DF1BF0", VA = "0x188DF33F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid KDHYOLRJFFW
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5270", Offset = "0x8DF3A70", VA = "0x188DF5270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid KRXVVGLYZDE
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC5B0", Offset = "0x8DEADB0", VA = "0x188DEC5B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid JGENOGCRFEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1230", Offset = "0x8DEFA30", VA = "0x188DF1230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid ZEQMDJMQRYN
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2FF0", Offset = "0x8DF17F0", VA = "0x188DF2FF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid FEVPFBGTEJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3CF0", Offset = "0x8DF24F0", VA = "0x188DF3CF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid EZWSHLAOCQJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA7B0", Offset = "0x8DE8FB0", VA = "0x188DEA7B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid EENGFMIITNC
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0x8DEE330", Offset = "0x8DECB30", VA = "0x188DEE330")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid ZMEYKOOGNPI
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC130", Offset = "0x8DEA930", VA = "0x188DEC130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid FZEBGEHBCIM
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1530", Offset = "0x8DEFD30", VA = "0x188DF1530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid BVINGZBTWRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2D70", Offset = "0x8DF1570", VA = "0x188DF2D70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid PGIPRLIQXWY
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0x8DF21F0", Offset = "0x8DF09F0", VA = "0x188DF21F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid LAVTBPGKJLD
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA630", Offset = "0x8DE8E30", VA = "0x188DEA630")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid EYJSRQBTWJO
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF1B0", Offset = "0x8DED9B0", VA = "0x188DEF1B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid NVNURXNVRUQ
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0x8DF49F0", Offset = "0x8DF31F0", VA = "0x188DF49F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid XPRKNFGZMCY
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF50F0", Offset = "0x8DF38F0", VA = "0x188DF50F0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid PULNBFECLZG
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0x8DF5E70", Offset = "0x8DF4670", VA = "0x188DF5E70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid ZGQKFPRQJVE
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC030", Offset = "0x8DEA830", VA = "0x188DEC030")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid ZCDSNYXLRWA
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0x8DF2A70", Offset = "0x8DF1270", VA = "0x188DF2A70")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid KBIFJOEARLZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0x8DECA30", Offset = "0x8DEB230", VA = "0x188DECA30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid RYYOQVLZNWY
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0x8DE89B0", Offset = "0x8DE71B0", VA = "0x188DE89B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid WZHQCECKRDT
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0x8DE75B0", Offset = "0x8DE5DB0", VA = "0x188DE75B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid SZSKJWNPGCB
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0x8DEB530", Offset = "0x8DE9D30", VA = "0x188DEB530")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid QJTWRYBBXIQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3DF0", Offset = "0x8DF25F0", VA = "0x188DF3DF0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid GWVTWAPFVTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9230", Offset = "0x8DE7A30", VA = "0x188DE9230")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid PUBJQDPLRLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0x8DF3570", Offset = "0x8DF1D70", VA = "0x188DF3570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid MKPOPCQQXQM
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7130", Offset = "0x8DE5930", VA = "0x188DE7130")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid HCIQBSIKZOA
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8430", Offset = "0x8DE6C30", VA = "0x188DE8430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid URNVSHHUXJZ
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7D30", Offset = "0x8DE6530", VA = "0x188DE7D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid DVGHXYOHAAK
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0x8DEC3B0", Offset = "0x8DEABB0", VA = "0x188DEC3B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid OTZDNSCSZTY
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8A30", Offset = "0x8DE7230", VA = "0x188DE8A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid UNSULHSJWZY
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4570", Offset = "0x8DF2D70", VA = "0x188DF4570")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid WOCEFYLFWQH
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7930", Offset = "0x8DE6130", VA = "0x188DE7930")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid FKDHXLEEPUX
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0x8DE88B0", Offset = "0x8DE70B0", VA = "0x188DE88B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid YTMTZOOBVSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0x8DEF2B0", Offset = "0x8DEDAB0", VA = "0x188DEF2B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid ILZGBFYQFOC
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0x8DEA6B0", Offset = "0x8DE8EB0", VA = "0x188DEA6B0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid CMDCGDIATZV
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0x8DF1D30", Offset = "0x8DF0530", VA = "0x188DF1D30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid CKXDQCUBJTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6BB0", Offset = "0x8DE53B0", VA = "0x188DE6BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid CLCKNJNYTES
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0x8DE6C30", Offset = "0x8DE5430", VA = "0x188DE6C30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid RMQCUWMCAOP
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0x8DE9EB0", Offset = "0x8DE86B0", VA = "0x188DE9EB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid VZUBENBLIHC
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0x8DE8F30", Offset = "0x8DE7730", VA = "0x188DE8F30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid OENCUKFXECW
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0x8DF0430", Offset = "0x8DEEC30", VA = "0x188DF0430")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid LUSNUUYJBUM
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0x8DE7BB0", Offset = "0x8DE63B0", VA = "0x188DE7BB0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid EEPLUVLPIUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0x8DF4270", Offset = "0x8DF2A70", VA = "0x188DF4270")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid TMRFNIXECJM
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0x8DE5A30", Offset = "0x8DE4230", VA = "0x188DE5A30")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid LVBILEFLJHF
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0x8DF40F0", Offset = "0x8DF28F0", VA = "0x188DF40F0")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE070", Offset = "0x8DBC870", VA = "0x188DBE070")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE450", Offset = "0x8DBCC50", VA = "0x188DBE450")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> TWFSSQQPTIF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class OVFCOPRRNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF980", Offset = "0x8DDE180", VA = "0x188DDF980")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class IUWJXSWKCBW
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC860", Offset = "0x8DDB060", VA = "0x188DDC860")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class BWAPAJLJTHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC580", Offset = "0x8DDAD80", VA = "0x188DDC580")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class UTTGXPACGCN
		{
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private static readonly Dictionary<Guid, float> QEDUIVFGUJZ;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private static readonly Dictionary<Guid, float> FJEZCKFRMLI;

			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private static readonly Dictionary<Guid, bool> FYOLXVQKJAV;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8DE25A0", Offset = "0x8DE0DA0", VA = "0x188DE25A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class UTOAAIGEWRE
		{
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private static readonly Dictionary<Guid, float> IIXPJMNUPFC;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private static readonly Dictionary<Guid, float> JAKSOQNYBDF;

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1100", Offset = "0x8DDF900", VA = "0x188DE1100")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class QYNXTKQRPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8DDFD60", Offset = "0x8DDE560", VA = "0x188DDFD60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class NTMPTKFUJGW
		{
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private static readonly Dictionary<Guid, int> YEWBTCLWQEQ;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private static readonly Dictionary<Guid, bool> WMHTDAXSNBM;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private static readonly Dictionary<Guid, bool> RLWGXYHQYCH;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private static readonly Dictionary<Guid, int> MRXYUXHQLGF;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private static readonly Dictionary<Guid, bool> JMTXRUGEBLS;

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCD60", Offset = "0x8DDB560", VA = "0x188DDCD60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class NTCBYWRZQKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCBA0", Offset = "0x8DDB3A0", VA = "0x188DDCBA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<HYKMXKQCBUU, PersistedRoomData, PersistedRoomVersion> DJYDIXUIPID;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Dictionary<Guid, int> YTLCQLJTAUY;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Guid ZPGATERTSMI;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Guid YHJQPBQMOKW;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly float GSPSITKSAQE;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8DD8150", Offset = "0x8DD6950", VA = "0x188DD8150")]
		public static PersistedRoomData ILOQZJKTLJN(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DD8270", Offset = "0x8DD6A70", VA = "0x188DD8270")]
		public static Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DD83A0", Offset = "0x8DD6BA0", VA = "0x188DD83A0")]
		public static Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8DD7D30", Offset = "0x8DD6530", VA = "0x188DD7D30")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(HYKMXKQCBUU a, PersistedRoomData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8DD8070", Offset = "0x8DD6870", VA = "0x188DD8070")]
		public static Guid EYAODCDPKHF(BESXCZTRGHM a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class AWHJDXZQYLZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public interface HYKMXKQCBUU : EODZNSSPBFM<SYNWNGHNLWX, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public sealed class JKCUUNJHGIZ : HYKMXKQCBUU, EODZNSSPBFM<SYNWNGHNLWX, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static JKCUUNJHGIZ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			public PlayerSaveVersion DTWCZEXJDGA()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xB83F00", Offset = "0xB82700", VA = "0x180B83F00", Slot = "5")]
			public PlayerSaveVersion TLYCXURBGLE()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1802BC0", Offset = "0x18013C0", VA = "0x181802BC0", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2C445B0", Offset = "0x2C42DB0", VA = "0x182C445B0", Slot = "7")]
			public bool UPUAHVXNEJP(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCA70", Offset = "0x8DDB270", VA = "0x188DDCA70", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JKCUUNJHGIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private static Versioner<HYKMXKQCBUU, SYNWNGHNLWX, PlayerSaveVersion> DJYDIXUIPID;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC040", Offset = "0x8DDA840", VA = "0x188DDC040")]
		public static SYNWNGHNLWX? RTMZCDWHPAT([Optional] PNBUDRSZEST? a, [Optional] OQXJAHGXWMD? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8DDAFF0", Offset = "0x8DD97F0", VA = "0x188DDAFF0")]
		public static Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, byte[]? bytes)
		{
			return default(Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8DDAB70", Offset = "0x8DD9370", VA = "0x188DDAB70")]
		public static Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA990", Offset = "0x8DD9190", VA = "0x188DDA990")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(HYKMXKQCBUU a, SYNWNGHNLWX b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBD10", Offset = "0x8DDA510", VA = "0x188DDBD10")]
		public static void RAEAXMTWMVY(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBAD0", Offset = "0x8DDA2D0", VA = "0x188DDBAD0")]
		public static void QZYUAFZZDKP(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB630", Offset = "0x8DD9E30", VA = "0x188DDB630")]
		public static void QZTNCZGBTZG(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB500", Offset = "0x8DD9D00", VA = "0x188DDB500")]
		public static void QZOGFSMEKNX(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB490", Offset = "0x8DD9C90", VA = "0x188DDB490")]
		public static void QZIZILSHBCO(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB200", Offset = "0x8DD9A00", VA = "0x188DDB200")]
		private static OQXJAHGXWMD MXMQLSIZJLZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB120", Offset = "0x8DD9920", VA = "0x188DDB120")]
		private static OQXJAHGXWMD MXHJOLPCAAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC010", Offset = "0x8DDA810", VA = "0x188DDC010")]
		[CompilerGenerated]
		internal static bool RSRUKTKEOBG(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA6F0", Offset = "0x8DD8EF0", VA = "0x188DDA6F0")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU AETEPCUARLU(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8DDAB40", Offset = "0x8DD9340", VA = "0x188DDAB40")]
		[CompilerGenerated]
		internal static float JEKQEPBCZRO(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC1C0", Offset = "0x8DDA9C0", VA = "0x188DDC1C0")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU WQCGBNYIRXG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA840", Offset = "0x8DD9040", VA = "0x188DDA840")]
		[CompilerGenerated]
		internal static int AWQUHMKQZDP(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB3B0", Offset = "0x8DD9BB0", VA = "0x188DDB3B0")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU OAXXZZCCBBP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB2E0", Offset = "0x8DD9AE0", VA = "0x188DDB2E0")]
		[CompilerGenerated]
		internal static CircuitsQuat NLXZQINKWWK(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA910", Offset = "0x8DD9110", VA = "0x188DDA910")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU CEPIWAMXIKE(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC130", Offset = "0x8DDA930", VA = "0x188DDC130")]
		[CompilerGenerated]
		internal static string UIYFHUNQUTH(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC150", Offset = "0x8DDA950", VA = "0x188DDC150")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU URONCIJQXRN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA760", Offset = "0x8DD8F60", VA = "0x188DDA760")]
		[CompilerGenerated]
		internal static CircuitsVec3 AUDQWXEIDAV(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDAAC0", Offset = "0x8DD92C0", VA = "0x188DDAAC0")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU GGRKRHKBNFF(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB420", Offset = "0x8DD9C20", VA = "0x188DDB420")]
		[CompilerGenerated]
		internal static int QMJZSSYWSTM(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA870", Offset = "0x8DD9070", VA = "0x188DDA870")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU BCZENQZYLZW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3041F60", Offset = "0x3040760", VA = "0x183041F60")]
		[CompilerGenerated]
		internal static void ZWRMYVNLHXA<a>(RepeatedField<TCKRUMUVKUZ> a, Func<ByteString, a> deserialize, Func<a, RWMGIRAZNGU> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class RVMIIXIDGNX
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF20", Offset = "0x8DDE720", VA = "0x188DDFF20")]
		public static XNILTSLWTZX AGYLCIGGYSZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0390", Offset = "0x8DDEB90", VA = "0x188DE0390")]
		public static Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC> MEFWJVUTFYP(RHKNGDSCLZV.HYKMXKQCBUU a, byte[] b)
		{
			return default(Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0040", Offset = "0x8DDE840", VA = "0x188DE0040")]
		public static Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC> MEFWJVUTFYP(RHKNGDSCLZV.HYKMXKQCBUU a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF70", Offset = "0x8DDE770", VA = "0x188DDFF70")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(RHKNGDSCLZV.HYKMXKQCBUU a, XNILTSLWTZX b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class SCSHGYWHWLC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0F70", Offset = "0x8DDF770", VA = "0x188DE0F70")]
		public static SpawnableTemplateData XMKDXNLHWPO([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0C50", Offset = "0x8DDF450", VA = "0x188DE0C50")]
		public static Result<ParseResult<SpawnableTemplateData>, KZUDSDVUTEC> MEFWJVUTFYP(RHKNGDSCLZV.HYKMXKQCBUU a, WOYSETZYWWN.HYKMXKQCBUU b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0840", Offset = "0x8DDF040", VA = "0x188DE0840")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(RHKNGDSCLZV.HYKMXKQCBUU a, WOYSETZYWWN.HYKMXKQCBUU b, SpawnableTemplateData c)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0480", Offset = "0x8DDEC80", VA = "0x188DE0480")]
		private static Result<None, KZUDSDVUTEC> AOZQXKKQJTO(RHKNGDSCLZV.HYKMXKQCBUU a, SpawnableTemplateData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0AB0", Offset = "0x8DDF2B0", VA = "0x188DE0AB0")]
		private static Result<None, KZUDSDVUTEC> LIGXNQATZDQ(WOYSETZYWWN.HYKMXKQCBUU a, SpawnableTemplateData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class WOYSETZYWWN
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public interface HYKMXKQCBUU : EODZNSSPBFM<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public sealed class JKCUUNJHGIZ : HYKMXKQCBUU, EODZNSSPBFM<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static JKCUUNJHGIZ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			public SuperRoomVersion DTWCZEXJDGA()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB75090", Offset = "0xB73890", VA = "0x180B75090", Slot = "5")]
			public SuperRoomVersion TLYCXURBGLE()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x1802BC0", Offset = "0x18013C0", VA = "0x181802BC0", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x2C445B0", Offset = "0x2C42DB0", VA = "0x182C445B0", Slot = "7")]
			public bool UPUAHVXNEJP(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCA20", Offset = "0x8DDB220", VA = "0x188DDCA20", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JKCUUNJHGIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static Versioner<HYKMXKQCBUU, SuperRoomData, SuperRoomVersion> DJYDIXUIPID;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4490", Offset = "0x8DE2C90", VA = "0x188DE4490")]
		public static SuperRoomData ACAWTAGOZAR([Optional] VGWHPUEYAGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4EB0", Offset = "0x8DE36B0", VA = "0x188DE4EB0")]
		public static Result<ParseResult<SuperRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4BE0", Offset = "0x8DE33E0", VA = "0x188DE4BE0")]
		public static Result<ParseResult<SuperRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8DE47A0", Offset = "0x8DE2FA0", VA = "0x188DE47A0")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(HYKMXKQCBUU a, SuperRoomData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8DE51F0", Offset = "0x8DE39F0", VA = "0x188DE51F0")]
		private static void RAEAXMTWMVY(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8DE50F0", Offset = "0x8DE38F0", VA = "0x188DE50F0")]
		private static void QZYUAFZZDKP(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5060", Offset = "0x8DE3860", VA = "0x188DE5060")]
		private static void QZTNCZGBTZG(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4FE0", Offset = "0x8DE37E0", VA = "0x188DE4FE0")]
		private static void QZOGFSMEKNX(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE48D0", Offset = "0x8DE30D0", VA = "0x188DE48D0")]
		public static DataTableData LNJHEIHKZQM(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4590", Offset = "0x8DE2D90", VA = "0x188DE4590")]
		public static ProgressionManagerData EEBTEQONZKD(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE53B0", Offset = "0x8DE3BB0", VA = "0x188DE53B0")]
		[CompilerGenerated]
		internal static void XRENXTCQOJD(RepeatedField<LSFXPWSEAFF> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class SEUFFLADPDZ : HXSMSVOZQLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0FF0", Offset = "0x8DDF7F0", VA = "0x188DE0FF0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28E4640", Offset = "0x28E2E40", VA = "0x1828E4640")]
		public SEUFFLADPDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface EODZNSSPBFM<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b DTWCZEXJDGA();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b TLYCXURBGLE();

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UPUAHVXNEJP(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class ZZRZDOPGDSP : HXSMSVOZQLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private string IWTVHEQQRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private string WKBDELIDHEW;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC810", Offset = "0x8DDB010", VA = "0x188DDC810")]
		public ZZRZDOPGDSP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5EF0", Offset = "0x8DF46F0", VA = "0x188DF5EF0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ABC860", Offset = "0x5ABB060", VA = "0x185ABC860")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class VODSXLVVNDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3BAEA40", Offset = "0x3BAD240", VA = "0x183BAEA40")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class CLBYMVSLCGS : HXSMSVOZQLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string IWTVHEQQRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private string WKBDELIDHEW;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC810", Offset = "0x8DDB010", VA = "0x188DDC810")]
		public CLBYMVSLCGS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC7B0", Offset = "0x8DDAFB0", VA = "0x188DDC7B0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8DE43E0", Offset = "0x8DE2BE0", VA = "0x188DE43E0")]
		public static Guid? DJFHYGNOBAK(WSAKIWWEIUX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : EODZNSSPBFM<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x65F5400", Offset = "0x65F3C00", VA = "0x1865F5400")]
		public Result<TVersion, KZUDSDVUTEC> EOTEJAWPWJM(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x65F5BF0", Offset = "0x65F43F0", VA = "0x1865F5BF0")]
		public static VersionerFactory<TDeps, TData, TVersion> PBVLPMCLPSM()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class KITBCUMOFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public VersioningPhaseVoidDelegate<TData> CUSSHQGLCIO;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KITBCUMOFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x52058E0", Offset = "0x52040E0", VA = "0x1852058E0")]
			internal Result<None, KZUDSDVUTEC> FCXOXOQGSTQ(TDeps a, TData b)
			{
				return default(Result<None, KZUDSDVUTEC>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x65F35F0", Offset = "0x65F1DF0", VA = "0x1865F35F0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x65F3720", Offset = "0x65F1F20", VA = "0x1865F3720")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class IUUCWKWYKKU
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3002D70", Offset = "0x3001570", VA = "0x183002D70")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : EODZNSSPBFM<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class BCUFVWJLJCR : HXSMSVOZQLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public readonly Exception DAMWIGCCLGW;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x18E8EA0", Offset = "0x18E76A0", VA = "0x1818E8EA0")]
		public BCUFVWJLJCR(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC550", Offset = "0x8DDAD50", VA = "0x188DDC550", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC450", Offset = "0x8DDAC50", VA = "0x188DDC450", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class HXSMSVOZQLA : KZUDSDVUTEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x28E4640", Offset = "0x28E2E40", VA = "0x1828E4640")]
		protected HXSMSVOZQLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate Result<None, KZUDSDVUTEC> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
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
