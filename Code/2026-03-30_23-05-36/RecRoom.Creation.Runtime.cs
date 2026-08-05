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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x8488710", Offset = "0x8487510", VA = "0x188488710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ODGTIAXUUFB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> BBSFQKXCNVB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JAWOUTKWMCD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> IDBPIPFZTBT;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> CVLQGRTCCDU;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string DRUAJURMSIU;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string UECLCSHEJYJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string ALACMMZUTOQ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8488EF0", Offset = "0x8487CF0", VA = "0x188488EF0")]
	public static bool QZDYWMLEATV(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8488E60", Offset = "0x8487C60", VA = "0x188488E60")]
	public static bool MUTJBGUMDSN(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8488790", Offset = "0x8487590", VA = "0x188488790")]
	public static string BLXPDADAMZO(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x8488650", Offset = "0x8487450", VA = "0x188488650", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CCMAXKIOIZY
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid UKUQFGRNWWX;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid AGGBBWZXTNE;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid JLOHYBAUNQT;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid XIQWEBNPKMR;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid ZYUCCIRVVEF;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid MCLHLEVZYEQ;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid RLANMQOVKCQ;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid QILSFDSCMRK;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid CKQNJJYJCWZ;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid YRVQKDOETAG;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid FNDKXPHOPHI;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid YORFANQIANE;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid AVQLCPVVRLF;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid CUPFUGAMNKS;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid DRFATBPNRMN;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid XFOQUFYGIJI;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid LLHEYGFBIOV;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid FYPDLMCCOGW;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid GOBTIXKNIGE;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid KMDKYFHWSAN;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid PWWZQCDPBCW;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid DGJQMCUSDWY;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid WEFMKNFLQGZ;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid BQCSNKJNNLR;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid PCYRPRPEZTB;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid ICNUKWMZDDL;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid XGXQQCPSDBZ;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid JJKLUQPCQMJ;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid WPTZSZRYNKI;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid RSMKYSHEVSZ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid JSIEWGBIVEC;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid DYDZYKJZMHI;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid UWAEHNIACOH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid YHECSKXMMVX;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid OFBHOVKRCWM;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid YJBZYPYWDQT;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid FBSPDSDVQGO;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid CNTABULYFQA;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid GPGGJEHCMOW;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid TXOEITOJQBS;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid VEVNYPUTJUS;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid OIXBRDSYGWC;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid FVXZZMVUGUI;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid YZEAJFCKXWQ;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid XRPQTTYIHYK;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid QWNOEXRQIUX;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid TJHIHBOOTAU;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid FWMFPBLLASN;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid VOESJPCCWRD;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid VPEFADXEQOB;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid NDWLISPXQUE;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid BGHUYDPZYIP;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid ABRNTQVTGIO;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid ZGWOITLQBFA;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid APQFSBZRZYJ;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid ZTORFUWNDDT;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid EBNLPSYHCHR;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid CQPMNEBWSTW;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid QMMDYGLMPWW;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid BOEUUYUKUVN;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid UUFQKFJWGBH;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid BJZPJSRETNS;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid LPRAIOGFXSV;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid XHMGPFQELPU;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid BJHCQRJNVEW;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid CFXLPNQNZOJ;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid TKEVBRDNRBW;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid CPBMXYZNCEI;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid HXWKQFKMOIL;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid CMDXDZWXQOX;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid NDQKRJHESNI;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid KRREVJSKVXF;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid VIJBTYAVIIE;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid NYQLDCXTAJF;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid DQMLLWXELSW;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid BKCNBNCUXFO;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid NAWQNSQDGSX;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid FJOTHPPLGQV;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid YMGRFRFKXOJ;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid SMWBPXWYQCR;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid LBSWYUQMXOV;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid YEWJQGPVURC;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid BUETKAJBMWV;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid CMXJOMRFVHI;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid KDGBAIXVEGB;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid RGDUBFEZVVU;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid PYDOAMPNWWO;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid WBDKMZUGYRK;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid DBSNCOSBFXR;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid ZPRKPNEZKRM;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid QCJPZQRLKIK;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid HEXUCXLRABF;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid TUXXGVXCFID;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid PRNOLFGFQIK;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid KNLDBQDJKAS;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid JBBWVIZZJUS;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid HKSTRLBYKIU;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid CBGIPJTFVGW;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid BELFAENZNTZ;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid FNDWPDTEXAG;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid QGXZPPQRZAS;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid RACQHXYWKAZ;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid WQIBSSLALNE;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid SIPLYCAKPNP;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid RIAQEVWGZCO;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid SIEYDOMPWQX;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid DSSOZFLKIHC;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid ZCUEGLVTPGW;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid BMOOBYWLUWL;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid VYNZOTWYXZK;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid WUHJSCBYRYV;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid VYYNJHKTQWC;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid WWNHVHBKPWX;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid WAZEHXBTHFO;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid FBQYZYAPQTP;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid KUFNTIHTJZD;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid PMQIBGIMYSA;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid DYNMCDMEOYW;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid ULDSWMPUIRX;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid QGINWEKCEZG;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid GQWMOGWFBTW;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid QTQPISLTXKV;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid KMNDEFIRMBM;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid MAZLHMFGWDY;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid RNEWHYFRGIO;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid MWUPJRHOOUS;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid ZITUGGFYSMY;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid XDDUFMZYHFS;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid NRICIVCJAZS;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid BDTWDNLSFKN;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid PSACGRBIQGK;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid WDBDRMDNZBO;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid DXPDAYFMSOM;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid EOSPTNVFXIT;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid SJFOIQQWFZG;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid BRSZNQPUPUT;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid FTTBJWZVQQN;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid QIBZKOHTIGG;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid HOIDXTGWGOA;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid URHPOCRYOCD;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid HWWAEPIISYV;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid JGRHCKRMEDS;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid SVXGWGPQXPE;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid NFSVZWFCBHT;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid IGIQRDAQCZN;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid BGGNBRRBBMH;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid SUHRCJMDNHH;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid AUZQPTVZTJU;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid CMPUUCUOYBY;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid CMKNWWAROQP;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid CMFGZPGUFFG;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid CMAACIMWVTX;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid CLUTFBSZMIO;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid CLPMHUZCCXF;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid CLKFKOFETLW;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid MRLMBPCAFWO;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid UGDCEUWWLRC;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid THHRRAGRGXH;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid DDRXKCLYDGJ;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid NWVMGMVNQLK;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid MVEYKMWODKL;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid GFWDRFQZCKF;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid EKQDOKTSBPL;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid RXZXCPOOYGK;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid MMGCWQWDGVO;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid HCGEHTESHIV;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid EOMIKYGSEOU;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid THGOQRVXBCD;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid TATVIXGAVKJ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid CCXRVMSYIWW;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid YSJMGANKYNF;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid TAEARCYITCI;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid TAJHOJSGCNR;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid TBJQARNSXSK;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid XOFMDGCRHRP;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid BLAGJJHDYUO;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid KINKYINOMNJ;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid XNPRLLUZFJO;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid BSGHERBFILL;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid JDNCBZPDBIY;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid IQLZMADYJDY;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid RVXEGMLJRDJ;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid XBPTJQZSHAL;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid FVKBQMYTBVL;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid GDRORRWTOVJ;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid AMBPOUEMPQZ;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid OPYTVAQDJTQ;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid QAGCPOHJTKF;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid XMBUZKZWGZK;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid CQAJSIOSGZE;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid SEXVWTNJLOU;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid GYCWAZKQMGO;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid JPHFGQRLZGD;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid TUGMPPHOITT;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid IGLKAMTLOQQ;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid HDSZONIJNYG;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid YUGPTTFJPOJ;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid TQDSJOUIYDU;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid EMXZQDCQQIU;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid PZODALPDDJX;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid ESDEBSSXTOQ;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid WLUYHLEOHLB;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid QQUMLBSWZDN;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid HSNYSJUOOBU;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid RLMOJWJWBOH;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid MYAGUKAAWOU;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid RYKKRLQPVTI;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid POTEBCPPFXK;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid RCIYQQGQXRN;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid FRFBEYHVNSG;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid PGFBFSCBJLQ;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid NMZPRWJEKOV;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid PFGBSLOYTUL;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid TMCPCEOVIMC;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid VUNXBNUJLYX;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid ZDJJXQEAAGO;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid WEHRJDDIOOL;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid EEGRTSSQISX;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid NUUFVDOLJPP;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid MFQESKENASN;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid CIDPFGNGAJY;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid EHKEQKCACRS;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid XRCZNZVFQUR;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid SRDMUIWSJVQ;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid SAWZKAMJMMP;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid LLIAAOXAIWF;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid SLDNUSZIFIB;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid QJVGZSEKNXG;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid SSVRAHAJEMY;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid GLLNEQGGOYT;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid BIWYGUAWUXI;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid UKLUZMYEYCB;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid KKFJRIDNGJQ;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid TQPVGZKPOTY;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid PSAVNOUYPSA;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid HTEQPTRKNYC;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid BSEENTNKJYA;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid MHSEYFZXVHY;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid IWCJMOOCXGV;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid GEVEYPGWMHC;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid AFWRRWZUEYG;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid MTQCMQQUTOP;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid SDCNRSXVRJE;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid KSEPZYJHSUR;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid GQFYPYIKCXR;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid KOPGICNIVGN;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid GONIMTMQOEY;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid RKMKNCQDPJD;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid IUIJSBRPHDO;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid NQQFSUQREQY;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid SPRCMVPBHPX;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid OMPGUTHDEWM;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid JVRRLUCCFMA;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid KHJXWQRYDHW;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid IEQNGIWJEFG;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid SVBUQYJBMOS;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid NZVVUIXLCWS;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid XUSYPZMZGAL;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid VKXLPEFATQD;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid RGFCQRAMWHW;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid BUDZZZGJJZV;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid JOHVJHLRMTQ;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid AIUIKPCFTSK;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid ZTRKWRBTSBB;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid NMDQEVFJECG;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid KJFTUIRGOGG;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid EGLZVUYDJQS;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid PZENSUBPNTW;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid WULQVDTXRIM;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid KTXLRFRAHEU;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid MZSJERURTMU;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid CFQRIJGZIMN;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid MAUDBWRSRTT;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid HHKJSEOKBLA;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid COXKKEDBTYV;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid WAYXBTYHZYO;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid JNUCTFXJEJI;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid TUUPJISSKBP;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid ALXMTLGBVPO;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid JADUYXVNIXU;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid WIICYEXEYGA;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid SJOMBBOMKQX;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid DLLFTNCGHQP;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid ODCTIQTZBFB;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid SJZVQAFZCRY;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid UOVTGCYAZCQ;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid EBHIIKNJSHY;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid XCHIXOWTWGK;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid OHRYLPBKAZX;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid BPMMOELYEJB;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid OGKTFEATYGD;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid YXHNOQRGKGE;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid QRDZPBHOOXG;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid MFYJKIMEUWJ;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid AVXSALZHZNP;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid WGMQIWJUOZC;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid MAXQABUQCEG;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid LMNNMJCNGSR;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid RSEFVRCGDTM;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid LNSHUKOVZUD;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid YVJZJEJXLTO;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid WRDRWZDTBGE;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid YCRJKLPAAOO;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid SRKZEJJMDRH;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid FREESXMQHXF;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid MQQKNCGWMRH;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid DJZKEVGPTIU;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid VKBBZLGNIXT;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid CDIKTDOGBRX;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid KMMAJQANLDN;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid QZHBSYDWDCT;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid EIINFYKQAHK;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid BKNFBUQLQEE;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid YIGAFFTFJPI;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid EDVBFPNXERC;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid VJRKARTORGY;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid QISGLLXVBZQ;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid WKKIFNMTQGN;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid ZMULTWEFVTL;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid BTPMDBWTFLU;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid GPMUQOSRAZR;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid AYDWTJXEQRP;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid GCRXLFALQUL;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid FTPJWSBHWCK;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid ZYQLVRICJXY;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid HOWUBSBPPEB;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid EFRWZNOTPJB;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid OANUYFKTFSN;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid KZKQIDPGBDP;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid ZHSUFTJGMYO;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid CGTYDWZAHCI;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid EFHQZCEYLKT;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid VXPMKKXWXFL;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid MMGBICRLTVJ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid HZZEGLEKXIX;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid PHYTLHHRTCU;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid TSXYBAAIQUA;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid VBPLRDUUTXO;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid JLKNDLEDXJN;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid FIDRNCODBJV;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid BZKQEBKDXNE;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid OPTRDZCYZQI;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid YWFCBTQRVWJ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid KCHMHUJHZQB;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid XMHOYXBZOEE;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid BMJNRYIRUMF;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid OUFXCSQXCYR;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid MQHBSUQKPRA;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid UDEZHMEMPMB;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid IWVQWINRYTJ;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid ESDUWGSRBRO;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid UNLDABCAAWV;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid IZQCIIZYVHU;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid HIPOVAGOJRN;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid EEVNHNLGTGF;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid JQCPCIFDPKL;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid RSEDCLNERKV;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid WSBSXBVPYUS;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid PCEPHMMPASO;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid CTGIZTJCQFJ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid GWZVRSCPAAO;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid HZCPCQTCMRO;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid CWVQYILSEGU;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid BLGRKHLOWFX;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid KGHYZIXHELS;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid REQPCYMCLBL;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid IOYWBCGUFSE;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid LRHYZVDLPFD;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid CHZOAHOICNF;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid AFBGEFMCCNO;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid KGHDAWNANAY;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid ERMUVTBCAIQ;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid CWQPWWKBQFS;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid RKPVGGCFBLK;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid DABCAMRODLN;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid QLIYIYKDQIA;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid EOYXFFVRKZL;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid DDVAKNNDEVM;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid YXLRKJKRUZD;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid CQHIVJJSUFG;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid OFXRCBDSSNN;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid AWDGVXMWMQM;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid LNYBZJYFSBB;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid NXRIDJHCEBQ;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid VDLEWLNQWEX;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid QMUIAOTQDRH;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid ZDUVSTQYEUG;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid QBZLRRWJOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid TPHNFYPJWPY;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid MICOPWVWMIP;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid LGMHRCSBUOX;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid BSHLMOLOJRR;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid ECJXJXXGISJ;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid VTXQCGJIOVW;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid XVKVOFAZAWW;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid NFJAFMTQNSN;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid LVYWHLAOJZK;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid CVXUVDVTSUH;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid GTIMYIFSZUN;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid DZCAJHBBBQT;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid HNFIPMHITUV;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid DWIRVVXGRXO;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid HRSIZAQVANZ;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid PCJFGRSHKWU;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid FDFHDAZQKIU;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid ONRQJUEVEIV;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid IIKTXASLJJF;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid CCNXTGNFSOY;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid ULUZRAIPJHU;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid ZQSBREXHSJY;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid TQEESXVJCKT;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid FKCCVSQOZMY;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid NLQKHOBJTHJ;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid FVIGPGLQLSL;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid CNTMHXJQZQA;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid XVDWYAEQFUO;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid TDDALIGQWKE;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid WVEIUXSBWOX;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid XWZLLNQOVJY;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid URNQKJKZFTI;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid YEARYTQROOY;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid SPFSCFFDKGK;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid RVSNVGVRLTC;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid DTNALVXMUKJ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid FVWPUYFOHKX;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid CRJZRKCYKLU;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid RZVUPDXGEBU;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid CRESUDJBBAL;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid CQZLWWPDRPC;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid CQUEZPVGIDT;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid CQOYCJBIYSK;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid CQJRFCHLPHB;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid CQEKHVNOFVS;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid CPZDKOTQWKJ;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid CPTWNHZTMZA;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid EUXRDNBFOZG;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid MJMGKMLXBXS;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid NDAFFAEVPUF;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid JNZZBEPYTKR;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid ACCLCMLHTXT;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid GQJDEAPJGFN;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid GZMRNCEGVHM;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid LTNJSWXQVDE;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid VEQGBIWSAPF;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid IRDEYDQHLUV;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid PODLWMZWBLK;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid ASGINGZWEAK;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid NKOXGOJVJNI;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid TGYJFVGVAVP;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid FLKWEOCBSLW;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid PGZLCIBERQM;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid HNDWUSYXBBZ;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid LWJFKXHJOKL;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid PVHBUMAHOEF;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid MPDXDMZIPTD;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid BHHKEBCPQQW;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid EYROCDXWYJT;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid EXRFPWCKDFA;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid SYMMAJMKEIA;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid VQUSLBABJYN;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid NACDPCJJLWE;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid CYFAEGAYUOB;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid LDMJTJUHBOJ;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid UFUCYYUOQBI;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid GBHNTNQMOIK;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid SYQQWLXQOFK;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid WRIPBRFCLJO;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid NPXCOFYMPPS;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid GRIARATQZIR;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid AINVSJUPUMQ;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid HQUOPIKPHPS;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid EQXMNNLFCZD;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid CAKKREVHOBS;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid WGONKJZVHSN;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid QUFOFKDWQXK;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid ZRAEULJCHJG;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid BPPEFBWHUCX;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid BUJYALUYMJO;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid EOGASYNSHCM;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid PWBIEIMBZGU;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid PWSYKLZWTQS;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid ALKBFQISNIF;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid TLKNSDBFRVP;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid BZVGGKXFMKV;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid AFBLYNYPYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid JOKNJKUDAOJ;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid VWAVLGAJUTV;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid XZXOZPYPVSU;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid QTSXYDYQJOL;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid EACXCPLKQGJ;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid JUTXGUJSCNS;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid QEXOJGQQYZU;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid ACZIOQPTHTF;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid MEFWNQDYKNW;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid LELWLXTFBWJ;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid MRJHPGOKOHF;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid WLZCJJXJIVU;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid LGJTXLMHUDY;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid KAEOVRTUOWG;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid WEUYNSUPBXM;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid QGBEEXXTHOU;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid IVESFNLJDDV;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid BMFOIZRPSKR;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid APFNECTXWAI;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid EYYOAAGFMAT;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid BGFNFBFKWBC;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid ZQDTMMOOHPX;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid GFPXNRELAZW;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid WFGUZSTAFZT;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid SUMGEGXGJJY;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid HYHMEPELRJB;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid EAUTEBRHWZB;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid UBYSUQXHMMA;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid ICAGSWBTIKW;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid IMYDHGKTFUI;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid TTZSQUDBESN;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid EFAEXIFITDK;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid CHIKEYJDRRT;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid NVYBJVHHAVV;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid LDBVMYTVEQO;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid LCQIBXNXUKU;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid LCVOZEHVDWD;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid JWKMRCZJVNX;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid MLOLOINVXXZ;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid DLVIWMSLAOA;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid INMCYVVBRLM;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid XEIELNDEDZW;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid SJSCSWHLGXL;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid QMVTIRBDCCI;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid CIVXMYFROLL;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid ITOUHWCKCQA;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid EVOTTOJGFNY;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid GUAFREKWQOD;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid KWMZKAZDWTO;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid VDMQGSPUPES;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid CVIPNBPLGRE;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid AGAEQBZMRTJ;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid AAVXPYVWTQD;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid XQWBSBMCWFK;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid QBLNGNYEHIW;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid WTPQTOUXYFH;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid HHRNORXEOVL;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid VAWWCYWDOFA;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid CPDGSUVAPWA;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid PZZLTYAFQTG;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid UADJCKCFHDC;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid DHSTGEAEHJO;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid SBAAQVXUWSZ;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid CMTOUYHMGRD;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid SXSMESFEOBY;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid SSNNPBQJPFV;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid EUHQEDKTSJN;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid WKUBVHHHSVY;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid EDQMHQHQOIH;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid DGKJKJMZQRW;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid UDLSDCXUZGG;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid DYHABRJZWQL;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid AHEEQBRKXMB;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid BSBDXSPKEDP;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid EPVSUCFXSJP;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid UQDCHJDLMER;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid SIHGCHPVCGL;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid PHSNNMPXSCU;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid ZGMFDXLZCDD;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid TOTFQGOWEJW;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid QLFJOLSIKVA;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid IHLZZNWZHYO;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid CBOQETGSJEW;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid BOYQTOFUONZ;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid LKEQSMUFMZA;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid KCHFNTNEHTL;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid FFLTLRPAAXB;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid FFRAIYIXKIK;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid FFWHGFCUTTT;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid KNRLHAGXRIM;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid NJOEIPFWULG;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid NKDZAJNOWTH;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid WMFQZAAIKYN;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid CJTHEAPTCPL;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid WRWFGYOQSEJ;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid HTTBMOZHKQC;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid YRXYXBJAALB;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid CWNQYGENHMJ;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid AQJLTDSUZQS;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid DGRARDYERQM;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid TFOHSBOWETL;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid EOFYTMCITVD;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid MCWKNEZAMJP;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid RNYUOCAOCJB;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid MPJJVKMCQOO;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid BZDJAZXFLJQ;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid UHAAPJPZARB;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid GBNFNDVAPGV;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid GAUGIWRSCCM;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid DHDPVJCNHIR;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid JQRMRZEPSCH;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid KXMLHNPAMXP;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid TQHXYEELNDJ;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid PBPJCFSBMPK;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid AYZJXUBPZLV;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid NXNTULCUBLU;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid APFHCOAKDJU;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid NGANMHHJKPC;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid GDSZEPVRCGZ;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid LBBWPFYUZOT;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid JFJQGIUQSEP;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid SLGWTUCGBGP;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid JNKMCNZXRGN;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid HVIJYBRKFRH;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid BNTFRHMSLPP;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid NVLXSOLRPRY;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid PDKODPVPQXR;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid NBCGOOWQCER;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid VXZBRPHUCHU;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid VXIIPWOBWIR;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid XEERBKNEEZH;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid FZWRKCBRITB;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid AMVSOLUNACJ;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid HLHVNTCQRKX;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid JKHHWZTJZNV;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid QCOPSCZRBIO;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid QHETWSGLRQB;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid FDCSHXTAOOH;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid EKLKQVRFMOB;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid RYZOFGZSNVI;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid EPLRSSXOXZS;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid JMENSVFVXQG;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid YFYTFDIBVVZ;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid WBXYWYCPLZG;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid BYUUZGIOVCT;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid XUIGQZVXIHC;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid XTJFTFCATRJ;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid VJLRYJEFQVB;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid TOGBWAKMLJT;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid QRSDIJNVYRA;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid QPYLLWYFQOH;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid KTSLYLDFVNZ;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid NCUUNJNLZBI;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid TDKIVYJGDPQ;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid YWDWGSKOZYZ;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid ZZTELEPUCGY;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid VYZMYUMJRTT;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid XXUEUUQZVEE;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid NGHTAEIJBPX;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid FEFIPSFXKWX;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid NCSWMEQGQZQ;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid KVAUDOTHSMC;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid OVWMNBNMTOD;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid RZIPGTIRPHE;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid FXGAJIQVVKO;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid FOVQTBDKFJL;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid TPTSYDDNDXQ;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid DAGQXBHRLXV;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid TWSUKYMYIKB;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid JOQXEFCFWMI;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid APFBWSJMNBU;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid JYCKYBPCOZV;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> ZHTYQJVFSBJ;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> QUONICWTLVB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> EDKERCDXLJU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8479E50", Offset = "0x8478C50", VA = "0x188479E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> ZNOYRQSPZIC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8479DF0", Offset = "0x8478BF0", VA = "0x188479DF0")]
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
	public static class ZHNNAOQYEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x848D960", Offset = "0x848C760", VA = "0x18848D960")]
		public static bool FQDXKEFBUOZ(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x848D550", Offset = "0x848C350", VA = "0x18848D550")]
		private static bool FQDXKEFBUOZ(DHZNTPEYEJU a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface GLLDWSUJCQL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(QXBKXEEMRQV data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, ZLQUBFCQAKZ circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly PWYZVPLOZDE Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<TFJYNGUFQVY> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<TFJYNGUFQVY> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<VTHPCPYYILP> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<DERVXWIACXB>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JLUPJSLAMZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x848D470", Offset = "0x848C270", VA = "0x18848D470")]
		public R1CreateTemplateParams(PWYZVPLOZDE circuits, IEnumerable<TFJYNGUFQVY> rootData, IReadOnlyList<TFJYNGUFQVY> allPersistableData, Id32<VTHPCPYYILP> sourceGraphId, IReadOnlyList<Id128<DERVXWIACXB>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly PWYZVPLOZDE Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<TFJYNGUFQVY> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<VTHPCPYYILP> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<DERVXWIACXB>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x848D4E0", Offset = "0x848C2E0", VA = "0x18848D4E0")]
		public R2CreateTemplateParams(PWYZVPLOZDE circuits, Id32<VTHPCPYYILP> sourceGraphId, IReadOnlyList<Id128<DERVXWIACXB>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<TFJYNGUFQVY> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EHUOURJDVNH : CSFDYVXFWCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid EHOEKHLZQZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> HUAUDYBWUTA;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4F37770", Offset = "0x4F36570", VA = "0x184F37770")]
		private EHUOURJDVNH(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x847A3B0", Offset = "0x84791B0", VA = "0x18847A3B0")]
		public static EHUOURJDVNH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x847A730", Offset = "0x8479530", VA = "0x18847A730")]
		private static Dictionary<Guid, Guid> PYPAYJJXWNR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x847A080", Offset = "0x8478E80", VA = "0x18847A080")]
		public static EHUOURJDVNH CTKBGNUHOIM(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x847A440", Offset = "0x8479240", VA = "0x18847A440")]
		public static EHUOURJDVNH OEWUHPEEZOJ(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x847A7E0", Offset = "0x84795E0", VA = "0x18847A7E0")]
		public Dictionary<Guid, Guid> QSKWMKEIYXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
		public Dictionary<Guid, Guid> IIKIVKDBAUX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8479EB0", Offset = "0x8478CB0", VA = "0x188479EB0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x847A090", Offset = "0x8478E90", VA = "0x18847A090")]
		public void JCVZTMYAKLY(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8479F30", Offset = "0x8478D30", VA = "0x188479F30")]
		public Guid BSAESOTYQEQ([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x847A310", Offset = "0x8479110", VA = "0x18847A310")]
		public Guid MIKDDXUXIIF([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x847A850", Offset = "0x8479650", VA = "0x18847A850")]
		public bool UPCYSYDSOSO([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x847A850", Offset = "0x8479650", VA = "0x18847A850", Slot = "4")]
		private bool QXHVKJJUJAS([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface CCSKCIJAICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AZLSCZYJIDM(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RABOZAYLBTA(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DDTVUPGWXEB
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
	public abstract class PFBNSOLEDRT : CCSKCIJAICJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LMLUTUHYETE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string NIKLBOMTNZR
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public LMLUTUHYETE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8488550", Offset = "0x8487350", VA = "0x188488550", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8488610", Offset = "0x8487410", VA = "0x188488610", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84884C0", Offset = "0x84872C0", VA = "0x1884884C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> GZIMJFDXMSY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84884C0", Offset = "0x84872C0", VA = "0x1884884C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? IQYQIJYJBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? ORKZCDLPXAH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> KGCTQIBYOUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x848CDC0", Offset = "0x848BBC0", VA = "0x18848CDC0")]
			[IteratorStateMachine(typeof(LMLUTUHYETE))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? HXDQBMJVAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool QKLLXANAZBV
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool FMQWUNKAYVI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> IGEHDTUAMWF(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool MVEDOESBROD(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x848CEE0", Offset = "0x848BCE0", VA = "0x18848CEE0")]
		public void OAGZMZWRPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE07220", Offset = "0xE06020", VA = "0x180E07220")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x848C990", Offset = "0x848B790", VA = "0x18848C990", Slot = "4")]
		public bool AZLSCZYJIDM(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x848D310", Offset = "0x848C110", VA = "0x18848D310", Slot = "5")]
		public bool RABOZAYLBTA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x848CE20", Offset = "0x848BC20", VA = "0x18848CE20")]
		private bool MPLGBJPDAJU(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x848CC40", Offset = "0x848BA40", VA = "0x18848CC40")]
		protected List<Guid> FLUBRQPGQBB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected PFBNSOLEDRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class GUUJKLMFSWV
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CLBNUKTSEYG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public PWYZVPLOZDE JBXZWCYVPZY;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public CLBNUKTSEYG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x848EAA0", Offset = "0x848D8A0", VA = "0x18848EAA0")]
			internal Id32<FZPOOBNDDMS> AWSQOQXSPFO((Id32<VTHPCPYYILP> GraphId, Id32<DERVXWIACXB> NodeId) i)
			{
				return default(Id32<FZPOOBNDDMS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int UKUQTSNTJLM = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<FZPOOBNDDMS>, MCLMOCYLKQM> BZPDLUANOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long YCYPHOWZBQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long HIFQJEXEVKR;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<FZPOOBNDDMS, int?> OVIIBTAXOME;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long JLRPVDWONAW;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long VKZLEZZDKSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x847AA00", Offset = "0x8479800", VA = "0x18847AA00")]
		public static GUUJKLMFSWV GRZIDZKMIJS(PWYZVPLOZDE a, Id128<VTHPCPYYILP> b, [Optional] GUUJKLMFSWV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x847B070", Offset = "0x8479E70", VA = "0x18847B070")]
		public static (long, long) VWGEPOBHYZI(PWYZVPLOZDE a, Id32<VTHPCPYYILP> b, Id32<DERVXWIACXB> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x847AF40", Offset = "0x8479D40", VA = "0x18847AF40")]
		public static long SQKAGTGZMPL([In] ReadOnlySpan<Id32<FZPOOBNDDMS>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x847A8C0", Offset = "0x84796C0", VA = "0x18847A8C0")]
		private static long BDSFNLWSQMW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8488440", Offset = "0x8487240", VA = "0x188488440")]
		public GUUJKLMFSWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class MCLMOCYLKQM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long GREWHVQIKRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC607C0", Offset = "0xC5F5C0", VA = "0x180C607C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long FHFOUCUYAOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xBD3890", Offset = "0xBD2690", VA = "0x180BD3890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F98010", Offset = "0x7F96E10", VA = "0x187F98010")]
		public MCLMOCYLKQM(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class GOAKJARPUTG
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> CSQWQVERLUX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class SPPWNOKDTHH
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class WGGVHNYXUDK : IEnumerable<TFJYNGUFQVY>, IEnumerable, IEnumerator<TFJYNGUFQVY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private TFJYNGUFQVY LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData ZPWYBVCTMCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData ITWZORAPZCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams NEXZZTUJFHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams DGTKJZDZLKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int QZMPRZMGFLM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private TFJYNGUFQVY WGZVSBEZAHH
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public WGGVHNYXUDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x849EFD0", Offset = "0x849DDD0", VA = "0x18849EFD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x849F0E0", Offset = "0x849DEE0", VA = "0x18849F0E0", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x849EE70", Offset = "0x849DC70", VA = "0x18849EE70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<TFJYNGUFQVY> TOKAUCGWGOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x849EE70", Offset = "0x849DC70", VA = "0x18849EE70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8499740", Offset = "0x8498540", VA = "0x188499740")]
		public static SpawnableTemplateData IKVUDYEURTE([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84998D0", Offset = "0x84986D0", VA = "0x1884998D0")]
		public static SpawnableTemplateData IKVUDYEURTE([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x849C630", Offset = "0x849B430", VA = "0x18849C630")]
		private static HashSet<Id128<MIEKGKNYHZF>> WXHCZMTPKDK(IReadOnlyList<TFJYNGUFQVY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x849BFA0", Offset = "0x849ADA0", VA = "0x18849BFA0")]
		private static void UALKOUKLBLT(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8499D50", Offset = "0x8498B50", VA = "0x188499D50")]
		public static Result<EHUOURJDVNH, TryCloneTemplateError> OCARBFQBXIE(SpawnableTemplateData a, SpawnTemplateParams b, EHUOURJDVNH? srcRemapper, bool c)
		{
			return default(Result<EHUOURJDVNH, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84993A0", Offset = "0x84981A0", VA = "0x1884993A0")]
		[IteratorStateMachine(typeof(WGGVHNYXUDK))]
		private static IEnumerable<TFJYNGUFQVY> CLUTFOTFHLL(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x849B370", Offset = "0x849A170", VA = "0x18849B370")]
		private static void PFTFYZXTWYO(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x849B920", Offset = "0x849A720", VA = "0x18849B920")]
		private static bool QZUIGJBKHQJ(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8499A60", Offset = "0x8498860", VA = "0x188499A60")]
		private static Dictionary<Guid, DHZNTPEYEJU> JXNDXIKPSVT(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x849B890", Offset = "0x849A690", VA = "0x18849B890")]
		private static void PWRODNRFORZ(bool a, TFJYNGUFQVY b, EHUOURJDVNH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84994B0", Offset = "0x84982B0", VA = "0x1884994B0")]
		private static void EHLEDDTGKRB(TFJYNGUFQVY a, Guid b, SpawnTransformData? c, Dictionary<Guid, DHZNTPEYEJU> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x849B3E0", Offset = "0x849A1E0", VA = "0x18849B3E0")]
		private static void PSGLYERBFSS(IEnumerable<TFJYNGUFQVY> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public PWYZVPLOZDE circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public DDTVUPGWXEB roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public GLLDWSUJCQL circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<VTHPCPYYILP> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public TCUPUQZQHHZ globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<TFJYNGUFQVY> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public LYCITQCZXRT photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 FPNBMRBYURJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x849D0F0", Offset = "0x849BEF0", VA = "0x18849D0F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS LNJJHCHAUWP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x849D200", Offset = "0x849C000", VA = "0x18849D200")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x149C630", Offset = "0x149B430", VA = "0x18149C630")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x849D2D0", Offset = "0x849C0D0", VA = "0x18849D2D0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x849CD70", Offset = "0x849BB70", VA = "0x18849CD70")]
		public static SpawnTransformData IOOLQFCEREN(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x849D3A0", Offset = "0x849C1A0", VA = "0x18849D3A0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x849D3C0", Offset = "0x849C1C0", VA = "0x18849D3C0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x849D060", Offset = "0x849BE60", VA = "0x18849D060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x849CB60", Offset = "0x849B960", VA = "0x18849CB60")]
		public SpawnTransformData EDYJFNEDNWZ(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x849CFF0", Offset = "0x849BDF0", VA = "0x18849CFF0")]
		public static SpawnTransformData KZRFHTOXRMX(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x849D240", Offset = "0x849C040", VA = "0x18849D240")]
		public readonly CircuitsRigidTransform ZOOIZEOBGCD()
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
		private readonly GVGCNFONGHQ _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1765950", Offset = "0x1764750", VA = "0x181765950")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, GVGCNFONGHQ innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x849D520", Offset = "0x849C320", VA = "0x18849D520")]
		public YFJSVKAVCRZ MIAUCCTVLLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x849D590", Offset = "0x849C390", VA = "0x18849D590")]
		public static Result<EHUOURJDVNH, TryCloneTemplateError> New(DQYGXZOXXVU<None> innerError)
		{
			return default(Result<EHUOURJDVNH, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x849D700", Offset = "0x849C500", VA = "0x18849D700")]
		public static Result<EHUOURJDVNH, TryCloneTemplateError> New(YFJSVKAVCRZ innerError)
		{
			return default(Result<EHUOURJDVNH, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x849D640", Offset = "0x849C440", VA = "0x18849D640")]
		public static Result<EHUOURJDVNH, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<EHUOURJDVNH, TryCloneTemplateError>);
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
	public class DDJYUHUZCAO : IDisposable, NCEVONWFTET
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> QQWEIQWLFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float QWPPTMESNIZ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags SREKYBTSWGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool RXJAEQWSGGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x848FA60", Offset = "0x848E860", VA = "0x18848FA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool YOINKCOGFNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x848F830", Offset = "0x848E630", VA = "0x18848F830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> JYOBFLFMSYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int SVIUOKMYGKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x848F140", Offset = "0x848DF40", VA = "0x18848F140", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GHMYKXALIJE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8490820", Offset = "0x848F620", VA = "0x188490820")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8491AF0", Offset = "0x84908F0", VA = "0x188491AF0")]
		public DDJYUHUZCAO(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x848FA00", Offset = "0x848E800", VA = "0x18848FA00", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84914D0", Offset = "0x84902D0", VA = "0x1884914D0")]
		public Vector3 ZCTXRKJQNLN(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8490960", Offset = "0x848F760", VA = "0x188490960", Slot = "6")]
		public Quaternion WGDVDFOOUDK(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x848FD10", Offset = "0x848EB10", VA = "0x18848FD10", Slot = "5")]
		public Vector3 MLYZUJTJOSR(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8490670", Offset = "0x848F470", VA = "0x188490670", Slot = "7")]
		public float REIWLWCJTJK(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8490A90", Offset = "0x848F890", VA = "0x188490A90")]
		public void WZMVKUJKAOO(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x848F840", Offset = "0x848E640", VA = "0x18848F840")]
		private bool DDCPNWTTZOW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8491370", Offset = "0x8490170", VA = "0x188491370")]
		public void XOYZSAVXHEW(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x848FA70", Offset = "0x848E870", VA = "0x18848FA70")]
		public void IXEXWTSDFTH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84906D0", Offset = "0x848F4D0", VA = "0x1884906D0")]
		public void SFRHCRBOMZO(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x848FB60", Offset = "0x848E960", VA = "0x18848FB60")]
		public void LTGAJPGEHTK(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84919A0", Offset = "0x84907A0", VA = "0x1884919A0")]
		public void ZZMXGXVCZZE(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x848F8A0", Offset = "0x848E6A0", VA = "0x18848F8A0")]
		public void DSYIBUWAGXL(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x848FDB0", Offset = "0x848EBB0", VA = "0x18848FDB0")]
		public static Quaternion OFOTDNNFSGP(Quaternion a, int b, float c, NCEVONWFTET d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x848F180", Offset = "0x848DF80", VA = "0x18848F180")]
		public Bounds BWUZLTMJGFH(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x848FB00", Offset = "0x848E900", VA = "0x18848FB00", Slot = "10")]
		public virtual void LLYYRHYPRVJ(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84905C0", Offset = "0x848F3C0", VA = "0x1884905C0")]
		public NativeList<CurvePointData> PQRSLQXUFKR(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x848F0C0", Offset = "0x848DEC0", VA = "0x18848F0C0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x848EB70", Offset = "0x848D970", VA = "0x18848EB70")]
		public Quaternion AXUXEIOGSTM(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x848EC30", Offset = "0x848DA30", VA = "0x18848EC30")]
		public CurvePoint QVIZCTRCFLY(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x848EF20", Offset = "0x848DD20", VA = "0x18848EF20")]
		public LYVDMMZZPSR VJNXIYHAJIA(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class LDJIXSMNEVR : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8493950", Offset = "0x8492750", VA = "0x188493950", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8493320", Offset = "0x8492120", VA = "0x188493320")]
		private void FSDCTBYCLGK(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x84938F0", Offset = "0x84926F0", VA = "0x1884938F0")]
		private void FSDCTBYCLGK(Dictionary<Guid, Guid> a, IUKPUAKSXXP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84930A0", Offset = "0x8491EA0", VA = "0x1884930A0")]
		private void FSDCTBYCLGK(Dictionary<Guid, Guid> a, FELJCXHVJFI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public LDJIXSMNEVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class JCSIYJSEJEK : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8492E90", Offset = "0x8491C90", VA = "0x188492E90", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public JCSIYJSEJEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class KYKBBAFRJVJ : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8492F40", Offset = "0x8491D40", VA = "0x188492F40", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KYKBBAFRJVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class EXGECYSBCUP : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8491EF0", Offset = "0x8490CF0", VA = "0x188491EF0", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public EXGECYSBCUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class YCKBUHSIRLH : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x849F2E0", Offset = "0x849E0E0", VA = "0x18849F2E0", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YCKBUHSIRLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class FSHZIJHDGGK : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8492050", Offset = "0x8490E50", VA = "0x188492050", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public FSHZIJHDGGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HLOUKWVFOUO : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8492550", Offset = "0x8491350", VA = "0x188492550", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HLOUKWVFOUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class OZKXEYGSNSZ : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84939D0", Offset = "0x84927D0", VA = "0x1884939D0", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public OZKXEYGSNSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class WSGVCDMHZLB : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x849F120", Offset = "0x849DF20", VA = "0x18849F120", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public WSGVCDMHZLB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class VKVQKDASVMX : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x849EB80", Offset = "0x849D980", VA = "0x18849EB80", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public VKVQKDASVMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class YOXGEQJJKBH : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x849F500", Offset = "0x849E300", VA = "0x18849F500", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YOXGEQJJKBH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class WEIBLCXXEPG : LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly FAQLBFBELLM TSMMGFHDNLF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x849ED40", Offset = "0x849DB40", VA = "0x18849ED40", Slot = "4")]
		public void OJSJZKUHMRL(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public WEIBLCXXEPG()
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
		public LYCITQCZXRT photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface LIUIXJYMBQY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OJSJZKUHMRL(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class CCSCMXMJNUF
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly LIUIXJYMBQY[] PASVPKVGTNB;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x848E010", Offset = "0x848CE10", VA = "0x18848E010")]
		public static void HAOGLXHMTRM(TFJYNGUFQVY a, EHUOURJDVNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x848D990", Offset = "0x848C790", VA = "0x18848D990")]
		public static void BDLCGTSMWKY(TFJYNGUFQVY? data, EHUOURJDVNH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x848E290", Offset = "0x848D090", VA = "0x18848E290")]
		public static void MXAJYONAMCG(TFJYNGUFQVY? data, EHUOURJDVNH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x848DC20", Offset = "0x848CA20", VA = "0x18848DC20")]
		public static void FQDXKEFBUOZ(PersistableCloneParams a)
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
		public TFJYNGUFQVY viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8493E60", Offset = "0x8492C60", VA = "0x188493E60")]
		public Guid AVEDNPSUGWP(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface LYCITQCZXRT
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> NBKGKXCTZDO;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> PKNVMXHQJMW;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> AZVCEBLKUWQ;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker NPKBFBYALZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> RIOZBPUWHJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> KOAVOCTQBOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> BMSOQTOBGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> PZBURVXQUEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> ZHTBHDCQRHQ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> BWLATSPGRZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> UXKQXFHTXYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> XPKRNKKHQKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> NSEZCGNWGWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8494E30", Offset = "0x8493C30", VA = "0x188494E30")]
		public static void JRGAXNUYQIK(SpawnableTemplateData a, DFMOGWYNWIS b, EHUOURJDVNH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8493F10", Offset = "0x8492D10", VA = "0x188493F10")]
		public static PersistedRoomDataReferences DRXURHINSHA(PersistedRoomData a, DFMOGWYNWIS? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8496530", Offset = "0x8495330", VA = "0x188496530")]
		public static PersistedRoomDataReferences KUKDLQNTPMF(SpawnableTemplateData a, DFMOGWYNWIS? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8498420", Offset = "0x8497220", VA = "0x188498420")]
		public static PersistedRoomDataReferences UBFLQCEKIXT(SZCDXXODIBX a, JKGVAFPNBIH b, DFMOGWYNWIS? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8494770", Offset = "0x8493570", VA = "0x188494770")]
		public static PersistedRoomDataReferences FMFXKLUOQSK(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8498A00", Offset = "0x8497800", VA = "0x188498A00")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8498830", Offset = "0x8497630", VA = "0x188498830")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8496F10", Offset = "0x8495D10", VA = "0x188496F10")]
		private void NHGUJRTYNBV(PersistedRoomData a, DFMOGWYNWIS? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8497C00", Offset = "0x8496A00", VA = "0x188497C00")]
		private void NHGUJRTYNBV(SpawnableTemplateData a, DFMOGWYNWIS? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84941D0", Offset = "0x8492FD0", VA = "0x1884941D0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8497230", Offset = "0x8496030", VA = "0x188497230")]
		private void NHGUJRTYNBV(SZCDXXODIBX? a, DFMOGWYNWIS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84971B0", Offset = "0x8495FB0", VA = "0x1884971B0")]
		private void NHGUJRTYNBV(JKGVAFPNBIH? a, DFMOGWYNWIS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x84965B0", Offset = "0x84953B0", VA = "0x1884965B0")]
		private void NHGUJRTYNBV(YAHPONFDZRR? a, DFMOGWYNWIS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x84980A0", Offset = "0x8496EA0", VA = "0x1884980A0")]
		private static bool QAQXMEULRIA(YAHPONFDZRR a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8493F90", Offset = "0x8492D90", VA = "0x188493F90")]
		private static bool ESDQXYUSOME(YAHPONFDZRR a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8495E60", Offset = "0x8494C60", VA = "0x188495E60")]
		private static void JRGAXNUYQIK(JKGVAFPNBIH? root, DFMOGWYNWIS a, EHUOURJDVNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8495F30", Offset = "0x8494D30", VA = "0x188495F30")]
		private static void JRGAXNUYQIK(YAHPONFDZRR? customProperties, DFMOGWYNWIS a, EHUOURJDVNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84961C0", Offset = "0x8494FC0", VA = "0x1884961C0")]
		private static void JRGAXNUYQIK(SZCDXXODIBX? root, DFMOGWYNWIS a, EHUOURJDVNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8495810", Offset = "0x8494610", VA = "0x188495810")]
		private static void JRGAXNUYQIK(CircuitsV2.Protobuf.CircuitNodeData? node, DFMOGWYNWIS a, EHUOURJDVNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8496790", Offset = "0x8495590", VA = "0x188496790")]
		private void NHGUJRTYNBV(CircuitsV2.Protobuf.CircuitNodeData? a, DFMOGWYNWIS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8497E90", Offset = "0x8496C90", VA = "0x188497E90")]
		private void OQQLAYGRHQX(Guid? a, DFMOGWYNWIS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8496B10", Offset = "0x8495910", VA = "0x188496B10")]
		private void NHGUJRTYNBV(TFJYNGUFQVY? a, DFMOGWYNWIS? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84949E0", Offset = "0x84937E0", VA = "0x1884949E0")]
		private static void JRGAXNUYQIK(TFJYNGUFQVY? viewData, DFMOGWYNWIS a, EHUOURJDVNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8494970", Offset = "0x8493770", VA = "0x188494970")]
		private void FTDLQPFAZEK(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84982F0", Offset = "0x84970F0", VA = "0x1884982F0")]
		private void TFOVDZHLOGC(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84982A0", Offset = "0x84970A0", VA = "0x1884982A0")]
		private void TFOVDZHLOGC(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84983C0", Offset = "0x84971C0", VA = "0x1884983C0")]
		private void TFOVDZHLOGC(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class PHOOOYSIKDX : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> NGBAGADXDHI;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x8493C40", Offset = "0x8492A40", VA = "0x188493C40", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x8493D00", Offset = "0x8492B00", VA = "0x188493D00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x8493DB0", Offset = "0x8492BB0", VA = "0x188493DB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x8493B60", Offset = "0x8492960", VA = "0x188493B60", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
			public PHOOOYSIKDX(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8493AC0", Offset = "0x84928C0", VA = "0x188493AC0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8493B10", Offset = "0x8492910", VA = "0x188493B10", Slot = "9")]
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
			private sealed class SSGJZRAAPJJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts FNBWZDPUGEI;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry WZFWHXXWVTF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xB611B0", Offset = "0xB5FFB0", VA = "0x180B611B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x849CAD0", Offset = "0x849B8D0", VA = "0x18849CAD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
				[DebuggerHidden]
				public SSGJZRAAPJJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x849C9D0", Offset = "0x849B7D0", VA = "0x18849C9D0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x849CB20", Offset = "0x849B920", VA = "0x18849CB20", Slot = "8")]
				[DebuggerHidden]
				private void USEBYPNATQY()
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
			private ICollection FXUNZICBYXR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x8498C50", Offset = "0x8497A50", VA = "0x188498C50", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x84990F0", Offset = "0x8497EF0", VA = "0x1884990F0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x84991D0", Offset = "0x8497FD0", VA = "0x1884991D0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool PIUOJRYBLAS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8499210", Offset = "0x8498010", VA = "0x188499210", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool MZZDBGRQKGF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x8499050", Offset = "0x8497E50", VA = "0x188499050", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection KBHFSCXAAAV
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8498E00", Offset = "0x8497C00", VA = "0x188498E00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int MQXLCEZLRWO
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8498BB0", Offset = "0x84979B0", VA = "0x188498BB0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool FKEOYGGWULX
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x84990A0", Offset = "0x8497EA0", VA = "0x1884990A0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object GJRMOMVQBBS
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x8498F90", Offset = "0x8497D90", VA = "0x188498F90", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8498FE0", Offset = "0x8497DE0", VA = "0x188498FE0")]
			[IteratorStateMachine(typeof(SSGJZRAAPJJ))]
			private IEnumerator<DictionaryEntry> OVZDGMMYOCK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8498E50", Offset = "0x8497C50", VA = "0x188498E50", Slot = "19")]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8498CE0", Offset = "0x8497AE0", VA = "0x188498CE0", Slot = "13")]
			private IDictionaryEnumerator FSSIQWNFZZV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8498C00", Offset = "0x8497A00", VA = "0x188498C00", Slot = "9")]
			private void FHBTCLDHMCO(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8498B60", Offset = "0x8497960", VA = "0x188498B60", Slot = "10")]
			private void CLXVJUTZKLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8498DB0", Offset = "0x8497BB0", VA = "0x188498DB0", Slot = "8")]
			private bool GLGFJMHKQSC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8498F40", Offset = "0x8497D40", VA = "0x188498F40", Slot = "14")]
			private void LLOLQSNQMAD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8498EF0", Offset = "0x8497CF0", VA = "0x188498EF0", Slot = "15")]
			private void JFQOIVHESHV(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class GCXMXJGWWLX : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention FNBWZDPUGEI;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry WZFWHXXWVTF
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xB611B0", Offset = "0xB5FFB0", VA = "0x180B611B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x84922B0", Offset = "0x84910B0", VA = "0x1884922B0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
				[DebuggerHidden]
				public GCXMXJGWWLX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x8492190", Offset = "0x8490F90", VA = "0x188492190", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8492300", Offset = "0x8491100", VA = "0x188492300", Slot = "8")]
				[DebuggerHidden]
				private void USEBYPNATQY()
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
			private ICollection FXUNZICBYXR
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x84927E0", Offset = "0x84915E0", VA = "0x1884927E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x8492C20", Offset = "0x8491A20", VA = "0x188492C20", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8492D30", Offset = "0x8491B30", VA = "0x188492D30", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool PIUOJRYBLAS
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x8492D70", Offset = "0x8491B70", VA = "0x188492D70", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool MZZDBGRQKGF
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x8492B80", Offset = "0x8491980", VA = "0x188492B80", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection KBHFSCXAAAV
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x8492950", Offset = "0x8491750", VA = "0x188492950", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int MQXLCEZLRWO
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x8492740", Offset = "0x8491540", VA = "0x188492740", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool FKEOYGGWULX
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x8492BD0", Offset = "0x84919D0", VA = "0x188492BD0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object GJRMOMVQBBS
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8492AD0", Offset = "0x84918D0", VA = "0x188492AD0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2924A00", Offset = "0x2923800", VA = "0x182924A00")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8492B20", Offset = "0x8491920", VA = "0x188492B20")]
			[IteratorStateMachine(typeof(GCXMXJGWWLX))]
			private IEnumerator<DictionaryEntry> OVZDGMMYOCK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x84929A0", Offset = "0x84917A0", VA = "0x1884929A0", Slot = "19")]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8492830", Offset = "0x8491630", VA = "0x188492830", Slot = "13")]
			private IDictionaryEnumerator FSSIQWNFZZV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8492790", Offset = "0x8491590", VA = "0x188492790", Slot = "9")]
			private void FHBTCLDHMCO(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x84926F0", Offset = "0x84914F0", VA = "0x1884926F0", Slot = "10")]
			private void CLXVJUTZKLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8492900", Offset = "0x8491700", VA = "0x188492900", Slot = "8")]
			private bool GLGFJMHKQSC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8492A80", Offset = "0x8491880", VA = "0x188492A80", Slot = "14")]
			private void LLOLQSNQMAD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8492A30", Offset = "0x8491830", VA = "0x188492A30", Slot = "15")]
			private void JFQOIVHESHV(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x849D9A0", Offset = "0x849C7A0", VA = "0x18849D9A0")]
		public static UgcRoomSaveStatsDetailed DRXURHINSHA(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x849EA00", Offset = "0x849D800", VA = "0x18849EA00")]
		[CompilerGenerated]
		internal static int LPFVSYQXCOY([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x849E370", Offset = "0x849D170", VA = "0x18849E370")]
		[CompilerGenerated]
		internal static void LKERHYXAIYU(int a, [In] SZCDXXODIBX graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class DFMOGWYNWIS
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid RSTAMKDHVIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> UXKQXFHTXYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind SSNBWZUXQFA;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x849EB20", Offset = "0x849D920", VA = "0x18849EB20")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly EHUOURJDVNH VKIAKNLYBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> XWDSDCNBWYR;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public EHUOURJDVNH DXCLOEKYWAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8491B70", Offset = "0x8490970", VA = "0x188491B70")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8491D70", Offset = "0x8490B70", VA = "0x188491D70")]
		public bool QVAMTAUTEWX(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8491E60", Offset = "0x8490C60", VA = "0x188491E60")]
		public DFMOGWYNWIS()
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
