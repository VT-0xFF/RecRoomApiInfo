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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9923910", Offset = "0x9922310", VA = "0x189923910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FHLGVKUWZGV
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> HHUCNQVILND;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> XXWWKARXURX;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> AXKBXFOUUTJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> FHAYPDZMSQY;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JBFNIEJXWLE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string SWQHEHJCVZF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string QLWRUYUGZLY;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x991F4C0", Offset = "0x991DEC0", VA = "0x18991F4C0")]
	public static bool FRHSZMGXPOR(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x991FC90", Offset = "0x991E690", VA = "0x18991FC90")]
	public static bool XYNRZOAHXPF(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x991F5C0", Offset = "0x991DFC0", VA = "0x18991F5C0")]
	public static string XUDJFFGETMS(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x9923850", Offset = "0x9922250", VA = "0x189923850", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class REZDRHBLQVS
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid ZQMNZYSSMBD;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid XFLYIIGWUTW;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid JISJMUCGHUJ;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid DDRUYLKTUGT;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid XPEZDVXFZTZ;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid MRXNWLONSYS;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid WIBXQNOAYCO;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid ANBOROMAEEC;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid AANVPALLAQT;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid RLUCPCYGOOY;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid IAVYIPGHWXS;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid XJHRFYKCESU;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid VWOMPLGUJDX;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid VWMRRBTUMKA;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid NNLZPYBVOPZ;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid QPKEJSHCMPC;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid YAXVVPSRABV;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid ARIQUCNNTNC;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid VYHVMZBGFJI;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid FUYUKYOPCHF;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid DHAWYCYUKQY;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid FJFQOMQWWXA;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid OMOEMJKNNQL;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid GDGBTEAGSSR;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid JECGCJOHJNL;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid MMNKYNCXLDB;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid MHDPLSYOVRD;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid LVJQMHCQXTJ;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid YYBUYMFBNQC;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid EAKNJDMGNIL;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid CIXIBNQYRLS;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid TUZKHGGSAKU;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid EHBBAZSYWVD;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid QOUNGPBORNV;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid SGHASIZUIFA;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid IPYGCKOBNGF;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid IEGOEBTLTHK;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid XIFSRLCKGHA;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid ERAITRXNHQU;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid EKOTBIZVFTY;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid AKKXMOUDWPG;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid BQILPAEDIBG;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid LSPYKHHSTPM;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid PGLXRNPYELM;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid JOBAHVGEKHK;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid MDSNNBRMFIJ;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid HWMTGJTSKSS;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid FDURAERDYCX;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid QMNAQDZVZTJ;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid FAGWUVEAGYT;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid QHUUXAULXXE;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid EEBLBEIKROJ;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid SLRBQAPOZHK;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid BJJFPXZOMIA;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid AEJVAKNCGWX;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid OEZOFSTJNBZ;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid ZDPBHAYNAIB;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid KCUUBHNOLMW;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid VVYBGESFJTC;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid ODOMKVLPHXT;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid HALDAIOSXGT;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid QZWDCWIDLJQ;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid HMWVRARLCSH;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid RPUMYWGKDUY;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid JIIKYZDNCBG;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid LDWONOVGGNF;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid KGPSBMXOAOW;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid ENBIOZKULXM;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid BERYVJBFWAB;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid LHMRUANUWAJ;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid GRUGSGSVNOA;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid MBRMABGJRER;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid HLBQWEZJNEG;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid CTREBZCBEXX;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid YZMUQUFCRYQ;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid WEVXKKBYYSO;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid XXMLTIZCIDH;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid UXXHOTPBSRN;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid JICSSATHCMD;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid HVKXDJSLWXF;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid VNOOYCJNABF;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid QTAPTSIJWBE;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid IJWRELNXLHF;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid IYYNUPGYEHK;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid TRKMFPVHOOT;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid VMQYEECGCHS;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid HCQOGOIHSDO;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid NJPOIBLVHUW;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid DTFPOEGLZQZ;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid LTVRMMVFGJS;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid RNDEWTOYGSA;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid XDRQLJHHVGZ;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid LEOSKIXITMJ;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid NNVRYBZYUZK;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid KLJOUKHWASM;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid YIISQHLVAJK;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid QKHXLZZUDLY;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid LWGJYMIEQQM;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid PGPXCSWCJTL;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid YLMFHUXLWDS;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid MZJATAYHUVS;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid CNQCBWVQHFB;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid HBVVGACVJFC;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid YAVMNNSQZYD;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid KLKGCRFCSTS;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid YBGAIBGLSUV;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid PSHJYMECTAK;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid DYTWESTJQRK;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid CYKLIWBGAWB;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid EIOOGLESTTU;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid QZGMWSNUTDN;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid EIEALXQYAXC;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid LTUZGKFOQCN;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid EHTMRKDDIAK;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid HTAMJOCRVLZ;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid PMUETFODKSH;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid IPIACKNURVA;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid XBXBCOIWKOI;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid OLBAZSONMRZ;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid WGUMHRLILIK;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid KCLNCHRLLZY;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid CFDWYKOUBOL;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid WEOXOEWNBSA;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid WJSIFAJIGWA;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid YRBJKSZRHYY;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid IBZUVISMISQ;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid ZTCVHEYEMGG;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid OLVEUJPNHDE;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid NNNHMPTZVEC;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid ROIAAXRVZPN;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid ABPWQMJWMMI;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid LZXYBDESVLY;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid UORLBNUUPRE;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid OMJHTVZRHTH;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid NAQTHFBOGDA;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid CZYCFHWYEQJ;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid AWLBUTAEMDJ;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid MJCPSBKXWMQ;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid IPNWZLKVGPM;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid OBKXDYNVVPP;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid UXUEUCSLBWP;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid FNVOSFVPVHU;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid URIUQNLXLZK;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid PFFETIUIHOD;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid WSDXNKCMBDD;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid VXMBDGNNJNH;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid PDFOZTZXWOX;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid IVVZRGRRWJG;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid MQILVXIFAGQ;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid MQYGNRPXCOR;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid MQSZQKVZTDI;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid MPSREDAMXYP;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid MPNKGWGPONG;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid MQDEYQOHQVH;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid MPXYBJUKHJY;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid QYDYJMTMKTS;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid WJGJDQPWOHM;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid FDLIYXYSLET;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid ZFZCKPWXAMT;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid IACAUTJKDDQ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid YRASUAUDLCV;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid JAZYBOYNUWD;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid OQZUBJCTJAX;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid YIMZGNFLFFO;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid VBPOGQZSXXY;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid PCNAGZKBZDJ;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid LTRPPCOPRUK;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid PBBXISQHYDP;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid IZSGIGAQEHR;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid VKOSJICWUOY;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid CBQHTHDNXUJ;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid IZXNFMUNNTA;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid JACUCTOKXEJ;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid IYRXVYFDJCY;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid QMLYTBZWTPR;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid HTKYNGBMZUE;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid ZRVQROEGWIB;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid QMRFQITUDBA;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid JWILSGTLLID;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid KKTMHTTWVGO;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid YIDZIVBMFJC;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid ADRKNRSXHTT;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid GQBQLZSZRZX;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid JEZKLKYRJBZ;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid SAYPRPBIXQJ;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid SIDFMZOBZTN;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid LVDUWRQFIBW;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid KATITJBFQCH;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid LTLEJWXDBZM;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid FAKBQFAOCDW;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid LEOSWLNEMQO;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid IOXAYPESCHG;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid ZASACGBLXEZ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid SZNJTIMUOTF;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid LCXUHAXARKW;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid HHGJDMWYLIQ;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid RGPFEBHDIDF;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid OAWUYOTDCCQ;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid MFMCHJJAXQK;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid SUKEHGXGFJR;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid IBJYRBUSFGK;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid TVZUYIWYZAB;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid NCBDFAZQNSR;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid ZYIYSCXSHZG;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid FOFMENSLMMZ;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid DHGEJKXUGHU;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid SJACJWDOETG;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid COGBWIDRXKK;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid KAUHJBZUREV;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid ZDJRROFIGKQ;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid MJYUEQUISXO;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid PEIKXAVRRDV;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid ZURASPQZMVL;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid JOSNTLHPGXS;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid XXWCCAMNELH;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid UHOYCZXHRXO;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid KFWOMSJHNPP;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid OHJXQPFQRIF;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid CNBJBNWRJEP;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid FXVSWSWTLLV;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid FMFGEJGKVDG;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid OSXNTXAJWFA;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid USDPGVOTOUX;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid QSPBNZOGDOQ;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid ENLCMTSUKAZ;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid EFMKECTXRYT;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid MZLXZNENNUP;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid WFIFHSEECKG;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid RBGSXFMAWDU;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid WZKHKLNQVOF;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid GACRDGUUDSQ;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid CKQNAKHRJXJ;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid WLNORXNHKZG;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid AYTFSQRVTNW;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid JXODMWPUJSW;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid ABAXFDXGSKE;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid EFCNRAHEHOC;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid LEUVQVGLRSI;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid ZELPUKCCXZF;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid ZJLYUDWSEZQ;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid OUZXLBVIBCM;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid NDEOVQUJKFL;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid SVOTAWSUVAQ;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid ELDLHHCPFJV;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid QEBZOFRAZFH;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid AHUVJDRBHDR;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid SEQJMOFHMLM;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid KVVGDKQBHCH;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid XUXYJJYIRDQ;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid ZHHVDHELHPQ;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid LHEKAMPXEFF;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid VFDNNEPJCOO;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid GNSCBCMQPAO;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid WBNNWBWYYXI;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid EULQRCYRBHU;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid GEBYRAKWBAU;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid NCUCVHDUVUA;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid HDRJRKWQGLP;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid DZUHUKNBVIR;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid BMTKLFNMUAW;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid PEORWPSGRER;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid SOSTNSAUOWQ;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid FFGYSFZBJWM;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid DHHSBSQGRQN;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid RKRPDYVRGDC;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid LRWWUIOZIXW;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid JRCRNDUUEWA;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid NIDDIMPWQPY;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid XABGITARLKW;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid CPDIMDSJLIW;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid ITRMIVQZOJA;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid FQFEKIDXWCH;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid RLYNBUPYGBR;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid LRMSHLKZWZW;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid ZQSHDNQUQHB;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid FTYLMNCRQDW;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid KRZUTZCUMRW;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid ITTTQPXLNNZ;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid SWATGSZXALM;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid AZMDXVSYWBS;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid OVDYBEGWXRE;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid IGBQTQDZVXX;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid RRRPRMRCRRL;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid ZSXQAMWBBTX;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid MWGFYZCQGMU;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid NNQQMRPEMKG;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid EDLBSOLNZCU;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid ZRGFIRRNOGU;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid ZESDHOMZLOD;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid BUDSOXXSYEF;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid TBOPYQWLYZT;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid KGFROPEDJZY;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid PDHGOCQMPFI;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid DHQTHPSXNPN;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid QQSJKICXNPJ;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid SPNNMYRZGDQ;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid LLXZANPZYDK;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid XWHPJLVLIHZ;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid MJKFBICMCXS;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid RXQXKJINDIZ;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid UJMWZKEHKVY;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid KCZLPYRZPEG;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid GHJMHQAODVS;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid YBEXWIBFRHZ;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid EOGINYVNYBD;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid BGCYJPUSRCT;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid DODJOAMVGNQ;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid EIHVMFIZWHN;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid KBFOJIIUBBF;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid CCNOUDJDHBL;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid LPELOGBYMSB;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid RVZOQTUXHAW;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid QFDGLHSBBHI;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid WYKOPBOIGLO;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid ACSMOXIWUYC;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid JGUXBDNOMDA;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid LIHQAMIHNKA;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid TTDNXGKINAD;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid QIHQQCTSKCX;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid HABHYWBLFOI;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid EHUJIAASNKZ;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid YAJTAQMSHHJ;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid IIQPVNWCSIJ;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid XEKMSKFIJWA;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid UENSYPLCYSM;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid WNHWKEJTJJR;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid ADIVLDNAKYJ;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid TULJSLNRPGT;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid TBOUGHDCOLR;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid PQECEDSOFJC;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid BBKTMAADJTA;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid VNACZHTONVH;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid MTWNOZNYFFV;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid URIHDVORKTT;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid LYGIURUZZSZ;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid FZOGVFVKWVI;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid FGUNGVBRVGW;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid NEAQBAIVFJE;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid SRGISPZLEUB;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid WNUCMZYOBTX;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid WZKMZETTCJO;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid CBPRGBREODE;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid EJLGKDKOMAT;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid UMJFNQSIAET;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid JJKXKOCJLGO;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid OPNZQAJLJWD;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid GSINEHESZSX;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid ZYVZSSIHRSY;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid TWHGGGXWFGT;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid LEHICRZNEJX;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid GLIHSDWNQVA;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid FKNQGHVSQGP;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid QDZELUZWNKQ;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid XOMKRUGVIRP;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid XANZLCANXHB;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid SWJEBVPWIER;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid TGROAFRRDIH;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid OISFMVBUGGI;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid TUVPFNXCOOQ;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid AVNLHNYDOKB;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid HVLMZBGEHOI;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid FXQGCQEZYPE;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid QUKIOVXVZRU;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid FOHSQDQGBEH;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid ERWQHHDMMIC;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid UKRTFFTTCFN;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid NBBSDYMSPDA;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid FXLHBCHBEMD;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid ZZABUPKKJVP;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid UALEODXOHZY;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid JCWVWGDOXSG;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid UTJCQBCGGQO;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid XJNTNLKCHCW;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid IOFEOMGQHYW;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid XJIFNECSHKV;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid CWPCNMIUBJA;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid RJFZQFKYAEH;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid EPNPJWKODLK;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid FLSIWCAKPTR;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid TISOTQLQMUK;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid VMXQPUHJUEB;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid IGHFJLKOWUO;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid XNDXBUGXGNT;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid AGBPBNSJTTW;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid SSUSJWTVOEF;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid QVGKAVKYKIX;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid NQELPCFISIU;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid PMUTKAAFGDD;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid AEDUUJAYVJC;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid XWPBMHCXRMV;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid AFGLJTYOKWJ;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid VDHUCSQMYNX;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid LXUPKMQYFSH;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid DNKKZXQDCBU;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid WQPNSMWZUYQ;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid JARLPPESUZV;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid QFTYDXTYVLY;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid NVGMLFPJOZL;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid CGESILUJNFV;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid KCYWSIVWVYJ;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid GRWBZWYQBVB;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid KISEBPUYVJQ;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid OSBSZFOSMIN;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid EJCMHJOSIKC;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid XGZYUTTXBMC;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid ARZAQYLTONN;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid OUYCJXVPRLT;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid QTSNWEOZRGG;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid GWLKDIVNGLO;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid VVRTTOQSBXK;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid OAKUCGBYQNT;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid TFCUFPFWOOO;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid LXZZYYBCROR;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid RSCKPRGCCNL;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid KQEERZGFITI;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid UAYSXZGGROU;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid VHLXFBQCDYK;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid YUAGUDNMWCF;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid BWBTJUWVHNG;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid UJYKSHJTTYQ;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid OSMXTLDJOAO;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid ZQUNEWVYOXG;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid UHHOTXGCTNQ;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid OBVXFRKFPHB;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid AHGUXORKCWF;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid QVDLTVXOEFS;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid APWEBLLXFSM;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid QVTGLQFGGNT;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid QVNZOJLIXCK;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid QUNRCBPWBXR;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid QUIKEUVYSMI;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid QUYEWPDQUUJ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid QUSXZIJTLJA;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid QTSPNAOGQEH;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid QTNIPTUJGSY;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid GNUFNFARBJQ;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid XJNTYMEYWTI;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid PGVSSSPZVEL;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid BENLINWNINZ;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid YNYLSCXOEST;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid RMSHLTOYDLL;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid OBXUYITXAAE;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid TEDOVXYIAKU;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid REFFEXBUOTP;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid ZAGROFUAPCH;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid WNFCNAYSLLU;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid MUNCBOOQZRW;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid CIAPXQJNYNW;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid YZFWRAZVHBN;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid FOXNJCGGTPA;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid SKEMJUWTFWW;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid EURXXWJXUIJ;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid BPZBWTEUUKV;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid CPHQKDJMEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid OOTPIQSNCRR;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid NHSOTFKMDSQ;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid WEGZLOCNILF;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid WEWUDIKFKTG;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid AUJBNEZNRJQ;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid DNLTYJWAMFZ;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid NRMIXRFLFNQ;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid JAIAWEKUQRB;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid GIOIDPIPXJB;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid FEFJTVHLYVC;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid OUBNOYMPKEM;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid FJSKMVWDYEW;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid WMYGASHDASS;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid AGXEQZPISVI;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid HLQVBVWPBVF;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid RFXWVKFUUUC;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid QZJMXGTHBFY;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid EGENXRTXEWL;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid DTJQRKDKKQG;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid DRGVIWYBFED;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid CENQLPUSODM;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid WQUUDUFFXRM;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid HASYLQBXUTL;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid IWUMEADJNJU;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid PAPHYBRHIBA;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid ZWFDVNCDZLE;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid IPGETKKOUCE;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid NFMDGPQCWWL;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid YMQUCYPHJXR;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid MKRQLEJTRPB;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid HLNWZZOTUGT;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid AIMXQQMTOVF;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid CECSVCWEGQF;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid KVYVXCKFBFM;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid TBODMPKUYZX;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid PQCWBPOOVMH;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid BIVRJNGUXPY;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid UTJVAQCYUZC;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid LWUVKKTVMER;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid NVGJSAGUHXQ;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid ZUYXIMBPOHB;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid PGIUPDUABHD;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid JEUAPBFEMCY;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid OLTCPIUWHYA;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid OSVMDQLAJOA;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid BLXONGVPJMQ;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid KRSJFJGVIDA;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid RCPJDRNQRCZ;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid EALEPFYOTPZ;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid STVELCRKMMS;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid RFKWVLATVJP;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid MIABRNINPPY;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid HNHZMPMODXV;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid UMNCLLCNFMK;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid RJDFQEIEFFJ;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid MLIUSHDYYZW;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid ATQOKIBCWRH;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid MVLSTLREKQJ;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid SBWVMXKYNYS;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid OZTKBWYEPRO;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid ULMPNMREILM;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid CCEUYFCHKYH;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid DYMPOMUMDEG;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid IJEWNYRUURF;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid RQMHYLYJNWB;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid ISFQVAVLNYA;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid JRSJRMEIUGO;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid JRXQOSYGDRX;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid KQKPHJYSSWL;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid MOCVOEDEWVT;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid KMCGZQOXEJA;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid QPYEMLJVARG;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid BSXASQJLVGO;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid PWKVANLZQXF;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid VHKGTHYTPUO;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid TGHEBTYGPIT;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid HVLDNWQGDKC;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid GXQYERTACDC;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid QIQDBYBAZOJ;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid YXGUICABNTQ;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid VDHKIJEGYRS;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid VONIDCOCRHO;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid TXMOMWWTJOV;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid DIEZAIGAGYV;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid WYPFJLHMZEW;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid PTGYMDLMXLC;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid RLJMIYRADTN;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid ZQWWGTUBXPN;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid ZLXYSMWUBNC;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid KCWHVFQOGAW;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid OSSOSTDQDLQ;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid NXXHGOQYLHY;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid IMYFPMOOYUO;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid DLJBKVPQIFN;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid ZSUUZASOURZ;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid NCMAHJSHVSU;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid AIVSJOMXCQN;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid SMHGOXJMXJX;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid SBQJAMSBQCA;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid BRPNIJWSXZH;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid ERGNWUFVHXE;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid XHFYXPQXCAA;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid XTEBIPPCNXL;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid WKDRZLUMCPN;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid QHCVAXJDVJZ;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid QLMSYKIRNUT;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid MLFTLRWJZKD;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid KWXCGMMDLRT;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid MNYROFULLQO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid ZIICGHDGQKL;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid DQRKSZQZSKC;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid HPPXFDOUOLW;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid NGDMEPIOWLG;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid IDAIQSSDCSU;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid FJEBODZWVLH;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid LRNBXYQWQTW;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid MSLOHRPRTVJ;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid RHOGDQAGXJX;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid RGYLLVSOVBW;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid RHDSJCMMENF;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid ZXKFHEHGDLA;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid YEFVRDSXRJE;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid YEAOTWZAHXV;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid AULZKDMIDTN;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid DIBMVMENREH;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid RAQDMNLEVQP;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid GZEPXWSTYGU;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid KPTOKSMVROR;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid LIWIWNSFYNN;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid LJNFOOQPZUA;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid EJYTVHQPNDI;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid RQWCXOLQHDF;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid RXUWGBIMKXV;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid EZQDZEDISEL;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid LJHFYJRUPAF;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid KGLUSPXAFOU;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid FLPMCQBJOWI;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid IWCSOLANBIF;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid CJFWHCMMUXN;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid UGHSIUVADZE;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid NKDVSCYXEQL;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid ZGSCTXNAMYF;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid MTZPJVRSIPJ;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid RCDSWHXVUXD;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid CYPPKXSZWOS;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid BPZZOBRFRMN;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid YWXNDOFYXBK;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid EFGACOGMXZG;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid EGNLGPJSZEW;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid PZLQVONUVFV;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid TGGMSVUDJAZ;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid ACRMMCDQDIR;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid ALYJZUUPJSN;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid GAGEUQEPBRJ;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid OAIUWZSQQBZ;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid HNSSGTSGEBB;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid NMTXTLZVABO;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid SGSDKMTCMCN;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid VEUWVUCKGKD;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid FPLAHLFSBLO;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid CHLCLFKAJBR;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid OXALMVHIPDF;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid HKWSOYHFCLX;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid MFTTPPNAMDV;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid GFCREXYGTKN;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid HCJIBIGZOVH;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid QVVYJAPQSIA;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid WVBACQTQMVV;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid CVHRGQFESUV;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid YZRIRJCPPDV;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid TPOMZQTSSQU;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid MOHQXCVVPLU;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid SZWKBWGZWIY;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid AEUATQWXSBT;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid YATGLLRLIFA;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid UQCPZWDXFIV;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid HDBZRAEOIIK;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid OEEGKDTNTXD;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid MVTXDAVAAXP;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid CVXPHZXEXTJ;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid KPJNXNBFUDK;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid KFYPQQKHWPL;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid JFESWQCRLPL;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid HLBHISDFUYE;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid LPMUPZFTNNK;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid ZPQOMYNOKLZ;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid YBRKTUNSONQ;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid BZDCPCARWUL;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid KDCYOOTBIUC;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid WMPEMWSUNHV;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid KYQDAKHHDLX;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid ZEFPRGZEXCA;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid MAMEJXJFIXS;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid YJYDFDUEYYF;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid OGIUPHFNPUI;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid MPCZEKTBZLS;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid VMMZJRIFEMD;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid HCVSIJBSJEA;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid FHZIMBDKBCR;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid MBIEAGDDRPV;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid TLHNGHMVOSW;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid SRSMDCENZSA;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid TMTIFHWCWWF;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> IHJRKBKOGGJ;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> PKHNRQCXCYJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> CEVLQKDYUAU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9923A70", Offset = "0x9922470", VA = "0x189923A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> XMNSYOQIOWE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9923AD0", Offset = "0x99224D0", VA = "0x189923AD0")]
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
	public static class UIVZGKVUQFT
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9924950", Offset = "0x9923350", VA = "0x189924950")]
		public static bool ILIQLNNSEQH(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9924540", Offset = "0x9922F40", VA = "0x189924540")]
		private static bool ILIQLNNSEQH(OFXQUQYPCHS a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KCLLXBHGPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(KQESAYCEJFN data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, VIOGERKCLEH circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly BSRXIMSMGHS Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<FKWMEATAMCU> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<FKWMEATAMCU> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<JNHEPOTZQDV> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<CEDSPQRYDBL>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FKVZFEGVPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9923990", Offset = "0x9922390", VA = "0x189923990")]
		public R1CreateTemplateParams(BSRXIMSMGHS circuits, IEnumerable<FKWMEATAMCU> rootData, IReadOnlyList<FKWMEATAMCU> allPersistableData, Id32<JNHEPOTZQDV> sourceGraphId, IReadOnlyList<Id128<CEDSPQRYDBL>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly BSRXIMSMGHS Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<FKWMEATAMCU> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<JNHEPOTZQDV> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<CEDSPQRYDBL>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9923A00", Offset = "0x9922400", VA = "0x189923A00")]
		public R2CreateTemplateParams(BSRXIMSMGHS circuits, Id32<JNHEPOTZQDV> sourceGraphId, IReadOnlyList<Id128<CEDSPQRYDBL>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<FKWMEATAMCU> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class UCIKTIVYHTF : AMGJPKHICCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid EJQOCYBRYBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> XVTQEQRCFCA;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64A8220", Offset = "0x64A6C20", VA = "0x1864A8220")]
		private UCIKTIVYHTF(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99241B0", Offset = "0x9922BB0", VA = "0x1899241B0")]
		public static UCIKTIVYHTF New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9924060", Offset = "0x9922A60", VA = "0x189924060")]
		private static Dictionary<Guid, Guid> KDDXIUTKBHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9924530", Offset = "0x9922F30", VA = "0x189924530")]
		public static UCIKTIVYHTF WAFUZXCEOUO(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9924240", Offset = "0x9922C40", VA = "0x189924240")]
		public static UCIKTIVYHTF RYHRPQYLPHN(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9923EA0", Offset = "0x99228A0", VA = "0x189923EA0")]
		public Dictionary<Guid, Guid> ESUQEBJXFXJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
		public Dictionary<Guid, Guid> SQLRGEKJEOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9923DB0", Offset = "0x99227B0", VA = "0x189923DB0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9923B30", Offset = "0x9922530", VA = "0x189923B30")]
		public void ANCJUTFKSKQ(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9923F10", Offset = "0x9922910", VA = "0x189923F10")]
		public Guid GYJOIBJWQYW([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9924110", Offset = "0x9922B10", VA = "0x189924110")]
		public Guid MQHKQNQUMSP([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9923E30", Offset = "0x9922830", VA = "0x189923E30")]
		public bool UEMQDSTCLEU([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9923E30", Offset = "0x9922830", VA = "0x189923E30", Slot = "4")]
		private bool BMXTHVXWJII([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IGKTYYDTNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JAOXOYOGGSA(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YTMZJVNGDCI(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MJMDNRSOBEP
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
	public abstract class YIQHJHBKHWT : IGKTYYDTNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LWTHXHNKTMY : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string XWYKLKVTTLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public LWTHXHNKTMY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9923700", Offset = "0x9922100", VA = "0x189923700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x99236C0", Offset = "0x99220C0", VA = "0x1899236C0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x99237C0", Offset = "0x99221C0", VA = "0x1899237C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> TWESGBWWWOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99237C0", Offset = "0x99221C0", VA = "0x1899237C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? NQBVMDVSXTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? OHZQVFQPFER;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> KPEKGTWOTXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9924A40", Offset = "0x9923440", VA = "0x189924A40")]
			[IteratorStateMachine(typeof(LWTHXHNKTMY))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? GYRJDZODMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool BIHKSCNPKND
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool XTWPEVPOZQM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> CHLIXRLDSTJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool PZAARMUONYV(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9924ED0", Offset = "0x99238D0", VA = "0x189924ED0")]
		public void TOQKMUFBOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x104F8B0", Offset = "0x104E2B0", VA = "0x18104F8B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9924C20", Offset = "0x9923620", VA = "0x189924C20", Slot = "4")]
		public bool JAOXOYOGGSA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9925300", Offset = "0x9923D00", VA = "0x189925300", Slot = "5")]
		public bool YTMZJVNGDCI(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9924980", Offset = "0x9923380", VA = "0x189924980")]
		private bool BNYLNIMKZUE(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9924AA0", Offset = "0x99234A0", VA = "0x189924AA0")]
		protected List<Guid> FWDRYGQWFSB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected YIQHJHBKHWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class BODCRRGRYMX
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class DMJSJVVHHBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public BSRXIMSMGHS UMMEGMEGOWI;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DMJSJVVHHBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9926410", Offset = "0x9924E10", VA = "0x189926410")]
			internal Id32<MXFPFCGZOVW> ANGEVSMCJTI((Id32<JNHEPOTZQDV> GraphId, Id32<CEDSPQRYDBL> NodeId) i)
			{
				return default(Id32<MXFPFCGZOVW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int DAUWRTDARAA = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<MXFPFCGZOVW>, DZUWJCFSJSW> QMPZMAXEYQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long ZHUWXFOJSNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long JBIHVMPJGMX;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<MXFPFCGZOVW, int?> FJVJTXKVDCK;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long ZANWABZSHTG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long WBTCCZASNYW
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9911C50", Offset = "0x9910650", VA = "0x189911C50")]
		public static BODCRRGRYMX OIJCPNZZEGS(BSRXIMSMGHS a, Id128<JNHEPOTZQDV> b, [Optional] BODCRRGRYMX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99118B0", Offset = "0x99102B0", VA = "0x1899118B0")]
		public static (long, long) LIDEGGFVAGE(BSRXIMSMGHS a, Id32<JNHEPOTZQDV> b, Id32<CEDSPQRYDBL> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99121A0", Offset = "0x9910BA0", VA = "0x1899121A0")]
		public static long PWSFKWVAWSH([In] ReadOnlySpan<Id32<MXFPFCGZOVW>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99122D0", Offset = "0x9910CD0", VA = "0x1899122D0")]
		private static long RDTMEZHLCBK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x991F440", Offset = "0x991DE40", VA = "0x18991F440")]
		public BODCRRGRYMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class DZUWJCFSJSW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xEDA670", Offset = "0xED9070", VA = "0x180EDA670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long MRDEOLLTDUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E20", Offset = "0xDF6820", VA = "0x180DF7E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x942CF80", Offset = "0x942B980", VA = "0x18942CF80")]
		public DZUWJCFSJSW(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class PYLFKSDZKLI
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> PCROOWGDSVD;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RYOSFQOPFQL
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class YYJIMQCAGBA : IEnumerable<FKWMEATAMCU>, IEnumerable, IEnumerator<FKWMEATAMCU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private FKWMEATAMCU RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData BXFWXQVVIIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData ZNOWDEHMAYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams OHAPMXXVHUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams LAZZCWDCERO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int XBQBCVFOHLO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private FKWMEATAMCU MWQQCZWCGZB
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public YYJIMQCAGBA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9937070", Offset = "0x9935A70", VA = "0x189937070", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9937030", Offset = "0x9935A30", VA = "0x189937030", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9936ED0", Offset = "0x99358D0", VA = "0x189936ED0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FKWMEATAMCU> FDUGLFWXQKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9936ED0", Offset = "0x99358D0", VA = "0x189936ED0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x992E5F0", Offset = "0x992CFF0", VA = "0x18992E5F0")]
		public static SpawnableTemplateData AXYVVZKHCRS([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x992E780", Offset = "0x992D180", VA = "0x18992E780")]
		public static SpawnableTemplateData AXYVVZKHCRS([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9930BE0", Offset = "0x992F5E0", VA = "0x189930BE0")]
		private static HashSet<Id128<MVCTDZBQWKN>> NKWFFBPPSWW(IReadOnlyList<FKWMEATAMCU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x992DF60", Offset = "0x992C960", VA = "0x18992DF60")]
		private static void AUDMVAGBWJN(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x992F320", Offset = "0x992DD20", VA = "0x18992F320")]
		public static Result<UCIKTIVYHTF, TryCloneTemplateError> IEAKNTSFFZY(SpawnableTemplateData a, SpawnTemplateParams b, UCIKTIVYHTF? srcRemapper, bool c)
		{
			return default(Result<UCIKTIVYHTF, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99314A0", Offset = "0x992FEA0", VA = "0x1899314A0")]
		[IteratorStateMachine(typeof(YYJIMQCAGBA))]
		private static IEnumerable<FKWMEATAMCU> WMRIOCALXZF(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9931430", Offset = "0x992FE30", VA = "0x189931430")]
		private static void UTVREWFSPKM(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x992E9A0", Offset = "0x992D3A0", VA = "0x18992E9A0")]
		private static bool CRYRAAWNYYP(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x992F030", Offset = "0x992DA30", VA = "0x18992F030")]
		private static Dictionary<Guid, OFXQUQYPCHS> EMYZYVODTJB(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x992E910", Offset = "0x992D310", VA = "0x18992E910")]
		private static void BETYWSAFHIB(bool a, FKWMEATAMCU b, UCIKTIVYHTF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9930950", Offset = "0x992F350", VA = "0x189930950")]
		private static void IQPVSAFQEIN(FKWMEATAMCU a, Guid b, SpawnTransformData? c, Dictionary<Guid, OFXQUQYPCHS> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9930F80", Offset = "0x992F980", VA = "0x189930F80")]
		private static void UCLDGNYVRAQ(IEnumerable<FKWMEATAMCU> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public BSRXIMSMGHS circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public MJMDNRSOBEP roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public KCLLXBHGPEN circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<JNHEPOTZQDV> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public PHLWUXYOEFH globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<FKWMEATAMCU> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public LBEEPGYUVMH photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 FFCXZMVQUPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9932460", Offset = "0x9930E60", VA = "0x189932460")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS LCDCBYBTPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9932420", Offset = "0x9930E20", VA = "0x189932420")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16F80B0", Offset = "0x16F6AB0", VA = "0x1816F80B0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9932700", Offset = "0x9931100", VA = "0x189932700")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99321A0", Offset = "0x9930BA0", VA = "0x1899321A0")]
		public static SpawnTransformData EOSNFUWYNMP(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99327D0", Offset = "0x99311D0", VA = "0x1899327D0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99327F0", Offset = "0x99311F0", VA = "0x1899327F0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9932600", Offset = "0x9931000", VA = "0x189932600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9931F90", Offset = "0x9930990", VA = "0x189931F90")]
		public SpawnTransformData BUNHIJPAHBJ(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9932690", Offset = "0x9931090", VA = "0x189932690")]
		public static SpawnTransformData ZPXHQJJDVCF(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9932570", Offset = "0x9930F70", VA = "0x189932570")]
		public readonly CircuitsRigidTransform KHRWWOZGVBX()
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
		private readonly CBUCXYTAOGI _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19C1B20", Offset = "0x19C0520", VA = "0x1819C1B20")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, CBUCXYTAOGI innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9932950", Offset = "0x9931350", VA = "0x189932950")]
		public ZBHZKEAZREZ LIJJMSQBPBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9932B30", Offset = "0x9931530", VA = "0x189932B30")]
		public static Result<UCIKTIVYHTF, TryCloneTemplateError> New(QAKXONPXUCM<None> innerError)
		{
			return default(Result<UCIKTIVYHTF, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9932A80", Offset = "0x9931480", VA = "0x189932A80")]
		public static Result<UCIKTIVYHTF, TryCloneTemplateError> New(ZBHZKEAZREZ innerError)
		{
			return default(Result<UCIKTIVYHTF, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99329C0", Offset = "0x99313C0", VA = "0x1899329C0")]
		public static Result<UCIKTIVYHTF, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<UCIKTIVYHTF, TryCloneTemplateError>);
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
	public class XHWGOAHFWNK : IDisposable, PBVYWFPTNYN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> NGSPIXSNBXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float YJQODPEAYRR;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags HGDNOHWTBJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CLHUFSGPDTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9936D10", Offset = "0x9935710", VA = "0x189936D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool UWSSZMLEXOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9936BB0", Offset = "0x99355B0", VA = "0x189936BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> OHLKRKSFIZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int VXKNJVJQYEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9936CD0", Offset = "0x99356D0", VA = "0x189936CD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DQDVWTJMZNW
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9934BE0", Offset = "0x99335E0", VA = "0x189934BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9936D20", Offset = "0x9935720", VA = "0x189936D20")]
		public XHWGOAHFWNK(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99344D0", Offset = "0x9932ED0", VA = "0x1899344D0", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9935430", Offset = "0x9933E30", VA = "0x189935430")]
		public Vector3 OEOKEASKHEJ(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99361A0", Offset = "0x9934BA0", VA = "0x1899361A0", Slot = "6")]
		public Quaternion RGRYJVYFFBU(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9934E70", Offset = "0x9933870", VA = "0x189934E70", Slot = "5")]
		public Vector3 HQUUASBSDRJ(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9934F70", Offset = "0x9933970", VA = "0x189934F70", Slot = "7")]
		public float JLSCMEXKEMK(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99362D0", Offset = "0x9934CD0", VA = "0x1899362D0")]
		public void RRESHEVGPTC(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9934F10", Offset = "0x9933910", VA = "0x189934F10")]
		private bool IBBOCMBMHTC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9934370", Offset = "0x9932D70", VA = "0x189934370")]
		public void CASXIAMDTWI(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9936110", Offset = "0x9934B10", VA = "0x189936110")]
		public void QYCTAXWGSGT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9934FD0", Offset = "0x99339D0", VA = "0x189934FD0")]
		public void KPOLJXHROCC(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9935280", Offset = "0x9933C80", VA = "0x189935280")]
		public void MLTXOQZOSHQ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9934D20", Offset = "0x9933720", VA = "0x189934D20")]
		public void HPYAFHUAVIE(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9935120", Offset = "0x9933B20", VA = "0x189935120")]
		public void LVJTCUOPOQX(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9935900", Offset = "0x9934300", VA = "0x189935900")]
		public static Quaternion PIIQCQOSTJP(Quaternion a, int b, float c, PBVYWFPTNYN d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9934530", Offset = "0x9932F30", VA = "0x189934530")]
		public Bounds GUKYXEYZDIH(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9936C70", Offset = "0x9935670", VA = "0x189936C70", Slot = "10")]
		public virtual void UTBUSODWTHD(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9936BC0", Offset = "0x99355C0", VA = "0x189936BC0")]
		public NativeList<CurvePointData> SFBNSSLLCVJ(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x9926390", Offset = "0x9924D90", VA = "0x189926390")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99262D0", Offset = "0x9924CD0", VA = "0x1899262D0")]
		public Quaternion LCLDDFXQKPK(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9925E40", Offset = "0x9924840", VA = "0x189925E40")]
		public CurvePoint AGMDCNZKVBG(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9926130", Offset = "0x9924B30", VA = "0x189926130")]
		public BEYGGOWQRXZ GPZTPXAODSK(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class CYHLLBIAVJD : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9925510", Offset = "0x9923F10", VA = "0x189925510", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9925870", Offset = "0x9924270", VA = "0x189925870")]
		private void KQQSWLCXNZS(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9925590", Offset = "0x9923F90", VA = "0x189925590")]
		private void KQQSWLCXNZS(Dictionary<Guid, Guid> a, GUTRVRQLCHN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x99255F0", Offset = "0x9923FF0", VA = "0x1899255F0")]
		private void KQQSWLCXNZS(Dictionary<Guid, Guid> a, ZHSXGHEPAIQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CYHLLBIAVJD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class CWCPTWRRWTG : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9925460", Offset = "0x9923E60", VA = "0x189925460", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CWCPTWRRWTG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class RBZLRVETTIB : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x992DE00", Offset = "0x992C800", VA = "0x18992DE00", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public RBZLRVETTIB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class GEHFGXSFRWJ : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9926B10", Offset = "0x9925510", VA = "0x189926B10", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public GEHFGXSFRWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class VDTNVMYKMMP : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9934150", Offset = "0x9932B50", VA = "0x189934150", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public VDTNVMYKMMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class GMICUWPDKCM : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9926C70", Offset = "0x9925670", VA = "0x189926C70", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public GMICUWPDKCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class SHROXZFETOA : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9931DF0", Offset = "0x99307F0", VA = "0x189931DF0", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public SHROXZFETOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class NMXTCAFVYGD : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9928C00", Offset = "0x9927600", VA = "0x189928C00", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public NMXTCAFVYGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class GYXRNSVBDDT : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9926DB0", Offset = "0x99257B0", VA = "0x189926DB0", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public GYXRNSVBDDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class QHBMGULWFSR : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x992DC40", Offset = "0x992C640", VA = "0x18992DC40", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public QHBMGULWFSR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class FZIRVNVCPFR : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9926690", Offset = "0x9925090", VA = "0x189926690", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public FZIRVNVCPFR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class XQJXXXZGRLQ : NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly OSGWICMDBHS UWWTFWAIYSF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9936DA0", Offset = "0x99357A0", VA = "0x189936DA0", Slot = "4")]
		public void GHQJZHJQUTZ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public XQJXXXZGRLQ()
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
		public LBEEPGYUVMH photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface NQXWPQXSNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GHQJZHJQUTZ(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class IPYTTAEMXOD
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly NQXWPQXSNEG[] WXVIFWBBHRT;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9927860", Offset = "0x9926260", VA = "0x189927860")]
		public static void TCKFWGLVGNC(FKWMEATAMCU a, UCIKTIVYHTF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x99275D0", Offset = "0x9925FD0", VA = "0x1899275D0")]
		public static void QBZPAMREDWO(FKWMEATAMCU? data, UCIKTIVYHTF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9926F70", Offset = "0x9925970", VA = "0x189926F70")]
		public static void HOCIYHVVPHG(FKWMEATAMCU? data, UCIKTIVYHTF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x99271E0", Offset = "0x9925BE0", VA = "0x1899271E0")]
		public static void ILIQLNNSEQH(PersistableCloneParams a)
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
		public FKWMEATAMCU viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9928F00", Offset = "0x9927900", VA = "0x189928F00")]
		public Guid ZMSNQUOKPFD(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface LBEEPGYUVMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> RFHJYNBTNWW;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> FYLREEIKYFS;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> FGKDBRBWXKK;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker LXQHEBKPWGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> WTVHWSNHVWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> ZQXXILDZYFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> SCSBTBTYHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> QEYXZKMETSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> WPJJROBSMPC;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> XGMARCNHWYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> UMYDXOQYXHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> YALXJOJYUVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> YHJNEHFMJNS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x992C290", Offset = "0x992AC90", VA = "0x18992C290")]
		public static void JDDCCINQSMY(SpawnableTemplateData a, GAEIMQVREOQ b, UCIKTIVYHTF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x992CF40", Offset = "0x992B940", VA = "0x18992CF40")]
		public static PersistedRoomDataReferences OMSUFUMHBUY(PersistedRoomData a, GAEIMQVREOQ? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x992CC80", Offset = "0x992B680", VA = "0x18992CC80")]
		public static PersistedRoomDataReferences LDERONHMBNZ(SpawnableTemplateData a, GAEIMQVREOQ? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x992AAA0", Offset = "0x99294A0", VA = "0x18992AAA0")]
		public static PersistedRoomDataReferences CWVWXGKBMCD(OSFDDQIVFJF a, ACRABJZMZHL b, GAEIMQVREOQ? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x992A8A0", Offset = "0x99292A0", VA = "0x18992A8A0")]
		public static PersistedRoomDataReferences BSKMWPXYFKI(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x992DAE0", Offset = "0x992C4E0", VA = "0x18992DAE0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x992D910", Offset = "0x992C310", VA = "0x18992D910")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9929030", Offset = "0x9927A30", VA = "0x189929030")]
		private void BMTSAEWUPUV(PersistedRoomData a, GAEIMQVREOQ? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x992A290", Offset = "0x9928C90", VA = "0x18992A290")]
		private void BMTSAEWUPUV(SpawnableTemplateData a, GAEIMQVREOQ? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x992AB60", Offset = "0x9929560", VA = "0x18992AB60")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x99294B0", Offset = "0x9927EB0", VA = "0x1899294B0")]
		private void BMTSAEWUPUV(OSFDDQIVFJF? a, GAEIMQVREOQ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9928FB0", Offset = "0x99279B0", VA = "0x189928FB0")]
		private void BMTSAEWUPUV(ACRABJZMZHL? a, GAEIMQVREOQ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x99292D0", Offset = "0x9927CD0", VA = "0x1899292D0")]
		private void BMTSAEWUPUV(LKEMMCBPTPX? a, GAEIMQVREOQ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x992D140", Offset = "0x992BB40", VA = "0x18992D140")]
		private static bool TQFJQTTDXVQ(LKEMMCBPTPX a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x992CD00", Offset = "0x992B700", VA = "0x18992CD00")]
		private static bool MKWGUQJTUTU(LKEMMCBPTPX a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x992BE30", Offset = "0x992A830", VA = "0x18992BE30")]
		private static void JDDCCINQSMY(ACRABJZMZHL? root, GAEIMQVREOQ a, UCIKTIVYHTF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x992BBA0", Offset = "0x992A5A0", VA = "0x18992BBA0")]
		private static void JDDCCINQSMY(LKEMMCBPTPX? customProperties, GAEIMQVREOQ a, UCIKTIVYHTF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x992BF00", Offset = "0x992A900", VA = "0x18992BF00")]
		private static void JDDCCINQSMY(OSFDDQIVFJF? root, GAEIMQVREOQ a, UCIKTIVYHTF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x992B100", Offset = "0x9929B00", VA = "0x18992B100")]
		private static void JDDCCINQSMY(CircuitsV2.Protobuf.CircuitNodeData? node, GAEIMQVREOQ a, UCIKTIVYHTF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x992A520", Offset = "0x9928F20", VA = "0x18992A520")]
		private void BMTSAEWUPUV(CircuitsV2.Protobuf.CircuitNodeData? a, GAEIMQVREOQ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x992D340", Offset = "0x992BD40", VA = "0x18992D340")]
		private void WALRZQWYDWZ(Guid? a, GAEIMQVREOQ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9929E90", Offset = "0x9928890", VA = "0x189929E90")]
		private void BMTSAEWUPUV(FKWMEATAMCU? a, GAEIMQVREOQ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x992B750", Offset = "0x992A150", VA = "0x18992B750")]
		private static void JDDCCINQSMY(FKWMEATAMCU? viewData, GAEIMQVREOQ a, UCIKTIVYHTF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x992D550", Offset = "0x992BF50", VA = "0x18992D550")]
		private void WJGFUTUDASQ(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x992D020", Offset = "0x992BA20", VA = "0x18992D020")]
		private void PUKTVZXPQWM(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x992D0F0", Offset = "0x992BAF0", VA = "0x18992D0F0")]
		private void PUKTVZXPQWM(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x992CFC0", Offset = "0x992B9C0", VA = "0x18992CFC0")]
		private void PUKTVZXPQWM(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class MGEZSSBMPBF : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> PRQKTGRDCXC;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x99289D0", Offset = "0x99273D0", VA = "0x1899289D0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x9928AA0", Offset = "0x99274A0", VA = "0x189928AA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x9928B50", Offset = "0x9927550", VA = "0x189928B50", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x99288F0", Offset = "0x99272F0", VA = "0x1899288F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
			public MGEZSSBMPBF(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9928850", Offset = "0x9927250", VA = "0x189928850", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x99288A0", Offset = "0x99272A0", VA = "0x1899288A0", Slot = "9")]
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
			private sealed class UWFXAXRDFYF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry EGIPLDUVLYF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x9932F10", Offset = "0x9931910", VA = "0x189932F10", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
				[DebuggerHidden]
				public UWFXAXRDFYF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x9932E10", Offset = "0x9931810", VA = "0x189932E10", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x9932DD0", Offset = "0x99317D0", VA = "0x189932DD0", Slot = "8")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
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
			private ICollection QHHNJBAFPMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x9931BD0", Offset = "0x99305D0", VA = "0x189931BD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x99318F0", Offset = "0x99302F0", VA = "0x1899318F0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x99319D0", Offset = "0x99303D0", VA = "0x1899319D0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool ORXKTNEVOUI
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x9931A10", Offset = "0x9930410", VA = "0x189931A10", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool RFMBCZIDGDR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x99315B0", Offset = "0x992FFB0", VA = "0x1899315B0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection KUUFTVDCPRN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x9931650", Offset = "0x9930050", VA = "0x189931650", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int GCITWWGREOU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x9931740", Offset = "0x9930140", VA = "0x189931740", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool IAGFFFYOBPV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x9931C60", Offset = "0x9930660", VA = "0x189931C60", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object TFRIEUNMJUO
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x9931830", Offset = "0x9930230", VA = "0x189931830", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9931880", Offset = "0x9930280", VA = "0x189931880")]
			[IteratorStateMachine(typeof(UWFXAXRDFYF))]
			private IEnumerator<DictionaryEntry> QQIYWPOOEBG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9931A60", Offset = "0x9930460", VA = "0x189931A60", Slot = "19")]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9931B00", Offset = "0x9930500", VA = "0x189931B00", Slot = "13")]
			private IDictionaryEnumerator YKKNSNPXOBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x99317E0", Offset = "0x99301E0", VA = "0x1899317E0", Slot = "9")]
			private void PBNXZCKBWJS(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x99316F0", Offset = "0x99300F0", VA = "0x1899316F0", Slot = "10")]
			private void IPEVFOJSVKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9931600", Offset = "0x9930000", VA = "0x189931600", Slot = "8")]
			private bool CTMOHUESSQY(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9931790", Offset = "0x9930190", VA = "0x189931790", Slot = "14")]
			private void JAHJHBDWZTD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x99316A0", Offset = "0x99300A0", VA = "0x1899316A0", Slot = "15")]
			private void HOUJVRUWXEN(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class DZTYCYZEUOX : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention TICTAVAJHVE;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry EGIPLDUVLYF
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x9926640", Offset = "0x9925040", VA = "0x189926640", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
				[DebuggerHidden]
				public DZTYCYZEUOX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x9926520", Offset = "0x9924F20", VA = "0x189926520", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x99264E0", Offset = "0x9924EE0", VA = "0x1899264E0", Slot = "8")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
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
			private ICollection QHHNJBAFPMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x99286E0", Offset = "0x99270E0", VA = "0x1899286E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x99283E0", Offset = "0x9926DE0", VA = "0x1899283E0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x99284F0", Offset = "0x9926EF0", VA = "0x1899284F0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool ORXKTNEVOUI
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x9928530", Offset = "0x9926F30", VA = "0x189928530", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool RFMBCZIDGDR
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x99280B0", Offset = "0x9926AB0", VA = "0x1899280B0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection KUUFTVDCPRN
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x9928150", Offset = "0x9926B50", VA = "0x189928150", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int GCITWWGREOU
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x9928240", Offset = "0x9926C40", VA = "0x189928240", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool IAGFFFYOBPV
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x9928730", Offset = "0x9927130", VA = "0x189928730", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object TFRIEUNMJUO
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x9928330", Offset = "0x9926D30", VA = "0x189928330", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B9D430", Offset = "0x2B9BE30", VA = "0x182B9D430")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9928380", Offset = "0x9926D80", VA = "0x189928380")]
			[IteratorStateMachine(typeof(DZTYCYZEUOX))]
			private IEnumerator<DictionaryEntry> QQIYWPOOEBG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9928580", Offset = "0x9926F80", VA = "0x189928580", Slot = "19")]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9928610", Offset = "0x9927010", VA = "0x189928610", Slot = "13")]
			private IDictionaryEnumerator YKKNSNPXOBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x99282E0", Offset = "0x9926CE0", VA = "0x1899282E0", Slot = "9")]
			private void PBNXZCKBWJS(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x99281F0", Offset = "0x9926BF0", VA = "0x1899281F0", Slot = "10")]
			private void IPEVFOJSVKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9928100", Offset = "0x9926B00", VA = "0x189928100", Slot = "8")]
			private bool CTMOHUESSQY(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9928290", Offset = "0x9926C90", VA = "0x189928290", Slot = "14")]
			private void JAHJHBDWZTD(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x99281A0", Offset = "0x9926BA0", VA = "0x1899281A0", Slot = "15")]
			private void HOUJVRUWXEN(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9933720", Offset = "0x9932120", VA = "0x189933720")]
		public static UgcRoomSaveStatsDetailed OMSUFUMHBUY(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9932F60", Offset = "0x9931960", VA = "0x189932F60")]
		[CompilerGenerated]
		internal static int CJLDBCUMQQK([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9933080", Offset = "0x9931A80", VA = "0x189933080")]
		[CompilerGenerated]
		internal static void DLZADTAVYNQ(int a, [In] OSFDDQIVFJF graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class GAEIMQVREOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid ROSJEGTEYEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> UMYDXOQYXHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind QZFCEIPKDTG;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x99340F0", Offset = "0x9932AF0", VA = "0x1899340F0")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly UCIKTIVYHTF ACOKOWLWOYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> WPLTOHAFRGD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public UCIKTIVYHTF TNOOWEHAXAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9926790", Offset = "0x9925190", VA = "0x189926790")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9926990", Offset = "0x9925390", VA = "0x189926990")]
		public bool BYWGVCUECHP(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9926A80", Offset = "0x9925480", VA = "0x189926A80")]
		public GAEIMQVREOQ()
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
