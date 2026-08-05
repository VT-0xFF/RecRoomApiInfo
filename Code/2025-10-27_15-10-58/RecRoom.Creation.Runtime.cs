using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Build;
using RecRoom.CircuitsV1.Protobuf;
using RecRoom.Core.Creation;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Algorithms;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.ObjectModel.Serialization;
using RecRoom.Persistence;
using RecRoom.Protobuf;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86751B0", Offset = "0x86741B0", VA = "0x1886751B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class RJTCECJYOGK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> FUOFZBOCOWQ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JHIAJOAUYKS;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> VDEZHGMNDYO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LLDOUNZDCTN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string YUFCCRODQHT;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string ZLWBPUALTAA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string HITDFMHESGV;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8675A70", Offset = "0x8674A70", VA = "0x188675A70")]
	public static bool LPLKQFOOQBK(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8675310", Offset = "0x8674310", VA = "0x188675310")]
	public static bool AMQMYAIMOGY(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86753A0", Offset = "0x86743A0", VA = "0x1886753A0")]
	public static string ESFPPFHNJNJ(Guid a)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DisallowSerialization]
public enum SpawnableToolType
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8674EA0", Offset = "0x8673EA0", VA = "0x188674EA0", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NPFWUVFDEMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public static readonly Guid DICKWYODZFG;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static readonly Guid MUFWUFQGGLO;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static readonly Guid VWXFHDDMFHA;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid FABZVDJJOYS;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid NOZHJXORNFD;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid UBDQAJUSHBD;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid UGWUZJJJCMS;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid ICFVBWHOSLZ;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid OUBNXFEEPDX;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid FCJDEKCUWNX;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid OUZVUVCZQTM;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid TUOQWSGKTBP;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid XDVHCUQICJM;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid WYHZJPUZKHT;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid VKTPBQUGHOC;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid XJWZLKHLOSD;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid MEUHDYBHZHV;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid CGBUOULAITU;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid KHXHTAXFDQT;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid TXMCEVNZHUI;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid FASDKKJZQII;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid MKKQCVAJZQG;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid GUTUQDOWIPW;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid LMUZUQLGAZA;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid TBGJTBPQXSM;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid DSDKCEGWCSZ;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid JDSSHSBFYFW;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid PYXWYBKHOQN;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid YKEJNDSVDEZ;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid SFPMSSOXGAG;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid GCUHLYCGYII;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid FTBJAPKWMLH;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid CWRDBFEURSQ;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid TURBDKXGMRJ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid ANCURYZJFHL;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid DPCXAXFZDFP;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid JATFBAIIZWH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid TLHSTWNYZNH;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid AWYJKUHHPIX;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid PLLCKJSDTGB;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid HZRVSASRIVP;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid YAJVCJEOKLZ;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid DNTKUQUSGDQ;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid TNMPSDWFMCP;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid KFDYIOMWGXO;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid MGLSSRAYPJO;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid MYHNXRWZDXW;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid NRUIZKAXEIX;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid AUBOAHVJWVE;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid TGMTXBXKVQL;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid HZNCCVPQUSZ;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid TZOXSCWDVHU;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid CRARCCXSDGG;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid JXFKMXBWFKK;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid YFUNLNQLHIT;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid BXRKSQUAXZV;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid XJRGNWCLTKE;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid OELSJOWIRPQ;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid VLFKSYXJQWP;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid ROYZTAXRLZI;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid GHEQJDJJYVD;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid WBAIWJWUHJH;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid XYIMOWCAQBU;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid VLVAPOZVZWR;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid HJGZQXCFLXH;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid KUDXIPMOXMG;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid MPLQDMWCNNU;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid NMZPRXYBQTL;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid DPVERMMJSKA;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid VZLXQETSXOD;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid LNNIUMJCZMK;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid JHLIHVPUUTX;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid FASHKEATJPF;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid IFKSPKHSDDU;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid VATWYSUJRAE;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid ZQUABEWMQFC;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid PPFFURZMFVU;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid WEITTVDNVPQ;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid KFQDUAVNZPZ;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid AOSMMQMREVA;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid JCHTXAVIRZB;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid IJCDHMIBFVQ;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid EFEGVWPKTPF;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid PWHWELAWZOZ;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid TZLYXNJPTQX;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid PUAYGAFJDZK;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid PCWPQWPYLCZ;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid LQVWCMXYHGT;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid BPEWBFVYNYS;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid HIFZGHQSHWG;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid DPUWXMWTGEZ;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid PKADYRUCMTV;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid ITSBJUAECTT;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid UMGVBSOYMTT;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid XZPOMBILSVH;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid VAHBVGLFSLO;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid VOMGEXYAKQD;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid DXJHTVRYOJZ;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid VPWSNQYHSHG;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid HYVMHVJHBMP;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid EKYKQWTGWOK;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid RYFXFPACGOT;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid EKNWWJFMDRS;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid ZUBEENZWTCR;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid XKHFSELEGWB;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid BXLSTEQLGRE;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid NSXFGHJMIIR;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid ROOLYAEIAUK;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid NSMRLTVRPLZ;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid HQHOHVPAOSI;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid NSCDRGHWWPH;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid HDRXWZCYKRM;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid KCGWCYHZYAM;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid AFAIUBCIRWZ;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid AJYULBUGBCV;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid LIUOWUUKCLG;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid MGBDYPORYVJ;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid HHHILYCXTZJ;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid UAYBQTOYKUI;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid JVCTUIDIIKP;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid RVQDPCEFRFR;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid UKUJCQZSZXT;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid RUZAZIWOWOF;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid BDQVXGMURTT;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid NIGZPMNFOSB;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid EVQSGWOERVX;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid JATGGCSRFFI;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid FUHZVLPFDOV;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid CXUEFPYTTHL;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid NQZPIGUDSBP;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid RWVGEBCVUZW;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid SVAGYZVBRGX;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid MGWAXDRONUY;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid MZVTUPRCVJQ;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid DYMJZOGLXDP;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid AZMAOMWZZEL;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid PYWVQWLHAQM;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid BIHSABWPORI;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid XSUNEPVEKHB;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid SPBCUTKJUZD;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid PNBIBTOUKPS;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid OXKLJMCHEFM;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid SWOGMVWPOBU;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid MXCSGVUAYCA;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid AZHRUZVJHTT;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid AGJJDTANZPL;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid AFTOLYSVXHK;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid AFYVJFMTGST;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid AFJARLFBEKS;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid AFOHORYYNWB;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid AEYMWXRGLOA;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid AFDTUELDUZJ;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid MIDFYJMDDZV;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid MFGBAKANNXN;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid KTBAKOYOLAG;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid RKUFITHEFXE;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid CORTZTOTWTD;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid XMIBNPVHITK;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid GCWZEMPPIIO;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid TICSZUANNPE;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid IBQDLEJMSVT;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid RHUNXGBHNQD;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid WMIGTXQFNIU;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid OLOHXRVFRZJ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid GFVAOKGXUOO;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid KSDYDCHUFJU;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid EOINRDMDPRF;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid UDJDMOAELTY;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid KRYRFVNWVYL;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid KRTKIOTZMNC;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid KRODLIACDBT;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid TNXABSIYODO;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid IOKNOXAFAYJ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid LAGYVSIIXQY;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid TOMUTMQQQLP;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid BZXUWHLNRGG;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid NYPCQRLRPIH;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid NKXPQVDBXHV;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid TITHQKIFUHA;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid ZTTPSIGOLPO;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid YWLEEAQHVTQ;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid CBKJXHMWPAY;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid LHYTZUDIHTM;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid HNUVQBWZBSN;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid BMDVCQTAKIU;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid XDIBMPGYCKL;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid MYGBEOZSTZJ;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid MNJOIBQSXZZ;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid AVFLKGLTERV;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid LFHIXTTICTQ;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid IHSKJNAMCTQ;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid JNCULIBEKEF;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid GMSKOHRWDDP;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ZUUUSGTCIAI;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid LILXDXSBYDF;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid EKWLZZLJPWL;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid JEDIHOKZURE;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid YJZSXVMZAUX;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid LSGRKFNJWRO;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid KVSSYJZDVPA;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid SMOAGWDJKSX;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid ATASGJXFPZW;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid CXEECSGMOLF;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid EZTDMEGOUFN;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid DMKDBVOTLQR;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid ICDBTFRCXLC;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid RFXQVLIIZQL;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid VQOHCYPQUTR;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid TDQMHWPNBSE;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid SRZVIKLLPLS;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid ZYCJYVJFHWX;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid JPVQTCKDBSG;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid GYQTIACRMMX;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid IIEKSZJMKYA;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid XITZYNSRQZY;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid EUXXJOZIUXW;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid JMCRGHLDUGW;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid RNIFUEPGJDB;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid UDPQPTIXLLT;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid ELVKBTITXTQ;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid QJIDTEVYUIR;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid TDSLSSVMMVA;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid ZBPHIXZLZMM;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid SCBWMWDLTIS;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid VRZLNQFZZWB;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid XSTKLUXCMKN;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid XSSXYOKQPJO;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid YWVPEPMDIOV;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid TYVAVGAUZOE;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid WOYPHBDAJAH;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid GDINTWISNRL;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid MMHMZVLOSOD;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid YMLFWKBRMAF;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid GDNWLHQYUUZ;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid NETHAVHUFUF;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid HIZWLRMXILS;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid TGQUIWYVGIV;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid DMBRVDRPSJP;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid TARWQEHPKRQ;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid KVNQFAAWFMP;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid TIWWJIEQZVE;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid LHNSGWFSEXQ;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid PLIAMSFYQBQ;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid XFPJEIPRCHT;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid TKJZQUSEFRA;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid ANYQUKEORTF;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid FZCCXOPWAKP;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid NFCLKOXSROI;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid XXCJKEISIIR;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid BUPXEGZJLUH;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid PBDLLHNBCRD;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid LKKLXGMSIUV;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid KJSZKMQJTKT;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid FCYPKRXUMTR;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid OSMGJHRJSDO;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid ZHQAATLTMMY;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid KTSFBEOCNQZ;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid NDFZWVTCUGQ;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid EZJUISXDYCH;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid BBPNMHNNGIZ;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid GRVCUPPUBTY;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid FMZEWAXBVAP;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid QWPQOXROWRF;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid LHQKTACMDQD;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid SQVZYZGEFKH;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid AVXIUMHBKYZ;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid MKCYNIOBFUR;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid YZOELFTSYNJ;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid SBSABBAPLDU;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid PHRYOHKGHQY;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid TFAKNMYDBSX;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid IGTLDGMHUQM;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid YBWUVHXBYJH;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid HOQDELGNROD;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid JBMRTNOOXMA;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid SEQHAQOOFBZ;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid OBAUEUCHDUZ;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid ZYKCCWYIKAV;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid GCVMOOWUPQY;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid DMJNRHXSYNM;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid HCBZASYYFJG;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid EHANLLWLNLX;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid TGYQFZRIVCZ;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid BJWLETSKEQP;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid QDPXBRXOJGB;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid AJROQXWSXQS;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid MKTNAFGAFLE;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid REUXBOYSBRU;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid BSKFICUBKAT;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid CDEMIYKDOVZ;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid NDELBVLSBOU;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid XNZGGTGFJCW;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid MRRQJDMVLXT;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid SAOSUXMNREV;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid IZVSTQUXYLK;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid JEEKAYNBCGV;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid VXMDNZGWHFO;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid BNKHRTBEQAJ;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid AXKARZLJGET;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid DEJFOKUCLKF;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid ZGLDHYPONEA;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid EFLTTLJEXUA;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid ZXBALWUJTCK;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid QMVAOHEFOSL;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid NVEACLNIJWO;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid XLEVGTGDPNY;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid AQSXJFOREAO;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid OOHWDGFVPOK;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid DPTRPRFRPZD;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid EWBVWCDHVLH;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid NQALOEGYGHL;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid JYIBNDFBNUJ;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid RRQMYAVNTUD;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid EJAXYBPJDXD;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid KJLCPKXKJGG;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid XVQNSYEFCYC;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid DJMCADFTYSL;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid GKMWVZNZVBS;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid COBPZUZTDEE;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid SVXVUVZLJJO;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid QEOCLQNRXWP;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid NJRPGOMDYBN;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid BZXITWSNDNI;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid VWPVKJKUCZG;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid HVUXDEVGLVI;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid PQLDOUGPTYM;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid MVDYQXVZYJB;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid XAQEVBTNFIN;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid XVCSRAVYXEA;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid GSTLERVXNBO;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid VTALAMPYQYW;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid MIJWRWMYRIM;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid NCZNEEMFSSJ;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid QVWZQSRZJAN;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid AKIRLEOKPBX;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid VLZPUTKEPTG;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid OQSGMJUFBEW;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid KZHBSCRSEUL;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid TSUQVUYJETF;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid ZCGEADPJNBK;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid CPZOHYBFVXO;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid VGUGVFLNHOV;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid OVSFUALBYCK;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid TKOQXTDQEXQ;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid FDHXAQMITAJ;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid MZDYPUVKSAC;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid ZINRDGUTKDW;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid ESQUNGYVVNF;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid PVIHHWHHALI;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid OOHNUACQVAB;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid NNDTVJGKCOE;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid KPTSMJSRTMI;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid TCTQOYOOLDY;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid YGXXZPTPXXG;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid MWSNSVENOAN;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid UZEZNAVHTPD;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid CJHGPBNLXTY;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid CQXCVOXEYTP;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid TGAMAQPKFYD;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid ZBHZCTJDIJN;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid ZZPTTGWYJGA;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid UGXSGZUUZBR;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid UAGHBPXKNAM;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid JUFRYACHNSN;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid SBLWQKQQTYU;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid WTGTGCCSPXM;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid JMRCGEDGKVR;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid BBWMYFYTQFT;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid QOCLQBVAHUL;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid CBDJHVYXGKT;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid HRJZPKCHKDX;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid NRFZWCJSJLA;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid XBCGXELULRN;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid EKYYBTQQHSU;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid MTCKOECPVVZ;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid IRVQYSAXVZS;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid GLXUCCICLWB;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid XAFMUSYTAVM;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid HANYFACHMXZ;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid BQPRGPLIWQA;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid NXFUZLDAYJJ;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid YNKZIXSLKQS;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid VRCSILSKYYE;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid IRCVNATUZUN;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid RPUFGUASOQO;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid EIEWHTFXAZB;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid YPKDGAJJCTC;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid JFLVODLFKNI;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid BIOYWKNARWS;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid MNMWFMYCFNO;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid TWHRFNJPWMZ;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid JGBVQLSOTMD;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid JIODKCKREEW;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid LXPNJJMWKIL;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid MMQIFCBALWG;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid DYLBCHZJOOU;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid HPWMESTVSMK;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid EPEMMLJHKCY;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid AEOVFSROLZF;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid KFQVLUVMNUE;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid RWLJPUOPTLD;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid RCQVONWEZRT;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid LDBNTEDUHQG;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid GQWTJATWXLY;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid GKLMYCWVIEP;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid CVBLSEBTJND;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid DQGIOIIAFMN;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid NHGLOGAAOHC;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid SYFGDBBZQZR;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid EEBINAKQMDS;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid KGFJQBYOSEK;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid OMQDNJNKGFR;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid QHVDUGRUVGV;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid XDBOWORSJRP;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid CNKFABWDCHE;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid GSBKOUSLPYD;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid YYIAVMSIWQH;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid TEPNRDIYRYN;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid TEKRQOHSNZN;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid KSNSQICPJBR;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid IXLZOBRHWQM;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid HRQQHTGCCIE;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid ZGFULCEHAOJ;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid RONPVOLCYYX;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid ZFPZTHWOYGI;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid ZFVGQOQMHRR;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid ZFFLYUIUFJQ;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid ZFKSWBCROUZ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid ZEUYEGUZMMY;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid ZFAFBNOWVYH;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid ZEKKJTHETQG;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid ZEPRHABCDBP;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid SAXHKMNWIJN;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid KDIPHMUQVSF;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid GNIEMHBGEAQ;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid NHDNMFMTXQQ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid SPRQKWTXCKE;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid HGVIHDFPNCI;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid YNKMFKKYQDP;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid QWHWWPWGLQF;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid TQHZECXZMQQ;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid YVDKXQVGTKG;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid WIQQEGJSXGL;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid LYLKPWIHVRB;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid AEVYZASEGLN;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid QLRYHCRAARS;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid CIMTKOFZMBF;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid POOXLZGJEAB;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid NBWCDDPKMYA;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid ADUBKYRPMUU;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid RTEIZNEIIXI;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid AAKJOLROJMA;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid WSTADBCFAZL;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid INDZGCXPEFA;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid IMOEOIPXBWZ;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid VAWWDRZWPTX;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid UJVCUUCJYFA;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid GKSEMYUFZPX;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid FRSBGCQKJTG;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid FHKEHQXERRI;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid WFCLCBWXDEJ;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid FSUWXXONTBB;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid OYQZYDDMYQN;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid ZARPJTMFDLH;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid TJBYWNNVWSP;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid MHVYNZGFBCM;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid JLJZZFFPMLX;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid CYFYWVRUQFZ;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid FVGVSPWFVSU;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid TMJKVDAOEHX;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid PBJJLQOBNVI;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid HJEWWHOSVSB;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid WJEVBAUFDTD;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid PYTQNPUAHTU;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid ACNJWKFYCWZ;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid MJEFGFWWEOD;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid NNANBNAXCMP;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid RQDKTFREMKD;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid MRNVBMKRICK;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid TFJEHEGIMKG;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid PQQGSAKFNNM;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid DINYMNLABLY;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid CSFBPOOLNCQ;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid CWCKHGGXYQU;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid NCCJTACVWKN;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid NMQRAXTNRPE;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid DCIFZZYBMBE;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid TBVUVFRMLRD;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid QNCGNYKTZJB;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid TZYCLHINCKE;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid OJJRHWMVRXT;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid XFXYVDSMJIM;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid GYEEGJLULLS;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid AGDEQSKZKWB;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid QSKAJDSYFPL;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid HZFZDHVWTBJ;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid JAKVWTEZTDF;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid DPEOGZBTJAH;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid NWPNVGAMKVK;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid ZJKWIVIGBHU;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid WOKGKYZQGTP;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid TRRLLGQCQKG;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid LFYHKCXBNVH;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid BEEBTDDTPWG;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid ETNJWJCKVDR;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid CRYURRHJCRY;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid AWSBPLDRXIR;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid IXOZXQTWZEA;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid ITGGPQKWOLW;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid NSLEODVIBJR;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid XNIDBHVYWHP;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid JTVHIRNJMMP;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid ZNIAELNRQCE;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid QZZLLLZSANJ;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid UCVFTHTURGI;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid HJJMSADVAJU;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid LQLBBXNYECZ;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid NPAQWPUGKOL;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid NOVJZJAJBDC;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid FYFXSJCGQIW;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid BQCYMZBHCKU;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid ZZQNMNKMITF;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid AUSRXZSCNMP;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid YLHKAWMBSMD;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid IUODIJXGMLI;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid GAKYZEZOCWZ;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid AVMTORQPPPA;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid FFUKZFPDDOL;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid KOLSJBISCGJ;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid PFLFZHKXKSO;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid BZCANKCLGRB;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid BVNKQEGZAYH;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid ZVFETBKFEUL;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid LASMYNKRTGC;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid AWNXRZGILDY;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid IEGELKONZYD;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid WRMPIKYQSJZ;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid TPBNAMUNSCY;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid UZTNVYUTNHY;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid WRSWPXLTQSJ;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid PAQLMPIXQAH;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid ESNXGOVSUDD;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid GZWXYBWVFBB;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid RKAJDKVCGTH;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid KBGNQQVBZSG;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid IVZEBNNOGRQ;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid DCEUIPIDWRF;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid NWKHFIUPYNE;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid XIYXZHMANKI;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid DXDIKOYFKFR;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid PDHRSHLEAEW;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid TNWVKBLKOKR;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid PHQTRNUBFHV;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid PNDBDXUNQOE;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid TVSZPAMTKWW;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid PDGWUQOYZBW;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid AXGKXXGYFNI;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid LONIDBPKPDY;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid ICGBZJCHIIK;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid APZBVGVYMYD;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid GAZBGWPDQCK;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid KICSAERYAOT;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid FQGTPXZIZCD;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid BWVABQEYEGJ;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid SJYDGEVAKMJ;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid HVTSCWLGSLQ;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid SZTRCANRNIL;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid QOGPWALOKZA;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid HYULDUJOUZG;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid HZKFVORGXHH;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid HZEYYHXJNVY;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid QGDTADMGEHN;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid MNVBOSUTDIX;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid MOAILZOQMUG;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid NKPSOEAEJYQ;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid UPKNPDCTYFU;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid KDFGZWSSSGI;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid MIAVDNZJJWN;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid SWBCYNECOHW;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid ZBECGDHDLFM;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid YHBHTQMBQAX;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid OFGRWULJMET;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid HNFLKPHEYAG;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid GSEYUKEZSAY;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid NDWULDUCEEW;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid VDCKTYESDWI;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid SUTGFRBSQSB;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid DRCWGKBWRXZ;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid MNWFTUFLRNA;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid DVWUAIBSGKE;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid SUELUMHPIPP;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid VLMCFYTNBJS;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid WCRWLTFBYTS;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid RTRWCCOIPDE;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid BPPXEYLJSUC;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid YJPPRLPUTIF;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid DUTLDSVBXSQ;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid TGLZAFASMAX;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid FQWKLDSQLFP;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid QRSZTXBISMX;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid RCETUFTBTUG;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid TLPKZSVUYOK;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid PRYXWHAQKFC;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid GKHVAYZIHEO;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid RSPPIBZNCRI;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid PPHSFRYIGYQ;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid IUSPVBUIEJC;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid BHRNBDVRRZP;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid ZBTJVBRZZLM;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid XYPNWQQFLHM;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid ABROFZZWMZR;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid MXYUROMMVVC;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid JDIBILBDPJG;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid JWZWAAFHFWG;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid NWTGKJHDYLA;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid AHAKEACUYJC;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid QHEBYRQQFKW;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid ZSPXZMRXPRR;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid SHIROTQBVFU;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid GIEAYMEDGIC;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid JSKRWCTDIXE;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid IBVOMCFEDPB;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid MFBYJPFPGTD;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid GSCUXIPGXGX;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid MWJKKZRCQXO;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid JSVFKAAKOBF;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid ZRCXCJHZDUU;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid GLDHKATPKHP;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid GKHPXSLFNQS;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid ANVKRSPPTOK;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid NEMCLRPCOLW;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid RSVVLPFAIEZ;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid XQRGEOINEPO;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid RRTSWTZSJHM;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid HFASMKSSXLJ;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid NBVFRTCBFTJ;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid GEWTZCPMBSW;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid PDJAAJBGUGP;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid DRIJXVSBAXC;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid ALWNBFNITVB;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid JGLMCQWHTHK;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid UIYPLYTTICM;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid QCUYNEEJRXB;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid HMQEJROOOFP;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid SJPEGGMCLVG;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid JNVTREJTVCN;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid LSQZTXRNIDU;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid RFFGQKVMRFF;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid XYNQLNEMXCS;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid LEUJCVLPDHC;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid XATTIJKROWL;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid XZKLLJSXKFF;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid ZQHWNVLWJNW;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private static readonly Dictionary<Guid, SpawnableToolType> ALRGFQJQZOI;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private static readonly Dictionary<SpawnableToolType, Guid> RDDMZCOPLSU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> ZIDJUXFHSQX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8674FC0", Offset = "0x8673FC0", VA = "0x188674FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> SJINPOLMRYX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8674F60", Offset = "0x8673F60", VA = "0x188674F60")]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EHWHWPSCTFS
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8674A60", Offset = "0x8673A60", VA = "0x188674A60")]
		public static bool FOPAFUOSSIC(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8674A90", Offset = "0x8673A90", VA = "0x188674A90")]
		private static bool FOPAFUOSSIC(YXVHLKGIDGF a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LQCPHLAGTRO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(RMQYZLSZAQY data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, HYPPKGPLRYA circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly SDUXUOJZYIJ Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public readonly IEnumerable<MQHFFIUQXTL> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public readonly IReadOnlyList<MQHFFIUQXTL> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public readonly Id32<LNVRVOESCOU> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public readonly IReadOnlyList<Id128<GOPNEBMAEKM>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool UFOXOJETHXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8675230", Offset = "0x8674230", VA = "0x188675230")]
		public R1CreateTemplateParams(SDUXUOJZYIJ circuits, IEnumerable<MQHFFIUQXTL> rootData, IReadOnlyList<MQHFFIUQXTL> allPersistableData, Id32<LNVRVOESCOU> sourceGraphId, IReadOnlyList<Id128<GOPNEBMAEKM>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly SDUXUOJZYIJ Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public readonly IReadOnlyList<MQHFFIUQXTL> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly Id32<LNVRVOESCOU> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IReadOnlyList<Id128<GOPNEBMAEKM>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86752A0", Offset = "0x86742A0", VA = "0x1886752A0")]
		public R2CreateTemplateParams(SDUXUOJZYIJ circuits, Id32<LNVRVOESCOU> sourceGraphId, IReadOnlyList<Id128<GOPNEBMAEKM>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<MQHFFIUQXTL> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class YAFQZIRFTAA : CHEUTFDOJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly Guid NTHDEOEORLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private readonly Dictionary<Guid, Guid> YUVNDRPLFHL;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x516D180", Offset = "0x516C180", VA = "0x18516D180")]
		private YAFQZIRFTAA(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8688230", Offset = "0x8687230", VA = "0x188688230")]
		public static YAFQZIRFTAA New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8687C60", Offset = "0x8686C60", VA = "0x188687C60")]
		private static Dictionary<Guid, Guid> CVFAETBMRNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86882C0", Offset = "0x86872C0", VA = "0x1886882C0")]
		public static YAFQZIRFTAA QEHKBNLXQMJ(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8687D80", Offset = "0x8686D80", VA = "0x188687D80")]
		public static YAFQZIRFTAA KPHAFLEQNVU(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86881C0", Offset = "0x86871C0", VA = "0x1886881C0")]
		public Dictionary<Guid, Guid> LSYLNINFHGU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
		public Dictionary<Guid, Guid> DBKLOHWFRWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8687B40", Offset = "0x8686B40", VA = "0x188687B40")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86882D0", Offset = "0x86872D0", VA = "0x1886882D0")]
		public void YNVPCHBAZAH(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8688070", Offset = "0x8687070", VA = "0x188688070")]
		public Guid LQVJTUBGCYH([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8687BC0", Offset = "0x8686BC0", VA = "0x188687BC0")]
		public Guid BONEQBNETGS([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8687D10", Offset = "0x8686D10", VA = "0x188687D10")]
		public bool KODASVGIPUD([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8687D10", Offset = "0x8686D10", VA = "0x188687D10", Slot = "4")]
		private bool DUSLGEQSYMF([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ZWVYLYYMPVO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QNLAOJKHTDF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OHLDZFJRTQD(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SZMCIIFTJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<ByteString> GetValidRoomCurrencies();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<ByteString> GetValidRoomConsumables();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class TRJLOAJRXUO : ZWVYLYYMPVO
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NYRZTNLPNSH : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private string IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string MDNALUYVRKQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
			[DebuggerHidden]
			public NYRZTNLPNSH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x86750F0", Offset = "0x86740F0", VA = "0x1886750F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8675020", Offset = "0x8674020", VA = "0x188675020", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8675060", Offset = "0x8674060", VA = "0x188675060", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> UWDMQJJAIDJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8675060", Offset = "0x8674060", VA = "0x188675060", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private Dictionary<string, HashSet<Guid>>? FYHWYDJWGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		protected Dictionary<string, string>? RBYRTXRULWW;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> MLYHFSQVCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8679760", Offset = "0x8678760", VA = "0x188679760")]
			[IteratorStateMachine(typeof(NYRZTNLPNSH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? XWOZTEZSLNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool QZUEPPDGTBA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool JHICIGPHRXN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> JHLRDHHUXUU(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool LRQKCITDDKI(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8679A70", Offset = "0x8678A70", VA = "0x188679A70")]
		public void ZKHTWIEMFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x10EE0F0", Offset = "0x10ED0F0", VA = "0x1810EE0F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86797C0", Offset = "0x86787C0", VA = "0x1886797C0", Slot = "4")]
		public bool QNLAOJKHTDF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8679690", Offset = "0x8678690", VA = "0x188679690", Slot = "5")]
		public bool OHLDZFJRTQD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8679450", Offset = "0x8678450", VA = "0x188679450")]
		private bool EVZFDUFSRSB(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8679510", Offset = "0x8678510", VA = "0x188679510")]
		protected List<Guid> FVODAASZZUE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected TRJLOAJRXUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class WMVUKFNBRTI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class IJCSPLUDTQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public SDUXUOJZYIJ XHZHTFLJZXN;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public IJCSPLUDTQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x868CBB0", Offset = "0x868BBB0", VA = "0x18868CBB0")]
			internal Id32<SPOBLADDTYT> KOJKUYSVDJL((Id32<LNVRVOESCOU> GraphId, Id32<GOPNEBMAEKM> NodeId) i)
			{
				return default(Id32<SPOBLADDTYT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private const int NDSGZNUAIFD = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Id32<SPOBLADDTYT>, ZUNDMIXFUXB> QIZQNCHBSCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private long EXMHTNJNPMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private long ONVKNDWCRRA;

		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private static readonly ReadOnlyIdArray<SPOBLADDTYT, int?> HIRVONAIYIJ;

		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private static readonly long GMFTBTVOERV;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long IRGWVMIGTMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x867A550", Offset = "0x8679550", VA = "0x18867A550")]
		public static WMVUKFNBRTI PXOSSNOOKYT(SDUXUOJZYIJ a, Id128<LNVRVOESCOU> b, [Optional] WMVUKFNBRTI c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x867A070", Offset = "0x8679070", VA = "0x18867A070")]
		public static (long, long) LNXKPYGNGUL(SDUXUOJZYIJ a, Id32<LNVRVOESCOU> b, Id32<GOPNEBMAEKM> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8679F40", Offset = "0x8678F40", VA = "0x188679F40")]
		public static long EARJPTRHQGQ([In] ReadOnlySpan<Id32<SPOBLADDTYT>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x867A410", Offset = "0x8679410", VA = "0x18867A410")]
		private static long NEEXOYEAAPL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8687AC0", Offset = "0x8686AC0", VA = "0x188687AC0")]
		public WMVUKFNBRTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class ZUNDMIXFUXB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xF79B00", Offset = "0xF78B00", VA = "0x180F79B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long OQASCXNAAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEC0760", Offset = "0xEBF760", VA = "0x180EC0760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81DBE00", Offset = "0x81DAE00", VA = "0x1881DBE00")]
		public ZUNDMIXFUXB(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class ZLBXJCRFPSP
	{
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public static readonly HashSet<SpawnableToolType> XSHRWFXHEQG;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class FUHIDQHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class TNJXNXXBREP : IEnumerable<MQHFFIUQXTL>, IEnumerable, IEnumerator<MQHFFIUQXTL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private MQHFFIUQXTL IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private SpawnableTemplateData IZXHJLAXRTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public SpawnableTemplateData MRPREMHMLTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private SpawnTemplateParams GOUQWTGVIDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public SpawnTemplateParams RPMENNVBYYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private int GLLQGAOFNOJ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private MQHFFIUQXTL SUOYWQLJLQU
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
			[DebuggerHidden]
			public TNJXNXXBREP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x86947D0", Offset = "0x86937D0", VA = "0x1886947D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8694630", Offset = "0x8693630", VA = "0x188694630", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8694670", Offset = "0x8693670", VA = "0x188694670", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MQHFFIUQXTL> LFIYESPQIDJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8694670", Offset = "0x8693670", VA = "0x188694670", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8689750", Offset = "0x8688750", VA = "0x188689750")]
		public static SpawnableTemplateData KSGKFUEQECT([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86895C0", Offset = "0x86885C0", VA = "0x1886895C0")]
		public static SpawnableTemplateData KSGKFUEQECT([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86898E0", Offset = "0x86888E0", VA = "0x1886898E0")]
		private static HashSet<Id128<KJRRKGEGKOM>> MBAJJKWCJNL(IReadOnlyList<MQHFFIUQXTL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x868B970", Offset = "0x868A970", VA = "0x18868B970")]
		private static void UTGJVTNZKBA(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8689C80", Offset = "0x8688C80", VA = "0x188689C80")]
		public static Result<YAFQZIRFTAA, TryCloneTemplateError> QVBUKMXXVEZ(SpawnableTemplateData a, SpawnTemplateParams b, YAFQZIRFTAA? srcRemapper, bool c)
		{
			return default(Result<YAFQZIRFTAA, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8689220", Offset = "0x8688220", VA = "0x188689220")]
		[IteratorStateMachine(typeof(TNJXNXXBREP))]
		private static IEnumerable<MQHFFIUQXTL> HPDVBTIPZUO(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x868B900", Offset = "0x868A900", VA = "0x18868B900")]
		private static void TMHSRRHCMIJ(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x868B270", Offset = "0x868A270", VA = "0x18868B270")]
		private static bool SPAWSDVAOJS(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868AFE0", VA = "0x18868BFE0")]
		private static Dictionary<Guid, YXVHLKGIDGF> UXXHPNBOLJW(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x868C2D0", Offset = "0x868B2D0", VA = "0x18868C2D0")]
		private static void YRVTTJZBVTQ(bool a, MQHFFIUQXTL b, YAFQZIRFTAA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8689330", Offset = "0x8688330", VA = "0x188689330")]
		private static void JCWHBBEKAZM(MQHFFIUQXTL a, Guid b, SpawnTransformData? c, Dictionary<Guid, YXVHLKGIDGF> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8688D70", Offset = "0x8687D70", VA = "0x188688D70")]
		private static void DBLAEXUILVJ(IEnumerable<MQHFFIUQXTL> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public SDUXUOJZYIJ circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public SZMCIIFTJBO roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public LQCPHLAGTRO circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public Id128<LNVRVOESCOU> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public ZPLAZZNSWLA globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public List<MQHFFIUQXTL> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public ZOSNUUTIUEU photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 KQQQCUNKXVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8693DD0", Offset = "0x8692DD0", VA = "0x188693DD0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS HRLISIKJRXM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8693B10", Offset = "0x8692B10", VA = "0x188693B10")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x176E5C0", Offset = "0x176D5C0", VA = "0x18176E5C0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8694280", Offset = "0x8693280", VA = "0x188694280")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8693B50", Offset = "0x8692B50", VA = "0x188693B50")]
		public static SpawnTransformData MLOZEUTFORW(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8694350", Offset = "0x8693350", VA = "0x188694350")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8694370", Offset = "0x8693370", VA = "0x188694370")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8693F70", Offset = "0x8692F70", VA = "0x188693F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8694070", Offset = "0x8693070", VA = "0x188694070")]
		public SpawnTransformData YBRYFFNXMOO(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8694000", Offset = "0x8693000", VA = "0x188694000")]
		public static SpawnTransformData UJBGWNWPGPY(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8693EE0", Offset = "0x8692EE0", VA = "0x188693EE0")]
		public readonly CircuitsRigidTransform QWJQADNIYDE()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly TBKCGNLOMPR _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1A340D0", Offset = "0x1A330D0", VA = "0x181A340D0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, TBKCGNLOMPR innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8694B00", Offset = "0x8693B00", VA = "0x188694B00")]
		public FJYIIDDGAPS WPWJODZJIUD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x86949A0", Offset = "0x86939A0", VA = "0x1886949A0")]
		public static Result<YAFQZIRFTAA, TryCloneTemplateError> New(SLHSXBHZGAZ<None> innerError)
		{
			return default(Result<YAFQZIRFTAA, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8694A50", Offset = "0x8693A50", VA = "0x188694A50")]
		public static Result<YAFQZIRFTAA, TryCloneTemplateError> New(FJYIIDDGAPS innerError)
		{
			return default(Result<YAFQZIRFTAA, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x86948E0", Offset = "0x86938E0", VA = "0x1886948E0")]
		public static Result<YAFQZIRFTAA, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<YAFQZIRFTAA, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class YKDUSEEDCND : IDisposable, ISZDMWUZHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private NativeList<CurvePointData> EHCMOYDZGHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private float FZMWSLQKYYY;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags CBGTSQAFPNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HKRQPJICDVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x86983E0", Offset = "0x86973E0", VA = "0x1886983E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DSYLAWXKJZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8698AB0", Offset = "0x8697AB0", VA = "0x188698AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> CVTGBFGEXGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int TSJVFUKEDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8698340", Offset = "0x8697340", VA = "0x188698340", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ELMUEDUBQAB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8698820", Offset = "0x8697820", VA = "0x188698820")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8698AC0", Offset = "0x8697AC0", VA = "0x188698AC0")]
		public YKDUSEEDCND(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8696730", Offset = "0x8695730", VA = "0x188696730", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8696260", Offset = "0x8695260", VA = "0x188696260")]
		public Vector3 DZNUYSXIQQE(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86986F0", Offset = "0x86976F0", VA = "0x1886986F0", Slot = "6")]
		public Quaternion SZLTBTDCHUR(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8696110", Offset = "0x8695110", VA = "0x188696110", Slot = "5")]
		public Vector3 ATXZOOJGCEI(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8698380", Offset = "0x8697380", VA = "0x188698380", Slot = "7")]
		public float PUJXXEGKNND(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8697650", Offset = "0x8696650", VA = "0x188697650")]
		public void JHUJVJYUYPB(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86989C0", Offset = "0x86979C0", VA = "0x1886989C0")]
		private bool UPWVLSPJUED(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86981E0", Offset = "0x86971E0", VA = "0x1886981E0")]
		public void MWAXYUDYZXP(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8698A20", Offset = "0x8697A20", VA = "0x188698A20")]
		public void XIWQZLJLJNO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86983F0", Offset = "0x86973F0", VA = "0x1886983F0")]
		public void RLMUHNDOPLD(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8698540", Offset = "0x8697540", VA = "0x188698540")]
		public void ROIQTSZAUGV(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8697F30", Offset = "0x8696F30", VA = "0x188697F30")]
		public void LDUDHLOKCNZ(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8698080", Offset = "0x8697080", VA = "0x188698080")]
		public void LJBYILJHOVM(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8696790", Offset = "0x8695790", VA = "0x188696790")]
		public static Quaternion GFMGRRLIJEE(Quaternion a, int b, float c, ISZDMWUZHFC d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8696FA0", Offset = "0x8695FA0", VA = "0x188696FA0")]
		public Bounds IXNXNJWRKLG(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8698960", Offset = "0x8697960", VA = "0x188698960", Slot = "10")]
		public virtual void UEEFXXXZKRC(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x86961B0", Offset = "0x86951B0", VA = "0x1886961B0")]
		public NativeList<CurvePointData> CJRBYVYLQEA(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8688AA0", Offset = "0x8687AA0", VA = "0x188688AA0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8688550", Offset = "0x8687550", VA = "0x188688550")]
		public Quaternion FIXKFVMHFBH(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86887B0", Offset = "0x86877B0", VA = "0x1886887B0")]
		public CurvePoint RAOBRMNFKEN(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8688610", Offset = "0x8687610", VA = "0x188688610")]
		public ZWKWRAGJKPO KSNFICYSFKZ(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class QXBBVZPZBEC : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8692850", Offset = "0x8691850", VA = "0x188692850", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8692BB0", Offset = "0x8691BB0", VA = "0x188692BB0")]
		private void VIGSMOKKEFD(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86928D0", Offset = "0x86918D0", VA = "0x1886928D0")]
		private void VIGSMOKKEFD(Dictionary<Guid, Guid> a, DFZXSSVXHUK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8692930", Offset = "0x8691930", VA = "0x188692930")]
		private void VIGSMOKKEFD(Dictionary<Guid, Guid> a, VYUSWULCEIT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public QXBBVZPZBEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class DORERKMOHGL : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8688CC0", Offset = "0x8687CC0", VA = "0x188688CC0", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public DORERKMOHGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class THRRGGKPKNC : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86944D0", Offset = "0x86934D0", VA = "0x1886944D0", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public THRRGGKPKNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class GTSJPUWEPJA : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x868C520", Offset = "0x868B520", VA = "0x18868C520", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public GTSJPUWEPJA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class KUYNVAHRYSI : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x868D5D0", Offset = "0x868C5D0", VA = "0x18868D5D0", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KUYNVAHRYSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class RJTZNNTHAAV : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8693190", Offset = "0x8692190", VA = "0x188693190", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public RJTZNNTHAAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DDRKZIULOEX : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8688B20", Offset = "0x8687B20", VA = "0x188688B20", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public DDRKZIULOEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class NLXBUGXTAKE : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x868D8F0", Offset = "0x868C8F0", VA = "0x18868D8F0", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public NLXBUGXTAKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class YFWUBFKUYGS : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8695F50", Offset = "0x8694F50", VA = "0x188695F50", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YFWUBFKUYGS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class GTNWXWAKFMK : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x868C360", Offset = "0x868B360", VA = "0x18868C360", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public GTNWXWAKFMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class LEZUCQRQSXE : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x868D7F0", Offset = "0x868C7F0", VA = "0x18868D7F0", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public LEZUCQRQSXE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class QVBJZABCWCR : EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public static readonly YGCXTFRAYET YDNBHZUUPBI;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8692720", Offset = "0x8691720", VA = "0x188692720", Slot = "4")]
		public void NUEGQCVAVQM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public QVBJZABCWCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public ZOSNUUTIUEU photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface EXITCILIIQJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NUEGQCVAVQM(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ZSTFGMGUHOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private static readonly EXITCILIIQJ[] TLAKBPNSLHU;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x86990D0", Offset = "0x86980D0", VA = "0x1886990D0")]
		public static void BBZVWNZGAFZ(MQHFFIUQXTL a, YAFQZIRFTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8699720", Offset = "0x8698720", VA = "0x188699720")]
		public static void JEUDVAMXMDV(MQHFFIUQXTL? data, YAFQZIRFTAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86999B0", Offset = "0x86989B0", VA = "0x1886999B0")]
		public static void OKLZFBMMYLH(MQHFFIUQXTL? data, YAFQZIRFTAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8699350", Offset = "0x8698350", VA = "0x188699350")]
		public static void FOPAFUOSSIC(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public MQHFFIUQXTL viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x868D9E0", Offset = "0x868C9E0", VA = "0x18868D9E0")]
		public Guid ULXZGXOCYJS(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface ZOSNUUTIUEU
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly HashSet<Guid> YWLTSWCXJFF;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly HashSet<Guid> QNINWMFREHP;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private static readonly HashSet<Guid> NHWNQKZRBZL;

		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private static readonly ProfilerMarker AEQRVIYOPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private readonly HashSet<string> WABPJVZJEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private readonly Dictionary<long, int> PUBXBBARSND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private readonly HashSet<Guid> LVXVOORLAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private readonly HashSet<Guid> PBVSCDJUPZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private readonly HashSet<Guid> ZRBENRKXBQN;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> JBKEQGZOZWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> ZXUFWAGULTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> QEFYOSJVYCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> YTMPGFWCJXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86905F0", Offset = "0x868F5F0", VA = "0x1886905F0")]
		public static void USPTDIUIBGZ(SpawnableTemplateData a, YWAAGZACRGT b, YAFQZIRFTAA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x868FFE0", Offset = "0x868EFE0", VA = "0x18868FFE0")]
		public static PersistedRoomDataReferences QJPVGBZXCKB(PersistedRoomData a, YWAAGZACRGT? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x868F380", Offset = "0x868E380", VA = "0x18868F380")]
		public static PersistedRoomDataReferences DSVPJYIVTFA(SpawnableTemplateData a, YWAAGZACRGT? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x868FD20", Offset = "0x868ED20", VA = "0x18868FD20")]
		public static PersistedRoomDataReferences FXUHDUPRJLS(AXHRZJQIHWM a, VESCAFWXFAI b, YWAAGZACRGT? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x868FB20", Offset = "0x868EB20", VA = "0x18868FB20")]
		public static PersistedRoomDataReferences FSKZIVNGISJ(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x86925C0", Offset = "0x86915C0", VA = "0x1886925C0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x86923F0", Offset = "0x86913F0", VA = "0x1886923F0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x868F0E0", Offset = "0x868E0E0", VA = "0x18868F0E0")]
		private void BCOYIIKBDHS(PersistedRoomData a, YWAAGZACRGT? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x868E470", Offset = "0x868D470", VA = "0x18868E470")]
		private void BCOYIIKBDHS(SpawnableTemplateData a, YWAAGZACRGT? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x868F580", Offset = "0x868E580", VA = "0x18868F580")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x868E700", Offset = "0x868D700", VA = "0x18868E700")]
		private void BCOYIIKBDHS(AXHRZJQIHWM? a, YWAAGZACRGT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x868DA90", Offset = "0x868CA90", VA = "0x18868DA90")]
		private void BCOYIIKBDHS(VESCAFWXFAI? a, YWAAGZACRGT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x868DB10", Offset = "0x868CB10", VA = "0x18868DB10")]
		private void BCOYIIKBDHS(JCJAWLSEYAQ? a, YWAAGZACRGT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x868FDE0", Offset = "0x868EDE0", VA = "0x18868FDE0")]
		private static bool QCCWQSBMAPJ(JCJAWLSEYAQ a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8690060", Offset = "0x868F060", VA = "0x188690060")]
		private static bool QLASLENTDRD(JCJAWLSEYAQ a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8690520", Offset = "0x868F520", VA = "0x188690520")]
		private static void USPTDIUIBGZ(VESCAFWXFAI? root, YWAAGZACRGT a, YAFQZIRFTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8691A90", Offset = "0x8690A90", VA = "0x188691A90")]
		private static void USPTDIUIBGZ(JCJAWLSEYAQ? customProperties, YWAAGZACRGT a, YAFQZIRFTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8691D20", Offset = "0x8690D20", VA = "0x188691D20")]
		private static void USPTDIUIBGZ(AXHRZJQIHWM? root, YWAAGZACRGT a, YAFQZIRFTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8690FF0", Offset = "0x868FFF0", VA = "0x188690FF0")]
		private static void USPTDIUIBGZ(CircuitsV2.Protobuf.CircuitNodeData? node, YWAAGZACRGT a, YAFQZIRFTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x868E0F0", Offset = "0x868D0F0", VA = "0x18868E0F0")]
		private void BCOYIIKBDHS(CircuitsV2.Protobuf.CircuitNodeData? a, YWAAGZACRGT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86902A0", Offset = "0x868F2A0", VA = "0x1886902A0")]
		private void SYBCBSAFTQA(Guid? a, YWAAGZACRGT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x868DCF0", Offset = "0x868CCF0", VA = "0x18868DCF0")]
		private void BCOYIIKBDHS(MQHFFIUQXTL? a, YWAAGZACRGT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8691640", Offset = "0x8690640", VA = "0x188691640")]
		private static void USPTDIUIBGZ(MQHFFIUQXTL? viewData, YWAAGZACRGT a, YAFQZIRFTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86904B0", Offset = "0x868F4B0", VA = "0x1886904B0")]
		private void UJSCGNTUHTD(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x868F400", Offset = "0x868E400", VA = "0x18868F400")]
		private void ENGYFGFGOAX(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x868F530", Offset = "0x868E530", VA = "0x18868F530")]
		private void ENGYFGFGOAX(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x868F4D0", Offset = "0x868E4D0", VA = "0x18868F4D0")]
		private void ENGYFGFGOAX(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class HHOTJAEZPPA : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private readonly IEnumerator<DictionaryEntry> JQZIITFQYIT;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x868C800", Offset = "0x868B800", VA = "0x18868C800", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x868C8C0", Offset = "0x868B8C0", VA = "0x18868C8C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x868C970", Offset = "0x868B970", VA = "0x18868C970", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x868C720", Offset = "0x868B720", VA = "0x18868C720", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
			public HHOTJAEZPPA(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x868C680", Offset = "0x868B680", VA = "0x18868C680", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x868C6D0", Offset = "0x868B6D0", VA = "0x18868C6D0", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			[CompilerGenerated]
			private sealed class IBPBQQGYWDK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				private int WDQRLRKBTGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058C")]
				private DictionaryEntry IGHQXRUYHSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400058D")]
				public RoomObjectCounts FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry HJMAASYCKEK
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xCD6080", Offset = "0xCD5080", VA = "0x180CD6080", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object UQAIKHVHSEP
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x868CB60", Offset = "0x868BB60", VA = "0x18868CB60", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
				[DebuggerHidden]
				public IBPBQQGYWDK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
				[DebuggerHidden]
				private void PRJHWGPKORK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x868CA60", Offset = "0x868BA60", VA = "0x18868CA60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x868CA20", Offset = "0x868BA20", VA = "0x18868CA20", Slot = "8")]
				[DebuggerHidden]
				private void HJPFLPVTXYN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection GBDQCMKKODW
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x86932D0", Offset = "0x86922D0", VA = "0x1886932D0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x8693630", Offset = "0x8692630", VA = "0x188693630", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x8693710", Offset = "0x8692710", VA = "0x188693710", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool ZJUJBBLLURR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8693930", Offset = "0x8692930", VA = "0x188693930", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool NHZGQNEYVKW
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x8693540", Offset = "0x8692540", VA = "0x188693540", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection LXJKRRBVIRM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8693820", Offset = "0x8692820", VA = "0x188693820", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int IYKAYXUITZV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8693980", Offset = "0x8692980", VA = "0x188693980", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool HUEWZOSPFTY
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x8693450", Offset = "0x8692450", VA = "0x188693450", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object UDBEJWJBPAH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x86934F0", Offset = "0x86924F0", VA = "0x1886934F0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x86938C0", Offset = "0x86928C0", VA = "0x1886938C0")]
			[IteratorStateMachine(typeof(IBPBQQGYWDK))]
			private IEnumerator<DictionaryEntry> XZAEWIONMLB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x86933B0", Offset = "0x86923B0", VA = "0x1886933B0", Slot = "19")]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8693750", Offset = "0x8692750", VA = "0x188693750", Slot = "13")]
			private IDictionaryEnumerator TOMFQBRWZAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8693590", Offset = "0x8692590", VA = "0x188693590", Slot = "9")]
			private void RVVNWVTNIML(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8693360", Offset = "0x8692360", VA = "0x188693360", Slot = "10")]
			private void JNZZPOXVNFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x86935E0", Offset = "0x86925E0", VA = "0x1886935E0", Slot = "8")]
			private bool RYWZUTYLGQR(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x86934A0", Offset = "0x86924A0", VA = "0x1886934A0", Slot = "14")]
			private void OFPFZPIKTOI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8693870", Offset = "0x8692870", VA = "0x188693870", Slot = "15")]
			private void VXKZVOGOTAM(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class KNVNSCYNXKQ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000591")]
				private int WDQRLRKBTGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000592")]
				private DictionaryEntry IGHQXRUYHSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				public Invention FOYWNDAXKGX;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry HJMAASYCKEK
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xCD6080", Offset = "0xCD5080", VA = "0x180CD6080", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object UQAIKHVHSEP
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x868D580", Offset = "0x868C580", VA = "0x18868D580", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
				[DebuggerHidden]
				public KNVNSCYNXKQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
				[DebuggerHidden]
				private void PRJHWGPKORK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x868D460", Offset = "0x868C460", VA = "0x18868D460", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x868D420", Offset = "0x868C420", VA = "0x18868D420", Slot = "8")]
				[DebuggerHidden]
				private void HJPFLPVTXYN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection GBDQCMKKODW
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x868CC80", Offset = "0x868BC80", VA = "0x18868CC80", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x868CF90", Offset = "0x868BF90", VA = "0x18868CF90", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x868D0A0", Offset = "0x868C0A0", VA = "0x18868D0A0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool ZJUJBBLLURR
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x868D2B0", Offset = "0x868C2B0", VA = "0x18868D2B0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool NHZGQNEYVKW
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x868CEA0", Offset = "0x868BEA0", VA = "0x18868CEA0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection LXJKRRBVIRM
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x868D1B0", Offset = "0x868C1B0", VA = "0x18868D1B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int IYKAYXUITZV
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x868D300", Offset = "0x868C300", VA = "0x18868D300", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool HUEWZOSPFTY
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x868CDB0", Offset = "0x868BDB0", VA = "0x18868CDB0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object UDBEJWJBPAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x868CE50", Offset = "0x868BE50", VA = "0x18868CE50", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B64950", Offset = "0x2B63950", VA = "0x182B64950")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x868D250", Offset = "0x868C250", VA = "0x18868D250")]
			[IteratorStateMachine(typeof(KNVNSCYNXKQ))]
			private IEnumerator<DictionaryEntry> XZAEWIONMLB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x868CD20", Offset = "0x868BD20", VA = "0x18868CD20", Slot = "19")]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x868D0E0", Offset = "0x868C0E0", VA = "0x18868D0E0", Slot = "13")]
			private IDictionaryEnumerator TOMFQBRWZAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x868CEF0", Offset = "0x868BEF0", VA = "0x18868CEF0", Slot = "9")]
			private void RVVNWVTNIML(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x868CCD0", Offset = "0x868BCD0", VA = "0x18868CCD0", Slot = "10")]
			private void JNZZPOXVNFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x868CF40", Offset = "0x868BF40", VA = "0x18868CF40", Slot = "8")]
			private bool RYWZUTYLGQR(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x868CE00", Offset = "0x868BE00", VA = "0x18868CE00", Slot = "14")]
			private void OFPFZPIKTOI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x868D200", Offset = "0x868C200", VA = "0x18868D200", Slot = "15")]
			private void VXKZVOGOTAM(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8694E80", Offset = "0x8693E80", VA = "0x188694E80")]
		public static UgcRoomSaveStatsDetailed QJPVGBZXCKB(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8694D60", Offset = "0x8693D60", VA = "0x188694D60")]
		[CompilerGenerated]
		internal static int FEGVBFBPZCX([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8695860", Offset = "0x8694860", VA = "0x188695860")]
		[CompilerGenerated]
		internal static void TPXOYQUYKNV(int a, [In] AXHRZJQIHWM graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class YWAAGZACRGT
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public readonly Guid YRKJPNLPYTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public readonly IReadOnlyList<Guid> ZXUFWAGULTP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public readonly UnitySubAssetKind BSZGMEOZKDB;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8695EF0", Offset = "0x8694EF0", VA = "0x188695EF0")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private readonly YAFQZIRFTAA OUOOVPOSJZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private readonly Dictionary<Guid, UnitySubAsset> ZZINYSXTJSY;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public YAFQZIRFTAA OWIYAUVEHQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8698B40", Offset = "0x8697B40", VA = "0x188698B40")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8698D40", Offset = "0x8697D40", VA = "0x188698D40")]
		public bool SMMBHYOABPS(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8698E30", Offset = "0x8697E30", VA = "0x188698E30")]
		public YWAAGZACRGT()
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
