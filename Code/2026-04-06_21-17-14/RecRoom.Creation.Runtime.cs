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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9912EC0", Offset = "0x9911EC0", VA = "0x189912EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DMFOEZTRDDT
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> EJHMSCJCZJD;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> LWDMCYHUQNH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> XFQNRNYPZWP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> HFEJANIJKRG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ESDHGLCJTEG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JRRVDLFFPWT;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string JIAAKCFIKAS;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9900460", Offset = "0x98FF460", VA = "0x189900460")]
	public static bool GPIJGDOWHYV(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9900C30", Offset = "0x98FFC30", VA = "0x189900C30")]
	public static bool XOTVNJDUVZR(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9900560", Offset = "0x98FF560", VA = "0x189900560")]
	public static string QGJNMCTPCVE(Guid a)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DisallowSerialization]
public enum SpawnableToolType
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	RANDOM_PAINTBALL_WEAPON = -2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	INVALID,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	AIR_CANNON,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	AVATAR_ITEM_DISPLAY,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WEARABLE_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
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
		[Cpp2IlInjected.Address(RVA = "0x9912E00", Offset = "0x9911E00", VA = "0x189912E00", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FKZXVDZBZDS
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid GZWTSSIQXIR;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid LGWKQZISBYA;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid NBBTPXLOTWV;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid SHZFCIGXSSD;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid ADSZBFHAZLR;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid EWABJUQIMRI;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid DYUCCMYWLMO;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid GHSSJJXILHI;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid NHYMCVBKLGT;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid PEUFNMNMLFO;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid BWARZNGWAUA;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid UHUMMAOHJCY;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid GWLEUZIAKIR;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid RCVKUVVLAGA;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid KTGDCWKHTJB;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid KGNTQXDCHEU;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid RWCPMNTFDYD;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid QYIPSMNDLSQ;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid JOVTWNBDSJM;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid QVDQRSANSFJ;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid VPRLJUUKAKM;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid FTSNQQUFSQO;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid OKUAEBGXSHR;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid RLKRNVQHNVP;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid FRWOOJUDRPX;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid WZWGXZETRSD;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid DTBSYZLEZUF;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid RROMZRSXGDV;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid URPSPIKETNQ;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid KZZPLEXKODZ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid PCIKEBLMXQI;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid ZYDTRHSSEFG;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid GHZCGJQURVX;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid XSXRGIVFOOP;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid NCAMXCLHRHQ;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid EURXWBAEVNX;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid LFXXEEOEIJK;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid PCQPOYCABHE;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid AXMHXKJPINO;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid EVUSSLCLXHI;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid EWYEXRAGTTS;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid LCYEMEUBUZW;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid YKNISJEYKEO;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid NCOUKWWICWG;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid QJHUINWYNPO;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid QRBQFXTMYOB;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid RCMKVKMHZEK;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid ETVMDHTJQDN;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid ZFPRWZGAONJ;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid GYHRRIGBKVJ;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid BZANJYTCZSW;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid XJWSXRCAHWR;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid ZRYSKNGRCUM;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid KVXPAXRCRKY;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid KBORDBSCUHV;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid ZMQFLNKEZNJ;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid WWQFOCLHTTX;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid AONMNGQBMYS;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid ODELSWHQVKU;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid BLJXKSZCJYZ;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid GVQTMTKSWKP;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid DPYKJWYMZRA;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid ZLWYHUEFBDR;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid COOHQFQWVAY;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid JODPAHKHVAU;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid EYGENMAQLTV;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid LOSZVKDLUHU;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid LHKJZQSSZHE;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid BGXBSHBEJUV;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid YUUAPBKACSV;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid WELOPBOPUDS;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid JJNRZJQIAFD;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid XWVHCGVPDRM;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid XAUZMZDVFTL;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid WPVTWQOCSGQ;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid MIDRZOKAEAC;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid MUQSSRPSLHT;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid KOQGEZZOMDJ;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid KEPQXYBBGZR;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid WMAYHJJIVXR;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid MSAHHMZMUDJ;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid CYMWJQVEKXQ;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid XSFZUDFPZSP;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid WARTSOZSXAU;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid ZYIKVRQUTLV;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid AEOJPRTZUEQ;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid QGUUNBRQJSU;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid AUYROJUGQTU;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid MEIROKZCCCZ;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid GCLTEFMKNPC;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid ILABUAFLFAQ;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid XFJDLOUPFSR;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid KGORWMHHZLT;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid SIFDCSKNNJO;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid FSMWBFXRTYM;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid PIWWDNZVYZK;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid JYYZAIACRZU;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid HBUDSBNCGIE;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid RDKQKHYHCCZ;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid LPGLBJAOUQA;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid OOEJVSOLKTO;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid ACHICQEMAHZ;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid FQKZUBKROEI;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid ATEGLXSNGCD;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid NDGIKVGGNDW;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid ATOUGLGHYYV;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid IJGDHKFWGUG;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid GRCQDCTFWVK;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid NGCXYSZTHPT;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid ILAGSHOIFRQ;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid ZBPSTZVEVRZ;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid IKPSXUANMUY;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid YPACJDJCRRD;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid IKFFDGMSTYG;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid SHFDSFHHOVR;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid VIZBGQEJTCT;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid IBCDDBLBZUS;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid PCMDGYOCPBG;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid NRBGHYPHLHB;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid GRGISMDCWEW;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid ZMSXVLSIWGC;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid LWEFUVATYYT;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid OCOVUQVOFRS;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid IYINSDDCIWI;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid DRMXJHJSRTK;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid OFOLIJXTHUY;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid NJWWJTLDINY;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid AVLJFUJIEDY;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid ZDJMCODLJZA;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid CIFPGHLZVYT;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid EHQXSAZQAWE;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid JJCVEMHYDDQ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid QJJXMDJYUMC;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid VRGEWJWAKJX;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid GVTWFAPVDMK;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid RDDAVEUYLAN;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid ZXRZLNATOUP;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid GDYLIHWUBAU;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid YBQWVHJFNFE;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid YUWJUJXBETL;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid LMSWUWGZHDV;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid TJJVEHUZLNA;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid HLVWDKAPSYY;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid RZPYSNGLZUH;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid AECHWQXAUIF;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid ZVXUEUGEGWB;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid KDVLITFHTZF;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid UJYWZAKGQPK;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid NOPTMRQFIBS;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid NPFOELXXKJT;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid NPAHHFEAAYK;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid NNZYUXINFTR;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid NNURXQOPWII;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid NOKMPKWHYQJ;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid NOFFSECKPFA;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid GDRUJDIWYIY;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid GEFOQDCPMBY;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid CNEDZEZFPIT;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid JKTMLAKIKJR;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid GJDOHJEZYYS;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid TBROOQRLQIV;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid RWHRSNSSUAX;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid YNZKDCIPEMT;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid AWFRKNXHLPS;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid UCZIJUUBDDI;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid UJHBWYHMIOH;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid EKDEGOFJXDM;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid PCMXAIEBKDX;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid WOYVVACQFQD;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid QZPPGVCHBUA;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid UHKLGSAFATP;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid WPECSGWNPBM;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid WPJJPNQKYMV;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid WNYNISHDKLK;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid KWQFOSMKLNV;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid KIEUQHNTUVG;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid PHEZDOXWGJX;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid KWVMLZGHUZE;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid XHDLDIXPSAX;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid CFKEDEROEXY;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid FSJTTJIBZMM;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid OVOULNUZQEF;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid NWHMVESJFRX;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid YMGSTFZKFRR;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid IDXKQXUPGNT;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid ABVTTHECBQT;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid DAMDFZUTAYQ;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid IFCZXTIQTKD;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid MNHVXNQYBCK;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ROIAGAKULDC;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid ZKXPRBFDRAC;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid QFMSBKWQRDC;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid MTSTBFPLGFD;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid YUSQDYFVJRV;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid UHUILHFUMFM;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid BXBWRXWQAVK;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid DAEIMLBLHTJ;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid LDZHJLSQUAE;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid AEFFEKQAZJI;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid ESRINNXBBWX;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid HRPNKZWIDJU;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid XSVAOXELIFL;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid CDPYZAJBQEJ;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid MUEQWJLCETO;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid FQHYEJQLZYN;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid TSHFYFSCKFY;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid ZGEJFTJMESQ;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid AJOOPAIFEBQ;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid BNJTQSVGIVP;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid LWOMIGAJMHO;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid IKKNZOFHWKI;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid PXNUJHCLJSP;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid RZDQNRVILUB;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid IYJFSXRFRQM;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid LSBSWDBGZQZ;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid IIRYBGBZGHK;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid MIRQAUJUPNT;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid YQBBGBOHATD;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid JXIAGOUGIBZ;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid NFJPHDLSTNZ;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid IJXZNYPQXFK;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid SJPKSDHMDSS;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid MYSFNLINNLV;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid HMKBMEIPEZG;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid RFVGSCUTNCB;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid FMHEXYFGXWX;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid UMXYHWJFJDJ;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid UACIFAMILKC;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid WVQWJREYIHE;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid VDRWHFKBRXT;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid EEKGAARFACE;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid QOTTNDLNYDV;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid RUVNVIEYTQU;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid EGUYJWNLZCM;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid HWQOPRDSOYW;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid NJQRHXBLCRG;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid BEBRTEXGTUG;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid KTPICEOCIFG;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid KQTAUFGCFKT;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid VMKBGKLKTBU;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid VIGNKBZFIKY;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid REBHRISJZGV;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid BUXNLZICNBG;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid OADMPNFSUSH;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid SOIKTUZPBKN;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid YQBIRIQQLCT;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid DJMLZYYOFEW;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid SFJAPEYTZYT;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid ZUJCIAEZZZM;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid PTGFHNXLRUW;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid CLECBRYKXUL;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid LFDJCXHAEZQ;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid FHYGQHEAAGO;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid SSDUEVXDUMO;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid MYFDCHIMFCO;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid LOCLHFCWGSM;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid LKOSOAAXEDW;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid FFWZMVRSMFT;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid CMJKHZUIYGR;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid WOEKIDOJTHM;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid FLHKOXWGOOZ;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid KOYUCALVTDS;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid JFUKUBDCOBS;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid BFTCGNJJPOB;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid ZXAEIBYQJZS;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid FQMPPTYOZZW;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid BJFLKABMYBC;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid ZXWKNPODWUG;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid OKNTUCMKDWW;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid XTYOCPUEJYG;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid KVCEDAPYBQW;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid PNPYVYHOSPN;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid WJKFACFIYXN;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid NRPFQOOJZOI;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid NORGLJQWBBJ;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid RHRCBJNXSUU;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid FAOMLFIFEPC;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid UHAMCURQHNJ;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid VPQXPUUJZYW;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid TNVACQZKPNW;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid VONFIWCKTZE;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid ETLLKBUUPTP;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid CZXEPUKGCUJ;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid FORMNUMCZCJ;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid XZUGZTQSBBW;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid WHWRRKIISCO;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid KQWOKFXUPFW;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid VPPBKQTXOTS;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid MUHDANHORSL;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid VPXOABAINSF;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid KEIJSLUXVPD;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid HQXDEMCEDYC;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid RFXOHADAVMK;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid WRBZWDRYIWT;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid LIVGCVECMUT;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid IGHMEYCHPOO;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid WXBAYKULLHW;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid ONIRHSZJBUT;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid AUDLKHGGBEU;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid JMFTGMPEXPL;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid UGMHMOFCJEO;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid MWKQQUINWFA;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid RORDGFXSXFS;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid AEXWSWRLMYD;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid KPLCWOKJPUJ;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid LRXTKQVAQLN;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid VBYVYGTVKFA;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid BGXTRRYIMTF;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid AZGTQWKIPMP;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid XBNYQKUVOSV;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid ACTYVRGGHYZ;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid SABDKJHSXWS;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid LHUFEYLHGMS;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid FSKFVAAJYXG;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid KBIDHGWWUUK;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid THQTOQABDJA;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid ZFDTPPMSFXW;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid GFVXOSCVOJN;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid RKJDCTQTPIP;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid IXLWRLCIXUM;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid ENRQCTQIGLL;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid NRPPKPKDTHR;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid LRVOHMMZVTH;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid CRXUMCGYXWY;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid YMHPRMPFLCI;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid UKSYPLRRCFF;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid SHEKGIAHHKZ;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid ENIQOWBHBTJ;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid LYBBDNUZZUT;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid KWFMLQOHPUU;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid SDSWLDPCHOC;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid OLUXEFPPLEB;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid NJTBYKQAUKH;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid RMLZOVVHYAJ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid QSJMCYVTREF;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid IUDLIXQXWZI;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid WXOVDRSVLMS;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid WIUNPUNJARY;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid DRUNLVAJFVD;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid YPQTEPBZDDH;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid BGMKJUNGTUU;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid AQQDAENWXEW;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid VTYXTDECGFJ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid WPAYEMFGOJZ;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid NMSVRWIWGIG;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid TDCRXURBAGX;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid TAXDYWBMMDR;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid LXIYCSVPMTC;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid ROBMQOPTTZF;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid HGCFQRAVQOV;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid CSGIXYAAHMW;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid CWLGPTVSUCH;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid HWWJKJVMKMY;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid FRKKJERGJGR;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid VMWWWPTGWJZ;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid QAHIQWZWSGV;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid KOTMJPRGJNF;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid APGOAUMTFCM;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid QNFTZGZSUHO;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid RHAYXCFAMJL;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid NHLFKGNGWKU;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid LAOYJWWEULE;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid QALVBMNQIIK;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid DFVRGLZTBTJ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid TPROCCNHKOW;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid RLCXRVFZYTZ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid JPMWHXAFMWG;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid VHKBNMNYTFF;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid AUSKKTFDDFP;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid ANYNWJUISIG;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid IWAAQQJMEIG;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid PEBWQPJEEYG;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid UFBTJFBFNGO;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid QZZEBTDKHBM;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid TLDMFNJPHZX;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid WPNFCWGWRFY;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid DCZORJPOJWP;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid EJQYQMEFDAQ;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid LQEIOWYFTIH;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid AHHVJVAQGPU;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid AWMYHACJDMF;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid YEXHOUHUXVQ;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid OKXEDRPWTSV;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid RSBXQDPCCDC;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid PLPARWSGGFT;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid XRDAQPBZTXV;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid ZAFABXNNSSI;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid LPVGDZPSSNX;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid QVSEGTQPWUI;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid XKASHYTBEAB;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid PVIUGGNFPGN;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid VDUNPTKLZPH;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid VEZKCAVSVNJ;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid AOKNIVRLLRA;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid SYBVOIILZEU;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid IUXPSHWNNIT;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid MZXHOMLVPTY;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid JETXOVVDDFP;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid URKUQXWXHMH;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid ASMRQIKGBPT;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid MIJAFNFNCDZ;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid ALYUEZGNCLA;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid GHOKMNGNDKF;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid PDTYFXCPBBA;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid GVMEMNULLOW;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid LCAECJPWDVR;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid BCAAYFGBIVT;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid RMWXCIGHVHM;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid LFEYHXHALIQ;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid GSRDZQZDICY;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid NEMFWEYWBEZ;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid EGRNRQIPNWK;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid RRXWRJZSKON;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid JYQLHXIWUJL;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid HQSPPVTTHMC;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid HFHVYLPJTPK;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid IMVWPMIGRQC;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid LVPOCEIKMHL;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid BFULJPJUPEI;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid WTOJHBOERJG;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid KIOBPSRDBVQ;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid NOYNWHLCVOE;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid ZNMMILRIBNY;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid BQKDPUDNEBZ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid VIPKZOELWYJ;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid MTMZVRLEAPO;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid PNEOTNXKRNG;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid MUCUNLSWCXP;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid MTXNQEYYTMG;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid MSXFDXDLYHN;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid MSRYGQJOOWE;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid MTHSYKRGREF;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid MTCMBDXJHSW;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid MSCDOWBWMOD;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid MRWWRPHZDCU;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid LQLXMWQVFWO;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid GRLOCKJMGQG;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid PIMLGZPXFCP;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid CBQWKESDYHF;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid TDLOTZRULIL;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid DSFWXYDCDAJ;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid MOPELRCQXEI;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid PVLZLZCRCNW;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid CLVWKRSQBEZ;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid HLREYGFBEMX;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid SQUHELSQYMW;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid RWZSKDZGEDW;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid MSWGQAMLIBO;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid LRIIAQBYPJF;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid KGSECYJGUKO;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid EXQZBLLEVDM;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid ENDSHPVUYHL;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid ZCQNVFPBSYZ;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid VCSDEVODJUL;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid GJDEREZQHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid VNTPVJHLTXG;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid JGXCCYUDYVR;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid JHMWUTBWBDS;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid ZUPWDAFHPFQ;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid WSRFXUDOFIH;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid SLZHAMICWQW;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid KFWEVJUQOCP;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid PERQJIOWLSP;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid FRCLGNKMGEM;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid RHSKVWXIROU;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid RJVZXRWDQTQ;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid HCCNTUXEGPA;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid UTXNQARWPWK;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid ZWDZLSGYFXZ;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid HMCPLWJJLIW;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid HDZGNXURSNE;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid DZOGXFQONYL;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid MMNVQBVNZEK;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid LJHMCKTDVPF;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid TPLJDWBCMFQ;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid GEIPISDREIC;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid CFVARGDMZRD;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid DTNRLTMVTVU;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid DVARNUVUYDE;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid NFHSHJHKAGC;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid GSPIAWQSMMA;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid KMLTKZKUFXF;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid ZVXRJABONWD;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid CCAEQBVLCQD;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid RJLYBSEJUBF;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid QAQPYYHGIYH;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid PQPRXHEFJEJ;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid JBJWDUENMOW;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid HYWHJWHHAMB;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid YTNGMIQDHDB;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid CVKDJFZEGEK;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid TXVQIUVTIGY;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid QAZTCZLQNUV;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid VJPYVBPEDGK;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid AGBMMSYRPVR;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid WWQOUZEOEEV;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid DUSRVAMSGAE;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid VPOLFTGLYLG;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid SAPCITOHSNO;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid LHDYYXKHFFG;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid BIATIIYYDLM;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid BQUZCVZRMMB;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid ANNSXVZPCBR;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid EBXKGRDRUYC;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid CFIHWOLEFSN;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid NPZEPETKUYC;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid QYOQTFZCRXN;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid IRUTTIQOKAG;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid QOJOGNGVMFF;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid KIEICQRBUXS;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid BLWNMKRTEOV;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid BGWTENYXCHL;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid QNKOHWASMEO;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid SYWSWJZGUYE;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid ACCFCHYPQGG;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid FSNMVHOYQXB;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid OGKNERSSYNY;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid HFAQPPKOQXZ;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid DQBGOPOHAUZ;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid IKEFBVXEHCM;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid TEYTCBQLVUG;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid TFDZZIKJFFP;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid OKJFZCTHEYX;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid XCRELKCGKHP;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid RZHKSNECTQW;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid KLMKYWYNDSQ;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid QPUMVYVJTQC;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid KSHORQOKDUP;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid DLAZUVPKRDY;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid IBZEWOQGCEP;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid EUVRKTPLHWC;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid KMZXVZQOHCI;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid CIAEHDNMJSB;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid IEUJQYHTWPU;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid HXHGWYORUWI;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid QPGWBWLCIXC;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid REUXGFZNHRP;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid BDAIQZPDDNX;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid BNOPUCYJWPM;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid CQJYNJSNPMQ;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid MIHEVGJKPIL;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid GAMHMINJRDN;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid PJLMCVSZOCE;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid GTWPDXSNAFU;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid NDMUTLWRPFE;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid FPPLJBWTAJY;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid UORPCGMLAQO;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid PNBDAJSQQDR;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid MGDNOZGSCJR;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid MLVNHZTWHAY;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid MJKYKPJALJH;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid KTYNAOVEBFX;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid TFPXZKDALLC;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid QYYMDHPURBP;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid VTMHYYMQXFQ;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid ZNEKICPAHYE;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid QWTSGEJDSVD;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid VWQKXGILFAP;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid JMEFTJIQQSL;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid RERCXMBXGTJ;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid DKPKTFNNQUT;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid LDSYABNKTAF;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid GUUQASKLYOO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid QQILSIPIOYX;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid UUKZIIXWBJI;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid UWNYTYSGHZW;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid EPCKQPHRYIE;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid ZSQACROOEQI;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid HBCMSQSJEAB;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid ISOWPYPNCWY;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid YYKXKAJPORV;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid USFGLZYWGGJ;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid URPLUFREDYI;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid URUSRMLBNJR;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid RZUYNOPTAQC;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid ZDFVGYWQWZI;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid ZDAOJSCTNNZ;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid KYMEJIQBJMD;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid CGXKDAEVIID;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid DPLMRIEVDYP;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid KOXZTDSAHRS;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid UEOGYDVANFD;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid GPMUIXNDRKX;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid EUHFIPNKKZS;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid YRRQKRTSHIW;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid RSPEVFPMELB;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid KRERTDZSFMH;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid MMPANAIXHVV;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid FGSFZFEZZRL;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid KSZXXXOOQTG;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid BZKGUUWOFPK;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid FCRLFNCJQXD;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid KRNRKHGUIEL;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid FLFFTTVXUFQ;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid ENEMCUOIKLN;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid SBHYYUMNWPP;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid ZUKCXQTNBLV;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid MJBSQJTKPIV;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid QGRGZYPLIPQ;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid ENIGRSFOATT;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid ZDNBUHOWKYI;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid JIQWMAEESWI;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid LURKZOMAWHU;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid IRPFTULNLXB;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid HKZRIBDOZMZ;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid YROSRJPKLBX;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid ZCMARDIONMB;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid PIGRXEZGDBZ;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid EFOQNBKVVZN;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid GABBNWIZIBZ;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid GAJNBCPSJJS;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid QYHITPIBIBP;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid XBJQNKHLFID;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid JETVCLACTWY;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid WXSHGRUSSXB;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid TORKUYEUYBF;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid PJIMJZHURJX;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid YZTRZXUTAAL;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid ZYDEUGUJKPX;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid OYBGGJKJNRT;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid WFFBFGCVFPG;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid LJSUMDLXZMT;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid QCFFDLUASCZ;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid KMAXKOEYJQT;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid NEKRZHTVFDC;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid QSAXTQNXIRE;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid BYDKOMCRTTG;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid NADNWDZDQVD;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid KWCTNYTRGYK;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid OTDSPRBPSJH;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid QFKAMVTMOGG;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid WIRMHJFXMRL;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid XZASNFDLPQR;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid XNURSWENVYX;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid UQQGAEHYCWM;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid EITEUWCZOAB;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid MRNDXPDAZLT;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid PSDBSXYAHOU;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid LPHSWTDTBRS;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid ABABVEDHOJV;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid FOEIUVSGMHE;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid YZYKOOEDFRN;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid SMFRCVKBPBE;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid HZXQQLBMXVR;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid QYQERZHREMJ;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid WQQWRTRXVOY;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid CGIKZEHHHPW;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid ICSJYDKSSDP;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid QOQRDGEHTTS;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid HCFZSBBVKHW;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid PQNBBZTOJWT;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid PFAJYMSVGHW;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid VSAPRGDVBHX;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid ZUADKDONRIL;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid YPIPBQHIWBI;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid VERWNWXWHSQ;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid JBAXOTHXSZP;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> GHGBZZYGEVL;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> DPWKHYFEOQR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> JJRRUUUWVPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99046C0", Offset = "0x99036C0", VA = "0x1899046C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> DIREDOMIONO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9904660", Offset = "0x9903660", VA = "0x189904660")]
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
	public static class QJWTKSXDBAZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9913D60", Offset = "0x9912D60", VA = "0x189913D60")]
		public static bool SCCAQWKEYVV(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9913950", Offset = "0x9912950", VA = "0x189913950")]
		private static bool SCCAQWKEYVV(LZBUEEHACUI a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface NVYYMCRTKEZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(ARECYKAOHRN data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, PSWWKHTDREX circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly FZLXAJZQSFG Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<RWNYJETRKPC> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<RWNYJETRKPC> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<YUFXTHDQAZB> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<ISSDUATOTVT>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool IVEJOHXVRBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9913D90", Offset = "0x9912D90", VA = "0x189913D90")]
		public R1CreateTemplateParams(FZLXAJZQSFG circuits, IEnumerable<RWNYJETRKPC> rootData, IReadOnlyList<RWNYJETRKPC> allPersistableData, Id32<YUFXTHDQAZB> sourceGraphId, IReadOnlyList<Id128<ISSDUATOTVT>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly FZLXAJZQSFG Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<RWNYJETRKPC> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<YUFXTHDQAZB> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<ISSDUATOTVT>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9913E00", Offset = "0x9912E00", VA = "0x189913E00")]
		public R2CreateTemplateParams(FZLXAJZQSFG circuits, Id32<YUFXTHDQAZB> sourceGraphId, IReadOnlyList<Id128<ISSDUATOTVT>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<RWNYJETRKPC> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PDYABOFUDJZ : OBGWNXMYGUZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid LXZNTMXZMKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> YALOXROULOQ;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64945E0", Offset = "0x64935E0", VA = "0x1864945E0")]
		private PDYABOFUDJZ(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9913630", Offset = "0x9912630", VA = "0x189913630")]
		public static PDYABOFUDJZ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99133C0", Offset = "0x99123C0", VA = "0x1899133C0")]
		private static Dictionary<Guid, Guid> HAXYEETNTZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9913940", Offset = "0x9912940", VA = "0x189913940")]
		public static PDYABOFUDJZ WMIVSMDBOHI(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9913030", Offset = "0x9912030", VA = "0x189913030")]
		public static PDYABOFUDJZ CEUWYRFHGFV(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99135C0", Offset = "0x99125C0", VA = "0x1899135C0")]
		public Dictionary<Guid, Guid> NXIXIUNIWNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
		public Dictionary<Guid, Guid> SKPXXCRMUQN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9912FB0", Offset = "0x9911FB0", VA = "0x189912FB0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99136C0", Offset = "0x99126C0", VA = "0x1899136C0")]
		public void VHVVPACOWIE(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9913470", Offset = "0x9912470", VA = "0x189913470")]
		public Guid JSXIRQFXXSO([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9913320", Offset = "0x9912320", VA = "0x189913320")]
		public Guid GRLNHIHQISP([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9912F40", Offset = "0x9911F40", VA = "0x189912F40")]
		public bool WSHUGJGQMJO([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9912F40", Offset = "0x9911F40", VA = "0x189912F40", Slot = "4")]
		private bool ABMJGNKFOTO([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface YXZTGOAWRYX
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OVXKXLAJIJK(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WAGYCQTJVDO(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OAGXSAPMKEL
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
	public abstract class HGOEMPVBXIH : YXZTGOAWRYX
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class UDPOEFEMMOA : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string IICGLFNMBZD
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public UDPOEFEMMOA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9913F00", Offset = "0x9912F00", VA = "0x189913F00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9913FC0", Offset = "0x9912FC0", VA = "0x189913FC0", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9913E70", Offset = "0x9912E70", VA = "0x189913E70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> EWVYKGATJSW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9913E70", Offset = "0x9912E70", VA = "0x189913E70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? EDZGPQOZCAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? HXGFOJKDNMB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> SUOCPOXGFUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9912320", Offset = "0x9911320", VA = "0x189912320")]
			[IteratorStateMachine(typeof(UDPOEFEMMOA))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? SAUDSEMPFZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool FVQCESHSBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool ZKETPEIMDFC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> MDYCUGULAOD(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool LTYGUGNICIB(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9912870", Offset = "0x9911870", VA = "0x189912870")]
		public void SPLMMDDDAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x10360F0", Offset = "0x10350F0", VA = "0x1810360F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9912500", Offset = "0x9911500", VA = "0x189912500", Slot = "4")]
		public bool OVXKXLAJIJK(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9912CA0", Offset = "0x9911CA0", VA = "0x189912CA0", Slot = "5")]
		public bool WAGYCQTJVDO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99127B0", Offset = "0x99117B0", VA = "0x1899127B0")]
		private bool RSKSIQHSXMM(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9912380", Offset = "0x9911380", VA = "0x189912380")]
		protected List<Guid> NZOMJNADRZT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected HGOEMPVBXIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class FXZEXYTOKLR
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class TNCYCEOSYMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public FZLXAJZQSFG OCHKMCDITEI;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TNCYCEOSYMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9920A90", Offset = "0x991FA90", VA = "0x189920A90")]
			internal Id32<DQODHRVSODS> HYQDUMOUTWC((Id32<YUFXTHDQAZB> GraphId, Id32<ISSDUATOTVT> NodeId) i)
			{
				return default(Id32<DQODHRVSODS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int IWFMLUWGFAQ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<DQODHRVSODS>, RJVMPVIIXIC> LLZZNXNDTEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long DWPNGJSKXSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long TMYNXFODXLN;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<DQODHRVSODS, int?> FLSVBZUEWOO;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long EAMKERNOGII;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long XBWBXJLCNTI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9904720", Offset = "0x9903720", VA = "0x189904720")]
		public static FXZEXYTOKLR HEJGQQAQZTE(FZLXAJZQSFG a, Id128<YUFXTHDQAZB> b, [Optional] FXZEXYTOKLR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9904C60", Offset = "0x9903C60", VA = "0x189904C60")]
		public static (long, long) MHGGXRHPIDC(FZLXAJZQSFG a, Id32<YUFXTHDQAZB> b, Id32<ISSDUATOTVT> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9905140", Offset = "0x9904140", VA = "0x189905140")]
		public static long VKBXPJYTIVJ([In] ReadOnlySpan<Id32<DQODHRVSODS>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9905000", Offset = "0x9904000", VA = "0x189905000")]
		private static long NAYBNHWKAWI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99122A0", Offset = "0x99112A0", VA = "0x1899122A0")]
		public FXZEXYTOKLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class RJVMPVIIXIC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xE8FE60", Offset = "0xE8EE60", VA = "0x180E8FE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long UMMEIEHJMUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xE01B00", Offset = "0xE00B00", VA = "0x180E01B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x941D240", Offset = "0x941C240", VA = "0x18941D240")]
		public RJVMPVIIXIC(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class SGLSEXNNWCC
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> EMZNBJFKNPL;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class VYZCOXWQKKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class ELVZUVEKULU : IEnumerable<RWNYJETRKPC>, IEnumerable, IEnumerator<RWNYJETRKPC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private RWNYJETRKPC NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData IRQDNDQRKWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData XRRMSEYNWKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams TUJIPYPIUCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams PVPIFOVTBZC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int AVRZTXKIQLK;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private RWNYJETRKPC UWQKLGPIQXN
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public ELVZUVEKULU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9918AE0", Offset = "0x9917AE0", VA = "0x189918AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9918D50", Offset = "0x9917D50", VA = "0x189918D50", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9918BF0", Offset = "0x9917BF0", VA = "0x189918BF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RWNYJETRKPC> SKUWSUKCAAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9918BF0", Offset = "0x9917BF0", VA = "0x189918BF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99221C0", Offset = "0x99211C0", VA = "0x1899221C0")]
		public static SpawnableTemplateData BNNDPFEHXSE([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9922350", Offset = "0x9921350", VA = "0x189922350")]
		public static SpawnableTemplateData BNNDPFEHXSE([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9924DD0", Offset = "0x9923DD0", VA = "0x189924DD0")]
		private static HashSet<Id128<WIDRWTBBIAB>> SZJAHMIXEES(IReadOnlyList<RWNYJETRKPC> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99246D0", Offset = "0x99236D0", VA = "0x1899246D0")]
		private static void OHUKLBNFGLJ(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9922C20", Offset = "0x9921C20", VA = "0x189922C20")]
		public static Result<PDYABOFUDJZ, TryCloneTemplateError> FBERIAPZZNQ(SpawnableTemplateData a, SpawnTemplateParams b, PDYABOFUDJZ? srcRemapper, bool c)
		{
			return default(Result<PDYABOFUDJZ, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99245C0", Offset = "0x99235C0", VA = "0x1899245C0")]
		[IteratorStateMachine(typeof(ELVZUVEKULU))]
		private static IEnumerable<RWNYJETRKPC> NJEKAICLORZ(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9924D60", Offset = "0x9923D60", VA = "0x189924D60")]
		private static void OURZWKAXNMI(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9925170", Offset = "0x9924170", VA = "0x189925170")]
		private static bool XXIKVDMYAMP(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9924240", Offset = "0x9923240", VA = "0x189924240")]
		private static Dictionary<Guid, LZBUEEHACUI> LMGPIXNZNCP(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9924530", Offset = "0x9923530", VA = "0x189924530")]
		private static void NAIRFTMBGDH(bool a, RWNYJETRKPC b, PDYABOFUDJZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9922990", Offset = "0x9921990", VA = "0x189922990")]
		private static void EJPHTENISMN(RWNYJETRKPC a, Guid b, SpawnTransformData? c, Dictionary<Guid, LZBUEEHACUI> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99224E0", Offset = "0x99214E0", VA = "0x1899224E0")]
		private static void EJJXAAIMKEM(IEnumerable<RWNYJETRKPC> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FZLXAJZQSFG circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public OAGXSAPMKEL roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public NVYYMCRTKEZ circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<YUFXTHDQAZB> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public OOFXQBZYQXD globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<RWNYJETRKPC> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public VGVNYLVPQQL photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 YBDCAOWIQBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x99202E0", Offset = "0x991F2E0", VA = "0x1899202E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS JITZMYAXDWB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x99204F0", Offset = "0x991F4F0", VA = "0x1899204F0")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16CD590", Offset = "0x16CC590", VA = "0x1816CD590")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9920840", Offset = "0x991F840", VA = "0x189920840")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99205C0", Offset = "0x991F5C0", VA = "0x1899205C0")]
		public static SpawnTransformData UQSRILUHBCL(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9920910", Offset = "0x991F910", VA = "0x189920910")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9920930", Offset = "0x991F930", VA = "0x189920930")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9920460", Offset = "0x991F460", VA = "0x189920460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99200D0", Offset = "0x991F0D0", VA = "0x1899200D0")]
		public SpawnTransformData NKATFLJBFWH(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99203F0", Offset = "0x991F3F0", VA = "0x1899203F0")]
		public static SpawnTransformData NZOVNYBNXIR(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9920530", Offset = "0x991F530", VA = "0x189920530")]
		public readonly CircuitsRigidTransform UNHMVPWUJBH()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private readonly YCREHOYWOHO _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19957B0", Offset = "0x19947B0", VA = "0x1819957B0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, YCREHOYWOHO innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9920B60", Offset = "0x991FB60", VA = "0x189920B60")]
		public OVKUTAZGTAB JPSUGHOWYVY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9920C90", Offset = "0x991FC90", VA = "0x189920C90")]
		public static Result<PDYABOFUDJZ, TryCloneTemplateError> New(DTAIHFDTMUY<None> innerError)
		{
			return default(Result<PDYABOFUDJZ, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9920D40", Offset = "0x991FD40", VA = "0x189920D40")]
		public static Result<PDYABOFUDJZ, TryCloneTemplateError> New(OVKUTAZGTAB innerError)
		{
			return default(Result<PDYABOFUDJZ, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9920BD0", Offset = "0x991FBD0", VA = "0x189920BD0")]
		public static Result<PDYABOFUDJZ, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<PDYABOFUDJZ, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DOLJEIVXCKY : IDisposable, GTSWNVKNLGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> XEGNUFOPEJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float YCGEWOATNZV;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags PBJVUTHFVIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FXPMQJNPCQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9918760", Offset = "0x9917760", VA = "0x189918760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QEFGKQOQYXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9918A50", Offset = "0x9917A50", VA = "0x189918A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> TGKDLOVAWIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int HGKRSMJVTKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9916480", Offset = "0x9915480", VA = "0x189916480", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float XOIYDEWSGZK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x99172A0", Offset = "0x99162A0", VA = "0x1899172A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9918A60", Offset = "0x9917A60", VA = "0x189918A60")]
		public DOLJEIVXCKY(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9916420", Offset = "0x9915420", VA = "0x189916420", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9916DD0", Offset = "0x9915DD0", VA = "0x189916DD0")]
		public Vector3 LMATYHVRSPX(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99188C0", Offset = "0x99178C0", VA = "0x1899188C0", Slot = "6")]
		public Quaternion TWZKYARKJFE(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9916620", Offset = "0x9915620", VA = "0x189916620", Slot = "5")]
		public Vector3 ITYCTUOFWQP(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99189F0", Offset = "0x99179F0", VA = "0x1899189F0", Slot = "7")]
		public float UDLVGPGZNCC(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99173E0", Offset = "0x99163E0", VA = "0x1899173E0")]
		public void OPLXHCWMRMQ(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9916D70", Offset = "0x9915D70", VA = "0x189916D70")]
		private bool JOJZBMSXMDG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99164C0", Offset = "0x99154C0", VA = "0x1899164C0")]
		public void GGIACKSFTVS(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9917D70", Offset = "0x9916D70", VA = "0x189917D70")]
		public void OWIHQANAZEL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9917E00", Offset = "0x9916E00", VA = "0x189917E00")]
		public void OXMJXLSMBTU(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9916270", Offset = "0x9915270", VA = "0x189916270")]
		public void CQRGCMLSZNY(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9918770", Offset = "0x9917770", VA = "0x189918770")]
		public void THMOBZXKEII(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x99160B0", Offset = "0x99150B0", VA = "0x1899160B0")]
		public void AFQINKDNADB(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9917F50", Offset = "0x9916F50", VA = "0x189917F50")]
		public static Quaternion STKLZHIZCBL(Quaternion a, int b, float c, GTSWNVKNLGJ d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x99166C0", Offset = "0x99156C0", VA = "0x1899166C0")]
		public Bounds JMZXTLTUCPN(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9916210", Offset = "0x9915210", VA = "0x189916210", Slot = "10")]
		public virtual void ATTFFHEKBMZ(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9917CC0", Offset = "0x9916CC0", VA = "0x189917CC0")]
		public NativeList<CurvePointData> OSJVPSDHCBR(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9915C90", Offset = "0x9914C90", VA = "0x189915C90")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9915BD0", Offset = "0x9914BD0", VA = "0x189915BD0")]
		public Quaternion VVYJWXTZIMY(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99158E0", Offset = "0x99148E0", VA = "0x1899158E0")]
		public CurvePoint TWIJWWZDIPG(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9915740", Offset = "0x9914740", VA = "0x189915740")]
		public UDWGCJFTWNB NDDQTNMSERA(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class QHKBUBCHDKZ : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x991ED50", Offset = "0x991DD50", VA = "0x18991ED50", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x991F050", Offset = "0x991E050", VA = "0x18991F050")]
		private void VHPOCIJXRNK(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x991F620", Offset = "0x991E620", VA = "0x18991F620")]
		private void VHPOCIJXRNK(Dictionary<Guid, Guid> a, TOPNAQAEUZJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x991EDD0", Offset = "0x991DDD0", VA = "0x18991EDD0")]
		private void VHPOCIJXRNK(Dictionary<Guid, Guid> a, AKVCOUJEZMM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public QHKBUBCHDKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ILVPJEVEQVS : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9919180", Offset = "0x9918180", VA = "0x189919180", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ILVPJEVEQVS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class EWTBBDTVAUV : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9918D90", Offset = "0x9917D90", VA = "0x189918D90", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EWTBBDTVAUV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class PFVTCFOCZTP : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9919EF0", Offset = "0x9918EF0", VA = "0x189919EF0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public PFVTCFOCZTP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class JRDWHTTZRHV : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x99199D0", Offset = "0x99189D0", VA = "0x1899199D0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public JRDWHTTZRHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class KOUIKXEBIMQ : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9919BF0", Offset = "0x9918BF0", VA = "0x189919BF0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KOUIKXEBIMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class BPXHGSYNMFO : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9915140", Offset = "0x9914140", VA = "0x189915140", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public BPXHGSYNMFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CQDNBIXBCUP : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x99154A0", Offset = "0x99144A0", VA = "0x1899154A0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public CQDNBIXBCUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CPYYXJEWITH : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x99152E0", Offset = "0x99142E0", VA = "0x1899152E0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public CPYYXJEWITH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class OIRWZOABIDD : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9919D30", Offset = "0x9918D30", VA = "0x189919D30", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public OIRWZOABIDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class FDCTZYMBHED : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9918EF0", Offset = "0x9917EF0", VA = "0x189918EF0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public FDCTZYMBHED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class WJBPIUHWXTI : TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly OUQOHLXHTOE TTXVPETSDLP;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x99257F0", Offset = "0x99247F0", VA = "0x1899257F0", Slot = "4")]
		public void QZCDWKLOCEX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public WJBPIUHWXTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public VGVNYLVPQQL photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface TMLCLXUSMYS
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QZCDWKLOCEX(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class BDTGFVPHWSX
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly TMLCLXUSMYS[] RRPJPONOAUZ;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9914270", Offset = "0x9913270", VA = "0x189914270")]
		public static void MCQVWJLEBJG(RWNYJETRKPC a, PDYABOFUDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x99144F0", Offset = "0x99134F0", VA = "0x1899144F0")]
		public static void PTRWHDXYNBI(RWNYJETRKPC? data, PDYABOFUDJZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9914000", Offset = "0x9913000", VA = "0x189914000")]
		public static void KSDQJUQKOVG(RWNYJETRKPC? data, PDYABOFUDJZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9914780", Offset = "0x9913780", VA = "0x189914780")]
		public static void SCCAQWKEYVV(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public RWNYJETRKPC viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x991A050", Offset = "0x9919050", VA = "0x18991A050")]
		public Guid EQWGVWKVTNL(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface VGVNYLVPQQL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> GLOYPDSVDHE;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> VDXNVLNOUGY;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> LCBDBIGNTVU;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker QBSBIYHTMQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> ZXBQJYCKGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> SLSKRNVKZOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> ZFCCXNJNWGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> BUOQOWDFYYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> PRSERSFCHXG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> SMFOSWPXDIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> JQJIZRROWLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> MKHMPPLYVBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> WYEBSPUVVYM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x991AC20", Offset = "0x9919C20", VA = "0x18991AC20")]
		public static void FSYDTMCGTUE(SpawnableTemplateData a, XPMYYZVZUYM b, PDYABOFUDJZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x991A3C0", Offset = "0x99193C0", VA = "0x18991A3C0")]
		public static PersistedRoomDataReferences DCMMBETDOZS(PersistedRoomData a, XPMYYZVZUYM? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x991E3E0", Offset = "0x991D3E0", VA = "0x18991E3E0")]
		public static PersistedRoomDataReferences NFKNBDRHMBN(SpawnableTemplateData a, XPMYYZVZUYM? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x991A100", Offset = "0x9919100", VA = "0x18991A100")]
		public static PersistedRoomDataReferences CCCMWGEQKNV(FZCUOOHXFZF a, MLDULGZVPWF b, XPMYYZVZUYM? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x991A1C0", Offset = "0x99191C0", VA = "0x18991A1C0")]
		public static PersistedRoomDataReferences CVFDXTAUTFC(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x991EBF0", Offset = "0x991DBF0", VA = "0x18991EBF0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x991EA20", Offset = "0x991DA20", VA = "0x18991EA20")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x991CCF0", Offset = "0x991BCF0", VA = "0x18991CCF0")]
		private void GQVSDIHXOSF(PersistedRoomData a, XPMYYZVZUYM? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x991CF90", Offset = "0x991BF90", VA = "0x18991CF90")]
		private void GQVSDIHXOSF(SpawnableTemplateData a, XPMYYZVZUYM? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x991A680", Offset = "0x9919680", VA = "0x18991A680")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x991D400", Offset = "0x991C400", VA = "0x18991D400")]
		private void GQVSDIHXOSF(FZCUOOHXFZF? a, XPMYYZVZUYM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x991CC70", Offset = "0x991BC70", VA = "0x18991CC70")]
		private void GQVSDIHXOSF(MLDULGZVPWF? a, XPMYYZVZUYM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x991D220", Offset = "0x991C220", VA = "0x18991D220")]
		private void GQVSDIHXOSF(OHBMHMZYDUN? a, XPMYYZVZUYM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x991E4D0", Offset = "0x991D4D0", VA = "0x18991E4D0")]
		private static bool ZWAJEHNFWCS(OHBMHMZYDUN a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x991A440", Offset = "0x9919440", VA = "0x18991A440")]
		private static bool EOWMPONCDVM(OHBMHMZYDUN a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x991B600", Offset = "0x991A600", VA = "0x18991B600")]
		private static void FSYDTMCGTUE(MLDULGZVPWF? root, XPMYYZVZUYM a, PDYABOFUDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x991BB20", Offset = "0x991AB20", VA = "0x18991BB20")]
		private static void FSYDTMCGTUE(OHBMHMZYDUN? customProperties, XPMYYZVZUYM a, PDYABOFUDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x991C400", Offset = "0x991B400", VA = "0x18991C400")]
		private static void FSYDTMCGTUE(FZCUOOHXFZF? root, XPMYYZVZUYM a, PDYABOFUDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x991BDB0", Offset = "0x991ADB0", VA = "0x18991BDB0")]
		private static void FSYDTMCGTUE(CircuitsV2.Protobuf.CircuitNodeData? node, XPMYYZVZUYM a, PDYABOFUDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x991C8F0", Offset = "0x991B8F0", VA = "0x18991C8F0")]
		private void GQVSDIHXOSF(CircuitsV2.Protobuf.CircuitNodeData? a, XPMYYZVZUYM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x991E1D0", Offset = "0x991D1D0", VA = "0x18991E1D0")]
		private void ITLEDQFAMWF(Guid? a, XPMYYZVZUYM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x991DDD0", Offset = "0x991CDD0", VA = "0x18991DDD0")]
		private void GQVSDIHXOSF(RWNYJETRKPC? a, XPMYYZVZUYM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x991B6D0", Offset = "0x991A6D0", VA = "0x18991B6D0")]
		private static void FSYDTMCGTUE(RWNYJETRKPC? viewData, XPMYYZVZUYM a, PDYABOFUDJZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x991E460", Offset = "0x991D460", VA = "0x18991E460")]
		private void QDVEZXZCPCM(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x991C7C0", Offset = "0x991B7C0", VA = "0x18991C7C0")]
		private void GKCIFOMUAGU(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x991C770", Offset = "0x991B770", VA = "0x18991C770")]
		private void GKCIFOMUAGU(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x991C890", Offset = "0x991B890", VA = "0x18991C890")]
		private void GKCIFOMUAGU(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class DHJEKHFMOHN : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> WZLJUKUDVXG;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x9915E90", Offset = "0x9914E90", VA = "0x189915E90", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x9915F50", Offset = "0x9914F50", VA = "0x189915F50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x9916000", Offset = "0x9915000", VA = "0x189916000", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x9915DB0", Offset = "0x9914DB0", VA = "0x189915DB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
			public DHJEKHFMOHN(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9915D10", Offset = "0x9914D10", VA = "0x189915D10", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9915D60", Offset = "0x9914D60", VA = "0x189915D60", Slot = "9")]
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
			private sealed class GZCWCIRCTNT : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int KVXTPCCUFNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry NNNUNWANACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry OJLQKMPRHCB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object BVCEDTADISM
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x9918FF0", Offset = "0x9917FF0", VA = "0x189918FF0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public GZCWCIRCTNT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
				[DebuggerHidden]
				private void OHWWSGWCEEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x9919040", Offset = "0x9918040", VA = "0x189919040", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x9919140", Offset = "0x9918140", VA = "0x189919140", Slot = "8")]
				[DebuggerHidden]
				private void UCVOSCIFQDQ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection LMMUHDUMZUZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x991F930", Offset = "0x991E930", VA = "0x18991F930", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x991FA10", Offset = "0x991EA10", VA = "0x18991FA10", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x991FAF0", Offset = "0x991EAF0", VA = "0x18991FAF0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool YCNKFZQTHJS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x991F840", Offset = "0x991E840", VA = "0x18991F840", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool ALAEEBTZRZJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x991F6D0", Offset = "0x991E6D0", VA = "0x18991F6D0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection WNUALDGIUPN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x991FC40", Offset = "0x991EC40", VA = "0x18991FC40", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int GDCAAUQNZLO
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x991FBA0", Offset = "0x991EBA0", VA = "0x18991FBA0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool HMHWZHBOIXZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x991FBF0", Offset = "0x991EBF0", VA = "0x18991FBF0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object QXJPCOMEZAG
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x991FC90", Offset = "0x991EC90", VA = "0x18991FC90", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x991FB30", Offset = "0x991EB30", VA = "0x18991FB30")]
			[IteratorStateMachine(typeof(GZCWCIRCTNT))]
			private IEnumerator<DictionaryEntry> UTNTKAZQIWU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x991FCE0", Offset = "0x991ECE0", VA = "0x18991FCE0", Slot = "19")]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x991F720", Offset = "0x991E720", VA = "0x18991F720", Slot = "13")]
			private IDictionaryEnumerator FFZQTHTHZYV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x991F9C0", Offset = "0x991E9C0", VA = "0x18991F9C0", Slot = "9")]
			private void QBSANLQLFQQ(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x991F7F0", Offset = "0x991E7F0", VA = "0x18991F7F0", Slot = "10")]
			private void GMPSZIVSMBQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x991F890", Offset = "0x991E890", VA = "0x18991F890", Slot = "8")]
			private bool IMHCZTRRNMM(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x991F8E0", Offset = "0x991E8E0", VA = "0x18991F8E0", Slot = "14")]
			private void MWALQCDBQTP(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x991F680", Offset = "0x991E680", VA = "0x18991F680", Slot = "15")]
			private void CYNZUYRXFOZ(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class CUSJYTMQQTV : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int KVXTPCCUFNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry NNNUNWANACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention NJJCUEUTHZM;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry OJLQKMPRHCB
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object BVCEDTADISM
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x9915590", Offset = "0x9914590", VA = "0x189915590", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public CUSJYTMQQTV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
				[DebuggerHidden]
				private void OHWWSGWCEEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x99155E0", Offset = "0x99145E0", VA = "0x1899155E0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x9915700", Offset = "0x9914700", VA = "0x189915700", Slot = "8")]
				[DebuggerHidden]
				private void UCVOSCIFQDQ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection LMMUHDUMZUZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x99194E0", Offset = "0x99184E0", VA = "0x1899194E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x9919580", Offset = "0x9918580", VA = "0x189919580", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x9919690", Offset = "0x9918690", VA = "0x189919690", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool YCNKFZQTHJS
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x99193F0", Offset = "0x99183F0", VA = "0x1899193F0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool ALAEEBTZRZJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x9919280", Offset = "0x9918280", VA = "0x189919280", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection WNUALDGIUPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x99197D0", Offset = "0x99187D0", VA = "0x1899197D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int GDCAAUQNZLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x9919730", Offset = "0x9918730", VA = "0x189919730", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool HMHWZHBOIXZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x9919780", Offset = "0x9918780", VA = "0x189919780", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object QXJPCOMEZAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x9919820", Offset = "0x9918820", VA = "0x189919820", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B67E80", Offset = "0x2B66E80", VA = "0x182B67E80")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x99196D0", Offset = "0x99186D0", VA = "0x1899196D0")]
			[IteratorStateMachine(typeof(CUSJYTMQQTV))]
			private IEnumerator<DictionaryEntry> UTNTKAZQIWU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9919870", Offset = "0x9918870", VA = "0x189919870", Slot = "19")]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x99192D0", Offset = "0x99182D0", VA = "0x1899192D0", Slot = "13")]
			private IDictionaryEnumerator FFZQTHTHZYV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9919530", Offset = "0x9918530", VA = "0x189919530", Slot = "9")]
			private void QBSANLQLFQQ(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x99193A0", Offset = "0x99183A0", VA = "0x1899193A0", Slot = "10")]
			private void GMPSZIVSMBQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9919440", Offset = "0x9918440", VA = "0x189919440", Slot = "8")]
			private bool IMHCZTRRNMM(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9919490", Offset = "0x9918490", VA = "0x189919490", Slot = "14")]
			private void MWALQCDBQTP(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9919230", Offset = "0x9918230", VA = "0x189919230", Slot = "15")]
			private void CYNZUYRXFOZ(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9921670", Offset = "0x9920670", VA = "0x189921670")]
		public static UgcRoomSaveStatsDetailed DCMMBETDOZS(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9922040", Offset = "0x9921040", VA = "0x189922040")]
		[CompilerGenerated]
		internal static int ZIKQCAWALWC([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9920FE0", Offset = "0x991FFE0", VA = "0x189920FE0")]
		[CompilerGenerated]
		internal static void AQBGDUTTEIC(int a, [In] FZCUOOHXFZF graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class XPMYYZVZUYM
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid EZQLAUPOEPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> JQJIZRROWLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind BWQZNOWSFXG;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9922160", Offset = "0x9921160", VA = "0x189922160")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly PDYABOFUDJZ MAMCGJLHOZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> KWIIGWUGYHF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public PDYABOFUDJZ VRJCHFMVEZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9925920", Offset = "0x9924920", VA = "0x189925920")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9925B20", Offset = "0x9924B20", VA = "0x189925B20")]
		public bool KFWIPLJZMMN(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9925C10", Offset = "0x9924C10", VA = "0x189925C10")]
		public XPMYYZVZUYM()
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
