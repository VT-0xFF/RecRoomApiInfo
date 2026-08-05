using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x894F450", Offset = "0x894E050", VA = "0x18894F450")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class WAEMVZJCBVU
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LWGQHQEBXYM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> WEBYQWDSMGG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DRCYTYXWJDM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> TOAFTZJJJQL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string MSDZGTPLYQV;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string RBHOWZEGYAI;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string SKZAGHJKOUV;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x895E310", Offset = "0x895CF10", VA = "0x18895E310")]
	public static bool HAZYHQMSQMI(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x895E410", Offset = "0x895D010", VA = "0x18895E410")]
	public static bool NQTLKVAWNTG(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x895DC40", Offset = "0x895C840", VA = "0x18895DC40")]
	public static string BACRKKEDBBF(Guid a)
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
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
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
		[Cpp2IlInjected.Address(RVA = "0x894E780", Offset = "0x894D380", VA = "0x18894E780", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JBRQWRMOWVB
	{
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public static readonly Guid IQVQSAYXTDO;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public static readonly Guid XMYBYPOJRTG;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public static readonly Guid PWYAFWXQDWG;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public static readonly Guid IUSOTMHDEMO;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public static readonly Guid JRDROFVCVHD;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public static readonly Guid AWBJMUGYMSJ;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public static readonly Guid RFCYNFRNCNE;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static readonly Guid ARYBGLKKJFV;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static readonly Guid QDHAUVURXRH;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid NPRFKDUTCJT;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid BDCJREBUWZE;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid HGWNOIARLOJ;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid TFBPFVHXHKK;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid NHFCRXCKHHT;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid ZILYWWXTKWC;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid LAMOOVRACQT;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid HYZRURUPMBZ;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid SGDJTPFIDZQ;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid WVQCSOFMXKL;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid YFXHYIFJFIU;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid CLPXXDALNWU;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid NURXCXYVTVQ;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid CWAYXGSUSMA;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid TADPEMFVIJM;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid BNRXLYQBGQI;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid UAKNSNHUEFP;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid VVLRCCRJOZS;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid PDEOMHXZBJT;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid YRCSTZQOASN;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid OJXBXGKLIES;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid VOLLGAVTQAU;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid BMKBZOCPZBT;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid ZDKVPGRRVDC;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid HTEEMTNCFGH;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid CMZXLXHORWB;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid SHLRNVGLOTT;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid MIWHUXOWKYT;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid ALKWXGBBBEF;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid GTBIOIQNDAT;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid EBFDCQRQHEZ;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid WNPNKTSAUOR;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid IOPPTTXEFOT;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid KSLKFBMOZUW;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid RGPASXDILBR;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid ACRMESVEIQY;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid ZNKXBPLMHCI;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid CXWXZJZBRZG;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid UJSJDPDMHLZ;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid BYYLPCRCROK;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid HZRVXUXLVUX;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid KCVIAVHKBVT;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid GSCFPKAHAXE;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid GPTGYGEZWKW;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid ZQXMYWIQTAC;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid BSAIBBTDHCL;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid LEZDGEZQAQP;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid SUAZWPUVXQU;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid BXBMACKBRNY;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid HYFSGUYHWMP;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid NCMEHSFFWUC;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid SUSCJUAJULT;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid RNAIZUNUSLT;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid AAGKCWJEKUK;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid ZYVZZWKNBNX;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid GGGISOGPIQN;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid WICMXFQIEJE;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid JVILYLRBJZY;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid CSJNADUHGHH;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid DNLLMESYYCM;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid MLPDRXQKLRR;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid DWPBFETICQK;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid OOGFVTBSSAR;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid ZBGRECEZDTJ;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid IYYJJIAUQZQ;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid DSGFQILUGVK;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid UYSBNWUKCXK;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid JCNMPUKVXVI;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid VGTVSPGXSFE;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid EAAFJNQWJIL;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid AZEPIUZMLPE;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid WWTGDQOWVHB;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid XWYSHXRTFTQ;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid XTVEEVAPFQX;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid JFDCXBTAROF;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid RFWVYWEZXDN;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid QGDWEJUBEEE;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid WWGYTRZLNQZ;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid QKWYSWOEVUL;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid FZMYDHKSGZI;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid ETFQKBRLNMO;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid ZNERKADPCIV;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid BXDICTLCRVJ;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid DWXZCJRRVQZ;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid NRUWBSKWKCJ;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid ZYGFLJGMTTL;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid HTMXTGMMUGM;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid EIGMCKUKBRR;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid JTHXJDEILBJ;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid KHWCNECZLUM;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid CYHGKNIMXCH;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid DECCAXBSLHQ;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid SYIPITYOYML;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid DDROGJNXSKY;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid GKOPUNPXRAB;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid WDKXCETPVPH;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid QEGGIMZNMDU;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid EORLOLJIOXX;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid UENOUFLDBZI;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid EOGXTXVNWBF;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid OQTGQMDRQNW;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid EPMNDMKYARH;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid NVSSGRIVOMK;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid MQAWVDLXGTK;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid DUYDJQIJKUF;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid ADQFLITKATT;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid KCWNYZWCWAI;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid DMYYTULGRDV;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid ZAKHIGBDBEH;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid UYYJUJCPSYM;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid JOMVRNKFBPV;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid MVEYHVFGMJJ;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid ZPSSOAOLQFP;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid VCPYGOLJABL;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid PMTNWBNXUSF;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid NJOWEJOFDCJ;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid LYPCGXAQWMZ;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid YFHQJJNLQWG;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid BVDAQVTOXDX;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid VRTRVKNGOIR;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid UWOMNAVFTDL;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid UVEQUEBGXBW;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid HSCFLAUIHHB;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid KXWJYZSJYLC;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid TIXPGQLEMJI;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid WPZVKAKKUAF;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid QSHGPWSFCQL;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid DYHDFVKCHDO;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid UDTKGMHSZXU;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid INSMBRBUUGP;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid LRLONHPWCUR;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid GTKUBYSLDVW;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid GGOGDZRYKXU;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid JHMTQOWETBE;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid BHYSLXELKKU;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid FXXELJVNYYB;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid HUMLKOASHCJ;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid HTWQSTTAEUI;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid HUBXQAMXOFR;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid HVCGCIIKJKK;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid HVHMZPCHSVT;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid HURSHUUPQNS;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid HUWZFBOMZZB;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid EJCUSGHPVVJ;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid OWKOGWSKGNB;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid NSLXBWBLZQC;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid BGPVHFZPSBQ;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid YVLEWPLDGAN;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid SWYTXBYENZW;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid OURBIANZEGO;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid FYJFOWTSLTQ;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid UUNNQPWURMN;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid PCBIJLOCUSH;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid JDJEXRHNJKE;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid LWUHKJJAUQT;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid DZJTSGDOTJY;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid TOWOIJEESCS;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid UDZTTANMOLZ;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid KTPVGWMFTZY;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid TORHLCKHIRJ;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid TOMANVQJZGA;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid TPWWUQZRNHL;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid EQBLNVPVPUE;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid KNXSDGEZJIB;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid HSNMDRGCIJO;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid EQRGFPXNSCF;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid PNBOQSEXVYO;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid CQRGXVPPKNN;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid SDIKZPHFGOH;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid NKEJLVQYRZE;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid KPBWILSAVZG;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid WSQTNFJSCBE;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid TGRLYWDMORG;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid TZMJGGZTMZA;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid RYGWLIMQRND;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid GOSUJHLCQXS;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid FVHLJCZSOBB;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid RHHYMCWPVFF;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid JJJDLLEMNPR;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid XXVAPKWWIVZ;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid XMFDWAVCMZY;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid XZDOSIWTRZM;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid RTZTECCTXXP;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid PXXQKREKKGR;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid UFZOXHMYFDK;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid TGJYJCFOJTV;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid WMPOJAJIEFN;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid DQJRLCVDWTM;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid MWXXECECLTZ;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid IKDMSWXYVSU;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid QPEVYGMLMPI;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid ZZFPPCUSRWP;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid BKKXYCTQIKU;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid RQOEYIBFEWL;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid ZRSAWFSLMEL;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid NIUAAYYXRIN;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid VKTJQOYKLAU;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid SQPEYVHECDV;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid TQXITZBHFBV;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid CPXFSSNOJUU;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid KEVELAWYNJC;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid LMBYZDCXPKT;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid IGZSAHDFFOC;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid MPDAKVGQTUX;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid QLHCRQXPUPO;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid NXLQWFSPEFU;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid UMSKQXSMFKA;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid TREOQYKJGKK;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid KYYLNVHMZXV;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid ZCTJESOKJXX;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid WWENPIJHRNQ;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid VTMKJPZQWKZ;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid RZXJGUNAIPY;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid TVZAWHVJPAQ;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid JVCXNWYSFFU;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid MKSIWBIOXYJ;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid UQOVRQIUZUJ;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid WWIKMTUAPTW;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid CJHXOBRCZNX;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid WAVKJDCKLJS;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid BUPGYJIPHKP;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid BOIVDSPBVAJ;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid ZZXGPFZPHNF;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid ZLFOGXCAGKF;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid WCFZQIXJMIV;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid CQVNUBKOILX;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid ZWJRBXYILPK;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid TVATGIWCNEF;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid QGASZHTTEPH;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid IMUIAXSASGC;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid HWMIXIBQJBR;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid VYWNWWXUIWK;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid NSDUZTHSXGC;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid ECFQMTEJVHM;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid KTTNCHQEIDP;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid ACSQEPOESTU;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid ICCJFBAIFST;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid DNBRSXTXWGD;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid IIWCWWAXFPK;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid GODHJEQZEMF;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid PXKPCPRGSCD;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid HRTGBHFMUOV;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid UBDWJRQRLJL;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid PRSBGXIZNFB;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid KEXPBDYCNHR;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid RXJLDIURYRW;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid UUEEODVUTVG;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid SMIQEYSOIRX;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid HGSSTDKOFUU;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid SYJYAYUTLRJ;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid DRYEALMDVIZ;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid XUHICSQLWRU;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid SSOUGWCFTAD;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid MZODIXRWHWD;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid YNQCBGFBAIT;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid ZCEIOZREFVV;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid KVTTGKXQYSJ;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid DGJYDYMZPLP;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid AVJJZRMBFBB;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid FFNPUFSRKDU;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid NPYKIGKOWIA;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid ZTQQTJNJFHR;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid HMUPULBXTFS;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid QHVMUSGUVSF;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid AYJGVGMQGIP;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid YANTTOACWQI;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid RIREUADQAFZ;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid OWTRRHEQVTH;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid NQJPEDQKGLL;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid VQZDCLEFZNC;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid QZTODTEXVXI;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid RYHGTWQZVSY;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid TBQLIAGPKKR;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid HIMDHIZSDMR;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid BJONCGWJAML;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid CCYITLXQYWB;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid WHBIKGONTVM;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid FCJVVZRVGBQ;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid FKKFSLXWWHA;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid BWOFOSFOGMX;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid KUWDQOKEITJ;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid YWTOUDGVGAI;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid SGNORSQBKCO;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid ZFCPGGPDDQN;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid UQNUYMHRRYR;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid AFLIBIXJFXK;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid UYRHDTTNYNT;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid CDOPVOSYHGV;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid ZZNCJAUAOPR;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid WHFBDPWWJWR;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid VEJTFIPEZHW;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid PEEYYJCARAM;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid MEVUCNXZALQ;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid VWNDVOMJKPF;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid HRMWDVOPXYW;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid VGTIEIFAUZY;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid AJOZOHEQLPI;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid WLGTLBGVPHM;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid YZYTBRBBZIB;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid CRFGYWQKQIF;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid ALXCFNWKDDL;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid JPMWZVUXTLP;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid MDSDMFESBSD;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid MZQTEAMBLFL;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid AJSWOIRFPRU;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid GGWGRIEGVWW;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid SMQECFBSSIT;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid PSTNOASVEDO;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid GMWWILLVROM;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid JZFOZBQTCHS;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid AKRGFQHIKAD;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid YOMXUMPWYBR;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid BDGAIALABIO;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid WBQWMDJJCYU;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid LBDSSHLUYNA;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid XJFERJYUVJO;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid XVMBJOZELKP;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid TAYQIRPYVXT;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid XUZWCMGPOBW;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid OBNUCSXEDNS;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid MTRADSWKIYS;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid IIDOONXDUVK;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid KXIELYDYOQR;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid TERLIFSYBUJ;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid NJSLDKFSWRH;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid LCFBRXTLPPK;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid YQHZMVLMSUG;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid BDKCHLLDXGH;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid QCCXLNZSVWX;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid RZGVVYMYMPO;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid JFSCXSCWIWI;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid XHQULYJPYDD;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid ILZYHYQDLTQ;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid SDIJWDRWMYS;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid KTUWQRFYVSJ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid FKCOCAEZZCW;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid QPWKLNCNBRS;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid KBTYOPKQZPV;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid BIKXDPVUVKC;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid GFIZBOWSGEZ;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid MENPPQJPSJS;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid DGHISJSAHCQ;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid FGNEZMWWVAS;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid CJKZUNMUTAY;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid GKCOMMOXJHP;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid PHONCOINDQF;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid FVGIBPKZJPE;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid NGEMZUDZFSB;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid MJTQHVYMKVB;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid BABJDEQIYCX;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid PETSMJONCBK;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid UIKJVCYNYNR;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid SKJDDWWPUAE;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid CREXOBQSFQA;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid MSMJQOAZWBY;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid KXBZPQHJYPJ;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid HSOOPOLARYV;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid KZXKUEDNSMT;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid GPUTBCNNEVX;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid YCUOZADXAZM;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid JEMOENXZTFR;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid BIFCKEWWYHK;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid UTYMPHPOOTF;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid NGAQVPHLNOM;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid JGJEEPRLIJT;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid YJIISHDJNVM;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid DMBJUSTDWZJ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid FIYMOQIXKWA;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid DAXUJPXAOMX;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid KAWRYSURDTE;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid VALZRCJVSDS;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid NPHZWNYHZEZ;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid DKFNVUHMUUS;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid ZXJNSRARPBR;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid DKHWGBWEHEI;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid IAOREYQGWIG;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid IIISHQLFOZU;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid ZGHGZSSXSCU;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid ELGOOUSWIQV;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid AVDBMWHTWJR;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid ISWATHXVQQS;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid YTLAOFVPMFF;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid ZWBHLMDABMG;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid WPXQPPGAYRK;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid MMISLPORFLE;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid URESMRNHYKE;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid UKJSBBPSPMD;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid QMYEQYUEDLS;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid CMPAARWCRPX;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid NHKNAIQBZAB;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid ZHPKXPPUEDI;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid BJTMQZQWVNI;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid ZYGWOERPWJB;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid RJDYMRNMHEZ;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid HSBBJYMCWFL;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid RDNFWPZYUGI;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid QZPNFMKPKJN;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid JMGKIRMWGIM;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid HABPFZVNRJI;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid PYKDWWFRVRB;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid NQUHDXYFZVL;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid HMBSNIMGRGJ;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid QNQNHCHIMPA;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid RHLNVHFADOT;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid MXZEPZPDSPN;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid GCXSYQWBOGJ;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid LPVREKETMBN;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid ZRPXXVPOIIL;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid PISACMOUZVS;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid RYTBFTTPHDO;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid ZFOULMCTJTP;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid LFCVFBZZUTV;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid ZEYZTRVBHLO;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid ZFEGQYOYQWX;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid ZGEPDGKLMBQ;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid ZGJWANEIVMZ;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid ZFUBISWQTEY;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid ZFZIFZQOCQH;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid ZGZQSHMAXVA;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid ZHEXPOFYHGJ;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid RYHNHHBQPCL;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid KXZRSQOEUFX;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid YCBMVARXCAM;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid WHHKZIZYLFK;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid FFKSBSQPAEU;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid ORYNUEVFDBG;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid FOBWHRMSMXT;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid GYUGHHMWEQN;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid BTWLSPRVNII;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid ZEVXMPHZKNA;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid QKAWVQFLFIL;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid FKLMHSJGWMD;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid PUHIHTNROTR;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid GSCJMTFUAKM;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid LKHPNNHLSLV;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid WCSKURQIXDD;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid TCTVEZXNBMA;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid UPRFNVSNQTS;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid RBOHEGFHYYS;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid UIYXGZYMBLO;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid GNARRBONNHH;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid SLTYWVEBGNE;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid SMUHJCZOBRX;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid BPMNRTGNGZT;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid YDFEJPSVWKK;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid PXGVNGRYRAJ;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid IXBTRTFRUAM;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid YJFDTCCUOMK;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid PAKXXEPTKAJ;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid XLWAJBLQKJZ;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid IJXUXYDMCCF;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid XNJUJTCZSHP;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid TOPEIPFZMLB;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid HKTVIFQZNBC;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid APSWBZDDCLD;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid LCQDCLSYHZR;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid QHQDBZFIHME;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid DSLZIBYLJQV;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid IJACUXCNJHQ;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid ROZOOUOPLGV;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid XJHAQWHNBOB;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid KETKSMVDZZU;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid IPGPJYDAQYB;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid WIILBYZUEID;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid ZVZRBCRYAUT;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid PRRGSMGMSHF;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid VCMVNXFMGGW;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid ZSAEQZGXNUK;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid FVTSMXPZPUK;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid GLDSQAMQHWG;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid ZIMBFPDZYXW;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid WBKJDGZNMWM;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid VUCUPKNLVXD;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid LFMAAFSRYAS;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid ZJICSPKFDSS;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid JFEISQUCELH;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid IOGBUPJKDST;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid GWDPWATIDYI;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid HKXDIUOVWUB;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid YVBKNAUSIWA;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid MSOJPRKNYMB;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid NCUXGWCEUKN;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid RDNVLWZAYZZ;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid SODVBTSBDCD;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid FRMWGFLORJB;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid KPWSHVMKXUM;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid FJPRCTTALGK;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid XLLZDGARBIF;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid UQRKWIIBIFU;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid NTAKOYMQGGN;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid ENGRUKCIFMG;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid PRDBVJHPMHJ;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid MYBWZEGVLGG;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid HTAGZEBVQXD;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid OJBJLKREWZW;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid MAEYOEBGEVG;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid TVWJUDODZWD;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid TRQAPADTZCB;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid HVQYFMUWVZG;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid HERMTBOBGHZ;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid QLTZRJILUYE;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid SNSRCJVUNNM;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid KGUKOSXJFNT;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid JAVFBZBSJGD;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid JAPYESHUZUU;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid XNVWLDTRACG;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid WEYELDYPDJW;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid PEENRBVKKHB;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid WIOYTPNLKWD;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid DBDXWTHKUZN;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid HSRCSVVEDXI;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid LFLOULILIRX;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid JSDLZHQEQWS;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid HPXAJKXWFGX;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid SAYVIPUQABX;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid BFJLHHYZQSK;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid DIJPVRVAQXB;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid FXPESTQXZVN;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid IEVXZJOUZLN;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid YNOEMXWAHRI;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid VSZXKPLHYRU;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid RXNEICNNOGH;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid UVQVGXIJLBJ;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid FISKRMTUACU;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid MJZJHDTMGWK;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid JEIZFXVGOAZ;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid SNWZOBWLAOP;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid SZPRZTPTKWR;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid WBDUIHJEVOT;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid GQCSIJAYYAR;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid LZWPLOINPXY;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid HGEOZTFFLXM;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid FCGHPEFIBAP;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid NMUDHBPGFTS;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid FSNTNDBUSYH;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid ZQOICBLSIMS;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid NTZFQAIUOKF;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid XDVKNFGHWLF;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid SYMPBRKXTVO;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid VERIRAVGJSO;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid XFACCMOSUXK;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid ATEYWBIBIFA;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid IYDDFKSOLNA;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid GVHAYFHYFRA;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid RQRREYERXGX;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid TDDXFKRFVBM;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid WRFRGWZNLSL;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid CGGCOUTFBPV;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid MAPTHFTTNLP;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid AJSBUJKLZMR;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid BOINSOSEJOK;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid IXRBPKSTUET;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid VKSUROPHKPI;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid ZIPECZNSHOE;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid ZJEYUTVKJWF;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid ZIZRXNBNAKW;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid OIUYPODETKP;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid FKDGQJLTPHF;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid FKINNQFQYSO;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid NWGAVLSEXUU;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid LJNNLFIEPXY;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid RCPPHCMPMDK;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid PWZGAXHRXCJ;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid WDFKAXTFUMI;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid OYKUVNKHDWG;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid PUHVCXRICSH;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid STYUMTYVUKD;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid AASGOQIHFKK;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid GTBMCVDCMXG;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid QUYFRSNSDPI;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid DVUTDXTJMAU;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid NHVRCHIIVBD;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid SUWFVMXORWP;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid ZYOUHDCXROK;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid NQSHPQWHTWU;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid VTZNQNLDTRT;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid RYABXUPPNVO;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid NUORENFLSUM;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid KXBOUKEPKFI;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid TUINOMEYUDA;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid QLOPJZUPAUN;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid GHVWVKKABYY;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid GXWQSTZWYXF;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid TIVJUDVFHBL;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid LBXGRBNPRJV;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid LBGTYJJLSHA;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid VRUSFLSKVAG;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid EGWFPYOJZJK;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid WQYSREDXYGS;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid MLEJYHJJLSW;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid QAMCWNUMDUY;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid CKXXJRIGGSM;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid RGRFHVWOHEN;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid FCIYOFUYDKS;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid SZELPRLRESG;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid FHJNQFAUNAD;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid XAVKTJRSVGE;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid SUOQSIZWLEE;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid TJDOHBAZOZA;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid BZVERDBCLMW;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid CYMWOAOGKXK;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid XOGOHWRCXRM;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid WFSSSKNFISP;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid FBNDKLQTBNI;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid ETZWPQUSMWK;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid UGIAJYJFDPU;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid LIVYJFZNLBZ;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid BHUDHFKYZZH;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid XOQSVPDLITN;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid VNXHPSVNIEY;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid YVCGTKGJYXN;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid BFUYRRUXPXK;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid DJFINBNHLSJ;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid PZWOJIDNVRE;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid RKSIXWWBLJY;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid VXUNEDYSMFG;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid RDBXDPWXKIF;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid SYHPWBWQOUY;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid KWALXRXCSAC;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid OMXUTRRTNOP;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid LXLCMHWIXOP;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid QYXUSVGWYES;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid BFGZSDEDJYL;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid NPDOTQEWGWQ;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid MUWRBRPYIBJ;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid SERPVZPFYXS;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid EVDCSVJTENK;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid BHKYKSIPDGP;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid BCENRJGCOLP;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid HULEGYCOWEA;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid QGLXPRZPBTP;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid GATBTSOJPSW;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid ZQNLSLYFZJR;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid BERXNSBYWAO;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid PZEZDZUMHDO;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid MIYHJNIGRFF;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid HNCEOWFXMJJ;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid UNZUPRVNNFC;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private static readonly Dictionary<Guid, SpawnableToolType> UAWCHTUHTAA;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private static readonly Dictionary<SpawnableToolType, Guid> NLZMERBXNQM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> QBHRFDXNDBF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x894D8D0", Offset = "0x894C4D0", VA = "0x18894D8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> TNTBXCPPXYT
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x894D870", Offset = "0x894C470", VA = "0x18894D870")]
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
	public static class JNYMOGYMFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x894D930", Offset = "0x894C530", VA = "0x18894D930")]
		public static bool WYDRASXHPOG(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x894D960", Offset = "0x894C560", VA = "0x18894D960")]
		private static bool WYDRASXHPOG(ZJWUIFZIEUJ a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface XSQOUPKVEZO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(EDQNQCZBFSM data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, EZQXCOHVNNS circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public readonly YHTFDKLWCND Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public readonly IEnumerable<ABLNPBVPOUZ> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public readonly IReadOnlyList<ABLNPBVPOUZ> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public readonly Id32<JQPVMRMCZNG> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public readonly IReadOnlyList<Id128<LWYTCPIHOQE>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RKTKYYAYETO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x894F4D0", Offset = "0x894E0D0", VA = "0x18894F4D0")]
		public R1CreateTemplateParams(YHTFDKLWCND circuits, IEnumerable<ABLNPBVPOUZ> rootData, IReadOnlyList<ABLNPBVPOUZ> allPersistableData, Id32<JQPVMRMCZNG> sourceGraphId, IReadOnlyList<Id128<LWYTCPIHOQE>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public readonly YHTFDKLWCND Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public readonly IReadOnlyList<ABLNPBVPOUZ> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public readonly Id32<JQPVMRMCZNG> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public readonly IReadOnlyList<Id128<LWYTCPIHOQE>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x894F540", Offset = "0x894E140", VA = "0x18894F540")]
		public R2CreateTemplateParams(YHTFDKLWCND circuits, Id32<JQPVMRMCZNG> sourceGraphId, IReadOnlyList<Id128<LWYTCPIHOQE>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<ABLNPBVPOUZ> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KTGVHRCVUQA : NBTHPRXTAVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly Guid LYOLLVGPIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private readonly Dictionary<Guid, Guid> CJFZWMEGUHL;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x540D2B0", Offset = "0x540BEB0", VA = "0x18540D2B0")]
		private KTGVHRCVUQA(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x894DFC0", Offset = "0x894CBC0", VA = "0x18894DFC0")]
		public static KTGVHRCVUQA New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x894E3B0", Offset = "0x894CFB0", VA = "0x18894E3B0")]
		private static Dictionary<Guid, Guid> TQKGWLSWUCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x894DD70", Offset = "0x894C970", VA = "0x18894DD70")]
		public static KTGVHRCVUQA AICOHWLJSIF(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x894E0C0", Offset = "0x894CCC0", VA = "0x18894E0C0")]
		public static KTGVHRCVUQA RYUWGXWWFNQ(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x894DE00", Offset = "0x894CA00", VA = "0x18894DE00")]
		public Dictionary<Guid, Guid> GQWMUBQKXPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
		public Dictionary<Guid, Guid> OMFAQPCDENE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x894DD80", Offset = "0x894C980", VA = "0x18894DD80")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x894E460", Offset = "0x894D060", VA = "0x18894E460")]
		public void XMYLLZOVIJN(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x894DE70", Offset = "0x894CA70", VA = "0x18894DE70")]
		public Guid KGLCLNTQLXJ([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x894E6E0", Offset = "0x894D2E0", VA = "0x18894E6E0")]
		public Guid XXSKQLWQTVI([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x894E050", Offset = "0x894CC50", VA = "0x18894E050")]
		public bool OIVDPKBMJFN([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x894E050", Offset = "0x894CC50", VA = "0x18894E050", Slot = "4")]
		private bool WUXPNGWLHJD([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface XFMNBNHDEVO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BPWJNVWSYBJ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DJWLYJNEDXR(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JMZQIDAEFDG
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
	public abstract class NQUOMCEAHVY : XFMNBNHDEVO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <InitializeRoleAllowListAsync>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public NQUOMCEAHVY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private Dictionary<string, HashSet<Guid>> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private string <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private TaskAwaiter<List<Guid>?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x895D230", Offset = "0x895BE30", VA = "0x18895D230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x895D910", Offset = "0x895C510", VA = "0x18895D910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class DRYBEAOETWD : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private string DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string DMWONALYXSM
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public DRYBEAOETWD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x894D6E0", Offset = "0x894C2E0", VA = "0x18894D6E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x894D7A0", Offset = "0x894C3A0", VA = "0x18894D7A0", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x894D7E0", Offset = "0x894C3E0", VA = "0x18894D7E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> YDQXJDTSKET()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x894D7E0", Offset = "0x894C3E0", VA = "0x18894D7E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private Dictionary<string, HashSet<Guid>>? GGCAODVBHQZ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> NNBYEOGAYPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x894F1C0", Offset = "0x894DDC0", VA = "0x18894F1C0")]
			[IteratorStateMachine(typeof(DRYBEAOETWD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? QGKTAACAIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool OQRWTJIAYBA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool NSWORRKSGVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task<List<Guid>> MAFWMOKBPGE(string a);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x894F220", Offset = "0x894DE20", VA = "0x18894F220")]
		[AsyncStateMachine(typeof(<InitializeRoleAllowListAsync>d__13))]
		public Task LRJCCLNTWMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x13F4D60", Offset = "0x13F3960", VA = "0x1813F4D60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x894E840", Offset = "0x894D440", VA = "0x18894E840", Slot = "4")]
		public bool BPWJNVWSYBJ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x894EDC0", Offset = "0x894D9C0", VA = "0x18894EDC0", Slot = "5")]
		public bool DJWLYJNEDXR(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x894F300", Offset = "0x894DF00", VA = "0x18894F300")]
		private bool WWNAFZEPQYN(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected NQUOMCEAHVY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class SHWGHHGHUUW
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			public YHTFDKLWCND PFACUQXCNNN;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8967E60", Offset = "0x8966A60", VA = "0x188967E60")]
			internal Id32<TFITIOWUSRJ> JLFLCFSEASB((Id32<JQPVMRMCZNG> GraphId, Id32<LWYTCPIHOQE> NodeId) i)
			{
				return default(Id32<TFITIOWUSRJ>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private readonly Dictionary<Id32<TFITIOWUSRJ>, ZLUMFMJSSTN> JWQKUCOONCE;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly ReadOnlyIdArray<TFITIOWUSRJ, int?> LMOTBDXBIQV;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly long FEXUZWNZLVF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyDictionary<Id32<TFITIOWUSRJ>, ZLUMFMJSSTN> QUOKQGGHSPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x894FB60", Offset = "0x894E760", VA = "0x18894FB60")]
		public static SHWGHHGHUUW HWOCBOFJPAL(YHTFDKLWCND a, Id128<JQPVMRMCZNG> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x894F6E0", Offset = "0x894E2E0", VA = "0x18894F6E0")]
		public static (long, long) DLOEDTLURVJ(YHTFDKLWCND a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x894F5B0", Offset = "0x894E1B0", VA = "0x18894F5B0")]
		public static long CQKXIVFYOWU([In] ReadOnlySpan<Id32<TFITIOWUSRJ>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8950040", Offset = "0x894EC40", VA = "0x188950040")]
		private static long LKCAARZBBDT()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x895D1B0", Offset = "0x895BDB0", VA = "0x18895D1B0")]
		public SHWGHHGHUUW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class ZLUMFMJSSTN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long PGMCRKQODOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xE6CC90", Offset = "0xE6B890", VA = "0x180E6CC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long ERNBYZNVJRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8973090", Offset = "0x8971C90", VA = "0x188973090")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84E00F0", Offset = "0x84DECF0", VA = "0x1884E00F0")]
		public ZLUMFMJSSTN(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class TMTBLQBIGRZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public static readonly HashSet<SpawnableToolType> QKMFVWZXZCS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class SYBPNBIPAQI
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NIVIYFQPRJJ : IEnumerable<ABLNPBVPOUZ>, IEnumerable, IEnumerator<ABLNPBVPOUZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private ABLNPBVPOUZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private SpawnableTemplateData DFANXJPAAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public SpawnableTemplateData WJWAMJUKTBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private SpawnTemplateParams YOSGFZHFFRY;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public SpawnTemplateParams CGQMYCFMUAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private int NAMOISTICOB;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private ABLNPBVPOUZ QNLZVFFLZZW
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public NIVIYFQPRJJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8967BB0", Offset = "0x89667B0", VA = "0x188967BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8967E20", Offset = "0x8966A20", VA = "0x188967E20", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8967CC0", Offset = "0x89668C0", VA = "0x188967CC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ABLNPBVPOUZ> NNLTRMQXXRN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8967CC0", Offset = "0x89668C0", VA = "0x188967CC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x896FAA0", Offset = "0x896E6A0", VA = "0x18896FAA0")]
		public static SpawnableTemplateData ZDDOARFFSPN([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x896FC30", Offset = "0x896E830", VA = "0x18896FC30")]
		public static SpawnableTemplateData ZDDOARFFSPN([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x896D480", Offset = "0x896C080", VA = "0x18896D480")]
		private static HashSet<Id128<CRFUMRQJTMA>> BZURDFFJQPX(IReadOnlyList<ABLNPBVPOUZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x896D820", Offset = "0x896C420", VA = "0x18896D820")]
		private static void FHFHBVXXHJQ(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x896E590", Offset = "0x896D190", VA = "0x18896E590")]
		public static Result<KTGVHRCVUQA, TryCloneTemplateError> TryCloneTemplate(SpawnableTemplateData spawnableTemplateData, SpawnTemplateParams spawnParams, KTGVHRCVUQA? srcRemapper, bool objectModelEnabled)
		{
			return default(Result<KTGVHRCVUQA, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x896E480", Offset = "0x896D080", VA = "0x18896E480")]
		[IteratorStateMachine(typeof(NIVIYFQPRJJ))]
		private static IEnumerable<ABLNPBVPOUZ> SEPVLKRJVPE(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x896E410", Offset = "0x896D010", VA = "0x18896E410")]
		private static void OSUYJEODGHH(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x896FDC0", Offset = "0x896E9C0", VA = "0x18896FDC0")]
		private static bool ZWAFOLDRTUU(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x896DE90", Offset = "0x896CA90", VA = "0x18896DE90")]
		private static Dictionary<Guid, ZJWUIFZIEUJ> KMYANGQAEMA(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x896CF40", Offset = "0x896BB40", VA = "0x18896CF40")]
		private static void BDTWPMZWCXY(bool a, ABLNPBVPOUZ b, KTGVHRCVUQA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x896E180", Offset = "0x896CD80", VA = "0x18896E180")]
		private static void LEJRRQIVUIK(ABLNPBVPOUZ a, Guid b, SpawnTransformData? c, Dictionary<Guid, ZJWUIFZIEUJ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x896CFD0", Offset = "0x896BBD0", VA = "0x18896CFD0")]
		private static void BTMCOZZFJXZ(IEnumerable<ABLNPBVPOUZ> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public YHTFDKLWCND circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public JMZQIDAEFDG roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public XSQOUPKVEZO circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public Id128<JQPVMRMCZNG> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public CMFLWIUZKZI globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public List<ABLNPBVPOUZ> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public TUWEZKGHCUY photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Matrix4x4 FWBEJGDGJCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x89706D0", Offset = "0x896F2D0", VA = "0x1889706D0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UniformTRS WHKDMSSVXXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8970870", Offset = "0x896F470", VA = "0x188970870")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x177DED0", Offset = "0x177CAD0", VA = "0x18177DED0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8970BC0", Offset = "0x896F7C0", VA = "0x188970BC0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8970940", Offset = "0x896F540", VA = "0x188970940")]
		public static SpawnTransformData YQTZTUWHLII(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8970C90", Offset = "0x896F890", VA = "0x188970C90")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8970CB0", Offset = "0x896F8B0", VA = "0x188970CB0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89707E0", Offset = "0x896F3E0", VA = "0x1889707E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89704C0", Offset = "0x896F0C0", VA = "0x1889704C0")]
		public SpawnTransformData OXCUKWZKECS(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8970450", Offset = "0x896F050", VA = "0x188970450")]
		public static SpawnTransformData OVZRGXAXFCK(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89708B0", Offset = "0x896F4B0", VA = "0x1889708B0")]
		public readonly CircuitsRigidTransform UJVJWNVJLLU()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private readonly GOLLTPPMOJR _innerError;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xF7DA70", Offset = "0xF7C670", VA = "0x180F7DA70")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, GOLLTPPMOJR innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8971240", Offset = "0x896FE40", VA = "0x188971240")]
		public VOMTLWUOHYQ WJCWPBYWZRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8971190", Offset = "0x896FD90", VA = "0x188971190")]
		public static Result<KTGVHRCVUQA, TryCloneTemplateError> New(XSGERBWOHRP<None> innerError)
		{
			return default(Result<KTGVHRCVUQA, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89710E0", Offset = "0x896FCE0", VA = "0x1889710E0")]
		public static Result<KTGVHRCVUQA, TryCloneTemplateError> New(VOMTLWUOHYQ innerError)
		{
			return default(Result<KTGVHRCVUQA, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8971020", Offset = "0x896FC20", VA = "0x188971020")]
		public static Result<KTGVHRCVUQA, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<KTGVHRCVUQA, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class NGNIEJVVRFT : IDisposable, SDMOUKEGRAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private NativeList<CurvePointData> GREMNZIRWGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private float JEFMODXSRSU;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ShapeConfigFlags LIHRVPAOUGS
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HEXIQCTUCXV
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8965D30", Offset = "0x8964930", VA = "0x188965D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DYETBOMUALO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8966740", Offset = "0x8965340", VA = "0x188966740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public List<CurvePoint> GOAIBHAIKXL
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int INVDILKLFRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8966C20", Offset = "0x8965820", VA = "0x188966C20", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float YWDCLKFWJWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x89679F0", Offset = "0x89665F0", VA = "0x1889679F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8967B30", Offset = "0x8966730", VA = "0x188967B30")]
		public NGNIEJVVRFT(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8965340", Offset = "0x8963F40", VA = "0x188965340", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8966750", Offset = "0x8965350", VA = "0x188966750")]
		public Vector3 QDXTRSSZHFS(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8965C00", Offset = "0x8964800", VA = "0x188965C00", Slot = "6")]
		public Quaternion JXIUGQAENFL(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8967070", Offset = "0x8965C70", VA = "0x188967070", Slot = "5")]
		public Vector3 YPOVISFBIKA(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8966EC0", Offset = "0x8965AC0", VA = "0x188966EC0", Slot = "7")]
		public float XEJNJVOHHYZ(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8967110", Offset = "0x8965D10", VA = "0x188967110")]
		public void YSUTODXHAJJ(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89652E0", Offset = "0x8963EE0", VA = "0x1889652E0")]
		private bool CQGWCFKRUZV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89665E0", Offset = "0x89651E0", VA = "0x1889665E0")]
		public void OQGZARKRVUR(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8966550", Offset = "0x8965150", VA = "0x188966550")]
		public void MTDQLYBGXGQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8966C60", Offset = "0x8965860", VA = "0x188966C60")]
		public void SKPQSYFPUOV(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89653A0", Offset = "0x8963FA0", VA = "0x1889653A0")]
		public void FMUXEHMJXYB(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8966F20", Offset = "0x8965B20", VA = "0x188966F20")]
		public void XHWRKAAMTBB(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8965180", Offset = "0x8963D80", VA = "0x188965180")]
		public void BQAIZNBEYUS(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8965D40", Offset = "0x8964940", VA = "0x188965D40")]
		public static Quaternion KOFFINPEXKM(Quaternion a, int b, float c, SDMOUKEGRAI d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8965550", Offset = "0x8964150", VA = "0x188965550")]
		public Bounds INUEJGUAJBC(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8966E60", Offset = "0x8965A60", VA = "0x188966E60", Slot = "10")]
		public virtual void VXVKZVGZHQM(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8966DB0", Offset = "0x89659B0", VA = "0x188966DB0")]
		public NativeList<CurvePointData> VEBLWCQFJBG(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8962570", Offset = "0x8961170", VA = "0x188962570")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8962020", Offset = "0x8960C20", VA = "0x188962020")]
		public Quaternion IUQKCKODGSF(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8962280", Offset = "0x8960E80", VA = "0x188962280")]
		public CurvePoint WRGBHDOXTDX(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89620E0", Offset = "0x8960CE0", VA = "0x1889620E0")]
		public ZPRJUYVXSJO LNWMFUPPOWJ(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class JZGJKJJTMVA : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x89643D0", Offset = "0x8962FD0", VA = "0x1889643D0", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x89644B0", Offset = "0x89630B0", VA = "0x1889644B0")]
		private void UWCKNRZMCBH(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8964450", Offset = "0x8963050", VA = "0x188964450")]
		private void UWCKNRZMCBH(Dictionary<Guid, Guid> a, BHPHGVTGAIS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8964A90", Offset = "0x8963690", VA = "0x188964A90")]
		private void UWCKNRZMCBH(Dictionary<Guid, Guid> a, EJZSFYPOMYX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public JZGJKJJTMVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class ZYOZROAONCX : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89730A0", Offset = "0x8971CA0", VA = "0x1889730A0", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ZYOZROAONCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class VAOHVOKSOQA : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8972B90", Offset = "0x8971790", VA = "0x188972B90", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public VAOHVOKSOQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class RSYIUWVLGHM : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x896C5A0", Offset = "0x896B1A0", VA = "0x18896C5A0", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RSYIUWVLGHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HCDHUZVRAAI : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8963850", Offset = "0x8962450", VA = "0x188963850", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public HCDHUZVRAAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class DJZMCRGCSIR : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89625F0", Offset = "0x89611F0", VA = "0x1889625F0", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public DJZMCRGCSIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UJGMPHHYNPZ : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8971650", Offset = "0x8970250", VA = "0x188971650", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UJGMPHHYNPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class LAGULOGWLMI : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8964D10", Offset = "0x8963910", VA = "0x188964D10", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LAGULOGWLMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class IBQXRWDJNJM : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8963A70", Offset = "0x8962670", VA = "0x188963A70", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IBQXRWDJNJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class CIFLFOWCNYO : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8961E60", Offset = "0x8960A60", VA = "0x188961E60", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CIFLFOWCNYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class UDTYVAYROVU : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8971550", Offset = "0x8970150", VA = "0x188971550", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UDTYVAYROVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class BUQTMXVBPYV : MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public static readonly NNRESWLNOLJ NBPCMHCMMQC;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8961D30", Offset = "0x8960930", VA = "0x188961D30", Slot = "4")]
		public void MCNFMPCTSWI(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public BUQTMXVBPYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public TUWEZKGHCUY photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface MYIOPGUYNWF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MCNFMPCTSWI(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class HAUGLONSLNU
	{
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private static readonly MYIOPGUYNWF[] FCJRTJRVTWS;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x89629A0", Offset = "0x89615A0", VA = "0x1889629A0")]
		public static void UNCATXFZABF(ABLNPBVPOUZ a, KTGVHRCVUQA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8962FF0", Offset = "0x8961BF0", VA = "0x188962FF0")]
		public static void ZLWZYZINFGH(ABLNPBVPOUZ? data, KTGVHRCVUQA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8962730", Offset = "0x8961330", VA = "0x188962730")]
		public static void GUHSWFTHSVH(ABLNPBVPOUZ? data, KTGVHRCVUQA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8962C20", Offset = "0x8961820", VA = "0x188962C20")]
		public static void WYDRASXHPOG(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public ABLNPBVPOUZ viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8967F30", Offset = "0x8966B30", VA = "0x188967F30")]
		public Guid HRPADJNTXKA(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface TUWEZKGHCUY
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private static readonly HashSet<Guid> KWGDZHTQNDN;

		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly ProfilerMarker ZMKMQGUCCSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private readonly HashSet<string> MGNOSQSJZAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private readonly Dictionary<long, int> IWKHJJZXCPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private readonly HashSet<Guid> YMSSQKQDZLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private readonly HashSet<Guid> LNBYMVPIUML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private readonly HashSet<Guid> CJEEJFSGRER;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<string> WIVPQLJXNBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> RYYUFHYKJCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyCollection<Guid> STPWVONRVKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IReadOnlyDictionary<long, int> NWQHDXNVFYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x89697E0", Offset = "0x89683E0", VA = "0x1889697E0")]
		public static void GDHQWZXJLFH(SpawnableTemplateData a, LJMQZKNEKLZ b, KTGVHRCVUQA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x896A670", Offset = "0x8969270", VA = "0x18896A670")]
		public static PersistedRoomDataReferences ODWJDMFNTUV(PersistedRoomData a, LJMQZKNEKLZ? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x896A580", Offset = "0x8969180", VA = "0x18896A580")]
		public static PersistedRoomDataReferences KJOYNZNQPLA(SpawnableTemplateData a, LJMQZKNEKLZ? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x896A4C0", Offset = "0x89690C0", VA = "0x18896A4C0")]
		public static PersistedRoomDataReferences KAAUGDJEZTO(IOKTUYUAJJS a, FXXOVHLAVLG b, LJMQZKNEKLZ? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8967FE0", Offset = "0x8966BE0", VA = "0x188967FE0")]
		public static PersistedRoomDataReferences AVVGPIGRURX(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x896C2B0", Offset = "0x896AEB0", VA = "0x18896C2B0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x896C0E0", Offset = "0x896ACE0", VA = "0x18896C0E0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x896BC20", Offset = "0x896A820", VA = "0x18896BC20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void VTPDRASJUDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x896AB90", Offset = "0x8969790", VA = "0x18896AB90")]
		private void PESZXNIWZQU(PersistedRoomData a, LJMQZKNEKLZ? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x896B740", Offset = "0x896A340", VA = "0x18896B740")]
		private void PESZXNIWZQU(SpawnableTemplateData a, LJMQZKNEKLZ? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x89681E0", Offset = "0x8966DE0", VA = "0x1889681E0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x896B240", Offset = "0x8969E40", VA = "0x18896B240")]
		private void PESZXNIWZQU(IOKTUYUAJJS? a, LJMQZKNEKLZ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x896B6C0", Offset = "0x896A2C0", VA = "0x18896B6C0")]
		private void PESZXNIWZQU(FXXOVHLAVLG? a, LJMQZKNEKLZ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x896B580", Offset = "0x896A180", VA = "0x18896B580")]
		private void PESZXNIWZQU(ZPNLZMOPDEI? a, LJMQZKNEKLZ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x896B9E0", Offset = "0x896A5E0", VA = "0x18896B9E0")]
		private static bool RNMTMBFKDPT(ZPNLZMOPDEI a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x896A1E0", Offset = "0x8968DE0", VA = "0x18896A1E0")]
		private static void GDHQWZXJLFH(FXXOVHLAVLG? root, LJMQZKNEKLZ a, KTGVHRCVUQA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8968F50", Offset = "0x8967B50", VA = "0x188968F50")]
		private static void GDHQWZXJLFH(ZPNLZMOPDEI? customProperties, LJMQZKNEKLZ a, KTGVHRCVUQA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8968BD0", Offset = "0x89677D0", VA = "0x188968BD0")]
		private static void GDHQWZXJLFH(IOKTUYUAJJS? root, LJMQZKNEKLZ a, KTGVHRCVUQA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8969190", Offset = "0x8967D90", VA = "0x188969190")]
		private static void GDHQWZXJLFH(CircuitsV2.Protobuf.CircuitNodeData? node, LJMQZKNEKLZ a, KTGVHRCVUQA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x896A870", Offset = "0x8969470", VA = "0x18896A870")]
		private void PESZXNIWZQU(CircuitsV2.Protobuf.CircuitNodeData? a, LJMQZKNEKLZ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x896A2B0", Offset = "0x8968EB0", VA = "0x18896A2B0")]
		private void HXUHDWBBOTS(Guid? a, LJMQZKNEKLZ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x896AE40", Offset = "0x8969A40", VA = "0x18896AE40")]
		private void PESZXNIWZQU(ABLNPBVPOUZ? a, LJMQZKNEKLZ? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8968780", Offset = "0x8967380", VA = "0x188968780")]
		private static void GDHQWZXJLFH(ABLNPBVPOUZ? viewData, LJMQZKNEKLZ a, KTGVHRCVUQA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x896A600", Offset = "0x8969200", VA = "0x18896A600")]
		private void KXVXQEJQQHT(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x896A7A0", Offset = "0x89693A0", VA = "0x18896A7A0")]
		private void OVJAKZDBFPB(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x896A750", Offset = "0x8969350", VA = "0x18896A750")]
		private void OVJAKZDBFPB(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x896A6F0", Offset = "0x89692F0", VA = "0x18896A6F0")]
		private void OVJAKZDBFPB(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x896BDC0", Offset = "0x896A9C0", VA = "0x18896BDC0")]
		[CompilerGenerated]
		private object YURGBNSBCSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x896BD20", Offset = "0x896A920", VA = "0x18896BD20")]
		[CompilerGenerated]
		private object YULZEGYDTHM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private class WTITUNYLWSC : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private readonly IEnumerator<DictionaryEntry> BZBAGIXFVVB;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8972E70", Offset = "0x8971A70", VA = "0x188972E70", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x8972F30", Offset = "0x8971B30", VA = "0x188972F30", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8972FE0", Offset = "0x8971BE0", VA = "0x188972FE0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x8972D90", Offset = "0x8971990", VA = "0x188972D90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
			public WTITUNYLWSC(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8972CF0", Offset = "0x89718F0", VA = "0x188972CF0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8972D40", Offset = "0x8971940", VA = "0x188972D40", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000038")]
			[CompilerGenerated]
			private sealed class RMWSULCKCYE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000588")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000589")]
				private DictionaryEntry DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400058A")]
				public RoomObjectCounts VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private DictionaryEntry CWJROQOETEK
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0xDF45B0", Offset = "0xDF31B0", VA = "0x180DF45B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0x896C410", Offset = "0x896B010", VA = "0x18896C410", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
				[DebuggerHidden]
				public RMWSULCKCYE(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x896C460", Offset = "0x896B060", VA = "0x18896C460", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x896C560", Offset = "0x896B160", VA = "0x18896C560", Slot = "8")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			private ICollection FCTNBRUGXEU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x896CCD0", Offset = "0x896B8D0", VA = "0x18896CCD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x896CA40", Offset = "0x896B640", VA = "0x18896CA40", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x896CB20", Offset = "0x896B720", VA = "0x18896CB20", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool EIGBBPAHPUT
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x896C7C0", Offset = "0x896B3C0", VA = "0x18896C7C0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private bool PATDOEOBDPA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x896C900", Offset = "0x896B500", VA = "0x18896C900", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private ICollection NLZQQXYHFBM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x896C810", Offset = "0x896B410", VA = "0x18896C810", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private int MSERCOGAIGT
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x896C8B0", Offset = "0x896B4B0", VA = "0x18896C8B0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private bool MPTDHTYFVRA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x896CB60", Offset = "0x896B760", VA = "0x18896CB60", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			private object ATQTVCVXCFF
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x896C950", Offset = "0x896B550", VA = "0x18896C950", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x896C750", Offset = "0x896B350", VA = "0x18896C750")]
			[IteratorStateMachine(typeof(RMWSULCKCYE))]
			private IEnumerator<DictionaryEntry> EPQSKITRJUP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x896CD60", Offset = "0x896B960", VA = "0x18896CD60", Slot = "19")]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x896CC00", Offset = "0x896B800", VA = "0x18896CC00", Slot = "13")]
			private IDictionaryEnumerator XIGILCZIAYS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x896C9A0", Offset = "0x896B5A0", VA = "0x18896C9A0", Slot = "9")]
			private void NSKICNEDGNF(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x896C9F0", Offset = "0x896B5F0", VA = "0x18896C9F0", Slot = "10")]
			private void PGUCIWDMWVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x896C860", Offset = "0x896B460", VA = "0x18896C860", Slot = "8")]
			private bool JTFWXTPJDDD(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x896CBB0", Offset = "0x896B7B0", VA = "0x18896CBB0", Slot = "14")]
			private void WRVMGBQTRYA(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x896C700", Offset = "0x896B300", VA = "0x18896C700", Slot = "15")]
			private void DGKUIQDWFEQ(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			[CompilerGenerated]
			private sealed class UPMWHUKNEBK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400058E")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058F")]
				private DictionaryEntry DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000590")]
				public Invention VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private DictionaryEntry CWJROQOETEK
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0xDF45B0", Offset = "0xDF31B0", VA = "0x180DF45B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0x89717F0", Offset = "0x89703F0", VA = "0x1889717F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
				[DebuggerHidden]
				public UPMWHUKNEBK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x8971840", Offset = "0x8970440", VA = "0x188971840", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x8971960", Offset = "0x8970560", VA = "0x188971960", Slot = "8")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x400058D")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			private ICollection FCTNBRUGXEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x8964220", Offset = "0x8962E20", VA = "0x188964220", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x8963F60", Offset = "0x8962B60", VA = "0x188963F60", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x8964070", Offset = "0x8962C70", VA = "0x188964070", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool EIGBBPAHPUT
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x8963CE0", Offset = "0x89628E0", VA = "0x188963CE0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private bool PATDOEOBDPA
			{
				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x8963E20", Offset = "0x8962A20", VA = "0x188963E20", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private ICollection NLZQQXYHFBM
			{
				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x8963D30", Offset = "0x8962930", VA = "0x188963D30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private int MSERCOGAIGT
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8963DD0", Offset = "0x89629D0", VA = "0x188963DD0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private bool MPTDHTYFVRA
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x89640B0", Offset = "0x8962CB0", VA = "0x1889640B0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			private object ATQTVCVXCFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x8963E70", Offset = "0x8962A70", VA = "0x188963E70", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2DBF770", Offset = "0x2DBE370", VA = "0x182DBF770")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8963C80", Offset = "0x8962880", VA = "0x188963C80")]
			[IteratorStateMachine(typeof(UPMWHUKNEBK))]
			private IEnumerator<DictionaryEntry> EPQSKITRJUP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8964270", Offset = "0x8962E70", VA = "0x188964270", Slot = "19")]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8964150", Offset = "0x8962D50", VA = "0x188964150", Slot = "13")]
			private IDictionaryEnumerator XIGILCZIAYS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8963EC0", Offset = "0x8962AC0", VA = "0x188963EC0", Slot = "9")]
			private void NSKICNEDGNF(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8963F10", Offset = "0x8962B10", VA = "0x188963F10", Slot = "10")]
			private void PGUCIWDMWVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8963D80", Offset = "0x8962980", VA = "0x188963D80", Slot = "8")]
			private bool JTFWXTPJDDD(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8964100", Offset = "0x8962D00", VA = "0x188964100", Slot = "14")]
			private void WRVMGBQTRYA(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8963C30", Offset = "0x8962830", VA = "0x188963C30", Slot = "15")]
			private void DGKUIQDWFEQ(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8972150", Offset = "0x8970D50", VA = "0x188972150")]
		public static UgcRoomSaveStatsDetailed ODWJDMFNTUV(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89719A0", Offset = "0x89705A0", VA = "0x1889719A0")]
		[CompilerGenerated]
		internal static int DMWIDHCVNLR([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8971AC0", Offset = "0x89706C0", VA = "0x188971AC0")]
		[CompilerGenerated]
		internal static void GQKIEFGKMQL(int a, [In] IOKTUYUAJJS graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		ParticleVfx
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class LJMQZKNEKLZ
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public readonly Guid CFIPSIJIVUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public readonly IReadOnlyList<Guid> RYYUFHYKJCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public readonly UnitySubAssetKind IXVPXZPOTQH;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8972B30", Offset = "0x8971730", VA = "0x188972B30")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private readonly KTGVHRCVUQA XYIGVVUKSQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private readonly Dictionary<Guid, UnitySubAsset> REKHOLBZIYM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public KTGVHRCVUQA XRVITQXTICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8964E00", Offset = "0x8963A00", VA = "0x188964E00")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8965000", Offset = "0x8963C00", VA = "0x188965000")]
		public bool JRZKRJJNVME(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x89650F0", Offset = "0x8963CF0", VA = "0x1889650F0")]
		public LJMQZKNEKLZ()
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
