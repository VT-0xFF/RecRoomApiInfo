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
		[Cpp2IlInjected.Address(RVA = "0x81317C0", Offset = "0x81303C0", VA = "0x1881317C0")]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PQAUYDECQRW
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> YKKOFNJMSFM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> IXEZQBRHAUY;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> RUNRDKLPTUM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> PWHRXQMOISF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string IVWHPSADNGP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string SXUDKZRIGOO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string OSPDQQKKDPR;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8131FA0", Offset = "0x8130BA0", VA = "0x188131FA0")]
	public static bool VOJYYRZELUW(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8131840", Offset = "0x8130440", VA = "0x188131840")]
	public static bool GLIUHPWEYXI(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81318D0", Offset = "0x81304D0", VA = "0x1881318D0")]
	public static string KJHGOLINAXP(Guid a)
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
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AVATAR_ITEM_DISPLAY,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WEARABLE_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
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
		[Cpp2IlInjected.Address(RVA = "0x8130B60", Offset = "0x812F760", VA = "0x188130B60", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FNNCHRLHPRD
	{
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid YRIRBVUDAEO;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid PQFUAGWIYQL;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid RYKLGIKZHQW;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid QTSUOIHXXEE;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid CVERBXWTOBC;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid VQTRMZRKOXR;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid TQYZKKQRCBN;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid NWAIDZJWYIY;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid ZPWGKKGHBVT;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid TFUQWFSQNUD;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid IAAXPHIIOOH;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid FYCYCAXKJTS;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid ZUYPGFKSBBZ;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid QIRSRAPQIQE;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid YOSNJUREOPZ;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid AVXJFOJCHIM;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid DVWOQZYSGVL;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid QKSAJJKYBBP;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid KSHMVRZBHNS;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid EUYVQLVBVWR;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid ICVTMSFXFOR;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid UWWXPXUDNKO;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid KODQWYSAAKG;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid TLZYHBMDAZO;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid EUEBCADJNMG;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid AYWMIUUXGZC;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid AFHEKFTAWZM;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid KSGUSBJEKCX;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid BKUTCNBUSJM;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid GJKMROISLXB;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid UTEYOMLTUDZ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid TPFNRVPNQQI;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid PUOBECKQRQG;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid VXGFVMVPCIH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid NRZYJPTBHSO;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid PJGTGVUGMIV;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid YEYSKPPJVUT;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid QFNXVNBILTJ;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid IGHXTLQKNHD;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid NLVAQCMACZR;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid GSDHHHTEOGB;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid SQYOPSVDDZR;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid ICUDTUNWJST;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid DSQKFWSHDTP;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid YIXMSTFXOXO;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid VKKPPZNBRTP;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid RRAODVQXIQG;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid QVBUIAVTSAS;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid ZPSZIZMINJI;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid RLGTAZFHHKR;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid DBKFNXSGMFG;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid DDRYVEGLALX;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid WUCARHPZNID;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid OKEOWPZCYNC;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid ENDSSIIKNJK;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid CJDNTXGKNEI;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid JTQCAYEYXEB;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid WDFAWQQYKJH;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid EDPWYSZQYPM;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid XSYCGSDVCME;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid DBHPLDLTGDT;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid EXGIHCJGZHK;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid DAXPFSTGQCX;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid TMKHGMZJSVR;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid ESRJCLAIQWA;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid DXQQMYWEZRR;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid JIUABQFHJFB;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid LYQBFJVGSIQ;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid ICHRLTXGSTC;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid WXZJOZADDBR;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid PNGHUIMVBNM;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid ERZPHZELNBL;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid OZBTTCQFIPW;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid POMOOBSENAH;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid DRJSSQUWYFT;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid WDBBLQSUFXG;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid APFKALXWDAO;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid GKFYZCOVZBA;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid HKTMVBFCSMY;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid FKXFMQGQRMA;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid KEGSAFSAGBT;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid NUWWSAFOBKQ;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid YDPOEUHMXRH;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid JRZRNMGUARO;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid FTKNKBVSUOJ;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid WHXQGNHTOXN;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid ZBKQHRQWHDP;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid HMCMNWSACLE;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid KVRSJOFYTRB;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid PUNLGETGIUF;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid HOAVFVUEICU;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid JDYPXDBKTBG;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid OAGBCXXSECX;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid IYSDAGSHPQF;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid BMTZXWGMHNB;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid MCRBNNTEOXB;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid PQKINNXTOHR;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid OOQDXAKIWKC;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid DNYJSUPCLCB;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid WIOYLERQPPH;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid VDEYLEXUXHQ;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid AHZZKBEHJKB;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid TCRULNRAVAU;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid VBJNSNHDLOB;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid TDCIGBEVNXM;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid VWDYXUVCNRJ;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid MYGYEADOOIL;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid QOOWEZYBNDC;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid LOEWNJWMOJV;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid ZPZWSBGVZUU;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid LOPKHXKHHGN;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid KAXZKFFZVPU;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid LLTRUGRSFDR;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid ZZQRGBRQKWY;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid LJSIPJPLUPQ;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid ZZVIPJYJUBJ;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid VSLGSZGFJOT;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid VVRMXDXGOCS;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid CKLUOQCOSER;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid VXOGVBPBTVH;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid BRHHBZPRLRQ;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid WVITWLMDYWZ;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid XLVLDBLJXDL;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid LQSDXPYXYMD;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid QBEWQVMBZGD;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid QUEGOZYWQLJ;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid ZRNAYLMFRGT;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid CYCNQQJXQUX;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid LLGPENDJKJO;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid VGIEWHQPOJV;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid KIRYMIXYYDF;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid NLWGHZPISFJ;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid ITKWDKAHNRM;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid JJWHDIDHJGJ;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid SJSLVINNOVM;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid RNPNBUTZEPK;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid CFNLRQGAYEH;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid TXLYOTABXBP;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid WQGXGQBGYLQ;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid UEIJFPJQXWE;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid XIVEIZNSFVH;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid AMJTSBTNZRR;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid MZFDXTVTCXY;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid CFVTOYNJPNO;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid WYCGDPOFRYE;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid SQLPOXPJZTU;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid DOQWKAKQDRV;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid SIIHQBAKKRV;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid SINONHUHUDE;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid SISVKOOFDON;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid SHHZDTEXPNC;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid SHNGAZYUYYL;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid SHSMYGSSIJU;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid SHXTVNMPRVD;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid MTDIWDFBAIF;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid UDQOPQYVTGR;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid MJDCBTTPIXO;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid RLKRQFSTPSQ;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid OJTVZYESPHZ;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid MDOWWNUOLLQ;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid RMNQYCZNKOQ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid YWDLUFSNUGA;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid XRNDLEJUNAX;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid MNPXSGOCJUF;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid OFPAWHEMDDY;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid YZDYDKEXLUR;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid CCQIZXBHMZK;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid WOTLXFIRQYA;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid SSGRNIRWLVH;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid ZRURVQPXEUA;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid WPJGOZQJTGB;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid WPDZRSWMJUS;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid WPTUJNEEMCT;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid XVJHNPKXIHE;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid EKBOQQHFKIT;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid MTMXSJVQFYO;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid XVEAQIQZYVV;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid JXZGBUYULRG;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid ZDEBLFSXADH;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid HOKLJHGAMGZ;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid ANUQFTJKHRK;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid RDMEWAGBFQS;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid TGIOYYJTJXO;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid FICFMQENVES;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid QKCIQELQJSQ;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid UZITDSVECDN;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid XHWHEXBKYNQ;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid QLUFLWVNBPT;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid VBUVJBZURKF;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid FUZNBRIXFPP;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid RXFHPHTKXDX;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid BQLFHENCGQI;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid LAOCIJVBXNK;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid RHKCCIYWESH;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid QLBSZHHJPCL;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid LRWWIBMSMEC;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid FEGTKNHKSLH;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid NZQNSLRHDWF;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid KDTQIKXSVKY;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid DRFPIDZZIEJ;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid HETXTTCQONI;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid HUQLQRRHQLO;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid SVUKICHHTBT;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid EMWBCLJNIRM;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid NVWMDHMNALH;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid WTQUSLLDAQJ;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid LURTLBRNYJJ;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid ZHPKEMXPGTM;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid GIHWHFGDBAZ;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid VZLADLBJXFL;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid RXNTVEQBCAC;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid PVLSFKJEXRU;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid RJQUXZSIMHX;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid ERPNZEEXUQY;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid SITPPLNXBTT;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid KZDKVAEJJZE;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid AQWHODGNWYY;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid FIOGLZVTBRA;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid IUSBGANCYTK;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid VZYWMTLUQCN;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid POAHKSTGCQL;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid LALRJPHWHOY;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid NLWQPZDFDPB;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid BFFFYZDJPLS;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid LXXATJVQYNM;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid ANYXJNPXCNS;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid VCDKZKOIQRZ;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid JPXGRZYOCID;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid AWFJBRDBBAS;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid KJOBUKHWMLV;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid QJQMIVRTNFM;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid GXWKPNXEANX;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid SKWRZYXVDQL;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid CCGZCGPSSYV;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid FZSPGIQENJJ;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid CHLWSBBDKEP;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid EGAKOMHZULJ;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid ERATJCEIQYO;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid SPOLQZKQWVV;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid XMYNTQFKJSP;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid OBFOHPJJIHC;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid BGGYIYYGYMF;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid MVXWMDRXMPW;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid FJSBGIPXWSI;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid DNDMWVRNEEI;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid XYDZSZKLCFB;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid JWRGTYKIWLW;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid TCWRBQURPLX;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid JSFBLZSIFIB;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid FZAYEEEDWQW;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid EIPNZHSDBWL;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid OTVUYQAESVX;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid RBMJRLGOILN;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid GRYXDVELIBJ;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid COJHCVAPYBD;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid NJFWKFQZYGB;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid JVSCQCNOZGG;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid RKWMEPETYYW;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid PSVWIAOHNYD;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid RNISENVHDIS;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid SDXYCUMFXDH;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid YLNSQKSRLDR;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid FSESSFFNURO;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid KLQBDMNCVVD;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid QQWGTGENIPD;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid WGSNYJCGLSN;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid LIEBUUTKUKJ;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid JZEEFAUEPDF;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid PHSRWTJBRXV;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid INXDWVMHXNX;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid OEVPWSWRBOE;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid ONAFYXTIRHQ;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid TUCOYFLHYDH;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid MPLOUACOMUC;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid PAPQJIZZZRF;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid AMXBFOCLQRX;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid LYNOAQAIPJM;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid WAQTYBPRDNL;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid ODNUAENWGKD;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid WWCPPNDJYZB;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid FUYWIYSBATQ;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid HFLGWPOSQXW;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid ZFSFQEDGQOK;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid RARWNUPPTQH;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid LCTMUWPFORR;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid FSLFPJHFXAZ;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid IOXGUSHDLCD;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid QCEKGTSVOEQ;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid DRAZXLDTOQY;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid YMTLSHXKAUI;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid PHJPWOYSAKF;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid OBVLATOGFOV;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid VHVGHAZFWNM;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid VATNSLHOCZC;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid VQQNPLYWDFR;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid JDAAELVQFDR;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid DYUHNOWSKMC;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid YQKRTBZASQL;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid SNKDHFFXRVM;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid QOGRFWTJRCD;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid TLQZGCPTRXX;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid EPYTUATQMJJ;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid VYGLWRGFBFE;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid SLDEGXOVFEW;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid NAUPBZJGESY;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid WITPHJHNRJT;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid CTFPEMFNVDO;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid YFLRZVWFVAA;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid QOKDZMRHEWE;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid ISRSMTZIREA;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid AMCUYLTLYBB;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid CCLOMMTODJJ;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid ZIHCIWJGFOL;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid JCWKWYHAKCX;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid VCUDLOGJYTH;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid NVSYGGTBOZN;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid WROKKNPOPRW;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid VVFWXMQOROA;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid QZRGTWESMTL;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid LKJYGKJKLXU;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid VOOJMZHHXKC;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid RTJDXKZSMWO;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid NXPVTZGTVLP;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid CEEWAZERRLD;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid VRABWQLJRCY;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid QURAKWQNZLA;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid OLIPREGCDWU;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid DSTYZOVQRFA;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid KUKLRBMFSQV;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid ESISVUVKUPN;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid XEBBOUJQYHQ;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid EDSTCYKSWNE;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid OUUFCQJQAIY;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid TGZWNIQPCWK;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid TSATUAHMGLF;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid EBXSRLLDOAH;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid RCDAZHJLPPN;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid WPZDJIPUYAW;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid QJWJNIWSAPS;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid VVPZQRELTJL;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid KVFLNONGSYB;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid LOGONNYWGOO;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid PPWGDETZOZE;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid BLPNOJYXOLJ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid GDSQLBIFCVK;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid LTBFYSEZOSA;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid JUGOLGWTAZF;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid JOIODGUMDKA;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid EOXUBUYHNQS;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid WEYQMXZGXWR;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid ESDUIWWVRAE;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid DTXWLDZOUQX;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid EAJVIOSZAHY;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid TLOKQCYRCKG;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid DKIHKJQWEFW;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid ATJGAVUQMDI;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid KHLVECQHJMD;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid AUHFZYTKAFN;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid RXEAWDJDYRS;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid JZWXQUVPOEX;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid KJFQMVHTSIJ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid OWJDVFEDTFL;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid LUSYKGSSIDU;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid IONSOLJIXCZ;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid LYFRBCMZNMC;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid BISPAOENNRF;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid DHHDJPOLGZQ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid IJLTQQWJIJC;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid SHIBJEIOUPL;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid PMXXXHNWYTR;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid FCYOIPRZAGZ;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid OORXFEHULZL;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid IQATTCGLWWH;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid SMCIEYMIFUU;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid EHYEEVPGTMV;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid XWOZBJVNDPE;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid STNKCIKPZLT;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid WXTWHWTCBPM;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid JHWTPSYLUBR;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid YXMBJWNGZJS;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid KFKRXELVDIV;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid EARGSRKYZNE;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid SBUFZUYMVYF;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid HZLUOBLANFK;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid ENVGXSOFHPE;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid KUCHYAUOTAL;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid ZHXFPEVROKU;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid RRWTZFOSRHT;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid BKIMOFCHPYO;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid STYKZRGTUIE;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid NVRTHMOBHWM;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid HAXJVILYTFY;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid ZSNCPVOFVDF;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid RWHGQXDAJZX;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid KYMYKHTTTSQ;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid PTTKXCWAETP;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid PEQYVASMCOQ;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid LZEJHTUOTBM;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid YODMWRPNEFW;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid PAERCRXRHVM;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid UJMUTZFZUDT;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid BWZBBRWBAYS;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid RQUXRGHMUGX;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid ISKNOIAJLSD;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid XNSCUDNYCHW;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid XMLXLKTILZO;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid XFLAARICREV;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid EHOXIMNMVTV;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid BUJFEDQEKFJ;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid KZYJZQBIADA;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid DTQCXZWZDSZ;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid POTHJXACGWC;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid VKUBFNWPZUY;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid WEXIZDDFHCV;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid MTCBJJEARVB;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid TPFPOAANVNN;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid EAHTINXJSMQ;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid JNKAQHVIISR;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid MJLNTPQHFSJ;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid IHWPTCUWJWD;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid TOKGCURNCPL;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid JZWHLEUONXP;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid ZWINIRYJHBM;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid XQZMFGFFSAG;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid JNHXTSTBGVN;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid BFOVRVKFXUR;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid JNNEQZMYQGW;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid JNSLOGGVZSF;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid JMHPHKXOLQU;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid JMMWERRLVCD;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid JMSDBYLJENM;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid JMXJZFFGNYV;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid JOSUAOCIUWY;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid JOYAXUWGEIH;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid JPPJVUNLVFP;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid UXZYLIIPURV;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid RUDTPCVYQLA;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid VBOTEEMLZLE;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid JXTABWSFBBM;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid KSZROTKGGTI;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid PPJZKLLDZCT;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid HPTLLSNVYUT;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid QZPVIVBLARA;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid TLQPSMJKFQY;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid OPZHWXBEVAZ;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid XBGKSDJJQWN;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid WYNHBCNWFUZ;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid FUCTBQSKSKK;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid EGPHVDZGOWZ;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid ZLVGSUTWYVV;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid IOMANMFSJMO;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid SXTBOQRIZFA;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid GIDYIZQYAEQ;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid TWLNUTJKEVQ;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid YKYCPEOYRZB;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid KNOHFINMWCU;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid KOOPRQIZRHN;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid VRWIQLQJQHZ;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid VXZQOGVLBOU;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid DNLGJCUKJBN;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid MPINUTWHBWG;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid HBANKNWMQZS;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid DUSJJHDJOPZ;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid VVNUECTLOIJ;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid HLCIRHJHICD;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid TQKMUBSSRVV;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid RLYSTUEQOKF;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid MXQAWXFEBMW;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid FOJREJXCSCD;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid HONDHITTSHH;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid EAUJCQYIBGW;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid RGUAFKIIDYL;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid SOWLQMXZASM;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid YRVOORDUOUL;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid XSFRTWQTGYT;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid OXEEVDNVXKU;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid CGEWQOFJTET;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid FFYZFDKBSTH;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid ELGWKQROFVL;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid VBTGVUDMJFT;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid EDOQHIWYKKQ;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid LKWUGRBEXPG;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid CAMKMSCOFLK;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid CULTZTQYQXK;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid ESPWPOSYMZQ;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid VABTQKEVNAS;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid CLFUSUBJCXJ;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid PYTLHYUEICY;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid DMHKDEVNYDG;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid CMAAFSPXOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid QVALXUPJIFT;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid WZIJRSWINYW;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid NMBZULMIQUP;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid DJQZIMCBRBY;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid GIMHMZLGRSG;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid KITHVYFLEYD;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid YCEJEBPVLKL;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid ZNVXISGJXWF;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid FLTFQMVGZLL;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid CESDBWNSHLT;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid JLQJKTAFWWS;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid DTAGEJNRWKI;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid AKVDVHQDSZF;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid MILYWKOVLGM;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid JVKVEGJKEEL;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid LEXDTJUUZTK;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid XKAAPMEDVYF;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid FPNDDBFGHHG;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid NFXIKGKYSXJ;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid VGUPTMRUCAO;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid JEFLAWABBKC;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid JTFONUYESHP;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid TAEMVWTQJNR;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid AXGYJHHYMKZ;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid EBPEAZRFJHU;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid NSXFEYOVGDL;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid PNWYEVYHBOW;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid JDNPGCIJDKQ;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid OMFABVACFBV;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid OBHRKHJRGWF;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid OBCKNAPTXKW;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid VHLOTNEVRTG;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid EBMVRXSSQGG;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid CTFKFHCVAXT;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid DQZFKUEXMSB;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid RJRBZKBNKSB;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid DAPLLNYEWUQ;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid VMJIYZUTBHJ;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid WHVMKQJJCOE;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid AWAELGFXQYN;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid YSVOVJKQWAP;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid YREWCHKWZGE;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid RTIDIBYBYMR;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid MYAPLAAYLVH;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid IHTEVBDLAPH;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid JUFUDCVPPZO;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid QCABIGZFGWM;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid CHFRDKVFVTD;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid IAIENUHYOAN;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid DWZXCLKNDTI;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid VXMSTLZFCZK;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid ZOPDTLTDMSX;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid TWFROSKUYIF;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid IBKVZAZRKHR;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid XQDLTCLIJSF;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid XEWYLEDQDVJ;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid IGBIOQKFNSI;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid KLLLLSBBRLG;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid TPSBSGGRTJT;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid CNEUJHABTPO;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid WDKRYKZYIEG;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid DADXOCOWOFL;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid CSASMVCJYGY;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid VHQUKDIFPZN;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid CDQWZUFEDQN;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid WVXCTVQCBXY;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid UEPMYRFLOAY;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid NRWLOULOVXU;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid QNXUGLEAANK;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid DKRTHDMNSKY;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid HUXCLROCNCM;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid HDXGYQENPLD;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid ZEJZBDUITRW;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid RQEBQVBYXVP;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid QZFPGGOHBFP;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid ZAENIXBPQZN;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid JEFVSIYXEOT;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid FAFDZZQLVDS;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid BXJIDUQGFLH;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid ACHNHACIEMU;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid UXYQNYWIDMS;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid UXTJQSCKUBJ;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid UXOCTLINKQA;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid TMAQGHAWMFL;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid GGHLSJUUQVX;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid GFRRAPNCONW;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid JCUNTVKGHDU;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid WIOJGEFNFYE;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid FCZBZEAKHBY;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid JGNQZEOBYVJ;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid OPJRNDLQQDA;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid HNKBKKUGQTG;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid CRRMRLMLLEJ;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid OMIFFCTWPGF;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid XKCBREHAYHW;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid BTRHBCXCETM;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid MURJIFKBTFK;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid NKYXGDKRCDI;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid CSJAMOTICHR;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid JGNFAOFVBUV;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid ENPLISTLTSM;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid ZVMWBTFWFAC;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid WIXBQXDBGIP;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid PZLKLLSFBBQ;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid EATWBMCCKJI;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid MZZQULXZBKY;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid TWNWBLQNLZC;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid DCQIBWMUNMD;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid VIADOQCSXRM;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid ZJMJGIJGPSJ;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid GZYEULXNMYH;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid QLQFNNHALJD;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid DUHKJNQFZWQ;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid EBXEIOLPPYE;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid XYKIEIAEYMC;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid ZHWBVCUWFWQ;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid HKHCRIJTKRK;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid TDDKCJIRIXY;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid RQRHSSFNLOO;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid QQRTEPGUTSX;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid QRKAPJMGAOE;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid AJRMBEBIAHO;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid IWQFCLPJXWZ;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid QUBAJFPXSIG;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid KNIJJBXBYOG;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid QTEKGHCXVBO;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid QAUDMJEOJYA;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid FNVJVZIKIFY;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid TZWXBPYPIAM;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid ZBQWZOYJKRD;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid TCVUCOHMGTG;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid SUKUPNWLCQM;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid AZIYTMTASCQ;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid EGPAISSRKAB;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid WNNAFYBHHAL;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid NESBBRSULUB;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid SHWOAZIOVSS;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid VPBNEQTLMLH;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid XTHSMPVFNMC;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid DIDJCZSWOQX;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid OUNUBCABRMY;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid SATMJEQTDNO;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid AWADMVYHDYS;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid IAYERTARWGD;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid CRIVZLYVHAO;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid NRFYBVNAKTG;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid NENSYGWSCDL;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid GERVFSMHQXD;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid PEKSDMZHRDO;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid ALZXSGTUIYR;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid ORYIZZJWZOW;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid CHGUXWBHADT;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid YSPVRSKCPLA;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid GVGYIBUWQJU;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid ICRIKVYRRAV;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid CYKWHCCBQHB;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid QJUVNCSDTJQ;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid BHVLERRHNRN;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid VAMSGQSDZJF;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid TIUGZKSBISA;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid XZPXYOJENPT;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid JLZBYQBZTUY;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid SZDYMWJFBBA;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid SIGEHUWHCIJ;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid AAXXGYUTBAB;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid CUGQTRMFRQK;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private static readonly Dictionary<Guid, SpawnableToolType> IBFZPPYDXDQ;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private static readonly Dictionary<SpawnableToolType, Guid> OSCJPKEZEVU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> TYMJOACELSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81223C0", Offset = "0x8120FC0", VA = "0x1881223C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> GOIZRCCXFXD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8122420", Offset = "0x8121020", VA = "0x188122420")]
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
	public static class CMZTOWFYFLY
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8121F80", Offset = "0x8120B80", VA = "0x188121F80")]
		public static bool SUDOEPIQVNG(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8121FB0", Offset = "0x8120BB0", VA = "0x188121FB0")]
		private static bool SUDOEPIQVNG(SQYEMCNRKEX a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QQUETYVYOTE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(ALEKCANWPMW data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, KMPSCVMNFYO circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly NSJEOKCMOGP Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public readonly IEnumerable<JEXJFGQTHAX> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly IReadOnlyList<JEXJFGQTHAX> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly Id32<LJKQDQDPBOO> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<Id128<YNBOVCHXCPU>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EUWBLNGHHQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81359E0", Offset = "0x81345E0", VA = "0x1881359E0")]
		public R1CreateTemplateParams(NSJEOKCMOGP circuits, IEnumerable<JEXJFGQTHAX> rootData, IReadOnlyList<JEXJFGQTHAX> allPersistableData, Id32<LJKQDQDPBOO> sourceGraphId, IReadOnlyList<Id128<YNBOVCHXCPU>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly NSJEOKCMOGP Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly IReadOnlyList<JEXJFGQTHAX> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly Id32<LJKQDQDPBOO> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<Id128<YNBOVCHXCPU>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8135A50", Offset = "0x8134650", VA = "0x188135A50")]
		public R2CreateTemplateParams(NSJEOKCMOGP circuits, Id32<LJKQDQDPBOO> sourceGraphId, IReadOnlyList<Id128<YNBOVCHXCPU>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<JEXJFGQTHAX> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NJDMWNWNPUS : YMTQMRDWHSE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly Guid EKYAQDGPBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private readonly Dictionary<Guid, Guid> ONIEUWDPGBN;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4D25DA0", Offset = "0x4D249A0", VA = "0x184D25DA0")]
		private NJDMWNWNPUS(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8130F80", Offset = "0x812FB80", VA = "0x188130F80")]
		public static NJDMWNWNPUS New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8130E60", Offset = "0x812FA60", VA = "0x188130E60")]
		private static Dictionary<Guid, Guid> EOVUUNLFMOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81313A0", Offset = "0x812FFA0", VA = "0x1881313A0")]
		public static NJDMWNWNPUS YDYSKEBFUQL(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8131010", Offset = "0x812FC10", VA = "0x188131010")]
		public static NJDMWNWNPUS TWGVGYKHOLK(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8130F10", Offset = "0x812FB10", VA = "0x188130F10")]
		public Dictionary<Guid, Guid> LQMGHCCIZNQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
		public Dictionary<Guid, Guid> VZRDSZTROEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8130C20", Offset = "0x812F820", VA = "0x188130C20")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81313B0", Offset = "0x812FFB0", VA = "0x1881313B0")]
		public void YTXFKOCAGVP(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8130D10", Offset = "0x812F910", VA = "0x188130D10")]
		public Guid EKXKYWCMOXP([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8131300", Offset = "0x812FF00", VA = "0x188131300")]
		public Guid UETBTOZSCMY([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8130CA0", Offset = "0x812F8A0", VA = "0x188130CA0")]
		public bool YPBFXCBWAKJ([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8130CA0", Offset = "0x812F8A0", VA = "0x188130CA0", Slot = "4")]
		private bool CAEHWSIVJHR([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface GRKNFSSFVCS
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TCPIUHCSYAB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HVZXAAFYVVP(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HUFZHZOESNI
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
	public abstract class KZSAUNORSAM : GRKNFSSFVCS
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NXJAIFTOYUJ : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			private string VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string WSCBMCOAYZI
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public NXJAIFTOYUJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x81316C0", Offset = "0x81302C0", VA = "0x1881316C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8131780", Offset = "0x8130380", VA = "0x188131780", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8131630", Offset = "0x8130230", VA = "0x188131630", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> EYJDILNHLTP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8131630", Offset = "0x8130230", VA = "0x188131630", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private Dictionary<string, HashSet<Guid>>? JISSSTBMPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		protected Dictionary<string, string>? KABXYDHXPRS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> YJOTDEZUPPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8122DA0", Offset = "0x81219A0", VA = "0x188122DA0")]
			[IteratorStateMachine(typeof(NXJAIFTOYUJ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? JNNAEPUDIZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool HLEYKMPEOSM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool CNGGCVYGBRP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> AVMENKSVDMC(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool KMYFZBDELGG(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81226C0", Offset = "0x81212C0", VA = "0x1881226C0")]
		public void NXVRZCINFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD19560", Offset = "0xD18160", VA = "0x180D19560")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8122AF0", Offset = "0x81216F0", VA = "0x188122AF0", Slot = "4")]
		public bool TCPIUHCSYAB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81225F0", Offset = "0x81211F0", VA = "0x1881225F0", Slot = "5")]
		public bool HVZXAAFYVVP(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8122E00", Offset = "0x8121A00", VA = "0x188122E00")]
		private bool WSBRDACHFQX(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8122480", Offset = "0x8121080", VA = "0x188122480")]
		protected List<Guid> HMUTQZRWLQC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected KZSAUNORSAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class LSJMJBZRKDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class SYNNFXFDNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public NSJEOKCMOGP NBRSZGQONUB;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SYNNFXFDNKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8145060", Offset = "0x8143C60", VA = "0x188145060")]
			internal Id32<WZTXIHTBGFP> ZZLPBMQVMLB((Id32<LJKQDQDPBOO> GraphId, Id32<YNBOVCHXCPU> NodeId) i)
			{
				return default(Id32<WZTXIHTBGFP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private const int DTTRRANXPWT = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly Dictionary<Id32<WZTXIHTBGFP>, JDQXQPTEJKZ> GVBJNSIBYFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private long EKMMBRYAABT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private long YJNGFFCJQOA;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly ReadOnlyIdArray<WZTXIHTBGFP, int?> XVPLRYFYWFN;

		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private static readonly long RHBRZAWHKKZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long QHGBPJLTTXB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8123560", Offset = "0x8122160", VA = "0x188123560")]
		public static LSJMJBZRKDK ZPYCGTFVWMV(NSJEOKCMOGP a, Id128<LJKQDQDPBOO> b, [Optional] LSJMJBZRKDK c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8123090", Offset = "0x8121C90", VA = "0x188123090")]
		public static (long, long) QSHKRXDIZCR(NSJEOKCMOGP a, Id32<LJKQDQDPBOO> b, Id32<YNBOVCHXCPU> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8123430", Offset = "0x8122030", VA = "0x188123430")]
		public static long TYMZQCEVDES([In] ReadOnlySpan<Id32<WZTXIHTBGFP>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8122F50", Offset = "0x8121B50", VA = "0x188122F50")]
		private static long ANBRMZUHZNB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8130AE0", Offset = "0x812F6E0", VA = "0x188130AE0")]
		public LSJMJBZRKDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class JDQXQPTEJKZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB99200", Offset = "0xB97E00", VA = "0x180B99200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long XLBTGSDSXFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB0BBF0", Offset = "0xB0A7F0", VA = "0x180B0BBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C767C0", Offset = "0x7C753C0", VA = "0x187C767C0")]
		public JDQXQPTEJKZ(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class SLIDXPHWCKV
	{
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly HashSet<SpawnableToolType> ISOAOCXIBIU;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class JWXATEPNAJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FIESVSOBJWV : IEnumerable<JEXJFGQTHAX>, IEnumerable, IEnumerator<JEXJFGQTHAX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private JEXJFGQTHAX VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private SpawnableTemplateData ADIHTNDYJTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public SpawnableTemplateData JLAIDGNULZT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnTemplateParams YKVTBVVGUEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnTemplateParams TRJUZZEWMHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private int DHBHAJRDLPJ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private JEXJFGQTHAX JTHDUEXFFLU
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public FIESVSOBJWV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8138290", Offset = "0x8136E90", VA = "0x188138290", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81383A0", Offset = "0x8136FA0", VA = "0x1881383A0", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8138130", Offset = "0x8136D30", VA = "0x188138130", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JEXJFGQTHAX> AKBRCKNDOHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8138130", Offset = "0x8136D30", VA = "0x188138130", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x813AB40", Offset = "0x8139740", VA = "0x18813AB40")]
		public static SpawnableTemplateData WXAZJSISKTH([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x813A9B0", Offset = "0x81395B0", VA = "0x18813A9B0")]
		public static SpawnableTemplateData WXAZJSISKTH([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8139220", Offset = "0x8137E20", VA = "0x188139220")]
		private static HashSet<Id128<UGSHCYHYMWS>> JAVQALIEYYT(IReadOnlyList<JEXJFGQTHAX> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81395C0", Offset = "0x81381C0", VA = "0x1881395C0")]
		private static void JBHXKVNUCXG(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x813ACD0", Offset = "0x81398D0", VA = "0x18813ACD0")]
		public static Result<NJDMWNWNPUS, TryCloneTemplateError> ZSVSBQHCIPF(SpawnableTemplateData a, SpawnTemplateParams b, NJDMWNWNPUS? srcRemapper, bool c)
		{
			return default(Result<NJDMWNWNPUS, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x813A8A0", Offset = "0x81394A0", VA = "0x18813A8A0")]
		[IteratorStateMachine(typeof(FIESVSOBJWV))]
		private static IEnumerable<JEXJFGQTHAX> WMUEYHYQZAE(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x813A2B0", Offset = "0x8138EB0", VA = "0x18813A2B0")]
		private static void OQYNJWKFGDJ(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8139C20", Offset = "0x8138820", VA = "0x188139C20")]
		private static bool OKDSNOPBTNQ(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x813A320", Offset = "0x8138F20", VA = "0x18813A320")]
		private static Dictionary<Guid, SQYEMCNRKEX> OSJLYMMBCHY(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8138CE0", Offset = "0x81378E0", VA = "0x188138CE0")]
		private static void CSZERSRRQSQ(bool a, JEXJFGQTHAX b, NJDMWNWNPUS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x813A610", Offset = "0x8139210", VA = "0x18813A610")]
		private static void TMRFAPCXOII(JEXJFGQTHAX a, Guid b, SpawnTransformData? c, Dictionary<Guid, SQYEMCNRKEX> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8138D70", Offset = "0x8137970", VA = "0x188138D70")]
		private static void FNCHMAWRKYR(IEnumerable<JEXJFGQTHAX> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public NSJEOKCMOGP circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public HUFZHZOESNI roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public QQUETYVYOTE circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public Id128<LJKQDQDPBOO> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public BEMBDYFQHQQ globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public List<JEXJFGQTHAX> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public JPWINSIOLTE photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 BCSVALIDCKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x81454F0", Offset = "0x81440F0", VA = "0x1881454F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS MDVFUVPBSGA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8145420", Offset = "0x8144020", VA = "0x188145420")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13C7FF0", Offset = "0x13C6BF0", VA = "0x1813C7FF0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x81458A0", Offset = "0x81444A0", VA = "0x1881458A0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x81451A0", Offset = "0x8143DA0", VA = "0x1881451A0")]
		public static SpawnTransformData GYNWDOAFNGK(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8145970", Offset = "0x8144570", VA = "0x188145970")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8145990", Offset = "0x8144590", VA = "0x188145990")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8145600", Offset = "0x8144200", VA = "0x188145600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8145690", Offset = "0x8144290", VA = "0x188145690")]
		public SpawnTransformData UELSKYOQTRS(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8145130", Offset = "0x8143D30", VA = "0x188145130")]
		public static SpawnTransformData GHINVPOJJPG(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8145460", Offset = "0x8144060", VA = "0x188145460")]
		public readonly CircuitsRigidTransform SGUTDRPLMMI()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private readonly JGLGQAAJYUN _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1688A10", Offset = "0x1687610", VA = "0x181688A10")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, JGLGQAAJYUN innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8145AF0", Offset = "0x81446F0", VA = "0x188145AF0")]
		public ZDIJIMUUKGW LCEALYEBJCR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8145C10", Offset = "0x8144810", VA = "0x188145C10")]
		public static Result<NJDMWNWNPUS, TryCloneTemplateError> New(ZFRSCJGMVXN<None> innerError)
		{
			return default(Result<NJDMWNWNPUS, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8145B60", Offset = "0x8144760", VA = "0x188145B60")]
		public static Result<NJDMWNWNPUS, TryCloneTemplateError> New(ZDIJIMUUKGW innerError)
		{
			return default(Result<NJDMWNWNPUS, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8145CC0", Offset = "0x81448C0", VA = "0x188145CC0")]
		public static Result<NJDMWNWNPUS, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<NJDMWNWNPUS, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class KFOWGXZFJRV : IDisposable, EFPEWGFKFOS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private NativeList<CurvePointData> SHZTVDLCOWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private float PZZIMQOHGVU;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags TWKJDAMGDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA2D20", Offset = "0xAA1920", VA = "0x180AA2D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MBFNWDEQRGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x813EA70", Offset = "0x813D670", VA = "0x18813EA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool EOLHCKVVELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x813EA00", Offset = "0x813D600", VA = "0x18813EA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> LAJRZJVQOJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int KEOSLWKAMSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x813C3F0", Offset = "0x813AFF0", VA = "0x18813C3F0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float AHPFGGOWPIT
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x813E8C0", Offset = "0x813D4C0", VA = "0x18813E8C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x813EC70", Offset = "0x813D870", VA = "0x18813EC70")]
		public KFOWGXZFJRV(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x813C590", Offset = "0x813B190", VA = "0x18813C590", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x813E340", Offset = "0x813CF40", VA = "0x18813E340")]
		public Vector3 PVPMXRQOECO(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x813C2C0", Offset = "0x813AEC0", VA = "0x18813C2C0", Slot = "6")]
		public Quaternion BBYSLLKQPCX(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x813EBD0", Offset = "0x813D7D0", VA = "0x18813EBD0", Slot = "5")]
		public Vector3 YTESNASEWLM(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x813EA10", Offset = "0x813D610", VA = "0x18813EA10", Slot = "7")]
		public float WIWOMLDUVTZ(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x813DA60", Offset = "0x813C660", VA = "0x18813DA60")]
		public void OQKCMJIQAIB(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x813C5F0", Offset = "0x813B1F0", VA = "0x18813C5F0")]
		private bool FPNHUAMYRKR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x813C430", Offset = "0x813B030", VA = "0x18813C430")]
		public void BYTKEEBQSYX(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x813D070", Offset = "0x813BC70", VA = "0x18813D070")]
		public void KDPRWEKBWOG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x813EA80", Offset = "0x813D680", VA = "0x18813EA80")]
		public void XHWFMGJCSYD(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x813CD60", Offset = "0x813B960", VA = "0x18813CD60")]
		public void JGPVYWCSPKT(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x813D910", Offset = "0x813C510", VA = "0x18813D910")]
		public void LEDJJWZKVSZ(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x813CF10", Offset = "0x813BB10", VA = "0x18813CF10")]
		public void JKBPNIZFRTK(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x813D100", Offset = "0x813BD00", VA = "0x18813D100")]
		public static Quaternion KUUVGPQPMBA(Quaternion a, int b, float c, EFPEWGFKFOS d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x813C6B0", Offset = "0x813B2B0", VA = "0x18813C6B0")]
		public Bounds HYJPXGBZWCS(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x813C650", Offset = "0x813B250", VA = "0x18813C650", Slot = "10")]
		public virtual void GFEHMWLWASW(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x813E810", Offset = "0x813D410", VA = "0x18813E810")]
		public NativeList<CurvePointData> QOBJGZFJVBM(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x81374B0", Offset = "0x81360B0", VA = "0x1881374B0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81373F0", Offset = "0x8135FF0", VA = "0x1881373F0")]
		public Quaternion PXYHZFCBXRV(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8137100", Offset = "0x8135D00", VA = "0x188137100")]
		public CurvePoint BNAJIFUQGNV(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8136F60", Offset = "0x8135B60", VA = "0x188136F60")]
		public ZBJXSUDBVLU AQCWZRKKKPJ(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class EZQLQPULSRS : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8137F80", Offset = "0x8136B80", VA = "0x188137F80", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8137950", Offset = "0x8136550", VA = "0x188137950")]
		private void QZHVELRWDXZ(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8137F20", Offset = "0x8136B20", VA = "0x188137F20")]
		private void QZHVELRWDXZ(Dictionary<Guid, Guid> a, LZXGVIYHLFC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x81376D0", Offset = "0x81362D0", VA = "0x1881376D0")]
		private void QZHVELRWDXZ(Dictionary<Guid, Guid> a, ANLTNDPNOND b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EZQLQPULSRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class PDVMGXGCJJT : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x813F1C0", Offset = "0x813DDC0", VA = "0x18813F1C0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public PDVMGXGCJJT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class YOHPEAYWZVE : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81475F0", Offset = "0x81461F0", VA = "0x1881475F0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public YOHPEAYWZVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class INZRWSDZRFC : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81383E0", Offset = "0x8136FE0", VA = "0x1881383E0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public INZRWSDZRFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class NMRVGYWZNBE : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x813EFA0", Offset = "0x813DBA0", VA = "0x18813EFA0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NMRVGYWZNBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class URFKVOCHELZ : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8145F70", Offset = "0x8144B70", VA = "0x188145F70", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public URFKVOCHELZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DKMQDFNCNKR : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8137530", Offset = "0x8136130", VA = "0x188137530", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DKMQDFNCNKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SQCAOBPTSTY : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8144F70", Offset = "0x8143B70", VA = "0x188144F70", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public SQCAOBPTSTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class WGUWBPOOZWY : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81472A0", Offset = "0x8145EA0", VA = "0x1881472A0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public WGUWBPOOZWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class QTKLPUFLTQA : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8143FB0", Offset = "0x8142BB0", VA = "0x188143FB0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public QTKLPUFLTQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class MUIJLDOWZGI : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x813EEA0", Offset = "0x813DAA0", VA = "0x18813EEA0", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public MUIJLDOWZGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class FDBISPKVKRR : GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public static readonly GOWKBFIOBKJ HSDKLHXBBCY;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8138000", Offset = "0x8136C00", VA = "0x188138000", Slot = "4")]
		public void USPJOGHWPWS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public FDBISPKVKRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public JPWINSIOLTE photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface GHRREDOVDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void USPJOGHWPWS(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class BZIYLHUAUEI
	{
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly GHRREDOVDRZ[] IJJHOWNEJCA;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8135D50", Offset = "0x8134950", VA = "0x188135D50")]
		public static void DRMTJIDEVFH(JEXJFGQTHAX a, NJDMWNWNPUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8135AC0", Offset = "0x81346C0", VA = "0x188135AC0")]
		public static void BMJDDTEIDER(JEXJFGQTHAX? data, NJDMWNWNPUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8135FD0", Offset = "0x8134BD0", VA = "0x188135FD0")]
		public static void HJMSOYOILUP(JEXJFGQTHAX? data, NJDMWNWNPUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8136240", Offset = "0x8134E40", VA = "0x188136240")]
		public static void SUDOEPIQVNG(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public JEXJFGQTHAX viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x813F270", Offset = "0x813DE70", VA = "0x18813F270")]
		public Guid EWVUQPVPUFQ(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface JPWINSIOLTE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private static readonly HashSet<Guid> KMFHHFRGZPP;

		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private static readonly HashSet<Guid> TFVCLKNWEGT;

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> RZLWHEVBCJF;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly ProfilerMarker QVHLFNHVUWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private readonly HashSet<string> HDEQOFNSHXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private readonly Dictionary<long, int> XARYMVUYOWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<Guid> CPNABELANYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly HashSet<Guid> AQPFAZFVKNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> SDLVAGETWDB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> OYESZNTXTOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> NTBCXOLLQXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> HPMWHKPOILH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> POCZAMIYWRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81406C0", Offset = "0x813F2C0", VA = "0x1881406C0")]
		public static void DDFXWWIWTJR(SpawnableTemplateData a, CUKGYQKIYEV b, NJDMWNWNPUS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8141ED0", Offset = "0x8140AD0", VA = "0x188141ED0")]
		public static PersistedRoomDataReferences KOYZTMWIPRN(PersistedRoomData a, CUKGYQKIYEV? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81438B0", Offset = "0x81424B0", VA = "0x1881438B0")]
		public static PersistedRoomDataReferences YPFNQRRGTZG(SpawnableTemplateData a, CUKGYQKIYEV? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8141E10", Offset = "0x8140A10", VA = "0x188141E10")]
		public static PersistedRoomDataReferences JCKVJWPPXPA(NOEXDRYNADI a, YYDLOFYLRHM b, CUKGYQKIYEV? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8141C10", Offset = "0x8140810", VA = "0x188141C10")]
		public static PersistedRoomDataReferences ISIVRYOFIPR(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8143E50", Offset = "0x8142A50", VA = "0x188143E50")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8143C80", Offset = "0x8142880", VA = "0x188143C80")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8141F50", Offset = "0x8140B50", VA = "0x188141F50")]
		private void PKKEIUHRONY(PersistedRoomData a, CUKGYQKIYEV? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8142570", Offset = "0x8141170", VA = "0x188142570")]
		private void PKKEIUHRONY(SpawnableTemplateData a, CUKGYQKIYEV? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x81412B0", Offset = "0x813FEB0", VA = "0x1881412B0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x81429E0", Offset = "0x81415E0", VA = "0x1881429E0")]
		private void PKKEIUHRONY(NOEXDRYNADI? a, CUKGYQKIYEV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x81437C0", Offset = "0x81423C0", VA = "0x1881437C0")]
		private void PKKEIUHRONY(YYDLOFYLRHM? a, CUKGYQKIYEV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8142800", Offset = "0x8141400", VA = "0x188142800")]
		private void PKKEIUHRONY(GSCYMCYEONA? a, CUKGYQKIYEV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x81410B0", Offset = "0x813FCB0", VA = "0x1881410B0")]
		private static bool EOYLBRSILXH(GSCYMCYEONA a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8141850", Offset = "0x8140450", VA = "0x188141850")]
		private static bool FINSYMSNVGH(GSCYMCYEONA a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x813FB80", Offset = "0x813E780", VA = "0x18813FB80")]
		private static void DDFXWWIWTJR(YYDLOFYLRHM? root, CUKGYQKIYEV a, NJDMWNWNPUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x813FC50", Offset = "0x813E850", VA = "0x18813FC50")]
		private static void DDFXWWIWTJR(GSCYMCYEONA? customProperties, CUKGYQKIYEV a, NJDMWNWNPUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8140330", Offset = "0x813EF30", VA = "0x188140330")]
		private static void DDFXWWIWTJR(NOEXDRYNADI? root, CUKGYQKIYEV a, NJDMWNWNPUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x813F530", Offset = "0x813E130", VA = "0x18813F530")]
		private static void DDFXWWIWTJR(CircuitsV2.Protobuf.CircuitNodeData? node, CUKGYQKIYEV a, NJDMWNWNPUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x81421F0", Offset = "0x8140DF0", VA = "0x1881421F0")]
		private void PKKEIUHRONY(CircuitsV2.Protobuf.CircuitNodeData? a, CUKGYQKIYEV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x813F320", Offset = "0x813DF20", VA = "0x18813F320")]
		private void CLXSLRMQKHM(Guid? a, CUKGYQKIYEV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x81433C0", Offset = "0x8141FC0", VA = "0x1881433C0")]
		private void PKKEIUHRONY(JEXJFGQTHAX? a, CUKGYQKIYEV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x813FEE0", Offset = "0x813EAE0", VA = "0x18813FEE0")]
		private static void DDFXWWIWTJR(JEXJFGQTHAX? viewData, CUKGYQKIYEV a, NJDMWNWNPUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8143840", Offset = "0x8142440", VA = "0x188143840")]
		private void UATKRWXOIQD(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8141AE0", Offset = "0x81406E0", VA = "0x188141AE0")]
		private void FMFXGFXJPND(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8141A90", Offset = "0x8140690", VA = "0x188141A90")]
		private void FMFXGFXJPND(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8141BB0", Offset = "0x81407B0", VA = "0x188141BB0")]
		private void FMFXGFXJPND(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class RDWQZREXEYY : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			private readonly IEnumerator<DictionaryEntry> YOHQCHZGVPP;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x81442F0", Offset = "0x8142EF0", VA = "0x1881442F0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x81443C0", Offset = "0x8142FC0", VA = "0x1881443C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x8144470", Offset = "0x8143070", VA = "0x188144470", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x8144210", Offset = "0x8142E10", VA = "0x188144210", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
			public RDWQZREXEYY(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8144170", Offset = "0x8142D70", VA = "0x188144170", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x81441C0", Offset = "0x8142DC0", VA = "0x1881441C0", Slot = "9")]
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
			private sealed class XNDEMSPTVFM : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000591")]
				private int VIUVMRSCWZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000592")]
				private DictionaryEntry VWMVUJJYLQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				public RoomObjectCounts BIVSZSMQJUR;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry IPTIZHLMCGY
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC652D0", VA = "0x180C666D0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object JGIILLOFTSJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8147460", Offset = "0x8146060", VA = "0x188147460", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
				[DebuggerHidden]
				public XNDEMSPTVFM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
				[DebuggerHidden]
				private void YZDXQKWRCHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x81474B0", Offset = "0x81460B0", VA = "0x1881474B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x81475B0", Offset = "0x81461B0", VA = "0x1881475B0", Slot = "8")]
				[DebuggerHidden]
				private void XHCIYLVFRPR()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x400058F")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection VZLMJKWJBJE
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x81447F0", Offset = "0x81433F0", VA = "0x1881447F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x8144920", Offset = "0x8143520", VA = "0x188144920", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x8144A00", Offset = "0x8143600", VA = "0x188144A00", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool GLUBEGRSZKF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8144880", Offset = "0x8143480", VA = "0x188144880", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool VOYHBFRZXMY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x81446D0", Offset = "0x81432D0", VA = "0x1881446D0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection NOPWTTFDHCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8144570", Offset = "0x8143170", VA = "0x188144570", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int QJCFHHVJYIV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8144BD0", Offset = "0x81437D0", VA = "0x188144BD0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool OQOMURXDXTC
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x81445C0", Offset = "0x81431C0", VA = "0x1881445C0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object JQYGOAQNBTD
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x8144A40", Offset = "0x8143640", VA = "0x188144A40", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8144660", Offset = "0x8143260", VA = "0x188144660")]
			[IteratorStateMachine(typeof(XNDEMSPTVFM))]
			private IEnumerator<DictionaryEntry> LZHHEDTNOYJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8144AE0", Offset = "0x81436E0", VA = "0x188144AE0", Slot = "19")]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8144720", Offset = "0x8143320", VA = "0x188144720", Slot = "13")]
			private IDictionaryEnumerator PLOQITPQVYQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8144B80", Offset = "0x8143780", VA = "0x188144B80", Slot = "9")]
			private void VSDBNKMGTIZ(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x81448D0", Offset = "0x81434D0", VA = "0x1881448D0", Slot = "10")]
			private void QFFVPBGCRNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8144520", Offset = "0x8143120", VA = "0x188144520", Slot = "8")]
			private bool BDOMMMZYFOT(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8144610", Offset = "0x8143210", VA = "0x188144610", Slot = "14")]
			private void HFTEJWNHAEC(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8144A90", Offset = "0x8143690", VA = "0x188144A90", Slot = "15")]
			private void UYJDRTBXIFU(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class MORWYWMMWZE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000597")]
				private int VIUVMRSCWZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000598")]
				private DictionaryEntry VWMVUJJYLQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				public Invention BIVSZSMQJUR;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry IPTIZHLMCGY
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC652D0", VA = "0x180C666D0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object JGIILLOFTSJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x813ECF0", Offset = "0x813D8F0", VA = "0x18813ECF0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
				[DebuggerHidden]
				public MORWYWMMWZE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
				[DebuggerHidden]
				private void YZDXQKWRCHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x813ED40", Offset = "0x813D940", VA = "0x18813ED40", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x813EE60", Offset = "0x813DA60", VA = "0x18813EE60", Slot = "8")]
				[DebuggerHidden]
				private void XHCIYLVFRPR()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000596")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection VZLMJKWJBJE
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x8138800", Offset = "0x8137400", VA = "0x188138800", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x81388F0", Offset = "0x81374F0", VA = "0x1881388F0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8138A00", Offset = "0x8137600", VA = "0x188138A00", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool GLUBEGRSZKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x8138850", Offset = "0x8137450", VA = "0x188138850", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool VOYHBFRZXMY
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x81386E0", Offset = "0x81372E0", VA = "0x1881386E0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection NOPWTTFDHCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x8138590", Offset = "0x8137190", VA = "0x188138590", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int QJCFHHVJYIV
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x8138BC0", Offset = "0x81377C0", VA = "0x188138BC0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool OQOMURXDXTC
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x81385E0", Offset = "0x81371E0", VA = "0x1881385E0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object JQYGOAQNBTD
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8138A40", Offset = "0x8137640", VA = "0x188138A40", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2890DF0", Offset = "0x288F9F0", VA = "0x182890DF0")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8138680", Offset = "0x8137280", VA = "0x188138680")]
			[IteratorStateMachine(typeof(MORWYWMMWZE))]
			private IEnumerator<DictionaryEntry> LZHHEDTNOYJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8138AE0", Offset = "0x81376E0", VA = "0x188138AE0", Slot = "19")]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8138730", Offset = "0x8137330", VA = "0x188138730", Slot = "13")]
			private IDictionaryEnumerator PLOQITPQVYQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8138B70", Offset = "0x8137770", VA = "0x188138B70", Slot = "9")]
			private void VSDBNKMGTIZ(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x81388A0", Offset = "0x81374A0", VA = "0x1881388A0", Slot = "10")]
			private void QFFVPBGCRNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8138540", Offset = "0x8137140", VA = "0x188138540", Slot = "8")]
			private bool BDOMMMZYFOT(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8138630", Offset = "0x8137230", VA = "0x188138630", Slot = "14")]
			private void HFTEJWNHAEC(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8138A90", Offset = "0x8137690", VA = "0x188138A90", Slot = "15")]
			private void UYJDRTBXIFU(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8146750", Offset = "0x8145350", VA = "0x188146750")]
		public static UgcRoomSaveStatsDetailed KOYZTMWIPRN(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8147120", Offset = "0x8145D20", VA = "0x188147120")]
		[CompilerGenerated]
		internal static int RWVFIOSBUVL([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x81460B0", Offset = "0x8144CB0", VA = "0x1881460B0")]
		[CompilerGenerated]
		internal static void BCRUINQRJEZ(int a, [In] NOEXDRYNADI graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class CUKGYQKIYEV
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public readonly Guid GHXFDFJTRVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public readonly IReadOnlyList<Guid> NTBCXOLLQXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly UnitySubAssetKind JNGPBCCCNLL;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8147240", Offset = "0x8145E40", VA = "0x188147240")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private readonly NJDMWNWNPUS AJEGHCSYLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private readonly Dictionary<Guid, UnitySubAsset> UPHMZFJKLTA;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NJDMWNWNPUS UCNFOQUXVMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8136BE0", Offset = "0x81357E0", VA = "0x188136BE0")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8136DE0", Offset = "0x81359E0", VA = "0x188136DE0")]
		public bool FMUDFFBYQFM(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8136ED0", Offset = "0x8135AD0", VA = "0x188136ED0")]
		public CUKGYQKIYEV()
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
