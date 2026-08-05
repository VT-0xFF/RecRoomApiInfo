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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83DD290", Offset = "0x83DC090", VA = "0x1883DD290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MZELHCKLTKA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> JJULOTRFASC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> HOMZFVJIRNK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> HOCWHIMZVSA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> EURBPSHHMXD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string AREFFVJOZHF;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string HAXJRDZIZSC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string NANTWBGETHZ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83D9200", Offset = "0x83D8000", VA = "0x1883D9200")]
	public static bool KMHSQQMCNCK(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83D9170", Offset = "0x83D7F70", VA = "0x1883D9170")]
	public static bool DRHVEJMRSVE(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83D9300", Offset = "0x83D8100", VA = "0x1883D9300")]
	public static string QALZILWWPZP(Guid a)
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
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D8FF0", Offset = "0x83D7DF0", VA = "0x1883D8FF0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MWAVRULGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public static readonly Guid UXVMZDAKBFQ;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public static readonly Guid WNIKUCNSCIK;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public static readonly Guid MJCQHADKJAE;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public static readonly Guid QCGOKYEVJMQ;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static readonly Guid ZMJWXCXEGZV;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static readonly Guid ELKIMFUUBJR;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid JYRAIIULJCA;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid FHXUUKEIHPH;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid DHLRKAMAWMX;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid SCMXTMIHRVV;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid WRVNSOFDAFS;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid AAYOSPYYUTR;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid ZVTKHVSKJSE;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid LHQAEXXIQYP;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid VQLEVZFDGMI;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid SPMCDJZTKRT;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid ORDKDOCAVDT;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid ATVBLICHTEU;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid RDDUFQRMXMN;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid TKKKKEHAUTY;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid SBEVRRITKDU;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid PLIZCJELXCA;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid JINULOBMITU;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid VRRCBCPGXYY;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid GBXXBBTFIUG;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid NCROOVOXRNN;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid XHXBIUFAKQO;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid EELNYNKKTFN;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid HPTLVYPOZLV;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid FOCNMRBFMTS;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid FKHIULXUSPE;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid GRMUXJHOLIT;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid GSJTHOLFZFA;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid OEHPMUTDCKJ;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid WCNQHYDNOXZ;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid XOQKIXFKCKP;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid SGDKKQKOVDT;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid DCXXEUTOIPV;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid HEZFSACAGMN;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid VNDKCMTGVNR;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid QCZUGWQPVKD;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid CZBUCEIVYXL;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid VAOJELQYEVK;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid KWDQVYJIYPL;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid FWMFNZQBWLI;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid XLZORNNLIHM;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid XFIDYSULZYC;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid ERQZEFOYBJD;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid BVBZMRJYGVW;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid SNSGRSPKLBP;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid GSLSAVOKEDJ;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid LWYIXOMQEDO;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid NERQXPFQSMA;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid LVJZBKQITRG;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid PAIFXKZJTEB;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid DPIYEGKSFOB;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid TKPJNUEMDUG;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid CJCCDTGNPMI;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid LYPJRJQBJYN;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid IQPQXRVEVEA;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid ALMAOZWJFOL;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid MPHYPLNBLTJ;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid KFFGPSFVSQE;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid KCOILTUEHWP;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid FVUTEFYVPFB;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid FAAATAADZOY;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid VPDXGYSRCWE;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid JTFLVXSZYIP;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid ZGTFILIFNFE;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid OAHFCROZENP;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid LGLKVOHNDEA;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid HRYEAFKMTPR;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid OAGIWVBJDYZ;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid KUHWDIWQHNK;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid MSENCUUYHDI;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid FHOOZBUFYJM;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid YHREVNWFZTW;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid MROBMMGJYPG;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid XTVWZIBQHRH;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid OLHHSGWNDOQ;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid FZNNJUPZHMJ;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid YTZGFMXTICE;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid XWZXZAROJEB;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid KCPCQCIXAVB;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid JQHDQAUFKZX;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid BBPZNGQDLBU;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid AEPRJVPKDOX;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid IQEJAGQQIRL;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid QMYVCPWBJYU;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid HKWFQYODIHW;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid LXWFZDOETYX;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid QKWVUPKCUAR;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid GYNPMKAAHUT;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid MTRKZKKWIFV;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid IPZICBHVRSP;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid QXABRZVEWRU;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid YTLEAGINAFP;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid RRAPXKFWXUN;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid IMFAXVARHHA;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid TWYUWUBBTCR;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid RFJVVIPKYJG;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid IGKCFOBVZDP;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid RFUJPWDFRFY;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid AKOVGPCBMPR;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid LHLMEDOSHPZ;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid BGDDKZWYBJW;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid DIKAIFIOCXR;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid TICFLGZTMAY;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid DIUOCSWIVUJ;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid UIJVJBHAACK;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid DJFBXGKDORB;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid CKVWBQQLQMU;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid CDBPBQNJQCK;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid BZLHOPVDJLJ;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid KYYCYPMCJIP;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid VELLYOFNFKW;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid VKVWGUIELIN;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid SDJHMOXSHUR;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid ZMZDLNIPDAC;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid BYHWMQDAUSR;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid SIXWPWFEFYR;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid GAIPMHQXPWL;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid WOFBZJITBHB;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid FAWKBYLQCNV;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid SGWTJGLZDOT;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid PAPKNGMZJXN;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid GHOBWJNIWNG;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid XNLATVFTXPN;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid SPAEKIADBIP;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid NQWTWTBACOX;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid VLDLREORTTY;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid LEYODASJPEN;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid PZXWUKEUWPI;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid LZMIIZUNMNG;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid EIPFIDRVFHV;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid IGHYQAJWYWJ;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid QTGLBBHAMPA;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid GUCSUQXZBCU;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid TTAWRWSUNLD;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid ESFZATSUKWL;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid MVOWIFAGGLQ;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid HBJUYVNNHNG;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid KDQFOKIVQZG;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid GYTUKVDQDUC;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid CSBEBIORCRZ;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid CJSZXIXPFTV;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid CJYGUPRMPFE;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid CKDNRWLJYQN;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid CISRLBCCKPC;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid CIXYIHVZUAL;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid CJDFFOPXDLU;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid CJIMCVJUMXD;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid CXWEBBBTDYR;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid RKSIKQTQORX;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid CGMYIVUGJMY;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid AZCLAXPNAII;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid FCYXEUSRZHR;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid WIDGCCNHVQW;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid COZEMZMXJUQ;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid COLJWHTAQBC;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid RCSFVOPOLTZ;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid FJPNETKUNSB;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid GRBBGCVJQLU;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid RCIKCVXCXUR;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid OWTQDLVHLUY;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid OJYSHMQYDMM;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid SCJVGCMATNP;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid VFXXECEXIIQ;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid OKOMZGYQFUN;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid OKJGCAESWJE;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid OKZATUMKYRF;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid BANAUGIPMYS;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid URHLMIPNLNF;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid UXNOYFTIKOW;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid BAHTWZOSDNJ;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid GFQDCVQFNEA;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid BECUCHPEPAZ;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid BGNVLFOBZJH;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid TUCAZNCBZAM;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid INHTDTLNHLU;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid WSJDASTYMGM;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid MDSSVMVOOIG;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid NWYWUPDLHUE;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid XGKNHGSCFYX;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid BEYYPLFAOHM;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid DVYJJETRZEZ;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid OKDGJLLXTBX;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid CEEXGMYZDKB;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid PPLDTGMCJLX;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid ZKZHNJMCWXK;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid GRYMFBDDGQI;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid UQIQRKQWFHJ;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid SVORNTGEMZB;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid UKAYSLOMBDQ;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid NQEZHEJTIXH;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid ZTMCKIAEPJH;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ZWYMRWMURLW;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid VSVWNWYAMHL;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid LEEYNUCVDKC;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid XKVJFTUURSU;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid EGDWXFMJRQN;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid BUWJKZDWNYS;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid KEQJRANPXKN;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid HMYXAJFAQQZ;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid TJILLSTAQUL;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid LDLDFOJNMNY;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid QXKTOXPYKWJ;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid UTYSNAWODRD;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid NZVAJSJBBDQ;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid ACYXBVWASYK;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid FFVZLHFCUOJ;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid YUNKFJAIAVW;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid PNMAHWBNRAJ;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid GWKOBNKALTI;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid GWQGOVLJMJO;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid YPARELDUJSG;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid XGYWHXRFWVO;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid LCOHCPVTETD;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid OWTTSVKEVVV;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid SEFXCUVWVMM;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid ZHOMQIBSXAX;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid TFMPAXUSDAQ;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid BTGBOCSRLZI;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid KVLGEKRFRDC;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid FBXZFVILCNZ;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid TFHNFNBVSKP;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid OECSKUNFVKG;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid JFNMBPQEOOH;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid HIGWXBPRNTI;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid ASQWTMGBGGV;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid INIJDUWSEDZ;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid XATEACVTGWJ;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid TULYDMWAOQH;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid OYHZNNZRPHF;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid RMPCAHJMLHV;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid ASELLQSCFSO;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid TKWECZNVQJV;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid XKIOLPBCALR;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid XELLVAOGKAQ;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid CGQPNWVOBYR;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid DOKUPNQSNNG;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid OUVTEFWJIXG;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid QWOBPBWTDTO;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid WNOEATGQOFB;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid CFZKKGZQDZO;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid OVKGXGQOPXP;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid CACYKQHVEOJ;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid PPYXCUSMLLU;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid UTLCYTBAEMT;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid SBREVXIWQNH;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid SSOJJAXTVPR;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid WZMKTTRBZPB;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid SBGHAWPQNQJ;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid JHZABUZGCAF;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid PBPQBYDQQSK;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid XJWPKZPNSLY;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid WRZKLRNGBLV;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid LNXHNAAKDOG;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid VTDVACQQYWV;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid NRBKUCWXVXZ;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid SMWLSDIMVRK;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid TLHCKNLGNDP;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid NLUGMDPHVUV;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid GJJAYWIKHTL;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid MXPGWSKMLQZ;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid AZLSZXKMJRJ;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid FGBGIOLTUIH;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid TMODSGCJTMZ;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid FJHZGHBAYMM;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid SDJFDGZFJHQ;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid UCOPGJTRSSB;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid QXYWVBWKYQS;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid ECFDBZHYXFF;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid IIWSCIDIIOV;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid QNFBDUCQQFY;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid TDWDMFKADRT;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid MGCSJEMDLSP;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid IFWYTSULKHF;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid QJWNPOOOEDQ;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid NCUGGIHUHMA;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid QUNFMFKRXMS;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid JILFABUYODN;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid TNESHXNTSEL;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid USBYGQPKNGV;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid PYXMMYPUVZV;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid SWHMODOAODK;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid ZUMATGVZSTS;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid DLORYGOOTPG;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid CUKZECCPQZP;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid MBWZIIQBYDX;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid DERPANVASSK;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid NHFTQCWQEGA;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid EMPZFLRHPEL;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid IFHMLHVCSAT;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid EPZBTPXLSWO;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid THOAGBFEATN;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid SOONNEAFJAG;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid NOUWHKDMLTB;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid VDSEABPXTYN;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid QRTBGOMNUQT;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid HGJHMKRXPGK;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid HJKNXKGIHKC;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid NODWKCVTCTW;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid LQTEOPPFZTH;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid GYFTBMJAHCQ;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid HQJANHLQFJW;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid YLAZQJXUVPG;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid HZDOGHYFZTK;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid PCLSMWQXUIT;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid EUWNWLVVDJJ;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid KOTGQZXYPWL;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid GPQFQHNGHXZ;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid CAHCZZBLWZL;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid VRKSVRTCVZR;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid MPFYOTPQJEY;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid EAYQESTXBMU;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid NGHJURDLYYZ;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid WQUDGJJUJPU;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid ICZKYFRBLUW;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid FRPXXLPGXWK;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid IFQPBWMXOMZ;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid USIARZWZLVP;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid SRWWAUYRIVG;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid CVOPDIFCMDE;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid EQLZUIVUBWU;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid ODBPGCBJGHI;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid GPXCSYJKWNT;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid SECUXTBHSPV;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid XBMAVTHCBXE;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid WTNZXEKRINM;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid WTHWJZTGWRO;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid LSRZVFXKIZE;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid ODWIZVYAVYP;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid PZMWYHZNMHR;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid IZXRDEEGDTV;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid TLIMIMQEASK;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid VDKFLYECNSY;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid YYSNGZSGWMR;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid GDECHPYEBHX;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid PGDYHHAEXUG;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid ULFAOQYPLYS;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid DRKWHAZPLHV;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid SQZDRMUTASI;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid FNXJRHCOUWQ;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid JNKPBCQYYYP;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid OQPUPSGMJZK;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid SVBXQISNSDY;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid MUIFSGYLVPP;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid SACZFXQVVME;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid IZZXFTRKDKP;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid AHMJFQGOHIC;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid RFYWCNACCKG;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid CVBJMTJFXHW;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid NWDIDMVAQQO;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid UUEKCCKCCNV;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid OUCCJPHZRFJ;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid DXOXOKQEFKE;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid DATXZWWMGLR;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid GNXDVMPRJJL;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid IQTGOXOOBIV;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid VLOMGOPBDCC;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid SVBUCEFXHHX;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid NRTAQCIEQZU;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid BIUIMOSXAHE;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid IARNVZKFUXO;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid ZEAGRNZVWSF;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid UYRVDUJDHFB;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid IBTINKIAMDX;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid ZTGLJBNZTXR;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid CGCBDMDOPJC;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid NXVYKICDBTH;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid XKBKRNOZTJI;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid QFVFGOOKMSB;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid AVQWMFHBJGG;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid VCZUKCJXELV;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid WASOSDBMZIU;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid CZJRFGELKGF;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid EKXBDQOUTSS;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid UWRXRPBCPQV;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid BPFOUBOUDEE;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid MHOSSGEUPSW;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid ICFXVGVFZVB;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid GCEOJBFZFSA;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid WXURSGNLCND;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid EFTMLLSKUVY;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid CGMBMHTIZDS;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid ECFVPWDIKTO;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid HMGMDJXUKSC;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid RIWZZAKJLID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid KYNSMLWNMTH;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid LVSOJNXVQBO;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid LPDWSQTIMIF;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid JNNBYSFGCCA;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid KAXDHGCNGQK;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid RHXSPMIMVZK;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid URBOESRGGCO;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid HEONOURHXBT;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid PKCLANLJIDM;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid FNWKGVMJVSL;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid TRMDGVZAMUL;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid VLJCAFXFAWY;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid DXVWXGIOSSQ;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid TIOGQURCZKB;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid WUJABVOXLAL;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid PKSNFFNHSFZ;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid BKZMXNMENWW;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid CLHSCJMKWRX;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid NGIWAPWKVVI;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid PSKSTIUMIIU;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid MMHXVTIRIXH;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid XOBJJCOMLOX;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid GLVFYTVGNZF;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid BSQPAPXLOHK;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid SFGAINHPUEN;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid DGHUOVTBATL;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid AQMVKCMPUOH;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid MHVMJAZTOTL;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid NGQLDGTZRQF;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid TDXUNIBDFBM;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid KZLHDWCKQGC;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid PGMRGYVBMTB;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid NMYLRZIFHUZ;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid PGRYEFOYWEK;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid PGXFBMIWFPT;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid PFMIUQZOROI;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid PFRPRXTMAZR;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid PFWWPENJKLA;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid PGCDMLHGTWJ;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid PERHFPXZFUY;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid PEWOCWRWPGH;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid TEFEAVVXGIV;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid NJHNUVJDSXZ;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid FLGRNZVZMPI;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid JAFKSFSBECK;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid VXDCWDGMMBA;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid DLUDMTSPITA;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid PAGEGXYGCLV;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid LJJWADXLKZR;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid ZWMRDGUYERQ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid MBBATKOXUZC;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid JXAUDATDRCV;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid GWIHYTOVYLD;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid MKQLCMEMSHP;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid CQGMYXILJTE;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid SPEFKJACNTT;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid KPTAYJEWTDF;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid WYRRTICGYBY;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid NJMYEKHZMWK;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid EOAEKDICSHS;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid JBMGWIXNXRM;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid DGLHDGZJVOP;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid YTSJLEGBMMI;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid YUSRXMBOHRB;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid BVKTCFTBVIT;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid VBECTEOTJPS;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid VOPOHQOBVPB;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid OIGZTCBHQGC;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid EFESCCMFEHW;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid XWREUSYOLNJ;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid TUZFBPWKDSB;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid SUKKXZTVAJV;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid SBDTMUYDQGP;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid WSHWYGAJVNL;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid QKCZKYZXJJE;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid LFUTIITSBTV;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid GDTYTBVNOSR;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid DKXUJZQJGDQ;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid YOSEEBFDAFF;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid DCWDWVIIVSI;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid QTUTEPGTQJB;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid ASCMJIQDFUH;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid WMOFKGWPBII;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid CWDOKYZKWDB;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid WIUXWRVAXAB;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid UAVIBGBKEAJ;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid DHTYPSNIYIB;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid QZGHBRPNCDG;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid XQDFDWODTHG;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid OBDZDTUMBZW;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid NULPWLNCWIQ;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid ZJRGEQGEMOW;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid AKKMQTNKSXY;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid MRAJPCIJYYP;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid MMIDXOYNQBS;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid UMMQUGNVJYI;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid GJHMMBXZAOT;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid OXSNZFRYNWF;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid XAVXBOTSEHM;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid LXHIRNIMAKL;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid RYUETSCOEPQ;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid ZQVKXOZVGVB;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid OZRABLOBJBV;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid HWEWPXKZIFT;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid AJGDXCPWFKN;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid QSKMAKVGQYF;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid TOJEZLBBWXA;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid UOWTTMUVLAQ;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid MLSRLJZKANF;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid MFDEGAVBYZS;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid QFLCHYWXHMP;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid LPSNSEDMVLC;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid UKLCGKUEPDP;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid EJWZYGBEGIY;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid DDAEYSBNTMD;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid LAYEWUGCKTY;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid LHBGEKPSXBE;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid TYZGJCHFEIN;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid HEJYNNYEHZJ;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid SPECSTPBUKZ;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid FQSHUXAYQJE;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid GOIJUECGGKF;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid EROSFRUHFCW;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid GNIZRKDOMWU;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid JGIICEYZMYD;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid QKKKXNIEJKB;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid QKFEAGOGZYS;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid QVVHRVZYEIY;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid AKOFMMEHVJU;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid IVRGESOIYWN;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid BSXPKTCVJIJ;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid VINMSVVMUGR;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid URPQACKEUNW;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid NRAOBMUFXOT;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid YXPTAPKZZBC;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid ZQKCZZHJOXX;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid JCBFWBHUBMD;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid QRXCRWFQGNS;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid JCJQYVYMSWF;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid OJDDVNWAZIJ;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid BVUIUPXMYOB;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid PMXBKXERCSQ;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid CKLLQSUYIZG;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid ZNSDCBMBESJ;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid PNGUYAFZVJX;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid RZKADVQMBDA;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid LCOZZJZKLBG;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid RKRSAZMUOUL;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid WHGQLVKBFNP;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid LLJOXLBVPUD;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid VSYAEFGBHOF;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid BNUKYNMBEEP;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid HSWBPBFTFAE;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid KUBWOTBITCI;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid INZGPJFPSON;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid DNRWBGSZYQY;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid FGSASCRKZPM;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid OMKSSFVYDBX;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid KDVMXRUHUUE;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid WWHIEIYSQZJ;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid JAPWMNDNBDH;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid FISCLECHOFY;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid LWDKOSVMCVW;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid HAKEOQORLLU;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid NFKYIUYPTDS;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid EKDRRDDRKOI;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid KOWLFOAEIIM;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid JLVOHACFLYZ;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid SVQQOBVNJAI;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid DOMHTKFTWFT;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid BLVAIBQVZXT;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid KWPHQTCBCTJ;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid UTOWMWRLMPB;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid LUOCTDYSQWY;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid QNVDIHQWHSB;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid NOKADTALFYI;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid JROYQIEPYCS;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid JRJRTBKSORJ;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid JREKVUQVFGA;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid GAXBFDFMESB;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid RJHYLAESFGR;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid RISDTFXACYQ;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid IITKLUNGQLY;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid BGMRXESQNHO;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid LOEMNSZMBWG;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid BOQCBVBPLAH;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid MXJLUNLYGWC;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid ZOEAZBRWLBW;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid INDVAVYYUBD;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid FNFHNGMPWSR;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid PTMVNYQSEQE;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid KDJQNMVEETU;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid SSKULSOMGRW;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid CFTFCKKVJVA;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid CBLICIOVXLV;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid GKJBMNMNRRL;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid YZMENGIXSEE;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid RPOMXPEEBVY;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid YMKDVGPZPRZ;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid FAOEIKRAVDM;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid UCNLNNHLWNA;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid CCZQHUSKWEA;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid YGFDCSQKOSM;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid FYPMYNBHDWH;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid IZJIKIBOGVA;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid ZCDRTKJJAZP;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid XRSLUBBPPUL;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid JJYSWRPGADT;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid WLMTTYKYTLW;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid FCEQRZUASZO;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid LMASVMKKZRU;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid DDSKINOGSZW;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid PRTQSTFRLZO;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid WMEURMLNSCK;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid MFLYKPDHXKO;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid VIMINRDUSXR;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid ZMMNSVRJFWA;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid LNXIZUVODJW;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid VGETGHPYZZT;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid SWAZGKTWOXQ;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid KBGAQAPXHDA;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid HHLUKGBSAEE;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid MVNMXGZGWHO;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid UPEBKBUQTYW;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid IJNOWLHUPUY;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid BQIZCAVMQFT;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid KNSHPYGZDTS;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid JHUEMCKFKWI;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid DBQKMIOEAAE;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid KNPEYXPFMRH;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid AXFMLEHOTUD;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid URIIXIXPPIZ;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid LNHLLVIHTEW;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid IGNACRLFVIZ;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid HULJRSHUTYC;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid XFNHLCFSSOT;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid VNCBYDMOXHS;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid FBAPMQQJNGE;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid FAZFKREOCXA;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid HCGERVWDKHB;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid IDGJDENVBBE;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid BYYGPBVOCJS;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid CVSZDFEDHTX;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid OQFFGCSSMVX;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid DFWONQPCQZG;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid GSCVRTCCGIR;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid VYCPCNMOHAC;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid ATRGTBSGLCB;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid LVENUYAEBUG;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid WIHBJPEJSAW;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid BEJAREKEEDL;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid MZZHDHVUYQH;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid NOWVDQYXDJI;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid MEJUAYZSDSL;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid XEKTIUIFONS;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid YGVGHHLHHGF;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid TWFPGRIBRZW;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid VPPRKVJWUXI;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid NFMPVYGITCB;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid QXIVLHQWUOJ;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid JVQGLKWBFTU;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly Dictionary<Guid, SpawnableToolType> TPTEMSQEKTU;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private static readonly Dictionary<SpawnableToolType, Guid> TAIGWLCRJIK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> DXYBQMGKSHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83D90B0", Offset = "0x83D7EB0", VA = "0x1883D90B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> CRRWGTNIMRD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x83D9110", Offset = "0x83D7F10", VA = "0x1883D9110")]
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
	public static class HABBKUBAEFQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83D81A0", Offset = "0x83D6FA0", VA = "0x1883D81A0")]
		public static bool YSPFTKKZKPO(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83D81D0", Offset = "0x83D6FD0", VA = "0x1883D81D0")]
		private static bool YSPFTKKZKPO(BVCOGACJCKD a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface DRZNQRNIHPQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(KEIRQLZDGXM data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, QVDZVPIRLPY circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public readonly PPOKMLHFENR Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public readonly IEnumerable<PALJQNQKVVN> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public readonly IReadOnlyList<PALJQNQKVVN> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public readonly Id32<TROAQNNIZMC> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public readonly IReadOnlyList<Id128<LQPAJNJDNAW>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GNJLMZOJQZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83DD310", Offset = "0x83DC110", VA = "0x1883DD310")]
		public R1CreateTemplateParams(PPOKMLHFENR circuits, IEnumerable<PALJQNQKVVN> rootData, IReadOnlyList<PALJQNQKVVN> allPersistableData, Id32<TROAQNNIZMC> sourceGraphId, IReadOnlyList<Id128<LQPAJNJDNAW>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly PPOKMLHFENR Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public readonly IReadOnlyList<PALJQNQKVVN> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public readonly Id32<TROAQNNIZMC> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public readonly IReadOnlyList<Id128<LQPAJNJDNAW>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83DD380", Offset = "0x83DC180", VA = "0x1883DD380")]
		public R2CreateTemplateParams(PPOKMLHFENR circuits, Id32<TROAQNNIZMC> sourceGraphId, IReadOnlyList<Id128<LQPAJNJDNAW>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<PALJQNQKVVN> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class LSIUDWLARTE : ZFDERKCBLNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly Guid SAORDWRWWVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<Guid, Guid> QJHIZFGJESD;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0E00", Offset = "0x4FDFC00", VA = "0x184FE0E00")]
		private LSIUDWLARTE(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83D8940", Offset = "0x83D7740", VA = "0x1883D8940")]
		public static LSIUDWLARTE New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83D86D0", Offset = "0x83D74D0", VA = "0x1883D86D0")]
		private static Dictionary<Guid, Guid> ELSMAIWMYHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83D8CF0", Offset = "0x83D7AF0", VA = "0x1883D8CF0")]
		public static LSIUDWLARTE VFQEYJYXNBF(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83D8D00", Offset = "0x83D7B00", VA = "0x1883D8D00")]
		public static LSIUDWLARTE XHDDQJFTOWU(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83D8780", Offset = "0x83D7580", VA = "0x1883D8780")]
		public Dictionary<Guid, Guid> IKYJJRVWKIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
		public Dictionary<Guid, Guid> OBITLIRNBOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83D8650", Offset = "0x83D7450", VA = "0x1883D8650")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83D8A70", Offset = "0x83D7870", VA = "0x1883D8A70")]
		public void UZNSIAHXHPH(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83D87F0", Offset = "0x83D75F0", VA = "0x1883D87F0")]
		public Guid LHEKSZJFPTT([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83D89D0", Offset = "0x83D77D0", VA = "0x1883D89D0")]
		public Guid OHXSIGNKNJC([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83D85E0", Offset = "0x83D73E0", VA = "0x1883D85E0")]
		public bool ZNQEYIRZSWZ([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83D85E0", Offset = "0x83D73E0", VA = "0x1883D85E0", Slot = "4")]
		private bool AFIARVJHQQD([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface NZXELXYXGZQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VWLOQMAJFIN(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YRDSPYXBRUZ(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OLEQEGLINJM
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
	public abstract class TNRFOKTWGXW : NZXELXYXGZQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class XHUKWJICDJD : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private string KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string XVIXERCRYDU
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public XHUKWJICDJD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x83EBB20", Offset = "0x83EA920", VA = "0x1883EBB20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83EBAE0", Offset = "0x83EA8E0", VA = "0x1883EBAE0", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83EBBE0", Offset = "0x83EA9E0", VA = "0x1883EBBE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> SGKYRZSMZGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83EBBE0", Offset = "0x83EA9E0", VA = "0x1883EBBE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private Dictionary<string, HashSet<Guid>>? KQZXWZZKVSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		protected Dictionary<string, string>? ELBSYUSWEIY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> DRMMWBUGWSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x83DD560", Offset = "0x83DC360", VA = "0x1883DD560")]
			[IteratorStateMachine(typeof(XHUKWJICDJD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? DAZVETYEKPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool QMOBVDGYSBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool WXZKKRGEQHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> TMOPTPKGMLY(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool MUDSHSVLFSW(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83DD680", Offset = "0x83DC480", VA = "0x1883DD680")]
		public void UPYARDZPJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x108FBC0", Offset = "0x108E9C0", VA = "0x18108FBC0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83DDAC0", Offset = "0x83DC8C0", VA = "0x1883DDAC0", Slot = "4")]
		public bool VWLOQMAJFIN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83DDD70", Offset = "0x83DCB70", VA = "0x1883DDD70", Slot = "5")]
		public bool YRDSPYXBRUZ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83DD5C0", Offset = "0x83DC3C0", VA = "0x1883DD5C0")]
		private bool QIBDYFZQRRN(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83DD3F0", Offset = "0x83DC1F0", VA = "0x1883DD3F0")]
		protected List<Guid> CETKCEHTURE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected TNRFOKTWGXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class UEGCGUPRFZK
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class YAKKJUTSMIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			public PPOKMLHFENR CDRPZFDNSBL;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public YAKKJUTSMIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83FD780", Offset = "0x83FC580", VA = "0x1883FD780")]
			internal Id32<HHVRSZHWLKJ> YNJLIKLNVPN((Id32<TROAQNNIZMC> GraphId, Id32<LQPAJNJDNAW> NodeId) i)
			{
				return default(Id32<HHVRSZHWLKJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private const int YFBAVJYOMKH = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly Dictionary<Id32<HHVRSZHWLKJ>, ECOTWVLSGJH> FRBXPJNNJPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private long HAUEQRYACHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private long EXVMWMGVVWU;

		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private static readonly ReadOnlyIdArray<HHVRSZHWLKJ, int?> NTBCTRORJFR;

		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private static readonly long DTLMHEASCOR;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long RCONOTFYQEL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83DDED0", Offset = "0x83DCCD0", VA = "0x1883DDED0")]
		public static UEGCGUPRFZK BHOMMAZTHZH(PPOKMLHFENR a, Id128<TROAQNNIZMC> b, [Optional] UEGCGUPRFZK c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83DE550", Offset = "0x83DD350", VA = "0x1883DE550")]
		public static (long, long) MLKSBAJWXRL(PPOKMLHFENR a, Id32<TROAQNNIZMC> b, Id32<LQPAJNJDNAW> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83DE420", Offset = "0x83DD220", VA = "0x1883DE420")]
		public static long GUIWKXVLTSO([In] ReadOnlySpan<Id32<HHVRSZHWLKJ>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83DE8F0", Offset = "0x83DD6F0", VA = "0x1883DE8F0")]
		private static long YSAFDWMZGDJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83EBA60", Offset = "0x83EA860", VA = "0x1883EBA60")]
		public UEGCGUPRFZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class ECOTWVLSGJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long DODEZUTZSIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xF18790", Offset = "0xF17590", VA = "0x180F18790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long PAGAPHUSEUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xE62A30", Offset = "0xE61830", VA = "0x180E62A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F300", Offset = "0x7F4E100", VA = "0x187F4F300")]
		public ECOTWVLSGJH(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class NZJKILWALEV
	{
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public static readonly HashSet<SpawnableToolType> KAEBLMZABDO;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class UGXHFKROQRY
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class KHFKAVVQACB : IEnumerable<PALJQNQKVVN>, IEnumerable, IEnumerator<PALJQNQKVVN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private PALJQNQKVVN KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private SpawnableTemplateData OXPMGDHEUFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public SpawnableTemplateData EBGOQRTNUTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private SpawnTemplateParams LNKHJJZJLOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public SpawnTemplateParams JMDKHNEPYLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private int AHISCSJYWTV;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private PALJQNQKVVN JKHPGADLTWG
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public KHFKAVVQACB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83EE0A0", Offset = "0x83ECEA0", VA = "0x1883EE0A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83EE060", Offset = "0x83ECE60", VA = "0x1883EE060", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83EDF00", Offset = "0x83ECD00", VA = "0x1883EDF00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PALJQNQKVVN> GQXMISCTKJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83EDF00", Offset = "0x83ECD00", VA = "0x1883EDF00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83F7D20", Offset = "0x83F6B20", VA = "0x1883F7D20")]
		public static SpawnableTemplateData XAJZNTOAVYR([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83F7EB0", Offset = "0x83F6CB0", VA = "0x1883F7EB0")]
		public static SpawnableTemplateData XAJZNTOAVYR([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83F72E0", Offset = "0x83F60E0", VA = "0x1883F72E0")]
		private static HashSet<Id128<ZOPOWZPEQUO>> SMWHBNVARNV(IReadOnlyList<PALJQNQKVVN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83F6C70", Offset = "0x83F5A70", VA = "0x1883F6C70")]
		private static void RRPRKKAXDKU(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83F5570", Offset = "0x83F4370", VA = "0x1883F5570")]
		public static Result<LSIUDWLARTE, TryCloneTemplateError> NRLNVTGZFJN(SpawnableTemplateData a, SpawnTemplateParams b, LSIUDWLARTE? srcRemapper, bool c)
		{
			return default(Result<LSIUDWLARTE, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83F6B60", Offset = "0x83F5960", VA = "0x1883F6B60")]
		[IteratorStateMachine(typeof(KHFKAVVQACB))]
		private static IEnumerable<PALJQNQKVVN> QXLKFQQBSQQ(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83F8040", Offset = "0x83F6E40", VA = "0x1883F8040")]
		private static void XIZXXULBCDB(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83F7680", Offset = "0x83F6480", VA = "0x1883F7680")]
		private static bool VGVYWJAVOGS(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83F5280", Offset = "0x83F4080", VA = "0x1883F5280")]
		private static Dictionary<Guid, BVCOGACJCKD> LHTTBSRPRKG(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83F51F0", Offset = "0x83F3FF0", VA = "0x1883F51F0")]
		private static void IVKCZGWUWKY(bool a, PALJQNQKVVN b, LSIUDWLARTE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83F4F60", Offset = "0x83F3D60", VA = "0x1883F4F60")]
		private static void DDOMXNNQLZK(PALJQNQKVVN a, Guid b, SpawnTransformData? c, Dictionary<Guid, BVCOGACJCKD> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83F80B0", Offset = "0x83F6EB0", VA = "0x1883F80B0")]
		private static void YJVNMZHDKCF(IEnumerable<PALJQNQKVVN> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public PPOKMLHFENR circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public OLEQEGLINJM roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public DRZNQRNIHPQ circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public Id128<TROAQNNIZMC> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public RDNXSUMSJLC globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public List<PALJQNQKVVN> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public TEUMKDGDGXA photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 UTLIDXBRNWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83F4120", Offset = "0x83F2F20", VA = "0x1883F4120")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS CXTHNKKDKRK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83F4520", Offset = "0x83F3320", VA = "0x1883F4520")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1705810", Offset = "0x1704610", VA = "0x181705810")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83F4890", Offset = "0x83F3690", VA = "0x1883F4890")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83F4230", Offset = "0x83F3030", VA = "0x1883F4230")]
		public static SpawnTransformData MEZPNWSAWFA(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83F4960", Offset = "0x83F3760", VA = "0x1883F4960")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x83F4980", Offset = "0x83F3780", VA = "0x1883F4980")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83F45F0", Offset = "0x83F33F0", VA = "0x1883F45F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83F4680", Offset = "0x83F3480", VA = "0x1883F4680")]
		public SpawnTransformData ZZOWBFNJANG(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83F44B0", Offset = "0x83F32B0", VA = "0x1883F44B0")]
		public static SpawnTransformData MVAODDARZWI(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83F4560", Offset = "0x83F3360", VA = "0x1883F4560")]
		public readonly CircuitsRigidTransform QJKDJRZYZUE()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private readonly HEYQXAVABBH _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19C77A0", Offset = "0x19C65A0", VA = "0x1819C77A0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, HEYQXAVABBH innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83F4AE0", Offset = "0x83F38E0", VA = "0x1883F4AE0")]
		public NVAIURBTDUG DUQOAOSEYHT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83F4CC0", Offset = "0x83F3AC0", VA = "0x1883F4CC0")]
		public static Result<LSIUDWLARTE, TryCloneTemplateError> New(PFIKVIQAZOP<None> innerError)
		{
			return default(Result<LSIUDWLARTE, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83F4B50", Offset = "0x83F3950", VA = "0x1883F4B50")]
		public static Result<LSIUDWLARTE, TryCloneTemplateError> New(NVAIURBTDUG innerError)
		{
			return default(Result<LSIUDWLARTE, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83F4C00", Offset = "0x83F3A00", VA = "0x1883F4C00")]
		public static Result<LSIUDWLARTE, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<LSIUDWLARTE, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class WHUOGPFHYDN : IDisposable, ITNQEMQJPLY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private NativeList<CurvePointData> JTEZHWKNMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private float IWYIAYZYVEC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags BQKKHFWCSBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAA950", Offset = "0xAA9750", VA = "0x180AAA950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DATNMRKDPWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x83FBEB0", Offset = "0x83FACB0", VA = "0x1883FBEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BXYCQTZIPYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x83FC400", Offset = "0x83FB200", VA = "0x1883FC400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> LLUVGJYPAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int IAQTFAFOLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83FB6C0", Offset = "0x83FA4C0", VA = "0x1883FB6C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float EANTZPYBIGT
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x83FC100", Offset = "0x83FAF00", VA = "0x1883FC100")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83FD700", Offset = "0x83FC500", VA = "0x1883FD700")]
		public WHUOGPFHYDN(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83FB700", Offset = "0x83FA500", VA = "0x1883FB700", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83FC6B0", Offset = "0x83FB4B0", VA = "0x1883FC6B0")]
		public Vector3 SOXLNGSOHOS(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83FD5D0", Offset = "0x83FC3D0", VA = "0x1883FD5D0", Slot = "6")]
		public Quaternion ZWRCLPTRVNB(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83FB760", Offset = "0x83FA560", VA = "0x1883FB760", Slot = "5")]
		public Vector3 EGHSQRBCJLI(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83FCB80", Offset = "0x83FB980", VA = "0x1883FCB80", Slot = "7")]
		public float SXHUTWEIMSP(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83FCC90", Offset = "0x83FBA90", VA = "0x1883FCC90")]
		public void XIHDEIYFMYB(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83FC240", Offset = "0x83FB040", VA = "0x1883FC240")]
		private bool OOEFPAMDBJL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83FAD50", Offset = "0x83F9B50", VA = "0x1883FAD50")]
		public void BHUWKMEWBAT(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83FC070", Offset = "0x83FAE70", VA = "0x1883FC070")]
		public void MBGCKHZEQJQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83FC410", Offset = "0x83FB210", VA = "0x1883FC410")]
		public void ROUDUUMLGCP(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83FBEC0", Offset = "0x83FACC0", VA = "0x1883FBEC0")]
		public void LXOGOEVRHXR(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83FC560", Offset = "0x83FB360", VA = "0x1883FC560")]
		public void SFRDCBQFVYN(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83FC2A0", Offset = "0x83FB0A0", VA = "0x1883FC2A0")]
		public void PTRGNQBMSQU(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83FAEB0", Offset = "0x83F9CB0", VA = "0x1883FAEB0")]
		public static Quaternion CMFZDXRBXUO(Quaternion a, int b, float c, ITNQEMQJPLY d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83FB800", Offset = "0x83FA600", VA = "0x1883FB800")]
		public Bounds EKTJMGAPQIW(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83FD570", Offset = "0x83FC370", VA = "0x1883FD570", Slot = "10")]
		public virtual void XMCOCCKKGTM(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83FCBE0", Offset = "0x83FB9E0", VA = "0x1883FCBE0")]
		public NativeList<CurvePointData> WCYFSGOIYCW(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83EC570", Offset = "0x83EB370", VA = "0x1883EC570")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83EC4B0", Offset = "0x83EB2B0", VA = "0x1883EC4B0")]
		public Quaternion XGWGSNUDKWP(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83EC020", Offset = "0x83EAE20", VA = "0x1883EC020")]
		public CurvePoint FONVHQKTFUD(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83EC310", Offset = "0x83EB110", VA = "0x1883EC310")]
		public TGIIRPBAFAS HCNKBWLRDBR(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class IUNDJVYERQA : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83ED550", Offset = "0x83EC350", VA = "0x1883ED550", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83ECF70", Offset = "0x83EBD70", VA = "0x1883ECF70")]
		private void OCAKHFEZEED(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83ECF10", Offset = "0x83EBD10", VA = "0x1883ECF10")]
		private void OCAKHFEZEED(Dictionary<Guid, Guid> a, OYVKOZIXXZS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83ECC90", Offset = "0x83EBA90", VA = "0x1883ECC90")]
		private void OCAKHFEZEED(Dictionary<Guid, Guid> a, MNUKSSPTMNT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public IUNDJVYERQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class DDFYXGITQMZ : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83EC5F0", Offset = "0x83EB3F0", VA = "0x1883EC5F0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public DDFYXGITQMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class GLWTJJBVHJE : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83EC970", Offset = "0x83EB770", VA = "0x1883EC970", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public GLWTJJBVHJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class WFLWJGWTMZW : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83FABF0", Offset = "0x83F99F0", VA = "0x1883FABF0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WFLWJGWTMZW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class KWADDDSMHFU : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83EE1B0", Offset = "0x83ECFB0", VA = "0x1883EE1B0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KWADDDSMHFU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class YOGEHJIHZRB : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83FD850", Offset = "0x83FC650", VA = "0x1883FD850", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public YOGEHJIHZRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class EZUVPRAXEJP : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83EC7D0", Offset = "0x83EB5D0", VA = "0x1883EC7D0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public EZUVPRAXEJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class RNPCASWLRCO : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x83F37F0", Offset = "0x83F25F0", VA = "0x1883F37F0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RNPCASWLRCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class HAWZXYASZSI : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83ECAD0", Offset = "0x83EB8D0", VA = "0x1883ECAD0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public HAWZXYASZSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class RGCFPHFKDMI : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83F3630", Offset = "0x83F2430", VA = "0x1883F3630", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RGCFPHFKDMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class OLWBYNVIVWA : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83EE790", Offset = "0x83ED590", VA = "0x1883EE790", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public OLWBYNVIVWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class EJBRAOYNTZF : LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public static readonly TMJBXLZCCWF NJVQKKMKRWQ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83EC6A0", Offset = "0x83EB4A0", VA = "0x1883EC6A0", Slot = "4")]
		public void UIYHTBMRQCG(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public EJBRAOYNTZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public TEUMKDGDGXA photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface LGQDTHYKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UIYHTBMRQCG(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class UKYJEHHVTDG
	{
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly LGQDTHYKIKL[] ZDMBTGKSNAM;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83F8A80", Offset = "0x83F7880", VA = "0x1883F8A80")]
		public static void XHZXZISVJSF(PALJQNQKVVN a, LSIUDWLARTE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83F87E0", Offset = "0x83F75E0", VA = "0x1883F87E0")]
		public static void QMAMCCHMSAV(PALJQNQKVVN? data, LSIUDWLARTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83F8560", Offset = "0x83F7360", VA = "0x1883F8560")]
		public static void AYZDMDFXINR(PALJQNQKVVN? data, LSIUDWLARTE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83F8D00", Offset = "0x83F7B00", VA = "0x1883F8D00")]
		public static void YSPFTKKZKPO(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public PALJQNQKVVN viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83EE890", Offset = "0x83ED690", VA = "0x1883EE890")]
		public Guid KBAMXUKSSVI(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface TEUMKDGDGXA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private static readonly HashSet<Guid> NIBQQKXKQFP;

		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private static readonly HashSet<Guid> SGJDAQHSUZN;

		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly HashSet<Guid> ABLPAHSJEZF;

		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private static readonly ProfilerMarker GEKFYTOMQPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private readonly HashSet<string> MLSNMSHEUWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private readonly Dictionary<long, int> PEYGRUDVRNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private readonly HashSet<Guid> TFZVCZLCFAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private readonly HashSet<Guid> YATSYLOTZNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private readonly HashSet<Guid> WQBNLDSMYKD;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> EACHYBPSDYO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> DHMBJPBBDZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> RFTSSQZKAGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> DZFAUOOUETR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83F06D0", Offset = "0x83EF4D0", VA = "0x1883F06D0")]
		public static void FMNAQYRWXRJ(SpawnableTemplateData a, ULVCFPKZCLH b, LSIUDWLARTE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83F10E0", Offset = "0x83EFEE0", VA = "0x1883F10E0")]
		public static PersistedRoomDataReferences NERRLNAAIVZ(PersistedRoomData a, ULVCFPKZCLH? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83F2E00", Offset = "0x83F1C00", VA = "0x1883F2E00")]
		public static PersistedRoomDataReferences UPKNJGXJJEQ(SpawnableTemplateData a, ULVCFPKZCLH? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83F2EF0", Offset = "0x83F1CF0", VA = "0x1883F2EF0")]
		public static PersistedRoomDataReferences XXPQGJPZIGO(HEZSYTDRMTA a, UPHKHJRASGC b, ULVCFPKZCLH? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83EE940", Offset = "0x83ED740", VA = "0x1883EE940")]
		public static PersistedRoomDataReferences AAJMJEIPWXR(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83F34D0", Offset = "0x83F22D0", VA = "0x1883F34D0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83F3300", Offset = "0x83F2100", VA = "0x1883F3300")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83F2760", Offset = "0x83F1560", VA = "0x1883F2760")]
		private void SGSALZNIQCO(PersistedRoomData a, ULVCFPKZCLH? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83F16D0", Offset = "0x83F04D0", VA = "0x1883F16D0")]
		private void SGSALZNIQCO(SpawnableTemplateData a, ULVCFPKZCLH? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83EEF80", Offset = "0x83EDD80", VA = "0x1883EEF80")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83F1960", Offset = "0x83F0760", VA = "0x1883F1960")]
		private void SGSALZNIQCO(HEZSYTDRMTA? a, ULVCFPKZCLH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83F2D80", Offset = "0x83F1B80", VA = "0x1883F2D80")]
		private void SGSALZNIQCO(UPHKHJRASGC? a, ULVCFPKZCLH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83F14F0", Offset = "0x83F02F0", VA = "0x1883F14F0")]
		private void SGSALZNIQCO(FJLBILPMIRY? a, ULVCFPKZCLH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83EEB40", Offset = "0x83ED940", VA = "0x1883EEB40")]
		private static bool ADZQOPDWLLX(FJLBILPMIRY a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83EED40", Offset = "0x83EDB40", VA = "0x1883EED40")]
		private static bool EGHSUWYCDUT(FJLBILPMIRY a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83EF530", Offset = "0x83EE330", VA = "0x1883EF530")]
		private static void FMNAQYRWXRJ(UPHKHJRASGC? root, ULVCFPKZCLH a, LSIUDWLARTE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83EFFF0", Offset = "0x83EEDF0", VA = "0x1883EFFF0")]
		private static void FMNAQYRWXRJ(FJLBILPMIRY? customProperties, ULVCFPKZCLH a, LSIUDWLARTE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83EFC50", Offset = "0x83EEA50", VA = "0x1883EFC50")]
		private static void FMNAQYRWXRJ(HEZSYTDRMTA? root, ULVCFPKZCLH a, LSIUDWLARTE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83EF600", Offset = "0x83EE400", VA = "0x1883EF600")]
		private static void FMNAQYRWXRJ(CircuitsV2.Protobuf.CircuitNodeData? node, ULVCFPKZCLH a, LSIUDWLARTE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83F2A00", Offset = "0x83F1800", VA = "0x1883F2A00")]
		private void SGSALZNIQCO(CircuitsV2.Protobuf.CircuitNodeData? a, ULVCFPKZCLH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83F1160", Offset = "0x83EFF60", VA = "0x1883F1160")]
		private void NTXGGTAXSOW(Guid? a, ULVCFPKZCLH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83F2360", Offset = "0x83F1160", VA = "0x1883F2360")]
		private void SGSALZNIQCO(PALJQNQKVVN? a, ULVCFPKZCLH? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83F0280", Offset = "0x83EF080", VA = "0x1883F0280")]
		private static void FMNAQYRWXRJ(PALJQNQKVVN? viewData, ULVCFPKZCLH a, LSIUDWLARTE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83F2E80", Offset = "0x83F1C80", VA = "0x1883F2E80")]
		private void VOZRNLHBOSX(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83F13C0", Offset = "0x83F01C0", VA = "0x1883F13C0")]
		private void SBHOHFWEZHH(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83F1370", Offset = "0x83F0170", VA = "0x1883F1370")]
		private void SBHOHFWEZHH(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83F1490", Offset = "0x83F0290", VA = "0x1883F1490")]
		private void SBHOHFWEZHH(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BKRHZMOADGA : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private readonly IEnumerator<DictionaryEntry> EOGPKWOZYKV;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x83EBDF0", Offset = "0x83EABF0", VA = "0x1883EBDF0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x83EBEC0", Offset = "0x83EACC0", VA = "0x1883EBEC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x83EBF70", Offset = "0x83EAD70", VA = "0x1883EBF70", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x83EBD10", Offset = "0x83EAB10", VA = "0x1883EBD10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
			public BKRHZMOADGA(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x83EBC70", Offset = "0x83EAA70", VA = "0x1883EBC70", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x83EBCC0", Offset = "0x83EAAC0", VA = "0x1883EBCC0", Slot = "9")]
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
			private sealed class JDIRKRJQQAC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000585")]
				private int DPSIYUGFINN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000586")]
				private DictionaryEntry KPVEVSUGXYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000587")]
				public RoomObjectCounts SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry ITTKUAOAWEU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xC580B0", Offset = "0xC56EB0", VA = "0x180C580B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object SQVTSFKREWF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x83EDEB0", Offset = "0x83ECCB0", VA = "0x1883EDEB0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
				[DebuggerHidden]
				public JDIRKRJQQAC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
				[DebuggerHidden]
				private void DUPJTQKNSZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x83EDDB0", Offset = "0x83ECBB0", VA = "0x1883EDDB0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x83EDD70", Offset = "0x83ECB70", VA = "0x1883EDD70", Slot = "8")]
				[DebuggerHidden]
				private void KJSXTMSAUIL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection HNSGNSPUULE
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x83F38E0", Offset = "0x83F26E0", VA = "0x1883F38E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x83F3CC0", Offset = "0x83F2AC0", VA = "0x1883F3CC0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x83F3DA0", Offset = "0x83F2BA0", VA = "0x1883F3DA0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool TFVRHJQXSEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x83F3A10", Offset = "0x83F2810", VA = "0x1883F3A10", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool YJHJQNHWVEA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x83F3AB0", Offset = "0x83F28B0", VA = "0x1883F3AB0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection ZXRFGRJFOLW
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x83F3DE0", Offset = "0x83F2BE0", VA = "0x1883F3DE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int AVYABIPDAMF
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x83F3C70", Offset = "0x83F2A70", VA = "0x1883F3C70", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool IEYIRWCBUVS
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x83F3A60", Offset = "0x83F2860", VA = "0x1883F3A60", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object HKOQXPJBFWN
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x83F3BD0", Offset = "0x83F29D0", VA = "0x1883F3BD0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x83F3F20", Offset = "0x83F2D20", VA = "0x1883F3F20")]
			[IteratorStateMachine(typeof(JDIRKRJQQAC))]
			private IEnumerator<DictionaryEntry> XDGEQAKTDPX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x83F3E80", Offset = "0x83F2C80", VA = "0x1883F3E80", Slot = "19")]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x83F3B00", Offset = "0x83F2900", VA = "0x1883F3B00", Slot = "13")]
			private IDictionaryEnumerator KXFBAHFZVGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x83F3E30", Offset = "0x83F2C30", VA = "0x1883F3E30", Slot = "9")]
			private void VXJKOJCPXGN(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x83F39C0", Offset = "0x83F27C0", VA = "0x1883F39C0", Slot = "10")]
			private void CRPNZRXYNBR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x83F3F90", Offset = "0x83F2D90", VA = "0x1883F3F90", Slot = "8")]
			private bool YDMQNUQNXAH(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x83F3970", Offset = "0x83F2770", VA = "0x1883F3970", Slot = "14")]
			private void BUYQLPZYTCK(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x83F3C20", Offset = "0x83F2A20", VA = "0x1883F3C20", Slot = "15")]
			private void MRXMTDDVNES(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class MGHNRGOAELA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				private int DPSIYUGFINN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058C")]
				private DictionaryEntry KPVEVSUGXYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400058D")]
				public Invention SVDPBWSVAHX;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry ITTKUAOAWEU
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xC580B0", Offset = "0xC56EB0", VA = "0x180C580B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object SQVTSFKREWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x83EE530", Offset = "0x83ED330", VA = "0x1883EE530", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
				[DebuggerHidden]
				public MGHNRGOAELA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
				[DebuggerHidden]
				private void DUPJTQKNSZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x83EE410", Offset = "0x83ED210", VA = "0x1883EE410", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x83EE3D0", Offset = "0x83ED1D0", VA = "0x1883EE3D0", Slot = "8")]
				[DebuggerHidden]
				private void KJSXTMSAUIL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection HNSGNSPUULE
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x83ED5D0", Offset = "0x83EC3D0", VA = "0x1883ED5D0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x83ED970", Offset = "0x83EC770", VA = "0x1883ED970", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x83EDA80", Offset = "0x83EC880", VA = "0x1883EDA80", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool TFVRHJQXSEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x83ED6C0", Offset = "0x83EC4C0", VA = "0x1883ED6C0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool YJHJQNHWVEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x83ED760", Offset = "0x83EC560", VA = "0x1883ED760", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection ZXRFGRJFOLW
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x83EDAC0", Offset = "0x83EC8C0", VA = "0x1883EDAC0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int AVYABIPDAMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x83ED920", Offset = "0x83EC720", VA = "0x1883ED920", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool IEYIRWCBUVS
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x83ED710", Offset = "0x83EC510", VA = "0x1883ED710", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object HKOQXPJBFWN
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x83ED880", Offset = "0x83EC680", VA = "0x1883ED880", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B02A00", Offset = "0x2B01800", VA = "0x182B02A00")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x83EDBF0", Offset = "0x83EC9F0", VA = "0x1883EDBF0")]
			[IteratorStateMachine(typeof(MGHNRGOAELA))]
			private IEnumerator<DictionaryEntry> XDGEQAKTDPX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x83EDB60", Offset = "0x83EC960", VA = "0x1883EDB60", Slot = "19")]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x83ED7B0", Offset = "0x83EC5B0", VA = "0x1883ED7B0", Slot = "13")]
			private IDictionaryEnumerator KXFBAHFZVGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x83EDB10", Offset = "0x83EC910", VA = "0x1883EDB10", Slot = "9")]
			private void VXJKOJCPXGN(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x83ED670", Offset = "0x83EC470", VA = "0x1883ED670", Slot = "10")]
			private void CRPNZRXYNBR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x83EDC50", Offset = "0x83ECA50", VA = "0x1883EDC50", Slot = "8")]
			private bool YDMQNUQNXAH(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x83ED620", Offset = "0x83EC420", VA = "0x1883ED620", Slot = "14")]
			private void BUYQLPZYTCK(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x83ED8D0", Offset = "0x83EC6D0", VA = "0x1883ED8D0", Slot = "15")]
			private void MRXMTDDVNES(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83F9B10", Offset = "0x83F8910", VA = "0x1883F9B10")]
		public static UgcRoomSaveStatsDetailed NERRLNAAIVZ(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83F99F0", Offset = "0x83F87F0", VA = "0x1883F99F0")]
		[CompilerGenerated]
		internal static int CSTXWGWRABL([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83FA4F0", Offset = "0x83F92F0", VA = "0x1883FA4F0")]
		[CompilerGenerated]
		internal static void PYOOLIXZOVT(int a, [In] HEZSYTDRMTA graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		ParticleVfx
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class ULVCFPKZCLH
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public readonly Guid HURYBTZNWRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public readonly IReadOnlyList<Guid> DHMBJPBBDZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public readonly UnitySubAssetKind KFDHSHLWAWJ;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x83FAB90", Offset = "0x83F9990", VA = "0x1883FAB90")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private readonly LSIUDWLARTE OQFTZHFZYRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private readonly Dictionary<Guid, UnitySubAsset> RBIOHWMSPDI;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public LSIUDWLARTE LZWRELPIGVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83F9670", Offset = "0x83F8470", VA = "0x1883F9670")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83F9870", Offset = "0x83F8670", VA = "0x1883F9870")]
		public bool XCKGXZBXGAW(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83F9960", Offset = "0x83F8760", VA = "0x1883F9960")]
		public ULVCFPKZCLH()
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
