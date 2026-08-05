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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97AD290", Offset = "0x97ABC90", VA = "0x1897AD290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class YQQTMBYCUUF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> CKQNDJXOFQF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JUDORWWSAYR;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> TKOEOOJNCOD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> KNDUFLNARFC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string QVBZGESENNE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DXMHJUSYBFF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string DKBNESYJGFQ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x97BB810", Offset = "0x97BA210", VA = "0x1897BB810")]
	public static bool WDWIMXZEGKN(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x97BB0B0", Offset = "0x97B9AB0", VA = "0x1897BB0B0")]
	public static bool JFABRCYETZB(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x97BB140", Offset = "0x97B9B40", VA = "0x1897BB140")]
	public static string SGVTECQGSSC(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x97AD1D0", Offset = "0x97ABBD0", VA = "0x1897AD1D0", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class UZCLSTPDYRC
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid MUSFEJCSOVL;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid QDRRMPUAHUI;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid SNSGUZMZGCR;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid JWRTAFUNEOL;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid DRDQSIZZUTV;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid OOXJVZDOJYG;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid UPVJTFOUAMS;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid LCTIZJYOZJE;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid CZODMSTKPRN;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid WLLJZWMVGRK;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid OBLPYHHVCUY;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid EFUNSFAYFHG;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid EUADILHZNZL;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid LFCOMDXYLPK;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid MHEGBFOEZWH;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid KKIRYFTWEFO;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid IYJXOETKRBB;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid GIROSOKCUJW;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid GGTMQVJLKNM;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid VDGTCKCAWCX;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid DPDYSQWGEMA;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid JAKTFAJIEWK;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid UIIXGFUCZBB;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid RMZTOVVVLTD;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid GAHZIRBRHNL;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid EKAFWOTWTDB;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid PERUQHURMLT;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid XQAAUFIHAAD;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid FUSMQMSJMAO;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid LSFMXSYTWDZ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid IBGAHFXTIMM;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid LWJJCWNENJS;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid QDBPOPYOGJT;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid JXKYHBOZIVZ;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid XTLXNOVFPNU;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid AWQXVJYFPQB;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid XANAHNUVDDK;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid LWPZIYAJDCO;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid SSLYHBYKRYM;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid KKAFVLMNUFA;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid TIWBOBDQSKY;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid HGRSBDQMJEE;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid LJRUPMBBNCG;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid AXSNRGOSRGC;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid BCZDMPWDDSY;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid MSLCUPUWSBD;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid WLCDAYEHAJU;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid OWECWOCQNVF;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid HISCFRXKTGT;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid QCRFIPORKQT;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid KKCHIBHTXQC;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid MDINWNMCNEV;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid BWLOYVHTYRK;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid SPMZSXZRFKI;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid KBEBWHCUDFV;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid URATWAYFCBN;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid LNUMFVITFBL;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid AWGGNIKVNNU;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid ZCQCWOVPRAI;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid AILOAUEXYCZ;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid PSFPNQUGAQT;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid ZGMEVBHYEQG;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid FVEPIOBMUWX;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid ACMPPYARVPC;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid VZJBXFVWJNS;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid VBLXYAIJCDZ;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid YTYWPTSNBFM;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid NAZFVXWKBAS;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid PWLHFWHDZRD;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid MKEJRCHTACN;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid VLOIYMYASVW;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid UPYZLETWAKZ;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid WPGEQPSJKQS;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid TDXVVZAXHER;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid FQXJBSRLOFK;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid GZUQLYUOGEK;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid UHUYKYPKSWZ;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid IYNECXXHLKH;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid NEQTKAFBNQX;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid TMQQUQSSJWT;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid ZDFEKOJZFCP;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid JQCIXXKJSQW;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid IIUADZFLBCH;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid MYPDUJCNSSU;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid XZPDPVRQXJB;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid YJIWGQXVKYY;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid DMXMBVISWAM;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid VYPXIOGTSOO;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid GUGIEGDKXRH;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid VUCMBSKYAIU;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid TEHSPSKBDJG;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid QGRWYWAWMXD;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid VCTZHYMOLVX;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid QERJFMDJIYE;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid LRYWULSWXXW;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid BKWYMQDCRPK;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid DCJZKHBMOZI;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid UYUSNKWKQCA;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid IFAZFNVAJOF;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid RAWAYQFRIMI;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid BQBEFJYXNGM;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid LAHOXOQCQHR;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid OVRHNGDEDXG;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid PMLXTDXLDZR;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid CPCXTABMHOI;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid PMWLNRLFWWJ;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid PSTQEMGHFJI;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid UQYVNJLWYVS;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid WVETTUMQJOF;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid IBJMYBDXLWW;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid ZKKQDSPAIBV;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid IAYZDNQCTAE;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid UEZCNKGUFAV;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid IDURREIRVDA;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid PGEMIFFEGBJ;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid PPKFRZLRCWH;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid AGMAOKVCFMC;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid AGTZFQNSCMU;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid WVCHKHQDEVJ;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid WLEZRXAIJQK;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid PEIVXBDVAWK;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid SENFSHOBPLR;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid XTAHXCZTIRW;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid KWFMGKYMLOE;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid IARSAGGHDHK;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid QNICRLNEINK;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid KMMPKECKYJA;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid PSOJMASUUOS;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid ZCCWXPGNQKS;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid XJFVUPWAVRJ;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid EAXJCWIRDLG;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid UFAVZYPDGDE;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid DUAZPUCBXLQ;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid YGBDKXFGQYB;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid YNHRSLHJPOO;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid BBRMCIKFZDH;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid NHWGVEXRDOP;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid RITBBYNOYBG;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid UAJUFCCKXBE;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid FZDTLIMRIQR;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid IZMXQYYDIWL;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid QPYVBXXKVRQ;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid YKWUZNCESVG;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid IIYHQLDKQHN;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid FBKYEXUKZON;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid OVMIKUFORAJ;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid XXSXOOARYVB;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid DRFTAXYVFPG;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid HZVAADQEKVC;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid IAKURXXWNDD;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid IAFNURDZDRU;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid HZFFIJIMINB;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid HYZYLCOOZBS;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid HZPTCWWHBJT;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid HZKMFQCJRYK;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid VNHAYYRGLNC;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid REQQEOFGUGG;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid VZYSWZOMMJV;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid VGHVFCCEWDV;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid YUSLVYJACZA;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid MFIHSRDIDIJ;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid BQQISETXXMT;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid VMVSDIXUHWD;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid PYZXSLFJHDC;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid YZDIDGKIAWW;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid XQVFNGJQQBR;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid HQBDVLBHRUS;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid RKSPQRXMPEJ;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid CYNZQDWMYHZ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid WWHIZOMHTPS;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid GIUGXHGMMVL;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid CYTGNKQKHTI;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid CYYNKRKHRER;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid CXNRDWBADDG;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid NAERUUFRJIP;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid DORUXBUIIVW;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid FCKFLFMGHHP;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid NAJYSAZOSTY;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid UMDRODOKJPF;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid BSPIQKIIVGG;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid DPXMISDNWUQ;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid VVBWNZHOUIN;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid BRTKCNDMKWR;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid FBZICEWGYDZ;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid ZALBGBWTNTT;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid JQKHEDDUNTN;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid CGJPTXEHOGE;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid XPFHNVFTRHZ;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid ETILSZSCOFA;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid BMQJZFVJMKY;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid CEZVQAJKNAS;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid DOJMHHJIWWY;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid WJUJMDIMXUJ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid NPXJRZZCEID;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid RXSXPEHBVNY;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid VOOXPYSBIAM;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid PSFZFFGVAPF;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid WGIDNRSEXOE;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid SMOKZLVWXJI;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid TUIUTNDOEVF;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid XVGPVLWAUWG;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid QKOTRXISNKF;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid ZFNPAELVKMJ;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid AASHIJWNPLC;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid DEUHCLUUKAJ;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid GPEVFIVHEBI;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid ARHSVJYOQBS;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid TNBFFIWGOOG;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid PYISQBDMYTL;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid UPDRQSIMRJW;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid SBTELFXPUVK;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid OBUTSXHDLTF;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid GOUNKQMRNEJ;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid RVAFQLXPWGU;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid ZHKVUKCFXQR;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid RKZCXWFNKNW;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid DVECYUMSBKB;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid XAONPNIGCXT;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid LMIZHKTFKPF;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid MEEYANTSUPJ;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid XQDHUIXCNKY;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid QODTLRMIZPQ;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid VNNEVDTPNZB;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid BGKJRJXNAPC;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid DLHHFBZSVAV;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid XXDWRVFTFBR;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid RKCCXSYLVGD;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid TVPMEJHPHRM;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid UYUSCWRHIFY;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid BGBQKBZUZUB;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid JYFIGYQNEZW;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid YPGNJCJHAXV;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid VNJQIVPGHBC;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid IZBGONTSZNO;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid MXJNMJFCUVE;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid NHTRXYYXWMA;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid IHDCPADZUBA;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid QVJSKPBAKMA;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid FSRCKISMAGH;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid EVBDFTCGAOG;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid VRYENXTPDWM;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid NNQQROVIHKF;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid LTMTMALDIDG;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid HCAELVUZZQH;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid HNUVTOTQFYR;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid XXWGYBFHPFV;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid QZTYGEXQYFI;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid PVOANHVSLCH;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid VQXZKOXOURQ;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid XVWYHECSAEK;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid MDQSSXTTLWH;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid PCMTHDZPMVI;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid RLUNFAGAGES;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid NROCQZPTVDM;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid UFBVMSFUDOW;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid UPZBYMUFRVS;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid WAIKPHAXZHC;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid DAXZLOAXONL;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid MWCWTCIRGRL;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid CPQZTNMZGXY;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid EMQQYLEPBQJ;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid EDESZOFDBDC;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid IOIQFYFIDLS;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid QUDCOZLGYSV;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid TEUFLXPPZRS;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid EKYGDRTJDHC;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid IIWVXBNMHLK;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid EHKVXQCTVSG;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid YKOPBXKMPCW;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid TKGEGLRIANA;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid PRMQWEKZZVE;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid MJTLPMLKWKX;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid JEAABYGZHOL;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid AGDMETWCPOA;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid MICIDCTEBHF;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid NBKBPYTWIIU;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid IALOEDSFPVC;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid UKCFIYVXLTN;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid DJWUVZERYDU;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid OJMKFUNRQCA;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid FGPUAEEGKBQ;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid GMPBWPCGMBX;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid MGUSYWJXWMZ;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid KPPLCCNGHZD;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid SVVTZSXYFOM;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid YURAKVFJEXU;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid NUPUIKYIDKM;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid IQMMNTLQXPG;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid YHAPFATIOEL;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid PMPVSVFLZSV;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid AEIFTPEMNXD;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid HURPYYPHNOO;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid FMZZKUBGKHQ;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid KGWEPTRSRBJ;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid QMZVOQOGIYT;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid MSSCQPMABEK;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid LZZZKYIOTQM;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid WCIGUOMXPSX;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid SCPGRVGCKUY;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid GRCMDLNRJUR;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid YTDGTVRRQBA;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid PCNMHZDQPTA;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid CHZTTJHHKEQ;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid UOQDAJFTKFR;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid LXJEPKWDVPL;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid STRUZKNKJWT;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid CCZYQXGGCTU;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid QFRHRWTKKFB;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid FYLCGSASJZN;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid VFFWKEFPXGB;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid VWSKBUSKABT;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid VNRKGBMLZZM;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid XERMJIHDPXI;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid QKIZFRINYBK;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid GAZBXDCVQVQ;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid OSRFGSXJTUK;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid SYKKHQYCVWY;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid LGCZRNVOZKX;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid NIBXKVHVUGH;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid UDADSKBUHGA;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid HXQWBDSREEZ;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid FRLCVAQJZLZ;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid RRPEGRLRIOV;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid WRUSKNGARZK;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid JXOOOEPPPCA;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid WVNGCGUVUTJ;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid HCKKGLMDCVH;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid XEGSDHTZZZV;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid YLAZMGDRAHR;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid NOSSPSKWOQA;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid EDYOSGFJMRQ;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid TQUAWYEKPJP;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid WKZCBCBANSL;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid XFXSJYHEQPD;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid SPLNVLMBFFD;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid WRQKZYDQFXQ;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid JQZTNKAXDOW;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid ZLESKZHWWIK;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid OMKFFAEMCYB;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid FTPYLGTSUWV;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid TUTUVEDEGDK;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid DCNDXSTFMAK;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid PPTPYTAUGLF;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid PABQCTEODPB;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid RHOBLNTNEHI;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid RNRTIELLJJN;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid ISRYVMILUWT;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid PBAREZJAIIA;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid AKYHUSHHMBZ;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid VVKGDJDWZTP;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid OQZAWVTVABQ;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid PIVBEKRFVIX;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid ZZFTOFDNYEA;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid YLDVTMHXVSJ;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid QRKWSRYLFEP;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid LDKZHFCHVJL;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid BMWWDFOUHNF;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid YOBZKGAGJJW;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid NSCTXTOEDXK;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid XNRLGLSCNCF;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid INHZOUXUGIA;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid JXISHGZMXMW;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid GQNCOXZTVSC;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid YWTWYBWIGRZ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid KECOARILJLQ;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid WHERARCUZHN;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid XHKKZNZMCXU;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid PKIWVZIMYLN;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid DBZZJEJHZMJ;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid DILAWPFIXMS;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid PIOOQQYCESK;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid OSHHDGATPLM;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid ZJROBOMCAXI;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid MZMIKLBPPNE;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid XIWHXZLSYBD;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid ISDTEJLJHZI;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid ISICVSCKZDF;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid NKSQVJFVIGY;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid NAIXFJGYHDJ;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid JMPVYRAQVFU;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid AXHQLNUVWSV;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid XNAPOKUUWNM;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid YUMJVNJAJON;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid EHJTTSDMNJS;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid DPGHKDLIIVT;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid VRVSXCHWYCT;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid WFJWLMCQIFS;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid XKAJZKRWHKJ;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid DSBEOTJBODK;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid HFPMBQJLMFX;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid IWNFXQRYOXX;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid KEHGHNUHUMR;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid UGTDDUKTTML;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid SNTCMUKRZRA;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid PHPZJFUXOWE;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid VGXDQOKRCNF;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid TFBVEBWXVAW;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid STRAMZMTCTP;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid RHTQPLSVPSD;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid UHRVIHZKOIN;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid YTPLKPSPTYL;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid DZIEHSOHHDU;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid YULDOGXVSQF;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid CVPHBDNAVBA;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid KYTTSRJRRDE;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid ZBHAQIFPWQH;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid UONSRBHYMLH;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid RCCICERYKZE;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid QLXMAOBVPVO;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid DPEPCCOFXYY;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid VFIIQIBCZIJ;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid JIDTGBFHFFM;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid UQYMIVRFFMF;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid ATZTQNHYUCJ;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid SSWILXYRLTE;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid XTMJDCMDJOU;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid MEJVAEYDRWG;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid YXIRFQEOEYJ;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid UMLSFMSLHJW;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid NLJZEDYSRLK;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid JYOVJXGPWNE;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid JHCHHRBAIHG;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid TLIWTRVSMRM;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid MCWIWOMPUPF;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid NOXDYCRHKMJ;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid QXIJWRYDTPS;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid RCRFDSWZLGU;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid QXYEOMFVVXT;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid QXSXRFLYMMK;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid QWSPEXQLRHR;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid QWNIHQWOHWI;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid QXDCZLEGKEJ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid QWXWCEKJATA;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid QZDTYAVGANV;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid QYYNAUBIRCM;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid UIUVWQEJFRI;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid JFRZBKKPHIS;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid CGDDFYPJZCX;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid UFYDJJVLLEP;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid GVJPKAQOBYL;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid FAABMIXRZWF;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid JOKQAEZDBMA;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid WLBZIPSGUQQ;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid TUCJCZEXHAJ;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid LVGVVJCIIMH;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid IUKTNGKXOHA;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid NTFGVGTYWAU;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid ZEBGFEQPPDW;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid HHONQWTOAXN;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid TTTBIYKWTEW;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid TZHNPSNBDVQ;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid OIUTRAPWLPX;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid KYLNYSGSZBT;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid GELFQWANFYL;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid WXBBYZTZIPV;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid HUBICTTKKLC;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid WBUYBEYVRBN;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid WCKSSZGNTJO;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid WZQFNYJJODQ;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid GIWHUXVJHZV;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid NYWOIHZUQTI;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid VBCTHJDRTIP;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid YPOGZTAUVWX;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid LKFMLEPMUEM;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid PDSRYZZQPZW;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid ORJGLDUGAYO;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid ATYGUIYAWJE;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid ZDRYXRVFJTQ;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid YHYCEJBDOVZ;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid UWHLGMSKDEO;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid WVNCGIRZALY;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid JFMCNDOCEVF;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid NXDEAUGSXKG;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid AUGDUXMEKUP;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid NEFNIVLITKK;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid RBZJXLUYIZY;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid GTSBIEBQUCF;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid LURORXYOXPA;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid YRZOKYMYBCS;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid GTCZBXZUHHU;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid TQGKAZEBDXG;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid TUMRGFERMFN;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid FCCSOKNXQYD;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid QTQXKQSGTVN;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid WFFOLIVSIWT;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid DIZEPFHERKH;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid FNIJQKULUPX;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid RTRVAFSNVIW;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid PSUJJKTGYPD;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid PDQBQCQCIMD;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid UXIWJHRYCWO;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid EOWZRVDRFIY;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid UBJIKZLISTT;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid GNYJFZCFWES;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid ANTRQWASITR;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid OISLFCYAUPP;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid VSEOQZVBJSE;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid MOHSUNFNQPG;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid VIWQDNFYKTS;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid WMAURSLQKDG;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid TKFWWLFWNSW;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid SYRDJIFOSIB;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid XTTMFSHFAZB;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid UCUIERFQSFI;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid HWIPNTSBZBX;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid CRESJSPOEXU;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid MYYUGGLOYKL;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid AGLWMQERRKG;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid MNMTKKCSRHN;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid TZWJKJTOFOI;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid YMJJQMJWSNX;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid ZDGCFBSDCIZ;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid PPQKLXIMNIK;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid NNBQSPZXAZK;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid VXVKJFMYXXQ;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid DFWHSIXKCLZ;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid MSKWPKBESYK;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid XPFHIWZWQOL;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid OJGNOOPYJNL;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid WTKBQTGGLHS;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid GHUENINTYEC;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid GHZLKPHRHPL;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid DEELVRJZKFF;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid PTDFOIXCKMV;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid HZFHQWVBTBM;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid CLWEWSOFLBS;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid WNKGMMHSEQO;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid XKUETVDCMSX;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid WWUOUSRTWPM;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid HECYCVFYKZF;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid ITLACCIZVRE;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid GUYTJFZIVJC;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid GTWKUOBRLDP;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid MPDFYUQKGBQ;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid MKOXSTEFXEY;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid WACYVLRTVVC;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid VIIXFAUOYSR;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid BZPEEGEKXHT;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid QNBEDUNQPUW;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid XTSZFTIAMFS;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid IPUNOLAUAGD;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid HAYWCUUJUCD;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid QCCEHREARZS;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid YKAXIQYXLTU;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid NYAVFYUKPEO;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid DLTNHYSVUMS;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid HHOLDVQLPSG;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid AHYQCDKMFDF;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid YADHYZBCMRB;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid GHPTNVRXIBK;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid WWPIGURZEYN;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid QLTXWYFVLBH;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid EFZLXXPGFDS;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid SOXFTGBUIOZ;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid HNDWUDRQQAG;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid ROLOYPMNCYI;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid CFAYBIYFLUB;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid SVOYTZCONRV;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid LZJVLNKYGPJ;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid FHCJOETLLMT;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid YDOIHFECAZB;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid EAIGXPQUCIR;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid VLYRXGTJTMO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid WMQLUFAQYHB;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid SRPINHLXMDI;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid FUAIQWMYPVW;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid HMWZOVPKIAU;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid UPLCHFPYOYI;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid SQROKTWVDCJ;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid DLAHTPHUNYY;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid IAJTVYPPFKX;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid QAMCMUMQZZH;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid PZWHVAEYXRG;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid QABOSGYWHCP;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid QHKQACGPLLQ;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid SLMKQETAQLU;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid SLHDSXZDHAL;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid JLKLJQEEOAX;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid GMRTQMXBMFJ;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid TRNBOTSHSBR;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid GUEPJXHJYXC;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid LMFLKTTMPNT;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid HWPDAZNYXQT;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid SHZZAKELGWQ;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid CPZUUQOLTQW;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid QMZBDZGTCDZ;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid ZKWGZXIMVEP;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid AGVHYRYQDTZ;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid FKSVUXJPVXH;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid GXSPJWFXFZW;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid LXQSXVEZTUQ;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid TYWOXIJKVVD;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid KSEFHADKOLF;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid YUCPPQUYPIW;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid ASHZIXZWZYH;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid BTZDCAUNIIF;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid QBLQRNIVAPZ;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid OCCJDYMZTFT;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid TDHRZFZGPLM;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid SFKCWVHSBSR;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid PZNGTBHUDMU;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid MJGENXGVQSI;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid CONNHRLYXFM;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid TGQLTIORYHF;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid OKJUWJNYTOV;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid RHKISQZSQHP;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid KAVBCZVGMQV;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid CIYUESLDOHR;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid AAVRMIGLIAD;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid MTMCUYLVVQH;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid QLBNRTFASIA;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid NKLKSZOAEEB;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid UUCMKYVAVIT;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid CYAHPWGJIYA;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid IPGMBXSQLYL;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid IBSJDZRCBNR;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid NMZHLTTKFMB;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid ZACKLLKGNTJ;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid JUVLDLIJBHT;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid HZOOWFHRDCZ;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid BWSGRHMXFQU;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid GYOHBTZNDBR;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid OGSTEGPPWKZ;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid TRRVKWPEYDB;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid PRKVTUHEXIY;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid WEQLQWTDFWW;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid GSQAJRNGREU;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid DNRIQPSTUMF;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid FRHPEHKLLMG;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid FDLHBYOWBAV;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid XZNVWTNUPHQ;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid AXCMKEGKBRH;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid PZFZDUBQCIF;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid YCFDAYZJJUH;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid URXLZJYQCEI;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid LAANDTBTNFL;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid HIKUXFHSUHX;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid SIJXCEBPKOI;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid AQVSBGOIRTO;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid IQLTWZRPRTN;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid NCMMYGYZBFE;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid XVKUTPFLNJV;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid RAPQTEARCES;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid YOXPTSMKQXB;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid KQMMTYCGFYN;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid FSNLDXADMZW;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid QXVQVFTPBMU;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid HJMQWRGHBPL;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid TLDAVZGUKOY;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid PSWTXKMISPG;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid MHOMHRPKHIP;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid DEZSGZHTMCI;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid PCIIPERBCOF;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid UNDSOVPTJYD;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid HXRUETSPLUG;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid JTXGWWGGSDS;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid PFVIGHCRQKF;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> PCQYRUMBRYJ;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> KHTMXZBZCKN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> OBPUBAOQMZS
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x97BAFF0", Offset = "0x97B99F0", VA = "0x1897BAFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> JYISLRZWLDW
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x97BB050", Offset = "0x97B9A50", VA = "0x1897BB050")]
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
	public static class GHXPHJWYOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97AC1F0", Offset = "0x97AABF0", VA = "0x1897AC1F0")]
		public static bool GJWCKJMVOMX(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x97AC220", Offset = "0x97AAC20", VA = "0x1897AC220")]
		private static bool GJWCKJMVOMX(XGIWHMXMAZG a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface NQYHDYSZVCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(WAJGQRQEPQP data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, IMGIMAVAFIP circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly UOXIAFFGFEM Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<TEAIRTFLUOM> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<TEAIRTFLUOM> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<EVDWFGHNUCH> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<IHXSJTKSKEJ>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KNRUBDRHGUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x97BAF10", Offset = "0x97B9910", VA = "0x1897BAF10")]
		public R1CreateTemplateParams(UOXIAFFGFEM circuits, IEnumerable<TEAIRTFLUOM> rootData, IReadOnlyList<TEAIRTFLUOM> allPersistableData, Id32<EVDWFGHNUCH> sourceGraphId, IReadOnlyList<Id128<IHXSJTKSKEJ>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly UOXIAFFGFEM Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<TEAIRTFLUOM> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<EVDWFGHNUCH> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<IHXSJTKSKEJ>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x97BAF80", Offset = "0x97B9980", VA = "0x1897BAF80")]
		public R2CreateTemplateParams(UOXIAFFGFEM circuits, Id32<EVDWFGHNUCH> sourceGraphId, IReadOnlyList<Id128<IHXSJTKSKEJ>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<TEAIRTFLUOM> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IVLTWGQLXJJ : DPBKQKJXMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid WAGFUVFIULY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> BMKGHHASQTS;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x644E560", Offset = "0x644CF60", VA = "0x18644E560")]
		private IVLTWGQLXJJ(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x97ACD00", Offset = "0x97AB700", VA = "0x1897ACD00")]
		public static IVLTWGQLXJJ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97AC7C0", Offset = "0x97AB1C0", VA = "0x1897AC7C0")]
		private static Dictionary<Guid, Guid> AVHMQBROGRL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97AC960", Offset = "0x97AB360", VA = "0x1897AC960")]
		public static IVLTWGQLXJJ EBKSBVCACNM(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x97ACEE0", Offset = "0x97AB8E0", VA = "0x1897ACEE0")]
		public static IVLTWGQLXJJ XBRQXSKQQJF(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x97ACA10", Offset = "0x97AB410", VA = "0x1897ACA10")]
		public Dictionary<Guid, Guid> JOIJJKPTOXN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
		public Dictionary<Guid, Guid> MEQRLNIEJGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97AC870", Offset = "0x97AB270", VA = "0x1897AC870")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x97ACA80", Offset = "0x97AB480", VA = "0x1897ACA80")]
		public void JRIAWABLNFG(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x97ACD90", Offset = "0x97AB790", VA = "0x1897ACD90")]
		public Guid VDBNOPTQMSK([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97AC970", Offset = "0x97AB370", VA = "0x1897AC970")]
		public Guid IJWICLFUBST([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97AC8F0", Offset = "0x97AB2F0", VA = "0x1897AC8F0")]
		public bool DCWRKCCSEBW([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97AC8F0", Offset = "0x97AB2F0", VA = "0x1897AC8F0", Slot = "4")]
		private bool VHLSZORQHPC([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface OFXQUIDKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FXEIPUYEGZC(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EMLMYWCCNLO(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ASOIYYOMXWL
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
	public abstract class CHSEXFGVSNR : OFXQUIDKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GZELMBOXDFO : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string KRJYKHHYAMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public GZELMBOXDFO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x97AC6C0", Offset = "0x97AB0C0", VA = "0x1897AC6C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x97AC780", Offset = "0x97AB180", VA = "0x1897AC780", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x97AC630", Offset = "0x97AB030", VA = "0x1897AC630", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> MFQFCXRZFYC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x97AC630", Offset = "0x97AB030", VA = "0x1897AC630", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? DGGUWJCEOFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? XQHDLNGDDER;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> AASOHNDSLXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x97ABF90", Offset = "0x97AA990", VA = "0x1897ABF90")]
			[IteratorStateMachine(typeof(GZELMBOXDFO))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? SZYRKCIFXSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool BTYFPOSFVZH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool JDHNYUNGLCY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> KGAPSFZIJYL(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool WIUNQQJJDKJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97AB720", Offset = "0x97AA120", VA = "0x1897AB720")]
		public void ECYTCWGBJYF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1018B40", Offset = "0x1017540", VA = "0x181018B40")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x97ABC20", Offset = "0x97AA620", VA = "0x1897ABC20", Slot = "4")]
		public bool FXEIPUYEGZC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97ABB50", Offset = "0x97AA550", VA = "0x1897ABB50", Slot = "5")]
		public bool EMLMYWCCNLO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97ABED0", Offset = "0x97AA8D0", VA = "0x1897ABED0")]
		private bool MGYLUNEPJME(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97ABFF0", Offset = "0x97AA9F0", VA = "0x1897ABFF0")]
		protected List<Guid> VKUMEUQTVTH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected CHSEXFGVSNR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class OHIAYGFNOEH
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ROPMAGTCYWA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public UOXIAFFGFEM YVHREDYMVYA;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ROPMAGTCYWA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x97CA210", Offset = "0x97C8C10", VA = "0x1897CA210")]
			internal Id32<TUBDDYPKAKM> UHFCTDVHGZI((Id32<EVDWFGHNUCH> GraphId, Id32<IHXSJTKSKEJ> NodeId) i)
			{
				return default(Id32<TUBDDYPKAKM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int PGZPOKJHPUA = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<TUBDDYPKAKM>, VUXFSMRMOSK> XLXJPMIBAAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long KGKFPHFCTAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long KDQONXWETXV;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<TUBDDYPKAKM, int?> LAJZTGYXKUS;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long CRFKXWKZOBO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long VADVLJNWXXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x97AD7F0", Offset = "0x97AC1F0", VA = "0x1897AD7F0")]
		public static OHIAYGFNOEH TQSAWJKGXMK(UOXIAFFGFEM a, Id128<EVDWFGHNUCH> b, [Optional] OHIAYGFNOEH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x97AD450", Offset = "0x97ABE50", VA = "0x1897AD450")]
		public static (long, long) KYXRVYTVFQU(UOXIAFFGFEM a, Id32<EVDWFGHNUCH> b, Id32<IHXSJTKSKEJ> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x97ADD30", Offset = "0x97AC730", VA = "0x1897ADD30")]
		public static long UYZSWJNQHEX([In] ReadOnlySpan<Id32<TUBDDYPKAKM>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x97AD310", Offset = "0x97ABD10", VA = "0x1897AD310")]
		private static long DUALIYIPESA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x97BAE90", Offset = "0x97B9890", VA = "0x1897BAE90")]
		public OHIAYGFNOEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class VUXFSMRMOSK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long AGNSAISSRJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xEA1330", Offset = "0xE9FD30", VA = "0x180EA1330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long LJSVLVUZVFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xDF2400", Offset = "0xDF0E00", VA = "0x180DF2400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x92C7870", Offset = "0x92C6270", VA = "0x1892C7870")]
		public VUXFSMRMOSK(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class WUBQJHODHRA
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> WZURDYHJULX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LQHNTHIPJSP
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DLIWLDOKFNE : IEnumerable<TEAIRTFLUOM>, IEnumerable, IEnumerator<TEAIRTFLUOM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private TEAIRTFLUOM BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData GDWNCAFTORZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData VMKTPCRSBWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams AAXBZIPHDTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams ZQSZSCUOBMU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int ZWVNFXOIPAU;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private TEAIRTFLUOM TTQMLMMKDGT
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public DLIWLDOKFNE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x97BFA90", Offset = "0x97BE490", VA = "0x1897BFA90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x97BFBA0", Offset = "0x97BE5A0", VA = "0x1897BFBA0", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x97BF930", Offset = "0x97BE330", VA = "0x1897BF930", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<TEAIRTFLUOM> BECJVLDGQSA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x97BF930", Offset = "0x97BE330", VA = "0x1897BF930", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97C4110", Offset = "0x97C2B10", VA = "0x1897C4110")]
		public static SpawnableTemplateData UEPOOCVJSNC([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x97C3F80", Offset = "0x97C2980", VA = "0x1897C3F80")]
		public static SpawnableTemplateData UEPOOCVJSNC([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97C2080", Offset = "0x97C0A80", VA = "0x1897C2080")]
		private static HashSet<Id128<IBWAZGTULTH>> KELTNFUTNOC(IReadOnlyList<TEAIRTFLUOM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x97C42A0", Offset = "0x97C2CA0", VA = "0x1897C42A0")]
		private static void VSFBKFDJZIT(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x97C2960", Offset = "0x97C1360", VA = "0x1897C2960")]
		public static Result<IVLTWGQLXJJ, TryCloneTemplateError> QHULINTWCEW(SpawnableTemplateData a, SpawnTemplateParams b, IVLTWGQLXJJ? srcRemapper, bool c)
		{
			return default(Result<IVLTWGQLXJJ, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97C1660", Offset = "0x97C0060", VA = "0x1897C1660")]
		[IteratorStateMachine(typeof(DLIWLDOKFNE))]
		private static IEnumerable<TEAIRTFLUOM> HOBYLQSTZYP(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97C15F0", Offset = "0x97BFFF0", VA = "0x1897C15F0")]
		private static void BMZXPOUCDCU(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x97C1A00", Offset = "0x97C0400", VA = "0x1897C1A00")]
		private static bool KCNTAUVDGMX(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97C1300", Offset = "0x97BFD00", VA = "0x1897C1300")]
		private static Dictionary<Guid, XGIWHMXMAZG> AGLJHKSRNVJ(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x97C2420", Offset = "0x97C0E20", VA = "0x1897C2420")]
		private static void LUSKWKCPYSB(bool a, TEAIRTFLUOM b, IVLTWGQLXJJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x97C1770", Offset = "0x97C0170", VA = "0x1897C1770")]
		private static void JYQDOMQDLBH(TEAIRTFLUOM a, Guid b, SpawnTransformData? c, Dictionary<Guid, XGIWHMXMAZG> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97C24B0", Offset = "0x97C0EB0", VA = "0x1897C24B0")]
		private static void PJBHITXYLZO(IEnumerable<TEAIRTFLUOM> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public UOXIAFFGFEM circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public ASOIYYOMXWL roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public NQYHDYSZVCJ circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<EVDWFGHNUCH> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public HZDTNYOITFT globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<TEAIRTFLUOM> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public TSCCEPKMIGP photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 XAGUPSXTOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x97CB150", Offset = "0x97C9B50", VA = "0x1897CB150")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS WWEIIMTFALT
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x97CAC80", Offset = "0x97C9680", VA = "0x1897CAC80")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16C0590", Offset = "0x16BEF90", VA = "0x1816C0590")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x97CB380", Offset = "0x97C9D80", VA = "0x1897CB380")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x97CAED0", Offset = "0x97C98D0", VA = "0x1897CAED0")]
		public static SpawnTransformData QIHOFJOJSZZ(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97CB450", Offset = "0x97C9E50", VA = "0x1897CB450")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x97CB470", Offset = "0x97C9E70", VA = "0x1897CB470")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x97CB260", Offset = "0x97C9C60", VA = "0x1897CB260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x97CACC0", Offset = "0x97C96C0", VA = "0x1897CACC0")]
		public SpawnTransformData KLMITDDJSKD(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x97CAC10", Offset = "0x97C9610", VA = "0x1897CAC10")]
		public static SpawnTransformData DJKWYOERDDL(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x97CB2F0", Offset = "0x97C9CF0", VA = "0x1897CB2F0")]
		public readonly CircuitsRigidTransform VARSKPGQLRH()
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
		private readonly FWOTOTOBXEY _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1988FB0", Offset = "0x19879B0", VA = "0x181988FB0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, FWOTOTOBXEY innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x97CC900", Offset = "0x97CB300", VA = "0x1897CC900")]
		public YUGSJIPXOCB UYGYROIJYUS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x97CC7A0", Offset = "0x97CB1A0", VA = "0x1897CC7A0")]
		public static Result<IVLTWGQLXJJ, TryCloneTemplateError> New(DBTBHEQYKQY<None> innerError)
		{
			return default(Result<IVLTWGQLXJJ, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x97CC850", Offset = "0x97CB250", VA = "0x1897CC850")]
		public static Result<IVLTWGQLXJJ, TryCloneTemplateError> New(YUGSJIPXOCB innerError)
		{
			return default(Result<IVLTWGQLXJJ, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x97CC6E0", Offset = "0x97CB0E0", VA = "0x1897CC6E0")]
		public static Result<IVLTWGQLXJJ, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<IVLTWGQLXJJ, TryCloneTemplateError>);
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
	public class WOXUXNNKXFG : IDisposable, VHKEIGOUDND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> AJWGBRMBMQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float TVIOKWILXGD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags KWIJCBATVVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OIHZDLTBRES
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x97D03C0", Offset = "0x97CEDC0", VA = "0x1897D03C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool EMFXVMYCELJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x97CEE60", Offset = "0x97CD860", VA = "0x1897CEE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> WOACALKLJLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int OGKRCCJJBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x97D03D0", Offset = "0x97CEDD0", VA = "0x1897D03D0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GQWZREBSXAI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x97CE5A0", Offset = "0x97CCFA0", VA = "0x1897CE5A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x97D0C90", Offset = "0x97CF690", VA = "0x1897D0C90")]
		public WOXUXNNKXFG(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x97CE540", Offset = "0x97CCF40", VA = "0x1897CE540", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x97CE990", Offset = "0x97CD390", VA = "0x1897CE990")]
		public Vector3 LJAFNMKMNQR(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x97D0410", Offset = "0x97CEE10", VA = "0x1897D0410", Slot = "6")]
		public Quaternion UEBKXCYOZXY(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x97D0540", Offset = "0x97CEF40", VA = "0x1897D0540", Slot = "5")]
		public Vector3 UZSYLHZGJDF(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x97CE6E0", Offset = "0x97CD0E0", VA = "0x1897CE6E0", Slot = "7")]
		public float FOQMFAJJIMK(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97CFAE0", Offset = "0x97CE4E0", VA = "0x1897CFAE0")]
		public void RORBVLFXXWE(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x97CE740", Offset = "0x97CD140", VA = "0x1897CE740")]
		private bool GMSEKSLWFWE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x97CE830", Offset = "0x97CD230", VA = "0x1897CE830")]
		public void JULVEOTWFZS(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97CE7A0", Offset = "0x97CD1A0", VA = "0x1897CE7A0")]
		public void JEUSEZEWBLN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x97CE340", Offset = "0x97CCD40", VA = "0x1897CE340")]
		public void CDBSKBEVCTA(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x97CF7E0", Offset = "0x97CE1E0", VA = "0x1897CF7E0")]
		public void PYYZUKNIGEW(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x97CF990", Offset = "0x97CE390", VA = "0x1897CF990")]
		public void RKBMBVAGPFS(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x97CF680", Offset = "0x97CE080", VA = "0x1897CF680")]
		public void NKFBVSMOBMT(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x97CEE70", Offset = "0x97CD870", VA = "0x1897CEE70")]
		public static Quaternion NFUAGWQTCYN(Quaternion a, int b, float c, VHKEIGOUDND d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x97D05E0", Offset = "0x97CEFE0", VA = "0x1897D05E0")]
		public Bounds ZTUUGAFRCAT(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x97CE2E0", Offset = "0x97CCCE0", VA = "0x1897CE2E0", Slot = "10")]
		public virtual void BSISVLMPNBX(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x97CE490", Offset = "0x97CCE90", VA = "0x1897CE490")]
		public NativeList<CurvePointData> DYQRPTKFJYX(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x97BF8B0", Offset = "0x97BE2B0", VA = "0x1897BF8B0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x97BF360", Offset = "0x97BDD60", VA = "0x1897BF360")]
		public Quaternion FEUDXHROBME(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x97BF420", Offset = "0x97BDE20", VA = "0x1897BF420")]
		public CurvePoint GBLKIOGICNS(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x97BF710", Offset = "0x97BE110", VA = "0x1897BF710")]
		public TLGVBOZBNDR ODAYBVZVTZU(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class HIBNEAYYYON : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x97BFF60", Offset = "0x97BE960", VA = "0x1897BFF60", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x97C0040", Offset = "0x97BEA40", VA = "0x1897C0040")]
		private void KXYOOSTYBGA(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x97BFFE0", Offset = "0x97BE9E0", VA = "0x1897BFFE0")]
		private void KXYOOSTYBGA(Dictionary<Guid, Guid> a, AROERPUQDHJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x97C0610", Offset = "0x97BF010", VA = "0x1897C0610")]
		private void KXYOOSTYBGA(Dictionary<Guid, Guid> a, HHYOQVVXHZC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public HIBNEAYYYON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class CXGQRFXVXEA : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x97BF2B0", Offset = "0x97BDCB0", VA = "0x1897BF2B0", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CXGQRFXVXEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class OHTLKKFDFSN : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97C4D40", Offset = "0x97C3740", VA = "0x1897C4D40", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public OHTLKKFDFSN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class MFBARLOXKQZ : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x97C4930", Offset = "0x97C3330", VA = "0x1897C4930", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public MFBARLOXKQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UTXQZZCZHPV : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x97CCB60", Offset = "0x97CB560", VA = "0x1897CCB60", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UTXQZZCZHPV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class JMIRYZJYHRC : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x97C11C0", Offset = "0x97BFBC0", VA = "0x1897C11C0", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public JMIRYZJYHRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PHJGZVCCKSU : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x97C4EA0", Offset = "0x97C38A0", VA = "0x1897C4EA0", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public PHJGZVCCKSU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SOJOHZLGEQP : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97CAB20", Offset = "0x97C9520", VA = "0x1897CAB20", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public SOJOHZLGEQP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UVVVJTHZQSB : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x97CCD80", Offset = "0x97CB780", VA = "0x1897CCD80", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UVVVJTHZQSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class VAIXBEPCMAB : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x97CE120", Offset = "0x97CCB20", VA = "0x1897CE120", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public VAIXBEPCMAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class MRFSLJLUANV : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97C4C40", Offset = "0x97C3640", VA = "0x1897C4C40", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public MRFSLJLUANV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class QAYVZRXAWWW : RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly MJRPJQWGVKE JRWFSLJACHD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x97C9D40", Offset = "0x97C8740", VA = "0x1897C9D40", Slot = "4")]
		public void JELEKKRWBSH(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public QAYVZRXAWWW()
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
		public TSCCEPKMIGP photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface RKQZRTGJUIS
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JELEKKRWBSH(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class TPOZHQHHBKT
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly RKQZRTGJUIS[] DCZOUDQOPPX;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x97CBEC0", Offset = "0x97CA8C0", VA = "0x1897CBEC0")]
		public static void QYHAZBCTBSM(TEAIRTFLUOM a, IVLTWGQLXJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x97CBC30", Offset = "0x97CA630", VA = "0x1897CBC30")]
		public static void MNSQVBCDEHQ(TEAIRTFLUOM? data, IVLTWGQLXJJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x97CB5D0", Offset = "0x97C9FD0", VA = "0x1897CB5D0")]
		public static void FXNRNQVOZYE(TEAIRTFLUOM? data, IVLTWGQLXJJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x97CB840", Offset = "0x97CA240", VA = "0x1897CB840")]
		public static void GJWCKJMVOMX(PersistableCloneParams a)
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
		public TEAIRTFLUOM viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x97C5040", Offset = "0x97C3A40", VA = "0x1897C5040")]
		public Guid HXOAEBHUEUB(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface TSCCEPKMIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> JFPKOTZJFPU;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> JNJUJUFMQHG;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> YLSAAQSPFQW;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker ECTCQZRQNZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> VKYFMWOZOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> IHQLQIHJOWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> MSVWUSTZATF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> JQJPYBLITNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> RBCGBMCWOYI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> VLBSDVKCNWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> LLFWTBRBVZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> FEWUJZWXUUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> ASIXUNBENQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x97C6870", Offset = "0x97C5270", VA = "0x1897C6870")]
		public static void HFACXHMBIIY(SpawnableTemplateData a, FFRPTKMQVBO b, IVLTWGQLXJJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x97C9240", Offset = "0x97C7C40", VA = "0x1897C9240")]
		public static PersistedRoomDataReferences UUTOQZXVTDC(PersistedRoomData a, FFRPTKMQVBO? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x97C8F80", Offset = "0x97C7980", VA = "0x1897C8F80")]
		public static PersistedRoomDataReferences OOPRZMSLSVV(SpawnableTemplateData a, FFRPTKMQVBO? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x97C9000", Offset = "0x97C7A00", VA = "0x1897C9000")]
		public static PersistedRoomDataReferences QFSTSBRBNPV(NOJIAPKTUHF a, WWOUAJPVRQR b, FFRPTKMQVBO? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x97C92C0", Offset = "0x97C7CC0", VA = "0x1897C92C0")]
		public static PersistedRoomDataReferences VBRKFKCUCRG(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x97C9BE0", Offset = "0x97C85E0", VA = "0x1897C9BE0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x97C9A10", Offset = "0x97C8410", VA = "0x1897C9A10")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x97C8490", Offset = "0x97C6E90", VA = "0x1897C8490")]
		private void IJBHVFHGHQV(PersistedRoomData a, FFRPTKMQVBO? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x97C7E00", Offset = "0x97C6800", VA = "0x1897C7E00")]
		private void IJBHVFHGHQV(SpawnableTemplateData a, FFRPTKMQVBO? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x97C5160", Offset = "0x97C3B60", VA = "0x1897C5160")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x97C7430", Offset = "0x97C5E30", VA = "0x1897C7430")]
		private void IJBHVFHGHQV(NOJIAPKTUHF? a, FFRPTKMQVBO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x97C8410", Offset = "0x97C6E10", VA = "0x1897C8410")]
		private void IJBHVFHGHQV(WWOUAJPVRQR? a, FFRPTKMQVBO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x97C7250", Offset = "0x97C5C50", VA = "0x1897C7250")]
		private void IJBHVFHGHQV(TVRLIQRPLND? a, FFRPTKMQVBO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x97C94C0", Offset = "0x97C7EC0", VA = "0x1897C94C0")]
		private static bool VRHPAYBZKWS(TVRLIQRPLND a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x97C8B30", Offset = "0x97C7530", VA = "0x1897C8B30")]
		private static bool IXUSTOQBJPA(TVRLIQRPLND a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x97C5EC0", Offset = "0x97C48C0", VA = "0x1897C5EC0")]
		private static void HFACXHMBIIY(WWOUAJPVRQR? root, FFRPTKMQVBO a, IVLTWGQLXJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x97C5F90", Offset = "0x97C4990", VA = "0x1897C5F90")]
		private static void HFACXHMBIIY(TVRLIQRPLND? customProperties, FFRPTKMQVBO a, IVLTWGQLXJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x97C5B50", Offset = "0x97C4550", VA = "0x1897C5B50")]
		private static void HFACXHMBIIY(NOJIAPKTUHF? root, FFRPTKMQVBO a, IVLTWGQLXJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x97C6220", Offset = "0x97C4C20", VA = "0x1897C6220")]
		private static void HFACXHMBIIY(CircuitsV2.Protobuf.CircuitNodeData? node, FFRPTKMQVBO a, IVLTWGQLXJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x97C8090", Offset = "0x97C6A90", VA = "0x1897C8090")]
		private void IJBHVFHGHQV(CircuitsV2.Protobuf.CircuitNodeData? a, FFRPTKMQVBO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x97C8D70", Offset = "0x97C7770", VA = "0x1897C8D70")]
		private void MZOFKVEPIQB(Guid? a, FFRPTKMQVBO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x97C8730", Offset = "0x97C7130", VA = "0x1897C8730")]
		private void IJBHVFHGHQV(TEAIRTFLUOM? a, FFRPTKMQVBO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x97C5700", Offset = "0x97C4100", VA = "0x1897C5700")]
		private static void HFACXHMBIIY(TEAIRTFLUOM? viewData, FFRPTKMQVBO a, IVLTWGQLXJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x97C50F0", Offset = "0x97C3AF0", VA = "0x1897C50F0")]
		private void AJUPOQIQXMA(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x97C9120", Offset = "0x97C7B20", VA = "0x1897C9120")]
		private void UJVCRTEWYYI(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x97C91F0", Offset = "0x97C7BF0", VA = "0x1897C91F0")]
		private void UJVCRTEWYYI(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x97C90C0", Offset = "0x97C7AC0", VA = "0x1897C90C0")]
		private void UJVCRTEWYYI(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class QZYMCJVHACH : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> PLKIIGZRKAA;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x97C9FF0", Offset = "0x97C89F0", VA = "0x1897C9FF0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x97CA0B0", Offset = "0x97C8AB0", VA = "0x1897CA0B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x97CA160", Offset = "0x97C8B60", VA = "0x1897CA160", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x97C9F10", Offset = "0x97C8910", VA = "0x1897C9F10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
			public QZYMCJVHACH(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x97C9E70", Offset = "0x97C8870", VA = "0x1897C9E70", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x97C9EC0", Offset = "0x97C88C0", VA = "0x1897C9EC0", Slot = "9")]
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
			private sealed class IWJUOQMGCUZ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry DXQFNITOLCR
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x97C0990", Offset = "0x97BF390", VA = "0x1897C0990", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public IWJUOQMGCUZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x97C0890", Offset = "0x97BF290", VA = "0x1897C0890", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x97C09E0", Offset = "0x97BF3E0", VA = "0x1897C09E0", Slot = "8")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
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
			private ICollection GFOVFYXKVER
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x97CA4A0", Offset = "0x97C8EA0", VA = "0x1897CA4A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x97CA730", Offset = "0x97C9130", VA = "0x1897CA730", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x97CA810", Offset = "0x97C9210", VA = "0x1897CA810", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool VTUGGDWKEHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x97CA8A0", Offset = "0x97C92A0", VA = "0x1897CA8A0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool KEYROEIORYD
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x97CA850", Offset = "0x97C9250", VA = "0x1897CA850", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection PQILGZFPNXJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x97CA990", Offset = "0x97C9390", VA = "0x1897CA990", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int JHBBNDMANRS
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x97CA530", Offset = "0x97C8F30", VA = "0x1897CA530", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool CXAQSXUHPLV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x97CA380", Offset = "0x97C8D80", VA = "0x1897CA380", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object ZPNYBMXHISG
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x97CA580", Offset = "0x97C8F80", VA = "0x1897CA580", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x97CA5D0", Offset = "0x97C8FD0", VA = "0x1897CA5D0")]
			[IteratorStateMachine(typeof(IWJUOQMGCUZ))]
			private IEnumerator<DictionaryEntry> OSSJBJMSDTO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x97CA690", Offset = "0x97C9090", VA = "0x1897CA690", Slot = "19")]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x97CA3D0", Offset = "0x97C8DD0", VA = "0x1897CA3D0", Slot = "13")]
			private IDictionaryEnumerator IXFOVRNTGUR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x97CA2E0", Offset = "0x97C8CE0", VA = "0x1897CA2E0", Slot = "9")]
			private void AIGNXFAATWM(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x97CA640", Offset = "0x97C9040", VA = "0x1897CA640", Slot = "10")]
			private void RKOJQURPDWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x97CA940", Offset = "0x97C9340", VA = "0x1897CA940", Slot = "8")]
			private bool XRLFWPQHKXC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x97CA330", Offset = "0x97C8D30", VA = "0x1897CA330", Slot = "14")]
			private void CVZYRFQZHQZ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x97CA8F0", Offset = "0x97C92F0", VA = "0x1897CA8F0", Slot = "15")]
			private void WPRRSHDIMHT(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class MJIGWFSHQQT : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry DXQFNITOLCR
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x97C4BB0", Offset = "0x97C35B0", VA = "0x1897C4BB0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public MJIGWFSHQQT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x97C4A90", Offset = "0x97C3490", VA = "0x1897C4A90", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x97C4C00", Offset = "0x97C3600", VA = "0x1897C4C00", Slot = "8")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
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
			private ICollection GFOVFYXKVER
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x97C0BE0", Offset = "0x97BF5E0", VA = "0x1897C0BE0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x97C0E10", Offset = "0x97BF810", VA = "0x1897C0E10", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x97C0F20", Offset = "0x97BF920", VA = "0x1897C0F20", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool VTUGGDWKEHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x97C0FB0", Offset = "0x97BF9B0", VA = "0x1897C0FB0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool KEYROEIORYD
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x97C0F60", Offset = "0x97BF960", VA = "0x1897C0F60", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection PQILGZFPNXJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x97C10A0", Offset = "0x97BFAA0", VA = "0x1897C10A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int JHBBNDMANRS
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x97C0C30", Offset = "0x97BF630", VA = "0x1897C0C30", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool CXAQSXUHPLV
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x97C0AC0", Offset = "0x97BF4C0", VA = "0x1897C0AC0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object ZPNYBMXHISG
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x97C0C80", Offset = "0x97BF680", VA = "0x1897C0C80", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B6A300", Offset = "0x2B68D00", VA = "0x182B6A300")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x97C0CD0", Offset = "0x97BF6D0", VA = "0x1897C0CD0")]
			[IteratorStateMachine(typeof(MJIGWFSHQQT))]
			private IEnumerator<DictionaryEntry> OSSJBJMSDTO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x97C0D80", Offset = "0x97BF780", VA = "0x1897C0D80", Slot = "19")]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x97C0B10", Offset = "0x97BF510", VA = "0x1897C0B10", Slot = "13")]
			private IDictionaryEnumerator IXFOVRNTGUR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x97C0A20", Offset = "0x97BF420", VA = "0x1897C0A20", Slot = "9")]
			private void AIGNXFAATWM(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x97C0D30", Offset = "0x97BF730", VA = "0x1897C0D30", Slot = "10")]
			private void RKOJQURPDWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x97C1050", Offset = "0x97BFA50", VA = "0x1897C1050", Slot = "8")]
			private bool XRLFWPQHKXC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x97C0A70", Offset = "0x97BF470", VA = "0x1897C0A70", Slot = "14")]
			private void CVZYRFQZHQZ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x97C1000", Offset = "0x97BFA00", VA = "0x1897C1000", Slot = "15")]
			private void WPRRSHDIMHT(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x97CD6F0", Offset = "0x97CC0F0", VA = "0x1897CD6F0")]
		public static UgcRoomSaveStatsDetailed UUTOQZXVTDC(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x97CD5D0", Offset = "0x97CBFD0", VA = "0x1897CD5D0")]
		[CompilerGenerated]
		internal static int GRHLKRUHKQS([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x97CCF40", Offset = "0x97CB940", VA = "0x1897CCF40")]
		[CompilerGenerated]
		internal static void DWTQKJCIWXU(int a, [In] NOJIAPKTUHF graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class FFRPTKMQVBO
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid PKBHVSEXSCU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> LLFWTBRBVZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind NDBCZWHGVDW;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x97CE0C0", Offset = "0x97CCAC0", VA = "0x1897CE0C0")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly IVLTWGQLXJJ PCFVLLSBSVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> MABWMQALGIT;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IVLTWGQLXJJ XXNHZWTALFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x97BFBE0", Offset = "0x97BE5E0", VA = "0x1897BFBE0")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x97BFDE0", Offset = "0x97BE7E0", VA = "0x1897BFDE0")]
		public bool LGWQPGAMLQZ(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x97BFED0", Offset = "0x97BE8D0", VA = "0x1897BFED0")]
		public FFRPTKMQVBO()
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
