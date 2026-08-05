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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EC0360", Offset = "0x8EBED60", VA = "0x188EC0360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
			public PersistedRoomVersion DTWCZEXJDGA()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8EBD8B0", Offset = "0x8EBC2B0", VA = "0x188EBD8B0", Slot = "5")]
			public PersistedRoomVersion TLYCXURBGLE()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x181A770", Offset = "0x1819170", VA = "0x18181A770", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2C57190", Offset = "0x2C55B90", VA = "0x182C57190", Slot = "7")]
			public bool UPUAHVXNEJP(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8EBD8C0", Offset = "0x8EBC2C0", VA = "0x188EBD8C0", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EC75B0", Offset = "0x8EC5FB0", VA = "0x188EC75B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class FXGOUPCFRCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8EBD5F0", Offset = "0x8EBBFF0", VA = "0x188EBD5F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class FWLNFOAQFIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8EBD420", Offset = "0x8EBBE20", VA = "0x188EBD420")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class MSWDJUGWEWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8EC01A0", Offset = "0x8EBEBA0", VA = "0x188EC01A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class MSQWMNMYVLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8EBFF70", Offset = "0x8EBE970", VA = "0x188EBFF70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class RWISRRZVEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB610", Offset = "0x8EDA010", VA = "0x188EDB610")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class YWKCYQAFRYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8EDC730", Offset = "0x8EDB130", VA = "0x188EDC730")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class QTETULIKOVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8EC6F10", Offset = "0x8EC5910", VA = "0x188EC6F10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class QSZMXEONFKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8EC6D40", Offset = "0x8EC5740", VA = "0x188EC6D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EBDC60", Offset = "0x8EBC660", VA = "0x188EBDC60")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8EBD980", Offset = "0x8EBC380", VA = "0x188EBD980")]
			private static Dictionary<Guid, BESXCZTRGHM> AEBDRBRXIZG(BESXCZTRGHM a, Dictionary<Guid, BESXCZTRGHM> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class JTDJNNIABLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8EBFB90", Offset = "0x8EBE590", VA = "0x188EBFB90")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class QZTNCZGBTZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8EC73F0", Offset = "0x8EC5DF0", VA = "0x188EC73F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class VQKDJHINHZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB7E0", Offset = "0x8EDA1E0", VA = "0x188EDB7E0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB7D0", Offset = "0x8EDA1D0", VA = "0x188EDB7D0")]
			private static void ITNRXSITTYE(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class VQURDUWIAVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8EDBAC0", Offset = "0x8EDA4C0", VA = "0x188EDBAC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class VRPSSVXXMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8EDBCD0", Offset = "0x8EDA6D0", VA = "0x188EDBCD0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class VSAGNJLSFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8EDC3D0", Offset = "0x8EDADD0", VA = "0x188EDC3D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class VRUZQCRUWAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8EDC0B0", Offset = "0x8EDAAB0", VA = "0x188EDC0B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class QZIZILSHBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8EC7230", Offset = "0x8EC5C30", VA = "0x188EC7230")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class OVUXGJZJPJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8EC6B70", Offset = "0x8EC5570", VA = "0x188EC6B70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class OVKJLWLOWMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8EC6920", Offset = "0x8EC5320", VA = "0x188EC6920")]
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
					[Cpp2IlInjected.Address(RVA = "0x8EF43C0", Offset = "0x8EF2DC0", VA = "0x188EF43C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid HLXXLSQBNRQ
				{
					[Cpp2IlInjected.Token(Token = "0x600002D")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAB40", Offset = "0x8EE9540", VA = "0x188EEAB40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid KFDEQJTWNFP
				{
					[Cpp2IlInjected.Token(Token = "0x600002E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF9C0", Offset = "0x8EEE3C0", VA = "0x188EEF9C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid NNYKAPMXYJR
				{
					[Cpp2IlInjected.Token(Token = "0x600002F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5980", Offset = "0x8EF4380", VA = "0x188EF5980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid WYPUTTLBELP
				{
					[Cpp2IlInjected.Token(Token = "0x6000030")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0540", Offset = "0x8EEEF40", VA = "0x188EF0540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid HIHUKMAFNUJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x8EF8080", Offset = "0x8EF6A80", VA = "0x188EF8080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid SLGDPYSWECM
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2540", Offset = "0x8EF0F40", VA = "0x188EF2540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid UFFYLFYFTXR
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBD40", Offset = "0x8EEA740", VA = "0x188EEBD40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid VXPRDGEEIHE
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF7C0", Offset = "0x8EEE1C0", VA = "0x188EEF7C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid PQFMXXSMMOT
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA2C0", Offset = "0x8EE8CC0", VA = "0x188EEA2C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid XHNRCMQNLIM
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9740", Offset = "0x8EE8140", VA = "0x188EE9740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid GMKUSAJWVSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x8EED5C0", Offset = "0x8EEBFC0", VA = "0x188EED5C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid KZHFLHREVZR
				{
					[Cpp2IlInjected.Token(Token = "0x6000038")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEFC0", Offset = "0x8EED9C0", VA = "0x188EEEFC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid MCQNBHFFCPZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0x8EF8180", Offset = "0x8EF6B80", VA = "0x188EF8180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid AAQDGCYABXJ
				{
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1D40", Offset = "0x8EF0740", VA = "0x188EF1D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid PBGOQGGNCNO
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0E40", Offset = "0x8EEF840", VA = "0x188EF0E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid LELEKOGXRJL
				{
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3AC0", Offset = "0x8EF24C0", VA = "0x188EF3AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid BXKWMCVVGNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600003D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1AC0", Offset = "0x8EF04C0", VA = "0x188EF1AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid YSBISABOXZQ
				{
					[Cpp2IlInjected.Token(Token = "0x600003E")]
					[Cpp2IlInjected.Address(RVA = "0x8EED240", Offset = "0x8EEBC40", VA = "0x188EED240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid TMPUBMALIHA
				{
					[Cpp2IlInjected.Token(Token = "0x600003F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF040", Offset = "0x8EEDA40", VA = "0x188EEF040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid DVZUBRXTBNE
				{
					[Cpp2IlInjected.Token(Token = "0x6000040")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB4C0", Offset = "0x8EE9EC0", VA = "0x188EEB4C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid SYHZCXGGQGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9140", Offset = "0x8EE7B40", VA = "0x188EE9140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid CXLTWFTKGFW
				{
					[Cpp2IlInjected.Token(Token = "0x6000042")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE7C0", Offset = "0x8EED1C0", VA = "0x188EEE7C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid GLOIUIIGHMI
				{
					[Cpp2IlInjected.Token(Token = "0x6000043")]
					[Cpp2IlInjected.Address(RVA = "0x8EED4C0", Offset = "0x8EEBEC0", VA = "0x188EED4C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid TAPOIXVDXPB
				{
					[Cpp2IlInjected.Token(Token = "0x6000044")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC0C0", Offset = "0x8EEAAC0", VA = "0x188EEC0C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid RQXVPZJEEQK
				{
					[Cpp2IlInjected.Token(Token = "0x6000045")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0CC0", Offset = "0x8EEF6C0", VA = "0x188EF0CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid CVXAZXGJNDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000046")]
					[Cpp2IlInjected.Address(RVA = "0x8EF19C0", Offset = "0x8EF03C0", VA = "0x188EF19C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid XZYVTLTGHLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000047")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2940", Offset = "0x8EF1340", VA = "0x188EF2940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid NDFVMTIPTLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC4C0", Offset = "0x8EEAEC0", VA = "0x188EEC4C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid RVVSTBWXFFV
				{
					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6300", Offset = "0x8EF4D00", VA = "0x188EF6300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid OPEPSVMBQJH
				{
					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9AC0", Offset = "0x8EE84C0", VA = "0x188EE9AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid BVTDCTQLMGW
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x8EE83C0", Offset = "0x8EE6DC0", VA = "0x188EE83C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid XIYEAVXIWRI
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8EED1C0", Offset = "0x8EEBBC0", VA = "0x188EED1C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid UNEYYLPQRCV
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2CC0", Offset = "0x8EF16C0", VA = "0x188EF2CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid SVOIVFIYROR
				{
					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE9C0", Offset = "0x8EED3C0", VA = "0x188EEE9C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid PIZFVVKZSOM
				{
					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6800", Offset = "0x8EF5200", VA = "0x188EF6800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid NHQYPBUIGRC
				{
					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAE40", Offset = "0x8EE9840", VA = "0x188EEAE40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid ERXTTSKJUGR
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8EED740", Offset = "0x8EEC140", VA = "0x188EED740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid TKEXWYPWCNP
				{
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFEC0", Offset = "0x8EEE8C0", VA = "0x188EEFEC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid FVUQKVKRZMG
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3440", Offset = "0x8EF1E40", VA = "0x188EF3440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid BDFBLKZEFSV
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA540", Offset = "0x8EE8F40", VA = "0x188EEA540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid GNNTUHXCANI
				{
					[Cpp2IlInjected.Token(Token = "0x6000055")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBF40", Offset = "0x8EEA940", VA = "0x188EEBF40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid HGGCSJKPTLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000056")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE240", Offset = "0x8EECC40", VA = "0x188EEE240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid UVTSJWNOGCC
				{
					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFDC0", Offset = "0x8EEE7C0", VA = "0x188EEFDC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid ITDPQWXACSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x8EECC40", Offset = "0x8EEB640", VA = "0x188EECC40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid UKSGBTFGOSD
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5300", Offset = "0x8EF3D00", VA = "0x188EF5300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid MCOSVMVAXSW
				{
					[Cpp2IlInjected.Token(Token = "0x600005A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7AC0", Offset = "0x8EE64C0", VA = "0x188EE7AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid FIBGFQSXMEX
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF32C0", Offset = "0x8EF1CC0", VA = "0x188EF32C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid LUCKUTLBUGS
				{
					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAAC0", Offset = "0x8EE94C0", VA = "0x188EEAAC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid OJONBUHZRAA
				{
					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7B80", Offset = "0x8EF6580", VA = "0x188EF7B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid WIDQBNJTZXJ
				{
					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3540", Offset = "0x8EF1F40", VA = "0x188EF3540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid VDZWTMFCKOV
				{
					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA240", Offset = "0x8EE8C40", VA = "0x188EEA240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid AIXBCQNRZBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0D40", Offset = "0x8EEF740", VA = "0x188EF0D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid AYUBQHFUSLP
				{
					[Cpp2IlInjected.Token(Token = "0x6000061")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6E80", Offset = "0x8EF5880", VA = "0x188EF6E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid KRQKYZKLGTC
				{
					[Cpp2IlInjected.Token(Token = "0x6000062")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8A40", Offset = "0x8EE7440", VA = "0x188EE8A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid TQQHRRWVIBE
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4240", Offset = "0x8EF2C40", VA = "0x188EF4240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid QLCJLZZOPLN
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB9C0", Offset = "0x8EEA3C0", VA = "0x188EEB9C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid OTCWFSXWUIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1140", Offset = "0x8EEFB40", VA = "0x188EF1140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid QMCSZCWKGGU
				{
					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA840", Offset = "0x8EE9240", VA = "0x188EEA840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid CZKCPUNEFLP
				{
					[Cpp2IlInjected.Token(Token = "0x6000067")]
					[Cpp2IlInjected.Address(RVA = "0x8EEABC0", Offset = "0x8EE95C0", VA = "0x188EEABC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid PVEPSQQAGMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000068")]
					[Cpp2IlInjected.Address(RVA = "0x8EF26C0", Offset = "0x8EF10C0", VA = "0x188EF26C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid ZTFNQVWBOPT
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5E80", Offset = "0x8EF4880", VA = "0x188EF5E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid RPUTBGKFERZ
				{
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5F80", Offset = "0x8EF4980", VA = "0x188EF5F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid QCBBPRDZGNJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0840", Offset = "0x8EEF240", VA = "0x188EF0840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid ZIQHGVOISUJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4C80", Offset = "0x8EF3680", VA = "0x188EF4C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid GKSJJZWBVKL
				{
					[Cpp2IlInjected.Token(Token = "0x600006D")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8940", Offset = "0x8EE7340", VA = "0x188EE8940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid HFXTVCPWFDJ
				{
					[Cpp2IlInjected.Token(Token = "0x600006E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7080", Offset = "0x8EF5A80", VA = "0x188EF7080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid HZBMVQUMLRN
				{
					[Cpp2IlInjected.Token(Token = "0x600006F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6A00", Offset = "0x8EF5400", VA = "0x188EF6A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid BJQKXNIIEGW
				{
					[Cpp2IlInjected.Token(Token = "0x6000070")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA6C0", Offset = "0x8EE90C0", VA = "0x188EEA6C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid EPRVRXATJZZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000071")]
					[Cpp2IlInjected.Address(RVA = "0x8EE87C0", Offset = "0x8EE71C0", VA = "0x188EE87C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid EGQJGEACQQV
				{
					[Cpp2IlInjected.Token(Token = "0x6000072")]
					[Cpp2IlInjected.Address(RVA = "0x8EEECC0", Offset = "0x8EED6C0", VA = "0x188EEECC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid UWSYGUPJVOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000073")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7780", Offset = "0x8EF6180", VA = "0x188EF7780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid EVLZCNCLBNM
				{
					[Cpp2IlInjected.Token(Token = "0x6000074")]
					[Cpp2IlInjected.Address(RVA = "0x8EECAC0", Offset = "0x8EEB4C0", VA = "0x188EECAC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid XBCJQHFODPP
				{
					[Cpp2IlInjected.Token(Token = "0x6000075")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF840", Offset = "0x8EEE240", VA = "0x188EEF840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid LUFPKJETKUM
				{
					[Cpp2IlInjected.Token(Token = "0x6000076")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0FC0", Offset = "0x8EEF9C0", VA = "0x188EF0FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid WYAHVUMGCXZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000077")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5500", Offset = "0x8EF3F00", VA = "0x188EF5500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid ZSVURZZHYKN
				{
					[Cpp2IlInjected.Token(Token = "0x6000078")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDE40", Offset = "0x8EEC840", VA = "0x188EEDE40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid XVMQGXRXHAQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000079")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDFC0", Offset = "0x8EEC9C0", VA = "0x188EEDFC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid GSHBIYUWFJE
				{
					[Cpp2IlInjected.Token(Token = "0x600007A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE97C0", Offset = "0x8EE81C0", VA = "0x188EE97C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid ETJZPZUAPRE
				{
					[Cpp2IlInjected.Token(Token = "0x600007B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7580", Offset = "0x8EF5F80", VA = "0x188EF7580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid OGESOJIXVJZ
				{
					[Cpp2IlInjected.Token(Token = "0x600007C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2F40", Offset = "0x8EF1940", VA = "0x188EF2F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid PGDGYNGFKZA
				{
					[Cpp2IlInjected.Token(Token = "0x600007D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF29C0", Offset = "0x8EF13C0", VA = "0x188EF29C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid RVKPACNVEBX
				{
					[Cpp2IlInjected.Token(Token = "0x600007E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA640", Offset = "0x8EE9040", VA = "0x188EEA640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid NVZEHLXYJKZ
				{
					[Cpp2IlInjected.Token(Token = "0x600007F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDB40", Offset = "0x8EEC540", VA = "0x188EEDB40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid LRTPEUTLKKH
				{
					[Cpp2IlInjected.Token(Token = "0x6000080")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFC40", Offset = "0x8EEE640", VA = "0x188EEFC40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid KCUQXKZJJPS
				{
					[Cpp2IlInjected.Token(Token = "0x6000081")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEE40", Offset = "0x8EED840", VA = "0x188EEEE40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid BRSWJJRFACU
				{
					[Cpp2IlInjected.Token(Token = "0x6000082")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5A80", Offset = "0x8EF4480", VA = "0x188EF5A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid ZQXODKIOWZN
				{
					[Cpp2IlInjected.Token(Token = "0x6000083")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF540", Offset = "0x8EEDF40", VA = "0x188EEF540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid SHZWTRFAFEY
				{
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7900", Offset = "0x8EF6300", VA = "0x188EF7900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid ILMMCGAETNN
				{
					[Cpp2IlInjected.Token(Token = "0x6000085")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC3C0", Offset = "0x8EEADC0", VA = "0x188EEC3C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid CBFPKOBDDCL
				{
					[Cpp2IlInjected.Token(Token = "0x6000086")]
					[Cpp2IlInjected.Address(RVA = "0x8EED940", Offset = "0x8EEC340", VA = "0x188EED940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid GOZKBAPKIEI
				{
					[Cpp2IlInjected.Token(Token = "0x6000087")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7800", Offset = "0x8EF6200", VA = "0x188EF7800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid NLWAUEKQFGC
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1CC0", Offset = "0x8EF06C0", VA = "0x188EF1CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid MJIEGFEZNHX
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1BC0", Offset = "0x8EF05C0", VA = "0x188EF1BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid UXJYYYHSZMF
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9FC0", Offset = "0x8EE89C0", VA = "0x188EE9FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid CZNMNXVLKSP
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA040", Offset = "0x8EE8A40", VA = "0x188EEA040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid FQMWJEOQXQY
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4680", Offset = "0x8EF3080", VA = "0x188EF4680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid FYUDHANDTDN
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5700", Offset = "0x8EF4100", VA = "0x188EF5700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid LDROVTPKGWG
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF15C0", Offset = "0x8EEFFC0", VA = "0x188EF15C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid LDHBBGBPNZO
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1440", Offset = "0x8EEFE40", VA = "0x188EF1440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid JOFCAHKRVBB
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF440", Offset = "0x8EEDE40", VA = "0x188EEF440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid JMELBRTSERP
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF240", Offset = "0x8EEDC40", VA = "0x188EEF240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid JLTXHEFXLUX
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF2C0", Offset = "0x8EEDCC0", VA = "0x188EEF2C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid HHIPFTTAUWP
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7400", Offset = "0x8EF5E00", VA = "0x188EF7400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid FOMTJCZSRTD
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7BC0", Offset = "0x8EE65C0", VA = "0x188EE7BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid PNGUOFEEISR
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEBC0", Offset = "0x8EED5C0", VA = "0x188EEEBC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid JCLAEFDXATS
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAF40", Offset = "0x8EE9940", VA = "0x188EEAF40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid XSSVTJPESLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0x8EECD40", Offset = "0x8EEB740", VA = "0x188EECD40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid LCSPFYEGZRN
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2340", Offset = "0x8EF0D40", VA = "0x188EF2340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid QBOJRQAMMGG
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA3C0", Offset = "0x8EE8DC0", VA = "0x188EEA3C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid EZBURXOZIGT
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB340", Offset = "0x8EE9D40", VA = "0x188EEB340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid GRPJQIRCKSI
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4980", Offset = "0x8EF3380", VA = "0x188EF4980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid YPBUVXJNXTO
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2D40", Offset = "0x8EF1740", VA = "0x188EF2D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid HBMYEQHGIRC
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDCC0", Offset = "0x8EEC6C0", VA = "0x188EEDCC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid GGOHFIRPKSJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC940", Offset = "0x8EEB340", VA = "0x188EEC940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid JWJRLUYRQJG
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE040", Offset = "0x8EECA40", VA = "0x188EEE040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid YMVDLIAQFEH
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1040", Offset = "0x8EEFA40", VA = "0x188EF1040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid LTPQXKSRVIY
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3740", Offset = "0x8EF2140", VA = "0x188EF3740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid QKHVYPDQCAQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0x8EF8100", Offset = "0x8EF6B00", VA = "0x188EF8100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid OYBJZNLGPKX
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB8C0", Offset = "0x8EEA2C0", VA = "0x188EEB8C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid LAJJNCIJCDE
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9540", Offset = "0x8EE7F40", VA = "0x188EE9540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid CDVIKKHWZRC
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4F00", Offset = "0x8EF3900", VA = "0x188EF4F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid NUVRXHTMXME
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE640", Offset = "0x8EED040", VA = "0x188EEE640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid DDJSUMHDVEG
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8AC0", Offset = "0x8EE74C0", VA = "0x188EE8AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid QQRFXYWMAML
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4D80", Offset = "0x8EF3780", VA = "0x188EF4D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid EQEAOJBFJGV
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2440", Offset = "0x8EF0E40", VA = "0x188EF2440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid TZYNUONXKFM
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8BC0", Offset = "0x8EE75C0", VA = "0x188EE8BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid SXSACBOCDXZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF12C0", Offset = "0x8EEFCC0", VA = "0x188EF12C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid OETJSLSZBSF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7D00", Offset = "0x8EF6700", VA = "0x188EF7D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid LVUENVALREF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3340", Offset = "0x8EF1D40", VA = "0x188EF3340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid EHXCINNOFSV
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF39C0", Offset = "0x8EF23C0", VA = "0x188EF39C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid GFLYLRCNICK
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5D00", Offset = "0x8EF4700", VA = "0x188EF5D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid KASYZPLCOFV
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF0C0", Offset = "0x8EEDAC0", VA = "0x188EEF0C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid ZSRADFHQHHC
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0A40", Offset = "0x8EEF440", VA = "0x188EF0A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid TWTTRXCECHS
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE8C0", Offset = "0x8EED2C0", VA = "0x188EEE8C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid AOIEOJGURPY
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0440", Offset = "0x8EEEE40", VA = "0x188EF0440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid YORXNYXYSXF
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8640", Offset = "0x8EE7040", VA = "0x188EE8640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid MYXUIXBBLSW
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0140", Offset = "0x8EEEB40", VA = "0x188EF0140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid KXEZHGOCZAB
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0x8EF18C0", Offset = "0x8EF02C0", VA = "0x188EF18C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid EYAEPJSQWAU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0x8EF03C0", Offset = "0x8EEEDC0", VA = "0x188EF03C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid WBMWPHAQCEN
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7A80", Offset = "0x8EF6480", VA = "0x188EF7A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid WXLPHNOQJNR
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE5C0", Offset = "0x8EECFC0", VA = "0x188EEE5C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid CZSXKZWUGGL
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB440", Offset = "0x8EE9E40", VA = "0x188EEB440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid IWJCWANZXQS
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBFC0", Offset = "0x8EEA9C0", VA = "0x188EEBFC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid IRPKRJPQORF
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8840", Offset = "0x8EE7240", VA = "0x188EE8840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid PETVBBVTYHG
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7B40", Offset = "0x8EE6540", VA = "0x188EE7B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid NWQIWCEMXZR
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4B80", Offset = "0x8EF3580", VA = "0x188EF4B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid KRWDOKGPHCK
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5C00", Offset = "0x8EF4600", VA = "0x188EF5C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid XLJOAGGHPFD
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1240", Offset = "0x8EEFC40", VA = "0x188EF1240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid ZMJSEWEOTIN
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1A40", Offset = "0x8EF0440", VA = "0x188EF1A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid VTRETJDGHSB
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF740", Offset = "0x8EEE140", VA = "0x188EEF740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid WLYZRXGKSVX
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF09C0", Offset = "0x8EEF3C0", VA = "0x188EF09C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid EPSFWPDGJXJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFFC0", Offset = "0x8EEE9C0", VA = "0x188EEFFC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid NNCXRVDOTSE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0x8EF28C0", Offset = "0x8EF12C0", VA = "0x188EF28C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid DFHGJMQYXCJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6000", Offset = "0x8EF4A00", VA = "0x188EF6000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid IUGDCHVDRWF
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4340", Offset = "0x8EF2D40", VA = "0x188EF4340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid QERUZHDBFLE
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8040", Offset = "0x8EE6A40", VA = "0x188EE8040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid WFZFYQLFHAP
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0x8EE95C0", Offset = "0x8EE7FC0", VA = "0x188EE95C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid XFDGBPWMIBP
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8EC0", Offset = "0x8EE78C0", VA = "0x188EE8EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid BXCGUDWXNAF
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2140", Offset = "0x8EF0B40", VA = "0x188EF2140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid HXAWYRMCBXS
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBB40", Offset = "0x8EEA540", VA = "0x188EEBB40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid TMWNNLXUGKI
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6580", Offset = "0x8EF4F80", VA = "0x188EF6580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid WPGUXGHVGWK
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7E80", Offset = "0x8EF6880", VA = "0x188EF7E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid IKEBPRCLAQD
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5000", Offset = "0x8EF3A00", VA = "0x188EF5000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid CLKXHMZEIWV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7F40", Offset = "0x8EE6940", VA = "0x188EE7F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid POOSKVMPWAC
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1740", Offset = "0x8EF0140", VA = "0x188EF1740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid RVHGZDCCKCE
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0x8EECFC0", Offset = "0x8EEB9C0", VA = "0x188EECFC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid ECIIFRERZOY
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB6C0", Offset = "0x8EEA0C0", VA = "0x188EEB6C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid HWZLJKNTLKQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC340", Offset = "0x8EEAD40", VA = "0x188EEC340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid QXUQOMWINJU
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1340", Offset = "0x8EEFD40", VA = "0x188EF1340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid HDQXLDNWBWX
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA940", Offset = "0x8EE9340", VA = "0x188EEA940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid FOVPLWXHSHJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0x8EF31C0", Offset = "0x8EF1BC0", VA = "0x188EF31C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid DIVKLCEGLDO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF34C0", Offset = "0x8EF1EC0", VA = "0x188EF34C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid TGKAANXQWGK
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4400", Offset = "0x8EF2E00", VA = "0x188EF4400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid SGBAJIGDCLO
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA1C0", Offset = "0x8EE8BC0", VA = "0x188EEA1C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid UQFRQORCMML
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1DC0", Offset = "0x8EF07C0", VA = "0x188EF1DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid KODLDAIFRQT
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9A40", Offset = "0x8EE8440", VA = "0x188EE9A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid OYJKERQRKPS
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0x8EF01C0", Offset = "0x8EEEBC0", VA = "0x188EF01C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid RMZIVECKGJV
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4040", Offset = "0x8EF2A40", VA = "0x188EF4040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid JROWVSQZJOP
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8240", Offset = "0x8EE6C40", VA = "0x188EE8240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid YNUGQFQCQYR
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0740", Offset = "0x8EEF140", VA = "0x188EF0740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid GGYVPIZEHUE
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0x8EED340", Offset = "0x8EEBD40", VA = "0x188EED340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid HJPGWOZCQSW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8340", Offset = "0x8EE6D40", VA = "0x188EE8340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid UQZQRYMZZXS
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7500", Offset = "0x8EF5F00", VA = "0x188EF7500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid MEOUZALINBC
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBEC0", Offset = "0x8EEA8C0", VA = "0x188EEBEC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid GTQAISQGDNZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0x8EE86C0", Offset = "0x8EE70C0", VA = "0x188EE86C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid IUIVBIYWSZZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0x8EECF40", Offset = "0x8EEB940", VA = "0x188EECF40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid DBLWMQTZEZK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF940", Offset = "0x8EEE340", VA = "0x188EEF940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid VXLVMJEWLEW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB3C0", Offset = "0x8EE9DC0", VA = "0x188EEB3C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid IXUMYFOMQBL
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2BC0", Offset = "0x8EF15C0", VA = "0x188EF2BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid JCSHBYBDTUK
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDA40", Offset = "0x8EEC440", VA = "0x188EEDA40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid AHLTGYRKDXZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF36C0", Offset = "0x8EF20C0", VA = "0x188EF36C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid WTHSDWBVUGY
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1940", Offset = "0x8EF0340", VA = "0x188EF1940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid DCCQLKUTNCQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0F40", Offset = "0x8EEF940", VA = "0x188EF0F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid FKLDJMDMCVD
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1F40", Offset = "0x8EF0940", VA = "0x188EF1F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid FRHVGZGPTEF
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4E80", Offset = "0x8EF3880", VA = "0x188EF4E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid NZWCITCXSNW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF08C0", Offset = "0x8EEF2C0", VA = "0x188EF08C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid UIGMJHMUETG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2AC0", Offset = "0x8EF14C0", VA = "0x188EF2AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid BLJEMTFDHAJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5A00", Offset = "0x8EF4400", VA = "0x188EF5A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid QDXREIAASLR
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF00C0", Offset = "0x8EEEAC0", VA = "0x188EF00C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid DKHEPOLSZLN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7980", Offset = "0x8EF6380", VA = "0x188EF7980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid RYVMFGCRUZA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7C40", Offset = "0x8EE6640", VA = "0x188EE7C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid THTQYSZHTBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9C40", Offset = "0x8EE8640", VA = "0x188EE9C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid TMOYLIISMHZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0x8EF24C0", Offset = "0x8EF0EC0", VA = "0x188EF24C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid GRHGXEARVWH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8EED0C0", Offset = "0x8EEBAC0", VA = "0x188EED0C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid EMFMQFZZUNK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDD40", Offset = "0x8EEC740", VA = "0x188EEDD40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid DICDXPXCZIK
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4140", Offset = "0x8EF2B40", VA = "0x188EF4140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid DUCKZKPLUCZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3CC0", Offset = "0x8EF26C0", VA = "0x188EF3CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid NLAJIGNLDOL
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA5C0", Offset = "0x8EE8FC0", VA = "0x188EEA5C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid PDNXWACNTZF
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8B40", Offset = "0x8EE7540", VA = "0x188EE8B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid QSPCOJJZFRX
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7680", Offset = "0x8EF6080", VA = "0x188EF7680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid XYPDFLNRFZR
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5D80", Offset = "0x8EF4780", VA = "0x188EF5D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid MYPESCOKZXN
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB140", Offset = "0x8EE9B40", VA = "0x188EEB140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid LJHWPAQZRMB
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2840", Offset = "0x8EF1240", VA = "0x188EF2840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid VYUWXEVADMO
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF140", Offset = "0x8EEDB40", VA = "0x188EEF140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid OVLWGDKOOPD
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7E00", Offset = "0x8EF6800", VA = "0x188EF7E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid JUJZSYCMCMT
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5480", Offset = "0x8EF3E80", VA = "0x188EF5480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid EBSRQIRCKGD
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0x8EF05C0", Offset = "0x8EEEFC0", VA = "0x188EF05C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid YBGGIGZYWLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9240", Offset = "0x8EE7C40", VA = "0x188EE9240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid WXGJLWASQIE
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8DC0", Offset = "0x8EE77C0", VA = "0x188EE8DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid ZFIUBOEHJIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6F80", Offset = "0x8EF5980", VA = "0x188EF6F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid BJCYKRVPGVS
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7FC0", Offset = "0x8EE69C0", VA = "0x188EE7FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid ERIQQYIKOFC
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF22C0", Offset = "0x8EF0CC0", VA = "0x188EF22C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid JJJKJMLEHOP
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA4C0", Offset = "0x8EE8EC0", VA = "0x188EEA4C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid JXIVEDAKPMN
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7D40", Offset = "0x8EE6740", VA = "0x188EE7D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid DMYAOOXPWQH
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9BC0", Offset = "0x8EE85C0", VA = "0x188EE9BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid SJMVWQTAYRA
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6700", Offset = "0x8EF5100", VA = "0x188EF6700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid YUZQKHOQPRP
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF42C0", Offset = "0x8EF2CC0", VA = "0x188EF42C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid DEUIFUSXDJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4700", Offset = "0x8EF3100", VA = "0x188EF4700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid FYXXATAWHCV
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC8C0", Offset = "0x8EEB2C0", VA = "0x188EEC8C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid DZGEONDNTGJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6680", Offset = "0x8EF5080", VA = "0x188EF6680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid PHKEGDRHXVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6100", Offset = "0x8EF4B00", VA = "0x188EF6100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid VDGPURFWUGA
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7F00", Offset = "0x8EF6900", VA = "0x188EF7F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid YBRVWUNVTON
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0x8EE96C0", Offset = "0x8EE80C0", VA = "0x188EE96C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid XJQJLNFVWSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8CC0", Offset = "0x8EE76C0", VA = "0x188EE8CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid PUXTIBPGLSZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB0C0", Offset = "0x8EE9AC0", VA = "0x188EEB0C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid JHAMFHFIOYM
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAFC0", Offset = "0x8EE99C0", VA = "0x188EEAFC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid FCVSGHGWETZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC640", Offset = "0x8EEB040", VA = "0x188EEC640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid JSASRBGRFWE
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3F40", Offset = "0x8EF2940", VA = "0x188EF3F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid YVMYUFTPAFU
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3D40", Offset = "0x8EF2740", VA = "0x188EF3D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid HCQFUSIHAYY
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1EC0", Offset = "0x8EF08C0", VA = "0x188EF1EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid FNIXYWHMAUF
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2740", Offset = "0x8EF1140", VA = "0x188EF2740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid KJVYQOODCUF
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6E00", Offset = "0x8EF5800", VA = "0x188EF6E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid BRZNSMABGUR
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF25C0", Offset = "0x8EF0FC0", VA = "0x188EF25C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid FQJUGATAQLI
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x8EE85C0", Offset = "0x8EE6FC0", VA = "0x188EE85C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid RJEHPWSEDVW
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4500", Offset = "0x8EF2F00", VA = "0x188EF4500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid KSHQGMUYFCB
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC040", Offset = "0x8EEAA40", VA = "0x188EEC040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid RHBDSDUDIWT
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3B40", Offset = "0x8EF2540", VA = "0x188EF3B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid GMWXHPEUNVN
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x8EF10C0", Offset = "0x8EEFAC0", VA = "0x188EF10C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid JRPPZWSMSWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x8EECDC0", Offset = "0x8EEB7C0", VA = "0x188EECDC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid ECWSDOWEZJC
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE1C0", Offset = "0x8EECBC0", VA = "0x188EEE1C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid BWBISRHGBTL
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8D40", Offset = "0x8EE7740", VA = "0x188EE8D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid OFUWRNHJNGT
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2A40", Offset = "0x8EF1440", VA = "0x188EF2A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid FTVLEJHMRUQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3EC0", Offset = "0x8EF28C0", VA = "0x188EF3EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid OSDDVAYANJK
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE84C0", Offset = "0x8EE6EC0", VA = "0x188EE84C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid OKIDLTOFPOH
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC140", Offset = "0x8EEAB40", VA = "0x188EEC140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid CWWEYSPTZJS
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0x8EE82C0", Offset = "0x8EE6CC0", VA = "0x188EE82C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid VVLXDLASXAN
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7EC0", Offset = "0x8EE68C0", VA = "0x188EE7EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid XQRSCWOZPEG
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE440", Offset = "0x8EECE40", VA = "0x188EEE440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid EKPONHJQRJP
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9D40", Offset = "0x8EE8740", VA = "0x188EE9D40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid CZKQXMFOYGC
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0x8EE88C0", Offset = "0x8EE72C0", VA = "0x188EE88C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid HZAXYPNVXOR
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2640", Offset = "0x8EF1040", VA = "0x188EF2640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid ZPVLVTFTFXG
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF340", Offset = "0x8EEDD40", VA = "0x188EEF340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid TSTMCLOQRTV
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF1C0", Offset = "0x8EEDBC0", VA = "0x188EEF1C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid VQFQBABPIOE
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0x8EF8000", Offset = "0x8EF6A00", VA = "0x188EF8000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid QZJQNWJDCBU
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB1C0", Offset = "0x8EE9BC0", VA = "0x188EEB1C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid ZHVORVCMTWZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBC40", Offset = "0x8EEA640", VA = "0x188EEBC40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid XREHIIKXOWG
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0x8EF04C0", Offset = "0x8EEEEC0", VA = "0x188EF04C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid CWGGIKTSFOD
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3BC0", Offset = "0x8EF25C0", VA = "0x188EF3BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid LFGLRQZEVFQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAEC0", Offset = "0x8EE98C0", VA = "0x188EEAEC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid VCVUHAEZMSX
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0340", Offset = "0x8EEED40", VA = "0x188EF0340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid UHFAOXFBNBM
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3A40", Offset = "0x8EF2440", VA = "0x188EF3A40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid EWERHGWYLFI
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8540", Offset = "0x8EE6F40", VA = "0x188EE8540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid OXXTMWNWSGG
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1E40", Offset = "0x8EF0840", VA = "0x188EF1E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid DKTDLXBWYRG
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF33C0", Offset = "0x8EF1DC0", VA = "0x188EF33C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid IEPNGYJJAOW
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7300", Offset = "0x8EF5D00", VA = "0x188EF7300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid MEROENCEASN
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDF40", Offset = "0x8EEC940", VA = "0x188EEDF40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid IEKGJRPLRDN
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7200", Offset = "0x8EF5C00", VA = "0x188EF7200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid IEEZMKVOHSE
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7280", Offset = "0x8EF5C80", VA = "0x188EF7280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid WVPUDDNRMDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7F80", Offset = "0x8EF6980", VA = "0x188EF7F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid GMCTENNQDKF
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF640", Offset = "0x8EEE040", VA = "0x188EEF640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid GLMYMTFYBCE
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF5C0", Offset = "0x8EEDFC0", VA = "0x188EEF5C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid TEAEQWGTYOG
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0x8EED840", Offset = "0x8EEC240", VA = "0x188EED840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid ZUWUPAAHZGM
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8440", Offset = "0x8EE6E40", VA = "0x188EE8440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid PUMGOBCBZHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFB40", Offset = "0x8EEE540", VA = "0x188EEFB40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid LGVVNKSDTRC
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBDC0", Offset = "0x8EEA7C0", VA = "0x188EEBDC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid UHUQQRHCMOC
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEB40", Offset = "0x8EED540", VA = "0x188EEEB40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid IEIMJTKESUN
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7D80", Offset = "0x8EF6780", VA = "0x188EF7D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid PYPXXDYFJZN
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3640", Offset = "0x8EF2040", VA = "0x188EF3640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid AGVBQJIEPAX
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6D00", Offset = "0x8EF5700", VA = "0x188EF6D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid TMRMESPTCFO
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE0C0", Offset = "0x8EECAC0", VA = "0x188EEE0C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid DICEEEBHSQB
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB240", Offset = "0x8EE9C40", VA = "0x188EEB240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid XEXFQJUBTXJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4D00", Offset = "0x8EF3700", VA = "0x188EF4D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid KQQMUCQYYLT
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2DC0", Offset = "0x8EF17C0", VA = "0x188EF2DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid ASVMIOETKIA
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFAC0", Offset = "0x8EEE4C0", VA = "0x188EEFAC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid MNVCZZZKCEX
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4800", Offset = "0x8EF3200", VA = "0x188EF4800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid GHVAVTWOSCO
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEAC0", Offset = "0x8EED4C0", VA = "0x188EEEAC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid TYHWKUSRPQG
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDAC0", Offset = "0x8EEC4C0", VA = "0x188EEDAC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid TVXZLHIHPDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0x8EECE40", Offset = "0x8EEB840", VA = "0x188EECE40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid UKBQZVYAJTD
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0x8EED9C0", Offset = "0x8EEC3C0", VA = "0x188EED9C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid OESNWTSMJII
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFF40", Offset = "0x8EEE940", VA = "0x188EEFF40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid VMKDFQHOBUH
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC840", Offset = "0x8EEB240", VA = "0x188EEC840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid FRKRUJUNWUI
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4780", Offset = "0x8EF3180", VA = "0x188EF4780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid RPFZZQRZUSB
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3840", Offset = "0x8EF2240", VA = "0x188EF3840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid IWWJMDHTQJD
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0x8EE81C0", Offset = "0x8EE6BC0", VA = "0x188EE81C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid WMFZYZXHLRD
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4900", Offset = "0x8EF3300", VA = "0x188EF4900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid ZLOBXIGAFJQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDDC0", Offset = "0x8EEC7C0", VA = "0x188EEDDC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid UKRUMRGUJLM
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDC40", Offset = "0x8EEC640", VA = "0x188EEDC40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid BAKXHIFXQMT
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA8C0", Offset = "0x8EE92C0", VA = "0x188EEA8C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid KMAARUUONPP
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2B40", Offset = "0x8EF1540", VA = "0x188EF2B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid NFFAOYEZHOY
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEEC0", Offset = "0x8EED8C0", VA = "0x188EEEEC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid QTGFHMVMDBX
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEA40", Offset = "0x8EED440", VA = "0x188EEEA40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid GRVIIUYTXZF
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA140", Offset = "0x8EE8B40", VA = "0x188EEA140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid AYUMCKNRVFJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6400", Offset = "0x8EF4E00", VA = "0x188EF6400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid WRPCSSOMRAF
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0x8EED040", Offset = "0x8EEBA40", VA = "0x188EED040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid GURGPEGNOQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6500", Offset = "0x8EF4F00", VA = "0x188EF6500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid AVYNYGWOTAF
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0x8EED2C0", Offset = "0x8EEBCC0", VA = "0x188EED2C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid CPFGBBKSMSB
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0x8EF20C0", Offset = "0x8EF0AC0", VA = "0x188EF20C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid QXCMZFOSUMN
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC5C0", Offset = "0x8EEAFC0", VA = "0x188EEC5C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid ZUDXJVCLSTP
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0B40", Offset = "0x8EEF540", VA = "0x188EF0B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid NOWMENKLIGN
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA740", Offset = "0x8EE9140", VA = "0x188EEA740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid HPPPKELLKVJ
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9340", Offset = "0x8EE7D40", VA = "0x188EE9340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid OQCFMZINGHL
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3140", Offset = "0x8EF1B40", VA = "0x188EF3140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid BJCFFROKDPC
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF41C0", Offset = "0x8EF2BC0", VA = "0x188EF41C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid TFOVJIXJKED
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0x8EECCC0", Offset = "0x8EEB6C0", VA = "0x188EECCC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid VQBXFHTOHAG
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4880", Offset = "0x8EF3280", VA = "0x188EF4880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid IPPMEERLRQS
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEC40", Offset = "0x8EED640", VA = "0x188EEEC40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid WOOYQEAITGK
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC1C0", Offset = "0x8EEABC0", VA = "0x188EEC1C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid ZKHMXBZIFRL
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5F00", Offset = "0x8EF4900", VA = "0x188EF5F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid QUXCUJZMEXO
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0x8EF30C0", Offset = "0x8EF1AC0", VA = "0x188EF30C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid HWGNXCKDAXF
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBE40", Offset = "0x8EEA840", VA = "0x188EEBE40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid QQXKDFMHYQG
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8E40", Offset = "0x8EE7840", VA = "0x188EE8E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid VXKACLFPLAP
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0x8EED540", Offset = "0x8EEBF40", VA = "0x188EED540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid ODXILSORHDU
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB940", Offset = "0x8EEA340", VA = "0x188EEB940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid ABDQNTRMJZH
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEED40", Offset = "0x8EED740", VA = "0x188EEED40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid SSTTTILNRJW
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0EC0", Offset = "0x8EEF8C0", VA = "0x188EF0EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid SXUEIZDWLPN
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0240", Offset = "0x8EEEC40", VA = "0x188EF0240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid JYISEZEPKWP
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4B00", Offset = "0x8EF3500", VA = "0x188EF4B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid VCUWTADKGSL
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9DC0", Offset = "0x8EE87C0", VA = "0x188EE9DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid GDPDGNBSPRO
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF14C0", Offset = "0x8EEFEC0", VA = "0x188EF14C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid UKTEMEDBVKM
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC540", Offset = "0x8EEAF40", VA = "0x188EEC540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid EIUYETIKMXY
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x8EF21C0", Offset = "0x8EF0BC0", VA = "0x188EF21C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid LUIIMKHHCSZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBBC0", Offset = "0x8EEA5C0", VA = "0x188EEBBC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid OSKFMWXMJJH
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB840", Offset = "0x8EEA240", VA = "0x188EEB840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid ARBUNMNTHQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0x8EF11C0", Offset = "0x8EEFBC0", VA = "0x188EF11C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid DAXPDJMKKEF
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1B40", Offset = "0x8EF0540", VA = "0x188EF1B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid HFVDPMBEDEO
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0040", Offset = "0x8EEEA40", VA = "0x188EF0040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid SADKYTXDBXX
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3E40", Offset = "0x8EF2840", VA = "0x188EF3E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid PZJGGRFMCTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5680", Offset = "0x8EF4080", VA = "0x188EF5680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid IESBVPMEWNP
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBA40", Offset = "0x8EEA440", VA = "0x188EEBA40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid LPGGIESOJTY
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBCC0", Offset = "0x8EEA6C0", VA = "0x188EEBCC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid ZSHWJAWSKVG
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0x8EE99C0", Offset = "0x8EE83C0", VA = "0x188EE99C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid WUTYFOWWIZN
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9B40", Offset = "0x8EE8540", VA = "0x188EE9B40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid LRLATILLABB
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0x8EE90C0", Offset = "0x8EE7AC0", VA = "0x188EE90C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid PAAIHFNTDQU
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE340", Offset = "0x8EECD40", VA = "0x188EEE340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid PEPJHODELWK
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0x8EE89C0", Offset = "0x8EE73C0", VA = "0x188EE89C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid IBWTPEGYVTI
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0x8EED7C0", Offset = "0x8EEC1C0", VA = "0x188EED7C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid TBQIJLMPORR
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4D80", VA = "0x188EF6380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid VKOHTUOVHEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC440", Offset = "0x8EEAE40", VA = "0x188EEC440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid OCCKRTEFTNQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0x8EF17C0", Offset = "0x8EF01C0", VA = "0x188EF17C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid TGTGKGKSOLS
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7880", Offset = "0x8EF6280", VA = "0x188EF7880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid VTZQJRGDFBZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0x8EF02C0", Offset = "0x8EEECC0", VA = "0x188EF02C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid TEXGHSVKVUI
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9440", Offset = "0x8EE7E40", VA = "0x188EE9440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid KWSJAJTVWAK
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7C00", Offset = "0x8EF6600", VA = "0x188EF7C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid QHMOVLFXTCP
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4A80", Offset = "0x8EF3480", VA = "0x188EF4A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid QLBZITJJMQA
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7A00", Offset = "0x8EF6400", VA = "0x188EF7A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid PJNOQPJNPBO
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9040", Offset = "0x8EE7A40", VA = "0x188EE9040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid MXYEBCDRUMW
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6880", Offset = "0x8EF5280", VA = "0x188EF6880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid SXGQXKABXGQ
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6280", Offset = "0x8EF4C80", VA = "0x188EF6280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid UWYXRWFSFDU
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFBC0", Offset = "0x8EEE5C0", VA = "0x188EEFBC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid FPSFTHIDEJP
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5400", Offset = "0x8EF3E00", VA = "0x188EF5400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid NHRWMVYOSQH
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7E40", Offset = "0x8EE6840", VA = "0x188EE7E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid RUKHMSUJLPM
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF4C0", Offset = "0x8EEDEC0", VA = "0x188EEF4C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid UDEETEIWQEJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0x8EECBC0", Offset = "0x8EEB5C0", VA = "0x188EECBC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid OIDDXUSUNHH
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5880", Offset = "0x8EF4280", VA = "0x188EF5880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid UTQOTJYIBFY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB740", Offset = "0x8EEA140", VA = "0x188EEB740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid VOIHWWLOPZV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE140", Offset = "0x8EECB40", VA = "0x188EEE140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid WLNRIOMLMEP
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8740", Offset = "0x8EE7140", VA = "0x188EE8740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid LCCUDLQNTOP
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0940", Offset = "0x8EEF340", VA = "0x188EF0940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid CLMVPFWPTDY
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9840", Offset = "0x8EE8240", VA = "0x188EE9840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid NOVTWKIGGMT
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF6C0", Offset = "0x8EEE0C0", VA = "0x188EEF6C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid LGRIBMSSUFT
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0x8EE92C0", Offset = "0x8EE7CC0", VA = "0x188EE92C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid HVATULCNKVA
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4C00", Offset = "0x8EF3600", VA = "0x188EF4C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid XCWOHUZARZB
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4600", Offset = "0x8EF3000", VA = "0x188EF4600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid OEQHOMRAUAS
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5C80", Offset = "0x8EF4680", VA = "0x188EF5C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid FYBQDHZAJHY
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC740", Offset = "0x8EEB140", VA = "0x188EEC740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid RQXYKXZFINY
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDEC0", Offset = "0x8EEC8C0", VA = "0x188EEDEC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid ULPWFONCPTL
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7700", Offset = "0x8EF6100", VA = "0x188EF7700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid EKAMQBMZRSD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6F00", Offset = "0x8EF5900", VA = "0x188EF6F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid SYRFZLQQUET
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6200", Offset = "0x8EF4C00", VA = "0x188EF6200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid OJJNYSSWNTF
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5280", Offset = "0x8EF3C80", VA = "0x188EF5280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid JGFPOILDTYP
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5800", Offset = "0x8EF4200", VA = "0x188EF5800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid QGXTQHMIQJD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0x8EED6C0", Offset = "0x8EEC0C0", VA = "0x188EED6C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid UDYGJKFRNEZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9EC0", Offset = "0x8EE88C0", VA = "0x188EE9EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid KFPASNSFTXN
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB040", Offset = "0x8EE9A40", VA = "0x188EEB040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid QQJAHSHKQEK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3940", Offset = "0x8EF2340", VA = "0x188EF3940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid ZZFUOFGAOQQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5B80", Offset = "0x8EF4580", VA = "0x188EF5B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid UNQHDOIVMRJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB640", Offset = "0x8EEA040", VA = "0x188EEB640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid XXPFHHWIWFT
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0AC0", Offset = "0x8EEF4C0", VA = "0x188EF0AC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid UPOPXLZRXJL
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3240", Offset = "0x8EF1C40", VA = "0x188EF3240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid FWNMDQOCQFQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0x8EF37C0", Offset = "0x8EF21C0", VA = "0x188EF37C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid BITBYNUMZYR
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC6C0", Offset = "0x8EEB0C0", VA = "0x188EEC6C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid MSQNBGTMAOU
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6980", Offset = "0x8EF5380", VA = "0x188EF6980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid HDZGCZFJBZU
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0x8EED640", Offset = "0x8EEC040", VA = "0x188EED640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid SMJNZRGZWTE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0x8EED3C0", Offset = "0x8EEBDC0", VA = "0x188EED3C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid COGIJIRLAEW
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0x8EE93C0", Offset = "0x8EE7DC0", VA = "0x188EE93C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid QHGZSCZMIKA
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0BC0", Offset = "0x8EEF5C0", VA = "0x188EF0BC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid PGFGMQKRROB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2240", Offset = "0x8EF0C40", VA = "0x188EF2240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid SJLELABXEYL
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE6C0", Offset = "0x8EED0C0", VA = "0x188EEE6C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid DFBNJSFNJVF
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA9C0", Offset = "0x8EE93C0", VA = "0x188EEA9C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid HFXEPZAUWMM
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5080", Offset = "0x8EF3A80", VA = "0x188EF5080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid XONFTUNVBYB
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8C40", Offset = "0x8EE7640", VA = "0x188EE8C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid PUMYDKPPQBE
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7380", Offset = "0x8EF5D80", VA = "0x188EF7380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid LALVQEVNSGJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8140", Offset = "0x8EE6B40", VA = "0x188EE8140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid WDJDSBUBVAQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0x8EEBAC0", Offset = "0x8EEA4C0", VA = "0x188EEBAC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid AWGDONHIWNX
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFA40", Offset = "0x8EEE440", VA = "0x188EEFA40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid UXVEPFHNQKU
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9640", Offset = "0x8EE8040", VA = "0x188EE9640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid ZIZNGEVCTUV
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0x8EEACC0", Offset = "0x8EE96C0", VA = "0x188EEACC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid NNRNASGDLOR
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0x8EECEC0", Offset = "0x8EEB8C0", VA = "0x188EECEC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid BKPVUTOTDRI
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3040", Offset = "0x8EF1A40", VA = "0x188EF3040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid PDYPUPQFWQG
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6B00", Offset = "0x8EF5500", VA = "0x188EF6B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid TJUDWUTXJIB
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE540", Offset = "0x8EECF40", VA = "0x188EEE540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid FBYFAJNEVWD
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB540", Offset = "0x8EE9F40", VA = "0x188EEB540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid VTFWXNVBLPN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7100", Offset = "0x8EF5B00", VA = "0x188EF7100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid ONTJEXMXDCM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2E40", Offset = "0x8EF1840", VA = "0x188EF2E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid ONDONDFFAUL
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2EC0", Offset = "0x8EF18C0", VA = "0x188EF2EC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid VYBNKOIQRRN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5180", Offset = "0x8EF3B80", VA = "0x188EF5180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid REVEFRQPYUI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB7C0", Offset = "0x8EEA1C0", VA = "0x188EEB7C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid PDRJBPOPWKM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0640", Offset = "0x8EEF040", VA = "0x188EF0640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid LYTVOYQCWUX
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFCC0", Offset = "0x8EEE6C0", VA = "0x188EEFCC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid DYKQHSPUQTU
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7B00", Offset = "0x8EF6500", VA = "0x188EF7B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid EOWLNSFVNLW
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6C00", Offset = "0x8EF5600", VA = "0x188EF6C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid RTABKIHMTHZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7180", Offset = "0x8EF5B80", VA = "0x188EF7180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid WMKAJNEOOOI
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0x8EF07C0", Offset = "0x8EEF1C0", VA = "0x188EF07C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid CBOEODMFWKU
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1FC0", Offset = "0x8EF09C0", VA = "0x188EF1FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid QSBADZYJQFY
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7C80", Offset = "0x8EF6680", VA = "0x188EF7C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid JZFLLMFEBFK
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5E00", Offset = "0x8EF4800", VA = "0x188EF5E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid BTWNPFYCRMR
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEF40", Offset = "0x8EED940", VA = "0x188EEEF40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid PJHVCMTHXPI
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5600", Offset = "0x8EF4000", VA = "0x188EF5600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid RRFQURFGIBL
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0x8EE98C0", Offset = "0x8EE82C0", VA = "0x188EE98C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid LUHEBQBCAZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4480", Offset = "0x8EF2E80", VA = "0x188EF4480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid ZTKNZBIUWIP
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFE40", Offset = "0x8EEE840", VA = "0x188EEFE40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid HLYBBEQDBPH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAA40", Offset = "0x8EE9440", VA = "0x188EEAA40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid YADCSBOWBXH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2C40", Offset = "0x8EF1640", VA = "0x188EF2C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid IPQNCDTNEWV
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF16C0", Offset = "0x8EF00C0", VA = "0x188EF16C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid RTNQJFFTAMA
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5200", Offset = "0x8EF3C00", VA = "0x188EF5200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid EJGFFLRTNVW
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0x8EE91C0", Offset = "0x8EE7BC0", VA = "0x188EE91C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid ZCABMDYIGUB
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1840", Offset = "0x8EF0240", VA = "0x188EF1840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid ZXFLTFGBCBK
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5580", Offset = "0x8EF3F80", VA = "0x188EF5580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid GQOIHEVJPVX
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6B80", Offset = "0x8EF5580", VA = "0x188EF6B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid GEXBLRNAHYC
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE840", Offset = "0x8EED240", VA = "0x188EEE840")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid GGEFREEGEZE
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF3C0", Offset = "0x8EEDDC0", VA = "0x188EEF3C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid DWVNPOTSCJV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6780", Offset = "0x8EF5180", VA = "0x188EF6780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid DJOIDVCFHVD
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3DC0", Offset = "0x8EF27C0", VA = "0x188EF3DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid IXXQZUSXBHU
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA440", Offset = "0x8EE8E40", VA = "0x188EEA440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid HXWXYIZZLYV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9E40", Offset = "0x8EE8840", VA = "0x188EE9E40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid YTBWJLYNWZU
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC7C0", Offset = "0x8EEB1C0", VA = "0x188EEC7C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid UTYXMNTTDJP
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6A80", Offset = "0x8EF5480", VA = "0x188EF6A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid WIBJLUHZWSI
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0x8EE80C0", Offset = "0x8EE6AC0", VA = "0x188EE80C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid WCWUHAOMRUZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC2C0", Offset = "0x8EEACC0", VA = "0x188EEC2C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid BIVIMMZIAPT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4A00", Offset = "0x8EF3400", VA = "0x188EF4A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid YQQNRYNFUIT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0x8EEF8C0", Offset = "0x8EEE2C0", VA = "0x188EEF8C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid DDZZISSKZCT
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0x8EF13C0", Offset = "0x8EEFDC0", VA = "0x188EF13C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid LRDGCHLJWJO
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1C40", Offset = "0x8EF0640", VA = "0x188EF1C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid YBXKNGUHSUA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0x8EED140", Offset = "0x8EEBB40", VA = "0x188EED140")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid WANJUDTOCZL
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7CC0", Offset = "0x8EE66C0", VA = "0x188EE7CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid IGGMQXPIGZV
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0x8EEFD40", Offset = "0x8EEE740", VA = "0x188EEFD40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid KHQGXXHUXEA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2FC0", Offset = "0x8EF19C0", VA = "0x188EF2FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid MOCESXPPKZD
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0x8EF23C0", Offset = "0x8EF0DC0", VA = "0x188EF23C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid ZXTHQMLJFGL
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7000", Offset = "0x8EF5A00", VA = "0x188EF7000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid DVUSTUTNXOV
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0x8EF2040", Offset = "0x8EF0A40", VA = "0x188EF2040")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid YLKUDUJKDDH
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE2C0", Offset = "0x8EECCC0", VA = "0x188EEE2C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid FINOKOMNXLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4F80", Offset = "0x8EF3980", VA = "0x188EF4F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid OFMIZOXCQCL
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6C80", Offset = "0x8EF5680", VA = "0x188EF6C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid SMRFFIUFVSY
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3FC0", Offset = "0x8EF29C0", VA = "0x188EF3FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid GCUJCEKPUJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0x8EEDBC0", Offset = "0x8EEC5C0", VA = "0x188EEDBC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid MPPTXCLBUTO
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0x8EED440", Offset = "0x8EEBE40", VA = "0x188EED440")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid UUWDHPRFKAU
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5B00", Offset = "0x8EF4500", VA = "0x188EF5B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid FXPGCJEMJWM
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0C40", Offset = "0x8EEF640", VA = "0x188EF0C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid GLOCWRGPCVW
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF0DC0", Offset = "0x8EEF7C0", VA = "0x188EF0DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid NBVUEGGGMIR
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF3C40", Offset = "0x8EF2640", VA = "0x188EF3C40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid WIUWNFMCGIS
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA340", Offset = "0x8EE8D40", VA = "0x188EEA340")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid ZJLWLGKBMEN
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5780", Offset = "0x8EF4180", VA = "0x188EF5780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid KDHYOLRJFFW
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7600", Offset = "0x8EF6000", VA = "0x188EF7600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid KRXVVGLYZDE
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE940", Offset = "0x8EED340", VA = "0x188EEE940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid JGENOGCRFEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0x8EF35C0", Offset = "0x8EF1FC0", VA = "0x188EF35C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid ZEQMDJMQRYN
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5380", Offset = "0x8EF3D80", VA = "0x188EF5380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid FEVPFBGTEJI
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6080", Offset = "0x8EF4A80", VA = "0x188EF6080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid EZWSHLAOCQJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0x8EECB40", Offset = "0x8EEB540", VA = "0x188EECB40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid EENGFMIITNC
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0x8EF06C0", Offset = "0x8EEF0C0", VA = "0x188EF06C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid ZMEYKOOGNPI
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE4C0", Offset = "0x8EECEC0", VA = "0x188EEE4C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid FZEBGEHBCIM
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0x8EF38C0", Offset = "0x8EF22C0", VA = "0x188EF38C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid BVINGZBTWRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5100", Offset = "0x8EF3B00", VA = "0x188EF5100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid PGIPRLIQXWY
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4580", Offset = "0x8EF2F80", VA = "0x188EF4580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid LAVTBPGKJLD
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC9C0", Offset = "0x8EEB3C0", VA = "0x188EEC9C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid EYJSRQBTWJO
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1540", Offset = "0x8EEFF40", VA = "0x188EF1540")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid NVNURXNVRUQ
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6D80", Offset = "0x8EF5780", VA = "0x188EF6D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid XPRKNFGZMCY
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF7480", Offset = "0x8EF5E80", VA = "0x188EF7480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid PULNBFECLZG
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0x8EF8200", Offset = "0x8EF6C00", VA = "0x188EF8200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid ZGQKFPRQJVE
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE3C0", Offset = "0x8EECDC0", VA = "0x188EEE3C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid ZCDSNYXLRWA
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0x8EF4E00", Offset = "0x8EF3800", VA = "0x188EF4E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid KBIFJOEARLZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0x8EEEDC0", Offset = "0x8EED7C0", VA = "0x188EEEDC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid RYYOQVLZNWY
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAD40", Offset = "0x8EE9740", VA = "0x188EEAD40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid WZHQCECKRDT
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9940", Offset = "0x8EE8340", VA = "0x188EE9940")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid SZSKJWNPGCB
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0x8EED8C0", Offset = "0x8EEC2C0", VA = "0x188EED8C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid QJTWRYBBXIQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6180", Offset = "0x8EF4B80", VA = "0x188EF6180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid GWVTWAPFVTX
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB5C0", Offset = "0x8EE9FC0", VA = "0x188EEB5C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid PUBJQDPLRLR
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0x8EF5900", Offset = "0x8EF4300", VA = "0x188EF5900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid MKPOPCQQXQM
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0x8EE94C0", Offset = "0x8EE7EC0", VA = "0x188EE94C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid HCIQBSIKZOA
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA7C0", Offset = "0x8EE91C0", VA = "0x188EEA7C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid URNVSHHUXJZ
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0x8EEA0C0", Offset = "0x8EE8AC0", VA = "0x188EEA0C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid DVGHXYOHAAK
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0x8EEE740", Offset = "0x8EED140", VA = "0x188EEE740")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid OTZDNSCSZTY
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0x8EEADC0", Offset = "0x8EE97C0", VA = "0x188EEADC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid UNSULHSJWZY
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6900", Offset = "0x8EF5300", VA = "0x188EF6900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid WOCEFYLFWQH
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9CC0", Offset = "0x8EE86C0", VA = "0x188EE9CC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid FKDHXLEEPUX
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0x8EEAC40", Offset = "0x8EE9640", VA = "0x188EEAC40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid YTMTZOOBVSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0x8EF1640", Offset = "0x8EF0040", VA = "0x188EF1640")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid ILZGBFYQFOC
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0x8EECA40", Offset = "0x8EEB440", VA = "0x188EECA40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid CMDCGDIATZV
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0x8EF40C0", Offset = "0x8EF2AC0", VA = "0x188EF40C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid CKXDQCUBJTJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8F40", Offset = "0x8EE7940", VA = "0x188EE8F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid CLCKNJNYTES
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0x8EE8FC0", Offset = "0x8EE79C0", VA = "0x188EE8FC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid RMQCUWMCAOP
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0x8EEC240", Offset = "0x8EEAC40", VA = "0x188EEC240")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid VZUBENBLIHC
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0x8EEB2C0", Offset = "0x8EE9CC0", VA = "0x188EEB2C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid OENCUKFXECW
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0x8EF27C0", Offset = "0x8EF11C0", VA = "0x188EF27C0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid LUSNUUYJBUM
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0x8EE9F40", Offset = "0x8EE8940", VA = "0x188EE9F40")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid EEPLUVLPIUV
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6600", Offset = "0x8EF5000", VA = "0x188EF6600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid TMRFNIXECJM
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0x8EE7DC0", Offset = "0x8EE67C0", VA = "0x188EE7DC0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid LVBILEFLJHF
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0x8EF6480", Offset = "0x8EF4E80", VA = "0x188EF6480")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8EC03E0", Offset = "0x8EBEDE0", VA = "0x188EC03E0")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8EC07C0", Offset = "0x8EBF1C0", VA = "0x188EC07C0")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> TWFSSQQPTIF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class OVFCOPRRNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x8EE1D00", Offset = "0x8EE0700", VA = "0x188EE1D00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class IUWJXSWKCBW
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x8EDEBE0", Offset = "0x8EDD5E0", VA = "0x188EDEBE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class BWAPAJLJTHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8EDE900", Offset = "0x8EDD300", VA = "0x188EDE900")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EE4920", Offset = "0x8EE3320", VA = "0x188EE4920")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EE3480", Offset = "0x8EE1E80", VA = "0x188EE3480")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class QYNXTKQRPJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8EE20E0", Offset = "0x8EE0AE0", VA = "0x188EE20E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EDF0E0", Offset = "0x8EDDAE0", VA = "0x188EDF0E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class NTCBYWRZQKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8EDEF20", Offset = "0x8EDD920", VA = "0x188EDEF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EDA4C0", Offset = "0x8ED8EC0", VA = "0x188EDA4C0")]
		public static PersistedRoomData ILOQZJKTLJN(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA5E0", Offset = "0x8ED8FE0", VA = "0x188EDA5E0")]
		public static Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA710", Offset = "0x8ED9110", VA = "0x188EDA710")]
		public static Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA0A0", Offset = "0x8ED8AA0", VA = "0x188EDA0A0")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(HYKMXKQCBUU a, PersistedRoomData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA3E0", Offset = "0x8ED8DE0", VA = "0x188EDA3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
			public PlayerSaveVersion DTWCZEXJDGA()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xB9B090", Offset = "0xB99A90", VA = "0x180B9B090", Slot = "5")]
			public PlayerSaveVersion TLYCXURBGLE()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x181A770", Offset = "0x1819170", VA = "0x18181A770", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2C57190", Offset = "0x2C55B90", VA = "0x182C57190", Slot = "7")]
			public bool UPUAHVXNEJP(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8EDEDF0", Offset = "0x8EDD7F0", VA = "0x188EDEDF0", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public JKCUUNJHGIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private static Versioner<HYKMXKQCBUU, SYNWNGHNLWX, PlayerSaveVersion> DJYDIXUIPID;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE3C0", Offset = "0x8EDCDC0", VA = "0x188EDE3C0")]
		public static SYNWNGHNLWX? RTMZCDWHPAT([Optional] PNBUDRSZEST? a, [Optional] OQXJAHGXWMD? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD370", Offset = "0x8EDBD70", VA = "0x188EDD370")]
		public static Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, byte[]? bytes)
		{
			return default(Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCEF0", Offset = "0x8EDB8F0", VA = "0x188EDCEF0")]
		public static Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<SYNWNGHNLWX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCD10", Offset = "0x8EDB710", VA = "0x188EDCD10")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(HYKMXKQCBUU a, SYNWNGHNLWX b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE090", Offset = "0x8EDCA90", VA = "0x188EDE090")]
		public static void RAEAXMTWMVY(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDE50", Offset = "0x8EDC850", VA = "0x188EDDE50")]
		public static void QZYUAFZZDKP(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD9B0", Offset = "0x8EDC3B0", VA = "0x188EDD9B0")]
		public static void QZTNCZGBTZG(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD880", Offset = "0x8EDC280", VA = "0x188EDD880")]
		public static void QZOGFSMEKNX(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD810", Offset = "0x8EDC210", VA = "0x188EDD810")]
		public static void QZIZILSHBCO(SYNWNGHNLWX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD580", Offset = "0x8EDBF80", VA = "0x188EDD580")]
		private static OQXJAHGXWMD MXMQLSIZJLZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD4A0", Offset = "0x8EDBEA0", VA = "0x188EDD4A0")]
		private static OQXJAHGXWMD MXHJOLPCAAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE390", Offset = "0x8EDCD90", VA = "0x188EDE390")]
		[CompilerGenerated]
		internal static bool RSRUKTKEOBG(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCA70", Offset = "0x8EDB470", VA = "0x188EDCA70")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU AETEPCUARLU(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCEC0", Offset = "0x8EDB8C0", VA = "0x188EDCEC0")]
		[CompilerGenerated]
		internal static float JEKQEPBCZRO(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE540", Offset = "0x8EDCF40", VA = "0x188EDE540")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU WQCGBNYIRXG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCBC0", Offset = "0x8EDB5C0", VA = "0x188EDCBC0")]
		[CompilerGenerated]
		internal static int AWQUHMKQZDP(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD730", Offset = "0x8EDC130", VA = "0x188EDD730")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU OAXXZZCCBBP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD660", Offset = "0x8EDC060", VA = "0x188EDD660")]
		[CompilerGenerated]
		internal static CircuitsQuat NLXZQINKWWK(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCC90", Offset = "0x8EDB690", VA = "0x188EDCC90")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU CEPIWAMXIKE(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE4B0", Offset = "0x8EDCEB0", VA = "0x188EDE4B0")]
		[CompilerGenerated]
		internal static string UIYFHUNQUTH(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE4D0", Offset = "0x8EDCED0", VA = "0x188EDE4D0")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU URONCIJQXRN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCAE0", Offset = "0x8EDB4E0", VA = "0x188EDCAE0")]
		[CompilerGenerated]
		internal static CircuitsVec3 AUDQWXEIDAV(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCE40", Offset = "0x8EDB840", VA = "0x188EDCE40")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU GGRKRHKBNFF(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD7A0", Offset = "0x8EDC1A0", VA = "0x188EDD7A0")]
		[CompilerGenerated]
		internal static int QMJZSSYWSTM(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCBF0", Offset = "0x8EDB5F0", VA = "0x188EDCBF0")]
		[CompilerGenerated]
		internal static RWMGIRAZNGU BCZENQZYLZW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3057960", Offset = "0x3056360", VA = "0x183057960")]
		[CompilerGenerated]
		internal static void ZWRMYVNLHXA<a>(RepeatedField<TCKRUMUVKUZ> a, Func<ByteString, a> deserialize, Func<a, RWMGIRAZNGU> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class RVMIIXIDGNX
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8EE22A0", Offset = "0x8EE0CA0", VA = "0x188EE22A0")]
		public static XNILTSLWTZX AGYLCIGGYSZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2710", Offset = "0x8EE1110", VA = "0x188EE2710")]
		public static Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC> MEFWJVUTFYP(RHKNGDSCLZV.HYKMXKQCBUU a, byte[] b)
		{
			return default(Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE23C0", Offset = "0x8EE0DC0", VA = "0x188EE23C0")]
		public static Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC> MEFWJVUTFYP(RHKNGDSCLZV.HYKMXKQCBUU a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<XNILTSLWTZX>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8EE22F0", Offset = "0x8EE0CF0", VA = "0x188EE22F0")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(RHKNGDSCLZV.HYKMXKQCBUU a, XNILTSLWTZX b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class SCSHGYWHWLC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE32F0", Offset = "0x8EE1CF0", VA = "0x188EE32F0")]
		public static SpawnableTemplateData XMKDXNLHWPO([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2FD0", Offset = "0x8EE19D0", VA = "0x188EE2FD0")]
		public static Result<ParseResult<SpawnableTemplateData>, KZUDSDVUTEC> MEFWJVUTFYP(RHKNGDSCLZV.HYKMXKQCBUU a, WOYSETZYWWN.HYKMXKQCBUU b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2BC0", Offset = "0x8EE15C0", VA = "0x188EE2BC0")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(RHKNGDSCLZV.HYKMXKQCBUU a, WOYSETZYWWN.HYKMXKQCBUU b, SpawnableTemplateData c)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2800", Offset = "0x8EE1200", VA = "0x188EE2800")]
		private static Result<None, KZUDSDVUTEC> AOZQXKKQJTO(RHKNGDSCLZV.HYKMXKQCBUU a, SpawnableTemplateData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2E30", Offset = "0x8EE1830", VA = "0x188EE2E30")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
			public SuperRoomVersion DTWCZEXJDGA()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB8C200", Offset = "0xB8AC00", VA = "0x180B8C200", Slot = "5")]
			public SuperRoomVersion TLYCXURBGLE()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x181A770", Offset = "0x1819170", VA = "0x18181A770", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x2C57190", Offset = "0x2C55B90", VA = "0x182C57190", Slot = "7")]
			public bool UPUAHVXNEJP(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8EDEDA0", Offset = "0x8EDD7A0", VA = "0x188EDEDA0", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public JKCUUNJHGIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static Versioner<HYKMXKQCBUU, SuperRoomData, SuperRoomVersion> DJYDIXUIPID;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6810", Offset = "0x8EE5210", VA = "0x188EE6810")]
		public static SuperRoomData ACAWTAGOZAR([Optional] VGWHPUEYAGF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7230", Offset = "0x8EE5C30", VA = "0x188EE7230")]
		public static Result<ParseResult<SuperRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6F60", Offset = "0x8EE5960", VA = "0x188EE6F60")]
		public static Result<ParseResult<SuperRoomData>, KZUDSDVUTEC> MEFWJVUTFYP(HYKMXKQCBUU a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6B20", Offset = "0x8EE5520", VA = "0x188EE6B20")]
		public static Result<None, KZUDSDVUTEC> EOTEJAWPWJM(HYKMXKQCBUU a, SuperRoomData b)
		{
			return default(Result<None, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7570", Offset = "0x8EE5F70", VA = "0x188EE7570")]
		private static void RAEAXMTWMVY(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7470", Offset = "0x8EE5E70", VA = "0x188EE7470")]
		private static void QZYUAFZZDKP(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8EE73E0", Offset = "0x8EE5DE0", VA = "0x188EE73E0")]
		private static void QZTNCZGBTZG(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7360", Offset = "0x8EE5D60", VA = "0x188EE7360")]
		private static void QZOGFSMEKNX(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6C50", Offset = "0x8EE5650", VA = "0x188EE6C50")]
		public static DataTableData LNJHEIHKZQM(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6910", Offset = "0x8EE5310", VA = "0x188EE6910")]
		public static ProgressionManagerData EEBTEQONZKD(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7730", Offset = "0x8EE6130", VA = "0x188EE7730")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EE3370", Offset = "0x8EE1D70", VA = "0x188EE3370", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28F6E20", Offset = "0x28F5820", VA = "0x1828F6E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EDEB90", Offset = "0x8EDD590", VA = "0x188EDEB90")]
		public ZZRZDOPGDSP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8280", Offset = "0x8EF6C80", VA = "0x188EF8280", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B82870", Offset = "0x5B81270", VA = "0x185B82870")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class VODSXLVVNDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5AF0", Offset = "0x3BC44F0", VA = "0x183BC5AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EDEB90", Offset = "0x8EDD590", VA = "0x188EDEB90")]
		public CLBYMVSLCGS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8EDEB30", Offset = "0x8EDD530", VA = "0x188EDEB30", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6760", Offset = "0x8EE5160", VA = "0x188EE6760")]
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
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x66F3840", Offset = "0x66F2240", VA = "0x1866F3840")]
		public Result<TVersion, KZUDSDVUTEC> EOTEJAWPWJM(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x66F4070", Offset = "0x66F2A70", VA = "0x1866F4070")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KITBCUMOFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5291410", Offset = "0x528FE10", VA = "0x185291410")]
			internal Result<None, KZUDSDVUTEC> FCXOXOQGSTQ(TDeps a, TData b)
			{
				return default(Result<None, KZUDSDVUTEC>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x66F1960", Offset = "0x66F0360", VA = "0x1866F1960")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x66F1AA0", Offset = "0x66F04A0", VA = "0x1866F1AA0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class IUUCWKWYKKU
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3018290", Offset = "0x3016C90", VA = "0x183018290")]
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
		[Cpp2IlInjected.Address(RVA = "0x1900B10", Offset = "0x18FF510", VA = "0x181900B10")]
		public BCUFVWJLJCR(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE8D0", Offset = "0x8EDD2D0", VA = "0x188EDE8D0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE7D0", Offset = "0x8EDD1D0", VA = "0x188EDE7D0", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class HXSMSVOZQLA : KZUDSDVUTEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x28F6E20", Offset = "0x28F5820", VA = "0x1828F6E20")]
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
