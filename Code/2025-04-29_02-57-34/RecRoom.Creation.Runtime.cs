using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A77ED0", Offset = "0x7A772D0", VA = "0x187A77ED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DCDHLOMJHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> KGGPKCKPHPK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> LFKBONPHACF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> IBHIHJCCOCF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> GJKGAKNEAAE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ELGGBNOMNLE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string IKBFJAKFJFO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string IMKJIMPHFBH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A62A10", Offset = "0x7A61E10", VA = "0x187A62A10")]
	public static bool HJLBDLDFFKP(Guid CDHMJPBFHLK, int NJOMPGIPEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A62980", Offset = "0x7A61D80", VA = "0x187A62980")]
	public static bool CDAGNDNABAB(Guid CDHMJPBFHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A62B10", Offset = "0x7A61F10", VA = "0x187A62B10")]
	public static string PGPHFPEEFJB(Guid FIAGFFPOAHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LFPMNEACGKC]
public enum EOBLBHGFKHE
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
	COSTUME_DUMMY_OM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELECTRICAL_UNIT,
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
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A77E40", Offset = "0x7A77240", VA = "0x187A77E40", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EFJPNEICBAB
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NAMGKBGMFFE;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid EOKLJLAHKKF;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid MNLNIJIPAOM;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid AJABLLFDBNP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid KBFGNDBJPJD;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid EGCFPANJFCI;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid NMPMAOBEPIC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid MNIFMBAPBOP;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid NGICNIAILDA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid BPONDINIDOE;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid CEDOILNMIEP;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid OHAAFENCOMH;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BDAAOPOBHEN;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EFINANIIGNB;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid DLNMKHNPIND;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid JFAAIBEBFHE;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid NHPEPDMCMLN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid JCCOGIBBBGE;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid DOHBDKNDJCH;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid BGGEOJOMJIE;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PGJMDKMJGAP;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DDAKFPEEBPB;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid MLEBDNEDGKJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid DPKALMBJDKP;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid OFCJHFAKPFA;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid AMKJEJIJDPD;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid AKGLMINGOIH;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DNJOJBLKJOL;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid AKHIDIHDJNJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid DEEDKJPKEAB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CKMMBKINNOD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NBDPADFKDPA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid NIEJONDBBMM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid NIOIFAFEKKE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid FBGPHMBEFFK;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid PPNJELPOMEO;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid EJGHOELFKDP;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PKPGLAMHKLE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid IOHAHGIJCPC;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid GJIGMIGMNBJ;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid PDJKNAPJGDF;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BCKJMNEOCIB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BCGAEKENCJK;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid EPCGIHHKLDP;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid LCNPAENGDAE;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CNOEHDDCGEO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid HKDDINKBLPL;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FCKJJIGKLKJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid IIJOECMPCCA;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid MKDFDAIOMNO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid HPGPHMFAEEE;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid FPEOJMKFDPC;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid EFEEBFEGFHI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid PLGPLLACIDE;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PMKFOAFIMJE;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid FABMHFFBLNL;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid ENIOMAMKDAJ;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid FLNINBLHPOB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid BFMBKAJGKJD;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid PJKKPDKFBJL;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid EGPBHCBIOLA;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GLMOLNFOMLO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid FMDCEJGBDME;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid DHIGDBEOPNI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid BALCMLKENMI;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid PPKHDNENKFO;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid NILDBEKHAKJ;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid OOFJGPBMHBD;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid DHPHPOEPPMD;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GAHKNODIDIK;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid BKIGGHKDMAN;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid KKEDBCMBPBE;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid EHBDACMOBJD;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FIPMLENDDPE;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid CDCEDNLPDOK;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid FLGEELNLDJC;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid ONGOPJBCEEM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid FCNDEODNIKD;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid KFEIGHEGLEL;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid FEAEOFLGIDK;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MOFBFOEOLOA;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid GHEDNEMMKEF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid EPEFLHAHBNK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NJFMMNIIJMA;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid CNPDBPEGCNB;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid LEBLNIHMDNB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid CBPEAHJKEEI;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid CGLLBHABCFP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid HPBKIGDEBNJ;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid DNGKKEPEEKM;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid IHLBFJEDINO;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MKJDKEIMPKB;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid PONOAHFNDLP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid PDOBKGGGFBD;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid EDGDKILAPLL;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid FPLHHAOPFFP;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid NFMBFEBNDIL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid DLOJFPBKDFP;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid NMPKCGFNHMP;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DBNCLEMDDDG;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KBOOIAFBHIH;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid JLMKHIFNBBP;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid OHIFADICPIL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HNOMMIGIFOO;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid DECDKELJJGB;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid EHGECGAOKCI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid OHCFGFJGIAC;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid CPLLIDNNLPD;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid CCIPMONFLAP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GICCCIMIIHE;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid GIEIFMHDFPO;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid GJOELDOFHKM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid JJLPEIPABMN;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ANEBNINMPLI;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid IEMEFIONMBH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OJJOCMKHAPB;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid LADIPKJHGLA;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid LJPBODADPGA;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid DHDABIFNIAA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid CMHIFBJEHIC;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PFLENADPHKB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid HGGPJPALEJL;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid FKDJJINNODM;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid ALKCLCCHBAB;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid ACACKKHJAEM;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid EEGJNGEJOFN;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DMOJPCACKEJ;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid OIDEKLCHFOF;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid LIBDLDOIMJJ;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CIFGGAFJKAL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid LHGOOJBHGAO;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid PIOPHGCEKPF;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid NDHAJPLKCDO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid GCELGIJNCPE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid FAAAHFOFNID;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PFGEEKBNODN;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IDCECNMHCON;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid OBBEEDECAAB;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid HLOJDCKHJOM;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid EEDLDJALEGG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid GMBFLGGKOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid KPJLCPKDDMB;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid AHAKAHDHKHI;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid DOAIMOFFLGK;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid KIDPAEOLHIJ;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid FCCCPEOJANG;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid FLBHEHOEMCB;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid LOJGKOFOEGA;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid MDMLPODBJDM;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid PBOKAFLONDI;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid JOHDOAPFLJA;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IGLMKGHJDIB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid OGONGIHCJOA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid ANHDEAPEFEP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OPMIGDGJAKM;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LGNPIBLMFNE;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid ICIBNNMCEKN;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid NPKJPDBFAMO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid HDNAMEFCDHM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid LCPFNPFDCLF;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NPLCANGGLED;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid JMCKENEELIN;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid CHGGGOGGPOD;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid ALMMONKFGID;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid JMJKLICCOPB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid CLOOGEGKCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid EPCGODKNHMO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid PNGKFCGPOFO;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid CFLABIFLPCA;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KNBJOKFGCKI;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid DLFPCALEPCK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LCMEJIKGAJB;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid HNCIBNCNAJG;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid IOJOFEMIMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid OFCNDFCOIOJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid BFDANAIBEEM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid OCOLLIDCIBI;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid OJEOCFCOOMA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid LDILBHOEDEJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DKGFLMNCBDO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid BAINGBHIJCA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid GDGGJMHICPP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid JBPDJPCAKCO;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid NIIIFPBOBCF;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid KFIPFLNHNLP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DKFAIFMKOAP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HCAEDMPJPHP;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid GKGLDLDLCEK;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid KLKLNDMLFAL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid OOAIJCPJICB;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid OBFBJNPIAME;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid MAPKNPBKJGP;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FDMIAEBPDDE;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BOJAEKBAECC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PAMFPFHLNOK;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid KAMBCNHEOHJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid HCBPPEMIAOI;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PBPAIIIMPBL;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LAIDIMLIOBC;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid GGNPEKKDBAD;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid LBODGNJPIMK;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid LCODOFGBCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid BCMJGGLMMAC;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GBEHAGGOINJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LIFNGJHOCAP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid IBBDBJBIDLG;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid HDEKIPDEGBO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid GKCKNPOJFOF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid JGKNCOEIKID;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LPHMDLNBMAO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PDEBAEDFNHF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid EHEODALLKFC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid MBNGCEILOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid EHFJACKFLKN;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid PBMEEHBBPPG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid BOLNCNPAKIK;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid EOHDKBOEGAM;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid ALEICMMIPKN;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid LGOFKNOGFPK;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid GGHEFNBHBGE;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GLKLOJMIODJ;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid DDODPKACIME;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid PBGKJNPKIFH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FPDCNMHOHED;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid MJEADNLAOMA;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid CAGFFIANGDO;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid FNDNCJJBGKD;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HJNHDHMNNKF;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid FNDFPAJFIGH;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid EAAFFOGDPAL;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid BICONCJOACM;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid ODMDOCGKDKA;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid CGELDJLIOKL;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid ALOMOJBBPEH;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid LPCCLFGADGL;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid KMJCKEFEEAA;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid EPJHEECNFCJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid DALDBPJPALC;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid ODJIFJDJFNN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NFOMODNNFIJ;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid EBNJPIOOGFG;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NGBKPGOHGFM;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HMOOCENLAPA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid FKHIHCLHPCD;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid IIBIPMHDEDB;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CJPOKPOAFPM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid DFNHAECDFEC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid CPEGABOHKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid IMCDGAIKFFB;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AOCJBNOOMDD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid GKADMIPOMAF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BPDEEEGFKAK;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HMJNEHPFCDC;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid DDPBBBHFGFC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid AJELNOEBMFC;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CBPJMNDMFAF;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid HJLPBMJLNND;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid DPHCJGGBFIO;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid JAICLNFPBOJ;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid PCNJEMNIHGL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid PFGFEHHAOFH;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid LLEADAPGNEC;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid LLNBCIDLODK;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid NHBMPEBNNNE;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid PLJKMCHFALJ;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid LNDBHOMHNIK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FLNFAGDNEJD;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid LBKGJPGALHN;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OPAJJMBJNFB;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid CDALDKLLHAK;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid KCIGEJIGPCE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DLDNDNMCOLO;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CKPHIBAFBJK;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid OEEPAHNAEKF;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid KNEMDLHILPO;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PJLHPILCAMA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid BGKNKOAMLBJ;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid ONCCHMMHIOK;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NCDOBLCJAKB;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid JHFKLOJNKML;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid FLOLHGGJKPJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LLPNAAABHCG;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid AKBFPCKHFHC;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PELGKDKBKNP;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GNEIHNMCGED;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NODAAFMMAFF;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid JHFDPHPANMI;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid KOGHOMNFGAG;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid EAELKNBFEJD;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid AKGKOJKNGJH;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BMLIHKJIKBJ;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LMMJOPFCLDP;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid GBOJKBBHEDB;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid IPHHIEBLFHB;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HLIBOBJAIFF;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LAAANJDDGND;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CMKAEMMABPH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid INMPEFEGDDM;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid GBDMFOAIFOH;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid PJGFFAIJLAG;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid MBFJKMFLPIH;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid AGIPJDHDFMK;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid EIGAKGBGKEC;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BMGHHDLEPMK;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid CPJEMDEAOLA;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid NNIPMCDDNDM;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid OJOIHFDNGDB;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid LJLPBHFBDOB;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid PFCBDHOKJAJ;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid MMGAHKIAGFL;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid CBHMBDNIGBG;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid FMFCDIANHPE;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid CIGJDKOJDMF;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid HINOJHJMMLA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid AENADJPECPC;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid KOONFLGPBDA;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid DMJFPNDNBJN;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid BIMNEBDEKKO;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid GFCIIAJNAGP;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid NDHIENFLFDL;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid OAFAINGDNCN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid CFCNPEIKNAI;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid IBDHBMDLDCD;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid EBLDBKPHNEL;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid FOMMPKGIFAF;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid KNFNBIMEOJO;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid PONEBCCNFBL;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid OIFJBCFANAE;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid PMHLLKEFHNG;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid IIALNIJKIOJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid IECENOFBCKL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid ABOACONBOHG;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid AFAJKBLPNJN;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CALKDELCCHA;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid KPGLLDOMCNI;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid IEOOBKMCMPB;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NLAMILDEMLA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid ANEINFDLCCD;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DMKGCMGBPDG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DALDIDLKJIL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PPCEMGELHHJ;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid MPEDGFHODCI;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GCJOPNLEJFN;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid PKAMJLCBPHP;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IHNMMDDCFLC;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid BCILOMNCDHJ;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid EKIEDEGPEED;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid GPDDGBBDBED;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid LLNHCHOOIKL;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid LCLNFJLIDIK;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid LKPDECAPAEL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AOIMHLJKLMD;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid PAEHMNJPHIH;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IBBKKHACOHE;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid HAKPLJFHCJO;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FCHEAECIKGI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid NFKGDOKNJPB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid OFNGPPPGEMM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid DDBDJPJBMEM;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FIIPBDHOMGL;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid KGGECCBJNNN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid APJGPMEOHNL;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid IHNEGICIMAO;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid FMNCLNDPNBE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid BMIPNMEBJII;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid BGKJBJMECKG;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid IFEFECMJOEB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid EKKMJLCECBI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid DIGPHLIEFBH;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid NKHCBJDKGJM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid KIHGCJGGDBF;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid DICILBDCILD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid JCIFIMNHMLE;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid MJMIFJOCCEL;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid JKIEEIGPBLL;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid HICCBAJGAEL;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid HIPIJDEAAED;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid GOPMIOJHGOP;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid MBLGEDAOJAG;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid NIDKNBGIGNG;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid HCEFMOGHHCH;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LPCKHBPCMDP;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid KBCEDEMHHBJ;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid OKOJHIOAMEA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FCENANDDJJI;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OKEPFCOAJMG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid EMBIBKBJPHJ;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid IHFPJEMFFEI;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid GHAEANPCMPP;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid EHDKKCOMJFB;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid IIDOEBEHEGH;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GFBHPLGJMKL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HHHJBOIBLLM;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NKAMDEDPMMP;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid OHJEKNBFPIE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid IPFGIAFENCI;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid DANHHHGFJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid IOJFGLJBPID;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid PGJFIFMMAAK;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DFPECPEIHDK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid CBDMCODIIDE;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid BOJLBMCPMIH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FMJCCNLMFKD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid BKMFAELAFCI;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid JJIDCMCDOEO;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid IFOHLDPHOCP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid NPGFHLJKPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PHAMBFJKNEF;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid LAPAAKHPEDD;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MJCIBCCEPNG;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid NNEKILBJMEL;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid OJGMCFOHGGO;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DCADJHJDODP;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid OAAPHMGFFDI;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid LBNLKOAIKFD;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid CGGPODAOOKO;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid BIDCIDINGDA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid MKDLIHLEABF;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid FAHILLDFIHI;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid EBJINONGKLO;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid LGOMJOOLPCE;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid JMMGPINEOGF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid DCDGOJJCKJO;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid OHPGDOHMDGN;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid EKHEHPPABDP;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid BDMBFDOMEFK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid DICMFGKLJKO;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BGMPJONFBOL;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid FMEGBKPPOPM;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid EKHFNHGPCNI;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CAKAHFLNGIM;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MGOGFMEJENP;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GHJONKMBMKJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DNJMNICLOFI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid IIBFODBMHAM;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid EGDHEIAHHEO;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid AOKMODEDGEA;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CGFJLCHNEDD;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid ALLINBEEKPG;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid OHPFNAPAPEI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IHECCFBNFCC;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IAHJDKBAEDL;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid JCKJNACPDKH;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid GGEGKGCEJHA;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FMNDLPJPKCP;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid CMLEMMPKGHN;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GALOJHFBOPA;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid NPHBMMADOBI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid GOBAHKNDFOP;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid CFCJNFKLCDM;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid MOEFHDJAPON;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid GMIHDAEGHFB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BDKDLJGBFIC;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid FCIEJICOKFI;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid LDCECELKMIG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GCNNMFLNCMI;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid HPLFHCLJMPL;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid GFPLOJJMNNG;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid NPGFHMJPKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ANFDHMLICIJ;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid MFAMKDGFMED;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JHIAMGCLMFP;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid EBBFFOGMLAB;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid LJEALGLNONI;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid HJNNJEOKPAK;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JCDAADJLJNG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid LINKKAJIHOB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OABPMHDKBKK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CKONNPKBAND;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FMKCJGPJAHB;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FOGKIBDOPPE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BCKJGGEMMIL;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid CNDFAEHANCF;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PIOOGMIOPBI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid NMHGCBBEPKM;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid LHIDIGKKJEG;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid OMKEMJKEPKG;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid HGFFNIBPLOF;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid AOIIKALNAPN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid DHFIAEFLFPC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid EKMIOEDIFLH;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid MHIDAIJJCAP;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NDOLBJNHLGC;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FHGMAIPCJAI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MONLOCAGCMP;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid HGAMBDHOBAH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid IPCIHENCGDF;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FEEKDOGPJGD;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid OPIJANOMJFL;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid PHPKJCHJFCL;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid ELDMPGHNGND;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BGJKIPAPHGO;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FFKEHCHFKJI;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid EINFMOFMOEO;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid AFMFAEGLFKH;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid ODMPMGDMKON;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid FELAPLHLALJ;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PBCGAFEHGMA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid EIACIDKEGLG;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid KBKGAONBINA;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid KNEPPLNEIMH;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid CDMMMDLGFKP;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid JBDMKCFOCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KFLLKCMHIHF;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MPEMKJIGKFN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid MDEPGAAIEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid JNLDGMBPKFF;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid ONOEMCMDGGM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid POBBGJJFOMN;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid NNDPOKHCJIO;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid DJDHDDIKCDO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid EPOAFNBKBGD;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid EOEPDGCDGNF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid ANMNCBNGNJD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ANDLMEIICGC;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid EBPNJMFBNCK;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BCEADOFNPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid PKIKBPLFMMH;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BOGBBOOIAEG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid ECIIKBNAPMI;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KHMAJNKNALC;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid ECEIGENKFDC;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid OHEIHOKNIIH;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid JADKNJBHEBN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid KFCLJOHDDOE;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid HFOJBJAFKGK;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid IPOMFDBJGAP;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JDGPEHLIPGD;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid CPGFEODLKKC;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid EFDOJDGOKKL;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid KKHHAGJCPEG;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid EDMGDBENBGI;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid KAJMOKBJMFC;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid HNHDGCJFNFP;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid KJPFPGNANGB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid HBOMIJFOIIB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid JHAPJNMCIPA;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid OAHCGNMBIIG;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid LLFAFAPIPCK;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid CALHLKFIIAG;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid BPOMPPLDPGM;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid DGGEFPFBEDA;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid CLIMPHGHGFM;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid EKKOHGOKOJM;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid IJGANAAHHHJ;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid HAPCCDLAEIL;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid EMEOKLKJLGJ;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid NKGIMDMIPJF;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid MNANJJHOOED;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid DDKLOINGOHA;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid MKLKMPBFJFP;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid MHHJPDJDONF;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid NFGPLAEHFHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JANILCKCKIE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GNNLFDNNGKI;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid LCNCIKJKMAN;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid IFHCBOLLKKM;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid CGJAGGADABO;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid LPGIGEPNDKN;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid BOGJMIFPKCG;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid MCPCOEOMNLL;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid FBKHGIHEBAA;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid JLKEOLAMIGJ;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid GMKLDNPLFLG;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid MIJEJCPLNEM;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid CKGBBBCLDHI;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid OCIDFEAHMKM;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid FOJEEFPPMLP;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid OGPHAFBMPLD;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid BLONPAPMDOH;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid ADLFJBPKDOC;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid BDEHNLIBBPF;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid AMHFBKENLND;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid NHJDMJFMMFB;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid PGCMKLMCHON;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid GDOEHKMODBM;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid MLBKOCPIJHJ;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LEMPJANHNIF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid MHMNBJHCEAE;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid GPCMGPDKNOG;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid CDCHIFEGNLD;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IJGLPEDLNIJ;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid LPKJIOEIJJM;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid JBKNILBMJCK;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid OFMFCBBMDFL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid JFLAGBDBPMF;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid LIJMKOFLGLM;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid OIKMOIKCAEE;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid JPALIDJKLIM;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid IGOLMBMAJMN;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid HAKEAFCEFEN;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid AEBLFAHHLJM;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid IFPDLELBEJL;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid JBNANMIEBKJ;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid LGIJKGMAJDP;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid NMEEEMJBNKE;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid JFLFFGJJPPK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DAGDDLMGFCB;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid KFGAJFHBFKE;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid INGHJDEMIBK;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid NMKKIGAJGPO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid FAEGCPGIFKI;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid GIDMJCAMKOH;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid LLIPAFCCJAI;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid AENKJBCJOIA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid EKAKABFPPNJ;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid HAJELNKKJDF;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid OJLAPFNLKBF;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid GIEHCNGFKLB;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid CLIPGCLNLDC;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid CCOBGDJKIBM;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid NLIFKHKDFNE;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid APDEHPJGMGL;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid JECHEELGOII;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid ODLFGDMBBDC;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid EJCPNENAFEF;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid LKMIOGCAFJL;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid CHCAHEDILHA;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid DMCBAICFPAB;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid AAGCLPOBNDP;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid LCONAPAONHO;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid HNDGLHBBJLE;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid JKJNFPEPAJA;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid CNFFJFICJAH;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid MOIKBIOHKPO;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid BEHFBENKIOL;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid LOGMAGIMELA;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid JHMPAOCBLJM;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid HOHAKMCKKNP;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid KAHEDNDPHEI;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid LNPNGJNNIHL;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid LBANFIOANBD;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid NNDJCCIBMOE;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid FGAGMGGCANH;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JKFBJONADEN;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid FNHGGIMKPCM;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid GJGKNNINPKE;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid CKABAGEAGNC;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid EMJNCFLJIMD;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid CNNGLCLOMNH;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly Dictionary<Guid, EOBLBHGFKHE> FOGEANKCCEO;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private static readonly Dictionary<EOBLBHGFKHE, Guid> CCHLBJIOOHB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, EOBLBHGFKHE> EDANPDOIBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A66710", Offset = "0x7A65B10", VA = "0x187A66710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<EOBLBHGFKHE, Guid> MAEECDLMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A66770", Offset = "0x7A65B70", VA = "0x187A66770")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PCCKAFHNCBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A77FC0", Offset = "0x7A773C0", VA = "0x187A77FC0")]
	public static bool ALCPLDIABHD(DFOHPJLFMCE POPAPOGFDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A77FF0", Offset = "0x7A773F0", VA = "0x187A77FF0")]
	private static bool ALCPLDIABHD(CHCONPFIFEN JBBAONHBPHP, DFOHPJLFMCE POPAPOGFDGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CHOBILKPBJA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(PBPEIKIHKGI AOFGGGKINCN, [Out] Dictionary<int, int> PBCPMGLNFPL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KFOIBDNOLMJ KGODMAGJPMM, OGHCFKLLOGF DIFMKGLBOKE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OEJDENJHAFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public readonly OOKBLLNDPGF OHBHMDMPINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public readonly IEnumerable<IBDHKNDIHNK> JIICPEKJMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly IReadOnlyList<IBDHKNDIHNK> CKKPABOEBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly JHLAGGIINPD<HHOOHPCIFEM> KOENKBMDFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<GKHNEBJMJEM<AIKGKILEHOL>> FCEFONGPFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly FHNEONLKGCM HMNJDAFOIPF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AJHJGGJLJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A77F50", Offset = "0x7A77350", VA = "0x187A77F50")]
	public OEJDENJHAFP(OOKBLLNDPGF EAKHKLKENBF, IEnumerable<IBDHKNDIHNK> GEDHHIAHIJI, IReadOnlyList<IBDHKNDIHNK> EENJBFPMNCL, JHLAGGIINPD<HHOOHPCIFEM> JNNOIANPDOB, IReadOnlyList<GKHNEBJMJEM<AIKGKILEHOL>> GGBAOHOMNLA, FHNEONLKGCM JEPOOJBBEFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EBNJIBFBOOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly OOKBLLNDPGF OHBHMDMPINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IReadOnlyList<IBDHKNDIHNK> IBFKFNOCHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly JHLAGGIINPD<HHOOHPCIFEM> KOENKBMDFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<GKHNEBJMJEM<AIKGKILEHOL>> FCEFONGPFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly ByteString OMHFJNDKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly FHNEONLKGCM HMNJDAFOIPF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A666A0", Offset = "0x7A65AA0", VA = "0x187A666A0")]
	public EBNJIBFBOOG(OOKBLLNDPGF EAKHKLKENBF, JHLAGGIINPD<HHOOHPCIFEM> JNNOIANPDOB, IReadOnlyList<GKHNEBJMJEM<AIKGKILEHOL>> GGBAOHOMNLA, ByteString LDCKALLGLJD, IReadOnlyList<IBDHKNDIHNK> LDIMMIBABOI, FHNEONLKGCM JEPOOJBBEFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HEFOBCPMPPP : PAIEBPGBCDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly Guid LDKKBFDHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly Dictionary<Guid, Guid> PPJCHOKILKM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4829170", Offset = "0x4828570", VA = "0x184829170")]
	private HEFOBCPMPPP(Guid DIFBBFBGDKA, Dictionary<Guid, Guid> PPJCHOKILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A66BB0", Offset = "0x7A65FB0", VA = "0x187A66BB0")]
	public static HEFOBCPMPPP FABCCGGAHMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A67060", Offset = "0x7A66460", VA = "0x187A67060")]
	private static Dictionary<Guid, Guid> MHEKMMLNDEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A66F40", Offset = "0x7A66340", VA = "0x187A66F40")]
	public static HEFOBCPMPPP KAJBNAOPGLJ(IReadOnlyDictionary<Guid, Guid> BHCEDEKBMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A67110", Offset = "0x7A66510", VA = "0x187A67110")]
	public static HEFOBCPMPPP NIEBNPAODKG(IEnumerable<KeyValuePair<Guid, Guid>> BHCEDEKBMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A66B30", Offset = "0x7A65F30", VA = "0x187A66B30")]
	public Dictionary<Guid, Guid> DHOMDDPMDMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
	public Dictionary<Guid, Guid> HOBOMDAHNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A66C40", Offset = "0x7A66040", VA = "0x187A66C40")]
	public void FGAAHPGCDNG(Guid BHCEDEKBMHE, Guid CMLCOMAALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A66CC0", Offset = "0x7A660C0", VA = "0x187A66CC0")]
	public void FHBMMDNPICD(IReadOnlyDictionary<Guid, Guid> IPFFKEKHJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A669E0", Offset = "0x7A65DE0", VA = "0x187A669E0")]
	public Guid DHHPNHLJJGF([In] Guid BHCEDEKBMHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A66F50", Offset = "0x7A66350", VA = "0x187A66F50")]
	public Guid MBAOCHPOCED([In] Guid BHCEDEKBMHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A66FF0", Offset = "0x7A663F0", VA = "0x187A66FF0")]
	public bool MELENHNIGEI([In] Guid BHCEDEKBMHE, [Out] Guid CMLCOMAALAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A66FF0", Offset = "0x7A663F0", VA = "0x187A66FF0", Slot = "4")]
	private bool PIBFMKIPHIF([In] Guid BHCEDEKBMHE, [Out] Guid CMLCOMAALAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FGKMBNDHAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JCKEBLIOOFF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PPPLBCGIKIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public OOKBLLNDPGF staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PPPLBCGIKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A783A0", Offset = "0x7A777A0", VA = "0x187A783A0")]
		internal JHLAGGIINPD<PPBAIKDIKBC> NMNKOJPAJND((JHLAGGIINPD<HHOOHPCIFEM> GraphId, JHLAGGIINPD<AIKGKILEHOL> NodeId) i)
		{
			return default(JHLAGGIINPD<PPBAIKDIKBC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private static readonly OCNKOJALFOI<PPBAIKDIKBC, int?> BGMDABBEOLD;

	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly long FHHJNIFOAJP;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A67650", Offset = "0x7A66A50", VA = "0x187A67650")]
	public static (long, long) OOGFBOCFIPO(OOKBLLNDPGF KGFEPJDCEEC, JHLAGGIINPD<HHOOHPCIFEM> APKPABPIPHP, JHLAGGIINPD<AIKGKILEHOL> PPHFMFHOCEJ)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A67400", Offset = "0x7A66800", VA = "0x187A67400")]
	public static long EJDNDKPCGNL([In] ReadOnlySpan<JHLAGGIINPD<PPBAIKDIKBC>> KHMMDOJLMFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A67530", Offset = "0x7A66930", VA = "0x187A67530")]
	private static long IPPCEECDNEK()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EGLIHFFIFGO
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public static readonly HashSet<EOBLBHGFKHE> FJBGKFDPDGP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LKGCAENMHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PGLEAOJEFPM : IEnumerable<IBDHKNDIHNK>, IEnumerable, IEnumerator<IBDHKNDIHNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private IBDHKNDIHNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private AEHFCHJCBKK spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public AEHFCHJCBKK <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private KNALKFFGNDO spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public KNALKFFGNDO <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IBDHKNDIHNK System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public PGLEAOJEFPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A83D80", Offset = "0x7A83180", VA = "0x187A83D80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7A84000", Offset = "0x7A83400", VA = "0x187A84000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A83E90", Offset = "0x7A83290", VA = "0x187A83E90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBDHKNDIHNK> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A83E90", Offset = "0x7A83290", VA = "0x187A83E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A76BD0", Offset = "0x7A75FD0", VA = "0x187A76BD0")]
	public static AEHFCHJCBKK MGNGHFPFACB([In] EBNJIBFBOOG OMIHGEBFBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A76D50", Offset = "0x7A76150", VA = "0x187A76D50")]
	public static AEHFCHJCBKK MGNGHFPFACB([In] OEJDENJHAFP OMIHGEBFBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A74AB0", Offset = "0x7A73EB0", VA = "0x187A74AB0")]
	private static HashSet<GKHNEBJMJEM<DEAOPEBPHHC>> FBEHLFBACFD(IReadOnlyList<IBDHKNDIHNK> LDAIHJLBDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A76F40", Offset = "0x7A76340", VA = "0x187A76F40")]
	private static void MJPJBDOPHFP(AEHFCHJCBKK NJMJGGMBJFP, [In] OEJDENJHAFP HMKPHPPFDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A74EE0", Offset = "0x7A742E0", VA = "0x187A74EE0")]
	public static BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH> GABOGNHEEOK(AEHFCHJCBKK NJMJGGMBJFP, KNALKFFGNDO PLCCGOFFIFL, HEFOBCPMPPP? ODPJKFJKGED, bool JPOBLHNDMNE)
	{
		return default(BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A77A50", Offset = "0x7A76E50", VA = "0x187A77A50")]
	[IteratorStateMachine(typeof(PGLEAOJEFPM))]
	private static IEnumerable<IBDHKNDIHNK> NLJHAEBIOPL(AEHFCHJCBKK NJMJGGMBJFP, KNALKFFGNDO PLCCGOFFIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A76ED0", Offset = "0x7A762D0", VA = "0x187A76ED0")]
	private static void MJHGBHEHOGJ(AEHFCHJCBKK NJMJGGMBJFP, KNALKFFGNDO PLCCGOFFIFL, IReadOnlyCollection<ByteString>? CLDFPCNKPJN, IReadOnlyCollection<ByteString>? KKMJBLLPKKM, IReadOnlyCollection<ByteString>? GKAFICPMBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A76530", Offset = "0x7A75930", VA = "0x187A76530")]
	private static bool JBEBMFFDLHA(AEHFCHJCBKK NJMJGGMBJFP, KFOIBDNOLMJ KGODMAGJPMM, KNALKFFGNDO PLCCGOFFIFL, [Out][NotNullWhen(false)] string? MHFONFLBJOA, [Out] Dictionary<int, int> PBCPMGLNFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A77B60", Offset = "0x7A76F60", VA = "0x187A77B60")]
	private static Dictionary<Guid, CHCONPFIFEN> OOBLNOHIFCL(AEHFCHJCBKK NJMJGGMBJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A74E50", Offset = "0x7A74250", VA = "0x187A74E50")]
	private static void FDMJPIAIDDD(bool OKNDCKAADLL, IBDHKNDIHNK GEBIOONDCDF, HEFOBCPMPPP HDEMFLLKJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A76260", Offset = "0x7A75660", VA = "0x187A76260")]
	private static void GDJOLAMNIKO(IBDHKNDIHNK GEBIOONDCDF, Guid MGDNCABPODA, IAALJBIHJIE? KHBMOIOJLNH, Dictionary<Guid, CHCONPFIFEN> IPJJHNCBOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A775A0", Offset = "0x7A769A0", VA = "0x187A775A0")]
	private static void NFMLMLGIGHD(IEnumerable<IBDHKNDIHNK> GILBBMPDJCB, IReadOnlyCollection<ByteString> CLDFPCNKPJN, IReadOnlyCollection<ByteString> KKMJBLLPKKM, IReadOnlyCollection<ByteString> GKAFICPMBAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KNALKFFGNDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public bool OKNDCKAADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public FHNEONLKGCM JEPOOJBBEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public IAALJBIHJIE? KHBMOIOJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public IAALJBIHJIE? GEDDFLBJNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public OOKBLLNDPGF BMDJMCJMMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public FGKMBNDHAFI BLDFIEOOJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public CHOBILKPBJA CKMKEBFIHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public GKHNEBJMJEM<HHOOHPCIFEM> JGMECOGPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public NDIEEALJBOE HGFFOAMGNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public List<IBDHKNDIHNK> CDNENPMCFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public FHKNBBDCLOD GAAFPFLNOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public JPHDAIAGEAJ GIFBKKIKKED;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IAALJBIHJIE
{
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private const float JEBLADGAMAE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Vector3 KBPOHLLNAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Quaternion PNEDBEMJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public float KPABPLHPKDL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 CALKLLDGIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A80FD0", Offset = "0x7A803D0", VA = "0x187A80FD0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS NAHNBMDFBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A811E0", Offset = "0x7A805E0", VA = "0x187A811E0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x130F3B0", Offset = "0x130E7B0", VA = "0x18130F3B0")]
	public IAALJBIHJIE(Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float KPABPLHPKDL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A817B0", Offset = "0x7A80BB0", VA = "0x187A817B0")]
	public IAALJBIHJIE(UniformTRS HHOJIIIEHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A81220", Offset = "0x7A80620", VA = "0x187A81220")]
	public static IAALJBIHJIE HAICFIDJKEA(IAALJBIHJIE GEFLCBDBKHP, IAALJBIHJIE HDBDONJDNAN)
	{
		return default(IAALJBIHJIE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A814A0", Offset = "0x7A808A0", VA = "0x187A814A0")]
	public static IAALJBIHJIE HIHFKEJHDAH((Vector3, Quaternion, float) AOFGGGKINCN)
	{
		return default(IAALJBIHJIE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A814C0", Offset = "0x7A808C0", VA = "0x187A814C0")]
	public static IAALJBIHJIE HIHFKEJHDAH(Matrix4x4 MOINPLIODJK)
	{
		return default(IAALJBIHJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A81720", Offset = "0x7A80B20", VA = "0x187A81720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A81640", Offset = "0x7A80A40", VA = "0x187A81640")]
	public IAALJBIHJIE MDICAIKNJKM(Matrix4x4 NIBJBBEPHBE)
	{
		return default(IAALJBIHJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A81170", Offset = "0x7A80570", VA = "0x187A81170")]
	public static IAALJBIHJIE EAMLDLIDICO(Vector3 KBPOHLLNAIG)
	{
		return default(IAALJBIHJIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A810E0", Offset = "0x7A804E0", VA = "0x187A810E0")]
	public readonly OJNENIBHGBE DMILELAEKCO()
	{
		return default(OJNENIBHGBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BBDBLIHEEOB
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct HCBFFNMPIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly ACPGHHADPMN JNHEJAAFHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HAPFLJDLPEC EPHNGDNPGLA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x15CFB00", Offset = "0x15CEF00", VA = "0x1815CFB00")]
	private HCBFFNMPIDH(ACPGHHADPMN JCPHFIALCGL, HAPFLJDLPEC NNKKCNKKLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7AE00", Offset = "0x7A7A200", VA = "0x187A7AE00")]
	public DJJEDLFAHGN DOGHPCECBPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A7AF30", Offset = "0x7A7A330", VA = "0x187A7AF30")]
	public static BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH> FABCCGGAHMJ(AELKLDIEDNK<FGGPIMEAIEJ> NNKKCNKKLNJ)
	{
		return default(BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A7AFE0", Offset = "0x7A7A3E0", VA = "0x187A7AFE0")]
	public static BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH> FABCCGGAHMJ(DJJEDLFAHGN NNKKCNKKLNJ)
	{
		return default(BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A7AE70", Offset = "0x7A7A270", VA = "0x187A7AE70")]
	public static BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH> FABCCGGAHMJ(string FILOIGKEBLD)
	{
		return default(BECHBBIPIFM<HEFOBCPMPPP, HCBFFNMPIDH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ACPGHHADPMN
{
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HCFEBNKLECI : IDisposable, OMOHOGJENME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private NativeList<KOLCMGJNCCI> IPCOLDHFCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private float MPMPFBJBJIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IOEIEABAMHG LKGEKDHOGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(IOEIEABAMHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CAOJPBOOEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69C5AC0", Offset = "0x69C4EC0", VA = "0x1869C5AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BABKJIOPMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69C5AD0", Offset = "0x69C4ED0", VA = "0x1869C5AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<HDBMCKKDCJO> GEOPDPBEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NDCFNEPGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7A7D7F0", Offset = "0x7A7CBF0", VA = "0x187A7D7F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float CINPFAHMOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7A7B850", Offset = "0x7A7AC50", VA = "0x187A7B850")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D890", Offset = "0x7A7CC90", VA = "0x187A7D890")]
	public HCFEBNKLECI(IOEIEABAMHG PNEABCGFGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B990", Offset = "0x7A7AD90", VA = "0x187A7B990", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B310", Offset = "0x7A7A710", VA = "0x187A7B310")]
	public Vector3 BFNKPIENDPM(int MLHFFBNEEHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B090", Offset = "0x7A7A490", VA = "0x187A7B090", Slot = "6")]
	public Quaternion AMOPPDJKJDE(int MLHFFBNEEHM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C040", Offset = "0x7A7B440", VA = "0x187A7C040", Slot = "5")]
	public Vector3 GMBOEEKPKGA(int MLHFFBNEEHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D830", Offset = "0x7A7CC30", VA = "0x187A7D830", Slot = "7")]
	public float PMCDBJDBBKL(int MLHFFBNEEHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7A7CD90", Offset = "0x7A7C190", VA = "0x187A7CD90")]
	public void PACENIHBCBP(Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float PPFBOIIFNHM, bool LLHHFMCELFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A7CD30", Offset = "0x7A7C130", VA = "0x187A7CD30")]
	private bool ODAKALMCNED(int HILPKIODFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A7CA50", Offset = "0x7A7BE50", VA = "0x187A7CA50")]
	public void KEGBLJGAEJP(Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C8F0", Offset = "0x7A7BCF0", VA = "0x187A7C8F0")]
	public void IHFEKAPJPMI(int HILPKIODFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B1C0", Offset = "0x7A7A5C0", VA = "0x187A7B1C0")]
	public void BAKDPJAOCAI(int HILPKIODFCA, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A7BE90", Offset = "0x7A7B290", VA = "0x187A7BE90")]
	public void EPBHCJMMMBM(int HILPKIODFCA, float3 KBPOHLLNAIG, quaternion PNEDBEMJDJJ, float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D6A0", Offset = "0x7A7CAA0", VA = "0x187A7D6A0")]
	public void PCLAFLPIAFP(int HILPKIODFCA, Vector3 KBPOHLLNAIG, float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A7CBD0", Offset = "0x7A7BFD0", VA = "0x187A7CBD0")]
	public void KFJFANEBNBH(int HILPKIODFCA, Vector3 KBGACFDBMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C0E0", Offset = "0x7A7B4E0", VA = "0x187A7C0E0")]
	public static Quaternion HBEABNAJMNG(Quaternion PNMIEECLPJC, int HILPKIODFCA, float FEOIKMOIJFN, OMOHOGJENME KBCIEKPLCPA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B9F0", Offset = "0x7A7ADF0", VA = "0x187A7B9F0")]
	public Bounds EKEEILNPIBN(Transform NIBJBBEPHBE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B7E0", Offset = "0x7A7ABE0", VA = "0x187A7B7E0", Slot = "10")]
	public virtual void BPEBJEBFGAC(bool GINBIHCFCMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C980", Offset = "0x7A7BD80", VA = "0x187A7C980")]
	public NativeList<KOLCMGJNCCI> ILAMCHLGOLF(float ADHEJCBIEEA = 1f)
	{
		return default(NativeList<KOLCMGJNCCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDBMCKKDCJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public float3 KHAINEMBOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public float HBPCAGLAIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public quaternion EKPEHDDNKCA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DE70", Offset = "0x7A7D270", VA = "0x187A7DE70")]
	public HDBMCKKDCJO(Vector3 EIODCDKJBOE, Quaternion PNMIEECLPJC, float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D920", Offset = "0x7A7CD20", VA = "0x187A7D920")]
	public Quaternion BMOECODPENF(Vector3 DJMLEJBBDGG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D9E0", Offset = "0x7A7CDE0", VA = "0x187A7D9E0")]
	public HDBMCKKDCJO IAJDIIJKDDE(Vector3 DANFJBHJNIJ, Vector3 GGILOIIOPPF, Vector3 OMCADDNHNLA)
	{
		return default(HDBMCKKDCJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DCD0", Offset = "0x7A7D0D0", VA = "0x187A7DCD0")]
	public PFLOJOPHNIH LCCEHBBDLCJ(Vector3 DJMLEJBBDGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KNJEGKDEDAP : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7A83580", Offset = "0x7A82980", VA = "0x187A83580", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7A82D20", Offset = "0x7A82120", VA = "0x187A82D20")]
	private void JMDMCFEIGBG(Dictionary<Guid, Guid> BNJEGKECFPD, JEPNDOOJEPJ KGDKOECBLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7A82CC0", Offset = "0x7A820C0", VA = "0x187A82CC0")]
	private void JMDMCFEIGBG(Dictionary<Guid, Guid> BNJEGKECFPD, IEIODFPODOO MMKFODAJKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7A83300", Offset = "0x7A82700", VA = "0x187A83300")]
	private void JMDMCFEIGBG(Dictionary<Guid, Guid> BNJEGKECFPD, DPJHMGCPFGB LDOGJGOGCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KNJEGKDEDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class KFDBCPABMAC : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A829F0", Offset = "0x7A81DF0", VA = "0x187A829F0", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KFDBCPABMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class IKMCOOOGCBB : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A81D20", Offset = "0x7A81120", VA = "0x187A81D20", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public IKMCOOOGCBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DEACIJFGCMK : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A78680", Offset = "0x7A77A80", VA = "0x187A78680", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public DEACIJFGCMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KMBDCCMPFIA : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A82AA0", Offset = "0x7A81EA0", VA = "0x187A82AA0", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KMBDCCMPFIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MDBEBPIJFPI : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A83600", Offset = "0x7A82A00", VA = "0x187A83600", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MDBEBPIJFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FMPGCEPEOHD : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A79B00", Offset = "0x7A78F00", VA = "0x187A79B00", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FMPGCEPEOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ICOKJKNLONM : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7A81880", Offset = "0x7A80C80", VA = "0x187A81880", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public ICOKJKNLONM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NIKNAEDPMPO : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7A83BC0", Offset = "0x7A82FC0", VA = "0x187A83BC0", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NIKNAEDPMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CKLFEJACPMK : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7A784C0", Offset = "0x7A778C0", VA = "0x187A784C0", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CKLFEJACPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MNCNNHOFDCC : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7A83AC0", Offset = "0x7A82EC0", VA = "0x187A83AC0", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MNCNNHOFDCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ENEEMGAJFDB : EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public static readonly KDEMNDKMEAF DIFKJFDABFD;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7A787E0", Offset = "0x7A77BE0", VA = "0x187A787E0", Slot = "4")]
	public void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public ENEEMGAJFDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct DFOHPJLFMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public KFOIBDNOLMJ IPCFHGIMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public LBFFJBPBGDL MKNFHNOLNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public Dictionary<int, int> JHCBIIJIMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public Dictionary<Guid, Guid> DCEGCOCGOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public JPHDAIAGEAJ GIFBKKIKKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public bool JPOBLHNDMNE;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EEAMCGOPJOG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPEBHPLAHKN(BOMIBFGPAGC EMDCLJFIBCO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GAKKCGMPCDK
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private static readonly EEAMCGOPJOG[] NCLFJOKPNHI;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A2F0", Offset = "0x7A796F0", VA = "0x187A7A2F0")]
	public static void JDLKBKCGJJG(IBDHKNDIHNK AOFGGGKINCN, HEFOBCPMPPP HAKFIGBPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A570", Offset = "0x7A79970", VA = "0x187A7A570")]
	public static void LDGHBDKLCNC(IBDHKNDIHNK? AOFGGGKINCN, HEFOBCPMPPP BEGJFAIHBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A070", Offset = "0x7A79470", VA = "0x187A7A070")]
	public static void IGEAIPDKIFN(IBDHKNDIHNK? AOFGGGKINCN, HEFOBCPMPPP HDEMFLLKJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A79CA0", Offset = "0x7A790A0", VA = "0x187A79CA0")]
	public static void ALCPLDIABHD(BOMIBFGPAGC EMDCLJFIBCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BOMIBFGPAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public KFOIBDNOLMJ HCNMCCFECNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public IBDHKNDIHNK GEBIOONDCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public Dictionary<int, int> JHCBIIJIMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public Dictionary<Guid, Guid> DCEGCOCGOHM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A78410", Offset = "0x7A77810", VA = "0x187A78410")]
	public Guid CCOKLIFIJOB(Guid FIAGFFPOAHP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JPHDAIAGEAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MBKPHHENGGF, [Out] Guid HMAJHNBMGKK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class HHOCCKCNFKN
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private static readonly ProfilerMarker FEFJIEDONNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly HashSet<string> JHLJEDELNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly Dictionary<long, int> GAPFAPJEJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly HashSet<Guid> EEBJLLGFHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly HashSet<Guid> HIJDDAFCGBD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> JKFINMECPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> BFMKHIGNNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> GDAFPMGIEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F590", Offset = "0x7A7E990", VA = "0x187A7F590")]
	public static void HKPEMDJNDKI(AEHFCHJCBKK EOOFKFAEGAF, IOPIMMFHANC PDIABGAHOAC, HEFOBCPMPPP CIGHOFPBIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EF00", Offset = "0x7A7E300", VA = "0x187A7EF00")]
	public static HHOCCKCNFKN FIGJKEKKOIK(MMIOGOBDHFC NILNGFKCINL, [Optional] IOPIMMFHANC? PDIABGAHOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7ECA0", Offset = "0x7A7E0A0", VA = "0x187A7ECA0")]
	public static HHOCCKCNFKN CPAECEKLCNP(AEHFCHJCBKK DMJEHCFLBMH, [Optional] IOPIMMFHANC? PDIABGAHOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A809E0", Offset = "0x7A7FDE0", VA = "0x187A809E0")]
	public static HHOCCKCNFKN OKKJHNMOLMC(IEnumerable<string> JHLJEDELNJL, IDictionary<long, int> FJMDHJDPDGG, IReadOnlyCollection<Guid> HIJDDAFCGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7A80E70", Offset = "0x7A80270", VA = "0x187A80E70")]
	private HHOCCKCNFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A80CA0", Offset = "0x7A800A0", VA = "0x187A80CA0")]
	private HHOCCKCNFKN(IEnumerable<string> JHLJEDELNJL, IDictionary<long, int> FJMDHJDPDGG, IReadOnlyCollection<Guid> HIJDDAFCGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EA80", Offset = "0x7A7DE80", VA = "0x187A7EA80")]
	private void CEMOFACNFIM(MMIOGOBDHFC NILNGFKCINL, IOPIMMFHANC? PDIABGAHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E500", Offset = "0x7A7D900", VA = "0x187A7E500")]
	private void CEMOFACNFIM(AEHFCHJCBKK DMJEHCFLBMH, IOPIMMFHANC? PDIABGAHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A80530", Offset = "0x7A7F930", VA = "0x187A80530")]
	private void MNAGDIHBFHC(ByteString? LDCKALLGLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E720", Offset = "0x7A7DB20", VA = "0x187A7E720")]
	private void CEMOFACNFIM(GBPDGMFBFGP? DGFFJNKGDJD, IOPIMMFHANC? PDIABGAHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EF80", Offset = "0x7A7E380", VA = "0x187A7EF80")]
	private static void HKPEMDJNDKI(GBPDGMFBFGP? DGFFJNKGDJD, IOPIMMFHANC PDIABGAHOAC, HEFOBCPMPPP CIGHOFPBIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A7F320", Offset = "0x7A7E720", VA = "0x187A7F320")]
	private static void HKPEMDJNDKI(DHJMMNEBKJD? HAIECNDMOKO, IOPIMMFHANC PDIABGAHOAC, HEFOBCPMPPP CIGHOFPBIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DEF0", Offset = "0x7A7D2F0", VA = "0x187A7DEF0")]
	private void CEMOFACNFIM(DHJMMNEBKJD? HAIECNDMOKO, IOPIMMFHANC? PDIABGAHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A7ED20", Offset = "0x7A7E120", VA = "0x187A7ED20")]
	private void FEJCNOIOEDO(Guid? FIAGFFPOAHP, IOPIMMFHANC? PDIABGAHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E100", Offset = "0x7A7D500", VA = "0x187A7E100")]
	private void CEMOFACNFIM(IBDHKNDIHNK? GEBIOONDCDF, IOPIMMFHANC? PDIABGAHOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A7FEF0", Offset = "0x7A7F2F0", VA = "0x187A7FEF0")]
	private static void HKPEMDJNDKI(IBDHKNDIHNK? GEBIOONDCDF, IOPIMMFHANC PDIABGAHOAC, HEFOBCPMPPP CIGHOFPBIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A804C0", Offset = "0x7A7F8C0", VA = "0x187A804C0")]
	private void LFJDJCPDKDL(string? NMOKLMMBBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A803F0", Offset = "0x7A7F7F0", VA = "0x187A803F0")]
	private void JCLJEABKDEB(long CAGIOACBMFJ, Guid PLNOLCNPCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A803A0", Offset = "0x7A7F7A0", VA = "0x187A803A0")]
	private void JCLJEABKDEB(MBGFKAFPNJB? KAKBKEIBNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A80340", Offset = "0x7A7F740", VA = "0x187A80340")]
	private void JCLJEABKDEB(KAMBGGLBAIB? KAKBKEIBNJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FIEAIONIKGL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class IHEIHMCLCFO : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private readonly IEnumerator<DictionaryEntry> KJLPEEACILI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry HOJNDCFLEDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7A81AF0", Offset = "0x7A80EF0", VA = "0x187A81AF0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7A81BC0", Offset = "0x7A80FC0", VA = "0x187A81BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7A81C70", Offset = "0x7A81070", VA = "0x187A81C70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A10", Offset = "0x7A80E10", VA = "0x187A81A10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
		public IHEIHMCLCFO(IEnumerator<DictionaryEntry> KJLPEEACILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A81970", Offset = "0x7A80D70", VA = "0x187A81970", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A819C0", Offset = "0x7A80DC0", VA = "0x187A819C0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class MEPNLMEAIGC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0xBD93B0", Offset = "0xBD87B0", VA = "0x180BD93B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x7A83A70", Offset = "0x7A82E70", VA = "0x187A83A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
			[DebuggerHidden]
			public MEPNLMEAIGC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7A83920", Offset = "0x7A82D20", VA = "0x187A83920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7A83A20", Offset = "0x7A82E20", VA = "0x187A83A20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7A84620", Offset = "0x7A83A20", VA = "0x187A84620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object IICGAABOENK]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7A84530", Offset = "0x7A83930", VA = "0x187A84530", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7A84710", Offset = "0x7A83B10", VA = "0x187A84710", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7A84470", Offset = "0x7A83870", VA = "0x187A84470", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7A844D0", Offset = "0x7A838D0", VA = "0x187A844D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7A846B0", Offset = "0x7A83AB0", VA = "0x187A846B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7A84130", Offset = "0x7A83530", VA = "0x187A84130", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7A84190", Offset = "0x7A83590", VA = "0x187A84190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7A841F0", Offset = "0x7A835F0", VA = "0x187A841F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
		public RoomObjectCounts(Dictionary<int, int> CBDAELMAIDP, [Optional] Dictionary<int, int> FBKFLGOELHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A84050", Offset = "0x7A83450", VA = "0x187A84050")]
		[IteratorStateMachine(typeof(MEPNLMEAIGC))]
		private IEnumerator<DictionaryEntry> JODNKINDKKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A84760", Offset = "0x7A83B60", VA = "0x187A84760", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A84370", Offset = "0x7A83770", VA = "0x187A84370", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A84250", Offset = "0x7A83650", VA = "0x187A84250", Slot = "9")]
		void IDictionary.Add(object IICGAABOENK, object OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A842B0", Offset = "0x7A836B0", VA = "0x187A842B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A84310", Offset = "0x7A83710", VA = "0x187A84310", Slot = "8")]
		bool IDictionary.Contains(object IICGAABOENK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A84410", Offset = "0x7A83810", VA = "0x187A84410", Slot = "14")]
		void IDictionary.Remove(object IICGAABOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A840D0", Offset = "0x7A834D0", VA = "0x187A840D0", Slot = "15")]
		void ICollection.CopyTo(Array IMLJIFPAFGH, int COPLIEINKOF)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MDPNNLOKOAC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xBD93B0", Offset = "0xBD87B0", VA = "0x180BD93B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x7A838D0", Offset = "0x7A82CD0", VA = "0x187A838D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
			[DebuggerHidden]
			public MDPNNLOKOAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7A83740", Offset = "0x7A82B40", VA = "0x187A83740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7A83880", Offset = "0x7A82C80", VA = "0x187A83880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7A82700", Offset = "0x7A81B00", VA = "0x187A82700", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object IICGAABOENK]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7A825D0", Offset = "0x7A819D0", VA = "0x187A825D0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7A827B0", Offset = "0x7A81BB0", VA = "0x187A827B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A82510", Offset = "0x7A81910", VA = "0x187A82510", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7A82570", Offset = "0x7A81970", VA = "0x187A82570", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7A82750", Offset = "0x7A81B50", VA = "0x187A82750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7A82190", Offset = "0x7A81590", VA = "0x187A82190", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7A821F0", Offset = "0x7A815F0", VA = "0x187A821F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7A82250", Offset = "0x7A81650", VA = "0x187A82250", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x26ED2A0", Offset = "0x26EC6A0", VA = "0x1826ED2A0")]
		public Invention(long FBLIJIPJKFJ, int PCGLBCNIEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7A820C0", Offset = "0x7A814C0", VA = "0x187A820C0")]
		[IteratorStateMachine(typeof(MDPNNLOKOAC))]
		private IEnumerator<DictionaryEntry> JODNKINDKKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A82800", Offset = "0x7A81C00", VA = "0x187A82800", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7A823D0", Offset = "0x7A817D0", VA = "0x187A823D0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A822B0", Offset = "0x7A816B0", VA = "0x187A822B0", Slot = "9")]
		void IDictionary.Add(object IICGAABOENK, object OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A82310", Offset = "0x7A81710", VA = "0x187A82310", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A82370", Offset = "0x7A81770", VA = "0x187A82370", Slot = "8")]
		bool IDictionary.Contains(object IICGAABOENK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A824B0", Offset = "0x7A818B0", VA = "0x187A824B0", Slot = "14")]
		void IDictionary.Remove(object IICGAABOENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A82130", Offset = "0x7A81530", VA = "0x187A82130", Slot = "15")]
		void ICollection.CopyTo(Array IMLJIFPAFGH, int COPLIEINKOF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> GIJKJKGGPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public readonly IReadOnlyList<Invention> OLMECGMIIPL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
	public FIEAIONIKGL(IReadOnlyDictionary<Guid, RoomObjectCounts> FMGGNNKHGFJ, IReadOnlyList<Invention> OCBMGJHDMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A78910", Offset = "0x7A77D10", VA = "0x187A78910")]
	public static FIEAIONIKGL FIGJKEKKOIK(MMIOGOBDHFC NILNGFKCINL)
	{
		return default(FIEAIONIKGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7A79320", Offset = "0x7A78720", VA = "0x187A79320")]
	[CompilerGenerated]
	internal static int HOHNIOJOHEE([In] IReadOnlyDictionary<long, int> MAOAJDFOBOO, long? CAGIOACBMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7A79440", Offset = "0x7A78840", VA = "0x187A79440")]
	[CompilerGenerated]
	internal static void OPEHEIKAEMH(int GKLDLKKJFEL, [In] GBPDGMFBFGP MDEFFKAKADO, [In] Dictionary<long, int> MAOAJDFOBOO, [In] Dictionary<Guid, RoomObjectCounts> FMGGNNKHGFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class IOPIMMFHANC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private readonly HEFOBCPMPPP NKHAPLKNDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> ACALKKBFDPC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public HEFOBCPMPPP BIJEJLNGBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7A81E80", Offset = "0x7A81280", VA = "0x187A81E80")]
	public void FGAAHPGCDNG(Guid FCJHCHJJCCK, Guid CCCIHLDGAMH, IReadOnlyList<Guid> PHCGBBOCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7A81F30", Offset = "0x7A81330", VA = "0x187A81F30")]
	public bool JCNNMOLMPKO(Guid MICNPDMHPCO, [Out] IReadOnlyList<Guid> HIJDDAFCGBD, [Out] bool BIICJAPBLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7A82020", Offset = "0x7A81420", VA = "0x187A82020")]
	public IOPIMMFHANC()
	{
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
