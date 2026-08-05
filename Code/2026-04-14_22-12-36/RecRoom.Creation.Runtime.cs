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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x97A6DC0", Offset = "0x97A59C0", VA = "0x1897A6DC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JOANJCEHBCL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LPHMUVZWSST;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> QAIJSLHSKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> TIQQVEVQKGV;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> TWCAMBPKFKK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JVWXCOYWRYQ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string OBGTHXJXOCR;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string KDNCAENPXSY;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x97A30D0", Offset = "0x97A1CD0", VA = "0x1897A30D0")]
	public static bool QJOKQRMMSML(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x97A3040", Offset = "0x97A1C40", VA = "0x1897A3040")]
	public static bool ORIMWQQTUFL(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x97A2970", Offset = "0x97A1570", VA = "0x1897A2970")]
	public static string MSPNAOJNOAQ(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x97A6D00", Offset = "0x97A5900", VA = "0x1897A6D00", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EELRHQVLONY
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid DBRSDTZYSUL;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid WWYCMPWBQJQ;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid WIBELTIBVAD;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid GLGZRPMVFHP;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid DVEERKJOGON;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid AJLTHOATNHG;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid VTDJQFASKGY;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid HSSMDFNVIOY;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid ZCUZAXWWTSN;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid HXISSSZQSIS;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid CHQCCJSHWQC;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid OORDYKCRWLQ;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid YOLCKJDTEGT;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid KCUQQISUMPM;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid YSYGMFCVPBL;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid HMCHKUENJMW;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid ZDCDNAAHNAF;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid UQALSOJAZRE;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid AQDAWVSEVKI;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid OKYGZSQTHZP;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid PDOMPKWPNKO;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid KOJJUEDQTFK;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid DNMBYETZLOF;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid UVKUVRJCIQD;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid LILVKWVMQNJ;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid OAHFBGCAIFD;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid QDLSUBFXKLJ;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid LGVNOBDEVSB;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid OOJOWCNVTAU;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid FKZYBUBTULD;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid UWLVKPCOQIW;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid QPKRDJTIKSC;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid ASLZGSQGSXF;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid TTEOAYBYSQJ;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid WBOHDNQLYCE;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid TTZWXTFHPDV;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid UFAVEXDCDNM;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid FRBAULZYZOM;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid LFLTLJDVHXA;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid SMQAQVJKRXS;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid ACXAALPAUJU;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid VEIPDXWVLZA;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid ZGLVPEMQSVG;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid MFUABUGCRRC;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid EABFWOPMBYK;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid ZNPUUPENTGH;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid LMPDKBIQVVS;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid XLWPIDTFRCR;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid WOLQHJXJWZD;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid NCZAWNXQXRP;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid UJHWNMCVHDK;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid WQNMPKOMTRZ;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid EFJCHJJSOYO;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid KFHPASUKNYK;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid ADYAPRFLXXD;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid RDZDOMMKTHL;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid UMKQDTQDIVV;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid LTNQBTAOQJK;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid GPOWVUFPAZU;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid MDKUUVLZLWX;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid GBZYRQDMORP;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid URJBWQBSRLW;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid CRFMAMNQQKR;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid BKOLYXMSGJM;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid ARZJPZBNGWW;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid EEQLFCIOWWV;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid BEMHCXKZKXO;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid DDCHCFJNKQY;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid DSOTCLUSOEL;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid BMRMLOVKEBZ;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid VDMAQVJHLIW;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid XWSFHOVDFED;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid GRIQRPRSSGQ;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid FTYOSODDPPF;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid ZAJYKZRDZVQ;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid OQSKYBUUVUI;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid INGWYQAEHCD;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid LRGVQVMAMXX;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid VXSICNRKMBP;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid ILQIHHHXQOZ;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid ODPKILAJRVX;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid FCDHNUVOTWU;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid IKVNOOJNHGR;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid BQIUSNFTMZA;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid JSLJSGFOAOB;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid BSVRYHIHWRA;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid RPJZGVQTLYO;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid NLRONFMYTHK;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid FYFJNXCCWLV;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid PZZSCIUVUTY;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid LXRIYBUUIZI;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid YASKZYRLDDN;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid PPYFTEYAEYP;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid BHQEAESYDJU;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid JTPQVKPBPPA;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid WXBUSUDFYIG;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid STCCOJSGCME;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid FUUWOSVIPSG;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid RQCRCIIAXEX;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid JDZWSYAPKKW;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid TEKFPOTXFPE;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid EVMKQWFOHHX;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid IPDLDZHWQHU;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid THFSZYXOWTP;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid GGDCZDSNFDU;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid TGVFFLJUDWX;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid DXOCSCOEFEE;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid ZHYZLJGRAPQ;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid WULRJJJNJXF;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid CHUIAKCVTQU;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid GWOPBNRHUMB;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid CIEVUXQQMNM;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid WDSVAHQHUOT;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid CGZGLJBGHXK;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid YASCTCJBBEZ;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid ZGVOXOHCOYJ;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid ECHYWGFWPAA;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid CCBTXQBDAZE;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid HQVQVQZWYAZ;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid ERLRGSAHWHS;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid HGROJBUEGWU;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid BXFDVTCVNMR;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid MHNRARKNTLU;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid MQVHHPCNKZM;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid NFXKZLMDSRM;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid ZSOWJAVMERQ;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid HCISPJTFUEQ;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid ZWJKDAZFARG;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid NONNABUDMJK;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid TZRAZISBSAN;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid CXKGHJKBZFA;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid WFFBEEWLVAA;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid FFYCAOAEAII;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid RSZNKBRKGOL;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid XEUZSLXKQPG;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid AFBLRPNEMWD;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid ODCTQJQTLSV;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid HIEUFEVCSES;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid TZXIUGBSWMM;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid YYDUCQGUHHV;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid XMXJEMKDONT;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid RORWTZIXKNW;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid EHPWZQDWAMW;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid IMPIVKEKNMZ;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid MSXFLVTPVLN;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid PJRERCLMZLR;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid OIJWZFJRBYV;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid RJFSAQVMSAC;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid OLTWBNDYEMS;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid OLOPEGKAVBJ;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid OLJIGZQDLQA;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid OLEBJSWGCER;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid OKYUMMCISTI;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid OKTNPFILJHZ;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid OKOGRYONZWQ;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid BCRBLWLOXRA;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid IJGRCZGXTOQ;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid LYZMFVLHNVH;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid IZBWLQVGGOF;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid LYEHFVKZDUM;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid ATELKHQVKWX;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid XSXWBYVAAYB;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid KATWSOTCSUN;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid EORPDEHQWHA;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid BIRTDMKWQIY;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid ZYHBYIOWGGV;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid IGZMOFVOSJW;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid NYQCCYYFTRN;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid PNKCKYEOWQB;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid TTYSAEOXZOS;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid OKXLNGPHDAL;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid PMUHTDWWUIA;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid PMZOQKQUDTJ;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid PNZXCSMGYYC;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid ODGATSWRKAF;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid TROAOKNFNHE;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid LLKGCDKMJBV;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid OCQGBYOZHSE;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid FZEPDUDCMVX;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid YIJZRPKLPUA;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid HWLUWAUXGEK;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid NMOVVLFEABR;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid NIZVRTBDDFZ;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid PZUAFEMVYSV;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid JKVVRWBGGSX;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid DHNTWTFYYPH;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid DMKLVKNRXJE;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid DWGMOUNTFBP;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid DNZNUQDFZVG;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid GJKBYJAHLCW;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid XPQMQJMUXRW;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid VWKNXNGFOEK;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid WZNOKFNRNTJ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid XKKOZFBZIOF;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid MMTVSWBSIWM;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid GFBMTYRRFJU;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid SVZMIGYOZGB;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid PJZPVNQCNLI;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid XNSZOSUSLYA;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid WNTWWIJCHDD;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid AWVCITSGSHK;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid SXFGLRMHXLR;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid XJTYZDVVKNF;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid BRNPCZASFKW;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid JJDRLYLKDEL;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid XHZKCESCAIQ;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid TRPXTDMLLQG;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid SPDIHNFPKFS;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid PCVPSJLLTEP;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid KRWKGEONSTA;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid OXUYZDNHLJE;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid CEEEPVNLESF;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid SJHVVOSJJED;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid AYCSWYTMDEW;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid PRDGONENDHZ;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid TEGGTYDXCXM;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid GVJBSQSVPJJ;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid CBYREGVYGKH;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid SANGSVQSMSV;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid YMRRMDDJNEN;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid ETMWLAKIHTA;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid XRUETTATLZO;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid PMUJJASOMSF;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid VOJXULLISIW;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid WZZQXGYVXDF;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid USSEYQEMRJL;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid TFGXWAWJJWV;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid BLVTMHOGHJS;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid LYZPMNLPSYA;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid WATPZOHJPDB;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid KQPOGYVRWWK;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid XWTBXJCXSZT;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid IFYKHCXHTYO;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid LDCALZZXTBQ;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid YYTWEJWSGBW;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid QEZBKSQGGSS;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid GUYWWZFDUTG;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid IZXLQOVAHMO;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid UXAYXHOEHZP;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid SRIWIWAPKRW;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid ZOLHPODXXLM;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid SXZBJRFUVGP;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid HUNTFCCDNWK;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid EIPQOVXLFYV;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid ERTCIZATTQT;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid WBUHRJWMSRD;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid YGGBKYJRABO;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid MGHANFRCWLD;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid VVKQARLOAUA;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid LNZUQUGVKGM;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid EFVZPFKGGYB;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid AWBPZIMDVWQ;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid DRKZNXPHCWI;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid VEFUXGFUYJW;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid XWKOKRCWQKE;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid OATFSFJORJA;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid XRMJHMQFTWG;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid TXPGRIZTDOD;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid KPKGFZDPTGX;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid IRFSFPWSMXW;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid FYZPQSCGWGP;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid XUJWJSPNFOW;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid USXHYXXIRDI;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid LADOCSZUPIH;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid NTQMLUZZXPQ;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid ZEMEQIUWSNI;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid MCZTVFIIZWG;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid XWSMEEVPDSQ;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid VEKLVYFVLCY;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid ZWAFFOBXWMI;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid WXTLPOXXXZK;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid VKPLOJWGLER;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid NEEBFAIHUOJ;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid RTZFEVAJHKS;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid XEILVSDQSPT;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid VIFHPJYIOZA;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid FCGUYAFBFGK;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid TWMLMQFRWSV;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid TBLSEPQEZLW;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid GLGPTXPNOEC;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid IQOYSZZNJMA;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid ZWGOZNBLDOH;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid HYGDLVMCCTN;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid SXXEOKYECXJ;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid EEPEIFNGHOS;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid DBMYICDBODC;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid WIDYGPGWVOG;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid NCOJFZSPVRY;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid GIHVGKKHWVX;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid CHQWAXLYLNV;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid VPUFLBCKUYP;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid SNWXNFOPNHO;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid TORGGLOOKQU;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid BJZPFXBSRKF;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid SRXLJRGNQCZ;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid AIEPBLRDXUA;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid XPLBSJWNXRA;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid XVNKIDTNSCJ;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid IAGEHSGYJCW;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid VQDVLSEKZWP;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid JLNBZPSVAYA;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid MQAPDHKWLMA;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid PUVSHBREYVA;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid EMXBUPVDTAR;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid JTQVVYRPDJR;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid DXMYVIHPRUV;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid VGPLXIBOHEM;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid YBGSOOUGUSV;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid WLNKJFVVNMZ;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid EZJKRGNSSEH;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid NTMAVXPPIDV;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid TFQSYYPCQZO;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid XZAWWVXBDCU;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid PZIKEXPLYOO;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid LMIDZEXWJVG;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid RMXOUAPGDVS;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid BRHJXXDERVY;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid ACMOCWYKWKN;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid QGSBWQRTKJD;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid ZPIYRDCJZCG;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid XHCTVJFPVBV;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid CFUTQPEJRUN;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid YMLCHEPHXJV;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid ORSWGPWIVAC;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid EYMKHZALOFY;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid FAPPDMSZQRD;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid SKSYUMBMCWT;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid ZWUCAFXVBQZ;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid NIVINTWBYWF;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid UIOCKASVUSK;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid TEGGBMHMKWM;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid TVFUCRSUSLV;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid TNTVRMYHCIR;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid PGDJNRGKOFN;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid SCIVFQTZZFN;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid QFDAPMAENFO;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid GXMZCHXQJFK;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid LPPVXGKRITS;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid WLXULKCHMZB;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid QOFMAGRPFZN;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid NSSWICECIWG;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid TMATNEODZTK;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid NXXOAJECCUZ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid PRNZSYXVRWN;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid WPHLAUCMNQA;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid ZYPNRXDNDZP;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid JFINRSHZZSZ;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid VDAFSDXAAHI;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid RKBVAWZNNCN;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid TYQRWECGEPR;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid HUEAHIACCCQ;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid CVOVMXFVSWN;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid CDCOCROTFAK;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid LAPEPYKMNZV;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid SGXKOVTCJIR;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid WRLYPZSVYNR;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid CGBWMEECZNP;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid OQNREDLOTEG;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid DDJBZEXDRYG;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid RNUYNKZHZDJ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid OEKYQVIXWHY;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid AYQENTWQJAM;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid PHQXFEXACUY;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid DZHORODJLSR;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid JRLNVISGIOU;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid UULJIECJSCV;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid YRPKJMFSRMI;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid NETXXFBNVFT;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid MJAIQUAHODZ;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid BFGYOTRGUDC;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid ZECGDSLNWMM;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid OHSLQVFZZTO;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid UBRFYMCUCCI;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid BAYECQFRSCI;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid UYTVQPKNUFF;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid ROUAHNEQLFC;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid ZLDTHDVOCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid DUVWJNHSVWO;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid MCGZDRIHUDH;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid QULLCCWDCYQ;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid AZGQIPSBUFV;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid AZOXFHQFTWE;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid WVSVDRYULWL;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid GIXRIXLHXMW;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid SDHMMFUWPBZ;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid MOEVGJLMNWF;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid NCEECZWXEWC;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid NTKNQGOQPHF;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid SKJADXGDOEO;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid NRLYSACTADB;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid OYYRJGRMVLB;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid DYAVHTJTIWD;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid KIORKKMYKDP;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid CQJVWLTTUTC;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid LCHQFUXBAXU;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid PEBGUNCOMUV;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid CIMHJJHNXGQ;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid EOBUMKUOXFZ;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid HQIGCBYUNBD;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid COOMVRRNEBF;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid SVFBOTVZPBT;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid DFSEYAVJXHW;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid NOUZYLXUURR;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid RAIMWMLTQMI;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid XGQVZZRRKOI;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid IHKOWITNIWB;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid RRSCTKEDVCD;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid WVAJGRBQORK;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid KZBDZKNCMXY;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid QZALYKYUJVU;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid BVIKRUFTGFN;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid TFDKSFFQDRW;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid SQTRHSZCDEH;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid MEOHVXTKYOH;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid PHTNARBVVOU;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid GNZVOPFGLZM;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid SCPJVNJGVRK;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid OADIKAOLERJ;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid OCGXAOFOTJY;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid HVWCDZBQQRA;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid JPCZVYTPGTO;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid FYXFIMYKFLM;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid YVBVJXNDKUE;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid LPPJUZEWYVD;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid HBGGFDEIMEX;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid FNQRCVAOKVI;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid DOYSTHDSNDU;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid FNLKFOGRBJZ;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid FNGDIHMTRYQ;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid FNAWLASWINH;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid FMVPNTYYZBY;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid FMQIQNFBPQP;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid FMLBTGLEGFG;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid FPMBEDXQRTL;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid FPGUGXDTIIC;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid ADOADPCGACE;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid BZNCRCCWKGY;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid VHUJZLRNKFH;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid NSIGPNQGHGR;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid CFBKFPXIWZT;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid XLAQLTLPXJJ;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid WOAVEHWDGCK;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid HIORWBLJINU;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid PJSGNSADAFJ;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid UGGKPGQMENX;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid TZERVFVJEMU;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid NAOQNCKPIVY;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid XDKCZQELJXM;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid RSLODVSLKDD;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid WHNYWDNEVHS;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid MADEIHLWBLG;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid MIXVFPUNQOD;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid PMWRKTWUUAX;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid KCBVXBFJTVP;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid AIXXSSSCSRT;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid LXKTHNKTATQ;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid TKEHJCOIDRP;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid TJDYWUSVIMW;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid NMKMHAGFGMA;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid UVLIQMGMFQN;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid VHAHMQQESGY;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid BEZTXTEUFGF;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid ICCDUFVNTTX;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid MPAFOFKIAUC;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid RCKZMBRNKMC;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid EOSUCPOJUQE;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid XRMRHSNDXQI;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid PSAZUAVPNDS;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid RZJJICLVGXX;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid VFGBLWBBLBK;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid UJBUQBKSTNW;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid EDAQOJHTEOB;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid FAIWLJCMSZS;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid GRFPOKRLGOR;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid BSCSUYBAOAQ;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid YJYKFZMEVLS;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid XGGTVYPZHDJ;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid AKTTSAEBBUM;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid PCXKVKXYRQA;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid JKZUXSZHPJW;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid JTDKTBWJLZI;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid VXEBDQLTWWF;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid IODVDZBCEDH;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid HYDIHMOUGUJ;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid XVNIOTIILIV;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid UGVCGLEIEDH;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid YKRJPGILHUX;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid UKWACXSIFZO;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid MHZFFHUYMOX;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid HGSLXTXQQOB;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid HRVUIHUDTXK;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid XMVMIEIWBYC;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid FLYOXMHMPUL;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid ZLFFBLGIPOA;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid TEHVBFEUZFD;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid BPPFKQOTSCH;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid WKDVFSCYGRU;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid TCJSKMBROLY;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid HMEOMGGLUWO;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid IFDAHMVQUXQ;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid VZJGGFLFJCM;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid PJRGVQGAHZJ;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid JXMXFSKNWKZ;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid RMVEAZGDDME;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid SLFESUJZNHR;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid LALRYTFNQYU;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid CKQAXYDMXFT;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid DHSTKTAXMJO;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid LRKFEXSGPCJ;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid MREQRQWEJCW;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid NGBTXMZDVOH;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid ZQMNOHQVOTV;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid CWITECJVAQA;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid DRVUBNZAUMS;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid TIMVNDDIJBG;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid YSYMAFJQFEV;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid ZXGSMFNYVII;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid OJDNMRFUCAJ;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid OOHKYEFWQVF;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid DONZYNSELYC;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid WMCAHHMEMYY;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid WMHHEOGBWKH;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid ZGUNCIFLNRX;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid EVMFURKXBUH;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid HTKPOWRICYE;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid DINEVELJQAG;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid FSLXIGOGUVC;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid XCXYJYXINTH;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid QVYRBUIRDPK;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid IIKYLWAFNLH;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid TKRSSSSOWFW;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid JUZIFDOLGGK;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid KGPMJFCIDZR;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid FUDQDSZLQWA;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid BRIROVIUCAW;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid LXMVMNHCRBY;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid VSAMUVYBDSL;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid INFBKRQUBVR;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid VRUNDPOPBSM;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid SOVCKMKPCWO;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid QMRCHOGNMYR;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid AAFQVOMREOZ;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid PRMXCSAIVFU;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid UHPJQMLNPUE;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid VZCPTPFLZFW;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid KAXIASFZJYA;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid UOKMIQOKDAQ;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid SVYMXTAURLL;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid HUWMCPHNNUZ;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid BIMNOPDKYOW;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid TSVKXAHLNQH;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid LFTKFZVBLOP;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid MPROWJZNLAO;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid AENQWOPICLR;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid RMYNABIKHBK;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid CDDABQLXZNQ;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid CNGMMCYZUIL;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid NGPJOHKGUBD;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid STDBATKUQNT;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid VPYSNDQQTGZ;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid CXMGUHREBUN;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid QZAHPLHZLPF;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid FXKPJWBUGXC;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid NLIAZSIPIIB;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid IYKVJIYRGXS;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid IZJCPIDWHSS;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid QXKQMIXESTU;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid YESMDOADYMK;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid VXIPLDYXDSD;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid CXMPHLKSKNA;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid HSNXNELGUJD;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid NQCHGXWMMVN;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid NQHOEEQJWGW;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid NQMVBLKHFSF;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid SGGXZPJCRGQ;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid XFPMFYIJETW;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid XGFGXSQBHBX;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid TBATCDEGFZP;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid LYWQHXTJZJD;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid EYDHXUBTCPL;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid LUYGFBVABAW;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid VFBXKXINOIX;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid TYHLAMUWZKV;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid KRKYBXCBONM;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid NOEAFAHNOGM;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid JPHNMMAOSQZ;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid RJLNUHFMPSZ;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid UZKGHISCNHX;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid CLYJVAESCFB;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid HLCGOCAOGQK;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid LHPINZZKWEG;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid JAENZQGEHZV;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid CSTZMPTYJHL;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid JKTPQLBYEBW;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid HUBTIRCJLSV;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid URGYJZPLTHJ;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid TWEKNJZAXIR;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid RRZAVVPGZZN;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid FLDVFFGOQMY;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid FWLSICLUFID;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid HXUQXCFZWTA;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid STZLQQPUYUK;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid ULOTFAMYEYQ;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid VYXOUYZAOXP;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid HNXHIYYPXCT;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid YBBOUBPPNJR;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid FIYDZGGOIIX;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid DLWSXUCROOB;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid UYHJWBSGGVD;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid NQRNSEJFLSB;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid YSYENOLDXCG;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid IBDPQIBBSLJ;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid NSYNLDWIDJT;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid COAVPYUAXBE;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid OABVKRTZQOF;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid IREANHMLLHP;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid GJUVTZVMEZF;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid KTUMDJPMXLD;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid MYPBALYTLOH;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid DKIEQMOEQDN;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid ERSRIKOOGBA;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid GXSVEVYLRXT;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid GKOMDQUBGEL;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid HRQOXBMWYWB;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid NGMXDMWGJLU;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid JODAGBPBBKQ;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid OJDZNACIBJU;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid SMVSMOIRADJ;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid UQLZAGAIRDK;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid ELRUROGALKT;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid PTNZBSYNUJW;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid LHQCGFQGOOD;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid FQQXWJRJYNJ;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid LIQRHMTDHGB;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid OLPTOAUYJNE;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid MYZQZTFXWQT;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid SCCVBPHVWZF;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid MOMJJJHMJNA;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid MWHAGBUZTXQ;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid DQSYLVNGNWF;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid UGOCMZOXHZW;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid NQMUDLJNIKJ;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid MXIQTOHRQSU;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid DYPAICNZMHD;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid YFQATHQOPLB;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid TIEUMAFPNSS;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid HEUHTIAILSS;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid RHOKIFQAJRV;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid QITOKJQUWRE;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid CGGONTQNVGO;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid LTLPHOCHSOV;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid ADXVNHHTHOS;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid VWXNRDSVYYP;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid SEVRLKDHRRH;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid FLSGPXLMNOI;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid RELJOWDKVQG;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid ZLXCVECZWHZ;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> DXDJZXJJPFV;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> VLJGCWQLEMP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> ABRKCTBGMNY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x97A1F00", Offset = "0x97A0B00", VA = "0x1897A1F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> FMJTDQSINJY
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x97A1EA0", Offset = "0x97A0AA0", VA = "0x1897A1EA0")]
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
	public static class VPUWNAZHKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97A7330", Offset = "0x97A5F30", VA = "0x1897A7330")]
		public static bool IIMOIANRJQZ(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x97A6F20", Offset = "0x97A5B20", VA = "0x1897A6F20")]
		private static bool IIMOIANRJQZ(BWPYMSYLZBA a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface XMWZUREHMQL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(SNMCIHPJLWB data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, AKEHMXMKEHP circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly EOMRJYDEACK Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<YMQXVRQNJLQ> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<YMQXVRQNJLQ> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<GNQADATMYDH> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<NYBQVHGBIMX>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DNXWKGJXVIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x97A6E40", Offset = "0x97A5A40", VA = "0x1897A6E40")]
		public R1CreateTemplateParams(EOMRJYDEACK circuits, IEnumerable<YMQXVRQNJLQ> rootData, IReadOnlyList<YMQXVRQNJLQ> allPersistableData, Id32<GNQADATMYDH> sourceGraphId, IReadOnlyList<Id128<NYBQVHGBIMX>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly EOMRJYDEACK Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<YMQXVRQNJLQ> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<GNQADATMYDH> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<NYBQVHGBIMX>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x97A6EB0", Offset = "0x97A5AB0", VA = "0x1897A6EB0")]
		public R2CreateTemplateParams(EOMRJYDEACK circuits, Id32<GNQADATMYDH> sourceGraphId, IReadOnlyList<Id128<NYBQVHGBIMX>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<YMQXVRQNJLQ> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HEDQKSGWXBH : DEMYGUIRPEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid PADVOELUWXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> TDKHIUHQEOK;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64149C0", Offset = "0x64135C0", VA = "0x1864149C0")]
		private HEDQKSGWXBH(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x97A26F0", Offset = "0x97A12F0", VA = "0x1897A26F0")]
		public static HEDQKSGWXBH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97A2640", Offset = "0x97A1240", VA = "0x1897A2640")]
		private static Dictionary<Guid, Guid> MDMZLXMXYDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97A2550", Offset = "0x97A1150", VA = "0x1897A2550")]
		public static HEDQKSGWXBH ILAOUMMKLKU(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x97A1F60", Offset = "0x97A0B60", VA = "0x1897A1F60")]
		public static HEDQKSGWXBH AHASXSLTZOJ(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x97A25D0", Offset = "0x97A11D0", VA = "0x1897A25D0")]
		public Dictionary<Guid, Guid> LIRGZMQEGBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
		public Dictionary<Guid, Guid> WEUIVTVRWVN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97A2250", Offset = "0x97A0E50", VA = "0x1897A2250")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x97A22D0", Offset = "0x97A0ED0", VA = "0x1897A22D0")]
		public void DCPEDBDSBYC(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x97A2780", Offset = "0x97A1380", VA = "0x1897A2780")]
		public Guid UMOJZSGNRAE([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97A28D0", Offset = "0x97A14D0", VA = "0x1897A28D0")]
		public Guid WAWREKIWZDD([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97A2560", Offset = "0x97A1160", VA = "0x1897A2560")]
		public bool KRYRIWQBJWK([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97A2560", Offset = "0x97A1160", VA = "0x1897A2560", Slot = "4")]
		private bool PHTFPHAXZIC([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QTALUSNVIUF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KNAMCPJRIJY(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AFNXIYRLUQK(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface YARAMBDDGPX
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
	public abstract class WUQTZWCMQZX : QTALUSNVIUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JQZHJPTFSRA : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string QJFOWEFJHUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public JQZHJPTFSRA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x97A6C40", Offset = "0x97A5840", VA = "0x1897A6C40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x97A6C00", Offset = "0x97A5800", VA = "0x1897A6C00", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x97A6B70", Offset = "0x97A5770", VA = "0x1897A6B70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> JXOSTSWOHUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x97A6B70", Offset = "0x97A5770", VA = "0x1897A6B70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? URXVBHZADYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? CZPISDADRKT;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> IABFHWOHEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x97A7860", Offset = "0x97A6460", VA = "0x1897A7860")]
			[IteratorStateMachine(typeof(JQZHJPTFSRA))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? XZOBFYDLRUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool OJHTHYJQLJV
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool PQVAWKCGBHY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> CYDUJURRCMR(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool ZTKHTWRHNYH(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97A7430", Offset = "0x97A6030", VA = "0x1897A7430")]
		public void ALVDXYPWAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x102F010", Offset = "0x102DC10", VA = "0x18102F010")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x97A78C0", Offset = "0x97A64C0", VA = "0x1897A78C0", Slot = "4")]
		public bool KNAMCPJRIJY(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97A7360", Offset = "0x97A5F60", VA = "0x1897A7360", Slot = "5")]
		public bool AFNXIYRLUQK(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97A7CE0", Offset = "0x97A68E0", VA = "0x1897A7CE0")]
		private bool SWYPEAYAHBY(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97A7B70", Offset = "0x97A6770", VA = "0x1897A7B70")]
		protected List<Guid> PGZFUSUMVUX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected WUQTZWCMQZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class XMMWMUUUUWN
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BFGCHHTGJIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public EOMRJYDEACK XDQFHZLZDQK;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public BFGCHHTGJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x97B5A30", Offset = "0x97B4630", VA = "0x1897B5A30")]
			internal Id32<GAWNVANSVBY> ZENWDTDXBJO((Id32<GNQADATMYDH> GraphId, Id32<NYBQVHGBIMX> NodeId) i)
			{
				return default(Id32<GAWNVANSVBY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int ZNZIXOAJTNY = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<GAWNVANSVBY>, GLPYXCIRNJO> MTBAUPWXCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long COJGQNQXFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long UNFBLDMHRMN;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<GAWNVANSVBY, int?> LTSARTBGYCQ;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long BTPLQAMYRPY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long RNBXVDATHKE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x97A7E30", Offset = "0x97A6A30", VA = "0x1897A7E30")]
		public static XMMWMUUUUWN CSWAMYWXPVO(EOMRJYDEACK a, Id128<GNQADATMYDH> b, [Optional] XMMWMUUUUWN c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x97A85E0", Offset = "0x97A71E0", VA = "0x1897A85E0")]
		public static (long, long) NZDXIAFXNAW(EOMRJYDEACK a, Id32<GNQADATMYDH> b, Id32<NYBQVHGBIMX> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x97A8370", Offset = "0x97A6F70", VA = "0x1897A8370")]
		public static long HOACARRKWKF([In] ReadOnlySpan<Id32<GAWNVANSVBY>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x97A84A0", Offset = "0x97A70A0", VA = "0x1897A84A0")]
		private static long NUCDZBYBNZQ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x97B59B0", Offset = "0x97B45B0", VA = "0x1897B59B0")]
		public XMMWMUUUUWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class GLPYXCIRNJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xE84FE0", Offset = "0xE83BE0", VA = "0x180E84FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long NBESHZDJYSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xDDD760", Offset = "0xDDC360", VA = "0x180DDD760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x92BF3A0", Offset = "0x92BDFA0", VA = "0x1892BF3A0")]
		public GLPYXCIRNJO(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class EIUANTLUUAE
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> TLSFQAPLLRN;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class XXHIPQJOAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class JWSFPZKQLAM : IEnumerable<YMQXVRQNJLQ>, IEnumerable, IEnumerator<YMQXVRQNJLQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private YMQXVRQNJLQ PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData CNTSDMQWRDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData XNYVUCHAULM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams XDMEBTIBQAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams BFIKMBUERKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int LPBUJELINTU;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private YMQXVRQNJLQ XWESJPTGRYZ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public JWSFPZKQLAM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x97B7780", Offset = "0x97B6380", VA = "0x1897B7780", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x97B7740", Offset = "0x97B6340", VA = "0x1897B7740", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x97B75E0", Offset = "0x97B61E0", VA = "0x1897B75E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YMQXVRQNJLQ> RAULMIVPSZU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x97B75E0", Offset = "0x97B61E0", VA = "0x1897B75E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97C64A0", Offset = "0x97C50A0", VA = "0x1897C64A0")]
		public static SpawnableTemplateData JVDWBLPECJM([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x97C6630", Offset = "0x97C5230", VA = "0x1897C6630")]
		public static SpawnableTemplateData JVDWBLPECJM([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97C7240", Offset = "0x97C5E40", VA = "0x1897C7240")]
		private static HashSet<Id128<FHADUUSLUOP>> WLWXRMPZZOI(IReadOnlyList<YMQXVRQNJLQ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x97C67C0", Offset = "0x97C53C0", VA = "0x1897C67C0")]
		private static void KBXUDRZEWEV(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x97C40C0", Offset = "0x97C2CC0", VA = "0x1897C40C0")]
		public static Result<HEDQKSGWXBH, TryCloneTemplateError> CEFWZNUSSFW(SpawnableTemplateData a, SpawnTemplateParams b, HEDQKSGWXBH? srcRemapper, bool c)
		{
			return default(Result<HEDQKSGWXBH, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97C3FB0", Offset = "0x97C2BB0", VA = "0x1897C3FB0")]
		[IteratorStateMachine(typeof(JWSFPZKQLAM))]
		private static IEnumerable<YMQXVRQNJLQ> AWVGGWNETLL(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97C6EE0", Offset = "0x97C5AE0", VA = "0x1897C6EE0")]
		private static void SUEBSVMXTVA(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x97C5970", Offset = "0x97C4570", VA = "0x1897C5970")]
		private static bool GMTLJGJVNRX(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97C6F50", Offset = "0x97C5B50", VA = "0x1897C6F50")]
		private static Dictionary<Guid, BWPYMSYLZBA> TFHENOWLLON(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E50", Offset = "0x97C5A50", VA = "0x1897C6E50")]
		private static void LYKBQPDQDQP(bool a, YMQXVRQNJLQ b, HEDQKSGWXBH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x97C56E0", Offset = "0x97C42E0", VA = "0x1897C56E0")]
		private static void EEJYBEKTDVV(YMQXVRQNJLQ a, Guid b, SpawnTransformData? c, Dictionary<Guid, BWPYMSYLZBA> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97C5FF0", Offset = "0x97C4BF0", VA = "0x1897C5FF0")]
		private static void JDPPEWXXGYK(IEnumerable<YMQXVRQNJLQ> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public EOMRJYDEACK circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public YARAMBDDGPX roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public XMWZUREHMQL circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<GNQADATMYDH> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public MHPCUTAZFHR globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<YMQXVRQNJLQ> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public ISMQUJBXXPP photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 VMSWBTYKHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x97C1290", Offset = "0x97BFE90", VA = "0x1897C1290")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS BZNOBTUWCJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x97C0C30", Offset = "0x97BF830", VA = "0x1897C0C30")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16C8440", Offset = "0x16C7040", VA = "0x1816C8440")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x97C13A0", Offset = "0x97BFFA0", VA = "0x1897C13A0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x97C0F10", Offset = "0x97BFB10", VA = "0x1897C0F10")]
		public static SpawnTransformData SQFZNODJFAV(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97C1470", Offset = "0x97C0070", VA = "0x1897C1470")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x97C1490", Offset = "0x97C0090", VA = "0x1897C1490")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x97C1190", Offset = "0x97BFD90", VA = "0x1897C1190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x97C0C70", Offset = "0x97BF870", VA = "0x1897C0C70")]
		public SpawnTransformData NBNFFDGBQRH(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x97C1220", Offset = "0x97BFE20", VA = "0x1897C1220")]
		public static SpawnTransformData UNGHZWUYWVZ(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x97C0E80", Offset = "0x97BFA80", VA = "0x1897C0E80")]
		public readonly CircuitsRigidTransform QQKEIAYEYMX()
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
		private readonly SCULPNIXVDU _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1990070", Offset = "0x198EC70", VA = "0x181990070")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, SCULPNIXVDU innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x97C15F0", Offset = "0x97C01F0", VA = "0x1897C15F0")]
		public RTVNPFLLCNZ MLTWOBMVRRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x97C1720", Offset = "0x97C0320", VA = "0x1897C1720")]
		public static Result<HEDQKSGWXBH, TryCloneTemplateError> New(ETUAPEYIGPE<None> innerError)
		{
			return default(Result<HEDQKSGWXBH, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x97C17D0", Offset = "0x97C03D0", VA = "0x1897C17D0")]
		public static Result<HEDQKSGWXBH, TryCloneTemplateError> New(RTVNPFLLCNZ innerError)
		{
			return default(Result<HEDQKSGWXBH, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x97C1660", Offset = "0x97C0260", VA = "0x1897C1660")]
		public static Result<HEDQKSGWXBH, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<HEDQKSGWXBH, TryCloneTemplateError>);
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
	public class NYNQCMSBDJI : IDisposable, ILHFYBTISUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> VVRROIWQXZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float AXVKYZXJXVP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags VGGDXNOJJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool TFGBHOMLNFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x97B8BC0", Offset = "0x97B77C0", VA = "0x1897B8BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DLPVZBYENZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x97BB350", Offset = "0x97B9F50", VA = "0x1897BB350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> PTXNMRFFMTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int VTOQGPWKBUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x97BB1E0", Offset = "0x97B9DE0", VA = "0x1897BB1E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float QRJWTEUPJIS
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x97BA370", Offset = "0x97B8F70", VA = "0x1897BA370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x97BB410", Offset = "0x97BA010", VA = "0x1897BB410")]
		public NYNQCMSBDJI(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x97B8D80", Offset = "0x97B7980", VA = "0x1897B8D80", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x97BACB0", Offset = "0x97B98B0", VA = "0x1897BACB0")]
		public Vector3 RMRKJOLXRKX(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x97BB220", Offset = "0x97B9E20", VA = "0x1897BB220", Slot = "6")]
		public Quaternion XRWEIASFMEA(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x97BA020", Offset = "0x97B8C20", VA = "0x1897BA020", Slot = "5")]
		public Vector3 HVDPJFLDYLH(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x97B9FC0", Offset = "0x97B8BC0", VA = "0x1897B9FC0", Slot = "7")]
		public float GHVKSCFXWWE(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97B96E0", Offset = "0x97B82E0", VA = "0x1897B96E0")]
		public void FPLUCGEODRM(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x97B9680", Offset = "0x97B8280", VA = "0x1897B9680")]
		private bool ELQTTAKTIJU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x97B8A60", Offset = "0x97B7660", VA = "0x1897B8A60")]
		public void AIWNSVTWNKC(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97B95F0", Offset = "0x97B81F0", VA = "0x1897B95F0")]
		public void EKYPLNWTVNL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x97BA0C0", Offset = "0x97B8CC0", VA = "0x1897BA0C0")]
		public void JNBOZYYVNCA(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x97B8BD0", Offset = "0x97B77D0", VA = "0x1897B8BD0")]
		public void DQZTAJDPRVO(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x97BA4B0", Offset = "0x97B90B0", VA = "0x1897BA4B0")]
		public void MTWMSQYRAIC(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x97BA210", Offset = "0x97B8E10", VA = "0x1897BA210")]
		public void KPOILBEQOKF(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x97B8DE0", Offset = "0x97B79E0", VA = "0x1897B8DE0")]
		public static Quaternion ECDTOMYUVOD(Quaternion a, int b, float c, ILHFYBTISUH d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x97BA600", Offset = "0x97B9200", VA = "0x1897BA600")]
		public Bounds NVJIKKFGEKN(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x97BB180", Offset = "0x97B9D80", VA = "0x1897BB180", Slot = "10")]
		public virtual void RMRQZEBMUBV(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x97BB360", Offset = "0x97B9F60", VA = "0x1897BB360")]
		public NativeList<CurvePointData> ZQFDGAUUWEB(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x97B6530", Offset = "0x97B5130", VA = "0x1897B6530")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x97B6470", Offset = "0x97B5070", VA = "0x1897B6470")]
		public Quaternion SWTLBIBENSC(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x97B6180", Offset = "0x97B4D80", VA = "0x1897B6180")]
		public CurvePoint PAQMCSWBEBA(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x97B5FE0", Offset = "0x97B4BE0", VA = "0x1897B5FE0")]
		public MTSOOUKDLCJ BABPNYJHSAM(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class MEQUXFQLTXZ : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x97B89E0", Offset = "0x97B75E0", VA = "0x1897B89E0", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x97B83B0", Offset = "0x97B6FB0", VA = "0x1897B83B0")]
		private void BPNUMMMAESW(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x97B8980", Offset = "0x97B7580", VA = "0x1897B8980")]
		private void BPNUMMMAESW(Dictionary<Guid, Guid> a, LSHEQWBAOEZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x97B8130", Offset = "0x97B6D30", VA = "0x1897B8130")]
		private void BPNUMMMAESW(Dictionary<Guid, Guid> a, ORLMYODBXMC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public MEQUXFQLTXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class FNFINOHHFAC : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x97B6900", Offset = "0x97B5500", VA = "0x1897B6900", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public FNFINOHHFAC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class BHYMWCTLJOH : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97B5B00", Offset = "0x97B4700", VA = "0x1897B5B00", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public BHYMWCTLJOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class STGFZQXDBUL : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x97C0AD0", Offset = "0x97BF6D0", VA = "0x1897C0AD0", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public STGFZQXDBUL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class WQZEBMWIMUZ : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x97C2C50", Offset = "0x97C1850", VA = "0x1897C2C50", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public WQZEBMWIMUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class DBIOAODVQVU : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x97B65B0", Offset = "0x97B51B0", VA = "0x1897B65B0", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public DBIOAODVQVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class JSESFNVRURM : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x97B7440", Offset = "0x97B6040", VA = "0x1897B7440", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public JSESFNVRURM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ZUZCGRHKTHH : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97C75E0", Offset = "0x97C61E0", VA = "0x1897C75E0", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public ZUZCGRHKTHH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class MDYIOPWQDQH : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x97B7F70", Offset = "0x97B6B70", VA = "0x1897B7F70", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public MDYIOPWQDQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class GOPEZZHQEOP : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x97B69B0", Offset = "0x97B55B0", VA = "0x1897B69B0", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public GOPEZZHQEOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SGBPTAVRGEB : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97C09D0", Offset = "0x97BF5D0", VA = "0x1897C09D0", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public SGBPTAVRGEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class JDNFZRUUUOA : NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly HATRHJNOBMC VSTRVOXPRHF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x97B7310", Offset = "0x97B5F10", VA = "0x1897B7310", Slot = "4")]
		public void EVSWRJHYIHP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public JDNFZRUUUOA()
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
		public ISMQUJBXXPP photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface NGDTBQPOFMY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EVSWRJHYIHP(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class XSXVOQHDISV
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly NGDTBQPOFMY[] MXVPUEYXGWL;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x97C34D0", Offset = "0x97C20D0", VA = "0x1897C34D0")]
		public static void RJCPCFJNQWW(YMQXVRQNJLQ a, HEDQKSGWXBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x97C3750", Offset = "0x97C2350", VA = "0x1897C3750")]
		public static void TDMZYOOIVQY(YMQXVRQNJLQ? data, HEDQKSGWXBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x97C2E70", Offset = "0x97C1A70", VA = "0x1897C2E70")]
		public static void BSIJHIKMTCS(YMQXVRQNJLQ? data, HEDQKSGWXBH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x97C30E0", Offset = "0x97C1CE0", VA = "0x1897C30E0")]
		public static void IIMOIANRJQZ(PersistableCloneParams a)
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
		public YMQXVRQNJLQ viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x97BB490", Offset = "0x97BA090", VA = "0x1897BB490")]
		public Guid LBQHNOKYASX(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface ISMQUJBXXPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> RDNBAGQMYCM;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> JSSUEYAQEBQ;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> ZLCHPGDJRYY;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker GIBZXPWBDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> BQXXCIYPQAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> CETOKLFGIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> AOIXVCLDCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> JQEPBYTYLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> KXZJPZCZACG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> JZETHTZWPFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> FWXOSBZFYSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> HNNAUACEYGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> JVFLUFVMXQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x97BD880", Offset = "0x97BC480", VA = "0x1897BD880")]
		public static void MFPNKRPASNI(SpawnableTemplateData a, BLFHJVERJHI b, HEDQKSGWXBH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x97BF550", Offset = "0x97BE150", VA = "0x1897BF550")]
		public static PersistedRoomDataReferences OVOBWQLQKSC(PersistedRoomData a, BLFHJVERJHI? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x97BD5C0", Offset = "0x97BC1C0", VA = "0x1897BD5C0")]
		public static PersistedRoomDataReferences JVOMTDDURAV(SpawnableTemplateData a, BLFHJVERJHI? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x97BF5D0", Offset = "0x97BE1D0", VA = "0x1897BF5D0")]
		public static PersistedRoomDataReferences VNHAPRDPGNP(NEAYWMKOJYN a, OZHVDWJGKZJ b, BLFHJVERJHI? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x97BF910", Offset = "0x97BE510", VA = "0x1897BF910")]
		public static PersistedRoomDataReferences XUGSUYKPAUW(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x97C0030", Offset = "0x97BEC30", VA = "0x1897C0030")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x97BFE60", Offset = "0x97BEA60", VA = "0x1897BFE60")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x97BB7D0", Offset = "0x97BA3D0", VA = "0x1897BB7D0")]
		private void DWGXUNBLTGL(PersistedRoomData a, BLFHJVERJHI? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x97BB540", Offset = "0x97BA140", VA = "0x1897BB540")]
		private void DWGXUNBLTGL(SpawnableTemplateData a, BLFHJVERJHI? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x97BCE20", Offset = "0x97BBA20", VA = "0x1897BCE20")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x97BC050", Offset = "0x97BAC50", VA = "0x1897BC050")]
		private void DWGXUNBLTGL(NEAYWMKOJYN? a, BLFHJVERJHI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x97BCDA0", Offset = "0x97BB9A0", VA = "0x1897BCDA0")]
		private void DWGXUNBLTGL(OZHVDWJGKZJ? a, BLFHJVERJHI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x97BBA70", Offset = "0x97BA670", VA = "0x1897BBA70")]
		private void DWGXUNBLTGL(IZPJWYOPWOD? a, BLFHJVERJHI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x97BD3C0", Offset = "0x97BBFC0", VA = "0x1897BD3C0")]
		private static bool JQRXMONWMOY(IZPJWYOPWOD a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x97BD640", Offset = "0x97BC240", VA = "0x1897BD640")]
		private static bool KIJURXPOSVC(IZPJWYOPWOD a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x97BE260", Offset = "0x97BCE60", VA = "0x1897BE260")]
		private static void MFPNKRPASNI(OZHVDWJGKZJ? root, BLFHJVERJHI a, HEDQKSGWXBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x97BF140", Offset = "0x97BDD40", VA = "0x1897BF140")]
		private static void MFPNKRPASNI(IZPJWYOPWOD? customProperties, BLFHJVERJHI a, HEDQKSGWXBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x97BEDD0", Offset = "0x97BD9D0", VA = "0x1897BEDD0")]
		private static void MFPNKRPASNI(NEAYWMKOJYN? root, BLFHJVERJHI a, HEDQKSGWXBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x97BE330", Offset = "0x97BCF30", VA = "0x1897BE330")]
		private static void MFPNKRPASNI(CircuitsV2.Protobuf.CircuitNodeData? node, BLFHJVERJHI a, HEDQKSGWXBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x97BCA20", Offset = "0x97BB620", VA = "0x1897BCA20")]
		private void DWGXUNBLTGL(CircuitsV2.Protobuf.CircuitNodeData? a, BLFHJVERJHI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x97BF690", Offset = "0x97BE290", VA = "0x1897BF690")]
		private void WHCHVRCYZGD(Guid? a, BLFHJVERJHI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x97BBC50", Offset = "0x97BA850", VA = "0x1897BBC50")]
		private void DWGXUNBLTGL(YMQXVRQNJLQ? a, BLFHJVERJHI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x97BE980", Offset = "0x97BD580", VA = "0x1897BE980")]
		private static void MFPNKRPASNI(YMQXVRQNJLQ? viewData, BLFHJVERJHI a, HEDQKSGWXBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x97BF8A0", Offset = "0x97BE4A0", VA = "0x1897BF8A0")]
		private void WNOGBFIFVVQ(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x97BF480", Offset = "0x97BE080", VA = "0x1897BF480")]
		private void MUFHFJUQIFE(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x97BF430", Offset = "0x97BE030", VA = "0x1897BF430")]
		private void MUFHFJUQIFE(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x97BF3D0", Offset = "0x97BDFD0", VA = "0x1897BF3D0")]
		private void MUFHFJUQIFE(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class KWUKBHTWTCV : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> LNEVESCRIOG;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x97B7BA0", Offset = "0x97B67A0", VA = "0x1897B7BA0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x97B7C60", Offset = "0x97B6860", VA = "0x1897B7C60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x97B7D10", Offset = "0x97B6910", VA = "0x1897B7D10", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x97B7AC0", Offset = "0x97B66C0", VA = "0x1897B7AC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
			public KWUKBHTWTCV(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x97B7A20", Offset = "0x97B6620", VA = "0x1897B7A20", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x97B7A70", Offset = "0x97B6670", VA = "0x1897B7A70", Slot = "9")]
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
			private sealed class KRDIYZRQHOP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry EVZINIDSQPZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x97B7890", Offset = "0x97B6490", VA = "0x1897B7890", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public KRDIYZRQHOP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x97B7920", Offset = "0x97B6520", VA = "0x1897B7920", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x97B78E0", Offset = "0x97B64E0", VA = "0x1897B78E0", Slot = "8")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
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
			private ICollection KZTZLUFVARV
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x97C0190", Offset = "0x97BED90", VA = "0x1897C0190", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x97C06B0", Offset = "0x97BF2B0", VA = "0x1897C06B0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x97C0790", Offset = "0x97BF390", VA = "0x1897C0790", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool OCTBNPBGYRE
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x97C02F0", Offset = "0x97BEEF0", VA = "0x1897C02F0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool YQUIYZUXMXD
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x97C0430", Offset = "0x97BF030", VA = "0x1897C0430", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection KKEAWXZYNVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x97C0480", Offset = "0x97BF080", VA = "0x1897C0480", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int HMGKMMWEPOG
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x97C0610", Offset = "0x97BF210", VA = "0x1897C0610", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool XESHMWHYAKJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x97C0340", Offset = "0x97BEF40", VA = "0x1897C0340", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object UMYCPRGYYRO
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x97C0390", Offset = "0x97BEF90", VA = "0x1897C0390", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x97C07D0", Offset = "0x97BF3D0", VA = "0x1897C07D0")]
			[IteratorStateMachine(typeof(KRDIYZRQHOP))]
			private IEnumerator<DictionaryEntry> VEWIKBFBCGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x97C04D0", Offset = "0x97BF0D0", VA = "0x1897C04D0", Slot = "19")]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x97C0220", Offset = "0x97BEE20", VA = "0x1897C0220", Slot = "13")]
			private IDictionaryEnumerator AXLTQTQDKPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x97C0840", Offset = "0x97BF440", VA = "0x1897C0840", Slot = "9")]
			private void WPGGQJEKFJU(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x97C03E0", Offset = "0x97BEFE0", VA = "0x1897C03E0", Slot = "10")]
			private void GCCDHRKTRHW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x97C05C0", Offset = "0x97BF1C0", VA = "0x1897C05C0", Slot = "8")]
			private bool LJFXEEBXNTE(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x97C0660", Offset = "0x97BF260", VA = "0x1897C0660", Slot = "14")]
			private void RWNLMOYJAQT(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x97C0570", Offset = "0x97BF170", VA = "0x1897C0570", Slot = "15")]
			private void KXSHFVVPTWL(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class LAFRPZKQKZD : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry EVZINIDSQPZ
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x97B7DC0", Offset = "0x97B69C0", VA = "0x1897B7DC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public LAFRPZKQKZD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x97B7E50", Offset = "0x97B6A50", VA = "0x1897B7E50", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x97B7E10", Offset = "0x97B6A10", VA = "0x1897B7E10", Slot = "8")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
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
			private ICollection KZTZLUFVARV
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x97B6B70", Offset = "0x97B5770", VA = "0x1897B6B70", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x97B7040", Offset = "0x97B5C40", VA = "0x1897B7040", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x97B7150", Offset = "0x97B5D50", VA = "0x1897B7150", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool OCTBNPBGYRE
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x97B6C90", Offset = "0x97B5890", VA = "0x1897B6C90", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool YQUIYZUXMXD
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x97B6DD0", Offset = "0x97B59D0", VA = "0x1897B6DD0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection KKEAWXZYNVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x97B6E20", Offset = "0x97B5A20", VA = "0x1897B6E20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int HMGKMMWEPOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x97B6FA0", Offset = "0x97B5BA0", VA = "0x1897B6FA0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool XESHMWHYAKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x97B6CE0", Offset = "0x97B58E0", VA = "0x1897B6CE0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object UMYCPRGYYRO
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x97B6D30", Offset = "0x97B5930", VA = "0x1897B6D30", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B67710", Offset = "0x2B66310", VA = "0x182B67710")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x97B7190", Offset = "0x97B5D90", VA = "0x1897B7190")]
			[IteratorStateMachine(typeof(LAFRPZKQKZD))]
			private IEnumerator<DictionaryEntry> VEWIKBFBCGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x97B6E70", Offset = "0x97B5A70", VA = "0x1897B6E70", Slot = "19")]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x97B6BC0", Offset = "0x97B57C0", VA = "0x1897B6BC0", Slot = "13")]
			private IDictionaryEnumerator AXLTQTQDKPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x97B71F0", Offset = "0x97B5DF0", VA = "0x1897B71F0", Slot = "9")]
			private void WPGGQJEKFJU(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x97B6D80", Offset = "0x97B5980", VA = "0x1897B6D80", Slot = "10")]
			private void GCCDHRKTRHW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x97B6F50", Offset = "0x97B5B50", VA = "0x1897B6F50", Slot = "8")]
			private bool LJFXEEBXNTE(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x97B6FF0", Offset = "0x97B5BF0", VA = "0x1897B6FF0", Slot = "14")]
			private void RWNLMOYJAQT(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x97B6F00", Offset = "0x97B5B00", VA = "0x1897B6F00", Slot = "15")]
			private void KXSHFVVPTWL(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x97C1A70", Offset = "0x97C0670", VA = "0x1897C1A70")]
		public static UgcRoomSaveStatsDetailed OVOBWQLQKSC(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x97C2AD0", Offset = "0x97C16D0", VA = "0x1897C2AD0")]
		[CompilerGenerated]
		internal static int YEASIVBNNWU([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x97C2440", Offset = "0x97C1040", VA = "0x1897C2440")]
		[CompilerGenerated]
		internal static void XACYHWNCXOU(int a, [In] NEAYWMKOJYN graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class BLFHJVERJHI
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid MRBCXADOTUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> FWXOSBZFYSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind JPOHFKUZLGS;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x97C2BF0", Offset = "0x97C17F0", VA = "0x1897C2BF0")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly HEDQKSGWXBH HZRVWQRELIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> SWKIYNWJXAF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public HEDQKSGWXBH UVWDQIRHDSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x97B5C60", Offset = "0x97B4860", VA = "0x1897B5C60")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x97B5E60", Offset = "0x97B4A60", VA = "0x1897B5E60")]
		public bool ODZHODPIUXN(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x97B5F50", Offset = "0x97B4B50", VA = "0x1897B5F50")]
		public BLFHJVERJHI()
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
