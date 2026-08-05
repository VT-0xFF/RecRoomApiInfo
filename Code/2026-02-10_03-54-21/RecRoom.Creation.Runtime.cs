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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x839A950", Offset = "0x8399B50", VA = "0x18839A950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GLIXOFKYXQT
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> CUNPIBNKFDB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> ZSXOTFPWXFV;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> WPIJLJGYUAN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> COHNBSUAWDQ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string NHKQZAOYJAE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string TJJMUVZBLGB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string QLALIQTBWGY;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8395F20", Offset = "0x8395120", VA = "0x188395F20")]
	public static bool GVJVIUQNYIX(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8395E90", Offset = "0x8395090", VA = "0x188395E90")]
	public static bool CHLRSGAZOAZ(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8396020", Offset = "0x8395220", VA = "0x188396020")]
	public static string IKTIXTWRIZK(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x839A7F0", Offset = "0x83999F0", VA = "0x18839A7F0", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MFGNZESEPQK
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid QRTWAFNNDSH;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid MGBIFFONIQO;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid NEDRITDNZIH;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid KOFTGUHOYZD;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid XTUTOWCFGFD;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid SWLLGNZMZMQ;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid CXWYCELJNGY;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid EEEYNMDFCRO;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid VXXNMCHKGQZ;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid ENQGPODUFSW;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid UEHNMNTJZQC;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid GJFMPBCLKPM;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid MJGCJKCISET;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid AZVXWLLYBPU;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid YOVHJOFQAMN;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid VRUAVXWNGHI;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid KPFRENAXYCR;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid VATEKTHALIC;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid VJGBRZIBLTK;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid XWDWRLWCPJT;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid VOJUOULSGWG;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid AQAGFDTHYUE;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid KXOCTKBTAAR;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid INORCGBKGTR;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid TVFXJXDJJYL;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid WECWPZESDIV;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid SMVGMVVDNCT;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid XTQWOWPTNXL;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid YBUTLDWMQRC;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid RTNUSCERMDX;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid SPBNUCMGBDI;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid OXLNKFSAIFA;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid SQZEZOTJLQT;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid RKHOGWIKBZP;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid OYIRHEHBDMQ;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid UUQTMOOCGVZ;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid KUJUBZUPIUG;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid XLDZUBSMQQY;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid XEZELKQSZPE;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid KBZTWACZDAE;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid UNPZBYLIVPY;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid BCTHXGHINSK;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid CYSHRLJICUU;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid FWMEGIYDDYY;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid ETEEZXPSPJE;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid FEXBWKHFYID;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid YABVSSHQRHS;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid QEIWSKALJQZ;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid QNHFIGXIVNT;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid QRQDWROTPDX;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid AQRTSCMARSA;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid TKGWZUEBVUX;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid TEKFSFLPREW;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid BPALTFQLFPQ;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid URNYETBTYLL;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid OZPWDKEJIKF;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid EPXOXULCBUH;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid RDFBRZZZWTK;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid QQQPCQXGOBA;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid JNLRYAXOBMP;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid SRWBTOGAGOR;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid AYIPZXTEIVS;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid JYUYPSOHOPL;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid FANCKTNIVTA;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid UAGNBAHKSOC;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid EHHMYAGFZIR;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid EDKHTUFGGBG;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid JOOVGXDIUAE;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid BTWLZQPFJZB;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid BCSRYBOZOUX;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid QMKCGGQXTPU;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid DPLLSJVNDKT;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid RLOMNXVOSVO;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid OPGKLYPRDMX;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid ZAXHIWOEDEW;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid DMZJUFGMGDK;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid CEOUZJJRCVV;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid FKVAITIKILL;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid IGXJNNHKSDP;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid QYZTCRIIPCJ;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid UZVPPQGKWUR;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid LRNCJINYAGM;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid GCSBFQDXWGZ;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid NNSHDKXIFDE;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid YCRHBBOVOEJ;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid LKZLXBJSRGO;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid EWZDDHNRVRQ;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid ZGQVJARTRLO;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid BKKXOCLXBID;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid ZAISJVYELKC;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid HNHXOAZWRNA;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid OZHCYFTIQVZ;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid ALVEYHVWKVB;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid MGRRVJUGEPQ;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid EGSUVDNNKJE;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid JMUREMLLZMO;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid LJTUAUDJJNS;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid XIDDGFKVVCK;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid XENHXPUJRZZ;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid XCLNVCXVQJE;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid YSUTPTGOTYG;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid XHQAPILZNOV;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid AFRIKCGMUDY;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid YSKNXNHWMZH;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid KPWQCOVSEWW;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid YSAACZUBUCP;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid WWRNINUSZQA;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid ETDUIXQYQVI;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid NDGNULYMJST;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid FFEGKPUEPPC;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid ATKHGNLQXQZ;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid FFOUFDHZILU;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid GFOMGEPXLPR;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid FCTBRMPKGIY;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid AKBXAVMGJIF;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid CQNUSBNFXER;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid SRCHMXXJHBK;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid XNSSWSZJENY;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid OEVQQXOHUMF;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid CBJOIUQSEVC;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid ETTULLBGJQQ;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid WPNNZOXCHIF;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid YORBRSBSHLY;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid PQSMIEPGEUK;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid COXOCJRYUYK;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid PMHOXLMCYYG;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid YRPFUIMVFGM;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid QKESTQOQASI;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid XQWFKPJCMJW;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid VFBZEXCSYEB;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid BPBWKTFXJIW;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid GWCDXRKYIUQ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid JNOIZVVUETG;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid DXEOBSTLIQD;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid ICHNQMETDZK;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid QUGVMQZLOKH;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid BJFPBYKKGRX;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid RRLHYRLSKMO;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid CXOSAZNXOEY;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid RPROSLVSNTR;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid OZCBOPTFNCZ;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid KUSQIZQLUZK;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid GOYAGRTXKBI;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid UDLEBRZZZRD;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid FAFRMYTZUNB;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid CBDSCXIDYXZ;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid WVZCHNDVZEZ;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid KGTGJBOVBBQ;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid TSLBTARTKBE;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid TSFUVTXWAPV;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid TSANYNDYREM;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid TTLKFINGFFX;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid TTGDIBTIVUO;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid TTAWKUZLMJF;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid TSVPNOFOCXW;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid RJWTPOFCUDE;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid CDAGCOBXJKE;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid BVHNHAMNCXD;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid ZWSJBWQEXOV;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid KYDALIHMNXS;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid XSKUVYAALTF;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid CFQZDZEQOCZ;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid AKXWSFMULJT;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid DKQATFVNMDM;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid HHNAAZYWDLS;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid JVYRTYEVHEZ;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid FXWPHNIQWHW;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid RINJSBCVLFJ;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid ITYETVVHALX;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid RROPGXZTUAW;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid VJFMVOJYWKP;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid ITIKCBNOYDW;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid ITNQZIHMHPF;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid ISXWHNZUFHE;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid YZSTKIVOODD;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid ETFKULVZRXI;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid BYIASOCMPFB;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid YZCYSONWLVC;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid RJALXZWKACJ;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid VEEOVXFYKYQ;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid XLVGYFAGRMC;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid AIVIMJFDDCP;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid TPUSOHRMKLV;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid BEGARLGLTAB;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid WNPXDKNIGCD;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid CQPREADDTPH;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid GOGXPSPLZZQ;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid MPBIBUMVCAJ;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid IGJWACQOQWM;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid RMCNRSBDLVE;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid XVTVXJTPZCQ;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid PZFRWEFTADY;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid PZMIFLBJUTR;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid SKYXJVYZTSF;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid QWJLRAHOCUE;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid KBGLSARVGTA;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid YMNFGILKWVD;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid PCWFFKMQYUG;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid PXIQSGIJYWU;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid EFQNOWIJZMF;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid AXVGHKFLJGU;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid CJUDHIPPIVF;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid KSDRBENWXPB;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid HSYWJYNGIZA;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid UTFCPTBFMJZ;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid YIOSFEFLXXC;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid EQWYGVONJBI;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid LMOLHUBFWOU;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid MWEENUVXZCH;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid FBHEUZNMQMK;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid UCYQCBBQHDM;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid RMQBPOEFFJP;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid MYQYIEXGPAP;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid WUMTYACHBPU;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid BENGMLPLFGX;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid AIFHGZSAVNI;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid ISRWXUBEQOH;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid NWHUZONLGQP;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid UAIEAUIEODX;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid DFOJYDOZDUR;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid QNJRTRQNCFM;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid AUIQLRHHFFS;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid QOKJIREXFYR;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid YHYVFDYUTMW;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid YUBEZWAHNTB;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid EDDNNPRUBUZ;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid OMXSZXVCHEV;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid TDSSROBVBIQ;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid FUAKJSFNFEI;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid AGFIYROVHXN;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid SQFUGYTFBRM;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid WVJZIIJHYBH;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid PWBOYLROKHY;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid UXNUZTUEVNM;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid MGGUXEKHZJO;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid ZXVKIOMYCVA;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid TMFRCEPSBBC;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid FYZIUTZAMJU;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid MTVTZMFLSNP;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid FYLEBTFBVHC;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid BDGTYPCPSWW;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid KWFRPPMCLVF;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid SPTJVCKHYFE;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid AICTVGFAKSZ;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid NHDAEJYWNNN;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid HFKNDTLFVVD;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid FKUCBXNRYPO;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid IFQIACRILUZ;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid EYOXVPALEHW;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid ACZJSZVWAXW;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid TSIWDCLBSRL;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid BGOPJZKEJAQ;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid PMCIOHINUQA;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid WRLFEXDFMSQ;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid FBPEUSHYNVG;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid THXWBLOWINY;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid PXQXIPPOQKW;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid SNWTYFRHNED;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid XGJULAFQRKD;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid PGRXJVUHSSE;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid YIXCXWTOMOD;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid YERWALQZYYC;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid ZOSBYSBNPXE;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid UUXYDUGYNCH;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid YNACWIJKRPU;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid JJJWKLZVYDY;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid PUBJMFEZEMK;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid OQDMZUXPDMQ;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid LYPIQLCOGWI;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid YVFOMQDVJSE;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid IRQZBFVMVKU;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid NJSLHRMUUFH;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid VOPPDKVSDLP;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid GICZEBXKVUS;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid HMWUAPOJOEF;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid NPECGTVEPLE;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid RWOBTNKSGOC;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid LXUJGHXTRBX;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid UZGSVFLIMWY;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid ISGWFTUUOLA;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid ONWIOQPQQSM;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid RSZKXPWANDJ;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid QFAHTRGCSKL;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid LLLRHXHVZJN;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid DWYRKHHAXEC;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid XGMHYKKMRIY;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid OGBCCQFEWJI;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid PRTKJMNWSJQ;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid WPYKVGLEFTT;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid LKOZZZXUTAD;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid KEIRBJERMFJ;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid QMQUMOSCRQI;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid LKTZHJZZJCQ;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid AMMORIYLPQV;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid MUQHMEPEDKJ;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid BHCWSKOJUIQ;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid XIIOQTZDSZA;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid DFLTCGDWDXP;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid QKOFXGGBKVQ;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid ZGUCBXLUQCP;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid OIFDALPGWYM;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid QXNBVJNCSKU;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid JATGNOZALHE;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid CUHSJYLXXRT;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid KSJFYNYNDKL;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid SQOZPANXHJH;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid SQRIWGOIEAU;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid OKPGNJSOVBP;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid BXKLYSBPYLD;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid CURKQZGTXZV;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid GLEUMQHQBNZ;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid RJEWMHLBLLK;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid MKFDXNKNGZO;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid YTDSPNFMJNA;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid NELJKHTXCXS;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid YUOVYHNAHNW;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid AJNSIQULEIC;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid QVFAVHKFFTT;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid XUZLFACHBTP;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid PDQHMNFEQLU;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid MFUJYYPULTF;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid DBITAWQORSF;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid TULSFBNMIBV;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid RKYQYUCNFVM;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid MFNLNSINHGO;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid GAPDNFRBJGZ;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid FIXXKGQVQQD;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid YXLIVVVXBAN;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid WZYNZKXFVNP;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid PQIPVPLHOOO;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid FWILUJQGSDW;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid DPDSETAQXCP;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid VTXYXWLBMEF;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid ELWVXXJPMBZ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid QDLHMFVCZVR;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid TDXULQSKBDW;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid GJVEGLXMUUM;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid GJHKZEGJZHK;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid NKESQAPSVWP;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid INOAZFQZFMD;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid FAJVKSFPOOS;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid ATHAXDUMRIE;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid AROHROGBDMZ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid QZHJJJRYLHP;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid ZHQDTHBENHG;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid LRWZWKADRYF;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid GOSJHLLEKJL;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid HSLZNCEVTXY;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid WXJXTAASWEB;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid DOJUKDYCGLN;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid LZYRDSOJDZC;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid GYOZOAXBJOF;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid UFVRBPLMJGS;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid NBEEGSIRESD;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid YCWCMMBFDFD;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid YDKDTYTLOUP;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid KQOCTDUBMPT;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid SFTSXDWTVVI;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid IFLDWGIJMBE;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid XSVWMCEIEGL;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid BQWTVEOLKXE;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid DXUUGWRZNKM;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid ASAECBMWUCY;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid OXXLGFTRDEJ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid ACGAWZJMQTW;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid JYHUNMRRYDH;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid KSIFNFBTYLK;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid OJENQWLURFX;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid RYWYUVSUYIT;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid CXWFUQIAHMA;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid BXOFYJUFEDC;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid PDGKMQSRNAQ;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid DLWPEHCPOLC;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid NCOEMSXBNJK;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid RFDVQFOWCJR;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid RZAKOVPWNAY;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid BYMLWTVUWMR;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid HGRPORGJITE;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid PGIQIFGPGYR;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid OBDIRJZWFJW;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid TDOTQWPPNTB;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid XSFAYZXZPCA;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid DOUNCVELNYD;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid RDZNVXFZIBM;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid CSABFCBQIIL;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid BYKXRMSSTEF;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid VDOLJQYNCMK;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid SNOAAQVAYBZ;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid VGNQLZMVCGO;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid OQBMZIGMQED;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid YKPSFWDGDGH;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid MRBCWTKLVEX;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid GXSMBDWELYF;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid XPBUANMPXGE;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid XEDVDUQPFEK;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid AKVEUVQKPRD;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid GZWHCNVAYQE;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid FAQWUIQZHVN;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid BOQDSHOBOQN;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid ABAGJLUZSBR;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid GRRSLQEQYUF;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid QJMOICSRUGA;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid ZRNYRMANYZN;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid HNMEQQNXGHW;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid PBFARQYZWCE;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid IJXSGQOABJT;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid IRJMNNWSYDJ;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid HYJOSUEPHPW;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid XLJYHUNZYZA;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid DOVOWDVVGQO;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid LZHJDXGSISX;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid SXBTUGLATKI;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid FOBBBVWKSUH;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid JCWMLOAAMKL;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid FTBPNLKLNCQ;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid BGZRZHLGTCO;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid MUGWAMATRPK;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid WEJAJREVKUX;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid HTMFFGTHANQ;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid XRKWMMOKWJU;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid DXWEIEQJRJC;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid FVSSLSJVQQS;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid XTJZLXSJDGI;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid DFKCIQGMVAV;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid OJGENCNQKQT;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid LXOZOVQRVNI;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid UQIMSQMMKUC;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid LXJSROWUMBZ;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid LXELUICXCQQ;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid LYPIBDMEQSB;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid LYKBDWSHHGS;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid LYEUGPYJXVJ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid LXZNJJEMOKA;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid LZKJQENUCLL;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid LZFCSXTWTAC;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid JTOKKDHITEA;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid IIMLEHFRJCA;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid MDOUQBDXGZT;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid BHAVVORZMXX;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid PYAVNNHQUIJ;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid BGODTQPYGWH;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid MOJYWXNSIEK;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid CREUQHIIBTA;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid SYUZDWYXAPZ;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid CBJNILFLQOZ;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid BEHLNBEOHOY;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid PRUPGBZSFSO;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid NRFQGTABYUC;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid QOELMQYPUDX;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid TGIXCBFIVME;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid TMSRGKYAEKQ;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid ZFPXWHQMXST;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid JOMQCHSKREX;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid GKUZJAYXHOJ;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid AIGVCCTCWKV;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid HPHOVWDWIUC;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid KWQGSQAYLSJ;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid KXGBKKIQOAK;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid YGXPNBHNFJG;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid TNYRFZFSQUF;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid JVOAQWJIKHK;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid GJLYUDLZDLH;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid IRGOCGZVBVX;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid RTOHHWACQIW;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid SXKLGNUVZWG;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid QUPDMNWGJSQ;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid RWQNNYQGPHO;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid IPSFUVKFIQA;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid XIJMJOOBPVL;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid RFYXDAAUTJO;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid MUWVPJGCNTG;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid TNZIAYKXEAZ;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid EAFMYQINIRO;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid QWODKLYFMVH;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid PBWQEDUAOGY;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid VOAXSBHNUFW;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid DYANGHDPQHB;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid BUYWLPUKJGM;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid MFVGGMSBRYU;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid BJFTXOJCSFG;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid CIQIALMYUHE;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid COCQXMLYQJT;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid JKOEEMIUGZP;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid AWVSJVLPRJX;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid SENIDCBCYXH;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid RBPIICXSKZP;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid BFHDENWSAFN;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid AIXAGKVJIFO;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid FHPNDNFVGZV;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid SQOYIRXLHLX;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid TFXZUBFQYWM;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid YUAKMHYZROC;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid IAUVBFPJRPB;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid XZIYKRDYLSE;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid SZZTPTGXRNP;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid IVYCWKQBIDZ;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid FSSWRENIBXY;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid WQIFQMSPVFM;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid CUXTSZHCZXU;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid HEHHGVDCHMO;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid IJCPZHXCAYA;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid WQKTYSFILIH;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid LHIXXUNQUCV;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid IMMYHXKTGGY;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid SZXKTMOIWKD;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid AOKQYAEKVKY;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid LGUYMEUKREJ;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid HGXKXFEBMPO;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid XCJDITRIOVL;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid THYMZQHPYVI;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid JYABXVXUPDJ;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid GWMPXOQMBRJ;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid DAMNIHGARMQ;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid UPVMSUCYQAG;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid MKMPJGNOUKM;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid IIGIRGEBXQJ;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid SIBSVLOUBNC;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid XFTPWGUYJMB;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid GWBQUNLQGYD;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid BJMKGAUGTUW;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid JLBGVNXRSWY;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid JLGNSURPCIH;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid FWJAQGWCEOV;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid NJZANIZZAXR;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid XFOXKTVMNCY;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid RLPXSNMHQDU;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid BXFDSJDQGYA;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid AFVBTIXHPDD;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid RAVQTLKJTEM;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid WJYJHBGPQDH;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid ZQGMROEXKEM;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid DCRLNKAZMAK;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid RXKWIFYOPAX;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid NSQEQFERQVO;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid QALIPBRZSDE;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid FWGTINNQKBA;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid WUVIBPMUWHJ;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid MHSVIWKCTLJ;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid RMRGAALEWWE;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid CJRGRWKHVDU;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid QJFVCYMNQYF;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid QBUXQULAHBD;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid UEAZAYIDPFI;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid SSBBCOPGERC;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid JHGGFAMCJMM;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid LLMPEKYTHTO;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid BOOLVNOKYSU;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid EPRQNRLNXHX;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid NCTNJNHEVSR;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid PFEPEEJOBLM;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid GRFKAGAJWOL;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid QHQEFQRHJXJ;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid FCWJEFFXBPE;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid ROCRMOVQIZB;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid EZUEADZASIE;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid FNIBNLVBWXM;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid OFDIATMLQJF;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid PGVGGUESPVL;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid GMCVINGFQDD;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid TQTIXEZNPGF;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid GBBFSLBDCMF;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid ASSKCGWMHHB;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid SPXEATLYLFO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid UGEMRCYCCMN;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid RBYOKLFYHOM;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid FHABRXBWAKS;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid CJWAQBNWLGO;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid QVHZWMTKHRI;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid VPFSQTBYCXZ;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid NFEDQXQVNOG;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid TSSJJRBKTAF;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid TWEGJVLHFUP;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid TWJNHCFEPFY;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid TWOUEIZBYRH;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid CQQHHFLUYVC;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid NQFWADQFLTW;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid NQVQRXXXOBX;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid GGSANUNNEYR;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid PDPYFVYOZDL;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid ECQRSBBYPSN;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid DBIEUJKDDCG;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid ERQRWZZABMX;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid POJLIXWYMKV;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid KHTFZTNIRXA;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid URYQSSQJQRK;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid ICMOBQJJLHT;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid QQTIRCZORMJ;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid UKRCPYAMOJT;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid NJMEOPFVJCP;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid IDKDYRIIBRI;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid IPTZMLDMWGW;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid HMYZIQYXJCX;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid RMMNTFKUSYZ;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid CYYOSGUWWWI;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid SMKLGGRLLJL;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid UMFPUAVXLBJ;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid XLQODHJFKPL;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid PFWOXXWGVKP;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid SMLIWKIDLOE;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid VHSCBTNAUJZ;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid PENRUQEQLUW;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid LVFYKYTSUNE;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid SAIWLEJWAPW;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid YFSJWBONSIJ;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid TWQNJRBEGEH;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid ECQKOFXMHLZ;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid VCBJFFBUVUH;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid XCINIHMPGBH;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid NGSJKVAHEUZ;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid SPWCKJMIHCN;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid XAAHDCTHAIK;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid XCXJMMMWNMP;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid NBXPFFBCJFH;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid AQCQOGILDSG;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid CMRBESZIKNT;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid KSLLSTWVTMJ;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid HRIAAPDHOJZ;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid FNEFJKZMKBX;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid EZCJZUWOKLV;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid PSUHBXIWMFV;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid WGHXNIIEUAW;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid TUQMRAVZQEB;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid VJYXZVORELZ;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid KYLPJYXBMAZ;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid ESLNJKBGOAK;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid BSKSQDGDXSU;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid SEEABTZMJVY;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid SWSNRULFUIT;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid QSRTJPFTKMA;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid NIBCXZSFHPV;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid KACJMNQAHUI;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid TDWFXYGMKPN;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid TFIFJJYUBFR;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid KPLSULGAELX;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid XVXROQWZGPQ;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid JSFJRMDOVRJ;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid UUELEWXCKQT;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid DXYDIMZSIKO;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid SETMLGVSZHM;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid ZMLUONPOHBT;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid WNWZWXJKYKE;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid ZBCBVPSSGQZ;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid RNOLSDGJALW;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid LDZNNPBWJTD;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid QFZXXVKGPSP;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid WTNDFXDJHNQ;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid TENMLJYNMRE;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid PMVVNYSROXB;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid CVRSRAZZVEG;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid PJJIEKTMDYG;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid JWFDHXXLBRH;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid LZGKYRMTXJY;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid VILCPMOZJGL;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid LPJPFMRVYQZ;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid LNLDAOTNERC;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid SGDZWNLPWWK;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid CBPCCIYSWBZ;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> TGCDJZFFQST;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> MWGIXPCXDXZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> QUFLVZDWNGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x839A8B0", Offset = "0x8399AB0", VA = "0x18839A8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> LSTVRUUWKIC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x839A900", Offset = "0x8399B00", VA = "0x18839A900")]
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
	public static class APYAGWVXHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8388290", Offset = "0x8387490", VA = "0x188388290")]
		public static bool MFBTENKFBNL(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8387E80", Offset = "0x8387080", VA = "0x188387E80")]
		private static bool MFBTENKFBNL(WHUINJIFGJI a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface VHPVQVRPLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(QPKNBITATPT data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, CHDJHGCFBFD circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly YGDIPUPKRWC Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<BSVXXMCDZJY> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<BSVXXMCDZJY> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<NZKBDZMUQMJ> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<FAVTMLJIUOX>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CBUHSEOEDLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x839A9D0", Offset = "0x8399BD0", VA = "0x18839A9D0")]
		public R1CreateTemplateParams(YGDIPUPKRWC circuits, IEnumerable<BSVXXMCDZJY> rootData, IReadOnlyList<BSVXXMCDZJY> allPersistableData, Id32<NZKBDZMUQMJ> sourceGraphId, IReadOnlyList<Id128<FAVTMLJIUOX>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly YGDIPUPKRWC Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<BSVXXMCDZJY> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<NZKBDZMUQMJ> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<FAVTMLJIUOX>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x839AA40", Offset = "0x8399C40", VA = "0x18839AA40")]
		public R2CreateTemplateParams(YGDIPUPKRWC circuits, Id32<NZKBDZMUQMJ> sourceGraphId, IReadOnlyList<Id128<FAVTMLJIUOX>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<BSVXXMCDZJY> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IKJAJAZEQBP : OHYXJPQWWWT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid TEMXXNUPVDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> QECKVPDBLDA;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E0A500", Offset = "0x4E09700", VA = "0x184E0A500")]
		private IKJAJAZEQBP(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x839A340", Offset = "0x8399540", VA = "0x18839A340")]
		public static IKJAJAZEQBP New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8399C50", Offset = "0x8398E50", VA = "0x188399C50")]
		private static Dictionary<Guid, Guid> AEVIJFQTIAX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x839A650", Offset = "0x8399850", VA = "0x18839A650")]
		public static IKJAJAZEQBP WTNPIHPPLNS(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8399D00", Offset = "0x8398F00", VA = "0x188399D00")]
		public static IKJAJAZEQBP ASVPENCJLZH(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x839A110", Offset = "0x8399310", VA = "0x18839A110")]
		public Dictionary<Guid, Guid> BIIQFXFGAAV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
		public Dictionary<Guid, Guid> WUSXQIHTAZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8399FF0", Offset = "0x83991F0", VA = "0x188399FF0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x839A3D0", Offset = "0x83995D0", VA = "0x18839A3D0")]
		public void SBSGVVONBRM(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x839A180", Offset = "0x8399380", VA = "0x18839A180")]
		public Guid BNZEKALDZUA([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x839A070", Offset = "0x8399270", VA = "0x18839A070")]
		public Guid BEOXNJYSLBD([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x839A2D0", Offset = "0x83994D0", VA = "0x18839A2D0")]
		public bool KJEZXDCQSFM([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x839A2D0", Offset = "0x83994D0", VA = "0x18839A2D0", Slot = "4")]
		private bool TXMUMPMBHAW([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface FGCDNTVFBVL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SSZOOAMSKHA(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BARIVZPTPQC(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PGRXNBYVEGV
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
	public abstract class RAHGREZXXIR : FGCDNTVFBVL
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IYVMDECSVWG : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string KUYIZNZFFWL
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public IYVMDECSVWG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x839A6F0", Offset = "0x83998F0", VA = "0x18839A6F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x839A7B0", Offset = "0x83999B0", VA = "0x18839A7B0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x839A660", Offset = "0x8399860", VA = "0x18839A660", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> ILEQMUNYVSI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x839A660", Offset = "0x8399860", VA = "0x18839A660", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? DLKWMHRUOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? HRMVUUIMEIP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> MNUXDYHFMSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x839B490", Offset = "0x839A690", VA = "0x18839B490")]
			[IteratorStateMachine(typeof(IYVMDECSVWG))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? VXARSDEOOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool QUWBNYFXUZF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool DBSCQNYLNZI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> EMEUPZMFMOJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool TSVZDVPTAJV(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x839AB80", Offset = "0x8399D80", VA = "0x18839AB80")]
		public void LOTSWYBRGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDD1810", Offset = "0xDD0A10", VA = "0x180DD1810")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x839B070", Offset = "0x839A270", VA = "0x18839B070", Slot = "4")]
		public bool SSZOOAMSKHA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x839AAB0", Offset = "0x8399CB0", VA = "0x18839AAB0", Slot = "5")]
		public bool BARIVZPTPQC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x839AFB0", Offset = "0x839A1B0", VA = "0x18839AFB0")]
		private bool RUMQVCKHXYO(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x839B320", Offset = "0x839A520", VA = "0x18839B320")]
		protected List<Guid> XSRVRGXUNFJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected RAHGREZXXIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class CSBFBXMNIKZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class YZUTTSBNCSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public YGDIPUPKRWC RUWXKOFGVVU;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public YZUTTSBNCSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83AD010", Offset = "0x83AC210", VA = "0x1883AD010")]
			internal Id32<QNINDUGEANA> GKANYROREOE((Id32<NZKBDZMUQMJ> GraphId, Id32<FAVTMLJIUOX> NodeId) i)
			{
				return default(Id32<QNINDUGEANA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int JKRIYWFGSRI = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<QNINDUGEANA>, NFPRGXFPGZW> OCAPKXUUWZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long VKZJCWTXVZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long OEIVLFWVPHL;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<QNINDUGEANA, int?> IHNGWXBRLUE;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long JKAVGWDMFXM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long UOADXXHBMWM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83883F0", Offset = "0x83875F0", VA = "0x1883883F0")]
		public static CSBFBXMNIKZ KTMDAQFYKGM(YGDIPUPKRWC a, Id128<NZKBDZMUQMJ> b, [Optional] CSBFBXMNIKZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8388A40", Offset = "0x8387C40", VA = "0x188388A40")]
		public static (long, long) ULJMNKIUHBQ(YGDIPUPKRWC a, Id32<NZKBDZMUQMJ> b, Id32<FAVTMLJIUOX> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8388920", Offset = "0x8387B20", VA = "0x188388920")]
		public static long MBUXRONDEYV([In] ReadOnlySpan<Id32<QNINDUGEANA>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83882C0", Offset = "0x83874C0", VA = "0x1883882C0")]
		private static long EQIDFCFFGOO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8395E10", Offset = "0x8395010", VA = "0x188395E10")]
		public CSBFBXMNIKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class NFPRGXFPGZW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long XZMTABGDEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC2DD50", Offset = "0xC2CF50", VA = "0x180C2DD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long BQPOZQIHAVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB82B40", Offset = "0xB81D40", VA = "0x180B82B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EB38F0", Offset = "0x7EB2AF0", VA = "0x187EB38F0")]
		public NFPRGXFPGZW(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class LZMKYZUCHNC
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> XKNKXBLFDSP;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class TTQWAEGTHLL
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FUARVPGFLNG : IEnumerable<BSVXXMCDZJY>, IEnumerable, IEnumerator<BSVXXMCDZJY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private BSVXXMCDZJY HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData ERMDSGHZOUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData SWLCJYHOWFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams HBIJAYKSTWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams IVOAJAJFWVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int RHIFHEGTOPM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private BSVXXMCDZJY PIQOZUQQZXP
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public FUARVPGFLNG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x839C0B0", Offset = "0x839B2B0", VA = "0x18839C0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x839C1C0", Offset = "0x839B3C0", VA = "0x18839C1C0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x839BF50", Offset = "0x839B150", VA = "0x18839BF50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BSVXXMCDZJY> YPORPIIVNPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x839BF50", Offset = "0x839B150", VA = "0x18839BF50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83A7040", Offset = "0x83A6240", VA = "0x1883A7040")]
		public static SpawnableTemplateData QUGXTYNBAKG([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83A6EB0", Offset = "0x83A60B0", VA = "0x1883A6EB0")]
		public static SpawnableTemplateData QUGXTYNBAKG([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83A6B10", Offset = "0x83A5D10", VA = "0x1883A6B10")]
		private static HashSet<Id128<NFKDLTDXJBR>> QKSPMLKIROM(IReadOnlyList<BSVXXMCDZJY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83A7670", Offset = "0x83A6870", VA = "0x1883A7670")]
		private static void SSEXXRXYWMR(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83A54F0", Offset = "0x83A46F0", VA = "0x1883A54F0")]
		public static Result<IKJAJAZEQBP, TryCloneTemplateError> PDXAQYSOGJC(SpawnableTemplateData a, SpawnTemplateParams b, IKJAJAZEQBP? srcRemapper, bool c)
		{
			return default(Result<IKJAJAZEQBP, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83A46E0", Offset = "0x83A38E0", VA = "0x1883A46E0")]
		[IteratorStateMachine(typeof(FUARVPGFLNG))]
		private static IEnumerable<BSVXXMCDZJY> ECGARTNEHGJ(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83A47F0", Offset = "0x83A39F0", VA = "0x1883A47F0")]
		private static void HLIDKMYVDDQ(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83A4E70", Offset = "0x83A4070", VA = "0x1883A4E70")]
		private static bool NLVJAWSEVLP(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83A4B80", Offset = "0x83A3D80", VA = "0x1883A4B80")]
		private static Dictionary<Guid, WHUINJIFGJI> NFWLGUSEURX(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83A4AF0", Offset = "0x83A3CF0", VA = "0x1883A4AF0")]
		private static void KRGPQSLJZGH(bool a, BSVXXMCDZJY b, IKJAJAZEQBP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83A4860", Offset = "0x83A3A60", VA = "0x1883A4860")]
		private static void IMETHHPUBDN(BSVXXMCDZJY a, Guid b, SpawnTransformData? c, Dictionary<Guid, WHUINJIFGJI> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83A71C0", Offset = "0x83A63C0", VA = "0x1883A71C0")]
		private static void SFEJLPXPJDM(IEnumerable<BSVXXMCDZJY> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public YGDIPUPKRWC circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public PGRXNBYVEGV roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public VHPVQVRPLDF circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<NZKBDZMUQMJ> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public AAIZPJCHXDV globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<BSVXXMCDZJY> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public RCACNTGCMNT photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 GNTSTLLKPXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83A3A20", Offset = "0x83A2C20", VA = "0x1883A3A20")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS AOJIOTDFMRN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83A3D30", Offset = "0x83A2F30", VA = "0x1883A3D30")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1460300", Offset = "0x145F500", VA = "0x181460300")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83A40F0", Offset = "0x83A32F0", VA = "0x1883A40F0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83A3D70", Offset = "0x83A2F70", VA = "0x1883A3D70")]
		public static SpawnTransformData RGJTATNTRPD(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83A41C0", Offset = "0x83A33C0", VA = "0x1883A41C0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x83A41E0", Offset = "0x83A33E0", VA = "0x1883A41E0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83A3FF0", Offset = "0x83A31F0", VA = "0x1883A3FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83A3B20", Offset = "0x83A2D20", VA = "0x1883A3B20")]
		public SpawnTransformData NIHPKQCKFKN(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83A4080", Offset = "0x83A3280", VA = "0x1883A4080")]
		public static SpawnTransformData ZSFXAGZVTRJ(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83A3990", Offset = "0x83A2B90", VA = "0x1883A3990")]
		public readonly CircuitsRigidTransform CGLOQKDBNMH()
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
		private readonly WMUYMRHRYMC _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1725490", Offset = "0x1724690", VA = "0x181725490")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, WMUYMRHRYMC innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83A7CF0", Offset = "0x83A6EF0", VA = "0x1883A7CF0")]
		public SXSCEXBQPFJ EGJXZRYJHDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83A7D60", Offset = "0x83A6F60", VA = "0x1883A7D60")]
		public static Result<IKJAJAZEQBP, TryCloneTemplateError> New(ERAPLCUIXZA<None> innerError)
		{
			return default(Result<IKJAJAZEQBP, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83A7E10", Offset = "0x83A7010", VA = "0x1883A7E10")]
		public static Result<IKJAJAZEQBP, TryCloneTemplateError> New(SXSCEXBQPFJ innerError)
		{
			return default(Result<IKJAJAZEQBP, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83A7EC0", Offset = "0x83A70C0", VA = "0x1883A7EC0")]
		public static Result<IKJAJAZEQBP, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<IKJAJAZEQBP, TryCloneTemplateError>);
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
	public class XUNOUGJTFDA : IDisposable, AQTYGESIWPV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> VPJJAMWGGXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float ERBIEDBZZGZ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags XBWVDBSMEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB4310", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAC3260", Offset = "0xAC2460", VA = "0x180AC3260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool VISSJYCGGGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x83ABDC0", Offset = "0x83AAFC0", VA = "0x1883ABDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ZRVCXRYVBZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x83ABE70", Offset = "0x83AB070", VA = "0x1883ABE70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> LUIJAELHYYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int MTMSADJJWCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83A9CB0", Offset = "0x83A8EB0", VA = "0x1883A9CB0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float EQRRYYRPMDU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x83AA220", Offset = "0x83A9420", VA = "0x1883AA220")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83ABE80", Offset = "0x83AB080", VA = "0x1883ABE80")]
		public XUNOUGJTFDA(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83A9C50", Offset = "0x83A8E50", VA = "0x1883A9C50", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83A9D50", Offset = "0x83A8F50", VA = "0x1883A9D50")]
		public Vector3 HEJWPBGONHZ(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83AAD90", Offset = "0x83A9F90", VA = "0x1883AAD90", Slot = "6")]
		public Quaternion MTNNZUTJVHS(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83ABDD0", Offset = "0x83AAFD0", VA = "0x1883ABDD0", Slot = "5")]
		public Vector3 ZDBQAYVEHWB(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83A9BF0", Offset = "0x83A8DF0", VA = "0x1883A9BF0", Slot = "7")]
		public float DKWSDYVYJEA(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83AA360", Offset = "0x83A9560", VA = "0x1883AA360")]
		public void KJCBUORLKEG(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83A9CF0", Offset = "0x83A8EF0", VA = "0x1883A9CF0")]
		private bool FMSJZEQJOWW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83AB270", Offset = "0x83AA470", VA = "0x1883AB270")]
		public void RFLAZENHRAC(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83ABBD0", Offset = "0x83AADD0", VA = "0x1883ABBD0")]
		public void VAYFNGSLDFX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83AAC40", Offset = "0x83A9E40", VA = "0x1883AAC40")]
		public void LXTYXXECNKM(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83AAEC0", Offset = "0x83AA0C0", VA = "0x1883AAEC0")]
		public void OQZYMANJWEQ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83AB120", Offset = "0x83AA320", VA = "0x1883AB120")]
		public void QRPAQYOHBMS(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83ABC60", Offset = "0x83AAE60", VA = "0x1883ABC60")]
		public void YGBVNUWNNYJ(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83AB3D0", Offset = "0x83AA5D0", VA = "0x1883AB3D0")]
		public static Quaternion UEBHJNJUVDV(Quaternion a, int b, float c, AQTYGESIWPV d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83A9540", Offset = "0x83A8740", VA = "0x1883A9540")]
		public Bounds CXLRWLHSHJP(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83A94E0", Offset = "0x83A86E0", VA = "0x1883A94E0", Slot = "10")]
		public virtual void AQMUYWYDPNV(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83AB070", Offset = "0x83AA270", VA = "0x1883AB070")]
		public NativeList<CurvePointData> QCNWTJPYKJD(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x839BDD0", Offset = "0x839AFD0", VA = "0x18839BDD0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x839BD10", Offset = "0x839AF10", VA = "0x18839BD10")]
		public Quaternion YJKIWQWMXBI(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x839B880", Offset = "0x839AA80", VA = "0x18839B880")]
		public CurvePoint BIVREWTCFYK(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x839BB70", Offset = "0x839AD70", VA = "0x18839BB70")]
		public YYKOWVTSTTT DPQLIQQLQLC(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class SSARLOMHLRR : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83A3060", Offset = "0x83A2260", VA = "0x1883A3060", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83A3360", Offset = "0x83A2560", VA = "0x1883A3360")]
		private void ILOEHIVWAEO(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83A3930", Offset = "0x83A2B30", VA = "0x1883A3930")]
		private void ILOEHIVWAEO(Dictionary<Guid, Guid> a, ZKWTOCXYUJD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83A30E0", Offset = "0x83A22E0", VA = "0x1883A30E0")]
		private void ILOEHIVWAEO(Dictionary<Guid, Guid> a, PEXHBDTZRSK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public SSARLOMHLRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class HXMMUQTOHEO : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x839C450", Offset = "0x839B650", VA = "0x18839C450", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public HXMMUQTOHEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class AIEZDZCWIAL : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x839B570", Offset = "0x839A770", VA = "0x18839B570", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public AIEZDZCWIAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class GLVGMJQVUOP : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x839C200", Offset = "0x839B400", VA = "0x18839C200", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public GLVGMJQVUOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class REHENUVTLEJ : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83A2620", Offset = "0x83A1820", VA = "0x1883A2620", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public REHENUVTLEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class KUIGPUIAHTI : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x839CCA0", Offset = "0x839BEA0", VA = "0x18839CCA0", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public KUIGPUIAHTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PNLWFKTVYRI : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x839CFF0", Offset = "0x839C1F0", VA = "0x18839CFF0", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public PNLWFKTVYRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class GSOSDLIJDFH : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x839C360", Offset = "0x839B560", VA = "0x18839C360", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public GSOSDLIJDFH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class QGZUQAZEBGP : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83A2350", Offset = "0x83A1550", VA = "0x1883A2350", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public QGZUQAZEBGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class BSXGIWNFOVN : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x839B6D0", Offset = "0x839A8D0", VA = "0x18839B6D0", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public BSXGIWNFOVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class DCPYBZVPYRT : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x839BE50", Offset = "0x839B050", VA = "0x18839BE50", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public DCPYBZVPYRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class QRXKIQGLIGM : HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly BORGQKVKPEO DGAMSNSLPXZ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83A2500", Offset = "0x83A1700", VA = "0x1883A2500", Slot = "4")]
		public void ACJENCTTPPX(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public QRXKIQGLIGM()
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
		public RCACNTGCMNT photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface HLEKDUHUWHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ACJENCTTPPX(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class YRATSQOBGDP
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly HLEKDUHUWHK[] ZXTRYDVHCDN;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83ABF00", Offset = "0x83AB100", VA = "0x1883ABF00")]
		public static void BHXJMZLBIPQ(BSVXXMCDZJY a, IKJAJAZEQBP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83AC570", Offset = "0x83AB770", VA = "0x1883AC570")]
		public static void TOEIHLUKRFS(BSVXXMCDZJY? data, IKJAJAZEQBP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83AC800", Offset = "0x83ABA00", VA = "0x1883AC800")]
		public static void XSNEECTFFOG(BSVXXMCDZJY? data, IKJAJAZEQBP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83AC180", Offset = "0x83AB380", VA = "0x1883AC180")]
		public static void MFBTENKFBNL(PersistableCloneParams a)
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
		public BSVXXMCDZJY viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x839D310", Offset = "0x839C510", VA = "0x18839D310")]
		public Guid VKUBHJLBCKL(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface RCACNTGCMNT
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> AMMRFQTLGBK;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> QYCSGEXPABU;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> BRDXIAOKQKE;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker YXDJVZQSMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> FJJFXFYJQJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> PCDPDMMPQLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> XJUBSDSPBOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> KXHFNXTLQSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> WHTNFURDETI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> JITIOCFFTAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> CYNPMLFTORU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> HRRFDLWHJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> YKYOHPJFBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x839FBC0", Offset = "0x839EDC0", VA = "0x18839FBC0")]
		public static void RGXCWJJXPNY(SpawnableTemplateData a, QGMOESDVPFI b, IKJAJAZEQBP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x839FB40", Offset = "0x839ED40", VA = "0x18839FB40")]
		public static PersistedRoomDataReferences PGYQXUMVBSS(PersistedRoomData a, QGMOESDVPFI? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x839D530", Offset = "0x839C730", VA = "0x18839D530")]
		public static PersistedRoomDataReferences ARFGONMQFOV(SpawnableTemplateData a, QGMOESDVPFI? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x839FA80", Offset = "0x839EC80", VA = "0x18839FA80")]
		public static PersistedRoomDataReferences JMJVJKXJTQJ(SXKHJAXUAYV a, QBMYICRFLCP b, QGMOESDVPFI? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x839F2E0", Offset = "0x839E4E0", VA = "0x18839F2E0")]
		public static PersistedRoomDataReferences EVIJTTGFYIC(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83A1E70", Offset = "0x83A1070", VA = "0x1883A1E70")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83A1CA0", Offset = "0x83A0EA0", VA = "0x1883A1CA0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x839F040", Offset = "0x839E240", VA = "0x18839F040")]
		private void EUDGUVFHPKX(PersistedRoomData a, QGMOESDVPFI? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x839EDB0", Offset = "0x839DFB0", VA = "0x18839EDB0")]
		private void EUDGUVFHPKX(SpawnableTemplateData a, QGMOESDVPFI? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x839F4E0", Offset = "0x839E6E0", VA = "0x18839F4E0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x839DFE0", Offset = "0x839D1E0", VA = "0x18839DFE0")]
		private void EUDGUVFHPKX(SXKHJAXUAYV? a, QGMOESDVPFI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x839DBE0", Offset = "0x839CDE0", VA = "0x18839DBE0")]
		private void EUDGUVFHPKX(QBMYICRFLCP? a, QGMOESDVPFI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x839DA00", Offset = "0x839CC00", VA = "0x18839DA00")]
		private void EUDGUVFHPKX(YPQYVJZYUAL? a, QGMOESDVPFI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83A1700", Offset = "0x83A0900", VA = "0x1883A1700")]
		private static bool SETNRFDXCEY(YPQYVJZYUAL a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x839D7C0", Offset = "0x839C9C0", VA = "0x18839D7C0")]
		private static bool CEEOMUYMTDO(YPQYVJZYUAL a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83A1630", Offset = "0x83A0830", VA = "0x1883A1630")]
		private static void RGXCWJJXPNY(QBMYICRFLCP? root, QGMOESDVPFI a, IKJAJAZEQBP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83A0BF0", Offset = "0x839FDF0", VA = "0x1883A0BF0")]
		private static void RGXCWJJXPNY(YPQYVJZYUAL? customProperties, QGMOESDVPFI a, IKJAJAZEQBP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83A0E80", Offset = "0x83A0080", VA = "0x1883A0E80")]
		private static void RGXCWJJXPNY(SXKHJAXUAYV? root, QGMOESDVPFI a, IKJAJAZEQBP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83A05A0", Offset = "0x839F7A0", VA = "0x1883A05A0")]
		private static void RGXCWJJXPNY(CircuitsV2.Protobuf.CircuitNodeData? node, QGMOESDVPFI a, IKJAJAZEQBP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x839DC60", Offset = "0x839CE60", VA = "0x18839DC60")]
		private void EUDGUVFHPKX(CircuitsV2.Protobuf.CircuitNodeData? a, QGMOESDVPFI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x839D5B0", Offset = "0x839C7B0", VA = "0x18839D5B0")]
		private void BKRKGDKUPLN(Guid? a, QGMOESDVPFI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x839E9B0", Offset = "0x839DBB0", VA = "0x18839E9B0")]
		private void EUDGUVFHPKX(BSVXXMCDZJY? a, QGMOESDVPFI? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83A11F0", Offset = "0x83A03F0", VA = "0x1883A11F0")]
		private static void RGXCWJJXPNY(BSVXXMCDZJY? viewData, QGMOESDVPFI a, IKJAJAZEQBP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83A1900", Offset = "0x83A0B00", VA = "0x1883A1900")]
		private void YHXQAGHGOQK(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x839D410", Offset = "0x839C610", VA = "0x18839D410")]
		private void AEXEFLQQOSW(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x839D4E0", Offset = "0x839C6E0", VA = "0x18839D4E0")]
		private void AEXEFLQQOSW(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x839D3B0", Offset = "0x839C5B0", VA = "0x18839D3B0")]
		private void AEXEFLQQOSW(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class TGMNZQTUPIN : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> GUQOGXMJXKG;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x83A44C0", Offset = "0x83A36C0", VA = "0x1883A44C0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x83A4580", Offset = "0x83A3780", VA = "0x1883A4580", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x83A4630", Offset = "0x83A3830", VA = "0x1883A4630", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x83A43E0", Offset = "0x83A35E0", VA = "0x1883A43E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
			public TGMNZQTUPIN(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x83A4340", Offset = "0x83A3540", VA = "0x1883A4340", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x83A4390", Offset = "0x83A3590", VA = "0x1883A4390", Slot = "9")]
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
			private sealed class PRQUSWPQURR : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int HDIOWKWRMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry HVLGGEUBMPZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry BDJWXPOHALF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object CVJXXTOQWTE
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x839D180", Offset = "0x839C380", VA = "0x18839D180", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
				[DebuggerHidden]
				public PRQUSWPQURR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
				[DebuggerHidden]
				private void JZSTYLGWFSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x839D1D0", Offset = "0x839C3D0", VA = "0x18839D1D0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x839D2D0", Offset = "0x839C4D0", VA = "0x18839D2D0", Slot = "8")]
				[DebuggerHidden]
				private void ZJSIHLTIANO()
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
			private ICollection UWDGQVRNWSX
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x83A2CF0", Offset = "0x83A1EF0", VA = "0x1883A2CF0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x83A2B30", Offset = "0x83A1D30", VA = "0x1883A2B30", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x83A2C10", Offset = "0x83A1E10", VA = "0x1883A2C10", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool RZTYFNOZYNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x83A2AE0", Offset = "0x83A1CE0", VA = "0x1883A2AE0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool SKXEFPGLWAV
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x83A2D70", Offset = "0x83A1F70", VA = "0x1883A2D70", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection AQWOHRWPRXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x83A2890", Offset = "0x83A1A90", VA = "0x1883A2890", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int SSRYQDFPIAC
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x83A2840", Offset = "0x83A1A40", VA = "0x1883A2840", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool RTFGHCADZWR
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x83A2E10", Offset = "0x83A2010", VA = "0x1883A2E10", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object TLNZTUSKGZK
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x83A2DC0", Offset = "0x83A1FC0", VA = "0x1883A2DC0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x83A2A20", Offset = "0x83A1C20", VA = "0x1883A2A20")]
			[IteratorStateMachine(typeof(PRQUSWPQURR))]
			private IEnumerator<DictionaryEntry> LCWPWEPXYUS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x83A2980", Offset = "0x83A1B80", VA = "0x1883A2980", Slot = "19")]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x83A2E60", Offset = "0x83A2060", VA = "0x1883A2E60", Slot = "13")]
			private IDictionaryEnumerator XTLNPLAXPTF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x83A2CA0", Offset = "0x83A1EA0", VA = "0x1883A2CA0", Slot = "9")]
			private void UDXVSLZZDJI(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x83A2930", Offset = "0x83A1B30", VA = "0x1883A2930", Slot = "10")]
			private void GBOSICSCZFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x83A2C50", Offset = "0x83A1E50", VA = "0x1883A2C50", Slot = "8")]
			private bool TBZYQFMSEIK(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x83A2A90", Offset = "0x83A1C90", VA = "0x1883A2A90", Slot = "14")]
			private void MVXUOVCBTCX(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x83A28E0", Offset = "0x83A1AE0", VA = "0x1883A28E0", Slot = "15")]
			private void EIWJXDHELIL(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class WMZJONAOBSJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int HDIOWKWRMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry HVLGGEUBMPZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention LQBDIDDTHZG;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry BDJWXPOHALF
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object CVJXXTOQWTE
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x83A9330", Offset = "0x83A8530", VA = "0x1883A9330", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
				[DebuggerHidden]
				public WMZJONAOBSJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
				[DebuggerHidden]
				private void JZSTYLGWFSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x83A9380", Offset = "0x83A8580", VA = "0x1883A9380", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x83A94A0", Offset = "0x83A86A0", VA = "0x1883A94A0", Slot = "8")]
				[DebuggerHidden]
				private void ZJSIHLTIANO()
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
			private ICollection UWDGQVRNWSX
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x839C9C0", Offset = "0x839BBC0", VA = "0x18839C9C0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x839C7D0", Offset = "0x839B9D0", VA = "0x18839C7D0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x839C8E0", Offset = "0x839BAE0", VA = "0x18839C8E0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool RZTYFNOZYNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x839C780", Offset = "0x839B980", VA = "0x18839C780", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool SKXEFPGLWAV
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x839CA10", Offset = "0x839BC10", VA = "0x18839CA10", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection AQWOHRWPRXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x839C550", Offset = "0x839B750", VA = "0x18839C550", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int SSRYQDFPIAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x839C500", Offset = "0x839B700", VA = "0x18839C500", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool RTFGHCADZWR
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x839CAB0", Offset = "0x839BCB0", VA = "0x18839CAB0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object TLNZTUSKGZK
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x839CA60", Offset = "0x839BC60", VA = "0x18839CA60", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28EEC50", Offset = "0x28EDE50", VA = "0x1828EEC50")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x839C6D0", Offset = "0x839B8D0", VA = "0x18839C6D0")]
			[IteratorStateMachine(typeof(WMZJONAOBSJ))]
			private IEnumerator<DictionaryEntry> LCWPWEPXYUS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x839C640", Offset = "0x839B840", VA = "0x18839C640", Slot = "19")]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x839CB00", Offset = "0x839BD00", VA = "0x18839CB00", Slot = "13")]
			private IDictionaryEnumerator XTLNPLAXPTF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x839C970", Offset = "0x839BB70", VA = "0x18839C970", Slot = "9")]
			private void UDXVSLZZDJI(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x839C5F0", Offset = "0x839B7F0", VA = "0x18839C5F0", Slot = "10")]
			private void GBOSICSCZFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x839C920", Offset = "0x839BB20", VA = "0x18839C920", Slot = "8")]
			private bool TBZYQFMSEIK(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x839C730", Offset = "0x839B930", VA = "0x18839C730", Slot = "14")]
			private void MVXUOVCBTCX(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x839C5A0", Offset = "0x839B7A0", VA = "0x18839C5A0", Slot = "15")]
			private void EIWJXDHELIL(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83A8290", Offset = "0x83A7490", VA = "0x1883A8290")]
		public static UgcRoomSaveStatsDetailed PGYQXUMVBSS(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83A8170", Offset = "0x83A7370", VA = "0x1883A8170")]
		[CompilerGenerated]
		internal static int GLKEMYFOQWM([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83A8C40", Offset = "0x83A7E40", VA = "0x1883A8C40")]
		[CompilerGenerated]
		internal static void VLPMTWINHSI(int a, [In] SXKHJAXUAYV graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class QGMOESDVPFI
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid XCFOFMWMQNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> CYNPMLFTORU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind EQBNTADKZHU;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x83A92D0", Offset = "0x83A84D0", VA = "0x1883A92D0")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly IKJAJAZEQBP NUJNJJZEEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> FRHCRKAGMCJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IKJAJAZEQBP PKXUOOANJHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83A1FD0", Offset = "0x83A11D0", VA = "0x1883A1FD0")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83A21D0", Offset = "0x83A13D0", VA = "0x1883A21D0")]
		public bool UTIERZHUWSL(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83A22C0", Offset = "0x83A14C0", VA = "0x1883A22C0")]
		public QGMOESDVPFI()
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
