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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x817DBE0", Offset = "0x817CFE0", VA = "0x18817DBE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FRBWIFQZYIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> QHLOWKXYDRX;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> TXOTSBZHHDD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> RCYYNSATJST;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> MCXIOQCGFTK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JSCSOUAHYYW;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string NQRLKVYENLV;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string XHSOMMLKEXA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x816C410", Offset = "0x816B810", VA = "0x18816C410")]
	public static bool GULULOATDSF(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x816C510", Offset = "0x816B910", VA = "0x18816C510")]
	public static bool KIVWEDNXFQP(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x816BD90", Offset = "0x816B190", VA = "0x18816BD90")]
	public static string CKVFWOAGDJU(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x817DB20", Offset = "0x817CF20", VA = "0x18817DB20", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EWKFJSOZKXK
	{
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid ZGDCGRFFVQN;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid BWMBEARTEFW;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid RWZMWBSZIGF;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid ZFGBUOKMMFZ;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid GMKQBZPHUGL;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid GSXRHLVFQQW;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid RXPTXURBOOS;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid HYDUGFGIFRZ;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid XNWMNSWBUGU;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid JOETDNTOKWI;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid BNOIEDIKSRC;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid OJVNHKJNOKZ;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid KEAHOSAFIAA;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid QPWCBTYJSOH;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid RILLJGJXYAM;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid AIECDAUOPKL;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid PVYPLMIGCIU;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid RHOXBXEMSGG;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid POTIHEZLXRR;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid UVAUBXPKSHG;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid FAMMSMCHNFU;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid TGPIUWOBTUH;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid NAASNOQPNBT;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid GDURLSRODXL;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid THKIHRQRODZ;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid GZWFVZXGYJL;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid RRFJYMSZLXF;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid HSQEABJHEXM;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid CSWGALYICFB;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid QLHFZVPGZLO;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid CYFDJHLANDC;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid XTNUVHEIUHD;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid CNUBQHGGWIX;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid GIOBMKYEQSS;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid JEXXQCFTANX;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid HJRWESKYVYU;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid NDLNAXLHGZI;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid ONSFCPOBGCA;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid LUWRCBPHDBY;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid TYCWAYHRIIA;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid ILTKWKLVEME;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid OJFIZUDVRXY;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid YLSAFXMHXFI;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid GPLNWQQOMEE;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid GIAUGGAQSXL;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid EABVVPZRZEW;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid EXLMKUCLLXF;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid BYMLYVGDHQD;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid PFUGDQDTSAX;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid SJPOUQIANWS;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid YBKIKEQACLH;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid XVUJTZBNROI;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid BUCXKNVVFEI;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid KQIKMQYLRTN;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid QVAAGLHGFIH;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid QVDYQOIUHSF;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid EHUMLFDDHVA;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid ACQGLFTIZFK;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid KRNSUHNYJFD;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid FPTETCXYEAX;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid LVUHKNCXQEC;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid FPWRLPNJHFZ;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid LUCRMFJRNWA;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid HXSSRVNOTMY;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid GKFYJPSUVLZ;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid QOZEDKTHFDU;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid UCELQYWJORY;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid DRNOIMWQGSZ;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid XVCWTICVNXT;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid ZRKXHSWLDUI;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid NRNNDOHJQNH;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid YMYWOFAQSEG;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid UHDAPDNOHAV;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid SYSFIZJPJCI;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid TNHKUSLUDXE;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid UMXZECRMBXX;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid SFGJEHRJLKD;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid PQHCOACRHNJ;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid AXQLAENYGMP;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid PAUOPGJJHDJ;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid BACSCPUABZU;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid FOHOJHYEITN;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid GXWSVWAFYHO;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid ULRNHCDWTDB;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid PHPLIUFHFXK;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid HKYDWSEPMUI;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid PASSQYDXGYG;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid ILRCBNXULTX;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid LHYSAPZDXIE;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid ADZVKTVGBWI;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid RAONWWHAWYN;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid WGNNLUYBTEF;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid DAXXGMPZKCE;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid TURLVUPEWDG;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid OGLBQSMRLKA;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid KUQSDJIUIPA;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid QEEJRCHDWDK;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid QCADDOXWUUB;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid HKOMZWLVGLW;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid LZUVBWBVLQM;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid THSKILVXHLJ;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid AABQVEGBIAM;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid DUITYPOGUXF;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid ZCFPLUXBJTK;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid DUTHTDCBNTX;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid MVKSFVYAPAG;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid ISJFCMPYZUE;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid VQKNUDICJLX;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid DOKXQOTBOAS;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid PQVUAACPDUX;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid DOAJWBFGVEA;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid YIFQUPJFRHL;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid DPFZFPUQZUC;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid ZIGWEBRRYAP;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid GIJXYZKJVVB;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid BDJOTDDOKQS;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid GYIOXQAHAKE;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid VEJOBZCAQKL;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid GSTPPXBNSZA;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid RSLKAXLZCIK;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid HBAPWSJCMWT;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid SORFLFENZPC;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid BNRXYBVZBQM;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid ZMTAQXIXSQY;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid MHTNOKQGXZS;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid WLCERWDRYXQ;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid EMCFESFKSVI;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid HBEQZJGFVNE;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid PAPXTHRPGKP;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid SWYQBLGNCOA;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid NPPZYMIUQZU;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid BTQJTZAGXQC;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid NNPZYMWUZWN;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid GQDHXMXAZCS;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid LMHKNKLZWHH;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid JVRRXZXMGTV;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid HNCWCQQAXMI;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid UEPUXFUBQHA;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid YKTSMDHSDIJ;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid DGHYLDOPORZ;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid XCECHAPZJOK;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid UXQFOLNEGJS;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid IWBMQPDXPZJ;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid HKEAVXFMCMR;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid UCOUXLKXUKV;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid JCZHPJGMEGL;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid ZNWUMCLAATW;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid SJGXYHXDKLS;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid SJWSQCEVMTT;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid SJRLSVKYDIK;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid SKHGKPSQFQL;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid SKBZNIYSWFC;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid SKRUFDGKYND;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid SKMNHWMNPBU;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid KUDMMYMZCRS;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid PKMONGXPYJE;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid TIRBCLGSKED;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid OHXBJBWBFML;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid MLLFKUBXJFI;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid VTSBMTCGXZL;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid TKVECZQKJEX;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid JNNVGVGGFTF;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid XKAFXHWVGCU;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid OXLTGLNXRWO;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid DZJKQLLNLRZ;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid ECWEJUTBXVM;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid MPMMFSWYDNT;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid ANGILJCAYRZ;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid TXIHHVKUKVG;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid EAONNSXVMTT;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid ANLPIPVYIDI;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid ANQWFWPVROR;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid ANWDDDJTBAA;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid DYERJAPDRKP;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid UMSFBIQWKTG;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid CTDLRYYBFLT;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid DYJYGHJBAVY;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid CPFTXIXRYQL;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid FOKPUSAINLQ;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid QNCZZPGKQJK;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid MAMVRGCIDZT;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid KHXCQHTYHWZ;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid GQOFYAIGVZN;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid QUXDDPTXUNP;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid ZPKHKDJHTIP;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid IOLZDYGIKUE;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid AXVFTKTEBSX;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid QRXWLMQOOVE;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid GUOZLDXPQJO;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid OJNTENMXOCG;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid BVGKINXNXQU;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid JDWAFLNBJAF;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid WPPXMKWCDMD;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid SNUCYVQACRA;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid PNILQKZVUWU;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid CHVMUDYUSKT;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid ZUMETNMYOQY;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid UGHTGTNYCEK;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid OABMGWSAFZV;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid TYOICTGYPCW;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid DXVYHMHVJWB;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid IGBMDQZSFMR;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid YKCNIJIQROA;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid LLZWSKABGEV;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid QNEKGYGUIYW;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid IKMBJXUFUMQ;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid PKVMXHVUJEK;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid TSWFGHQHUAN;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid TJWYBXHKBDW;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid ZFVMRRZSQCU;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid CXYOGXIPHVV;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid YGRHGZEUAEZ;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid PMXCHHTMAAM;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid LZUCKYAJSTD;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid XSRRHVQBZIY;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid DLHMUDFKXMB;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid GGZTCUCTSWB;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid ZZVUACUTSUX;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid FQYQBAKEMQL;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid TOKHCJJHANK;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid GDDWVFYKGLY;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid OUXYJPBXYVB;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid ERATTMWMXXK;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid VPPHDNGJJDD;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid EWCMILHUZMX;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid DBCJPOXGBDV;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid QYGJKSAISQG;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid QZQXRGLUEBE;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid VNKPFJWKULD;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid ZJOUGVSBUEU;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid VWJDJDZYWTZ;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid DJEFKCLLPGM;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid LHETZFEGTNK;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid GPJDXJZUPZM;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid BPZSAPCWPIY;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid YPINMPQCTIK;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid BTRJWWEBDZO;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid VDOKVMCZFEL;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid SOCCUCTAKHY;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid FLLWKPLVQDK;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid BASQJIKSHRD;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid VXBGPXZXNNK;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid XQOGIRGXAYP;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid XJYCVPFBUBP;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid NUHTDQAOUNV;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid ZWAHFOBAJGG;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid UGURFMTYYRR;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid EFZAQZGPJVI;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid APPVSCNCGNM;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid CHAKIVMQAAD;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid CKPCJRBLFLE;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid PNNTHTMBLLE;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid MGLMEDNINEG;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid PODWNZMZQQK;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid SWKNLGBRHNG;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid HPFBVJTXIEI;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid BHIATSMCAUZ;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid MVKAESOWHVL;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid UPRSQHAEMGO;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid GDKRJIRAMNP;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid NIHCOFIWTXG;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid UUBMQPJUERW;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid EGAZBBVITHT;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid XILXGXMGFEA;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid IBKBBDTBUYQ;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid QWOKCTTFJJC;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid UMLUHDIZUDU;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid VSKFFGJIIDU;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid RMDRQQHHSTY;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid HZMYYNJHQXY;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid JODNURCIBJZ;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid DCYLXVJIRYT;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid MVRKYGSMIME;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid MILDQIHXVMX;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid FTSFJYLVPPW;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid JMSDPPPZNLC;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid FKRTPVEAFZF;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid QTZXFNNVOBM;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid ERBFGYWAAFG;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid OGLZTXVVIUO;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid CDNNIKOMYDX;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid GNOQZGQPTEZ;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid FXFRYJBLCOJ;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid PIIAIBTBJVK;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid VWKMTCDLTKW;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid TYVVWTAEOII;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid NXEEMLHKEQM;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid WGEPGGCGUHR;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid LMYCQKITUUB;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid GBEGFNFXEMR;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid NZOPLPLWSZQ;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid LOWCWGNTNIW;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid SBZHHMBXXTR;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid NCMYSTUWITZ;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid COLAKOCQAIC;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid YKXERXBAXEA;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid DNHMIGLBDPJ;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid QTEUDGSUKGY;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid XSPVNZIRQMZ;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid GMMZDFLUSDI;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid UJOJWYPYUKC;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid GSZPXCAPCAM;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid PMBNRFIJMVV;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid WIWFUCFFOTT;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid KVNAEUMYDVR;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid QHXWZAYDFNQ;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid ANLIAQIPDBB;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid OFIQJEWLKIX;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid ANWZUXSFUAV;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid SWLLWSZSLFD;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid CDRLCPSLDLE;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid BZDNFDFDGLA;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid ZNKOCRYJFDW;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid OPQPWWRXIQO;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid IMSUJIZOIJA;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid TVTROFAZDTC;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid ARBZSQRVCWX;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid YVCVDCFLKIX;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid GYZZTCLSKMU;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid QMBAXCPFUJL;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid XSZWMOUFFGH;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid PHCXURCFACZ;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid YPNJKEZRXJO;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid ULNQDGAGDNO;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid HEAAMXJQCQD;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid RKBXFYIXKCJ;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid IIFKFOMQDCP;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid IMNUTPAFPLR;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid SOCUKVROPFO;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid ENEAUGTSLDE;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid SEOWXWMWRQF;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid EULNEGKTFVJ;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid URLNKSEMRYZ;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid HTSPLMYCUEF;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid JPBPANXTSBE;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid XIMTRFWQMSG;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid MWGJTQKKQYG;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid JTPUQVFOYRL;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid HITXJHHVWWZ;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid GCBHGFHYZKE;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid RHWKIPEMHEC;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid OVTLLEDVDML;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid VTUHAXAIIVN;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid WHATBANGPFU;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid GHSXKDNRJZR;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid BXJLKEAPIID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid PCTSTGJSTSU;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid KYPKCHKDORV;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid EZGBFJJNUVD;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid EINSGWQYWPY;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid BNUWODQWQXR;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid ZNDZAJUXESQ;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid WYRIXBZBRYJ;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid WJFKZZKMHUT;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid TFSLUCUXGEF;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid IIMTIFPDLTN;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid CBZFOTZJWZG;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid RGMZNTVYRAM;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid OYTSMGKCJDP;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid SJIBVVLJKXO;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid HDQGISZPLGG;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid POCBOOJAMVE;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid UIYICWSLGOL;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid YVYYOSODNOG;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid DFZTADLJVOT;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid OOIAMVANYLY;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid SYOBLOQGHUD;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid DHOOHYKYVSB;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid NPMPTTAJCXE;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid FYFKAFHGXJM;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid BANRDPBAITE;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid NGXHMYUOQSW;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid FHTZGQXVSEW;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid JOXZWFQVUHD;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid OLXLSWHGXSC;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid TELCEYQXMDF;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid BLSMKESCWVO;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid WJZZOLIDJBR;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid SJGVZAGCJCG;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid SGSWMZDFCDH;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid JTQZCAMSAKW;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid NWZIOHQYJQV;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid FUNAPFMQPHK;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid SFBPURIQMRX;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid VZBBINKBHCD;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid EQMBDGFPMLK;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid TOAWUVCQKXH;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid WWKERDEKQXG;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid BTKJBLXVTBX;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid HQBZBEXAHRL;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid FKPSYVJNPYR;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid ACCPABGLEHV;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid SVDBQPHQQMK;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid OGUAIIKACKA;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid TBNHZCJVWBZ;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid HCWORYAPDSO;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid BUEBZCUGPDP;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid ANBCMMNMBTF;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid ZXMXNSIQMNX;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid BWEFQDYBYJZ;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid AYWMPPEWIBA;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid YJYGPJVOOLT;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid LDKKFALQLSS;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid ZKNMFJCJARQ;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid TIKPEXCKVHZ;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid NVKLGHRBDOJ;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid OOWTUBBQCZI;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid ZUYIZEAYJVC;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid KJFDQFPQOXS;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid CZINLVYRDMN;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid KOUCQUBBVWO;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid SJCCDULJCWJ;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid CMWOVSVDZIN;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid TAAJBVRGFLY;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid BJDFTSXZYEY;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid THMNCYQILQG;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid TIJTXNSXQNT;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid XRLFZEEXFVS;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid YSDZWPKGHIM;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid EYNZCNEJSGW;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid WFOMRSSWANW;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid QMTYDANGTFE;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid JDFLGONGBAD;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid FBNTHXZZSWB;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid EAEMMFPQAIQ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid DBAIYILMPZK;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid EAUHDZXICQR;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid EAPAGTDKTFI;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid EBEUYNLCVNJ;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid EAZOBGRFMCA;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid EBPITAYXOKB;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid EBKBVUFAEYS;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid EBZWNOMSHGT;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid EBUPQHSUXVK;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid OAONBZVFOAK;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid WRJMGEPEBHQ;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid JSKPGFASJAH;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid FUFKDTMPKRN;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid NPDULQFDZAX;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid KPBNGWLIMQR;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid NOYULZPVFGA;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid WOCXXDSMEZK;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid JYVXJCRNABP;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid QODRPWZVKNR;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid ALCBJZLOAAS;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid GHEFICLKQOU;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid GKNOQUCVRWU;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid DKLTZWPPNPN;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid QRIGGWBDVEK;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid BXUUBRRKCNI;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid EYMYRMNUAUN;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid HCVWHQIZZYB;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid LJOBJYZIPRV;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid JHGZKXDYSFV;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid QSDBSZKOCOI;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid LSGHQAHNHTF;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid LRFZDSMAMOM;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid POIUQISNWWG;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid WDPIGZJZOVN;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid KVEPXABUDXA;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid FHNRDNWFDML;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid CGPNLVREUTF;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid GAHILJFMYGU;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid JRJVEOFKIVO;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid EYEIIAZRNPI;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid CQSPEITRVGC;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid LOMUPLLXRGO;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid PNLEDGLAGNV;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid BUPBMKWQCIW;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid NMAYRXWIFGS;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid OZUQAZGPABR;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid GKSYIPJZANI;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid SQVHOVLMYRZ;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid BBJJPZTLRNQ;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid VTHMPMEAWFE;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid KGXCHZZXILX;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid RMRRPNNSIOS;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid UBNSBYXHRES;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid ZFXQRLCKQOW;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid UTEDVJVVVWM;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid AVZLSMWQCKX;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid FMDUVHASTCH;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid LMTEZHODVOH;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid EBTWRGHOXCL;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid MYEPPKMZNXJ;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid GGLSCYKCGTL;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid ZZWZIMZLNJY;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid GUZHCBBPCOZ;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid STKAUEBUATZ;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid ELLFMETKTLM;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid EPIBUHSNUUI;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid TOKHLHXKRPT;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid BKHRBFGEGEG;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid MYKKHVIDUHF;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid GSXYZQTMKHL;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid WUPNRDUQFXW;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid MBLMGLBIEMQ;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid GLOWAWLYXWM;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid YFJPMFHRWDK;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid XBIGSMRFSZY;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid CSZJQNFDSFL;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid FHNFEOTXMHB;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid MADEFCVWQXA;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid EGMWFWFRFVL;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid DBOGSAVDHUC;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid ZJRZODKDJIH;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid QBOAZBCYSZA;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid SDCQDSYALKT;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid WHEGFAPMPLC;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid OGHHWUZHNPT;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid PJYWKGDUNWN;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid WZULOCUFACW;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid AGFTEKMKNSQ;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid OGCYLUJDDWO;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid UMFSANLZMTV;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid TNEGLAHLKUW;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid UPNQVVXURUX;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid MSOKQZGFLDD;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid EEIHJHSIQFO;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid CMFEEXYTZTE;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid CMKLCESRJEN;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid VZCTMZSKKVB;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid TNKFEWZRHFD;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid JCDRSUBMYYO;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid GEOVTRSDHII;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid ISKCWLKCGZA;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid FYXSTGEYXFZ;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid CQDFYALHHVA;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid SJAUKENUCED;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid DFYDFOHJPXE;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid FGHWIHWCFSE;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid NSHGBDVNEJL;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid SQFVVESHXSO;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid JOOBLHJSSCM;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid EDRBQWSVAGY;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid MLGXADJBIAB;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid FTHOETLFMSF;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid RFAXFNCWRDU;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid LSEYEMEMIEA;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid YLDVBNZUVCL;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid YPMNMOCOBAH;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid SOKYASPOZEY;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid QAJKEMXKBRE;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid JVCMYDAKTSW;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid XEIMSLPMTRA;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid PCKVNYPDUQS;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid TVUAFZESMSX;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid TJORFPURYPJ;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid RZSZXMNMPPW;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid PMABGHBTNRD;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid ZBJKWKCPSLD;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid ROKRJQBSOLS;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid CSXLIHOKMLL;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid CWVJFPASQVA;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid CHBEMKQJOXG;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid ZOCFBNRHNGJ;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid NBCAHDBTJXN;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid VOYTFXEWAYL;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid SQUVEAOBZXR;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid CVYRWBSUVPV;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid LHHGAHKTJIR;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid FUDVFKEAZWG;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid PYYKHJZYWGX;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid WVJDPXMYTXY;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid SHYAEYZELBS;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid GAPNVTYWNSY;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid MMLBBGOJVMQ;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid VEHLMQIUART;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid JABEHMLJRGY;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid NSXMXFIMBCT;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid ZLIDPYYKXPH;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid ZKSIYEQSVHG;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid ZKXPVLKQESP;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid XNKBYZLPRPU;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid MUQQRJAIMJE;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid MULJUCGLCXV;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid UXYHWFOMNGL;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid GCIHTYXIZPN;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid VCIMRRPPMVN;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid AAEFOMIUXNG;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid BCVRQTBWZNX;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid VYIBYMGSZJN;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid KVBFYXNVYDC;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid VVZGSYOXSLQ;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid FFCKHGSAKNZ;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid IAONLODHONF;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid KGDLTKFGQIH;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid MCXJWPDKYHH;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid VUBXFMSECFG;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid HZMQLPSYFBC;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid UNFBLIORZCV;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid KBTSBSIAIXR;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid ONJCFGHWVGO;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid AUWNRWKYNTV;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid CUJRHGMBXOB;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid ADURJNLRKNZ;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid EVGQGMLPLIB;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid TUDWJJFGDUG;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid YPDNOPLMXEB;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid QNEOGDGJMME;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid BZMKCQYFYVO;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid SKSFHAAWADI;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid WXWWIQTIEGT;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid VVJSXNCQDVL;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid MXNGVNZDQRP;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid OOSOLGZGRWR;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid RUAKKFGWKDV;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid HTVCWGEVHSP;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid KSPQCZUYSFN;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid JRCSNMJSMKI;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid LTQKVLTIPIR;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid CKYPIEQNCCX;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid ZXBZGGCIKBK;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid JDYGZZCATEX;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid COBUBLJKZPJ;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid SIPNVIWOWCV;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid PWGDASFGLXV;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid VWXOWDQGAXD;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid SSKMRKZHRIB;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid IWLYZZIGBMI;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid JJAKRQAXPXR;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid CJDRYZSIJXP;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid TECBYKMPGNB;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid NLXIFSHVGAQ;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid QTGFIPZHYCO;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid RWYCDTSVJYQ;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid VHEOQBJBGYR;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid XOBBLXHCSYG;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid RSJAWWOBRYJ;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid OEJNMNCRBEC;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid BONDYRVXRJD;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid PQYRVZKPWFP;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid WALGMIDODDF;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid OUIOKELPMSI;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid PXSNCUXMTXL;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid SQZZGMRWOGF;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid YIOLHRUJQMA;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid VXLPCGYQNMQ;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid EPOVUNSEQIL;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid OPSJVESDSMO;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid OZUFEMKOVSP;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid BXAHNXWUMAW;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid RESSGKTVPST;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid PQVCODZICXX;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid DLTVQCPAWKA;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid QIAOUWVNRGU;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid NMDHTOHIGXD;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid OGRMIJIFNFC;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid KPHGNKJLUVG;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid KZLVXLGQCDB;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid BFYDSZGRAHK;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid SIUGDKAMYSZ;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid VJEXSSKCVWD;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid ZJQYDJNGDGG;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid CLWKRDMFAJS;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid QRFLJIRUGSB;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private static readonly Dictionary<Guid, SpawnableToolType> YOMSMWYSGOV;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private static readonly Dictionary<SpawnableToolType, Guid> EPMSDWVSPER;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> SLSKEXWXNWI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x816B330", Offset = "0x816A730", VA = "0x18816B330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> RSCEOTGGEZK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x816B2E0", Offset = "0x816A6E0", VA = "0x18816B2E0")]
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
	public static class IWOAXTHCIYR
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x817DAF0", Offset = "0x817CEF0", VA = "0x18817DAF0")]
		public static bool MPZXWFXQHEP(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x817D6E0", Offset = "0x817CAE0", VA = "0x18817D6E0")]
		private static bool MPZXWFXQHEP(ZHLEOSYTUAE a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface EMAVHHXMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(OYDQVLAAVPV data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, UHQQYIFLWXZ circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly ZIFYNAHDVNO Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public readonly IEnumerable<PJGKUFHRWDW> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly IReadOnlyList<PJGKUFHRWDW> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly Id32<LVEMYDMRMXB> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<Id128<YAEGQIMTQZT>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FYFSOAQHFHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x817DDF0", Offset = "0x817D1F0", VA = "0x18817DDF0")]
		public R1CreateTemplateParams(ZIFYNAHDVNO circuits, IEnumerable<PJGKUFHRWDW> rootData, IReadOnlyList<PJGKUFHRWDW> allPersistableData, Id32<LVEMYDMRMXB> sourceGraphId, IReadOnlyList<Id128<YAEGQIMTQZT>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly ZIFYNAHDVNO Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly IReadOnlyList<PJGKUFHRWDW> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly Id32<LVEMYDMRMXB> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<Id128<YAEGQIMTQZT>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x817DE60", Offset = "0x817D260", VA = "0x18817DE60")]
		public R2CreateTemplateParams(ZIFYNAHDVNO circuits, Id32<LVEMYDMRMXB> sourceGraphId, IReadOnlyList<Id128<YAEGQIMTQZT>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<PJGKUFHRWDW> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FKGNXVXVPVN : BCNYYYIECUV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly Guid TTTWNXWTBAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private readonly Dictionary<Guid, Guid> GPCGSVYEWRK;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E057E0", Offset = "0x4E04BE0", VA = "0x184E057E0")]
		private FKGNXVXVPVN(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x816BB30", Offset = "0x816AF30", VA = "0x18816BB30")]
		public static FKGNXVXVPVN New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x816BBC0", Offset = "0x816AFC0", VA = "0x18816BBC0")]
		private static Dictionary<Guid, Guid> PPTALOUEDAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x816BC70", Offset = "0x816B070", VA = "0x18816BC70")]
		public static FKGNXVXVPVN TRVESAMNCEC(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x816B5C0", Offset = "0x816A9C0", VA = "0x18816B5C0")]
		public static FKGNXVXVPVN JYYOEVNEPXB(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x816B550", Offset = "0x816A950", VA = "0x18816B550")]
		public Dictionary<Guid, Guid> ENDGIJKDEOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
		public Dictionary<Guid, Guid> BAWZIJXPPSZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x816B380", Offset = "0x816A780", VA = "0x18816B380")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x816B8B0", Offset = "0x816ACB0", VA = "0x18816B8B0")]
		public void LZYDIDPHLSI(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x816B400", Offset = "0x816A800", VA = "0x18816B400")]
		public Guid DUTFHAFCUEK([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x816BC80", Offset = "0x816B080", VA = "0x18816BC80")]
		public Guid URXFDQVCDFR([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x816BD20", Offset = "0x816B120", VA = "0x18816BD20")]
		public bool YFERBCFHOIE([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x816BD20", Offset = "0x816B120", VA = "0x18816BD20", Slot = "4")]
		private bool YRTORDEFXTO([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface HORKMIMPVXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LJAIZTFANWY(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QVVHQQENHVO(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface TMPCNXDQIIP
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
	public abstract class EIFFKSWURIT : HORKMIMPVXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class OHKNFCQHFIU : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			private string FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string ENARBZMVDAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
			[DebuggerHidden]
			public OHKNFCQHFIU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x817DD30", Offset = "0x817D130", VA = "0x18817DD30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x817DC60", Offset = "0x817D060", VA = "0x18817DC60", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x817DCA0", Offset = "0x817D0A0", VA = "0x18817DCA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> MXWGMYNXTOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x817DCA0", Offset = "0x817D0A0", VA = "0x18817DCA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private Dictionary<string, HashSet<Guid>>? INSIRGALRGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		protected Dictionary<string, string>? ORQLGPBJQHL;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> JVVMNHPHNAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x816AAD0", Offset = "0x8169ED0", VA = "0x18816AAD0")]
			[IteratorStateMachine(typeof(OHKNFCQHFIU))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? ZWWIOZPNPMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool UPKYVSFXQHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool UGUOBZEMHHS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> GSEJXHUEAML(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool RHQWKAGKFJH(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x816AE30", Offset = "0x816A230", VA = "0x18816AE30")]
		public void SUDEQKJPTVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD4CB20", Offset = "0xD4BF20", VA = "0x180D4CB20")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x816A820", Offset = "0x8169C20", VA = "0x18816A820", Slot = "4")]
		public bool LJAIZTFANWY(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x816AB30", Offset = "0x8169F30", VA = "0x18816AB30", Slot = "5")]
		public bool QVVHQQENHVO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x816AD70", Offset = "0x816A170", VA = "0x18816AD70")]
		private bool RKKERRZRRRG(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x816AC00", Offset = "0x816A000", VA = "0x18816AC00")]
		protected List<Guid> QZMOURKSTHL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected EIFFKSWURIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class IABJGMKMLLR
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ZUBXSHNKXNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public ZIFYNAHDVNO IARFCCNKTTW;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ZUBXSHNKXNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x818F990", Offset = "0x818ED90", VA = "0x18818F990")]
			internal Id32<KKPQBRSEYJS> ZSFOXJXLEOS((Id32<LVEMYDMRMXB> GraphId, Id32<YAEGQIMTQZT> NodeId) i)
			{
				return default(Id32<KKPQBRSEYJS>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private const int LMQCSVHCTSY = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly Dictionary<Id32<KKPQBRSEYJS>, NHVAQOZHKNA> LXUHKVRCTDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private long ZZQYYEDXYHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private long EEYGQEZDNNN;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly ReadOnlyIdArray<KKPQBRSEYJS, int?> SJNZPFHAYCC;

		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private static readonly long MGICWFOSLOU;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long IKTUXQWURYC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81700F0", Offset = "0x816F4F0", VA = "0x1881700F0")]
		public static IABJGMKMLLR YBNGHWHQWSO(ZIFYNAHDVNO a, Id128<LVEMYDMRMXB> b, [Optional] IABJGMKMLLR c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x816FD50", Offset = "0x816F150", VA = "0x18816FD50")]
		public static (long, long) RQZIDKHOKOQ(ZIFYNAHDVNO a, Id32<LVEMYDMRMXB> b, Id32<YAEGQIMTQZT> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x816FC30", Offset = "0x816F030", VA = "0x18816FC30")]
		public static long ORJTPTGCKVN([In] ReadOnlySpan<Id32<KKPQBRSEYJS>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x816FB00", Offset = "0x816EF00", VA = "0x18816FB00")]
		private static long LSSIXFYPISU()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x817D660", Offset = "0x817CA60", VA = "0x18817D660")]
		public IABJGMKMLLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class NHVAQOZHKNA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long RUUQZBEMWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xBCF360", Offset = "0xBCE760", VA = "0x180BCF360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long QSFNHBBEWKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB2FE30", Offset = "0xB2F230", VA = "0x180B2FE30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7CB0D60", Offset = "0x7CB0160", VA = "0x187CB0D60")]
		public NHVAQOZHKNA(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class XRPGRCLRDLI
	{
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly HashSet<SpawnableToolType> ILKXIOVLYRX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class KPWABCETUBB
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NMPZXXRFVFA : IEnumerable<PJGKUFHRWDW>, IEnumerable, IEnumerator<PJGKUFHRWDW>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private PJGKUFHRWDW FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private SpawnableTemplateData AGPPXWGYJDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public SpawnableTemplateData MSVHIQRSYJS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnTemplateParams NBTYMYRYLAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnTemplateParams LOPYNHOGCSY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private int LPLBTFNQDEY;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private PJGKUFHRWDW STQDZZKVJVJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
			[DebuggerHidden]
			public NMPZXXRFVFA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8186160", Offset = "0x8185560", VA = "0x188186160", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8186120", Offset = "0x8185520", VA = "0x188186120", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8185FC0", Offset = "0x81853C0", VA = "0x188185FC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PJGKUFHRWDW> CAWTSGISOWM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8185FC0", Offset = "0x81853C0", VA = "0x188185FC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81834C0", Offset = "0x81828C0", VA = "0x1881834C0")]
		public static SpawnableTemplateData LBOELCYRDDW([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8183330", Offset = "0x8182730", VA = "0x188183330")]
		public static SpawnableTemplateData LBOELCYRDDW([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8183CB0", Offset = "0x81830B0", VA = "0x188183CB0")]
		private static HashSet<Id128<SMGNNBTWEUN>> SHPLMHQFRFI(IReadOnlyList<PJGKUFHRWDW> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8183640", Offset = "0x8182A40", VA = "0x188183640")]
		private static void MEXSOAWVVWT(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8184340", Offset = "0x8183740", VA = "0x188184340")]
		public static Result<FKGNXVXVPVN, TryCloneTemplateError> XHZUXROTCIK(SpawnableTemplateData a, SpawnTemplateParams b, FKGNXVXVPVN? srcRemapper, bool c)
		{
			return default(Result<FKGNXVXVPVN, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8185BC0", Offset = "0x8184FC0", VA = "0x188185BC0")]
		[IteratorStateMachine(typeof(NMPZXXRFVFA))]
		private static IEnumerable<PJGKUFHRWDW> ZXNPHOTAXKX(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8182780", Offset = "0x8181B80", VA = "0x188182780")]
		private static void BMGCZVVARBS(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81827F0", Offset = "0x8181BF0", VA = "0x1881827F0")]
		private static bool FMREPSCNGWH(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8184050", Offset = "0x8183450", VA = "0x188184050")]
		private static Dictionary<Guid, ZHLEOSYTUAE> XATTKDZNPBN(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81826F0", Offset = "0x8181AF0", VA = "0x1881826F0")]
		private static void ASQBLDDESSF(bool a, PJGKUFHRWDW b, FKGNXVXVPVN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8185930", Offset = "0x8184D30", VA = "0x188185930")]
		private static void YAJMSRRXQTT(PJGKUFHRWDW a, Guid b, SpawnTransformData? c, Dictionary<Guid, ZHLEOSYTUAE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8182E80", Offset = "0x8182280", VA = "0x188182E80")]
		private static void JKDTXLLCHEM(IEnumerable<PJGKUFHRWDW> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public ZIFYNAHDVNO circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public TMPCNXDQIIP roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public EMAVHHXMMHH circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public Id128<LVEMYDMRMXB> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CFVHDLAXNSV globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public List<PJGKUFHRWDW> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public NAMXWXTEIQH photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 PVDHHZPWCMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x818CF90", Offset = "0x818C390", VA = "0x18818CF90")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS OSHUXHUOPDL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x818D310", Offset = "0x818C710", VA = "0x18818D310")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13F73C0", Offset = "0x13F67C0", VA = "0x1813F73C0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x818D450", Offset = "0x818C850", VA = "0x18818D450")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x818D090", Offset = "0x818C490", VA = "0x18818D090")]
		public static SpawnTransformData SLGPSKGGYYX(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x818D520", Offset = "0x818C920", VA = "0x18818D520")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x818D540", Offset = "0x818C940", VA = "0x18818D540")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x818D350", Offset = "0x818C750", VA = "0x18818D350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x818CD80", Offset = "0x818C180", VA = "0x18818CD80")]
		public SpawnTransformData JWIBPKDUIOH(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x818D3E0", Offset = "0x818C7E0", VA = "0x18818D3E0")]
		public static SpawnTransformData YYFDBXVUFBD(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x818CCF0", Offset = "0x818C0F0", VA = "0x18818CCF0")]
		public readonly CircuitsRigidTransform CYOMCIXXIMZ()
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
		private readonly AFOSPUXIYKE _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x16B50C0", Offset = "0x16B44C0", VA = "0x1816B50C0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, AFOSPUXIYKE innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x818E140", Offset = "0x818D540", VA = "0x18818E140")]
		public NIBBSNHBBHP NKVPAMYDCAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x818E260", Offset = "0x818D660", VA = "0x18818E260")]
		public static Result<FKGNXVXVPVN, TryCloneTemplateError> New(JTEQHTFKULG<None> innerError)
		{
			return default(Result<FKGNXVXVPVN, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x818E1B0", Offset = "0x818D5B0", VA = "0x18818E1B0")]
		public static Result<FKGNXVXVPVN, TryCloneTemplateError> New(NIBBSNHBBHP innerError)
		{
			return default(Result<FKGNXVXVPVN, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x818E310", Offset = "0x818D710", VA = "0x18818E310")]
		public static Result<FKGNXVXVPVN, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<FKGNXVXVPVN, TryCloneTemplateError>);
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
	public class HANGKQGFZTO : IDisposable, LQCWCQVSYUV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private NativeList<CurvePointData> GZRYJIBJJBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private float JVZOOWYPTBB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags SLJIVVOVDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA5C90", Offset = "0xAA5090", VA = "0x180AA5C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool AUTZIQHGWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x817F910", Offset = "0x817ED10", VA = "0x18817F910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OTVLZGWFYGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x81808E0", Offset = "0x817FCE0", VA = "0x1881808E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> ATTNQPWFDDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int RZRIAZHLSEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8181C70", Offset = "0x8181070", VA = "0x188181C70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float SOOFHWJECXC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8181240", Offset = "0x8180640", VA = "0x188181240")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8181CB0", Offset = "0x81810B0", VA = "0x188181CB0")]
		public HANGKQGFZTO(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x817F620", Offset = "0x817EA20", VA = "0x18817F620", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x817F9C0", Offset = "0x817EDC0", VA = "0x18817F9C0")]
		public Vector3 JXLNEAMVQCV(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x817F680", Offset = "0x817EA80", VA = "0x18817F680", Slot = "6")]
		public Quaternion FOALUTTUCPY(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x817F920", Offset = "0x817ED20", VA = "0x18817F920", Slot = "5")]
		public Vector3 IRHHTKMJCDV(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x817F310", Offset = "0x817E710", VA = "0x18817F310", Slot = "7")]
		public float AXOHVDAOJGG(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x817FF40", Offset = "0x817F340", VA = "0x18817FF40")]
		public void KQVPZBKBTYM(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8180820", Offset = "0x817FC20", VA = "0x188180820")]
		private bool NALWVIJISII(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x817F370", Offset = "0x817E770", VA = "0x18817F370")]
		public void BFKWOELPZUA(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8181380", Offset = "0x8180780", VA = "0x188181380")]
		public void WVZKKHOJWML(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x817F4D0", Offset = "0x817E8D0", VA = "0x18817F4D0")]
		public void CSXOTSJVMWO(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8181AC0", Offset = "0x8180EC0", VA = "0x188181AC0")]
		public void ZCYTRAXEGJA(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81810F0", Offset = "0x81804F0", VA = "0x1881810F0")]
		public void VSFKKIMGPJW(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x817F7B0", Offset = "0x817EBB0", VA = "0x18817F7B0")]
		public void FUVWITAEBHJ(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81808F0", Offset = "0x817FCF0", VA = "0x1881808F0")]
		public static Quaternion USFEYFNJXXX(Quaternion a, int b, float c, LQCWCQVSYUV d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8181410", Offset = "0x8180810", VA = "0x188181410")]
		public Bounds XLWRJVZLUBF(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8180880", Offset = "0x817FC80", VA = "0x188180880", Slot = "10")]
		public virtual void NEZNORYVXAV(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x817FE90", Offset = "0x817F290", VA = "0x18817FE90")]
		public NativeList<CurvePointData> KCTQFDODGKT(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x817EFC0", Offset = "0x817E3C0", VA = "0x18817EFC0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x817EF00", Offset = "0x817E300", VA = "0x18817EF00")]
		public Quaternion YNGOSYPJKKA(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x817EC10", Offset = "0x817E010", VA = "0x18817EC10")]
		public CurvePoint QWRYGFHUWIQ(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x817EA70", Offset = "0x817DE70", VA = "0x18817EA70")]
		public CELQLFNPTBZ GOZJWYRBDJQ(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class TEHRKESZLMZ : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x818D6A0", Offset = "0x818CAA0", VA = "0x18818D6A0", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x818D720", Offset = "0x818CB20", VA = "0x18818D720")]
		private void WOKNDTPXNZG(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x818DF80", Offset = "0x818D380", VA = "0x18818DF80")]
		private void WOKNDTPXNZG(Dictionary<Guid, Guid> a, QVRAODRSZOP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x818DD00", Offset = "0x818D100", VA = "0x18818DD00")]
		private void WOKNDTPXNZG(Dictionary<Guid, Guid> a, HZXAAVDSRCE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public TEHRKESZLMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class OIHSCFXIVJS : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8186370", Offset = "0x8185770", VA = "0x188186370", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public OIHSCFXIVJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class TSGUZVYTDBL : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x818DFE0", Offset = "0x818D3E0", VA = "0x18818DFE0", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public TSGUZVYTDBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class MSYNNAAMLQR : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8185E60", Offset = "0x8185260", VA = "0x188185E60", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MSYNNAAMLQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class JFBQOBLNGZZ : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81824D0", Offset = "0x81818D0", VA = "0x1881824D0", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public JFBQOBLNGZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class CPKUKGYJYHO : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x817E780", Offset = "0x817DB80", VA = "0x18817E780", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public CPKUKGYJYHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class BVKCTSYEHUY : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x817E5F0", Offset = "0x817D9F0", VA = "0x18817E5F0", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public BVKCTSYEHUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class OIRDFESMSBB : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8186420", Offset = "0x8185820", VA = "0x188186420", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public OIRDFESMSBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CXXZFSOBUYB : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x817E8C0", Offset = "0x817DCC0", VA = "0x18817E8C0", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public CXXZFSOBUYB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class FDJWXVTMLPD : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x817F040", Offset = "0x817E440", VA = "0x18817F040", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public FDJWXVTMLPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class NMSESAEITHR : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8186270", Offset = "0x8185670", VA = "0x188186270", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public NMSESAEITHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class FFEENKWOOQW : GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public static readonly RUZOEYNNZQU AVDBZCARTPD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x817F1F0", Offset = "0x817E5F0", VA = "0x18817F1F0", Slot = "4")]
		public void PQXBKJGXDKT(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public FFEENKWOOQW()
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
		public NAMXWXTEIQH photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface GSEXNNZSPUK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PQXBKJGXDKT(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SERSWYBWXJZ
	{
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly GSEXNNZSPUK[] EWLTHBGTCJD;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x818C4B0", Offset = "0x818B8B0", VA = "0x18818C4B0")]
		public static void YRUYVABOKGM(PJGKUFHRWDW a, FKGNXVXVPVN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x818C220", Offset = "0x818B620", VA = "0x18818C220")]
		public static void RWXKBCGYSDU(PJGKUFHRWDW? data, FKGNXVXVPVN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x818BBE0", Offset = "0x818AFE0", VA = "0x18818BBE0")]
		public static void BPPXIDGUNOE(PJGKUFHRWDW? data, FKGNXVXVPVN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x818BE50", Offset = "0x818B250", VA = "0x18818BE50")]
		public static void MPZXWFXQHEP(PersistableCloneParams a)
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
		public PJGKUFHRWDW viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81866C0", Offset = "0x8185AC0", VA = "0x1881866C0")]
		public Guid WZPVISCXSSZ(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface NAMXWXTEIQH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private static readonly HashSet<Guid> NLJVNRWIOWW;

		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private static readonly HashSet<Guid> ANYUTIBEJAU;

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> SZOUUJMZYPY;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly ProfilerMarker KRSOAIAHSSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private readonly HashSet<string> KYSOCYTCONT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private readonly Dictionary<long, int> MWRYVRYORMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<Guid> QESDXKRJMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly HashSet<Guid> NKNELGJXKBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> ZWRGBENJUHO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> GHLVFODHMCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> BAQFRYKGCDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> CDGDNCDPYJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> ZWDITICMAAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8188430", Offset = "0x8187830", VA = "0x188188430")]
		public static void GXCALNBFLXS(SpawnableTemplateData a, BFKITSIWYSM b, FKGNXVXVPVN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8188E30", Offset = "0x8188230", VA = "0x188188E30")]
		public static PersistedRoomDataReferences KZHFXKSGRJK(PersistedRoomData a, BFKITSIWYSM? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8189120", Offset = "0x8188520", VA = "0x188189120")]
		public static PersistedRoomDataReferences TXXQINNVQPV(SpawnableTemplateData a, BFKITSIWYSM? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x81893B0", Offset = "0x81887B0", VA = "0x1881893B0")]
		public static PersistedRoomDataReferences YRFHJMIQIAD(EQKDAXAXTVB a, OXOXLKQPEBH b, BFKITSIWYSM? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8186760", Offset = "0x8185B60", VA = "0x188186760")]
		public static PersistedRoomDataReferences CROHTYQJUGY(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x818B260", Offset = "0x818A660", VA = "0x18818B260")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x818B090", Offset = "0x818A490", VA = "0x18818B090")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8189650", Offset = "0x8188A50", VA = "0x188189650")]
		private void ZPRZAMXJGOZ(PersistedRoomData a, BFKITSIWYSM? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8189CF0", Offset = "0x81890F0", VA = "0x188189CF0")]
		private void ZPRZAMXJGOZ(SpawnableTemplateData a, BFKITSIWYSM? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8186960", Offset = "0x8185D60", VA = "0x188186960")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x818A300", Offset = "0x8189700", VA = "0x18818A300")]
		private void ZPRZAMXJGOZ(EQKDAXAXTVB? a, BFKITSIWYSM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x818ACE0", Offset = "0x818A0E0", VA = "0x18818ACE0")]
		private void ZPRZAMXJGOZ(OXOXLKQPEBH? a, BFKITSIWYSM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8189470", Offset = "0x8188870", VA = "0x188189470")]
		private void ZPRZAMXJGOZ(UCUZKFCXZAZ? a, BFKITSIWYSM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8188F20", Offset = "0x8188320", VA = "0x188188F20")]
		private static bool RYQJQPPHABY(UCUZKFCXZAZ a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8187080", Offset = "0x8186480", VA = "0x188187080")]
		private static bool FYEJQJPNLBQ(UCUZKFCXZAZ a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8188360", Offset = "0x8187760", VA = "0x188188360")]
		private static void GXCALNBFLXS(OXOXLKQPEBH? root, BFKITSIWYSM a, FKGNXVXVPVN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81872C0", Offset = "0x81866C0", VA = "0x1881872C0")]
		private static void GXCALNBFLXS(UCUZKFCXZAZ? customProperties, BFKITSIWYSM a, FKGNXVXVPVN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8187990", Offset = "0x8186D90", VA = "0x188187990")]
		private static void GXCALNBFLXS(EQKDAXAXTVB? root, BFKITSIWYSM a, FKGNXVXVPVN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8187D10", Offset = "0x8187110", VA = "0x188187D10")]
		private static void GXCALNBFLXS(CircuitsV2.Protobuf.CircuitNodeData? node, BFKITSIWYSM a, FKGNXVXVPVN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8189F80", Offset = "0x8189380", VA = "0x188189F80")]
		private void ZPRZAMXJGOZ(CircuitsV2.Protobuf.CircuitNodeData? a, BFKITSIWYSM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x81891A0", Offset = "0x81885A0", VA = "0x1881891A0")]
		private void WTVCVEYENSV(Guid? a, BFKITSIWYSM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x81898F0", Offset = "0x8188CF0", VA = "0x1881898F0")]
		private void ZPRZAMXJGOZ(PJGKUFHRWDW? a, BFKITSIWYSM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8187550", Offset = "0x8186950", VA = "0x188187550")]
		private static void GXCALNBFLXS(PJGKUFHRWDW? viewData, BFKITSIWYSM a, FKGNXVXVPVN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8188EB0", Offset = "0x81882B0", VA = "0x188188EB0")]
		private void PUPXWJJWQBO(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8186F00", Offset = "0x8186300", VA = "0x188186F00")]
		private void FSVLJIFOXQY(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8186FD0", Offset = "0x81863D0", VA = "0x188186FD0")]
		private void FSVLJIFOXQY(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8187020", Offset = "0x8186420", VA = "0x188187020")]
		private void FSVLJIFOXQY(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class AVCHZPMFZWP : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			private readonly IEnumerator<DictionaryEntry> AJMNSZFPBUQ;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x817E050", Offset = "0x817D450", VA = "0x18817E050", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x817E110", Offset = "0x817D510", VA = "0x18817E110", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x817E1C0", Offset = "0x817D5C0", VA = "0x18817E1C0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x817DF70", Offset = "0x817D370", VA = "0x18817DF70", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
			public AVCHZPMFZWP(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x817DED0", Offset = "0x817D2D0", VA = "0x18817DED0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x817DF20", Offset = "0x817D320", VA = "0x18817DF20", Slot = "9")]
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
			private sealed class MRPNQTHFBRX : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000591")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000592")]
				private DictionaryEntry FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				public RoomObjectCounts ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry HITZBKOWNSF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8185CD0", Offset = "0x81850D0", VA = "0x188185CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
				[DebuggerHidden]
				public MRPNQTHFBRX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8185D60", Offset = "0x8185160", VA = "0x188185D60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x8185D20", Offset = "0x8185120", VA = "0x188185D20", Slot = "8")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
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
			private ICollection NPWGSJZTVHP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x818B940", Offset = "0x818AD40", VA = "0x18818B940", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x818B820", Offset = "0x818AC20", VA = "0x18818B820", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x818B900", Offset = "0x818AD00", VA = "0x18818B900", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool BRIBLPLZDHS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x818B3C0", Offset = "0x818A7C0", VA = "0x18818B3C0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool NQPZWMPTTLZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x818BA10", Offset = "0x818AE10", VA = "0x18818BA10", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection ELTHTRZTLAT
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x818B460", Offset = "0x818A860", VA = "0x18818B460", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int HRXGKIMXYAU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x818B410", Offset = "0x818A810", VA = "0x18818B410", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool BLUVHMFBXHJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x818B500", Offset = "0x818A900", VA = "0x18818B500", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object QIEHQKNGTLM
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x818B760", Offset = "0x818AB60", VA = "0x18818B760", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x818B7B0", Offset = "0x818ABB0", VA = "0x18818B7B0")]
			[IteratorStateMachine(typeof(MRPNQTHFBRX))]
			private IEnumerator<DictionaryEntry> RJOCMFHBMTG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x818B6C0", Offset = "0x818AAC0", VA = "0x18818B6C0", Slot = "19")]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x818B5F0", Offset = "0x818A9F0", VA = "0x18818B5F0", Slot = "13")]
			private IDictionaryEnumerator JLIJPVAVPJP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x818B9C0", Offset = "0x818ADC0", VA = "0x18818B9C0", Slot = "9")]
			private void VNYELMAIZGY(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x818BA60", Offset = "0x818AE60", VA = "0x18818BA60", Slot = "10")]
			private void YVFNVXAVATA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x818B550", Offset = "0x818A950", VA = "0x18818B550", Slot = "8")]
			private bool CYVKFMIHZOM(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x818B5A0", Offset = "0x818A9A0", VA = "0x18818B5A0", Slot = "14")]
			private void IVXCKKTVAYJ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x818B4B0", Offset = "0x818A8B0", VA = "0x18818B4B0", Slot = "15")]
			private void BQEDVFPTKND(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class OZMYQSLKFYD : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000597")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000598")]
				private DictionaryEntry FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				public Invention ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry HITZBKOWNSF
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8186510", Offset = "0x8185910", VA = "0x188186510", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
				[DebuggerHidden]
				public OZMYQSLKFYD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x81865A0", Offset = "0x81859A0", VA = "0x1881865A0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8186560", Offset = "0x8185960", VA = "0x188186560", Slot = "8")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
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
			private ICollection NPWGSJZTVHP
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x81822C0", Offset = "0x81816C0", VA = "0x1881822C0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x8182170", Offset = "0x8181570", VA = "0x188182170", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8182280", Offset = "0x8181680", VA = "0x188182280", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool BRIBLPLZDHS
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x8181D30", Offset = "0x8181130", VA = "0x188181D30", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool NQPZWMPTTLZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x8182360", Offset = "0x8181760", VA = "0x188182360", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection ELTHTRZTLAT
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x8181DD0", Offset = "0x81811D0", VA = "0x188181DD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int HRXGKIMXYAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x8181D80", Offset = "0x8181180", VA = "0x188181D80", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool BLUVHMFBXHJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x8181E70", Offset = "0x8181270", VA = "0x188181E70", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object QIEHQKNGTLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x81820C0", Offset = "0x81814C0", VA = "0x1881820C0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28A86F0", Offset = "0x28A7AF0", VA = "0x1828A86F0")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8182110", Offset = "0x8181510", VA = "0x188182110")]
			[IteratorStateMachine(typeof(OZMYQSLKFYD))]
			private IEnumerator<DictionaryEntry> RJOCMFHBMTG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8182030", Offset = "0x8181430", VA = "0x188182030", Slot = "19")]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8181F60", Offset = "0x8181360", VA = "0x188181F60", Slot = "13")]
			private IDictionaryEnumerator JLIJPVAVPJP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8182310", Offset = "0x8181710", VA = "0x188182310", Slot = "9")]
			private void VNYELMAIZGY(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x81823B0", Offset = "0x81817B0", VA = "0x1881823B0", Slot = "10")]
			private void YVFNVXAVATA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8181EC0", Offset = "0x81812C0", VA = "0x188181EC0", Slot = "8")]
			private bool CYVKFMIHZOM(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8181F10", Offset = "0x8181310", VA = "0x188181F10", Slot = "14")]
			private void IVXCKKTVAYJ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8181E20", Offset = "0x8181220", VA = "0x188181E20", Slot = "15")]
			private void BQEDVFPTKND(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x818E6E0", Offset = "0x818DAE0", VA = "0x18818E6E0")]
		public static UgcRoomSaveStatsDetailed KZHFXKSGRJK(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x818E5C0", Offset = "0x818D9C0", VA = "0x18818E5C0")]
		[CompilerGenerated]
		internal static int CYXYUVFJAQG([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x818F090", Offset = "0x818E490", VA = "0x18818F090")]
		[CompilerGenerated]
		internal static void PIISHOXBNIK(int a, [In] EQKDAXAXTVB graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class BFKITSIWYSM
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public readonly Guid XUDXWLJMVIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public readonly IReadOnlyList<Guid> BAQFRYKGCDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly UnitySubAssetKind DKWEGDBOTPS;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x818F720", Offset = "0x818EB20", VA = "0x18818F720")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private readonly FKGNXVXVPVN GOUEZIYPVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private readonly Dictionary<Guid, UnitySubAsset> ZARLSEJNDAD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FKGNXVXVPVN WRKTUSPJVMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x817E270", Offset = "0x817D670", VA = "0x18817E270")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x817E470", Offset = "0x817D870", VA = "0x18817E470")]
		public bool HLANXEOESLD(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x817E560", Offset = "0x817D960", VA = "0x18817E560")]
		public BFKITSIWYSM()
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
