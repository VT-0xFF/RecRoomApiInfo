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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8263940", Offset = "0x8262140", VA = "0x188263940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ZVHJMQYSBXC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> QMMNNDJMXGK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> RPWXBGLMNYQ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> FMSGSGDUHLK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> EJVTLTTEJRH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string MYAPMRZCTDJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DFOXFJLNQMG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string UWZWNWVIPML;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82653B0", Offset = "0x8263BB0", VA = "0x1882653B0")]
	public static bool CABSEEJHKFU(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8265B30", Offset = "0x8264330", VA = "0x188265B30")]
	public static bool UTVSPTPDPLI(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82654B0", Offset = "0x8263CB0", VA = "0x1882654B0")]
	public static string RRGXWFKTMSV(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x8263880", Offset = "0x8262080", VA = "0x188263880", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CNXKNBPCJBX
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid KMXINHBQVRM;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid EMFWYOISPCX;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid BQRGYGXSIAW;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid SQOAAPWUKCY;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid LXUIAKUMNGI;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid LVNSKOWTPNR;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid EYEVSZONPTZ;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid EZGSBVTNGDN;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid NNGMUAWXGGY;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid FGWULSOTAVT;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid JUWNTMZNTPZ;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid TPRUCHUWRZZ;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid PYXCPDILVME;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid FCWIRCXKMZR;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid BHYIZNXSPBC;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid XZTKYIJOFMX;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid YNUDLFZHZBW;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid QSZLJQQRCXT;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid QESKDPNIWAZ;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid TROMATTFEDW;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid ZEZCCZRTNRH;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid HACDJDEBYWJ;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid PXLNPVNJFUG;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid UXCBVAFCQOK;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid MLMSYSZUQTW;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid NBNGLOWZFYC;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid LJHVGPWFZLW;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid CYNOQLQDXDY;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid AEDUFWBZVLF;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid JAXJKGHLABI;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid YTAYKENVNYD;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid VHNZEZOWMWP;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid ARAMENLVDPS;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid KICUYFTZMIW;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid AJYZPMRCETN;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid PDIFPFQYYBQ;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid DFUHVCDTLCR;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid TFOYVAIDAYD;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid CXJZXGOQTZZ;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid IMGOECLWXVD;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid RWFAVLGZMST;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid DDPJWLEWLBL;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid SOMDHBKMZBN;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid YBPTEZJGCVV;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid FZJDDBSINZX;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid BXZQBQWKTWY;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid WCXEFEUEVZX;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid RCADPCROYHU;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid SRZTJOEYQDY;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid LDCVAVUMMNQ;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid UWMLRAPHKWR;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid HYHYEPMYGCQ;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid FRMKMRYJYQB;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid MZUZKXYPGED;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid HZZRTLLAXUM;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid UMPTVWNWHVG;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid PRMBCQQRQSU;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid AETYXPLXWDD;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid XJRLFGGCKSR;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid YXAFYYEIICK;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid VHPDPWHLTEM;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid UEDPEHZSOHH;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid ZMQLRQRNVAM;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid UYELKZILPAD;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid XMNMMDHKEOT;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid SYALWQMNCXC;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid TECFGKDEAMD;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid WRZDUPGVUXF;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid DGMTZQXQFYI;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid GELZDJBRHVG;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid FZFPIKJLCOP;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid XCZGKBYCHAK;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid PMXDUYUEXBX;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid MNWPHNBEZJS;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid JSQRIXKETTV;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid UROGLTPMJVD;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid KRHCJPPJPTK;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid MKRWKRHAELQ;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid QCUMGIPXQFA;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid HOZESBDPCME;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid UXDFOQMBXBS;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid MLXIHSIGQFX;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid QYDJNZTBKEM;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid HLCOUHDKCGF;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid NNBAPKOWPUA;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid MWONEJQWZUF;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid UOGAPVMMHPN;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid YKTQYNYNIOJ;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid NGAQHFOIXBQ;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid KPWFJQPCQML;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid PJOZRPLCPVL;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid OJBYPYXZNTS;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid KZCOKHVNEXS;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid LXFKIPTTKXZ;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid TDBXSFDDRGN;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid MJQYUASZZUH;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid BFXVDDMQAWH;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid EWFBLPPZJTZ;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid QBHHLYYOBSS;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid MHZAGFLOCZT;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid SJHJPHJRHNX;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid ZDGLWPWJFMK;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid UBTHBVCYSLP;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid PVNTVOWJJPK;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid PENCGYFFGHX;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid PVYHQCKECMC;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid ZFLPZBDCEOH;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid JXPKEJVQSWD;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid SGVUPSOUXHW;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid FKCBKLLNAUL;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid UILWUPTXWVC;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid FKMPEYZHTRD;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid EGSUKUJFIXE;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid FJGZVKJXPBB;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid UGRQQEDPNDG;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid RSVRFDJQEZI;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid ZQYTXIUPXOP;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid ILVINUSFSWD;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid LUMHPQJYXBM;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid CYMZUANEOGB;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid FMCLTRMCMAR;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid UGOTARDFDPI;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid LARDYCGBPQN;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid EGRGYZFABRD;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid UIRMDYUPXPF;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid AZHYOUJLJJJ;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid PUNOBDHPJSD;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid VLGZWUIJAYP;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid QMGHSVSJTVN;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid QTLFWVOBPTK;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid AZKKJBQWRXR;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid OXVELJWAXVJ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid WZMWGLNUTXF;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid BIXNOOTKRIC;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid JDRPHIWXPKN;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid RJYJIVWVKVQ;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid OEGYMMOYHVO;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid XDJWIYVWNEH;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid XYKEEJWYEKF;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid PXNJGLALVMO;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid DJVYWCUJKUA;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid ZPTXGGJCGAR;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid BAFRJINDFLZ;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid KWNIMCPLYYS;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid PDTMKVGRHKI;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid LTRNVPKWBNW;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid AUDGIVDLYVY;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid KLZNIVCDVJZ;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid VCUCUFHEQDV;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid VCZJRMBBZPE;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid VDEQOSUZJAN;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid VDJXLZOWSLW;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid VDPEJGIUBXF;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid VDULGNCRLIO;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid VDZSDTWOUTX;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid MDUNVGOFCDD;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid DIJQFTTSHOV;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid EUCKETOLOUQ;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid QFTXVFIYVYQ;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid XFOPUKNBFBR;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid TULSZKEZKUG;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid EQZINLBVNWQ;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid QTRPZLSFOWM;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid ZTWPNVNNVKH;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid OBYXAOPOLIR;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid DWNKBCRBFCW;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid ZUJGOOKTRAV;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid PJHJEDHTRXG;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid FRRAGUVQSUE;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid BMCMAXCZYFH;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid ISFIOIJQKCY;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid FSGUYPDIVCF;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid FSBOBIJLLQW;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid FRBFPANYQMD;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid GUOJQIBYQCK;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid PFNHLLXTTED;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid PPQZGGMHOKC;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid GUJCTBIBGRB;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid YIBKUKDRSKU;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid QCLIYUOZNCB;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid EUIBGJFXMZX;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid XDGAEMZFVOM;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid BSGYHDBUJBU;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid NAVGIFZNNHK;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid SLBIFCEDSZQ;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid QTWKDKARTBW;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid ATVHASGJTMD;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid PJFDWHOOCFU;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid AKSLDHMGNXH;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ZMHFWNNEXFD;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid LJLZSVIZQLX;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid XDSICOMHBTL;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid XZPEMQDQJSU;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid OXDTNHOGYPW;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid FVJXKLNJXXV;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid TZDIRKOMTRZ;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid ZZDFVBOKNIK;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid TNZAGCOUWVP;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid SQKVITPTZHX;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid YFVXNUKCGSY;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid HYSFZJPHVAJ;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid WXXSYARYSCK;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid CBAQECSMNNC;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid SGBCSFHXRMB;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid MNHTRQSAVUW;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid ZLRLZBOEANP;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid WEKGFTLACND;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid DDHUSEKPRLV;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid ZBYUOXWXMXA;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid BIPIPKEIQDD;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid BFFHIJHCKQV;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid OQDUSHFVXUS;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid XPLCZSQSSGC;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid PUZYFTLVAGN;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid GKHBTZDMWDO;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid GUKUQKYHRUN;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid DMJIQUBTHES;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid PJSJOVHXPCE;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid BEROCOBTXMG;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid NDIMTOSRBLS;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid IYINNMKLMTH;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid YVSDKKZETXN;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid QPDMRKERXKU;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid LQKWHRSOBNZ;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid QRJTXHPWWOM;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid KNBZXBZCDTI;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid SGKEEZYGLSI;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid NKHXYYDWWNF;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid RZZDGINKORN;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid VUWTYEJKWNA;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid FSPSYGLYSRF;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid IPFDESKRHKG;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid APUXFUPILSV;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid HVVNZBHCMVZ;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid HLWPYLNARWR;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid WDRKTQXSBFV;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid NSZOAUIIBWD;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid XXQOTRYZFEP;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid NBJTDLAABJE;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid ETCQWUFYXWD;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid WRTFKMPTMKH;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid ZAXSTSPBHCE;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid RXEBTPGAFHH;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid KONUBFKSCXC;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid PWWFRCPXDJC;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid IMBRBLMYAWQ;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid CPBFOWVWSRF;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid CCNXEIUCIPC;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid SFVVRSQBIDX;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid JANANWPQGKV;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid EQTQHSHZMZI;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid GJYDTUMNNET;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid IETJLOFNUVD;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid IXZXPKXLOAP;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid QZEPJFGWMXR;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid MQNCIDBZMTD;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid PCWZMFGGAGF;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid RTCDBQNFHIO;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid UUWCVGVMALM;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid QNZHRFZPECH;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid QEAHGAMLUYC;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid VPSELYPGUWB;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid MMYDBQOSZKX;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid NVRGVENJNLK;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid ORFJGILRPSN;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid ZJBBFRTPFFX;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid EMKTAFQYMNX;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid DKYAAZDHLZL;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid MIWEWIJCZIP;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid TLUPNROEQTV;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid NNCALCOZGYZ;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid HUKXDKSCWAQ;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid JGDXEXUXMNU;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid UZYBQWVMHRD;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid QDTJJHHGUGC;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid HTBUKMKUDGX;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid BHBGUXXBWMN;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid BDKRSGHVRQC;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid XOWLLUFNDAR;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid PETOIPRQNHJ;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid FDUYSWHSBTV;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid WAVLFUDBVTI;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid AQNBNDRJXFS;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid ABAADOOCYUC;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid EFRVDBCVXMD;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid YCMDFJLYGTJ;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid DRHBXBLEFRL;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid SQZNMRIKVGH;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid FPEGWXHVHQI;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid GWSXJUKJPKU;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid JTZZXSFRCCY;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid YWMQQASXGIN;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid HGUZXVQKYUZ;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid UYHMAHUYPQW;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid MKJWHJPCDNC;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid NNJCGLJJABR;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid DCVQBHRMBUL;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid VXMBWOSDNUK;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid ROAKOZMKNHF;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid ANRCBUMHIDQ;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid SCGWCAJOGTB;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid EMHNDGMOABD;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid AKEUJHVMGLZ;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid ZNAKVTCNOKS;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid QHYWCJRNZZA;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid SAWHPCROUBG;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid FFVAKDJMYCB;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid QBDPLVWYEEM;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid AKJRVOTYURG;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid LHWHCIGCBHS;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid XZTGLIGBTQU;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid KAQVVMJIGPR;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid LQZYUVIIZNN;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid KAPGFMARHRJ;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid BXZNHVRBJAL;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid JIDJFSIQOGF;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid UGLZNXDVGJR;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid EWTPSNEMBAU;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid THYMJDUIVJW;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid FNBXLDAPULH;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid FUXSRXHWMFA;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid HJRZUKHHGPY;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid SDLFTTDREYW;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid HEICGQTHBSF;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid YEDJKPGYLOB;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid YPXYMNCRDOM;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid RUAWQHVAOZE;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid QKOYNCTTDSQ;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid HNMDBNCEZAO;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid CFDJGBULQZP;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid AZOCDSMDHRZ;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid HSARFTWIFIO;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid JGBYDXYVSBQ;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid WIJCASPSRFO;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid TPYZCBDGCWW;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid DWKSQBIGWOD;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid GCDLVZAMFCL;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid PZCLTUGYVXZ;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid DNFLREZQSAS;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid LJPDTWZJPZW;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid WQLSPQNSUUV;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid KGMTVWNDISZ;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid IGMBXMHYXMS;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid QJKLLPSPJAG;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid FIDQERQJJVN;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid BXPITNDYLFK;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid AHABAZCNLPW;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid PJEWHNTQVFN;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid MJNCPIYJSCY;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid MSFPYGOQKXU;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid ARHUOAMJBRP;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid UAWDEPDEBIY;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid DWVYSHATCQL;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid GLUUKYFQJYW;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid KMBFFYAQBEK;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid XKFWFKROESY;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid TLZEKSULMBI;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid UKARUEPBZIP;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid JGAJRZWMUSX;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid HXCPTBNKZWQ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid ZBTOXPXBFXR;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid SIPLSCAEGOZ;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid LDACHWBAHGF;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid QEKCABJGAXA;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid HKZJUPJAKUV;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid DYGAHNMQOSG;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid ARIZDOSYCGL;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid GFJKQANCEWS;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid IIPDLBSVABW;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid TETCIMWAYHX;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid YWPQTECRHDZ;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid DMIPCLPBSKV;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid WIJNCERDBWN;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid RGVOQTGNHPF;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid NHCBNKFSTQQ;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid ZNNBWXLVWQN;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid SYWRQPEPAYC;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid QXUIMNQFBUN;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid FRBGEBZNKOW;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid ZQFIBXJWHFR;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid QKDWUXZROZK;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid JNHJHCCLHMJ;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid QJPGBRPDRCO;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid MTMCQMQEJQZ;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid GPCORJWXHCM;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid AEGNPDFCNSC;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid CFDXIBGNEFR;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid ANQRNRBJYUM;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid QRDXEONKFDH;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid KUSBDDGGCYG;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid ABCZMNYKZHG;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid OLDDMXSENZK;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid ECWZNBLQMSG;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid WLCRTQGGQEL;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid VOIJQABZONH;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid JYDPASWBPUA;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid CTHLAHDNWXD;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid ZSWGRCQAEKE;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid DHXIHFGXHQS;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid RMQFNABXOZC;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid XRUQZXJAZOG;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid DZBXPEDXCND;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid GKXLDXYUPVI;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid AXANQCMRDXV;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid SWVFUFZVFMD;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid QBMWITVRSKU;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid TLXNGRGEAQA;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid HKWTBLOBNRX;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid FWDBYIQSKNZ;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid DYKKNNMOSYX;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid PNDTAQZRNAG;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid LDFGJDWCDJP;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid LBNZKPGXXKS;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid MIPOOPZVTCY;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid FNJIZURTWYJ;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid FVYYUJMENVV;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid OLMRMVCZNWP;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid EMLIBLMAJTS;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid EAVRNLQZFGB;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid DDVEGNIFASR;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid WYDVRTWIRGH;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid VNNKXEWBWLX;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid BMQQILRVCRT;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid HNSXIOTODRQ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid TTKWZWGAUJQ;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid BVDWJCFNXNF;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid KCUCGBCVXIN;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid BVJDGIZLGYO;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid BVOKDPTIQJX;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid BVTRAWNFZVG;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid BVYXYDHDJGP;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid BWEEVKBASRY;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid BWJLSQUYCDH;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid BTIMHTILQPC;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid BTNTFACJAAL;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid NXRABMQCUSN;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid YDGYMSNSIQD;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid YIVEETWPLPA;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid QGRRWDLEJZE;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid KJPCXMZIFHU;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid XDLEWLBDQBI;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid MVKQNVVCUUX;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid YUMVNKZKJET;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid WQGEZMOOCIG;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid TWMMQRDIBVC;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid RMNOQHWDNSB;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid QEGEVSQYNPD;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid FPXBKYTUTKR;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid TYYGVDSNZRE;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid EKGQEYSUKYR;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid USRSEXHZDVF;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid KMEKBGJBNLU;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid WGYUFSTJJVM;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid YPEBAGLSGMU;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid DNFFUQCPVES;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid MYPOOAZMNFF;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid TWLSPDDKPHK;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid TVVXXIVSMZJ;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid XAXZEZGACED;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid XSWVWEHGGEA;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid KZIVPOPADEL;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid YXWDNVKZJBE;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid GKAABTILQUA;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid ZTHRZYSXZXB;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid EOYRUHJWSVL;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid VIMFFIVBQNJ;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid FZIZIUVWHDN;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid BDCOKZZFVXT;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid PKTOKZGARIK;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid HYOLOVMKBTB;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid ARCDBCDYJZL;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid JAPHOHWBVKK;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid WRAITBRRXTZ;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid TBFYPEYQTMQ;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid ZXVPQDAXBCH;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid ASYJEZFRBKX;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid OISWFLFKRBK;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid ENZWJSAQMTV;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid MXUERJSLDKB;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid ZHFRJFOQYEN;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid SIDCBPTLAXH;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid JXCSMEMPWXK;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid IPFDLCYJULG;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid WFOYNHVQIEA;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid VRLNIYFNBKE;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid OJIDLWJGIEW;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid THTAUCBAAEK;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid CWIOBCWUNIP;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid UFXPTKDNEMQ;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid QRJASFMOBAM;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid NFUDUCYOUPF;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid TRPYYLSOXSJ;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid QKOOUYUNWTI;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid XBQDLWRFNGD;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid DHJZKIYOLBU;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid TLHJSHLCBIW;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid FUJZOHGJIIX;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid WDMJHTBMDLV;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid BFGXVXWTQLD;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid AYQOKHNFIFH;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid GTAIWHUKBSB;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid NFXQQPNCTGS;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid PJQAMJVPNTG;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid IKBVFZXIHSL;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid EPHFCMGGICM;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid JGXXSQFVPWP;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid MQWZCGGVIWU;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid GUPXCROGXPT;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid NHBQNAEIRSE;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid TMSHTVXCBHZ;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid MHWCPKYGWTM;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid YRWTQSPEZXE;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid DYVLXRFAHNL;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid XVSTUMHVOWP;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid HEUYBVIJLDP;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid PSHHCNBGBLY;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid OPXESWGOJIZ;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid NSWPNSTIZTQ;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid BLFNSNGLHZG;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid YLXZWIYICRV;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid PVUAWCSFAEV;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid PVOTYVYHQTM;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid WWRTAJQIUGQ;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid KENCNHEWOIW;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid TVJJCCATKLP;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid OSRRIQTJNHP;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid EZXHKRJKGTL;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid ZIGFCKNLSNS;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid SDBQNBTYLJB;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid YVGUXSQVPMY;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid BYRJNRVPFSR;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid NLORBGXFWMD;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid XYNXWEWGWJW;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid WZFZOKPBBYB;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid YXTPTGYSWYJ;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid BPXQEUXPAZX;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid PQNUCKTNFOQ;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid TLOTXRVVMAU;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid TJHZXYRAMRH;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid JAZFNMBSQGF;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid OBMTXAJTXTE;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid WNIWGHYRYPK;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid PRGOFWRYGLZ;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid TEHBXWFPIUJ;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid ALLHQFPGCXF;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid UGFDGQXXFHX;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid YKIJGXULSXF;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid IIWMOXPPHDC;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid IFQKVSGQMWI;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid VLIZBNQKUAV;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid JYLQRJLIONK;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid UAGJINTBQJA;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid FIRDNVHGJKZ;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid PXHALRMHOTK;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid SPUAJMIOCXB;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid SDSPFKXCTGN;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid BUYRKQZYCQG;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid XBSGTJFAMRS;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid BRMNTIUWDDA;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid IHMHYSSCMPC;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid JYUTAWLTCHS;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid NNMBVAFLKUI;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid DHOXTSTTCCF;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid GQPCCELJBHW;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid JWSYXMLMKKV;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid SYHIFGRSXZT;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid OXXMKRMPHPZ;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid JXYSTYIWEYT;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid PNALCVUGOFW;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid WWSKDORMMDX;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid JXSJOBJFAGE;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid UTLNKAQJOLU;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid UTGGMTWMFAL;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid UTAZPNCOVPC;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid ULCYLQYQPWB;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid FAGDPRMRKXH;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid EZQIXXEZIPG;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid SRZVIACYJMG;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid KWLYCQZMBCE;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid SCKGKCWYJMW;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid HTWDMIOVWEX;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid NLKSRZRZOJI;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid EFZOWTENCMA;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid UIFDHRADOGN;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid NLODBQKVAWF;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid XLLREHCBLXW;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid EUVYQZHGHCO;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid GMVRAFCJTOM;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid QAYMQTGHNYW;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid PAFMQEPYBRN;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid VCTDDAUXOZL;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid XVMHEKBFUQA;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid GFPMAFRYODE;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid TSEBNAZTSXN;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid JIFBVWQZFJE;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid CYBSKUWASRU;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid ZSLBWNJZRPC;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid MBGKFBOPFBO;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid WCGVNUKFPNV;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid MMEOQWEYYKS;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid BKKAIJCZDFX;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid RYQUINODTMP;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid JFJHDRHZCJT;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid HBOEKKECTMI;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid NDDPRIHQYBS;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid BBRKJKDNUZM;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid JVKKXNUQBKM;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid HXXOCJFAFKY;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid LDTKKGDWHFM;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid INTXMLIXVZE;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid AFFPMNSBKML;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid IWRPTIXGYBC;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid BCUBZVSBOLC;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid AMMLVURHMFL;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid TRNUUCMZBHQ;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid KWUIZBUAMZU;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid KRBPQQBBYOM;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid KUTLXLKFULS;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid KOEACVCEPMC;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid AEOSDYRNHAE;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid SFLCAKWIQHD;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid VXUDQFGUPNS;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid UZUSOADRDEE;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid OMHUOEDNMLC;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid JVQUDLRMYVT;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid EYDNLLQGFOD;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid CWRAUASIGWV;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid MDZAJLTWKZM;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid JAKVIMDEIDD;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid IOJEXMZTGSG;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid WFDZJQRSNIH;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid BPHNSEMMFTG;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid JZINPGDNFJK;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid CEFSPXAZNEO;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid IAKXQGXESYL;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid KDMEPQYCEMW;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid OUAYEWLUZEE;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid ALBJDNKPPBX;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid TIPNXOGLRXT;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid PPFAIKDWULW;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid DVXHLNJDOOR;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid TSBUTZVLWPE;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid ASOAVURANZP;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid ZAFZXAQHNAK;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid ILCOLTSDDLI;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid UIBTLSNEGKR;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid YTEKCVNZGHF;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid CUOSWSVKYDM;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid OYLKWRMRWRF;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid HYQUPQQAAFN;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid QMSTSQWDMHS;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid JKPEPWBJUQR;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid EURKOXYQFIE;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid ZDFMEXXZWZI;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid XZFHHMBJNZH;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid UGZSZQTWTQF;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid ZOQQCCVJORQ;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> WCRSWTPMNLM;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> FZWZQICEUFI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> JXEDLSZPPRH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8255AC0", Offset = "0x82542C0", VA = "0x188255AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> PTRTRMJPHHX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8255A70", Offset = "0x8254270", VA = "0x188255A70")]
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
	public static class VCVEFOYAPJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8265380", Offset = "0x8263B80", VA = "0x188265380")]
		public static bool CNVSYUQBAMY(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8264F70", Offset = "0x8263770", VA = "0x188264F70")]
		private static bool CNVSYUQBAMY(KYSBUCYODST a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface UDWPHSUNUTA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(YBEOCOLQGBU data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, IYMBRLUJJVA circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly LIKWTTGVGUH Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<PHWYRKJBQIP> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<PHWYRKJBQIP> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<VAEORNAZREW> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<CATHGSEFVUK>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XTSCFIDHKZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82639C0", Offset = "0x82621C0", VA = "0x1882639C0")]
		public R1CreateTemplateParams(LIKWTTGVGUH circuits, IEnumerable<PHWYRKJBQIP> rootData, IReadOnlyList<PHWYRKJBQIP> allPersistableData, Id32<VAEORNAZREW> sourceGraphId, IReadOnlyList<Id128<CATHGSEFVUK>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly LIKWTTGVGUH Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<PHWYRKJBQIP> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<VAEORNAZREW> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<CATHGSEFVUK>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8263A30", Offset = "0x8262230", VA = "0x188263A30")]
		public R2CreateTemplateParams(LIKWTTGVGUH circuits, Id32<VAEORNAZREW> sourceGraphId, IReadOnlyList<Id128<CATHGSEFVUK>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<PHWYRKJBQIP> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class TJRZKRIYLYW : FNWFGOGTAZO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid IQYQENRBXEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> KDTTZBLFULV;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E340", Offset = "0x4E1CB40", VA = "0x184E1E340")]
		private TJRZKRIYLYW(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8264A90", Offset = "0x8263290", VA = "0x188264A90")]
		public static TJRZKRIYLYW New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8264970", Offset = "0x8263170", VA = "0x188264970")]
		private static Dictionary<Guid, Guid> MKGHXILJLNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8264B20", Offset = "0x8263320", VA = "0x188264B20")]
		public static TJRZKRIYLYW OTIFUMNLBWX(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8264B30", Offset = "0x8263330", VA = "0x188264B30")]
		public static TJRZKRIYLYW WAJUDOHQECA(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8264A20", Offset = "0x8263220", VA = "0x188264A20")]
		public Dictionary<Guid, Guid> NIWGNJFFGZQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
		public Dictionary<Guid, Guid> TRKTCHEUKKQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82647E0", Offset = "0x8262FE0", VA = "0x1882647E0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8264560", Offset = "0x8262D60", VA = "0x188264560")]
		public void AJHHYPZORQJ(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8264E20", Offset = "0x8263620", VA = "0x188264E20")]
		public Guid ZIDUQEIMGTD([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82648D0", Offset = "0x82630D0", VA = "0x1882648D0")]
		public Guid KOEFOMHNJIY([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8264860", Offset = "0x8263060", VA = "0x188264860")]
		public bool DKDTXKHBVBD([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8264860", Offset = "0x8263060", VA = "0x188264860", Slot = "4")]
		private bool TOIXGNPVTAT([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface DLFIWITRBIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZEVXQHEIAPH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UCQJLAEHLBD(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface YISYLYERMLQ
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
	public abstract class RWTPIUIWSCM : DLFIWITRBIS
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KKCZFHJSMCB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string YFNFUBIVZOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public KKCZFHJSMCB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x82637C0", Offset = "0x8261FC0", VA = "0x1882637C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82636F0", Offset = "0x8261EF0", VA = "0x1882636F0", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8263730", Offset = "0x8261F30", VA = "0x188263730", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> LLBBLQJYWFT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8263730", Offset = "0x8261F30", VA = "0x188263730", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? GSNZOINYSXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? MMWYAXKNAJS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> MNYERSKSSMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8263AA0", Offset = "0x82622A0", VA = "0x188263AA0")]
			[IteratorStateMachine(typeof(KKCZFHJSMCB))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? YOIZDDMKAND
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool JQWFQCYHOFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool XYSHZMCPHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> BLMCDDEBGVY(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool SDOCDXGANXA(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8263BC0", Offset = "0x82623C0", VA = "0x188263BC0")]
		public void QHEQQUVSRTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDA6BD0", Offset = "0xDA53D0", VA = "0x180DA6BD0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8264230", Offset = "0x8262A30", VA = "0x188264230", Slot = "4")]
		public bool ZEVXQHEIAPH(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8263FF0", Offset = "0x82627F0", VA = "0x188263FF0", Slot = "5")]
		public bool UCQJLAEHLBD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8263B00", Offset = "0x8262300", VA = "0x188263B00")]
		private bool HAJSWGWFAYH(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82640C0", Offset = "0x82628C0", VA = "0x1882640C0")]
		protected List<Guid> XHPDKSGAYYS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected RWTPIUIWSCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class DXBNVRYJRKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class XGUNRQTJNJZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public LIKWTTGVGUH AQATHCAPBAV;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public XGUNRQTJNJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x827A770", Offset = "0x8278F70", VA = "0x18827A770")]
			internal Id32<EIHRYTCDBRP> YGQLZWSRGJJ((Id32<VAEORNAZREW> GraphId, Id32<CATHGSEFVUK> NodeId) i)
			{
				return default(Id32<EIHRYTCDBRP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int OHFWHNOQJLV = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<EIHRYTCDBRP>, LIBRWCLKZEJ> SORXCYEPWES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long WEMMEZKXFNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long GQAQEILSEKM;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<EIHRYTCDBRP, int?> ZWLUIFOCCAT;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long ZQURDAFQPRT;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long BKQWURTYBRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8255C40", Offset = "0x8254440", VA = "0x188255C40")]
		public static DXBNVRYJRKM FPBRAOQVLGB(LIKWTTGVGUH a, Id128<VAEORNAZREW> b, [Optional] DXBNVRYJRKM c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82562A0", Offset = "0x8254AA0", VA = "0x1882562A0")]
		public static (long, long) YRCMKZHULXD(LIKWTTGVGUH a, Id32<VAEORNAZREW> b, Id32<CATHGSEFVUK> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8256180", Offset = "0x8254980", VA = "0x188256180")]
		public static long HNTOUZTHZDI([In] ReadOnlySpan<Id32<EIHRYTCDBRP>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8255B10", Offset = "0x8254310", VA = "0x188255B10")]
		private static long BHBELVGRZXZ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8263670", Offset = "0x8261E70", VA = "0x188263670")]
		public DXBNVRYJRKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class LIBRWCLKZEJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long UHDSQPYTSJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC022A0", Offset = "0xC00AA0", VA = "0x180C022A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long EMEESGXPHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB5F2F0", Offset = "0xB5DAF0", VA = "0x180B5F2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D94E20", Offset = "0x7D93620", VA = "0x187D94E20")]
		public LIBRWCLKZEJ(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class YEDGANDZZQJ
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> TJWIFELWXYA;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class TTJGYLOHMQO
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DZVXSFLQKOF : IEnumerable<PHWYRKJBQIP>, IEnumerable, IEnumerator<PHWYRKJBQIP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private PHWYRKJBQIP VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData UCIAPJHVIGY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData BJJCOFOFJPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams QSPXKWPTUEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams EROOGEONXRL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int BWHCZIMPJCX;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private PHWYRKJBQIP YMLZNAWIASO
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public DZVXSFLQKOF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x826C6D0", Offset = "0x826AED0", VA = "0x18826C6D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x826C530", Offset = "0x826AD30", VA = "0x18826C530", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x826C570", Offset = "0x826AD70", VA = "0x18826C570", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PHWYRKJBQIP> TZCOLGWPENH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x826C570", Offset = "0x826AD70", VA = "0x18826C570", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82767D0", Offset = "0x8274FD0", VA = "0x1882767D0")]
		public static SpawnableTemplateData IUVZRJKQSMJ([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8276950", Offset = "0x8275150", VA = "0x188276950")]
		public static SpawnableTemplateData IUVZRJKQSMJ([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82763C0", Offset = "0x8274BC0", VA = "0x1882763C0")]
		private static HashSet<Id128<MSOPKGVLNVM>> GIRYLMGFWNV(IReadOnlyList<PHWYRKJBQIP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8275D60", Offset = "0x8274560", VA = "0x188275D60")]
		private static void EWJRCINSMFW(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8276E00", Offset = "0x8275600", VA = "0x188276E00")]
		public static Result<TJRZKRIYLYW, TryCloneTemplateError> QZDHRJNJNLN(SpawnableTemplateData a, SpawnTemplateParams b, TJRZKRIYLYW? srcRemapper, bool c)
		{
			return default(Result<TJRZKRIYLYW, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82783F0", Offset = "0x8276BF0", VA = "0x1882783F0")]
		[IteratorStateMachine(typeof(DZVXSFLQKOF))]
		private static IEnumerable<PHWYRKJBQIP> TDFTYSRTGBC(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8276760", Offset = "0x8274F60", VA = "0x188276760")]
		private static void IBRDBNGNGIL(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8275230", Offset = "0x8273A30", VA = "0x188275230")]
		private static bool AUOKOLDICMS(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8278500", Offset = "0x8276D00", VA = "0x188278500")]
		private static Dictionary<Guid, KYSBUCYODST> TQRDODIPFTA(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8276D70", Offset = "0x8275570", VA = "0x188276D70")]
		private static void QDUIRRLRQAA(bool a, PHWYRKJBQIP b, TJRZKRIYLYW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8276AE0", Offset = "0x82752E0", VA = "0x188276AE0")]
		private static void OFGDKFEXTQA(PHWYRKJBQIP a, Guid b, SpawnTransformData? c, Dictionary<Guid, KYSBUCYODST> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82758B0", Offset = "0x82740B0", VA = "0x1882758B0")]
		private static void DHMOLOALMZD(IEnumerable<PHWYRKJBQIP> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public LIKWTTGVGUH circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public YISYLYERMLQ roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public UDWPHSUNUTA circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<VAEORNAZREW> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public QCLYYAWWCMI globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<PHWYRKJBQIP> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public QJOCETTFAHE photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 NWPNRJQQBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8274880", Offset = "0x8273080", VA = "0x188274880")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS MDMKRDGFTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8274FA0", Offset = "0x82737A0", VA = "0x188274FA0")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x142C910", Offset = "0x142B110", VA = "0x18142C910")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8274FE0", Offset = "0x82737E0", VA = "0x188274FE0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8274CB0", Offset = "0x82734B0", VA = "0x188274CB0")]
		public static SpawnTransformData UBEXTAHJVVQ(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82750B0", Offset = "0x82738B0", VA = "0x1882750B0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82750D0", Offset = "0x82738D0", VA = "0x1882750D0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8274C20", Offset = "0x8273420", VA = "0x188274C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8274A10", Offset = "0x8273210", VA = "0x188274A10")]
		public SpawnTransformData RDPVBJDHIUM(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8274F30", Offset = "0x8273730", VA = "0x188274F30")]
		public static SpawnTransformData WHFXSMCBGGY(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8274980", Offset = "0x8273180", VA = "0x188274980")]
		public readonly CircuitsRigidTransform KVIVFPUUVYI()
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
		private readonly ZVSGMZZHZEF _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x16F0FC0", Offset = "0x16EF7C0", VA = "0x1816F0FC0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, ZVSGMZZHZEF innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8278A10", Offset = "0x8277210", VA = "0x188278A10")]
		public VFHGFKHTIMO UJHVEJXUVGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82787F0", Offset = "0x8276FF0", VA = "0x1882787F0")]
		public static Result<TJRZKRIYLYW, TryCloneTemplateError> New(XURXEZWYKED<None> innerError)
		{
			return default(Result<TJRZKRIYLYW, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82788A0", Offset = "0x82770A0", VA = "0x1882788A0")]
		public static Result<TJRZKRIYLYW, TryCloneTemplateError> New(VFHGFKHTIMO innerError)
		{
			return default(Result<TJRZKRIYLYW, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8278950", Offset = "0x8277150", VA = "0x188278950")]
		public static Result<TJRZKRIYLYW, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<TJRZKRIYLYW, TryCloneTemplateError>);
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
	public class DKJKYDWIMFV : IDisposable, NPOXPXKAVSO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> XGFMLGQITUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float JRCOQUEVLJM;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags MDXRTNQSSYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KEIKDMSJSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x826B830", Offset = "0x826A030", VA = "0x18826B830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QYJTDLZVTMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x826ADE0", Offset = "0x82695E0", VA = "0x18826ADE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> UZMJDPQUQPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int XUIJLFBBKVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x826AF50", Offset = "0x8269750", VA = "0x18826AF50", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IAKTDBDQCCH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x826ABF0", Offset = "0x82693F0", VA = "0x18826ABF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x826C4B0", Offset = "0x826ACB0", VA = "0x18826C4B0")]
		public DKJKYDWIMFV(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x826A660", Offset = "0x8268E60", VA = "0x18826A660", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x826A720", Offset = "0x8268F20", VA = "0x18826A720")]
		public Vector3 KMEQHVZRWVU(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8269B10", Offset = "0x8268310", VA = "0x188269B10", Slot = "6")]
		public Quaternion ANPXDOKVXFN(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x826B790", Offset = "0x8269F90", VA = "0x18826B790", Slot = "5")]
		public Vector3 QLRIXFEVBZA(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x826A5A0", Offset = "0x8268DA0", VA = "0x18826A5A0", Slot = "7")]
		public float CQEFXGFQKJN(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x826B8D0", Offset = "0x826A0D0", VA = "0x18826B8D0")]
		public void WPSCRNMSZOV(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x826A600", Offset = "0x8268E00", VA = "0x18826A600")]
		private bool DLUYKTMZCRT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x826ADF0", Offset = "0x82695F0", VA = "0x18826ADF0")]
		public void PEHTTPPOWSP(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x826B840", Offset = "0x826A040", VA = "0x18826B840")]
		public void TNQJAQWLBAS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x826A450", Offset = "0x8268C50", VA = "0x18826A450")]
		public void COVFURDLHJJ(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x826C1B0", Offset = "0x826A9B0", VA = "0x18826C1B0")]
		public void XPYJXGEDLBJ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x826C360", Offset = "0x826AB60", VA = "0x18826C360")]
		public void YHOOUGFKZCN(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x826A2F0", Offset = "0x8268AF0", VA = "0x18826A2F0")]
		public void CIFEUDHWZHG(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x826AF90", Offset = "0x8269790", VA = "0x18826AF90")]
		public static Quaternion PJTRMNOHXLM(Quaternion a, int b, float c, NPOXPXKAVSO d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8269C40", Offset = "0x8268440", VA = "0x188269C40")]
		public Bounds BGFAPVUPKGG(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x826A6C0", Offset = "0x8268EC0", VA = "0x18826A6C0", Slot = "10")]
		public virtual void FPWZXSINSQO(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x826AD30", Offset = "0x8269530", VA = "0x18826AD30")]
		public NativeList<CurvePointData> LYUQIYKKVRQ(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x8269A90", Offset = "0x8268290", VA = "0x188269A90")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8269830", Offset = "0x8268030", VA = "0x188269830")]
		public Quaternion PFWQRMVPVFB(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8269540", Offset = "0x8267D40", VA = "0x188269540")]
		public CurvePoint EBASNGFWWQL(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82698F0", Offset = "0x82680F0", VA = "0x1882698F0")]
		public WOJGRNVQUGG UGRDFCJSASH(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class WZNIFOGAAQQ : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8279E40", Offset = "0x8278640", VA = "0x188279E40", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x827A1A0", Offset = "0x82789A0", VA = "0x18827A1A0")]
		private void PNVMKPDKIGT(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8279EC0", Offset = "0x82786C0", VA = "0x188279EC0")]
		private void PNVMKPDKIGT(Dictionary<Guid, Guid> a, GMDTUSQYINS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8279F20", Offset = "0x8278720", VA = "0x188279F20")]
		private void PNVMKPDKIGT(Dictionary<Guid, Guid> a, TWZGNVATLCR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public WZNIFOGAAQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class NSDPOUWRMBL : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x826EE90", Offset = "0x826D690", VA = "0x18826EE90", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public NSDPOUWRMBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class FAPMYLCDJPM : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x826C7E0", Offset = "0x826AFE0", VA = "0x18826C7E0", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public FAPMYLCDJPM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class LHEFAKFFPHC : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x826ED30", Offset = "0x826D530", VA = "0x18826ED30", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public LHEFAKFFPHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class CMIJKGIUESC : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8269320", Offset = "0x8267B20", VA = "0x188269320", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public CMIJKGIUESC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class HMCYHNNLZEH : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x826DA50", Offset = "0x826C250", VA = "0x18826DA50", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public HMCYHNNLZEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class OSNJDJASBIZ : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x826F1D0", Offset = "0x826D9D0", VA = "0x18826F1D0", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public OSNJDJASBIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class YDYHUSCRTYO : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x827A840", Offset = "0x8279040", VA = "0x18827A840", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public YDYHUSCRTYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class JZTEYOMTRIA : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x826E6B0", Offset = "0x826CEB0", VA = "0x18826E6B0", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public JZTEYOMTRIA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class YHVAKBWDCPK : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x827AB40", Offset = "0x8279340", VA = "0x18827AB40", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public YHVAKBWDCPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class NWBIFVVRNNO : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x826EF40", Offset = "0x826D740", VA = "0x18826EF40", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public NWBIFVVRNNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class KTFQJVCTVMT : OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly CGNYHZMWLJH HEGLPUYKBYY;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x826E860", Offset = "0x826D060", VA = "0x18826E860", Slot = "4")]
		public void CQRPTTCARMS(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KTFQJVCTVMT()
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
		public QJOCETTFAHE photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface OHBCPKHJOZZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CQRPTTCARMS(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class HFELYWRYTIY
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly OHBCPKHJOZZ[] TMDDWUZMMLW;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x826CD10", Offset = "0x826B510", VA = "0x18826CD10")]
		public static void DBXKHUUCIIJ(PHWYRKJBQIP a, TJRZKRIYLYW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x826D200", Offset = "0x826BA00", VA = "0x18826D200")]
		public static void IMAWKMVJKUR(PHWYRKJBQIP? data, TJRZKRIYLYW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x826CF90", Offset = "0x826B790", VA = "0x18826CF90")]
		public static void FRHBIQBJBDN(PHWYRKJBQIP? data, TJRZKRIYLYW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x826C940", Offset = "0x826B140", VA = "0x18826C940")]
		public static void CNVSYUQBAMY(PersistableCloneParams a)
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
		public PHWYRKJBQIP viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x826F360", Offset = "0x826DB60", VA = "0x18826F360")]
		public Guid QYLRQMMNZBA(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface QJOCETTFAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> MIWSODYYIHP;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> KDRXTXWLSAD;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> JBZFBTCYYIL;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker WSYWEXAJCNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> YSTCFMGKVTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> PBBYSOXZGFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> IQAMCYSNNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> EQXTFGUWIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> CQPIBIEQJRV;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> GZEYFLIICBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> TVBYDDSBZMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> CFUKTQRCCIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> LGBPPLMZNBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8271FC0", Offset = "0x82707C0", VA = "0x188271FC0")]
		public static void NDGHGGAIRSD(SpawnableTemplateData a, JQWIWDCENVT b, TJRZKRIYLYW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8273390", Offset = "0x8271B90", VA = "0x188273390")]
		public static PersistedRoomDataReferences SKMXLAEHINV(PersistedRoomData a, JQWIWDCENVT? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8273980", Offset = "0x8272180", VA = "0x188273980")]
		public static PersistedRoomDataReferences ZZRQTHXTCYQ(SpawnableTemplateData a, JQWIWDCENVT? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82738C0", Offset = "0x82720C0", VA = "0x1882738C0")]
		public static PersistedRoomDataReferences YPGGLGDPSAO(HDPCUABSWTU a, VMIPOFFELEO b, JQWIWDCENVT? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8273410", Offset = "0x8271C10", VA = "0x188273410")]
		public static PersistedRoomDataReferences UNMDOVVVSBR(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8273F00", Offset = "0x8272700", VA = "0x188273F00")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8273D30", Offset = "0x8272530", VA = "0x188273D30")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x826F600", Offset = "0x826DE00", VA = "0x18826F600")]
		private void DWAKTSDXCUO(PersistedRoomData a, JQWIWDCENVT? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x826FCA0", Offset = "0x826E4A0", VA = "0x18826FCA0")]
		private void DWAKTSDXCUO(SpawnableTemplateData a, JQWIWDCENVT? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8270EF0", Offset = "0x826F6F0", VA = "0x188270EF0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8270510", Offset = "0x826ED10", VA = "0x188270510")]
		private void DWAKTSDXCUO(HDPCUABSWTU? a, JQWIWDCENVT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8270490", Offset = "0x826EC90", VA = "0x188270490")]
		private void DWAKTSDXCUO(VMIPOFFELEO? a, JQWIWDCENVT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x82702B0", Offset = "0x826EAB0", VA = "0x1882702B0")]
		private void DWAKTSDXCUO(RJNRGWCBEMO? a, JQWIWDCENVT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x826F400", Offset = "0x826DC00", VA = "0x18826F400")]
		private static bool DFOKJBGYPFP(RJNRGWCBEMO a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8273610", Offset = "0x8271E10", VA = "0x188273610")]
		private static bool VSWWHADMUQT(RJNRGWCBEMO a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8271820", Offset = "0x8270020", VA = "0x188271820")]
		private static void NDGHGGAIRSD(VMIPOFFELEO? root, JQWIWDCENVT a, TJRZKRIYLYW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8271D30", Offset = "0x8270530", VA = "0x188271D30")]
		private static void NDGHGGAIRSD(RJNRGWCBEMO? customProperties, JQWIWDCENVT a, TJRZKRIYLYW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8273000", Offset = "0x8271800", VA = "0x188273000")]
		private static void NDGHGGAIRSD(HDPCUABSWTU? root, JQWIWDCENVT a, TJRZKRIYLYW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x82729B0", Offset = "0x82711B0", VA = "0x1882729B0")]
		private static void NDGHGGAIRSD(CircuitsV2.Protobuf.CircuitNodeData? node, JQWIWDCENVT a, TJRZKRIYLYW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x826FF30", Offset = "0x826E730", VA = "0x18826FF30")]
		private void DWAKTSDXCUO(CircuitsV2.Protobuf.CircuitNodeData? a, JQWIWDCENVT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8271490", Offset = "0x826FC90", VA = "0x188271490")]
		private void FDXRNJJHRZA(Guid? a, JQWIWDCENVT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x826F8A0", Offset = "0x826E0A0", VA = "0x18826F8A0")]
		private void DWAKTSDXCUO(PHWYRKJBQIP? a, JQWIWDCENVT? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82718F0", Offset = "0x82700F0", VA = "0x1882718F0")]
		private static void NDGHGGAIRSD(PHWYRKJBQIP? viewData, JQWIWDCENVT a, TJRZKRIYLYW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8273850", Offset = "0x8272050", VA = "0x188273850")]
		private void WWRBDCQFZVR(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x82716F0", Offset = "0x826FEF0", VA = "0x1882716F0")]
		private void MXCGVEWGAOB(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82716A0", Offset = "0x826FEA0", VA = "0x1882716A0")]
		private void MXCGVEWGAOB(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82717C0", Offset = "0x826FFC0", VA = "0x1882717C0")]
		private void MXCGVEWGAOB(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class LFKKXUJTAIU : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> PRMTHGWFHQB;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x826EB00", Offset = "0x826D300", VA = "0x18826EB00", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x826EBD0", Offset = "0x826D3D0", VA = "0x18826EBD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x826EC80", Offset = "0x826D480", VA = "0x18826EC80", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x826EA20", Offset = "0x826D220", VA = "0x18826EA20", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
			public LFKKXUJTAIU(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x826E980", Offset = "0x826D180", VA = "0x18826E980", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x826E9D0", Offset = "0x826D1D0", VA = "0x18826E9D0", Slot = "9")]
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
			private sealed class OFMAWXIYLHU : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int RXIHLDXPFTB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry VMXRQLYYOUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry ILUMIDGKGNW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object BXTOFOKJAZT
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x826F180", Offset = "0x826D980", VA = "0x18826F180", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
				[DebuggerHidden]
				public OFMAWXIYLHU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
				[DebuggerHidden]
				private void QMTXDIUIKRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x826F080", Offset = "0x826D880", VA = "0x18826F080", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x826F040", Offset = "0x826D840", VA = "0x18826F040", Slot = "8")]
				[DebuggerHidden]
				private void FKDUCXAGPJJ()
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
			private ICollection CIPCAERVQJU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x8274120", Offset = "0x8272920", VA = "0x188274120", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x8274540", Offset = "0x8272D40", VA = "0x188274540", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x8274620", Offset = "0x8272E20", VA = "0x188274620", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool VTDLCCPIYYZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8274400", Offset = "0x8272C00", VA = "0x188274400", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool EWPEOARCFLO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x82744A0", Offset = "0x8272CA0", VA = "0x1882744A0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection TOJIULSSSBO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8274660", Offset = "0x8272E60", VA = "0x188274660", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int ILCOBFIXMCV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8274060", Offset = "0x8272860", VA = "0x188274060", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool JRTYGGBYMJO
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x8274290", Offset = "0x8272A90", VA = "0x188274290", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object WJVWQDESUON
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x8274700", Offset = "0x8272F00", VA = "0x188274700", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x82740B0", Offset = "0x82728B0", VA = "0x1882740B0")]
			[IteratorStateMachine(typeof(OFMAWXIYLHU))]
			private IEnumerator<DictionaryEntry> ALSWCNKRSYF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x82741A0", Offset = "0x82729A0", VA = "0x1882741A0", Slot = "19")]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x82742E0", Offset = "0x8272AE0", VA = "0x1882742E0", Slot = "13")]
			private IDictionaryEnumerator NOPQABRJCTC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x82744F0", Offset = "0x8272CF0", VA = "0x1882744F0", Slot = "9")]
			private void SRHMIHUDSWV(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8274240", Offset = "0x8272A40", VA = "0x188274240", Slot = "10")]
			private void LXERGNWPCZJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8274450", Offset = "0x8272C50", VA = "0x188274450", Slot = "8")]
			private bool QDJSTFGDALR(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x82746B0", Offset = "0x8272EB0", VA = "0x1882746B0", Slot = "14")]
			private void UDQBRUAGTZI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x82743B0", Offset = "0x8272BB0", VA = "0x1882743B0", Slot = "15")]
			private void ORHTZAOEVOS(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class BWDCIBUBZAO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int RXIHLDXPFTB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry VMXRQLYYOUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry ILUMIDGKGNW
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object BXTOFOKJAZT
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x82692D0", Offset = "0x8267AD0", VA = "0x1882692D0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
				[DebuggerHidden]
				public BWDCIBUBZAO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
				[DebuggerHidden]
				private void QMTXDIUIKRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x82691B0", Offset = "0x82679B0", VA = "0x1882691B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8269170", Offset = "0x8267970", VA = "0x188269170", Slot = "8")]
				[DebuggerHidden]
				private void FKDUCXAGPJJ()
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
			private ICollection CIPCAERVQJU
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x826DC40", Offset = "0x826C440", VA = "0x18826DC40", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x826E020", Offset = "0x826C820", VA = "0x18826E020", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x826E130", Offset = "0x826C930", VA = "0x18826E130", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool VTDLCCPIYYZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x826DEE0", Offset = "0x826C6E0", VA = "0x18826DEE0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool EWPEOARCFLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x826DF80", Offset = "0x826C780", VA = "0x18826DF80", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection TOJIULSSSBO
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x826E170", Offset = "0x826C970", VA = "0x18826E170", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int ILCOBFIXMCV
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x826DB90", Offset = "0x826C390", VA = "0x18826DB90", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool JRTYGGBYMJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x826DD70", Offset = "0x826C570", VA = "0x18826DD70", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object WJVWQDESUON
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x826E210", Offset = "0x826CA10", VA = "0x18826E210", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x28CA750", Offset = "0x28C8F50", VA = "0x1828CA750")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x826DBE0", Offset = "0x826C3E0", VA = "0x18826DBE0")]
			[IteratorStateMachine(typeof(BWDCIBUBZAO))]
			private IEnumerator<DictionaryEntry> ALSWCNKRSYF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x826DC90", Offset = "0x826C490", VA = "0x18826DC90", Slot = "19")]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x826DDC0", Offset = "0x826C5C0", VA = "0x18826DDC0", Slot = "13")]
			private IDictionaryEnumerator NOPQABRJCTC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x826DFD0", Offset = "0x826C7D0", VA = "0x18826DFD0", Slot = "9")]
			private void SRHMIHUDSWV(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x826DD20", Offset = "0x826C520", VA = "0x18826DD20", Slot = "10")]
			private void LXERGNWPCZJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x826DF30", Offset = "0x826C730", VA = "0x18826DF30", Slot = "8")]
			private bool QDJSTFGDALR(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x826E1C0", Offset = "0x826C9C0", VA = "0x18826E1C0", Slot = "14")]
			private void UDQBRUAGTZI(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x826DE90", Offset = "0x826C690", VA = "0x18826DE90", Slot = "15")]
			private void ORHTZAOEVOS(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8278C70", Offset = "0x8277470", VA = "0x188278C70")]
		public static UgcRoomSaveStatsDetailed SKMXLAEHINV(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8279CC0", Offset = "0x82784C0", VA = "0x188279CC0")]
		[CompilerGenerated]
		internal static int VWNDFXRPWNH([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8279620", Offset = "0x8277E20", VA = "0x188279620")]
		[CompilerGenerated]
		internal static void THZLNCTIYKV(int a, [In] HDPCUABSWTU graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class JQWIWDCENVT
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid URLMDMXQDYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> TVBYDDSBZMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind OHCPFBUROHL;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8279DE0", Offset = "0x82785E0", VA = "0x188279DE0")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly TJRZKRIYLYW SPOHRVKMESZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> KAEGOZFQBQS;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TJRZKRIYLYW ICNAGTNWGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x826E330", Offset = "0x826CB30", VA = "0x18826E330")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x826E530", Offset = "0x826CD30", VA = "0x18826E530")]
		public bool PUUDTZXYLGS(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x826E620", Offset = "0x826CE20", VA = "0x18826E620")]
		public JQWIWDCENVT()
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
