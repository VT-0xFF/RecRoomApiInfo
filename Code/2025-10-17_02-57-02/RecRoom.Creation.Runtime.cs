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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x846E090", Offset = "0x846C690", VA = "0x18846E090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class TMZWAFNYVIP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> TUATFQXGHYL;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> RZHBDNCMHUT;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> SXJSTRXVRAV;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> VRVQQEMWTFM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string QHJFCLMUDIA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string QCJSLGFPJCN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string TQSHJFLVYRG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x846E1F0", Offset = "0x846C7F0", VA = "0x18846E1F0")]
	public static bool ELDHKLNMDEP(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x846E970", Offset = "0x846CF70", VA = "0x18846E970")]
	public static bool SHERVJEXPCF(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x846E2F0", Offset = "0x846C8F0", VA = "0x18846E2F0")]
	public static string GDCKXJRASNO(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x8460400", Offset = "0x845EA00", VA = "0x188460400", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BTMLUOCUETU
	{
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public static readonly Guid LDRGLNFQKKH;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public static readonly Guid FOGNREEHMZV;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public static readonly Guid HMZWKSSJKXT;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public static readonly Guid WYKPXARGJIF;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static readonly Guid MLZKCQEOELW;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static readonly Guid CQBXFNJSXSU;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid WXXPIYUDXMZ;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid FZZJTVSSPTY;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid WBGIRGOMOTU;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid ZQEWQPONBJA;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid OASCLVYQYBF;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid QFMEGLVNEIS;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid XQUXLEUDRHP;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid HJJTJPQKFIO;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid UNIMANLXQRX;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid PUWCZCHTLWK;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid BFSLVYPOUCE;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid AKMROCKCWJD;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid DHPKDCPZYDQ;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid EHBKFJVUTJX;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid SJZYCFXYFCD;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid ZRBYGIBMZDB;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid QHIYDCXYMLP;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid UVNFDUONQZN;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid XKOXLZSCKXT;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid SYHKKIJMVWQ;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid CGPRPITMVCZ;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid GIMLZHWPGNM;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid FQRVSCQHXLU;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid CKEMZJSZXSD;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid KZVPKPGMUIZ;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid CABWUGMDCZO;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid EZYIZWOGUTB;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid RHCXVUTVBIW;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid FYDNVCRHZHC;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid CKJSOZWFHPI;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid SCVEFQWSLQY;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid IDDQUGOFUNM;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid REWFXOTSQLY;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid GNFYTXULOIY;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid CLYWEXEJNBC;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid ROXCQTMXAEW;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid CKNSJJNDZNR;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid HKHIBUSOZME;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid TXMCHNIKSKN;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid PJEMECCNLMZ;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid JPCTZBKKBHT;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid EEFKZUQWIDW;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid RPFGOUYXTPN;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid JTYVYLMHZIS;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid NJZZMGHOAOK;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid PYIFFDTKZPL;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid JZWMRRXHHLT;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid SCSWGKEZLKP;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid AXGFHWIVJIQ;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid INKZFLTLXSG;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid WUHRMYDYHFB;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid XWGHNSEJUMJ;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid QRZBFOABOHK;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid TLGEKFQMRKF;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid GWCRDKIKTZA;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid STZPNULUPGC;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid CHRATMEIEGV;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid ANFTGYVFKZC;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid JSCLDGREWBO;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid WESBNMRPSLF;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid FRCQZVHCERR;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid PWYHEKPWZRU;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid WROUYSTBPMT;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid JRGQSHPBRMI;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid BOTIWNTGKPJ;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid EAXIZJJFLXM;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid KNIAGMNIUBS;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid ACDDRTUCPHZ;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid GJFDJCHJQKZ;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid DTTTEQTVHNL;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid DRKJXQBZGWZ;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid PEPQVZBBFYB;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid XEVZQXUHHTC;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid IPTHCSAVONH;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid LKFCHNASEVI;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid LEWYIVXXXQB;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid WQVFEPHGRJE;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid ADOOQYJTULE;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid HHQNOJJWTCU;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid VCVKOGIEFQP;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid MSZTDRGZCIW;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid IAWMPORTLUO;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid HZAMBJGWPNZ;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid HDFSCLMSEWL;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid POPIMWRVSLE;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid AZBOGMEKYOW;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid ATHLIBMYHZQ;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid AMDFLEDSONS;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid RMFXOBYTIIW;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid TATPMFDAWRR;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid WHPYWNDWBGS;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid GFUMEARJRDU;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid TMXKRZDUQJX;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid XDGZCDRXUDM;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid NCSAAEOKRFX;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid YPQCWPQPOBM;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid NCHMFRAPYJF;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid LIMWLKHPVIM;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid TWWSIOJTQZE;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid HFGGZEQMGKT;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid OQKMIZVSXYE;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid KLGFPWRQMXD;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid OQVADNJNQUW;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid UOJMSHQMRLN;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid OSVRCDANHEI;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid OZRWFOTDYOB;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid YVJZKRKTEKN;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid XTUEQKERJFG;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid GWTBJUXZVNA;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid PAELWFOWCLL;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid VYRFAPBVBDG;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid SVWOWPYZKJW;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid KXCPAVQWZUB;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid YQSCYDNRQDY;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid QGDUMYFHVYS;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid KERCPUNRAIG;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid WUNKACAASXU;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid JQHHLWKMSTS;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid OMDGOAAHGZG;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid LNQZTLGAFOE;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid OCHLEAFGVWV;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid BQSTSHDYVLU;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid MJHRRGHZPKM;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid QXAMWTLHTME;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid DDMTFHIVXFR;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid EUKEBVMSMGY;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid BKMGDGMJOYX;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid GMKGMUVLBQZ;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid SDCFJDWDVZU;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid HGJRMZMYTAI;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid OQWHSAQIITR;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid VMZWDZRYHZX;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid JXKOSSSXGTC;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid XGYWKFSLBYK;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid QMCMLUKJWKJ;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid GMRPPKRCFRR;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid VGBYMBLHXHB;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid TFRQPCSWBFT;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid IXRLOFVWDSC;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid GULROENBRRM;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid GUGKQXTEIGD;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid GUBDTQZGYUU;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid GTVWWKFJPJL;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid GTQPZDLMFYC;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid GTLJBWROWMT;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid GTGCEPXRNBK;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid KEYPYEYFFLE;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid UDIDWHCDVCY;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid IVWQCVJUOIF;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid JJZCBODGSCF;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid ZOGQPXZORDO;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid BMEOTKHDSCH;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid SIGELHITSPT;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid QBUWVZHZBMB;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid XIWGYDVXHRY;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid FDAAGMAWCRO;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid JCKXUZDRZOJ;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid QIWYLGSZHNK;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid VMAKILZROVR;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid JEPHOBDDNTX;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid PPQXVSMUZRU;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid WARUMQBRDAT;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid JDZMWGVLLLW;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid JEETTNPIUXF;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid JFFCFVKVQBY;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid EIXQIMQALLD;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid EIPLGOTNMTI;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid AXSFJGUZZCL;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid EIHVQSIIJDC;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid KXCDZEIEWLL;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid XZKBOHRRHLC;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid HCZEZMOYNWK;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid QYARDFXFEPF;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid NMFKMLYFHQD;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid WXSWMEUJQEZ;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid BPWGSQOSQAL;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid RCWAXXRGCLP;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid IMYUKLUZSPE;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid CGJKXVFEEZD;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid EZRBJPSJTVW;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid UBHEQWMAUQG;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid MBGTZSXLLUI;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid QBUCYXNLZUG;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid DXOZXIPVYJJ;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid ZRLYYQYJCWV;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid HNYKSLKFWFO;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid MCJSPELYSMC;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid KJOMQHCHUDT;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid ZJUPRHMDVIG;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid AMBFDZKYKBC;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ZLBJEMXHJUB;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid IWKZJSKBWLC;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid SRQCLVHWWYD;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid CNJUWMXXGRV;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid AGUWYNPSFJY;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid UQYMBSOMYPR;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid KVTWLTXWWIQ;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid BTMUIFMJNBM;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid FVMLGLFROEE;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid OOCKITNATVF;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid OPWCKPHQNZY;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid DELPXSTEYSW;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid XIBZIQEYBWZ;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid XEEXEMTYULB;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid TBHNXIPRVFU;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid WUGOOQCIQDN;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid CDDSQOVYKIC;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid ITRDXMXVSGD;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid MNWENLDQHHJ;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid PPAGDCEMZCZ;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid QZZSOGEZWYZ;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid AYBCEWKAMPM;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid TSMYOKPPLJW;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid VZSOMQYKHGJ;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid BPUJRFFHPXM;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid UXIUNOPJBCP;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid HLILNJALGTT;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid BGXBBCXGBQR;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid FRVUSTZLWZW;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid SMJRILLRARW;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid JHRPUIUAFJN;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid YGZQAINZTSG;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid ZMJJTROZOQV;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid PVPMNQKDCPE;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid LTUWUWZLQJE;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid BWKYUXSDAPS;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid KJRYLBKKLFI;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid YMXAADARTIQ;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid VDDYCMSZDQW;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid IGAIEURVLDL;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid JJOGCKTJDLW;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid KJQZADHZRRA;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid TKFJAFOWIFV;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid AKQEMUNWBYW;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid ALDHSWYJULT;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid UFMTSRXLLPF;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid XEKJVFFXWBT;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid KFSMDISFEHK;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid KAWQVUDRMDL;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid JFYPLWHYXAU;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid XGVWRCDYCDK;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid PTXTBYOTOGF;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid SDUQARHTKFO;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid FVMZDASXMFS;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid BPNYHXBQRDG;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid ZMGCJWQQBBC;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid SISGEPPPDGW;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid HBIPDYCXOBU;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid CEXLZSFRWTN;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid QNMLNJWMFLN;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid VIPQVVLBPYA;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid UXOVJRFXGFJ;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid MSKYSATEUIW;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid BJOXRDKTGDU;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid QJCKOECTTDZ;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid BWUMBFAWEZY;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid NDHZLQOEQTM;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid SPCABEQHFJY;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid BQUQKDMUZPW;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid JWYSCOTYKOE;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid YYYPJZSRCNG;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid TVVGORDPZOI;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid RHFMIYFDGRT;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid UMEYKSMLCGJ;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid QURZFLSVZAG;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid KWLOWQJZPWZ;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid RIVTTTDEYAK;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid DLCEGXWQPRE;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid VBRCXNAJGEZ;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid WXBAKEERNUM;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid WJJAOKBWUZI;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid ELSLGRBSYZC;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid ECJLBAVDYTJ;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid SYMREKXNBSL;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid NXIAOOGODBJ;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid EDPPIUMDYXE;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid YWRRKCAKGMI;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid YKXMEODHLZQ;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid ZWFEESPTUMG;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid XNECVCQHOYB;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid UUATLWCEKGH;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid ERPHPQOSEPR;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid SYFEKYIZULS;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid VPACNISGNIA;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid DIMYQBEIGPX;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid ZSFEJOJPGCZ;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid YBFAJMDCYLW;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid DEBXKJGXSUO;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid HEVPIUROSPX;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid IOYDZCUOPEC;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid MIROJXUEKBV;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid UROYZLDOBVK;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid DPFOJZQXTYY;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid DANGOXYCZJM;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid QQKCYPSFSRT;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid RDEJPRJVYEX;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid YMDWEGVOEAR;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid VTVVXHGRJGA;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid XTYEMJQCFKJ;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid BDBDONSYOKJ;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid GTNTQMEZCBF;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid WYMMTNIXARB;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid HKSHKPSWYLS;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid IDGMDBJYGYM;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid MMFNHLXEVQG;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid ORSJHYCTQGA;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid WGRSSTXOGNO;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid UKPUGJPQOLQ;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid NBANPYHZOPL;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid NVCCBENDOKR;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid AUYRWZLDEQG;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid GSHRZVITUBB;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid BZIZNXJPNOR;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid KXVSJYRTMZJ;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid NYHIJLTKYIO;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid GDWNMNURCJI;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid QYJFWUGPDSV;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid WSQKBBHMWAX;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid ZXWLBVOEFXD;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid ZFHZBBVYXYF;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid JEPGWEBRSOC;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid GQJNHCFSLTO;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid IDWJQUBMHSD;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid PASUBGQKRND;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid QRTORKUZHUT;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid BTKCVIKBWDF;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid DTKRYQDXIQE;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid JWUJAXGEKXK;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid TJMYGOUVTTO;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid HZXLHHOTUSP;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid BFDEOLSTNUH;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid JXFKVUQHTGK;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid WUMWQMPVCFK;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid TXGFZMMMKPT;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid PRJLUJVKEIN;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid GRKSRJGADYA;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid OPTBEVHKSOB;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid OLUEFOXHVMN;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid GYVDKHZGNNA;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid DMFCYAYQFUZ;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid BVFMDMDAQCL;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid LEDLKOLPERC;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid NIYNDOPNTUF;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid EDJGSLJDBLE;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid AVQEQEBAQLN;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid WBTBAXKQYMV;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid FGCSTWFMUID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid QCHRRYUUYVL;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid URGJUKAPPJE;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid FTABTJEAJOK;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid PRYQKGWGRCD;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid DMZGNUNAOLA;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid YHPVMMWHUDC;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid FSEZHVWQTYE;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid HZBMPUBTDUV;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid GXMWZCNKEQY;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid TOMUVQNXYZP;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid XJMNCXXYSBX;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid KKCKUWQXCXJ;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid ADPKCWKKMNG;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid LZTKAPJNHNW;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid TXRJNBQASKU;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid ZFQAEAPJSYE;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid NTXFUOELZJR;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid ILIXLZSSFKA;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid EGSQOJCUCPH;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid CAKOLGKGCBU;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid BPLXDGMZDAR;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid MQHDIMHCKDC;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid VRNRGXVFSDZ;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid MUUNSXJRIPO;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid NUAKKFQXYID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid CZMUHNLPZMW;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid AIVIKPULAMX;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid DZEBPOFMTZX;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid LNDUCELPXUS;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid ACUBIAVIUQP;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid JVYASEIMNTM;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid CFDBQXPAPJZ;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid EMNTTBORVPZ;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid IGMVHMHMDKP;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid CERPLRTAIGR;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid NKBPZYEBIXC;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid YITLSLYJXQW;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid QMAXNKKSLWN;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid RUDFOYFTMDC;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid FADZAKCICTJ;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid GRNIVGGNMTT;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid MALVTEDHQHR;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid ZRVMAEHRGGN;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid HBRXNHONYCM;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid VGRVBKPOGPV;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid NMDIGLPLZDW;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid FXBZVBITFTC;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid IRTMFDDIMIN;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid UISCNFPCPJF;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid QDSZAOWOYAU;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid ENAPNDEYKRE;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid FVWKGUXVDWS;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid PDDYNAKRAUH;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid NQBBXQZCLOM;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid TIPEFKOGZQP;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid GETOLTQQIVZ;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid NTKNFBCUBOE;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid OCJRMAHLCVY;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid AEWXQVIEHIU;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid WTUKKGERPIP;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid HDYZJGIPVPU;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid ZQJUAGLKVMG;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid JNHQLDYJFGM;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid GWOLKKXUVFQ;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid SRLTGZETVWM;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid CBPQJPHEKDH;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid FPOUIGDQEVV;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid QNIJPDJOZYG;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid ESUSXLPPPUS;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid QNDCRWPRQMX;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid QMXVUPVUHBO;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid QMSOXJBWXQF;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid QMNIACHZOEW;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid QMIBCVOCETN;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid QMCUFOUEVIE;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid QLXNIIAHLWV;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid QLSGLBGKCLM;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid DWAVWJNSHLG;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid UMCMHGTNOYU;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid FRKFOCICCJP;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid OWLDZOHQQXL;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid WBIHPPCOMBD;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid KUEZLTQBTXV;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid CLXEEJJWXQK;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid KAEMZTLVNGO;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid GKWAANWMQTN;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid WPRDMSBEREF;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid IWMWXVIRHEA;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid GCAVLMASZXQ;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid YKKTCQIJTJY;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid VKORISJJZXH;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid BHMMWSSCPAY;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid QMGRLKPABUE;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid SSCBZUKXAIH;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid IPLIFYJEENN;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid RWUDOABBASR;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid YUPHOEYCUDP;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid MSIUNXETLCW;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid RUUPSHMMKWZ;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid RTUHFZQZPSG;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid LNREPQABMPS;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid RJOBSCBJFOR;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid UNXBNNNALSU;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid MGOVUBPSSGZ;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid YGLKFJZEYYR;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid SDUVPJZYLHA;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid TDGYSSBFZIG;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid TLKTMRDQBMI;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid RTJFHUAREJC;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid UFJYWEMUENS;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid FPOZQSEZUMF;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid LYTXWSPIYIQ;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid IELTFJSYZGM;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid VCUDFMQVWBT;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid BMCOXLNUYCI;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid JIFADSNITMB;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid XICNQNINEXS;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid ACQHOAAQDGE;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid QPLRRHINQSX;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid JCECACDDAOU;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid ESQGDMCVOXG;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid MACQRXSFMTW;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid QZTVSLCLEDI;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid GGSLNZUUJND;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid SJADJUHWFZP;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid CVPFZGYNWWF;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid TRNELBLQYPT;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid OZUCXRQARRP;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid FUWZGYEBUZZ;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid HBWYKJOXIYM;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid YYXFVIPNAML;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid KSPBUTLXAOR;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid IJDVFOGPQJK;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid SURWDPOWYWS;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid TRUIHOXTNVZ;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid EHRGKDSZZOI;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid LCQQOQAWKUB;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid VNLJXBLAIOS;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid NJVAGRIRLOO;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid TMOLQGLMQVY;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid DEOMBMBUNCG;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid BTCNEPPLAXG;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid VCUJQEVYZWX;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid ZFBBLQYWSFL;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid DQXMHHUVFGQ;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid LZXOYBKPSVJ;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid OUVFCRXILOM;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid YVFNRYNFOER;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid UQEOOHLPNZS;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid MKRMASKNCQR;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid KHMBESYDITA;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid CGOTVMRHZPV;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid UAYWXJRMTUH;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid UIXWVWBPOBW;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid GKVQOQQIOEC;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid XIYVCUUFPXC;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid BKNECIIOVYV;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid SISKZYULLBW;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid UIQHJRFXQFP;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid PLMWIEPTJDF;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid CYHERODYSPY;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid WCHRQQKSJPW;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid WCMYNXEPTBF;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid ZVMGZNGSIWJ;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid QOCKTTLHWQD;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid BIWYZYZREXG;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid GGBAKQKTFCG;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid DKQBIANQPJG;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid SNPYIXOIUEJ;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid HWBSZAEEBWM;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid SBDJVGZYBWJ;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid WALOUVPZXFC;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid YSKAAYVFAQG;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid EIQMJYTKNAL;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid IGZICQXENDK;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid DPMDWXEPXZI;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid IQIOXJDCEAO;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid HZGSVIGOTHZ;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid VXGXTEGJGMX;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid DLXZHQWYXDK;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid ACTODDGCGIK;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid PNNUPJSGAQR;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid XWTMPZBJNWN;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid ZHZJDZANDZU;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid BMYAKLHZTNS;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid MGJTEFTMYAM;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid KBAUURQFSVC;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid NDPJOPVBBTK;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid TWWNNRYHWOZ;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid ALTHJQQYEEN;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid NHYXVLFHRDA;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid CAIDVSHVZPZ;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid MSBAACYDGAH;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid GFXOCHYYPFM;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid SKXMZFIXQQH;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid AVIGTGTITBC;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid IOGQNVZWBAS;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid MJUEEWYZBTB;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid UUGQJBKEELH;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid TFTMMVPNNSN;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid EUUFZIRLQAB;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid QATGGXVCYLT;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid DMOTPTRPOIX;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid CWBDTBZLSMQ;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid BBYAUELCSNX;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid GCAPNVVXMRO;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid UVJSVLFMCUK;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid UAKZWJTWJMG;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid BSGFTUZFCZI;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid QFKDJSOLOBJ;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid EAKBBHXCJCK;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid HIHWTCNZVJP;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid MTDDLZVZIUH;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid MTIKJGPWSFQ;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid MTNRGNJUBQZ;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid HAQYGCRAPVK;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid TGABHEQUNTS;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid TGPVYYYMQBT;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid NISAOJEOZVP;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid CNHOQBQWAMZ;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid ZBBLCZFYJMN;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid BIJPTKGURGS;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid IPJUSSPEDJJ;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid ZPJXXLGNBVX;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid UYNHBYWFIXY;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid WHMAEOWPIDK;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid DQLGJWPWPGB;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid XRHNHBJRSGV;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid MXTQVLZPSKF;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid UIEZIPBGPHR;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid THIKTODKQXU;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid UIFCMEKYYYO;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid XOBSJOGMXIH;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid PJCUQGFEZSV;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid HEGJMMCDSEA;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid YDQDQFZGNDD;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid KKXQLHXGXPZ;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid GTGCCNYXNJP;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid YIUQXULRGKP;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid CMGKVJTTEJG;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid JDXEBKZMLAD;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid PDSEHQQXNVI;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid YWGMTGYLOLM;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid GIZDCTFOIRO;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid ZIMLSVXHEMF;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid VAYKRLKLAJB;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid AQYPICVMLXN;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid ZINXSJORWTR;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid DVAPJTYRKRL;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid KSBIONLNQYN;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid YRWJNDERVVT;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid PLWWHHVANNQ;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid OUBSVLIHXSH;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid XMCIXJSJNRL;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid IJGPHBPFGLU;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid YPIGEZPXNIV;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid EYIFYCGUBAN;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid ZJXSMOSGAFV;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid THLUYNAKPQZ;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid QIWVCFCTHGP;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid HFWLIGGDWRZ;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid RRPRLRQVNSK;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid DIDIQVBBTYJ;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid WINYJHQFQJJ;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid SVKTSOUQKHX;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid SEPVVZEIRYK;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid YYVWZRURYTC;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid LYDVDZSVELE;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid FHBWKDESBYT;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid ECZAPFYGDYI;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid BSGIQYJSMYL;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid SGIOAAPNPVK;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid LRMKHZGXDUD;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid ZYKRGUGVIBJ;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid XIISVGKMPPH;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid XUJSFUHKNXI;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid WPTYHUUNCWP;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid FHVCLSRYLMD;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid SAJBHMWNNGW;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid AVRTASJACPE;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid RBUJOOBETUZ;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid FULNQJTERUQ;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid ZDKGEOHMXQB;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid PAFLPIWFPXO;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid FMJDLZQBHYV;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid HLOLKOFIDYX;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid YGJLSXUAFSC;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid ZPSUBDUYKQC;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid NOIYHCOMURB;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid IOIDXWPQLJY;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid FVTJUTMJJUV;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid ALCEIBQRDNE;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid DQORAWYEOTJ;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid CWMAAKKBBDL;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid DOFQJNPAKWM;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid VBPLBQDFRTI;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid HMPWUCDAJDV;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly Dictionary<Guid, SpawnableToolType> LFBXVQLIOKX;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private static readonly Dictionary<SpawnableToolType, Guid> IGYADGGHFYL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> ZLBMXGXKEGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x845F510", Offset = "0x845DB10", VA = "0x18845F510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> DEXJUUCZYPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x845F560", Offset = "0x845DB60", VA = "0x18845F560")]
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
	public static class IYPPEIFTLHR
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x845F9C0", Offset = "0x845DFC0", VA = "0x18845F9C0")]
		public static bool YOXVQLUYKVD(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x845F5B0", Offset = "0x845DBB0", VA = "0x18845F5B0")]
		private static bool YOXVQLUYKVD(FQFDPGEIZCW a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface VBELKZXFZBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(LXCRBADIMON data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, YMQXKTMHYLH circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public readonly OIGOTMLEWKK Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public readonly IEnumerable<UMNTAHYOPJM> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public readonly IReadOnlyList<UMNTAHYOPJM> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public readonly Id32<YRJDGOUPWNL> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public readonly IReadOnlyList<Id128<BZFRCGZKOVF>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NYFYOMBJNCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x846E110", Offset = "0x846C710", VA = "0x18846E110")]
		public R1CreateTemplateParams(OIGOTMLEWKK circuits, IEnumerable<UMNTAHYOPJM> rootData, IReadOnlyList<UMNTAHYOPJM> allPersistableData, Id32<YRJDGOUPWNL> sourceGraphId, IReadOnlyList<Id128<BZFRCGZKOVF>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly OIGOTMLEWKK Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public readonly IReadOnlyList<UMNTAHYOPJM> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public readonly Id32<YRJDGOUPWNL> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public readonly IReadOnlyList<Id128<BZFRCGZKOVF>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x846E180", Offset = "0x846C780", VA = "0x18846E180")]
		public R2CreateTemplateParams(OIGOTMLEWKK circuits, Id32<YRJDGOUPWNL> sourceGraphId, IReadOnlyList<Id128<BZFRCGZKOVF>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<UMNTAHYOPJM> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class LVRKTOTQUSB : TUERVWEIBLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly Guid WCPYKGSNAMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<Guid, Guid> IJSTTSQZDUC;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4FC9E70", Offset = "0x4FC8470", VA = "0x184FC9E70")]
		private LVRKTOTQUSB(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x845FE80", Offset = "0x845E480", VA = "0x18845FE80")]
		public static LVRKTOTQUSB New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8460200", Offset = "0x845E800", VA = "0x188460200")]
		private static Dictionary<Guid, Guid> UBUGZDKUNLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x845FE00", Offset = "0x845E400", VA = "0x18845FE00")]
		public static LVRKTOTQUSB FXTXIUDIZVW(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x845FF10", Offset = "0x845E510", VA = "0x18845FF10")]
		public static LVRKTOTQUSB QODVZUFKVCR(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x845FE10", Offset = "0x845E410", VA = "0x18845FE10")]
		public Dictionary<Guid, Guid> GRAAHVDNYNX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
		public Dictionary<Guid, Guid> QMPLQTALVAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x845F9F0", Offset = "0x845DFF0", VA = "0x18845F9F0")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x845FA70", Offset = "0x845E070", VA = "0x18845FA70")]
		public void BMCDHAIDIIW(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84602B0", Offset = "0x845E8B0", VA = "0x1884602B0")]
		public Guid UUJXCMAHOJO([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x845FCF0", Offset = "0x845E2F0", VA = "0x18845FCF0")]
		public Guid FNOZEFBECYF([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x845FD90", Offset = "0x845E390", VA = "0x18845FD90")]
		public bool FWCRLXXRHPA([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x845FD90", Offset = "0x845E390", VA = "0x18845FD90", Slot = "4")]
		private bool XNGTNJMZBIK([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QCPMMFRZULH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XJMCBRFXEPE(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SYXGVCLBHKS(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JQESZZRGKLP
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
	public abstract class ZDSOHRNSANX : QCPMMFRZULH
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class YAHJUIUXZHA : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private string MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string FOLRAZEUJML
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public YAHJUIUXZHA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8471F70", Offset = "0x8470570", VA = "0x188471F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8472030", Offset = "0x8470630", VA = "0x188472030", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8471EE0", Offset = "0x84704E0", VA = "0x188471EE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> IWXTODGYYKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8471EE0", Offset = "0x84704E0", VA = "0x188471EE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private Dictionary<string, HashSet<Guid>>? MFGIXHLDPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		protected Dictionary<string, string>? TNPRWVVBUIT;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> XOCIWVYQXDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8472070", Offset = "0x8470670", VA = "0x188472070")]
			[IteratorStateMachine(typeof(YAHJUIUXZHA))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? CTFWRFMSXFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool TOWUGXPDCUL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool FDSCNHHDSZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> RUDQLHDHLRD(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool XVKCTIFSPCL(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8472240", Offset = "0x8470840", VA = "0x188472240")]
		public void RKABTJLTQWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1091A50", Offset = "0x1090050", VA = "0x181091A50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8472740", Offset = "0x8470D40", VA = "0x188472740", Slot = "4")]
		public bool XJMCBRFXEPE(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8472670", Offset = "0x8470C70", VA = "0x188472670", Slot = "5")]
		public bool SYXGVCLBHKS(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84729F0", Offset = "0x8470FF0", VA = "0x1884729F0")]
		private bool YZSAANGJDDE(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84720D0", Offset = "0x84706D0", VA = "0x1884720D0")]
		protected List<Guid> IVXNYYNAQMT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected ZDSOHRNSANX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class NKRVZGKLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NEFENOBNJAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			public OIGOTMLEWKK VUFXXDVFMTQ;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NEFENOBNJAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8478B00", Offset = "0x8477100", VA = "0x188478B00")]
			internal Id32<KOCDTBIOGSC> FWMLHHNKGOI((Id32<YRJDGOUPWNL> GraphId, Id32<BZFRCGZKOVF> NodeId) i)
			{
				return default(Id32<KOCDTBIOGSC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private const int KRBVOOSTFUC = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly Dictionary<Id32<KOCDTBIOGSC>, AVQMEGHCBKE> LXPKYRNHXOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private long RXCWSESBXRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private long XCVOOGZJNEF;

		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private static readonly ReadOnlyIdArray<KOCDTBIOGSC, int?> THKDXXGBWKI;

		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private static readonly long QLAESMTUHEG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long ANGFUGSGUYE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8460980", Offset = "0x845EF80", VA = "0x188460980")]
		public static NKRVZGKLJFD SLPTHEVUNZO(OIGOTMLEWKK a, Id128<YRJDGOUPWNL> b, [Optional] NKRVZGKLJFD c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84604C0", Offset = "0x845EAC0", VA = "0x1884604C0")]
		public static (long, long) PRFAKXAZDRM(OIGOTMLEWKK a, Id32<YRJDGOUPWNL> b, Id32<BZFRCGZKOVF> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8460860", Offset = "0x845EE60", VA = "0x188460860")]
		public static long SJZPJZJMXCJ([In] ReadOnlySpan<Id32<KOCDTBIOGSC>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8460EB0", Offset = "0x845F4B0", VA = "0x188460EB0")]
		private static long UVBNWJGFTWO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x846E010", Offset = "0x846C610", VA = "0x18846E010")]
		public NKRVZGKLJFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class AVQMEGHCBKE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long AVDRTHZIYSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xE58D40", Offset = "0xE57340", VA = "0x180E58D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEF40", Offset = "0x7FDD540", VA = "0x187FDEF40")]
		public AVQMEGHCBKE(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class OVVYFANUURS
	{
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public static readonly HashSet<SpawnableToolType> JSPUKVPLBIX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RVNBOTOHMUR
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class JZSPGDNXLXW : IEnumerable<UMNTAHYOPJM>, IEnumerable, IEnumerator<UMNTAHYOPJM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private UMNTAHYOPJM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private SpawnableTemplateData NCTQGUNKRUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public SpawnableTemplateData GSQSWMYVTGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private SpawnTemplateParams JMVEHYVBEKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public SpawnTemplateParams TQDWRAQPWYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private int HAOYDNHAFWO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private UMNTAHYOPJM RNPGCCVXELP
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public JZSPGDNXLXW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8475C50", Offset = "0x8474250", VA = "0x188475C50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8475D60", Offset = "0x8474360", VA = "0x188475D60", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8475AF0", Offset = "0x84740F0", VA = "0x188475AF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<UMNTAHYOPJM> RMMFZAKCZWW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8475AF0", Offset = "0x84740F0", VA = "0x188475AF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x847F7E0", Offset = "0x847DDE0", VA = "0x18847F7E0")]
		public static SpawnableTemplateData QCTQLQLQJVA([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x847F650", Offset = "0x847DC50", VA = "0x18847F650")]
		public static SpawnableTemplateData QCTQLQLQJVA([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x847E6D0", Offset = "0x847CCD0", VA = "0x18847E6D0")]
		private static HashSet<Id128<XHEPRZIYYMD>> LBBZOCPZXIE(IReadOnlyList<UMNTAHYOPJM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x847EA70", Offset = "0x847D070", VA = "0x18847EA70")]
		private static void NHQRLAIJUPP(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x847F960", Offset = "0x847DF60", VA = "0x18847F960")]
		public static Result<LVRKTOTQUSB, TryCloneTemplateError> VDZRYHUVFPW(SpawnableTemplateData a, SpawnTemplateParams b, LVRKTOTQUSB? srcRemapper, bool c)
		{
			return default(Result<LVRKTOTQUSB, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8481500", Offset = "0x847FB00", VA = "0x188481500")]
		[IteratorStateMachine(typeof(JZSPGDNXLXW))]
		private static IEnumerable<UMNTAHYOPJM> XSGJKBGDGEF(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8480FE0", Offset = "0x847F5E0", VA = "0x188480FE0")]
		private static void WLDSPTDLHRA(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x847E050", Offset = "0x847C650", VA = "0x18847E050")]
		private static bool KVVRJKYCGKZ(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x847F0D0", Offset = "0x847D6D0", VA = "0x18847F0D0")]
		private static Dictionary<Guid, FQFDPGEIZCW> NKRYIAQJDEZ(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8480F50", Offset = "0x847F550", VA = "0x188480F50")]
		private static void WBCOARSKBVN(bool a, UMNTAHYOPJM b, LVRKTOTQUSB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x847F3C0", Offset = "0x847D9C0", VA = "0x18847F3C0")]
		private static void QBJZQROUKJR(UMNTAHYOPJM a, Guid b, SpawnTransformData? c, Dictionary<Guid, FQFDPGEIZCW> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8481050", Offset = "0x847F650", VA = "0x188481050")]
		private static void XPXUHCBOPAW(IEnumerable<UMNTAHYOPJM> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public OIGOTMLEWKK circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public JQESZZRGKLP roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public VBELKZXFZBF circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public Id128<YRJDGOUPWNL> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public MHPSHNFTXZN globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public List<UMNTAHYOPJM> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JMXSYSOFGTD photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 YKOKDFUYNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8482490", Offset = "0x8480A90", VA = "0x188482490")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS NUFTOZRRLKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8481E30", Offset = "0x8480430", VA = "0x188481E30")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1703390", Offset = "0x1701990", VA = "0x181703390")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8482590", Offset = "0x8480B90", VA = "0x188482590")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8481E70", Offset = "0x8480470", VA = "0x188481E70")]
		public static SpawnTransformData KYSTFUHYKCN(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8482660", Offset = "0x8480C60", VA = "0x188482660")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8482680", Offset = "0x8480C80", VA = "0x188482680")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8482400", Offset = "0x8480A00", VA = "0x188482400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84821F0", Offset = "0x84807F0", VA = "0x1884821F0")]
		public SpawnTransformData PYXQDIKABUV(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8482180", Offset = "0x8480780", VA = "0x188482180")]
		public static SpawnTransformData OOYVLRPRFJV(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84820F0", Offset = "0x84806F0", VA = "0x1884820F0")]
		public readonly CircuitsRigidTransform LVLOEVICGXZ()
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
		private readonly OYBEQJHIRPM _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19C4AC0", Offset = "0x19C30C0", VA = "0x1819C4AC0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, OYBEQJHIRPM innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8482B20", Offset = "0x8481120", VA = "0x188482B20")]
		public MIWOMKTZBCT DFXQSOGMQUE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8482C40", Offset = "0x8481240", VA = "0x188482C40")]
		public static Result<LVRKTOTQUSB, TryCloneTemplateError> New(ZGUYUKLWOWW<None> innerError)
		{
			return default(Result<LVRKTOTQUSB, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8482B90", Offset = "0x8481190", VA = "0x188482B90")]
		public static Result<LVRKTOTQUSB, TryCloneTemplateError> New(MIWOMKTZBCT innerError)
		{
			return default(Result<LVRKTOTQUSB, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8482CF0", Offset = "0x84812F0", VA = "0x188482CF0")]
		public static Result<LVRKTOTQUSB, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<LVRKTOTQUSB, TryCloneTemplateError>);
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
	public class LWTBHBJXKHY : IDisposable, TGTFRFYHYCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private NativeList<CurvePointData> VYIESAZJBZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private float PMOKSMDMFQJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags IYREEORWVFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DSWCOMDJNGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x84786F0", Offset = "0x8476CF0", VA = "0x1884786F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QMCXKPNDNRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8476970", Offset = "0x8474F70", VA = "0x188476970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> AGVGLQWWTOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int GJESTOHYQDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8478700", Offset = "0x8476D00", VA = "0x188478700", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MCOSFVIDKRM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8477EA0", Offset = "0x84764A0", VA = "0x188477EA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8478740", Offset = "0x8476D40", VA = "0x188478740")]
		public LWTBHBJXKHY(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8476110", Offset = "0x8474710", VA = "0x188476110", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84781C0", Offset = "0x84767C0", VA = "0x1884781C0")]
		public Vector3 VNRPOEHLKZV(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8477FE0", Offset = "0x84765E0", VA = "0x188477FE0", Slot = "6")]
		public Quaternion SNWEFGIPWCU(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8477500", Offset = "0x8475B00", VA = "0x188477500", Slot = "5")]
		public Vector3 JKZRWOXSAVT(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8477CE0", Offset = "0x84762E0", VA = "0x188477CE0", Slot = "7")]
		public float NTAREGFYHJS(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8476AD0", Offset = "0x84750D0", VA = "0x188476AD0")]
		public void FORBPBSBJHY(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8478690", Offset = "0x8476C90", VA = "0x188478690")]
		private bool WDUVNQFWEEW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8475DA0", Offset = "0x84743A0", VA = "0x188475DA0")]
		public void CGIUTBKHNZM(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8477C50", Offset = "0x8476250", VA = "0x188477C50")]
		public void NFREQTIESQZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84773B0", Offset = "0x84759B0", VA = "0x1884773B0")]
		public void FZLTMQNDJME(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8475F60", Offset = "0x8474560", VA = "0x188475F60")]
		public void DGUGLDDAKOQ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8476980", Offset = "0x8474F80", VA = "0x188476980")]
		public void FKRGWLSDTDA(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8477D40", Offset = "0x8476340", VA = "0x188477D40")]
		public void QHLEGKLCXHH(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8476170", Offset = "0x8474770", VA = "0x188476170")]
		public static Quaternion EACBUTJSRXR(Quaternion a, int b, float c, TGTFRFYHYCD d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84775A0", Offset = "0x8475BA0", VA = "0x1884775A0")]
		public Bounds JOPWZZMKCMZ(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8475F00", Offset = "0x8474500", VA = "0x188475F00", Slot = "10")]
		public virtual void CZYCSXJCPZB(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8478110", Offset = "0x8476710", VA = "0x188478110")]
		public NativeList<CurvePointData> TVVYLGWIDSZ(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x8473080", Offset = "0x8471680", VA = "0x188473080")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8472FC0", Offset = "0x84715C0", VA = "0x188472FC0")]
		public Quaternion XLSLVZYQJFM(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8472CD0", Offset = "0x84712D0", VA = "0x188472CD0")]
		public CurvePoint BZHTJAVMZUO(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8472B30", Offset = "0x8471130", VA = "0x188472B30")]
		public UGBHLQQAKEJ BRRUZBIMRRG(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class GSMGZDTDURZ : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8474210", Offset = "0x8472810", VA = "0x188474210", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8474290", Offset = "0x8472890", VA = "0x188474290")]
		private void QFYIFKZDISG(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8474860", Offset = "0x8472E60", VA = "0x188474860")]
		private void QFYIFKZDISG(Dictionary<Guid, Guid> a, GXYWQOKEOMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84748C0", Offset = "0x8472EC0", VA = "0x1884748C0")]
		private void QFYIFKZDISG(Dictionary<Guid, Guid> a, ZGAKASVMDNY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public GSMGZDTDURZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class MTDLGDAMGLA : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84788C0", Offset = "0x8476EC0", VA = "0x1884788C0", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public MTDLGDAMGLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class ORKVPZENEWT : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8478BD0", Offset = "0x84771D0", VA = "0x188478BD0", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ORKVPZENEWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class PUAPXYZDLJJ : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8478F40", Offset = "0x8477540", VA = "0x188478F40", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PUAPXYZDLJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class VNHAVNPUNXP : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8484160", Offset = "0x8482760", VA = "0x188484160", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VNHAVNPUNXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class QTBVCTFHXLE : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x847DF10", Offset = "0x847C510", VA = "0x18847DF10", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public QTBVCTFHXLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class TWDQIUBIOJU : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8482990", Offset = "0x8480F90", VA = "0x188482990", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public TWDQIUBIOJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class JOFTBMAWEAR : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8475680", Offset = "0x8473C80", VA = "0x188475680", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public JOFTBMAWEAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class PWPIHFZGDVN : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84790A0", Offset = "0x84776A0", VA = "0x1884790A0", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PWPIHFZGDVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class ZXYKUFJVRHB : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84844A0", Offset = "0x8482AA0", VA = "0x1884844A0", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZXYKUFJVRHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class MOQEBWLLFOZ : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84787C0", Offset = "0x8476DC0", VA = "0x1884787C0", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public MOQEBWLLFOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class ZPSAZPKDDBG : FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public static readonly PXEOKTLTGPA HDAVWWNBRJZ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8484380", Offset = "0x8482980", VA = "0x188484380", Slot = "4")]
		public void OETEDUJKMDP(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZPSAZPKDDBG()
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
		public JMXSYSOFGTD photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface FGZCXZKJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OETEDUJKMDP(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class EHFCPQOZTSB
	{
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly FGZCXZKJBEI[] SPEJPXBTKZF;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8473600", Offset = "0x8471C00", VA = "0x188473600")]
		public static void WCGXVUQYFKK(UMNTAHYOPJM a, LVRKTOTQUSB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8473100", Offset = "0x8471700", VA = "0x188473100")]
		public static void FDWBVKUHQUU(UMNTAHYOPJM? data, LVRKTOTQUSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8473390", Offset = "0x8471990", VA = "0x188473390")]
		public static void NSTSZDUEMQK(UMNTAHYOPJM? data, LVRKTOTQUSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8473880", Offset = "0x8471E80", VA = "0x188473880")]
		public static void YOXVQLUYKVD(PersistableCloneParams a)
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
		public UMNTAHYOPJM viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8479250", Offset = "0x8477850", VA = "0x188479250")]
		public Guid NSDTXVREQRZ(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface JMXSYSOFGTD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private static readonly HashSet<Guid> YBZDAKKUDKI;

		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private static readonly HashSet<Guid> AACCRGLJQNY;

		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly HashSet<Guid> DZYTKXQYGQE;

		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private static readonly ProfilerMarker DGHOPSDFPUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private readonly HashSet<string> GOYFSBCXEYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private readonly Dictionary<long, int> HQBYROYDIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private readonly HashSet<Guid> CXQZXNNYAPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private readonly HashSet<Guid> JUKRQALTGYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private readonly HashSet<Guid> HLWKZILNOUS;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> WBCDZYIMUIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> OTFILNHPVMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> FBCHWTAHYCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> WHMOHLFIROG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8479B40", Offset = "0x8478140", VA = "0x188479B40")]
		public static void DMSIZNPYTXI(SpawnableTemplateData a, JSCJRQBGZIO b, LVRKTOTQUSB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x847B030", Offset = "0x8479630", VA = "0x18847B030")]
		public static PersistedRoomDataReferences EHUWZSYXLVA(PersistedRoomData a, JSCJRQBGZIO? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x847D830", Offset = "0x847BE30", VA = "0x18847D830")]
		public static PersistedRoomDataReferences YNCBAVLXNFD(SpawnableTemplateData a, JSCJRQBGZIO? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x847D530", Offset = "0x847BB30", VA = "0x18847D530")]
		public static PersistedRoomDataReferences VVWJHXKIQQZ(QYYXSVXZQGV a, ZHTHSYSXTAP b, JSCJRQBGZIO? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x847B840", Offset = "0x8479E40", VA = "0x18847B840")]
		public static PersistedRoomDataReferences NSGMIKAAIEG(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x847DDB0", Offset = "0x847C3B0", VA = "0x18847DDB0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x847DBE0", Offset = "0x847C1E0", VA = "0x18847DBE0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x847CC00", Offset = "0x847B200", VA = "0x18847CC00")]
		private void NTPDBTFCFJV(PersistedRoomData a, JSCJRQBGZIO? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x847BFA0", Offset = "0x847A5A0", VA = "0x18847BFA0")]
		private void NTPDBTFCFJV(SpawnableTemplateData a, JSCJRQBGZIO? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x847B120", Offset = "0x8479720", VA = "0x18847B120")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x847C230", Offset = "0x847A830", VA = "0x18847C230")]
		private void NTPDBTFCFJV(QYYXSVXZQGV? a, JSCJRQBGZIO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x847D2A0", Offset = "0x847B8A0", VA = "0x18847D2A0")]
		private void NTPDBTFCFJV(ZHTHSYSXTAP? a, JSCJRQBGZIO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x847BDC0", Offset = "0x847A3C0", VA = "0x18847BDC0")]
		private void NTPDBTFCFJV(SAXMKXJYVOH? a, JSCJRQBGZIO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x84792F0", Offset = "0x84778F0", VA = "0x1884792F0")]
		private static bool DHHRIOJHNPK(SAXMKXJYVOH a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x847D5F0", Offset = "0x847BBF0", VA = "0x18847D5F0")]
		private static bool XOJQWAMKIQU(SAXMKXJYVOH a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x847AF60", Offset = "0x8479560", VA = "0x18847AF60")]
		private static void DMSIZNPYTXI(ZHTHSYSXTAP? root, JSCJRQBGZIO a, LVRKTOTQUSB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x847A960", Offset = "0x8478F60", VA = "0x18847A960")]
		private static void DMSIZNPYTXI(SAXMKXJYVOH? customProperties, JSCJRQBGZIO a, LVRKTOTQUSB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x847ABF0", Offset = "0x84791F0", VA = "0x18847ABF0")]
		private static void DMSIZNPYTXI(QYYXSVXZQGV? root, JSCJRQBGZIO a, LVRKTOTQUSB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x84794F0", Offset = "0x8477AF0", VA = "0x1884794F0")]
		private static void DMSIZNPYTXI(CircuitsV2.Protobuf.CircuitNodeData? node, JSCJRQBGZIO a, LVRKTOTQUSB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x847BA40", Offset = "0x847A040", VA = "0x18847BA40")]
		private void NTPDBTFCFJV(CircuitsV2.Protobuf.CircuitNodeData? a, JSCJRQBGZIO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x847D320", Offset = "0x847B920", VA = "0x18847D320")]
		private void VKHEXNSMSTF(Guid? a, JSCJRQBGZIO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x847CEA0", Offset = "0x847B4A0", VA = "0x18847CEA0")]
		private void NTPDBTFCFJV(UMNTAHYOPJM? a, JSCJRQBGZIO? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x847A520", Offset = "0x8478B20", VA = "0x18847A520")]
		private static void DMSIZNPYTXI(UMNTAHYOPJM? viewData, JSCJRQBGZIO a, LVRKTOTQUSB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x847B0B0", Offset = "0x84796B0", VA = "0x18847B0B0")]
		private void EJTXCUIVTWW(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x847B710", Offset = "0x8479D10", VA = "0x18847B710")]
		private void LPBIZVTBIIW(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x847B6C0", Offset = "0x8479CC0", VA = "0x18847B6C0")]
		private void LPBIZVTBIIW(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x847B7E0", Offset = "0x8479DE0", VA = "0x18847B7E0")]
		private void LPBIZVTBIIW(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class HJBPKBRTTTL : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private readonly IEnumerator<DictionaryEntry> OEQLNSSVJVE;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x8474CC0", Offset = "0x84732C0", VA = "0x188474CC0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x8474D80", Offset = "0x8473380", VA = "0x188474D80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x8474E30", Offset = "0x8473430", VA = "0x188474E30", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x8474BE0", Offset = "0x84731E0", VA = "0x188474BE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
			public HJBPKBRTTTL(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8474B40", Offset = "0x8473140", VA = "0x188474B40", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8474B90", Offset = "0x8473190", VA = "0x188474B90", Slot = "9")]
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
			private sealed class MUNKOUOTMFF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000585")]
				private int AEMBTWPORMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000586")]
				private DictionaryEntry MVWPOXUKILF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000587")]
				public RoomObjectCounts CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry CSYHZYTUCJF
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object HLWKSVCMTHU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8478970", Offset = "0x8476F70", VA = "0x188478970", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
				[DebuggerHidden]
				public MUNKOUOTMFF(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
				[DebuggerHidden]
				private void CJOOGEZDZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x84789C0", Offset = "0x8476FC0", VA = "0x1884789C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x8478AC0", Offset = "0x84770C0", VA = "0x188478AC0", Slot = "8")]
				[DebuggerHidden]
				private void VIZWRAVZEQM()
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
			private ICollection ZKIGBLWUXPN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x8481720", Offset = "0x847FD20", VA = "0x188481720", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x8481A70", Offset = "0x8480070", VA = "0x188481A70", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x8481B50", Offset = "0x8480150", VA = "0x188481B50", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool JIEDTKRUTXU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x84817F0", Offset = "0x847FDF0", VA = "0x1884817F0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool UKWJQAJNOBP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x8481A20", Offset = "0x8480020", VA = "0x188481A20", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection BEZPGOKFFPD
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8481930", Offset = "0x847FF30", VA = "0x188481930", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int ZVEQDOZLJZA
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8481610", Offset = "0x847FC10", VA = "0x188481610", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool TLDXZMSOVOF
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x84819D0", Offset = "0x847FFD0", VA = "0x1884819D0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object YRXWROBWUGU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x8481CB0", Offset = "0x84802B0", VA = "0x188481CB0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x84816B0", Offset = "0x847FCB0", VA = "0x1884816B0")]
			[IteratorStateMachine(typeof(MUNKOUOTMFF))]
			private IEnumerator<DictionaryEntry> ENGQWJBWIKS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8481840", Offset = "0x847FE40", VA = "0x188481840", Slot = "19")]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8481BE0", Offset = "0x84801E0", VA = "0x188481BE0", Slot = "13")]
			private IDictionaryEnumerator VRPVZJOIODV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8481980", Offset = "0x847FF80", VA = "0x188481980", Slot = "9")]
			private void PAGCVNIKQUC(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x84817A0", Offset = "0x847FDA0", VA = "0x1884817A0", Slot = "10")]
			private void KNVWLIGJCMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x84818E0", Offset = "0x847FEE0", VA = "0x1884818E0", Slot = "8")]
			private bool OEUSVAQKFJI(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8481660", Offset = "0x847FC60", VA = "0x188481660", Slot = "14")]
			private void DNBXIWDNYKH(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8481B90", Offset = "0x8480190", VA = "0x188481B90", Slot = "15")]
			private void TFNWQZZYQLV(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class TSWYXXZYKWJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				private int AEMBTWPORMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058C")]
				private DictionaryEntry MVWPOXUKILF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400058D")]
				public Invention CDTALOACOKM;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry CSYHZYTUCJF
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object HLWKSVCMTHU
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x84827E0", Offset = "0x8480DE0", VA = "0x1884827E0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
				[DebuggerHidden]
				public TSWYXXZYKWJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
				[DebuggerHidden]
				private void CJOOGEZDZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x8482830", Offset = "0x8480E30", VA = "0x188482830", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8482950", Offset = "0x8480F50", VA = "0x188482950", Slot = "8")]
				[DebuggerHidden]
				private void VIZWRAVZEQM()
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
			private ICollection ZKIGBLWUXPN
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x8474FE0", Offset = "0x84735E0", VA = "0x188474FE0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x84752F0", Offset = "0x84738F0", VA = "0x1884752F0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8475400", Offset = "0x8473A00", VA = "0x188475400", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool JIEDTKRUTXU
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x8475080", Offset = "0x8473680", VA = "0x188475080", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool UKWJQAJNOBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x84752A0", Offset = "0x84738A0", VA = "0x1884752A0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection BEZPGOKFFPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x84751B0", Offset = "0x84737B0", VA = "0x1884751B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int ZVEQDOZLJZA
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x8474EE0", Offset = "0x84734E0", VA = "0x188474EE0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool TLDXZMSOVOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x8475250", Offset = "0x8473850", VA = "0x188475250", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object YRXWROBWUGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8475560", Offset = "0x8473B60", VA = "0x188475560", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2AEE0E0", Offset = "0x2AEC6E0", VA = "0x182AEE0E0")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8474F80", Offset = "0x8473580", VA = "0x188474F80")]
			[IteratorStateMachine(typeof(TSWYXXZYKWJ))]
			private IEnumerator<DictionaryEntry> ENGQWJBWIKS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x84750D0", Offset = "0x84736D0", VA = "0x1884750D0", Slot = "19")]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8475490", Offset = "0x8473A90", VA = "0x188475490", Slot = "13")]
			private IDictionaryEnumerator VRPVZJOIODV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8475200", Offset = "0x8473800", VA = "0x188475200", Slot = "9")]
			private void PAGCVNIKQUC(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8475030", Offset = "0x8473630", VA = "0x188475030", Slot = "10")]
			private void KNVWLIGJCMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8475160", Offset = "0x8473760", VA = "0x188475160", Slot = "8")]
			private bool OEUSVAQKFJI(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8474F30", Offset = "0x8473530", VA = "0x188474F30", Slot = "14")]
			private void DNBXIWDNYKH(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8475440", Offset = "0x8473A40", VA = "0x188475440", Slot = "15")]
			private void TFNWQZZYQLV(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8482FA0", Offset = "0x84815A0", VA = "0x188482FA0")]
		public static UgcRoomSaveStatsDetailed EHUWZSYXLVA(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8483FE0", Offset = "0x84825E0", VA = "0x188483FE0")]
		[CompilerGenerated]
		internal static int LKWZUPTNABS([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8483950", Offset = "0x8481F50", VA = "0x188483950")]
		[CompilerGenerated]
		internal static void EWSASMDMWPG(int a, [In] QYYXSVXZQGV graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class JSCJRQBGZIO
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public readonly Guid OELHPZIFRSO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public readonly IReadOnlyList<Guid> OTFILNHPVMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public readonly UnitySubAssetKind CXTXOPLXEQC;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8484100", Offset = "0x8482700", VA = "0x188484100")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private readonly LVRKTOTQUSB RISERBAAJIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private readonly Dictionary<Guid, UnitySubAsset> GXOTKIWATGJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public LVRKTOTQUSB LSYGPRCFBVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8475770", Offset = "0x8473D70", VA = "0x188475770")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8475970", Offset = "0x8473F70", VA = "0x188475970")]
		public bool XVPMKBUAUFJ(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8475A60", Offset = "0x8474060", VA = "0x188475A60")]
		public JSCJRQBGZIO()
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
